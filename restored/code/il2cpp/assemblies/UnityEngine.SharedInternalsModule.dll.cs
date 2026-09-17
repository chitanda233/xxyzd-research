// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28715
{}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4, Inherited = False)]
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 28716
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x87E3894 Offset: 0x87DF894 VA: 0x87E3894
	public void .ctor(string preferredExtension, string[] otherExtensions) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 28717
{
	// Methods

	// RVA: 0x87E38D8 Offset: 0x87DF8D8 VA: 0x87E38D8
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(2048, AllowMultiple = False)]
internal class WritableAttribute : Attribute // TypeDefIndex: 28718
{
	// Methods

	// RVA: 0x87E38E0 Offset: 0x87DF8E0 VA: 0x87E38E0
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(1)]
internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 28719
{
	// Methods

	// RVA: 0x87E38E8 Offset: 0x87DF8E8 VA: 0x87E38E8
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(12, Inherited = False)]
internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 28720
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <QualifiedNativeName>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Declaration>k__BackingField; // 0x18

	// Properties
	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E38F0 Offset: 0x87DF8F0 VA: 0x87E38F0
	private void set_QualifiedNativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E38F8 Offset: 0x87DF8F8 VA: 0x87E38F8
	private void set_Declaration(string value) { }

	// RVA: 0x87E3900 Offset: 0x87DF900 VA: 0x87E3900
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x87E3984 Offset: 0x87DF984 VA: 0x87E3984
	public void .ctor(string qualifiedCppName, string declaration) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal sealed class UnityString // TypeDefIndex: 28721
{
	// Methods

	// RVA: 0x87E39C8 Offset: 0x87DF9C8 VA: 0x87E39C8
	public static string Format(string fmt, object[] args) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(5628, Inherited = False)]
internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 28722
{
	// Methods

	// RVA: 0x87E3A50 Offset: 0x87DFA50 VA: 0x87E3A50
	public void .ctor() { }

	// RVA: 0x87E3A58 Offset: 0x87DFA58 VA: 0x87E3A58
	public void .ctor(string[] modules) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 28723
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Condition>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <StubReturnStatement>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Enabled>k__BackingField; // 0x20

	// Properties
	public string Condition { set; }
	public string StubReturnStatement { set; }
	public bool Enabled { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3A60 Offset: 0x87DFA60 VA: 0x87E3A60
	public void set_Condition(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E3A68 Offset: 0x87DFA68 VA: 0x87E3A68
	public void set_StubReturnStatement(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E3A70 Offset: 0x87DFA70 VA: 0x87E3A70
	public void set_Enabled(bool value) { }

	// RVA: 0x87E3A7C Offset: 0x87DFA7C VA: 0x87E3A7C
	public void .ctor(string condition) { }

	// RVA: 0x87E3AB8 Offset: 0x87DFAB8 VA: 0x87E3AB8
	public void .ctor(string condition, string stubReturnStatement) { }
}

// Namespace: UnityEngine.Bindings
[Usage(10716, AllowMultiple = True)]
[VisibleToOtherModules]
internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 28724
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Header>k__BackingField; // 0x10

	// Properties
	public string Header { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3B04 Offset: 0x87DFB04 VA: 0x87E3B04 Slot: 11
	public void set_Header(string value) { }

	// RVA: 0x87E3B0C Offset: 0x87DFB0C VA: 0x87E3B0C
	public void .ctor() { }

	// RVA: 0x87E3B14 Offset: 0x87DFB14 VA: 0x87E3B14
	public void .ctor(string header) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(448)]
internal class NativeNameAttribute : Attribute // TypeDefIndex: 28725
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3C18 Offset: 0x87DFC18 VA: 0x87E3C18 Slot: 11
	public void set_Name(string value) { }

	// RVA: 0x87E3C20 Offset: 0x87DFC20 VA: 0x87E3C20
	public void .ctor(string name) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal sealed class NativeWritableSelfAttribute : Attribute // TypeDefIndex: 28726
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <WritableSelf>k__BackingField; // 0x10

	// Properties
	public bool WritableSelf { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3D24 Offset: 0x87DFD24 VA: 0x87E3D24 Slot: 11
	public void set_WritableSelf(bool value) { }

	// RVA: 0x87E3D30 Offset: 0x87DFD30 VA: 0x87E3D30
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeMethodAttribute : Attribute // TypeDefIndex: 28727
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3D50 Offset: 0x87DFD50 VA: 0x87E3D50 Slot: 11
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E3D58 Offset: 0x87DFD58 VA: 0x87E3D58 Slot: 12
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87E3D64 Offset: 0x87DFD64 VA: 0x87E3D64 Slot: 13
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87E3D70 Offset: 0x87DFD70 VA: 0x87E3D70 Slot: 14
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87E3D7C Offset: 0x87DFD7C VA: 0x87E3D7C Slot: 15
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x87E3D88 Offset: 0x87DFD88 VA: 0x87E3D88
	public void .ctor() { }

	// RVA: 0x87E3D90 Offset: 0x87DFD90 VA: 0x87E3D90
	public void .ctor(string name) { }

	// RVA: 0x87E3E94 Offset: 0x87DFE94 VA: 0x87E3E94
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x87E3EBC Offset: 0x87DFEBC VA: 0x87E3EBC
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum TargetType // TypeDefIndex: 28728
{
	// Fields
	public int value__; // 0x0
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(128)]
internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 28729
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TargetType <TargetType>k__BackingField; // 0x1C

	// Properties
	public TargetType TargetType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3EF0 Offset: 0x87DFEF0 VA: 0x87E3EF0
	public void set_TargetType(TargetType value) { }

	// RVA: 0x87E3EF8 Offset: 0x87DFEF8 VA: 0x87E3EF8
	public void .ctor() { }

	// RVA: 0x87E3F00 Offset: 0x87DFF00 VA: 0x87E3F00
	public void .ctor(string name) { }

	// RVA: 0x87E3F04 Offset: 0x87DFF04 VA: 0x87E3F04
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x87E3F34 Offset: 0x87DFF34 VA: 0x87E3F34
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum CodegenOptions // TypeDefIndex: 28730
{
	// Fields
	public int value__; // 0x0
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4)]
internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 28731
{
	// Methods

	// RVA: 0x87E3F78 Offset: 0x87DFF78 VA: 0x87E3F78
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(28)]
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 28732
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Header>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E3F80 Offset: 0x87DFF80 VA: 0x87E3F80 Slot: 11
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E3F88 Offset: 0x87DFF88 VA: 0x87E3F88
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E3F90 Offset: 0x87DFF90 VA: 0x87E3F90 Slot: 12
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x87E3F98 Offset: 0x87DFF98 VA: 0x87E3F98
	public void .ctor() { }

	// RVA: 0x87E3FB4 Offset: 0x87DFFB4 VA: 0x87E3FB4
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x87E3FDC Offset: 0x87DFFDC VA: 0x87E3FDC
	public void .ctor(string header) { }

	// RVA: 0x87E40E4 Offset: 0x87E00E4 VA: 0x87E40E4
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(2048)]
internal class NotNullAttribute : Attribute // TypeDefIndex: 28733
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Exception>k__BackingField; // 0x10

	// Properties
	public string Exception { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E411C Offset: 0x87E011C VA: 0x87E411C
	public void set_Exception(string value) { }

	// RVA: 0x87E4124 Offset: 0x87E0124 VA: 0x87E4124
	public void .ctor(string exception = "ArgumentNullException") { }
}

// Namespace: UnityEngine.Bindings
[Usage(2048)]
[VisibleToOtherModules]
internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 28734
{
	// Methods

	// RVA: 0x87E4154 Offset: 0x87E0154 VA: 0x87E4154
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 28735
{
	// Methods

	// RVA: 0x87E415C Offset: 0x87E015C VA: 0x87E415C
	public void .ctor() { }

	// RVA: 0x87E417C Offset: 0x87E017C VA: 0x87E417C
	public void .ctor(string name) { }

	// RVA: 0x87E4198 Offset: 0x87E0198 VA: 0x87E4198
	public void .ctor(string name, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 28736
{
	// Methods

	// RVA: 0x87E41C8 Offset: 0x87E01C8 VA: 0x87E41C8
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum StaticAccessorType // TypeDefIndex: 28737
{
	// Fields
	public int value__; // 0x0
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
[Usage(204)]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 28738
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E41E8 Offset: 0x87E01E8 VA: 0x87E41E8
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E41F0 Offset: 0x87E01F0 VA: 0x87E41F0
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x87E41F8 Offset: 0x87E01F8 VA: 0x87E41F8
	internal void .ctor(string name) { }

	// RVA: 0x87E4228 Offset: 0x87E0228 VA: 0x87E4228
	public void .ctor(string name, StaticAccessorType type) { }
}

// Namespace: UnityEngine.Bindings
[Usage(192)]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 28739
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties
	public bool ThrowsException { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E4264 Offset: 0x87E0264 VA: 0x87E4264 Slot: 11
	public void set_ThrowsException(bool value) { }

	// RVA: 0x87E4270 Offset: 0x87E0270 VA: 0x87E4270
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(256)]
internal class IgnoreAttribute : Attribute // TypeDefIndex: 28740
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public bool DoesNotContributeToSize { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87E4290 Offset: 0x87E0290 VA: 0x87E4290
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x87E429C Offset: 0x87E029C VA: 0x87E429C
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4, AllowMultiple = False, Inherited = False)]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 28741
{
	// Methods

	// RVA: 0x87E42A4 Offset: 0x87E02A4 VA: 0x87E42A4
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(2048, AllowMultiple = False, Inherited = False)]
internal class SpanAttribute : Attribute // TypeDefIndex: 28742
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <SizeParameter>k__BackingField; // 0x18

	// Methods

	// RVA: 0x87E42AC Offset: 0x87E02AC VA: 0x87E42AC
	public void .ctor(string sizeParameter, bool isReadOnly = False) { }
}

// Namespace: UnityEngine.Scripting
[Usage(1532, Inherited = False)]
[VisibleToOtherModules]
internal class UsedByNativeCodeAttribute : Attribute // TypeDefIndex: 28743
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	// RVA: 0x87E42E8 Offset: 0x87E02E8 VA: 0x87E42E8
	public void .ctor() { }

	// RVA: 0x87E42F0 Offset: 0x87E02F0 VA: 0x87E42F0
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x87E4320 Offset: 0x87E0320 VA: 0x87E4320
	public void set_Name(string value) { }
}

// Namespace: UnityEngine.Scripting
[VisibleToOtherModules]
[Usage(1532, Inherited = False)]
internal class RequiredByNativeCodeAttribute : Attribute // TypeDefIndex: 28744
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Optional>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Properties
	public string Name { set; }
	public bool Optional { set; }
	public bool GenerateProxy { set; }

	// Methods

	// RVA: 0x87E4328 Offset: 0x87E0328 VA: 0x87E4328
	public void .ctor() { }

	// RVA: 0x87E4330 Offset: 0x87E0330 VA: 0x87E4330
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x87E4360 Offset: 0x87E0360 VA: 0x87E4360
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x87E4368 Offset: 0x87E0368 VA: 0x87E4368
	public void set_Optional(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87E4374 Offset: 0x87E0374 VA: 0x87E4374
	public void set_GenerateProxy(bool value) { }
}

