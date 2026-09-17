// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28923
{}

// Namespace: System.Configuration.Provider
public abstract class ProviderBase // TypeDefIndex: 28924
{
	// Methods

	// RVA: 0x7FCB8E8 Offset: 0x7FC78E8 VA: 0x7FCB8E8 Slot: 4
	public virtual void Initialize(string name, NameValueCollection config) { }
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 28925
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x7FCB920 Offset: 0x7FC7920 VA: 0x7FCB920 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x7FCB958 Offset: 0x7FC7958 VA: 0x7FCB958 Slot: 5
	protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x7FCB990 Offset: 0x7FC7990 VA: 0x7FCB990 Slot: 6
	protected internal virtual void InitializeDefault() { }

	// RVA: 0x7FCB9C8 Offset: 0x7FC79C8 VA: 0x7FCB9C8 Slot: 7
	protected internal virtual bool IsModified() { }

	// RVA: 0x7FCBA00 Offset: 0x7FC7A00 VA: 0x7FCBA00 Slot: 8
	protected virtual void PostDeserialize() { }

	// RVA: 0x7FCBA38 Offset: 0x7FC7A38 VA: 0x7FCBA38 Slot: 9
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x7FCBA70 Offset: 0x7FC7A70 VA: 0x7FCBA70 Slot: 10
	protected internal virtual void ResetModified() { }

	// RVA: 0x7FCBAA8 Offset: 0x7FC7AA8 VA: 0x7FCBAA8 Slot: 11
	protected internal virtual bool SerializeToXmlElement(XmlWriter writer, string elementName) { }

	// RVA: 0x7FCBAE0 Offset: 0x7FC7AE0 VA: 0x7FCBAE0 Slot: 12
	protected internal virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public sealed class Configuration // TypeDefIndex: 28926
{}

// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 28927
{
	// Methods

	// RVA: 0x7FCBB18 Offset: 0x7FC7B18 VA: 0x7FCBB18 Slot: 13
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x7FCBB50 Offset: 0x7FC7B50 VA: 0x7FCBB50 Slot: 7
	protected internal override bool IsModified() { }

	// RVA: 0x7FCBB88 Offset: 0x7FC7B88 VA: 0x7FCBB88 Slot: 10
	protected internal override void ResetModified() { }

	// RVA: 0x7FCBBC0 Offset: 0x7FC7BC0 VA: 0x7FCBBC0 Slot: 14
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public enum ConfigurationSaveMode // TypeDefIndex: 28928
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class ConfigurationPropertyCollection // TypeDefIndex: 28929
{}

// Namespace: System.Configuration
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 28930
{
	// Properties
	public virtual ConfigurationElementCollectionType CollectionType { get; }
	protected virtual string ElementName { get; }
	protected virtual bool ThrowOnDuplicate { get; }

	// Methods

	// RVA: 0x7FCBBF8 Offset: 0x7FC7BF8 VA: 0x7FCBBF8 Slot: 13
	public virtual ConfigurationElementCollectionType get_CollectionType() { }

	// RVA: 0x7FCBC30 Offset: 0x7FC7C30 VA: 0x7FCBC30 Slot: 14
	protected virtual string get_ElementName() { }

	// RVA: 0x7FCBC68 Offset: 0x7FC7C68 VA: 0x7FCBC68 Slot: 15
	protected virtual bool get_ThrowOnDuplicate() { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract ConfigurationElement CreateNewElement();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract object GetElementKey(ConfigurationElement element);
}

// Namespace: System.Configuration
public enum ConfigurationElementCollectionType // TypeDefIndex: 28931
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationElementCollectionType AddRemoveClearMap = 1;
	public const ConfigurationElementCollectionType AddRemoveClearMapAlternate = 3;
	public const ConfigurationElementCollectionType BasicMap = 0;
	public const ConfigurationElementCollectionType BasicMapAlternate = 2;
}

// Namespace: System.Configuration
[Usage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 28932
{
	// Properties
	public string AddItemName { set; }
	public string ClearItemsName { set; }
	public ConfigurationElementCollectionType CollectionType { set; }
	public string RemoveItemName { set; }

	// Methods

	// RVA: 0x7FCBCA0 Offset: 0x7FC7CA0 VA: 0x7FCBCA0
	public void .ctor(Type itemType) { }

	// RVA: 0x7FCBCA4 Offset: 0x7FC7CA4 VA: 0x7FCBCA4
	public void set_AddItemName(string value) { }

	// RVA: 0x7FCBCA8 Offset: 0x7FC7CA8 VA: 0x7FCBCA8
	public void set_ClearItemsName(string value) { }

	// RVA: 0x7FCBCAC Offset: 0x7FC7CAC VA: 0x7FCBCAC
	public void set_CollectionType(ConfigurationElementCollectionType value) { }

	// RVA: 0x7FCBCB0 Offset: 0x7FC7CB0 VA: 0x7FCBCB0
	public void set_RemoveItemName(string value) { }
}

// Namespace: System.Configuration
public class ConfigurationSectionGroup // TypeDefIndex: 28933
{}

// Namespace: System.Configuration.Provider
[DefaultMember("Item")]
public class ProviderCollection // TypeDefIndex: 28934
{
	// Methods

	// RVA: 0x7FCBCB4 Offset: 0x7FC7CB4 VA: 0x7FCBCB4 Slot: 4
	public virtual void Add(ProviderBase provider) { }
}

// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 28935
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x7FCBCEC Offset: 0x7FC7CEC VA: 0x7FCBCEC
	public void .ctor() { }

	// RVA: 0x7FCBD24 Offset: 0x7FC7D24 VA: 0x7FCBD24 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x7FCBD5C Offset: 0x7FC7D5C VA: 0x7FCBD5C Slot: 13
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x7FCBD94 Offset: 0x7FC7D94 VA: 0x7FCBD94 Slot: 7
	protected internal override bool IsModified() { }

	// RVA: 0x7FCBDCC Offset: 0x7FC7DCC VA: 0x7FCBDCC Slot: 9
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x7FCBE04 Offset: 0x7FC7E04 VA: 0x7FCBE04 Slot: 10
	protected internal override void ResetModified() { }

	// RVA: 0x7FCBE3C Offset: 0x7FC7E3C VA: 0x7FCBE3C Slot: 14
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration.Internal
public interface IConfigErrorInfo // TypeDefIndex: 28936
{
	// Properties
	public abstract string Filename { get; }
	public abstract int LineNumber { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Filename();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 28937
{
	// Methods

	// RVA: 0x7FCBE74 Offset: 0x7FC7E74 VA: 0x7FCBE74
	public static void ThrowNotSupportedException() { }
}

