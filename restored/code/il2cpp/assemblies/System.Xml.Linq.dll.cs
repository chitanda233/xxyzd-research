// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27967
{}

// Namespace: 
internal static class SR // TypeDefIndex: 27968
{
	// Methods

	// RVA: 0x81A39CC Offset: 0x819F9CC VA: 0x81A39CC
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x81A3A3C Offset: 0x819FA3C VA: 0x81A3A3C
	internal static string Format(string resourceFormat, object p1, object p2) { }
}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation // TypeDefIndex: 27969
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x81A3AB4 Offset: 0x819FAB4 VA: 0x81A3AB4
	public void .ctor(string baseUri) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation // TypeDefIndex: 27970
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x81A3AE4 Offset: 0x819FAE4 VA: 0x81A3AE4
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 27971
{
	// Methods

	// RVA: 0x81A3B10 Offset: 0x819FB10 VA: 0x81A3B10
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
public class XAttribute : XObject // TypeDefIndex: 27972
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x81A3B3C Offset: 0x819FB3C VA: 0x81A3B3C
	public void .ctor(XName name, object value) { }

	// RVA: 0x81A4274 Offset: 0x81A0274 VA: 0x81A4274
	public void .ctor(XAttribute other) { }

	// RVA: 0x81A4300 Offset: 0x81A0300 VA: 0x81A4300
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x81A43B8 Offset: 0x81A03B8 VA: 0x81A43B8
	public XName get_Name() { }

	// RVA: 0x81A43C0 Offset: 0x81A03C0 VA: 0x81A43C0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A43C8 Offset: 0x81A03C8 VA: 0x81A43C8
	public string get_Value() { }

	// RVA: 0x81A43D0 Offset: 0x81A03D0 VA: 0x81A43D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x81A47AC Offset: 0x81A07AC VA: 0x81A47AC
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x81A4044 Offset: 0x81A0044 VA: 0x81A4044
	private static void ValidateAttribute(XName name, string value) { }
}

// Namespace: System.Xml.Linq
public class XCData : XText // TypeDefIndex: 27973
{
	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x81A4AF8 Offset: 0x81A0AF8 VA: 0x81A4AF8
	public void .ctor(string value) { }

	// RVA: 0x81A4B78 Offset: 0x81A0B78 VA: 0x81A4B78
	public void .ctor(XCData other) { }

	// RVA: 0x81A4BF8 Offset: 0x81A0BF8 VA: 0x81A4BF8 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A4C00 Offset: 0x81A0C00 VA: 0x81A4C00 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81A4C70 Offset: 0x81A0C70 VA: 0x81A4C70 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
public class XComment : XNode // TypeDefIndex: 27974
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x81A4CC8 Offset: 0x81A0CC8 VA: 0x81A4CC8
	public void .ctor(string value) { }

	// RVA: 0x81A4D4C Offset: 0x81A0D4C VA: 0x81A4D4C
	public void .ctor(XComment other) { }

	// RVA: 0x81A4DC8 Offset: 0x81A0DC8 VA: 0x81A4DC8 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A4DD0 Offset: 0x81A0DD0 VA: 0x81A4DD0
	public string get_Value() { }

	// RVA: 0x81A4DD8 Offset: 0x81A0DD8 VA: 0x81A4DD8 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81A4E48 Offset: 0x81A0E48 VA: 0x81A4E48 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
private sealed class XContainer.ContentReader // TypeDefIndex: 27975
{
	// Fields
	private readonly NamespaceCache _eCache; // 0x10
	private readonly NamespaceCache _aCache; // 0x20
	private readonly IXmlLineInfo _lineInfo; // 0x30
	private XContainer _currentContainer; // 0x38
	private string _baseUri; // 0x40

	// Methods

	// RVA: 0x81A68E4 Offset: 0x81A28E4 VA: 0x81A68E4
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x81A7000 Offset: 0x81A3000 VA: 0x81A7000
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x81A6914 Offset: 0x81A2914 VA: 0x81A6914
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x81A70C8 Offset: 0x81A30C8 VA: 0x81A70C8
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 27976
{
	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__2; // 0x30

	// Properties
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x81A6060 Offset: 0x81A2060 VA: 0x81A6060
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x81A85D4 Offset: 0x81A45D4 VA: 0x81A85D4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x81A85D8 Offset: 0x81A45D8 VA: 0x81A85D8 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x81A8698 Offset: 0x81A4698 VA: 0x81A8698 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x81A86A0 Offset: 0x81A46A0 VA: 0x81A86A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x81A86D8 Offset: 0x81A46D8 VA: 0x81A86D8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x81A86E0 Offset: 0x81A46E0 VA: 0x81A86E0 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x81A8784 Offset: 0x81A4784 VA: 0x81A8784 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
public abstract class XContainer : XNode // TypeDefIndex: 27977
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x81A4EA0 Offset: 0x81A0EA0 VA: 0x81A4EA0
	internal void .ctor() { }

	// RVA: 0x81A4EA8 Offset: 0x81A0EA8 VA: 0x81A4EA8
	internal void .ctor(XContainer other) { }

	// RVA: 0x81A50DC Offset: 0x81A10DC VA: 0x81A50DC
	public XNode get_LastNode() { }

	// RVA: 0x81A5230 Offset: 0x81A1230 VA: 0x81A5230
	public void Add(object content) { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x81A5FE4 Offset: 0x81A1FE4 VA: 0x81A5FE4
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x81A6094 Offset: 0x81A2094 VA: 0x81A6094 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x81A6098 Offset: 0x81A2098 VA: 0x81A6098 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x81A5790 Offset: 0x81A1790 VA: 0x81A5790
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x81A5C5C Offset: 0x81A1C5C VA: 0x81A5C5C
	internal void AddNode(XNode n) { }

	// RVA: 0x81A609C Offset: 0x81A209C VA: 0x81A609C
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x81A5CDC Offset: 0x81A1CDC VA: 0x81A5CDC
	internal void AddString(string s) { }

	// RVA: 0x81A611C Offset: 0x81A211C VA: 0x81A611C
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x81A638C Offset: 0x81A238C VA: 0x81A638C
	internal void AppendNode(XNode n) { }

	// RVA: 0x81A4FEC Offset: 0x81A0FEC VA: 0x81A4FEC
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x81A66FC Offset: 0x81A26FC VA: 0x81A66FC Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x81A62A4 Offset: 0x81A22A4 VA: 0x81A62A4
	internal void ConvertTextToNode() { }

	// RVA: 0x81A3C1C Offset: 0x819FC1C VA: 0x81A3C1C
	internal static string GetStringValue(object value) { }

	// RVA: 0x81A67E4 Offset: 0x81A27E4 VA: 0x81A67E4
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x81A6ED8 Offset: 0x81A2ED8 VA: 0x81A6ED8
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x81A7D78 Offset: 0x81A3D78 VA: 0x81A7D78
	internal void RemoveNode(XNode n) { }

	// RVA: 0x81A7F58 Offset: 0x81A3F58 VA: 0x81A7F58 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x81A7F5C Offset: 0x81A3F5C VA: 0x81A7F5C Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x81A7F60 Offset: 0x81A3F60 VA: 0x81A7F60
	internal void WriteContentTo(XmlWriter writer) { }
}

// Namespace: System.Xml.Linq
public class XDeclaration // TypeDefIndex: 27978
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x81A8788 Offset: 0x81A4788 VA: 0x81A8788
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x81A87E8 Offset: 0x81A47E8 VA: 0x81A87E8
	public void .ctor(XDeclaration other) { }

	// RVA: 0x81A8884 Offset: 0x81A4884 VA: 0x81A8884
	public string get_Encoding() { }

	// RVA: 0x81A888C Offset: 0x81A488C VA: 0x81A888C
	public string get_Standalone() { }

	// RVA: 0x81A8894 Offset: 0x81A4894 VA: 0x81A8894
	public string get_Version() { }

	// RVA: 0x81A889C Offset: 0x81A489C VA: 0x81A889C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Linq
public class XDocument : XContainer // TypeDefIndex: 27979
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x81A8B0C Offset: 0x81A4B0C VA: 0x81A8B0C
	public void .ctor() { }

	// RVA: 0x81A8B14 Offset: 0x81A4B14 VA: 0x81A8B14
	public void .ctor(XDocument other) { }

	// RVA: 0x81A8BA0 Offset: 0x81A4BA0 VA: 0x81A8BA0
	public XDeclaration get_Declaration() { }

	// RVA: 0x81A8BA8 Offset: 0x81A4BA8 VA: 0x81A8BA8
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x81A8BB0 Offset: 0x81A4BB0 VA: 0x81A8BB0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A8BB8 Offset: 0x81A4BB8 VA: 0x81A8BB8
	public XElement get_Root() { }

	// RVA: 0x81A8C00 Offset: 0x81A4C00 VA: 0x81A8C00 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81A8D2C Offset: 0x81A4D2C VA: 0x81A8D2C Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x81A8D78 Offset: 0x81A4D78 VA: 0x81A8D78 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x81A8DC4 Offset: 0x81A4DC4 VA: 0x81A8DC4 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4783C24 Offset: 0x477FC24 VA: 0x4783C24
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x81A8E1C Offset: 0x81A4E1C VA: 0x81A8E1C
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x81A8EB0 Offset: 0x81A4EB0 VA: 0x81A8EB0 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x81A9054 Offset: 0x81A5054 VA: 0x81A9054
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x81A9178 Offset: 0x81A5178 VA: 0x81A9178 Slot: 14
	internal override void ValidateString(string s) { }
}

// Namespace: System.Xml.Linq
public class XDocumentType : XNode // TypeDefIndex: 27980
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x81A82D8 Offset: 0x81A42D8 VA: 0x81A82D8
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x81A91D8 Offset: 0x81A51D8 VA: 0x81A91D8
	public void .ctor(XDocumentType other) { }

	// RVA: 0x81A9284 Offset: 0x81A5284 VA: 0x81A9284
	public string get_InternalSubset() { }

	// RVA: 0x81A928C Offset: 0x81A528C VA: 0x81A928C
	public string get_Name() { }

	// RVA: 0x81A9294 Offset: 0x81A5294 VA: 0x81A9294 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A929C Offset: 0x81A529C VA: 0x81A929C
	public string get_PublicId() { }

	// RVA: 0x81A92A4 Offset: 0x81A52A4 VA: 0x81A92A4
	public string get_SystemId() { }

	// RVA: 0x81A92AC Offset: 0x81A52AC VA: 0x81A92AC Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81A931C Offset: 0x81A531C VA: 0x81A931C Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XElement.<GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 27981
{
	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XName name; // 0x30
	public XName <>3__name; // 0x38
	private XAttribute <a>5__2; // 0x40

	// Properties
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x81A9E6C Offset: 0x81A5E6C VA: 0x81A9E6C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x81AA77C Offset: 0x81A677C VA: 0x81AA77C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x81AA780 Offset: 0x81A6780 VA: 0x81AA780 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x81AA858 Offset: 0x81A6858 VA: 0x81AA858 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x81AA860 Offset: 0x81A6860 VA: 0x81AA860 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x81AA898 Offset: 0x81A6898 VA: 0x81AA898 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x81AA8A0 Offset: 0x81A68A0 VA: 0x81AA8A0 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x81AA954 Offset: 0x81A6954 VA: 0x81AA954 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 27982
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x81A8154 Offset: 0x81A4154 VA: 0x81A8154
	public void .ctor(XName name) { }

	// RVA: 0x81A9374 Offset: 0x81A5374 VA: 0x81A9374
	public void .ctor(XElement other) { }

	// RVA: 0x81A5F5C Offset: 0x81A1F5C VA: 0x81A5F5C
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x81A9420 Offset: 0x81A5420 VA: 0x81A9420
	public bool get_HasAttributes() { }

	// RVA: 0x81A9430 Offset: 0x81A5430 VA: 0x81A9430
	public bool get_IsEmpty() { }

	// RVA: 0x81A9440 Offset: 0x81A5440 VA: 0x81A9440
	public XName get_Name() { }

	// RVA: 0x81A9448 Offset: 0x81A5448 VA: 0x81A9448 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81A9450 Offset: 0x81A5450 VA: 0x81A9450
	public string get_Value() { }

	// RVA: 0x81A94E4 Offset: 0x81A54E4 VA: 0x81A94E4
	public XAttribute Attribute(XName name) { }

	// RVA: 0x81A9520 Offset: 0x81A5520 VA: 0x81A9520
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x81A48E4 Offset: 0x81A08E4 VA: 0x81A48E4
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x81A96C0 Offset: 0x81A56C0 VA: 0x81A96C0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81A9918 Offset: 0x81A5918 VA: 0x81A9918 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x81A9920 Offset: 0x81A5920 VA: 0x81A9920 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x81A9B24 Offset: 0x81A5B24 VA: 0x81A9B24 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x81A9B30 Offset: 0x81A5B30 VA: 0x81A9B30 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x81A9D2C Offset: 0x81A5D2C VA: 0x81A9D2C Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x81A9C18 Offset: 0x81A5C18 VA: 0x81A9C18
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x81A81D0 Offset: 0x81A41D0 VA: 0x81A81D0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x81A9E14 Offset: 0x81A5E14 VA: 0x81A9E14 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x81A9528 Offset: 0x81A5528 VA: 0x81A9528
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x81A95CC Offset: 0x81A55CC VA: 0x81A95CC
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x81A9AAC Offset: 0x81A5AAC VA: 0x81A9AAC
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x81A9EA0 Offset: 0x81A5EA0 VA: 0x81A9EA0
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x81A8484 Offset: 0x81A4484 VA: 0x81A8484
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x81AA648 Offset: 0x81A6648 VA: 0x81AA648 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}

// Namespace: 
public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 27983
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6339D78 Offset: 0x6335D78 VA: 0x6339D78
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|
	|-RVA: 0x6339E94 Offset: 0x6335E94 VA: 0x6339E94
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6339E80 Offset: 0x6335E80 VA: 0x6339E80
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	|
	|-RVA: 0x6339F9C Offset: 0x6335F9C VA: 0x6339F9C
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 27984
{
	// Fields
	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0
}

// Namespace: 
private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 27985
{
	// Fields
	private int[] _buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] _entries; // 0x0
	private int _numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> _extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0C63C Offset: 0x5B0863C VA: 0x5B0C63C
	|-XHashtable.XHashtableState<object>..ctor
	|
	|-RVA: 0x5B0CE28 Offset: 0x5B08E28 VA: 0x5B0CE28
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0C6FC Offset: 0x5B086FC VA: 0x5B0C6FC
	|-XHashtable.XHashtableState<object>.Resize
	|
	|-RVA: 0x5B0CEE8 Offset: 0x5B08EE8 VA: 0x5B0CEE8
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0C94C Offset: 0x5B0894C VA: 0x5B0C94C
	|-XHashtable.XHashtableState<object>.TryGetValue
	|
	|-RVA: 0x5B0D308 Offset: 0x5B09308 VA: 0x5B0D308
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0CA0C Offset: 0x5B08A0C VA: 0x5B0CA0C
	|-XHashtable.XHashtableState<object>.TryAdd
	|
	|-RVA: 0x5B0D498 Offset: 0x5B09498 VA: 0x5B0D498
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0CBD8 Offset: 0x5B08BD8 VA: 0x5B0CBD8
	|-XHashtable.XHashtableState<object>.FindEntry
	|
	|-RVA: 0x5B0D864 Offset: 0x5B09864 VA: 0x5B0D864
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0CDAC Offset: 0x5B08DAC VA: 0x5B0CDAC
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	|
	|-RVA: 0x5B0DC24 Offset: 0x5B09C24 VA: 0x5B0DC24
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.ComputeHashCode
	*/
}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<TValue> // TypeDefIndex: 27986
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0DCA0 Offset: 0x5B09CA0 VA: 0x5B0DCA0
	|-XHashtable<object>..ctor
	|
	|-RVA: 0x5B0DE94 Offset: 0x5B09E94 VA: 0x5B0DE94
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0DD18 Offset: 0x5B09D18 VA: 0x5B0DD18
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0x5B0DF10 Offset: 0x5B09F10 VA: 0x5B0DF10
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B0DD3C Offset: 0x5B09D3C VA: 0x5B0DD3C
	|-XHashtable<object>.Add
	|
	|-RVA: 0x5B0DF38 Offset: 0x5B09F38 VA: 0x5B0DF38
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: System.Xml.Linq
internal struct NamespaceCache // TypeDefIndex: 27987
{
	// Fields
	private XNamespace _ns; // 0x0
	private string _namespaceName; // 0x8

	// Methods

	// RVA: 0x81A80A8 Offset: 0x81A40A8 VA: 0x81A80A8
	public XNamespace Get(string namespaceName) { }
}

// Namespace: System.Xml.Linq
internal struct ElementWriter // TypeDefIndex: 27988
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x81A9758 Offset: 0x81A5758 VA: 0x81A9758
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x81A9778 Offset: 0x81A5778 VA: 0x81A9778
	public void WriteElement(XElement e) { }

	// RVA: 0x81AAC38 Offset: 0x81A6C38 VA: 0x81AAC38
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x81AA958 Offset: 0x81A6958 VA: 0x81AA958
	private void PushAncestors(XElement e) { }

	// RVA: 0x81AAF18 Offset: 0x81A6F18 VA: 0x81AAF18
	private void PushElement(XElement e) { }

	// RVA: 0x81AABE0 Offset: 0x81A6BE0 VA: 0x81AABE0
	private void WriteEndElement() { }

	// RVA: 0x81AAC0C Offset: 0x81A6C0C VA: 0x81AAC0C
	private void WriteFullEndElement() { }

	// RVA: 0x81AAA80 Offset: 0x81A6A80 VA: 0x81AAA80
	private void WriteStartElement(XElement e) { }
}

// Namespace: 
private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 27989
{
	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x81AB184 Offset: 0x81A7184 VA: 0x81AB184
	public void .ctor() { }
}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver // TypeDefIndex: 27990
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x81AAFEC Offset: 0x81A6FEC VA: 0x81AAFEC
	public void PushScope() { }

	// RVA: 0x81AB0E0 Offset: 0x81A70E0 VA: 0x81AB0E0
	public void PopScope() { }

	// RVA: 0x81AAFFC Offset: 0x81A6FFC VA: 0x81AAFFC
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x81AAE28 Offset: 0x81A6E28 VA: 0x81AAE28
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x81AAD34 Offset: 0x81A6D34 VA: 0x81AAD34
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}

// Namespace: System.Xml.Linq
public enum XObjectChange // TypeDefIndex: 27991
{
	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;
}

// Namespace: System.Xml.Linq
[Flags]
public enum LoadOptions // TypeDefIndex: 27992
{
	// Fields
	public int value__; // 0x0
	public const LoadOptions None = 0;
	public const LoadOptions PreserveWhitespace = 1;
	public const LoadOptions SetBaseUri = 2;
	public const LoadOptions SetLineInfo = 4;
}

// Namespace: System.Xml.Linq
[Flags]
public enum SaveOptions // TypeDefIndex: 27993
{
	// Fields
	public int value__; // 0x0
	public const SaveOptions None = 0;
	public const SaveOptions DisableFormatting = 1;
	public const SaveOptions OmitDuplicateNamespaces = 2;
}

// Namespace: System.Xml.Linq
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 27994
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x81AB18C Offset: 0x81A718C VA: 0x81AB18C
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x81AB25C Offset: 0x81A725C VA: 0x81AB25C
	public string get_LocalName() { }

	// RVA: 0x81AB264 Offset: 0x81A7264 VA: 0x81AB264
	public XNamespace get_Namespace() { }

	// RVA: 0x81A439C Offset: 0x81A039C VA: 0x81A439C
	public string get_NamespaceName() { }

	// RVA: 0x81AB26C Offset: 0x81A726C VA: 0x81AB26C Slot: 3
	public override string ToString() { }

	// RVA: 0x81AB2FC Offset: 0x81A72FC VA: 0x81AB2FC
	public static XName Get(string expandedName) { }

	// RVA: 0x81AB88C Offset: 0x81A788C VA: 0x81AB88C
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x81AB8B0 Offset: 0x81A78B0 VA: 0x81AB8B0
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x81AB8BC Offset: 0x81A78BC VA: 0x81AB8BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x81AB8C8 Offset: 0x81A78C8 VA: 0x81AB8C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81A3C10 Offset: 0x819FC10 VA: 0x81A3C10
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x81AB8D0 Offset: 0x81A78D0 VA: 0x81AB8D0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x81AB8DC Offset: 0x81A78DC VA: 0x81AB8DC Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x81AB914 Offset: 0x81A7914 VA: 0x81AB914
	internal void .ctor() { }
}

// Namespace: System.Xml.Linq
public sealed class XNamespace // TypeDefIndex: 27995
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x81AB94C Offset: 0x81A794C VA: 0x81AB94C
	internal void .ctor(string namespaceName) { }

	// RVA: 0x81ABA58 Offset: 0x81A7A58 VA: 0x81ABA58
	public string get_NamespaceName() { }

	// RVA: 0x81A80F4 Offset: 0x81A40F4 VA: 0x81A80F4
	public XName GetName(string localName) { }

	// RVA: 0x81ABA60 Offset: 0x81A7A60 VA: 0x81ABA60 Slot: 3
	public override string ToString() { }

	// RVA: 0x81AB824 Offset: 0x81A7824 VA: 0x81AB824
	public static XNamespace get_None() { }

	// RVA: 0x81ABB48 Offset: 0x81A7B48 VA: 0x81ABB48
	public static XNamespace get_Xml() { }

	// RVA: 0x81ABBA8 Offset: 0x81A7BA8 VA: 0x81ABBA8
	public static XNamespace get_Xmlns() { }

	// RVA: 0x81AA38C Offset: 0x81A638C VA: 0x81AA38C
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x81ABC08 Offset: 0x81A7C08 VA: 0x81ABC08
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x81ABC1C Offset: 0x81A7C1C VA: 0x81ABC1C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x81ABC28 Offset: 0x81A7C28 VA: 0x81ABC28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81A95C0 Offset: 0x81A55C0 VA: 0x81A95C0
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x81ABC30 Offset: 0x81A7C30 VA: 0x81ABC30
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x81AB71C Offset: 0x81A771C VA: 0x81AB71C
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x81AB444 Offset: 0x81A7444 VA: 0x81AB444
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x81ABC3C Offset: 0x81A7C3C VA: 0x81ABC3C
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x81ABC54 Offset: 0x81A7C54 VA: 0x81ABC54
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x81ABA68 Offset: 0x81A7A68 VA: 0x81ABA68
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}

// Namespace: System.Xml.Linq
public abstract class XNode : XObject // TypeDefIndex: 27996
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x81A4D44 Offset: 0x81A0D44 VA: 0x81A4D44
	internal void .ctor() { }

	// RVA: 0x81ABCCC Offset: 0x81A7CCC VA: 0x81ABCCC
	public void Remove() { }

	// RVA: 0x81ABD2C Offset: 0x81A7D2C VA: 0x81ABD2C Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x81AC2A0 Offset: 0x81A82A0 VA: 0x81AC2A0 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x81ABE28 Offset: 0x81A7E28 VA: 0x81ABE28
	private string GetXmlString(SaveOptions o) { }
}

// Namespace: System.Xml.Linq
public abstract class XObject : IXmlLineInfo // TypeDefIndex: 27997
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x81A3C08 Offset: 0x819FC08 VA: 0x81A3C08
	internal void .ctor() { }

	// RVA: 0x81A8548 Offset: 0x81A4548 VA: 0x81A8548
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x81AC2A4 Offset: 0x81A82A4 VA: 0x81AC2A4
	public XElement get_Parent() { }

	// RVA: 0x81AA3EC Offset: 0x81A63EC VA: 0x81AA3EC
	public void AddAnnotation(object annotation) { }

	// RVA: 0x81AC320 Offset: 0x81A8320 VA: 0x81AC320
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4786CFC Offset: 0x4782CFC VA: 0x4786CFC
	|-XObject.Annotation<object>
	*/

	// RVA: 0x81AC46C Offset: 0x81A846C VA: 0x81AC46C Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x81AC4C0 Offset: 0x81A84C0 VA: 0x81AC4C0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x81AC514 Offset: 0x81A8514 VA: 0x81AC514 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x81A84F4 Offset: 0x81A44F4 VA: 0x81A84F4
	internal bool get_HasBaseUri() { }

	// RVA: 0x81A6548 Offset: 0x81A2548 VA: 0x81A6548
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x81A64A0 Offset: 0x81A24A0 VA: 0x81A64A0
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x81A839C Offset: 0x81A439C VA: 0x81A839C
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x81A8414 Offset: 0x81A4414 VA: 0x81A8414
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x81A5720 Offset: 0x81A1720 VA: 0x81A5720
	internal bool SkipNotify() { }

	// RVA: 0x81ABD48 Offset: 0x81A7D48 VA: 0x81ABD48
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}

// Namespace: System.Xml.Linq
internal class XObjectChangeAnnotation // TypeDefIndex: 27998
{
	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
}

// Namespace: System.Xml.Linq
public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 27999
{
	// Fields
	private XObjectChange _objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x81AC568 Offset: 0x81A8568 VA: 0x81AC568
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x81AC5D4 Offset: 0x81A85D4 VA: 0x81AC5D4
	private static void .cctor() { }
}

// Namespace: System.Xml.Linq
public class XProcessingInstruction : XNode // TypeDefIndex: 28000
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x81A8240 Offset: 0x81A4240 VA: 0x81A8240
	public void .ctor(string target, string data) { }

	// RVA: 0x81AC78C Offset: 0x81A878C VA: 0x81AC78C
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x81AC818 Offset: 0x81A8818 VA: 0x81AC818
	public string get_Data() { }

	// RVA: 0x81AC820 Offset: 0x81A8820 VA: 0x81AC820 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81AC828 Offset: 0x81A8828 VA: 0x81AC828
	public string get_Target() { }

	// RVA: 0x81AC830 Offset: 0x81A8830 VA: 0x81AC830 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81AC8A0 Offset: 0x81A88A0 VA: 0x81AC8A0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x81AC6B4 Offset: 0x81A86B4 VA: 0x81AC6B4
	private static void ValidateName(string name) { }
}

// Namespace: System.Xml.Linq
public class XStreamingElement // TypeDefIndex: 28001
{
	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18
}

// Namespace: System.Xml.Linq
public class XText : XNode // TypeDefIndex: 28002
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x81A4AFC Offset: 0x81A0AFC VA: 0x81A4AFC
	public void .ctor(string value) { }

	// RVA: 0x81A4B7C Offset: 0x81A0B7C VA: 0x81A4B7C
	public void .ctor(XText other) { }

	// RVA: 0x81AC8F8 Offset: 0x81A88F8 VA: 0x81AC8F8 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x81AC900 Offset: 0x81A8900 VA: 0x81AC900
	public string get_Value() { }

	// RVA: 0x81A65F0 Offset: 0x81A25F0 VA: 0x81A65F0
	public void set_Value(string value) { }

	// RVA: 0x81AC908 Offset: 0x81A8908 VA: 0x81AC908 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x81AC9F4 Offset: 0x81A89F4 VA: 0x81AC9F4 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x81ACA18 Offset: 0x81A8A18 VA: 0x81ACA18 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 28003
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x81A8A08 Offset: 0x81A4A08 VA: 0x81A8A08
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x81ACA70 Offset: 0x81A8A70 VA: 0x81ACA70
	public static void Release(StringBuilder sb) { }

	// RVA: 0x81A8AD0 Offset: 0x81A4AD0 VA: 0x81A8AD0
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 28004
{
	// Methods

	// RVA: 0x81ACAF0 Offset: 0x81A8AF0 VA: 0x81ACAF0
	public static void ThrowNotSupportedException() { }
}

