// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26621
{}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class AssetListAttribute : Attribute // TypeDefIndex: 26622
{
	// Fields
	public bool AutoPopulate; // 0x10
	public string Tags; // 0x18
	public string LayerNames; // 0x20
	public string AssetNamePrefix; // 0x28
	public string Path; // 0x30
	public string CustomFilterMethod; // 0x38

	// Methods

	// RVA: 0x7E7E51C Offset: 0x7E7A51C VA: 0x7E7E51C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AssetSelectorAttribute.<>c // TypeDefIndex: 26623
{
	// Fields
	public static readonly AssetSelectorAttribute.<>c <>9; // 0x0
	public static Func<string, string> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x7E7E77C Offset: 0x7E7A77C VA: 0x7E7E77C
	private static void .cctor() { }

	// RVA: 0x7E7E7E4 Offset: 0x7E7A7E4 VA: 0x7E7E7E4
	public void .ctor() { }

	// RVA: 0x7E7E7EC Offset: 0x7E7A7EC VA: 0x7E7E7EC
	internal string <set_Paths>b__12_0(string x) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class AssetSelectorAttribute : Attribute // TypeDefIndex: 26624
{
	// Fields
	public bool IsUniqueList; // 0x10
	public bool DrawDropdownForListElements; // 0x11
	public bool DisableListAddButtonBehaviour; // 0x12
	public bool ExcludeExistingValuesInList; // 0x13
	public bool ExpandAllMenuItems; // 0x14
	public bool FlattenTreeView; // 0x15
	public int DropdownWidth; // 0x18
	public int DropdownHeight; // 0x1C
	public string DropdownTitle; // 0x20
	public string[] SearchInFolders; // 0x28
	public string Filter; // 0x30

	// Properties
	public string Paths { get; set; }

	// Methods

	// RVA: 0x7E7E574 Offset: 0x7E7A574 VA: 0x7E7E574
	public void set_Paths(string value) { }

	// RVA: 0x7E7E704 Offset: 0x7E7A704 VA: 0x7E7E704
	public string get_Paths() { }

	// RVA: 0x7E7E764 Offset: 0x7E7A764 VA: 0x7E7E764
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class AssetsOnlyAttribute : Attribute // TypeDefIndex: 26625
{
	// Methods

	// RVA: 0x7E7E88C Offset: 0x7E7A88C VA: 0x7E7E88C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public class BoxGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26626
{
	// Fields
	public bool ShowLabel; // 0x31
	public bool CenterLabel; // 0x32
	public string LabelText; // 0x38

	// Methods

	// RVA: 0x7E7E894 Offset: 0x7E7A894 VA: 0x7E7E894
	public void .ctor(string group, bool showLabel = True, bool centerLabel = False, float order = 0) { }

	// RVA: 0x7E7E95C Offset: 0x7E7A95C VA: 0x7E7E95C
	public void .ctor() { }

	// RVA: 0x7E7E9B0 Offset: 0x7E7A9B0 VA: 0x7E7E9B0 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public class ButtonAttribute : ShowInInspectorAttribute // TypeDefIndex: 26627
{
	// Fields
	public string Name; // 0x10
	public ButtonStyle Style; // 0x18
	public bool Expanded; // 0x1C
	public bool DisplayParameters; // 0x1D
	public bool DirtyOnClick; // 0x1E
	public SdfIconType Icon; // 0x20
	[CompilerGenerated]
	private bool <HasDefinedButtonHeight>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <HasDefinedButtonIconAlignment>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <HasDefinedButtonAlignment>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <HasDefinedStretch>k__BackingField; // 0x27
	private int buttonHeight; // 0x28
	private bool drawResult; // 0x2C
	private bool drawResultIsSet; // 0x2D
	private bool stretch; // 0x2E
	private IconAlignment buttonIconAlignment; // 0x30
	private float buttonAlignment; // 0x34

	// Properties
	public int ButtonHeight { get; set; }
	public IconAlignment IconAlignment { get; set; }
	public float ButtonAlignment { get; set; }
	public bool Stretch { get; set; }
	public bool DrawResult { get; set; }
	public bool DrawResultIsSet { get; }
	public bool HasDefinedButtonHeight { get; set; }
	public bool HasDefinedIcon { get; }
	public bool HasDefinedButtonIconAlignment { get; set; }
	public bool HasDefinedButtonAlignment { get; set; }
	public bool HasDefinedStretch { get; set; }

	// Methods

	// RVA: 0x7E7EA68 Offset: 0x7E7AA68 VA: 0x7E7EA68
	public int get_ButtonHeight() { }

	// RVA: 0x7E7EA70 Offset: 0x7E7AA70 VA: 0x7E7EA70
	public void set_ButtonHeight(int value) { }

	// RVA: 0x7E7EA80 Offset: 0x7E7AA80 VA: 0x7E7EA80
	public IconAlignment get_IconAlignment() { }

	// RVA: 0x7E7EA88 Offset: 0x7E7AA88 VA: 0x7E7EA88
	public void set_IconAlignment(IconAlignment value) { }

	// RVA: 0x7E7EA98 Offset: 0x7E7AA98 VA: 0x7E7EA98
	public float get_ButtonAlignment() { }

	// RVA: 0x7E7EAA0 Offset: 0x7E7AAA0 VA: 0x7E7EAA0
	public void set_ButtonAlignment(float value) { }

	// RVA: 0x7E7EAB0 Offset: 0x7E7AAB0 VA: 0x7E7EAB0
	public bool get_Stretch() { }

	// RVA: 0x7E7EAB8 Offset: 0x7E7AAB8 VA: 0x7E7EAB8
	public void set_Stretch(bool value) { }

	// RVA: 0x7E7EACC Offset: 0x7E7AACC VA: 0x7E7EACC
	public void set_DrawResult(bool value) { }

	// RVA: 0x7E7EAE0 Offset: 0x7E7AAE0 VA: 0x7E7EAE0
	public bool get_DrawResult() { }

	// RVA: 0x7E7EAE8 Offset: 0x7E7AAE8 VA: 0x7E7EAE8
	public bool get_DrawResultIsSet() { }

	[CompilerGenerated]
	// RVA: 0x7E7EAF0 Offset: 0x7E7AAF0 VA: 0x7E7EAF0
	public bool get_HasDefinedButtonHeight() { }

	[CompilerGenerated]
	// RVA: 0x7E7EAF8 Offset: 0x7E7AAF8 VA: 0x7E7EAF8
	private void set_HasDefinedButtonHeight(bool value) { }

	// RVA: 0x7E7EB04 Offset: 0x7E7AB04 VA: 0x7E7EB04
	public bool get_HasDefinedIcon() { }

	[CompilerGenerated]
	// RVA: 0x7E7EB14 Offset: 0x7E7AB14 VA: 0x7E7EB14
	public bool get_HasDefinedButtonIconAlignment() { }

	[CompilerGenerated]
	// RVA: 0x7E7EB1C Offset: 0x7E7AB1C VA: 0x7E7EB1C
	private void set_HasDefinedButtonIconAlignment(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7EB28 Offset: 0x7E7AB28 VA: 0x7E7EB28
	public bool get_HasDefinedButtonAlignment() { }

	[CompilerGenerated]
	// RVA: 0x7E7EB30 Offset: 0x7E7AB30 VA: 0x7E7EB30
	private void set_HasDefinedButtonAlignment(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7EB3C Offset: 0x7E7AB3C VA: 0x7E7EB3C
	public bool get_HasDefinedStretch() { }

	[CompilerGenerated]
	// RVA: 0x7E7EB44 Offset: 0x7E7AB44 VA: 0x7E7EB44
	private void set_HasDefinedStretch(bool value) { }

	// RVA: 0x7E7EB50 Offset: 0x7E7AB50 VA: 0x7E7EB50
	public void .ctor() { }

	// RVA: 0x7E7EB84 Offset: 0x7E7AB84 VA: 0x7E7EB84
	public void .ctor(ButtonSizes size) { }

	// RVA: 0x7E7EBCC Offset: 0x7E7ABCC VA: 0x7E7EBCC
	public void .ctor(int buttonSize) { }

	// RVA: 0x7E7EC10 Offset: 0x7E7AC10 VA: 0x7E7EC10
	public void .ctor(string name) { }

	// RVA: 0x7E7EC48 Offset: 0x7E7AC48 VA: 0x7E7EC48
	public void .ctor(string name, ButtonSizes buttonSize) { }

	// RVA: 0x7E7EC94 Offset: 0x7E7AC94 VA: 0x7E7EC94
	public void .ctor(string name, int buttonSize) { }

	// RVA: 0x7E7ECE0 Offset: 0x7E7ACE0 VA: 0x7E7ECE0
	public void .ctor(ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7ED20 Offset: 0x7E7AD20 VA: 0x7E7ED20
	public void .ctor(int buttonSize, ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7ED70 Offset: 0x7E7AD70 VA: 0x7E7ED70
	public void .ctor(ButtonSizes size, ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7EDC0 Offset: 0x7E7ADC0 VA: 0x7E7EDC0
	public void .ctor(string name, ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7EE04 Offset: 0x7E7AE04 VA: 0x7E7EE04
	public void .ctor(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7EE60 Offset: 0x7E7AE60 VA: 0x7E7EE60
	public void .ctor(string name, int buttonSize, ButtonStyle parameterBtnStyle) { }

	// RVA: 0x7E7EEBC Offset: 0x7E7AEBC VA: 0x7E7EEBC
	public void .ctor(SdfIconType icon, IconAlignment iconAlignment) { }

	// RVA: 0x7E7EF08 Offset: 0x7E7AF08 VA: 0x7E7EF08
	public void .ctor(SdfIconType icon) { }

	// RVA: 0x7E7EF44 Offset: 0x7E7AF44 VA: 0x7E7EF44
	public void .ctor(SdfIconType icon, string name) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(64, AllowMultiple = True, Inherited = True)]
[IncludeMys]
[ShowInInspector]
public class ButtonGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26628
{
	// Fields
	public int ButtonHeight; // 0x34
	[CompilerGenerated]
	private bool <HasDefinedButtonIconAlignment>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <HasDefinedButtonAlignment>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <HasDefinedStretch>k__BackingField; // 0x3A
	private IconAlignment buttonIconAlignment; // 0x3C
	private int buttonAlignment; // 0x40
	private bool stretch; // 0x44

	// Properties
	public IconAlignment IconAlignment { get; set; }
	public int ButtonAlignment { get; set; }
	public bool Stretch { get; set; }
	public bool HasDefinedButtonIconAlignment { get; set; }
	public bool HasDefinedButtonAlignment { get; set; }
	public bool HasDefinedStretch { get; set; }

	// Methods

	// RVA: 0x7E7EF88 Offset: 0x7E7AF88 VA: 0x7E7EF88
	public IconAlignment get_IconAlignment() { }

	// RVA: 0x7E7EF90 Offset: 0x7E7AF90 VA: 0x7E7EF90
	public void set_IconAlignment(IconAlignment value) { }

	// RVA: 0x7E7EFA0 Offset: 0x7E7AFA0 VA: 0x7E7EFA0
	public int get_ButtonAlignment() { }

	// RVA: 0x7E7EFA8 Offset: 0x7E7AFA8 VA: 0x7E7EFA8
	public void set_ButtonAlignment(int value) { }

	// RVA: 0x7E7EFB8 Offset: 0x7E7AFB8 VA: 0x7E7EFB8
	public bool get_Stretch() { }

	// RVA: 0x7E7EFC0 Offset: 0x7E7AFC0 VA: 0x7E7EFC0
	public void set_Stretch(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7EFD4 Offset: 0x7E7AFD4 VA: 0x7E7EFD4
	public bool get_HasDefinedButtonIconAlignment() { }

	[CompilerGenerated]
	// RVA: 0x7E7EFDC Offset: 0x7E7AFDC VA: 0x7E7EFDC
	private void set_HasDefinedButtonIconAlignment(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7EFE8 Offset: 0x7E7AFE8 VA: 0x7E7EFE8
	public bool get_HasDefinedButtonAlignment() { }

	[CompilerGenerated]
	// RVA: 0x7E7EFF0 Offset: 0x7E7AFF0 VA: 0x7E7EFF0
	private void set_HasDefinedButtonAlignment(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7EFFC Offset: 0x7E7AFFC VA: 0x7E7EFFC
	public bool get_HasDefinedStretch() { }

	[CompilerGenerated]
	// RVA: 0x7E7F004 Offset: 0x7E7B004 VA: 0x7E7F004
	private void set_HasDefinedStretch(bool value) { }

	// RVA: 0x7E7F010 Offset: 0x7E7B010 VA: 0x7E7F010
	public void .ctor(string group = "_DefaultGroup", float order = 0) { }
}

// Namespace: Sirenix.OdinInspector
public enum ButtonStyle // TypeDefIndex: 26629
{
	// Fields
	public int value__; // 0x0
	public const ButtonStyle CompactBox = 0;
	public const ButtonStyle FoldoutButton = 1;
	public const ButtonStyle Box = 2;
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class ChildGameObjectsOnlyAttribute : Attribute // TypeDefIndex: 26630
{
	// Fields
	public bool IncludeSelf; // 0x10
	public bool IncludeInactive; // 0x11

	// Methods

	// RVA: 0x7E7F014 Offset: 0x7E7B014 VA: 0x7E7F014
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ColorPaletteAttribute : Attribute // TypeDefIndex: 26631
{
	// Fields
	public string PaletteName; // 0x10
	public bool ShowAlpha; // 0x18

	// Methods

	// RVA: 0x7E7F024 Offset: 0x7E7B024 VA: 0x7E7F024
	public void .ctor() { }

	// RVA: 0x7E7F054 Offset: 0x7E7B054 VA: 0x7E7F054
	public void .ctor(string paletteName) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class CustomContextMenuAttribute : Attribute // TypeDefIndex: 26632
{
	// Fields
	public string MenuItem; // 0x10
	public string Action; // 0x18

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Use the Action member instead.", False)]
	public string MethodName { get; set; }

	// Methods

	// RVA: 0x7E7F090 Offset: 0x7E7B090 VA: 0x7E7F090
	public string get_MethodName() { }

	// RVA: 0x7E7F098 Offset: 0x7E7B098 VA: 0x7E7F098
	public void set_MethodName(string value) { }

	// RVA: 0x7E7F0A0 Offset: 0x7E7B0A0 VA: 0x7E7F0A0
	public void .ctor(string menuItem, string action) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class CustomValueDrawerAttribute : Attribute // TypeDefIndex: 26633
{
	// Fields
	public string Action; // 0x10

	// Properties
	[Obsolete("Use the Action member instead.", False)]
	[EditorBrowsable(1)]
	public string MethodName { get; set; }

	// Methods

	// RVA: 0x7E7F0E4 Offset: 0x7E7B0E4 VA: 0x7E7F0E4
	public string get_MethodName() { }

	// RVA: 0x7E7F0EC Offset: 0x7E7B0EC VA: 0x7E7F0EC
	public void set_MethodName(string value) { }

	// RVA: 0x7E7F0F4 Offset: 0x7E7B0F4 VA: 0x7E7F0F4
	public void .ctor(string action) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class DelayedPropertyAttribute : Attribute // TypeDefIndex: 26634
{
	// Methods

	// RVA: 0x7E7F124 Offset: 0x7E7B124 VA: 0x7E7F124
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
public class DetailedInfoBoxAttribute : Attribute // TypeDefIndex: 26635
{
	// Fields
	public string Message; // 0x10
	public string Details; // 0x18
	public InfoMessageType InfoMessageType; // 0x20
	public string VisibleIf; // 0x28

	// Methods

	// RVA: 0x7E7F12C Offset: 0x7E7B12C VA: 0x7E7F12C
	public void .ctor(string message, string details, InfoMessageType infoMessageType = 1, string visibleIf) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public sealed class DictionaryDrawerSettings : Attribute // TypeDefIndex: 26636
{
	// Fields
	public string KeyLabel; // 0x10
	public string ValueLabel; // 0x18
	public DictionaryDisplayOptions DisplayMode; // 0x20
	public bool IsReadOnly; // 0x24
	public float KeyColumnWidth; // 0x28

	// Methods

	// RVA: 0x7E7F194 Offset: 0x7E7B194 VA: 0x7E7F194
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
[DontApplyToListElements]
public sealed class DisableContextMenuAttribute : Attribute // TypeDefIndex: 26637
{
	// Fields
	public bool DisableForMember; // 0x10
	public bool DisableForCollectionElements; // 0x11

	// Methods

	// RVA: 0x7E7F220 Offset: 0x7E7B220 VA: 0x7E7F220
	public void .ctor(bool disableForMember = True, bool disableCollectionElements = False) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
public sealed class DisableIfAttribute : Attribute // TypeDefIndex: 26638
{
	// Fields
	public string Condition; // 0x10
	public object Value; // 0x18

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E7F250 Offset: 0x7E7B250 VA: 0x7E7F250
	public string get_MemberName() { }

	// RVA: 0x7E7F258 Offset: 0x7E7B258 VA: 0x7E7F258
	public void set_MemberName(string value) { }

	// RVA: 0x7E7F260 Offset: 0x7E7B260 VA: 0x7E7F260
	public void .ctor(string condition) { }

	// RVA: 0x7E7F290 Offset: 0x7E7B290 VA: 0x7E7F290
	public void .ctor(string condition, object optionalValue) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
[DontApplyToListElements]
public class DisableInAttribute : Attribute // TypeDefIndex: 26639
{
	// Fields
	public PrefabKind PrefabKind; // 0x10

	// Methods

	// RVA: 0x7E7F2D4 Offset: 0x7E7B2D4 VA: 0x7E7F2D4
	public void .ctor(PrefabKind prefabKind) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
[DontApplyToListElements]
public class DisableInEditorModeAttribute : Attribute // TypeDefIndex: 26640
{
	// Methods

	// RVA: 0x7E7F2FC Offset: 0x7E7B2FC VA: 0x7E7F2FC
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class DisableInInlineEditorsAttribute : Attribute // TypeDefIndex: 26641
{
	// Methods

	// RVA: 0x7E7F304 Offset: 0x7E7B304 VA: 0x7E7F304
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[EditorBrowsable(1)]
[Conditional("UNITY_EDITOR")]
[Obsolete("Use [DisableIn(PrefabKind.NonPrefabInstance)] instead.", False)]
[DontApplyToListElements]
[Usage(32767)]
public class DisableInNonPrefabsAttribute : Attribute // TypeDefIndex: 26642
{
	// Methods

	// RVA: 0x7E7F30C Offset: 0x7E7B30C VA: 0x7E7F30C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class DisableInPlayModeAttribute : Attribute // TypeDefIndex: 26643
{
	// Methods

	// RVA: 0x7E7F314 Offset: 0x7E7B314 VA: 0x7E7F314
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(1)]
[Obsolete("Use [DisableIn(PrefabKind.PrefabAsset)] instead.", False)]
public class DisableInPrefabAssetsAttribute : Attribute // TypeDefIndex: 26644
{
	// Methods

	// RVA: 0x7E7F31C Offset: 0x7E7B31C VA: 0x7E7F31C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[EditorBrowsable(1)]
[Obsolete("Use [DisableIn(PrefabKind.PrefabInstance)] instead.", False)]
[Usage(32767)]
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
public class DisableInPrefabInstancesAttribute : Attribute // TypeDefIndex: 26645
{
	// Methods

	// RVA: 0x7E7F324 Offset: 0x7E7B324 VA: 0x7E7F324
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Obsolete("Use [DisableIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", False)]
[EditorBrowsable(1)]
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class DisableInPrefabsAttribute : Attribute // TypeDefIndex: 26646
{
	// Methods

	// RVA: 0x7E7F32C Offset: 0x7E7B32C VA: 0x7E7F32C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class DisallowModificationsInAttribute : Attribute // TypeDefIndex: 26647
{
	// Fields
	public PrefabKind PrefabKind; // 0x10

	// Methods

	// RVA: 0x7E7F334 Offset: 0x7E7B334 VA: 0x7E7F334
	public void .ctor(PrefabKind kind) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class DisplayAsStringAttribute : Attribute // TypeDefIndex: 26648
{
	// Fields
	public bool Overflow; // 0x10
	public TextAlignment Alignment; // 0x14
	public int FontSize; // 0x18
	public bool EnableRichText; // 0x1C

	// Methods

	// RVA: 0x7E7F35C Offset: 0x7E7B35C VA: 0x7E7F35C
	public void .ctor() { }

	// RVA: 0x7E7F37C Offset: 0x7E7B37C VA: 0x7E7F37C
	public void .ctor(bool overflow) { }

	// RVA: 0x7E7F3A4 Offset: 0x7E7B3A4 VA: 0x7E7F3A4
	public void .ctor(TextAlignment alignment) { }

	// RVA: 0x7E7F3CC Offset: 0x7E7B3CC VA: 0x7E7F3CC
	public void .ctor(int fontSize) { }

	// RVA: 0x7E7F3F4 Offset: 0x7E7B3F4 VA: 0x7E7F3F4
	public void .ctor(bool overflow, TextAlignment alignment) { }

	// RVA: 0x7E7F424 Offset: 0x7E7B424 VA: 0x7E7F424
	public void .ctor(bool overflow, int fontSize) { }

	// RVA: 0x7E7F454 Offset: 0x7E7B454 VA: 0x7E7F454
	public void .ctor(int fontSize, TextAlignment alignment) { }

	// RVA: 0x7E7F480 Offset: 0x7E7B480 VA: 0x7E7F480
	public void .ctor(bool overflow, int fontSize, TextAlignment alignment) { }

	// RVA: 0x7E7F4BC Offset: 0x7E7B4BC VA: 0x7E7F4BC
	public void .ctor(TextAlignment alignment, bool enableRichText) { }

	// RVA: 0x7E7F4EC Offset: 0x7E7B4EC VA: 0x7E7F4EC
	public void .ctor(int fontSize, bool enableRichText) { }

	// RVA: 0x7E7F51C Offset: 0x7E7B51C VA: 0x7E7F51C
	public void .ctor(bool overflow, TextAlignment alignment, bool enableRichText) { }

	// RVA: 0x7E7F55C Offset: 0x7E7B55C VA: 0x7E7F55C
	public void .ctor(bool overflow, int fontSize, bool enableRichText) { }

	// RVA: 0x7E7F59C Offset: 0x7E7B59C VA: 0x7E7F59C
	public void .ctor(int fontSize, TextAlignment alignment, bool enableRichText) { }

	// RVA: 0x7E7F5D8 Offset: 0x7E7B5D8 VA: 0x7E7F5D8
	public void .ctor(bool overflow, int fontSize, TextAlignment alignment, bool enableRichText) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public sealed class DoNotDrawAsReferenceAttribute : Attribute // TypeDefIndex: 26649
{
	// Methods

	// RVA: 0x7E7F61C Offset: 0x7E7B61C VA: 0x7E7F61C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(4)]
public sealed class DontApplyToListElementsAttribute : Attribute // TypeDefIndex: 26650
{
	// Methods

	// RVA: 0x7E7F624 Offset: 0x7E7B624 VA: 0x7E7F624
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class DontValidateAttribute : Attribute // TypeDefIndex: 26651
{
	// Methods

	// RVA: 0x7E7F62C Offset: 0x7E7B62C VA: 0x7E7F62C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class DrawWithUnityAttribute : Attribute // TypeDefIndex: 26652
{
	// Methods

	// RVA: 0x7E7F634 Offset: 0x7E7B634 VA: 0x7E7F634
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class EnableGUIAttribute : Attribute // TypeDefIndex: 26653
{
	// Methods

	// RVA: 0x7E7F63C Offset: 0x7E7B63C VA: 0x7E7F63C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[DontApplyToListElements]
public sealed class EnableIfAttribute : Attribute // TypeDefIndex: 26654
{
	// Fields
	public string Condition; // 0x10
	public object Value; // 0x18

	// Properties
	[Obsolete("Use the Condition member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E7F644 Offset: 0x7E7B644 VA: 0x7E7F644
	public string get_MemberName() { }

	// RVA: 0x7E7F64C Offset: 0x7E7B64C VA: 0x7E7F64C
	public void set_MemberName(string value) { }

	// RVA: 0x7E7F654 Offset: 0x7E7B654 VA: 0x7E7F654
	public void .ctor(string condition) { }

	// RVA: 0x7E7F684 Offset: 0x7E7B684 VA: 0x7E7F684
	public void .ctor(string condition, object optionalValue) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class EnableInAttribute : Attribute // TypeDefIndex: 26655
{
	// Fields
	public PrefabKind PrefabKind; // 0x10

	// Methods

	// RVA: 0x7E7F6C8 Offset: 0x7E7B6C8 VA: 0x7E7F6C8
	public void .ctor(PrefabKind prefabKind) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False)]
public class EnumPagingAttribute : Attribute // TypeDefIndex: 26656
{
	// Methods

	// RVA: 0x7E7F6F0 Offset: 0x7E7B6F0 VA: 0x7E7F6F0
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class EnumToggleButtonsAttribute : Attribute // TypeDefIndex: 26657
{
	// Methods

	// RVA: 0x7E7F6F8 Offset: 0x7E7B6F8 VA: 0x7E7F6F8
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class FilePathAttribute : Attribute // TypeDefIndex: 26658
{
	// Fields
	public bool AbsolutePath; // 0x10
	public string Extensions; // 0x18
	public string ParentFolder; // 0x20
	[EditorBrowsable(1)]
	[Obsolete("Use RequireExistingPath instead.", True)]
	public bool RequireValidPath; // 0x28
	public bool RequireExistingPath; // 0x29
	public bool UseBackslashes; // 0x2A
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; // 0x2B

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Add a ReadOnly attribute to the property instead.", True)]
	public bool ReadOnly { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7E7F700 Offset: 0x7E7B700 VA: 0x7E7F700
	public bool get_ReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x7E7F708 Offset: 0x7E7B708 VA: 0x7E7F708
	public void set_ReadOnly(bool value) { }

	// RVA: 0x7E7F714 Offset: 0x7E7B714 VA: 0x7E7F714
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class FolderPathAttribute : Attribute // TypeDefIndex: 26659
{
	// Fields
	public bool AbsolutePath; // 0x10
	public string ParentFolder; // 0x18
	[Obsolete("Use RequireExistingPath instead.", True)]
	[EditorBrowsable(1)]
	public bool RequireValidPath; // 0x20
	public bool RequireExistingPath; // 0x21
	public bool UseBackslashes; // 0x22

	// Methods

	// RVA: 0x7E7F71C Offset: 0x7E7B71C VA: 0x7E7F71C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class FoldoutGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26660
{
	// Fields
	private bool expanded; // 0x31
	[CompilerGenerated]
	private bool <HasDefinedExpanded>k__BackingField; // 0x32

	// Properties
	public bool Expanded { get; set; }
	public bool HasDefinedExpanded { get; set; }

	// Methods

	// RVA: 0x7E7F724 Offset: 0x7E7B724 VA: 0x7E7F724
	public bool get_Expanded() { }

	// RVA: 0x7E7F72C Offset: 0x7E7B72C VA: 0x7E7F72C
	public void set_Expanded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7F740 Offset: 0x7E7B740 VA: 0x7E7F740
	public bool get_HasDefinedExpanded() { }

	[CompilerGenerated]
	// RVA: 0x7E7F748 Offset: 0x7E7B748 VA: 0x7E7F748
	private void set_HasDefinedExpanded(bool value) { }

	// RVA: 0x7E7F754 Offset: 0x7E7B754 VA: 0x7E7F754
	public void .ctor(string groupName, float order = 0) { }

	// RVA: 0x7E7F758 Offset: 0x7E7B758 VA: 0x7E7F758
	public void .ctor(string groupName, bool expanded, float order = 0) { }

	// RVA: 0x7E7F784 Offset: 0x7E7B784 VA: 0x7E7F784 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class GUIColorAttribute : Attribute // TypeDefIndex: 26661
{
	// Fields
	public Color Color; // 0x10
	public string GetColor; // 0x20

	// Methods

	// RVA: 0x7E7F830 Offset: 0x7E7B830 VA: 0x7E7F830
	public void .ctor(float r, float g, float b, float a = 1) { }

	// RVA: 0x7E7F870 Offset: 0x7E7B870 VA: 0x7E7F870
	public void .ctor(string getColor) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class HideDuplicateReferenceBoxAttribute : Attribute // TypeDefIndex: 26662
{
	// Methods

	// RVA: 0x7E7F8A0 Offset: 0x7E7B8A0 VA: 0x7E7F8A0
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class HideIfAttribute : Attribute // TypeDefIndex: 26663
{
	// Fields
	public string Condition; // 0x10
	public object Value; // 0x18
	public bool Animate; // 0x20

	// Properties
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E7F8A8 Offset: 0x7E7B8A8 VA: 0x7E7F8A8
	public string get_MemberName() { }

	// RVA: 0x7E7F8B0 Offset: 0x7E7B8B0 VA: 0x7E7F8B0
	public void set_MemberName(string value) { }

	// RVA: 0x7E7F8B8 Offset: 0x7E7B8B8 VA: 0x7E7F8B8
	public void .ctor(string condition, bool animate = True) { }

	// RVA: 0x7E7F8F4 Offset: 0x7E7B8F4 VA: 0x7E7F8F4
	public void .ctor(string condition, object optionalValue, bool animate = True) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class HideIfGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26664
{
	// Fields
	public object Value; // 0x38

	// Properties
	public bool Animate { get; set; }
	[Obsolete("Use the Condition member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }
	public string Condition { get; set; }

	// Methods

	// RVA: 0x7E7F94C Offset: 0x7E7B94C VA: 0x7E7F94C
	public bool get_Animate() { }

	// RVA: 0x7E7F954 Offset: 0x7E7B954 VA: 0x7E7F954
	public void set_Animate(bool value) { }

	// RVA: 0x7E7F960 Offset: 0x7E7B960 VA: 0x7E7F960
	public string get_MemberName() { }

	// RVA: 0x7E7F9C0 Offset: 0x7E7B9C0 VA: 0x7E7F9C0
	public void set_MemberName(string value) { }

	// RVA: 0x7E7F990 Offset: 0x7E7B990 VA: 0x7E7F990
	public string get_Condition() { }

	// RVA: 0x7E7F9C8 Offset: 0x7E7B9C8 VA: 0x7E7F9C8
	public void set_Condition(string value) { }

	// RVA: 0x7E7F9D0 Offset: 0x7E7B9D0 VA: 0x7E7F9D0
	public void .ctor(string path, bool animate = True) { }

	// RVA: 0x7E7FA04 Offset: 0x7E7BA04 VA: 0x7E7FA04
	public void .ctor(string path, object value, bool animate = True) { }

	// RVA: 0x7E7FA44 Offset: 0x7E7BA44 VA: 0x7E7FA44 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class HideInAttribute : Attribute // TypeDefIndex: 26665
{
	// Fields
	public PrefabKind PrefabKind; // 0x10

	// Methods

	// RVA: 0x7E7FAE0 Offset: 0x7E7BAE0 VA: 0x7E7FAE0
	public void .ctor(PrefabKind prefabKind) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class HideInEditorModeAttribute : Attribute // TypeDefIndex: 26666
{
	// Methods

	// RVA: 0x7E7FB08 Offset: 0x7E7BB08 VA: 0x7E7FB08
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class HideInInlineEditorsAttribute : Attribute // TypeDefIndex: 26667
{
	// Methods

	// RVA: 0x7E7FB10 Offset: 0x7E7BB10 VA: 0x7E7FB10
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(1)]
[Obsolete("Use [HideIn(PrefabKind.NonPrefabInstance)] instead.", False)]
public class HideInNonPrefabsAttribute : Attribute // TypeDefIndex: 26668
{
	// Methods

	// RVA: 0x7E7FB18 Offset: 0x7E7BB18 VA: 0x7E7FB18
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class HideInPlayModeAttribute : Attribute // TypeDefIndex: 26669
{
	// Methods

	// RVA: 0x7E7FB20 Offset: 0x7E7BB20 VA: 0x7E7FB20
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Obsolete("Use [HideIn(PrefabKind.PrefabAsset)] instead.", False)]
[EditorBrowsable(1)]
[Usage(32767)]
public class HideInPrefabAssetsAttribute : Attribute // TypeDefIndex: 26670
{
	// Methods

	// RVA: 0x7E7FB28 Offset: 0x7E7BB28 VA: 0x7E7FB28
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(1)]
[Obsolete("Use [HideIn(PrefabKind.PrefabInstance)] instead.", False)]
public class HideInPrefabInstancesAttribute : Attribute // TypeDefIndex: 26671
{
	// Methods

	// RVA: 0x7E7FB30 Offset: 0x7E7BB30 VA: 0x7E7FB30
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Obsolete("Use [HideIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", False)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(1)]
[DontApplyToListElements]
[Usage(32767)]
public class HideInPrefabsAttribute : Attribute // TypeDefIndex: 26672
{
	// Methods

	// RVA: 0x7E7FB38 Offset: 0x7E7BB38 VA: 0x7E7FB38
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class HideInTablesAttribute : Attribute // TypeDefIndex: 26673
{
	// Methods

	// RVA: 0x7E7FB40 Offset: 0x7E7BB40 VA: 0x7E7FB40
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class HideLabelAttribute : Attribute // TypeDefIndex: 26674
{
	// Methods

	// RVA: 0x7E7FB48 Offset: 0x7E7BB48 VA: 0x7E7FB48
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(4, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class HideMonoScriptAttribute : Attribute // TypeDefIndex: 26675
{
	// Methods

	// RVA: 0x7E7FB50 Offset: 0x7E7BB50 VA: 0x7E7FB50
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(4, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class HideNetworkBehaviourFieldsAttribute : Attribute // TypeDefIndex: 26676
{
	// Methods

	// RVA: 0x7E7FB58 Offset: 0x7E7BB58 VA: 0x7E7FB58
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class HideReferenceObjectPickerAttribute : Attribute // TypeDefIndex: 26677
{
	// Methods

	// RVA: 0x7E7FB60 Offset: 0x7E7BB60 VA: 0x7E7FB60
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public class HorizontalGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26678
{
	// Fields
	private const int DefaultHorizontalGroupGap = 3;
	public float Width; // 0x34
	public float MarginLeft; // 0x38
	public float MarginRight; // 0x3C
	public float PaddingLeft; // 0x40
	public float PaddingRight; // 0x44
	public float MinWidth; // 0x48
	public float MaxWidth; // 0x4C
	public float Gap; // 0x50
	public string Title; // 0x58
	public bool DisableAutomaticLabelWidth; // 0x60
	public float LabelWidth; // 0x64

	// Methods

	// RVA: 0x7E7FB68 Offset: 0x7E7BB68 VA: 0x7E7FB68
	public void .ctor(string group, float width = 0, int marginLeft = 0, int marginRight = 0, float order = 0) { }

	// RVA: 0x7E7FBB4 Offset: 0x7E7BBB4 VA: 0x7E7FBB4
	public void .ctor(float width = 0, int marginLeft = 0, int marginRight = 0, float order = 0) { }

	// RVA: 0x7E7FC3C Offset: 0x7E7BC3C VA: 0x7E7FC3C Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[DontApplyToListElements]
public sealed class IndentAttribute : Attribute // TypeDefIndex: 26679
{
	// Fields
	public int IndentLevel; // 0x10

	// Methods

	// RVA: 0x7E7FD1C Offset: 0x7E7BD1C VA: 0x7E7FD1C
	public void .ctor(int indentLevel = 1) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class InfoBoxAttribute : Attribute // TypeDefIndex: 26680
{
	// Fields
	public string Message; // 0x10
	public InfoMessageType InfoMessageType; // 0x18
	public string VisibleIf; // 0x20
	public bool GUIAlwaysEnabled; // 0x28
	public string IconColor; // 0x30
	[CompilerGenerated]
	private bool <HasDefinedIcon>k__BackingField; // 0x38
	private SdfIconType icon; // 0x3C

	// Properties
	public SdfIconType Icon { get; set; }
	public bool HasDefinedIcon { get; set; }

	// Methods

	// RVA: 0x7E7FD44 Offset: 0x7E7BD44 VA: 0x7E7FD44
	public SdfIconType get_Icon() { }

	// RVA: 0x7E7FD4C Offset: 0x7E7BD4C VA: 0x7E7FD4C
	public void set_Icon(SdfIconType value) { }

	[CompilerGenerated]
	// RVA: 0x7E7FD5C Offset: 0x7E7BD5C VA: 0x7E7FD5C
	public bool get_HasDefinedIcon() { }

	[CompilerGenerated]
	// RVA: 0x7E7FD64 Offset: 0x7E7BD64 VA: 0x7E7FD64
	private void set_HasDefinedIcon(bool value) { }

	// RVA: 0x7E7FD70 Offset: 0x7E7BD70 VA: 0x7E7FD70
	public void .ctor(string message, InfoMessageType infoMessageType = 1, string visibleIfMemberName) { }

	// RVA: 0x7E7FDC4 Offset: 0x7E7BDC4 VA: 0x7E7FDC4
	public void .ctor(string message, string visibleIfMemberName) { }

	// RVA: 0x7E7FE10 Offset: 0x7E7BE10 VA: 0x7E7FE10
	public void .ctor(string message, SdfIconType icon, string visibleIfMemberName) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class InlineButtonAttribute : Attribute // TypeDefIndex: 26681
{
	// Fields
	public string Action; // 0x10
	public string Label; // 0x18
	public string ShowIf; // 0x20
	public string ButtonColor; // 0x28
	public string TextColor; // 0x30
	public SdfIconType Icon; // 0x38
	public IconAlignment IconAlignment; // 0x3C

	// Properties
	[Obsolete("Use the Action member instead.", False)]
	public string MemberMethod { get; set; }

	// Methods

	// RVA: 0x7E7FE74 Offset: 0x7E7BE74 VA: 0x7E7FE74
	public string get_MemberMethod() { }

	// RVA: 0x7E7FE7C Offset: 0x7E7BE7C VA: 0x7E7FE7C
	public void set_MemberMethod(string value) { }

	// RVA: 0x7E7FE84 Offset: 0x7E7BE84 VA: 0x7E7FE84
	public void .ctor(string action, string label) { }

	// RVA: 0x7E7FEC8 Offset: 0x7E7BEC8 VA: 0x7E7FEC8
	public void .ctor(string action, SdfIconType icon, string label) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class InlineEditorAttribute : Attribute // TypeDefIndex: 26682
{
	// Fields
	private bool expanded; // 0x10
	public bool DrawHeader; // 0x11
	public bool DrawGUI; // 0x12
	public bool DrawPreview; // 0x13
	public float MaxHeight; // 0x14
	public float PreviewWidth; // 0x18
	public float PreviewHeight; // 0x1C
	public bool IncrementInlineEditorDrawerDepth; // 0x20
	public InlineEditorObjectFieldModes ObjectFieldMode; // 0x24
	public bool DisableGUIForVCSLockedAssets; // 0x28
	public PreviewAlignment PreviewAlignment; // 0x2C
	[CompilerGenerated]
	private bool <ExpandedHasValue>k__BackingField; // 0x30

	// Properties
	public bool Expanded { get; set; }
	public bool ExpandedHasValue { get; set; }

	// Methods

	// RVA: 0x7E7FF1C Offset: 0x7E7BF1C VA: 0x7E7FF1C
	public bool get_Expanded() { }

	// RVA: 0x7E7FF24 Offset: 0x7E7BF24 VA: 0x7E7FF24
	public void set_Expanded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E7FF38 Offset: 0x7E7BF38 VA: 0x7E7FF38
	public bool get_ExpandedHasValue() { }

	[CompilerGenerated]
	// RVA: 0x7E7FF40 Offset: 0x7E7BF40 VA: 0x7E7FF40
	private void set_ExpandedHasValue(bool value) { }

	// RVA: 0x7E7FF4C Offset: 0x7E7BF4C VA: 0x7E7FF4C
	public void .ctor(InlineEditorModes inlineEditorMode = 0, InlineEditorObjectFieldModes objectFieldMode = 0) { }

	// RVA: 0x7E80048 Offset: 0x7E7C048 VA: 0x7E80048
	public void .ctor(InlineEditorObjectFieldModes objectFieldMode) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public class InlinePropertyAttribute : Attribute // TypeDefIndex: 26683
{
	// Fields
	public int LabelWidth; // 0x10

	// Methods

	// RVA: 0x7E80090 Offset: 0x7E7C090 VA: 0x7E80090
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class LabelTextAttribute : Attribute // TypeDefIndex: 26684
{
	// Fields
	public string Text; // 0x10
	public bool NicifyText; // 0x18
	public SdfIconType Icon; // 0x1C
	public string IconColor; // 0x20

	// Methods

	// RVA: 0x7E80098 Offset: 0x7E7C098 VA: 0x7E80098
	public void .ctor(string text) { }

	// RVA: 0x7E800C8 Offset: 0x7E7C0C8 VA: 0x7E800C8
	public void .ctor(SdfIconType icon) { }

	// RVA: 0x7E800F0 Offset: 0x7E7C0F0 VA: 0x7E800F0
	public void .ctor(string text, bool nicifyText) { }

	// RVA: 0x7E8012C Offset: 0x7E7C12C VA: 0x7E8012C
	public void .ctor(string text, SdfIconType icon) { }

	// RVA: 0x7E80168 Offset: 0x7E7C168 VA: 0x7E80168
	public void .ctor(string text, bool nicifyText, SdfIconType icon) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class LabelWidthAttribute : Attribute // TypeDefIndex: 26685
{
	// Fields
	public float Width; // 0x10

	// Methods

	// RVA: 0x7E801B4 Offset: 0x7E7C1B4 VA: 0x7E801B4
	public void .ctor(float width) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class ListDrawerSettingsAttribute : Attribute // TypeDefIndex: 26686
{
	// Fields
	public bool HideAddButton; // 0x10
	public bool HideRemoveButton; // 0x11
	public string ListElementLabelName; // 0x18
	public string CustomAddFunction; // 0x20
	public string CustomRemoveIndexFunction; // 0x28
	public string CustomRemoveElementFunction; // 0x30
	public string OnBeginListElementGUI; // 0x38
	public string OnEndListElementGUI; // 0x40
	public bool AlwaysAddDefaultValue; // 0x48
	public bool AddCopiesLastElement; // 0x49
	public string ElementColor; // 0x50
	private string onTitleBarGUI; // 0x58
	private int numberOfItemsPerPage; // 0x60
	private bool paging; // 0x64
	private bool draggable; // 0x65
	private bool isReadOnly; // 0x66
	private bool showItemCount; // 0x67
	private bool pagingHasValue; // 0x68
	private bool draggableHasValue; // 0x69
	private bool isReadOnlyHasValue; // 0x6A
	private bool showItemCountHasValue; // 0x6B
	private bool numberOfItemsPerPageHasValue; // 0x6C
	private bool showIndexLabels; // 0x6D
	private bool showIndexLabelsHasValue; // 0x6E
	private bool defaultExpandedStateHasValue; // 0x6F
	private bool defaultExpandedState; // 0x70
	public bool ShowFoldout; // 0x71

	// Properties
	public bool ShowPaging { get; set; }
	public bool DraggableItems { get; set; }
	public int NumberOfItemsPerPage { get; set; }
	public bool IsReadOnly { get; set; }
	public bool ShowItemCount { get; set; }
	[Obsolete("Use ShowFoldout instead, which is what Expanded has always done. If you want to control the default expanded state, use DefaultExpandedState. Expanded has been implemented wrong for a long time.")]
	public bool Expanded { get; set; }
	public bool DefaultExpandedState { get; set; }
	public bool ShowIndexLabels { get; set; }
	public string OnTitleBarGUI { get; set; }
	public bool PagingHasValue { get; }
	public bool ShowItemCountHasValue { get; }
	public bool NumberOfItemsPerPageHasValue { get; }
	public bool DraggableHasValue { get; }
	public bool IsReadOnlyHasValue { get; }
	public bool ShowIndexLabelsHasValue { get; }
	public bool DefaultExpandedStateHasValue { get; }

	// Methods

	// RVA: 0x7E801DC Offset: 0x7E7C1DC VA: 0x7E801DC
	public bool get_ShowPaging() { }

	// RVA: 0x7E801E4 Offset: 0x7E7C1E4 VA: 0x7E801E4
	public void set_ShowPaging(bool value) { }

	// RVA: 0x7E801F8 Offset: 0x7E7C1F8 VA: 0x7E801F8
	public bool get_DraggableItems() { }

	// RVA: 0x7E80200 Offset: 0x7E7C200 VA: 0x7E80200
	public void set_DraggableItems(bool value) { }

	// RVA: 0x7E80214 Offset: 0x7E7C214 VA: 0x7E80214
	public int get_NumberOfItemsPerPage() { }

	// RVA: 0x7E8021C Offset: 0x7E7C21C VA: 0x7E8021C
	public void set_NumberOfItemsPerPage(int value) { }

	// RVA: 0x7E8022C Offset: 0x7E7C22C VA: 0x7E8022C
	public bool get_IsReadOnly() { }

	// RVA: 0x7E80234 Offset: 0x7E7C234 VA: 0x7E80234
	public void set_IsReadOnly(bool value) { }

	// RVA: 0x7E80248 Offset: 0x7E7C248 VA: 0x7E80248
	public bool get_ShowItemCount() { }

	// RVA: 0x7E80250 Offset: 0x7E7C250 VA: 0x7E80250
	public void set_ShowItemCount(bool value) { }

	// RVA: 0x7E80264 Offset: 0x7E7C264 VA: 0x7E80264
	public bool get_Expanded() { }

	// RVA: 0x7E80274 Offset: 0x7E7C274 VA: 0x7E80274
	public void set_Expanded(bool value) { }

	// RVA: 0x7E80284 Offset: 0x7E7C284 VA: 0x7E80284
	public bool get_DefaultExpandedState() { }

	// RVA: 0x7E8028C Offset: 0x7E7C28C VA: 0x7E8028C
	public void set_DefaultExpandedState(bool value) { }

	// RVA: 0x7E802A0 Offset: 0x7E7C2A0 VA: 0x7E802A0
	public bool get_ShowIndexLabels() { }

	// RVA: 0x7E802A8 Offset: 0x7E7C2A8 VA: 0x7E802A8
	public void set_ShowIndexLabels(bool value) { }

	// RVA: 0x7E802BC Offset: 0x7E7C2BC VA: 0x7E802BC
	public string get_OnTitleBarGUI() { }

	// RVA: 0x7E802C4 Offset: 0x7E7C2C4 VA: 0x7E802C4
	public void set_OnTitleBarGUI(string value) { }

	// RVA: 0x7E802CC Offset: 0x7E7C2CC VA: 0x7E802CC
	public bool get_PagingHasValue() { }

	// RVA: 0x7E802D4 Offset: 0x7E7C2D4 VA: 0x7E802D4
	public bool get_ShowItemCountHasValue() { }

	// RVA: 0x7E802DC Offset: 0x7E7C2DC VA: 0x7E802DC
	public bool get_NumberOfItemsPerPageHasValue() { }

	// RVA: 0x7E802E4 Offset: 0x7E7C2E4 VA: 0x7E802E4
	public bool get_DraggableHasValue() { }

	// RVA: 0x7E802EC Offset: 0x7E7C2EC VA: 0x7E802EC
	public bool get_IsReadOnlyHasValue() { }

	// RVA: 0x7E802F4 Offset: 0x7E7C2F4 VA: 0x7E802F4
	public bool get_ShowIndexLabelsHasValue() { }

	// RVA: 0x7E802FC Offset: 0x7E7C2FC VA: 0x7E802FC
	public bool get_DefaultExpandedStateHasValue() { }

	// RVA: 0x7E80304 Offset: 0x7E7C304 VA: 0x7E80304
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MaxValueAttribute : Attribute // TypeDefIndex: 26687
{
	// Fields
	public double MaxValue; // 0x10
	public string Expression; // 0x18

	// Methods

	// RVA: 0x7E80314 Offset: 0x7E7C314 VA: 0x7E80314
	public void .ctor(double maxValue) { }

	// RVA: 0x7E8033C Offset: 0x7E7C33C VA: 0x7E8033C
	public void .ctor(string expression) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MinMaxSliderAttribute : Attribute // TypeDefIndex: 26688
{
	// Fields
	public float MinValue; // 0x10
	public float MaxValue; // 0x14
	public string MinValueGetter; // 0x18
	public string MaxValueGetter; // 0x20
	public string MinMaxValueGetter; // 0x28
	public bool ShowFields; // 0x30

	// Properties
	[Obsolete("Use the MinValueGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string MinMember { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use the MaxValueGetter member instead.", False)]
	public string MaxMember { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use the MinMaxValueGetter member instead.", False)]
	public string MinMaxMember { get; set; }

	// Methods

	// RVA: 0x7E8036C Offset: 0x7E7C36C VA: 0x7E8036C
	public string get_MinMember() { }

	// RVA: 0x7E80374 Offset: 0x7E7C374 VA: 0x7E80374
	public void set_MinMember(string value) { }

	// RVA: 0x7E8037C Offset: 0x7E7C37C VA: 0x7E8037C
	public string get_MaxMember() { }

	// RVA: 0x7E80384 Offset: 0x7E7C384 VA: 0x7E80384
	public void set_MaxMember(string value) { }

	// RVA: 0x7E8038C Offset: 0x7E7C38C VA: 0x7E8038C
	public string get_MinMaxMember() { }

	// RVA: 0x7E80394 Offset: 0x7E7C394 VA: 0x7E80394
	public void set_MinMaxMember(string value) { }

	// RVA: 0x7E8039C Offset: 0x7E7C39C VA: 0x7E8039C
	public void .ctor(float minValue, float maxValue, bool showFields = False) { }

	// RVA: 0x7E803D8 Offset: 0x7E7C3D8 VA: 0x7E803D8
	public void .ctor(string minValueGetter, float maxValue, bool showFields = False) { }

	// RVA: 0x7E80424 Offset: 0x7E7C424 VA: 0x7E80424
	public void .ctor(float minValue, string maxValueGetter, bool showFields = False) { }

	// RVA: 0x7E80470 Offset: 0x7E7C470 VA: 0x7E80470
	public void .ctor(string minValueGetter, string maxValueGetter, bool showFields = False) { }

	// RVA: 0x7E804C8 Offset: 0x7E7C4C8 VA: 0x7E804C8
	public void .ctor(string minMaxValueGetter, bool showFields = False) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MinValueAttribute : Attribute // TypeDefIndex: 26689
{
	// Fields
	public double MinValue; // 0x10
	public string Expression; // 0x18

	// Methods

	// RVA: 0x7E80504 Offset: 0x7E7C504 VA: 0x7E80504
	public void .ctor(double minValue) { }

	// RVA: 0x7E8052C Offset: 0x7E7C52C VA: 0x7E8052C
	public void .ctor(string expression) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MultiLinePropertyAttribute : Attribute // TypeDefIndex: 26690
{
	// Fields
	public int Lines; // 0x10

	// Methods

	// RVA: 0x7E8055C Offset: 0x7E7C55C VA: 0x7E8055C
	public void .ctor(int lines = 3) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class OnCollectionChangedAttribute : Attribute // TypeDefIndex: 26691
{
	// Fields
	public string Before; // 0x10
	public string After; // 0x18

	// Methods

	// RVA: 0x7E805D8 Offset: 0x7E7C5D8 VA: 0x7E805D8
	public void .ctor() { }

	// RVA: 0x7E805E0 Offset: 0x7E7C5E0 VA: 0x7E805E0
	public void .ctor(string after) { }

	// RVA: 0x7E80610 Offset: 0x7E7C610 VA: 0x7E80610
	public void .ctor(string before, string after) { }
}

// Namespace: Sirenix.OdinInspector
[IncludeMys]
[Usage(32767, AllowMultiple = True, Inherited = False)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[HideInTables]
public class OnInspectorDisposeAttribute : ShowInInspectorAttribute // TypeDefIndex: 26692
{
	// Fields
	public string Action; // 0x10

	// Methods

	// RVA: 0x7E80654 Offset: 0x7E7C654 VA: 0x7E80654
	public void .ctor() { }

	// RVA: 0x7E8065C Offset: 0x7E7C65C VA: 0x7E8065C
	public void .ctor(string action) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute // TypeDefIndex: 26693
{
	// Fields
	public string Prepend; // 0x10
	public string Append; // 0x18
	[EditorBrowsable(1)]
	[Obsolete("Use the Prepend member instead.", False)]
	public string PrependMethodName; // 0x20
	[EditorBrowsable(1)]
	[Obsolete("Use the Append member instead.", False)]
	public string AppendMethodName; // 0x28

	// Methods

	// RVA: 0x7E8068C Offset: 0x7E7C68C VA: 0x7E8068C
	public void .ctor() { }

	// RVA: 0x7E80694 Offset: 0x7E7C694 VA: 0x7E80694
	public void .ctor(string action, bool append = True) { }

	// RVA: 0x7E806E0 Offset: 0x7E7C6E0 VA: 0x7E806E0
	public void .ctor(string prepend, string append) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = False)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[IncludeMys]
[HideInTables]
public class OnInspectorInitAttribute : ShowInInspectorAttribute // TypeDefIndex: 26694
{
	// Fields
	public string Action; // 0x10

	// Methods

	// RVA: 0x7E80724 Offset: 0x7E7C724 VA: 0x7E80724
	public void .ctor() { }

	// RVA: 0x7E8072C Offset: 0x7E7C72C VA: 0x7E8072C
	public void .ctor(string action) { }
}

// Namespace: Sirenix.OdinInspector
[HideInTables]
[DontApplyToListElements]
[IncludeMys]
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class OnStateUpdateAttribute : Attribute // TypeDefIndex: 26695
{
	// Fields
	public string Action; // 0x10

	// Methods

	// RVA: 0x7E8075C Offset: 0x7E7C75C VA: 0x7E8075C
	public void .ctor(string action) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
public sealed class OnValueChangedAttribute : Attribute // TypeDefIndex: 26696
{
	// Fields
	public string Action; // 0x10
	public bool IncludeChildren; // 0x18
	public bool InvokeOnUndoRedo; // 0x19
	public bool InvokeOnInitialize; // 0x1A

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Use the Action member instead.", False)]
	public string MethodName { get; set; }

	// Methods

	// RVA: 0x7E8078C Offset: 0x7E7C78C VA: 0x7E8078C
	public string get_MethodName() { }

	// RVA: 0x7E80794 Offset: 0x7E7C794 VA: 0x7E80794
	public void set_MethodName(string value) { }

	// RVA: 0x7E8079C Offset: 0x7E7C79C VA: 0x7E8079C
	public void .ctor(string action, bool includeChildren = False) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(384, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class OptionalAttribute : Attribute // TypeDefIndex: 26697
{
	// Methods

	// RVA: 0x7E807E0 Offset: 0x7E7C7E0 VA: 0x7E807E0
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class PreviewFieldAttribute : Attribute // TypeDefIndex: 26698
{
	// Fields
	private ObjectFieldAlignment alignment; // 0x10
	private bool alignmentHasValue; // 0x14
	private string previewGetter; // 0x18
	public float Height; // 0x20
	public FilterMode FilterMode; // 0x24
	[CompilerGenerated]
	private bool <PreviewGetterHasValue>k__BackingField; // 0x28

	// Properties
	public ObjectFieldAlignment Alignment { get; set; }
	public bool AlignmentHasValue { get; }
	public string PreviewGetter { get; set; }
	public bool PreviewGetterHasValue { get; set; }

	// Methods

	// RVA: 0x7E807E8 Offset: 0x7E7C7E8 VA: 0x7E807E8
	public ObjectFieldAlignment get_Alignment() { }

	// RVA: 0x7E807F0 Offset: 0x7E7C7F0 VA: 0x7E807F0
	public void set_Alignment(ObjectFieldAlignment value) { }

	// RVA: 0x7E80800 Offset: 0x7E7C800 VA: 0x7E80800
	public bool get_AlignmentHasValue() { }

	// RVA: 0x7E80808 Offset: 0x7E7C808 VA: 0x7E80808
	public string get_PreviewGetter() { }

	// RVA: 0x7E80810 Offset: 0x7E7C810 VA: 0x7E80810
	public void set_PreviewGetter(string value) { }

	[CompilerGenerated]
	// RVA: 0x7E80834 Offset: 0x7E7C834 VA: 0x7E80834
	public bool get_PreviewGetterHasValue() { }

	[CompilerGenerated]
	// RVA: 0x7E8083C Offset: 0x7E7C83C VA: 0x7E8083C
	private void set_PreviewGetterHasValue(bool value) { }

	// RVA: 0x7E80848 Offset: 0x7E7C848 VA: 0x7E80848
	public void .ctor() { }

	// RVA: 0x7E8086C Offset: 0x7E7C86C VA: 0x7E8086C
	public void .ctor(float height) { }

	// RVA: 0x7E8089C Offset: 0x7E7C89C VA: 0x7E8089C
	public void .ctor(string previewGetter, FilterMode filterMode = 1) { }

	// RVA: 0x7E808F0 Offset: 0x7E7C8F0 VA: 0x7E808F0
	public void .ctor(string previewGetter, float height, FilterMode filterMode = 1) { }

	// RVA: 0x7E80954 Offset: 0x7E7C954 VA: 0x7E80954
	public void .ctor(float height, ObjectFieldAlignment alignment) { }

	// RVA: 0x7E80998 Offset: 0x7E7C998 VA: 0x7E80998
	public void .ctor(string previewGetter, ObjectFieldAlignment alignment, FilterMode filterMode = 1) { }

	// RVA: 0x7E80A00 Offset: 0x7E7CA00 VA: 0x7E80A00
	public void .ctor(string previewGetter, float height, ObjectFieldAlignment alignment, FilterMode filterMode = 1) { }

	// RVA: 0x7E80A78 Offset: 0x7E7CA78 VA: 0x7E80A78
	public void .ctor(ObjectFieldAlignment alignment) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ProgressBarAttribute : Attribute // TypeDefIndex: 26699
{
	// Fields
	public double Min; // 0x10
	public double Max; // 0x18
	public string MinGetter; // 0x20
	public string MaxGetter; // 0x28
	public float R; // 0x30
	public float G; // 0x34
	public float B; // 0x38
	public int Height; // 0x3C
	public string ColorGetter; // 0x40
	public string BackgroundColorGetter; // 0x48
	public bool Segmented; // 0x50
	public string CustomValueStringGetter; // 0x58
	private bool drawValueLabel; // 0x60
	private TextAlignment valueLabelAlignment; // 0x64
	[CompilerGenerated]
	private bool <DrawValueLabelHasValue>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <ValueLabelAlignmentHasValue>k__BackingField; // 0x69

	// Properties
	[Obsolete("Use the MinGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string MinMember { get; set; }
	[Obsolete("Use the MaxGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string MaxMember { get; set; }
	[Obsolete("Use the ColorGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string ColorMember { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use the BackgroundColorGetter member instead.", False)]
	public string BackgroundColorMember { get; set; }
	[Obsolete("Use the CustomValueStringGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string CustomValueStringMember { get; set; }
	public bool DrawValueLabel { get; set; }
	public bool DrawValueLabelHasValue { get; set; }
	public TextAlignment ValueLabelAlignment { get; set; }
	public bool ValueLabelAlignmentHasValue { get; set; }
	public Color Color { get; }

	// Methods

	// RVA: 0x7E80AAC Offset: 0x7E7CAAC VA: 0x7E80AAC
	public string get_MinMember() { }

	// RVA: 0x7E80AB4 Offset: 0x7E7CAB4 VA: 0x7E80AB4
	public void set_MinMember(string value) { }

	// RVA: 0x7E80ABC Offset: 0x7E7CABC VA: 0x7E80ABC
	public string get_MaxMember() { }

	// RVA: 0x7E80AC4 Offset: 0x7E7CAC4 VA: 0x7E80AC4
	public void set_MaxMember(string value) { }

	// RVA: 0x7E80ACC Offset: 0x7E7CACC VA: 0x7E80ACC
	public string get_ColorMember() { }

	// RVA: 0x7E80AD4 Offset: 0x7E7CAD4 VA: 0x7E80AD4
	public void set_ColorMember(string value) { }

	// RVA: 0x7E80ADC Offset: 0x7E7CADC VA: 0x7E80ADC
	public string get_BackgroundColorMember() { }

	// RVA: 0x7E80AE4 Offset: 0x7E7CAE4 VA: 0x7E80AE4
	public void set_BackgroundColorMember(string value) { }

	// RVA: 0x7E80AEC Offset: 0x7E7CAEC VA: 0x7E80AEC
	public string get_CustomValueStringMember() { }

	// RVA: 0x7E80AF4 Offset: 0x7E7CAF4 VA: 0x7E80AF4
	public void set_CustomValueStringMember(string value) { }

	// RVA: 0x7E80AFC Offset: 0x7E7CAFC VA: 0x7E80AFC
	public void .ctor(double min, double max, float r = 0.15, float g = 0.47, float b = 0.74) { }

	// RVA: 0x7E80B68 Offset: 0x7E7CB68 VA: 0x7E80B68
	public void .ctor(string minGetter, double max, float r = 0.15, float g = 0.47, float b = 0.74) { }

	// RVA: 0x7E80BE4 Offset: 0x7E7CBE4 VA: 0x7E80BE4
	public void .ctor(double min, string maxGetter, float r = 0.15, float g = 0.47, float b = 0.74) { }

	// RVA: 0x7E80C60 Offset: 0x7E7CC60 VA: 0x7E80C60
	public void .ctor(string minGetter, string maxGetter, float r = 0.15, float g = 0.47, float b = 0.74) { }

	// RVA: 0x7E80CE8 Offset: 0x7E7CCE8 VA: 0x7E80CE8
	public bool get_DrawValueLabel() { }

	// RVA: 0x7E80CF0 Offset: 0x7E7CCF0 VA: 0x7E80CF0
	public void set_DrawValueLabel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7E80D04 Offset: 0x7E7CD04 VA: 0x7E80D04
	public bool get_DrawValueLabelHasValue() { }

	[CompilerGenerated]
	// RVA: 0x7E80D0C Offset: 0x7E7CD0C VA: 0x7E80D0C
	private void set_DrawValueLabelHasValue(bool value) { }

	// RVA: 0x7E80D18 Offset: 0x7E7CD18 VA: 0x7E80D18
	public TextAlignment get_ValueLabelAlignment() { }

	// RVA: 0x7E80D20 Offset: 0x7E7CD20 VA: 0x7E80D20
	public void set_ValueLabelAlignment(TextAlignment value) { }

	[CompilerGenerated]
	// RVA: 0x7E80D30 Offset: 0x7E7CD30 VA: 0x7E80D30
	public bool get_ValueLabelAlignmentHasValue() { }

	[CompilerGenerated]
	// RVA: 0x7E80D38 Offset: 0x7E7CD38 VA: 0x7E80D38
	private void set_ValueLabelAlignmentHasValue(bool value) { }

	// RVA: 0x7E80D44 Offset: 0x7E7CD44 VA: 0x7E80D44
	public Color get_Color() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public abstract class PropertyGroupAttribute : Attribute // TypeDefIndex: 26700
{
	// Fields
	public string GroupID; // 0x10
	public string GroupName; // 0x18
	public float Order; // 0x20
	public bool HideWhenChildrenAreInvisible; // 0x24
	public string VisibleIf; // 0x28
	public bool AnimateVisibility; // 0x30

	// Methods

	// RVA: 0x7E7E8C0 Offset: 0x7E7A8C0 VA: 0x7E7E8C0
	public void .ctor(string groupId, float order) { }

	// RVA: 0x7E7F9FC Offset: 0x7E7B9FC VA: 0x7E7F9FC
	public void .ctor(string groupId) { }

	// RVA: 0x7E80D54 Offset: 0x7E7CD54 VA: 0x7E80D54
	public PropertyGroupAttribute Combine(PropertyGroupAttribute other) { }

	// RVA: 0x7E80F50 Offset: 0x7E7CF50 VA: 0x7E80F50 Slot: 11
	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class PropertyOrderAttribute : Attribute // TypeDefIndex: 26701
{
	// Fields
	public float Order; // 0x10

	// Methods

	// RVA: 0x7E80F54 Offset: 0x7E7CF54 VA: 0x7E80F54
	public void .ctor() { }

	// RVA: 0x7E80F5C Offset: 0x7E7CF5C VA: 0x7E80F5C
	public void .ctor(float order) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class PropertyRangeAttribute : Attribute // TypeDefIndex: 26702
{
	// Fields
	public double Min; // 0x10
	public double Max; // 0x18
	public string MinGetter; // 0x20
	public string MaxGetter; // 0x28

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Use the MinGetter member instead.", False)]
	public string MinMember { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use the MaxGetter member instead.", False)]
	public string MaxMember { get; set; }

	// Methods

	// RVA: 0x7E80F84 Offset: 0x7E7CF84 VA: 0x7E80F84
	public string get_MinMember() { }

	// RVA: 0x7E80F8C Offset: 0x7E7CF8C VA: 0x7E80F8C
	public void set_MinMember(string value) { }

	// RVA: 0x7E80F94 Offset: 0x7E7CF94 VA: 0x7E80F94
	public string get_MaxMember() { }

	// RVA: 0x7E80F9C Offset: 0x7E7CF9C VA: 0x7E80F9C
	public void set_MaxMember(string value) { }

	// RVA: 0x7E80FA4 Offset: 0x7E7CFA4 VA: 0x7E80FA4
	public void .ctor(double min, double max) { }

	// RVA: 0x7E80FE4 Offset: 0x7E7CFE4 VA: 0x7E80FE4
	public void .ctor(string minGetter, double max) { }

	// RVA: 0x7E81028 Offset: 0x7E7D028 VA: 0x7E81028
	public void .ctor(double min, string maxGetter) { }

	// RVA: 0x7E81068 Offset: 0x7E7D068 VA: 0x7E81068
	public void .ctor(string minGetter, string maxGetter) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class PropertySpaceAttribute : Attribute // TypeDefIndex: 26703
{
	// Fields
	public float SpaceBefore; // 0x10
	public float SpaceAfter; // 0x14

	// Methods

	// RVA: 0x7E810AC Offset: 0x7E7D0AC VA: 0x7E810AC
	public void .ctor() { }

	// RVA: 0x7E810D0 Offset: 0x7E7D0D0 VA: 0x7E810D0
	public void .ctor(float spaceBefore) { }

	// RVA: 0x7E810FC Offset: 0x7E7D0FC VA: 0x7E810FC
	public void .ctor(float spaceBefore, float spaceAfter) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class PropertyTooltipAttribute : Attribute // TypeDefIndex: 26704
{
	// Fields
	public string Tooltip; // 0x10

	// Methods

	// RVA: 0x7E81128 Offset: 0x7E7D128 VA: 0x7E81128
	public void .ctor(string tooltip) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 26705
{
	// Methods

	// RVA: 0x7E81158 Offset: 0x7E7D158 VA: 0x7E81158
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class RequiredAttribute : Attribute // TypeDefIndex: 26706
{
	// Fields
	public string ErrorMessage; // 0x10
	public InfoMessageType MessageType; // 0x18

	// Methods

	// RVA: 0x7E81160 Offset: 0x7E7D160 VA: 0x7E81160
	public void .ctor() { }

	// RVA: 0x7E81180 Offset: 0x7E7D180 VA: 0x7E81180
	public void .ctor(string errorMessage, InfoMessageType messageType) { }

	// RVA: 0x7E811BC Offset: 0x7E7D1BC VA: 0x7E811BC
	public void .ctor(string errorMessage) { }

	// RVA: 0x7E811F8 Offset: 0x7E7D1F8 VA: 0x7E811F8
	public void .ctor(InfoMessageType messageType) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class RequiredInAttribute : Attribute // TypeDefIndex: 26707
{
	// Fields
	public string ErrorMessage; // 0x10
	public PrefabKind PrefabKind; // 0x18

	// Methods

	// RVA: 0x7E81220 Offset: 0x7E7D220 VA: 0x7E81220
	public void .ctor(PrefabKind kind) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Obsolete("Use [RequiredIn(PrefabKind.PrefabAsset)] instead.", True)]
[EditorBrowsable(1)]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class RequiredInPrefabAssetsAttribute : Attribute // TypeDefIndex: 26708
{
	// Fields
	public string ErrorMessage; // 0x10
	public InfoMessageType MessageType; // 0x18

	// Methods

	// RVA: 0x7E81248 Offset: 0x7E7D248 VA: 0x7E81248
	public void .ctor() { }

	// RVA: 0x7E81268 Offset: 0x7E7D268 VA: 0x7E81268
	public void .ctor(string errorMessage, InfoMessageType messageType) { }

	// RVA: 0x7E812A4 Offset: 0x7E7D2A4 VA: 0x7E812A4
	public void .ctor(string errorMessage) { }

	// RVA: 0x7E812E0 Offset: 0x7E7D2E0 VA: 0x7E812E0
	public void .ctor(InfoMessageType messageType) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(1)]
[Obsolete("Use [RequiredIn(PrefabKind.PrefabInstance)] instead.", True)]
public sealed class RequiredInPrefabInstancesAttribute : Attribute // TypeDefIndex: 26709
{
	// Fields
	public string ErrorMessage; // 0x10
	public InfoMessageType MessageType; // 0x18

	// Methods

	// RVA: 0x7E81308 Offset: 0x7E7D308 VA: 0x7E81308
	public void .ctor() { }

	// RVA: 0x7E81328 Offset: 0x7E7D328 VA: 0x7E81328
	public void .ctor(string errorMessage, InfoMessageType messageType) { }

	// RVA: 0x7E81364 Offset: 0x7E7D364 VA: 0x7E81364
	public void .ctor(string errorMessage) { }

	// RVA: 0x7E813A0 Offset: 0x7E7D3A0 VA: 0x7E813A0
	public void .ctor(InfoMessageType messageType) { }
}

// Namespace: Sirenix.OdinInspector
public sealed class RequiredListLengthAttribute : Attribute // TypeDefIndex: 26710
{
	// Fields
	private PrefabKind prefabKind; // 0x10
	private bool prefabKindIsSet; // 0x14
	private int minLength; // 0x18
	private int maxLength; // 0x1C
	private bool minLengthIsSet; // 0x20
	private bool maxLengthIsSet; // 0x21
	public string MinLengthGetter; // 0x28
	public string MaxLengthGetter; // 0x30

	// Properties
	public int MinLength { get; set; }
	public int MaxLength { get; set; }
	public bool MinLengthIsSet { get; }
	public bool MaxLengthIsSet { get; }
	public bool PrefabKindIsSet { get; }
	public PrefabKind PrefabKind { get; set; }

	// Methods

	// RVA: 0x7E813C8 Offset: 0x7E7D3C8 VA: 0x7E813C8
	public int get_MinLength() { }

	// RVA: 0x7E813D0 Offset: 0x7E7D3D0 VA: 0x7E813D0
	public void set_MinLength(int value) { }

	// RVA: 0x7E813E0 Offset: 0x7E7D3E0 VA: 0x7E813E0
	public int get_MaxLength() { }

	// RVA: 0x7E813E8 Offset: 0x7E7D3E8 VA: 0x7E813E8
	public void set_MaxLength(int value) { }

	// RVA: 0x7E813F8 Offset: 0x7E7D3F8 VA: 0x7E813F8
	public bool get_MinLengthIsSet() { }

	// RVA: 0x7E81400 Offset: 0x7E7D400 VA: 0x7E81400
	public bool get_MaxLengthIsSet() { }

	// RVA: 0x7E81408 Offset: 0x7E7D408 VA: 0x7E81408
	public bool get_PrefabKindIsSet() { }

	// RVA: 0x7E81410 Offset: 0x7E7D410 VA: 0x7E81410
	public PrefabKind get_PrefabKind() { }

	// RVA: 0x7E81418 Offset: 0x7E7D418 VA: 0x7E81418
	public void set_PrefabKind(PrefabKind value) { }

	// RVA: 0x7E81428 Offset: 0x7E7D428 VA: 0x7E81428
	public void .ctor() { }

	// RVA: 0x7E81430 Offset: 0x7E7D430 VA: 0x7E81430
	public void .ctor(int fixedLength) { }

	// RVA: 0x7E81460 Offset: 0x7E7D460 VA: 0x7E81460
	public void .ctor(int minLength, int maxLength) { }

	// RVA: 0x7E81494 Offset: 0x7E7D494 VA: 0x7E81494
	public void .ctor(int minLength, string maxLengthGetter) { }

	// RVA: 0x7E814D4 Offset: 0x7E7D4D4 VA: 0x7E814D4
	public void .ctor(string fixedLengthGetter) { }

	// RVA: 0x7E81514 Offset: 0x7E7D514 VA: 0x7E81514
	public void .ctor(string minLengthGetter, string maxLengthGetter) { }

	// RVA: 0x7E81558 Offset: 0x7E7D558 VA: 0x7E81558
	public void .ctor(string minLengthGetter, int maxLength) { }
}

// Namespace: Sirenix.OdinInspector
[IncludeMys]
[ShowInInspector]
[Usage(64, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26711
{
	// Fields
	public ButtonSizes DefaultButtonSize; // 0x34
	public bool UniformLayout; // 0x38

	// Methods

	// RVA: 0x7E8159C Offset: 0x7E7D59C VA: 0x7E8159C
	public void .ctor(string group = "_DefaultResponsiveButtonGroup") { }

	// RVA: 0x7E815AC Offset: 0x7E7D5AC VA: 0x7E815AC Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class SceneObjectsOnlyAttribute : Attribute // TypeDefIndex: 26712
{
	// Methods

	// RVA: 0x7E81668 Offset: 0x7E7D668 VA: 0x7E81668
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
public class SearchableAttribute : Attribute // TypeDefIndex: 26713
{
	// Fields
	public bool FuzzySearch; // 0x10
	public SearchFilterOptions FilterOptions; // 0x14
	public bool Recursive; // 0x18

	// Methods

	// RVA: 0x7E81670 Offset: 0x7E7D670 VA: 0x7E81670
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767)]
[Conditional("UNITY_EDITOR")]
public class ShowDrawerChainAttribute : Attribute // TypeDefIndex: 26714
{
	// Methods

	// RVA: 0x7E8168C Offset: 0x7E7D68C VA: 0x7E8168C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ShowIfAttribute : Attribute // TypeDefIndex: 26715
{
	// Fields
	public string Condition; // 0x10
	public object Value; // 0x18
	public bool Animate; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E81694 Offset: 0x7E7D694 VA: 0x7E81694
	public string get_MemberName() { }

	// RVA: 0x7E8169C Offset: 0x7E7D69C VA: 0x7E8169C
	public void set_MemberName(string value) { }

	// RVA: 0x7E816A4 Offset: 0x7E7D6A4 VA: 0x7E816A4
	public void .ctor(string condition, bool animate = True) { }

	// RVA: 0x7E816E0 Offset: 0x7E7D6E0 VA: 0x7E816E0
	public void .ctor(string condition, object optionalValue, bool animate = True) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class ShowIfGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26716
{
	// Fields
	public object Value; // 0x38

	// Properties
	public bool Animate { get; set; }
	[Obsolete("Use the Condition member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }
	public string Condition { get; set; }

	// Methods

	// RVA: 0x7E81738 Offset: 0x7E7D738 VA: 0x7E81738
	public bool get_Animate() { }

	// RVA: 0x7E81740 Offset: 0x7E7D740 VA: 0x7E81740
	public void set_Animate(bool value) { }

	// RVA: 0x7E8174C Offset: 0x7E7D74C VA: 0x7E8174C
	public string get_MemberName() { }

	// RVA: 0x7E817AC Offset: 0x7E7D7AC VA: 0x7E817AC
	public void set_MemberName(string value) { }

	// RVA: 0x7E8177C Offset: 0x7E7D77C VA: 0x7E8177C
	public string get_Condition() { }

	// RVA: 0x7E817B4 Offset: 0x7E7D7B4 VA: 0x7E817B4
	public void set_Condition(string value) { }

	// RVA: 0x7E817BC Offset: 0x7E7D7BC VA: 0x7E817BC
	public void .ctor(string path, bool animate = True) { }

	// RVA: 0x7E817E8 Offset: 0x7E7D7E8 VA: 0x7E817E8
	public void .ctor(string path, object value, bool animate = True) { }

	// RVA: 0x7E81828 Offset: 0x7E7D828 VA: 0x7E81828 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class ShowInAttribute : Attribute // TypeDefIndex: 26717
{
	// Fields
	public PrefabKind PrefabKind; // 0x10

	// Methods

	// RVA: 0x7E818C4 Offset: 0x7E7D8C4 VA: 0x7E818C4
	public void .ctor(PrefabKind prefabKind) { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Conditional("UNITY_EDITOR")]
[Usage(32767)]
public class ShowInInlineEditorsAttribute : Attribute // TypeDefIndex: 26718
{
	// Methods

	// RVA: 0x7E818EC Offset: 0x7E7D8EC VA: 0x7E818EC
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[MeansImplicitUse]
[Usage(32767, AllowMultiple = False, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public class ShowInInspectorAttribute : Attribute // TypeDefIndex: 26719
{
	// Methods

	// RVA: 0x7E7EB7C Offset: 0x7E7AB7C VA: 0x7E7EB7C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(4, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class ShowOdinSerializedPropertiesInInspectorAttribute : Attribute // TypeDefIndex: 26720
{
	// Methods

	// RVA: 0x7E818F4 Offset: 0x7E7D8F4 VA: 0x7E818F4
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
public class ShowPropertyResolverAttribute : Attribute // TypeDefIndex: 26721
{
	// Methods

	// RVA: 0x7E818FC Offset: 0x7E7D8FC VA: 0x7E818FC
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public sealed class SuffixLabelAttribute : Attribute // TypeDefIndex: 26722
{
	// Fields
	public string Label; // 0x10
	public bool Overlay; // 0x18
	public string IconColor; // 0x20
	[CompilerGenerated]
	private bool <HasDefinedIcon>k__BackingField; // 0x28
	private SdfIconType icon; // 0x2C

	// Properties
	public SdfIconType Icon { get; set; }
	public bool HasDefinedIcon { get; set; }

	// Methods

	// RVA: 0x7E81904 Offset: 0x7E7D904 VA: 0x7E81904
	public SdfIconType get_Icon() { }

	// RVA: 0x7E8190C Offset: 0x7E7D90C VA: 0x7E8190C
	public void set_Icon(SdfIconType value) { }

	[CompilerGenerated]
	// RVA: 0x7E8191C Offset: 0x7E7D91C VA: 0x7E8191C
	public bool get_HasDefinedIcon() { }

	[CompilerGenerated]
	// RVA: 0x7E81924 Offset: 0x7E7D924 VA: 0x7E81924
	private void set_HasDefinedIcon(bool value) { }

	// RVA: 0x7E81930 Offset: 0x7E7D930 VA: 0x7E81930
	public void .ctor(string label, bool overlay = False) { }

	// RVA: 0x7E8196C Offset: 0x7E7D96C VA: 0x7E8196C
	public void .ctor(string label, SdfIconType icon, bool overlay = False) { }

	// RVA: 0x7E819C0 Offset: 0x7E7D9C0 VA: 0x7E819C0
	public void .ctor(SdfIconType icon) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class SuppressInvalidAttributeErrorAttribute : Attribute // TypeDefIndex: 26723
{
	// Methods

	// RVA: 0x7E819F0 Offset: 0x7E7D9F0 VA: 0x7E819F0
	public void .ctor() { }
}

// Namespace: 
[Conditional("UNITY_EDITOR")]
public class TabGroupAttribute.TabSubGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26724
{
	// Fields
	public TabGroupAttribute Tab; // 0x38

	// Methods

	// RVA: 0x7E82014 Offset: 0x7E7E014 VA: 0x7E82014
	public void .ctor(TabGroupAttribute tab, string groupId, float order) { }

	// RVA: 0x7E820E8 Offset: 0x7E7E0E8 VA: 0x7E820E8 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute // TypeDefIndex: 26725
{
	// Fields
	public const string DEFAULT_NAME = "_DefaultTabGroup";
	public string TabName; // 0x38
	public string TabId; // 0x40
	public bool UseFixedHeight; // 0x48
	public bool Paddingless; // 0x49
	public bool HideTabGroupIfTabGroupOnlyHasOneTab; // 0x4A
	public string TextColor; // 0x50
	public SdfIconType Icon; // 0x58
	public TabLayouting TabLayouting; // 0x5C
	public List<TabGroupAttribute> Tabs; // 0x60

	// Methods

	// RVA: 0x7E819F8 Offset: 0x7E7D9F8 VA: 0x7E819F8
	public void .ctor(string tab, bool useFixedHeight = False, float order = 0) { }

	// RVA: 0x7E81A68 Offset: 0x7E7DA68 VA: 0x7E81A68
	public void .ctor(string group, string tab, bool useFixedHeight = False, float order = 0) { }

	// RVA: 0x7E81B2C Offset: 0x7E7DB2C VA: 0x7E81B2C
	public void .ctor(string group, string tab, SdfIconType icon, bool useFixedHeight = False, float order = 0) { }

	// RVA: 0x7E81B54 Offset: 0x7E7DB54 VA: 0x7E81B54 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }

	// RVA: 0x7E81CC4 Offset: 0x7E7DCC4 VA: 0x7E81CC4 Slot: 12
	private IList<PropertyGroupAttribute> Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.GetSubGroupAttributes() { }

	// RVA: 0x7E82044 Offset: 0x7E7E044 VA: 0x7E82044 Slot: 13
	private string Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.RepathMemberAttribute(PropertyGroupAttribute attr) { }
}

// Namespace: Sirenix.OdinInspector
public enum TabLayouting // TypeDefIndex: 26726
{
	// Fields
	public int value__; // 0x0
	public const TabLayouting MultiRow = 0;
	public const TabLayouting Shrink = 1;
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class TableColumnWidthAttribute : Attribute // TypeDefIndex: 26727
{
	// Fields
	public int Width; // 0x10
	public bool Resizable; // 0x14

	// Methods

	// RVA: 0x7E821D0 Offset: 0x7E7E1D0 VA: 0x7E821D0
	public void .ctor(int width, bool resizable = True) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class TableListAttribute : Attribute // TypeDefIndex: 26728
{
	// Fields
	public int NumberOfItemsPerPage; // 0x10
	public bool IsReadOnly; // 0x14
	public int DefaultMinColumnWidth; // 0x18
	public bool ShowIndexLabels; // 0x1C
	public bool DrawScrollView; // 0x1D
	public int MinScrollViewHeight; // 0x20
	public int MaxScrollViewHeight; // 0x24
	public bool AlwaysExpanded; // 0x28
	public bool HideToolbar; // 0x29
	public int CellPadding; // 0x2C
	[SerializeField]
	[HideInInspector]
	private bool showPagingHasValue; // 0x30
	[SerializeField]
	[HideInInspector]
	private bool showPaging; // 0x31

	// Properties
	public bool ShowPaging { get; set; }
	public bool ShowPagingHasValue { get; }
	public int ScrollViewHeight { get; set; }

	// Methods

	// RVA: 0x7E82208 Offset: 0x7E7E208 VA: 0x7E82208
	public bool get_ShowPaging() { }

	// RVA: 0x7E82210 Offset: 0x7E7E210 VA: 0x7E82210
	public void set_ShowPaging(bool value) { }

	// RVA: 0x7E82224 Offset: 0x7E7E224 VA: 0x7E82224
	public bool get_ShowPagingHasValue() { }

	// RVA: 0x7E8222C Offset: 0x7E7E22C VA: 0x7E8222C
	public int get_ScrollViewHeight() { }

	// RVA: 0x7E8228C Offset: 0x7E7E28C VA: 0x7E8228C
	public void set_ScrollViewHeight(int value) { }

	// RVA: 0x7E82294 Offset: 0x7E7E294 VA: 0x7E82294
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class TableMatrixAttribute : Attribute // TypeDefIndex: 26729
{
	// Fields
	public bool IsReadOnly; // 0x10
	public bool ResizableColumns; // 0x11
	public string VerticalTitle; // 0x18
	public string HorizontalTitle; // 0x20
	public string DrawElementMethod; // 0x28
	public int RowHeight; // 0x30
	public bool SquareCells; // 0x34
	public bool HideColumnIndices; // 0x35
	public bool HideRowIndices; // 0x36
	public bool RespectIndentLevel; // 0x37
	public bool Transpose; // 0x38

	// Methods

	// RVA: 0x7E822BC Offset: 0x7E7E2BC VA: 0x7E822BC
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[DontApplyToListElements]
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TitleAttribute : Attribute // TypeDefIndex: 26730
{
	// Fields
	public string Title; // 0x10
	public string Subtitle; // 0x18
	public bool Bold; // 0x20
	public bool HorizontalLine; // 0x21
	public TitleAlignments TitleAlignment; // 0x24

	// Methods

	// RVA: 0x7E822D0 Offset: 0x7E7E2D0 VA: 0x7E822D0
	public void .ctor(string title, string subtitle, TitleAlignments titleAlignment = 0, bool horizontalLine = True, bool bold = True) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class TitleGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26731
{
	// Fields
	public string Subtitle; // 0x38
	public TitleAlignments Alignment; // 0x40
	public bool HorizontalLine; // 0x44
	public bool BoldTitle; // 0x45
	public bool Indent; // 0x46

	// Methods

	// RVA: 0x7E8238C Offset: 0x7E7E38C VA: 0x7E8238C
	public void .ctor(string title, string subtitle, TitleAlignments alignment = 0, bool horizontalLine = True, bool boldTitle = True, bool indent = False, float order = 0) { }

	// RVA: 0x7E823EC Offset: 0x7E7E3EC VA: 0x7E823EC Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class ToggleAttribute : Attribute // TypeDefIndex: 26732
{
	// Fields
	public string ToggleMemberName; // 0x10
	public bool CollapseOthersOnExpand; // 0x18

	// Methods

	// RVA: 0x7E824D4 Offset: 0x7E7E4D4 VA: 0x7E824D4
	public void .ctor(string toggleMemberName) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class ToggleGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26733
{
	// Fields
	public string ToggleGroupTitle; // 0x38
	public bool CollapseOthersOnExpand; // 0x40
	[CompilerGenerated]
	private string <TitleStringMemberName>k__BackingField; // 0x48

	// Properties
	public string ToggleMemberName { get; }
	[EditorBrowsable(1)]
	[Obsolete("Add a $ infront of group title instead, i.e: "$MyStringMember".")]
	public string TitleStringMemberName { get; set; }

	// Methods

	// RVA: 0x7E82510 Offset: 0x7E7E510 VA: 0x7E82510
	public void .ctor(string toggleMemberName, float order = 0, string groupTitle) { }

	// RVA: 0x7E82548 Offset: 0x7E7E548 VA: 0x7E82548
	public void .ctor(string toggleMemberName, string groupTitle) { }

	[EditorBrowsable(1)]
	[Obsolete("Use [ToggleGroup("toggleMemberName", groupTitle: "$titleStringMemberName")] instead")]
	// RVA: 0x7E82584 Offset: 0x7E7E584 VA: 0x7E82584
	public void .ctor(string toggleMemberName, float order, string groupTitle, string titleStringMemberName) { }

	// RVA: 0x7E825BC Offset: 0x7E7E5BC VA: 0x7E825BC
	public string get_ToggleMemberName() { }

	[CompilerGenerated]
	// RVA: 0x7E825C4 Offset: 0x7E7E5C4 VA: 0x7E825C4
	public string get_TitleStringMemberName() { }

	[CompilerGenerated]
	// RVA: 0x7E825CC Offset: 0x7E7E5CC VA: 0x7E825CC
	public void set_TitleStringMemberName(string value) { }

	// RVA: 0x7E825D4 Offset: 0x7E7E5D4 VA: 0x7E825D4 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class ToggleLeftAttribute : Attribute // TypeDefIndex: 26734
{
	// Methods

	// RVA: 0x7E8267C Offset: 0x7E7E67C VA: 0x7E8267C
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public class TypeFilterAttribute : Attribute // TypeDefIndex: 26735
{
	// Fields
	public string FilterGetter; // 0x10
	public string DropdownTitle; // 0x18
	public bool DrawValueNormally; // 0x20

	// Properties
	[Obsolete("Use the FilterGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E82684 Offset: 0x7E7E684 VA: 0x7E82684
	public string get_MemberName() { }

	// RVA: 0x7E8268C Offset: 0x7E7E68C VA: 0x7E8268C
	public void set_MemberName(string value) { }

	// RVA: 0x7E82694 Offset: 0x7E7E694 VA: 0x7E82694
	public void .ctor(string filterGetter) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(1036, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TypeInfoBoxAttribute : Attribute // TypeDefIndex: 26736
{
	// Fields
	public string Message; // 0x10

	// Methods

	// RVA: 0x7E826C4 Offset: 0x7E7E6C4 VA: 0x7E826C4
	public void .ctor(string message) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class ValidateInputAttribute : Attribute // TypeDefIndex: 26737
{
	// Fields
	public string DefaultMessage; // 0x10
	public string Condition; // 0x18
	public InfoMessageType MessageType; // 0x20
	public bool IncludeChildren; // 0x24
	public bool ContinuousValidationCheck; // 0x25

	// Properties
	[Obsolete("Use the Condition member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use the ContinuousValidationCheck member instead.")]
	public bool ContiniousValidationCheck { get; set; }

	// Methods

	// RVA: 0x7E826F4 Offset: 0x7E7E6F4 VA: 0x7E826F4
	public string get_MemberName() { }

	// RVA: 0x7E826FC Offset: 0x7E7E6FC VA: 0x7E826FC
	public void set_MemberName(string value) { }

	// RVA: 0x7E82704 Offset: 0x7E7E704 VA: 0x7E82704
	public bool get_ContiniousValidationCheck() { }

	// RVA: 0x7E8270C Offset: 0x7E7E70C VA: 0x7E8270C
	public void set_ContiniousValidationCheck(bool value) { }

	// RVA: 0x7E82718 Offset: 0x7E7E718 VA: 0x7E82718
	public void .ctor(string condition, string defaultMessage, InfoMessageType messageType = 3) { }

	[EditorBrowsable(1)]
	[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", True)]
	// RVA: 0x7E82778 Offset: 0x7E7E778 VA: 0x7E82778
	public void .ctor(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput) { }
}

// Namespace: Sirenix.OdinInspector
[Usage(32767, AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class ValueDropdownAttribute : Attribute // TypeDefIndex: 26738
{
	// Fields
	public string ValuesGetter; // 0x10
	public int NumberOfItemsBeforeEnablingSearch; // 0x18
	public bool IsUniqueList; // 0x1C
	public bool DrawDropdownForListElements; // 0x1D
	public bool DisableListAddButtonBehaviour; // 0x1E
	public bool ExcludeExistingValuesInList; // 0x1F
	public bool ExpandAllMenuItems; // 0x20
	public bool AppendNextDrawer; // 0x21
	public bool DisableGUIInAppendedDrawer; // 0x22
	public bool DoubleClickToConfirm; // 0x23
	public bool FlattenTreeView; // 0x24
	public int DropdownWidth; // 0x28
	public int DropdownHeight; // 0x2C
	public string DropdownTitle; // 0x30
	public bool SortDropdownItems; // 0x38
	public bool HideChildProperties; // 0x39
	public bool CopyValues; // 0x3A
	public bool OnlyChangeValueOnConfirm; // 0x3B

	// Properties
	[Obsolete("Use the ValuesGetter member instead.", False)]
	[EditorBrowsable(1)]
	public string MemberName { get; set; }

	// Methods

	// RVA: 0x7E827D8 Offset: 0x7E7E7D8 VA: 0x7E827D8
	public string get_MemberName() { }

	// RVA: 0x7E827E0 Offset: 0x7E7E7E0 VA: 0x7E827E0
	public void set_MemberName(string value) { }

	// RVA: 0x7E827E8 Offset: 0x7E7E7E8 VA: 0x7E827E8
	public void .ctor(string valuesGetter) { }
}

// Namespace: Sirenix.OdinInspector
public interface IValueDropdownItem // TypeDefIndex: 26739
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetText();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue();
}

// Namespace: Sirenix.OdinInspector
public class ValueDropdownList<T> : List<ValueDropdownItem<T>> // TypeDefIndex: 26740
{
	// Methods

	// RVA: -1 Offset: -1
	public void Add(string text, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741AF0 Offset: 0x573DAF0 VA: 0x5741AF0
	|-ValueDropdownList<ServerInfo>.Add
	|
	|-RVA: 0x5741D90 Offset: 0x573DD90 VA: 0x5741D90
	|-ValueDropdownList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741BF4 Offset: 0x573DBF4 VA: 0x5741BF4
	|-ValueDropdownList<ServerInfo>.Add
	|
	|-RVA: 0x5741EE4 Offset: 0x573DEE4 VA: 0x5741EE4
	|-ValueDropdownList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741D34 Offset: 0x573DD34 VA: 0x5741D34
	|-ValueDropdownList<ServerInfo>..ctor
	|
	|-RVA: 0x57420C4 Offset: 0x573E0C4 VA: 0x57420C4
	|-ValueDropdownList<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.OdinInspector
public struct ValueDropdownItem : IValueDropdownItem // TypeDefIndex: 26741
{
	// Fields
	public string Text; // 0x0
	public object Value; // 0x8

	// Methods

	// RVA: 0x7E82830 Offset: 0x7E7E830 VA: 0x7E82830
	public void .ctor(string text, object value) { }

	// RVA: 0x7E82860 Offset: 0x7E7E860 VA: 0x7E82860 Slot: 3
	public override string ToString() { }

	// RVA: 0x7E828C8 Offset: 0x7E7E8C8 VA: 0x7E828C8 Slot: 4
	private string Sirenix.OdinInspector.IValueDropdownItem.GetText() { }

	// RVA: 0x7E828D0 Offset: 0x7E7E8D0 VA: 0x7E828D0 Slot: 5
	private object Sirenix.OdinInspector.IValueDropdownItem.GetValue() { }
}

// Namespace: Sirenix.OdinInspector
public struct ValueDropdownItem<T> : IValueDropdownItem // TypeDefIndex: 26742
{
	// Fields
	public string Text; // 0x0
	public T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string text, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x57414D0 Offset: 0x573D4D0 VA: 0x57414D0
	|-ValueDropdownItem<ServerInfo>..ctor
	|
	|-RVA: 0x57415F4 Offset: 0x573D5F4 VA: 0x57415F4
	|-ValueDropdownItem<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private string Sirenix.OdinInspector.IValueDropdownItem.GetText() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741508 Offset: 0x573D508 VA: 0x5741508
	|-ValueDropdownItem<ServerInfo>.Sirenix.OdinInspector.IValueDropdownItem.GetText
	|
	|-RVA: 0x574174C Offset: 0x573D74C VA: 0x574174C
	|-ValueDropdownItem<__Il2CppFullySharedGenericType>.Sirenix.OdinInspector.IValueDropdownItem.GetText
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object Sirenix.OdinInspector.IValueDropdownItem.GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741510 Offset: 0x573D510 VA: 0x5741510
	|-ValueDropdownItem<ServerInfo>.Sirenix.OdinInspector.IValueDropdownItem.GetValue
	|
	|-RVA: 0x574178C Offset: 0x573D78C VA: 0x574178C
	|-ValueDropdownItem<__Il2CppFullySharedGenericType>.Sirenix.OdinInspector.IValueDropdownItem.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574154C Offset: 0x573D54C VA: 0x574154C
	|-ValueDropdownItem<ServerInfo>.ToString
	|
	|-RVA: 0x5741888 Offset: 0x573D888 VA: 0x5741888
	|-ValueDropdownItem<__Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public class VerticalGroupAttribute : PropertyGroupAttribute // TypeDefIndex: 26743
{
	// Fields
	public float PaddingTop; // 0x34
	public float PaddingBottom; // 0x38

	// Methods

	// RVA: 0x7E828D8 Offset: 0x7E7E8D8 VA: 0x7E828D8
	public void .ctor(string groupId, float order = 0) { }

	// RVA: 0x7E828DC Offset: 0x7E7E8DC VA: 0x7E828DC
	public void .ctor(float order = 0) { }

	// RVA: 0x7E82934 Offset: 0x7E7E934 VA: 0x7E82934 Slot: 11
	protected override void CombineValuesWith(PropertyGroupAttribute other) { }
}

// Namespace: Sirenix.OdinInspector
[Conditional("UNITY_EDITOR")]
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class WrapAttribute : Attribute // TypeDefIndex: 26744
{
	// Fields
	public double Min; // 0x10
	public double Max; // 0x18

	// Methods

	// RVA: 0x7E829C8 Offset: 0x7E7E9C8 VA: 0x7E829C8
	public void .ctor(double min, double max) { }
}

// Namespace: Sirenix.OdinInspector
public static class AttributeTargetFlags // TypeDefIndex: 26745
{
	// Fields
	public const AttributeTargets Default = 32767;
}

// Namespace: Sirenix.OdinInspector
public enum ButtonSizes // TypeDefIndex: 26746
{
	// Fields
	public int value__; // 0x0
	public const ButtonSizes Small = 0;
	public const ButtonSizes Medium = 22;
	public const ButtonSizes Large = 31;
	public const ButtonSizes Gigantic = 62;
}

// Namespace: Sirenix.OdinInspector
public enum DictionaryDisplayOptions // TypeDefIndex: 26747
{
	// Fields
	public int value__; // 0x0
	public const DictionaryDisplayOptions OneLine = 0;
	public const DictionaryDisplayOptions Foldout = 1;
	public const DictionaryDisplayOptions CollapsedFoldout = 2;
	public const DictionaryDisplayOptions ExpandedFoldout = 3;
}

// Namespace: Sirenix.OdinInspector
public enum IconAlignment // TypeDefIndex: 26748
{
	// Fields
	public int value__; // 0x0
	public const IconAlignment LeftOfText = 0;
	public const IconAlignment RightOfText = 1;
	public const IconAlignment LeftEdge = 2;
	public const IconAlignment RightEdge = 3;
}

// Namespace: Sirenix.OdinInspector
[Usage(4)]
public class IncludeMyAttributesAttribute : Attribute // TypeDefIndex: 26749
{
	// Methods

	// RVA: 0x7E82A08 Offset: 0x7E7EA08 VA: 0x7E82A08
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public enum InfoMessageType // TypeDefIndex: 26750
{
	// Fields
	public int value__; // 0x0
	public const InfoMessageType None = 0;
	public const InfoMessageType Info = 1;
	public const InfoMessageType Warning = 2;
	public const InfoMessageType Error = 3;
}

// Namespace: Sirenix.OdinInspector
public enum InlineEditorModes // TypeDefIndex: 26751
{
	// Fields
	public int value__; // 0x0
	public const InlineEditorModes GUIOnly = 0;
	public const InlineEditorModes GUIAndHeader = 1;
	public const InlineEditorModes GUIAndPreview = 2;
	public const InlineEditorModes SmallPreview = 3;
	public const InlineEditorModes LargePreview = 4;
	public const InlineEditorModes FullEditor = 5;
}

// Namespace: Sirenix.OdinInspector
public enum InlineEditorObjectFieldModes // TypeDefIndex: 26752
{
	// Fields
	public int value__; // 0x0
	public const InlineEditorObjectFieldModes Boxed = 0;
	public const InlineEditorObjectFieldModes Foldout = 1;
	public const InlineEditorObjectFieldModes Hidden = 2;
	public const InlineEditorObjectFieldModes CompletelyHidden = 3;
}

// Namespace: Sirenix.OdinInspector
public interface ISearchFilterable // TypeDefIndex: 26753
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsMatch(string searchString);
}

// Namespace: Sirenix.OdinInspector
public interface ISelfValidator // TypeDefIndex: 26754
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Validate(SelfValidationResult result);
}

// Namespace: Sirenix.OdinInspector
[EnumToggleButtons]
public enum ValidatorSeverity // TypeDefIndex: 26755
{
	// Fields
	public int value__; // 0x0
	public const ValidatorSeverity Error = 0;
	public const ValidatorSeverity Warning = 1;
	public const ValidatorSeverity Ignore = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class SelfValidationResultItemExtensions.<>c__DisplayClass6_0 // TypeDefIndex: 26756
{
	// Fields
	public string path; // 0x10
	public Action onClick; // 0x18

	// Methods

	// RVA: 0x7E82E20 Offset: 0x7E7EE20 VA: 0x7E82E20
	public void .ctor() { }

	// RVA: 0x7E83470 Offset: 0x7E7F470 VA: 0x7E83470
	internal IEnumerable<SelfValidationResult.ContextMenuItem> <WithContextClick>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SelfValidationResultItemExtensions.<>c__DisplayClass7_0 // TypeDefIndex: 26757
{
	// Fields
	public string path; // 0x10
	public bool on; // 0x18
	public Action onClick; // 0x20

	// Methods

	// RVA: 0x7E82F20 Offset: 0x7E7EF20 VA: 0x7E82F20
	public void .ctor() { }

	// RVA: 0x7E83544 Offset: 0x7E7F544 VA: 0x7E83544
	internal IEnumerable<SelfValidationResult.ContextMenuItem> <WithContextClick>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SelfValidationResultItemExtensions.<>c__DisplayClass8_0 // TypeDefIndex: 26758
{
	// Fields
	public SelfValidationResult.ContextMenuItem onContextClick; // 0x10

	// Methods

	// RVA: 0x7E8301C Offset: 0x7E7F01C VA: 0x7E8301C
	public void .ctor() { }

	// RVA: 0x7E83620 Offset: 0x7E7F620 VA: 0x7E83620
	internal IEnumerable<SelfValidationResult.ContextMenuItem> <WithContextClick>b__0() { }
}

// Namespace: Sirenix.OdinInspector
[Extension]
public static class SelfValidationResultItemExtensions // TypeDefIndex: 26759
{
	// Methods

	[Extension]
	// RVA: 0x7E82A10 Offset: 0x7E7EA10 VA: 0x7E82A10
	public static ref SelfValidationResult.ResultItem WithFix(ref SelfValidationResult.ResultItem item, string title, Action fix, bool offerInInspector = True) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ref SelfValidationResult.ResultItem WithFix<T>(ref SelfValidationResult.ResultItem item, string title, Action<T> fix, bool offerInInspector = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E13E4 Offset: 0x46DD3E4 VA: 0x46E13E4
	|-SelfValidationResultItemExtensions.WithFix<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7E82B48 Offset: 0x7E7EB48 VA: 0x7E82B48
	public static ref SelfValidationResult.ResultItem WithFix(ref SelfValidationResult.ResultItem item, Action fix, bool offerInInspector = True) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ref SelfValidationResult.ResultItem WithFix<T>(ref SelfValidationResult.ResultItem item, Action<T> fix, bool offerInInspector = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E1320 Offset: 0x46DD320 VA: 0x46E1320
	|-SelfValidationResultItemExtensions.WithFix<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7E82C7C Offset: 0x7E7EC7C VA: 0x7E82C7C
	public static ref SelfValidationResult.ResultItem WithFix(ref SelfValidationResult.ResultItem item, SelfFix fix) { }

	[Extension]
	// RVA: 0x7E82D18 Offset: 0x7E7ED18 VA: 0x7E82D18
	public static ref SelfValidationResult.ResultItem WithContextClick(ref SelfValidationResult.ResultItem item, Func<IEnumerable<SelfValidationResult.ContextMenuItem>> onContextClick) { }

	[Extension]
	// RVA: 0x7E82D34 Offset: 0x7E7ED34 VA: 0x7E82D34
	public static ref SelfValidationResult.ResultItem WithContextClick(ref SelfValidationResult.ResultItem item, string path, Action onClick) { }

	[Extension]
	// RVA: 0x7E82E28 Offset: 0x7E7EE28 VA: 0x7E82E28
	public static ref SelfValidationResult.ResultItem WithContextClick(ref SelfValidationResult.ResultItem item, string path, bool on, Action onClick) { }

	[Extension]
	// RVA: 0x7E82F28 Offset: 0x7E7EF28 VA: 0x7E82F28
	public static ref SelfValidationResult.ResultItem WithContextClick(ref SelfValidationResult.ResultItem item, SelfValidationResult.ContextMenuItem onContextClick) { }

	[Extension]
	// RVA: 0x7E83024 Offset: 0x7E7F024 VA: 0x7E83024
	public static ref SelfValidationResult.ResultItem WithSceneGUI(ref SelfValidationResult.ResultItem item, Action onSceneGUI) { }

	[Extension]
	// RVA: 0x7E83040 Offset: 0x7E7F040 VA: 0x7E83040
	public static ref SelfValidationResult.ResultItem SetSelectionObject(ref SelfValidationResult.ResultItem item, Object uObj) { }

	[Extension]
	// RVA: 0x7E8305C Offset: 0x7E7F05C VA: 0x7E8305C
	public static ref SelfValidationResult.ResultItem EnableRichText(ref SelfValidationResult.ResultItem item) { }

	[Extension]
	// RVA: 0x7E83068 Offset: 0x7E7F068 VA: 0x7E83068
	public static ref SelfValidationResult.ResultItem WithMetaData(ref SelfValidationResult.ResultItem resultItem, string name, object value, Attribute[] attributes) { }

	[Extension]
	// RVA: 0x7E831D0 Offset: 0x7E7F1D0 VA: 0x7E831D0
	public static ref SelfValidationResult.ResultItem WithMetaData(ref SelfValidationResult.ResultItem resultItem, object value, Attribute[] attributes) { }

	[Extension]
	// RVA: 0x7E832F0 Offset: 0x7E7F2F0 VA: 0x7E832F0
	public static ref SelfValidationResult.ResultItem WithButton(ref SelfValidationResult.ResultItem resultItem, string name, Action onClick) { }
}

// Namespace: 
public struct SelfValidationResult.ContextMenuItem // TypeDefIndex: 26760
{
	// Fields
	public string Path; // 0x0
	public bool On; // 0x8
	public bool AddSeparatorBefore; // 0x9
	public Action OnClick; // 0x10
}

// Namespace: 
public enum SelfValidationResult.ResultType // TypeDefIndex: 26761
{
	// Fields
	public int value__; // 0x0
	public const SelfValidationResult.ResultType Error = 0;
	public const SelfValidationResult.ResultType Warning = 1;
	public const SelfValidationResult.ResultType Valid = 2;
}

// Namespace: 
public struct SelfValidationResult.ResultItem // TypeDefIndex: 26762
{
	// Fields
	public string Message; // 0x0
	public SelfValidationResult.ResultType ResultType; // 0x8
	public Nullable<SelfFix> Fix; // 0x10
	public SelfValidationResult.ResultItemMetaData[] MetaData; // 0x30
	public Func<IEnumerable<SelfValidationResult.ContextMenuItem>> OnContextClick; // 0x38
	public Action OnSceneGUI; // 0x40
	public Object SelectionObject; // 0x48
	public bool RichText; // 0x50
}

// Namespace: 
public struct SelfValidationResult.ResultItemMetaData // TypeDefIndex: 26763
{
	// Fields
	public string Name; // 0x0
	public object Value; // 0x8
	public Attribute[] Attributes; // 0x10

	// Methods

	// RVA: 0x7E8318C Offset: 0x7E7F18C VA: 0x7E8318C
	public void .ctor(string name, object value, Attribute[] attributes) { }
}

// Namespace: Sirenix.OdinInspector
[DefaultMember("Item")]
public class SelfValidationResult // TypeDefIndex: 26764
{
	// Fields
	private static SelfValidationResult.ResultItem NoResultItem; // 0x0
	private SelfValidationResult.ResultItem[] items; // 0x10
	private int itemsCount; // 0x18

	// Properties
	public int Count { get; }
	public SelfValidationResult.ResultItem Item { get; }

	// Methods

	// RVA: 0x7E836CC Offset: 0x7E7F6CC VA: 0x7E836CC
	public int get_Count() { }

	// RVA: 0x7E836D4 Offset: 0x7E7F6D4 VA: 0x7E836D4
	public ref SelfValidationResult.ResultItem get_Item(int index) { }

	// RVA: 0x7E83708 Offset: 0x7E7F708 VA: 0x7E83708
	public ref SelfValidationResult.ResultItem AddError(string error) { }

	// RVA: 0x7E83930 Offset: 0x7E7F930 VA: 0x7E83930
	public ref SelfValidationResult.ResultItem AddWarning(string warning) { }

	// RVA: 0x7E83990 Offset: 0x7E7F990 VA: 0x7E83990
	public ref SelfValidationResult.ResultItem Add(ValidatorSeverity severity, string message) { }

	// RVA: 0x7E83764 Offset: 0x7E7F764 VA: 0x7E83764
	public ref SelfValidationResult.ResultItem Add(SelfValidationResult.ResultItem item) { }

	// RVA: 0x7E83AB0 Offset: 0x7E7FAB0 VA: 0x7E83AB0
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public class SelfMetaData : List<SelfValidationResult.ResultItemMetaData> // TypeDefIndex: 26765
{
	// Methods

	// RVA: 0x7E83AB8 Offset: 0x7E7FAB8 VA: 0x7E83AB8
	public void Add(string key, object value) { }

	// RVA: 0x7E83C20 Offset: 0x7E7FC20 VA: 0x7E83C20
	public void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public struct SelfFix // TypeDefIndex: 26766
{
	// Fields
	public string Title; // 0x0
	public Delegate Action; // 0x8
	public bool OfferInInspector; // 0x10

	// Methods

	// RVA: 0x7E83C8C Offset: 0x7E7FC8C VA: 0x7E83C8C
	public void .ctor(string name, Action action, bool offerInInspector) { }

	// RVA: 0x7E83CC8 Offset: 0x7E7FCC8 VA: 0x7E83CC8
	public void .ctor(string name, Delegate action, bool offerInInspector) { }

	// RVA: 0x7E82BF8 Offset: 0x7E7EBF8 VA: 0x7E82BF8
	public static SelfFix Create(Action action, bool offerInInspector = True) { }

	// RVA: 0x7E82AF0 Offset: 0x7E7EAF0 VA: 0x7E82AF0
	public static SelfFix Create(string title, Action action, bool offerInInspector = True) { }

	// RVA: -1 Offset: -1
	public static SelfFix Create<T>(Action<T> action, bool offerInInspector = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E1290 Offset: 0x46DD290 VA: 0x46E1290
	|-SelfFix.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SelfFix Create<T>(string title, Action<T> action, bool offerInInspector = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E12FC Offset: 0x46DD2FC VA: 0x46E12FC
	|-SelfFix.Create<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.OdinInspector
public enum ObjectFieldAlignment // TypeDefIndex: 26767
{
	// Fields
	public int value__; // 0x0
	public const ObjectFieldAlignment Left = 0;
	public const ObjectFieldAlignment Center = 1;
	public const ObjectFieldAlignment Right = 2;
}

// Namespace: Sirenix.OdinInspector
[Usage(1, AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class OdinRegisterAttributeAttribute : Attribute // TypeDefIndex: 26768
{
	// Fields
	public Type AttributeType; // 0x10
	public string Categories; // 0x18
	public string Description; // 0x20
	public string DocumentationUrl; // 0x28
	public bool IsEnterprise; // 0x30

	// Methods

	// RVA: 0x7E83D04 Offset: 0x7E7FD04 VA: 0x7E83D04
	public void .ctor(Type attributeType, string category, string description, bool isEnterprise) { }

	// RVA: 0x7E83D70 Offset: 0x7E7FD70 VA: 0x7E83D70
	public void .ctor(Type attributeType, string category, string description, bool isEnterprise, string url) { }
}

// Namespace: Sirenix.OdinInspector
[Flags]
public enum PrefabKind // TypeDefIndex: 26769
{
	// Fields
	public int value__; // 0x0
	public const PrefabKind None = 0;
	public const PrefabKind InstanceInScene = 1;
	public const PrefabKind InstanceInPrefab = 2;
	public const PrefabKind Regular = 4;
	public const PrefabKind Variant = 8;
	public const PrefabKind NonPrefabInstance = 16;
	public const PrefabKind PrefabInstance = 3;
	public const PrefabKind PrefabAsset = 12;
	public const PrefabKind PrefabInstanceAndNonPrefabInstance = 19;
	public const PrefabKind All = 31;
}

// Namespace: Sirenix.OdinInspector
public enum PreviewAlignment // TypeDefIndex: 26770
{
	// Fields
	public int value__; // 0x0
	public const PreviewAlignment Left = 0;
	public const PreviewAlignment Right = 1;
	public const PreviewAlignment Top = 2;
	public const PreviewAlignment Bottom = 3;
}

// Namespace: Sirenix.OdinInspector
public enum SdfIconType // TypeDefIndex: 26771
{
	// Fields
	public int value__; // 0x0
	public const SdfIconType None = 0;
	public const SdfIconType AlarmFill = 1;
	public const SdfIconType Alarm = 2;
	public const SdfIconType AlignBottom = 3;
	public const SdfIconType AlignCenter = 4;
	public const SdfIconType AlignEnd = 5;
	public const SdfIconType AlignMiddle = 6;
	public const SdfIconType AlignStart = 7;
	public const SdfIconType AlignTop = 8;
	public const SdfIconType Alt = 9;
	public const SdfIconType AppIndicator = 10;
	public const SdfIconType App = 11;
	public const SdfIconType ArchiveFill = 12;
	public const SdfIconType Archive = 13;
	public const SdfIconType Arrow90degDown = 14;
	public const SdfIconType Arrow90degLeft = 15;
	public const SdfIconType Arrow90degRight = 16;
	public const SdfIconType Arrow90degUp = 17;
	public const SdfIconType ArrowBarDown = 18;
	public const SdfIconType ArrowBarLeft = 19;
	public const SdfIconType ArrowBarRight = 20;
	public const SdfIconType ArrowBarUp = 21;
	public const SdfIconType ArrowClockwise = 22;
	public const SdfIconType ArrowCounterclockwise = 23;
	public const SdfIconType ArrowDownCircleFill = 24;
	public const SdfIconType ArrowDownCircle = 25;
	public const SdfIconType ArrowDownLeftCircleFill = 26;
	public const SdfIconType ArrowDownLeftCircle = 27;
	public const SdfIconType ArrowDownLeftSquareFill = 28;
	public const SdfIconType ArrowDownLeftSquare = 29;
	public const SdfIconType ArrowDownLeft = 30;
	public const SdfIconType ArrowDownRightCircleFill = 31;
	public const SdfIconType ArrowDownRightCircle = 32;
	public const SdfIconType ArrowDownRightSquareFill = 33;
	public const SdfIconType ArrowDownRightSquare = 34;
	public const SdfIconType ArrowDownRight = 35;
	public const SdfIconType ArrowDownShort = 36;
	public const SdfIconType ArrowDownSquareFill = 37;
	public const SdfIconType ArrowDownSquare = 38;
	public const SdfIconType ArrowDownUp = 39;
	public const SdfIconType ArrowDown = 40;
	public const SdfIconType ArrowLeftCircleFill = 41;
	public const SdfIconType ArrowLeftCircle = 42;
	public const SdfIconType ArrowLeftRight = 43;
	public const SdfIconType ArrowLeftShort = 44;
	public const SdfIconType ArrowLeftSquareFill = 45;
	public const SdfIconType ArrowLeftSquare = 46;
	public const SdfIconType ArrowLeft = 47;
	public const SdfIconType ArrowRepeat = 48;
	public const SdfIconType ArrowReturnLeft = 49;
	public const SdfIconType ArrowReturnRight = 50;
	public const SdfIconType ArrowRightCircleFill = 51;
	public const SdfIconType ArrowRightCircle = 52;
	public const SdfIconType ArrowRightShort = 53;
	public const SdfIconType ArrowRightSquareFill = 54;
	public const SdfIconType ArrowRightSquare = 55;
	public const SdfIconType ArrowRight = 56;
	public const SdfIconType ArrowUpCircleFill = 57;
	public const SdfIconType ArrowUpCircle = 58;
	public const SdfIconType ArrowUpLeftCircleFill = 59;
	public const SdfIconType ArrowUpLeftCircle = 60;
	public const SdfIconType ArrowUpLeftSquareFill = 61;
	public const SdfIconType ArrowUpLeftSquare = 62;
	public const SdfIconType ArrowUpLeft = 63;
	public const SdfIconType ArrowUpRightCircleFill = 64;
	public const SdfIconType ArrowUpRightCircle = 65;
	public const SdfIconType ArrowUpRightSquareFill = 66;
	public const SdfIconType ArrowUpRightSquare = 67;
	public const SdfIconType ArrowUpRight = 68;
	public const SdfIconType ArrowUpShort = 69;
	public const SdfIconType ArrowUpSquareFill = 70;
	public const SdfIconType ArrowUpSquare = 71;
	public const SdfIconType ArrowUp = 72;
	public const SdfIconType ArrowsAngleContract = 73;
	public const SdfIconType ArrowsAngleExpand = 74;
	public const SdfIconType ArrowsCollapse = 75;
	public const SdfIconType ArrowsExpand = 76;
	public const SdfIconType ArrowsFullscreen = 77;
	public const SdfIconType ArrowsMove = 78;
	public const SdfIconType AspectRatioFill = 79;
	public const SdfIconType AspectRatio = 80;
	public const SdfIconType Asterisk = 81;
	public const SdfIconType At = 82;
	public const SdfIconType AwardFill = 83;
	public const SdfIconType Award = 84;
	public const SdfIconType Back = 85;
	public const SdfIconType BackspaceFill = 86;
	public const SdfIconType BackspaceReverseFill = 87;
	public const SdfIconType BackspaceReverse = 88;
	public const SdfIconType Backspace = 89;
	public const SdfIconType Badge3dFill = 90;
	public const SdfIconType Badge3d = 91;
	public const SdfIconType Badge4kFill = 92;
	public const SdfIconType Badge4k = 93;
	public const SdfIconType Badge8kFill = 94;
	public const SdfIconType Badge8k = 95;
	public const SdfIconType BadgeAdFill = 96;
	public const SdfIconType BadgeAd = 97;
	public const SdfIconType BadgeArFill = 98;
	public const SdfIconType BadgeAr = 99;
	public const SdfIconType BadgeCcFill = 100;
	public const SdfIconType BadgeCc = 101;
	public const SdfIconType BadgeHdFill = 102;
	public const SdfIconType BadgeHd = 103;
	public const SdfIconType BadgeTmFill = 104;
	public const SdfIconType BadgeTm = 105;
	public const SdfIconType BadgeVoFill = 106;
	public const SdfIconType BadgeVo = 107;
	public const SdfIconType BadgeVrFill = 108;
	public const SdfIconType BadgeVr = 109;
	public const SdfIconType BadgeWcFill = 110;
	public const SdfIconType BadgeWc = 111;
	public const SdfIconType BagCheckFill = 112;
	public const SdfIconType BagCheck = 113;
	public const SdfIconType BagDashFill = 114;
	public const SdfIconType BagDash = 115;
	public const SdfIconType BagFill = 116;
	public const SdfIconType BagPlusFill = 117;
	public const SdfIconType BagPlus = 118;
	public const SdfIconType BagXFill = 119;
	public const SdfIconType BagX = 120;
	public const SdfIconType Bag = 121;
	public const SdfIconType BarChartFill = 122;
	public const SdfIconType BarChartLineFill = 123;
	public const SdfIconType BarChartLine = 124;
	public const SdfIconType BarChartSteps = 125;
	public const SdfIconType BarChart = 126;
	public const SdfIconType BasketFill = 127;
	public const SdfIconType Basket = 128;
	public const SdfIconType Basket2Fill = 129;
	public const SdfIconType Basket2 = 130;
	public const SdfIconType Basket3Fill = 131;
	public const SdfIconType Basket3 = 132;
	public const SdfIconType BatteryCharging = 133;
	public const SdfIconType BatteryFull = 134;
	public const SdfIconType BatteryHalf = 135;
	public const SdfIconType Battery = 136;
	public const SdfIconType BellFill = 137;
	public const SdfIconType Bell = 138;
	public const SdfIconType Bezier = 139;
	public const SdfIconType Bezier2 = 140;
	public const SdfIconType Bicycle = 141;
	public const SdfIconType BinocularsFill = 142;
	public const SdfIconType Binoculars = 143;
	public const SdfIconType BlockquoteLeft = 144;
	public const SdfIconType BlockquoteRight = 145;
	public const SdfIconType BookFill = 146;
	public const SdfIconType BookHalf = 147;
	public const SdfIconType Book = 148;
	public const SdfIconType BookmarkCheckFill = 149;
	public const SdfIconType BookmarkCheck = 150;
	public const SdfIconType BookmarkDashFill = 151;
	public const SdfIconType BookmarkDash = 152;
	public const SdfIconType BookmarkFill = 153;
	public const SdfIconType BookmarkHeartFill = 154;
	public const SdfIconType BookmarkHeart = 155;
	public const SdfIconType BookmarkPlusFill = 156;
	public const SdfIconType BookmarkPlus = 157;
	public const SdfIconType BookmarkStarFill = 158;
	public const SdfIconType BookmarkStar = 159;
	public const SdfIconType BookmarkXFill = 160;
	public const SdfIconType BookmarkX = 161;
	public const SdfIconType Bookmark = 162;
	public const SdfIconType BookmarksFill = 163;
	public const SdfIconType Bookmarks = 164;
	public const SdfIconType Bookshelf = 165;
	public const SdfIconType BootstrapFill = 166;
	public const SdfIconType BootstrapReboot = 167;
	public const SdfIconType Bootstrap = 168;
	public const SdfIconType BorderAll = 169;
	public const SdfIconType BorderBottom = 170;
	public const SdfIconType BorderCenter = 171;
	public const SdfIconType BorderInner = 172;
	public const SdfIconType BorderLeft = 173;
	public const SdfIconType BorderMiddle = 174;
	public const SdfIconType BorderOuter = 175;
	public const SdfIconType BorderRight = 176;
	public const SdfIconType BorderStyle = 177;
	public const SdfIconType BorderTop = 178;
	public const SdfIconType BorderWidth = 179;
	public const SdfIconType Border = 180;
	public const SdfIconType BoundingBoxCircles = 181;
	public const SdfIconType BoundingBox = 182;
	public const SdfIconType BoxArrowDownLeft = 183;
	public const SdfIconType BoxArrowDownRight = 184;
	public const SdfIconType BoxArrowDown = 185;
	public const SdfIconType BoxArrowInDownLeft = 186;
	public const SdfIconType BoxArrowInDownRight = 187;
	public const SdfIconType BoxArrowInDown = 188;
	public const SdfIconType BoxArrowInLeft = 189;
	public const SdfIconType BoxArrowInRight = 190;
	public const SdfIconType BoxArrowInUpLeft = 191;
	public const SdfIconType BoxArrowInUpRight = 192;
	public const SdfIconType BoxArrowInUp = 193;
	public const SdfIconType BoxArrowLeft = 194;
	public const SdfIconType BoxArrowRight = 195;
	public const SdfIconType BoxArrowUpLeft = 196;
	public const SdfIconType BoxArrowUpRight = 197;
	public const SdfIconType BoxArrowUp = 198;
	public const SdfIconType BoxSeam = 199;
	public const SdfIconType Box = 200;
	public const SdfIconType Braces = 201;
	public const SdfIconType Bricks = 202;
	public const SdfIconType BriefcaseFill = 203;
	public const SdfIconType Briefcase = 204;
	public const SdfIconType BrightnessAltHighFill = 205;
	public const SdfIconType BrightnessAltHigh = 206;
	public const SdfIconType BrightnessAltLowFill = 207;
	public const SdfIconType BrightnessAltLow = 208;
	public const SdfIconType BrightnessHighFill = 209;
	public const SdfIconType BrightnessHigh = 210;
	public const SdfIconType BrightnessLowFill = 211;
	public const SdfIconType BrightnessLow = 212;
	public const SdfIconType BroadcastPin = 213;
	public const SdfIconType Broadcast = 214;
	public const SdfIconType BrushFill = 215;
	public const SdfIconType Brush = 216;
	public const SdfIconType BucketFill = 217;
	public const SdfIconType Bucket = 218;
	public const SdfIconType BugFill = 219;
	public const SdfIconType Bug = 220;
	public const SdfIconType Building = 221;
	public const SdfIconType Bullseye = 222;
	public const SdfIconType CalculatorFill = 223;
	public const SdfIconType Calculator = 224;
	public const SdfIconType CalendarCheckFill = 225;
	public const SdfIconType CalendarCheck = 226;
	public const SdfIconType CalendarDateFill = 227;
	public const SdfIconType CalendarDate = 228;
	public const SdfIconType CalendarDayFill = 229;
	public const SdfIconType CalendarDay = 230;
	public const SdfIconType CalendarEventFill = 231;
	public const SdfIconType CalendarEvent = 232;
	public const SdfIconType CalendarFill = 233;
	public const SdfIconType CalendarMinusFill = 234;
	public const SdfIconType CalendarMinus = 235;
	public const SdfIconType CalendarMonthFill = 236;
	public const SdfIconType CalendarMonth = 237;
	public const SdfIconType CalendarPlusFill = 238;
	public const SdfIconType CalendarPlus = 239;
	public const SdfIconType CalendarRangeFill = 240;
	public const SdfIconType CalendarRange = 241;
	public const SdfIconType CalendarWeekFill = 242;
	public const SdfIconType CalendarWeek = 243;
	public const SdfIconType CalendarXFill = 244;
	public const SdfIconType CalendarX = 245;
	public const SdfIconType Calendar = 246;
	public const SdfIconType Calendar2CheckFill = 247;
	public const SdfIconType Calendar2Check = 248;
	public const SdfIconType Calendar2DateFill = 249;
	public const SdfIconType Calendar2Date = 250;
	public const SdfIconType Calendar2DayFill = 251;
	public const SdfIconType Calendar2Day = 252;
	public const SdfIconType Calendar2EventFill = 253;
	public const SdfIconType Calendar2Event = 254;
	public const SdfIconType Calendar2Fill = 255;
	public const SdfIconType Calendar2MinusFill = 256;
	public const SdfIconType Calendar2Minus = 257;
	public const SdfIconType Calendar2MonthFill = 258;
	public const SdfIconType Calendar2Month = 259;
	public const SdfIconType Calendar2PlusFill = 260;
	public const SdfIconType Calendar2Plus = 261;
	public const SdfIconType Calendar2RangeFill = 262;
	public const SdfIconType Calendar2Range = 263;
	public const SdfIconType Calendar2WeekFill = 264;
	public const SdfIconType Calendar2Week = 265;
	public const SdfIconType Calendar2XFill = 266;
	public const SdfIconType Calendar2X = 267;
	public const SdfIconType Calendar2 = 268;
	public const SdfIconType Calendar3EventFill = 269;
	public const SdfIconType Calendar3Event = 270;
	public const SdfIconType Calendar3Fill = 271;
	public const SdfIconType Calendar3RangeFill = 272;
	public const SdfIconType Calendar3Range = 273;
	public const SdfIconType Calendar3WeekFill = 274;
	public const SdfIconType Calendar3Week = 275;
	public const SdfIconType Calendar3 = 276;
	public const SdfIconType Calendar4Event = 277;
	public const SdfIconType Calendar4Range = 278;
	public const SdfIconType Calendar4Week = 279;
	public const SdfIconType Calendar4 = 280;
	public const SdfIconType CameraFill = 281;
	public const SdfIconType CameraReelsFill = 282;
	public const SdfIconType CameraReels = 283;
	public const SdfIconType CameraVideoFill = 284;
	public const SdfIconType CameraVideoOffFill = 285;
	public const SdfIconType CameraVideoOff = 286;
	public const SdfIconType CameraVideo = 287;
	public const SdfIconType Camera = 288;
	public const SdfIconType Camera2 = 289;
	public const SdfIconType CapslockFill = 290;
	public const SdfIconType Capslock = 291;
	public const SdfIconType CardChecklist = 292;
	public const SdfIconType CardHeading = 293;
	public const SdfIconType CardImage = 294;
	public const SdfIconType CardList = 295;
	public const SdfIconType CardText = 296;
	public const SdfIconType CaretDownFill = 297;
	public const SdfIconType CaretDownSquareFill = 298;
	public const SdfIconType CaretDownSquare = 299;
	public const SdfIconType CaretDown = 300;
	public const SdfIconType CaretLeftFill = 301;
	public const SdfIconType CaretLeftSquareFill = 302;
	public const SdfIconType CaretLeftSquare = 303;
	public const SdfIconType CaretLeft = 304;
	public const SdfIconType CaretRightFill = 305;
	public const SdfIconType CaretRightSquareFill = 306;
	public const SdfIconType CaretRightSquare = 307;
	public const SdfIconType CaretRight = 308;
	public const SdfIconType CaretUpFill = 309;
	public const SdfIconType CaretUpSquareFill = 310;
	public const SdfIconType CaretUpSquare = 311;
	public const SdfIconType CaretUp = 312;
	public const SdfIconType CartCheckFill = 313;
	public const SdfIconType CartCheck = 314;
	public const SdfIconType CartDashFill = 315;
	public const SdfIconType CartDash = 316;
	public const SdfIconType CartFill = 317;
	public const SdfIconType CartPlusFill = 318;
	public const SdfIconType CartPlus = 319;
	public const SdfIconType CartXFill = 320;
	public const SdfIconType CartX = 321;
	public const SdfIconType Cart = 322;
	public const SdfIconType Cart2 = 323;
	public const SdfIconType Cart3 = 324;
	public const SdfIconType Cart4 = 325;
	public const SdfIconType C744 = 326;
	public const SdfIconType C745 = 327;
	public const SdfIconType Cast = 328;
	public const SdfIconType ChatDotsFill = 329;
	public const SdfIconType ChatDots = 330;
	public const SdfIconType ChatFill = 331;
	public const SdfIconType ChatLeftDotsFill = 332;
	public const SdfIconType ChatLeftDots = 333;
	public const SdfIconType ChatLeftFill = 334;
	public const SdfIconType ChatLeftQuoteFill = 335;
	public const SdfIconType ChatLeftQuote = 336;
	public const SdfIconType ChatLeftTextFill = 337;
	public const SdfIconType ChatLeftText = 338;
	public const SdfIconType ChatLeft = 339;
	public const SdfIconType ChatQuoteFill = 340;
	public const SdfIconType ChatQuote = 341;
	public const SdfIconType ChatRightDotsFill = 342;
	public const SdfIconType ChatRightDots = 343;
	public const SdfIconType ChatRightFill = 344;
	public const SdfIconType ChatRightQuoteFill = 345;
	public const SdfIconType ChatRightQuote = 346;
	public const SdfIconType ChatRightTextFill = 347;
	public const SdfIconType ChatRightText = 348;
	public const SdfIconType ChatRight = 349;
	public const SdfIconType ChatSquareDotsFill = 350;
	public const SdfIconType ChatSquareDots = 351;
	public const SdfIconType ChatSquareFill = 352;
	public const SdfIconType ChatSquareQuoteFill = 353;
	public const SdfIconType ChatSquareQuote = 354;
	public const SdfIconType ChatSquareTextFill = 355;
	public const SdfIconType ChatSquareText = 356;
	public const SdfIconType ChatSquare = 357;
	public const SdfIconType ChatTextFill = 358;
	public const SdfIconType ChatText = 359;
	public const SdfIconType Chat = 360;
	public const SdfIconType CheckAll = 361;
	public const SdfIconType CheckCircleFill = 362;
	public const SdfIconType CheckCircle = 363;
	public const SdfIconType CheckSquareFill = 364;
	public const SdfIconType CheckSquare = 365;
	public const SdfIconType Check = 366;
	public const SdfIconType Check2All = 367;
	public const SdfIconType Check2Circle = 368;
	public const SdfIconType Check2Square = 369;
	public const SdfIconType Check2 = 370;
	public const SdfIconType ChevronBarContract = 371;
	public const SdfIconType ChevronBarDown = 372;
	public const SdfIconType ChevronBarExpand = 373;
	public const SdfIconType ChevronBarLeft = 374;
	public const SdfIconType ChevronBarRight = 375;
	public const SdfIconType ChevronBarUp = 376;
	public const SdfIconType ChevronCompactDown = 377;
	public const SdfIconType ChevronCompactLeft = 378;
	public const SdfIconType ChevronCompactRight = 379;
	public const SdfIconType ChevronCompactUp = 380;
	public const SdfIconType ChevronContract = 381;
	public const SdfIconType ChevronDoubleDown = 382;
	public const SdfIconType ChevronDoubleLeft = 383;
	public const SdfIconType ChevronDoubleRight = 384;
	public const SdfIconType ChevronDoubleUp = 385;
	public const SdfIconType ChevronDown = 386;
	public const SdfIconType ChevronExpand = 387;
	public const SdfIconType ChevronLeft = 388;
	public const SdfIconType ChevronRight = 389;
	public const SdfIconType ChevronUp = 390;
	public const SdfIconType CircleFill = 391;
	public const SdfIconType CircleHalf = 392;
	public const SdfIconType CircleSquare = 393;
	public const SdfIconType Circle = 394;
	public const SdfIconType ClipboardCheck = 395;
	public const SdfIconType ClipboardData = 396;
	public const SdfIconType ClipboardMinus = 397;
	public const SdfIconType ClipboardPlus = 398;
	public const SdfIconType ClipboardX = 399;
	public const SdfIconType Clipboard = 400;
	public const SdfIconType ClockFill = 401;
	public const SdfIconType ClockHistory = 402;
	public const SdfIconType Clock = 403;
	public const SdfIconType CloudArrowDownFill = 404;
	public const SdfIconType CloudArrowDown = 405;
	public const SdfIconType CloudArrowUpFill = 406;
	public const SdfIconType CloudArrowUp = 407;
	public const SdfIconType CloudCheckFill = 408;
	public const SdfIconType CloudCheck = 409;
	public const SdfIconType CloudDownloadFill = 410;
	public const SdfIconType CloudDownload = 411;
	public const SdfIconType CloudDrizzleFill = 412;
	public const SdfIconType CloudDrizzle = 413;
	public const SdfIconType CloudFill = 414;
	public const SdfIconType CloudFogFill = 415;
	public const SdfIconType CloudFog = 416;
	public const SdfIconType CloudFog2Fill = 417;
	public const SdfIconType CloudFog2 = 418;
	public const SdfIconType CloudHailFill = 419;
	public const SdfIconType CloudHail = 420;
	public const SdfIconType CloudHaze1 = 421;
	public const SdfIconType CloudHazeFill = 422;
	public const SdfIconType CloudHaze = 423;
	public const SdfIconType CloudHaze2Fill = 424;
	public const SdfIconType CloudLightningFill = 425;
	public const SdfIconType CloudLightningRainFill = 426;
	public const SdfIconType CloudLightningRain = 427;
	public const SdfIconType CloudLightning = 428;
	public const SdfIconType CloudMinusFill = 429;
	public const SdfIconType CloudMinus = 430;
	public const SdfIconType CloudMoonFill = 431;
	public const SdfIconType CloudMoon = 432;
	public const SdfIconType CloudPlusFill = 433;
	public const SdfIconType CloudPlus = 434;
	public const SdfIconType CloudRainFill = 435;
	public const SdfIconType CloudRainHeavyFill = 436;
	public const SdfIconType CloudRainHeavy = 437;
	public const SdfIconType CloudRain = 438;
	public const SdfIconType CloudSlashFill = 439;
	public const SdfIconType CloudSlash = 440;
	public const SdfIconType CloudSleetFill = 441;
	public const SdfIconType CloudSleet = 442;
	public const SdfIconType CloudSnowFill = 443;
	public const SdfIconType CloudSnow = 444;
	public const SdfIconType CloudSunFill = 445;
	public const SdfIconType CloudSun = 446;
	public const SdfIconType CloudUploadFill = 447;
	public const SdfIconType CloudUpload = 448;
	public const SdfIconType Cloud = 449;
	public const SdfIconType CloudsFill = 450;
	public const SdfIconType Clouds = 451;
	public const SdfIconType CloudyFill = 452;
	public const SdfIconType Cloudy = 453;
	public const SdfIconType CodeSlash = 454;
	public const SdfIconType CodeSquare = 455;
	public const SdfIconType Code = 456;
	public const SdfIconType CollectionFill = 457;
	public const SdfIconType CollectionPlayFill = 458;
	public const SdfIconType CollectionPlay = 459;
	public const SdfIconType Collection = 460;
	public const SdfIconType ColumnsGap = 461;
	public const SdfIconType Columns = 462;
	public const SdfIconType Command = 463;
	public const SdfIconType CompassFill = 464;
	public const SdfIconType Compass = 465;
	public const SdfIconType ConeStriped = 466;
	public const SdfIconType Cone = 467;
	public const SdfIconType Controller = 468;
	public const SdfIconType CpuFill = 469;
	public const SdfIconType Cpu = 470;
	public const SdfIconType CreditCard2BackFill = 471;
	public const SdfIconType CreditCard2Back = 472;
	public const SdfIconType CreditCard2FrontFill = 473;
	public const SdfIconType CreditCard2Front = 474;
	public const SdfIconType CreditCardFill = 475;
	public const SdfIconType CreditCard = 476;
	public const SdfIconType Crop = 477;
	public const SdfIconType CupFill = 478;
	public const SdfIconType CupStraw = 479;
	public const SdfIconType Cup = 480;
	public const SdfIconType CursorFill = 481;
	public const SdfIconType CursorText = 482;
	public const SdfIconType Cursor = 483;
	public const SdfIconType DashCircleDotted = 484;
	public const SdfIconType DashCircleFill = 485;
	public const SdfIconType DashCircle = 486;
	public const SdfIconType DashSquareDotted = 487;
	public const SdfIconType DashSquareFill = 488;
	public const SdfIconType DashSquare = 489;
	public const SdfIconType Dash = 490;
	public const SdfIconType Diagram2Fill = 491;
	public const SdfIconType Diagram2 = 492;
	public const SdfIconType Diagram3Fill = 493;
	public const SdfIconType Diagram3 = 494;
	public const SdfIconType DiamondFill = 495;
	public const SdfIconType DiamondHalf = 496;
	public const SdfIconType Diamond = 497;
	public const SdfIconType Dice1Fill = 498;
	public const SdfIconType Dice1 = 499;
	public const SdfIconType Dice2Fill = 500;
	public const SdfIconType Dice2 = 501;
	public const SdfIconType Dice3Fill = 502;
	public const SdfIconType Dice3 = 503;
	public const SdfIconType Dice4Fill = 504;
	public const SdfIconType Dice4 = 505;
	public const SdfIconType Dice5Fill = 506;
	public const SdfIconType Dice5 = 507;
	public const SdfIconType Dice6Fill = 508;
	public const SdfIconType Dice6 = 509;
	public const SdfIconType DiscFill = 510;
	public const SdfIconType Disc = 511;
	public const SdfIconType Discord = 512;
	public const SdfIconType DisplayFill = 513;
	public const SdfIconType Display = 514;
	public const SdfIconType DistributeHorizontal = 515;
	public const SdfIconType DistributeVertical = 516;
	public const SdfIconType DoorClosedFill = 517;
	public const SdfIconType DoorClosed = 518;
	public const SdfIconType DoorOpenFill = 519;
	public const SdfIconType DoorOpen = 520;
	public const SdfIconType Dot = 521;
	public const SdfIconType Download = 522;
	public const SdfIconType DropletFill = 523;
	public const SdfIconType DropletHalf = 524;
	public const SdfIconType Droplet = 525;
	public const SdfIconType Earbuds = 526;
	public const SdfIconType EaselFill = 527;
	public const SdfIconType Easel = 528;
	public const SdfIconType EggFill = 529;
	public const SdfIconType EggFried = 530;
	public const SdfIconType Egg = 531;
	public const SdfIconType EjectFill = 532;
	public const SdfIconType Eject = 533;
	public const SdfIconType EmojiAngryFill = 534;
	public const SdfIconType EmojiAngry = 535;
	public const SdfIconType EmojiDizzyFill = 536;
	public const SdfIconType EmojiDizzy = 537;
	public const SdfIconType EmojiExpressionlessFill = 538;
	public const SdfIconType EmojiExpressionless = 539;
	public const SdfIconType EmojiFrownFill = 540;
	public const SdfIconType EmojiFrown = 541;
	public const SdfIconType EmojiHeartEyesFill = 542;
	public const SdfIconType EmojiHeartEyes = 543;
	public const SdfIconType EmojiLaughingFill = 544;
	public const SdfIconType EmojiLaughing = 545;
	public const SdfIconType EmojiNeutralFill = 546;
	public const SdfIconType EmojiNeutral = 547;
	public const SdfIconType EmojiSmileFill = 548;
	public const SdfIconType EmojiSmileUpsideDownFill = 549;
	public const SdfIconType EmojiSmileUpsideDown = 550;
	public const SdfIconType EmojiSmile = 551;
	public const SdfIconType EmojiSunglassesFill = 552;
	public const SdfIconType EmojiSunglasses = 553;
	public const SdfIconType EmojiWinkFill = 554;
	public const SdfIconType EmojiWink = 555;
	public const SdfIconType EnvelopeFill = 556;
	public const SdfIconType EnvelopeOpenFill = 557;
	public const SdfIconType EnvelopeOpen = 558;
	public const SdfIconType Envelope = 559;
	public const SdfIconType EraserFill = 560;
	public const SdfIconType Eraser = 561;
	public const SdfIconType ExclamationCircleFill = 562;
	public const SdfIconType ExclamationCircle = 563;
	public const SdfIconType ExclamationDiamondFill = 564;
	public const SdfIconType ExclamationDiamond = 565;
	public const SdfIconType ExclamationOctagonFill = 566;
	public const SdfIconType ExclamationOctagon = 567;
	public const SdfIconType ExclamationSquareFill = 568;
	public const SdfIconType ExclamationSquare = 569;
	public const SdfIconType ExclamationTriangleFill = 570;
	public const SdfIconType ExclamationTriangle = 571;
	public const SdfIconType Exclamation = 572;
	public const SdfIconType Exclude = 573;
	public const SdfIconType EyeFill = 574;
	public const SdfIconType EyeSlashFill = 575;
	public const SdfIconType EyeSlash = 576;
	public const SdfIconType Eye = 577;
	public const SdfIconType Eyedropper = 578;
	public const SdfIconType Eyeglasses = 579;
	public const SdfIconType Facebook = 580;
	public const SdfIconType FileArrowDownFill = 581;
	public const SdfIconType FileArrowDown = 582;
	public const SdfIconType FileArrowUpFill = 583;
	public const SdfIconType FileArrowUp = 584;
	public const SdfIconType FileBarGraphFill = 585;
	public const SdfIconType FileBarGraph = 586;
	public const SdfIconType FileBinaryFill = 587;
	public const SdfIconType FileBinary = 588;
	public const SdfIconType FileBreakFill = 589;
	public const SdfIconType FileBreak = 590;
	public const SdfIconType FileCheckFill = 591;
	public const SdfIconType FileCheck = 592;
	public const SdfIconType FileCodeFill = 593;
	public const SdfIconType FileCode = 594;
	public const SdfIconType FileDiffFill = 595;
	public const SdfIconType FileDiff = 596;
	public const SdfIconType FileEarmarkArrowDownFill = 597;
	public const SdfIconType FileEarmarkArrowDown = 598;
	public const SdfIconType FileEarmarkArrowUpFill = 599;
	public const SdfIconType FileEarmarkArrowUp = 600;
	public const SdfIconType FileEarmarkBarGraphFill = 601;
	public const SdfIconType FileEarmarkBarGraph = 602;
	public const SdfIconType FileEarmarkBinaryFill = 603;
	public const SdfIconType FileEarmarkBinary = 604;
	public const SdfIconType FileEarmarkBreakFill = 605;
	public const SdfIconType FileEarmarkBreak = 606;
	public const SdfIconType FileEarmarkCheckFill = 607;
	public const SdfIconType FileEarmarkCheck = 608;
	public const SdfIconType FileEarmarkCodeFill = 609;
	public const SdfIconType FileEarmarkCode = 610;
	public const SdfIconType FileEarmarkDiffFill = 611;
	public const SdfIconType FileEarmarkDiff = 612;
	public const SdfIconType FileEarmarkEaselFill = 613;
	public const SdfIconType FileEarmarkEasel = 614;
	public const SdfIconType FileEarmarkExcelFill = 615;
	public const SdfIconType FileEarmarkExcel = 616;
	public const SdfIconType FileEarmarkFill = 617;
	public const SdfIconType FileEarmarkFontFill = 618;
	public const SdfIconType FileEarmarkFont = 619;
	public const SdfIconType FileEarmarkImageFill = 620;
	public const SdfIconType FileEarmarkImage = 621;
	public const SdfIconType FileEarmarkLockFill = 622;
	public const SdfIconType FileEarmarkLock = 623;
	public const SdfIconType FileEarmarkLock2Fill = 624;
	public const SdfIconType FileEarmarkLock2 = 625;
	public const SdfIconType FileEarmarkMedicalFill = 626;
	public const SdfIconType FileEarmarkMedical = 627;
	public const SdfIconType FileEarmarkMinusFill = 628;
	public const SdfIconType FileEarmarkMinus = 629;
	public const SdfIconType FileEarmarkMusicFill = 630;
	public const SdfIconType FileEarmarkMusic = 631;
	public const SdfIconType FileEarmarkPersonFill = 632;
	public const SdfIconType FileEarmarkPerson = 633;
	public const SdfIconType FileEarmarkPlayFill = 634;
	public const SdfIconType FileEarmarkPlay = 635;
	public const SdfIconType FileEarmarkPlusFill = 636;
	public const SdfIconType FileEarmarkPlus = 637;
	public const SdfIconType FileEarmarkPostFill = 638;
	public const SdfIconType FileEarmarkPost = 639;
	public const SdfIconType FileEarmarkPptFill = 640;
	public const SdfIconType FileEarmarkPpt = 641;
	public const SdfIconType FileEarmarkRichtextFill = 642;
	public const SdfIconType FileEarmarkRichtext = 643;
	public const SdfIconType FileEarmarkRuledFill = 644;
	public const SdfIconType FileEarmarkRuled = 645;
	public const SdfIconType FileEarmarkSlidesFill = 646;
	public const SdfIconType FileEarmarkSlides = 647;
	public const SdfIconType FileEarmarkSpreadsheetFill = 648;
	public const SdfIconType FileEarmarkSpreadsheet = 649;
	public const SdfIconType FileEarmarkTextFill = 650;
	public const SdfIconType FileEarmarkText = 651;
	public const SdfIconType FileEarmarkWordFill = 652;
	public const SdfIconType FileEarmarkWord = 653;
	public const SdfIconType FileEarmarkXFill = 654;
	public const SdfIconType FileEarmarkX = 655;
	public const SdfIconType FileEarmarkZipFill = 656;
	public const SdfIconType FileEarmarkZip = 657;
	public const SdfIconType FileEarmark = 658;
	public const SdfIconType FileEaselFill = 659;
	public const SdfIconType FileEasel = 660;
	public const SdfIconType FileExcelFill = 661;
	public const SdfIconType FileExcel = 662;
	public const SdfIconType FileFill = 663;
	public const SdfIconType FileFontFill = 664;
	public const SdfIconType FileFont = 665;
	public const SdfIconType FileImageFill = 666;
	public const SdfIconType FileImage = 667;
	public const SdfIconType FileLockFill = 668;
	public const SdfIconType FileLock = 669;
	public const SdfIconType FileLock2Fill = 670;
	public const SdfIconType FileLock2 = 671;
	public const SdfIconType FileMedicalFill = 672;
	public const SdfIconType FileMedical = 673;
	public const SdfIconType FileMinusFill = 674;
	public const SdfIconType FileMinus = 675;
	public const SdfIconType FileMusicFill = 676;
	public const SdfIconType FileMusic = 677;
	public const SdfIconType FilePersonFill = 678;
	public const SdfIconType FilePerson = 679;
	public const SdfIconType FilePlayFill = 680;
	public const SdfIconType FilePlay = 681;
	public const SdfIconType FilePlusFill = 682;
	public const SdfIconType FilePlus = 683;
	public const SdfIconType FilePostFill = 684;
	public const SdfIconType FilePost = 685;
	public const SdfIconType FilePptFill = 686;
	public const SdfIconType FilePpt = 687;
	public const SdfIconType FileRichtextFill = 688;
	public const SdfIconType FileRichtext = 689;
	public const SdfIconType FileRuledFill = 690;
	public const SdfIconType FileRuled = 691;
	public const SdfIconType FileSlidesFill = 692;
	public const SdfIconType FileSlides = 693;
	public const SdfIconType FileSpreadsheetFill = 694;
	public const SdfIconType FileSpreadsheet = 695;
	public const SdfIconType FileTextFill = 696;
	public const SdfIconType FileText = 697;
	public const SdfIconType FileWordFill = 698;
	public const SdfIconType FileWord = 699;
	public const SdfIconType FileXFill = 700;
	public const SdfIconType FileX = 701;
	public const SdfIconType FileZipFill = 702;
	public const SdfIconType FileZip = 703;
	public const SdfIconType File = 704;
	public const SdfIconType FilesAlt = 705;
	public const SdfIconType Files = 706;
	public const SdfIconType Film = 707;
	public const SdfIconType FilterCircleFill = 708;
	public const SdfIconType FilterCircle = 709;
	public const SdfIconType FilterLeft = 710;
	public const SdfIconType FilterRight = 711;
	public const SdfIconType FilterSquareFill = 712;
	public const SdfIconType FilterSquare = 713;
	public const SdfIconType Filter = 714;
	public const SdfIconType FlagFill = 715;
	public const SdfIconType Flag = 716;
	public const SdfIconType Flower1 = 717;
	public const SdfIconType Flower2 = 718;
	public const SdfIconType Flower3 = 719;
	public const SdfIconType FolderCheck = 720;
	public const SdfIconType FolderFill = 721;
	public const SdfIconType FolderMinus = 722;
	public const SdfIconType FolderPlus = 723;
	public const SdfIconType FolderSymlinkFill = 724;
	public const SdfIconType FolderSymlink = 725;
	public const SdfIconType FolderX = 726;
	public const SdfIconType Folder = 727;
	public const SdfIconType Folder2Open = 728;
	public const SdfIconType Folder2 = 729;
	public const SdfIconType Fonts = 730;
	public const SdfIconType ForwardFill = 731;
	public const SdfIconType Forward = 732;
	public const SdfIconType Front = 733;
	public const SdfIconType FullscreenExit = 734;
	public const SdfIconType Fullscreen = 735;
	public const SdfIconType FunnelFill = 736;
	public const SdfIconType Funnel = 737;
	public const SdfIconType GearFill = 738;
	public const SdfIconType GearWideConnected = 739;
	public const SdfIconType GearWide = 740;
	public const SdfIconType Gear = 741;
	public const SdfIconType Gem = 742;
	public const SdfIconType GeoAltFill = 743;
	public const SdfIconType GeoAlt = 744;
	public const SdfIconType GeoFill = 745;
	public const SdfIconType Geo = 746;
	public const SdfIconType GiftFill = 747;
	public const SdfIconType Gift = 748;
	public const SdfIconType Github = 749;
	public const SdfIconType Globe = 750;
	public const SdfIconType Globe2 = 751;
	public const SdfIconType Google = 752;
	public const SdfIconType GraphDown = 753;
	public const SdfIconType GraphUp = 754;
	public const SdfIconType Grid1x2Fill = 755;
	public const SdfIconType Grid1x2 = 756;
	public const SdfIconType Grid3x2GapFill = 757;
	public const SdfIconType Grid3x2Gap = 758;
	public const SdfIconType Grid3x2 = 759;
	public const SdfIconType Grid3x3GapFill = 760;
	public const SdfIconType Grid3x3Gap = 761;
	public const SdfIconType Grid3x3 = 762;
	public const SdfIconType GridFill = 763;
	public const SdfIconType Grid = 764;
	public const SdfIconType GripHorizontal = 765;
	public const SdfIconType GripVertical = 766;
	public const SdfIconType Hammer = 767;
	public const SdfIconType HandIndexFill = 768;
	public const SdfIconType HandIndexThumbFill = 769;
	public const SdfIconType HandIndexThumb = 770;
	public const SdfIconType HandIndex = 771;
	public const SdfIconType HandThumbsDownFill = 772;
	public const SdfIconType HandThumbsDown = 773;
	public const SdfIconType HandThumbsUpFill = 774;
	public const SdfIconType HandThumbsUp = 775;
	public const SdfIconType HandbagFill = 776;
	public const SdfIconType Handbag = 777;
	public const SdfIconType Hash = 778;
	public const SdfIconType HddFill = 779;
	public const SdfIconType HddNetworkFill = 780;
	public const SdfIconType HddNetwork = 781;
	public const SdfIconType HddRackFill = 782;
	public const SdfIconType HddRack = 783;
	public const SdfIconType HddStackFill = 784;
	public const SdfIconType HddStack = 785;
	public const SdfIconType Hdd = 786;
	public const SdfIconType Headphones = 787;
	public const SdfIconType Headset = 788;
	public const SdfIconType HeartFill = 789;
	public const SdfIconType HeartHalf = 790;
	public const SdfIconType Heart = 791;
	public const SdfIconType HeptagonFill = 792;
	public const SdfIconType HeptagonHalf = 793;
	public const SdfIconType Heptagon = 794;
	public const SdfIconType HexagonFill = 795;
	public const SdfIconType HexagonHalf = 796;
	public const SdfIconType Hexagon = 797;
	public const SdfIconType HourglassBottom = 798;
	public const SdfIconType HourglassSplit = 799;
	public const SdfIconType HourglassTop = 800;
	public const SdfIconType Hourglass = 801;
	public const SdfIconType HouseDoorFill = 802;
	public const SdfIconType HouseDoor = 803;
	public const SdfIconType HouseFill = 804;
	public const SdfIconType House = 805;
	public const SdfIconType Hr = 806;
	public const SdfIconType Hurricane = 807;
	public const SdfIconType ImageAlt = 808;
	public const SdfIconType ImageFill = 809;
	public const SdfIconType Image = 810;
	public const SdfIconType Images = 811;
	public const SdfIconType InboxFill = 812;
	public const SdfIconType Inbox = 813;
	public const SdfIconType InboxesFill = 814;
	public const SdfIconType Inboxes = 815;
	public const SdfIconType InfoCircleFill = 816;
	public const SdfIconType InfoCircle = 817;
	public const SdfIconType InfoSquareFill = 818;
	public const SdfIconType InfoSquare = 819;
	public const SdfIconType Info = 820;
	public const SdfIconType InputCursorText = 821;
	public const SdfIconType InputCursor = 822;
	public const SdfIconType Instagram = 823;
	public const SdfIconType Intersect = 824;
	public const SdfIconType JournalAlbum = 825;
	public const SdfIconType JournalArrowDown = 826;
	public const SdfIconType JournalArrowUp = 827;
	public const SdfIconType JournalBookmarkFill = 828;
	public const SdfIconType JournalBookmark = 829;
	public const SdfIconType JournalCheck = 830;
	public const SdfIconType JournalCode = 831;
	public const SdfIconType JournalMedical = 832;
	public const SdfIconType JournalMinus = 833;
	public const SdfIconType JournalPlus = 834;
	public const SdfIconType JournalRichtext = 835;
	public const SdfIconType JournalText = 836;
	public const SdfIconType JournalX = 837;
	public const SdfIconType Journal = 838;
	public const SdfIconType Journals = 839;
	public const SdfIconType Joystick = 840;
	public const SdfIconType JustifyLeft = 841;
	public const SdfIconType JustifyRight = 842;
	public const SdfIconType Justify = 843;
	public const SdfIconType KanbanFill = 844;
	public const SdfIconType Kanban = 845;
	public const SdfIconType KeyFill = 846;
	public const SdfIconType Key = 847;
	public const SdfIconType KeyboardFill = 848;
	public const SdfIconType Keyboard = 849;
	public const SdfIconType Ladder = 850;
	public const SdfIconType LampFill = 851;
	public const SdfIconType Lamp = 852;
	public const SdfIconType LaptopFill = 853;
	public const SdfIconType Laptop = 854;
	public const SdfIconType LayerBackward = 855;
	public const SdfIconType LayerForward = 856;
	public const SdfIconType LayersFill = 857;
	public const SdfIconType LayersHalf = 858;
	public const SdfIconType Layers = 859;
	public const SdfIconType LayoutSidebarInsetReverse = 860;
	public const SdfIconType LayoutSidebarInset = 861;
	public const SdfIconType LayoutSidebarReverse = 862;
	public const SdfIconType LayoutSidebar = 863;
	public const SdfIconType LayoutSplit = 864;
	public const SdfIconType LayoutTextSidebarReverse = 865;
	public const SdfIconType LayoutTextSidebar = 866;
	public const SdfIconType LayoutTextWindowReverse = 867;
	public const SdfIconType LayoutTextWindow = 868;
	public const SdfIconType LayoutThreeColumns = 869;
	public const SdfIconType LayoutWtf = 870;
	public const SdfIconType LifePreserver = 871;
	public const SdfIconType LightbulbFill = 872;
	public const SdfIconType LightbulbOffFill = 873;
	public const SdfIconType LightbulbOff = 874;
	public const SdfIconType Lightbulb = 875;
	public const SdfIconType LightningChargeFill = 876;
	public const SdfIconType LightningCharge = 877;
	public const SdfIconType LightningFill = 878;
	public const SdfIconType Lightning = 879;
	public const SdfIconType Link45deg = 880;
	public const SdfIconType Link = 881;
	public const SdfIconType Linkedin = 882;
	public const SdfIconType ListCheck = 883;
	public const SdfIconType ListNested = 884;
	public const SdfIconType ListOl = 885;
	public const SdfIconType ListStars = 886;
	public const SdfIconType ListTask = 887;
	public const SdfIconType ListUl = 888;
	public const SdfIconType List = 889;
	public const SdfIconType LockFill = 890;
	public const SdfIconType Lock = 891;
	public const SdfIconType Mailbox = 892;
	public const SdfIconType Mailbox2 = 893;
	public const SdfIconType MapFill = 894;
	public const SdfIconType Map = 895;
	public const SdfIconType MarkdownFill = 896;
	public const SdfIconType Markdown = 897;
	public const SdfIconType Mask = 898;
	public const SdfIconType MegaphoneFill = 899;
	public const SdfIconType Megaphone = 900;
	public const SdfIconType MenuAppFill = 901;
	public const SdfIconType MenuApp = 902;
	public const SdfIconType MenuButtonFill = 903;
	public const SdfIconType MenuButtonWideFill = 904;
	public const SdfIconType MenuButtonWide = 905;
	public const SdfIconType MenuButton = 906;
	public const SdfIconType MenuDown = 907;
	public const SdfIconType MenuUp = 908;
	public const SdfIconType MicFill = 909;
	public const SdfIconType MicMuteFill = 910;
	public const SdfIconType MicMute = 911;
	public const SdfIconType Mic = 912;
	public const SdfIconType MinecartLoaded = 913;
	public const SdfIconType Minecart = 914;
	public const SdfIconType Moisture = 915;
	public const SdfIconType MoonFill = 916;
	public const SdfIconType MoonStarsFill = 917;
	public const SdfIconType MoonStars = 918;
	public const SdfIconType Moon = 919;
	public const SdfIconType MouseFill = 920;
	public const SdfIconType Mouse = 921;
	public const SdfIconType Mouse2Fill = 922;
	public const SdfIconType Mouse2 = 923;
	public const SdfIconType Mouse3Fill = 924;
	public const SdfIconType Mouse3 = 925;
	public const SdfIconType MusicNoteBeamed = 926;
	public const SdfIconType MusicNoteList = 927;
	public const SdfIconType MusicNote = 928;
	public const SdfIconType MusicPlayerFill = 929;
	public const SdfIconType MusicPlayer = 930;
	public const SdfIconType Newspaper = 931;
	public const SdfIconType NodeMinusFill = 932;
	public const SdfIconType NodeMinus = 933;
	public const SdfIconType NodePlusFill = 934;
	public const SdfIconType NodePlus = 935;
	public const SdfIconType NutFill = 936;
	public const SdfIconType Nut = 937;
	public const SdfIconType OctagonFill = 938;
	public const SdfIconType OctagonHalf = 939;
	public const SdfIconType Octagon = 940;
	public const SdfIconType Option = 941;
	public const SdfIconType Outlet = 942;
	public const SdfIconType PaintBucket = 943;
	public const SdfIconType PaletteFill = 944;
	public const SdfIconType Palette = 945;
	public const SdfIconType Palette2 = 946;
	public const SdfIconType Paperclip = 947;
	public const SdfIconType Paragraph = 948;
	public const SdfIconType PatchCheckFill = 949;
	public const SdfIconType PatchCheck = 950;
	public const SdfIconType PatchExclamationFill = 951;
	public const SdfIconType PatchExclamation = 952;
	public const SdfIconType PatchMinusFill = 953;
	public const SdfIconType PatchMinus = 954;
	public const SdfIconType PatchPlusFill = 955;
	public const SdfIconType PatchPlus = 956;
	public const SdfIconType PatchQuestionFill = 957;
	public const SdfIconType PatchQuestion = 958;
	public const SdfIconType PauseBtnFill = 959;
	public const SdfIconType PauseBtn = 960;
	public const SdfIconType PauseCircleFill = 961;
	public const SdfIconType PauseCircle = 962;
	public const SdfIconType PauseFill = 963;
	public const SdfIconType Pause = 964;
	public const SdfIconType PeaceFill = 965;
	public const SdfIconType Peace = 966;
	public const SdfIconType PenFill = 967;
	public const SdfIconType Pen = 968;
	public const SdfIconType PencilFill = 969;
	public const SdfIconType PencilSquare = 970;
	public const SdfIconType Pencil = 971;
	public const SdfIconType PentagonFill = 972;
	public const SdfIconType PentagonHalf = 973;
	public const SdfIconType Pentagon = 974;
	public const SdfIconType PeopleFill = 975;
	public const SdfIconType People = 976;
	public const SdfIconType Percent = 977;
	public const SdfIconType PersonBadgeFill = 978;
	public const SdfIconType PersonBadge = 979;
	public const SdfIconType PersonBoundingBox = 980;
	public const SdfIconType PersonCheckFill = 981;
	public const SdfIconType PersonCheck = 982;
	public const SdfIconType PersonCircle = 983;
	public const SdfIconType PersonDashFill = 984;
	public const SdfIconType PersonDash = 985;
	public const SdfIconType PersonFill = 986;
	public const SdfIconType PersonLinesFill = 987;
	public const SdfIconType PersonPlusFill = 988;
	public const SdfIconType PersonPlus = 989;
	public const SdfIconType PersonSquare = 990;
	public const SdfIconType PersonXFill = 991;
	public const SdfIconType PersonX = 992;
	public const SdfIconType Person = 993;
	public const SdfIconType PhoneFill = 994;
	public const SdfIconType PhoneLandscapeFill = 995;
	public const SdfIconType PhoneLandscape = 996;
	public const SdfIconType PhoneVibrateFill = 997;
	public const SdfIconType PhoneVibrate = 998;
	public const SdfIconType Phone = 999;
	public const SdfIconType PieChartFill = 1000;
	public const SdfIconType PieChart = 1001;
	public const SdfIconType PinAngleFill = 1002;
	public const SdfIconType PinAngle = 1003;
	public const SdfIconType PinFill = 1004;
	public const SdfIconType Pin = 1005;
	public const SdfIconType PipFill = 1006;
	public const SdfIconType Pip = 1007;
	public const SdfIconType PlayBtnFill = 1008;
	public const SdfIconType PlayBtn = 1009;
	public const SdfIconType PlayCircleFill = 1010;
	public const SdfIconType PlayCircle = 1011;
	public const SdfIconType PlayFill = 1012;
	public const SdfIconType Play = 1013;
	public const SdfIconType PlugFill = 1014;
	public const SdfIconType Plug = 1015;
	public const SdfIconType PlusCircleDotted = 1016;
	public const SdfIconType PlusCircleFill = 1017;
	public const SdfIconType PlusCircle = 1018;
	public const SdfIconType PlusSquareDotted = 1019;
	public const SdfIconType PlusSquareFill = 1020;
	public const SdfIconType PlusSquare = 1021;
	public const SdfIconType Plus = 1022;
	public const SdfIconType Power = 1023;
	public const SdfIconType PrinterFill = 1024;
	public const SdfIconType Printer = 1025;
	public const SdfIconType PuzzleFill = 1026;
	public const SdfIconType Puzzle = 1027;
	public const SdfIconType QuestionCircleFill = 1028;
	public const SdfIconType QuestionCircle = 1029;
	public const SdfIconType QuestionDiamondFill = 1030;
	public const SdfIconType QuestionDiamond = 1031;
	public const SdfIconType QuestionOctagonFill = 1032;
	public const SdfIconType QuestionOctagon = 1033;
	public const SdfIconType QuestionSquareFill = 1034;
	public const SdfIconType QuestionSquare = 1035;
	public const SdfIconType Question = 1036;
	public const SdfIconType Rainbow = 1037;
	public const SdfIconType ReceiptCutoff = 1038;
	public const SdfIconType Receipt = 1039;
	public const SdfIconType Reception0 = 1040;
	public const SdfIconType Reception1 = 1041;
	public const SdfIconType Reception2 = 1042;
	public const SdfIconType Reception3 = 1043;
	public const SdfIconType Reception4 = 1044;
	public const SdfIconType RecordBtnFill = 1045;
	public const SdfIconType RecordBtn = 1046;
	public const SdfIconType RecordCircleFill = 1047;
	public const SdfIconType RecordCircle = 1048;
	public const SdfIconType RecordFill = 1049;
	public const SdfIconType Record = 1050;
	public const SdfIconType Record2Fill = 1051;
	public const SdfIconType Record2 = 1052;
	public const SdfIconType ReplyAllFill = 1053;
	public const SdfIconType ReplyAll = 1054;
	public const SdfIconType ReplyFill = 1055;
	public const SdfIconType Reply = 1056;
	public const SdfIconType RssFill = 1057;
	public const SdfIconType Rss = 1058;
	public const SdfIconType Rulers = 1059;
	public const SdfIconType SaveFill = 1060;
	public const SdfIconType Save = 1061;
	public const SdfIconType Save2Fill = 1062;
	public const SdfIconType Save2 = 1063;
	public const SdfIconType Scissors = 1064;
	public const SdfIconType Screwdriver = 1065;
	public const SdfIconType Search = 1066;
	public const SdfIconType SegmentedNav = 1067;
	public const SdfIconType Server = 1068;
	public const SdfIconType ShareFill = 1069;
	public const SdfIconType Share = 1070;
	public const SdfIconType ShieldCheck = 1071;
	public const SdfIconType ShieldExclamation = 1072;
	public const SdfIconType ShieldFillCheck = 1073;
	public const SdfIconType ShieldFillExclamation = 1074;
	public const SdfIconType ShieldFillMinus = 1075;
	public const SdfIconType ShieldFillPlus = 1076;
	public const SdfIconType ShieldFillX = 1077;
	public const SdfIconType ShieldFill = 1078;
	public const SdfIconType ShieldLockFill = 1079;
	public const SdfIconType ShieldLock = 1080;
	public const SdfIconType ShieldMinus = 1081;
	public const SdfIconType ShieldPlus = 1082;
	public const SdfIconType ShieldShaded = 1083;
	public const SdfIconType ShieldSlashFill = 1084;
	public const SdfIconType ShieldSlash = 1085;
	public const SdfIconType ShieldX = 1086;
	public const SdfIconType Shield = 1087;
	public const SdfIconType ShiftFill = 1088;
	public const SdfIconType Shift = 1089;
	public const SdfIconType ShopWindow = 1090;
	public const SdfIconType Shop = 1091;
	public const SdfIconType Shuffle = 1092;
	public const SdfIconType Signpost2Fill = 1093;
	public const SdfIconType Signpost2 = 1094;
	public const SdfIconType SignpostFill = 1095;
	public const SdfIconType SignpostSplitFill = 1096;
	public const SdfIconType SignpostSplit = 1097;
	public const SdfIconType Signpost = 1098;
	public const SdfIconType SimFill = 1099;
	public const SdfIconType Sim = 1100;
	public const SdfIconType SkipBackwardBtnFill = 1101;
	public const SdfIconType SkipBackwardBtn = 1102;
	public const SdfIconType SkipBackwardCircleFill = 1103;
	public const SdfIconType SkipBackwardCircle = 1104;
	public const SdfIconType SkipBackwardFill = 1105;
	public const SdfIconType SkipBackward = 1106;
	public const SdfIconType SkipEndBtnFill = 1107;
	public const SdfIconType SkipEndBtn = 1108;
	public const SdfIconType SkipEndCircleFill = 1109;
	public const SdfIconType SkipEndCircle = 1110;
	public const SdfIconType SkipEndFill = 1111;
	public const SdfIconType SkipEnd = 1112;
	public const SdfIconType SkipForwardBtnFill = 1113;
	public const SdfIconType SkipForwardBtn = 1114;
	public const SdfIconType SkipForwardCircleFill = 1115;
	public const SdfIconType SkipForwardCircle = 1116;
	public const SdfIconType SkipForwardFill = 1117;
	public const SdfIconType SkipForward = 1118;
	public const SdfIconType SkipStartBtnFill = 1119;
	public const SdfIconType SkipStartBtn = 1120;
	public const SdfIconType SkipStartCircleFill = 1121;
	public const SdfIconType SkipStartCircle = 1122;
	public const SdfIconType SkipStartFill = 1123;
	public const SdfIconType SkipStart = 1124;
	public const SdfIconType Slack = 1125;
	public const SdfIconType SlashCircleFill = 1126;
	public const SdfIconType SlashCircle = 1127;
	public const SdfIconType SlashSquareFill = 1128;
	public const SdfIconType SlashSquare = 1129;
	public const SdfIconType Slash = 1130;
	public const SdfIconType Sliders = 1131;
	public const SdfIconType Smartwatch = 1132;
	public const SdfIconType Snow = 1133;
	public const SdfIconType Snow2 = 1134;
	public const SdfIconType Snow3 = 1135;
	public const SdfIconType SortAlphaDownAlt = 1136;
	public const SdfIconType SortAlphaDown = 1137;
	public const SdfIconType SortAlphaUpAlt = 1138;
	public const SdfIconType SortAlphaUp = 1139;
	public const SdfIconType SortDownAlt = 1140;
	public const SdfIconType SortDown = 1141;
	public const SdfIconType SortNumericDownAlt = 1142;
	public const SdfIconType SortNumericDown = 1143;
	public const SdfIconType SortNumericUpAlt = 1144;
	public const SdfIconType SortNumericUp = 1145;
	public const SdfIconType SortUpAlt = 1146;
	public const SdfIconType SortUp = 1147;
	public const SdfIconType Soundwave = 1148;
	public const SdfIconType SpeakerFill = 1149;
	public const SdfIconType Speaker = 1150;
	public const SdfIconType Speedometer = 1151;
	public const SdfIconType Speedometer2 = 1152;
	public const SdfIconType Spellcheck = 1153;
	public const SdfIconType SquareFill = 1154;
	public const SdfIconType SquareHalf = 1155;
	public const SdfIconType Square = 1156;
	public const SdfIconType Stack = 1157;
	public const SdfIconType StarFill = 1158;
	public const SdfIconType StarHalf = 1159;
	public const SdfIconType Star = 1160;
	public const SdfIconType Stars = 1161;
	public const SdfIconType StickiesFill = 1162;
	public const SdfIconType Stickies = 1163;
	public const SdfIconType StickyFill = 1164;
	public const SdfIconType Sticky = 1165;
	public const SdfIconType StopBtnFill = 1166;
	public const SdfIconType StopBtn = 1167;
	public const SdfIconType StopCircleFill = 1168;
	public const SdfIconType StopCircle = 1169;
	public const SdfIconType StopFill = 1170;
	public const SdfIconType Stop = 1171;
	public const SdfIconType StoplightsFill = 1172;
	public const SdfIconType Stoplights = 1173;
	public const SdfIconType StopwatchFill = 1174;
	public const SdfIconType Stopwatch = 1175;
	public const SdfIconType Subtract = 1176;
	public const SdfIconType SuitClubFill = 1177;
	public const SdfIconType SuitClub = 1178;
	public const SdfIconType SuitDiamondFill = 1179;
	public const SdfIconType SuitDiamond = 1180;
	public const SdfIconType SuitHeartFill = 1181;
	public const SdfIconType SuitHeart = 1182;
	public const SdfIconType SuitSpadeFill = 1183;
	public const SdfIconType SuitSpade = 1184;
	public const SdfIconType SunFill = 1185;
	public const SdfIconType Sun = 1186;
	public const SdfIconType Sunglasses = 1187;
	public const SdfIconType SunriseFill = 1188;
	public const SdfIconType Sunrise = 1189;
	public const SdfIconType SunsetFill = 1190;
	public const SdfIconType Sunset = 1191;
	public const SdfIconType SymmetryHorizontal = 1192;
	public const SdfIconType SymmetryVertical = 1193;
	public const SdfIconType Table = 1194;
	public const SdfIconType TabletFill = 1195;
	public const SdfIconType TabletLandscapeFill = 1196;
	public const SdfIconType TabletLandscape = 1197;
	public const SdfIconType Tablet = 1198;
	public const SdfIconType TagFill = 1199;
	public const SdfIconType Tag = 1200;
	public const SdfIconType TagsFill = 1201;
	public const SdfIconType Tags = 1202;
	public const SdfIconType Telegram = 1203;
	public const SdfIconType TelephoneFill = 1204;
	public const SdfIconType TelephoneForwardFill = 1205;
	public const SdfIconType TelephoneForward = 1206;
	public const SdfIconType TelephoneInboundFill = 1207;
	public const SdfIconType TelephoneInbound = 1208;
	public const SdfIconType TelephoneMinusFill = 1209;
	public const SdfIconType TelephoneMinus = 1210;
	public const SdfIconType TelephoneOutboundFill = 1211;
	public const SdfIconType TelephoneOutbound = 1212;
	public const SdfIconType TelephonePlusFill = 1213;
	public const SdfIconType TelephonePlus = 1214;
	public const SdfIconType TelephoneXFill = 1215;
	public const SdfIconType TelephoneX = 1216;
	public const SdfIconType Telephone = 1217;
	public const SdfIconType TerminalFill = 1218;
	public const SdfIconType Terminal = 1219;
	public const SdfIconType TextCenter = 1220;
	public const SdfIconType TextIndentLeft = 1221;
	public const SdfIconType TextIndentRight = 1222;
	public const SdfIconType TextLeft = 1223;
	public const SdfIconType TextParagraph = 1224;
	public const SdfIconType TextRight = 1225;
	public const SdfIconType TextareaResize = 1226;
	public const SdfIconType TextareaT = 1227;
	public const SdfIconType Textarea = 1228;
	public const SdfIconType ThermometerHalf = 1229;
	public const SdfIconType ThermometerHigh = 1230;
	public const SdfIconType ThermometerLow = 1231;
	public const SdfIconType ThermometerSnow = 1232;
	public const SdfIconType ThermometerSun = 1233;
	public const SdfIconType Thermometer = 1234;
	public const SdfIconType ThreeDotsVertical = 1235;
	public const SdfIconType ThreeDots = 1236;
	public const SdfIconType ToggleOff = 1237;
	public const SdfIconType ToggleOn = 1238;
	public const SdfIconType Toggle2Off = 1239;
	public const SdfIconType Toggle2On = 1240;
	public const SdfIconType Toggles = 1241;
	public const SdfIconType Toggles2 = 1242;
	public const SdfIconType Tools = 1243;
	public const SdfIconType Tornado = 1244;
	public const SdfIconType TrashFill = 1245;
	public const SdfIconType Trash = 1246;
	public const SdfIconType Trash2Fill = 1247;
	public const SdfIconType Trash2 = 1248;
	public const SdfIconType TreeFill = 1249;
	public const SdfIconType Tree = 1250;
	public const SdfIconType TriangleFill = 1251;
	public const SdfIconType TriangleHalf = 1252;
	public const SdfIconType Triangle = 1253;
	public const SdfIconType TrophyFill = 1254;
	public const SdfIconType Trophy = 1255;
	public const SdfIconType TropicalStorm = 1256;
	public const SdfIconType TruckFlatbed = 1257;
	public const SdfIconType Truck = 1258;
	public const SdfIconType Tsunami = 1259;
	public const SdfIconType TvFill = 1260;
	public const SdfIconType Tv = 1261;
	public const SdfIconType Twitch = 1262;
	public const SdfIconType Twitter = 1263;
	public const SdfIconType TypeBold = 1264;
	public const SdfIconType TypeH1 = 1265;
	public const SdfIconType TypeH2 = 1266;
	public const SdfIconType TypeH3 = 1267;
	public const SdfIconType TypeItalic = 1268;
	public const SdfIconType TypeStrikethrough = 1269;
	public const SdfIconType TypeUnderline = 1270;
	public const SdfIconType Type = 1271;
	public const SdfIconType UiChecksGrid = 1272;
	public const SdfIconType UiChecks = 1273;
	public const SdfIconType UiRadiosGrid = 1274;
	public const SdfIconType UiRadios = 1275;
	public const SdfIconType UmbrellaFill = 1276;
	public const SdfIconType Umbrella = 1277;
	public const SdfIconType Union = 1278;
	public const SdfIconType UnlockFill = 1279;
	public const SdfIconType Unlock = 1280;
	public const SdfIconType UpcScan = 1281;
	public const SdfIconType Upc = 1282;
	public const SdfIconType Upload = 1283;
	public const SdfIconType VectorPen = 1284;
	public const SdfIconType ViewList = 1285;
	public const SdfIconType ViewStacked = 1286;
	public const SdfIconType VinylFill = 1287;
	public const SdfIconType Vinyl = 1288;
	public const SdfIconType Voicemail = 1289;
	public const SdfIconType VolumeDownFill = 1290;
	public const SdfIconType VolumeDown = 1291;
	public const SdfIconType VolumeMuteFill = 1292;
	public const SdfIconType VolumeMute = 1293;
	public const SdfIconType VolumeOffFill = 1294;
	public const SdfIconType VolumeOff = 1295;
	public const SdfIconType VolumeUpFill = 1296;
	public const SdfIconType VolumeUp = 1297;
	public const SdfIconType Vr = 1298;
	public const SdfIconType W1717 = 1299;
	public const SdfIconType W1718 = 1300;
	public const SdfIconType W1719 = 1301;
	public const SdfIconType Watch = 1302;
	public const SdfIconType Water = 1303;
	public const SdfIconType Whatsapp = 1304;
	public const SdfIconType Wifi1 = 1305;
	public const SdfIconType Wifi2 = 1306;
	public const SdfIconType WifiOff = 1307;
	public const SdfIconType Wifi = 1308;
	public const SdfIconType Wind = 1309;
	public const SdfIconType WindowDock = 1310;
	public const SdfIconType WindowSidebar = 1311;
	public const SdfIconType Window = 1312;
	public const SdfIconType Wrench = 1313;
	public const SdfIconType XCircleFill = 1314;
	public const SdfIconType XCircle = 1315;
	public const SdfIconType XDiamondFill = 1316;
	public const SdfIconType XDiamond = 1317;
	public const SdfIconType XOctagonFill = 1318;
	public const SdfIconType XOctagon = 1319;
	public const SdfIconType XSquareFill = 1320;
	public const SdfIconType XSquare = 1321;
	public const SdfIconType X = 1322;
	public const SdfIconType Youtube = 1323;
	public const SdfIconType ZoomIn = 1324;
	public const SdfIconType ZoomOut = 1325;
	public const SdfIconType Bank = 1326;
	public const SdfIconType Bank2 = 1327;
	public const SdfIconType BellSlashFill = 1328;
	public const SdfIconType BellSlash = 1329;
	public const SdfIconType C1748 = 1330;
	public const SdfIconType CheckLg = 1331;
	public const SdfIconType Coin = 1332;
	public const SdfIconType Currency1751 = 1333;
	public const SdfIconType CurrencyDollar = 1334;
	public const SdfIconType CurrencyEuro = 1335;
	public const SdfIconType CurrencyExchange = 1336;
	public const SdfIconType CurrencyPound = 1337;
	public const SdfIconType CurrencyYen = 1338;
	public const SdfIconType DashLg = 1339;
	public const SdfIconType ExclamationLg = 1340;
	public const SdfIconType FileEarmarkPdfFill = 1341;
	public const SdfIconType FileEarmarkPdf = 1342;
	public const SdfIconType FilePdfFill = 1343;
	public const SdfIconType FilePdf = 1344;
	public const SdfIconType GenderAmbiguous = 1345;
	public const SdfIconType GenderFemale = 1346;
	public const SdfIconType GenderMale = 1347;
	public const SdfIconType GenderTrans = 1348;
	public const SdfIconType HeadsetVr = 1349;
	public const SdfIconType InfoLg = 1350;
	public const SdfIconType Mastodon = 1351;
	public const SdfIconType Messenger = 1352;
	public const SdfIconType PiggyBankFill = 1353;
	public const SdfIconType PiggyBank = 1354;
	public const SdfIconType PinMapFill = 1355;
	public const SdfIconType PinMap = 1356;
	public const SdfIconType PlusLg = 1357;
	public const SdfIconType QuestionLg = 1358;
	public const SdfIconType Recycle = 1359;
	public const SdfIconType Reddit = 1360;
	public const SdfIconType SafeFill = 1361;
	public const SdfIconType Safe2Fill = 1362;
	public const SdfIconType Safe2 = 1363;
	public const SdfIconType SdCardFill = 1364;
	public const SdfIconType SdCard = 1365;
	public const SdfIconType Skype = 1366;
	public const SdfIconType SlashLg = 1367;
	public const SdfIconType Translate = 1368;
	public const SdfIconType XLg = 1369;
	public const SdfIconType Safe = 1370;
	public const SdfIconType Apple = 1371;
	public const SdfIconType Microsoft = 1372;
	public const SdfIconType Windows = 1373;
	public const SdfIconType Behance = 1374;
	public const SdfIconType Dribbble = 1375;
	public const SdfIconType Line = 1376;
	public const SdfIconType Medium = 1377;
	public const SdfIconType Paypal = 1378;
	public const SdfIconType Pinterest = 1379;
	public const SdfIconType Signal = 1380;
	public const SdfIconType Snapchat = 1381;
	public const SdfIconType Spotify = 1382;
	public const SdfIconType StackOverflow = 1383;
	public const SdfIconType Strava = 1384;
	public const SdfIconType Wordpress = 1385;
	public const SdfIconType Vimeo = 1386;
	public const SdfIconType Activity = 1387;
	public const SdfIconType Easel2Fill = 1388;
	public const SdfIconType Easel2 = 1389;
	public const SdfIconType Easel3Fill = 1390;
	public const SdfIconType Easel3 = 1391;
	public const SdfIconType Fan = 1392;
	public const SdfIconType Fingerprint = 1393;
	public const SdfIconType GraphDownArrow = 1394;
	public const SdfIconType GraphUpArrow = 1395;
	public const SdfIconType Hypnotize = 1396;
	public const SdfIconType Magic = 1397;
	public const SdfIconType PersonRolodex = 1398;
	public const SdfIconType PersonVideo = 1399;
	public const SdfIconType PersonVideo2 = 1400;
	public const SdfIconType PersonVideo3 = 1401;
	public const SdfIconType PersonWorkspace = 1402;
	public const SdfIconType Radioactive = 1403;
	public const SdfIconType WebcamFill = 1404;
	public const SdfIconType Webcam = 1405;
	public const SdfIconType YinYang = 1406;
	public const SdfIconType BandaidFill = 1407;
	public const SdfIconType Bandaid = 1408;
	public const SdfIconType Bluetooth = 1409;
	public const SdfIconType BodyText = 1410;
	public const SdfIconType Boombox = 1411;
	public const SdfIconType Boxes = 1412;
	public const SdfIconType DpadFill = 1413;
	public const SdfIconType Dpad = 1414;
	public const SdfIconType EarFill = 1415;
	public const SdfIconType Ear = 1416;
	public const SdfIconType EnvelopeCheck1 = 1417;
	public const SdfIconType EnvelopeCheckFill = 1418;
	public const SdfIconType EnvelopeCheck = 1419;
	public const SdfIconType EnvelopeDash1 = 1420;
	public const SdfIconType EnvelopeDashFill = 1421;
	public const SdfIconType EnvelopeDash = 1422;
	public const SdfIconType EnvelopeExclamation1 = 1423;
	public const SdfIconType EnvelopeExclamationFill = 1424;
	public const SdfIconType EnvelopeExclamation = 1425;
	public const SdfIconType EnvelopePlusFill = 1426;
	public const SdfIconType EnvelopePlus = 1427;
	public const SdfIconType EnvelopeSlash1 = 1428;
	public const SdfIconType EnvelopeSlashFill = 1429;
	public const SdfIconType EnvelopeSlash = 1430;
	public const SdfIconType EnvelopeX1 = 1431;
	public const SdfIconType EnvelopeXFill = 1432;
	public const SdfIconType EnvelopeX = 1433;
	public const SdfIconType ExplicitFill = 1434;
	public const SdfIconType Explicit = 1435;
	public const SdfIconType Git = 1436;
	public const SdfIconType Infinity = 1437;
	public const SdfIconType ListColumnsReverse = 1438;
	public const SdfIconType ListColumns = 1439;
	public const SdfIconType Meta = 1440;
	public const SdfIconType MortorboardFill = 1441;
	public const SdfIconType Mortorboard = 1442;
	public const SdfIconType NintendoSwitch = 1443;
	public const SdfIconType PcDisplayHorizontal = 1444;
	public const SdfIconType PcDisplay = 1445;
	public const SdfIconType PcHorizontal = 1446;
	public const SdfIconType Pc = 1447;
	public const SdfIconType Playstation = 1448;
	public const SdfIconType PlusSlashMinus = 1449;
	public const SdfIconType ProjectorFill = 1450;
	public const SdfIconType Projector = 1451;
	public const SdfIconType QrCodeScan = 1452;
	public const SdfIconType QrCode = 1453;
	public const SdfIconType Quora = 1454;
	public const SdfIconType Quote = 1455;
	public const SdfIconType Robot = 1456;
	public const SdfIconType SendCheckFill = 1457;
	public const SdfIconType SendCheck = 1458;
	public const SdfIconType SendDashFill = 1459;
	public const SdfIconType SendDash = 1460;
	public const SdfIconType SendExclamation1 = 1461;
	public const SdfIconType SendExclamationFill = 1462;
	public const SdfIconType SendExclamation = 1463;
	public const SdfIconType SendFill = 1464;
	public const SdfIconType SendPlusFill = 1465;
	public const SdfIconType SendPlus = 1466;
	public const SdfIconType SendSlashFill = 1467;
	public const SdfIconType SendSlash = 1468;
	public const SdfIconType SendXFill = 1469;
	public const SdfIconType SendX = 1470;
	public const SdfIconType Send = 1471;
	public const SdfIconType Steam = 1472;
	public const SdfIconType TerminalDash1 = 1473;
	public const SdfIconType TerminalDash = 1474;
	public const SdfIconType TerminalPlus = 1475;
	public const SdfIconType TerminalSplit = 1476;
	public const SdfIconType TicketDetailedFill = 1477;
	public const SdfIconType TicketDetailed = 1478;
	public const SdfIconType TicketFill = 1479;
	public const SdfIconType TicketPerforatedFill = 1480;
	public const SdfIconType TicketPerforated = 1481;
	public const SdfIconType Ticket = 1482;
	public const SdfIconType Tiktok = 1483;
	public const SdfIconType WindowDash = 1484;
	public const SdfIconType WindowDesktop = 1485;
	public const SdfIconType WindowFullscreen = 1486;
	public const SdfIconType WindowPlus = 1487;
	public const SdfIconType WindowSplit = 1488;
	public const SdfIconType WindowStack = 1489;
	public const SdfIconType WindowX = 1490;
	public const SdfIconType Xbox = 1491;
	public const SdfIconType Ethernet = 1492;
	public const SdfIconType HdmiFill = 1493;
	public const SdfIconType Hdmi = 1494;
	public const SdfIconType UsbCFill = 1495;
	public const SdfIconType UsbC = 1496;
	public const SdfIconType UsbFill = 1497;
	public const SdfIconType UsbPlugFill = 1498;
	public const SdfIconType UsbPlug = 1499;
	public const SdfIconType UsbSymbol = 1500;
	public const SdfIconType Usb = 1501;
	public const SdfIconType BoomboxFill = 1502;
	public const SdfIconType Displayport1 = 1503;
	public const SdfIconType Displayport = 1504;
	public const SdfIconType GpuCard = 1505;
	public const SdfIconType Memory = 1506;
	public const SdfIconType ModemFill = 1507;
	public const SdfIconType Modem = 1508;
	public const SdfIconType MotherboardFill = 1509;
	public const SdfIconType Motherboard = 1510;
	public const SdfIconType OpticalAudioFill = 1511;
	public const SdfIconType OpticalAudio = 1512;
	public const SdfIconType PciCard = 1513;
	public const SdfIconType RouterFill = 1514;
	public const SdfIconType Router = 1515;
	public const SdfIconType SsdFill = 1516;
	public const SdfIconType Ssd = 1517;
	public const SdfIconType ThunderboltFill = 1518;
	public const SdfIconType Thunderbolt = 1519;
	public const SdfIconType UsbDriveFill = 1520;
	public const SdfIconType UsbDrive = 1521;
	public const SdfIconType UsbMicroFill = 1522;
	public const SdfIconType UsbMicro = 1523;
	public const SdfIconType UsbMiniFill = 1524;
	public const SdfIconType UsbMini = 1525;
	public const SdfIconType CloudHaze2 = 1526;
	public const SdfIconType DeviceHddFill = 1527;
	public const SdfIconType DeviceHdd = 1528;
	public const SdfIconType DeviceSsdFill = 1529;
	public const SdfIconType DeviceSsd = 1530;
	public const SdfIconType DisplayportFill = 1531;
	public const SdfIconType MortarboardFill = 1532;
	public const SdfIconType Mortarboard = 1533;
	public const SdfIconType TerminalX = 1534;
}

// Namespace: Sirenix.OdinInspector
[Flags]
public enum SearchFilterOptions // TypeDefIndex: 26772
{
	// Fields
	public int value__; // 0x0
	public const SearchFilterOptions PropertyName = 1;
	public const SearchFilterOptions PropertyNiceName = 2;
	public const SearchFilterOptions TypeOfValue = 4;
	public const SearchFilterOptions ValueToString = 8;
	public const SearchFilterOptions ISearchFilterableInterface = 16;
	public const SearchFilterOptions All = -1;
}

// Namespace: Sirenix.OdinInspector
public enum TitleAlignments // TypeDefIndex: 26773
{
	// Fields
	public int value__; // 0x0
	public const TitleAlignments Left = 0;
	public const TitleAlignments Centered = 1;
	public const TitleAlignments Right = 2;
	public const TitleAlignments Split = 3;
}

// Namespace: Sirenix.OdinInspector.Internal
public interface ISubGroupProviderAttribute // TypeDefIndex: 26774
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<PropertyGroupAttribute> GetSubGroupAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string RepathMemberAttribute(PropertyGroupAttribute attr);
}

