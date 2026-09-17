// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 19299
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 19300
{
	// Methods

	// RVA: 0x7C5EB8C Offset: 0x7C5AB8C VA: 0x7C5EB8C
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 19301
{
	// Methods

	// RVA: 0x7C5EB94 Offset: 0x7C5AB94 VA: 0x7C5EB94
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 19302
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x7C5EB9C Offset: 0x7C5AB9C VA: 0x7C5EB9C
	public void .ctor(byte ) { }

	// RVA: 0x7C5EC24 Offset: 0x7C5AC24 VA: 0x7C5EC24
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 19303
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x7C5EC54 Offset: 0x7C5AC54 VA: 0x7C5EC54
	public void .ctor(byte ) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(10688, AllowMultiple = True)]
internal sealed class NotNullAttribute : Attribute // TypeDefIndex: 19304
{
	// Methods

	// RVA: 0x7C5EC7C Offset: 0x7C5AC7C VA: 0x7C5EC7C
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, AllowMultiple = False)]
internal sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 19305
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7C5EC84 Offset: 0x7C5AC84 VA: 0x7C5EC84
	public void .ctor(bool returnValue) { }
}

// Namespace: Newtonsoft.Json
public enum ConstructorHandling // TypeDefIndex: 19306
{
	// Fields
	public int value__; // 0x0
	public const ConstructorHandling Default = 0;
	public const ConstructorHandling AllowNonPublicDefaultConstructor = 1;
}

// Namespace: Newtonsoft.Json
public enum DateFormatHandling // TypeDefIndex: 19307
{
	// Fields
	public int value__; // 0x0
	public const DateFormatHandling IsoDateFormat = 0;
	public const DateFormatHandling MicrosoftDateFormat = 1;
}

// Namespace: Newtonsoft.Json
public enum DateParseHandling // TypeDefIndex: 19308
{
	// Fields
	public int value__; // 0x0
	public const DateParseHandling None = 0;
	public const DateParseHandling DateTime = 1;
	public const DateParseHandling DateTimeOffset = 2;
}

// Namespace: Newtonsoft.Json
public enum DateTimeZoneHandling // TypeDefIndex: 19309
{
	// Fields
	public int value__; // 0x0
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;
}

// Namespace: 
[Nullable(0)]
private class DefaultJsonNameTable.Entry // TypeDefIndex: 19310
{
	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal DefaultJsonNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0x7C5F28C Offset: 0x7C5B28C VA: 0x7C5F28C
	internal void .ctor(string value, int hashCode, DefaultJsonNameTable.Entry next) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 19311
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private DefaultJsonNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x7C5ECAC Offset: 0x7C5ACAC VA: 0x7C5ECAC
	private static void .cctor() { }

	// RVA: 0x7C5ECFC Offset: 0x7C5ACFC VA: 0x7C5ECFC
	public void .ctor() { }

	// RVA: 0x7C5ED74 Offset: 0x7C5AD74 VA: 0x7C5ED74 Slot: 4
	public override string Get(char[] key, int start, int length) { }

	// RVA: 0x7C5EFC4 Offset: 0x7C5AFC4 VA: 0x7C5EFC4
	public string Add(string key) { }

	// RVA: 0x7C5F178 Offset: 0x7C5B178 VA: 0x7C5F178
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x7C5F2E0 Offset: 0x7C5B2E0 VA: 0x7C5F2E0
	private void Grow() { }

	// RVA: 0x7C5EF08 Offset: 0x7C5AF08 VA: 0x7C5EF08
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: Newtonsoft.Json
[Flags]
public enum DefaultValueHandling // TypeDefIndex: 19312
{
	// Fields
	public int value__; // 0x0
	public const DefaultValueHandling Include = 0;
	public const DefaultValueHandling Ignore = 1;
	public const DefaultValueHandling Populate = 2;
	public const DefaultValueHandling IgnoreAndPopulate = 3;
}

// Namespace: Newtonsoft.Json
public enum FloatFormatHandling // TypeDefIndex: 19313
{
	// Fields
	public int value__; // 0x0
	public const FloatFormatHandling String = 0;
	public const FloatFormatHandling Symbol = 1;
	public const FloatFormatHandling DefaultValue = 2;
}

// Namespace: Newtonsoft.Json
public enum FloatParseHandling // TypeDefIndex: 19314
{
	// Fields
	public int value__; // 0x0
	public const FloatParseHandling Double = 0;
	public const FloatParseHandling Decimal = 1;
}

// Namespace: Newtonsoft.Json
public enum Formatting // TypeDefIndex: 19315
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
public interface IArrayPool<T> // TypeDefIndex: 19316
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: Newtonsoft.Json
public interface IJsonLineInfo // TypeDefIndex: 19317
{
	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();
}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 19318
{}

// Namespace: Newtonsoft.Json
[Usage(32, AllowMultiple = False)]
public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 19319
{}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
[NullableContext(2)]
[Nullable(0)]
public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 19320
{
	// Fields
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x10
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x20
	internal Nullable<bool> _isReference; // 0x28
	internal Nullable<bool> _itemIsReference; // 0x2A
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x2C
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x34
	private Type _namingStrategyType; // 0x40
	[Nullable(new[] { 2, 1 })]
	private object[] _namingStrategyParameters; // 0x48

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	internal NamingStrategy NamingStrategyInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C5F438 Offset: 0x7C5B438 VA: 0x7C5F438
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x7C5F440 Offset: 0x7C5B440 VA: 0x7C5F440
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x7C5F448 Offset: 0x7C5B448 VA: 0x7C5F448
	public Type get_NamingStrategyType() { }

	// RVA: 0x7C5F450 Offset: 0x7C5B450 VA: 0x7C5F450
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x7C5F458 Offset: 0x7C5B458 VA: 0x7C5F458
	internal NamingStrategy get_NamingStrategyInstance() { }

	[CompilerGenerated]
	// RVA: 0x7C5F460 Offset: 0x7C5B460 VA: 0x7C5F460
	internal void set_NamingStrategyInstance(NamingStrategy value) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert // TypeDefIndex: 19321
{
	// Fields
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Properties
	[Nullable(new[] { 2, 1 })]
	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C5F468 Offset: 0x7C5B468 VA: 0x7C5F468
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGenerated]
	// RVA: 0x7C5F4C0 Offset: 0x7C5B4C0 VA: 0x7C5F4C0
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0x7C5F528 Offset: 0x7C5B528 VA: 0x7C5F528
	public static string ToString(DateTime value) { }

	// RVA: 0x7C5F584 Offset: 0x7C5B584 VA: 0x7C5F584
	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	// RVA: 0x7C5F7F0 Offset: 0x7C5B7F0 VA: 0x7C5F7F0
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x7C5F858 Offset: 0x7C5B858 VA: 0x7C5F858
	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	// RVA: 0x7C5FAA4 Offset: 0x7C5BAA4 VA: 0x7C5FAA4
	public static string ToString(bool value) { }

	// RVA: 0x7C5FB10 Offset: 0x7C5BB10 VA: 0x7C5FB10
	public static string ToString(char value) { }

	// RVA: 0x7C5FBF4 Offset: 0x7C5BBF4 VA: 0x7C5FBF4
	public static string ToString(Enum value) { }

	// RVA: 0x7C5FC48 Offset: 0x7C5BC48 VA: 0x7C5FC48
	public static string ToString(int value) { }

	// RVA: 0x7C5FCB4 Offset: 0x7C5BCB4 VA: 0x7C5FCB4
	public static string ToString(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C5FD20 Offset: 0x7C5BD20 VA: 0x7C5FD20
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C5FD8C Offset: 0x7C5BD8C VA: 0x7C5FD8C
	public static string ToString(uint value) { }

	// RVA: 0x7C5FDF8 Offset: 0x7C5BDF8 VA: 0x7C5FDF8
	public static string ToString(long value) { }

	// RVA: 0x7C5FE64 Offset: 0x7C5BE64 VA: 0x7C5FE64
	private static string ToStringInternal(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C5FF04 Offset: 0x7C5BF04 VA: 0x7C5FF04
	public static string ToString(ulong value) { }

	// RVA: 0x7C5FF70 Offset: 0x7C5BF70 VA: 0x7C5FF70
	public static string ToString(float value) { }

	// RVA: 0x7C60100 Offset: 0x7C5C100 VA: 0x7C60100
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x7C601F0 Offset: 0x7C5C1F0 VA: 0x7C601F0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x7C60314 Offset: 0x7C5C314 VA: 0x7C60314
	public static string ToString(double value) { }

	// RVA: 0x7C603DC Offset: 0x7C5C3DC VA: 0x7C603DC
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x7C6003C Offset: 0x7C5C03C VA: 0x7C6003C
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0x7C604C8 Offset: 0x7C5C4C8 VA: 0x7C604C8
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0x7C6053C Offset: 0x7C5C53C VA: 0x7C6053C
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C605A8 Offset: 0x7C5C5A8 VA: 0x7C605A8
	public static string ToString(sbyte value) { }

	// RVA: 0x7C60614 Offset: 0x7C5C614 VA: 0x7C60614
	public static string ToString(Decimal value) { }

	// RVA: 0x7C60708 Offset: 0x7C5C708 VA: 0x7C60708
	public static string ToString(Guid value) { }

	// RVA: 0x7C60770 Offset: 0x7C5C770 VA: 0x7C60770
	internal static string ToString(Guid value, char quoteChar) { }

	// RVA: 0x7C60854 Offset: 0x7C5C854 VA: 0x7C60854
	public static string ToString(TimeSpan value) { }

	// RVA: 0x7C608AC Offset: 0x7C5C8AC VA: 0x7C608AC
	internal static string ToString(TimeSpan value, char quoteChar) { }

	// RVA: 0x7C609B4 Offset: 0x7C5C9B4 VA: 0x7C609B4
	public static string ToString(Uri value) { }

	// RVA: 0x7C60A68 Offset: 0x7C5CA68 VA: 0x7C60A68
	internal static string ToString(Uri value, char quoteChar) { }

	// RVA: 0x7C5FB9C Offset: 0x7C5BB9C VA: 0x7C5FB9C
	public static string ToString(string value) { }

	// RVA: 0x7C6094C Offset: 0x7C5C94C VA: 0x7C6094C
	public static string ToString(string value, char delimiter) { }

	// RVA: 0x7C60AE0 Offset: 0x7C5CAE0 VA: 0x7C60AE0
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x7C60BC4 Offset: 0x7C5CBC4 VA: 0x7C60BC4
	public static string ToString(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x7C6145C Offset: 0x7C5D45C VA: 0x7C6145C
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x7C61534 Offset: 0x7C5D534 VA: 0x7C61534
	public static string SerializeObject(object value, Formatting formatting) { }

	[DebuggerStepThrough]
	// RVA: 0x7C6160C Offset: 0x7C5D60C VA: 0x7C6160C
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	// RVA: 0x7C61744 Offset: 0x7C5D744 VA: 0x7C61744
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x7C6189C Offset: 0x7C5D89C VA: 0x7C6189C
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x7C614B8 Offset: 0x7C5D4B8 VA: 0x7C614B8
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x7C6159C Offset: 0x7C5D59C VA: 0x7C6159C
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x7C61804 Offset: 0x7C5D804 VA: 0x7C61804
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0x7C61938 Offset: 0x7C5D938 VA: 0x7C61938
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[DebuggerStepThrough]
	// RVA: 0x7C61BE0 Offset: 0x7C5DBE0 VA: 0x7C61BE0
	public static object DeserializeObject(string value) { }

	[DebuggerStepThrough]
	// RVA: 0x7C61E98 Offset: 0x7C5DE98 VA: 0x7C61E98
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x7C61F00 Offset: 0x7C5DF00 VA: 0x7C61F00
	public static object DeserializeObject(string value, Type type) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46470B0 Offset: 0x46430B0 VA: 0x46470B0
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x4647118 Offset: 0x4643118 VA: 0x4647118
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x4647208 Offset: 0x4643208 VA: 0x4647208
	|-JsonConvert.DeserializeObject<MailInfoViewModule.GuildBossMvpMailData>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646EC8 Offset: 0x4642EC8 VA: 0x4646EC8
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646FB4 Offset: 0x4642FB4 VA: 0x4646FB4
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonConverter[] converters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4647390 Offset: 0x4643390 VA: 0x4647390
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4647294 Offset: 0x4643294 VA: 0x4647294
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x46474DC Offset: 0x46434DC VA: 0x46474DC
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x4647628 Offset: 0x4643628 VA: 0x4647628
	|-JsonConvert.DeserializeObject<MailInfoViewModule.GuildBossMvpMailData>
	*/

	[DebuggerStepThrough]
	// RVA: 0x7C61F68 Offset: 0x7C5DF68 VA: 0x7C61F68
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x7C61C3C Offset: 0x7C5DC3C VA: 0x7C61C3C
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x7C62188 Offset: 0x7C5E188 VA: 0x7C62188
	public static void PopulateObject(string value, object target) { }

	// RVA: 0x7C621F0 Offset: 0x7C5E1F0 VA: 0x7C621F0
	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	// RVA: 0x7C624E4 Offset: 0x7C5E4E4 VA: 0x7C624E4
	public static string SerializeXmlNode(XmlNode node) { }

	// RVA: 0x7C6253C Offset: 0x7C5E53C VA: 0x7C6253C
	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	// RVA: 0x7C62638 Offset: 0x7C5E638 VA: 0x7C62638
	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x7C62740 Offset: 0x7C5E740 VA: 0x7C62740
	public static XmlDocument DeserializeXmlNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x7C62798 Offset: 0x7C5E798 VA: 0x7C62798
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x7C62800 Offset: 0x7C5E800 VA: 0x7C62800
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x7C62870 Offset: 0x7C5E870 VA: 0x7C62870
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x7C62A44 Offset: 0x7C5EA44 VA: 0x7C62A44
	public static string SerializeXNode(XObject node) { }

	// RVA: 0x7C62A9C Offset: 0x7C5EA9C VA: 0x7C62A9C
	public static string SerializeXNode(XObject node, Formatting formatting) { }

	// RVA: 0x7C62B04 Offset: 0x7C5EB04 VA: 0x7C62B04
	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x7C62C0C Offset: 0x7C5EC0C VA: 0x7C62C0C
	public static XDocument DeserializeXNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x7C62C64 Offset: 0x7C5EC64 VA: 0x7C62C64
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x7C62CCC Offset: 0x7C5ECCC VA: 0x7C62CCC
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x7C62D3C Offset: 0x7C5ED3C VA: 0x7C62D3C
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x7C62F10 Offset: 0x7C5EF10 VA: 0x7C62F10
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public abstract class JsonConverter // TypeDefIndex: 19322
{
	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x7C63078 Offset: 0x7C5F078 VA: 0x7C63078 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x7C63080 Offset: 0x7C5F080 VA: 0x7C63080 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x7C63088 Offset: 0x7C5F088 VA: 0x7C63088
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(3484, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 19323
{
	// Fields
	private readonly Type _converterType; // 0x10
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x7C63090 Offset: 0x7C5F090 VA: 0x7C63090
	public Type get_ConverterType() { }

	[CompilerGenerated]
	// RVA: 0x7C63098 Offset: 0x7C5F098 VA: 0x7C63098
	public object[] get_ConverterParameters() { }
}

// Namespace: Newtonsoft.Json
[Nullable(new[] { 0, 1 })]
public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 19324
{
	// Methods

	// RVA: 0x7C630A0 Offset: 0x7C5F0A0 VA: 0x7C630A0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonDictionaryAttribute : JsonContainerAttribute // TypeDefIndex: 19325
{}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class JsonException : Exception // TypeDefIndex: 19326
{
	// Methods

	// RVA: 0x7C630E8 Offset: 0x7C5F0E8 VA: 0x7C630E8
	public void .ctor() { }

	// RVA: 0x7C63140 Offset: 0x7C5F140 VA: 0x7C63140
	public void .ctor(string message) { }

	// RVA: 0x7C631A8 Offset: 0x7C5F1A8 VA: 0x7C631A8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x7C63218 Offset: 0x7C5F218 VA: 0x7C63218
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 19327
{
	// Fields
	[CompilerGenerated]
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ReadData>k__BackingField; // 0x11

	// Properties
	public bool WriteData { get; }
	public bool ReadData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C63298 Offset: 0x7C5F298 VA: 0x7C63298
	public bool get_WriteData() { }

	[CompilerGenerated]
	// RVA: 0x7C632A0 Offset: 0x7C5F2A0 VA: 0x7C632A0
	public bool get_ReadData() { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 19328
{
	// Methods

	// RVA: 0x7C632A8 Offset: 0x7C5F2A8 VA: 0x7C632A8
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable // TypeDefIndex: 19329
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(char[] key, int start, int length);

	// RVA: 0x7C5ED6C Offset: 0x7C5AD6C VA: 0x7C5ED6C
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 19330
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x50
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x54
	internal Nullable<Required> _itemRequired; // 0x5C
	internal Nullable<NullValueHandling> _itemNullValueHandling; // 0x64

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x7C632B0 Offset: 0x7C5F2B0 VA: 0x7C632B0
	public MemberSerialization get_MemberSerialization() { }
}

// Namespace: Newtonsoft.Json
internal enum JsonContainerType // TypeDefIndex: 19331
{
	// Fields
	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
internal struct JsonPosition // TypeDefIndex: 19332
{
	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	[Nullable(2)]
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x7C632B8 Offset: 0x7C5F2B8 VA: 0x7C632B8
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x7C6334C Offset: 0x7C5F34C VA: 0x7C6334C
	internal int CalculateLength() { }

	[NullableContext(2)]
	// RVA: 0x7C633E0 Offset: 0x7C5F3E0 VA: 0x7C633E0
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

	// RVA: 0x7C6333C Offset: 0x7C5F33C VA: 0x7C6333C
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0x7C635FC Offset: 0x7C5F5FC VA: 0x7C635FC
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0x7C63904 Offset: 0x7C5F904 VA: 0x7C63904
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0x7C63C30 Offset: 0x7C5FC30 VA: 0x7C63C30
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Usage(2432, AllowMultiple = False)]
[Nullable(0)]
public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 19333
{
	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x60
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; // 0x70
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	public string PropertyName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C63CD0 Offset: 0x7C5FCD0 VA: 0x7C63CD0
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x7C63CD8 Offset: 0x7C5FCD8 VA: 0x7C63CD8
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x7C63CE0 Offset: 0x7C5FCE0 VA: 0x7C63CE0
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	// RVA: 0x7C63CE8 Offset: 0x7C5FCE8 VA: 0x7C63CE8
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x7C63CF0 Offset: 0x7C5FCF0 VA: 0x7C63CF0
	public string get_PropertyName() { }
}

// Namespace: 
[NullableContext(0)]
protected internal enum JsonReader.State // TypeDefIndex: 19334
{
	// Fields
	public int value__; // 0x0
	public const JsonReader.State Start = 0;
	public const JsonReader.State Complete = 1;
	public const JsonReader.State Property = 2;
	public const JsonReader.State ObjectStart = 3;
	public const JsonReader.State Object = 4;
	public const JsonReader.State ArrayStart = 5;
	public const JsonReader.State Array = 6;
	public const JsonReader.State Closed = 7;
	public const JsonReader.State PostValue = 8;
	public const JsonReader.State ConstructorStart = 9;
	public const JsonReader.State Constructor = 10;
	public const JsonReader.State Error = 11;
	public const JsonReader.State Finished = 12;
}

// Namespace: 
[CompilerGenerated]
private struct JsonReader.<MoveToContentFromNonContentAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 19335
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x7C67D78 Offset: 0x7C63D78 VA: 0x7C67D78 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C68018 Offset: 0x7C64018 VA: 0x7C68018 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonReader.<ReadAndMoveToContentAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 19336
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x7C68094 Offset: 0x7C64094 VA: 0x7C68094 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C683F4 Offset: 0x7C643F4 VA: 0x7C683F4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonReader.<SkipAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 19337
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30
	private int <depth>5__2; // 0x40

	// Methods

	// RVA: 0x7C68470 Offset: 0x7C64470 VA: 0x7C68470 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C68828 Offset: 0x7C64828 VA: 0x7C68828 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public abstract class JsonReader : IDisposable // TypeDefIndex: 19338
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	[Nullable(1)]
	public virtual string Path { get; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7C63CF8 Offset: 0x7C5FCF8 VA: 0x7C63CF8 Slot: 5
	public virtual Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<SkipAsync>d__1))]
	[NullableContext(1)]
	// RVA: 0x7C63DB8 Offset: 0x7C5FDB8 VA: 0x7C63DB8
	public Task SkipAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<ReadAndMoveToContentAsync>d__12))]
	// RVA: 0x7C63EB4 Offset: 0x7C5FEB4 VA: 0x7C63EB4
	internal Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x7C63FDC Offset: 0x7C5FFDC VA: 0x7C63FDC
	internal Task<bool> MoveToContentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<MoveToContentFromNonContentAsync>d__14))]
	[NullableContext(1)]
	// RVA: 0x7C6406C Offset: 0x7C6006C VA: 0x7C6406C
	private Task<bool> MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C64194 Offset: 0x7C60194 VA: 0x7C64194
	protected JsonReader.State get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x7C6419C Offset: 0x7C6019C VA: 0x7C6419C
	public bool get_CloseInput() { }

	[CompilerGenerated]
	// RVA: 0x7C641A4 Offset: 0x7C601A4 VA: 0x7C641A4
	public void set_CloseInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7C641B0 Offset: 0x7C601B0 VA: 0x7C641B0
	public bool get_SupportMultipleContent() { }

	[CompilerGenerated]
	// RVA: 0x7C641B8 Offset: 0x7C601B8 VA: 0x7C641B8
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x7C641C4 Offset: 0x7C601C4 VA: 0x7C641C4
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x7C641CC Offset: 0x7C601CC VA: 0x7C641CC
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x7C6422C Offset: 0x7C6022C VA: 0x7C6422C
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x7C64234 Offset: 0x7C60234 VA: 0x7C64234
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x7C64294 Offset: 0x7C60294 VA: 0x7C64294
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x7C6429C Offset: 0x7C6029C VA: 0x7C6429C
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x7C642FC Offset: 0x7C602FC VA: 0x7C642FC
	public string get_DateFormatString() { }

	// RVA: 0x7C64304 Offset: 0x7C60304 VA: 0x7C64304
	public void set_DateFormatString(string value) { }

	// RVA: 0x7C6430C Offset: 0x7C6030C VA: 0x7C6430C
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x7C64314 Offset: 0x7C60314 VA: 0x7C64314
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x7C643D0 Offset: 0x7C603D0 VA: 0x7C643D0 Slot: 6
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x7C643D8 Offset: 0x7C603D8 VA: 0x7C643D8 Slot: 7
	public virtual object get_Value() { }

	// RVA: 0x7C643E0 Offset: 0x7C603E0 VA: 0x7C643E0 Slot: 8
	public virtual Type get_ValueType() { }

	// RVA: 0x7C643F4 Offset: 0x7C603F4 VA: 0x7C643F4 Slot: 9
	public virtual int get_Depth() { }

	[NullableContext(1)]
	// RVA: 0x7C64470 Offset: 0x7C60470 VA: 0x7C64470 Slot: 10
	public virtual string get_Path() { }

	[NullableContext(1)]
	// RVA: 0x7C64588 Offset: 0x7C60588 VA: 0x7C64588
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x7C645F0 Offset: 0x7C605F0 VA: 0x7C645F0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x7C645F8 Offset: 0x7C605F8 VA: 0x7C645F8
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0x7C6469C Offset: 0x7C6069C VA: 0x7C6469C
	protected void .ctor() { }

	// RVA: 0x7C6472C Offset: 0x7C6072C VA: 0x7C6472C
	private void Push(JsonContainerType value) { }

	// RVA: 0x7C64A18 Offset: 0x7C60A18 VA: 0x7C64A18
	private JsonContainerType Pop() { }

	// RVA: 0x7C64B40 Offset: 0x7C60B40 VA: 0x7C64B40
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Read();

	// RVA: 0x7C64B48 Offset: 0x7C60B48 VA: 0x7C64B48 Slot: 12
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0x7C6513C Offset: 0x7C6113C VA: 0x7C6513C
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0x7C652A8 Offset: 0x7C612A8 VA: 0x7C652A8 Slot: 13
	public virtual string ReadAsString() { }

	// RVA: 0x7C65510 Offset: 0x7C61510 VA: 0x7C65510 Slot: 14
	public virtual byte[] ReadAsBytes() { }

	[NullableContext(1)]
	// RVA: 0x7C65AA4 Offset: 0x7C61AA4 VA: 0x7C65AA4
	internal byte[] ReadArrayIntoByteArray() { }

	[NullableContext(1)]
	// RVA: 0x7C65BCC Offset: 0x7C61BCC VA: 0x7C65BCC
	private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) { }

	// RVA: 0x7C65DD0 Offset: 0x7C61DD0 VA: 0x7C65DD0 Slot: 15
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0x7C66090 Offset: 0x7C62090 VA: 0x7C66090
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0x7C661F8 Offset: 0x7C621F8 VA: 0x7C661F8 Slot: 16
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x7C664E8 Offset: 0x7C624E8 VA: 0x7C664E8
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0x7C66654 Offset: 0x7C62654 VA: 0x7C66654 Slot: 17
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x7C66A28 Offset: 0x7C62A28 VA: 0x7C66A28
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0x7C66C44 Offset: 0x7C62C44 VA: 0x7C66C44 Slot: 18
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x7C66EA8 Offset: 0x7C62EA8 VA: 0x7C66EA8
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0x7C670E4 Offset: 0x7C630E4 VA: 0x7C670E4 Slot: 19
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x7C67344 Offset: 0x7C63344 VA: 0x7C67344
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0x7C65A60 Offset: 0x7C61A60 VA: 0x7C65A60
	internal void ReaderReadAndAssert() { }

	[NullableContext(1)]
	// RVA: 0x7C6753C Offset: 0x7C6353C VA: 0x7C6753C
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0x7C65894 Offset: 0x7C61894 VA: 0x7C65894
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0x7C67588 Offset: 0x7C63588 VA: 0x7C67588
	public void Skip() { }

	// RVA: 0x7C65BC0 Offset: 0x7C61BC0 VA: 0x7C65BC0
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0x7C67620 Offset: 0x7C63620 VA: 0x7C67620
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0x7C64FC8 Offset: 0x7C60FC8 VA: 0x7C64FC8
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0x7C67724 Offset: 0x7C63724 VA: 0x7C67724
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0x7C649F8 Offset: 0x7C609F8 VA: 0x7C649F8
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0x7C67628 Offset: 0x7C63628 VA: 0x7C67628
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0x7C67830 Offset: 0x7C63830 VA: 0x7C67830
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0x7C67760 Offset: 0x7C63760 VA: 0x7C67760
	private void SetFinished() { }

	// RVA: 0x7C67788 Offset: 0x7C63788 VA: 0x7C67788
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0x7C6791C Offset: 0x7C6391C VA: 0x7C6791C Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7C6798C Offset: 0x7C6398C VA: 0x7C6798C Slot: 20
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x7C679B0 Offset: 0x7C639B0 VA: 0x7C679B0 Slot: 21
	public virtual void Close() { }

	// RVA: 0x7C679C8 Offset: 0x7C639C8 VA: 0x7C679C8
	internal void ReadAndAssert() { }

	// RVA: 0x7C67A1C Offset: 0x7C63A1C VA: 0x7C67A1C
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0x7C67A6C Offset: 0x7C63A6C VA: 0x7C67A6C
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0x7C67CF0 Offset: 0x7C63CF0 VA: 0x7C67CF0
	internal bool ReadAndMoveToContent() { }

	// RVA: 0x7C67D20 Offset: 0x7C63D20 VA: 0x7C67D20
	internal bool MoveToContent() { }

	// RVA: 0x7C64EC4 Offset: 0x7C60EC4 VA: 0x7C64EC4
	private JsonToken GetContentToken() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonReaderException : JsonException // TypeDefIndex: 19339
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x90
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0x7C68890 Offset: 0x7C64890 VA: 0x7C68890
	public void .ctor() { }

	// RVA: 0x7C68894 Offset: 0x7C64894 VA: 0x7C68894
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7C68898 Offset: 0x7C64898 VA: 0x7C68898
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x7C64A10 Offset: 0x7C60A10 VA: 0x7C64A10
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0x7C64F44 Offset: 0x7C60F44 VA: 0x7C64F44
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x7C688E0 Offset: 0x7C648E0 VA: 0x7C688E0
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 19340
{
	// Methods

	// RVA: 0x7C68AE4 Offset: 0x7C64AE4 VA: 0x7C68AE4
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class JsonSerializationException : JsonException // TypeDefIndex: 19341
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x90
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0x7C68AEC Offset: 0x7C64AEC VA: 0x7C68AEC
	public void .ctor() { }

	// RVA: 0x7C68AF0 Offset: 0x7C64AF0 VA: 0x7C68AF0
	public void .ctor(string message) { }

	// RVA: 0x7C68AF4 Offset: 0x7C64AF4 VA: 0x7C68AF4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x7C68AF8 Offset: 0x7C64AF8 VA: 0x7C68AF8
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7C68AFC Offset: 0x7C64AFC VA: 0x7C68AFC
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x7C624DC Offset: 0x7C5E4DC VA: 0x7C624DC
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0x7C68B44 Offset: 0x7C64B44 VA: 0x7C68B44
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x7C68BC8 Offset: 0x7C64BC8 VA: 0x7C68BC8
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public class JsonSerializer // TypeDefIndex: 19342
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; // 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	[Nullable(2)]
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual ISerializationBinder SerializationBinder { set; }
	[Nullable(2)]
	public virtual ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { get; set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual Nullable<int> MaxDepth { get; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C68DCC Offset: 0x7C64DCC VA: 0x7C68DCC Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x7C68E7C Offset: 0x7C64E7C VA: 0x7C68E7C Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x7C68F2C Offset: 0x7C64F2C VA: 0x7C68F2C Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x7C68FA4 Offset: 0x7C64FA4 VA: 0x7C68FA4 Slot: 7
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	// RVA: 0x7C6901C Offset: 0x7C6501C VA: 0x7C6901C Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x7C69024 Offset: 0x7C65024 VA: 0x7C69024 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x7C6902C Offset: 0x7C6502C VA: 0x7C6902C Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x7C69034 Offset: 0x7C65034 VA: 0x7C69034 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x7C69094 Offset: 0x7C65094 VA: 0x7C69094 Slot: 12
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x7C690F4 Offset: 0x7C650F4 VA: 0x7C690F4 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x7C69154 Offset: 0x7C65154 VA: 0x7C69154 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x7C691B4 Offset: 0x7C651B4 VA: 0x7C691B4 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x7C69214 Offset: 0x7C65214 VA: 0x7C69214 Slot: 16
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0x7C6921C Offset: 0x7C6521C VA: 0x7C6921C Slot: 17
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x7C6927C Offset: 0x7C6527C VA: 0x7C6927C Slot: 18
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x7C692DC Offset: 0x7C652DC VA: 0x7C692DC Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x7C6933C Offset: 0x7C6533C VA: 0x7C6933C Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x7C6939C Offset: 0x7C6539C VA: 0x7C6939C Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x7C693A4 Offset: 0x7C653A4 VA: 0x7C693A4 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x7C69404 Offset: 0x7C65404 VA: 0x7C69404 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x7C69470 Offset: 0x7C65470 VA: 0x7C69470 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0x7C69478 Offset: 0x7C65478 VA: 0x7C69478 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x7C69528 Offset: 0x7C65528 VA: 0x7C69528 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0x7C69534 Offset: 0x7C65534 VA: 0x7C69534 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0x7C69544 Offset: 0x7C65544 VA: 0x7C69544 Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0x7C69580 Offset: 0x7C65580 VA: 0x7C69580 Slot: 29
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0x7C695E8 Offset: 0x7C655E8 VA: 0x7C695E8 Slot: 30
	public virtual Nullable<int> get_MaxDepth() { }

	// RVA: 0x7C695F0 Offset: 0x7C655F0 VA: 0x7C695F0 Slot: 31
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0x7C6962C Offset: 0x7C6562C VA: 0x7C6962C Slot: 32
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x7C62024 Offset: 0x7C5E024 VA: 0x7C62024
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0x7C69694 Offset: 0x7C65694 VA: 0x7C69694
	public void .ctor() { }

	// RVA: 0x7C697E0 Offset: 0x7C657E0 VA: 0x7C697E0
	public static JsonSerializer Create() { }

	// RVA: 0x7C69830 Offset: 0x7C65830 VA: 0x7C69830
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0x7C69F9C Offset: 0x7C65F9C VA: 0x7C69F9C
	public static JsonSerializer CreateDefault() { }

	// RVA: 0x7C61904 Offset: 0x7C5D904 VA: 0x7C61904
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0x7C69864 Offset: 0x7C65864 VA: 0x7C69864
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x7C62490 Offset: 0x7C5E490 VA: 0x7C62490
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x7C6A328 Offset: 0x7C66328 VA: 0x7C6A328 Slot: 33
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4653F18 Offset: 0x464FF18 VA: 0x4653F18
	|-JsonSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0x4653FF0 Offset: 0x464FFF0 VA: 0x4653FF0
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x7C62178 Offset: 0x7C5E178 VA: 0x7C62178
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x7C6AC08 Offset: 0x7C66C08 VA: 0x7C6AC08 Slot: 34
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x7C6A5A0 Offset: 0x7C665A0 VA: 0x7C6A5A0
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x7C6A9EC Offset: 0x7C669EC VA: 0x7C6A9EC
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x7C61BD0 Offset: 0x7C5DBD0 VA: 0x7C61BD0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x7C6AE88 Offset: 0x7C66E88 VA: 0x7C6AE88
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0x7C6A964 Offset: 0x7C66964 VA: 0x7C6A964
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x7C6AE9C Offset: 0x7C66E9C VA: 0x7C6AE9C Slot: 35
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x7C6B460 Offset: 0x7C67460 VA: 0x7C6B460
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0x7C6B4D0 Offset: 0x7C674D0 VA: 0x7C6B4D0
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0x7C6B4D8 Offset: 0x7C674D8 VA: 0x7C6B4D8
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0x7C6B634 Offset: 0x7C67634 VA: 0x7C6B634
	internal void OnError(ErrorEventArgs e) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings // TypeDefIndex: 19343
{
	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; }
	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public ISerializationBinder SerializationBinder { get; }
	[Nullable(new[] { 2, 1 })]
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }
	public bool CheckAdditionalContent { get; }

	// Methods

	// RVA: 0x7C6A130 Offset: 0x7C66130 VA: 0x7C6A130
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x7C6A16C Offset: 0x7C6616C VA: 0x7C6A16C
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x7C6A1A8 Offset: 0x7C661A8 VA: 0x7C6A1A8
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x7C6A1E4 Offset: 0x7C661E4 VA: 0x7C6A1E4
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x7C6A220 Offset: 0x7C66220 VA: 0x7C6A220
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x7C6B65C Offset: 0x7C6765C VA: 0x7C6B65C
	public IList<JsonConverter> get_Converters() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x7C6B664 Offset: 0x7C67664 VA: 0x7C6B664
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0x7C6A0F4 Offset: 0x7C660F4 VA: 0x7C6A0F4
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x7C6A040 Offset: 0x7C66040 VA: 0x7C6A040
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x7C6A07C Offset: 0x7C6607C VA: 0x7C6A07C
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x7C6A0B8 Offset: 0x7C660B8 VA: 0x7C6A0B8
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x7C6A25C Offset: 0x7C6625C VA: 0x7C6A25C
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGenerated]
	// RVA: 0x7C6B66C Offset: 0x7C6766C VA: 0x7C6B66C
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	// RVA: 0x7C6B674 Offset: 0x7C67674 VA: 0x7C6B674
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x7C6B67C Offset: 0x7C6767C VA: 0x7C6B67C
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	// RVA: 0x7C6B684 Offset: 0x7C67684 VA: 0x7C6B684
	public ITraceWriter get_TraceWriter() { }

	[CompilerGenerated]
	// RVA: 0x7C6B68C Offset: 0x7C6768C VA: 0x7C6B68C
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	// RVA: 0x7C6B694 Offset: 0x7C67694 VA: 0x7C6B694
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0x7C6A298 Offset: 0x7C66298 VA: 0x7C6A298
	public StreamingContext get_Context() { }

	// RVA: 0x7C624A0 Offset: 0x7C5E4A0 VA: 0x7C624A0
	public bool get_CheckAdditionalContent() { }

	// RVA: 0x7C6B69C Offset: 0x7C6769C VA: 0x7C6B69C
	private static void .cctor() { }

	[DebuggerStepThrough]
	// RVA: 0x7C616BC Offset: 0x7C5D6BC VA: 0x7C616BC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<DoReadAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 19344
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public Task<bool> task; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C73C90 Offset: 0x7C6FC90 VA: 0x7C73C90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C73FD8 Offset: 0x7C6FFD8 VA: 0x7C73FD8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<EatWhitespaceAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 19345
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x7C74054 Offset: 0x7C70054 VA: 0x7C74054 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C74454 Offset: 0x7C70454 VA: 0x7C74454 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<MatchAndSetAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 19346
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	[Nullable(0)]
	public string value; // 0x28
	public CancellationToken cancellationToken; // 0x30
	public JsonToken newToken; // 0x38
	[Nullable(0)]
	public object tokenValue; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x48

	// Methods

	// RVA: 0x7C744BC Offset: 0x7C704BC VA: 0x7C744BC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C747CC Offset: 0x7C707CC VA: 0x7C747CC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<MatchValueAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 19347
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	[Nullable(0)]
	public string value; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C74834 Offset: 0x7C70834 VA: 0x7C74834 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C74AD4 Offset: 0x7C70AD4 VA: 0x7C74AD4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 19348
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	[Nullable(0)]
	public string value; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C74B50 Offset: 0x7C70B50 VA: 0x7C74B50 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C74F48 Offset: 0x7C70F48 VA: 0x7C74F48 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseCommentAsync>d__16 : IAsyncStateMachine // TypeDefIndex: 19349
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool setToken; // 0x30
	private bool <singlelineComment>5__2; // 0x31
	private int <initialPosition>5__3; // 0x34
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3; // 0x58

	// Methods

	// RVA: 0x7C74FC4 Offset: 0x7C70FC4 VA: 0x7C74FC4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C75858 Offset: 0x7C71858 VA: 0x7C75858 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseConstructorAsync>d__25 : IAsyncStateMachine // TypeDefIndex: 19350
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30
	private int <initialPosition>5__2; // 0x40
	private int <endPosition>5__3; // 0x44
	[Nullable(0)]
	private string <constructorName>5__4; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; // 0x60

	// Methods

	// RVA: 0x7C758C0 Offset: 0x7C718C0 VA: 0x7C758C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C762E4 Offset: 0x7C722E4 VA: 0x7C762E4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseNumberAsync>d__29 : IAsyncStateMachine // TypeDefIndex: 19351
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public ReadType readType; // 0x30
	private char <firstChar>5__2; // 0x34
	private int <initialPosition>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C7634C Offset: 0x7C7234C VA: 0x7C7634C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C765A4 Offset: 0x7C725A4 VA: 0x7C765A4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseNumberNaNAsync>d__26 : IAsyncStateMachine // TypeDefIndex: 19352
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public ReadType readType; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ReadType <>7__wrap1; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40

	// Methods

	// RVA: 0x7C7660C Offset: 0x7C7260C VA: 0x7C7660C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C768D4 Offset: 0x7C728D4 VA: 0x7C768D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28 : IAsyncStateMachine // TypeDefIndex: 19353
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public ReadType readType; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ReadType <>7__wrap1; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40

	// Methods

	// RVA: 0x7C76950 Offset: 0x7C72950 VA: 0x7C76950 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C76C18 Offset: 0x7C72C18 VA: 0x7C76C18 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27 : IAsyncStateMachine // TypeDefIndex: 19354
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public ReadType readType; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ReadType <>7__wrap1; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40

	// Methods

	// RVA: 0x7C76C94 Offset: 0x7C72C94 VA: 0x7C76C94 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C76F5C Offset: 0x7C72F5C VA: 0x7C76F5C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseObjectAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 19355
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__3; // 0x50

	// Methods

	// RVA: 0x7C76FD8 Offset: 0x7C72FD8 VA: 0x7C76FD8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C77644 Offset: 0x7C73644 VA: 0x7C77644 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParsePostValueAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 19356
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool ignoreComments; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x7C776C0 Offset: 0x7C736C0 VA: 0x7C776C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C77D74 Offset: 0x7C73D74 VA: 0x7C77D74 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParsePropertyAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 19357
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private char <quoteChar>5__2; // 0x30
	[Nullable(0)]
	private string <propertyName>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C77DF0 Offset: 0x7C73DF0 VA: 0x7C77DF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C784D0 Offset: 0x7C744D0 VA: 0x7C784D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseStringAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 19358
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	public char quote; // 0x30
	public ReadType readType; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C7854C Offset: 0x7C7454C VA: 0x7C7854C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C787AC Offset: 0x7C747AC VA: 0x7C787AC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseUnicodeAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 19359
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<char> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x7C78814 Offset: 0x7C74814 VA: 0x7C78814 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C78A9C Offset: 0x7C74A9C VA: 0x7C78A9C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseUnquotedPropertyAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 19360
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private int <initialPosition>5__2; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C78B18 Offset: 0x7C74B18 VA: 0x7C78B18 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C78E48 Offset: 0x7C74E48 VA: 0x7C78E48 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ParseValueAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 19361
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__3; // 0x50
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__4; // 0x60

	// Methods

	// RVA: 0x7C78EB0 Offset: 0x7C74EB0 VA: 0x7C78EB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7A168 Offset: 0x7C76168 VA: 0x7C7A168 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ProcessCarriageReturnAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 19362
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task<bool> task; // 0x20
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x7C7A1E4 Offset: 0x7C761E4 VA: 0x7C7A1E4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7A420 Offset: 0x7C76420 VA: 0x7C7A420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ReadCharsAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 19363
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public int relativePosition; // 0x28
	public bool append; // 0x2C
	public CancellationToken cancellationToken; // 0x30
	private int <charsRequired>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x7C7A488 Offset: 0x7C76488 VA: 0x7C7A488 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7A738 Offset: 0x7C76738 VA: 0x7C7A738 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ReadDataAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 19364
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public bool append; // 0x28
	public int charsRequired; // 0x2C
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C7A7B4 Offset: 0x7C767B4 VA: 0x7C7A7B4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7AAF4 Offset: 0x7C76AF4 VA: 0x7C7AAF4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ReadFromFinishedAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 19365
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x7C7AB70 Offset: 0x7C76B70 VA: 0x7C7AB70 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7B0EC Offset: 0x7C770EC VA: 0x7C7B0EC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ReadNumberIntoBufferAsync>d__32 : IAsyncStateMachine // TypeDefIndex: 19366
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private int <charPos>5__2; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x7C7B168 Offset: 0x7C77168 VA: 0x7C7B168 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7B438 Offset: 0x7C77438 VA: 0x7C7B438 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextReader.<ReadStringIntoBufferAsync>d__9 : IAsyncStateMachine // TypeDefIndex: 19367
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextReader <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public char quote; // 0x30
	private int <charPos>5__2; // 0x34
	private int <initialPosition>5__3; // 0x38
	private int <lastWritePosition>5__4; // 0x3C
	private int <escapeStartPos>5__5; // 0x40
	private char <writeChar>5__6; // 0x44
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x58
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char> <>u__3; // 0x68
	private bool <anotherHighSurrogate>5__7; // 0x78
	private char <highSurrogate>5__8; // 0x7A
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__4; // 0x80

	// Methods

	// RVA: 0x7C7B4A0 Offset: 0x7C774A0 VA: 0x7C7B4A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C7C19C Offset: 0x7C7819C VA: 0x7C7C19C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 19368
{
	// Fields
	private readonly bool _safeAsync; // 0x72
	private readonly TextReader _reader; // 0x78
	[Nullable(2)]
	private char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0xC0
	[CompilerGenerated]
	[Nullable(2)]
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xC8

	// Properties
	[Nullable(2)]
	public JsonNameTable PropertyNameTable { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x7C6B724 Offset: 0x7C67724 VA: 0x7C6B724 Slot: 5
	public override Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C6B734 Offset: 0x7C67734 VA: 0x7C6B734
	internal Task<bool> DoReadAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsync>d__3))]
	// RVA: 0x7C6BD34 Offset: 0x7C67D34 VA: 0x7C6BD34
	private Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePostValueAsync>d__4))]
	// RVA: 0x7C6BBF8 Offset: 0x7C67BF8 VA: 0x7C6BBF8
	private Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadFromFinishedAsync>d__5))]
	// RVA: 0x7C6BE74 Offset: 0x7C67E74 VA: 0x7C6BE74
	private Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C6BFA0 Offset: 0x7C67FA0 VA: 0x7C6BFA0
	private Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadDataAsync>d__7))]
	// RVA: 0x7C6BFB0 Offset: 0x7C67FB0 VA: 0x7C6BFB0
	private Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseValueAsync>d__8))]
	// RVA: 0x7C6B99C Offset: 0x7C6799C VA: 0x7C6B99C
	private Task<bool> ParseValueAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadStringIntoBufferAsync>d__9))]
	// RVA: 0x7C6C0F8 Offset: 0x7C680F8 VA: 0x7C6C0F8
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	// RVA: 0x7C6C204 Offset: 0x7C68204 VA: 0x7C6C204
	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ProcessCarriageReturnAsync>d__11))]
	// RVA: 0x7C6C42C Offset: 0x7C6842C VA: 0x7C6C42C
	private Task ProcessCarriageReturnAsync(Task<bool> task) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnicodeAsync>d__12))]
	// RVA: 0x7C6C524 Offset: 0x7C68524 VA: 0x7C6C524
	private Task<char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C6C304 Offset: 0x7C68304 VA: 0x7C6C304
	private Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadCharsAsync>d__14))]
	// RVA: 0x7C6C64C Offset: 0x7C6864C VA: 0x7C6C64C
	private Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseObjectAsync>d__15))]
	// RVA: 0x7C6BACC Offset: 0x7C67ACC VA: 0x7C6BACC
	private Task<bool> ParseObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseCommentAsync>d__16))]
	// RVA: 0x7C6C794 Offset: 0x7C68794 VA: 0x7C6C794
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<EatWhitespaceAsync>d__17))]
	// RVA: 0x7C6C8A8 Offset: 0x7C688A8 VA: 0x7C6C8A8
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseStringAsync>d__18))]
	// RVA: 0x7C6C9A4 Offset: 0x7C689A4 VA: 0x7C6C9A4
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueAsync>d__19))]
	// RVA: 0x7C6CAB8 Offset: 0x7C68AB8 VA: 0x7C6CAB8
	private Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20))]
	// RVA: 0x7C6CBF8 Offset: 0x7C68BF8 VA: 0x7C6CBF8
	private Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchAndSetAsync>d__21))]
	// RVA: 0x7C6CD38 Offset: 0x7C68D38 VA: 0x7C6CD38
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	// RVA: 0x7C6CE78 Offset: 0x7C68E78 VA: 0x7C6CE78
	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C6CF20 Offset: 0x7C68F20 VA: 0x7C6CF20
	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C6CFC4 Offset: 0x7C68FC4 VA: 0x7C6CFC4
	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseConstructorAsync>d__25))]
	// RVA: 0x7C6D03C Offset: 0x7C6903C VA: 0x7C6D03C
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNaNAsync>d__26))]
	// RVA: 0x7C6D13C Offset: 0x7C6913C VA: 0x7C6D13C
	private Task<object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27))]
	// RVA: 0x7C6D270 Offset: 0x7C69270 VA: 0x7C6D270
	private Task<object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28))]
	// RVA: 0x7C6D3A4 Offset: 0x7C693A4 VA: 0x7C6D3A4
	private Task<object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberAsync>d__29))]
	// RVA: 0x7C6D4D8 Offset: 0x7C694D8 VA: 0x7C6D4D8
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	// RVA: 0x7C6D5E4 Offset: 0x7C695E4 VA: 0x7C6D5E4
	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePropertyAsync>d__31))]
	// RVA: 0x7C6D65C Offset: 0x7C6965C VA: 0x7C6D65C
	private Task<bool> ParsePropertyAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNumberIntoBufferAsync>d__32))]
	// RVA: 0x7C6D788 Offset: 0x7C69788 VA: 0x7C6D788
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnquotedPropertyAsync>d__33))]
	// RVA: 0x7C6D884 Offset: 0x7C69884 VA: 0x7C6D884
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C62060 Offset: 0x7C5E060 VA: 0x7C62060
	public void .ctor(TextReader reader) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7C6D980 Offset: 0x7C69980 VA: 0x7C6D980
	public JsonNameTable get_PropertyNameTable() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7C6D988 Offset: 0x7C69988 VA: 0x7C6D988
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0x7C6D990 Offset: 0x7C69990 VA: 0x7C6D990
	private void EnsureBufferNotEmpty() { }

	// RVA: 0x7C6C3CC Offset: 0x7C683CC VA: 0x7C6C3CC
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0x7C6D9F0 Offset: 0x7C699F0 VA: 0x7C6D9F0
	private void OnNewLine(int pos) { }

	// RVA: 0x7C6DA00 Offset: 0x7C69A00 VA: 0x7C6DA00
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0x7C6DF68 Offset: 0x7C69F68 VA: 0x7C6DF68
	private void ParseReadString(char quote, ReadType readType) { }

	// RVA: 0x7C6E2A4 Offset: 0x7C6A2A4 VA: 0x7C6E2A4
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x7C6DA48 Offset: 0x7C69A48 VA: 0x7C6DA48
	private void ShiftBufferIfNeeded() { }

	// RVA: 0x7C6E2B8 Offset: 0x7C6A2B8 VA: 0x7C6E2B8
	private int ReadData(bool append) { }

	// RVA: 0x7C6E354 Offset: 0x7C6A354 VA: 0x7C6E354
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0x7C6E2C4 Offset: 0x7C6A2C4 VA: 0x7C6E2C4
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0x7C6E510 Offset: 0x7C6A510 VA: 0x7C6E510
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0x7C6E530 Offset: 0x7C6A530 VA: 0x7C6E530
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0x7C6E5A0 Offset: 0x7C6A5A0 VA: 0x7C6E5A0 Slot: 11
	public override bool Read() { }

	// RVA: 0x7C6F3D0 Offset: 0x7C6B3D0 VA: 0x7C6F3D0 Slot: 12
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x7C6F838 Offset: 0x7C6B838 VA: 0x7C6F838 Slot: 18
	public override Nullable<DateTime> ReadAsDateTime() { }

	[NullableContext(2)]
	// RVA: 0x7C6FD88 Offset: 0x7C6BD88 VA: 0x7C6FD88 Slot: 13
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x7C6FDEC Offset: 0x7C6BDEC VA: 0x7C6FDEC Slot: 14
	public override byte[] ReadAsBytes() { }

	[NullableContext(2)]
	// RVA: 0x7C6F8C8 Offset: 0x7C6B8C8 VA: 0x7C6F8C8
	private object ReadStringValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x7C70678 Offset: 0x7C6C678 VA: 0x7C70678
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0x7C703E0 Offset: 0x7C6C3E0 VA: 0x7C703E0
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0x7C70B44 Offset: 0x7C6CB44 VA: 0x7C70B44 Slot: 16
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x7C70374 Offset: 0x7C6C374 VA: 0x7C70374
	private void ProcessValueComma() { }

	[NullableContext(2)]
	// RVA: 0x7C6F460 Offset: 0x7C6B460 VA: 0x7C6F460
	private object ReadNumberValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x7C71084 Offset: 0x7C6D084 VA: 0x7C71084
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0x7C7120C Offset: 0x7C6D20C VA: 0x7C7120C Slot: 19
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x7C712D8 Offset: 0x7C6D2D8 VA: 0x7C712D8 Slot: 17
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x7C713A4 Offset: 0x7C6D3A4 VA: 0x7C713A4 Slot: 15
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x7C702A4 Offset: 0x7C6C2A4 VA: 0x7C702A4
	private void HandleNull() { }

	// RVA: 0x7C70514 Offset: 0x7C6C514 VA: 0x7C70514
	private void ReadFinished() { }

	// RVA: 0x7C70254 Offset: 0x7C6C254 VA: 0x7C70254
	private bool ReadNullChar() { }

	// RVA: 0x7C6B93C Offset: 0x7C6793C VA: 0x7C6B93C
	private void EnsureBuffer() { }

	// RVA: 0x7C6DAFC Offset: 0x7C69AFC VA: 0x7C6DAFC
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0x7C71594 Offset: 0x7C6D594 VA: 0x7C71594
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0x7C71544 Offset: 0x7C6D544 VA: 0x7C71544
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0x7C71638 Offset: 0x7C6D638 VA: 0x7C71638
	private char ConvertUnicode(bool enoughChars) { }

	// RVA: 0x7C71504 Offset: 0x7C6D504 VA: 0x7C71504
	private char ParseUnicode() { }

	// RVA: 0x7C7178C Offset: 0x7C6D78C VA: 0x7C7178C
	private void ReadNumberIntoBuffer() { }

	// RVA: 0x7C71810 Offset: 0x7C6D810 VA: 0x7C71810
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	// RVA: 0x7C7198C Offset: 0x7C6D98C VA: 0x7C7198C
	private void ClearRecentString() { }

	// RVA: 0x7C6ED88 Offset: 0x7C6AD88 VA: 0x7C6ED88
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0x7C6EBF8 Offset: 0x7C6ABF8 VA: 0x7C6EBF8
	private bool ParseObject() { }

	// RVA: 0x7C71998 Offset: 0x7C6D998 VA: 0x7C71998
	private bool ParseProperty() { }

	// RVA: 0x7C71BBC Offset: 0x7C6DBBC VA: 0x7C71BBC
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0x7C71C38 Offset: 0x7C6DC38 VA: 0x7C71C38
	private void ParseUnquotedProperty() { }

	// RVA: 0x7C71D38 Offset: 0x7C6DD38 VA: 0x7C71D38
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	// RVA: 0x7C6E7D8 Offset: 0x7C6A7D8 VA: 0x7C6E7D8
	private bool ParseValue() { }

	// RVA: 0x7C704F8 Offset: 0x7C6C4F8 VA: 0x7C704F8
	private void ProcessLineFeed() { }

	// RVA: 0x7C704B0 Offset: 0x7C6C4B0 VA: 0x7C704B0
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0x7C6F030 Offset: 0x7C6B030 VA: 0x7C6F030
	private void EatWhitespace() { }

	// RVA: 0x7C72044 Offset: 0x7C6E044 VA: 0x7C72044
	private void ParseConstructor() { }

	// RVA: 0x7C70940 Offset: 0x7C6C940 VA: 0x7C70940
	private void ParseNumber(ReadType readType) { }

	// RVA: 0x7C7241C Offset: 0x7C6E41C VA: 0x7C7241C
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	// RVA: 0x7C733F4 Offset: 0x7C6F3F4 VA: 0x7C733F4
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0x7C73430 Offset: 0x7C6F430 VA: 0x7C73430
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0x7C6F144 Offset: 0x7C6B144 VA: 0x7C6F144
	private void ParseComment(bool setToken) { }

	// RVA: 0x7C734B8 Offset: 0x7C6F4B8 VA: 0x7C734B8
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0x7C73524 Offset: 0x7C6F524 VA: 0x7C73524
	private bool MatchValue(string value) { }

	// RVA: 0x7C73580 Offset: 0x7C6F580 VA: 0x7C73580
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0x7C709A8 Offset: 0x7C6C9A8 VA: 0x7C709A8
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0x7C73660 Offset: 0x7C6F660 VA: 0x7C73660
	private bool IsSeparator(char c) { }

	// RVA: 0x7C71E94 Offset: 0x7C6DE94 VA: 0x7C71E94
	private void ParseTrue() { }

	// RVA: 0x7C71458 Offset: 0x7C6D458 VA: 0x7C71458
	private void ParseNull() { }

	// RVA: 0x7C72370 Offset: 0x7C6E370 VA: 0x7C72370
	private void ParseUndefined() { }

	// RVA: 0x7C71F6C Offset: 0x7C6DF6C VA: 0x7C71F6C
	private void ParseFalse() { }

	// RVA: 0x7C708C4 Offset: 0x7C6C8C4 VA: 0x7C708C4
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0x7C737B8 Offset: 0x7C6F7B8 VA: 0x7C737B8
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0x7C70A4C Offset: 0x7C6CA4C VA: 0x7C70A4C
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0x7C7390C Offset: 0x7C6F90C VA: 0x7C7390C
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0x7C70AC8 Offset: 0x7C6CAC8 VA: 0x7C70AC8
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0x7C73A60 Offset: 0x7C6FA60 VA: 0x7C73A60
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0x7C73BB4 Offset: 0x7C6FBB4 VA: 0x7C73BB4 Slot: 21
	public override void Close() { }

	// RVA: 0x7C73C34 Offset: 0x7C6FC34 VA: 0x7C73C34 Slot: 22
	public bool HasLineInfo() { }

	// RVA: 0x7C73C3C Offset: 0x7C6FC3C VA: 0x7C73C3C Slot: 23
	public int get_LineNumber() { }

	// RVA: 0x7C73C84 Offset: 0x7C6FC84 VA: 0x7C73C84 Slot: 24
	public int get_LinePosition() { }
}

// Namespace: Newtonsoft.Json
internal enum ReadType // TypeDefIndex: 19369
{
	// Fields
	public int value__; // 0x0
	public const ReadType Read = 0;
	public const ReadType ReadAsInt32 = 1;
	public const ReadType ReadAsInt64 = 2;
	public const ReadType ReadAsBytes = 3;
	public const ReadType ReadAsString = 4;
	public const ReadType ReadAsDecimal = 5;
	public const ReadType ReadAsDateTime = 6;
	public const ReadType ReadAsDateTimeOffset = 7;
	public const ReadType ReadAsDouble = 8;
	public const ReadType ReadAsBoolean = 9;
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteCommentAsync>d__115 : IAsyncStateMachine // TypeDefIndex: 19370
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public string text; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C81840 Offset: 0x7C7D840 VA: 0x7C81840 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C81DA0 Offset: 0x7C7DDA0 VA: 0x7C81DA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWritePropertyNameAsync>d__30 : IAsyncStateMachine // TypeDefIndex: 19371
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	[Nullable(0)]
	public string name; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C81E08 Offset: 0x7C7DE08 VA: 0x7C81E08 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C821AC Offset: 0x7C7E1AC VA: 0x7C821AC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteRawValueAsync>d__121 : IAsyncStateMachine // TypeDefIndex: 19372
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	[Nullable(0)]
	public string json; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C82214 Offset: 0x7C7E214 VA: 0x7C82214 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C824C0 Offset: 0x7C7E4C0 VA: 0x7C824C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteStartArrayAsync>d__35 : IAsyncStateMachine // TypeDefIndex: 19373
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C82528 Offset: 0x7C7E528 VA: 0x7C82528 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C8280C Offset: 0x7C7E80C VA: 0x7C8280C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteStartConstructorAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 19374
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public string name; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C82874 Offset: 0x7C7E874 VA: 0x7C82874 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C82D8C Offset: 0x7C7ED8C VA: 0x7C82D8C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteStartObjectAsync>d__38 : IAsyncStateMachine // TypeDefIndex: 19375
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C82DF4 Offset: 0x7C7EDF4 VA: 0x7C82DF4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C830D8 Offset: 0x7C7F0D8 VA: 0x7C830D8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteUndefinedAsync>d__43 : IAsyncStateMachine // TypeDefIndex: 19376
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C83140 Offset: 0x7C7F140 VA: 0x7C83140 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C83458 Offset: 0x7C7F458 VA: 0x7C83458 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteValueAsync>d__60 : IAsyncStateMachine // TypeDefIndex: 19377
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public DateTime value; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C834C0 Offset: 0x7C7F4C0 VA: 0x7C834C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C83B50 Offset: 0x7C7FB50 VA: 0x7C83B50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteValueAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 19378
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public DateTimeOffset value; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C83BB8 Offset: 0x7C7FBB8 VA: 0x7C83BB8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C84200 Offset: 0x7C80200 VA: 0x7C84200 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteValueAsync>d__78 : IAsyncStateMachine // TypeDefIndex: 19379
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public Guid value; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C84268 Offset: 0x7C80268 VA: 0x7C84268 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C847B8 Offset: 0x7C807B8 VA: 0x7C847B8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteValueAsync>d__97 : IAsyncStateMachine // TypeDefIndex: 19380
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public string value; // 0x28
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C84820 Offset: 0x7C80820 VA: 0x7C84820 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C84B64 Offset: 0x7C80B64 VA: 0x7C84B64 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<DoWriteValueAsync>d__99 : IAsyncStateMachine // TypeDefIndex: 19381
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public TimeSpan value; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C84BCC Offset: 0x7C80BCC VA: 0x7C84BCC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C85160 Offset: 0x7C81160 VA: 0x7C85160 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<WriteIndentAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 19382
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public int newLineLen; // 0x28
	public int currentIndentCount; // 0x2C
	public CancellationToken cancellationToken; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C851C8 Offset: 0x7C811C8 VA: 0x7C851C8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C85680 Offset: 0x7C81680 VA: 0x7C85680 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<WriteIntegerValueAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 19383
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	public ulong uvalue; // 0x30
	public bool negative; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x7C856E8 Offset: 0x7C816E8 VA: 0x7C856E8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C85998 Offset: 0x7C81998 VA: 0x7C85998 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<WriteValueInternalAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 19384
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	[Nullable(0)]
	public string value; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C85A00 Offset: 0x7C81A00 VA: 0x7C85A00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C85DA4 Offset: 0x7C81DA4 VA: 0x7C85DA4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<WriteValueNonNullAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 19385
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public byte[] value; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C85E0C Offset: 0x7C81E0C VA: 0x7C85E0C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C866F8 Offset: 0x7C826F8 VA: 0x7C866F8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonTextWriter.<WriteValueNotNullAsync>d__110 : IAsyncStateMachine // TypeDefIndex: 19386
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonTextWriter <>4__this; // 0x28
	[Nullable(0)]
	public Uri value; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C86760 Offset: 0x7C82760 VA: 0x7C86760 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C86A2C Offset: 0x7C82A2C VA: 0x7C86A2C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public class JsonTextWriter : JsonWriter // TypeDefIndex: 19387
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private readonly TextWriter _writer; // 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; // 0x70
	private char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	[Nullable(2)]
	private bool[] _charEscapeFlags; // 0x88
	[Nullable(2)]
	private char[] _writeBuffer; // 0x90
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0x98
	[Nullable(2)]
	private char[] _indentChars; // 0xA0

	// Properties
	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }

	// Methods

	// RVA: 0x7C7C204 Offset: 0x7C78204 VA: 0x7C7C204 Slot: 7
	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C218 Offset: 0x7C78218 VA: 0x7C7C218
	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C288 Offset: 0x7C78288 VA: 0x7C7C288 Slot: 5
	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C29C Offset: 0x7C7829C VA: 0x7C7C29C
	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C3E8 Offset: 0x7C783E8 VA: 0x7C7C3E8 Slot: 6
	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C3FC Offset: 0x7C783FC VA: 0x7C7C3FC
	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIndentAsync>d__13))]
	// RVA: 0x7C7C5B8 Offset: 0x7C785B8 VA: 0x7C7C5B8
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C6C8 Offset: 0x7C786C8 VA: 0x7C7C6C8
	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueInternalAsync>d__15))]
	// RVA: 0x7C7C7A8 Offset: 0x7C787A8 VA: 0x7C7C7A8
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C8D4 Offset: 0x7C788D4 VA: 0x7C7C8D4 Slot: 8
	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C8E8 Offset: 0x7C788E8 VA: 0x7C7C8E8
	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C958 Offset: 0x7C78958 VA: 0x7C7C958 Slot: 9
	public override Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C96C Offset: 0x7C7896C VA: 0x7C7C96C
	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C7C9E0 Offset: 0x7C789E0 VA: 0x7C7C9E0 Slot: 13
	public override Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7C9F4 Offset: 0x7C789F4 VA: 0x7C7C9F4
	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7CA68 Offset: 0x7C78A68 VA: 0x7C7CA68
	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CC10 Offset: 0x7C78C10 VA: 0x7C7CC10
	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIntegerValueAsync>d__24))]
	// RVA: 0x7C7CCE0 Offset: 0x7C78CE0 VA: 0x7C7CCE0
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CE18 Offset: 0x7C78E18 VA: 0x7C7CE18
	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CE30 Offset: 0x7C78E30 VA: 0x7C7CE30
	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CE3C Offset: 0x7C78E3C VA: 0x7C7CE3C
	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CEF0 Offset: 0x7C78EF0 VA: 0x7C7CEF0 Slot: 14
	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C7CF04 Offset: 0x7C78F04 VA: 0x7C7CF04
	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWritePropertyNameAsync>d__30))]
	// RVA: 0x7C7D058 Offset: 0x7C79058 VA: 0x7C7D058
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D184 Offset: 0x7C79184 VA: 0x7C7D184 Slot: 15
	public override Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7D198 Offset: 0x7C79198 VA: 0x7C7D198
	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartArrayAsync>d__35))]
	// RVA: 0x7C7D264 Offset: 0x7C79264 VA: 0x7C7D264
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D37C Offset: 0x7C7937C VA: 0x7C7D37C Slot: 19
	public override Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7D390 Offset: 0x7C79390 VA: 0x7C7D390
	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartObjectAsync>d__38))]
	// RVA: 0x7C7D45C Offset: 0x7C7945C VA: 0x7C7D45C
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D574 Offset: 0x7C79574 VA: 0x7C7D574 Slot: 18
	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartConstructorAsync>d__40))]
	// RVA: 0x7C7D588 Offset: 0x7C79588 VA: 0x7C7D588
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D6A0 Offset: 0x7C796A0 VA: 0x7C7D6A0 Slot: 58
	public override Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7D6B4 Offset: 0x7C796B4 VA: 0x7C7D6B4
	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteUndefinedAsync>d__43))]
	// RVA: 0x7C7D7B0 Offset: 0x7C797B0 VA: 0x7C7D7B0
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D8C8 Offset: 0x7C798C8 VA: 0x7C7D8C8 Slot: 20
	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D8E4 Offset: 0x7C798E4 VA: 0x7C7D8E4
	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D960 Offset: 0x7C79960 VA: 0x7C7D960 Slot: 21
	public override Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7D97C Offset: 0x7C7997C VA: 0x7C7D97C
	internal Task DoWriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DA00 Offset: 0x7C79A00 VA: 0x7C7DA00 Slot: 22
	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DA24 Offset: 0x7C79A24 VA: 0x7C7DA24 Slot: 23
	public override Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DA40 Offset: 0x7C79A40 VA: 0x7C7DA40
	internal Task DoWriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DAC4 Offset: 0x7C79AC4 VA: 0x7C7DAC4 Slot: 24
	public override Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNonNullAsync>d__54))]
	// RVA: 0x7C7DAF4 Offset: 0x7C79AF4 VA: 0x7C7DAF4
	internal Task WriteValueNonNullAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DC0C Offset: 0x7C79C0C VA: 0x7C7DC0C Slot: 25
	public override Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DC20 Offset: 0x7C79C20 VA: 0x7C7DC20
	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DC9C Offset: 0x7C79C9C VA: 0x7C7DC9C Slot: 26
	public override Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DCB8 Offset: 0x7C79CB8 VA: 0x7C7DCB8
	internal Task DoWriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DD38 Offset: 0x7C79D38 VA: 0x7C7DD38 Slot: 27
	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__60))]
	// RVA: 0x7C7DD4C Offset: 0x7C79D4C VA: 0x7C7DD4C
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DE54 Offset: 0x7C79E54 VA: 0x7C7DE54 Slot: 28
	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DE68 Offset: 0x7C79E68 VA: 0x7C7DE68
	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7DEE8 Offset: 0x7C79EE8 VA: 0x7C7DEE8 Slot: 29
	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__64))]
	// RVA: 0x7C7DEFC Offset: 0x7C79EFC VA: 0x7C7DEFC
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E00C Offset: 0x7C7A00C VA: 0x7C7E00C Slot: 30
	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E060 Offset: 0x7C7A060 VA: 0x7C7E060
	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E0E0 Offset: 0x7C7A0E0 VA: 0x7C7E0E0 Slot: 31
	public override Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E0F4 Offset: 0x7C7A0F4 VA: 0x7C7E0F4
	internal Task DoWriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E180 Offset: 0x7C7A180 VA: 0x7C7E180 Slot: 32
	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E1F4 Offset: 0x7C7A1F4 VA: 0x7C7E1F4
	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E274 Offset: 0x7C7A274 VA: 0x7C7E274 Slot: 33
	public override Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E294 Offset: 0x7C7A294 VA: 0x7C7E294
	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E330 Offset: 0x7C7A330 VA: 0x7C7E330 Slot: 34
	public override Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E3F0 Offset: 0x7C7A3F0 VA: 0x7C7E3F0 Slot: 35
	public override Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E410 Offset: 0x7C7A410 VA: 0x7C7E410
	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E4AC Offset: 0x7C7A4AC VA: 0x7C7E4AC Slot: 36
	public override Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E568 Offset: 0x7C7A568 VA: 0x7C7E568 Slot: 37
	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__78))]
	// RVA: 0x7C7E57C Offset: 0x7C7A57C VA: 0x7C7E57C
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E68C Offset: 0x7C7A68C VA: 0x7C7E68C Slot: 38
	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E6E0 Offset: 0x7C7A6E0 VA: 0x7C7E6E0
	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E764 Offset: 0x7C7A764 VA: 0x7C7E764 Slot: 39
	public override Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E794 Offset: 0x7C7A794 VA: 0x7C7E794 Slot: 40
	public override Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E7A8 Offset: 0x7C7A7A8 VA: 0x7C7E7A8
	internal Task DoWriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E834 Offset: 0x7C7A834 VA: 0x7C7E834 Slot: 41
	public override Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E860 Offset: 0x7C7A860 VA: 0x7C7E860 Slot: 42
	public override Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E874 Offset: 0x7C7A874 VA: 0x7C7E874
	internal Task DoWriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E900 Offset: 0x7C7A900 VA: 0x7C7E900
	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7E9C0 Offset: 0x7C7A9C0 VA: 0x7C7E9C0 Slot: 43
	public override Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7EB18 Offset: 0x7C7AB18 VA: 0x7C7EB18 Slot: 44
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7EB48 Offset: 0x7C7AB48 VA: 0x7C7EB48 Slot: 45
	public override Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7EB64 Offset: 0x7C7AB64 VA: 0x7C7EB64
	internal Task DoWriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7EBF4 Offset: 0x7C7ABF4 VA: 0x7C7EBF4 Slot: 46
	public override Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7EC24 Offset: 0x7C7AC24 VA: 0x7C7EC24 Slot: 47
	public override Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7EC40 Offset: 0x7C7AC40 VA: 0x7C7EC40
	internal Task DoWriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7ECD0 Offset: 0x7C7ACD0 VA: 0x7C7ECD0 Slot: 48
	public override Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7ECE4 Offset: 0x7C7ACE4 VA: 0x7C7ECE4
	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__97))]
	// RVA: 0x7C7EE0C Offset: 0x7C7AE0C VA: 0x7C7EE0C
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7EF38 Offset: 0x7C7AF38 VA: 0x7C7EF38 Slot: 49
	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__99))]
	// RVA: 0x7C7EF4C Offset: 0x7C7AF4C VA: 0x7C7EF4C
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F054 Offset: 0x7C7B054 VA: 0x7C7F054 Slot: 50
	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F068 Offset: 0x7C7B068 VA: 0x7C7F068
	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F0E8 Offset: 0x7C7B0E8 VA: 0x7C7F0E8 Slot: 51
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F10C Offset: 0x7C7B10C VA: 0x7C7F10C Slot: 52
	public override Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F120 Offset: 0x7C7B120 VA: 0x7C7F120
	internal Task DoWriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F1A4 Offset: 0x7C7B1A4 VA: 0x7C7F1A4 Slot: 53
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F1C4 Offset: 0x7C7B1C4 VA: 0x7C7F1C4 Slot: 54
	public override Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F1D8 Offset: 0x7C7B1D8 VA: 0x7C7F1D8
	internal Task DoWriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F25C Offset: 0x7C7B25C VA: 0x7C7F25C Slot: 55
	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F328 Offset: 0x7C7B328 VA: 0x7C7F328
	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNotNullAsync>d__110))]
	// RVA: 0x7C7F3F8 Offset: 0x7C7B3F8 VA: 0x7C7F3F8
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F524 Offset: 0x7C7B524 VA: 0x7C7F524 Slot: 56
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C7F548 Offset: 0x7C7B548 VA: 0x7C7F548 Slot: 57
	public override Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F564 Offset: 0x7C7B564 VA: 0x7C7F564
	internal Task DoWriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F5E8 Offset: 0x7C7B5E8 VA: 0x7C7F5E8 Slot: 16
	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteCommentAsync>d__115))]
	// RVA: 0x7C7F5FC Offset: 0x7C7B5FC VA: 0x7C7F5FC
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F714 Offset: 0x7C7B714 VA: 0x7C7F714 Slot: 10
	public override Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7F738 Offset: 0x7C7B738 VA: 0x7C7F738 Slot: 11
	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7F75C Offset: 0x7C7B75C VA: 0x7C7F75C Slot: 12
	public override Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C7F780 Offset: 0x7C7B780 VA: 0x7C7F780 Slot: 17
	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F794 Offset: 0x7C7B794 VA: 0x7C7F794
	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteRawValueAsync>d__121))]
	// RVA: 0x7C7F860 Offset: 0x7C7B860 VA: 0x7C7F860
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C7F98C Offset: 0x7C7B98C VA: 0x7C7F98C
	internal char[] EnsureWriteBuffer(int length, int copyTo) { }

	// RVA: 0x7C7FA38 Offset: 0x7C7BA38 VA: 0x7C7FA38
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0x7C7FABC Offset: 0x7C7BABC VA: 0x7C7FABC
	public char get_QuoteChar() { }

	// RVA: 0x7C7FAC4 Offset: 0x7C7BAC4 VA: 0x7C7FAC4
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0x7C7FC98 Offset: 0x7C7BC98 VA: 0x7C7FC98 Slot: 60
	public override void Close() { }

	// RVA: 0x7C7FCB4 Offset: 0x7C7BCB4 VA: 0x7C7FCB4
	private void CloseBufferAndWriter() { }

	// RVA: 0x7C7FD18 Offset: 0x7C7BD18 VA: 0x7C7FD18 Slot: 61
	public override void WriteStartObject() { }

	// RVA: 0x7C7FD54 Offset: 0x7C7BD54 VA: 0x7C7FD54 Slot: 63
	public override void WriteStartArray() { }

	// RVA: 0x7C7FD90 Offset: 0x7C7BD90 VA: 0x7C7FD90 Slot: 65
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x7C7FE3C Offset: 0x7C7BE3C VA: 0x7C7FE3C Slot: 71
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x7C7FF30 Offset: 0x7C7BF30 VA: 0x7C7FF30 Slot: 67
	public override void WritePropertyName(string name) { }

	// RVA: 0x7C8003C Offset: 0x7C7C03C VA: 0x7C8003C Slot: 68
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x7C80100 Offset: 0x7C7C100 VA: 0x7C80100 Slot: 59
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0x7C7FC24 Offset: 0x7C7BC24 VA: 0x7C7FC24
	private void UpdateCharEscapeFlags() { }

	// RVA: 0x7C80104 Offset: 0x7C7C104 VA: 0x7C80104 Slot: 72
	protected override void WriteIndent() { }

	// RVA: 0x7C7C4C0 Offset: 0x7C784C0 VA: 0x7C7C4C0
	private int SetIndentChars() { }

	// RVA: 0x7C8022C Offset: 0x7C7C22C VA: 0x7C8022C Slot: 73
	protected override void WriteValueDelimiter() { }

	// RVA: 0x7C80254 Offset: 0x7C7C254 VA: 0x7C80254 Slot: 74
	protected override void WriteIndentSpace() { }

	// RVA: 0x7C8027C Offset: 0x7C7C27C VA: 0x7C8027C
	private void WriteValueInternal(string value, JsonToken token) { }

	[NullableContext(2)]
	// RVA: 0x7C802A0 Offset: 0x7C7C2A0 VA: 0x7C802A0 Slot: 116
	public override void WriteValue(object value) { }

	// RVA: 0x7C803B0 Offset: 0x7C7C3B0 VA: 0x7C803B0 Slot: 75
	public override void WriteNull() { }

	// RVA: 0x7C80434 Offset: 0x7C7C434 VA: 0x7C80434 Slot: 76
	public override void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x7C804B8 Offset: 0x7C7C4B8 VA: 0x7C804B8 Slot: 77
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x7C804F8 Offset: 0x7C7C4F8 VA: 0x7C804F8 Slot: 79
	public override void WriteValue(string value) { }

	// RVA: 0x7C7FF80 Offset: 0x7C7BF80 VA: 0x7C7FF80
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0x7C805E8 Offset: 0x7C7C5E8 VA: 0x7C805E8 Slot: 80
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C80664 Offset: 0x7C7C664 VA: 0x7C80664 Slot: 81
	public override void WriteValue(uint value) { }

	// RVA: 0x7C806E0 Offset: 0x7C7C6E0 VA: 0x7C806E0 Slot: 82
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C80710 Offset: 0x7C7C710 VA: 0x7C80710 Slot: 83
	public override void WriteValue(ulong value) { }

	// RVA: 0x7C807B4 Offset: 0x7C7C7B4 VA: 0x7C807B4 Slot: 84
	public override void WriteValue(float value) { }

	// RVA: 0x7C80860 Offset: 0x7C7C860 VA: 0x7C80860 Slot: 101
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x7C80954 Offset: 0x7C7C954 VA: 0x7C80954 Slot: 85
	public override void WriteValue(double value) { }

	// RVA: 0x7C80A00 Offset: 0x7C7CA00 VA: 0x7C80A00 Slot: 102
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x7C80B00 Offset: 0x7C7CB00 VA: 0x7C80B00 Slot: 86
	public override void WriteValue(bool value) { }

	// RVA: 0x7C80B98 Offset: 0x7C7CB98 VA: 0x7C80B98 Slot: 87
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C80BC8 Offset: 0x7C7CBC8 VA: 0x7C80BC8 Slot: 88
	public override void WriteValue(ushort value) { }

	// RVA: 0x7C80BF8 Offset: 0x7C7CBF8 VA: 0x7C80BF8 Slot: 89
	public override void WriteValue(char value) { }

	// RVA: 0x7C80C90 Offset: 0x7C7CC90 VA: 0x7C80C90 Slot: 90
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C80CC0 Offset: 0x7C7CCC0 VA: 0x7C80CC0 Slot: 91
	public override void WriteValue(sbyte value) { }

	// RVA: 0x7C80CF0 Offset: 0x7C7CCF0 VA: 0x7C80CF0 Slot: 92
	public override void WriteValue(Decimal value) { }

	// RVA: 0x7C80D90 Offset: 0x7C7CD90 VA: 0x7C80D90 Slot: 93
	public override void WriteValue(DateTime value) { }

	// RVA: 0x7C80F14 Offset: 0x7C7CF14 VA: 0x7C80F14
	private int WriteValueToBuffer(DateTime value) { }

	[NullableContext(2)]
	// RVA: 0x7C8102C Offset: 0x7C7D02C VA: 0x7C8102C Slot: 114
	public override void WriteValue(byte[] value) { }

	// RVA: 0x7C810E4 Offset: 0x7C7D0E4 VA: 0x7C810E4 Slot: 94
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x7C81240 Offset: 0x7C7D240 VA: 0x7C81240
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0x7C813A0 Offset: 0x7C7D3A0 VA: 0x7C813A0 Slot: 95
	public override void WriteValue(Guid value) { }

	// RVA: 0x7C8149C Offset: 0x7C7D49C VA: 0x7C8149C Slot: 96
	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x7C815B0 Offset: 0x7C7D5B0 VA: 0x7C815B0 Slot: 115
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x7C81670 Offset: 0x7C7D670 VA: 0x7C81670 Slot: 117
	public override void WriteComment(string text) { }

	// RVA: 0x7C8059C Offset: 0x7C7C59C VA: 0x7C8059C
	private void EnsureWriteBuffer() { }

	// RVA: 0x7C80694 Offset: 0x7C7C694 VA: 0x7C80694
	private void WriteIntegerValue(long value) { }

	// RVA: 0x7C80744 Offset: 0x7C7C744 VA: 0x7C80744
	private void WriteIntegerValue(ulong value, bool negative) { }

	// RVA: 0x7C7CB44 Offset: 0x7C78B44 VA: 0x7C7CB44
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	// RVA: 0x7C80618 Offset: 0x7C7C618 VA: 0x7C80618
	private void WriteIntegerValue(int value) { }

	// RVA: 0x7C817D0 Offset: 0x7C7D7D0 VA: 0x7C817D0
	private void WriteIntegerValue(uint value, bool negative) { }

	// RVA: 0x7C81728 Offset: 0x7C7D728 VA: 0x7C81728
	private int WriteNumberToBuffer(uint value, bool negative) { }
}

// Namespace: Newtonsoft.Json
public enum JsonToken // TypeDefIndex: 19388
{
	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;
}

// Namespace: 
[NullableContext(0)]
internal enum JsonWriter.State // TypeDefIndex: 19389
{
	// Fields
	public int value__; // 0x0
	public const JsonWriter.State Start = 0;
	public const JsonWriter.State Property = 1;
	public const JsonWriter.State ObjectStart = 2;
	public const JsonWriter.State Object = 3;
	public const JsonWriter.State ArrayStart = 4;
	public const JsonWriter.State Array = 5;
	public const JsonWriter.State ConstructorStart = 6;
	public const JsonWriter.State Constructor = 7;
	public const JsonWriter.State Closed = 8;
	public const JsonWriter.State Error = 9;
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d : IAsyncStateMachine // TypeDefIndex: 19390
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x28
	public int LevelsToComplete; // 0x30
	public CancellationToken CancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C8FD4C Offset: 0x7C8BD4C VA: 0x7C8FD4C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C8FFFC Offset: 0x7C8BFFC VA: 0x7C8FFFC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d : IAsyncStateMachine // TypeDefIndex: 19391
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x28
	public JsonToken token; // 0x30
	public CancellationToken CancellationToken; // 0x38
	public int LevelsToComplete; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x7C90064 Offset: 0x7C8C064 VA: 0x7C90064 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C90404 Offset: 0x7C8C404 VA: 0x7C90404 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d : IAsyncStateMachine // TypeDefIndex: 19392
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x28
	public CancellationToken CancellationToken; // 0x30
	public JsonToken token; // 0x38
	public int LevelsToComplete; // 0x3C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C9046C Offset: 0x7C8C46C VA: 0x7C9046C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C90908 Offset: 0x7C8C908 VA: 0x7C90908 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : IAsyncStateMachine // TypeDefIndex: 19393
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x20
	public CancellationToken CancellationToken; // 0x28
	public int LevelsToComplete; // 0x30
	private JsonToken <token>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7C90970 Offset: 0x7C8C970 VA: 0x7C90970 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C90D80 Offset: 0x7C8CD80 VA: 0x7C90D80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<AutoCompleteAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 19394
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x7C90DE8 Offset: 0x7C8CDE8 VA: 0x7C90DE8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C910B0 Offset: 0x7C8D0B0 VA: 0x7C910B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JsonWriter.<InternalWriteStartAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 19395
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonWriter <>4__this; // 0x20
	public JsonToken token; // 0x28
	public CancellationToken cancellationToken; // 0x30
	public JsonContainerType container; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7C91118 Offset: 0x7C8D118 VA: 0x7C91118 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C91330 Offset: 0x7C8D330 VA: 0x7C91330 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public abstract class JsonWriter : IDisposable // TypeDefIndex: 19396
{
	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTemplate; // 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	[Nullable(2)]
	private string _dateFormatString; // 0x50
	[Nullable(2)]
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	public bool AutoCompleteOnClose { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	[Nullable(2)]
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x7C86A94 Offset: 0x7C82A94 VA: 0x7C86A94
	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<AutoCompleteAsync>d__1))]
	// RVA: 0x7C86D38 Offset: 0x7C82D38 VA: 0x7C86D38
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C86E30 Offset: 0x7C82E30 VA: 0x7C86E30 Slot: 5
	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x7C87014 Offset: 0x7C83014 VA: 0x7C87014 Slot: 6
	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C870E4 Offset: 0x7C830E4 VA: 0x7C870E4 Slot: 7
	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C871B4 Offset: 0x7C831B4 VA: 0x7C871B4 Slot: 8
	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C87284 Offset: 0x7C83284 VA: 0x7C87284 Slot: 9
	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C8735C Offset: 0x7C8335C VA: 0x7C8735C
	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	// RVA: 0x7C87C78 Offset: 0x7C83C78 VA: 0x7C87C78 Slot: 10
	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C87D48 Offset: 0x7C83D48 VA: 0x7C87D48 Slot: 11
	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C87E18 Offset: 0x7C83E18 VA: 0x7C87E18 Slot: 12
	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C87EE8 Offset: 0x7C83EE8 VA: 0x7C87EE8 Slot: 13
	public virtual Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C87FB8 Offset: 0x7C83FB8 VA: 0x7C87FB8 Slot: 14
	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C88090 Offset: 0x7C84090 VA: 0x7C88090
	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C88154 Offset: 0x7C84154 VA: 0x7C88154 Slot: 15
	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<InternalWriteStartAsync>d__20))]
	// RVA: 0x7C88224 Offset: 0x7C84224 VA: 0x7C88224
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	// RVA: 0x7C88338 Offset: 0x7C84338 VA: 0x7C88338 Slot: 16
	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x7C88410 Offset: 0x7C84410 VA: 0x7C88410
	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C8841C Offset: 0x7C8441C VA: 0x7C8841C Slot: 17
	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x7C884F4 Offset: 0x7C844F4 VA: 0x7C884F4 Slot: 18
	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x7C885CC Offset: 0x7C845CC VA: 0x7C885CC Slot: 19
	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C8869C Offset: 0x7C8469C VA: 0x7C8869C Slot: 20
	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88774 Offset: 0x7C84774 VA: 0x7C88774 Slot: 21
	public virtual Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8884C Offset: 0x7C8484C VA: 0x7C8884C Slot: 22
	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88924 Offset: 0x7C84924 VA: 0x7C88924 Slot: 23
	public virtual Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C889FC Offset: 0x7C849FC VA: 0x7C889FC Slot: 24
	public virtual Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88AD4 Offset: 0x7C84AD4 VA: 0x7C88AD4 Slot: 25
	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88BAC Offset: 0x7C84BAC VA: 0x7C88BAC Slot: 26
	public virtual Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88C84 Offset: 0x7C84C84 VA: 0x7C88C84 Slot: 27
	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88D5C Offset: 0x7C84D5C VA: 0x7C88D5C Slot: 28
	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88E44 Offset: 0x7C84E44 VA: 0x7C88E44 Slot: 29
	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x7C88F2C Offset: 0x7C84F2C VA: 0x7C88F2C Slot: 30
	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89020 Offset: 0x7C85020 VA: 0x7C89020 Slot: 31
	public virtual Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89108 Offset: 0x7C85108 VA: 0x7C89108 Slot: 32
	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89220 Offset: 0x7C85220 VA: 0x7C89220 Slot: 33
	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x7C892F8 Offset: 0x7C852F8 VA: 0x7C892F8 Slot: 34
	public virtual Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C893E0 Offset: 0x7C853E0 VA: 0x7C893E0 Slot: 35
	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x7C894B8 Offset: 0x7C854B8 VA: 0x7C894B8 Slot: 36
	public virtual Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89590 Offset: 0x7C85590 VA: 0x7C89590 Slot: 37
	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89678 Offset: 0x7C85678 VA: 0x7C89678 Slot: 38
	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8976C Offset: 0x7C8576C VA: 0x7C8976C Slot: 39
	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89844 Offset: 0x7C85844 VA: 0x7C89844 Slot: 40
	public virtual Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8991C Offset: 0x7C8591C VA: 0x7C8991C Slot: 41
	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x7C899F4 Offset: 0x7C859F4 VA: 0x7C899F4 Slot: 42
	public virtual Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89ADC Offset: 0x7C85ADC VA: 0x7C89ADC Slot: 43
	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C89BB4 Offset: 0x7C85BB4 VA: 0x7C89BB4 Slot: 44
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C89C8C Offset: 0x7C85C8C VA: 0x7C89C8C Slot: 45
	public virtual Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89D64 Offset: 0x7C85D64 VA: 0x7C89D64 Slot: 46
	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89E3C Offset: 0x7C85E3C VA: 0x7C89E3C Slot: 47
	public virtual Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89F14 Offset: 0x7C85F14 VA: 0x7C89F14 Slot: 48
	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x7C89FEC Offset: 0x7C85FEC VA: 0x7C89FEC Slot: 49
	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8A0C4 Offset: 0x7C860C4 VA: 0x7C8A0C4 Slot: 50
	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A1AC Offset: 0x7C861AC VA: 0x7C8A1AC Slot: 51
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A284 Offset: 0x7C86284 VA: 0x7C8A284 Slot: 52
	public virtual Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A35C Offset: 0x7C8635C VA: 0x7C8A35C Slot: 53
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A434 Offset: 0x7C86434 VA: 0x7C8A434 Slot: 54
	public virtual Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8A51C Offset: 0x7C8651C VA: 0x7C8A51C Slot: 55
	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A5F4 Offset: 0x7C865F4 VA: 0x7C8A5F4 Slot: 56
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8A6CC Offset: 0x7C866CC VA: 0x7C8A6CC Slot: 57
	public virtual Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8A7A4 Offset: 0x7C867A4 VA: 0x7C8A7A4 Slot: 58
	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x7C863C8 Offset: 0x7C823C8 VA: 0x7C863C8
	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x7C8A88C Offset: 0x7C8688C VA: 0x7C8A88C
	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	// RVA: 0x7C8BC24 Offset: 0x7C87C24 VA: 0x7C8BC24
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0x7C8BF60 Offset: 0x7C87F60 VA: 0x7C8BF60
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7C8C280 Offset: 0x7C88280 VA: 0x7C8C280
	public bool get_CloseOutput() { }

	[CompilerGenerated]
	// RVA: 0x7C8C288 Offset: 0x7C88288 VA: 0x7C8C288
	public void set_CloseOutput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7C8C294 Offset: 0x7C88294 VA: 0x7C8C294
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	// RVA: 0x7C8C29C Offset: 0x7C8829C VA: 0x7C8C29C
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0x7C8C2A8 Offset: 0x7C882A8 VA: 0x7C8C2A8
	protected internal int get_Top() { }

	// RVA: 0x7C8C300 Offset: 0x7C88300 VA: 0x7C8C300
	public WriteState get_WriteState() { }

	// RVA: 0x7C8C3AC Offset: 0x7C883AC VA: 0x7C8C3AC
	internal string get_ContainerPath() { }

	// RVA: 0x7C8C458 Offset: 0x7C88458 VA: 0x7C8C458
	public string get_Path() { }

	// RVA: 0x7C8C574 Offset: 0x7C88574 VA: 0x7C8C574
	public Formatting get_Formatting() { }

	// RVA: 0x7C8C57C Offset: 0x7C8857C VA: 0x7C8C57C
	public void set_Formatting(Formatting value) { }

	// RVA: 0x7C8C5DC Offset: 0x7C885DC VA: 0x7C8C5DC
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x7C8C5E4 Offset: 0x7C885E4 VA: 0x7C8C5E4
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x7C8C644 Offset: 0x7C88644 VA: 0x7C8C644
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x7C8C64C Offset: 0x7C8864C VA: 0x7C8C64C
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x7C8C6AC Offset: 0x7C886AC VA: 0x7C8C6AC
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x7C8C6B4 Offset: 0x7C886B4 VA: 0x7C8C6B4
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x7C8C720 Offset: 0x7C88720 VA: 0x7C8C720 Slot: 59
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x7C8C724 Offset: 0x7C88724 VA: 0x7C8C724
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x7C8C72C Offset: 0x7C8872C VA: 0x7C8C72C
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[NullableContext(2)]
	// RVA: 0x7C8C78C Offset: 0x7C8878C VA: 0x7C8C78C
	public string get_DateFormatString() { }

	[NullableContext(2)]
	// RVA: 0x7C8C794 Offset: 0x7C88794 VA: 0x7C8C794
	public void set_DateFormatString(string value) { }

	// RVA: 0x7C8C79C Offset: 0x7C8879C VA: 0x7C8C79C
	public CultureInfo get_Culture() { }

	// RVA: 0x7C8C804 Offset: 0x7C88804 VA: 0x7C8C804
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x7C8C80C Offset: 0x7C8880C VA: 0x7C8C80C
	protected void .ctor() { }

	// RVA: 0x7C8A874 Offset: 0x7C86874 VA: 0x7C8A874
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0x7C8C838 Offset: 0x7C88838 VA: 0x7C8C838
	private void Push(JsonContainerType value) { }

	// RVA: 0x7C876B0 Offset: 0x7C836B0 VA: 0x7C876B0
	private JsonContainerType Pop() { }

	// RVA: 0x7C8C2F8 Offset: 0x7C882F8 VA: 0x7C8C2F8
	private JsonContainerType Peek() { }

	// RVA: 0x7C8C9E8 Offset: 0x7C889E8 VA: 0x7C8C9E8 Slot: 60
	public virtual void Close() { }

	// RVA: 0x7C8CA38 Offset: 0x7C88A38 VA: 0x7C8CA38 Slot: 61
	public virtual void WriteStartObject() { }

	// RVA: 0x7C8CA84 Offset: 0x7C88A84 VA: 0x7C8CA84 Slot: 62
	public virtual void WriteEndObject() { }

	// RVA: 0x7C8CA90 Offset: 0x7C88A90 VA: 0x7C8CA90 Slot: 63
	public virtual void WriteStartArray() { }

	// RVA: 0x7C8CA9C Offset: 0x7C88A9C VA: 0x7C8CA9C Slot: 64
	public virtual void WriteEndArray() { }

	// RVA: 0x7C8CAA4 Offset: 0x7C88AA4 VA: 0x7C8CAA4 Slot: 65
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0x7C8CAB0 Offset: 0x7C88AB0 VA: 0x7C8CAB0 Slot: 66
	public virtual void WriteEndConstructor() { }

	// RVA: 0x7C8CAB8 Offset: 0x7C88AB8 VA: 0x7C8CAB8 Slot: 67
	public virtual void WritePropertyName(string name) { }

	// RVA: 0x7C8CAF8 Offset: 0x7C88AF8 VA: 0x7C8CAF8 Slot: 68
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0x7C8CB08 Offset: 0x7C88B08 VA: 0x7C8CB08 Slot: 69
	public virtual void WriteEnd() { }

	// RVA: 0x7C8CBE8 Offset: 0x7C88BE8 VA: 0x7C8CBE8
	public void WriteToken(JsonReader reader) { }

	// RVA: 0x7C8CBF0 Offset: 0x7C88BF0 VA: 0x7C8CBF0
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	// RVA: 0x7C8CC70 Offset: 0x7C88C70 VA: 0x7C8CC70
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0x7C8D34C Offset: 0x7C8934C VA: 0x7C8D34C Slot: 70
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0x7C8D674 Offset: 0x7C89674 VA: 0x7C8D674
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0x7C8D548 Offset: 0x7C89548 VA: 0x7C8D548
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0x7C8D6E0 Offset: 0x7C896E0 VA: 0x7C8D6E0
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0x7C8D5AC Offset: 0x7C895AC VA: 0x7C8D5AC
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0x7C8CB10 Offset: 0x7C88B10 VA: 0x7C8CB10
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0x7C8C9F8 Offset: 0x7C889F8 VA: 0x7C8C9F8
	private void AutoCompleteAll() { }

	// RVA: 0x7C8778C Offset: 0x7C8378C VA: 0x7C8778C
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0x7C8D740 Offset: 0x7C89740 VA: 0x7C8D740
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x7C875BC Offset: 0x7C835BC VA: 0x7C875BC
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0x7C87BC8 Offset: 0x7C83BC8 VA: 0x7C87BC8
	private void UpdateCurrentState() { }

	// RVA: 0x7C8D7FC Offset: 0x7C897FC VA: 0x7C8D7FC Slot: 71
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x7C8D800 Offset: 0x7C89800 VA: 0x7C8D800 Slot: 72
	protected virtual void WriteIndent() { }

	// RVA: 0x7C8D804 Offset: 0x7C89804 VA: 0x7C8D804 Slot: 73
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x7C8D808 Offset: 0x7C89808 VA: 0x7C8D808 Slot: 74
	protected virtual void WriteIndentSpace() { }

	// RVA: 0x7C8D80C Offset: 0x7C8980C VA: 0x7C8D80C
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0x7C8DA10 Offset: 0x7C89A10 VA: 0x7C8DA10 Slot: 75
	public virtual void WriteNull() { }

	// RVA: 0x7C8DA44 Offset: 0x7C89A44 VA: 0x7C8DA44 Slot: 76
	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x7C8DA60 Offset: 0x7C89A60 VA: 0x7C8DA60 Slot: 77
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x7C8DA68 Offset: 0x7C89A68 VA: 0x7C8DA68 Slot: 78
	public virtual void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x7C8DAB8 Offset: 0x7C89AB8 VA: 0x7C8DAB8 Slot: 79
	public virtual void WriteValue(string value) { }

	// RVA: 0x7C8DAD4 Offset: 0x7C89AD4 VA: 0x7C8DAD4 Slot: 80
	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DAF0 Offset: 0x7C89AF0 VA: 0x7C8DAF0 Slot: 81
	public virtual void WriteValue(uint value) { }

	// RVA: 0x7C8DB0C Offset: 0x7C89B0C VA: 0x7C8DB0C Slot: 82
	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DB28 Offset: 0x7C89B28 VA: 0x7C8DB28 Slot: 83
	public virtual void WriteValue(ulong value) { }

	// RVA: 0x7C8DB44 Offset: 0x7C89B44 VA: 0x7C8DB44 Slot: 84
	public virtual void WriteValue(float value) { }

	// RVA: 0x7C8DB60 Offset: 0x7C89B60 VA: 0x7C8DB60 Slot: 85
	public virtual void WriteValue(double value) { }

	// RVA: 0x7C8DB7C Offset: 0x7C89B7C VA: 0x7C8DB7C Slot: 86
	public virtual void WriteValue(bool value) { }

	// RVA: 0x7C8DB98 Offset: 0x7C89B98 VA: 0x7C8DB98 Slot: 87
	public virtual void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DBB4 Offset: 0x7C89BB4 VA: 0x7C8DBB4 Slot: 88
	public virtual void WriteValue(ushort value) { }

	// RVA: 0x7C8DBD0 Offset: 0x7C89BD0 VA: 0x7C8DBD0 Slot: 89
	public virtual void WriteValue(char value) { }

	// RVA: 0x7C8DBEC Offset: 0x7C89BEC VA: 0x7C8DBEC Slot: 90
	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DC08 Offset: 0x7C89C08 VA: 0x7C8DC08 Slot: 91
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0x7C8DC24 Offset: 0x7C89C24 VA: 0x7C8DC24 Slot: 92
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x7C8DC40 Offset: 0x7C89C40 VA: 0x7C8DC40 Slot: 93
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x7C8DC5C Offset: 0x7C89C5C VA: 0x7C8DC5C Slot: 94
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0x7C8DC78 Offset: 0x7C89C78 VA: 0x7C8DC78 Slot: 95
	public virtual void WriteValue(Guid value) { }

	// RVA: 0x7C8DC94 Offset: 0x7C89C94 VA: 0x7C8DC94 Slot: 96
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0x7C8DCB0 Offset: 0x7C89CB0 VA: 0x7C8DCB0 Slot: 97
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DD2C Offset: 0x7C89D2C VA: 0x7C8DD2C Slot: 98
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0x7C8DDA8 Offset: 0x7C89DA8 VA: 0x7C8DDA8 Slot: 99
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8DE34 Offset: 0x7C89E34 VA: 0x7C8DE34 Slot: 100
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0x7C8DEC0 Offset: 0x7C89EC0 VA: 0x7C8DEC0 Slot: 101
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0x7C8DF40 Offset: 0x7C89F40 VA: 0x7C8DF40 Slot: 102
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0x7C8DFCC Offset: 0x7C89FCC VA: 0x7C8DFCC Slot: 103
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0x7C8E050 Offset: 0x7C8A050 VA: 0x7C8E050 Slot: 104
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8E0CC Offset: 0x7C8A0CC VA: 0x7C8E0CC Slot: 105
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x7C8E148 Offset: 0x7C8A148 VA: 0x7C8E148 Slot: 106
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0x7C8E1C4 Offset: 0x7C8A1C4 VA: 0x7C8E1C4 Slot: 107
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7C8E240 Offset: 0x7C8A240 VA: 0x7C8E240 Slot: 108
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x7C8E2BC Offset: 0x7C8A2BC VA: 0x7C8E2BC Slot: 109
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x7C8E33C Offset: 0x7C8A33C VA: 0x7C8E33C Slot: 110
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x7C8E3C8 Offset: 0x7C8A3C8 VA: 0x7C8E3C8 Slot: 111
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x7C8E448 Offset: 0x7C8A448 VA: 0x7C8E448 Slot: 112
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x7C8E4CC Offset: 0x7C8A4CC VA: 0x7C8E4CC Slot: 113
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	// RVA: 0x7C8E558 Offset: 0x7C8A558 VA: 0x7C8E558 Slot: 114
	public virtual void WriteValue(byte[] value) { }

	[NullableContext(2)]
	// RVA: 0x7C8E588 Offset: 0x7C8A588 VA: 0x7C8E588 Slot: 115
	public virtual void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x7C8E634 Offset: 0x7C8A634 VA: 0x7C8E634 Slot: 116
	public virtual void WriteValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x7C8F8EC Offset: 0x7C8B8EC VA: 0x7C8F8EC Slot: 117
	public virtual void WriteComment(string text) { }

	// RVA: 0x7C8F8FC Offset: 0x7C8B8FC VA: 0x7C8F8FC Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7C8F96C Offset: 0x7C8B96C VA: 0x7C8F96C Slot: 118
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x7C8E7CC Offset: 0x7C8A7CC VA: 0x7C8E7CC
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0x7C8B9D4 Offset: 0x7C879D4 VA: 0x7C8B9D4
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0x7C8BB70 Offset: 0x7C87B70 VA: 0x7C8BB70
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0x7C8FA7C Offset: 0x7C8BA7C VA: 0x7C8FA7C
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0x7C8CA8C Offset: 0x7C88A8C VA: 0x7C8CA8C
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0x7C8CAD8 Offset: 0x7C88AD8 VA: 0x7C8CAD8
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x7C8DA64 Offset: 0x7C89A64 VA: 0x7C8DA64
	internal void InternalWriteRaw() { }

	// RVA: 0x7C8CA44 Offset: 0x7C88A44 VA: 0x7C8CA44
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0x7C8DA2C Offset: 0x7C89A2C VA: 0x7C8DA2C
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0x7C8F8F4 Offset: 0x7C8B8F4 VA: 0x7C8F8F4
	internal void InternalWriteComment() { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x7C87848 Offset: 0x7C83848 VA: 0x7C87848
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	[CompilerGenerated]
	// RVA: 0x7C87974 Offset: 0x7C83974 VA: 0x7C87974
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CompilerGenerated]
	// RVA: 0x7C87AA8 Offset: 0x7C83AA8 VA: 0x7C87AA8
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	[CompilerGenerated]
	// RVA: 0x7C8FC40 Offset: 0x7C8BC40 VA: 0x7C8FC40
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }
}

// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
[Serializable]
public class JsonWriterException : JsonException // TypeDefIndex: 19397
{
	// Fields
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0x7C91398 Offset: 0x7C8D398 VA: 0x7C91398
	public void .ctor() { }

	// RVA: 0x7C913A0 Offset: 0x7C8D3A0 VA: 0x7C913A0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7C913A8 Offset: 0x7C8D3A8 VA: 0x7C913A8
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0x7C86D08 Offset: 0x7C82D08 VA: 0x7C86D08
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0x7C913DC Offset: 0x7C8D3DC VA: 0x7C913DC
	internal static JsonWriterException Create(string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
public enum MemberSerialization // TypeDefIndex: 19398
{
	// Fields
	public int value__; // 0x0
	public const MemberSerialization OptOut = 0;
	public const MemberSerialization OptIn = 1;
	public const MemberSerialization Fields = 2;
}

// Namespace: Newtonsoft.Json
public enum MetadataPropertyHandling // TypeDefIndex: 19399
{
	// Fields
	public int value__; // 0x0
	public const MetadataPropertyHandling Default = 0;
	public const MetadataPropertyHandling ReadAhead = 1;
	public const MetadataPropertyHandling Ignore = 2;
}

// Namespace: Newtonsoft.Json
public enum MissingMemberHandling // TypeDefIndex: 19400
{
	// Fields
	public int value__; // 0x0
	public const MissingMemberHandling Ignore = 0;
	public const MissingMemberHandling Error = 1;
}

// Namespace: Newtonsoft.Json
public enum NullValueHandling // TypeDefIndex: 19401
{
	// Fields
	public int value__; // 0x0
	public const NullValueHandling Include = 0;
	public const NullValueHandling Ignore = 1;
}

// Namespace: Newtonsoft.Json
public enum ObjectCreationHandling // TypeDefIndex: 19402
{
	// Fields
	public int value__; // 0x0
	public const ObjectCreationHandling Auto = 0;
	public const ObjectCreationHandling Reuse = 1;
	public const ObjectCreationHandling Replace = 2;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum PreserveReferencesHandling // TypeDefIndex: 19403
{
	// Fields
	public int value__; // 0x0
	public const PreserveReferencesHandling None = 0;
	public const PreserveReferencesHandling Objects = 1;
	public const PreserveReferencesHandling Arrays = 2;
	public const PreserveReferencesHandling All = 3;
}

// Namespace: Newtonsoft.Json
public enum ReferenceLoopHandling // TypeDefIndex: 19404
{
	// Fields
	public int value__; // 0x0
	public const ReferenceLoopHandling Error = 0;
	public const ReferenceLoopHandling Ignore = 1;
	public const ReferenceLoopHandling Serialize = 2;
}

// Namespace: Newtonsoft.Json
public enum Required // TypeDefIndex: 19405
{
	// Fields
	public int value__; // 0x0
	public const Required Default = 0;
	public const Required AllowNull = 1;
	public const Required Always = 2;
	public const Required DisallowNull = 3;
}

// Namespace: Newtonsoft.Json
public enum StringEscapeHandling // TypeDefIndex: 19406
{
	// Fields
	public int value__; // 0x0
	public const StringEscapeHandling Default = 0;
	public const StringEscapeHandling EscapeNonAscii = 1;
	public const StringEscapeHandling EscapeHtml = 2;
}

// Namespace: Newtonsoft.Json
public enum TypeNameAssemblyFormatHandling // TypeDefIndex: 19407
{
	// Fields
	public int value__; // 0x0
	public const TypeNameAssemblyFormatHandling Simple = 0;
	public const TypeNameAssemblyFormatHandling Full = 1;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum TypeNameHandling // TypeDefIndex: 19408
{
	// Fields
	public int value__; // 0x0
	public const TypeNameHandling None = 0;
	public const TypeNameHandling Objects = 1;
	public const TypeNameHandling Arrays = 2;
	public const TypeNameHandling All = 3;
	public const TypeNameHandling Auto = 4;
}

// Namespace: Newtonsoft.Json
public enum WriteState // TypeDefIndex: 19409
{
	// Fields
	public int value__; // 0x0
	public const WriteState Error = 0;
	public const WriteState Closed = 1;
	public const WriteState Object = 2;
	public const WriteState Array = 3;
	public const WriteState Constructor = 4;
	public const WriteState Property = 5;
	public const WriteState Start = 6;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncUtils.<>c // TypeDefIndex: 19410
{
	// Fields
	[Nullable(0)]
	public static readonly AsyncUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Action <>9__5_0; // 0x8

	// Methods

	// RVA: 0x7C91834 Offset: 0x7C8D834 VA: 0x7C91834
	private static void .cctor() { }

	// RVA: 0x7C9189C Offset: 0x7C8D89C VA: 0x7C9189C
	public void .ctor() { }

	// RVA: 0x7C918A4 Offset: 0x7C8D8A4 VA: 0x7C918A4
	internal void <FromCanceled>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncUtils.<>c__6<T> // TypeDefIndex: 19411
{
	// Fields
	[Nullable(0)]
	public static readonly AsyncUtils.<>c__6<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T> <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B764 Offset: 0x4857764 VA: 0x485B764
	|-AsyncUtils.<>c__6<bool>..cctor
	|
	|-RVA: 0x485B830 Offset: 0x4857830 VA: 0x485B830
	|-AsyncUtils.<>c__6<int>..cctor
	|
	|-RVA: 0x485B9D0 Offset: 0x48579D0 VA: 0x485B9D0
	|-AsyncUtils.<>c__6<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B820 Offset: 0x4857820 VA: 0x485B820
	|-AsyncUtils.<>c__6<bool>..ctor
	|
	|-RVA: 0x485B8EC Offset: 0x48578EC VA: 0x485B8EC
	|-AsyncUtils.<>c__6<int>..ctor
	|
	|-RVA: 0x485BAC4 Offset: 0x4857AC4 VA: 0x485BAC4
	|-AsyncUtils.<>c__6<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <FromCanceled>b__6_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B828 Offset: 0x4857828 VA: 0x485B828
	|-AsyncUtils.<>c__6<bool>.<FromCanceled>b__6_0
	|
	|-RVA: 0x485B8F4 Offset: 0x48578F4 VA: 0x485B8F4
	|-AsyncUtils.<>c__6<int>.<FromCanceled>b__6_0
	|
	|-RVA: 0x485BACC Offset: 0x4857ACC VA: 0x485BACC
	|-AsyncUtils.<>c__6<__Il2CppFullySharedGenericType>.<FromCanceled>b__6_0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class AsyncUtils // TypeDefIndex: 19412
{
	// Fields
	public static readonly Task<bool> False; // 0x0
	public static readonly Task<bool> True; // 0x8
	internal static readonly Task CompletedTask; // 0x10

	// Methods

	[Extension]
	// RVA: 0x7C9149C Offset: 0x7C8D49C VA: 0x7C9149C
	internal static Task<bool> ToAsync(bool value) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x7C91504 Offset: 0x7C8D504 VA: 0x7C91504
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Extension]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static Task<T> CancelIfRequestedAsync<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x451B860 Offset: 0x4517860 VA: 0x451B860
	|-AsyncUtils.CancelIfRequestedAsync<bool>
	|
	|-RVA: 0x451B908 Offset: 0x4517908 VA: 0x451B908
	|-AsyncUtils.CancelIfRequestedAsync<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7C86F08 Offset: 0x7C82F08 VA: 0x7C86F08
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Task<T> FromCanceled<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x451B9B4 Offset: 0x45179B4 VA: 0x451B9B4
	|-AsyncUtils.FromCanceled<bool>
	|
	|-RVA: 0x451BB10 Offset: 0x4517B10 VA: 0x451BB10
	|-AsyncUtils.FromCanceled<int>
	|
	|-RVA: 0x451BC6C Offset: 0x4517C6C VA: 0x451BC6C
	|-AsyncUtils.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7C9159C Offset: 0x7C8D59C VA: 0x7C9159C
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x7C85CE0 Offset: 0x7C81CE0 VA: 0x7C85CE0
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x7C855A4 Offset: 0x7C815A4 VA: 0x7C855A4
	public static Task WriteAsync(TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x7C91660 Offset: 0x7C8D660 VA: 0x7C91660
	public static Task<int> ReadAsync(TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x7C87824 Offset: 0x7C83824 VA: 0x7C87824
	public static bool IsCompletedSuccessfully(Task task) { }

	// RVA: 0x7C91754 Offset: 0x7C8D754 VA: 0x7C91754
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct Base64Encoder.<EncodeAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 19413
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Base64Encoder <>4__this; // 0x20
	[Nullable(0)]
	public byte[] buffer; // 0x28
	public int index; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private int <num4>5__2; // 0x40
	private int <length>5__3; // 0x44
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x7C91ECC Offset: 0x7C8DECC VA: 0x7C91ECC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7C922D4 Offset: 0x7C8E2D4 VA: 0x7C922D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class Base64Encoder // TypeDefIndex: 19414
{
	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	[Nullable(2)]
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x7C918A8 Offset: 0x7C8D8A8 VA: 0x7C918A8
	public void .ctor(TextWriter writer) { }

	// RVA: 0x7C9194C Offset: 0x7C8D94C VA: 0x7C9194C
	private void ValidateEncode(byte[] buffer, int index, int count) { }

	// RVA: 0x7C91A10 Offset: 0x7C8DA10 VA: 0x7C91A10
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x7C91C70 Offset: 0x7C8DC70 VA: 0x7C91C70
	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) { }

	// RVA: 0x7C91BB0 Offset: 0x7C8DBB0 VA: 0x7C91BB0
	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) { }

	// RVA: 0x7C91D8C Offset: 0x7C8DD8C VA: 0x7C91D8C
	public void Flush() { }

	// RVA: 0x7C91C4C Offset: 0x7C8DC4C VA: 0x7C91C4C
	private void WriteChars(char[] chars, int index, int count) { }

	[AsyncStateMachine(typeof(Base64Encoder.<EncodeAsync>d__13))]
	// RVA: 0x7C86490 Offset: 0x7C82490 VA: 0x7C86490
	public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x7C91E44 Offset: 0x7C8DE44 VA: 0x7C91E44
	private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x7C865C0 Offset: 0x7C825C0 VA: 0x7C865C0
	public Task FlushAsync(CancellationToken cancellationToken) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 19415
{
	// Fields
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; // 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B86AD8 Offset: 0x5B82AD8 VA: 0x5B86AD8
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x5B87030 Offset: 0x5B83030 VA: 0x5B87030
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(TFirst first, TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B86BC0 Offset: 0x5B82BC0 VA: 0x5B86BC0
	|-BidirectionalDictionary<object, object>.Set
	|
	|-RVA: 0x5B87120 Offset: 0x5B83120 VA: 0x5B87120
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool TryGetByFirst(TFirst first, out TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B86EE8 Offset: 0x5B82EE8 VA: 0x5B86EE8
	|-BidirectionalDictionary<object, object>.TryGetByFirst
	|
	|-RVA: 0x5B87894 Offset: 0x5B83894 VA: 0x5B87894
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetByFirst
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBySecond(TSecond second, out TFirst first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B86F8C Offset: 0x5B82F8C VA: 0x5B86F8C
	|-BidirectionalDictionary<object, object>.TryGetBySecond
	|
	|-RVA: 0x5B879E0 Offset: 0x5B839E0 VA: 0x5B879E0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBySecond
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class BoxedPrimitives // TypeDefIndex: 19416
{
	// Fields
	internal static readonly object BooleanTrue; // 0x0
	internal static readonly object BooleanFalse; // 0x8
	internal static readonly object Int32_M1; // 0x10
	internal static readonly object Int32_0; // 0x18
	internal static readonly object Int32_1; // 0x20
	internal static readonly object Int32_2; // 0x28
	internal static readonly object Int32_3; // 0x30
	internal static readonly object Int32_4; // 0x38
	internal static readonly object Int32_5; // 0x40
	internal static readonly object Int32_6; // 0x48
	internal static readonly object Int32_7; // 0x50
	internal static readonly object Int32_8; // 0x58
	internal static readonly object Int64_M1; // 0x60
	internal static readonly object Int64_0; // 0x68
	internal static readonly object Int64_1; // 0x70
	internal static readonly object Int64_2; // 0x78
	internal static readonly object Int64_3; // 0x80
	internal static readonly object Int64_4; // 0x88
	internal static readonly object Int64_5; // 0x90
	internal static readonly object Int64_6; // 0x98
	internal static readonly object Int64_7; // 0xA0
	internal static readonly object Int64_8; // 0xA8
	private static readonly object DecimalZero; // 0xB0
	internal static readonly object DoubleNaN; // 0xB8
	internal static readonly object DoublePositiveInfinity; // 0xC0
	internal static readonly object DoubleNegativeInfinity; // 0xC8
	internal static readonly object DoubleZero; // 0xD0

	// Methods

	// RVA: 0x7C9233C Offset: 0x7C8E33C VA: 0x7C9233C
	internal static object Get(bool value) { }

	// RVA: 0x7C923A4 Offset: 0x7C8E3A4 VA: 0x7C923A4
	internal static object Get(int value) { }

	// RVA: 0x7C925B4 Offset: 0x7C8E5B4 VA: 0x7C925B4
	internal static object Get(long value) { }

	// RVA: 0x7C927D0 Offset: 0x7C8E7D0 VA: 0x7C927D0
	internal static object Get(Decimal value) { }

	// RVA: 0x7C928B8 Offset: 0x7C8E8B8 VA: 0x7C928B8
	internal static object Get(double value) { }

	// RVA: 0x7C929C0 Offset: 0x7C8E9C0 VA: 0x7C929C0
	private static void .cctor() { }
}

// Namespace: 
[NullableContext(0)]
private static class CollectionUtils.EmptyArrayContainer<T> // TypeDefIndex: 19417
{
	// Fields
	[Nullable(1)]
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605336C Offset: 0x604F36C VA: 0x605336C
	|-CollectionUtils.EmptyArrayContainer<byte>..cctor
	|
	|-RVA: 0x6053414 Offset: 0x604F414 VA: 0x6053414
	|-CollectionUtils.EmptyArrayContainer<int>..cctor
	|
	|-RVA: 0x60534BC Offset: 0x604F4BC VA: 0x60534BC
	|-CollectionUtils.EmptyArrayContainer<object>..cctor
	|
	|-RVA: 0x6053564 Offset: 0x604F564 VA: 0x6053564
	|-CollectionUtils.EmptyArrayContainer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class CollectionUtils // TypeDefIndex: 19418
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4554CF0 Offset: 0x4550CF0 VA: 0x4554CF0
	|-CollectionUtils.IsNullOrEmpty<object>
	|
	|-RVA: 0x4554DA4 Offset: 0x4550DA4 VA: 0x4554DA4
	|-CollectionUtils.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4553444 Offset: 0x454F444 VA: 0x4553444
	|-CollectionUtils.AddRange<object>
	|
	|-RVA: 0x45537D8 Offset: 0x454F7D8 VA: 0x45537D8
	|-CollectionUtils.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7C92F30 Offset: 0x7C8EF30 VA: 0x7C92F30
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x7C930D0 Offset: 0x7C8F0D0 VA: 0x7C930D0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x7C931EC Offset: 0x7C8F1EC VA: 0x7C931EC
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45543D0 Offset: 0x45503D0 VA: 0x45543D0
	|-CollectionUtils.IndexOf<object>
	|
	|-RVA: 0x45546EC Offset: 0x45506EC VA: 0x45546EC
	|-CollectionUtils.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4553DB4 Offset: 0x454FDB4 VA: 0x4553DB4
	|-CollectionUtils.Contains<object>
	|
	|-RVA: 0x4553ED4 Offset: 0x454FED4 VA: 0x4553ED4
	|-CollectionUtils.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4554AE8 Offset: 0x4550AE8 VA: 0x4554AE8
	|-CollectionUtils.IndexOfReference<object>
	|
	|-RVA: 0x4554B6C Offset: 0x4550B6C VA: 0x4554B6C
	|-CollectionUtils.IndexOfReference<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void FastReverse<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45540DC Offset: 0x45500DC VA: 0x45540DC
	|-CollectionUtils.FastReverse<JsonPosition>
	|
	|-RVA: 0x45541E0 Offset: 0x45501E0 VA: 0x45541E0
	|-CollectionUtils.FastReverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7C93524 Offset: 0x7C8F524 VA: 0x7C93524
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x7C937D8 Offset: 0x7C8F7D8 VA: 0x7C937D8
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x7C93A94 Offset: 0x7C8FA94 VA: 0x7C93A94
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x7C93BD0 Offset: 0x7C8FBD0 VA: 0x7C93BD0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: -1 Offset: -1
	public static T[] ArrayEmpty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4553C44 Offset: 0x454FC44 VA: 0x4553C44
	|-CollectionUtils.ArrayEmpty<byte>
	|
	|-RVA: 0x4553CA0 Offset: 0x454FCA0 VA: 0x4553CA0
	|-CollectionUtils.ArrayEmpty<int>
	|
	|-RVA: 0x4553CFC Offset: 0x454FCFC VA: 0x4553CFC
	|-CollectionUtils.ArrayEmpty<object>
	|
	|-RVA: 0x4553D58 Offset: 0x454FD58 VA: 0x4553D58
	|-CollectionUtils.ArrayEmpty<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 19419
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingCollection { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection // TypeDefIndex: 19420
{
	// Fields
	[Nullable(2)]
	private readonly IList _list; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly ICollection<T> _genericCollection; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBC95C Offset: 0x5BB895C VA: 0x5BBC95C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBCB68 Offset: 0x5BB8B68 VA: 0x5BBCB68
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBCC78 Offset: 0x5BB8C78 VA: 0x5BBCC78
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBCE94 Offset: 0x5BB8E94 VA: 0x5BBCE94
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBCFC0 Offset: 0x5BB8FC0 VA: 0x5BBCFC0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD0D4 Offset: 0x5BB90D4 VA: 0x5BBD0D4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD1E4 Offset: 0x5BB91E4 VA: 0x5BBD1E4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public virtual IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD4C0 Offset: 0x5BB94C0 VA: 0x5BBD4C0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD574 Offset: 0x5BB9574 VA: 0x5BBD574
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 16
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD61C Offset: 0x5BB961C VA: 0x5BBD61C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD728 Offset: 0x5BB9728 VA: 0x5BBD728
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 21
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD834 Offset: 0x5BB9834 VA: 0x5BBD834
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBD9F0 Offset: 0x5BB99F0 VA: 0x5BBD9F0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBDAEC Offset: 0x5BB9AEC VA: 0x5BBDAEC
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBDCA4 Offset: 0x5BB9CA4 VA: 0x5BBDCA4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBDDB4 Offset: 0x5BB9DB4 VA: 0x5BBDDB4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 14
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBDEAC Offset: 0x5BB9EAC VA: 0x5BBDEAC
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBDFA4 Offset: 0x5BB9FA4 VA: 0x5BBDFA4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE15C Offset: 0x5BBA15C VA: 0x5BBE15C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE1E0 Offset: 0x5BBA1E0 VA: 0x5BBE1E0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE1E8 Offset: 0x5BBA1E8 VA: 0x5BBE1E8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static void VerifyValueType(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE25C Offset: 0x5BBA25C VA: 0x5BBE25C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.VerifyValueType
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE390 Offset: 0x5BBA390 VA: 0x5BBE390
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public object get_UnderlyingCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBE4D8 Offset: 0x5BBA4D8 VA: 0x5BBE4D8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_UnderlyingCollection
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal enum PrimitiveTypeCode // TypeDefIndex: 19421
{
	// Fields
	public int value__; // 0x0
	public const PrimitiveTypeCode Empty = 0;
	public const PrimitiveTypeCode Object = 1;
	public const PrimitiveTypeCode Char = 2;
	public const PrimitiveTypeCode CharNullable = 3;
	public const PrimitiveTypeCode Boolean = 4;
	public const PrimitiveTypeCode BooleanNullable = 5;
	public const PrimitiveTypeCode SByte = 6;
	public const PrimitiveTypeCode SByteNullable = 7;
	public const PrimitiveTypeCode Int16 = 8;
	public const PrimitiveTypeCode Int16Nullable = 9;
	public const PrimitiveTypeCode UInt16 = 10;
	public const PrimitiveTypeCode UInt16Nullable = 11;
	public const PrimitiveTypeCode Int32 = 12;
	public const PrimitiveTypeCode Int32Nullable = 13;
	public const PrimitiveTypeCode Byte = 14;
	public const PrimitiveTypeCode ByteNullable = 15;
	public const PrimitiveTypeCode UInt32 = 16;
	public const PrimitiveTypeCode UInt32Nullable = 17;
	public const PrimitiveTypeCode Int64 = 18;
	public const PrimitiveTypeCode Int64Nullable = 19;
	public const PrimitiveTypeCode UInt64 = 20;
	public const PrimitiveTypeCode UInt64Nullable = 21;
	public const PrimitiveTypeCode Single = 22;
	public const PrimitiveTypeCode SingleNullable = 23;
	public const PrimitiveTypeCode Double = 24;
	public const PrimitiveTypeCode DoubleNullable = 25;
	public const PrimitiveTypeCode DateTime = 26;
	public const PrimitiveTypeCode DateTimeNullable = 27;
	public const PrimitiveTypeCode DateTimeOffset = 28;
	public const PrimitiveTypeCode DateTimeOffsetNullable = 29;
	public const PrimitiveTypeCode Decimal = 30;
	public const PrimitiveTypeCode DecimalNullable = 31;
	public const PrimitiveTypeCode Guid = 32;
	public const PrimitiveTypeCode GuidNullable = 33;
	public const PrimitiveTypeCode TimeSpan = 34;
	public const PrimitiveTypeCode TimeSpanNullable = 35;
	public const PrimitiveTypeCode BigInteger = 36;
	public const PrimitiveTypeCode BigIntegerNullable = 37;
	public const PrimitiveTypeCode Uri = 38;
	public const PrimitiveTypeCode String = 39;
	public const PrimitiveTypeCode Bytes = 40;
	public const PrimitiveTypeCode DBNull = 41;
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class TypeInformation // TypeDefIndex: 19422
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }
	public PrimitiveTypeCode TypeCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7C93DAC Offset: 0x7C8FDAC VA: 0x7C93DAC
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x7C93DB4 Offset: 0x7C8FDB4 VA: 0x7C93DB4
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0x7C93DBC Offset: 0x7C8FDBC VA: 0x7C93DBC
	public void .ctor(Type type, PrimitiveTypeCode typeCode) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParseResult // TypeDefIndex: 19423
{
	// Fields
	public int value__; // 0x0
	public const ParseResult None = 0;
	public const ParseResult Success = 1;
	public const ParseResult Overflow = 2;
	public const ParseResult Invalid = 3;
}

// Namespace: 
[NullableContext(0)]
internal enum ConvertUtils.ConvertResult // TypeDefIndex: 19424
{
	// Fields
	public int value__; // 0x0
	public const ConvertUtils.ConvertResult Success = 0;
	public const ConvertUtils.ConvertResult CannotConvertNull = 1;
	public const ConvertUtils.ConvertResult NotInstantiableType = 2;
	public const ConvertUtils.ConvertResult NoValidConversion = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class ConvertUtils.<>c__DisplayClass8_0 // TypeDefIndex: 19425
{
	// Fields
	[Nullable(new[] { 0, 2, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x7C943F8 Offset: 0x7C903F8 VA: 0x7C943F8
	public void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x7C97F34 Offset: 0x7C93F34 VA: 0x7C97F34
	internal object <CreateCastConverter>b__0(object o) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal static class ConvertUtils // TypeDefIndex: 19426
{
	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	[Nullable(new[] { 1, 0, 1, 1, 2, 2, 2 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x7C8E764 Offset: 0x7C8A764 VA: 0x7C8E764
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x7C93DF8 Offset: 0x7C8FDF8 VA: 0x7C93DF8
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x7C8F990 Offset: 0x7C8B990 VA: 0x7C8F990
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x7C94078 Offset: 0x7C90078 VA: 0x7C94078
	public static bool IsConvertible(Type t) { }

	// RVA: 0x7C9410C Offset: 0x7C9010C VA: 0x7C9410C
	public static TimeSpan ParseTimeSpan(string input) { }

	[NullableContext(2)]
	// RVA: 0x7C9419C Offset: 0x7C9019C VA: 0x7C9419C
	private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	// RVA: 0x7C94400 Offset: 0x7C90400 VA: 0x7C94400
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0x7C94774 Offset: 0x7C90774 VA: 0x7C94774
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0x7C94C8C Offset: 0x7C90C8C VA: 0x7C94C8C
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x7C95920 Offset: 0x7C91920 VA: 0x7C95920
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x7C94EF4 Offset: 0x7C90EF4 VA: 0x7C94EF4
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x7C95CF0 Offset: 0x7C91CF0 VA: 0x7C95CF0
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x7C95AE0 Offset: 0x7C91AE0 VA: 0x7C95AE0
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x7C95AD8 Offset: 0x7C91AD8 VA: 0x7C95AD8
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x7C95A48 Offset: 0x7C91A48 VA: 0x7C95A48
	public static bool IsInteger(object value) { }

	// RVA: 0x7C95E6C Offset: 0x7C91E6C VA: 0x7C95E6C
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x7C95FE8 Offset: 0x7C91FE8 VA: 0x7C95FE8
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x7C96158 Offset: 0x7C92158 VA: 0x7C96158
	public static ParseResult DecimalTryParse(char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0x7C96B2C Offset: 0x7C92B2C VA: 0x7C96B2C
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x7C96B88 Offset: 0x7C92B88 VA: 0x7C96B88
	public static bool TryHexTextToInt(char[] text, int start, int end, out int value) { }

	// RVA: 0x7C96C58 Offset: 0x7C92C58 VA: 0x7C96C58
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParserTimeZone // TypeDefIndex: 19427
{
	// Fields
	public int value__; // 0x0
	public const ParserTimeZone Unspecified = 0;
	public const ParserTimeZone Utc = 1;
	public const ParserTimeZone LocalWestOfUtc = 2;
	public const ParserTimeZone LocalEastOfUtc = 3;
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal struct DateTimeParser // TypeDefIndex: 19428
{
	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0x7C97FF4 Offset: 0x7C93FF4 VA: 0x7C97FF4
	private static void .cctor() { }

	// RVA: 0x7C98278 Offset: 0x7C94278 VA: 0x7C98278
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x7C98378 Offset: 0x7C94378 VA: 0x7C98378
	private bool ParseDate(int start) { }

	// RVA: 0x7C9856C Offset: 0x7C9456C VA: 0x7C9856C
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x7C98794 Offset: 0x7C94794 VA: 0x7C98794
	private bool ParseTime(ref int start) { }

	// RVA: 0x7C98A70 Offset: 0x7C94A70 VA: 0x7C98A70
	private bool ParseZone(int start) { }

	// RVA: 0x7C98608 Offset: 0x7C94608 VA: 0x7C98608
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x7C986F8 Offset: 0x7C946F8 VA: 0x7C986F8
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x7C98520 Offset: 0x7C94520 VA: 0x7C98520
	private bool ParseChar(int start, char ch) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
[Extension]
internal static class DateTimeUtils // TypeDefIndex: 19429
{
	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x7C98C78 Offset: 0x7C94C78 VA: 0x7C98C78
	private static void .cctor() { }

	[Extension]
	// RVA: 0x7C98D70 Offset: 0x7C94D70 VA: 0x7C98D70
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x7C98DD8 Offset: 0x7C94DD8 VA: 0x7C98DD8
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x7C98E5C Offset: 0x7C94E5C VA: 0x7C98E5C
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0x7C98FAC Offset: 0x7C94FAC VA: 0x7C98FAC
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x7C99084 Offset: 0x7C95084 VA: 0x7C99084
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x7C9915C Offset: 0x7C9515C VA: 0x7C9915C
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x7C9921C Offset: 0x7C9521C VA: 0x7C9921C
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x7C99378 Offset: 0x7C95378 VA: 0x7C99378
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x7C9945C Offset: 0x7C9545C VA: 0x7C9945C
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x7C994B4 Offset: 0x7C954B4 VA: 0x7C994B4
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x7C993E0 Offset: 0x7C953E0 VA: 0x7C993E0
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	// RVA: 0x7C99570 Offset: 0x7C95570 VA: 0x7C99570
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x7C995F8 Offset: 0x7C955F8 VA: 0x7C995F8
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x7C99B34 Offset: 0x7C95B34 VA: 0x7C99B34
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x7C99A3C Offset: 0x7C95A3C VA: 0x7C99A3C
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x7C99DC0 Offset: 0x7C95DC0 VA: 0x7C99DC0
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x7C9A240 Offset: 0x7C96240 VA: 0x7C9A240
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x7C9A510 Offset: 0x7C96510 VA: 0x7C9A510
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x7C9A940 Offset: 0x7C96940 VA: 0x7C9A940
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x7C9AC1C Offset: 0x7C96C1C VA: 0x7C9AC1C
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x7C99FF0 Offset: 0x7C95FF0 VA: 0x7C99FF0
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x7C9A15C Offset: 0x7C9615C VA: 0x7C9A15C
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x7C9A730 Offset: 0x7C96730 VA: 0x7C9A730
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x7C9A894 Offset: 0x7C96894 VA: 0x7C9A894
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x7C9AD98 Offset: 0x7C96D98 VA: 0x7C9AD98
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x7C9AF18 Offset: 0x7C96F18 VA: 0x7C9AF18
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x7C9B090 Offset: 0x7C97090 VA: 0x7C9B090
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x7C9B558 Offset: 0x7C97558 VA: 0x7C9B558
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x7C9BBB4 Offset: 0x7C97BB4 VA: 0x7C9BBB4
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x7C9B3A0 Offset: 0x7C973A0 VA: 0x7C9B3A0
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x7C9BC1C Offset: 0x7C97C1C VA: 0x7C9BC1C
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x7C9B984 Offset: 0x7C97984 VA: 0x7C9B984
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 19430
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingDictionary { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();
}

// Namespace: 
[Nullable(0)]
[IsReadOnly]
private struct DictionaryWrapper.DictionaryEnumerator<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 19431
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	[Nullable(2)]
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D542FC Offset: 0x5D502FC VA: 0x5D542FC
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54364 Offset: 0x5D50364 VA: 0x5D54364
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54430 Offset: 0x5D50430 VA: 0x5D54430
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D544A8 Offset: 0x5D504A8 VA: 0x5D544A8
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54520 Offset: 0x5D50520 VA: 0x5D54520
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54930 Offset: 0x5D50930 VA: 0x5D54930
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D549D0 Offset: 0x5D509D0 VA: 0x5D549D0
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DictionaryWrapper.<>c<TKey, TValue> // TypeDefIndex: 19432
{
	// Fields
	[Nullable(0)]
	public static readonly DictionaryWrapper.<>c<TKey, TValue> <>9; // 0x0
	[Nullable(0)]
	public static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> <>9__29_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834680 Offset: 0x4830680 VA: 0x4834680
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834774 Offset: 0x4830774 VA: 0x4834774
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x483477C Offset: 0x483077C VA: 0x483477C
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<GetEnumerator>b__29_0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[DefaultMember("Item")]
[Nullable(0)]
internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection // TypeDefIndex: 19433
{
	// Fields
	[Nullable(2)]
	private readonly IDictionary _dictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IDictionary<TKey, TValue> _genericDictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	internal IDictionary<TKey, TValue> GenericDictionary { get; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AEE8 Offset: 0x5D56EE8 VA: 0x5D5AEE8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_GenericDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AEF0 Offset: 0x5D56EF0 VA: 0x5D5AEF0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5B1B8 Offset: 0x5D571B8 VA: 0x5D5B1B8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5B494 Offset: 0x5D57494 VA: 0x5D5B494
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5B67C Offset: 0x5D5767C VA: 0x5D5B67C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5B9A4 Offset: 0x5D579A4 VA: 0x5D5B9A4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5BD74 Offset: 0x5D57D74 VA: 0x5D5BD74
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5BF5C Offset: 0x5D57F5C VA: 0x5D5BF5C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5C2B0 Offset: 0x5D582B0 VA: 0x5D5C2B0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5C5B4 Offset: 0x5D585B4 VA: 0x5D5C5B4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5C7FC Offset: 0x5D587FC VA: 0x5D5C7FC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5C954 Offset: 0x5D58954 VA: 0x5D5C954
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5CBD8 Offset: 0x5D58BD8 VA: 0x5D5CBD8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5D264 Offset: 0x5D59264 VA: 0x5D5D264
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5D3E8 Offset: 0x5D593E8 VA: 0x5D5D3E8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5D528 Offset: 0x5D59528 VA: 0x5D5D528
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5D960 Offset: 0x5D59960 VA: 0x5D5D960
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5DC44 Offset: 0x5D59C44 VA: 0x5D5DC44
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5DC58 Offset: 0x5D59C58 VA: 0x5D5DC58
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5DEF4 Offset: 0x5D59EF4 VA: 0x5D5DEF4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5E1D0 Offset: 0x5D5A1D0 VA: 0x5D5E1D0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5E46C Offset: 0x5D5A46C VA: 0x5D5E46C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5E644 Offset: 0x5D5A644 VA: 0x5D5E644
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5E8F0 Offset: 0x5D5A8F0 VA: 0x5D5E8F0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5E9BC Offset: 0x5D5A9BC VA: 0x5D5E9BC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5EB60 Offset: 0x5D5AB60 VA: 0x5D5EB60
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5ED90 Offset: 0x5D5AD90 VA: 0x5D5ED90
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5EF34 Offset: 0x5D5AF34 VA: 0x5D5EF34
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5F110 Offset: 0x5D5B110 VA: 0x5D5F110
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5F1C0 Offset: 0x5D5B1C0 VA: 0x5D5F1C0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public object get_UnderlyingDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5F234 Offset: 0x5D5B234 VA: 0x5D5F234
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnderlyingDictionary
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class DynamicProxy<T> // TypeDefIndex: 19434
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual IEnumerable<string> GetDynamicMemberNames(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6050F9C Offset: 0x604CF9C VA: 0x6050F9C
	|-DynamicProxy<object>.GetDynamicMemberNames
	|
	|-RVA: 0x6051150 Offset: 0x604D150 VA: 0x6051150
	|-DynamicProxy<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051028 Offset: 0x604D028 VA: 0x6051028
	|-DynamicProxy<object>.TryBinaryOperation
	|
	|-RVA: 0x60511DC Offset: 0x604D1DC VA: 0x60511DC
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual bool TryConvert(T instance, ConvertBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051048 Offset: 0x604D048 VA: 0x6051048
	|-DynamicProxy<object>.TryConvert
	|
	|-RVA: 0x60511FC Offset: 0x604D1FC VA: 0x60511FC
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryConvert
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051068 Offset: 0x604D068 VA: 0x6051068
	|-DynamicProxy<object>.TryCreateInstance
	|
	|-RVA: 0x605121C Offset: 0x604D21C VA: 0x605121C
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051088 Offset: 0x604D088 VA: 0x6051088
	|-DynamicProxy<object>.TryDeleteIndex
	|
	|-RVA: 0x605123C Offset: 0x604D23C VA: 0x605123C
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051090 Offset: 0x604D090 VA: 0x6051090
	|-DynamicProxy<object>.TryDeleteMember
	|
	|-RVA: 0x6051244 Offset: 0x604D244 VA: 0x6051244
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051098 Offset: 0x604D098 VA: 0x6051098
	|-DynamicProxy<object>.TryGetIndex
	|
	|-RVA: 0x605124C Offset: 0x604D24C VA: 0x605124C
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60510B8 Offset: 0x604D0B8 VA: 0x60510B8
	|-DynamicProxy<object>.TryGetMember
	|
	|-RVA: 0x605126C Offset: 0x604D26C VA: 0x605126C
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60510D8 Offset: 0x604D0D8 VA: 0x60510D8
	|-DynamicProxy<object>.TryInvoke
	|
	|-RVA: 0x605128C Offset: 0x604D28C VA: 0x605128C
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60510F8 Offset: 0x604D0F8 VA: 0x60510F8
	|-DynamicProxy<object>.TryInvokeMember
	|
	|-RVA: 0x60512AC Offset: 0x604D2AC VA: 0x60512AC
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051118 Offset: 0x604D118 VA: 0x6051118
	|-DynamicProxy<object>.TrySetIndex
	|
	|-RVA: 0x60512CC Offset: 0x604D2CC VA: 0x60512CC
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051120 Offset: 0x604D120 VA: 0x6051120
	|-DynamicProxy<object>.TrySetMember
	|
	|-RVA: 0x60512D4 Offset: 0x604D2D4 VA: 0x60512D4
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetMember
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051128 Offset: 0x604D128 VA: 0x6051128
	|-DynamicProxy<object>.TryUnaryOperation
	|
	|-RVA: 0x60512DC Offset: 0x604D2DC VA: 0x60512DC
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryUnaryOperation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051148 Offset: 0x604D148 VA: 0x6051148
	|-DynamicProxy<object>..ctor
	|
	|-RVA: 0x60512FC Offset: 0x604D2FC VA: 0x60512FC
	|-DynamicProxy<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[NullableContext(0)]
private sealed class DynamicProxyMetaObject.Fallback<T> : MulticastDelegate // TypeDefIndex: 19435
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A1E8 Offset: 0x63361E8 VA: 0x633A1E8
	|-DynamicProxyMetaObject.Fallback<object>..ctor
	|
	|-RVA: 0x633A304 Offset: 0x6336304 VA: 0x633A304
	|-DynamicProxyMetaObject.Fallback<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A2F0 Offset: 0x63362F0 VA: 0x633A2F0
	|-DynamicProxyMetaObject.Fallback<object>.Invoke
	|
	|-RVA: 0x633A40C Offset: 0x633640C VA: 0x633A40C
	|-DynamicProxyMetaObject.Fallback<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
[Nullable(0)]
private sealed class DynamicProxyMetaObject.GetBinderAdapter<T> : GetMemberBinder // TypeDefIndex: 19436
{
	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(InvokeMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B998 Offset: 0x4907998 VA: 0x490B998
	|-DynamicProxyMetaObject.GetBinderAdapter<object>..ctor
	|
	|-RVA: 0x490B9F0 Offset: 0x49079F0 VA: 0x490B9F0
	|-DynamicProxyMetaObject.GetBinderAdapter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B9BC Offset: 0x49079BC VA: 0x490B9BC
	|-DynamicProxyMetaObject.GetBinderAdapter<object>.FallbackGetMember
	|
	|-RVA: 0x490BA14 Offset: 0x4907A14 VA: 0x490BA14
	|-DynamicProxyMetaObject.GetBinderAdapter<__Il2CppFullySharedGenericType>.FallbackGetMember
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DynamicProxyMetaObject.<>c<T> // TypeDefIndex: 19437
{
	// Fields
	[Nullable(0)]
	public static readonly DynamicProxyMetaObject.<>c<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<DynamicMetaObject, Expression> <>9__18_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823684 Offset: 0x481F684 VA: 0x4823684
	|-DynamicProxyMetaObject.<>c<object>..cctor
	|
	|-RVA: 0x4827D1C Offset: 0x4823D1C VA: 0x4827D1C
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823740 Offset: 0x481F740 VA: 0x4823740
	|-DynamicProxyMetaObject.<>c<object>..ctor
	|
	|-RVA: 0x4827E10 Offset: 0x4823E10 VA: 0x4827E10
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal Expression <GetArgs>b__18_0(DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823748 Offset: 0x481F748 VA: 0x4823748
	|-DynamicProxyMetaObject.<>c<object>.<GetArgs>b__18_0
	|
	|-RVA: 0x4827E18 Offset: 0x4823E18 VA: 0x4827E18
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>.<GetArgs>b__18_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass10_0<T> // TypeDefIndex: 19438
{
	// Fields
	[Nullable(0)]
	public BinaryOperationBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(0)]
	public DynamicMetaObject arg; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4864810 Offset: 0x4860810 VA: 0x4864810
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<object>..ctor
	|
	|-RVA: 0x4864844 Offset: 0x4860844 VA: 0x4864844
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4864818 Offset: 0x4860818 VA: 0x4864818
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<object>.<BindBinaryOperation>b__0
	|
	|-RVA: 0x486484C Offset: 0x486084C VA: 0x486484C
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType>.<BindBinaryOperation>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass11_0<T> // TypeDefIndex: 19439
{
	// Fields
	[Nullable(0)]
	public UnaryOperationBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4865F20 Offset: 0x4861F20 VA: 0x4865F20
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<object>..ctor
	|
	|-RVA: 0x4866288 Offset: 0x4862288 VA: 0x4866288
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindUnaryOperation>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4865F28 Offset: 0x4861F28 VA: 0x4865F28
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<object>.<BindUnaryOperation>b__0
	|
	|-RVA: 0x4866290 Offset: 0x4862290 VA: 0x4866290
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>.<BindUnaryOperation>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass12_0<T> // TypeDefIndex: 19440
{
	// Fields
	[Nullable(0)]
	public GetIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48668BC Offset: 0x48628BC VA: 0x48668BC
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<object>..ctor
	|
	|-RVA: 0x48668F0 Offset: 0x48628F0 VA: 0x48668F0
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindGetIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48668C4 Offset: 0x48628C4 VA: 0x48668C4
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<object>.<BindGetIndex>b__0
	|
	|-RVA: 0x48668F8 Offset: 0x48628F8 VA: 0x48668F8
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>.<BindGetIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass13_0<T> // TypeDefIndex: 19441
{
	// Fields
	[Nullable(0)]
	public SetIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0
	[Nullable(0)]
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866BA4 Offset: 0x4862BA4 VA: 0x4866BA4
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<object>..ctor
	|
	|-RVA: 0x4866BDC Offset: 0x4862BDC VA: 0x4866BDC
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindSetIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866BAC Offset: 0x4862BAC VA: 0x4866BAC
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<object>.<BindSetIndex>b__0
	|
	|-RVA: 0x4866BE4 Offset: 0x4862BE4 VA: 0x4866BE4
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType>.<BindSetIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass14_0<T> // TypeDefIndex: 19442
{
	// Fields
	[Nullable(0)]
	public DeleteIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866EC0 Offset: 0x4862EC0 VA: 0x4866EC0
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<object>..ctor
	|
	|-RVA: 0x4866EF4 Offset: 0x4862EF4 VA: 0x4866EF4
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866EC8 Offset: 0x4862EC8 VA: 0x4866EC8
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<object>.<BindDeleteIndex>b__0
	|
	|-RVA: 0x4866EFC Offset: 0x4862EFC VA: 0x4866EFC
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<BindDeleteIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass3_0<T> // TypeDefIndex: 19443
{
	// Fields
	[Nullable(0)]
	public GetMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4875160 Offset: 0x4871160 VA: 0x4875160
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<object>..ctor
	|
	|-RVA: 0x4875194 Offset: 0x4871194 VA: 0x4875194
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindGetMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4875168 Offset: 0x4871168 VA: 0x4875168
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<object>.<BindGetMember>b__0
	|
	|-RVA: 0x487519C Offset: 0x487119C VA: 0x487519C
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>.<BindGetMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass4_0<T> // TypeDefIndex: 19444
{
	// Fields
	[Nullable(0)]
	public SetMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(0)]
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459568 Offset: 0x5455568 VA: 0x5459568
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<object>..ctor
	|
	|-RVA: 0x545959C Offset: 0x545559C VA: 0x545959C
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459570 Offset: 0x5455570 VA: 0x5459570
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<object>.<BindSetMember>b__0
	|
	|-RVA: 0x54595A4 Offset: 0x54555A4 VA: 0x54595A4
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<BindSetMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass5_0<T> // TypeDefIndex: 19445
{
	// Fields
	[Nullable(0)]
	public DeleteMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545ADD0 Offset: 0x5456DD0 VA: 0x545ADD0
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<object>..ctor
	|
	|-RVA: 0x545AE04 Offset: 0x5456E04 VA: 0x545AE04
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545ADD8 Offset: 0x5456DD8 VA: 0x545ADD8
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<object>.<BindDeleteMember>b__0
	|
	|-RVA: 0x545AE0C Offset: 0x5456E0C VA: 0x545AE0C
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<BindDeleteMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass6_0<T> // TypeDefIndex: 19446
{
	// Fields
	[Nullable(0)]
	public ConvertBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545C134 Offset: 0x5458134 VA: 0x545C134
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x545C168 Offset: 0x5458168 VA: 0x545C168
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindConvert>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545C13C Offset: 0x545813C VA: 0x545C13C
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<object>.<BindConvert>b__0
	|
	|-RVA: 0x545C170 Offset: 0x5458170 VA: 0x545C170
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<BindConvert>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass7_0<T> // TypeDefIndex: 19447
{
	// Fields
	[Nullable(0)]
	public InvokeMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EC80 Offset: 0x545AC80 VA: 0x545EC80
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>..ctor
	|
	|-RVA: 0x545EDB4 Offset: 0x545ADB4 VA: 0x545EDB4
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545EC88 Offset: 0x545AC88 VA: 0x545EC88
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>.<BindInvokeMember>b__0
	|
	|-RVA: 0x545EDBC Offset: 0x545ADBC VA: 0x545EDBC
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<BindInvokeMember>b__0
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvokeMember>b__1(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545ECB4 Offset: 0x545ACB4 VA: 0x545ECB4
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>.<BindInvokeMember>b__1
	|
	|-RVA: 0x545EDE8 Offset: 0x545ADE8 VA: 0x545EDE8
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<BindInvokeMember>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass8_0<T> // TypeDefIndex: 19448
{
	// Fields
	[Nullable(0)]
	public CreateInstanceBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469728 Offset: 0x5465728 VA: 0x5469728
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<object>..ctor
	|
	|-RVA: 0x546975C Offset: 0x546575C VA: 0x546975C
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindCreateInstance>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469730 Offset: 0x5465730 VA: 0x5469730
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<object>.<BindCreateInstance>b__0
	|
	|-RVA: 0x5469764 Offset: 0x5465764 VA: 0x5469764
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>.<BindCreateInstance>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass9_0<T> // TypeDefIndex: 19449
{
	// Fields
	[Nullable(0)]
	public InvokeBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B080 Offset: 0x5467080 VA: 0x546B080
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<object>..ctor
	|
	|-RVA: 0x546B0B4 Offset: 0x54670B4 VA: 0x546B0B4
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B088 Offset: 0x5467088 VA: 0x546B088
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<object>.<BindInvoke>b__0
	|
	|-RVA: 0x546B0BC Offset: 0x54670BC VA: 0x546B0BC
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<BindInvoke>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 19450
{
	// Fields
	private readonly DynamicProxy<T> _proxy; // 0x0

	// Properties
	private static Expression[] NoArgs { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression expression, T value, DynamicProxy<T> proxy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B260 Offset: 0x6047260 VA: 0x604B260
	|-DynamicProxyMetaObject<object>..ctor
	|
	|-RVA: 0x604DF58 Offset: 0x6049F58 VA: 0x604DF58
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsOverridden(string method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B324 Offset: 0x6047324 VA: 0x604B324
	|-DynamicProxyMetaObject<object>.IsOverridden
	|
	|-RVA: 0x604E0C4 Offset: 0x604A0C4 VA: 0x604E0C4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.IsOverridden
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B3F4 Offset: 0x60473F4 VA: 0x604B3F4
	|-DynamicProxyMetaObject<object>.BindGetMember
	|
	|-RVA: 0x604E194 Offset: 0x604A194 VA: 0x604E194
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B55C Offset: 0x604755C VA: 0x604B55C
	|-DynamicProxyMetaObject<object>.BindSetMember
	|
	|-RVA: 0x604E31C Offset: 0x604A31C VA: 0x604E31C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B758 Offset: 0x6047758 VA: 0x604B758
	|-DynamicProxyMetaObject<object>.BindDeleteMember
	|
	|-RVA: 0x604E52C Offset: 0x604A52C VA: 0x604E52C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604B8BC Offset: 0x60478BC VA: 0x604B8BC
	|-DynamicProxyMetaObject<object>.BindConvert
	|
	|-RVA: 0x604E6B0 Offset: 0x604A6B0 VA: 0x604E6B0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindConvert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604BA24 Offset: 0x6047A24 VA: 0x604BA24
	|-DynamicProxyMetaObject<object>.BindInvokeMember
	|
	|-RVA: 0x604E838 Offset: 0x604A838 VA: 0x604E838
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604BCAC Offset: 0x6047CAC VA: 0x604BCAC
	|-DynamicProxyMetaObject<object>.BindCreateInstance
	|
	|-RVA: 0x604EAF8 Offset: 0x604AAF8 VA: 0x604EAF8
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604BE40 Offset: 0x6047E40 VA: 0x604BE40
	|-DynamicProxyMetaObject<object>.BindInvoke
	|
	|-RVA: 0x604ECA0 Offset: 0x604ACA0 VA: 0x604ECA0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604BFD4 Offset: 0x6047FD4 VA: 0x604BFD4
	|-DynamicProxyMetaObject<object>.BindBinaryOperation
	|
	|-RVA: 0x604EE48 Offset: 0x604AE48 VA: 0x604EE48
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C1D4 Offset: 0x60481D4 VA: 0x604C1D4
	|-DynamicProxyMetaObject<object>.BindUnaryOperation
	|
	|-RVA: 0x604F05C Offset: 0x604B05C VA: 0x604F05C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindUnaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C33C Offset: 0x604833C VA: 0x604C33C
	|-DynamicProxyMetaObject<object>.BindGetIndex
	|
	|-RVA: 0x604F1E4 Offset: 0x604B1E4 VA: 0x604F1E4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C4D0 Offset: 0x60484D0 VA: 0x604C4D0
	|-DynamicProxyMetaObject<object>.BindSetIndex
	|
	|-RVA: 0x604F38C Offset: 0x604B38C VA: 0x604F38C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C68C Offset: 0x604868C VA: 0x604C68C
	|-DynamicProxyMetaObject<object>.BindDeleteIndex
	|
	|-RVA: 0x604F55C Offset: 0x604B55C VA: 0x604F55C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteIndex
	*/

	// RVA: -1 Offset: -1
	private static Expression[] get_NoArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C81C Offset: 0x604881C VA: 0x604C81C
	|-DynamicProxyMetaObject<object>.get_NoArgs
	|
	|-RVA: 0x604F700 Offset: 0x604B700 VA: 0x604F700
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.get_NoArgs
	*/

	// RVA: -1 Offset: -1
	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C8A8 Offset: 0x60488A8 VA: 0x604C8A8
	|-DynamicProxyMetaObject<object>.GetArgs
	|
	|-RVA: 0x604F78C Offset: 0x604B78C VA: 0x604F78C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgs
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604CA6C Offset: 0x6048A6C VA: 0x604CA6C
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x604F950 Offset: 0x604B950 VA: 0x604F950
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604CBD4 Offset: 0x6048BD4 VA: 0x604CBD4
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x604FAE8 Offset: 0x604BAE8 VA: 0x604FAE8
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604CDF0 Offset: 0x6048DF0 VA: 0x604CDF0
	|-DynamicProxyMetaObject<object>.Constant
	|
	|-RVA: 0x604FD34 Offset: 0x604BD34 VA: 0x604FD34
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.Constant
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604CE80 Offset: 0x6048E80 VA: 0x604CE80
	|-DynamicProxyMetaObject<object>.CallMethodWithResult
	|
	|-RVA: 0x604FDC4 Offset: 0x604BDC4 VA: 0x604FDC4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604CEFC Offset: 0x6048EFC VA: 0x604CEFC
	|-DynamicProxyMetaObject<object>.BuildCallMethodWithResult
	|
	|-RVA: 0x604FE4C Offset: 0x604BE4C VA: 0x604FE4C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BuildCallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604D4F0 Offset: 0x60494F0 VA: 0x604D4F0
	|-DynamicProxyMetaObject<object>.CallMethodReturnLast
	|
	|-RVA: 0x6050470 Offset: 0x604C470 VA: 0x6050470
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodReturnLast
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604DACC Offset: 0x6049ACC VA: 0x604DACC
	|-DynamicProxyMetaObject<object>.CallMethodNoResult
	|
	|-RVA: 0x6050A74 Offset: 0x604CA74 VA: 0x6050A74
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodNoResult
	*/

	// RVA: -1 Offset: -1
	private BindingRestrictions GetRestrictions() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604DE0C Offset: 0x6049E0C VA: 0x604DE0C
	|-DynamicProxyMetaObject<object>.GetRestrictions
	|
	|-RVA: 0x6050DDC Offset: 0x604CDDC VA: 0x6050DDC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetRestrictions
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604DED4 Offset: 0x6049ED4 VA: 0x604DED4
	|-DynamicProxyMetaObject<object>.GetDynamicMemberNames
	|
	|-RVA: 0x6050EA4 Offset: 0x604CEA4 VA: 0x6050EA4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/
}

// Namespace: 
[Nullable(0)]
internal static class DynamicUtils.BinderWrapper // TypeDefIndex: 19451
{
	// Fields
	[Nullable(2)]
	private static object _getCSharpArgumentInfoArray; // 0x0
	[Nullable(2)]
	private static object _setCSharpArgumentInfoArray; // 0x8
	[Nullable(2)]
	private static MethodCall<object, object> _getMemberCall; // 0x10
	[Nullable(2)]
	private static MethodCall<object, object> _setMemberCall; // 0x18
	private static bool _init; // 0x20

	// Methods

	// RVA: 0x7C9BEC0 Offset: 0x7C97EC0 VA: 0x7C9BEC0
	private static void Init() { }

	// RVA: 0x7C9C0B4 Offset: 0x7C980B4 VA: 0x7C9C0B4
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0x7C9C3B0 Offset: 0x7C983B0 VA: 0x7C9C3B0
	private static void CreateMemberCalls() { }

	// RVA: 0x7C9C904 Offset: 0x7C98904 VA: 0x7C9C904
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0x7C9CB08 Offset: 0x7C98B08 VA: 0x7C9CB08
	public static CallSiteBinder SetMember(string name, Type context) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class DynamicUtils // TypeDefIndex: 19452
{
	// Methods

	[Extension]
	// RVA: 0x7C9BDD8 Offset: 0x7C97DD8 VA: 0x7C9BDD8
	public static IEnumerable<string> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class NoThrowGetBinderMember : GetMemberBinder // TypeDefIndex: 19453
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x7C9CD0C Offset: 0x7C98D0C VA: 0x7C9CD0C
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0x7C9CD4C Offset: 0x7C98D4C VA: 0x7C9CD4C Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowSetBinderMember : SetMemberBinder // TypeDefIndex: 19454
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x7C9CE9C Offset: 0x7C98E9C VA: 0x7C9CE9C
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0x7C9CEDC Offset: 0x7C98EDC VA: 0x7C9CEDC Slot: 9
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class NoThrowExpressionVisitor : ExpressionVisitor // TypeDefIndex: 19455
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0x7C9D030 Offset: 0x7C99030 VA: 0x7C9D030 Slot: 7
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x7C9CE94 Offset: 0x7C98E94 VA: 0x7C9CE94
	public void .ctor() { }

	// RVA: 0x7C9D11C Offset: 0x7C9911C VA: 0x7C9D11C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class EnumInfo // TypeDefIndex: 19456
{
	// Fields
	public readonly bool IsFlags; // 0x10
	public readonly ulong[] Values; // 0x18
	public readonly string[] Names; // 0x20
	public readonly string[] ResolvedNames; // 0x28

	// Methods

	// RVA: 0x7C9D198 Offset: 0x7C99198 VA: 0x7C9D198
	public void .ctor(bool isFlags, ulong[] values, string[] names, string[] resolvedNames) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumUtils.<>c // TypeDefIndex: 19457
{
	// Fields
	[Nullable(0)]
	public static readonly EnumUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<EnumMemberAttribute, string> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x7C9E7FC Offset: 0x7C9A7FC VA: 0x7C9E7FC
	private static void .cctor() { }

	// RVA: 0x7C9E864 Offset: 0x7C9A864 VA: 0x7C9E864
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7C9E86C Offset: 0x7C9A86C VA: 0x7C9E86C
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal static class EnumUtils // TypeDefIndex: 19458
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 2, 1 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0x7C9D200 Offset: 0x7C99200 VA: 0x7C9D200
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	// RVA: 0x7C9DA24 Offset: 0x7C99A24 VA: 0x7C9DA24
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0x7C9DBC4 Offset: 0x7C99BC4 VA: 0x7C9DBC4
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	// RVA: 0x7C8BEA4 Offset: 0x7C87EA4 VA: 0x7C8BEA4
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0x7C9D6F8 Offset: 0x7C996F8 VA: 0x7C9D6F8
	private static ulong ToUInt64(object value) { }

	// RVA: 0x7C9DD5C Offset: 0x7C99D5C VA: 0x7C9DD5C
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0x7C9E5F4 Offset: 0x7C9A5F4 VA: 0x7C9E5F4
	private static Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x7C9E504 Offset: 0x7C9A504 VA: 0x7C9E504
	private static Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x7C9E6D8 Offset: 0x7C9A6D8 VA: 0x7C9E6D8
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal class FSharpFunction // TypeDefIndex: 19459
{
	// Fields
	private readonly object _instance; // 0x10
	[Nullable(new[] { 1, 2, 1 })]
	private readonly MethodCall<object, object> _invoker; // 0x18

	// Methods

	// RVA: 0x7C9E884 Offset: 0x7C9A884 VA: 0x7C9E884
	public void .ctor(object instance, MethodCall<object, object> invoker) { }

	[NullableContext(1)]
	// RVA: 0x7C9E8C8 Offset: 0x7C9A8C8 VA: 0x7C9E8C8
	public object Invoke(object[] args) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FSharpUtils.<>c__55<TKey, TValue> // TypeDefIndex: 19460
{
	// Fields
	[Nullable(0)]
	public static readonly FSharpUtils.<>c__55<TKey, TValue> <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>> <>9__55_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B518 Offset: 0x4857518 VA: 0x485B518
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B60C Offset: 0x485760C VA: 0x485B60C
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal Tuple<TKey, TValue> <BuildMapCreator>b__55_1(KeyValuePair<TKey, TValue> kv) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B614 Offset: 0x4857614 VA: 0x485B614
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<BuildMapCreator>b__55_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FSharpUtils.<>c__DisplayClass52_0 // TypeDefIndex: 19461
{
	// Fields
	[Nullable(new[] { 0, 2, 2 })]
	public MethodCall<object, object> call; // 0x10
	[Nullable(new[] { 0, 2, 1 })]
	public MethodCall<object, object> invoke; // 0x18

	// Methods

	// RVA: 0x7C9F318 Offset: 0x7C9B318 VA: 0x7C9F318
	public void .ctor() { }

	// RVA: 0x7C9F664 Offset: 0x7C9B664 VA: 0x7C9F664
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FSharpUtils.<>c__DisplayClass55_0<TKey, TValue> // TypeDefIndex: 19462
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public ObjectConstructor<object> ctorDelegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545AB6C Offset: 0x5456B6C VA: 0x545AB6C
	|-FSharpUtils.<>c__DisplayClass55_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <BuildMapCreator>b__0(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545AB74 Offset: 0x5456B74 VA: 0x545AB74
	|-FSharpUtils.<>c__DisplayClass55_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<BuildMapCreator>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class FSharpUtils // TypeDefIndex: 19463
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <IsUnion>k__BackingField; // 0x28
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCases>k__BackingField; // 0x30
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionReader>k__BackingField; // 0x40
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField; // 0x68

	// Properties
	public static FSharpUtils Instance { get; }
	private Assembly FSharpCoreAssembly { set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> IsUnion { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> GetUnionCases { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionTagReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionConstructor { get; set; }
	public Func<object, object> GetUnionCaseInfoDeclaringType { get; set; }
	public Func<object, object> GetUnionCaseInfoName { get; set; }
	public Func<object, object> GetUnionCaseInfoTag { get; set; }
	[Nullable(new[] { 1, 1, 2 })]
	public MethodCall<object, object> GetUnionCaseInfoFields { get; set; }

	// Methods

	// RVA: 0x7C9E8F4 Offset: 0x7C9A8F4 VA: 0x7C9E8F4
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0x7C9F0C0 Offset: 0x7C9B0C0 VA: 0x7C9F0C0
	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x7C9F118 Offset: 0x7C9B118 VA: 0x7C9F118
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F120 Offset: 0x7C9B120 VA: 0x7C9F120
	public MethodCall<object, object> get_IsUnion() { }

	[CompilerGenerated]
	// RVA: 0x7C9F128 Offset: 0x7C9B128 VA: 0x7C9F128
	private void set_IsUnion(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F130 Offset: 0x7C9B130 VA: 0x7C9F130
	public MethodCall<object, object> get_GetUnionCases() { }

	[CompilerGenerated]
	// RVA: 0x7C9F138 Offset: 0x7C9B138 VA: 0x7C9F138
	private void set_GetUnionCases(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F140 Offset: 0x7C9B140 VA: 0x7C9F140
	public MethodCall<object, object> get_PreComputeUnionTagReader() { }

	[CompilerGenerated]
	// RVA: 0x7C9F148 Offset: 0x7C9B148 VA: 0x7C9F148
	private void set_PreComputeUnionTagReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F150 Offset: 0x7C9B150 VA: 0x7C9F150
	public MethodCall<object, object> get_PreComputeUnionReader() { }

	[CompilerGenerated]
	// RVA: 0x7C9F158 Offset: 0x7C9B158 VA: 0x7C9F158
	private void set_PreComputeUnionReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F160 Offset: 0x7C9B160 VA: 0x7C9F160
	public MethodCall<object, object> get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	// RVA: 0x7C9F168 Offset: 0x7C9B168 VA: 0x7C9F168
	private void set_PreComputeUnionConstructor(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F170 Offset: 0x7C9B170 VA: 0x7C9F170
	public Func<object, object> get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x7C9F178 Offset: 0x7C9B178 VA: 0x7C9F178
	private void set_GetUnionCaseInfoDeclaringType(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F180 Offset: 0x7C9B180 VA: 0x7C9F180
	public Func<object, object> get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	// RVA: 0x7C9F188 Offset: 0x7C9B188 VA: 0x7C9F188
	private void set_GetUnionCaseInfoName(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F190 Offset: 0x7C9B190 VA: 0x7C9F190
	public Func<object, object> get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	// RVA: 0x7C9F198 Offset: 0x7C9B198 VA: 0x7C9F198
	private void set_GetUnionCaseInfoTag(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7C9F1A0 Offset: 0x7C9B1A0 VA: 0x7C9F1A0
	public MethodCall<object, object> get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	// RVA: 0x7C9F1A8 Offset: 0x7C9B1A8 VA: 0x7C9F1A8
	private void set_GetUnionCaseInfoFields(MethodCall<object, object> value) { }

	// RVA: 0x7C9F1B0 Offset: 0x7C9B1B0 VA: 0x7C9F1B0
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0x7C9EE50 Offset: 0x7C9AE50 VA: 0x7C9EE50
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0x7C9EEC4 Offset: 0x7C9AEC4 VA: 0x7C9EEC4
	private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0x7C9F320 Offset: 0x7C9B320 VA: 0x7C9F320
	public ObjectConstructor<object> CreateSeq(Type t) { }

	// RVA: 0x7C9F428 Offset: 0x7C9B428 VA: 0x7C9F428
	public ObjectConstructor<object> CreateMap(Type keyType, Type valueType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FCCD0 Offset: 0x45F8CD0 VA: 0x45FCCD0
	|-FSharpUtils.BuildMapCreator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7C9F5E8 Offset: 0x7C9B5E8 VA: 0x7C9F5E8
	private static void .cctor() { }
}

// Namespace: 
[Nullable(0)]
internal class ImmutableCollectionsUtils.ImmutableCollectionTypeInfo // TypeDefIndex: 19464
{
	// Fields
	[CompilerGenerated]
	private string <ContractTypeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <CreatedTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <BuilderTypeName>k__BackingField; // 0x20

	// Properties
	public string ContractTypeName { get; set; }
	public string CreatedTypeName { get; set; }
	public string BuilderTypeName { get; set; }

	// Methods

	// RVA: 0x7CA09D4 Offset: 0x7C9C9D4 VA: 0x7CA09D4
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	[CompilerGenerated]
	// RVA: 0x7CA0A34 Offset: 0x7C9CA34 VA: 0x7CA0A34
	public string get_ContractTypeName() { }

	[CompilerGenerated]
	// RVA: 0x7CA0A3C Offset: 0x7C9CA3C VA: 0x7CA0A3C
	public void set_ContractTypeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7CA0A44 Offset: 0x7C9CA44 VA: 0x7CA0A44
	public string get_CreatedTypeName() { }

	[CompilerGenerated]
	// RVA: 0x7CA0A4C Offset: 0x7C9CA4C VA: 0x7CA0A4C
	public void set_CreatedTypeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7CA0A54 Offset: 0x7C9CA54 VA: 0x7CA0A54
	public string get_BuilderTypeName() { }

	[CompilerGenerated]
	// RVA: 0x7CA0A5C Offset: 0x7C9CA5C VA: 0x7CA0A5C
	public void set_BuilderTypeName(string value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ImmutableCollectionsUtils.<>c // TypeDefIndex: 19465
{
	// Fields
	[Nullable(0)]
	public static readonly ImmutableCollectionsUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<MethodInfo, bool> <>9__24_1; // 0x8
	[Nullable(0)]
	public static Func<MethodInfo, bool> <>9__25_1; // 0x10

	// Methods

	// RVA: 0x7CA0A64 Offset: 0x7C9CA64 VA: 0x7CA0A64
	private static void .cctor() { }

	// RVA: 0x7CA0ACC Offset: 0x7C9CACC VA: 0x7CA0ACC
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CA0AD4 Offset: 0x7C9CAD4 VA: 0x7CA0AD4
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	[NullableContext(0)]
	// RVA: 0x7CA0B6C Offset: 0x7C9CB6C VA: 0x7CA0B6C
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableCollectionsUtils.<>c__DisplayClass24_0 // TypeDefIndex: 19466
{
	// Fields
	[Nullable(0)]
	public string name; // 0x10

	// Methods

	// RVA: 0x7C9FBC8 Offset: 0x7C9BBC8 VA: 0x7C9FBC8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CA0CD4 Offset: 0x7C9CCD4 VA: 0x7CA0CD4
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableCollectionsUtils.<>c__DisplayClass25_0 // TypeDefIndex: 19467
{
	// Fields
	[Nullable(0)]
	public string name; // 0x10

	// Methods

	// RVA: 0x7CA0104 Offset: 0x7C9C104 VA: 0x7CA0104
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CA0CF8 Offset: 0x7C9CCF8 VA: 0x7CA0CF8
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ImmutableCollectionsUtils // TypeDefIndex: 19468
{
	// Fields
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0x7C9F700 Offset: 0x7C9B700 VA: 0x7C9F700
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x7C9FBF0 Offset: 0x7C9BBF0 VA: 0x7C9FBF0
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x7CA010C Offset: 0x7C9C10C VA: 0x7CA010C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal static class BufferUtils // TypeDefIndex: 19469
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7CA0D1C Offset: 0x7C9CD1C VA: 0x7CA0D1C
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x7CA0DE4 Offset: 0x7C9CDE4 VA: 0x7CA0DE4
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x7CA0E94 Offset: 0x7C9CE94 VA: 0x7CA0E94
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }
}

// Namespace: 
[CompilerGenerated]
private struct JavaScriptUtils.<WriteCharAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 19470
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public TextWriter writer; // 0x28
	public char c; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7CA36D8 Offset: 0x7C9F6D8 VA: 0x7CA36D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CA39B0 Offset: 0x7C9F9B0 VA: 0x7CA39B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : IAsyncStateMachine // TypeDefIndex: 19471
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public char[] writeBuffer; // 0x20
	public int lastWritePosition; // 0x28
	[Nullable(0)]
	public JsonTextWriter client; // 0x30
	[Nullable(0)]
	public string s; // 0x38
	[Nullable(0)]
	public TextWriter writer; // 0x40
	public CancellationToken cancellationToken; // 0x48
	[Nullable(0)]
	public bool[] charEscapeFlags; // 0x50
	public StringEscapeHandling stringEscapeHandling; // 0x58
	private bool <isEscapedUnicodeText>5__2; // 0x5C
	[Nullable(0)]
	private string <escapedValue>5__3; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x68
	private int <i>5__4; // 0x78

	// Methods

	// RVA: 0x7CA3A18 Offset: 0x7C9FA18 VA: 0x7CA3A18 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CA4558 Offset: 0x7CA0558 VA: 0x7CA4558 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 19472
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public string s; // 0x28
	[Nullable(0)]
	public TextWriter writer; // 0x30
	[Nullable(0)]
	public bool[] charEscapeFlags; // 0x38
	public StringEscapeHandling stringEscapeHandling; // 0x40
	[Nullable(0)]
	public JsonTextWriter client; // 0x48
	[Nullable(0)]
	public char[] writeBuffer; // 0x50
	public CancellationToken cancellationToken; // 0x58
	public char delimiter; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x68

	// Methods

	// RVA: 0x7CA45C0 Offset: 0x7CA05C0 VA: 0x7CA45C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CA49A8 Offset: 0x7CA09A8 VA: 0x7CA49A8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal static class JavaScriptUtils // TypeDefIndex: 19473
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x7CA0FD0 Offset: 0x7C9CFD0 VA: 0x7CA0FD0
	private static void .cctor() { }

	// RVA: 0x7CA1C40 Offset: 0x7C9DC40 VA: 0x7CA1C40
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x7CA1CD8 Offset: 0x7C9DCD8 VA: 0x7CA1CD8
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	[NullableContext(2)]
	// RVA: 0x7CA1D60 Offset: 0x7C9DD60 VA: 0x7CA1D60
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x7CA24C0 Offset: 0x7C9E4C0 VA: 0x7CA24C0
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x7CA2350 Offset: 0x7C9E350 VA: 0x7CA2350
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x7CA27AC Offset: 0x7C9E7AC VA: 0x7CA27AC
	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x7CA2974 Offset: 0x7C9E974 VA: 0x7CA2974
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	// RVA: 0x7CA2C88 Offset: 0x7C9EC88 VA: 0x7CA2C88
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteCharAsync>d__14))]
	// RVA: 0x7CA2E18 Offset: 0x7C9EE18 VA: 0x7CA2E18
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	// RVA: 0x7CA2B60 Offset: 0x7C9EB60 VA: 0x7CA2B60
	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	// RVA: 0x7CA2F38 Offset: 0x7C9EF38 VA: 0x7CA2F38
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x7CA30B0 Offset: 0x7C9F0B0 VA: 0x7CA30B0
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0x7CA3518 Offset: 0x7C9F518 VA: 0x7CA3518
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils // TypeDefIndex: 19474
{
	// Methods

	// RVA: 0x7CA4A10 Offset: 0x7CA0A10 VA: 0x7CA4A10
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x7CA4A20 Offset: 0x7CA0A20 VA: 0x7CA4A20
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x7CA4A30 Offset: 0x7CA0A30 VA: 0x7CA4A30
	internal static bool IsPrimitiveToken(JsonToken token) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 19475
{
	// Fields
	[Nullable(0)]
	public ConstructorInfo c; // 0x10
	[Nullable(0)]
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0x7CA4C50 Offset: 0x7CA0C50 VA: 0x7CA4C50
	public void .ctor() { }

	// RVA: 0x7CA4D1C Offset: 0x7CA0D1C VA: 0x7CA4D1C
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0x7CA4D38 Offset: 0x7CA0D38 VA: 0x7CA4D38
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 19476
{
	// Fields
	[Nullable(0)]
	public ConstructorInfo c; // 0x0
	[Nullable(0)]
	public MethodBase method; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459F98 Offset: 0x5455F98 VA: 0x5459F98
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	|
	|-RVA: 0x545A298 Offset: 0x5456298 VA: 0x545A298
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459FA0 Offset: 0x5455FA0 VA: 0x5459FA0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	|
	|-RVA: 0x545A2A0 Offset: 0x54562A0 VA: 0x545A2A0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateMethodCall>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459FC0 Offset: 0x5455FC0 VA: 0x5459FC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	|
	|-RVA: 0x545A2C0 Offset: 0x54562C0 VA: 0x545A2C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateMethodCall>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 19477
{
	// Fields
	[Nullable(0)]
	public Type type; // 0x0
	[Nullable(0)]
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545B310 Offset: 0x5457310 VA: 0x545B310
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	|
	|-RVA: 0x545B4F4 Offset: 0x54574F4 VA: 0x545B4F4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545B318 Offset: 0x5457318 VA: 0x545B318
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	|
	|-RVA: 0x545B4FC Offset: 0x54574FC VA: 0x545B4FC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<CreateDefaultConstructor>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545B384 Offset: 0x5457384 VA: 0x545B384
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	|
	|-RVA: 0x545B5C4 Offset: 0x54575C4 VA: 0x545B5C4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<CreateDefaultConstructor>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 19478
{
	// Fields
	[Nullable(0)]
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DA5C Offset: 0x5459A5C VA: 0x545DA5C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x545DFFC Offset: 0x5459FFC VA: 0x545DFFC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DA64 Offset: 0x5459A64 VA: 0x545DA64
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	|
	|-RVA: 0x545E004 Offset: 0x545A004 VA: 0x545E004
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CreateGet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 19479
{
	// Fields
	[Nullable(0)]
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54605A8 Offset: 0x545C5A8 VA: 0x54605A8
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	|
	|-RVA: 0x54605D4 Offset: 0x545C5D4 VA: 0x54605D4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54605B0 Offset: 0x545C5B0 VA: 0x54605B0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	|
	|-RVA: 0x54605DC Offset: 0x545C5DC VA: 0x54605DC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<CreateGet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 19480
{
	// Fields
	[Nullable(0)]
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469790 Offset: 0x5465790 VA: 0x5469790
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	|
	|-RVA: 0x54697B4 Offset: 0x54657B4 VA: 0x54697B4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469798 Offset: 0x5465798 VA: 0x5469798
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	|
	|-RVA: 0x54697BC Offset: 0x54657BC VA: 0x54697BC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>.<CreateSet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 19481
{
	// Fields
	[Nullable(0)]
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B1C8 Offset: 0x54671C8 VA: 0x546B1C8
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	|
	|-RVA: 0x546B3C0 Offset: 0x54673C0 VA: 0x546B3C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B1D0 Offset: 0x54671D0 VA: 0x546B1D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	|
	|-RVA: 0x546B3C8 Offset: 0x54673C8 VA: 0x546B3C8
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<CreateSet>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 19482
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x7CA4A54 Offset: 0x7CA0A54 VA: 0x7CA4A54
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x7CA4AAC Offset: 0x7CA0AAC VA: 0x7CA4AAC Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46554BC Offset: 0x46514BC VA: 0x46554BC
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	|
	|-RVA: 0x4655644 Offset: 0x4651644 VA: 0x4655644
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4654D18 Offset: 0x4650D18 VA: 0x4654D18
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0x4654F2C Offset: 0x4650F2C VA: 0x4654F2C
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4655224 Offset: 0x4651224 VA: 0x4655224
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x46553DC Offset: 0x46513DC VA: 0x46553DC
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x465514C Offset: 0x465114C VA: 0x465514C
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x46552FC Offset: 0x46512FC VA: 0x46552FC
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46557D4 Offset: 0x46517D4 VA: 0x46557D4
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x4655984 Offset: 0x4651984 VA: 0x4655984
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46558AC Offset: 0x46518AC VA: 0x46558AC
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x4655A64 Offset: 0x4651A64 VA: 0x4655A64
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CA4CA4 Offset: 0x7CA0CA4 VA: 0x7CA4CA4
	public void .ctor() { }

	// RVA: 0x7CA4CB4 Offset: 0x7CA0CB4 VA: 0x7CA4CB4
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils // TypeDefIndex: 19483
{
	// Methods

	// RVA: 0x7CA4D5C Offset: 0x7CA0D5C VA: 0x7CA4D5C
	public static int IntLength(ulong i) { }

	// RVA: 0x7CA4F20 Offset: 0x7CA0F20 VA: 0x7CA4F20
	public static char IntToHex(int n) { }

	// RVA: 0x7CA4F38 Offset: 0x7CA0F38 VA: 0x7CA4F38
	public static bool ApproxEquals(double d1, double d2) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 19484
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F2204 Offset: 0x50EE204 VA: 0x50F2204
	|-MethodCall<object, object>..ctor
	|
	|-RVA: 0x50F2324 Offset: 0x50EE324 VA: 0x50F2324
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F2310 Offset: 0x50EE310 VA: 0x50F2310
	|-MethodCall<object, object>.Invoke
	|
	|-RVA: 0x50F2430 Offset: 0x50EE430 VA: 0x50F2430
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class MiscellaneousUtils // TypeDefIndex: 19485
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x7CA4FD8 Offset: 0x7CA0FD8 VA: 0x7CA4FD8
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0x7CA52F0 Offset: 0x7CA12F0 VA: 0x7CA52F0
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0x7CA549C Offset: 0x7CA149C VA: 0x7CA549C
	public static string ToString(object value) { }

	// RVA: 0x7CA554C Offset: 0x7CA154C VA: 0x7CA554C
	public static int ByteArrayCompare(byte[] a1, byte[] a2) { }

	// RVA: 0x7CA55FC Offset: 0x7CA15FC VA: 0x7CA55FC
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0x7CA56DC Offset: 0x7CA16DC VA: 0x7CA56DC
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0x7CA5620 Offset: 0x7CA1620 VA: 0x7CA5620
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	// RVA: 0x7CA5714 Offset: 0x7CA1714 VA: 0x7CA5714
	internal static RegexOptions GetRegexOptions(string optionsText) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal abstract class ReflectionDelegateFactory // TypeDefIndex: 19486
{
	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B9B4C Offset: 0x46B5B4C VA: 0x46B9B4C
	|-ReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x46B9D24 Offset: 0x46B5D24 VA: 0x46B9D24
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B9EFC Offset: 0x46B5EFC VA: 0x46B9EFC
	|-ReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x46BA050 Offset: 0x46B6050 VA: 0x46BA050
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CA4CAC Offset: 0x7CA0CAC VA: 0x7CA4CAC
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(2)]
internal class ReflectionMember // TypeDefIndex: 19487
{
	// Fields
	[CompilerGenerated]
	private Type <MemberType>k__BackingField; // 0x10
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Func<object, object> <Getter>k__BackingField; // 0x18
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 2 })]
	private Action<object, object> <Setter>k__BackingField; // 0x20

	// Properties
	public Type MemberType { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Func<object, object> Getter { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> Setter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CA57BC Offset: 0x7CA17BC VA: 0x7CA57BC
	public Type get_MemberType() { }

	[CompilerGenerated]
	// RVA: 0x7CA57C4 Offset: 0x7CA17C4 VA: 0x7CA57C4
	public void set_MemberType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7CA57CC Offset: 0x7CA17CC VA: 0x7CA57CC
	public Func<object, object> get_Getter() { }

	[CompilerGenerated]
	// RVA: 0x7CA57D4 Offset: 0x7CA17D4 VA: 0x7CA57D4
	public void set_Getter(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CA57DC Offset: 0x7CA17DC VA: 0x7CA57DC
	public Action<object, object> get_Setter() { }

	[CompilerGenerated]
	// RVA: 0x7CA57E4 Offset: 0x7CA17E4 VA: 0x7CA57E4
	public void set_Setter(Action<object, object> value) { }

	// RVA: 0x7CA57EC Offset: 0x7CA17EC VA: 0x7CA57EC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_0 // TypeDefIndex: 19488
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public Func<object> ctor; // 0x10

	// Methods

	// RVA: 0x7CA6474 Offset: 0x7CA2474 VA: 0x7CA6474
	public void .ctor() { }

	// RVA: 0x7CA6A58 Offset: 0x7CA2A58 VA: 0x7CA6A58
	internal object <Create>b__0(object[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_1 // TypeDefIndex: 19489
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x7CA6768 Offset: 0x7CA2768 VA: 0x7CA6768
	public void .ctor() { }

	// RVA: 0x7CA6A7C Offset: 0x7CA2A7C VA: 0x7CA6A7C
	internal object <Create>b__1(object target) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_2 // TypeDefIndex: 19490
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x7CA6770 Offset: 0x7CA2770 VA: 0x7CA6770
	public void .ctor() { }

	// RVA: 0x7CA6B34 Offset: 0x7CA2B34 VA: 0x7CA6B34
	internal void <Create>b__2(object target, object arg) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ReflectionObject // TypeDefIndex: 19491
{
	// Fields
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private readonly ObjectConstructor<object> <Creator>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> Creator { get; }
	public IDictionary<string, ReflectionMember> Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CA57F4 Offset: 0x7CA17F4 VA: 0x7CA57F4
	public ObjectConstructor<object> get_Creator() { }

	[CompilerGenerated]
	// RVA: 0x7CA57FC Offset: 0x7CA17FC VA: 0x7CA57FC
	public IDictionary<string, ReflectionMember> get_Members() { }

	// RVA: 0x7CA5804 Offset: 0x7CA1804 VA: 0x7CA5804
	private void .ctor(ObjectConstructor<object> creator) { }

	// RVA: 0x7CA58A0 Offset: 0x7CA18A0 VA: 0x7CA58A0
	public object GetValue(object target, string member) { }

	// RVA: 0x7CA5974 Offset: 0x7CA1974 VA: 0x7CA5974
	public void SetValue(object target, string member, object value) { }

	// RVA: 0x7CA5A50 Offset: 0x7CA1A50 VA: 0x7CA5A50
	public Type GetType(string member) { }

	// RVA: 0x7CA5B04 Offset: 0x7CA1B04 VA: 0x7CA5B04
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0x7CA5B10 Offset: 0x7CA1B10 VA: 0x7CA5B10
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectionUtils.<>c // TypeDefIndex: 19492
{
	// Fields
	[Nullable(0)]
	public static readonly ReflectionUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<ConstructorInfo, bool> <>9__11_0; // 0x8
	[Nullable(0)]
	public static Func<MemberInfo, string> <>9__31_0; // 0x10
	[Nullable(0)]
	public static Func<ParameterInfo, Type> <>9__39_0; // 0x18
	[Nullable(0)]
	public static Func<FieldInfo, bool> <>9__41_0; // 0x20

	// Methods

	// RVA: 0x7CAAF48 Offset: 0x7CA6F48 VA: 0x7CAAF48
	private static void .cctor() { }

	// RVA: 0x7CAAFB0 Offset: 0x7CA6FB0 VA: 0x7CAAFB0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CAAFB8 Offset: 0x7CA6FB8 VA: 0x7CAAFB8
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	[NullableContext(0)]
	// RVA: 0x7CAB024 Offset: 0x7CA7024 VA: 0x7CAB024
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x7CAB04C Offset: 0x7CA704C VA: 0x7CAB04C
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	[NullableContext(0)]
	// RVA: 0x7CAB074 Offset: 0x7CA7074 VA: 0x7CAB074
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass31_0 // TypeDefIndex: 19493
{
	// Fields
	[Nullable(0)]
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0x7CA9C2C Offset: 0x7CA5C2C VA: 0x7CA9C2C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CAB08C Offset: 0x7CA708C VA: 0x7CAB08C
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass44_0 // TypeDefIndex: 19494
{
	// Fields
	[Nullable(0)]
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x7CAABD8 Offset: 0x7CA6BD8 VA: 0x7CAABD8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CAB130 Offset: 0x7CA7130 VA: 0x7CAB130
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	[NullableContext(0)]
	// RVA: 0x7CAB18C Offset: 0x7CA718C VA: 0x7CAB18C
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass44_1 // TypeDefIndex: 19495
{
	// Fields
	[Nullable(0)]
	public Type subTypePropertyDeclaringType; // 0x10
	[Nullable(0)]
	public ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7CAABE0 Offset: 0x7CA6BE0 VA: 0x7CAABE0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CAB288 Offset: 0x7CA7288 VA: 0x7CAB288
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass45_0 // TypeDefIndex: 19496
{
	// Fields
	[Nullable(0)]
	public string method; // 0x10
	[Nullable(0)]
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0x7CAACFC Offset: 0x7CA6CFC VA: 0x7CAACFC
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CAB3A4 Offset: 0x7CA73A4 VA: 0x7CAB3A4
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class ReflectionUtils // TypeDefIndex: 19497
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0x7CA6BF8 Offset: 0x7CA2BF8 VA: 0x7CA6BF8
	private static void .cctor() { }

	[Extension]
	// RVA: 0x7CA6C78 Offset: 0x7CA2C78 VA: 0x7CA6C78
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x7CA6D58 Offset: 0x7CA2D58 VA: 0x7CA6D58
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x7CA6E1C Offset: 0x7CA2E1C VA: 0x7CA6E1C
	public static bool IsPublic(PropertyInfo property) { }

	[NullableContext(2)]
	// RVA: 0x7CA6EAC Offset: 0x7CA2EAC VA: 0x7CA6EAC
	public static Type GetObjectType(object v) { }

	// RVA: 0x7CA6EBC Offset: 0x7CA2EBC VA: 0x7CA6EBC
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0x7CA6F94 Offset: 0x7CA2F94 VA: 0x7CA6F94
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0x7CA70C4 Offset: 0x7CA30C4 VA: 0x7CA70C4
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x7CA6388 Offset: 0x7CA2388 VA: 0x7CA6388
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x7CA73A0 Offset: 0x7CA33A0 VA: 0x7CA73A0
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x7CA726C Offset: 0x7CA326C VA: 0x7CA726C
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x7CA73F8 Offset: 0x7CA33F8 VA: 0x7CA73F8
	public static bool IsNullable(Type t) { }

	// RVA: 0x7CA7494 Offset: 0x7CA3494 VA: 0x7CA7494
	public static bool IsNullableType(Type t) { }

	// RVA: 0x7CA7580 Offset: 0x7CA3580 VA: 0x7CA7580
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x7CA75F4 Offset: 0x7CA35F4 VA: 0x7CA75F4
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0x7CA7644 Offset: 0x7CA3644 VA: 0x7CA7644
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x7CA76F0 Offset: 0x7CA36F0 VA: 0x7CA76F0
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x7CA7764 Offset: 0x7CA3764 VA: 0x7CA7764
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x7CA7A24 Offset: 0x7CA3A24 VA: 0x7CA7A24
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x7CA7A98 Offset: 0x7CA3A98 VA: 0x7CA7A98
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x7CA7C00 Offset: 0x7CA3C00 VA: 0x7CA7C00
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x7CA7D3C Offset: 0x7CA3D3C VA: 0x7CA7D3C
	public static Type GetCollectionItemType(Type type) { }

	[NullableContext(2)]
	// RVA: 0x7CA7F5C Offset: 0x7CA3F5C VA: 0x7CA7F5C
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x7CA686C Offset: 0x7CA286C VA: 0x7CA686C
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x7CA81AC Offset: 0x7CA41AC VA: 0x7CA81AC
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0x7CA87C4 Offset: 0x7CA47C4 VA: 0x7CA87C4
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x7CA883C Offset: 0x7CA483C VA: 0x7CA883C
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x7CA8B50 Offset: 0x7CA4B50 VA: 0x7CA8B50
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x7CA6498 Offset: 0x7CA2498 VA: 0x7CA6498
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x7CA65E4 Offset: 0x7CA25E4 VA: 0x7CA65E4
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x7CA8D64 Offset: 0x7CA4D64 VA: 0x7CA8D64
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x7CA9C34 Offset: 0x7CA5C34 VA: 0x7CA9C34
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BA5E8 Offset: 0x46B65E8 VA: 0x46BA5E8
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BA650 Offset: 0x46B6650 VA: 0x46BA650
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BA6D8 Offset: 0x46B66D8 VA: 0x46BA6D8
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x7CA82B4 Offset: 0x7CA42B4 VA: 0x7CA82B4
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x7CA9E14 Offset: 0x7CA5E14 VA: 0x7CA9E14
	public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0x7CA9F08 Offset: 0x7CA5F08 VA: 0x7CA9F08
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x7CAA194 Offset: 0x7CA6194 VA: 0x7CAA194
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x7CA980C Offset: 0x7CA580C VA: 0x7CA980C
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x7CAA408 Offset: 0x7CA6408 VA: 0x7CAA408
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x7CA9924 Offset: 0x7CA5924 VA: 0x7CA9924
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[Extension]
	// RVA: 0x7CAA5FC Offset: 0x7CA65FC VA: 0x7CAA5FC
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x7CAA60C Offset: 0x7CA660C VA: 0x7CAA60C
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x7CAABE8 Offset: 0x7CA6BE8 VA: 0x7CAABE8
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0x7CAAD04 Offset: 0x7CA6D04 VA: 0x7CAAD04
	public static object GetDefaultValue(Type type) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal struct StringBuffer // TypeDefIndex: 19498
{
	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x7CAB4C4 Offset: 0x7CA74C4 VA: 0x7CAB4C4
	public int get_Position() { }

	// RVA: 0x7CAB4CC Offset: 0x7CA74CC VA: 0x7CAB4CC
	public void set_Position(int value) { }

	// RVA: 0x7CAB4D4 Offset: 0x7CA74D4 VA: 0x7CAB4D4
	public bool get_IsEmpty() { }

	// RVA: 0x7CAB4E4 Offset: 0x7CA74E4 VA: 0x7CAB4E4
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	// RVA: 0x7CAB514 Offset: 0x7CA7514 VA: 0x7CAB514
	private void .ctor(char[] buffer) { }

	// RVA: 0x7CAB530 Offset: 0x7CA7530 VA: 0x7CAB530
	public void Append(IArrayPool<char> bufferPool, char value) { }

	[NullableContext(1)]
	// RVA: 0x7CAB610 Offset: 0x7CA7610 VA: 0x7CAB610
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x7CAB690 Offset: 0x7CA7690 VA: 0x7CAB690
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x7CAB5A8 Offset: 0x7CA75A8 VA: 0x7CAB5A8
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	[NullableContext(1)]
	// RVA: 0x7CAB6C8 Offset: 0x7CA76C8 VA: 0x7CAB6C8 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x7CAB6E0 Offset: 0x7CA76E0 VA: 0x7CAB6E0
	public string ToString(int start, int length) { }

	// RVA: 0x7CAB6FC Offset: 0x7CA76FC VA: 0x7CAB6FC
	public char[] get_InternalBuffer() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
internal struct StringReference // TypeDefIndex: 19499
{
	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x7CAB704 Offset: 0x7CA7704 VA: 0x7CAB704
	public char get_Item(int i) { }

	// RVA: 0x7CAB734 Offset: 0x7CA7734 VA: 0x7CAB734
	public char[] get_Chars() { }

	// RVA: 0x7CAB73C Offset: 0x7CA773C VA: 0x7CAB73C
	public int get_StartIndex() { }

	// RVA: 0x7CAB744 Offset: 0x7CA7744 VA: 0x7CAB744
	public int get_Length() { }

	// RVA: 0x7CAB74C Offset: 0x7CA774C VA: 0x7CAB74C
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x7CAB778 Offset: 0x7CA7778 VA: 0x7CAB778 Slot: 3
	public override string ToString() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringReferenceExtensions // TypeDefIndex: 19500
{
	// Methods

	[Extension]
	// RVA: 0x7CAB78C Offset: 0x7CA778C VA: 0x7CAB78C
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[Extension]
	// RVA: 0x7CAB810 Offset: 0x7CA7810 VA: 0x7CAB810
	public static bool StartsWith(StringReference s, string text) { }

	[Extension]
	// RVA: 0x7CAB8D0 Offset: 0x7CA78D0 VA: 0x7CAB8D0
	public static bool EndsWith(StringReference s, string text) { }
}

// Namespace: 
[NullableContext(0)]
private enum StringUtils.SeparatedCaseState // TypeDefIndex: 19501
{
	// Fields
	public int value__; // 0x0
	public const StringUtils.SeparatedCaseState Start = 0;
	public const StringUtils.SeparatedCaseState Lower = 1;
	public const StringUtils.SeparatedCaseState Upper = 2;
	public const StringUtils.SeparatedCaseState NewWord = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class StringUtils.<>c__DisplayClass14_0<TSource> // TypeDefIndex: 19502
{
	// Fields
	[Nullable(new[] { 0, 0, 1 })]
	public Func<TSource, string> valueSelector; // 0x0
	[Nullable(0)]
	public string testValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866F28 Offset: 0x4862F28 VA: 0x4866F28
	|-StringUtils.<>c__DisplayClass14_0<object>..ctor
	|
	|-RVA: 0x4866FA0 Offset: 0x4862FA0 VA: 0x4866FA0
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866F30 Offset: 0x4862F30 VA: 0x4866F30
	|-StringUtils.<>c__DisplayClass14_0<object>.<ForgivingCaseSensitiveFind>b__0
	|
	|-RVA: 0x4866FA8 Offset: 0x4862FA8 VA: 0x4866FA8
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<ForgivingCaseSensitiveFind>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866F68 Offset: 0x4862F68 VA: 0x4866F68
	|-StringUtils.<>c__DisplayClass14_0<object>.<ForgivingCaseSensitiveFind>b__1
	|
	|-RVA: 0x4867090 Offset: 0x4863090 VA: 0x4867090
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<ForgivingCaseSensitiveFind>b__1
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
[Extension]
internal static class StringUtils // TypeDefIndex: 19503
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x7CA2348 Offset: 0x7C9E348 VA: 0x7CA2348
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	// RVA: 0x7CA53E8 Offset: 0x7CA13E8 VA: 0x7CA53E8
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	// RVA: 0x7CA6778 Offset: 0x7CA2778 VA: 0x7CA6778
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x7CABA00 Offset: 0x7CA7A00 VA: 0x7CABA00
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x7CABB2C Offset: 0x7CA7B2C VA: 0x7CABB2C
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x7CAB994 Offset: 0x7CA7994 VA: 0x7CAB994
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x7CA26E4 Offset: 0x7C9E6E4 VA: 0x7CA26E4
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x7CA2404 Offset: 0x7C9E404 VA: 0x7CA2404
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4705FC0 Offset: 0x4701FC0 VA: 0x4705FC0
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	|
	|-RVA: 0x4706170 Offset: 0x4702170 VA: 0x4706170
	|-StringUtils.ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CABC98 Offset: 0x7CA7C98 VA: 0x7CABC98
	public static string ToCamelCase(string s) { }

	// RVA: 0x7CABE80 Offset: 0x7CA7E80 VA: 0x7CABE80
	private static char ToLower(char c) { }

	// RVA: 0x7CABF10 Offset: 0x7CA7F10 VA: 0x7CABF10
	public static string ToSnakeCase(string s) { }

	// RVA: 0x7CAC200 Offset: 0x7CA8200 VA: 0x7CAC200
	public static string ToKebabCase(string s) { }

	// RVA: 0x7CABF18 Offset: 0x7CA7F18 VA: 0x7CABF18
	private static string ToSeparatedCase(string s, char separator) { }

	// RVA: 0x7CAC208 Offset: 0x7CA8208 VA: 0x7CAC208
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x7CAC260 Offset: 0x7CA8260 VA: 0x7CAC260
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x7CA5700 Offset: 0x7CA1700 VA: 0x7CA5700
	public static int IndexOf(string s, char c) { }

	[Extension]
	// RVA: 0x7CAC2B8 Offset: 0x7CA82B8 VA: 0x7CAC2B8
	public static bool StartsWith(string source, char value) { }

	[Extension]
	// RVA: 0x7CAC2FC Offset: 0x7CA82FC VA: 0x7CAC2FC
	public static bool EndsWith(string source, char value) { }

	[Extension]
	// RVA: 0x7CA9FE0 Offset: 0x7CA5FE0 VA: 0x7CA9FE0
	public static string Trim(string s, int start, int length) { }
}

// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[IsReadOnly]
[NullableContext(1)]
internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 19504
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 v1, T2 v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x552F0F4 Offset: 0x552B0F4 VA: 0x552F0F4
	|-StructMultiKey<object, object>..ctor
	|
	|-RVA: 0x552F2C0 Offset: 0x552B2C0 VA: 0x552F2C0
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x552F124 Offset: 0x552B124 VA: 0x552F124
	|-StructMultiKey<object, object>.GetHashCode
	|
	|-RVA: 0x552F4A4 Offset: 0x552B4A4 VA: 0x552F4A4
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x552F19C Offset: 0x552B19C VA: 0x552F19C
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x552F8A8 Offset: 0x552B8A8 VA: 0x552F8A8
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StructMultiKey<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x552F278 Offset: 0x552B278 VA: 0x552F278
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x552FA9C Offset: 0x552BA9C VA: 0x552FA9C
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 19505
{
	// Fields
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; // 0x0
	private readonly Func<TKey, TValue> _creator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TKey, TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x562AD80 Offset: 0x5626D80 VA: 0x562AD80
	|-ThreadSafeStore<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x562AE64 Offset: 0x5626E64 VA: 0x562AE64
	|-ThreadSafeStore<object, object>..ctor
	|
	|-RVA: 0x562AF48 Offset: 0x5626F48 VA: 0x562AF48
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x562AE38 Offset: 0x5626E38 VA: 0x562AE38
	|-ThreadSafeStore<StructMultiKey<object, object>, object>.Get
	|
	|-RVA: 0x562AF1C Offset: 0x5626F1C VA: 0x562AF1C
	|-ThreadSafeStore<object, object>.Get
	|
	|-RVA: 0x562B004 Offset: 0x5627004 VA: 0x562B004
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class TypeExtensions // TypeDefIndex: 19506
{
	// Methods

	[Extension]
	// RVA: 0x7CA647C Offset: 0x7CA247C VA: 0x7CA647C
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x7CAC33C Offset: 0x7CA833C VA: 0x7CAC33C
	public static bool ContainsGenericParameters(Type type) { }

	[Extension]
	// RVA: 0x7CA79F0 Offset: 0x7CA39F0 VA: 0x7CA79F0
	public static bool IsInterface(Type type) { }

	[Extension]
	// RVA: 0x7C9FBA8 Offset: 0x7C9BBA8 VA: 0x7C9FBA8
	public static bool IsGenericType(Type type) { }

	[Extension]
	// RVA: 0x7CA7A04 Offset: 0x7CA3A04 VA: 0x7CA7A04
	public static bool IsGenericTypeDefinition(Type type) { }

	[Extension]
	// RVA: 0x7CA7D1C Offset: 0x7CA3D1C VA: 0x7CA7D1C
	public static Type BaseType(Type type) { }

	[Extension]
	// RVA: 0x7C9FBD0 Offset: 0x7C9BBD0 VA: 0x7C9FBD0
	public static Assembly Assembly(Type type) { }

	[Extension]
	// RVA: 0x7CAC35C Offset: 0x7CA835C VA: 0x7CAC35C
	public static bool IsEnum(Type type) { }

	[Extension]
	// RVA: 0x7CA7BEC Offset: 0x7CA3BEC VA: 0x7CA7BEC
	public static bool IsClass(Type type) { }

	[Extension]
	// RVA: 0x7CAC37C Offset: 0x7CA837C VA: 0x7CAC37C
	public static bool IsSealed(Type type) { }

	[Extension]
	// RVA: 0x7CAC390 Offset: 0x7CA8390 VA: 0x7CAC390
	public static bool IsAbstract(Type type) { }

	[Extension]
	// RVA: 0x7CAC3A4 Offset: 0x7CA83A4 VA: 0x7CAC3A4
	public static bool IsVisible(Type type) { }

	[Extension]
	// RVA: 0x7CA7258 Offset: 0x7CA3258 VA: 0x7CA7258
	public static bool IsValueType(Type type) { }

	[Extension]
	// RVA: 0x7CAC3B8 Offset: 0x7CA83B8 VA: 0x7CAC3B8
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Extension]
	// RVA: 0x7CAC548 Offset: 0x7CA8548 VA: 0x7CAC548
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Extension]
	// RVA: 0x7CAC568 Offset: 0x7CA8568 VA: 0x7CAC568
	public static bool ImplementInterface(Type type, Type interfaceType) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils // TypeDefIndex: 19507
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7CA4C58 Offset: 0x7CA0C58 VA: 0x7CA4C58
	public static void ArgumentNotNull(object value, string parameterName) { }
}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T> // TypeDefIndex: 19508
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<object, T> TypeAttributeCache; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static T GetAttribute(object type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4D80 Offset: 0x5BA0D80 VA: 0x5BA4D80
	|-CachedAttributeGetter<object>.GetAttribute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4E28 Offset: 0x5BA0E28 VA: 0x5BA4E28
	|-CachedAttributeGetter<object>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy : NamingStrategy // TypeDefIndex: 19509
{
	// Methods

	// RVA: 0x7CAC954 Offset: 0x7CA8954 VA: 0x7CAC954
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x7CAC98C Offset: 0x7CA898C VA: 0x7CAC98C
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x7CAC9D8 Offset: 0x7CA89D8 VA: 0x7CAC9D8
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x7CAC9E0 Offset: 0x7CA89E0 VA: 0x7CAC9E0 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> : IEnumerator<KeyValuePair<object, object>>, IEnumerator, IDisposable // TypeDefIndex: 19510
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(new[] { 0, 1, 1 })]
	private KeyValuePair<object, object> <>2__current; // 0x0
	public DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this; // 0x0
	[Nullable(new[] { 0, 0, 1, 1 })]
	private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1; // 0x0

	// Properties
	private KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A658 Offset: 0x5D26658 VA: 0x5D2A658
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A680 Offset: 0x5D26680 VA: 0x5D2A680
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A6AC Offset: 0x5D266AC VA: 0x5D2A6AC
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2AB18 Offset: 0x5D26B18 VA: 0x5D2AB18
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ABC8 Offset: 0x5D26BC8 VA: 0x5D2ABC8
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ABD4 Offset: 0x5D26BD4 VA: 0x5D2ABD4
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2AC08 Offset: 0x5D26C08 VA: 0x5D2AC08
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[NullableContext(0)]
internal class DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable // TypeDefIndex: 19511
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BB928 Offset: 0x60B7928 VA: 0x60BB928
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<KeyValuePair<object, object>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BB99C Offset: 0x60B799C VA: 0x60BB99C
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BBA18 Offset: 0x60B7A18 VA: 0x60BBA18
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DefaultContractResolver.<>c // TypeDefIndex: 19512
{
	// Fields
	[Nullable(0)]
	public static readonly DefaultContractResolver.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__40_0; // 0x8
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__40_1; // 0x10
	[Nullable(0)]
	public static Func<Type, IEnumerable<MemberInfo>> <>9__44_0; // 0x18
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__44_1; // 0x20
	[Nullable(0)]
	public static Func<ConstructorInfo, bool> <>9__47_0; // 0x28
	[Nullable(0)]
	public static Func<JsonProperty, int> <>9__75_0; // 0x30

	// Methods

	// RVA: 0x7CB6258 Offset: 0x7CB2258 VA: 0x7CB6258
	private static void .cctor() { }

	// RVA: 0x7CB62C0 Offset: 0x7CB22C0 VA: 0x7CB62C0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CB62C8 Offset: 0x7CB22C8 VA: 0x7CB62C8
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x7CB6378 Offset: 0x7CB2378 VA: 0x7CB6378
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x7CB63EC Offset: 0x7CB23EC VA: 0x7CB63EC
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	[NullableContext(0)]
	// RVA: 0x7CB64CC Offset: 0x7CB24CC VA: 0x7CB64CC
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x7CB68A8 Offset: 0x7CB28A8 VA: 0x7CB68A8
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	[NullableContext(0)]
	// RVA: 0x7CB6944 Offset: 0x7CB2944 VA: 0x7CB6944
	internal int <CreateProperties>b__75_0(JsonProperty p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass42_0 // TypeDefIndex: 19513
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x7CAE468 Offset: 0x7CAA468 VA: 0x7CAE468
	public void .ctor() { }

	// RVA: 0x7CB699C Offset: 0x7CB299C VA: 0x7CB699C
	internal string <CreateObjectContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_0 // TypeDefIndex: 19514
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public Func<object, object> getExtensionDataDictionary; // 0x10
	[Nullable(0)]
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0x7CAFABC Offset: 0x7CABABC VA: 0x7CAFABC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_1 // TypeDefIndex: 19515
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public Action<object, object> setExtensionDataDictionary; // 0x10
	[Nullable(new[] { 0, 1 })]
	public Func<object> createExtensionDataDictionary; // 0x18
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
	[Nullable(0)]
	public DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x7CAFAC4 Offset: 0x7CABAC4 VA: 0x7CAFAC4
	public void .ctor() { }

	// RVA: 0x7CB69BC Offset: 0x7CB29BC VA: 0x7CB69BC
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_2 // TypeDefIndex: 19516
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	[Nullable(0)]
	public DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x7CAFBD8 Offset: 0x7CABBD8 VA: 0x7CAFBD8
	public void .ctor() { }

	// RVA: 0x7CB6BC8 Offset: 0x7CB2BC8 VA: 0x7CB6BC8
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass62_0 // TypeDefIndex: 19517
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x7CB314C Offset: 0x7CAF14C VA: 0x7CB314C
	public void .ctor() { }

	// RVA: 0x7CB6CE0 Offset: 0x7CB2CE0 VA: 0x7CB6CE0
	internal string <CreateDictionaryContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass67_0 // TypeDefIndex: 19518
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x7CB47F4 Offset: 0x7CB07F4 VA: 0x7CB47F4
	public void .ctor() { }

	// RVA: 0x7CB6D00 Offset: 0x7CB2D00 VA: 0x7CB6D00
	internal string <CreateDynamicContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass80_0 // TypeDefIndex: 19519
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x7CB5CAC Offset: 0x7CB1CAC VA: 0x7CB5CAC
	public void .ctor() { }

	// RVA: 0x7CB6D20 Offset: 0x7CB2D20 VA: 0x7CB6D20
	internal bool <CreateShouldSerializeTest>b__0(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass81_0 // TypeDefIndex: 19520
{
	// Fields
	[Nullable(new[] { 0, 1, 1 })]
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x7CB5CB4 Offset: 0x7CB1CB4 VA: 0x7CB5CB4
	public void .ctor() { }

	// RVA: 0x7CB6E18 Offset: 0x7CB2E18 VA: 0x7CB6E18
	internal bool <SetIsSpecifiedActions>b__0(object o) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public class DefaultContractResolver : IContractResolver // TypeDefIndex: 19521
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; // 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	[CompilerGenerated]
	[Nullable(2)]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Properties
	internal static IContractResolver Instance { get; }
	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }
	public bool IgnoreIsSpecifiedMembers { get; }
	public bool IgnoreShouldSerializeMembers { get; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; }

	// Methods

	// RVA: 0x7CAC9E8 Offset: 0x7CA89E8 VA: 0x7CAC9E8
	internal static IContractResolver get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x7CACA40 Offset: 0x7CA8A40 VA: 0x7CACA40
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGenerated]
	// RVA: 0x7CACA48 Offset: 0x7CA8A48 VA: 0x7CACA48
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	// RVA: 0x7CACA50 Offset: 0x7CA8A50 VA: 0x7CACA50
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGenerated]
	// RVA: 0x7CACA58 Offset: 0x7CA8A58 VA: 0x7CACA58
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	// RVA: 0x7CACA60 Offset: 0x7CA8A60 VA: 0x7CACA60
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	// RVA: 0x7CACA68 Offset: 0x7CA8A68 VA: 0x7CACA68
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CACA74 Offset: 0x7CA8A74 VA: 0x7CACA74
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	// RVA: 0x7CACA7C Offset: 0x7CA8A7C VA: 0x7CACA7C
	public bool get_IgnoreShouldSerializeMembers() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7CACA84 Offset: 0x7CA8A84 VA: 0x7CACA84
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0x7CACA8C Offset: 0x7CA8A8C VA: 0x7CACA8C
	public void .ctor() { }

	// RVA: 0x7CACB9C Offset: 0x7CA8B9C VA: 0x7CACB9C Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0x7CACC1C Offset: 0x7CA8C1C VA: 0x7CACC1C
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0x7CACD60 Offset: 0x7CA8D60 VA: 0x7CACD60 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0x7CADB08 Offset: 0x7CA9B08 VA: 0x7CADB08
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0x7CADC10 Offset: 0x7CA9C10 VA: 0x7CADC10 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0x7CAF870 Offset: 0x7CAB870 VA: 0x7CAF870
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0x7CAEC98 Offset: 0x7CAAC98 VA: 0x7CAEC98
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0x7CAEE64 Offset: 0x7CAAE64 VA: 0x7CAEE64
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0x7CAE470 Offset: 0x7CAA470 VA: 0x7CAE470
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0x7CAE9DC Offset: 0x7CAA9DC VA: 0x7CAE9DC
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0x7CAE994 Offset: 0x7CAA994 VA: 0x7CAE994
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0x7CAFD90 Offset: 0x7CABD90 VA: 0x7CAFD90 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0x7CAFCE8 Offset: 0x7CABCE8 VA: 0x7CAFCE8
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0x7CAFF20 Offset: 0x7CABF20 VA: 0x7CAFF20 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0x7CB08A8 Offset: 0x7CAC8A8 VA: 0x7CB08A8 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0x7CB0900 Offset: 0x7CAC900 VA: 0x7CB0900
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0x7CAE204 Offset: 0x7CAA204 VA: 0x7CAE204
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0x7CB09A0 Offset: 0x7CAC9A0 VA: 0x7CB09A0
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0x7CB0ACC Offset: 0x7CACACC VA: 0x7CB0ACC
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x7CB203C Offset: 0x7CAE03C VA: 0x7CB203C
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0x7CB175C Offset: 0x7CAD75C VA: 0x7CB175C
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x7CB1680 Offset: 0x7CAD680 VA: 0x7CB1680
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0x7CAF904 Offset: 0x7CAB904 VA: 0x7CAF904
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0x7CB2184 Offset: 0x7CAE184 VA: 0x7CB2184 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0x7CB3154 Offset: 0x7CAF154 VA: 0x7CB3154 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0x7CB42A0 Offset: 0x7CB02A0 VA: 0x7CB42A0 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0x7CB4314 Offset: 0x7CB0314 VA: 0x7CB4314 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0x7CB4388 Offset: 0x7CB0388 VA: 0x7CB4388 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0x7CB45D0 Offset: 0x7CB05D0 VA: 0x7CB45D0 Slot: 16
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0x7CB47FC Offset: 0x7CB07FC VA: 0x7CB47FC Slot: 17
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0x7CB4870 Offset: 0x7CB0870 VA: 0x7CB4870 Slot: 18
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0x7CB4C78 Offset: 0x7CB0C78 VA: 0x7CB4C78
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0x7CB4DF4 Offset: 0x7CB0DF4 VA: 0x7CB4DF4
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0x7CB4CDC Offset: 0x7CB0CDC VA: 0x7CB4CDC
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0x7CB1838 Offset: 0x7CAD838 VA: 0x7CB1838
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0x7CB4F6C Offset: 0x7CB0F6C VA: 0x7CB4F6C
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x7CB5070 Offset: 0x7CB1070 VA: 0x7CB5070 Slot: 19
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0x7CB5490 Offset: 0x7CB1490 VA: 0x7CB5490 Slot: 20
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x7CB5498 Offset: 0x7CB1498 VA: 0x7CB5498 Slot: 21
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0x7CB54F4 Offset: 0x7CB14F4 VA: 0x7CB54F4 Slot: 22
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0x7CB01E4 Offset: 0x7CAC1E4 VA: 0x7CB01E4
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0x7CB5718 Offset: 0x7CB1718 VA: 0x7CB5718
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0x7CB5984 Offset: 0x7CB1984 VA: 0x7CB5984
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x7CB5CBC Offset: 0x7CB1CBC VA: 0x7CB5CBC Slot: 23
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0x7CB5CDC Offset: 0x7CB1CDC VA: 0x7CB5CDC Slot: 24
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0x7CB5CF8 Offset: 0x7CB1CF8 VA: 0x7CB5CF8 Slot: 25
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0x7CB5D24 Offset: 0x7CB1D24 VA: 0x7CB5D24
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0x7CB5D34 Offset: 0x7CB1D34 VA: 0x7CB5D34
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy : NamingStrategy // TypeDefIndex: 19522
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7CB6EA4 Offset: 0x7CB2EA4 VA: 0x7CB6EA4 Slot: 7
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0x7CB6EAC Offset: 0x7CB2EAC VA: 0x7CB6EAC
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 19523
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0x7CB6EB4 Offset: 0x7CB2EB4 VA: 0x7CB6EB4
	private BidirectionalDictionary<string, object> GetMappings(object context) { }

	// RVA: 0x7CB6FC4 Offset: 0x7CB2FC4 VA: 0x7CB6FC4 Slot: 4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0x7CB7038 Offset: 0x7CB3038 VA: 0x7CB7038 Slot: 5
	public string GetReference(object context, object value) { }

	// RVA: 0x7CB712C Offset: 0x7CB312C VA: 0x7CB712C Slot: 7
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0x7CB7198 Offset: 0x7CB3198 VA: 0x7CB7198 Slot: 6
	public bool IsReferenced(object context, object value) { }

	// RVA: 0x7CB720C Offset: 0x7CB320C VA: 0x7CB720C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 19524
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	[Nullable(new[] { 1, 0, 2, 1, 1 })]
	private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x7CB7214 Offset: 0x7CB3214 VA: 0x7CB7214
	public void .ctor() { }

	// RVA: 0x7CB72EC Offset: 0x7CB32EC VA: 0x7CB72EC
	private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x7CB76E8 Offset: 0x7CB36E8 VA: 0x7CB76E8
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0x7CB79A4 Offset: 0x7CB39A4 VA: 0x7CB79A4
	private Type GetTypeByName(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x7CB7A0C Offset: 0x7CB3A0C VA: 0x7CB7A0C Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x7CB7A88 Offset: 0x7CB3A88 VA: 0x7CB7A88 Slot: 4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0x7CB7B08 Offset: 0x7CB3B08 VA: 0x7CB7B08
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public class ErrorContext // TypeDefIndex: 19525
{
	// Fields
	[CompilerGenerated]
	private bool <Traced>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; // 0x18
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <OriginalObject>k__BackingField; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <Member>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x38

	// Properties
	internal bool Traced { get; set; }
	public Exception Error { get; }
	public bool Handled { get; }

	// Methods

	// RVA: 0x7CB7B6C Offset: 0x7CB3B6C VA: 0x7CB7B6C
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x7CB7BE0 Offset: 0x7CB3BE0 VA: 0x7CB7BE0
	internal bool get_Traced() { }

	[CompilerGenerated]
	// RVA: 0x7CB7BE8 Offset: 0x7CB3BE8 VA: 0x7CB7BE8
	internal void set_Traced(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CB7BF4 Offset: 0x7CB3BF4 VA: 0x7CB7BF4
	public Exception get_Error() { }

	[CompilerGenerated]
	// RVA: 0x7CB7BFC Offset: 0x7CB3BFC VA: 0x7CB7BFC
	public bool get_Handled() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
public class ErrorEventArgs : EventArgs // TypeDefIndex: 19526
{
	// Fields
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <CurrentObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7CB7C04 Offset: 0x7CB3C04 VA: 0x7CB7C04
	public void .ctor(object currentObject, ErrorContext errorContext) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IAttributeProvider // TypeDefIndex: 19527
{}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IContractResolver // TypeDefIndex: 19528
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract JsonContract ResolveContract(Type type);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IReferenceResolver // TypeDefIndex: 19529
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ResolveReference(object context, string reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetReference(object context, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsReferenced(object context, object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddReference(object context, string reference, object value);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ISerializationBinder // TypeDefIndex: 19530
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type BindToType(string assemblyName, string typeName);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void BindToName(Type serializedType, out string assemblyName, out string typeName);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ITraceWriter // TypeDefIndex: 19531
{
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IValueProvider // TypeDefIndex: 19532
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(object target, object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 19533
{
	// Fields
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; // 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; }
	public bool IsMultidimensionalArray { get; }
	internal bool IsArray { get; }
	internal bool ShouldCreateWrapper { get; }
	internal bool CanDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CB7C8C Offset: 0x7CB3C8C VA: 0x7CB7C8C
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	// RVA: 0x7CB7C94 Offset: 0x7CB3C94 VA: 0x7CB7C94
	public bool get_IsMultidimensionalArray() { }

	[CompilerGenerated]
	// RVA: 0x7CB7C9C Offset: 0x7CB3C9C VA: 0x7CB7C9C
	internal bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x7CB7CA4 Offset: 0x7CB3CA4 VA: 0x7CB7CA4
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	// RVA: 0x7CB7CAC Offset: 0x7CB3CAC VA: 0x7CB7CAC
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x7CB7CB4 Offset: 0x7CB3CB4 VA: 0x7CB7CB4
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x7CB7CC0 Offset: 0x7CB3CC0 VA: 0x7CB7CC0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x7CB7D8C Offset: 0x7CB3D8C VA: 0x7CB7D8C
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x7CB427C Offset: 0x7CB027C VA: 0x7CB427C
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB7D94 Offset: 0x7CB3D94 VA: 0x7CB7D94
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x7CB7D9C Offset: 0x7CB3D9C VA: 0x7CB7D9C
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x7CB7DA8 Offset: 0x7CB3DA8 VA: 0x7CB7DA8
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x7CB34A4 Offset: 0x7CAF4A4 VA: 0x7CB34A4
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x7CB8128 Offset: 0x7CB4128 VA: 0x7CB8128
	internal IWrappedCollection CreateWrapper(object list) { }

	[NullableContext(1)]
	// RVA: 0x7CB8540 Offset: 0x7CB4540 VA: 0x7CB8540
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	// RVA: 0x7CB8004 Offset: 0x7CB4004 VA: 0x7CB8004
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(2)]
public class JsonContainerContract : JsonContract // TypeDefIndex: 19534
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x7CB87B4 Offset: 0x7CB47B4 VA: 0x7CB87B4
	internal JsonContract get_ItemContract() { }

	// RVA: 0x7CB87BC Offset: 0x7CB47BC VA: 0x7CB87BC
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x7CB8824 Offset: 0x7CB4824 VA: 0x7CB8824
	internal JsonContract get_FinalItemContract() { }

	[CompilerGenerated]
	// RVA: 0x7CB882C Offset: 0x7CB482C VA: 0x7CB882C
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x7CB8834 Offset: 0x7CB4834 VA: 0x7CB8834
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x7CB883C Offset: 0x7CB483C VA: 0x7CB883C
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x7CB8844 Offset: 0x7CB4844 VA: 0x7CB8844
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB884C Offset: 0x7CB484C VA: 0x7CB884C
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CB8854 Offset: 0x7CB4854 VA: 0x7CB8854
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB885C Offset: 0x7CB485C VA: 0x7CB885C
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CB8864 Offset: 0x7CB4864 VA: 0x7CB8864
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x7CB7E28 Offset: 0x7CB3E28 VA: 0x7CB7E28
	internal void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
internal enum JsonContractType // TypeDefIndex: 19535
{
	// Fields
	public int value__; // 0x0
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 19536
{
	// Methods

	// RVA: 0x7CAF764 Offset: 0x7CAB764 VA: 0x7CAF764
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x7CB89E8 Offset: 0x7CB49E8 VA: 0x7CB89E8 Slot: 13
	public virtual void Invoke(object o, StreamingContext context) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 19537
{
	// Methods

	// RVA: 0x7CB89FC Offset: 0x7CB49FC VA: 0x7CB89FC
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x7CB8B08 Offset: 0x7CB4B08 VA: 0x7CB8B08 Slot: 13
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter : MulticastDelegate // TypeDefIndex: 19538
{
	// Methods

	// RVA: 0x7CAFACC Offset: 0x7CABACC VA: 0x7CAFACC
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x7CB8B1C Offset: 0x7CB4B1C VA: 0x7CB8B1C Slot: 13
	public virtual void Invoke(object o, string key, object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter : MulticastDelegate // TypeDefIndex: 19539
{
	// Methods

	// RVA: 0x7CAFBE0 Offset: 0x7CABBE0 VA: 0x7CAFBE0
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x7CB8B30 Offset: 0x7CB4B30 VA: 0x7CB8B30 Slot: 13
	public virtual IEnumerable<KeyValuePair<object, object>> Invoke(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonContract.<>c__DisplayClass57_0 // TypeDefIndex: 19540
{
	// Fields
	[Nullable(0)]
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x7CB9298 Offset: 0x7CB5298 VA: 0x7CB9298
	public void .ctor() { }

	// RVA: 0x7CB92A8 Offset: 0x7CB52A8 VA: 0x7CB92A8
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonContract.<>c__DisplayClass58_0 // TypeDefIndex: 19541
{
	// Fields
	[Nullable(0)]
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x7CB92A0 Offset: 0x7CB52A0 VA: 0x7CB92A0
	public void .ctor() { }

	// RVA: 0x7CB93A8 Offset: 0x7CB53A8 VA: 0x7CB93A8
	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonContract // TypeDefIndex: 19542
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializedCallbacks; // 0x40
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializingCallbacks; // 0x48
	[Nullable(new[] { 2, 1 })]
	private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <Converter>k__BackingField; // 0x70
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	[Nullable(2)]
	public JsonConverter Converter { get; set; }
	[Nullable(2)]
	public JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	[Nullable(new[] { 2, 1 })]
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CB8B44 Offset: 0x7CB4B44 VA: 0x7CB8B44
	public Type get_UnderlyingType() { }

	// RVA: 0x7CB8B4C Offset: 0x7CB4B4C VA: 0x7CB8B4C
	public Type get_CreatedType() { }

	// RVA: 0x7CB7F40 Offset: 0x7CB3F40 VA: 0x7CB7F40
	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7CB8B54 Offset: 0x7CB4B54 VA: 0x7CB8B54
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x7CB8B5C Offset: 0x7CB4B5C VA: 0x7CB8B5C
	public void set_IsReference(Nullable<bool> value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7CB8B64 Offset: 0x7CB4B64 VA: 0x7CB8B64
	public JsonConverter get_Converter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7CB8B6C Offset: 0x7CB4B6C VA: 0x7CB8B6C
	public void set_Converter(JsonConverter value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7CB8B74 Offset: 0x7CB4B74 VA: 0x7CB8B74
	public JsonConverter get_InternalConverter() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7CB8B7C Offset: 0x7CB4B7C VA: 0x7CB8B7C
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x7CB1578 Offset: 0x7CAD578 VA: 0x7CB1578
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x7CB14F4 Offset: 0x7CAD4F4 VA: 0x7CB14F4
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x7CB1470 Offset: 0x7CAD470 VA: 0x7CB1470
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x7CAF6E0 Offset: 0x7CAB6E0 VA: 0x7CAF6E0
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x7CB15FC Offset: 0x7CAD5FC VA: 0x7CB15FC
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGenerated]
	// RVA: 0x7CB8B84 Offset: 0x7CB4B84 VA: 0x7CB8B84
	public Func<object> get_DefaultCreator() { }

	[CompilerGenerated]
	// RVA: 0x7CB8B8C Offset: 0x7CB4B8C VA: 0x7CB8B8C
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB8B94 Offset: 0x7CB4B94 VA: 0x7CB8B94
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	// RVA: 0x7CB8B9C Offset: 0x7CB4B9C VA: 0x7CB8B9C
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x7CB886C Offset: 0x7CB486C VA: 0x7CB886C
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x7CB8BA8 Offset: 0x7CB4BA8 VA: 0x7CB8BA8
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x7CB8D08 Offset: 0x7CB4D08 VA: 0x7CB8D08
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x7CB8E68 Offset: 0x7CB4E68 VA: 0x7CB8E68
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x7CB8FC8 Offset: 0x7CB4FC8 VA: 0x7CB8FC8
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x7CB9128 Offset: 0x7CB5128 VA: 0x7CB9128
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x7CB1ECC Offset: 0x7CADECC VA: 0x7CB1ECC
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x7CB1F84 Offset: 0x7CADF84 VA: 0x7CB1F84
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(2)]
public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 19543
{
	// Fields
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x110
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> DictionaryKeyResolver { get; set; }
	public Type DictionaryKeyType { get; }
	public Type DictionaryValueType { get; }
	internal JsonContract KeyContract { get; set; }
	internal bool ShouldCreateWrapper { get; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CB94E8 Offset: 0x7CB54E8 VA: 0x7CB94E8
	public Func<string, string> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	// RVA: 0x7CB94F0 Offset: 0x7CB54F0 VA: 0x7CB94F0
	public void set_DictionaryKeyResolver(Func<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB94F8 Offset: 0x7CB54F8 VA: 0x7CB94F8
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	// RVA: 0x7CB9500 Offset: 0x7CB5500 VA: 0x7CB9500
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	// RVA: 0x7CB9508 Offset: 0x7CB5508 VA: 0x7CB9508
	internal JsonContract get_KeyContract() { }

	[CompilerGenerated]
	// RVA: 0x7CB9510 Offset: 0x7CB5510 VA: 0x7CB9510
	internal void set_KeyContract(JsonContract value) { }

	[CompilerGenerated]
	// RVA: 0x7CB9518 Offset: 0x7CB5518 VA: 0x7CB9518
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0x7CB9520 Offset: 0x7CB5520 VA: 0x7CB9520
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x7CB95EC Offset: 0x7CB55EC VA: 0x7CB95EC
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x7CB95F4 Offset: 0x7CB55F4 VA: 0x7CB95F4
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CB9604 Offset: 0x7CB5604 VA: 0x7CB9604
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x7CB960C Offset: 0x7CB560C VA: 0x7CB960C
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x7CB9618 Offset: 0x7CB5618 VA: 0x7CB9618
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x7CB2700 Offset: 0x7CAE700 VA: 0x7CB2700
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x7CB9698 Offset: 0x7CB5698 VA: 0x7CB9698
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[NullableContext(1)]
	// RVA: 0x7CB996C Offset: 0x7CB596C VA: 0x7CB996C
	internal IDictionary CreateTemporaryDictionary() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 19544
{
	// Fields
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
	[Nullable(new[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8

	// Properties
	public JsonPropertyCollection Properties { get; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> PropertyNameResolver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CB9C1C Offset: 0x7CB5C1C VA: 0x7CB9C1C
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x7CB9C24 Offset: 0x7CB5C24 VA: 0x7CB9C24
	public Func<string, string> get_PropertyNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x7CB9C2C Offset: 0x7CB5C2C VA: 0x7CB9C2C
	public void set_PropertyNameResolver(Func<string, string> value) { }

	// RVA: 0x7CB9C34 Offset: 0x7CB5C34 VA: 0x7CB9C34
	private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) { }

	// RVA: 0x7CB9D60 Offset: 0x7CB5D60 VA: 0x7CB9D60
	private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) { }

	// RVA: 0x7CB9E8C Offset: 0x7CB5E8C VA: 0x7CB9E8C
	public void .ctor(Type underlyingType) { }

	// RVA: 0x7CBA1D0 Offset: 0x7CB61D0 VA: 0x7CBA1D0
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0x7CBA2F4 Offset: 0x7CB62F4 VA: 0x7CBA2F4
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 19545
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x7CBA3F4 Offset: 0x7CB63F4 VA: 0x7CBA3F4
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464F44C Offset: 0x464B44C VA: 0x464F44C
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x464F5F4 Offset: 0x464B5F4 VA: 0x464F5F4
	|-JsonFormatterConverter.GetTokenValue<byte>
	|
	|-RVA: 0x464F79C Offset: 0x464B79C VA: 0x464F79C
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x464F944 Offset: 0x464B944 VA: 0x464F944
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x464FAEC Offset: 0x464BAEC VA: 0x464FAEC
	|-JsonFormatterConverter.GetTokenValue<object>
	|
	|-RVA: 0x464FC90 Offset: 0x464BC90 VA: 0x464FC90
	|-JsonFormatterConverter.GetTokenValue<float>
	|
	|-RVA: 0x464FE38 Offset: 0x464BE38 VA: 0x464FE38
	|-JsonFormatterConverter.GetTokenValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CBA4BC Offset: 0x7CB64BC VA: 0x7CBA4BC Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x7CBA6F8 Offset: 0x7CB66F8 VA: 0x7CBA6F8 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x7CBA750 Offset: 0x7CB6750 VA: 0x7CBA750 Slot: 6
	public byte ToByte(object value) { }

	// RVA: 0x7CBA7A8 Offset: 0x7CB67A8 VA: 0x7CBA7A8 Slot: 7
	public int ToInt32(object value) { }

	// RVA: 0x7CBA800 Offset: 0x7CB6800 VA: 0x7CBA800 Slot: 8
	public long ToInt64(object value) { }

	// RVA: 0x7CBA858 Offset: 0x7CB6858 VA: 0x7CBA858 Slot: 9
	public float ToSingle(object value) { }

	// RVA: 0x7CBA8B0 Offset: 0x7CB68B0 VA: 0x7CBA8B0 Slot: 10
	public string ToString(object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract : JsonContainerContract // TypeDefIndex: 19546
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private ObjectConstructor<object> <ISerializableCreator>k__BackingField; // 0xC0

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> ISerializableCreator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CBA908 Offset: 0x7CB6908 VA: 0x7CBA908
	public ObjectConstructor<object> get_ISerializableCreator() { }

	[CompilerGenerated]
	// RVA: 0x7CBA910 Offset: 0x7CB6910 VA: 0x7CBA910
	public void set_ISerializableCreator(ObjectConstructor<object> value) { }

	[NullableContext(1)]
	// RVA: 0x7CBA918 Offset: 0x7CB6918 VA: 0x7CBA918
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract : JsonContract // TypeDefIndex: 19547
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7CBA938 Offset: 0x7CB6938 VA: 0x7CBA938
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 19548
{
	// Fields
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xBC
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xC8
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xD8
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE8
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <ExtensionDataNameResolver>k__BackingField; // 0xF0
	internal bool ExtensionDataIsJToken; // 0xF8
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0xF9
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<MissingMemberHandling> MissingMemberHandling { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public Nullable<NullValueHandling> ItemNullValueHandling { get; set; }
	[Nullable(1)]
	public JsonPropertyCollection Properties { get; }
	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; set; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> ExtensionDataNameResolver { get; set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CBA958 Offset: 0x7CB6958 VA: 0x7CBA958
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	// RVA: 0x7CBA960 Offset: 0x7CB6960 VA: 0x7CBA960
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	// RVA: 0x7CBA968 Offset: 0x7CB6968 VA: 0x7CBA968
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBA970 Offset: 0x7CB6970 VA: 0x7CBA970
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBA978 Offset: 0x7CB6978 VA: 0x7CBA978
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	// RVA: 0x7CBA980 Offset: 0x7CB6980 VA: 0x7CBA980
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBA988 Offset: 0x7CB6988 VA: 0x7CBA988
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBA990 Offset: 0x7CB6990 VA: 0x7CBA990
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x7CBA998 Offset: 0x7CB6998 VA: 0x7CBA998
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	// RVA: 0x7CBA9A0 Offset: 0x7CB69A0 VA: 0x7CBA9A0
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x7CBAA20 Offset: 0x7CB6A20 VA: 0x7CBAA20
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x7CBAA28 Offset: 0x7CB6A28 VA: 0x7CBAA28
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	// RVA: 0x7CBAA38 Offset: 0x7CB6A38 VA: 0x7CBAA38
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x7CBAA40 Offset: 0x7CB6A40 VA: 0x7CBAA40
	internal void set_ParameterizedCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBAA50 Offset: 0x7CB6A50 VA: 0x7CBAA50
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGenerated]
	// RVA: 0x7CBAA58 Offset: 0x7CB6A58 VA: 0x7CBAA58
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGenerated]
	// RVA: 0x7CBAA60 Offset: 0x7CB6A60 VA: 0x7CBAA60
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	// RVA: 0x7CBAA68 Offset: 0x7CB6A68 VA: 0x7CBAA68
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x7CBAA70 Offset: 0x7CB6A70 VA: 0x7CBAA70
	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7CBAB50 Offset: 0x7CB6B50 VA: 0x7CBAB50
	public Func<string, string> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x7CBAB58 Offset: 0x7CB6B58 VA: 0x7CBAB58
	public void set_ExtensionDataNameResolver(Func<string, string> value) { }

	// RVA: 0x7CBAB60 Offset: 0x7CB6B60 VA: 0x7CBAB60
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[NullableContext(1)]
	// RVA: 0x7CBAFB4 Offset: 0x7CB6FB4 VA: 0x7CBAFB4
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x7CBB03C Offset: 0x7CB703C VA: 0x7CBB03C
	internal object GetUninitializedObject() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 19549
{
	// Fields
	[CompilerGenerated]
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	// Properties
	internal PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CBB248 Offset: 0x7CB7248 VA: 0x7CBB248
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGenerated]
	// RVA: 0x7CBB250 Offset: 0x7CB7250 VA: 0x7CBB250
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x7CBB258 Offset: 0x7CB7258 VA: 0x7CBB258
	public void .ctor(Type underlyingType) { }

	// RVA: 0x7CBB350 Offset: 0x7CB7350 VA: 0x7CBB350
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(2)]
public class JsonProperty // TypeDefIndex: 19550
{
	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; // 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xB8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldSerialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldDeserialize { get; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> GetIsSpecified { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CBB6B4 Offset: 0x7CB76B4 VA: 0x7CBB6B4
	internal JsonContract get_PropertyContract() { }

	[CompilerGenerated]
	// RVA: 0x7CBB6BC Offset: 0x7CB76BC VA: 0x7CBB6BC
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x7CBB6C4 Offset: 0x7CB76C4 VA: 0x7CBB6C4
	public string get_PropertyName() { }

	// RVA: 0x7CBB6CC Offset: 0x7CB76CC VA: 0x7CBB6CC
	public void set_PropertyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB764 Offset: 0x7CB7764 VA: 0x7CBB764
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x7CBB76C Offset: 0x7CB776C VA: 0x7CBB76C
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB774 Offset: 0x7CB7774 VA: 0x7CBB774
	public Nullable<int> get_Order() { }

	[CompilerGenerated]
	// RVA: 0x7CBB77C Offset: 0x7CB777C VA: 0x7CBB77C
	public void set_Order(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB784 Offset: 0x7CB7784 VA: 0x7CBB784
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	// RVA: 0x7CBB78C Offset: 0x7CB778C VA: 0x7CBB78C
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB794 Offset: 0x7CB7794 VA: 0x7CBB794
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	// RVA: 0x7CBB79C Offset: 0x7CB779C VA: 0x7CBB79C
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB7A4 Offset: 0x7CB77A4 VA: 0x7CBB7A4
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x7CBB7AC Offset: 0x7CB77AC VA: 0x7CBB7AC
	public Type get_PropertyType() { }

	// RVA: 0x7CBB7B4 Offset: 0x7CB77B4 VA: 0x7CBB7B4
	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB840 Offset: 0x7CB7840 VA: 0x7CBB840
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	// RVA: 0x7CBB848 Offset: 0x7CB7848 VA: 0x7CBB848
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB850 Offset: 0x7CB7850 VA: 0x7CBB850
	public bool get_Ignored() { }

	[CompilerGenerated]
	// RVA: 0x7CBB858 Offset: 0x7CB7858 VA: 0x7CBB858
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB864 Offset: 0x7CB7864 VA: 0x7CBB864
	public bool get_Readable() { }

	[CompilerGenerated]
	// RVA: 0x7CBB86C Offset: 0x7CB786C VA: 0x7CBB86C
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB878 Offset: 0x7CB7878 VA: 0x7CBB878
	public bool get_Writable() { }

	[CompilerGenerated]
	// RVA: 0x7CBB880 Offset: 0x7CB7880 VA: 0x7CBB880
	public void set_Writable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB88C Offset: 0x7CB788C VA: 0x7CBB88C
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	// RVA: 0x7CBB894 Offset: 0x7CB7894 VA: 0x7CBB894
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x7CBB8A0 Offset: 0x7CB78A0 VA: 0x7CBB8A0
	public object get_DefaultValue() { }

	// RVA: 0x7CBB8B8 Offset: 0x7CB78B8 VA: 0x7CBB8B8
	public void set_DefaultValue(object value) { }

	// RVA: 0x7CBB8C8 Offset: 0x7CB78C8 VA: 0x7CBB8C8
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x7CBAF78 Offset: 0x7CB6F78 VA: 0x7CBAF78
	public Required get_Required() { }

	[CompilerGenerated]
	// RVA: 0x7CBB99C Offset: 0x7CB799C VA: 0x7CBB99C
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9A4 Offset: 0x7CB79A4 VA: 0x7CBB9A4
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9AC Offset: 0x7CB79AC VA: 0x7CBB9AC
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9B4 Offset: 0x7CB79B4 VA: 0x7CBB9B4
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9BC Offset: 0x7CB79BC VA: 0x7CBB9BC
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9C4 Offset: 0x7CB79C4 VA: 0x7CBB9C4
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9CC Offset: 0x7CB79CC VA: 0x7CBB9CC
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9D4 Offset: 0x7CB79D4 VA: 0x7CBB9D4
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9DC Offset: 0x7CB79DC VA: 0x7CBB9DC
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9E4 Offset: 0x7CB79E4 VA: 0x7CBB9E4
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9EC Offset: 0x7CB79EC VA: 0x7CBB9EC
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBB9F4 Offset: 0x7CB79F4 VA: 0x7CBB9F4
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBB9FC Offset: 0x7CB79FC VA: 0x7CBB9FC
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA04 Offset: 0x7CB7A04 VA: 0x7CBBA04
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBBA0C Offset: 0x7CB7A0C VA: 0x7CBBA0C
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA14 Offset: 0x7CB7A14 VA: 0x7CBBA14
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA1C Offset: 0x7CB7A1C VA: 0x7CBBA1C
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBBA24 Offset: 0x7CB7A24 VA: 0x7CBBA24
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA2C Offset: 0x7CB7A2C VA: 0x7CBBA2C
	public void set_SetIsSpecified(Action<object, object> value) { }

	[NullableContext(1)]
	// RVA: 0x7CBBA34 Offset: 0x7CB7A34 VA: 0x7CBBA34 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA88 Offset: 0x7CB7A88 VA: 0x7CBBA88
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x7CBBA90 Offset: 0x7CB7A90 VA: 0x7CBBA90
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x7CBBA98 Offset: 0x7CB7A98 VA: 0x7CBBA98
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x7CBBAA0 Offset: 0x7CB7AA0 VA: 0x7CBBAA0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBBAA8 Offset: 0x7CB7AA8 VA: 0x7CBBAA8
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBBAB0 Offset: 0x7CB7AB0 VA: 0x7CBBAB0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x7CBBAB8 Offset: 0x7CB7AB8 VA: 0x7CBBAB8
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x7CBBAC0 Offset: 0x7CB7AC0 VA: 0x7CBBAC0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x7CBBAC8 Offset: 0x7CB7AC8 VA: 0x7CBBAC8
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x7CBBB18 Offset: 0x7CB7B18 VA: 0x7CBBB18
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(new[] { 0, 1, 1 })]
[NullableContext(1)]
public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 19551
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly List<JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0x7CBA054 Offset: 0x7CB6054 VA: 0x7CBA054
	public void .ctor(Type type) { }

	// RVA: 0x7CBBB20 Offset: 0x7CB7B20 VA: 0x7CBBB20 Slot: 39
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x7CBBB38 Offset: 0x7CB7B38 VA: 0x7CBBB38
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x7CBBDF4 Offset: 0x7CB7DF4 VA: 0x7CBBDF4
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x7CBBF20 Offset: 0x7CB7F20 VA: 0x7CBBF20
	private bool TryGetProperty(string key, out JsonProperty item) { }

	// RVA: 0x7CBBE34 Offset: 0x7CB7E34 VA: 0x7CBBE34
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }
}

// Namespace: 
[NullableContext(0)]
private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 19552
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x7CBC784 Offset: 0x7CB8784 VA: 0x7CBC784 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	[NullableContext(1)]
	// RVA: 0x7CBC790 Offset: 0x7CB8790 VA: 0x7CBC790 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x7CBC1B4 Offset: 0x7CB81B4 VA: 0x7CBC1B4
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal abstract class JsonSerializerInternalBase // TypeDefIndex: 19553
{
	// Fields
	[Nullable(2)]
	private ErrorContext _currentErrorContext; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; // 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x7CBC008 Offset: 0x7CB8008 VA: 0x7CBC008
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x7CBC0A4 Offset: 0x7CB80A4 VA: 0x7CBC0A4
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x7CBC1BC Offset: 0x7CB81BC VA: 0x7CBC1BC
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0x7CBC248 Offset: 0x7CB8248 VA: 0x7CBC248
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x7CBC344 Offset: 0x7CB8344 VA: 0x7CBC344
	protected void ClearErrorContext() { }

	[NullableContext(2)]
	// RVA: 0x7CBC3A8 Offset: 0x7CB83A8 VA: 0x7CBC3A8
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }
}

// Namespace: 
[NullableContext(0)]
internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 19554
{
	// Fields
	public int value__; // 0x0
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;
}

// Namespace: 
[Nullable(0)]
[NullableContext(2)]
internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 19555
{
	// Fields
	[Nullable(1)]
	public readonly string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38

	// Methods

	[NullableContext(1)]
	// RVA: 0x7CC8138 Offset: 0x7CC4138 VA: 0x7CC8138
	public void .ctor(string name) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 19556
{
	// Fields
	[Nullable(0)]
	public static readonly JsonSerializerInternalReader.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JsonProperty, string> <>9__38_0; // 0x8
	[Nullable(new[] { 0, 0, 1 })]
	public static Func<JsonProperty, string> <>9__38_2; // 0x10
	[Nullable(0)]
	public static Func<JsonProperty, JsonProperty> <>9__42_0; // 0x18
	[Nullable(0)]
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__42_1; // 0x20

	// Methods

	// RVA: 0x7CC8BA8 Offset: 0x7CC4BA8 VA: 0x7CC8BA8
	private static void .cctor() { }

	// RVA: 0x7CC8C10 Offset: 0x7CC4C10 VA: 0x7CC8C10
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CC8C18 Offset: 0x7CC4C18 VA: 0x7CC8C18
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	[NullableContext(0)]
	// RVA: 0x7CC8C30 Offset: 0x7CC4C30 VA: 0x7CC8C30
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	[NullableContext(0)]
	// RVA: 0x7CC8C48 Offset: 0x7CC4C48 VA: 0x7CC8C48
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	[NullableContext(0)]
	// RVA: 0x7CC8C50 Offset: 0x7CC4C50 VA: 0x7CC8C50
	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonSerializerInternalReader.<>c__DisplayClass38_0 // TypeDefIndex: 19557
{
	// Fields
	[Nullable(0)]
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0x7CC8130 Offset: 0x7CC4130 VA: 0x7CC8130
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CC8C58 Offset: 0x7CC4C58 VA: 0x7CC8C58
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 19558
{
	// Methods

	// RVA: 0x7CBC79C Offset: 0x7CB879C VA: 0x7CBC79C
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x7CBC7A0 Offset: 0x7CB87A0 VA: 0x7CBC7A0
	public void Populate(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x7CBE650 Offset: 0x7CBA650 VA: 0x7CBE650
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x7CBE6DC Offset: 0x7CBA6DC VA: 0x7CBE6DC
	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	// RVA: 0x7CBE78C Offset: 0x7CBA78C VA: 0x7CBE78C
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x7CBF448 Offset: 0x7CBB448 VA: 0x7CBF448
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x7CBF548 Offset: 0x7CBB548 VA: 0x7CBF548
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x7CBF964 Offset: 0x7CBB964 VA: 0x7CBF964
	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x7CBEF3C Offset: 0x7CBAF3C VA: 0x7CBEF3C
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x7CC1530 Offset: 0x7CBD530 VA: 0x7CC1530
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x7CC1664 Offset: 0x7CBD664 VA: 0x7CC1664
	internal string GetExpectedDescription(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x7CBEABC Offset: 0x7CBAABC VA: 0x7CBEABC
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CBFDD0 Offset: 0x7CBBDD0 VA: 0x7CBFDD0
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x7CC171C Offset: 0x7CBD71C VA: 0x7CC171C
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x7CC1E8C Offset: 0x7CBDE8C VA: 0x7CC1E8C
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x7CC37A8 Offset: 0x7CBF7A8 VA: 0x7CC37A8
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x7CC3DCC Offset: 0x7CBFDCC VA: 0x7CC3DCC
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x7CC0914 Offset: 0x7CBC914 VA: 0x7CC0914
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[NullableContext(2)]
	// RVA: 0x7CC254C Offset: 0x7CBE54C VA: 0x7CC254C
	private bool HasNoDefinedType(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x7CC0F6C Offset: 0x7CBCF6C VA: 0x7CC0F6C
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x7CC48AC Offset: 0x7CC08AC VA: 0x7CC48AC
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x7CC4D7C Offset: 0x7CC0D7C VA: 0x7CC4D7C
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0x7CC5450 Offset: 0x7CC1450 VA: 0x7CC5450
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0x7CC5444 Offset: 0x7CC1444 VA: 0x7CC5444
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	// RVA: 0x7CC534C Offset: 0x7CC134C VA: 0x7CC534C
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0x7CC3F4C Offset: 0x7CBFF4C VA: 0x7CC3F4C
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x7CC286C Offset: 0x7CBE86C VA: 0x7CC286C
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x7CC5814 Offset: 0x7CC1814 VA: 0x7CC5814
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x7CC5A44 Offset: 0x7CC1A44 VA: 0x7CC5A44
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x7CBD1F4 Offset: 0x7CB91F4 VA: 0x7CBD1F4
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x7CC41E8 Offset: 0x7CC01E8 VA: 0x7CC41E8
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x7CC5C74 Offset: 0x7CC1C74 VA: 0x7CC5C74
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x7CBCCC8 Offset: 0x7CB8CC8 VA: 0x7CBCCC8
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x7CC310C Offset: 0x7CBF10C VA: 0x7CC310C
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x7CBA5D4 Offset: 0x7CB65D4 VA: 0x7CBA5D4
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x7CC2AC0 Offset: 0x7CBEAC0 VA: 0x7CC2AC0
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0x7CC5DA8 Offset: 0x7CC1DA8 VA: 0x7CC5DA8
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x7CBEB28 Offset: 0x7CBAB28 VA: 0x7CBEB28
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x7CC7A88 Offset: 0x7CC3A88 VA: 0x7CC7A88
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x7CC2648 Offset: 0x7CBE648 VA: 0x7CC2648
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x7CBDBC4 Offset: 0x7CB9BC4 VA: 0x7CBDBC4
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x7CC883C Offset: 0x7CC483C VA: 0x7CC883C
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x7CBFCB4 Offset: 0x7CBBCB4 VA: 0x7CBFCB4
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x7CC86C8 Offset: 0x7CC46C8 VA: 0x7CC86C8
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x7CC860C Offset: 0x7CC460C VA: 0x7CC860C
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x7CC8168 Offset: 0x7CC4168 VA: 0x7CC8168
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x7CC8AA0 Offset: 0x7CC4AA0 VA: 0x7CC8AA0
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x7CBF3E0 Offset: 0x7CBB3E0 VA: 0x7CBF3E0
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 19559
{
	// Fields
	[Nullable(2)]
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x7CC8C7C Offset: 0x7CC4C7C VA: 0x7CC8C7C
	public void .ctor(JsonSerializer serializer) { }

	[NullableContext(2)]
	// RVA: 0x7CC8D08 Offset: 0x7CC4D08 VA: 0x7CC8D08
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x7CC9AA4 Offset: 0x7CC5AA4 VA: 0x7CC9AA4
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x7CC8FA8 Offset: 0x7CC4FA8 VA: 0x7CC8FA8
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x7CC9BA4 Offset: 0x7CC5BA4 VA: 0x7CC9BA4
	private JsonContract GetContract(object value) { }

	// RVA: 0x7CC9C68 Offset: 0x7CC5C68 VA: 0x7CC9C68
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CC93D0 Offset: 0x7CC53D0 VA: 0x7CC93D0
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CCCD50 Offset: 0x7CC8D50 VA: 0x7CCCD50
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CC8FB8 Offset: 0x7CC4FB8 VA: 0x7CC8FB8
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CCCE0C Offset: 0x7CC8E0C VA: 0x7CCCE0C
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	// RVA: 0x7CCCEE4 Offset: 0x7CC8EE4 VA: 0x7CCCEE4
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x7CC914C Offset: 0x7CC514C VA: 0x7CC914C
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x7CCD454 Offset: 0x7CC9454 VA: 0x7CCD454
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x7CCD640 Offset: 0x7CC9640 VA: 0x7CCD640
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x7CCB800 Offset: 0x7CC7800 VA: 0x7CCB800
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x7CCD954 Offset: 0x7CC9954 VA: 0x7CCD954
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x7CCDB5C Offset: 0x7CC9B5C VA: 0x7CCDB5C
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x7CCA7A8 Offset: 0x7CC67A8 VA: 0x7CCA7A8
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCDEA8 Offset: 0x7CC9EA8 VA: 0x7CCDEA8
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x7CCDD64 Offset: 0x7CC9D64 VA: 0x7CCDD64
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCECB4 Offset: 0x7CCACB4 VA: 0x7CCECB4
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0x7CCED68 Offset: 0x7CCAD68 VA: 0x7CCED68
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x7CCA004 Offset: 0x7CC6004 VA: 0x7CCA004
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0x7CCCED8 Offset: 0x7CC8ED8 VA: 0x7CCCED8
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x7CCCE00 Offset: 0x7CC8E00 VA: 0x7CCCE00
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0x7CCEFB4 Offset: 0x7CCAFB4 VA: 0x7CCEFB4
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x7CCA284 Offset: 0x7CC6284 VA: 0x7CCA284
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCAEFC Offset: 0x7CC6EFC VA: 0x7CCAEFC
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCB5FC Offset: 0x7CC75FC VA: 0x7CCB5FC
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCF274 Offset: 0x7CCB274 VA: 0x7CCF274
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x7CCEFC0 Offset: 0x7CCAFC0 VA: 0x7CCEFC0
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCC8D8 Offset: 0x7CC88D8 VA: 0x7CCC8D8
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCC138 Offset: 0x7CC8138 VA: 0x7CCC138
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x7CCF5E8 Offset: 0x7CCB5E8 VA: 0x7CCF5E8
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	// RVA: 0x7CC9DD8 Offset: 0x7CC5DD8 VA: 0x7CC9DD8
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCB884 Offset: 0x7CC7884 VA: 0x7CCB884
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x7CCE300 Offset: 0x7CCA300 VA: 0x7CCE300
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x7CC9A30 Offset: 0x7CC5A30 VA: 0x7CC9A30
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x7CCE7F4 Offset: 0x7CCA7F4 VA: 0x7CCE7F4
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x7CCEA54 Offset: 0x7CCAA54 VA: 0x7CCEA54
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 19560
{
	// Fields
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Properties
	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver { set; }
	[Nullable(2)]
	public override ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { get; set; }
	public override ObjectCreationHandling ObjectCreationHandling { set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override ISerializationBinder SerializationBinder { set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override Nullable<int> MaxDepth { get; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x7CCF6A4 Offset: 0x7CCB6A4 VA: 0x7CCF6A4 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x7CCF6C4 Offset: 0x7CCB6C4 VA: 0x7CCF6C4 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x7CCF6E4 Offset: 0x7CCB6E4 VA: 0x7CCF6E4 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[NullableContext(2)]
	// RVA: 0x7CCF704 Offset: 0x7CCB704 VA: 0x7CCF704 Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x7CCF724 Offset: 0x7CCB724 VA: 0x7CCF724 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x7CCF744 Offset: 0x7CCB744 VA: 0x7CCF744 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x7CCF764 Offset: 0x7CCB764 VA: 0x7CCF764 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x7CCF788 Offset: 0x7CCB788 VA: 0x7CCF788 Slot: 18
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x7CCF7AC Offset: 0x7CCB7AC VA: 0x7CCF7AC Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x7CCF7D0 Offset: 0x7CCB7D0 VA: 0x7CCF7D0 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x7CCF7F4 Offset: 0x7CCB7F4 VA: 0x7CCF7F4 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x7CCF818 Offset: 0x7CCB818 VA: 0x7CCF818 Slot: 16
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0x7CCF83C Offset: 0x7CCB83C VA: 0x7CCF83C Slot: 17
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x7CCF860 Offset: 0x7CCB860 VA: 0x7CCF860 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x7CCF884 Offset: 0x7CCB884 VA: 0x7CCF884 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x7CCF8A8 Offset: 0x7CCB8A8 VA: 0x7CCF8A8 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x7CCF8CC Offset: 0x7CCB8CC VA: 0x7CCF8CC Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x7CCF8EC Offset: 0x7CCB8EC VA: 0x7CCF8EC Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x7CCF910 Offset: 0x7CCB910 VA: 0x7CCF910 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x7CCF934 Offset: 0x7CCB934 VA: 0x7CCF934 Slot: 12
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x7CCF954 Offset: 0x7CCB954 VA: 0x7CCF954 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x7CCF978 Offset: 0x7CCB978 VA: 0x7CCF978 Slot: 7
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0x7CCF998 Offset: 0x7CCB998 VA: 0x7CCF998 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x7CCF9BC Offset: 0x7CCB9BC VA: 0x7CCF9BC Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x7CCF9E0 Offset: 0x7CCB9E0 VA: 0x7CCF9E0 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x7CCFA04 Offset: 0x7CCBA04 VA: 0x7CCFA04 Slot: 29
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x7CCFA28 Offset: 0x7CCBA28 VA: 0x7CCFA28 Slot: 30
	public override Nullable<int> get_MaxDepth() { }

	// RVA: 0x7CCFA4C Offset: 0x7CCBA4C VA: 0x7CCFA4C Slot: 31
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x7CCFA70 Offset: 0x7CCBA70 VA: 0x7CCFA70 Slot: 32
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x7CCFA98 Offset: 0x7CCBA98 VA: 0x7CCFA98
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x7CBF4BC Offset: 0x7CBB4BC VA: 0x7CBF4BC
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x7CC9B18 Offset: 0x7CC5B18 VA: 0x7CC9B18
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	[NullableContext(2)]
	// RVA: 0x7CCFAB4 Offset: 0x7CCBAB4 VA: 0x7CCFAB4 Slot: 34
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x7CCFAE8 Offset: 0x7CCBAE8 VA: 0x7CCFAE8 Slot: 33
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x7CCFB18 Offset: 0x7CCBB18 VA: 0x7CCFB18 Slot: 35
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 19561
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7CCFB48 Offset: 0x7CCBB48 VA: 0x7CCFB48
	public void .ctor(Type underlyingType) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonTypeReflector.<>c // TypeDefIndex: 19562
{
	// Fields
	[Nullable(0)]
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<object, Type> <>9__22_1; // 0x8

	// Methods

	// RVA: 0x7CD0B14 Offset: 0x7CCCB14 VA: 0x7CD0B14
	private static void .cctor() { }

	// RVA: 0x7CD0B7C Offset: 0x7CCCB7C VA: 0x7CD0B7C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CD0B84 Offset: 0x7CCCB84 VA: 0x7CD0B84
	internal Type <GetCreator>b__22_1(object param) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonTypeReflector.<>c__DisplayClass22_0 // TypeDefIndex: 19563
{
	// Fields
	[Nullable(0)]
	public Type type; // 0x10
	[Nullable(new[] { 0, 1 })]
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x7CD05B8 Offset: 0x7CCC5B8 VA: 0x7CD05B8
	public void .ctor() { }

	// RVA: 0x7CD0BE0 Offset: 0x7CCCBE0 VA: 0x7CD0BE0
	internal object <GetCreator>b__0(object[] parameters) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal static class JsonTypeReflector // TypeDefIndex: 19564
{
	// Fields
	private static Nullable<bool> _fullyTrusted; // 0x0
	[Nullable(new[] { 1, 1, 1, 2, 1, 1 })]
	private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache; // 0x8
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4654684 Offset: 0x4650684 VA: 0x4654684
	|-JsonTypeReflector.GetCachedAttribute<object>
	*/

	// RVA: 0x7CCD758 Offset: 0x7CC9758 VA: 0x7CCD758
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0x7CCFBB8 Offset: 0x7CCBBB8 VA: 0x7CCFBB8
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x7CCFC84 Offset: 0x7CCBC84 VA: 0x7CCFC84
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x7CCFF0C Offset: 0x7CCBF0C VA: 0x7CCFF0C
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x7CD0060 Offset: 0x7CCC060 VA: 0x7CD0060
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x7CD0180 Offset: 0x7CCC180 VA: 0x7CD0180
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0x7CD0274 Offset: 0x7CCC274 VA: 0x7CD0274
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0x7CD0368 Offset: 0x7CCC368 VA: 0x7CD0368
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0x7CD0434 Offset: 0x7CCC434 VA: 0x7CD0434
	private static Func<object[], object> GetCreator(Type type) { }

	// RVA: 0x7CD0648 Offset: 0x7CCC648 VA: 0x7CD0648
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x7CD06C8 Offset: 0x7CCC6C8 VA: 0x7CD06C8
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46544E4 Offset: 0x46504E4 VA: 0x46544E4
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4654110 Offset: 0x4650110 VA: 0x4654110
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x7CD0910 Offset: 0x7CCC910 VA: 0x7CD0910
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0x7CCFFE4 Offset: 0x7CCBFE4 VA: 0x7CCFFE4
	public static bool IsSerializable(object provider) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4654390 Offset: 0x4650390 VA: 0x4654390
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x7CBB13C Offset: 0x7CB713C VA: 0x7CBB13C
	public static bool get_FullyTrusted() { }

	// RVA: 0x7CD05C0 Offset: 0x7CCC5C0 VA: 0x7CD05C0
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x7CD098C Offset: 0x7CCC98C VA: 0x7CD098C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy : NamingStrategy // TypeDefIndex: 19565
{
	// Methods

	// RVA: 0x7CD1018 Offset: 0x7CCD018 VA: 0x7CD1018
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x7CD1058 Offset: 0x7CCD058 VA: 0x7CD1058
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x7CD10A4 Offset: 0x7CCD0A4 VA: 0x7CD10A4
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x7CD10AC Offset: 0x7CCD0AC VA: 0x7CD10AC Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class NamingStrategy // TypeDefIndex: 19566
{
	// Fields
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Properties
	public bool ProcessDictionaryKeys { get; set; }
	public bool ProcessExtensionDataNames { get; set; }
	public bool OverrideSpecifiedNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CD10B8 Offset: 0x7CCD0B8 VA: 0x7CD10B8
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	// RVA: 0x7CD10C0 Offset: 0x7CCD0C0 VA: 0x7CD10C0
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CD10CC Offset: 0x7CCD0CC VA: 0x7CD10CC
	public bool get_ProcessExtensionDataNames() { }

	[CompilerGenerated]
	// RVA: 0x7CD10D4 Offset: 0x7CCD0D4 VA: 0x7CD10D4
	public void set_ProcessExtensionDataNames(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7CD10E0 Offset: 0x7CCD0E0 VA: 0x7CD10E0
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	// RVA: 0x7CD10E8 Offset: 0x7CCD0E8 VA: 0x7CD10E8
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0x7CD10F4 Offset: 0x7CCD0F4 VA: 0x7CD10F4 Slot: 4
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0x7CD1114 Offset: 0x7CCD114 VA: 0x7CD1114 Slot: 5
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0x7CD1130 Offset: 0x7CCD130 VA: 0x7CD1130 Slot: 6
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ResolvePropertyName(string name);

	// RVA: 0x7CD114C Offset: 0x7CCD14C VA: 0x7CD114C Slot: 2
	public override int GetHashCode() { }

	[NullableContext(2)]
	// RVA: 0x7CD122C Offset: 0x7CCD22C VA: 0x7CD122C Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	// RVA: 0x7CD12AC Offset: 0x7CCD2AC VA: 0x7CD12AC
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0x7CD1050 Offset: 0x7CCD050 VA: 0x7CD1050
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T> : MulticastDelegate // TypeDefIndex: 19567
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5165C5C Offset: 0x5161C5C VA: 0x5165C5C
	|-ObjectConstructor<object>..ctor
	|
	|-RVA: 0x5165D78 Offset: 0x5161D78 VA: 0x5165D78
	|-ObjectConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5165D64 Offset: 0x5161D64 VA: 0x5165D64
	|-ObjectConstructor<object>.Invoke
	|
	|-RVA: 0x5165E80 Offset: 0x5161E80 VA: 0x5165E80
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Newtonsoft.Json.Serialization
[Usage(64, Inherited = False)]
public sealed class OnErrorAttribute : Attribute // TypeDefIndex: 19568
{}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionAttributeProvider : IAttributeProvider // TypeDefIndex: 19569
{
	// Fields
	private readonly object _attributeProvider; // 0x10

	// Methods

	// RVA: 0x7CD13A8 Offset: 0x7CCD3A8 VA: 0x7CD13A8
	public void .ctor(object attributeProvider) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 19570
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0x7CD141C Offset: 0x7CCD41C VA: 0x7CD141C
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0x7CD1490 Offset: 0x7CCD490 VA: 0x7CD1490 Slot: 4
	public void SetValue(object target, object value) { }

	// RVA: 0x7CD1630 Offset: 0x7CCD630 VA: 0x7CD1630 Slot: 5
	public object GetValue(object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy : NamingStrategy // TypeDefIndex: 19571
{
	// Methods

	// RVA: 0x7CD18CC Offset: 0x7CCD8CC VA: 0x7CD18CC
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x7CD1904 Offset: 0x7CCD904 VA: 0x7CD1904
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x7CD1950 Offset: 0x7CCD950 VA: 0x7CD1950
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x7CD1958 Offset: 0x7CCD958 VA: 0x7CD1958 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 19572
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	[Nullable(2)]
	public override object Value { get; }
	[Nullable(2)]
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x7CD1964 Offset: 0x7CCD964 VA: 0x7CD1964
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x7CD1AD0 Offset: 0x7CCDAD0 VA: 0x7CD1AD0
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x7CD1AF0 Offset: 0x7CCDAF0 VA: 0x7CD1AF0 Slot: 11
	public override bool Read() { }

	// RVA: 0x7CD1B68 Offset: 0x7CCDB68 VA: 0x7CD1B68 Slot: 12
	public override Nullable<int> ReadAsInt32() { }

	[NullableContext(2)]
	// RVA: 0x7CD1BA8 Offset: 0x7CCDBA8 VA: 0x7CD1BA8 Slot: 13
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x7CD1BEC Offset: 0x7CCDBEC VA: 0x7CD1BEC Slot: 14
	public override byte[] ReadAsBytes() { }

	// RVA: 0x7CD1C30 Offset: 0x7CCDC30 VA: 0x7CD1C30 Slot: 17
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x7CD1CAC Offset: 0x7CCDCAC VA: 0x7CD1CAC Slot: 15
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x7CD1CF8 Offset: 0x7CCDCF8 VA: 0x7CD1CF8 Slot: 16
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x7CD1D3C Offset: 0x7CCDD3C VA: 0x7CD1D3C Slot: 18
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x7CD1D88 Offset: 0x7CCDD88 VA: 0x7CD1D88 Slot: 19
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x7CD1B30 Offset: 0x7CCDB30 VA: 0x7CD1B30
	public void WriteCurrentToken() { }

	// RVA: 0x7CD1DE4 Offset: 0x7CCDDE4 VA: 0x7CD1DE4 Slot: 9
	public override int get_Depth() { }

	// RVA: 0x7CD1E04 Offset: 0x7CCDE04 VA: 0x7CD1E04 Slot: 10
	public override string get_Path() { }

	// RVA: 0x7CD1E24 Offset: 0x7CCDE24 VA: 0x7CD1E24 Slot: 6
	public override JsonToken get_TokenType() { }

	[NullableContext(2)]
	// RVA: 0x7CD1E44 Offset: 0x7CCDE44 VA: 0x7CD1E44 Slot: 7
	public override object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x7CD1E64 Offset: 0x7CCDE64 VA: 0x7CD1E64 Slot: 8
	public override Type get_ValueType() { }

	// RVA: 0x7CD1E84 Offset: 0x7CCDE84 VA: 0x7CD1E84 Slot: 21
	public override void Close() { }

	// RVA: 0x7CD1EA8 Offset: 0x7CCDEA8 VA: 0x7CD1EA8 Slot: 22
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x7CD1F5C Offset: 0x7CCDF5C VA: 0x7CD1F5C Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x7CD2014 Offset: 0x7CCE014 VA: 0x7CD2014 Slot: 24
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 19573
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x7CD20CC Offset: 0x7CCE0CC VA: 0x7CD20CC
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x7CD22D4 Offset: 0x7CCE2D4 VA: 0x7CD22D4
	public string GetSerializedJsonMessage() { }

	// RVA: 0x7CD22F4 Offset: 0x7CCE2F4 VA: 0x7CD22F4 Slot: 92
	public override void WriteValue(Decimal value) { }

	// RVA: 0x7CD2360 Offset: 0x7CCE360 VA: 0x7CD2360 Slot: 109
	public override void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x7CD247C Offset: 0x7CCE47C VA: 0x7CD247C Slot: 86
	public override void WriteValue(bool value) { }

	// RVA: 0x7CD24E0 Offset: 0x7CCE4E0 VA: 0x7CD24E0 Slot: 103
	public override void WriteValue(Nullable<bool> value) { }

	// RVA: 0x7CD2594 Offset: 0x7CCE594 VA: 0x7CD2594 Slot: 90
	public override void WriteValue(byte value) { }

	// RVA: 0x7CD25F4 Offset: 0x7CCE5F4 VA: 0x7CD25F4 Slot: 107
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x7CD26A4 Offset: 0x7CCE6A4 VA: 0x7CD26A4 Slot: 89
	public override void WriteValue(char value) { }

	// RVA: 0x7CD2704 Offset: 0x7CCE704 VA: 0x7CD2704 Slot: 106
	public override void WriteValue(Nullable<char> value) { }

	[NullableContext(2)]
	// RVA: 0x7CD27B4 Offset: 0x7CCE7B4 VA: 0x7CD27B4 Slot: 114
	public override void WriteValue(byte[] value) { }

	// RVA: 0x7CD2828 Offset: 0x7CCE828 VA: 0x7CD2828 Slot: 93
	public override void WriteValue(DateTime value) { }

	// RVA: 0x7CD2888 Offset: 0x7CCE888 VA: 0x7CD2888 Slot: 110
	public override void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x7CD2948 Offset: 0x7CCE948 VA: 0x7CD2948 Slot: 94
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x7CD29B4 Offset: 0x7CCE9B4 VA: 0x7CD29B4 Slot: 111
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x7CD2AA8 Offset: 0x7CCEAA8 VA: 0x7CD2AA8 Slot: 85
	public override void WriteValue(double value) { }

	// RVA: 0x7CD2B08 Offset: 0x7CCEB08 VA: 0x7CD2B08 Slot: 102
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x7CD2BCC Offset: 0x7CCEBCC VA: 0x7CD2BCC Slot: 76
	public override void WriteUndefined() { }

	// RVA: 0x7CD2C18 Offset: 0x7CCEC18 VA: 0x7CD2C18 Slot: 75
	public override void WriteNull() { }

	// RVA: 0x7CD2C64 Offset: 0x7CCEC64 VA: 0x7CD2C64 Slot: 84
	public override void WriteValue(float value) { }

	// RVA: 0x7CD2CC4 Offset: 0x7CCECC4 VA: 0x7CD2CC4 Slot: 101
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x7CD2D74 Offset: 0x7CCED74 VA: 0x7CD2D74 Slot: 95
	public override void WriteValue(Guid value) { }

	// RVA: 0x7CD2DE0 Offset: 0x7CCEDE0 VA: 0x7CD2DE0 Slot: 112
	public override void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x7CD2ED8 Offset: 0x7CCEED8 VA: 0x7CD2ED8 Slot: 80
	public override void WriteValue(int value) { }

	// RVA: 0x7CD2F38 Offset: 0x7CCEF38 VA: 0x7CD2F38 Slot: 97
	public override void WriteValue(Nullable<int> value) { }

	// RVA: 0x7CD2FE4 Offset: 0x7CCEFE4 VA: 0x7CD2FE4 Slot: 82
	public override void WriteValue(long value) { }

	// RVA: 0x7CD3044 Offset: 0x7CCF044 VA: 0x7CD3044 Slot: 99
	public override void WriteValue(Nullable<long> value) { }

	[NullableContext(2)]
	// RVA: 0x7CD3104 Offset: 0x7CCF104 VA: 0x7CD3104 Slot: 116
	public override void WriteValue(object value) { }

	// RVA: 0x7CD31D0 Offset: 0x7CCF1D0 VA: 0x7CD31D0 Slot: 91
	public override void WriteValue(sbyte value) { }

	// RVA: 0x7CD3230 Offset: 0x7CCF230 VA: 0x7CD3230 Slot: 108
	public override void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x7CD32E0 Offset: 0x7CCF2E0 VA: 0x7CD32E0 Slot: 87
	public override void WriteValue(short value) { }

	// RVA: 0x7CD3340 Offset: 0x7CCF340 VA: 0x7CD3340 Slot: 104
	public override void WriteValue(Nullable<short> value) { }

	[NullableContext(2)]
	// RVA: 0x7CD33F0 Offset: 0x7CCF3F0 VA: 0x7CD33F0 Slot: 79
	public override void WriteValue(string value) { }

	// RVA: 0x7CD3450 Offset: 0x7CCF450 VA: 0x7CD3450 Slot: 96
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x7CD34B0 Offset: 0x7CCF4B0 VA: 0x7CD34B0 Slot: 113
	public override void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0x7CD3570 Offset: 0x7CCF570 VA: 0x7CD3570 Slot: 81
	public override void WriteValue(uint value) { }

	// RVA: 0x7CD35D0 Offset: 0x7CCF5D0 VA: 0x7CD35D0 Slot: 98
	public override void WriteValue(Nullable<uint> value) { }

	// RVA: 0x7CD367C Offset: 0x7CCF67C VA: 0x7CD367C Slot: 83
	public override void WriteValue(ulong value) { }

	// RVA: 0x7CD36DC Offset: 0x7CCF6DC VA: 0x7CD36DC Slot: 100
	public override void WriteValue(Nullable<ulong> value) { }

	[NullableContext(2)]
	// RVA: 0x7CD379C Offset: 0x7CCF79C VA: 0x7CD379C Slot: 115
	public override void WriteValue(Uri value) { }

	// RVA: 0x7CD3860 Offset: 0x7CCF860 VA: 0x7CD3860 Slot: 88
	public override void WriteValue(ushort value) { }

	// RVA: 0x7CD38C0 Offset: 0x7CCF8C0 VA: 0x7CD38C0 Slot: 105
	public override void WriteValue(Nullable<ushort> value) { }

	[NullableContext(2)]
	// RVA: 0x7CD3970 Offset: 0x7CCF970 VA: 0x7CD3970 Slot: 117
	public override void WriteComment(string text) { }

	// RVA: 0x7CD39D0 Offset: 0x7CCF9D0 VA: 0x7CD39D0 Slot: 63
	public override void WriteStartArray() { }

	// RVA: 0x7CD3A1C Offset: 0x7CCFA1C VA: 0x7CD3A1C Slot: 64
	public override void WriteEndArray() { }

	// RVA: 0x7CD3A68 Offset: 0x7CCFA68 VA: 0x7CD3A68 Slot: 65
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x7CD3AC8 Offset: 0x7CCFAC8 VA: 0x7CD3AC8 Slot: 66
	public override void WriteEndConstructor() { }

	// RVA: 0x7CD3B14 Offset: 0x7CCFB14 VA: 0x7CD3B14 Slot: 67
	public override void WritePropertyName(string name) { }

	// RVA: 0x7CD3B74 Offset: 0x7CCFB74 VA: 0x7CD3B74 Slot: 68
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x7CD3BE0 Offset: 0x7CCFBE0 VA: 0x7CD3BE0 Slot: 61
	public override void WriteStartObject() { }

	// RVA: 0x7CD3C2C Offset: 0x7CCFC2C VA: 0x7CD3C2C Slot: 62
	public override void WriteEndObject() { }

	[NullableContext(2)]
	// RVA: 0x7CD3C78 Offset: 0x7CCFC78 VA: 0x7CD3C78 Slot: 78
	public override void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x7CD3CD8 Offset: 0x7CCFCD8 VA: 0x7CD3CD8 Slot: 77
	public override void WriteRaw(string json) { }

	// RVA: 0x7CD3D38 Offset: 0x7CCFD38 VA: 0x7CD3D38 Slot: 60
	public override void Close() { }
}

// Namespace: Newtonsoft.Json.Linq
public enum CommentHandling // TypeDefIndex: 19574
{
	// Fields
	public int value__; // 0x0
	public const CommentHandling Ignore = 0;
	public const CommentHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum DuplicatePropertyNameHandling // TypeDefIndex: 19575
{
	// Fields
	public int value__; // 0x0
	public const DuplicatePropertyNameHandling Replace = 0;
	public const DuplicatePropertyNameHandling Ignore = 1;
	public const DuplicatePropertyNameHandling Error = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c // TypeDefIndex: 19576
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JObject, IEnumerable<JProperty>> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x7CD3F70 Offset: 0x7CCFF70 VA: 0x7CD3F70
	private static void .cctor() { }

	// RVA: 0x7CD3FD8 Offset: 0x7CCFFD8 VA: 0x7CD3FD8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CD3FE0 Offset: 0x7CCFFE0 VA: 0x7CD3FE0
	internal IEnumerable<JProperty> <Properties>b__4_0(JObject d) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c__0<T> // TypeDefIndex: 19577
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c__0<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, IEnumerable<JToken>> <>9__0_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856544 Offset: 0x4852544 VA: 0x4856544
	|-Extensions.<>c__0<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856600 Offset: 0x4852600 VA: 0x4856600
	|-Extensions.<>c__0<object>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IEnumerable<JToken> <Ancestors>b__0_0(T j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856608 Offset: 0x4852608 VA: 0x4856608
	|-Extensions.<>c__0<object>.<Ancestors>b__0_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c__1<T> // TypeDefIndex: 19578
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c__1<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, IEnumerable<JToken>> <>9__1_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858FFC Offset: 0x4854FFC VA: 0x4858FFC
	|-Extensions.<>c__1<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48590B8 Offset: 0x48550B8 VA: 0x48590B8
	|-Extensions.<>c__1<object>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IEnumerable<JToken> <AncestorsAndSelf>b__1_0(T j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48590C0 Offset: 0x48550C0 VA: 0x48590C0
	|-Extensions.<>c__1<object>.<AncestorsAndSelf>b__1_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c__13<T, U> // TypeDefIndex: 19579
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c__13<T, U> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, IEnumerable<JToken>> <>9__13_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858D5C Offset: 0x4854D5C VA: 0x4858D5C
	|-Extensions.<>c__13<object, object>..cctor
	|
	|-RVA: 0x4858E90 Offset: 0x4854E90 VA: 0x4858E90
	|-Extensions.<>c__13<object, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858E18 Offset: 0x4854E18 VA: 0x4858E18
	|-Extensions.<>c__13<object, object>..ctor
	|
	|-RVA: 0x4858F84 Offset: 0x4854F84 VA: 0x4858F84
	|-Extensions.<>c__13<object, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IEnumerable<JToken> <Children>b__13_0(T c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4858E20 Offset: 0x4854E20 VA: 0x4858E20
	|-Extensions.<>c__13<object, object>.<Children>b__13_0
	|
	|-RVA: 0x4858F8C Offset: 0x4854F8C VA: 0x4858F8C
	|-Extensions.<>c__13<object, __Il2CppFullySharedGenericType>.<Children>b__13_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c__2<T> // TypeDefIndex: 19580
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c__2<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, IEnumerable<JToken>> <>9__2_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48594E8 Offset: 0x48554E8 VA: 0x48594E8
	|-Extensions.<>c__2<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48595A4 Offset: 0x48555A4 VA: 0x48595A4
	|-Extensions.<>c__2<object>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IEnumerable<JToken> <Descendants>b__2_0(T j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48595AC Offset: 0x48555AC VA: 0x48595AC
	|-Extensions.<>c__2<object>.<Descendants>b__2_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extensions.<>c__3<T> // TypeDefIndex: 19581
{
	// Fields
	[Nullable(0)]
	public static readonly Extensions.<>c__3<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, IEnumerable<JToken>> <>9__3_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485ADB0 Offset: 0x4856DB0 VA: 0x485ADB0
	|-Extensions.<>c__3<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485AE6C Offset: 0x4856E6C VA: 0x485AE6C
	|-Extensions.<>c__3<object>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IEnumerable<JToken> <DescendantsAndSelf>b__3_0(T j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485AE74 Offset: 0x4856E74 VA: 0x485AE74
	|-Extensions.<>c__3<object>.<DescendantsAndSelf>b__3_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Extensions.<Convert>d__14<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable // TypeDefIndex: 19582
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(2)]
	private U <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<T> source; // 0x0
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<T> <>3__source; // 0x0
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<T> <>7__wrap1; // 0x0

	// Properties
	private U System.Collections.Generic.IEnumerator<U>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD4D00 Offset: 0x5BD0D00 VA: 0x5BD4D00
	|-Extensions.<Convert>d__14<object, object>..ctor
	|
	|-RVA: 0x5BD51E0 Offset: 0x5BD11E0 VA: 0x5BD51E0
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD4D34 Offset: 0x5BD0D34 VA: 0x5BD4D34
	|-Extensions.<Convert>d__14<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5BD5248 Offset: 0x5BD1248 VA: 0x5BD5248
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD4D50 Offset: 0x5BD0D50 VA: 0x5BD4D50
	|-Extensions.<Convert>d__14<object, object>.MoveNext
	|
	|-RVA: 0x5BD52A8 Offset: 0x5BD12A8 VA: 0x5BD52A8
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5048 Offset: 0x5BD1048 VA: 0x5BD5048
	|-Extensions.<Convert>d__14<object, object>.<>m__Finally1
	|
	|-RVA: 0x5BD572C Offset: 0x5BD172C VA: 0x5BD572C
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private U System.Collections.Generic.IEnumerator<U>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD50F8 Offset: 0x5BD10F8 VA: 0x5BD50F8
	|-Extensions.<Convert>d__14<object, object>.System.Collections.Generic.IEnumerator<U>.get_Current
	|
	|-RVA: 0x5BD5838 Offset: 0x5BD1838 VA: 0x5BD5838
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<U>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5100 Offset: 0x5BD1100 VA: 0x5BD5100
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5BD58D8 Offset: 0x5BD18D8 VA: 0x5BD58D8
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5134 Offset: 0x5BD1134 VA: 0x5BD5134
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5BD590C Offset: 0x5BD190C VA: 0x5BD590C
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD513C Offset: 0x5BD113C VA: 0x5BD513C
	|-Extensions.<Convert>d__14<object, object>.System.Collections.Generic.IEnumerable<U>.GetEnumerator
	|
	|-RVA: 0x5BD59B0 Offset: 0x5BD19B0 VA: 0x5BD59B0
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<U>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD51D0 Offset: 0x5BD11D0 VA: 0x5BD51D0
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BD5AC0 Offset: 0x5BD1AC0 VA: 0x5BD5AC0
	|-Extensions.<Convert>d__14<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Extensions.<Values>d__11<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable // TypeDefIndex: 19583
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(2)]
	private U <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<T> source; // 0x0
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<T> <>3__source; // 0x0
	[Nullable(0)]
	private object key; // 0x0
	[Nullable(0)]
	public object <>3__key; // 0x0
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<T> <>7__wrap1; // 0x0
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap2; // 0x0

	// Properties
	private U System.Collections.Generic.IEnumerator<U>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E50958 Offset: 0x5E4C958 VA: 0x5E50958
	|-Extensions.<Values>d__11<object, object>..ctor
	|
	|-RVA: 0x5E514D4 Offset: 0x5E4D4D4 VA: 0x5E514D4
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E5098C Offset: 0x5E4C98C VA: 0x5E5098C
	|-Extensions.<Values>d__11<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5E5153C Offset: 0x5E4D53C VA: 0x5E5153C
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E50A6C Offset: 0x5E4CA6C VA: 0x5E50A6C
	|-Extensions.<Values>d__11<object, object>.MoveNext
	|
	|-RVA: 0x5E51684 Offset: 0x5E4D684 VA: 0x5E51684
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E511CC Offset: 0x5E4D1CC VA: 0x5E511CC
	|-Extensions.<Values>d__11<object, object>.<>m__Finally1
	|
	|-RVA: 0x5E5216C Offset: 0x5E4E16C VA: 0x5E5216C
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E5127C Offset: 0x5E4D27C VA: 0x5E5127C
	|-Extensions.<Values>d__11<object, object>.<>m__Finally2
	|
	|-RVA: 0x5E52278 Offset: 0x5E4E278 VA: 0x5E52278
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E5132C Offset: 0x5E4D32C VA: 0x5E5132C
	|-Extensions.<Values>d__11<object, object>.<>m__Finally3
	|
	|-RVA: 0x5E52384 Offset: 0x5E4E384 VA: 0x5E52384
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.<>m__Finally3
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private U System.Collections.Generic.IEnumerator<U>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E513DC Offset: 0x5E4D3DC VA: 0x5E513DC
	|-Extensions.<Values>d__11<object, object>.System.Collections.Generic.IEnumerator<U>.get_Current
	|
	|-RVA: 0x5E52490 Offset: 0x5E4E490 VA: 0x5E52490
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<U>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E513E4 Offset: 0x5E4D3E4 VA: 0x5E513E4
	|-Extensions.<Values>d__11<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5E52530 Offset: 0x5E4E530 VA: 0x5E52530
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E51418 Offset: 0x5E4D418 VA: 0x5E51418
	|-Extensions.<Values>d__11<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5E52564 Offset: 0x5E4E564 VA: 0x5E52564
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E51420 Offset: 0x5E4D420 VA: 0x5E51420
	|-Extensions.<Values>d__11<object, object>.System.Collections.Generic.IEnumerable<U>.GetEnumerator
	|
	|-RVA: 0x5E52608 Offset: 0x5E4E608 VA: 0x5E52608
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<U>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E514C4 Offset: 0x5E4D4C4 VA: 0x5E514C4
	|-Extensions.<Values>d__11<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5E52754 Offset: 0x5E4E754 VA: 0x5E52754
	|-Extensions.<Values>d__11<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Newtonsoft.Json.Linq
[Extension]
[NullableContext(1)]
[Nullable(0)]
public static class Extensions // TypeDefIndex: 19584
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Ancestors<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9938 Offset: 0x45F5938 VA: 0x45F9938
	|-Extensions.Ancestors<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> AncestorsAndSelf<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9AA4 Offset: 0x45F5AA4 VA: 0x45F9AA4
	|-Extensions.AncestorsAndSelf<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Descendants<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FBB74 Offset: 0x45F7B74 VA: 0x45FBB74
	|-Extensions.Descendants<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> DescendantsAndSelf<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FBCE0 Offset: 0x45F7CE0 VA: 0x45FBCE0
	|-Extensions.DescendantsAndSelf<object>
	*/

	[Extension]
	// RVA: 0x7CD3D84 Offset: 0x7CCFD84 VA: 0x7CD3D84
	public static IJEnumerable<JProperty> Properties(IEnumerable<JObject> source) { }

	[Extension]
	// RVA: 0x7CD3EC4 Offset: 0x7CCFEC4 VA: 0x7CD3EC4
	public static IJEnumerable<JToken> Values(IEnumerable<JToken> source, object key) { }

	[Extension]
	// RVA: 0x7CD3F68 Offset: 0x7CCFF68 VA: 0x7CD3F68
	public static IJEnumerable<JToken> Values(IEnumerable<JToken> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Values<U>(IEnumerable<JToken> source, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC63C Offset: 0x45F863C VA: 0x45FC63C
	|-Extensions.Values<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Values<U>(IEnumerable<JToken> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC5FC Offset: 0x45F85FC VA: 0x45FC5FC
	|-Extensions.Values<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	public static U Value<U>(IEnumerable<JToken> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FBE4C Offset: 0x45F7E4C VA: 0x45FBE4C
	|-Extensions.Value<bool>
	|
	|-RVA: 0x45FBE84 Offset: 0x45F7E84 VA: 0x45FBE84
	|-Extensions.Value<double>
	|
	|-RVA: 0x45FBEBC Offset: 0x45F7EBC VA: 0x45FBEBC
	|-Extensions.Value<int>
	|
	|-RVA: 0x45FBEF4 Offset: 0x45F7EF4 VA: 0x45FBEF4
	|-Extensions.Value<long>
	|
	|-RVA: 0x45FBF2C Offset: 0x45F7F2C VA: 0x45FBF2C
	|-Extensions.Value<object>
	|
	|-RVA: 0x45FBF64 Offset: 0x45F7F64 VA: 0x45FBF64
	|-Extensions.Value<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static U Value<T, U>(IEnumerable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC01C Offset: 0x45F801C VA: 0x45FC01C
	|-Extensions.Value<object, bool>
	|
	|-RVA: 0x45FC100 Offset: 0x45F8100 VA: 0x45FC100
	|-Extensions.Value<object, double>
	|
	|-RVA: 0x45FC1E4 Offset: 0x45F81E4 VA: 0x45FC1E4
	|-Extensions.Value<object, int>
	|
	|-RVA: 0x45FC2C8 Offset: 0x45F82C8 VA: 0x45FC2C8
	|-Extensions.Value<object, long>
	|
	|-RVA: 0x45FC3AC Offset: 0x45F83AC VA: 0x45FC3AC
	|-Extensions.Value<object, object>
	|
	|-RVA: 0x45FC490 Offset: 0x45F8490 VA: 0x45FC490
	|-Extensions.Value<object, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Extensions.<Values>d__11<T, U>))]
	[Extension]
	// RVA: -1 Offset: -1
	internal static IEnumerable<U> Values<T, U>(IEnumerable<T> source, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC680 Offset: 0x45F8680 VA: 0x45FC680
	|-Extensions.Values<object, object>
	|
	|-RVA: 0x45FC708 Offset: 0x45F8708 VA: 0x45FC708
	|-Extensions.Values<object, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Children<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9CAC Offset: 0x45F5CAC VA: 0x45F9CAC
	|-Extensions.Children<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Children<T, U>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9CEC Offset: 0x45F5CEC VA: 0x45F9CEC
	|-Extensions.Children<object, object>
	|
	|-RVA: 0x45F9E5C Offset: 0x45F5E5C VA: 0x45F9E5C
	|-Extensions.Children<object, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(Extensions.<Convert>d__14<T, U>))]
	// RVA: -1 Offset: -1
	internal static IEnumerable<U> Convert<T, U>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FB53C Offset: 0x45F753C VA: 0x45FB53C
	|-Extensions.Convert<object, object>
	|
	|-RVA: 0x45FBAF0 Offset: 0x45F7AF0 VA: 0x45FBAF0
	|-Extensions.Convert<object, __Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	internal static U Convert<T, U>(T token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9FD0 Offset: 0x45F5FD0 VA: 0x45F9FD0
	|-Extensions.Convert<object, bool>
	|
	|-RVA: 0x45FA428 Offset: 0x45F6428 VA: 0x45FA428
	|-Extensions.Convert<object, double>
	|
	|-RVA: 0x45FA874 Offset: 0x45F6874 VA: 0x45FA874
	|-Extensions.Convert<object, int>
	|
	|-RVA: 0x45FACBC Offset: 0x45F6CBC VA: 0x45FACBC
	|-Extensions.Convert<object, long>
	|
	|-RVA: 0x45FB104 Offset: 0x45F7104 VA: 0x45FB104
	|-Extensions.Convert<object, object>
	|
	|-RVA: 0x45FB5B0 Offset: 0x45F75B0 VA: 0x45FB5B0
	|-Extensions.Convert<object, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7CD3F20 Offset: 0x7CCFF20 VA: 0x7CD3F20
	public static IJEnumerable<JToken> AsJEnumerable(IEnumerable<JToken> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<T> AsJEnumerable<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9C10 Offset: 0x45F5C10 VA: 0x45F9C10
	|-Extensions.AsJEnumerable<object>
	*/
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[DefaultMember("Item")]
public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 19585
{
	// Properties
	public abstract IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IJEnumerable<JToken> get_Item(object key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJEnumerable<object>.get_Item
	*/
}

// Namespace: 
[CompilerGenerated]
private struct JArray.<LoadAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 19586
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JArray> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x30
	[Nullable(0)]
	private JArray <a>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x7CD6784 Offset: 0x7CD2784 VA: 0x7CD6784 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CD6EF8 Offset: 0x7CD2EF8 VA: 0x7CD6EF8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JArray.<WriteToAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 19587
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonWriter writer; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JArray <>4__this; // 0x30
	[Nullable(new[] { 0, 1 })]
	public JsonConverter[] converters; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private int <i>5__2; // 0x50

	// Methods

	// RVA: 0x7CD6F74 Offset: 0x7CD2F74 VA: 0x7CD6F74 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CD73A4 Offset: 0x7CD33A4 VA: 0x7CD73A4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 19588
{
	// Fields
	private readonly List<JToken> _values; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	[AsyncStateMachine(typeof(JArray.<WriteToAsync>d__0))]
	// RVA: 0x7CD403C Offset: 0x7CD003C VA: 0x7CD403C Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JArray.<LoadAsync>d__2))]
	// RVA: 0x7CD416C Offset: 0x7CD016C VA: 0x7CD416C
	public static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CD429C Offset: 0x7CD029C VA: 0x7CD429C Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x7CD42A4 Offset: 0x7CD02A4 VA: 0x7CD42A4 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x7CD42AC Offset: 0x7CD02AC VA: 0x7CD42AC
	public void .ctor() { }

	// RVA: 0x7CD4388 Offset: 0x7CD0388 VA: 0x7CD4388
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0x7CD4788 Offset: 0x7CD0788 VA: 0x7CD4788
	public void .ctor(object content) { }

	// RVA: 0x7CD4828 Offset: 0x7CD0828 VA: 0x7CD4828 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x7CD4B84 Offset: 0x7CD0B84 VA: 0x7CD4B84 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x7CD4BEC Offset: 0x7CD0BEC VA: 0x7CD4BEC
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x7CD5090 Offset: 0x7CD1090 VA: 0x7CD5090 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x7CD5164 Offset: 0x7CD1164 VA: 0x7CD5164 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x7CD5288 Offset: 0x7CD1288 VA: 0x7CD5288 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x7CD53B4 Offset: 0x7CD13B4 VA: 0x7CD53B4 Slot: 27
	public JToken get_Item(int index) { }

	// RVA: 0x7CD53C4 Offset: 0x7CD13C4 VA: 0x7CD53C4 Slot: 28
	public void set_Item(int index, JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CD53D4 Offset: 0x7CD13D4 VA: 0x7CD53D4 Slot: 79
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x7CD5438 Offset: 0x7CD1438 VA: 0x7CD5438 Slot: 91
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x7CD6358 Offset: 0x7CD2358 VA: 0x7CD6358 Slot: 29
	public int IndexOf(JToken item) { }

	// RVA: 0x7CD6368 Offset: 0x7CD2368 VA: 0x7CD6368 Slot: 30
	public void Insert(int index, JToken item) { }

	// RVA: 0x7CD6380 Offset: 0x7CD2380 VA: 0x7CD6380 Slot: 31
	public void RemoveAt(int index) { }

	// RVA: 0x7CD6390 Offset: 0x7CD2390 VA: 0x7CD6390 Slot: 5
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x7CD6428 Offset: 0x7CD2428 VA: 0x7CD6428 Slot: 34
	public void Add(JToken item) { }

	// RVA: 0x7CD6438 Offset: 0x7CD2438 VA: 0x7CD6438 Slot: 35
	public void Clear() { }

	// RVA: 0x7CD6448 Offset: 0x7CD2448 VA: 0x7CD6448 Slot: 36
	public bool Contains(JToken item) { }

	// RVA: 0x7CD6458 Offset: 0x7CD2458 VA: 0x7CD6458 Slot: 37
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x7CD6468 Offset: 0x7CD2468 VA: 0x7CD6468 Slot: 33
	public bool get_IsReadOnly() { }

	// RVA: 0x7CD6470 Offset: 0x7CD2470 VA: 0x7CD6470 Slot: 38
	public bool Remove(JToken item) { }

	// RVA: 0x7CD6480 Offset: 0x7CD2480 VA: 0x7CD6480 Slot: 25
	internal override int GetDeepHashCode() { }
}

// Namespace: 
[CompilerGenerated]
private struct JConstructor.<LoadAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 19589
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JConstructor> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x30
	[Nullable(0)]
	private JConstructor <c>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x7CD8008 Offset: 0x7CD4008 VA: 0x7CD8008 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CD86A8 Offset: 0x7CD46A8 VA: 0x7CD86A8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JConstructor.<WriteToAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 19590
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonWriter writer; // 0x20
	[Nullable(0)]
	public JConstructor <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(new[] { 0, 1 })]
	public JsonConverter[] converters; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private int <i>5__2; // 0x50

	// Methods

	// RVA: 0x7CD8724 Offset: 0x7CD4724 VA: 0x7CD8724 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CD8B88 Offset: 0x7CD4B88 VA: 0x7CD8B88 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JConstructor : JContainer // TypeDefIndex: 19591
{
	// Fields
	[Nullable(2)]
	private string _name; // 0x58
	private readonly List<JToken> _values; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	[Nullable(2)]
	public string Name { get; set; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }

	// Methods

	[AsyncStateMachine(typeof(JConstructor.<WriteToAsync>d__0))]
	// RVA: 0x7CD740C Offset: 0x7CD340C VA: 0x7CD740C Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JConstructor.<LoadAsync>d__2))]
	// RVA: 0x7CD753C Offset: 0x7CD353C VA: 0x7CD753C
	public static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CD766C Offset: 0x7CD366C VA: 0x7CD766C Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	// RVA: 0x7CD7674 Offset: 0x7CD3674 VA: 0x7CD7674 Slot: 79
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x7CD76D8 Offset: 0x7CD36D8 VA: 0x7CD76D8 Slot: 91
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x7CD7794 Offset: 0x7CD3794 VA: 0x7CD7794
	public string get_Name() { }

	[NullableContext(2)]
	// RVA: 0x7CD779C Offset: 0x7CD379C VA: 0x7CD779C
	public void set_Name(string value) { }

	// RVA: 0x7CD77A4 Offset: 0x7CD37A4 VA: 0x7CD77A4 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x7CD77AC Offset: 0x7CD37AC VA: 0x7CD77AC
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0x7CD7860 Offset: 0x7CD3860 VA: 0x7CD7860
	public void .ctor(string name) { }

	// RVA: 0x7CD7994 Offset: 0x7CD3994 VA: 0x7CD7994 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x7CD7A34 Offset: 0x7CD3A34 VA: 0x7CD7A34 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x7CD7A9C Offset: 0x7CD3A9C VA: 0x7CD7A9C Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x7CD7B84 Offset: 0x7CD3B84 VA: 0x7CD7B84 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x7CD7CA8 Offset: 0x7CD3CA8 VA: 0x7CD7CA8 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x7CD7DD4 Offset: 0x7CD3DD4 VA: 0x7CD7DD4 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x7CD7E18 Offset: 0x7CD3E18 VA: 0x7CD7E18
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JContainer.<GetDescendants>d__36 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19592
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private bool self; // 0x24
	public bool <>3__self; // 0x25
	[Nullable(0)]
	public JContainer <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x30
	[Nullable(0)]
	private JToken <o>5__3; // 0x38
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap3; // 0x40

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CD99C4 Offset: 0x7CD59C4 VA: 0x7CD99C4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CDCBC4 Offset: 0x7CD8BC4 VA: 0x7CDCBC4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CDCC78 Offset: 0x7CD8C78 VA: 0x7CDCC78 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CDD254 Offset: 0x7CD9254 VA: 0x7CDD254
	private void <>m__Finally1() { }

	// RVA: 0x7CDD1A4 Offset: 0x7CD91A4 VA: 0x7CDD1A4
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CDD304 Offset: 0x7CD9304 VA: 0x7CDD304 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CDD30C Offset: 0x7CD930C VA: 0x7CDD30C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CDD344 Offset: 0x7CD9344 VA: 0x7CDD344 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CDD34C Offset: 0x7CD934C VA: 0x7CDD34C Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CDD3F8 Offset: 0x7CD93F8 VA: 0x7CDD3F8 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private struct JContainer.<ReadContentFromAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 19593
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	[Nullable(0)]
	public JContainer <>4__this; // 0x28
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x30
	public CancellationToken cancellationToken; // 0x38
	[Nullable(0)]
	private IJsonLineInfo <lineInfo>5__2; // 0x40
	[Nullable(0)]
	private JContainer <parent>5__3; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x7CDD3FC Offset: 0x7CD93FC VA: 0x7CDD3FC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CDDDC8 Offset: 0x7CD9DC8 VA: 0x7CDDDC8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JContainer.<ReadTokenFromAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 19594
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JContainer <>4__this; // 0x30
	[Nullable(0)]
	public JsonLoadSettings options; // 0x38
	private int <startDepth>5__2; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x7CDDE30 Offset: 0x7CD9E30 VA: 0x7CDDE30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CDE358 Offset: 0x7CDA358 VA: 0x7CDE358 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged // TypeDefIndex: 19595
{
	// Fields
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; // 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; // 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x40
	[Nullable(2)]
	private object _syncRoot; // 0x48
	private bool _busy; // 0x50

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	[Nullable(2)]
	public override JToken First { get; }
	[Nullable(2)]
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	[Nullable(2)]
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }

	// Methods

	[AsyncStateMachine(typeof(JContainer.<ReadTokenFromAsync>d__0))]
	// RVA: 0x7CD6DC8 Offset: 0x7CD2DC8 VA: 0x7CD6DC8
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JContainer.<ReadContentFromAsync>d__1))]
	// RVA: 0x7CD8BF0 Offset: 0x7CD4BF0 VA: 0x7CD8BF0
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CD8D20 Offset: 0x7CD4D20 VA: 0x7CD8D20 Slot: 51
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x7CD8DB0 Offset: 0x7CD4DB0 VA: 0x7CD8DB0 Slot: 52
	public void remove_ListChanged(ListChangedEventHandler value) { }

	[NullableContext(2)]
	// RVA: 0x7CD8E40 Offset: 0x7CD4E40 VA: 0x7CD8E40 Slot: 73
	public void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[NullableContext(2)]
	// RVA: 0x7CD8ED0 Offset: 0x7CD4ED0 VA: 0x7CD8ED0 Slot: 74
	public void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	// RVA: -1 Offset: -1 Slot: 75
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0x7CD4330 Offset: 0x7CD0330 VA: 0x7CD4330
	internal void .ctor() { }

	// RVA: 0x7CD4424 Offset: 0x7CD0424 VA: 0x7CD4424
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0x7CD9398 Offset: 0x7CD5398 VA: 0x7CD9398
	internal void CheckReentrancy() { }

	// RVA: 0x7CD9440 Offset: 0x7CD5440 VA: 0x7CD9440 Slot: 76
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x7CD9468 Offset: 0x7CD5468 VA: 0x7CD9468 Slot: 77
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x7CD94F0 Offset: 0x7CD54F0 VA: 0x7CD94F0 Slot: 78
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x7CD9578 Offset: 0x7CD5578 VA: 0x7CD9578 Slot: 16
	public override bool get_HasValues() { }

	// RVA: 0x7CD48B4 Offset: 0x7CD08B4 VA: 0x7CD48B4
	internal bool ContentsEqual(JContainer container) { }

	[NullableContext(2)]
	// RVA: 0x7CD9638 Offset: 0x7CD5638 VA: 0x7CD9638 Slot: 20
	public override JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x7CD9774 Offset: 0x7CD5774 VA: 0x7CD9774 Slot: 21
	public override JToken get_Last() { }

	// RVA: 0x7CD98B0 Offset: 0x7CD58B0 VA: 0x7CD98B0 Slot: 22
	public override JEnumerable<JToken> Children() { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public override IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646258 Offset: 0x4642258 VA: 0x4646258
	|-JContainer.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CD9924 Offset: 0x7CD5924 VA: 0x7CD9924
	public IEnumerable<JToken> Descendants() { }

	// RVA: 0x7CD99BC Offset: 0x7CD59BC VA: 0x7CD99BC
	public IEnumerable<JToken> DescendantsAndSelf() { }

	[IteratorStateMachine(typeof(JContainer.<GetDescendants>d__36))]
	// RVA: 0x7CD992C Offset: 0x7CD592C VA: 0x7CD992C
	internal IEnumerable<JToken> GetDescendants(bool self) { }

	[NullableContext(2)]
	// RVA: 0x7CD5518 Offset: 0x7CD1518 VA: 0x7CD5518
	internal bool IsMultiContent(object content) { }

	// RVA: 0x7CD99F8 Offset: 0x7CD59F8 VA: 0x7CD99F8
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 79
	internal abstract int IndexOfItem(JToken item);

	[NullableContext(2)]
	// RVA: 0x7CD9B14 Offset: 0x7CD5B14 VA: 0x7CD9B14 Slot: 80
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x7CD9F48 Offset: 0x7CD5F48 VA: 0x7CD9F48 Slot: 81
	internal virtual void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CDA3DC Offset: 0x7CD63DC VA: 0x7CDA3DC Slot: 82
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0x7CDA428 Offset: 0x7CD6428 VA: 0x7CDA428 Slot: 83
	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CDA4E4 Offset: 0x7CD64E4 VA: 0x7CDA4E4 Slot: 84
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0x7CDAAB0 Offset: 0x7CD6AB0 VA: 0x7CDAAB0 Slot: 85
	internal virtual void ClearItems() { }

	// RVA: 0x7CDAEF4 Offset: 0x7CD6EF4 VA: 0x7CDAEF4 Slot: 86
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	// RVA: 0x7CDAF58 Offset: 0x7CD6F58 VA: 0x7CDAF58 Slot: 87
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0x7CDAF7C Offset: 0x7CD6F7C VA: 0x7CDAF7C Slot: 88
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0x7CDAA00 Offset: 0x7CD6A00 VA: 0x7CDAA00
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0x7CDB45C Offset: 0x7CD745C VA: 0x7CDB45C Slot: 89
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	// RVA: 0x7CDB57C Offset: 0x7CD757C VA: 0x7CDB57C Slot: 90
	public virtual void Add(object content) { }

	[NullableContext(2)]
	// RVA: 0x7CDB64C Offset: 0x7CD764C VA: 0x7CDB64C
	internal bool TryAdd(object content) { }

	// RVA: 0x7CDB71C Offset: 0x7CD771C VA: 0x7CDB71C
	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x7CD8FFC Offset: 0x7CD4FFC VA: 0x7CD8FFC
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x7CDB7EC Offset: 0x7CD77EC VA: 0x7CDB7EC
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0x7CDB890 Offset: 0x7CD7890 VA: 0x7CDB890
	public void RemoveAll() { }

	// RVA: -1 Offset: -1 Slot: 91
	internal abstract void MergeItem(object content, JsonMergeSettings settings);

	[NullableContext(2)]
	// RVA: 0x7CDB8A0 Offset: 0x7CD78A0 VA: 0x7CDB8A0
	public void Merge(object content, JsonMergeSettings settings) { }

	// RVA: 0x7CDB8E4 Offset: 0x7CD78E4 VA: 0x7CDB8E4
	private void ValidateContent(object content) { }

	// RVA: 0x7CD4F2C Offset: 0x7CD0F2C VA: 0x7CD4F2C
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0x7CDBA40 Offset: 0x7CD7A40 VA: 0x7CDBA40
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x7CDBEC0 Offset: 0x7CD7EC0 VA: 0x7CDBEC0
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0x7CD6484 Offset: 0x7CD2484 VA: 0x7CD6484
	internal int ContentsHashCode() { }

	// RVA: 0x7CDC338 Offset: 0x7CD8338 VA: 0x7CDC338 Slot: 39
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x7CDC380 Offset: 0x7CD8380 VA: 0x7CDC380 Slot: 40
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x7CDC4D8 Offset: 0x7CD84D8 VA: 0x7CDC4D8 Slot: 29
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0x7CDC4E8 Offset: 0x7CD84E8 VA: 0x7CDC4E8 Slot: 30
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0x7CDC500 Offset: 0x7CD8500 VA: 0x7CDC500 Slot: 31
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0x7CDC510 Offset: 0x7CD8510 VA: 0x7CDC510 Slot: 27
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0x7CDC520 Offset: 0x7CD8520 VA: 0x7CDC520 Slot: 28
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0x7CDC530 Offset: 0x7CD8530 VA: 0x7CDC530 Slot: 34
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0x7CDC540 Offset: 0x7CD8540 VA: 0x7CDC540 Slot: 35
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0x7CDC550 Offset: 0x7CD8550 VA: 0x7CDC550 Slot: 36
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0x7CDC560 Offset: 0x7CD8560 VA: 0x7CDC560 Slot: 37
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x7CDC570 Offset: 0x7CD8570 VA: 0x7CDC570 Slot: 33
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0x7CDC578 Offset: 0x7CD8578 VA: 0x7CDC578 Slot: 38
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x7CDC588 Offset: 0x7CD8588 VA: 0x7CDC588
	private JToken EnsureValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x7CDC644 Offset: 0x7CD8644 VA: 0x7CDC644 Slot: 60
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x7CDC67C Offset: 0x7CD867C VA: 0x7CDC67C Slot: 62
	private void System.Collections.IList.Clear() { }

	[NullableContext(2)]
	// RVA: 0x7CDC68C Offset: 0x7CD868C VA: 0x7CDC68C Slot: 61
	private bool System.Collections.IList.Contains(object value) { }

	[NullableContext(2)]
	// RVA: 0x7CDC6B4 Offset: 0x7CD86B4 VA: 0x7CDC6B4 Slot: 65
	private int System.Collections.IList.IndexOf(object value) { }

	[NullableContext(2)]
	// RVA: 0x7CDC6DC Offset: 0x7CD86DC VA: 0x7CDC6DC Slot: 66
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x7CDC720 Offset: 0x7CD8720 VA: 0x7CDC720 Slot: 64
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x7CDC728 Offset: 0x7CD8728 VA: 0x7CDC728 Slot: 63
	private bool System.Collections.IList.get_IsReadOnly() { }

	[NullableContext(2)]
	// RVA: 0x7CDC730 Offset: 0x7CD8730 VA: 0x7CDC730 Slot: 67
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x7CDC758 Offset: 0x7CD8758 VA: 0x7CDC758 Slot: 68
	private void System.Collections.IList.RemoveAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CDC768 Offset: 0x7CD8768 VA: 0x7CDC768 Slot: 58
	private object System.Collections.IList.get_Item(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CDC778 Offset: 0x7CD8778 VA: 0x7CDC778 Slot: 59
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x7CDC7B4 Offset: 0x7CD87B4 VA: 0x7CDC7B4 Slot: 69
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x7CDB3A8 Offset: 0x7CD73A8 VA: 0x7CDB3A8 Slot: 70
	public int get_Count() { }

	// RVA: 0x7CDC7C4 Offset: 0x7CD87C4 VA: 0x7CDC7C4 Slot: 72
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x7CDC7CC Offset: 0x7CD87CC VA: 0x7CDC7CC Slot: 71
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x7CDC840 Offset: 0x7CD8840 VA: 0x7CDC840 Slot: 53
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x7CDC844 Offset: 0x7CD8844 VA: 0x7CDC844 Slot: 42
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x7CDCA04 Offset: 0x7CD8A04 VA: 0x7CDCA04 Slot: 43
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x7CDCA0C Offset: 0x7CD8A0C VA: 0x7CDCA0C Slot: 41
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x7CDCA14 Offset: 0x7CD8A14 VA: 0x7CDCA14 Slot: 44
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x7CDCA1C Offset: 0x7CD8A1C VA: 0x7CDCA1C Slot: 54
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x7CDCA54 Offset: 0x7CD8A54 VA: 0x7CDCA54 Slot: 55
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x7CDCA8C Offset: 0x7CD8A8C VA: 0x7CDCA8C Slot: 48
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x7CDCA94 Offset: 0x7CD8A94 VA: 0x7CDCA94 Slot: 56
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x7CDCA98 Offset: 0x7CD8A98 VA: 0x7CDCA98 Slot: 57
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x7CDCAD0 Offset: 0x7CD8AD0 VA: 0x7CDCAD0 Slot: 50
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[NullableContext(2)]
	// RVA: 0x7CDCAD8 Offset: 0x7CD8AD8 VA: 0x7CDCAD8 Slot: 49
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x7CDCAE0 Offset: 0x7CD8AE0 VA: 0x7CDCAE0 Slot: 45
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x7CDCAE8 Offset: 0x7CD8AE8 VA: 0x7CDCAE8 Slot: 46
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x7CDCAF0 Offset: 0x7CD8AF0 VA: 0x7CDCAF0 Slot: 47
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x7CD55FC Offset: 0x7CD15FC VA: 0x7CD55FC
	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[IsReadOnly]
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> // TypeDefIndex: 19596
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly JEnumerable<T> Empty; // 0x0
	private readonly IEnumerable<T> _enumerable; // 0x0

	// Properties
	public IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76030 Offset: 0x4A72030 VA: 0x4A76030
	|-JEnumerable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76098 Offset: 0x4A72098 VA: 0x4A76098
	|-JEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A761C4 Offset: 0x4A721C4 VA: 0x4A761C4
	|-JEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IJEnumerable<JToken> get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76234 Offset: 0x4A72234 VA: 0x4A76234
	|-JEnumerable<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(JEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7631C Offset: 0x4A7231C VA: 0x4A7631C
	|-JEnumerable<object>.Equals
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76328 Offset: 0x4A72328 VA: 0x4A76328
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A76434 Offset: 0x4A72434 VA: 0x4A76434
	|-JEnumerable<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7644C Offset: 0x4A7244C VA: 0x4A7644C
	|-JEnumerable<object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JObject.JObjectDynamicProxy.<>c // TypeDefIndex: 19597
{
	// Fields
	[Nullable(0)]
	public static readonly JObject.JObjectDynamicProxy.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JProperty, string> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x7CE1E8C Offset: 0x7CDDE8C VA: 0x7CE1E8C
	private static void .cctor() { }

	// RVA: 0x7CE1EF4 Offset: 0x7CDDEF4 VA: 0x7CE1EF4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CE1EFC Offset: 0x7CDDEFC VA: 0x7CE1EFC
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }
}

// Namespace: 
[Nullable(new[] { 0, 1 })]
private class JObject.JObjectDynamicProxy : DynamicProxy<JObject> // TypeDefIndex: 19598
{
	// Methods

	// RVA: 0x7CE1C68 Offset: 0x7CDDC68 VA: 0x7CE1C68 Slot: 11
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

	// RVA: 0x7CE1CA8 Offset: 0x7CDDCA8 VA: 0x7CE1CA8 Slot: 15
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0x7CE1D78 Offset: 0x7CDDD78 VA: 0x7CE1D78 Slot: 4
	public override IEnumerable<string> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0x7CE1C20 Offset: 0x7CDDC20 VA: 0x7CE1C20
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct JObject.<<WriteToAsync>g__AwaitProperties|0_0>d : IAsyncStateMachine // TypeDefIndex: 19599
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JObject <>4__this; // 0x28
	public int i; // 0x30
	[Nullable(0)]
	public JsonWriter Writer; // 0x38
	public CancellationToken CancellationToken; // 0x40
	[Nullable(new[] { 0, 1 })]
	public JsonConverter[] Converters; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x7CE1F14 Offset: 0x7CDDF14 VA: 0x7CE1F14 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CE233C Offset: 0x7CDE33C VA: 0x7CE233C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JObject.<>c // TypeDefIndex: 19600
{
	// Fields
	[Nullable(0)]
	public static readonly JObject.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JProperty, JToken> <>9__31_0; // 0x8

	// Methods

	// RVA: 0x7CE23A4 Offset: 0x7CDE3A4 VA: 0x7CE23A4
	private static void .cctor() { }

	// RVA: 0x7CE240C Offset: 0x7CDE40C VA: 0x7CE240C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CE2414 Offset: 0x7CDE414 VA: 0x7CE2414
	internal JToken <PropertyValues>b__31_0(JProperty p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JObject.<GetEnumerator>d__64 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable // TypeDefIndex: 19601
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(new[] { 0, 1, 2 })]
	private KeyValuePair<string, JToken> <>2__current; // 0x18
	[Nullable(0)]
	public JObject <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CE1428 Offset: 0x7CDD428 VA: 0x7CE1428
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CE2434 Offset: 0x7CDE434 VA: 0x7CE2434 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CE2450 Offset: 0x7CDE450 VA: 0x7CE2450 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7CE273C Offset: 0x7CDE73C VA: 0x7CE273C
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7CE27EC Offset: 0x7CDE7EC VA: 0x7CE27EC Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CE27F8 Offset: 0x7CDE7F8 VA: 0x7CE27F8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CE2830 Offset: 0x7CDE830 VA: 0x7CE2830 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private struct JObject.<LoadAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 19602
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JObject> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x30
	[Nullable(0)]
	private JObject <o>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x7CE288C Offset: 0x7CDE88C VA: 0x7CE288C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CE2EF8 Offset: 0x7CDEEF8 VA: 0x7CE2EF8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 19603
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x58
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x60
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangingEventHandler PropertyChanging; // 0x68

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	[Nullable(2)]
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	[Nullable(new[] { 1, 2 })]
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x7CDE3C0 Offset: 0x7CDA3C0 VA: 0x7CDE3C0 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x7CDE6AC Offset: 0x7CDA6AC VA: 0x7CDE6AC
	public static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JObject.<LoadAsync>d__2))]
	// RVA: 0x7CDE6B8 Offset: 0x7CDA6B8 VA: 0x7CDE6B8
	public static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CDE7E8 Offset: 0x7CDA7E8 VA: 0x7CDE7E8 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7CDE7F0 Offset: 0x7CDA7F0 VA: 0x7CDE7F0 Slot: 108
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7CDE88C Offset: 0x7CDA88C VA: 0x7CDE88C Slot: 109
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7CDE928 Offset: 0x7CDA928 VA: 0x7CDE928 Slot: 122
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7CDE9C4 Offset: 0x7CDA9C4 VA: 0x7CDE9C4 Slot: 123
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0x7CDBE5C Offset: 0x7CD7E5C VA: 0x7CDBE5C
	public void .ctor() { }

	// RVA: 0x7CDEAF0 Offset: 0x7CDAAF0 VA: 0x7CDEAF0
	public void .ctor(JObject other) { }

	// RVA: 0x7CDEB68 Offset: 0x7CDAB68 VA: 0x7CDEB68
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0x7CDEBE4 Offset: 0x7CDABE4 VA: 0x7CDEBE4
	public void .ctor(object[] content) { }

	// RVA: 0x7CDEBE8 Offset: 0x7CDABE8 VA: 0x7CDEBE8
	public void .ctor(object content) { }

	// RVA: 0x7CDEC70 Offset: 0x7CDAC70 VA: 0x7CDEC70 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	[NullableContext(2)]
	// RVA: 0x7CDF064 Offset: 0x7CDB064 VA: 0x7CDF064 Slot: 79
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x7CDF130 Offset: 0x7CDB130 VA: 0x7CDF130 Slot: 80
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x7CDF1A4 Offset: 0x7CDB1A4 VA: 0x7CDF1A4 Slot: 89
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0x7CDF440 Offset: 0x7CDB440 VA: 0x7CDF440 Slot: 91
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x7CDF94C Offset: 0x7CDB94C VA: 0x7CDF94C
	private static bool IsNull(JToken token) { }

	// RVA: 0x7CDFA74 Offset: 0x7CDBA74 VA: 0x7CDFA74
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0x7CDFBC0 Offset: 0x7CDBBC0 VA: 0x7CDFBC0
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0x7CDFBE4 Offset: 0x7CDBBE4 VA: 0x7CDFBE4 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x7CDFC4C Offset: 0x7CDBC4C VA: 0x7CDFC4C Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x7CD3FF4 Offset: 0x7CCFFF4 VA: 0x7CD3FF4
	public IEnumerable<JProperty> Properties() { }

	// RVA: 0x7CDFC54 Offset: 0x7CDBC54 VA: 0x7CDFC54
	public JProperty Property(string name) { }

	// RVA: 0x7CDC094 Offset: 0x7CD8094 VA: 0x7CDC094
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0x7CDFC5C Offset: 0x7CDBC5C VA: 0x7CDFC5C
	public JEnumerable<JToken> PropertyValues() { }

	// RVA: 0x7CDFDA0 Offset: 0x7CDBDA0 VA: 0x7CDFDA0 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x7CDFF30 Offset: 0x7CDBF30 VA: 0x7CDFF30 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x7CDFEB0 Offset: 0x7CDBEB0 VA: 0x7CDFEB0 Slot: 92
	public JToken get_Item(string propertyName) { }

	// RVA: 0x7CE0048 Offset: 0x7CDC048 VA: 0x7CE0048 Slot: 93
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0x7CE00C0 Offset: 0x7CDC0C0 VA: 0x7CE00C0
	public static JObject Load(JsonReader reader) { }

	// RVA: 0x7CE00C8 Offset: 0x7CDC0C8 VA: 0x7CE00C8
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x7CE028C Offset: 0x7CDC28C VA: 0x7CE028C
	public static JObject Parse(string json) { }

	// RVA: 0x7CE0294 Offset: 0x7CDC294 VA: 0x7CE0294
	public static JObject Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x7CE0480 Offset: 0x7CDC480 VA: 0x7CE0480
	public static JObject FromObject(object o) { }

	// RVA: 0x7CE04A0 Offset: 0x7CDC4A0 VA: 0x7CE04A0
	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x7CE0838 Offset: 0x7CDC838 VA: 0x7CE0838 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x7CE0928 Offset: 0x7CDC928 VA: 0x7CE0928
	public JToken GetValue(string propertyName) { }

	[NullableContext(2)]
	// RVA: 0x7CE0930 Offset: 0x7CDC930 VA: 0x7CE0930
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	// RVA: 0x7CE0960 Offset: 0x7CDC960 VA: 0x7CE0960
	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	// RVA: 0x7CDF8D0 Offset: 0x7CDB8D0 VA: 0x7CDF8D0 Slot: 97
	public void Add(string propertyName, JToken value) { }

	// RVA: 0x7CE0A94 Offset: 0x7CDCA94 VA: 0x7CE0A94 Slot: 96
	public bool ContainsKey(string propertyName) { }

	// RVA: 0x7CE0BAC Offset: 0x7CDCBAC VA: 0x7CE0BAC Slot: 94
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0x7CE0C1C Offset: 0x7CDCC1C VA: 0x7CE0C1C Slot: 98
	public bool Remove(string propertyName) { }

	// RVA: 0x7CE0CB4 Offset: 0x7CDCCB4 VA: 0x7CE0CB4 Slot: 99
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0x7CE0D10 Offset: 0x7CDCD10 VA: 0x7CE0D10 Slot: 95
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0x7CE0D48 Offset: 0x7CDCD48 VA: 0x7CE0D48 Slot: 102
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0x7CE0DDC Offset: 0x7CDCDDC VA: 0x7CE0DDC Slot: 103
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0x7CE0DEC Offset: 0x7CDCDEC VA: 0x7CE0DEC Slot: 104
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0x7CE0E6C Offset: 0x7CDCE6C VA: 0x7CE0E6C Slot: 105
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x7CE12DC Offset: 0x7CDD2DC VA: 0x7CE12DC Slot: 101
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0x7CE12E4 Offset: 0x7CDD2E4 VA: 0x7CE12E4 Slot: 106
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0x7CE1424 Offset: 0x7CDD424 VA: 0x7CE1424 Slot: 25
	internal override int GetDeepHashCode() { }

	[IteratorStateMachine(typeof(JObject.<GetEnumerator>d__64))]
	// RVA: 0x7CDF864 Offset: 0x7CDB864 VA: 0x7CDF864 Slot: 107
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0x7CE1450 Offset: 0x7CDD450 VA: 0x7CE1450 Slot: 124
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0x7CE14E0 Offset: 0x7CDD4E0 VA: 0x7CE14E0 Slot: 125
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0x7CE1570 Offset: 0x7CDD570 VA: 0x7CE1570 Slot: 119
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x7CE160C Offset: 0x7CDD60C VA: 0x7CE160C Slot: 120
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x7CE1970 Offset: 0x7CDD970 VA: 0x7CE1970 Slot: 110
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[NullableContext(2)]
	// RVA: 0x7CE19C8 Offset: 0x7CDD9C8 VA: 0x7CE19C8 Slot: 111
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[NullableContext(2)]
	// RVA: 0x7CE19D0 Offset: 0x7CDD9D0 VA: 0x7CE19D0 Slot: 112
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x7CE19D8 Offset: 0x7CDD9D8 VA: 0x7CE19D8 Slot: 113
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	// RVA: 0x7CE1A2C Offset: 0x7CDDA2C VA: 0x7CE1A2C Slot: 114
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[NullableContext(2)]
	// RVA: 0x7CE1A34 Offset: 0x7CDDA34 VA: 0x7CE1A34 Slot: 115
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x7CE1A3C Offset: 0x7CDDA3C VA: 0x7CE1A3C Slot: 116
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x7CE1A44 Offset: 0x7CDDA44 VA: 0x7CE1A44 Slot: 118
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x7CE1A9C Offset: 0x7CDDA9C VA: 0x7CE1A9C Slot: 117
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[NullableContext(2)]
	// RVA: 0x7CE1AF4 Offset: 0x7CDDAF4 VA: 0x7CE1AF4 Slot: 121
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x7CE1B70 Offset: 0x7CDDB70 VA: 0x7CE1B70 Slot: 26
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	[CompilerGenerated]
	[AsyncStateMachine(typeof(JObject.<<WriteToAsync>g__AwaitProperties|0_0>d))]
	// RVA: 0x7CDE55C Offset: 0x7CDA55C VA: 0x7CDE55C
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19604
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	[Nullable(0)]
	public JProperty.JPropertyList <>4__this; // 0x20

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CE3DD0 Offset: 0x7CDFDD0 VA: 0x7CE3DD0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CE3FA0 Offset: 0x7CDFFA0 VA: 0x7CE3FA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CE3FA4 Offset: 0x7CDFFA4 VA: 0x7CE3FA4 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CE400C Offset: 0x7CE000C VA: 0x7CE400C Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CE4014 Offset: 0x7CE0014 VA: 0x7CE4014 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CE404C Offset: 0x7CE004C VA: 0x7CE404C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[Nullable(0)]
[DefaultMember("Item")]
private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 19605
{
	// Fields
	[Nullable(2)]
	internal JToken _token; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }

	// Methods

	[IteratorStateMachine(typeof(JProperty.JPropertyList.<GetEnumerator>d__1))]
	// RVA: 0x7CE3D64 Offset: 0x7CDFD64 VA: 0x7CE3D64 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x7CE3DF8 Offset: 0x7CDFDF8 VA: 0x7CE3DF8 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7CE3DFC Offset: 0x7CDFDFC VA: 0x7CE3DFC Slot: 11
	public void Add(JToken item) { }

	// RVA: 0x7CE3E04 Offset: 0x7CDFE04 VA: 0x7CE3E04 Slot: 12
	public void Clear() { }

	// RVA: 0x7CE3E10 Offset: 0x7CDFE10 VA: 0x7CE3E10 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0x7CE3E20 Offset: 0x7CDFE20 VA: 0x7CE3E20 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x7CE3E94 Offset: 0x7CDFE94 VA: 0x7CE3E94 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0x7CE3ECC Offset: 0x7CDFECC VA: 0x7CE3ECC Slot: 9
	public int get_Count() { }

	// RVA: 0x7CE3EDC Offset: 0x7CDFEDC VA: 0x7CE3EDC Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x7CE36E0 Offset: 0x7CDF6E0 VA: 0x7CE36E0 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0x7CE3EE4 Offset: 0x7CDFEE4 VA: 0x7CE3EE4 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0x7CE3EF8 Offset: 0x7CDFEF8 VA: 0x7CE3EF8 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x7CE3F0C Offset: 0x7CDFF0C VA: 0x7CE3F0C Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0x7CE3F54 Offset: 0x7CDFF54 VA: 0x7CE3F54 Slot: 5
	public void set_Item(int index, JToken value) { }

	// RVA: 0x7CE33B8 Offset: 0x7CDF3B8 VA: 0x7CE33B8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct JProperty.<LoadAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 19606
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JProperty> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x30
	[Nullable(0)]
	private JProperty <p>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x7CE4054 Offset: 0x7CE0054 VA: 0x7CE4054 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CE46F4 Offset: 0x7CE06F4 VA: 0x7CE46F4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct JProperty.<WriteToAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 19607
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Task task; // 0x20
	[Nullable(0)]
	public JProperty <>4__this; // 0x28
	[Nullable(0)]
	public JsonWriter writer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	[Nullable(new[] { 0, 1 })]
	public JsonConverter[] converters; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x7CE4770 Offset: 0x7CE0770 VA: 0x7CE4770 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CE4A18 Offset: 0x7CE0A18 VA: 0x7CE4A18 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JProperty : JContainer // TypeDefIndex: 19608
{
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x7CE2F74 Offset: 0x7CDEF74 VA: 0x7CE2F74 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JProperty.<WriteToAsync>d__1))]
	// RVA: 0x7CE3094 Offset: 0x7CDF094 VA: 0x7CE3094
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x7CE3048 Offset: 0x7CDF048 VA: 0x7CE3048
	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JProperty.<LoadAsync>d__4))]
	// RVA: 0x7CE31E0 Offset: 0x7CDF1E0 VA: 0x7CE31E0
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CE3310 Offset: 0x7CDF310 VA: 0x7CE3310 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	// RVA: 0x7CE3318 Offset: 0x7CDF318 VA: 0x7CE3318
	public string get_Name() { }

	[DebuggerStepThrough]
	// RVA: 0x7CDBE40 Offset: 0x7CD7E40 VA: 0x7CDBE40
	public JToken get_Value() { }

	// RVA: 0x7CDF9F0 Offset: 0x7CDB9F0 VA: 0x7CDF9F0
	public void set_Value(JToken value) { }

	// RVA: 0x7CE3320 Offset: 0x7CDF320 VA: 0x7CE3320
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0x7CE33C0 Offset: 0x7CDF3C0 VA: 0x7CE33C0 Slot: 83
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CE3414 Offset: 0x7CDF414 VA: 0x7CE3414 Slot: 84
	internal override void SetItem(int index, JToken item) { }

	[NullableContext(2)]
	// RVA: 0x7CE3558 Offset: 0x7CDF558 VA: 0x7CE3558 Slot: 82
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0x7CE3604 Offset: 0x7CDF604 VA: 0x7CE3604 Slot: 81
	internal override void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x7CE36B0 Offset: 0x7CDF6B0 VA: 0x7CE36B0 Slot: 79
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x7CE36F0 Offset: 0x7CDF6F0 VA: 0x7CE36F0 Slot: 80
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: 0x7CE380C Offset: 0x7CDF80C VA: 0x7CE380C Slot: 87
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0x7CE3830 Offset: 0x7CDF830 VA: 0x7CE3830 Slot: 91
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x7CE38E8 Offset: 0x7CDF8E8 VA: 0x7CE38E8 Slot: 85
	internal override void ClearItems() { }

	// RVA: 0x7CE3994 Offset: 0x7CDF994 VA: 0x7CE3994 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x7CE3A34 Offset: 0x7CDFA34 VA: 0x7CE3A34 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x7CE3A9C Offset: 0x7CDFA9C VA: 0x7CE3A9C Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x7CDC21C Offset: 0x7CD821C VA: 0x7CDC21C
	internal void .ctor(string name) { }

	// RVA: 0x7CE0990 Offset: 0x7CDC990 VA: 0x7CE0990
	public void .ctor(string name, object content) { }

	// RVA: 0x7CE3AA4 Offset: 0x7CDFAA4 VA: 0x7CE3AA4 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x7CE3B24 Offset: 0x7CDFB24 VA: 0x7CE3B24 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x7CE3B74 Offset: 0x7CDFB74 VA: 0x7CE3B74
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 19609
{
	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0x7CE1964 Offset: 0x7CDD964 VA: 0x7CE1964
	public void .ctor(string name) { }

	// RVA: 0x7CE4A80 Offset: 0x7CE0A80 VA: 0x7CE4A80 Slot: 23
	public override bool CanResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x7CE4A88 Offset: 0x7CE0A88 VA: 0x7CE4A88 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x7CE4B24 Offset: 0x7CE0B24 VA: 0x7CE4B24 Slot: 29
	public override void ResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x7CE4B28 Offset: 0x7CE0B28 VA: 0x7CE4B28 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x7CE4C54 Offset: 0x7CE0C54 VA: 0x7CE4C54 Slot: 31
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x7CE4C5C Offset: 0x7CE0C5C VA: 0x7CE4C5C Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x7CE4CC8 Offset: 0x7CE0CC8 VA: 0x7CE4CC8 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x7CE4CD0 Offset: 0x7CE0CD0 VA: 0x7CE4CD0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x7CE4D3C Offset: 0x7CE0D3C VA: 0x7CE4D3C Slot: 11
	protected override int get_NameHashCode() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(new[] { 0, 1 })]
[DefaultMember("Item")]
internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 19610
{
	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, JToken> _dictionary; // 0x18

	// Properties
	public ICollection<string> Keys { get; }

	// Methods

	// RVA: 0x7CDEA60 Offset: 0x7CDAA60 VA: 0x7CDEA60
	public void .ctor() { }

	// RVA: 0x7CE4D44 Offset: 0x7CE0D44 VA: 0x7CE4D44
	private void AddKey(string key, JToken item) { }

	// RVA: 0x7CE4E70 Offset: 0x7CE0E70 VA: 0x7CE4E70 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x7CE0B00 Offset: 0x7CDCB00 VA: 0x7CE0B00
	public bool Contains(string key) { }

	// RVA: 0x7CE4DB4 Offset: 0x7CE0DB4 VA: 0x7CE4DB4
	private void EnsureDictionary() { }

	// RVA: 0x7CE4EE8 Offset: 0x7CE0EE8 VA: 0x7CE4EE8
	private string GetKeyForItem(JToken item) { }

	// RVA: 0x7CE4F68 Offset: 0x7CE0F68 VA: 0x7CE4F68 Slot: 36
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0x7CE4FE0 Offset: 0x7CE0FE0 VA: 0x7CE4FE0 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x7CE50D4 Offset: 0x7CE10D4 VA: 0x7CE50D4
	private void RemoveKey(string key) { }

	// RVA: 0x7CE5134 Offset: 0x7CE1134 VA: 0x7CE5134 Slot: 38
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0x7CDF3B8 Offset: 0x7CDB3B8 VA: 0x7CDF3B8
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0x7CE0BC4 Offset: 0x7CDCBC4 VA: 0x7CE0BC4
	public ICollection<string> get_Keys() { }

	// RVA: 0x7CDF08C Offset: 0x7CDB08C VA: 0x7CDF08C
	public int IndexOfReference(JToken t) { }

	// RVA: 0x7CDED04 Offset: 0x7CDAD04 VA: 0x7CDED04
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0x7CE533C Offset: 0x7CE133C VA: 0x7CE533C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
public class JRaw : JValue // TypeDefIndex: 19611
{
	// Methods

	// RVA: 0x7CE53EC Offset: 0x7CE13EC VA: 0x7CE53EC
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x7CE53F4 Offset: 0x7CE13F4 VA: 0x7CE53F4
	public void .ctor(object rawJson) { }

	// RVA: 0x7CE5400 Offset: 0x7CE1400 VA: 0x7CE5400
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0x7CE5780 Offset: 0x7CE1780 VA: 0x7CE5780 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings // TypeDefIndex: 19612
{
	// Fields
	[Nullable(1)]
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	[CompilerGenerated]
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Properties
	public bool CopyAnnotations { get; set; }

	// Methods

	// RVA: 0x7CE57EC Offset: 0x7CE17EC VA: 0x7CE57EC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7CE580C Offset: 0x7CE180C VA: 0x7CE580C
	public bool get_CopyAnnotations() { }

	[CompilerGenerated]
	// RVA: 0x7CE5814 Offset: 0x7CE1814 VA: 0x7CE5814
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0x7CE5820 Offset: 0x7CE1820 VA: 0x7CE5820
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonLoadSettings // TypeDefIndex: 19613
{
	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18

	// Properties
	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }
	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get; }

	// Methods

	// RVA: 0x7CE588C Offset: 0x7CE188C VA: 0x7CE588C
	public CommentHandling get_CommentHandling() { }

	// RVA: 0x7CE5894 Offset: 0x7CE1894 VA: 0x7CE5894
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0x7CE589C Offset: 0x7CE189C VA: 0x7CE589C
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonMergeSettings // TypeDefIndex: 19614
{
	// Fields
	private MergeArrayHandling _mergeArrayHandling; // 0x10
	private MergeNullValueHandling _mergeNullValueHandling; // 0x14
	private StringComparison _propertyNameComparison; // 0x18

	// Properties
	public MergeArrayHandling MergeArrayHandling { get; }
	public MergeNullValueHandling MergeNullValueHandling { get; }
	public StringComparison PropertyNameComparison { get; }

	// Methods

	// RVA: 0x7CE58A4 Offset: 0x7CE18A4 VA: 0x7CE58A4
	public MergeArrayHandling get_MergeArrayHandling() { }

	// RVA: 0x7CE58AC Offset: 0x7CE18AC VA: 0x7CE58AC
	public MergeNullValueHandling get_MergeNullValueHandling() { }

	// RVA: 0x7CE58B4 Offset: 0x7CE18B4 VA: 0x7CE58B4
	public StringComparison get_PropertyNameComparison() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonSelectSettings // TypeDefIndex: 19615
{
	// Fields
	[CompilerGenerated]
	private Nullable<TimeSpan> <RegexMatchTimeout>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ErrorWhenNoMatch>k__BackingField; // 0x20

	// Properties
	public Nullable<TimeSpan> RegexMatchTimeout { get; }
	public bool ErrorWhenNoMatch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CE58BC Offset: 0x7CE18BC VA: 0x7CE58BC
	public Nullable<TimeSpan> get_RegexMatchTimeout() { }

	[CompilerGenerated]
	// RVA: 0x7CE58C8 Offset: 0x7CE18C8 VA: 0x7CE58C8
	public bool get_ErrorWhenNoMatch() { }

	[CompilerGenerated]
	// RVA: 0x7CE58D0 Offset: 0x7CE18D0 VA: 0x7CE58D0
	public void set_ErrorWhenNoMatch(bool value) { }

	// RVA: 0x7CE58DC Offset: 0x7CE18DC VA: 0x7CE58DC
	public void .ctor() { }
}

// Namespace: 
[NullableContext(0)]
private class JToken.LineInfoAnnotation // TypeDefIndex: 19616
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0x7CEE494 Offset: 0x7CEA494 VA: 0x7CEE494
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JToken.<AfterSelf>d__49 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19617
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	public JToken <>4__this; // 0x28
	[Nullable(0)]
	private JToken <o>5__2; // 0x30

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CE6224 Offset: 0x7CE2224 VA: 0x7CE6224
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CEF598 Offset: 0x7CEB598 VA: 0x7CEF598 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CEF59C Offset: 0x7CEB59C VA: 0x7CEF59C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CEF638 Offset: 0x7CEB638 VA: 0x7CEF638 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEF640 Offset: 0x7CEB640 VA: 0x7CEF640 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CEF678 Offset: 0x7CEB678 VA: 0x7CEF678 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEF680 Offset: 0x7CEB680 VA: 0x7CEF680 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CEF724 Offset: 0x7CEB724 VA: 0x7CEF724 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JToken.<Annotations>d__185<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 19618
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	[Nullable(0)]
	public JToken <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	private object[] <annotations>5__2; // 0x0
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
	|-RVA: 0x5BC826C Offset: 0x5BC426C VA: 0x5BC826C
	|-JToken.<Annotations>d__185<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC82A0 Offset: 0x5BC42A0 VA: 0x5BC82A0
	|-JToken.<Annotations>d__185<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC82A4 Offset: 0x5BC42A4 VA: 0x5BC82A4
	|-JToken.<Annotations>d__185<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC84DC Offset: 0x5BC44DC VA: 0x5BC84DC
	|-JToken.<Annotations>d__185<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC84E4 Offset: 0x5BC44E4 VA: 0x5BC84E4
	|-JToken.<Annotations>d__185<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC8518 Offset: 0x5BC4518 VA: 0x5BC8518
	|-JToken.<Annotations>d__185<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC8520 Offset: 0x5BC4520 VA: 0x5BC8520
	|-JToken.<Annotations>d__185<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC85B4 Offset: 0x5BC45B4 VA: 0x5BC85B4
	|-JToken.<Annotations>d__185<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class JToken.<Annotations>d__186 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 19619
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	private Type type; // 0x28
	[Nullable(0)]
	public Type <>3__type; // 0x30
	[Nullable(0)]
	public JToken <>4__this; // 0x38
	[Nullable(new[] { 0, 1 })]
	private object[] <annotations>5__2; // 0x40
	private int <i>5__3; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CEF048 Offset: 0x7CEB048 VA: 0x7CEF048
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CEF728 Offset: 0x7CEB728 VA: 0x7CEF728 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CEF72C Offset: 0x7CEB72C VA: 0x7CEF72C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CEF940 Offset: 0x7CEB940 VA: 0x7CEF940 Slot: 6
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEF948 Offset: 0x7CEB948 VA: 0x7CEF948 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CEF980 Offset: 0x7CEB980 VA: 0x7CEF980 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEF988 Offset: 0x7CEB988 VA: 0x7CEF988 Slot: 4
	private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CEFA3C Offset: 0x7CEBA3C VA: 0x7CEFA3C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JToken.<BeforeSelf>d__50 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19620
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	public JToken <>4__this; // 0x28
	[Nullable(0)]
	private JToken <o>5__2; // 0x30

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CE62D4 Offset: 0x7CE22D4 VA: 0x7CE62D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CEFA40 Offset: 0x7CEBA40 VA: 0x7CEFA40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CEFA44 Offset: 0x7CEBA44 VA: 0x7CEFA44 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CEFB04 Offset: 0x7CEBB04 VA: 0x7CEFB04 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEFB0C Offset: 0x7CEBB0C VA: 0x7CEFB0C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CEFB44 Offset: 0x7CEBB44 VA: 0x7CEFB44 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEFB4C Offset: 0x7CEBB4C VA: 0x7CEFB4C Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CEFBF0 Offset: 0x7CEBBF0 VA: 0x7CEFBF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JToken.<GetAncestors>d__48 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19621
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private bool self; // 0x24
	public bool <>3__self; // 0x25
	[Nullable(0)]
	public JToken <>4__this; // 0x28
	[Nullable(0)]
	private JToken <current>5__2; // 0x30

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CE6174 Offset: 0x7CE2174 VA: 0x7CE6174
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CEFBF4 Offset: 0x7CEBBF4 VA: 0x7CEFBF4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CEFBF8 Offset: 0x7CEBBF8 VA: 0x7CEFBF8 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CEFC94 Offset: 0x7CEBC94 VA: 0x7CEFC94 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEFC9C Offset: 0x7CEBC9C VA: 0x7CEFC9C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CEFCD4 Offset: 0x7CEBCD4 VA: 0x7CEFCD4 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CEFCDC Offset: 0x7CEBCDC VA: 0x7CEFCDC Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CEFD88 Offset: 0x7CEBD88 VA: 0x7CEFD88 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private struct JToken.<ReadFromAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 19622
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JToken> <>t__builder; // 0x8
	[Nullable(0)]
	public JsonReader reader; // 0x20
	[Nullable(0)]
	public JsonLoadSettings settings; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JObject> <>u__2; // 0x48
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JArray> <>u__3; // 0x58
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JConstructor> <>u__4; // 0x68
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JProperty> <>u__5; // 0x78

	// Methods

	// RVA: 0x7CEFD8C Offset: 0x7CEBD8C VA: 0x7CEFD8C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7CF0798 Offset: 0x7CEC798 VA: 0x7CF0798 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Newtonsoft.Json.Linq
[DefaultMember("Item")]
[NullableContext(1)]
[Nullable(0)]
public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 19623
{
	// Fields
	[Nullable(2)]
	private static JTokenEqualityComparer _equalityComparer; // 0x0
	[Nullable(2)]
	private JContainer _parent; // 0x10
	[Nullable(2)]
	private JToken _previous; // 0x18
	[Nullable(2)]
	private JToken _next; // 0x20
	[Nullable(2)]
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x8
	private static readonly JTokenType[] NumberTypes; // 0x10
	private static readonly JTokenType[] BigIntegerTypes; // 0x18
	private static readonly JTokenType[] StringTypes; // 0x20
	private static readonly JTokenType[] GuidTypes; // 0x28
	private static readonly JTokenType[] TimeSpanTypes; // 0x30
	private static readonly JTokenType[] UriTypes; // 0x38
	private static readonly JTokenType[] CharTypes; // 0x40
	private static readonly JTokenType[] DateTimeTypes; // 0x48
	private static readonly JTokenType[] BytesTypes; // 0x50

	// Properties
	public static JTokenEqualityComparer EqualityComparer { get; }
	[Nullable(2)]
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	[Nullable(2)]
	public JToken Next { get; set; }
	[Nullable(2)]
	public JToken Previous { get; set; }
	public string Path { get; }
	[Nullable(2)]
	public virtual JToken Item { get; set; }
	[Nullable(2)]
	public virtual JToken First { get; }
	[Nullable(2)]
	public virtual JToken Last { get; }
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x7CE58E4 Offset: 0x7CE18E4 VA: 0x7CE58E4 Slot: 12
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x7CE591C Offset: 0x7CE191C VA: 0x7CE591C
	public Task WriteToAsync(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x7CE5930 Offset: 0x7CE1930 VA: 0x7CE5930
	public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JToken.<ReadFromAsync>d__3))]
	// RVA: 0x7CE5998 Offset: 0x7CE1998 VA: 0x7CE5998
	public static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CE5AD0 Offset: 0x7CE1AD0 VA: 0x7CE5AD0
	public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x7CE5B38 Offset: 0x7CE1B38 VA: 0x7CE5B38
	public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x7CDCAF8 Offset: 0x7CD8AF8 VA: 0x7CDCAF8
	public static JTokenEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x7CE5BA4 Offset: 0x7CE1BA4 VA: 0x7CE5BA4
	public JContainer get_Parent() { }

	[NullableContext(2)]
	// RVA: 0x7CE5BAC Offset: 0x7CE1BAC VA: 0x7CE5BAC
	internal void set_Parent(JContainer value) { }

	// RVA: 0x7CD9AFC Offset: 0x7CD5AFC VA: 0x7CD9AFC
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract JToken CloneToken(JsonCloneSettings settings);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_HasValues();

	[NullableContext(2)]
	// RVA: 0x7CE5BB4 Offset: 0x7CE1BB4 VA: 0x7CE5BB4
	public static bool DeepEquals(JToken t1, JToken t2) { }

	[NullableContext(2)]
	// RVA: 0x7CE5BE4 Offset: 0x7CE1BE4 VA: 0x7CE5BE4
	public JToken get_Next() { }

	[NullableContext(2)]
	// RVA: 0x7CE5BEC Offset: 0x7CE1BEC VA: 0x7CE5BEC
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE5BF4 Offset: 0x7CE1BF4 VA: 0x7CE5BF4
	public JToken get_Previous() { }

	[NullableContext(2)]
	// RVA: 0x7CE5BFC Offset: 0x7CE1BFC VA: 0x7CE5BFC
	internal void set_Previous(JToken value) { }

	// RVA: 0x7CE5C04 Offset: 0x7CE1C04 VA: 0x7CE5C04
	public string get_Path() { }

	// RVA: 0x7CD8F60 Offset: 0x7CD4F60 VA: 0x7CD8F60
	internal void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x7CE5F94 Offset: 0x7CE1F94 VA: 0x7CE5F94
	public void AddAfterSelf(object content) { }

	[NullableContext(2)]
	// RVA: 0x7CE6034 Offset: 0x7CE2034 VA: 0x7CE6034
	public void AddBeforeSelf(object content) { }

	// RVA: 0x7CE60D4 Offset: 0x7CE20D4 VA: 0x7CE60D4
	public IEnumerable<JToken> Ancestors() { }

	// RVA: 0x7CE616C Offset: 0x7CE216C VA: 0x7CE616C
	public IEnumerable<JToken> AncestorsAndSelf() { }

	[IteratorStateMachine(typeof(JToken.<GetAncestors>d__48))]
	// RVA: 0x7CE60DC Offset: 0x7CE20DC VA: 0x7CE60DC
	internal IEnumerable<JToken> GetAncestors(bool self) { }

	[IteratorStateMachine(typeof(JToken.<AfterSelf>d__49))]
	// RVA: 0x7CE61A8 Offset: 0x7CE21A8 VA: 0x7CE61A8
	public IEnumerable<JToken> AfterSelf() { }

	[IteratorStateMachine(typeof(JToken.<BeforeSelf>d__50))]
	// RVA: 0x7CE6258 Offset: 0x7CE2258 VA: 0x7CE6258
	public IEnumerable<JToken> BeforeSelf() { }

	// RVA: 0x7CE6308 Offset: 0x7CE2308 VA: 0x7CE6308 Slot: 17
	public virtual JToken get_Item(object key) { }

	// RVA: 0x7CE6398 Offset: 0x7CE2398 VA: 0x7CE6398 Slot: 18
	public virtual void set_Item(object key, JToken value) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 19
	public virtual T Value<T>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46469D8 Offset: 0x46429D8 VA: 0x46469D8
	|-JToken.Value<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x7CE6428 Offset: 0x7CE2428 VA: 0x7CE6428 Slot: 20
	public virtual JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x7CE64B8 Offset: 0x7CE24B8 VA: 0x7CE64B8 Slot: 21
	public virtual JToken get_Last() { }

	// RVA: 0x7CE6548 Offset: 0x7CE2548 VA: 0x7CE6548 Slot: 22
	public virtual JEnumerable<JToken> Children() { }

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public JEnumerable<T> Children<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646494 Offset: 0x4642494 VA: 0x4646494
	|-JToken.Children<object>
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public virtual IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646B04 Offset: 0x4642B04 VA: 0x4646B04
	|-JToken.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CE0C48 Offset: 0x7CDCC48 VA: 0x7CE0C48
	public void Remove() { }

	// RVA: 0x7CDC2C4 Offset: 0x7CD82C4 VA: 0x7CDC2C4
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0x7CE65A0 Offset: 0x7CE25A0 VA: 0x7CE65A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x7CE6638 Offset: 0x7CE2638 VA: 0x7CE6638
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0x7CE6890 Offset: 0x7CE2890 VA: 0x7CE6890
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0x7CE69A4 Offset: 0x7CE29A4 VA: 0x7CE69A4
	private static string GetType(JToken token) { }

	// RVA: 0x7CE6A98 Offset: 0x7CE2A98 VA: 0x7CE6A98
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0x7CE6B64 Offset: 0x7CE2B64 VA: 0x7CE6B64
	public static bool op_Explicit(JToken value) { }

	// RVA: 0x7CE6D6C Offset: 0x7CE2D6C VA: 0x7CE6D6C
	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE6FB8 Offset: 0x7CE2FB8 VA: 0x7CE6FB8
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0x7CE7208 Offset: 0x7CE3208 VA: 0x7CE7208
	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE73EC Offset: 0x7CE33EC VA: 0x7CE73EC
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE7610 Offset: 0x7CE3610 VA: 0x7CE7610
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE78E4 Offset: 0x7CE38E4 VA: 0x7CE78E4
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE7B24 Offset: 0x7CE3B24 VA: 0x7CE7B24
	public static Nullable<double> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE7D44 Offset: 0x7CE3D44 VA: 0x7CE7D44
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0x7CE7F68 Offset: 0x7CE3F68 VA: 0x7CE7F68
	public static int op_Explicit(JToken value) { }

	// RVA: 0x7CE814C Offset: 0x7CE414C VA: 0x7CE814C
	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CE8330 Offset: 0x7CE4330 VA: 0x7CE8330
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CE8514 Offset: 0x7CE4514 VA: 0x7CE8514
	public static char op_Explicit(JToken value) { }

	// RVA: 0x7CE86F8 Offset: 0x7CE46F8 VA: 0x7CE86F8
	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CE88DC Offset: 0x7CE48DC VA: 0x7CE88DC
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE8AC0 Offset: 0x7CE4AC0 VA: 0x7CE8AC0
	public static Nullable<int> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE8CE4 Offset: 0x7CE4CE4 VA: 0x7CE8CE4
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x7CE8F08 Offset: 0x7CE4F08 VA: 0x7CE8F08
	public static Nullable<ushort> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE912C Offset: 0x7CE512C VA: 0x7CE912C
	public static Nullable<byte> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x7CE9350 Offset: 0x7CE5350 VA: 0x7CE9350
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0x7CE9574 Offset: 0x7CE5574 VA: 0x7CE9574
	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE9760 Offset: 0x7CE5760 VA: 0x7CE9760
	public static Nullable<long> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CE9984 Offset: 0x7CE5984 VA: 0x7CE9984
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0x7CE9BA4 Offset: 0x7CE5BA4 VA: 0x7CE9BA4
	public static Decimal op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x7CE9D88 Offset: 0x7CE5D88 VA: 0x7CE9D88
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x7CE9FAC Offset: 0x7CE5FAC VA: 0x7CE9FAC
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0x7CEA1D0 Offset: 0x7CE61D0 VA: 0x7CEA1D0
	public static double op_Explicit(JToken value) { }

	// RVA: 0x7CEA3B4 Offset: 0x7CE63B4 VA: 0x7CEA3B4
	public static float op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CEA598 Offset: 0x7CE6598 VA: 0x7CEA598
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEA810 Offset: 0x7CE6810 VA: 0x7CEA810
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEA9F4 Offset: 0x7CE69F4 VA: 0x7CEA9F4
	public static ulong op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CEABD8 Offset: 0x7CE6BD8 VA: 0x7CEABD8
	public static byte[] op_Explicit(JToken value) { }

	// RVA: 0x7CEAE1C Offset: 0x7CE6E1C VA: 0x7CEAE1C
	public static Guid op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CEB03C Offset: 0x7CE703C VA: 0x7CEB03C
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0x7CEB2A0 Offset: 0x7CE72A0 VA: 0x7CEB2A0
	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CEB49C Offset: 0x7CE749C VA: 0x7CEB49C
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x7CEB6D4 Offset: 0x7CE76D4 VA: 0x7CEB6D4
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0x7CEB8D0 Offset: 0x7CE78D0 VA: 0x7CEB8D0
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0x7CEBA1C Offset: 0x7CE7A1C VA: 0x7CEBA1C
	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0x7CEBBC8 Offset: 0x7CE7BC8 VA: 0x7CEBBC8
	public static JToken op_Implicit(bool value) { }

	// RVA: 0x7CEBC24 Offset: 0x7CE7C24 VA: 0x7CEBC24
	public static JToken op_Implicit(DateTimeOffset value) { }

	// RVA: 0x7CEBC90 Offset: 0x7CE7C90 VA: 0x7CEBC90
	public static JToken op_Implicit(byte value) { }

	// RVA: 0x7CEBCEC Offset: 0x7CE7CEC VA: 0x7CEBCEC
	public static JToken op_Implicit(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEBD7C Offset: 0x7CE7D7C VA: 0x7CEBD7C
	public static JToken op_Implicit(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEBDD8 Offset: 0x7CE7DD8 VA: 0x7CEBDD8
	public static JToken op_Implicit(Nullable<sbyte> value) { }

	// RVA: 0x7CEBE68 Offset: 0x7CE7E68 VA: 0x7CEBE68
	public static JToken op_Implicit(Nullable<bool> value) { }

	// RVA: 0x7CEBEF8 Offset: 0x7CE7EF8 VA: 0x7CEBEF8
	public static JToken op_Implicit(long value) { }

	// RVA: 0x7CEBF54 Offset: 0x7CE7F54 VA: 0x7CEBF54
	public static JToken op_Implicit(Nullable<DateTime> value) { }

	// RVA: 0x7CEBFF0 Offset: 0x7CE7FF0 VA: 0x7CEBFF0
	public static JToken op_Implicit(Nullable<DateTimeOffset> value) { }

	// RVA: 0x7CEC094 Offset: 0x7CE8094 VA: 0x7CEC094
	public static JToken op_Implicit(Nullable<Decimal> value) { }

	// RVA: 0x7CEC158 Offset: 0x7CE8158 VA: 0x7CEC158
	public static JToken op_Implicit(Nullable<double> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC1F4 Offset: 0x7CE81F4 VA: 0x7CEC1F4
	public static JToken op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC250 Offset: 0x7CE8250 VA: 0x7CEC250
	public static JToken op_Implicit(ushort value) { }

	// RVA: 0x7CEC2AC Offset: 0x7CE82AC VA: 0x7CEC2AC
	public static JToken op_Implicit(int value) { }

	// RVA: 0x7CEC308 Offset: 0x7CE8308 VA: 0x7CEC308
	public static JToken op_Implicit(Nullable<int> value) { }

	// RVA: 0x7CEC398 Offset: 0x7CE8398 VA: 0x7CEC398
	public static JToken op_Implicit(DateTime value) { }

	// RVA: 0x7CEC3F4 Offset: 0x7CE83F4 VA: 0x7CEC3F4
	public static JToken op_Implicit(Nullable<long> value) { }

	// RVA: 0x7CEC490 Offset: 0x7CE8490 VA: 0x7CEC490
	public static JToken op_Implicit(Nullable<float> value) { }

	// RVA: 0x7CEC520 Offset: 0x7CE8520 VA: 0x7CEC520
	public static JToken op_Implicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC58C Offset: 0x7CE858C VA: 0x7CEC58C
	public static JToken op_Implicit(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC61C Offset: 0x7CE861C VA: 0x7CEC61C
	public static JToken op_Implicit(Nullable<ushort> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC6AC Offset: 0x7CE86AC VA: 0x7CEC6AC
	public static JToken op_Implicit(Nullable<uint> value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC73C Offset: 0x7CE873C VA: 0x7CEC73C
	public static JToken op_Implicit(Nullable<ulong> value) { }

	// RVA: 0x7CEC7D8 Offset: 0x7CE87D8 VA: 0x7CEC7D8
	public static JToken op_Implicit(double value) { }

	// RVA: 0x7CEC83C Offset: 0x7CE883C VA: 0x7CEC83C
	public static JToken op_Implicit(float value) { }

	// RVA: 0x7CEC8A0 Offset: 0x7CE88A0 VA: 0x7CEC8A0
	public static JToken op_Implicit(string value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC8FC Offset: 0x7CE88FC VA: 0x7CEC8FC
	public static JToken op_Implicit(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CEC958 Offset: 0x7CE8958 VA: 0x7CEC958
	public static JToken op_Implicit(ulong value) { }

	// RVA: 0x7CEC9B4 Offset: 0x7CE89B4 VA: 0x7CEC9B4
	public static JToken op_Implicit(byte[] value) { }

	// RVA: 0x7CECA10 Offset: 0x7CE8A10 VA: 0x7CECA10
	public static JToken op_Implicit(Uri value) { }

	// RVA: 0x7CECA6C Offset: 0x7CE8A6C VA: 0x7CECA6C
	public static JToken op_Implicit(TimeSpan value) { }

	// RVA: 0x7CECAC8 Offset: 0x7CE8AC8 VA: 0x7CECAC8
	public static JToken op_Implicit(Nullable<TimeSpan> value) { }

	// RVA: 0x7CECB64 Offset: 0x7CE8B64 VA: 0x7CECB64
	public static JToken op_Implicit(Guid value) { }

	// RVA: 0x7CECBD0 Offset: 0x7CE8BD0 VA: 0x7CECBD0
	public static JToken op_Implicit(Nullable<Guid> value) { }

	// RVA: 0x7CECC74 Offset: 0x7CE8C74 VA: 0x7CECC74 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7CECD08 Offset: 0x7CE8D08 VA: 0x7CECD08 Slot: 5
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract int GetDeepHashCode();

	// RVA: 0x7CECDA0 Offset: 0x7CE8DA0 VA: 0x7CECDA0 Slot: 4
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(object key) { }

	// RVA: 0x7CECDB0 Offset: 0x7CE8DB0 VA: 0x7CECDB0
	public JsonReader CreateReader() { }

	// RVA: 0x7CE0624 Offset: 0x7CDC624 VA: 0x7CE0624
	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x7CECE0C Offset: 0x7CE8E0C VA: 0x7CECE0C
	public static JToken FromObject(object o) { }

	// RVA: 0x7CECE74 Offset: 0x7CE8E74 VA: 0x7CECE74
	public static JToken FromObject(object o, JsonSerializer jsonSerializer) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46466E0 Offset: 0x46426E0 VA: 0x46466E0
	|-JToken.ToObject<object>
	|
	|-RVA: 0x46467A0 Offset: 0x46427A0 VA: 0x46467A0
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7CECED8 Offset: 0x7CE8ED8 VA: 0x7CECED8
	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>(JsonSerializer jsonSerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46468B8 Offset: 0x46428B8 VA: 0x46468B8
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x7CEDB50 Offset: 0x7CE9B50 VA: 0x7CEDB50
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0x7CEDDC0 Offset: 0x7CE9DC0 VA: 0x7CEDDC0
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0x7CEDE18 Offset: 0x7CE9E18 VA: 0x7CEDE18
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x7CEE0F4 Offset: 0x7CEA0F4 VA: 0x7CEE0F4
	public static JToken Parse(string json) { }

	// RVA: 0x7CEE14C Offset: 0x7CEA14C VA: 0x7CEE14C
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x7CEE368 Offset: 0x7CEA368 VA: 0x7CEE368
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x7CEE3CC Offset: 0x7CEA3CC VA: 0x7CEE3CC
	public static JToken Load(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x7CD4D8C Offset: 0x7CD0D8C VA: 0x7CD4D8C
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0x7CEE424 Offset: 0x7CEA424 VA: 0x7CEE424
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x7CEE71C Offset: 0x7CEA71C VA: 0x7CEE71C Slot: 7
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x7CEE770 Offset: 0x7CEA770 VA: 0x7CEE770 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x7CEE7C4 Offset: 0x7CEA7C4 VA: 0x7CEE7C4 Slot: 9
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x7CEE818 Offset: 0x7CEA818 VA: 0x7CEE818
	public JToken SelectToken(string path) { }

	// RVA: 0x7CEEB88 Offset: 0x7CEAB88 VA: 0x7CEEB88
	public JToken SelectToken(string path, bool errorWhenNoMatch) { }

	[NullableContext(2)]
	// RVA: 0x7CEE820 Offset: 0x7CEA820 VA: 0x7CEE820
	public JToken SelectToken(string path, JsonSelectSettings settings) { }

	// RVA: 0x7CEEC14 Offset: 0x7CEAC14 VA: 0x7CEEC14
	public IEnumerable<JToken> SelectTokens(string path) { }

	// RVA: 0x7CEECA0 Offset: 0x7CEACA0 VA: 0x7CEECA0
	public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch) { }

	// RVA: 0x7CEEC1C Offset: 0x7CEAC1C VA: 0x7CEEC1C
	public IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings settings) { }

	// RVA: 0x7CEED2C Offset: 0x7CEAD2C VA: 0x7CEED2C Slot: 26
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x7CEEDF4 Offset: 0x7CEADF4 VA: 0x7CEEDF4 Slot: 11
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x7CEEE04 Offset: 0x7CEAE04 VA: 0x7CEEE04 Slot: 10
	private object System.ICloneable.Clone() { }

	// RVA: 0x7CEEE18 Offset: 0x7CEAE18 VA: 0x7CEEE18
	public JToken DeepClone() { }

	// RVA: 0x7CEEE2C Offset: 0x7CEAE2C VA: 0x7CEEE2C
	public JToken DeepClone(JsonCloneSettings settings) { }

	// RVA: 0x7CEE4C0 Offset: 0x7CEA4C0 VA: 0x7CEE4C0
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46462A4 Offset: 0x46422A4 VA: 0x46462A4
	|-JToken.Annotation<object>
	*/

	// RVA: 0x7CEEE3C Offset: 0x7CEAE3C VA: 0x7CEEE3C
	public object Annotation(Type type) { }

	[IteratorStateMachine(typeof(JToken.<Annotations>d__185<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646420 Offset: 0x4642420 VA: 0x4646420
	|-JToken.Annotations<object>
	*/

	[IteratorStateMachine(typeof(JToken.<Annotations>d__186))]
	// RVA: 0x7CEEFB0 Offset: 0x7CEAFB0 VA: 0x7CEEFB0
	public IEnumerable<object> Annotations(Type type) { }

	// RVA: -1 Offset: -1
	public void RemoveAnnotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646530 Offset: 0x4642530 VA: 0x4646530
	|-JToken.RemoveAnnotations<object>
	*/

	// RVA: 0x7CEF07C Offset: 0x7CEB07C VA: 0x7CEF07C
	public void RemoveAnnotations(Type type) { }

	// RVA: 0x7CD8F68 Offset: 0x7CD4F68 VA: 0x7CD8F68
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0x7CEF298 Offset: 0x7CEB298 VA: 0x7CEF298
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 19624
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x7CF0814 Offset: 0x7CEC814 VA: 0x7CF0814 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	[NullableContext(1)]
	// RVA: 0x7CF087C Offset: 0x7CEC87C VA: 0x7CF087C Slot: 5
	public int GetHashCode(JToken obj) { }

	// RVA: 0x7CF08A0 Offset: 0x7CEC8A0 VA: 0x7CF08A0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 19625
{
	// Fields
	private readonly JToken _root; // 0x78
	[Nullable(2)]
	private string _initialPath; // 0x80
	[Nullable(2)]
	private JToken _parent; // 0x88
	[Nullable(2)]
	private JToken _current; // 0x90

	// Properties
	[Nullable(2)]
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x7CF08A8 Offset: 0x7CEC8A8 VA: 0x7CF08A8
	public JToken get_CurrentToken() { }

	// RVA: 0x7CF08B0 Offset: 0x7CEC8B0 VA: 0x7CF08B0
	public void .ctor(JToken token) { }

	// RVA: 0x7CF0924 Offset: 0x7CEC924 VA: 0x7CF0924 Slot: 11
	public override bool Read() { }

	// RVA: 0x7CF0A84 Offset: 0x7CECA84 VA: 0x7CF0A84
	private bool ReadOver(JToken t) { }

	// RVA: 0x7CF1150 Offset: 0x7CED150 VA: 0x7CF1150
	private bool ReadToEnd() { }

	// RVA: 0x7CF1220 Offset: 0x7CED220 VA: 0x7CF1220
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0x7CF0A00 Offset: 0x7CECA00 VA: 0x7CF0A00
	private bool ReadInto(JContainer c) { }

	// RVA: 0x7CF1180 Offset: 0x7CED180 VA: 0x7CF1180
	private bool SetEnd(JContainer c) { }

	// RVA: 0x7CF0B54 Offset: 0x7CECB54 VA: 0x7CF0B54
	private void SetToken(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x7CF1378 Offset: 0x7CED378 VA: 0x7CF1378
	private string SafeToString(object value) { }

	// RVA: 0x7CF1398 Offset: 0x7CED398 VA: 0x7CF1398 Slot: 22
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x7CF144C Offset: 0x7CED44C VA: 0x7CF144C Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x7CF1504 Offset: 0x7CED504 VA: 0x7CF1504 Slot: 24
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x7CF15BC Offset: 0x7CED5BC VA: 0x7CF15BC Slot: 10
	public override string get_Path() { }
}

// Namespace: Newtonsoft.Json.Linq
public enum JTokenType // TypeDefIndex: 19626
{
	// Fields
	public int value__; // 0x0
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(2)]
[Nullable(0)]
public class JTokenWriter : JsonWriter // TypeDefIndex: 19627
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken Token { get; }

	// Methods

	// RVA: 0x7CF16B4 Offset: 0x7CED6B4 VA: 0x7CF16B4
	public JToken get_Token() { }

	// RVA: 0x7CF16D0 Offset: 0x7CED6D0 VA: 0x7CF16D0
	public void .ctor() { }

	// RVA: 0x7CF1728 Offset: 0x7CED728 VA: 0x7CF1728 Slot: 60
	public override void Close() { }

	// RVA: 0x7CF1730 Offset: 0x7CED730 VA: 0x7CF1730 Slot: 61
	public override void WriteStartObject() { }

	[NullableContext(1)]
	// RVA: 0x7CF1798 Offset: 0x7CED798 VA: 0x7CF1798
	private void AddParent(JContainer container) { }

	// RVA: 0x7CF17FC Offset: 0x7CED7FC VA: 0x7CF17FC
	private void RemoveParent() { }

	// RVA: 0x7CF1870 Offset: 0x7CED870 VA: 0x7CF1870 Slot: 63
	public override void WriteStartArray() { }

	[NullableContext(1)]
	// RVA: 0x7CF18D8 Offset: 0x7CED8D8 VA: 0x7CF18D8 Slot: 65
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x7CF1954 Offset: 0x7CED954 VA: 0x7CF1954 Slot: 71
	protected override void WriteEnd(JsonToken token) { }

	[NullableContext(1)]
	// RVA: 0x7CF1958 Offset: 0x7CED958 VA: 0x7CF1958 Slot: 67
	public override void WritePropertyName(string name) { }

	// RVA: 0x7CF1A20 Offset: 0x7CEDA20 VA: 0x7CF1A20
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0x7CF1B10 Offset: 0x7CEDB10 VA: 0x7CF1B10
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0x7CF1C30 Offset: 0x7CEDC30 VA: 0x7CF1C30 Slot: 116
	public override void WriteValue(object value) { }

	// RVA: 0x7CF1CC0 Offset: 0x7CEDCC0 VA: 0x7CF1CC0 Slot: 75
	public override void WriteNull() { }

	// RVA: 0x7CF1CE4 Offset: 0x7CEDCE4 VA: 0x7CF1CE4 Slot: 76
	public override void WriteUndefined() { }

	// RVA: 0x7CF1D60 Offset: 0x7CEDD60 VA: 0x7CF1D60 Slot: 77
	public override void WriteRaw(string json) { }

	// RVA: 0x7CF1DDC Offset: 0x7CEDDDC VA: 0x7CF1DDC Slot: 117
	public override void WriteComment(string text) { }

	// RVA: 0x7CF1E6C Offset: 0x7CEDE6C VA: 0x7CF1E6C Slot: 79
	public override void WriteValue(string value) { }

	// RVA: 0x7CF1EF0 Offset: 0x7CEDEF0 VA: 0x7CF1EF0 Slot: 80
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CF1F70 Offset: 0x7CEDF70 VA: 0x7CF1F70 Slot: 81
	public override void WriteValue(uint value) { }

	// RVA: 0x7CF1FF0 Offset: 0x7CEDFF0 VA: 0x7CF1FF0 Slot: 82
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CF20DC Offset: 0x7CEE0DC VA: 0x7CF20DC Slot: 83
	public override void WriteValue(ulong value) { }

	// RVA: 0x7CF21C0 Offset: 0x7CEE1C0 VA: 0x7CF21C0 Slot: 84
	public override void WriteValue(float value) { }

	// RVA: 0x7CF22A4 Offset: 0x7CEE2A4 VA: 0x7CF22A4 Slot: 85
	public override void WriteValue(double value) { }

	// RVA: 0x7CF2390 Offset: 0x7CEE390 VA: 0x7CF2390 Slot: 86
	public override void WriteValue(bool value) { }

	// RVA: 0x7CF2480 Offset: 0x7CEE480 VA: 0x7CF2480 Slot: 87
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CF2500 Offset: 0x7CEE500 VA: 0x7CF2500 Slot: 88
	public override void WriteValue(ushort value) { }

	// RVA: 0x7CF2580 Offset: 0x7CEE580 VA: 0x7CF2580 Slot: 89
	public override void WriteValue(char value) { }

	// RVA: 0x7CF2674 Offset: 0x7CEE674 VA: 0x7CF2674 Slot: 90
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CF26F4 Offset: 0x7CEE6F4 VA: 0x7CF26F4 Slot: 91
	public override void WriteValue(sbyte value) { }

	// RVA: 0x7CF2774 Offset: 0x7CEE774 VA: 0x7CF2774 Slot: 92
	public override void WriteValue(Decimal value) { }

	// RVA: 0x7CF2874 Offset: 0x7CEE874 VA: 0x7CF2874 Slot: 93
	public override void WriteValue(DateTime value) { }

	// RVA: 0x7CF2998 Offset: 0x7CEE998 VA: 0x7CF2998 Slot: 94
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x7CF2A94 Offset: 0x7CEEA94 VA: 0x7CF2A94 Slot: 114
	public override void WriteValue(byte[] value) { }

	// RVA: 0x7CF2B10 Offset: 0x7CEEB10 VA: 0x7CF2B10 Slot: 96
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x7CF2BF4 Offset: 0x7CEEBF4 VA: 0x7CF2BF4 Slot: 95
	public override void WriteValue(Guid value) { }

	// RVA: 0x7CF2CF0 Offset: 0x7CEECF0 VA: 0x7CF2CF0 Slot: 115
	public override void WriteValue(Uri value) { }

	[NullableContext(1)]
	// RVA: 0x7CF2DEC Offset: 0x7CEEDEC VA: 0x7CF2DEC Slot: 70
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }
}

// Namespace: 
[Nullable(new[] { 0, 1 })]
[NullableContext(1)]
private class JValue.JValueDynamicProxy : DynamicProxy<JValue> // TypeDefIndex: 19628
{
	// Methods

	// RVA: 0x7CF69E0 Offset: 0x7CF29E0 VA: 0x7CF69E0 Slot: 6
	public override bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	// RVA: 0x7CF6BCC Offset: 0x7CF2BCC VA: 0x7CF6BCC Slot: 5
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

	// RVA: 0x7CF6304 Offset: 0x7CF2304 VA: 0x7CF6304
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(2)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 19629
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7CF30F8 Offset: 0x7CEF0F8 VA: 0x7CF30F8 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x7CF1A90 Offset: 0x7CEDA90 VA: 0x7CF1A90
	internal void .ctor(object value, JTokenType type) { }

	[NullableContext(1)]
	// RVA: 0x7CF3920 Offset: 0x7CEF920 VA: 0x7CF3920
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0x7CF2068 Offset: 0x7CEE068 VA: 0x7CF2068
	public void .ctor(long value) { }

	// RVA: 0x7CF27F8 Offset: 0x7CEE7F8 VA: 0x7CF27F8
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x7CF2154 Offset: 0x7CEE154 VA: 0x7CF2154
	public void .ctor(ulong value) { }

	// RVA: 0x7CF231C Offset: 0x7CEE31C VA: 0x7CF231C
	public void .ctor(double value) { }

	// RVA: 0x7CF2238 Offset: 0x7CEE238 VA: 0x7CF2238
	public void .ctor(float value) { }

	// RVA: 0x7CF292C Offset: 0x7CEE92C VA: 0x7CF292C
	public void .ctor(DateTime value) { }

	// RVA: 0x7CF2A1C Offset: 0x7CEEA1C VA: 0x7CF2A1C
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0x7CF240C Offset: 0x7CEE40C VA: 0x7CF240C
	public void .ctor(bool value) { }

	// RVA: 0x7CF1EE8 Offset: 0x7CEDEE8 VA: 0x7CF1EE8
	public void .ctor(string value) { }

	// RVA: 0x7CF2C78 Offset: 0x7CEEC78 VA: 0x7CF2C78
	public void .ctor(Guid value) { }

	// RVA: 0x7CF2D68 Offset: 0x7CEED68 VA: 0x7CF2D68
	public void .ctor(Uri value) { }

	// RVA: 0x7CF2B88 Offset: 0x7CEEB88 VA: 0x7CF2B88
	public void .ctor(TimeSpan value) { }

	// RVA: 0x7CF39EC Offset: 0x7CEF9EC VA: 0x7CF39EC
	public void .ctor(object value) { }

	[NullableContext(1)]
	// RVA: 0x7CF3E48 Offset: 0x7CEFE48 VA: 0x7CF3E48 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x7CF3F40 Offset: 0x7CEFF40 VA: 0x7CF3F40 Slot: 16
	public override bool get_HasValues() { }

	[NullableContext(1)]
	// RVA: 0x7CF3F48 Offset: 0x7CEFF48 VA: 0x7CF3F48
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0x7CF424C Offset: 0x7CF024C VA: 0x7CF424C
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[NullableContext(1)]
	// RVA: 0x7CF4CC4 Offset: 0x7CF0CC4 VA: 0x7CF4CC4
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0x7CF4DBC Offset: 0x7CF0DBC VA: 0x7CF4DBC
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[NullableContext(1)]
	// RVA: 0x7CF5700 Offset: 0x7CF1700 VA: 0x7CF5700 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[NullableContext(1)]
	// RVA: 0x7CF1E10 Offset: 0x7CEDE10 VA: 0x7CF1E10
	public static JValue CreateComment(string value) { }

	[NullableContext(1)]
	// RVA: 0x7CF1BD8 Offset: 0x7CEDBD8 VA: 0x7CF1BD8
	public static JValue CreateNull() { }

	[NullableContext(1)]
	// RVA: 0x7CF1D08 Offset: 0x7CEDD08 VA: 0x7CF1D08
	public static JValue CreateUndefined() { }

	// RVA: 0x7CF3A1C Offset: 0x7CEFA1C VA: 0x7CF3A1C
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0x7CF5768 Offset: 0x7CF1768 VA: 0x7CF5768
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0x7CF57E4 Offset: 0x7CF17E4 VA: 0x7CF57E4 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x7CF57EC Offset: 0x7CF17EC VA: 0x7CF57EC
	public object get_Value() { }

	[NullableContext(1)]
	// RVA: 0x7CF57F4 Offset: 0x7CF17F4 VA: 0x7CF57F4 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x7CF5FC4 Offset: 0x7CF1FC4 VA: 0x7CF5FC4 Slot: 25
	internal override int GetDeepHashCode() { }

	[NullableContext(1)]
	// RVA: 0x7CF3EE4 Offset: 0x7CEFEE4 VA: 0x7CF3EE4
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0x7CF6014 Offset: 0x7CF2014 VA: 0x7CF6014 Slot: 27
	public bool Equals(JValue other) { }

	// RVA: 0x7CF6024 Offset: 0x7CF2024 VA: 0x7CF6024 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7CF60B0 Offset: 0x7CF20B0 VA: 0x7CF60B0 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x7CF60C8 Offset: 0x7CF20C8 VA: 0x7CF60C8 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x7CF6130 Offset: 0x7CF2130 VA: 0x7CF6130 Slot: 46
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x7CF613C Offset: 0x7CF213C VA: 0x7CF613C Slot: 28
	public string ToString(string format, IFormatProvider formatProvider) { }

	[NullableContext(1)]
	// RVA: 0x7CF6254 Offset: 0x7CF2254 VA: 0x7CF6254 Slot: 26
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x7CF634C Offset: 0x7CF234C VA: 0x7CF634C Slot: 29
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x7CF6408 Offset: 0x7CF2408 VA: 0x7CF6408 Slot: 30
	public int CompareTo(JValue obj) { }

	// RVA: 0x7CF644C Offset: 0x7CF244C VA: 0x7CF644C Slot: 31
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0x7CF6508 Offset: 0x7CF2508 VA: 0x7CF6508 Slot: 32
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x7CF6560 Offset: 0x7CF2560 VA: 0x7CF6560 Slot: 33
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x7CF65B8 Offset: 0x7CF25B8 VA: 0x7CF65B8 Slot: 34
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x7CF6610 Offset: 0x7CF2610 VA: 0x7CF6610 Slot: 35
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x7CF6668 Offset: 0x7CF2668 VA: 0x7CF6668 Slot: 36
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x7CF66C0 Offset: 0x7CF26C0 VA: 0x7CF66C0 Slot: 37
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x7CF6718 Offset: 0x7CF2718 VA: 0x7CF6718 Slot: 38
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x7CF6770 Offset: 0x7CF2770 VA: 0x7CF6770 Slot: 39
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x7CF67C8 Offset: 0x7CF27C8 VA: 0x7CF67C8 Slot: 40
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x7CF6820 Offset: 0x7CF2820 VA: 0x7CF6820 Slot: 41
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x7CF6878 Offset: 0x7CF2878 VA: 0x7CF6878 Slot: 42
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x7CF68D0 Offset: 0x7CF28D0 VA: 0x7CF68D0 Slot: 43
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x7CF6928 Offset: 0x7CF2928 VA: 0x7CF6928 Slot: 44
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x7CF6980 Offset: 0x7CF2980 VA: 0x7CF6980 Slot: 45
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[NullableContext(1)]
	// RVA: 0x7CF69D8 Offset: 0x7CF29D8 VA: 0x7CF69D8 Slot: 47
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }
}

// Namespace: Newtonsoft.Json.Linq
public enum LineInfoHandling // TypeDefIndex: 19630
{
	// Fields
	public int value__; // 0x0
	public const LineInfoHandling Ignore = 0;
	public const LineInfoHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum MergeArrayHandling // TypeDefIndex: 19631
{
	// Fields
	public int value__; // 0x0
	public const MergeArrayHandling Concat = 0;
	public const MergeArrayHandling Union = 1;
	public const MergeArrayHandling Replace = 2;
	public const MergeArrayHandling Merge = 3;
}

// Namespace: Newtonsoft.Json.Linq
[Flags]
public enum MergeNullValueHandling // TypeDefIndex: 19632
{
	// Fields
	public int value__; // 0x0
	public const MergeNullValueHandling Ignore = 0;
	public const MergeNullValueHandling Merge = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class ArrayIndexFilter.<ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19633
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(1)]
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	public ArrayIndexFilter <>4__this; // 0x38
	private JsonSelectSettings settings; // 0x40
	public JsonSelectSettings <>3__settings; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x50
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap2; // 0x58

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CF6FD0 Offset: 0x7CF2FD0 VA: 0x7CF6FD0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF7014 Offset: 0x7CF3014 VA: 0x7CF7014 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CF70C8 Offset: 0x7CF30C8 VA: 0x7CF70C8 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CF7A5C Offset: 0x7CF3A5C VA: 0x7CF7A5C
	private void <>m__Finally1() { }

	// RVA: 0x7CF79AC Offset: 0x7CF39AC VA: 0x7CF79AC
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CF7B0C Offset: 0x7CF3B0C VA: 0x7CF7B0C Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF7B14 Offset: 0x7CF3B14 VA: 0x7CF7B14 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CF7B4C Offset: 0x7CF3B4C VA: 0x7CF7B4C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF7B54 Offset: 0x7CF3B54 VA: 0x7CF7B54 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CF7C18 Offset: 0x7CF3C18 VA: 0x7CF7C18 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
internal class ArrayIndexFilter : PathFilter // TypeDefIndex: 19634
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Index>k__BackingField; // 0x10

	// Properties
	public Nullable<int> Index { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CF6F14 Offset: 0x7CF2F14 VA: 0x7CF6F14
	public Nullable<int> get_Index() { }

	[CompilerGenerated]
	// RVA: 0x7CF6F1C Offset: 0x7CF2F1C VA: 0x7CF6F1C
	public void set_Index(Nullable<int> value) { }

	[IteratorStateMachine(typeof(ArrayIndexFilter.<ExecuteFilter>d__4))]
	[NullableContext(1)]
	// RVA: 0x7CF6F24 Offset: 0x7CF2F24 VA: 0x7CF6F24 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x7CF7004 Offset: 0x7CF3004 VA: 0x7CF7004
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ArrayMultipleIndexFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19635
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public ArrayMultipleIndexFilter <>4__this; // 0x38
	[Nullable(0)]
	private JsonSelectSettings settings; // 0x40
	[Nullable(0)]
	public JsonSelectSettings <>3__settings; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x50
	[Nullable(0)]
	private JToken <t>5__3; // 0x58
	[Nullable(0)]
	private List.Enumerator<int> <>7__wrap3; // 0x60

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CF7CF8 Offset: 0x7CF3CF8 VA: 0x7CF7CF8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF7D2C Offset: 0x7CF3D2C VA: 0x7CF7D2C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CF7DDC Offset: 0x7CF3DDC VA: 0x7CF7DDC Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CF81CC Offset: 0x7CF41CC VA: 0x7CF81CC
	private void <>m__Finally1() { }

	// RVA: 0x7CF817C Offset: 0x7CF417C VA: 0x7CF817C
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CF827C Offset: 0x7CF427C VA: 0x7CF827C Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF8284 Offset: 0x7CF4284 VA: 0x7CF8284 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CF82BC Offset: 0x7CF42BC VA: 0x7CF82BC Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF82C4 Offset: 0x7CF42C4 VA: 0x7CF82C4 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CF8388 Offset: 0x7CF4388 VA: 0x7CF8388 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class ArrayMultipleIndexFilter : PathFilter // TypeDefIndex: 19636
{
	// Fields
	internal List<int> Indexes; // 0x10

	// Methods

	// RVA: 0x7CF7C1C Offset: 0x7CF3C1C VA: 0x7CF7C1C
	public void .ctor(List<int> indexes) { }

	[IteratorStateMachine(typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7CF7C4C Offset: 0x7CF3C4C VA: 0x7CF7C4C Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ArraySliceFilter.<ExecuteFilter>d__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19637
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(1)]
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ArraySliceFilter <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x30
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x38
	private JsonSelectSettings settings; // 0x40
	public JsonSelectSettings <>3__settings; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x50
	private JArray <a>5__3; // 0x58
	private int <stepCount>5__4; // 0x60
	private int <stopIndex>5__5; // 0x64
	private bool <positiveStep>5__6; // 0x68
	private int <i>5__7; // 0x6C

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CF8468 Offset: 0x7CF4468 VA: 0x7CF8468
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF84BC Offset: 0x7CF44BC VA: 0x7CF84BC Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CF84D8 Offset: 0x7CF44D8 VA: 0x7CF84D8 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CF8E60 Offset: 0x7CF4E60 VA: 0x7CF8E60
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7CF8F10 Offset: 0x7CF4F10 VA: 0x7CF8F10 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF8F18 Offset: 0x7CF4F18 VA: 0x7CF8F18 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CF8F50 Offset: 0x7CF4F50 VA: 0x7CF8F50 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF8F58 Offset: 0x7CF4F58 VA: 0x7CF8F58 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CF901C Offset: 0x7CF501C VA: 0x7CF901C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
internal class ArraySliceFilter : PathFilter // TypeDefIndex: 19638
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Start>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <End>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <Step>k__BackingField; // 0x20

	// Properties
	public Nullable<int> Start { get; set; }
	public Nullable<int> End { get; set; }
	public Nullable<int> Step { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CF838C Offset: 0x7CF438C VA: 0x7CF838C
	public Nullable<int> get_Start() { }

	[CompilerGenerated]
	// RVA: 0x7CF8394 Offset: 0x7CF4394 VA: 0x7CF8394
	public void set_Start(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x7CF839C Offset: 0x7CF439C VA: 0x7CF839C
	public Nullable<int> get_End() { }

	[CompilerGenerated]
	// RVA: 0x7CF83A4 Offset: 0x7CF43A4 VA: 0x7CF83A4
	public void set_End(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x7CF83AC Offset: 0x7CF43AC VA: 0x7CF83AC
	public Nullable<int> get_Step() { }

	[CompilerGenerated]
	// RVA: 0x7CF83B4 Offset: 0x7CF43B4 VA: 0x7CF83B4
	public void set_Step(Nullable<int> value) { }

	[IteratorStateMachine(typeof(ArraySliceFilter.<ExecuteFilter>d__12))]
	[NullableContext(1)]
	// RVA: 0x7CF83BC Offset: 0x7CF43BC VA: 0x7CF83BC Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x7CF849C Offset: 0x7CF449C VA: 0x7CF849C
	private bool IsValid(int index, int stopIndex, bool positiveStep) { }

	// RVA: 0x7CF84B4 Offset: 0x7CF44B4 VA: 0x7CF84B4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FieldFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19639
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(1)]
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public FieldFilter <>4__this; // 0x38
	[Nullable(0)]
	private JsonSelectSettings settings; // 0x40
	[Nullable(0)]
	public JsonSelectSettings <>3__settings; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x50
	[Nullable(new[] { 0, 0, 1, 2 })]
	private IEnumerator<KeyValuePair<string, JToken>> <>7__wrap2; // 0x58

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CF90FC Offset: 0x7CF50FC VA: 0x7CF90FC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF9130 Offset: 0x7CF5130 VA: 0x7CF9130 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CF91E4 Offset: 0x7CF51E4 VA: 0x7CF91E4 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CF9910 Offset: 0x7CF5910 VA: 0x7CF9910
	private void <>m__Finally1() { }

	// RVA: 0x7CF9860 Offset: 0x7CF5860 VA: 0x7CF9860
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CF99C0 Offset: 0x7CF59C0 VA: 0x7CF99C0 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF99C8 Offset: 0x7CF59C8 VA: 0x7CF99C8 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CF9A00 Offset: 0x7CF5A00 VA: 0x7CF9A00 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF9A08 Offset: 0x7CF5A08 VA: 0x7CF9A08 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CF9ACC Offset: 0x7CF5ACC VA: 0x7CF9ACC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(2)]
internal class FieldFilter : PathFilter // TypeDefIndex: 19640
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x7CF9020 Offset: 0x7CF5020 VA: 0x7CF9020
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(FieldFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7CF9050 Offset: 0x7CF5050 VA: 0x7CF9050 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldMultipleFilter.<>c // TypeDefIndex: 19641
{
	// Fields
	[Nullable(0)]
	public static readonly FieldMultipleFilter.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<string, string> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x7CF9BE0 Offset: 0x7CF5BE0 VA: 0x7CF9BE0
	private static void .cctor() { }

	// RVA: 0x7CF9C48 Offset: 0x7CF5C48 VA: 0x7CF9C48
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7CF9C50 Offset: 0x7CF5C50 VA: 0x7CF9C50
	internal string <ExecuteFilter>b__2_0(string n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FieldMultipleFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19642
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public FieldMultipleFilter <>4__this; // 0x38
	[Nullable(0)]
	private JsonSelectSettings settings; // 0x40
	[Nullable(0)]
	public JsonSelectSettings <>3__settings; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x50
	[Nullable(0)]
	private JObject <o>5__3; // 0x58
	[Nullable(new[] { 0, 1 })]
	private List.Enumerator<string> <>7__wrap3; // 0x60
	[Nullable(0)]
	private string <name>5__5; // 0x78

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CF9BAC Offset: 0x7CF5BAC VA: 0x7CF9BAC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF9CA0 Offset: 0x7CF5CA0 VA: 0x7CF9CA0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CF9D50 Offset: 0x7CF5D50 VA: 0x7CF9D50 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CFA528 Offset: 0x7CF6528 VA: 0x7CFA528
	private void <>m__Finally1() { }

	// RVA: 0x7CFA4D8 Offset: 0x7CF64D8 VA: 0x7CFA4D8
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CFA5D8 Offset: 0x7CF65D8 VA: 0x7CFA5D8 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFA5E0 Offset: 0x7CF65E0 VA: 0x7CFA5E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CFA618 Offset: 0x7CF6618 VA: 0x7CFA618 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFA620 Offset: 0x7CF6620 VA: 0x7CFA620 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CFA6E4 Offset: 0x7CF66E4 VA: 0x7CFA6E4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(1)]
internal class FieldMultipleFilter : PathFilter // TypeDefIndex: 19643
{
	// Fields
	internal List<string> Names; // 0x10

	// Methods

	// RVA: 0x7CF9AD0 Offset: 0x7CF5AD0 VA: 0x7CF9AD0
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(FieldMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7CF9B00 Offset: 0x7CF5B00 VA: 0x7CF9B00 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class JPath // TypeDefIndex: 19644
{
	// Fields
	private static readonly char[] FloatCharacters; // 0x0
	private readonly string _expression; // 0x10
	[CompilerGenerated]
	private readonly List<PathFilter> <Filters>k__BackingField; // 0x18
	private int _currentIndex; // 0x20

	// Properties
	public List<PathFilter> Filters { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CFA6E8 Offset: 0x7CF66E8 VA: 0x7CFA6E8
	public List<PathFilter> get_Filters() { }

	// RVA: 0x7CFA6F0 Offset: 0x7CF66F0 VA: 0x7CFA6F0
	public void .ctor(string expression) { }

	// RVA: 0x7CFA7C0 Offset: 0x7CF67C0 VA: 0x7CFA7C0
	private void ParseMain() { }

	// RVA: 0x7CFA978 Offset: 0x7CF6978 VA: 0x7CFA978
	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	// RVA: 0x7CFAF7C Offset: 0x7CF6F7C VA: 0x7CFAF7C
	private static PathFilter CreatePathFilter(string member, bool scan) { }

	// RVA: 0x7CFB00C Offset: 0x7CF700C VA: 0x7CFB00C
	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	// RVA: 0x7CFB714 Offset: 0x7CF7714 VA: 0x7CFB714
	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	// RVA: 0x7CFA924 Offset: 0x7CF6924 VA: 0x7CFA924
	private void EatWhitespace() { }

	// RVA: 0x7CFB538 Offset: 0x7CF7538 VA: 0x7CFB538
	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	// RVA: 0x7CFC3D8 Offset: 0x7CF83D8 VA: 0x7CFC3D8
	private bool TryParseExpression(out List<PathFilter> expressionPath) { }

	// RVA: 0x7CFC5EC Offset: 0x7CF85EC VA: 0x7CFC5EC
	private JsonException CreateUnexpectedCharacterException() { }

	// RVA: 0x7CFC6D0 Offset: 0x7CF86D0 VA: 0x7CFC6D0
	private object ParseSide() { }

	// RVA: 0x7CFBEA0 Offset: 0x7CF7EA0 VA: 0x7CFBEA0
	private QueryExpression ParseExpression() { }

	[NullableContext(2)]
	// RVA: 0x7CFC7E0 Offset: 0x7CF87E0 VA: 0x7CFC7E0
	private bool TryParseValue(out object value) { }

	// RVA: 0x7CFCF58 Offset: 0x7CF8F58 VA: 0x7CFCF58
	private string ReadQuotedString() { }

	// RVA: 0x7CFD1E4 Offset: 0x7CF91E4 VA: 0x7CFD1E4
	private string ReadRegexString() { }

	// RVA: 0x7CFCE18 Offset: 0x7CF8E18 VA: 0x7CFCE18
	private bool Match(string s) { }

	// RVA: 0x7CFCB64 Offset: 0x7CF8B64 VA: 0x7CFCB64
	private QueryOperator ParseOperator() { }

	// RVA: 0x7CFB1B0 Offset: 0x7CF71B0 VA: 0x7CFB1B0
	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	// RVA: 0x7CFB144 Offset: 0x7CF7144 VA: 0x7CFB144
	private void EnsureLength(string message) { }

	// RVA: 0x7CFD380 Offset: 0x7CF9380 VA: 0x7CFD380
	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x7CFD400 Offset: 0x7CF9400 VA: 0x7CFD400
	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x7CFD5DC Offset: 0x7CF95DC VA: 0x7CFD5DC
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(2)]
internal abstract class PathFilter // TypeDefIndex: 19645
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings);

	// RVA: 0x7CF76E4 Offset: 0x7CF36E4 VA: 0x7CF76E4
	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

	// RVA: 0x7CFD67C Offset: 0x7CF967C VA: 0x7CFD67C
	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	// RVA: 0x7CF700C Offset: 0x7CF300C VA: 0x7CF700C
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
internal enum QueryOperator // TypeDefIndex: 19646
{
	// Fields
	public int value__; // 0x0
	public const QueryOperator None = 0;
	public const QueryOperator Equals = 1;
	public const QueryOperator NotEquals = 2;
	public const QueryOperator Exists = 3;
	public const QueryOperator LessThan = 4;
	public const QueryOperator LessThanOrEquals = 5;
	public const QueryOperator GreaterThan = 6;
	public const QueryOperator GreaterThanOrEquals = 7;
	public const QueryOperator And = 8;
	public const QueryOperator Or = 9;
	public const QueryOperator RegexEquals = 10;
	public const QueryOperator StrictEquals = 11;
	public const QueryOperator StrictNotEquals = 12;
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal abstract class QueryExpression // TypeDefIndex: 19647
{
	// Fields
	internal QueryOperator Operator; // 0x10

	// Methods

	// RVA: 0x7CFD714 Offset: 0x7CF9714 VA: 0x7CFD714
	public void .ctor(QueryOperator operator) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings);
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class CompositeExpression : QueryExpression // TypeDefIndex: 19648
{
	// Fields
	[CompilerGenerated]
	private List<QueryExpression> <Expressions>k__BackingField; // 0x18

	// Properties
	public List<QueryExpression> Expressions { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7CFD73C Offset: 0x7CF973C VA: 0x7CFD73C
	public List<QueryExpression> get_Expressions() { }

	[CompilerGenerated]
	// RVA: 0x7CFD744 Offset: 0x7CF9744 VA: 0x7CFD744
	public void set_Expressions(List<QueryExpression> value) { }

	// RVA: 0x7CFCEC8 Offset: 0x7CF8EC8 VA: 0x7CFCEC8
	public void .ctor(QueryOperator operator) { }

	// RVA: 0x7CFD74C Offset: 0x7CF974C VA: 0x7CFD74C Slot: 4
	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(1)]
internal class BooleanQueryExpression : QueryExpression // TypeDefIndex: 19649
{
	// Fields
	public readonly object Left; // 0x18
	[Nullable(2)]
	public readonly object Right; // 0x20

	// Methods

	// RVA: 0x7CFCDC4 Offset: 0x7CF8DC4 VA: 0x7CFCDC4
	public void .ctor(QueryOperator operator, object left, object right) { }

	// RVA: 0x7CFDA0C Offset: 0x7CF9A0C VA: 0x7CFDA0C
	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	// RVA: 0x7CFDBDC Offset: 0x7CF9BDC VA: 0x7CFDBDC Slot: 4
	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x7CFE2D0 Offset: 0x7CFA2D0 VA: 0x7CFE2D0
	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	// RVA: 0x7CFE47C Offset: 0x7CFA47C VA: 0x7CFE47C
	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

	// RVA: 0x7CFE658 Offset: 0x7CFA658 VA: 0x7CFE658
	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	// RVA: 0x7CFEBCC Offset: 0x7CFABCC VA: 0x7CFEBCC
	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QueryFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19650
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public QueryFilter <>4__this; // 0x38
	[Nullable(0)]
	private JToken root; // 0x40
	[Nullable(0)]
	public JToken <>3__root; // 0x48
	[Nullable(0)]
	private JsonSelectSettings settings; // 0x50
	[Nullable(0)]
	public JsonSelectSettings <>3__settings; // 0x58
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x60
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap2; // 0x68

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CFEDA8 Offset: 0x7CFADA8 VA: 0x7CFEDA8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CFEDDC Offset: 0x7CFADDC VA: 0x7CFEDDC Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CFEE8C Offset: 0x7CFAE8C VA: 0x7CFEE8C Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CFF3B4 Offset: 0x7CFB3B4 VA: 0x7CFF3B4
	private void <>m__Finally1() { }

	// RVA: 0x7CFF304 Offset: 0x7CFB304 VA: 0x7CFF304
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CFF464 Offset: 0x7CFB464 VA: 0x7CFF464 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFF46C Offset: 0x7CFB46C VA: 0x7CFF46C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CFF4A4 Offset: 0x7CFB4A4 VA: 0x7CFF4A4 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFF4AC Offset: 0x7CFB4AC VA: 0x7CFF4AC Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CFF580 Offset: 0x7CFB580 VA: 0x7CFF580 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class QueryFilter : PathFilter // TypeDefIndex: 19651
{
	// Fields
	internal QueryExpression Expression; // 0x10

	// Methods

	// RVA: 0x7CFC378 Offset: 0x7CF8378 VA: 0x7CFC378
	public void .ctor(QueryExpression expression) { }

	[IteratorStateMachine(typeof(QueryFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7CFECE0 Offset: 0x7CFACE0 VA: 0x7CFECE0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QueryScanFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19652
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public QueryScanFilter <>4__this; // 0x38
	[Nullable(0)]
	private JToken root; // 0x40
	[Nullable(0)]
	public JToken <>3__root; // 0x48
	[Nullable(0)]
	private JsonSelectSettings settings; // 0x50
	[Nullable(0)]
	public JsonSelectSettings <>3__settings; // 0x58
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x60
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap2; // 0x68

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7CFF64C Offset: 0x7CFB64C VA: 0x7CFF64C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CFF680 Offset: 0x7CFB680 VA: 0x7CFF680 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CFF734 Offset: 0x7CFB734 VA: 0x7CFF734 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7CFFD30 Offset: 0x7CFBD30 VA: 0x7CFFD30
	private void <>m__Finally1() { }

	// RVA: 0x7CFFC80 Offset: 0x7CFBC80 VA: 0x7CFFC80
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7CFFDE0 Offset: 0x7CFBDE0 VA: 0x7CFFDE0 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFFDE8 Offset: 0x7CFBDE8 VA: 0x7CFFDE8 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7CFFE20 Offset: 0x7CFBE20 VA: 0x7CFFE20 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFFE28 Offset: 0x7CFBE28 VA: 0x7CFFE28 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7CFFEFC Offset: 0x7CFBEFC VA: 0x7CFFEFC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class QueryScanFilter : PathFilter // TypeDefIndex: 19653
{
	// Fields
	internal QueryExpression Expression; // 0x10

	// Methods

	// RVA: 0x7CFC3A8 Offset: 0x7CF83A8 VA: 0x7CFC3A8
	public void .ctor(QueryExpression expression) { }

	[IteratorStateMachine(typeof(QueryScanFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7CFF584 Offset: 0x7CFB584 VA: 0x7CFF584 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class RootFilter : PathFilter // TypeDefIndex: 19654
{
	// Fields
	public static readonly RootFilter Instance; // 0x0

	// Methods

	// RVA: 0x7CFFF00 Offset: 0x7CFBF00 VA: 0x7CFFF00
	private void .ctor() { }

	// RVA: 0x7CFFF08 Offset: 0x7CFBF08 VA: 0x7CFFF08 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x7CFFFA4 Offset: 0x7CFBFA4 VA: 0x7CFFFA4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ScanFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19655
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(1)]
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public ScanFilter <>4__this; // 0x38
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x40
	[Nullable(0)]
	private JToken <c>5__3; // 0x48
	[Nullable(0)]
	private JToken <value>5__4; // 0x50

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D000A4 Offset: 0x7CFC0A4 VA: 0x7D000A4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D000D8 Offset: 0x7CFC0D8 VA: 0x7D000D8 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D00104 Offset: 0x7CFC104 VA: 0x7D00104 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7D00598 Offset: 0x7CFC598 VA: 0x7D00598
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7D00648 Offset: 0x7CFC648 VA: 0x7D00648 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D00650 Offset: 0x7CFC650 VA: 0x7D00650 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D00688 Offset: 0x7CFC688 VA: 0x7D00688 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D00690 Offset: 0x7CFC690 VA: 0x7D00690 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7D00744 Offset: 0x7CFC744 VA: 0x7D00744 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(2)]
internal class ScanFilter : PathFilter // TypeDefIndex: 19656
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x7CFB114 Offset: 0x7CF7114 VA: 0x7CFB114
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ScanFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7D0000C Offset: 0x7CFC00C VA: 0x7D0000C Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ScanMultipleFilter.<ExecuteFilter>d__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 19657
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(new[] { 0, 1 })]
	private IEnumerable<JToken> current; // 0x28
	[Nullable(new[] { 0, 1 })]
	public IEnumerable<JToken> <>3__current; // 0x30
	[Nullable(0)]
	public ScanMultipleFilter <>4__this; // 0x38
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x40
	[Nullable(0)]
	private JToken <c>5__3; // 0x48
	[Nullable(0)]
	private JToken <value>5__4; // 0x50
	[Nullable(0)]
	private JProperty <property>5__5; // 0x58
	[Nullable(new[] { 0, 1 })]
	private List.Enumerator<string> <>7__wrap5; // 0x60

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D007E0 Offset: 0x7CFC7E0 VA: 0x7D007E0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D00814 Offset: 0x7CFC814 VA: 0x7D00814 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D008C4 Offset: 0x7CFC8C4 VA: 0x7D008C4 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7D00E18 Offset: 0x7CFCE18 VA: 0x7D00E18
	private void <>m__Finally1() { }

	// RVA: 0x7D00DC8 Offset: 0x7CFCDC8 VA: 0x7D00DC8
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7D00EC8 Offset: 0x7CFCEC8 VA: 0x7D00EC8 Slot: 6
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D00ED0 Offset: 0x7CFCED0 VA: 0x7D00ED0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D00F08 Offset: 0x7CFCF08 VA: 0x7D00F08 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D00F10 Offset: 0x7CFCF10 VA: 0x7D00F10 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7D00FC4 Offset: 0x7CFCFC4 VA: 0x7D00FC4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[Nullable(0)]
[NullableContext(1)]
internal class ScanMultipleFilter : PathFilter // TypeDefIndex: 19658
{
	// Fields
	private List<string> _names; // 0x10

	// Methods

	// RVA: 0x7CFD350 Offset: 0x7CF9350 VA: 0x7CFD350
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(ScanMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x7D00748 Offset: 0x7CFC748 VA: 0x7D00748 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class BinaryConverter : JsonConverter // TypeDefIndex: 19659
{
	// Fields
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x7D00FC8 Offset: 0x7CFCFC8 VA: 0x7D00FC8 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D0101C Offset: 0x7CFD01C VA: 0x7D0101C
	private byte[] GetByteArray(object value) { }

	// RVA: 0x7D01204 Offset: 0x7CFD204 VA: 0x7D01204
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0x7D013C4 Offset: 0x7CFD3C4 VA: 0x7D013C4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D017BC Offset: 0x7CFD7BC VA: 0x7D017BC
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0x7D01A48 Offset: 0x7CFDA48 VA: 0x7D01A48 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D01B60 Offset: 0x7CFDB60 VA: 0x7D01B60
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 19660
{
	// Methods

	// RVA: 0x7D01B68 Offset: 0x7CFDB68 VA: 0x7D01B68 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D01C68 Offset: 0x7CFDC68 VA: 0x7D01C68 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D01DEC Offset: 0x7CFDDEC VA: 0x7D01DEC Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D01E74 Offset: 0x7CFDE74 VA: 0x7D01E74
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 19661
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D18E7C Offset: 0x5D14E7C VA: 0x5D18E7C
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D18EC4 Offset: 0x5D14EC4 VA: 0x5D18EC4
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Create(Type objectType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D190A0 Offset: 0x5D150A0 VA: 0x5D190A0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool get_CanWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1912C Offset: 0x5D1512C VA: 0x5D1912C
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.get_CanWrite
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19134 Offset: 0x5D15134 VA: 0x5D19134
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataSetConverter : JsonConverter // TypeDefIndex: 19662
{
	// Methods

	// RVA: 0x7D01E7C Offset: 0x7CFDE7C VA: 0x7D01E7C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D02314 Offset: 0x7CFE314 VA: 0x7D02314 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D025FC Offset: 0x7CFE5FC VA: 0x7D025FC Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x7D02690 Offset: 0x7CFE690 VA: 0x7D02690
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataTableConverter : JsonConverter // TypeDefIndex: 19663
{
	// Methods

	// RVA: 0x7D02698 Offset: 0x7CFE698 VA: 0x7D02698 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D02EA4 Offset: 0x7CFEEA4 VA: 0x7D02EA4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D03190 Offset: 0x7CFF190 VA: 0x7D03190
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0x7D036B0 Offset: 0x7CFF6B0 VA: 0x7D036B0
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0x7D0387C Offset: 0x7CFF87C VA: 0x7D0387C Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x7D0230C Offset: 0x7CFE30C VA: 0x7D0230C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 19664
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x7D03910 Offset: 0x7CFF910 VA: 0x7D03910 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D03A84 Offset: 0x7CFFA84 VA: 0x7D03A84
	protected void .ctor() { }
}

// Namespace: 
[Nullable(0)]
internal class DiscriminatedUnionConverter.Union // TypeDefIndex: 19665
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly List<DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0x7D04468 Offset: 0x7D00468 VA: 0x7D04468
	public void .ctor(FSharpFunction tagReader, List<DiscriminatedUnionConverter.UnionCase> cases) { }
}

// Namespace: 
[Nullable(0)]
internal class DiscriminatedUnionConverter.UnionCase // TypeDefIndex: 19666
{
	// Fields
	public readonly int Tag; // 0x10
	public readonly string Name; // 0x18
	public readonly PropertyInfo[] Fields; // 0x20
	public readonly FSharpFunction FieldReader; // 0x28
	public readonly FSharpFunction Constructor; // 0x30

	// Methods

	// RVA: 0x7D044AC Offset: 0x7D004AC VA: 0x7D044AC
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscriminatedUnionConverter.<>c__DisplayClass8_0 // TypeDefIndex: 19667
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0x7D049C4 Offset: 0x7D009C4 VA: 0x7D049C4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7D05488 Offset: 0x7D01488 VA: 0x7D05488
	internal bool <WriteJson>b__0(DiscriminatedUnionConverter.UnionCase c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscriminatedUnionConverter.<>c__DisplayClass9_0 // TypeDefIndex: 19668
{
	// Fields
	[Nullable(0)]
	public string caseName; // 0x10
	[Nullable(0)]
	public Func<DiscriminatedUnionConverter.UnionCase, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x7D0504C Offset: 0x7D0104C VA: 0x7D0504C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x7D054AC Offset: 0x7D014AC VA: 0x7D054AC
	internal bool <ReadJson>b__0(DiscriminatedUnionConverter.UnionCase c) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 19669
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0x7D03A8C Offset: 0x7CFFA8C VA: 0x7D03A8C
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0x7D03C98 Offset: 0x7CFFC98 VA: 0x7D03C98
	private static DiscriminatedUnionConverter.Union CreateUnion(Type t) { }

	// RVA: 0x7D04530 Offset: 0x7D00530 VA: 0x7D04530 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D049CC Offset: 0x7D009CC VA: 0x7D049CC Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D05054 Offset: 0x7D01054 VA: 0x7D05054 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D052F0 Offset: 0x7D012F0 VA: 0x7D052F0
	public void .ctor() { }

	// RVA: 0x7D052F8 Offset: 0x7D012F8 VA: 0x7D052F8
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 19670
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x7D054D0 Offset: 0x7D014D0 VA: 0x7D054D0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D0594C Offset: 0x7D0194C VA: 0x7D0594C
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0x7D05A38 Offset: 0x7D01A38 VA: 0x7D05A38 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D0582C Offset: 0x7D0182C VA: 0x7D0582C
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0x7D05CF0 Offset: 0x7D01CF0 VA: 0x7D05CF0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D05D40 Offset: 0x7D01D40 VA: 0x7D05D40
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 19671
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x7D05D48 Offset: 0x7D01D48 VA: 0x7D05D48 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D05D4C Offset: 0x7D01D4C VA: 0x7D05D4C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D05D50 Offset: 0x7D01D50 VA: 0x7D05D50
	private object ReadValue(JsonReader reader) { }

	// RVA: 0x7D06068 Offset: 0x7D02068 VA: 0x7D06068
	private object ReadList(JsonReader reader) { }

	// RVA: 0x7D05EAC Offset: 0x7D01EAC VA: 0x7D05EAC
	private object ReadObject(JsonReader reader) { }

	// RVA: 0x7D061F0 Offset: 0x7D021F0 VA: 0x7D061F0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D06278 Offset: 0x7D02278 VA: 0x7D06278 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0x7D06280 Offset: 0x7D02280 VA: 0x7D06280
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 19672
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	[Nullable(2)]
	private string _dateTimeFormat; // 0x18
	[Nullable(2)]
	private CultureInfo _culture; // 0x20

	// Properties
	public DateTimeStyles DateTimeStyles { get; set; }
	[Nullable(2)]
	public string DateTimeFormat { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x7D06288 Offset: 0x7D02288 VA: 0x7D06288
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0x7D06290 Offset: 0x7D02290 VA: 0x7D06290
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[NullableContext(2)]
	// RVA: 0x7D06298 Offset: 0x7D02298 VA: 0x7D06298
	public string get_DateTimeFormat() { }

	[NullableContext(2)]
	// RVA: 0x7D062EC Offset: 0x7D022EC VA: 0x7D062EC
	public void set_DateTimeFormat(string value) { }

	// RVA: 0x7D0632C Offset: 0x7D0232C VA: 0x7D0632C
	public CultureInfo get_Culture() { }

	// RVA: 0x7D06394 Offset: 0x7D02394 VA: 0x7D06394
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x7D0639C Offset: 0x7D0239C VA: 0x7D0639C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D06604 Offset: 0x7D02604 VA: 0x7D06604 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D06B0C Offset: 0x7D02B0C VA: 0x7D06B0C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class JavaScriptDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 19673
{
	// Methods

	// RVA: 0x7D06B1C Offset: 0x7D02B1C VA: 0x7D06B1C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D06D00 Offset: 0x7D02D00 VA: 0x7D06D00 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D0702C Offset: 0x7D0302C VA: 0x7D0702C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 19674
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0x7D07034 Offset: 0x7D03034 VA: 0x7D07034
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0x7D072B0 Offset: 0x7D032B0 VA: 0x7D072B0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D0750C Offset: 0x7D0350C VA: 0x7D0750C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D079D4 Offset: 0x7D039D4 VA: 0x7D079D4 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D07AEC Offset: 0x7D03AEC VA: 0x7D07AEC
	public void .ctor() { }

	// RVA: 0x7D07AF4 Offset: 0x7D03AF4 VA: 0x7D07AF4
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class RegexConverter : JsonConverter // TypeDefIndex: 19675
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0x7D07BDC Offset: 0x7D03BDC VA: 0x7D07BDC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D07FF8 Offset: 0x7D03FF8 VA: 0x7D07FF8
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0x7D07CFC Offset: 0x7D03CFC VA: 0x7D07CFC
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0x7D07E34 Offset: 0x7D03E34 VA: 0x7D07E34
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0x7D08004 Offset: 0x7D04004 VA: 0x7D08004 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D0831C Offset: 0x7D0431C VA: 0x7D0831C
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0x7D080B0 Offset: 0x7D040B0 VA: 0x7D080B0
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0x7D08480 Offset: 0x7D04480 VA: 0x7D08480 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D08500 Offset: 0x7D04500 VA: 0x7D08500
	private bool IsRegex(Type objectType) { }

	// RVA: 0x7D08588 Offset: 0x7D04588 VA: 0x7D08588
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class StringEnumConverter : JsonConverter // TypeDefIndex: 19676
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Properties
	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	// RVA: 0x7D08590 Offset: 0x7D04590 VA: 0x7D08590
	public bool get_CamelCaseText() { }

	// RVA: 0x7D0860C Offset: 0x7D0460C VA: 0x7D0860C
	public void set_CamelCaseText(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7D086DC Offset: 0x7D046DC VA: 0x7D086DC
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7D086E4 Offset: 0x7D046E4 VA: 0x7D086E4
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	// RVA: 0x7D086EC Offset: 0x7D046EC VA: 0x7D086EC
	public bool get_AllowIntegerValues() { }

	[CompilerGenerated]
	// RVA: 0x7D086F4 Offset: 0x7D046F4 VA: 0x7D086F4
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0x7D08700 Offset: 0x7D04700 VA: 0x7D08700
	public void .ctor() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	// RVA: 0x7D08710 Offset: 0x7D04710 VA: 0x7D08710
	public void .ctor(bool camelCaseText) { }

	// RVA: 0x7D08798 Offset: 0x7D04798 VA: 0x7D08798
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues = True) { }

	// RVA: 0x7D087E0 Offset: 0x7D047E0 VA: 0x7D087E0
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0x7D08890 Offset: 0x7D04890 VA: 0x7D08890
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0x7D0894C Offset: 0x7D0494C VA: 0x7D0894C
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0x7D08A18 Offset: 0x7D04A18 VA: 0x7D08A18 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D08C08 Offset: 0x7D04C08 VA: 0x7D08C08 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D09078 Offset: 0x7D05078 VA: 0x7D09078 Slot: 6
	public override bool CanConvert(Type objectType) { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 19677
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	[CompilerGenerated]
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Properties
	public bool AllowPreEpoch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D090F0 Offset: 0x7D050F0 VA: 0x7D090F0
	public bool get_AllowPreEpoch() { }

	[CompilerGenerated]
	// RVA: 0x7D090F8 Offset: 0x7D050F8 VA: 0x7D090F8
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0x7D09104 Offset: 0x7D05104 VA: 0x7D09104
	public void .ctor() { }

	// RVA: 0x7D09120 Offset: 0x7D05120 VA: 0x7D09120
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0x7D0914C Offset: 0x7D0514C VA: 0x7D0914C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D093B0 Offset: 0x7D053B0 VA: 0x7D093B0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D097B4 Offset: 0x7D057B4 VA: 0x7D097B4
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class VersionConverter : JsonConverter // TypeDefIndex: 19678
{
	// Methods

	// RVA: 0x7D09830 Offset: 0x7D05830 VA: 0x7D09830 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D09918 Offset: 0x7D05918 VA: 0x7D09918 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D09B9C Offset: 0x7D05B9C VA: 0x7D09B9C Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x7D09C24 Offset: 0x7D05C24 VA: 0x7D09C24
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 19679
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x7D09C2C Offset: 0x7D05C2C VA: 0x7D09C2C
	public void .ctor(XmlDocument document) { }

	// RVA: 0x7D09C9C Offset: 0x7D05C9C VA: 0x7D09C9C Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0x7D09D30 Offset: 0x7D05D30 VA: 0x7D09D30 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x7D09DC4 Offset: 0x7D05DC4 VA: 0x7D09DC4 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x7D09E58 Offset: 0x7D05E58 VA: 0x7D09E58 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x7D09EEC Offset: 0x7D05EEC VA: 0x7D09EEC Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x7D09F80 Offset: 0x7D05F80 VA: 0x7D09F80 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x7D0A05C Offset: 0x7D0605C VA: 0x7D0A05C Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x7D0A13C Offset: 0x7D0613C VA: 0x7D0A13C Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x7D0A1E0 Offset: 0x7D061E0 VA: 0x7D0A1E0 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x7D0A29C Offset: 0x7D0629C VA: 0x7D0A29C Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x7D0A328 Offset: 0x7D06328 VA: 0x7D0A328 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x7D0A3FC Offset: 0x7D063FC VA: 0x7D0A3FC Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x7D0A4B8 Offset: 0x7D064B8 VA: 0x7D0A4B8 Slot: 27
	public IXmlElement get_DocumentElement() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 19680
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x7D0A25C Offset: 0x7D0625C VA: 0x7D0A25C
	public void .ctor(XmlElement element) { }

	// RVA: 0x7D0A548 Offset: 0x7D06548 VA: 0x7D0A548 Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x7D0A630 Offset: 0x7D06630 VA: 0x7D0A630 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x7D0A654 Offset: 0x7D06654 VA: 0x7D0A654 Slot: 17
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 19681
{
	// Fields
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0A01C Offset: 0x7D0601C VA: 0x7D0A01C
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0x7D0A670 Offset: 0x7D06670 VA: 0x7D0A670 Slot: 15
	public string get_Version() { }

	// RVA: 0x7D0A68C Offset: 0x7D0668C VA: 0x7D0A68C Slot: 16
	public string get_Encoding() { }

	// RVA: 0x7D0A6A8 Offset: 0x7D066A8 VA: 0x7D0A6A8 Slot: 17
	public string get_Standalone() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 19682
{
	// Fields
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0A0FC Offset: 0x7D060FC VA: 0x7D0A0FC
	public void .ctor(XmlDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x7D0A6C4 Offset: 0x7D066C4 VA: 0x7D0A6C4 Slot: 15
	public string get_Name() { }

	// RVA: 0x7D0A6E4 Offset: 0x7D066E4 VA: 0x7D0A6E4 Slot: 16
	public string get_System() { }

	// RVA: 0x7D0A700 Offset: 0x7D06700 VA: 0x7D0A700 Slot: 17
	public string get_Public() { }

	// RVA: 0x7D0A71C Offset: 0x7D0671C VA: 0x7D0A71C Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0x7D0A738 Offset: 0x7D06738 VA: 0x7D0A738 Slot: 13
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 19683
{
	// Fields
	[Nullable(1)]
	private readonly XmlNode _node; // 0x10
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public List<IXmlNode> Attributes { get; }
	private bool HasAttributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D09C6C Offset: 0x7D05C6C VA: 0x7D09C6C
	public void .ctor(XmlNode node) { }

	// RVA: 0x7D0A778 Offset: 0x7D06778 VA: 0x7D0A778 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x7D0A780 Offset: 0x7D06780 VA: 0x7D0A780 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0x7D0A7A0 Offset: 0x7D067A0 VA: 0x7D0A7A0 Slot: 13
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x7D0A7C4 Offset: 0x7D067C4 VA: 0x7D0A7C4 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x7D0AC18 Offset: 0x7D06C18 VA: 0x7D0AC18
	internal static IXmlNode WrapNode(XmlNode node) { }

	[NullableContext(1)]
	// RVA: 0x7D0ADFC Offset: 0x7D06DFC VA: 0x7D0ADFC Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0x7D0B240 Offset: 0x7D07240 VA: 0x7D0B240
	private bool get_HasAttributes() { }

	// RVA: 0x7D0B2F4 Offset: 0x7D072F4 VA: 0x7D0B2F4 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0x7D0B394 Offset: 0x7D07394 VA: 0x7D0B394 Slot: 9
	public string get_Value() { }

	// RVA: 0x7D0A3DC Offset: 0x7D063DC VA: 0x7D0A3DC Slot: 14
	public void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x7D0B3B4 Offset: 0x7D073B4 VA: 0x7D0B3B4 Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x7D0B474 Offset: 0x7D07474 VA: 0x7D0B474 Slot: 11
	public string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDocument : IXmlNode // TypeDefIndex: 19684
{
	// Properties
	[Nullable(2)]
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 19685
{
	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; }
	public abstract string Standalone { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Standalone();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 19686
{
	// Properties
	[Nullable(1)]
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlElement : IXmlNode // TypeDefIndex: 19687
{
	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlNode // TypeDefIndex: 19688
{
	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object get_WrappedNode();
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 19689
{
	// Fields
	[CompilerGenerated]
	[Nullable(1)]
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	[Nullable(1)]
	internal XDeclaration Declaration { get; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x7D0B498 Offset: 0x7D07498 VA: 0x7D0B498
	internal XDeclaration get_Declaration() { }

	[NullableContext(1)]
	// RVA: 0x7D0B4A0 Offset: 0x7D074A0 VA: 0x7D0B4A0
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0x7D0B510 Offset: 0x7D07510 VA: 0x7D0B510 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7D0B518 Offset: 0x7D07518 VA: 0x7D0B518 Slot: 21
	public string get_Version() { }

	// RVA: 0x7D0B534 Offset: 0x7D07534 VA: 0x7D0B534 Slot: 22
	public string get_Encoding() { }

	// RVA: 0x7D0B550 Offset: 0x7D07550 VA: 0x7D0B550 Slot: 23
	public string get_Standalone() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 19690
{
	// Fields
	[Nullable(1)]
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0B56C Offset: 0x7D0756C VA: 0x7D0B56C
	public void .ctor(XDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x7D0B5AC Offset: 0x7D075AC VA: 0x7D0B5AC Slot: 21
	public string get_Name() { }

	// RVA: 0x7D0B5C8 Offset: 0x7D075C8 VA: 0x7D0B5C8 Slot: 22
	public string get_System() { }

	// RVA: 0x7D0B5E4 Offset: 0x7D075E4 VA: 0x7D0B5E4 Slot: 23
	public string get_Public() { }

	// RVA: 0x7D0B600 Offset: 0x7D07600 VA: 0x7D0B600 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0x7D0B61C Offset: 0x7D0761C VA: 0x7D0B61C Slot: 14
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 19691
{
	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected override bool HasChildNodes { get; }
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x7D0B65C Offset: 0x7D0765C VA: 0x7D0B65C
	private XDocument get_Document() { }

	// RVA: 0x7D0B6D4 Offset: 0x7D076D4 VA: 0x7D0B6D4
	public void .ctor(XDocument document) { }

	// RVA: 0x7D0B734 Offset: 0x7D07734 VA: 0x7D0B734 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x7D0BCC0 Offset: 0x7D07CC0 VA: 0x7D0BCC0 Slot: 21
	protected override bool get_HasChildNodes() { }

	// RVA: 0x7D0BD24 Offset: 0x7D07D24 VA: 0x7D0BD24 Slot: 22
	public IXmlNode CreateComment(string text) { }

	// RVA: 0x7D0BDC0 Offset: 0x7D07DC0 VA: 0x7D0BDC0 Slot: 23
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x7D0BE5C Offset: 0x7D07E5C VA: 0x7D0BE5C Slot: 24
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x7D0BEF8 Offset: 0x7D07EF8 VA: 0x7D0BEF8 Slot: 25
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x7D0BF94 Offset: 0x7D07F94 VA: 0x7D0BF94 Slot: 26
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x7D0C030 Offset: 0x7D08030 VA: 0x7D0C030 Slot: 27
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x7D0C0D4 Offset: 0x7D080D4 VA: 0x7D0C0D4 Slot: 28
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x7D0C180 Offset: 0x7D08180 VA: 0x7D0C180 Slot: 29
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x7D0C254 Offset: 0x7D08254 VA: 0x7D0C254 Slot: 30
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x7D0C334 Offset: 0x7D08334 VA: 0x7D0C334 Slot: 31
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x7D0C3F4 Offset: 0x7D083F4 VA: 0x7D0C3F4 Slot: 32
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x7D0C4DC Offset: 0x7D084DC VA: 0x7D0C4DC Slot: 33
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x7D0C5AC Offset: 0x7D085AC VA: 0x7D0C5AC Slot: 34
	public IXmlElement get_DocumentElement() { }

	// RVA: 0x7D0C654 Offset: 0x7D08654 VA: 0x7D0C654 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 19692
{
	// Properties
	[Nullable(1)]
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0C7D4 Offset: 0x7D087D4 VA: 0x7D0C7D4
	private XText get_Text() { }

	[NullableContext(1)]
	// RVA: 0x7D0C84C Offset: 0x7D0884C VA: 0x7D0C84C
	public void .ctor(XText text) { }

	// RVA: 0x7D0C87C Offset: 0x7D0887C VA: 0x7D0C87C Slot: 18
	public override string get_Value() { }

	// RVA: 0x7D0C898 Offset: 0x7D08898 VA: 0x7D0C898 Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 19693
{
	// Properties
	[Nullable(1)]
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0CBE4 Offset: 0x7D08BE4 VA: 0x7D0CBE4
	private XComment get_Text() { }

	[NullableContext(1)]
	// RVA: 0x7D0CC5C Offset: 0x7D08C5C VA: 0x7D0CC5C
	public void .ctor(XComment text) { }

	// RVA: 0x7D0CC8C Offset: 0x7D08C8C VA: 0x7D0CC8C Slot: 18
	public override string get_Value() { }

	// RVA: 0x7D0CCA8 Offset: 0x7D08CA8 VA: 0x7D0CCA8 Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 19694
{
	// Properties
	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0CCEC Offset: 0x7D08CEC VA: 0x7D0CCEC
	private XProcessingInstruction get_ProcessingInstruction() { }

	[NullableContext(1)]
	// RVA: 0x7D0C224 Offset: 0x7D08224 VA: 0x7D0C224
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0x7D0CD64 Offset: 0x7D08D64 VA: 0x7D0CD64 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0x7D0CD80 Offset: 0x7D08D80 VA: 0x7D0CD80 Slot: 18
	public override string get_Value() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 19695
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(2)]
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0x7D0CD9C Offset: 0x7D08D9C VA: 0x7D0CD9C
	private XContainer get_Container() { }

	// RVA: 0x7D0B704 Offset: 0x7D07704 VA: 0x7D0B704
	public void .ctor(XContainer container) { }

	// RVA: 0x7D0B8A0 Offset: 0x7D078A0 VA: 0x7D0B8A0 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x7D0BCFC Offset: 0x7D07CFC VA: 0x7D0BCFC Slot: 21
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(2)]
	// RVA: 0x7D0CE14 Offset: 0x7D08E14 VA: 0x7D0CE14 Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0x7D0C8DC Offset: 0x7D088DC VA: 0x7D0C8DC
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0x7D0C6F8 Offset: 0x7D086F8 VA: 0x7D0C6F8 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XObjectWrapper : IXmlNode // TypeDefIndex: 19696
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x7D0B4E0 Offset: 0x7D074E0 VA: 0x7D0B4E0
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x7D0CE58 Offset: 0x7D08E58 VA: 0x7D0CE58 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x7D0CE60 Offset: 0x7D08E60 VA: 0x7D0CE60 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x7D0CE78 Offset: 0x7D08E78 VA: 0x7D0CE78 Slot: 14
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x7D0CE80 Offset: 0x7D08E80 VA: 0x7D0CE80 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x7D0CED8 Offset: 0x7D08ED8 VA: 0x7D0CED8 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x7D0CF30 Offset: 0x7D08F30 VA: 0x7D0CF30 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x7D0CF38 Offset: 0x7D08F38 VA: 0x7D0CF38 Slot: 18
	public virtual string get_Value() { }

	[NullableContext(1)]
	// RVA: 0x7D0CF40 Offset: 0x7D08F40 VA: 0x7D0CF40 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x7D0CF78 Offset: 0x7D08F78 VA: 0x7D0CF78 Slot: 20
	public virtual string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 19697
{
	// Properties
	[Nullable(1)]
	private XAttribute Attribute { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x7D0CF80 Offset: 0x7D08F80 VA: 0x7D0CF80
	private XAttribute get_Attribute() { }

	[NullableContext(1)]
	// RVA: 0x7D0C4AC Offset: 0x7D084AC VA: 0x7D0C4AC
	public void .ctor(XAttribute attribute) { }

	// RVA: 0x7D0CFF8 Offset: 0x7D08FF8 VA: 0x7D0CFF8 Slot: 18
	public override string get_Value() { }

	// RVA: 0x7D0D014 Offset: 0x7D09014 VA: 0x7D0D014 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0x7D0D038 Offset: 0x7D09038 VA: 0x7D0D038 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0x7D0D05C Offset: 0x7D0905C VA: 0x7D0D05C Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 19698
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	[Nullable(2)]
	public override string Value { get; }
	[Nullable(2)]
	public override string LocalName { get; }
	[Nullable(2)]
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x7D0D0A0 Offset: 0x7D090A0 VA: 0x7D0D0A0
	private XElement get_Element() { }

	// RVA: 0x7D0C304 Offset: 0x7D08304 VA: 0x7D0C304
	public void .ctor(XElement element) { }

	// RVA: 0x7D0D118 Offset: 0x7D09118 VA: 0x7D0D118 Slot: 22
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x7D0D1C4 Offset: 0x7D091C4 VA: 0x7D0D1C4 Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0x7D0D74C Offset: 0x7D0974C VA: 0x7D0D74C
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0x7D0DC38 Offset: 0x7D09C38 VA: 0x7D0DC38 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(2)]
	// RVA: 0x7D0DC6C Offset: 0x7D09C6C VA: 0x7D0DC6C Slot: 18
	public override string get_Value() { }

	[NullableContext(2)]
	// RVA: 0x7D0DC88 Offset: 0x7D09C88 VA: 0x7D0DC88 Slot: 14
	public override string get_LocalName() { }

	[NullableContext(2)]
	// RVA: 0x7D0DCAC Offset: 0x7D09CAC VA: 0x7D0DCAC Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0x7D0DBF8 Offset: 0x7D09BF8 VA: 0x7D0DBF8 Slot: 23
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x7D0DCD0 Offset: 0x7D09CD0 VA: 0x7D0DCD0 Slot: 24
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class XmlNodeConverter : JsonConverter // TypeDefIndex: 19699
{
	// Fields
	internal static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	[CompilerGenerated]
	[Nullable(2)]
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Properties
	[Nullable(2)]
	public string DeserializeRootElementName { get; set; }
	public bool WriteArrayAttribute { get; set; }
	public bool OmitRootObject { get; set; }
	public bool EncodeSpecialCharacters { get; set; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7D0DCEC Offset: 0x7D09CEC VA: 0x7D0DCEC
	public string get_DeserializeRootElementName() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7D0DCF4 Offset: 0x7D09CF4 VA: 0x7D0DCF4
	public void set_DeserializeRootElementName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7D0DCFC Offset: 0x7D09CFC VA: 0x7D0DCFC
	public bool get_WriteArrayAttribute() { }

	[CompilerGenerated]
	// RVA: 0x7D0DD04 Offset: 0x7D09D04 VA: 0x7D0DD04
	public void set_WriteArrayAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D0DD10 Offset: 0x7D09D10 VA: 0x7D0DD10
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	// RVA: 0x7D0DD18 Offset: 0x7D09D18 VA: 0x7D0DD18
	public void set_OmitRootObject(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D0DD24 Offset: 0x7D09D24 VA: 0x7D0DD24
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	// RVA: 0x7D0DD2C Offset: 0x7D09D2C VA: 0x7D0DD2C
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0x7D0DD38 Offset: 0x7D09D38 VA: 0x7D0DD38 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x7D0DE80 Offset: 0x7D09E80 VA: 0x7D0DE80
	private IXmlNode WrapXml(object value) { }

	// RVA: 0x7D0DF98 Offset: 0x7D09F98 VA: 0x7D0DF98
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x7D0FD8C Offset: 0x7D0BD8C VA: 0x7D0FD8C
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x7D100A8 Offset: 0x7D0C0A8 VA: 0x7D100A8
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x7D104E8 Offset: 0x7D0C4E8 VA: 0x7D104E8
	private bool IsArray(IXmlNode node) { }

	// RVA: 0x7D10880 Offset: 0x7D0C880 VA: 0x7D10880
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x7D11230 Offset: 0x7D0D230 VA: 0x7D11230
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0x7D113A4 Offset: 0x7D0D3A4 VA: 0x7D113A4
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0x7D0E600 Offset: 0x7D0A600 VA: 0x7D0E600
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x7D1147C Offset: 0x7D0D47C VA: 0x7D1147C
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0x7D11A40 Offset: 0x7D0DA40 VA: 0x7D11A40 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x7D12D78 Offset: 0x7D0ED78 VA: 0x7D12D78
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0x7D122A0 Offset: 0x7D0E2A0 VA: 0x7D122A0
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0x7D14FD4 Offset: 0x7D10FD4 VA: 0x7D14FD4
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0x7D14C58 Offset: 0x7D10C58 VA: 0x7D14C58
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0x7D13324 Offset: 0x7D0F324 VA: 0x7D13324
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0x7D1425C Offset: 0x7D1025C VA: 0x7D1425C
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0x7D157DC Offset: 0x7D117DC VA: 0x7D157DC
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0x7D145FC Offset: 0x7D105FC VA: 0x7D145FC
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0x7D14644 Offset: 0x7D10644 VA: 0x7D14644
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0x7D139B0 Offset: 0x7D0F9B0 VA: 0x7D139B0
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0x7D13E64 Offset: 0x7D0FE64 VA: 0x7D13E64
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0x7D15620 Offset: 0x7D11620 VA: 0x7D15620
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0x7D125E8 Offset: 0x7D0E5E8 VA: 0x7D125E8
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0x7D15B1C Offset: 0x7D11B1C VA: 0x7D15B1C
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0x7D11728 Offset: 0x7D0D728 VA: 0x7D11728
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0x7D15C14 Offset: 0x7D11C14 VA: 0x7D15C14 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x7D15CBC Offset: 0x7D11CBC VA: 0x7D15CBC
	private bool IsXObject(Type valueType) { }

	// RVA: 0x7D15D50 Offset: 0x7D11D50 VA: 0x7D15D50
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0x7D15DE4 Offset: 0x7D11DE4 VA: 0x7D15DE4
	public void .ctor() { }

	// RVA: 0x7D15DEC Offset: 0x7D11DEC VA: 0x7D15DEC
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectId // TypeDefIndex: 19700
{
	// Fields
	[CompilerGenerated]
	private readonly byte[] <Value>k__BackingField; // 0x10

	// Properties
	public byte[] Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D15E84 Offset: 0x7D11E84 VA: 0x7D15E84
	public byte[] get_Value() { }

	// RVA: 0x7D15E8C Offset: 0x7D11E8C VA: 0x7D15E8C
	public void .ctor(byte[] value) { }
}

// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken // TypeDefIndex: 19701
{
	// Fields
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; // 0x10

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGenerated]
	// RVA: 0x7D15F70 Offset: 0x7D11F70 VA: 0x7D15F70
	public void set_Parent(BsonToken value) { }

	// RVA: 0x7D15F78 Offset: 0x7D11F78 VA: 0x7D15F78
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject : BsonToken // TypeDefIndex: 19702
{
	// Fields
	private readonly List<BsonProperty> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x7D15F80 Offset: 0x7D11F80 VA: 0x7D15F80
	public void Add(string name, BsonToken token) { }

	// RVA: 0x7D16128 Offset: 0x7D12128 VA: 0x7D16128 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray : BsonToken // TypeDefIndex: 19703
{
	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x7D16130 Offset: 0x7D12130 VA: 0x7D16130
	public void Add(BsonToken token) { }

	// RVA: 0x7D161EC Offset: 0x7D121EC VA: 0x7D161EC Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue : BsonToken // TypeDefIndex: 19704
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x7D161F4 Offset: 0x7D121F4 VA: 0x7D161F4
	public void .ctor(object value, BsonType type) { }

	// RVA: 0x7D16230 Offset: 0x7D12230 VA: 0x7D16230 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString : BsonValue // TypeDefIndex: 19705
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0x7D160E4 Offset: 0x7D120E4 VA: 0x7D160E4
	public void .ctor(object value, bool includeLength) { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex : BsonToken // TypeDefIndex: 19706
{
	// Fields
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; // 0x20

	// Properties
	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D16238 Offset: 0x7D12238 VA: 0x7D16238
	public void set_Pattern(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x7D16240 Offset: 0x7D12240 VA: 0x7D16240
	public void set_Options(BsonString value) { }

	// RVA: 0x7D16248 Offset: 0x7D12248 VA: 0x7D16248
	public void .ctor(string pattern, string options) { }

	// RVA: 0x7D1631C Offset: 0x7D1231C VA: 0x7D1631C Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty // TypeDefIndex: 19707
{
	// Fields
	[CompilerGenerated]
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private BsonToken <Value>k__BackingField; // 0x18

	// Properties
	public BsonString Name { set; }
	public BsonToken Value { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D16324 Offset: 0x7D12324 VA: 0x7D16324
	public void set_Name(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x7D1632C Offset: 0x7D1232C VA: 0x7D1632C
	public void set_Value(BsonToken value) { }

	// RVA: 0x7D160DC Offset: 0x7D120DC VA: 0x7D160DC
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal enum BsonType // TypeDefIndex: 19708
{
	// Fields
	public sbyte value__; // 0x0
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = -1;
	public const BsonType MaxKey = 127;
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter // TypeDefIndex: 19709
{
	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0x7D16334 Offset: 0x7D12334 VA: 0x7D16334
	private void AddValue(object value, BsonType type) { }

	// RVA: 0x7D163B4 Offset: 0x7D123B4 VA: 0x7D163B4
	internal void AddToken(BsonToken token) { }

	// RVA: 0x7D1659C Offset: 0x7D1259C VA: 0x7D1659C
	public void WriteObjectId(byte[] value) { }

	// RVA: 0x7D16668 Offset: 0x7D12668 VA: 0x7D16668
	public void WriteRegex(string pattern, string options) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 19710
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 19711
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 19712
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 19713
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 19714
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 19715
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 19716
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 19717
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 19718
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 19719
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 19720
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 0698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139 /*Metadata offset 0xEFD550*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 19AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994 /*Metadata offset 0xEFD580*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570 /*Metadata offset 0xEFD590*/; // 0x36
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 33350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE /*Metadata offset 0xEFD5C0*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 38809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63 /*Metadata offset 0xEFD5D8*/; // 0x72
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6 /*Metadata offset 0xEFD608*/; // 0x9A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 4EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF /*Metadata offset 0xEFD628*/; // 0xB6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0xEFD640*/; // 0xC6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 5ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2 /*Metadata offset 0xEFD678*/; // 0xFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 5DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9 /*Metadata offset 0xEFD698*/; // 0x116
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04 /*Metadata offset 0xEFD6B8*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62 /*Metadata offset 0xEFD6D0*/; // 0x13E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1 /*Metadata offset 0xEFD6F8*/; // 0x162
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 772907508FD7AA0ED404C8FC80B6B772E26D67FA3C3662C22D62B871067C28DA /*Metadata offset 0xEFD728*/; // 0x18A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5 /*Metadata offset 0xEFD730*/; // 0x190
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89 /*Metadata offset 0xEFD760*/; // 0x1B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122 /*Metadata offset 0xEFD778*/; // 0x1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326 /*Metadata offset 0xEFD790*/; // 0x1DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A /*Metadata offset 0xEFD7A8*/; // 0x1F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7 /*Metadata offset 0xEFD7D8*/; // 0x218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0xEFD808*/; // 0x240
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A /*Metadata offset 0xEFD840*/; // 0x274
}

