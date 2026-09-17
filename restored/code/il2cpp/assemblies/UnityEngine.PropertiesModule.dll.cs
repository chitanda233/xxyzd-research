// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27781
{}

// Namespace: Unity.Properties
[Usage(384)]
public class CreatePropertyAttribute : Attribute // TypeDefIndex: 27782
{}

// Namespace: Unity.Properties
[Usage(256)]
public class DontCreatePropertyAttribute : Attribute // TypeDefIndex: 27783
{}

// Namespace: Unity.Properties
public sealed class PropertyGetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27784
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52988CC Offset: 0x52948CC VA: 0x52988CC
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529897C Offset: 0x529497C VA: 0x529897C
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public sealed class PropertySetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27785
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298990 Offset: 0x5294990 VA: 0x5298990
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298A44 Offset: 0x5294A44 VA: 0x5298A44
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 27786
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D42B14 Offset: 0x5D3EB14 VA: 0x5D42B14
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D42B1C Offset: 0x5D3EB1C VA: 0x5D42B1C
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IProperty // TypeDefIndex: 27787
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type DeclaredValueType();
}

// Namespace: Unity.Properties
public interface IProperty<TContainer> : IProperty // TypeDefIndex: 27788
{}

// Namespace: Unity.Properties
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes // TypeDefIndex: 27789
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298A58 Offset: 0x5294A58 VA: 0x5298A58
	|-Property<Bounds, Vector3>.DeclaredValueType
	|
	|-RVA: 0x52991D4 Offset: 0x52951D4 VA: 0x52991D4
	|-Property<BoundsInt, Vector3Int>.DeclaredValueType
	|
	|-RVA: 0x5299950 Offset: 0x5295950 VA: 0x5299950
	|-Property<Color, float>.DeclaredValueType
	|
	|-RVA: 0x529A0CC Offset: 0x52960CC VA: 0x529A0CC
	|-Property<object, int>.DeclaredValueType
	|
	|-RVA: 0x529A848 Offset: 0x5296848 VA: 0x529A848
	|-Property<Rect, float>.DeclaredValueType
	|
	|-RVA: 0x529AFC4 Offset: 0x5296FC4 VA: 0x529AFC4
	|-Property<RectInt, int>.DeclaredValueType
	|
	|-RVA: 0x529B740 Offset: 0x5297740 VA: 0x529B740
	|-Property<Vector2, float>.DeclaredValueType
	|
	|-RVA: 0x529BEBC Offset: 0x5297EBC VA: 0x529BEBC
	|-Property<Vector2Int, int>.DeclaredValueType
	|
	|-RVA: 0x529C638 Offset: 0x5298638 VA: 0x529C638
	|-Property<Vector3, float>.DeclaredValueType
	|
	|-RVA: 0x529CDB4 Offset: 0x5298DB4 VA: 0x529CDB4
	|-Property<Vector3Int, int>.DeclaredValueType
	|
	|-RVA: 0x529D530 Offset: 0x5299530 VA: 0x529D530
	|-Property<Vector4, float>.DeclaredValueType
	|
	|-RVA: 0x529DCAC Offset: 0x5299CAC VA: 0x529DCAC
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1
	protected void AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298ABC Offset: 0x5294ABC VA: 0x5298ABC
	|-Property<Bounds, Vector3>.AddAttribute
	|
	|-RVA: 0x5299238 Offset: 0x5295238 VA: 0x5299238
	|-Property<BoundsInt, Vector3Int>.AddAttribute
	|
	|-RVA: 0x52999B4 Offset: 0x52959B4 VA: 0x52999B4
	|-Property<Color, float>.AddAttribute
	|
	|-RVA: 0x529A130 Offset: 0x5296130 VA: 0x529A130
	|-Property<object, int>.AddAttribute
	|
	|-RVA: 0x529A8AC Offset: 0x52968AC VA: 0x529A8AC
	|-Property<Rect, float>.AddAttribute
	|
	|-RVA: 0x529B028 Offset: 0x5297028 VA: 0x529B028
	|-Property<RectInt, int>.AddAttribute
	|
	|-RVA: 0x529B7A4 Offset: 0x52977A4 VA: 0x529B7A4
	|-Property<Vector2, float>.AddAttribute
	|
	|-RVA: 0x529BF20 Offset: 0x5297F20 VA: 0x529BF20
	|-Property<Vector2Int, int>.AddAttribute
	|
	|-RVA: 0x529C69C Offset: 0x529869C VA: 0x529C69C
	|-Property<Vector3, float>.AddAttribute
	|
	|-RVA: 0x529CE18 Offset: 0x5298E18 VA: 0x529CE18
	|-Property<Vector3Int, int>.AddAttribute
	|
	|-RVA: 0x529D594 Offset: 0x5299594 VA: 0x529D594
	|-Property<Vector4, float>.AddAttribute
	|
	|-RVA: 0x529DD10 Offset: 0x5299D10 VA: 0x529DD10
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttribute
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298B60 Offset: 0x5294B60 VA: 0x5298B60
	|-Property<Bounds, Vector3>.AddAttributes
	|
	|-RVA: 0x52992DC Offset: 0x52952DC VA: 0x52992DC
	|-Property<BoundsInt, Vector3Int>.AddAttributes
	|
	|-RVA: 0x5299A58 Offset: 0x5295A58 VA: 0x5299A58
	|-Property<Color, float>.AddAttributes
	|
	|-RVA: 0x529A1D4 Offset: 0x52961D4 VA: 0x529A1D4
	|-Property<object, int>.AddAttributes
	|
	|-RVA: 0x529A950 Offset: 0x5296950 VA: 0x529A950
	|-Property<Rect, float>.AddAttributes
	|
	|-RVA: 0x529B0CC Offset: 0x52970CC VA: 0x529B0CC
	|-Property<RectInt, int>.AddAttributes
	|
	|-RVA: 0x529B848 Offset: 0x5297848 VA: 0x529B848
	|-Property<Vector2, float>.AddAttributes
	|
	|-RVA: 0x529BFC4 Offset: 0x5297FC4 VA: 0x529BFC4
	|-Property<Vector2Int, int>.AddAttributes
	|
	|-RVA: 0x529C740 Offset: 0x5298740 VA: 0x529C740
	|-Property<Vector3, float>.AddAttributes
	|
	|-RVA: 0x529CEBC Offset: 0x5298EBC VA: 0x529CEBC
	|-Property<Vector3Int, int>.AddAttributes
	|
	|-RVA: 0x529D638 Offset: 0x5299638 VA: 0x529D638
	|-Property<Vector4, float>.AddAttributes
	|
	|-RVA: 0x529DDB4 Offset: 0x5299DB4 VA: 0x529DDB4
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298C08 Offset: 0x5294C08 VA: 0x5298C08
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x5299384 Offset: 0x5295384 VA: 0x5299384
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x5299B00 Offset: 0x5295B00 VA: 0x5299B00
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529A27C Offset: 0x529627C VA: 0x529A27C
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529A9F8 Offset: 0x52969F8 VA: 0x529A9F8
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529B174 Offset: 0x5297174 VA: 0x529B174
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529B8F0 Offset: 0x52978F0 VA: 0x529B8F0
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529C06C Offset: 0x529806C VA: 0x529C06C
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529C7E8 Offset: 0x52987E8 VA: 0x529C7E8
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529CF64 Offset: 0x5298F64 VA: 0x529CF64
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529D6E0 Offset: 0x52996E0 VA: 0x529D6E0
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x529DE5C Offset: 0x5299E5C VA: 0x529DE5C
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttribute
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5298D98 Offset: 0x5294D98 VA: 0x5298D98
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x5299514 Offset: 0x5295514 VA: 0x5299514
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x5299C90 Offset: 0x5295C90 VA: 0x5299C90
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529A40C Offset: 0x529640C VA: 0x529A40C
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529AB88 Offset: 0x5296B88 VA: 0x529AB88
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529B304 Offset: 0x5297304 VA: 0x529B304
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529BA80 Offset: 0x5297A80 VA: 0x529BA80
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529C1FC Offset: 0x52981FC VA: 0x529C1FC
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529C978 Offset: 0x5298978 VA: 0x529C978
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529D0F4 Offset: 0x52990F4 VA: 0x529D0F4
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529D870 Offset: 0x5299870 VA: 0x529D870
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x529DFEC Offset: 0x5299FEC VA: 0x529DFEC
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4345DD8 Offset: 0x4341DD8 VA: 0x4345DD8
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52991CC Offset: 0x52951CC VA: 0x52991CC
	|-Property<Bounds, Vector3>..ctor
	|
	|-RVA: 0x5299948 Offset: 0x5295948 VA: 0x5299948
	|-Property<BoundsInt, Vector3Int>..ctor
	|
	|-RVA: 0x529A0C4 Offset: 0x52960C4 VA: 0x529A0C4
	|-Property<Color, float>..ctor
	|
	|-RVA: 0x529A840 Offset: 0x5296840 VA: 0x529A840
	|-Property<object, int>..ctor
	|
	|-RVA: 0x529AFBC Offset: 0x5296FBC VA: 0x529AFBC
	|-Property<Rect, float>..ctor
	|
	|-RVA: 0x529B738 Offset: 0x5297738 VA: 0x529B738
	|-Property<RectInt, int>..ctor
	|
	|-RVA: 0x529BEB4 Offset: 0x5297EB4 VA: 0x529BEB4
	|-Property<Vector2, float>..ctor
	|
	|-RVA: 0x529C630 Offset: 0x5298630 VA: 0x529C630
	|-Property<Vector2Int, int>..ctor
	|
	|-RVA: 0x529CDAC Offset: 0x5298DAC VA: 0x529CDAC
	|-Property<Vector3, float>..ctor
	|
	|-RVA: 0x529D528 Offset: 0x5299528 VA: 0x529D528
	|-Property<Vector3Int, int>..ctor
	|
	|-RVA: 0x529DCA4 Offset: 0x5299CA4 VA: 0x529DCA4
	|-Property<Vector4, float>..ctor
	|
	|-RVA: 0x529E420 Offset: 0x529A420 VA: 0x529E420
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
internal interface IMemberInfo // TypeDefIndex: 27790
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Attribute> GetCustomAttributes();
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct FieldMember : IMemberInfo // TypeDefIndex: 27791
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x87DE1D4 Offset: 0x87DA1D4 VA: 0x87DE1D4
	public void .ctor(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	// RVA: 0x87DE2F8 Offset: 0x87DA2F8 VA: 0x87DE2F8 Slot: 4
	public string get_Name() { }

	// RVA: 0x87DE300 Offset: 0x87DA300 VA: 0x87DE300 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x87DE31C Offset: 0x87DA31C VA: 0x87DE31C Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x87DE340 Offset: 0x87DA340 VA: 0x87DE340 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct PropertyMember : IMemberInfo // TypeDefIndex: 27792
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87DE34C Offset: 0x87DA34C VA: 0x87DE34C Slot: 4
	public string get_Name() { }

	// RVA: 0x87DE354 Offset: 0x87DA354 VA: 0x87DE354 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x87DE384 Offset: 0x87DA384 VA: 0x87DE384 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x87DE3A8 Offset: 0x87DA3A8 VA: 0x87DE3A8
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x87DE3D4 Offset: 0x87DA3D4 VA: 0x87DE3D4 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27793
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BB64 Offset: 0x4907B64 VA: 0x490BB64
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BC14 Offset: 0x4907C14 VA: 0x490BC14
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27794
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E5058 Offset: 0x54E1058 VA: 0x54E5058
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E510C Offset: 0x54E110C VA: 0x54E510C
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27795
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BA48 Offset: 0x4907A48 VA: 0x490BA48
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BB50 Offset: 0x4907B50 VA: 0x490BB50
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 27796
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E4D84 Offset: 0x54E0D84 VA: 0x54E4D84
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E4E90 Offset: 0x54E0E90 VA: 0x54E4E90
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 27797
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495448 Offset: 0x5491448 VA: 0x5495448
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495450 Offset: 0x5491450 VA: 0x5495450
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement> // TypeDefIndex: 27798
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6209404 Offset: 0x6205404 VA: 0x6209404
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TElement[] InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x620940C Offset: 0x620540C VA: 0x620940C
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TElement[] Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6209438 Offset: 0x6205438 VA: 0x6209438
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x620944C Offset: 0x620544C VA: 0x620944C
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer> // TypeDefIndex: 27799
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0FA7C Offset: 0x5D0BA7C VA: 0x5D0FA7C
	|-ContainerPropertyBag<Bounds>..cctor
	|
	|-RVA: 0x5D0FC84 Offset: 0x5D0BC84 VA: 0x5D0FC84
	|-ContainerPropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0x5D0FE8C Offset: 0x5D0BE8C VA: 0x5D0FE8C
	|-ContainerPropertyBag<Color>..cctor
	|
	|-RVA: 0x5D10094 Offset: 0x5D0C094 VA: 0x5D10094
	|-ContainerPropertyBag<object>..cctor
	|
	|-RVA: 0x5D1029C Offset: 0x5D0C29C VA: 0x5D1029C
	|-ContainerPropertyBag<Rect>..cctor
	|
	|-RVA: 0x5D104A4 Offset: 0x5D0C4A4 VA: 0x5D104A4
	|-ContainerPropertyBag<RectInt>..cctor
	|
	|-RVA: 0x5D106AC Offset: 0x5D0C6AC VA: 0x5D106AC
	|-ContainerPropertyBag<Vector2>..cctor
	|
	|-RVA: 0x5D108B4 Offset: 0x5D0C8B4 VA: 0x5D108B4
	|-ContainerPropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0x5D10ABC Offset: 0x5D0CABC VA: 0x5D10ABC
	|-ContainerPropertyBag<Vector3>..cctor
	|
	|-RVA: 0x5D10CC4 Offset: 0x5D0CCC4 VA: 0x5D10CC4
	|-ContainerPropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0x5D10ECC Offset: 0x5D0CECC VA: 0x5D10ECC
	|-ContainerPropertyBag<Vector4>..cctor
	|
	|-RVA: 0x5D110D4 Offset: 0x5D0D0D4 VA: 0x5D110D4
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42229A8 Offset: 0x421E9A8 VA: 0x42229A8
	|-ContainerPropertyBag<Bounds>.AddProperty<Vector3>
	|
	|-RVA: 0x4222A6C Offset: 0x421EA6C VA: 0x4222A6C
	|-ContainerPropertyBag<BoundsInt>.AddProperty<Vector3Int>
	|
	|-RVA: 0x4222B30 Offset: 0x421EB30 VA: 0x4222B30
	|-ContainerPropertyBag<Color>.AddProperty<float>
	|
	|-RVA: 0x4222BF4 Offset: 0x421EBF4 VA: 0x4222BF4
	|-ContainerPropertyBag<object>.AddProperty<int>
	|
	|-RVA: 0x4222CB8 Offset: 0x421ECB8 VA: 0x4222CB8
	|-ContainerPropertyBag<Rect>.AddProperty<float>
	|
	|-RVA: 0x4222D7C Offset: 0x421ED7C VA: 0x4222D7C
	|-ContainerPropertyBag<RectInt>.AddProperty<int>
	|
	|-RVA: 0x4222E40 Offset: 0x421EE40 VA: 0x4222E40
	|-ContainerPropertyBag<Vector2>.AddProperty<float>
	|
	|-RVA: 0x4222F04 Offset: 0x421EF04 VA: 0x4222F04
	|-ContainerPropertyBag<Vector2Int>.AddProperty<int>
	|
	|-RVA: 0x4222FC8 Offset: 0x421EFC8 VA: 0x4222FC8
	|-ContainerPropertyBag<Vector3>.AddProperty<float>
	|
	|-RVA: 0x422308C Offset: 0x421F08C VA: 0x422308C
	|-ContainerPropertyBag<Vector3Int>.AddProperty<int>
	|
	|-RVA: 0x4223150 Offset: 0x421F150 VA: 0x4223150
	|-ContainerPropertyBag<Vector4>.AddProperty<float>
	|
	|-RVA: 0x4223214 Offset: 0x421F214 VA: 0x4223214
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0FB78 Offset: 0x5D0BB78 VA: 0x5D0FB78
	|-ContainerPropertyBag<Bounds>.TryGetProperty
	|
	|-RVA: 0x5D0FD80 Offset: 0x5D0BD80 VA: 0x5D0FD80
	|-ContainerPropertyBag<BoundsInt>.TryGetProperty
	|
	|-RVA: 0x5D0FF88 Offset: 0x5D0BF88 VA: 0x5D0FF88
	|-ContainerPropertyBag<Color>.TryGetProperty
	|
	|-RVA: 0x5D10190 Offset: 0x5D0C190 VA: 0x5D10190
	|-ContainerPropertyBag<object>.TryGetProperty
	|
	|-RVA: 0x5D10398 Offset: 0x5D0C398 VA: 0x5D10398
	|-ContainerPropertyBag<Rect>.TryGetProperty
	|
	|-RVA: 0x5D105A0 Offset: 0x5D0C5A0 VA: 0x5D105A0
	|-ContainerPropertyBag<RectInt>.TryGetProperty
	|
	|-RVA: 0x5D107A8 Offset: 0x5D0C7A8 VA: 0x5D107A8
	|-ContainerPropertyBag<Vector2>.TryGetProperty
	|
	|-RVA: 0x5D109B0 Offset: 0x5D0C9B0 VA: 0x5D109B0
	|-ContainerPropertyBag<Vector2Int>.TryGetProperty
	|
	|-RVA: 0x5D10BB8 Offset: 0x5D0CBB8 VA: 0x5D10BB8
	|-ContainerPropertyBag<Vector3>.TryGetProperty
	|
	|-RVA: 0x5D10DC0 Offset: 0x5D0CDC0 VA: 0x5D10DC0
	|-ContainerPropertyBag<Vector3Int>.TryGetProperty
	|
	|-RVA: 0x5D10FC8 Offset: 0x5D0CFC8 VA: 0x5D10FC8
	|-ContainerPropertyBag<Vector4>.TryGetProperty
	|
	|-RVA: 0x5D111D0 Offset: 0x5D0D1D0 VA: 0x5D111D0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0FBA8 Offset: 0x5D0BBA8 VA: 0x5D0FBA8
	|-ContainerPropertyBag<Bounds>..ctor
	|
	|-RVA: 0x5D0FDB0 Offset: 0x5D0BDB0 VA: 0x5D0FDB0
	|-ContainerPropertyBag<BoundsInt>..ctor
	|
	|-RVA: 0x5D0FFB8 Offset: 0x5D0BFB8 VA: 0x5D0FFB8
	|-ContainerPropertyBag<Color>..ctor
	|
	|-RVA: 0x5D101C0 Offset: 0x5D0C1C0 VA: 0x5D101C0
	|-ContainerPropertyBag<object>..ctor
	|
	|-RVA: 0x5D103C8 Offset: 0x5D0C3C8 VA: 0x5D103C8
	|-ContainerPropertyBag<Rect>..ctor
	|
	|-RVA: 0x5D105D0 Offset: 0x5D0C5D0 VA: 0x5D105D0
	|-ContainerPropertyBag<RectInt>..ctor
	|
	|-RVA: 0x5D107D8 Offset: 0x5D0C7D8 VA: 0x5D107D8
	|-ContainerPropertyBag<Vector2>..ctor
	|
	|-RVA: 0x5D109E0 Offset: 0x5D0C9E0 VA: 0x5D109E0
	|-ContainerPropertyBag<Vector2Int>..ctor
	|
	|-RVA: 0x5D10BE8 Offset: 0x5D0CBE8 VA: 0x5D10BE8
	|-ContainerPropertyBag<Vector3>..ctor
	|
	|-RVA: 0x5D10DF0 Offset: 0x5D0CDF0 VA: 0x5D10DF0
	|-ContainerPropertyBag<Vector3Int>..ctor
	|
	|-RVA: 0x5D10FF8 Offset: 0x5D0CFF8 VA: 0x5D10FF8
	|-ContainerPropertyBag<Vector4>..ctor
	|
	|-RVA: 0x5D1121C Offset: 0x5D0D21C VA: 0x5D1121C
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 27800
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A0D4 Offset: 0x5D560D4 VA: 0x5D5A0D4
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override Dictionary<TKey, TValue> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A0DC Offset: 0x5D560DC VA: 0x5D5A0DC
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A124 Offset: 0x5D56124 VA: 0x5D5A124
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement> // TypeDefIndex: 27801
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914FA8 Offset: 0x4910FA8 VA: 0x4914FA8
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override HashSet<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914FB0 Offset: 0x4910FB0 VA: 0x4914FB0
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914FF8 Offset: 0x4910FF8 VA: 0x4914FF8
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IPropertyBag // TypeDefIndex: 27802
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ITypeVisitor visitor);
}

// Namespace: Unity.Properties
public interface IPropertyBag<TContainer> : IPropertyBag // TypeDefIndex: 27803
{}

// Namespace: 
private class IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> : Property<TList, TElement> // TypeDefIndex: 27804
{
	// Fields
	internal int m_Index; // 0x0

	// Properties
	public int Index { get; }
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B651B0 Offset: 0x4B611B0 VA: 0x4B651B0
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Index
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B651B8 Offset: 0x4B611B8 VA: 0x4B651B8
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B651E8 Offset: 0x4B611E8 VA: 0x4B651E8
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IPropertyBag<TList>, IPropertyBag, IConstructorWithCount<TList>, IConstructor // TypeDefIndex: 27805
{
	// Fields
	private readonly IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998AEC Offset: 0x4994AEC VA: 0x4998AEC
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual TList InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998BE8 Offset: 0x4994BE8 VA: 0x4998BE8
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998CE8 Offset: 0x4994CE8 VA: 0x4998CE8
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> : Property<TDictionary, KeyValuePair<TKey, TValue>> // TypeDefIndex: 27806
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TKey <Key>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }
	public TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF1044 Offset: 0x4AED044 VA: 0x4AF1044
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF118C Offset: 0x4AED18C VA: 0x4AF118C
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF1228 Offset: 0x4AED228 VA: 0x4AF1228
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IPropertyBag<TDictionary>, IPropertyBag // TypeDefIndex: 27807
{
	// Fields
	private readonly KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF0590 Offset: 0x4AEC590 VA: 0x4AF0590
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class KeyValuePairPropertyBag.<>c<TKey, TValue> // TypeDefIndex: 27808
{
	// Fields
	public static readonly KeyValuePairPropertyBag.<>c<TKey, TValue> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834948 Offset: 0x4830948 VA: 0x4834948
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834A3C Offset: 0x4830A3C VA: 0x4834A3C
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834A44 Offset: 0x4830A44 VA: 0x4834A44
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_0
	*/

	// RVA: -1 Offset: -1
	internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834AE4 Offset: 0x4830AE4 VA: 0x4834AE4
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_1
	*/
}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>> // TypeDefIndex: 27809
{
	// Fields
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty; // 0x0
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF123C Offset: 0x4AED23C VA: 0x4AF123C
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF129C Offset: 0x4AED29C VA: 0x4AF129C
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement> // TypeDefIndex: 27810
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6B804 Offset: 0x4B67804 VA: 0x4B6B804
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override List<TElement> InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6B80C Offset: 0x4B6780C VA: 0x4B6B80C
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override List<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6B864 Offset: 0x4B67864 VA: 0x4B6B864
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6B8AC Offset: 0x4B678AC VA: 0x4B6B8AC
	|-ListPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public static class PropertyBag // TypeDefIndex: 27811
{
	// Methods

	// RVA: -1 Offset: -1
	public static void Register<TContainer>(PropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A5C4C Offset: 0x46A1C4C VA: 0x46A5C4C
	|-PropertyBag.Register<Bounds>
	|
	|-RVA: 0x46A5CB0 Offset: 0x46A1CB0 VA: 0x46A5CB0
	|-PropertyBag.Register<BoundsInt>
	|
	|-RVA: 0x46A5D14 Offset: 0x46A1D14 VA: 0x46A5D14
	|-PropertyBag.Register<Color>
	|
	|-RVA: 0x46A5D78 Offset: 0x46A1D78 VA: 0x46A5D78
	|-PropertyBag.Register<object>
	|
	|-RVA: 0x46A5DDC Offset: 0x46A1DDC VA: 0x46A5DDC
	|-PropertyBag.Register<Rect>
	|
	|-RVA: 0x46A5E40 Offset: 0x46A1E40 VA: 0x46A5E40
	|-PropertyBag.Register<RectInt>
	|
	|-RVA: 0x46A5EA4 Offset: 0x46A1EA4 VA: 0x46A5EA4
	|-PropertyBag.Register<Vector2>
	|
	|-RVA: 0x46A5F08 Offset: 0x46A1F08 VA: 0x46A5F08
	|-PropertyBag.Register<Vector2Int>
	|
	|-RVA: 0x46A5F6C Offset: 0x46A1F6C VA: 0x46A5F6C
	|-PropertyBag.Register<Vector3>
	|
	|-RVA: 0x46A5FD0 Offset: 0x46A1FD0 VA: 0x46A5FD0
	|-PropertyBag.Register<Vector3Int>
	|
	|-RVA: 0x46A6034 Offset: 0x46A2034 VA: 0x46A6034
	|-PropertyBag.Register<Vector4>
	|
	|-RVA: 0x46A6098 Offset: 0x46A2098 VA: 0x46A6098
	|-PropertyBag.Register<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor // TypeDefIndex: 27812
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties
	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529692C Offset: 0x529292C VA: 0x529692C
	|-PropertyBag<Bounds>..cctor
	|
	|-RVA: 0x5296BD0 Offset: 0x5292BD0 VA: 0x5296BD0
	|-PropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0x5296E74 Offset: 0x5292E74 VA: 0x5296E74
	|-PropertyBag<Color>..cctor
	|
	|-RVA: 0x52970EC Offset: 0x52930EC VA: 0x52970EC
	|-PropertyBag<object>..cctor
	|
	|-RVA: 0x5297358 Offset: 0x5293358 VA: 0x5297358
	|-PropertyBag<Rect>..cctor
	|
	|-RVA: 0x52975D0 Offset: 0x52935D0 VA: 0x52975D0
	|-PropertyBag<RectInt>..cctor
	|
	|-RVA: 0x5297840 Offset: 0x5293840 VA: 0x5297840
	|-PropertyBag<Vector2>..cctor
	|
	|-RVA: 0x5297AB0 Offset: 0x5293AB0 VA: 0x5297AB0
	|-PropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0x5297D1C Offset: 0x5293D1C VA: 0x5297D1C
	|-PropertyBag<Vector3>..cctor
	|
	|-RVA: 0x5297F90 Offset: 0x5293F90 VA: 0x5297F90
	|-PropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0x5298210 Offset: 0x5294210 VA: 0x5298210
	|-PropertyBag<Vector4>..cctor
	|
	|-RVA: 0x5298488 Offset: 0x5294488 VA: 0x5298488
	|-PropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296A28 Offset: 0x5292A28 VA: 0x5296A28
	|-PropertyBag<Bounds>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5296CCC Offset: 0x5292CCC VA: 0x5296CCC
	|-PropertyBag<BoundsInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5296F70 Offset: 0x5292F70 VA: 0x5296F70
	|-PropertyBag<Color>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x52971E8 Offset: 0x52931E8 VA: 0x52971E8
	|-PropertyBag<object>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5297454 Offset: 0x5293454 VA: 0x5297454
	|-PropertyBag<Rect>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x52976CC Offset: 0x52936CC VA: 0x52976CC
	|-PropertyBag<RectInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x529793C Offset: 0x529393C VA: 0x529793C
	|-PropertyBag<Vector2>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5297BAC Offset: 0x5293BAC VA: 0x5297BAC
	|-PropertyBag<Vector2Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5297E18 Offset: 0x5293E18 VA: 0x5297E18
	|-PropertyBag<Vector3>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x529808C Offset: 0x529408C VA: 0x529808C
	|-PropertyBag<Vector3Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x529830C Offset: 0x529430C VA: 0x529830C
	|-PropertyBag<Vector4>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x5298584 Offset: 0x5294584 VA: 0x5298584
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.Internal.IPropertyBagRegister.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Accept(ITypeVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296A94 Offset: 0x5292A94 VA: 0x5296A94
	|-PropertyBag<Bounds>.Accept
	|
	|-RVA: 0x5296D38 Offset: 0x5292D38 VA: 0x5296D38
	|-PropertyBag<BoundsInt>.Accept
	|
	|-RVA: 0x5296FDC Offset: 0x5292FDC VA: 0x5296FDC
	|-PropertyBag<Color>.Accept
	|
	|-RVA: 0x5297254 Offset: 0x5293254 VA: 0x5297254
	|-PropertyBag<object>.Accept
	|
	|-RVA: 0x52974C0 Offset: 0x52934C0 VA: 0x52974C0
	|-PropertyBag<Rect>.Accept
	|
	|-RVA: 0x5297738 Offset: 0x5293738 VA: 0x5297738
	|-PropertyBag<RectInt>.Accept
	|
	|-RVA: 0x52979A8 Offset: 0x52939A8 VA: 0x52979A8
	|-PropertyBag<Vector2>.Accept
	|
	|-RVA: 0x5297C18 Offset: 0x5293C18 VA: 0x5297C18
	|-PropertyBag<Vector2Int>.Accept
	|
	|-RVA: 0x5297E84 Offset: 0x5293E84 VA: 0x5297E84
	|-PropertyBag<Vector3>.Accept
	|
	|-RVA: 0x52980F8 Offset: 0x52940F8 VA: 0x52980F8
	|-PropertyBag<Vector3Int>.Accept
	|
	|-RVA: 0x5298378 Offset: 0x5294378 VA: 0x5298378
	|-PropertyBag<Vector4>.Accept
	|
	|-RVA: 0x52985F4 Offset: 0x52945F4 VA: 0x52985F4
	|-PropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296B64 Offset: 0x5292B64 VA: 0x5296B64
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5296E08 Offset: 0x5292E08 VA: 0x5296E08
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x52970AC Offset: 0x52930AC VA: 0x52970AC
	|-PropertyBag<Color>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297324 Offset: 0x5293324 VA: 0x5297324
	|-PropertyBag<object>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297590 Offset: 0x5293590 VA: 0x5297590
	|-PropertyBag<Rect>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297808 Offset: 0x5293808 VA: 0x5297808
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297A78 Offset: 0x5293A78 VA: 0x5297A78
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297CE8 Offset: 0x5293CE8 VA: 0x5297CE8
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5297F54 Offset: 0x5293F54 VA: 0x5297F54
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x52981C8 Offset: 0x52941C8 VA: 0x52981C8
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x5298448 Offset: 0x5294448 VA: 0x5298448
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x52986C4 Offset: 0x52946C4 VA: 0x52986C4
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296B70 Offset: 0x5292B70 VA: 0x5296B70
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5296E14 Offset: 0x5292E14 VA: 0x5296E14
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x52970B8 Offset: 0x52930B8 VA: 0x52970B8
	|-PropertyBag<Color>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5297330 Offset: 0x5293330 VA: 0x5297330
	|-PropertyBag<object>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x529759C Offset: 0x529359C VA: 0x529759C
	|-PropertyBag<Rect>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5297814 Offset: 0x5293814 VA: 0x5297814
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5297A84 Offset: 0x5293A84 VA: 0x5297A84
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5297CF4 Offset: 0x5293CF4 VA: 0x5297CF4
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5297F60 Offset: 0x5293F60 VA: 0x5297F60
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x52981D4 Offset: 0x52941D4 VA: 0x52981D4
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x5298454 Offset: 0x5294454 VA: 0x5298454
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x52986D0 Offset: 0x52946D0 VA: 0x52986D0
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor<TContainer>.Instantiate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	protected virtual InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296BB0 Offset: 0x5292BB0 VA: 0x5296BB0
	|-PropertyBag<Bounds>.get_InstantiationKind
	|
	|-RVA: 0x5296E54 Offset: 0x5292E54 VA: 0x5296E54
	|-PropertyBag<BoundsInt>.get_InstantiationKind
	|
	|-RVA: 0x52970C4 Offset: 0x52930C4 VA: 0x52970C4
	|-PropertyBag<Color>.get_InstantiationKind
	|
	|-RVA: 0x529733C Offset: 0x529333C VA: 0x529733C
	|-PropertyBag<object>.get_InstantiationKind
	|
	|-RVA: 0x52975A8 Offset: 0x52935A8 VA: 0x52975A8
	|-PropertyBag<Rect>.get_InstantiationKind
	|
	|-RVA: 0x5297820 Offset: 0x5293820 VA: 0x5297820
	|-PropertyBag<RectInt>.get_InstantiationKind
	|
	|-RVA: 0x5297A90 Offset: 0x5293A90 VA: 0x5297A90
	|-PropertyBag<Vector2>.get_InstantiationKind
	|
	|-RVA: 0x5297D00 Offset: 0x5293D00 VA: 0x5297D00
	|-PropertyBag<Vector2Int>.get_InstantiationKind
	|
	|-RVA: 0x5297F6C Offset: 0x5293F6C VA: 0x5297F6C
	|-PropertyBag<Vector3>.get_InstantiationKind
	|
	|-RVA: 0x52981F0 Offset: 0x52941F0 VA: 0x52981F0
	|-PropertyBag<Vector3Int>.get_InstantiationKind
	|
	|-RVA: 0x5298460 Offset: 0x5294460 VA: 0x5298460
	|-PropertyBag<Vector4>.get_InstantiationKind
	|
	|-RVA: 0x52987B8 Offset: 0x52947B8 VA: 0x52987B8
	|-PropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual TContainer Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296BB8 Offset: 0x5292BB8 VA: 0x5296BB8
	|-PropertyBag<Bounds>.Instantiate
	|
	|-RVA: 0x5296E5C Offset: 0x5292E5C VA: 0x5296E5C
	|-PropertyBag<BoundsInt>.Instantiate
	|
	|-RVA: 0x52970CC Offset: 0x52930CC VA: 0x52970CC
	|-PropertyBag<Color>.Instantiate
	|
	|-RVA: 0x5297344 Offset: 0x5293344 VA: 0x5297344
	|-PropertyBag<object>.Instantiate
	|
	|-RVA: 0x52975B0 Offset: 0x52935B0 VA: 0x52975B0
	|-PropertyBag<Rect>.Instantiate
	|
	|-RVA: 0x5297828 Offset: 0x5293828 VA: 0x5297828
	|-PropertyBag<RectInt>.Instantiate
	|
	|-RVA: 0x5297A98 Offset: 0x5293A98 VA: 0x5297A98
	|-PropertyBag<Vector2>.Instantiate
	|
	|-RVA: 0x5297D08 Offset: 0x5293D08 VA: 0x5297D08
	|-PropertyBag<Vector2Int>.Instantiate
	|
	|-RVA: 0x5297F74 Offset: 0x5293F74 VA: 0x5297F74
	|-PropertyBag<Vector3>.Instantiate
	|
	|-RVA: 0x52981F8 Offset: 0x52941F8 VA: 0x52981F8
	|-PropertyBag<Vector3Int>.Instantiate
	|
	|-RVA: 0x5298468 Offset: 0x5294468 VA: 0x5298468
	|-PropertyBag<Vector4>.Instantiate
	|
	|-RVA: 0x52987C0 Offset: 0x52947C0 VA: 0x52987C0
	|-PropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5296BC4 Offset: 0x5292BC4 VA: 0x5296BC4
	|-PropertyBag<Bounds>..ctor
	|
	|-RVA: 0x5296E68 Offset: 0x5292E68 VA: 0x5296E68
	|-PropertyBag<BoundsInt>..ctor
	|
	|-RVA: 0x52970E0 Offset: 0x52930E0 VA: 0x52970E0
	|-PropertyBag<Color>..ctor
	|
	|-RVA: 0x529734C Offset: 0x529334C VA: 0x529734C
	|-PropertyBag<object>..ctor
	|
	|-RVA: 0x52975C4 Offset: 0x52935C4 VA: 0x52975C4
	|-PropertyBag<Rect>..ctor
	|
	|-RVA: 0x5297834 Offset: 0x5293834 VA: 0x5297834
	|-PropertyBag<RectInt>..ctor
	|
	|-RVA: 0x5297AA4 Offset: 0x5293AA4 VA: 0x5297AA4
	|-PropertyBag<Vector2>..ctor
	|
	|-RVA: 0x5297D10 Offset: 0x5293D10 VA: 0x5297D10
	|-PropertyBag<Vector2Int>..ctor
	|
	|-RVA: 0x5297F84 Offset: 0x5293F84 VA: 0x5297F84
	|-PropertyBag<Vector3>..ctor
	|
	|-RVA: 0x5298204 Offset: 0x5294204 VA: 0x5298204
	|-PropertyBag<Vector3Int>..ctor
	|
	|-RVA: 0x529847C Offset: 0x529447C VA: 0x529847C
	|-PropertyBag<Vector4>..ctor
	|
	|-RVA: 0x52988C0 Offset: 0x52948C0 VA: 0x52988C0
	|-PropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class SetPropertyBagBase.SetElementProperty<TSet, TElement> : Property<TSet, TElement> // TypeDefIndex: 27813
{
	// Fields
	internal TElement m_Value; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E4EA4 Offset: 0x54E0EA4 VA: 0x54E4EA4
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E4FA0 Offset: 0x54E0FA0 VA: 0x54E4FA0
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag // TypeDefIndex: 27814
{
	// Fields
	private readonly SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E4FB4 Offset: 0x54E0FB4 VA: 0x54E4FB4
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface ITypeVisitor // TypeDefIndex: 27815
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public static class TypeTraits // TypeDefIndex: 27816
{
	// Methods

	// RVA: 0x87DE3E0 Offset: 0x87DA3E0 VA: 0x87DE3E0
	public static bool IsContainer(Type type) { }
}

// Namespace: Unity.Properties
public static class TypeTraits<T> // TypeDefIndex: 27817
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsValueType>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsArray>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsObject>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsString>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Properties
	public static bool IsValueType { get; }
	public static bool IsPrimitive { get; }
	public static bool IsInterface { get; }
	public static bool IsAbstract { get; }
	public static bool IsArray { get; }
	public static bool IsEnum { get; }
	public static bool IsNullable { get; }
	public static bool IsObject { get; }
	public static bool IsString { get; }
	public static bool IsContainer { get; }
	public static bool CanBeNull { get; }
	public static bool IsAbstractOrInterface { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F790 Offset: 0x567B790 VA: 0x567F790
	|-TypeTraits<Bounds>.get_IsValueType
	|
	|-RVA: 0x56807A8 Offset: 0x567C7A8 VA: 0x56807A8
	|-TypeTraits<BoundsInt>.get_IsValueType
	|
	|-RVA: 0x56817C0 Offset: 0x567D7C0 VA: 0x56817C0
	|-TypeTraits<Color>.get_IsValueType
	|
	|-RVA: 0x56827D8 Offset: 0x567E7D8 VA: 0x56827D8
	|-TypeTraits<object>.get_IsValueType
	|
	|-RVA: 0x56837F0 Offset: 0x567F7F0 VA: 0x56837F0
	|-TypeTraits<Rect>.get_IsValueType
	|
	|-RVA: 0x5684808 Offset: 0x5680808 VA: 0x5684808
	|-TypeTraits<RectInt>.get_IsValueType
	|
	|-RVA: 0x5685820 Offset: 0x5681820 VA: 0x5685820
	|-TypeTraits<Vector2>.get_IsValueType
	|
	|-RVA: 0x5686838 Offset: 0x5682838 VA: 0x5686838
	|-TypeTraits<Vector2Int>.get_IsValueType
	|
	|-RVA: 0x5687850 Offset: 0x5683850 VA: 0x5687850
	|-TypeTraits<Vector3>.get_IsValueType
	|
	|-RVA: 0x5688868 Offset: 0x5684868 VA: 0x5688868
	|-TypeTraits<Vector3Int>.get_IsValueType
	|
	|-RVA: 0x5689880 Offset: 0x5685880 VA: 0x5689880
	|-TypeTraits<Vector4>.get_IsValueType
	|
	|-RVA: 0x568A898 Offset: 0x5686898 VA: 0x568A898
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsValueType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsPrimitive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F7FC Offset: 0x567B7FC VA: 0x567F7FC
	|-TypeTraits<Bounds>.get_IsPrimitive
	|
	|-RVA: 0x5680814 Offset: 0x567C814 VA: 0x5680814
	|-TypeTraits<BoundsInt>.get_IsPrimitive
	|
	|-RVA: 0x568182C Offset: 0x567D82C VA: 0x568182C
	|-TypeTraits<Color>.get_IsPrimitive
	|
	|-RVA: 0x5682844 Offset: 0x567E844 VA: 0x5682844
	|-TypeTraits<object>.get_IsPrimitive
	|
	|-RVA: 0x568385C Offset: 0x567F85C VA: 0x568385C
	|-TypeTraits<Rect>.get_IsPrimitive
	|
	|-RVA: 0x5684874 Offset: 0x5680874 VA: 0x5684874
	|-TypeTraits<RectInt>.get_IsPrimitive
	|
	|-RVA: 0x568588C Offset: 0x568188C VA: 0x568588C
	|-TypeTraits<Vector2>.get_IsPrimitive
	|
	|-RVA: 0x56868A4 Offset: 0x56828A4 VA: 0x56868A4
	|-TypeTraits<Vector2Int>.get_IsPrimitive
	|
	|-RVA: 0x56878BC Offset: 0x56838BC VA: 0x56878BC
	|-TypeTraits<Vector3>.get_IsPrimitive
	|
	|-RVA: 0x56888D4 Offset: 0x56848D4 VA: 0x56888D4
	|-TypeTraits<Vector3Int>.get_IsPrimitive
	|
	|-RVA: 0x56898EC Offset: 0x56858EC VA: 0x56898EC
	|-TypeTraits<Vector4>.get_IsPrimitive
	|
	|-RVA: 0x568A904 Offset: 0x5686904 VA: 0x568A904
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsPrimitive
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F868 Offset: 0x567B868 VA: 0x567F868
	|-TypeTraits<Bounds>.get_IsInterface
	|
	|-RVA: 0x5680880 Offset: 0x567C880 VA: 0x5680880
	|-TypeTraits<BoundsInt>.get_IsInterface
	|
	|-RVA: 0x5681898 Offset: 0x567D898 VA: 0x5681898
	|-TypeTraits<Color>.get_IsInterface
	|
	|-RVA: 0x56828B0 Offset: 0x567E8B0 VA: 0x56828B0
	|-TypeTraits<object>.get_IsInterface
	|
	|-RVA: 0x56838C8 Offset: 0x567F8C8 VA: 0x56838C8
	|-TypeTraits<Rect>.get_IsInterface
	|
	|-RVA: 0x56848E0 Offset: 0x56808E0 VA: 0x56848E0
	|-TypeTraits<RectInt>.get_IsInterface
	|
	|-RVA: 0x56858F8 Offset: 0x56818F8 VA: 0x56858F8
	|-TypeTraits<Vector2>.get_IsInterface
	|
	|-RVA: 0x5686910 Offset: 0x5682910 VA: 0x5686910
	|-TypeTraits<Vector2Int>.get_IsInterface
	|
	|-RVA: 0x5687928 Offset: 0x5683928 VA: 0x5687928
	|-TypeTraits<Vector3>.get_IsInterface
	|
	|-RVA: 0x5688940 Offset: 0x5684940 VA: 0x5688940
	|-TypeTraits<Vector3Int>.get_IsInterface
	|
	|-RVA: 0x5689958 Offset: 0x5685958 VA: 0x5689958
	|-TypeTraits<Vector4>.get_IsInterface
	|
	|-RVA: 0x568A970 Offset: 0x5686970 VA: 0x568A970
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsInterface
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstract() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F8D4 Offset: 0x567B8D4 VA: 0x567F8D4
	|-TypeTraits<Bounds>.get_IsAbstract
	|
	|-RVA: 0x56808EC Offset: 0x567C8EC VA: 0x56808EC
	|-TypeTraits<BoundsInt>.get_IsAbstract
	|
	|-RVA: 0x5681904 Offset: 0x567D904 VA: 0x5681904
	|-TypeTraits<Color>.get_IsAbstract
	|
	|-RVA: 0x568291C Offset: 0x567E91C VA: 0x568291C
	|-TypeTraits<object>.get_IsAbstract
	|
	|-RVA: 0x5683934 Offset: 0x567F934 VA: 0x5683934
	|-TypeTraits<Rect>.get_IsAbstract
	|
	|-RVA: 0x568494C Offset: 0x568094C VA: 0x568494C
	|-TypeTraits<RectInt>.get_IsAbstract
	|
	|-RVA: 0x5685964 Offset: 0x5681964 VA: 0x5685964
	|-TypeTraits<Vector2>.get_IsAbstract
	|
	|-RVA: 0x568697C Offset: 0x568297C VA: 0x568697C
	|-TypeTraits<Vector2Int>.get_IsAbstract
	|
	|-RVA: 0x5687994 Offset: 0x5683994 VA: 0x5687994
	|-TypeTraits<Vector3>.get_IsAbstract
	|
	|-RVA: 0x56889AC Offset: 0x56849AC VA: 0x56889AC
	|-TypeTraits<Vector3Int>.get_IsAbstract
	|
	|-RVA: 0x56899C4 Offset: 0x56859C4 VA: 0x56899C4
	|-TypeTraits<Vector4>.get_IsAbstract
	|
	|-RVA: 0x568A9DC Offset: 0x56869DC VA: 0x568A9DC
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstract
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F940 Offset: 0x567B940 VA: 0x567F940
	|-TypeTraits<Bounds>.get_IsArray
	|
	|-RVA: 0x5680958 Offset: 0x567C958 VA: 0x5680958
	|-TypeTraits<BoundsInt>.get_IsArray
	|
	|-RVA: 0x5681970 Offset: 0x567D970 VA: 0x5681970
	|-TypeTraits<Color>.get_IsArray
	|
	|-RVA: 0x5682988 Offset: 0x567E988 VA: 0x5682988
	|-TypeTraits<object>.get_IsArray
	|
	|-RVA: 0x56839A0 Offset: 0x567F9A0 VA: 0x56839A0
	|-TypeTraits<Rect>.get_IsArray
	|
	|-RVA: 0x56849B8 Offset: 0x56809B8 VA: 0x56849B8
	|-TypeTraits<RectInt>.get_IsArray
	|
	|-RVA: 0x56859D0 Offset: 0x56819D0 VA: 0x56859D0
	|-TypeTraits<Vector2>.get_IsArray
	|
	|-RVA: 0x56869E8 Offset: 0x56829E8 VA: 0x56869E8
	|-TypeTraits<Vector2Int>.get_IsArray
	|
	|-RVA: 0x5687A00 Offset: 0x5683A00 VA: 0x5687A00
	|-TypeTraits<Vector3>.get_IsArray
	|
	|-RVA: 0x5688A18 Offset: 0x5684A18 VA: 0x5688A18
	|-TypeTraits<Vector3Int>.get_IsArray
	|
	|-RVA: 0x5689A30 Offset: 0x5685A30 VA: 0x5689A30
	|-TypeTraits<Vector4>.get_IsArray
	|
	|-RVA: 0x568AA48 Offset: 0x5686A48 VA: 0x568AA48
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsArray
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsEnum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567F9AC Offset: 0x567B9AC VA: 0x567F9AC
	|-TypeTraits<Bounds>.get_IsEnum
	|
	|-RVA: 0x56809C4 Offset: 0x567C9C4 VA: 0x56809C4
	|-TypeTraits<BoundsInt>.get_IsEnum
	|
	|-RVA: 0x56819DC Offset: 0x567D9DC VA: 0x56819DC
	|-TypeTraits<Color>.get_IsEnum
	|
	|-RVA: 0x56829F4 Offset: 0x567E9F4 VA: 0x56829F4
	|-TypeTraits<object>.get_IsEnum
	|
	|-RVA: 0x5683A0C Offset: 0x567FA0C VA: 0x5683A0C
	|-TypeTraits<Rect>.get_IsEnum
	|
	|-RVA: 0x5684A24 Offset: 0x5680A24 VA: 0x5684A24
	|-TypeTraits<RectInt>.get_IsEnum
	|
	|-RVA: 0x5685A3C Offset: 0x5681A3C VA: 0x5685A3C
	|-TypeTraits<Vector2>.get_IsEnum
	|
	|-RVA: 0x5686A54 Offset: 0x5682A54 VA: 0x5686A54
	|-TypeTraits<Vector2Int>.get_IsEnum
	|
	|-RVA: 0x5687A6C Offset: 0x5683A6C VA: 0x5687A6C
	|-TypeTraits<Vector3>.get_IsEnum
	|
	|-RVA: 0x5688A84 Offset: 0x5684A84 VA: 0x5688A84
	|-TypeTraits<Vector3Int>.get_IsEnum
	|
	|-RVA: 0x5689A9C Offset: 0x5685A9C VA: 0x5689A9C
	|-TypeTraits<Vector4>.get_IsEnum
	|
	|-RVA: 0x568AAB4 Offset: 0x5686AB4 VA: 0x568AAB4
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsEnum
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsNullable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FA18 Offset: 0x567BA18 VA: 0x567FA18
	|-TypeTraits<Bounds>.get_IsNullable
	|
	|-RVA: 0x5680A30 Offset: 0x567CA30 VA: 0x5680A30
	|-TypeTraits<BoundsInt>.get_IsNullable
	|
	|-RVA: 0x5681A48 Offset: 0x567DA48 VA: 0x5681A48
	|-TypeTraits<Color>.get_IsNullable
	|
	|-RVA: 0x5682A60 Offset: 0x567EA60 VA: 0x5682A60
	|-TypeTraits<object>.get_IsNullable
	|
	|-RVA: 0x5683A78 Offset: 0x567FA78 VA: 0x5683A78
	|-TypeTraits<Rect>.get_IsNullable
	|
	|-RVA: 0x5684A90 Offset: 0x5680A90 VA: 0x5684A90
	|-TypeTraits<RectInt>.get_IsNullable
	|
	|-RVA: 0x5685AA8 Offset: 0x5681AA8 VA: 0x5685AA8
	|-TypeTraits<Vector2>.get_IsNullable
	|
	|-RVA: 0x5686AC0 Offset: 0x5682AC0 VA: 0x5686AC0
	|-TypeTraits<Vector2Int>.get_IsNullable
	|
	|-RVA: 0x5687AD8 Offset: 0x5683AD8 VA: 0x5687AD8
	|-TypeTraits<Vector3>.get_IsNullable
	|
	|-RVA: 0x5688AF0 Offset: 0x5684AF0 VA: 0x5688AF0
	|-TypeTraits<Vector3Int>.get_IsNullable
	|
	|-RVA: 0x5689B08 Offset: 0x5685B08 VA: 0x5689B08
	|-TypeTraits<Vector4>.get_IsNullable
	|
	|-RVA: 0x568AB20 Offset: 0x5686B20 VA: 0x568AB20
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsNullable
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FA84 Offset: 0x567BA84 VA: 0x567FA84
	|-TypeTraits<Bounds>.get_IsObject
	|
	|-RVA: 0x5680A9C Offset: 0x567CA9C VA: 0x5680A9C
	|-TypeTraits<BoundsInt>.get_IsObject
	|
	|-RVA: 0x5681AB4 Offset: 0x567DAB4 VA: 0x5681AB4
	|-TypeTraits<Color>.get_IsObject
	|
	|-RVA: 0x5682ACC Offset: 0x567EACC VA: 0x5682ACC
	|-TypeTraits<object>.get_IsObject
	|
	|-RVA: 0x5683AE4 Offset: 0x567FAE4 VA: 0x5683AE4
	|-TypeTraits<Rect>.get_IsObject
	|
	|-RVA: 0x5684AFC Offset: 0x5680AFC VA: 0x5684AFC
	|-TypeTraits<RectInt>.get_IsObject
	|
	|-RVA: 0x5685B14 Offset: 0x5681B14 VA: 0x5685B14
	|-TypeTraits<Vector2>.get_IsObject
	|
	|-RVA: 0x5686B2C Offset: 0x5682B2C VA: 0x5686B2C
	|-TypeTraits<Vector2Int>.get_IsObject
	|
	|-RVA: 0x5687B44 Offset: 0x5683B44 VA: 0x5687B44
	|-TypeTraits<Vector3>.get_IsObject
	|
	|-RVA: 0x5688B5C Offset: 0x5684B5C VA: 0x5688B5C
	|-TypeTraits<Vector3Int>.get_IsObject
	|
	|-RVA: 0x5689B74 Offset: 0x5685B74 VA: 0x5689B74
	|-TypeTraits<Vector4>.get_IsObject
	|
	|-RVA: 0x568AB8C Offset: 0x5686B8C VA: 0x568AB8C
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsObject
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FAF0 Offset: 0x567BAF0 VA: 0x567FAF0
	|-TypeTraits<Bounds>.get_IsString
	|
	|-RVA: 0x5680B08 Offset: 0x567CB08 VA: 0x5680B08
	|-TypeTraits<BoundsInt>.get_IsString
	|
	|-RVA: 0x5681B20 Offset: 0x567DB20 VA: 0x5681B20
	|-TypeTraits<Color>.get_IsString
	|
	|-RVA: 0x5682B38 Offset: 0x567EB38 VA: 0x5682B38
	|-TypeTraits<object>.get_IsString
	|
	|-RVA: 0x5683B50 Offset: 0x567FB50 VA: 0x5683B50
	|-TypeTraits<Rect>.get_IsString
	|
	|-RVA: 0x5684B68 Offset: 0x5680B68 VA: 0x5684B68
	|-TypeTraits<RectInt>.get_IsString
	|
	|-RVA: 0x5685B80 Offset: 0x5681B80 VA: 0x5685B80
	|-TypeTraits<Vector2>.get_IsString
	|
	|-RVA: 0x5686B98 Offset: 0x5682B98 VA: 0x5686B98
	|-TypeTraits<Vector2Int>.get_IsString
	|
	|-RVA: 0x5687BB0 Offset: 0x5683BB0 VA: 0x5687BB0
	|-TypeTraits<Vector3>.get_IsString
	|
	|-RVA: 0x5688BC8 Offset: 0x5684BC8 VA: 0x5688BC8
	|-TypeTraits<Vector3Int>.get_IsString
	|
	|-RVA: 0x5689BE0 Offset: 0x5685BE0 VA: 0x5689BE0
	|-TypeTraits<Vector4>.get_IsString
	|
	|-RVA: 0x568ABF8 Offset: 0x5686BF8 VA: 0x568ABF8
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsString
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsContainer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FB5C Offset: 0x567BB5C VA: 0x567FB5C
	|-TypeTraits<Bounds>.get_IsContainer
	|
	|-RVA: 0x5680B74 Offset: 0x567CB74 VA: 0x5680B74
	|-TypeTraits<BoundsInt>.get_IsContainer
	|
	|-RVA: 0x5681B8C Offset: 0x567DB8C VA: 0x5681B8C
	|-TypeTraits<Color>.get_IsContainer
	|
	|-RVA: 0x5682BA4 Offset: 0x567EBA4 VA: 0x5682BA4
	|-TypeTraits<object>.get_IsContainer
	|
	|-RVA: 0x5683BBC Offset: 0x567FBBC VA: 0x5683BBC
	|-TypeTraits<Rect>.get_IsContainer
	|
	|-RVA: 0x5684BD4 Offset: 0x5680BD4 VA: 0x5684BD4
	|-TypeTraits<RectInt>.get_IsContainer
	|
	|-RVA: 0x5685BEC Offset: 0x5681BEC VA: 0x5685BEC
	|-TypeTraits<Vector2>.get_IsContainer
	|
	|-RVA: 0x5686C04 Offset: 0x5682C04 VA: 0x5686C04
	|-TypeTraits<Vector2Int>.get_IsContainer
	|
	|-RVA: 0x5687C1C Offset: 0x5683C1C VA: 0x5687C1C
	|-TypeTraits<Vector3>.get_IsContainer
	|
	|-RVA: 0x5688C34 Offset: 0x5684C34 VA: 0x5688C34
	|-TypeTraits<Vector3Int>.get_IsContainer
	|
	|-RVA: 0x5689C4C Offset: 0x5685C4C VA: 0x5689C4C
	|-TypeTraits<Vector4>.get_IsContainer
	|
	|-RVA: 0x568AC64 Offset: 0x5686C64 VA: 0x568AC64
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_CanBeNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FBC8 Offset: 0x567BBC8 VA: 0x567FBC8
	|-TypeTraits<Bounds>.get_CanBeNull
	|
	|-RVA: 0x5680BE0 Offset: 0x567CBE0 VA: 0x5680BE0
	|-TypeTraits<BoundsInt>.get_CanBeNull
	|
	|-RVA: 0x5681BF8 Offset: 0x567DBF8 VA: 0x5681BF8
	|-TypeTraits<Color>.get_CanBeNull
	|
	|-RVA: 0x5682C10 Offset: 0x567EC10 VA: 0x5682C10
	|-TypeTraits<object>.get_CanBeNull
	|
	|-RVA: 0x5683C28 Offset: 0x567FC28 VA: 0x5683C28
	|-TypeTraits<Rect>.get_CanBeNull
	|
	|-RVA: 0x5684C40 Offset: 0x5680C40 VA: 0x5684C40
	|-TypeTraits<RectInt>.get_CanBeNull
	|
	|-RVA: 0x5685C58 Offset: 0x5681C58 VA: 0x5685C58
	|-TypeTraits<Vector2>.get_CanBeNull
	|
	|-RVA: 0x5686C70 Offset: 0x5682C70 VA: 0x5686C70
	|-TypeTraits<Vector2Int>.get_CanBeNull
	|
	|-RVA: 0x5687C88 Offset: 0x5683C88 VA: 0x5687C88
	|-TypeTraits<Vector3>.get_CanBeNull
	|
	|-RVA: 0x5688CA0 Offset: 0x5684CA0 VA: 0x5688CA0
	|-TypeTraits<Vector3Int>.get_CanBeNull
	|
	|-RVA: 0x5689CB8 Offset: 0x5685CB8 VA: 0x5689CB8
	|-TypeTraits<Vector4>.get_CanBeNull
	|
	|-RVA: 0x568ACD0 Offset: 0x5686CD0 VA: 0x568ACD0
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_CanBeNull
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstractOrInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FC34 Offset: 0x567BC34 VA: 0x567FC34
	|-TypeTraits<Bounds>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5680C4C Offset: 0x567CC4C VA: 0x5680C4C
	|-TypeTraits<BoundsInt>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5681C64 Offset: 0x567DC64 VA: 0x5681C64
	|-TypeTraits<Color>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5682C7C Offset: 0x567EC7C VA: 0x5682C7C
	|-TypeTraits<object>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5683C94 Offset: 0x567FC94 VA: 0x5683C94
	|-TypeTraits<Rect>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5684CAC Offset: 0x5680CAC VA: 0x5684CAC
	|-TypeTraits<RectInt>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5685CC4 Offset: 0x5681CC4 VA: 0x5685CC4
	|-TypeTraits<Vector2>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5686CDC Offset: 0x5682CDC VA: 0x5686CDC
	|-TypeTraits<Vector2Int>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5687CF4 Offset: 0x5683CF4 VA: 0x5687CF4
	|-TypeTraits<Vector3>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5688D0C Offset: 0x5684D0C VA: 0x5688D0C
	|-TypeTraits<Vector3Int>.get_IsAbstractOrInterface
	|
	|-RVA: 0x5689D24 Offset: 0x5685D24 VA: 0x5689D24
	|-TypeTraits<Vector4>.get_IsAbstractOrInterface
	|
	|-RVA: 0x568AD3C Offset: 0x5686D3C VA: 0x568AD3C
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstractOrInterface
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567FCA0 Offset: 0x567BCA0 VA: 0x567FCA0
	|-TypeTraits<Bounds>..cctor
	|
	|-RVA: 0x5680CB8 Offset: 0x567CCB8 VA: 0x5680CB8
	|-TypeTraits<BoundsInt>..cctor
	|
	|-RVA: 0x5681CD0 Offset: 0x567DCD0 VA: 0x5681CD0
	|-TypeTraits<Color>..cctor
	|
	|-RVA: 0x5682CE8 Offset: 0x567ECE8 VA: 0x5682CE8
	|-TypeTraits<object>..cctor
	|
	|-RVA: 0x5683D00 Offset: 0x567FD00 VA: 0x5683D00
	|-TypeTraits<Rect>..cctor
	|
	|-RVA: 0x5684D18 Offset: 0x5680D18 VA: 0x5684D18
	|-TypeTraits<RectInt>..cctor
	|
	|-RVA: 0x5685D30 Offset: 0x5681D30 VA: 0x5685D30
	|-TypeTraits<Vector2>..cctor
	|
	|-RVA: 0x5686D48 Offset: 0x5682D48 VA: 0x5686D48
	|-TypeTraits<Vector2Int>..cctor
	|
	|-RVA: 0x5687D60 Offset: 0x5683D60 VA: 0x5687D60
	|-TypeTraits<Vector3>..cctor
	|
	|-RVA: 0x5688D78 Offset: 0x5684D78 VA: 0x5688D78
	|-TypeTraits<Vector3Int>..cctor
	|
	|-RVA: 0x5689D90 Offset: 0x5685D90 VA: 0x5689D90
	|-TypeTraits<Vector4>..cctor
	|
	|-RVA: 0x568ADA8 Offset: 0x5686DA8 VA: 0x568ADA8
	|-TypeTraits<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public enum InstantiationKind // TypeDefIndex: 27818
{
	// Fields
	public int value__; // 0x0
	public const InstantiationKind Activator = 0;
	public const InstantiationKind PropertyBagOverride = 1;
	public const InstantiationKind NotInstantiatable = 2;
}

// Namespace: Unity.Properties
internal interface IConstructor // TypeDefIndex: 27819
{
	// Properties
	public abstract InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InstantiationKind get_InstantiationKind();
}

// Namespace: Unity.Properties
internal interface IConstructor<T> : IConstructor // TypeDefIndex: 27820
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/
}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T> : IConstructor // TypeDefIndex: 27821
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T InstantiateWithCount(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructorWithCount<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/
}

// Namespace: 
private interface TypeUtility.ITypeConstructor // TypeDefIndex: 27822
{
	// Properties
	public abstract bool CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_CanBeInstantiated();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Instantiate();
}

// Namespace: 
private interface TypeUtility.ITypeConstructor<T> : TypeUtility.ITypeConstructor // TypeDefIndex: 27823
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetExplicitConstructor(Func<T> constructor);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/
}

// Namespace: 
private class TypeUtility.TypeConstructor<T> : TypeUtility.ITypeConstructor<T>, TypeUtility.ITypeConstructor // TypeDefIndex: 27824
{
	// Fields
	private Func<T> m_ExplicitConstructor; // 0x0
	private Func<T> m_ImplicitConstructor; // 0x0
	private IConstructor<T> m_OverrideConstructor; // 0x0

	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678A6C Offset: 0x5674A6C VA: 0x5678A6C
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x5679398 Offset: 0x5675398 VA: 0x5679398
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x5679CC4 Offset: 0x5675CC4 VA: 0x5679CC4
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567A578 Offset: 0x5676578 VA: 0x567A578
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567ADE0 Offset: 0x5676DE0 VA: 0x567ADE0
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567B694 Offset: 0x5677694 VA: 0x567B694
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567BF3C Offset: 0x5677F3C VA: 0x567BF3C
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567C7D8 Offset: 0x56787D8 VA: 0x567C7D8
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567D070 Offset: 0x5679070 VA: 0x567D070
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567D920 Offset: 0x5679920 VA: 0x567D920
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567E1E4 Offset: 0x567A1E4 VA: 0x567E1E4
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x567EA98 Offset: 0x567AA98 VA: 0x567EA98
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678BA4 Offset: 0x5674BA4 VA: 0x5678BA4
	|-TypeUtility.TypeConstructor<Bounds>..ctor
	|
	|-RVA: 0x56794D0 Offset: 0x56754D0 VA: 0x56794D0
	|-TypeUtility.TypeConstructor<BoundsInt>..ctor
	|
	|-RVA: 0x5679DFC Offset: 0x5675DFC VA: 0x5679DFC
	|-TypeUtility.TypeConstructor<Color>..ctor
	|
	|-RVA: 0x567A6B0 Offset: 0x56766B0 VA: 0x567A6B0
	|-TypeUtility.TypeConstructor<object>..ctor
	|
	|-RVA: 0x567AF18 Offset: 0x5676F18 VA: 0x567AF18
	|-TypeUtility.TypeConstructor<Rect>..ctor
	|
	|-RVA: 0x567B7CC Offset: 0x56777CC VA: 0x567B7CC
	|-TypeUtility.TypeConstructor<RectInt>..ctor
	|
	|-RVA: 0x567C074 Offset: 0x5678074 VA: 0x567C074
	|-TypeUtility.TypeConstructor<Vector2>..ctor
	|
	|-RVA: 0x567C910 Offset: 0x5678910 VA: 0x567C910
	|-TypeUtility.TypeConstructor<Vector2Int>..ctor
	|
	|-RVA: 0x567D1A8 Offset: 0x56791A8 VA: 0x567D1A8
	|-TypeUtility.TypeConstructor<Vector3>..ctor
	|
	|-RVA: 0x567DA58 Offset: 0x5679A58 VA: 0x567DA58
	|-TypeUtility.TypeConstructor<Vector3Int>..ctor
	|
	|-RVA: 0x567E31C Offset: 0x567A31C VA: 0x567E31C
	|-TypeUtility.TypeConstructor<Vector4>..ctor
	|
	|-RVA: 0x567EBD0 Offset: 0x567ABD0 VA: 0x567EBD0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SetImplicitConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678C94 Offset: 0x5674C94 VA: 0x5678C94
	|-TypeUtility.TypeConstructor<Bounds>.SetImplicitConstructor
	|
	|-RVA: 0x56795C0 Offset: 0x56755C0 VA: 0x56795C0
	|-TypeUtility.TypeConstructor<BoundsInt>.SetImplicitConstructor
	|
	|-RVA: 0x5679EEC Offset: 0x5675EEC VA: 0x5679EEC
	|-TypeUtility.TypeConstructor<Color>.SetImplicitConstructor
	|
	|-RVA: 0x567A7A0 Offset: 0x56767A0 VA: 0x567A7A0
	|-TypeUtility.TypeConstructor<object>.SetImplicitConstructor
	|
	|-RVA: 0x567B008 Offset: 0x5677008 VA: 0x567B008
	|-TypeUtility.TypeConstructor<Rect>.SetImplicitConstructor
	|
	|-RVA: 0x567B8BC Offset: 0x56778BC VA: 0x567B8BC
	|-TypeUtility.TypeConstructor<RectInt>.SetImplicitConstructor
	|
	|-RVA: 0x567C164 Offset: 0x5678164 VA: 0x567C164
	|-TypeUtility.TypeConstructor<Vector2>.SetImplicitConstructor
	|
	|-RVA: 0x567CA00 Offset: 0x5678A00 VA: 0x567CA00
	|-TypeUtility.TypeConstructor<Vector2Int>.SetImplicitConstructor
	|
	|-RVA: 0x567D298 Offset: 0x5679298 VA: 0x567D298
	|-TypeUtility.TypeConstructor<Vector3>.SetImplicitConstructor
	|
	|-RVA: 0x567DB48 Offset: 0x5679B48 VA: 0x567DB48
	|-TypeUtility.TypeConstructor<Vector3Int>.SetImplicitConstructor
	|
	|-RVA: 0x567E40C Offset: 0x567A40C VA: 0x567E40C
	|-TypeUtility.TypeConstructor<Vector4>.SetImplicitConstructor
	|
	|-RVA: 0x567ECC8 Offset: 0x567ACC8 VA: 0x567ECC8
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetImplicitConstructor
	*/

	// RVA: -1 Offset: -1
	private static T CreateValueTypeInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678EDC Offset: 0x5674EDC VA: 0x5678EDC
	|-TypeUtility.TypeConstructor<Bounds>.CreateValueTypeInstance
	|
	|-RVA: 0x5679808 Offset: 0x5675808 VA: 0x5679808
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateValueTypeInstance
	|
	|-RVA: 0x567A134 Offset: 0x5676134 VA: 0x567A134
	|-TypeUtility.TypeConstructor<Color>.CreateValueTypeInstance
	|
	|-RVA: 0x567A9E8 Offset: 0x56769E8 VA: 0x567A9E8
	|-TypeUtility.TypeConstructor<object>.CreateValueTypeInstance
	|
	|-RVA: 0x567B250 Offset: 0x5677250 VA: 0x567B250
	|-TypeUtility.TypeConstructor<Rect>.CreateValueTypeInstance
	|
	|-RVA: 0x567BB04 Offset: 0x5677B04 VA: 0x567BB04
	|-TypeUtility.TypeConstructor<RectInt>.CreateValueTypeInstance
	|
	|-RVA: 0x567C3AC Offset: 0x56783AC VA: 0x567C3AC
	|-TypeUtility.TypeConstructor<Vector2>.CreateValueTypeInstance
	|
	|-RVA: 0x567CC48 Offset: 0x5678C48 VA: 0x567CC48
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateValueTypeInstance
	|
	|-RVA: 0x567D4E0 Offset: 0x56794E0 VA: 0x567D4E0
	|-TypeUtility.TypeConstructor<Vector3>.CreateValueTypeInstance
	|
	|-RVA: 0x567DD90 Offset: 0x5679D90 VA: 0x567DD90
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateValueTypeInstance
	|
	|-RVA: 0x567E654 Offset: 0x567A654 VA: 0x567E654
	|-TypeUtility.TypeConstructor<Vector4>.CreateValueTypeInstance
	|
	|-RVA: 0x567EF24 Offset: 0x567AF24 VA: 0x567EF24
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateValueTypeInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateScriptableObjectInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678EE8 Offset: 0x5674EE8 VA: 0x5678EE8
	|-TypeUtility.TypeConstructor<Bounds>.CreateScriptableObjectInstance
	|
	|-RVA: 0x5679814 Offset: 0x5675814 VA: 0x5679814
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567A148 Offset: 0x5676148 VA: 0x567A148
	|-TypeUtility.TypeConstructor<Color>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567A9F0 Offset: 0x56769F0 VA: 0x567A9F0
	|-TypeUtility.TypeConstructor<object>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567B264 Offset: 0x5677264 VA: 0x567B264
	|-TypeUtility.TypeConstructor<Rect>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567BB10 Offset: 0x5677B10 VA: 0x567BB10
	|-TypeUtility.TypeConstructor<RectInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567C3B8 Offset: 0x56783B8 VA: 0x567C3B8
	|-TypeUtility.TypeConstructor<Vector2>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567CC50 Offset: 0x5678C50 VA: 0x567CC50
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567D4F0 Offset: 0x56794F0 VA: 0x567D4F0
	|-TypeUtility.TypeConstructor<Vector3>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567DD9C Offset: 0x5679D9C VA: 0x567DD9C
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567E668 Offset: 0x567A668 VA: 0x567E668
	|-TypeUtility.TypeConstructor<Vector4>.CreateScriptableObjectInstance
	|
	|-RVA: 0x567F038 Offset: 0x567B038 VA: 0x567F038
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateScriptableObjectInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateClassInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5678FDC Offset: 0x5674FDC VA: 0x5678FDC
	|-TypeUtility.TypeConstructor<Bounds>.CreateClassInstance
	|
	|-RVA: 0x5679908 Offset: 0x5675908 VA: 0x5679908
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateClassInstance
	|
	|-RVA: 0x567A230 Offset: 0x5676230 VA: 0x567A230
	|-TypeUtility.TypeConstructor<Color>.CreateClassInstance
	|
	|-RVA: 0x567AACC Offset: 0x5676ACC VA: 0x567AACC
	|-TypeUtility.TypeConstructor<object>.CreateClassInstance
	|
	|-RVA: 0x567B34C Offset: 0x567734C VA: 0x567B34C
	|-TypeUtility.TypeConstructor<Rect>.CreateClassInstance
	|
	|-RVA: 0x567BBF8 Offset: 0x5677BF8 VA: 0x567BBF8
	|-TypeUtility.TypeConstructor<RectInt>.CreateClassInstance
	|
	|-RVA: 0x567C49C Offset: 0x567849C VA: 0x567C49C
	|-TypeUtility.TypeConstructor<Vector2>.CreateClassInstance
	|
	|-RVA: 0x567CD34 Offset: 0x5678D34 VA: 0x567CD34
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateClassInstance
	|
	|-RVA: 0x567D5D8 Offset: 0x56795D8 VA: 0x567D5D8
	|-TypeUtility.TypeConstructor<Vector3>.CreateClassInstance
	|
	|-RVA: 0x567DE88 Offset: 0x5679E88 VA: 0x567DE88
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateClassInstance
	|
	|-RVA: 0x567E750 Offset: 0x567A750 VA: 0x567E750
	|-TypeUtility.TypeConstructor<Vector4>.CreateClassInstance
	|
	|-RVA: 0x567F1E0 Offset: 0x567B1E0 VA: 0x567F1E0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateClassInstance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetExplicitConstructor(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x567902C Offset: 0x567502C VA: 0x567902C
	|-TypeUtility.TypeConstructor<Bounds>.SetExplicitConstructor
	|
	|-RVA: 0x5679958 Offset: 0x5675958 VA: 0x5679958
	|-TypeUtility.TypeConstructor<BoundsInt>.SetExplicitConstructor
	|
	|-RVA: 0x567A254 Offset: 0x5676254 VA: 0x567A254
	|-TypeUtility.TypeConstructor<Color>.SetExplicitConstructor
	|
	|-RVA: 0x567AAF0 Offset: 0x5676AF0 VA: 0x567AAF0
	|-TypeUtility.TypeConstructor<object>.SetExplicitConstructor
	|
	|-RVA: 0x567B370 Offset: 0x5677370 VA: 0x567B370
	|-TypeUtility.TypeConstructor<Rect>.SetExplicitConstructor
	|
	|-RVA: 0x567BC1C Offset: 0x5677C1C VA: 0x567BC1C
	|-TypeUtility.TypeConstructor<RectInt>.SetExplicitConstructor
	|
	|-RVA: 0x567C4C0 Offset: 0x56784C0 VA: 0x567C4C0
	|-TypeUtility.TypeConstructor<Vector2>.SetExplicitConstructor
	|
	|-RVA: 0x567CD58 Offset: 0x5678D58 VA: 0x567CD58
	|-TypeUtility.TypeConstructor<Vector2Int>.SetExplicitConstructor
	|
	|-RVA: 0x567D5FC Offset: 0x56795FC VA: 0x567D5FC
	|-TypeUtility.TypeConstructor<Vector3>.SetExplicitConstructor
	|
	|-RVA: 0x567DEB4 Offset: 0x5679EB4 VA: 0x567DEB4
	|-TypeUtility.TypeConstructor<Vector3Int>.SetExplicitConstructor
	|
	|-RVA: 0x567E774 Offset: 0x567A774 VA: 0x567E774
	|-TypeUtility.TypeConstructor<Vector4>.SetExplicitConstructor
	|
	|-RVA: 0x567F338 Offset: 0x567B338 VA: 0x567F338
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5679034 Offset: 0x5675034 VA: 0x5679034
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x5679960 Offset: 0x5675960 VA: 0x5679960
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567A25C Offset: 0x567625C VA: 0x567A25C
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567AAF8 Offset: 0x5676AF8 VA: 0x567AAF8
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567B378 Offset: 0x5677378 VA: 0x567B378
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567BC24 Offset: 0x5677C24 VA: 0x567BC24
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567C4C8 Offset: 0x56784C8 VA: 0x567C4C8
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567CD60 Offset: 0x5678D60 VA: 0x567CD60
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567D604 Offset: 0x5679604 VA: 0x567D604
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567DEBC Offset: 0x5679EBC VA: 0x567DEBC
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567E77C Offset: 0x567A77C VA: 0x567E77C
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x567F340 Offset: 0x567B340 VA: 0x567F340
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56792C8 Offset: 0x56752C8 VA: 0x56792C8
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x5679BF4 Offset: 0x5675BF4 VA: 0x5679BF4
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567A4BC Offset: 0x56764BC VA: 0x567A4BC
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567AD58 Offset: 0x5676D58 VA: 0x567AD58
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567B5D8 Offset: 0x56775D8 VA: 0x567B5D8
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567BE84 Offset: 0x5677E84 VA: 0x567BE84
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567C728 Offset: 0x5678728 VA: 0x567C728
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567CFC0 Offset: 0x5678FC0 VA: 0x567CFC0
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567D864 Offset: 0x5679864 VA: 0x567D864
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567E128 Offset: 0x567A128 VA: 0x567E128
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567E9DC Offset: 0x567A9DC VA: 0x567E9DC
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x567F684 Offset: 0x567B684 VA: 0x567F684
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	*/
}

// Namespace: 
private class TypeUtility.NonConstructable : TypeUtility.ITypeConstructor // TypeDefIndex: 27825
{
	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: 0x87DFEA0 Offset: 0x87DBEA0 VA: 0x87DFEA0 Slot: 4
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x87DFEA8 Offset: 0x87DBEA8 VA: 0x87DFEA8 Slot: 5
	public object Instantiate() { }

	// RVA: 0x87DFA70 Offset: 0x87DBA70 VA: 0x87DFA70
	public void .ctor() { }
}

// Namespace: 
private struct TypeUtility.Cache<T> // TypeDefIndex: 27826
{
	// Fields
	public static TypeUtility.ITypeConstructor<T> TypeConstructor; // 0x0
}

// Namespace: 
private class TypeUtility.TypeConstructorVisitor : ITypeVisitor // TypeDefIndex: 27827
{
	// Fields
	public TypeUtility.ITypeConstructor TypeConstructor; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Visit<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A453C Offset: 0x47A053C VA: 0x47A453C
	|-TypeUtility.TypeConstructorVisitor.Visit<Bounds>
	|
	|-RVA: 0x47A45AC Offset: 0x47A05AC VA: 0x47A45AC
	|-TypeUtility.TypeConstructorVisitor.Visit<BoundsInt>
	|
	|-RVA: 0x47A461C Offset: 0x47A061C VA: 0x47A461C
	|-TypeUtility.TypeConstructorVisitor.Visit<Color>
	|
	|-RVA: 0x47A468C Offset: 0x47A068C VA: 0x47A468C
	|-TypeUtility.TypeConstructorVisitor.Visit<object>
	|
	|-RVA: 0x47A46FC Offset: 0x47A06FC VA: 0x47A46FC
	|-TypeUtility.TypeConstructorVisitor.Visit<Rect>
	|
	|-RVA: 0x47A476C Offset: 0x47A076C VA: 0x47A476C
	|-TypeUtility.TypeConstructorVisitor.Visit<RectInt>
	|
	|-RVA: 0x47A47DC Offset: 0x47A07DC VA: 0x47A47DC
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector2>
	|
	|-RVA: 0x47A484C Offset: 0x47A084C VA: 0x47A484C
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector2Int>
	|
	|-RVA: 0x47A48BC Offset: 0x47A08BC VA: 0x47A48BC
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector3>
	|
	|-RVA: 0x47A492C Offset: 0x47A092C VA: 0x47A492C
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector3Int>
	|
	|-RVA: 0x47A499C Offset: 0x47A099C VA: 0x47A499C
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector4>
	|
	|-RVA: 0x47A4A0C Offset: 0x47A0A0C VA: 0x47A4A0C
	|-TypeUtility.TypeConstructorVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DFA68 Offset: 0x87DBA68 VA: 0x87DFA68
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeUtility.<>c // TypeDefIndex: 27828
{
	// Fields
	public static readonly TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x87DFEF4 Offset: 0x87DBEF4 VA: 0x87DFEF4
	private static void .cctor() { }

	// RVA: 0x87DFF5C Offset: 0x87DBF5C VA: 0x87DFF5C
	public void .ctor() { }

	// RVA: 0x87DFF64 Offset: 0x87DBF64 VA: 0x87DFF64
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x87DFFB8 Offset: 0x87DBFB8 VA: 0x87DFFB8
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x87DFFD0 Offset: 0x87DBFD0 VA: 0x87DFFD0
	internal string <.cctor>b__11_2() { }
}

// Namespace: Unity.Properties
[Extension]
public static class TypeUtility // TypeDefIndex: 27829
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x87DE520 Offset: 0x87DA520 VA: 0x87DE520
	private static void .cctor() { }

	// RVA: 0x87DE968 Offset: 0x87DA968 VA: 0x87DE968
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x87DEA80 Offset: 0x87DAA80 VA: 0x87DEA80
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x87DF42C Offset: 0x87DB42C VA: 0x87DF42C
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x87DF560 Offset: 0x87DB560 VA: 0x87DF560
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736E44 Offset: 0x4732E44 VA: 0x4736E44
	|-TypeUtility.CreateTypeConstructor<Bounds>
	|
	|-RVA: 0x4736F74 Offset: 0x4732F74 VA: 0x4736F74
	|-TypeUtility.CreateTypeConstructor<BoundsInt>
	|
	|-RVA: 0x47370A4 Offset: 0x47330A4 VA: 0x47370A4
	|-TypeUtility.CreateTypeConstructor<Color>
	|
	|-RVA: 0x47371D4 Offset: 0x47331D4 VA: 0x47371D4
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0x4737304 Offset: 0x4733304 VA: 0x4737304
	|-TypeUtility.CreateTypeConstructor<Rect>
	|
	|-RVA: 0x4737434 Offset: 0x4733434 VA: 0x4737434
	|-TypeUtility.CreateTypeConstructor<RectInt>
	|
	|-RVA: 0x4737564 Offset: 0x4733564 VA: 0x4737564
	|-TypeUtility.CreateTypeConstructor<Vector2>
	|
	|-RVA: 0x4737694 Offset: 0x4733694 VA: 0x4737694
	|-TypeUtility.CreateTypeConstructor<Vector2Int>
	|
	|-RVA: 0x47377C4 Offset: 0x47337C4 VA: 0x47377C4
	|-TypeUtility.CreateTypeConstructor<Vector3>
	|
	|-RVA: 0x47378F4 Offset: 0x47338F4 VA: 0x47378F4
	|-TypeUtility.CreateTypeConstructor<Vector3Int>
	|
	|-RVA: 0x4737A24 Offset: 0x4733A24 VA: 0x4737A24
	|-TypeUtility.CreateTypeConstructor<Vector4>
	|
	|-RVA: 0x4737B54 Offset: 0x4733B54 VA: 0x4737B54
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DFA78 Offset: 0x87DBA78 VA: 0x87DFA78
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4737C88 Offset: 0x4733C88 VA: 0x4737C88
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0x4737D20 Offset: 0x4733D20 VA: 0x4737D20
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DFB30 Offset: 0x87DBB30 VA: 0x87DFB30
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736C24 Offset: 0x4732C24 VA: 0x4736C24
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47389D0 Offset: 0x47349D0 VA: 0x47389D0
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0x4738AB4 Offset: 0x4734AB4 VA: 0x4738AB4
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4737DBC Offset: 0x4733DBC VA: 0x4737DBC
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4738B9C Offset: 0x4734B9C VA: 0x4738B9C
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4737F70 Offset: 0x4733F70 VA: 0x4737F70
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4738DB0 Offset: 0x4734DB0 VA: 0x4738DB0
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4738190 Offset: 0x4734190 VA: 0x4738190
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4739034 Offset: 0x4735034 VA: 0x4739034
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47385B0 Offset: 0x47345B0 VA: 0x47385B0
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DFBFC Offset: 0x87DBBFC VA: 0x87DFBFC
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736CF4 Offset: 0x4732CF4 VA: 0x4736CF4
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DFD6C Offset: 0x87DBD6C VA: 0x87DFD6C
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}

// Namespace: Unity.Properties.Internal
internal interface IAttributes // TypeDefIndex: 27830
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddAttribute(Attribute attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddAttributes(IEnumerable<Attribute> attributes);
}

// Namespace: Unity.Properties.Internal
internal static class DefaultPropertyBagInitializer // TypeDefIndex: 27831
{
	// Methods

	// RVA: 0x87E0018 Offset: 0x87DC018 VA: 0x87E0018
	internal static void Initialize() { }
}

// Namespace: 
private class ColorPropertyBag.RProperty : Property<Color, float> // TypeDefIndex: 27832
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1160 Offset: 0x87DD160 VA: 0x87E1160 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1040 Offset: 0x87DD040 VA: 0x87E1040
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.GProperty : Property<Color, float> // TypeDefIndex: 27833
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E11A0 Offset: 0x87DD1A0 VA: 0x87E11A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1088 Offset: 0x87DD088 VA: 0x87E1088
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.BProperty : Property<Color, float> // TypeDefIndex: 27834
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E11E0 Offset: 0x87DD1E0 VA: 0x87E11E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E10D0 Offset: 0x87DD0D0 VA: 0x87E10D0
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.AProperty : Property<Color, float> // TypeDefIndex: 27835
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1220 Offset: 0x87DD220 VA: 0x87E1220 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1118 Offset: 0x87DD118 VA: 0x87E1118
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag : ContainerPropertyBag<Color> // TypeDefIndex: 27836
{
	// Methods

	// RVA: 0x87E0348 Offset: 0x87DC348 VA: 0x87E0348
	public void .ctor() { }
}

// Namespace: 
private class Vector2PropertyBag.XProperty : Property<Vector2, float> // TypeDefIndex: 27837
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E12F0 Offset: 0x87DD2F0 VA: 0x87E12F0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1260 Offset: 0x87DD260 VA: 0x87E1260
	public void .ctor() { }
}

// Namespace: 
private class Vector2PropertyBag.YProperty : Property<Vector2, float> // TypeDefIndex: 27838
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1330 Offset: 0x87DD330 VA: 0x87E1330 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E12A8 Offset: 0x87DD2A8 VA: 0x87E12A8
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2> // TypeDefIndex: 27839
{
	// Methods

	// RVA: 0x87E04A8 Offset: 0x87DC4A8 VA: 0x87E04A8
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.XProperty : Property<Vector3, float> // TypeDefIndex: 27840
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1448 Offset: 0x87DD448 VA: 0x87E1448 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1370 Offset: 0x87DD370 VA: 0x87E1370
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.YProperty : Property<Vector3, float> // TypeDefIndex: 27841
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1488 Offset: 0x87DD488 VA: 0x87E1488 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E13B8 Offset: 0x87DD3B8 VA: 0x87E13B8
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.ZProperty : Property<Vector3, float> // TypeDefIndex: 27842
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E14C8 Offset: 0x87DD4C8 VA: 0x87E14C8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1400 Offset: 0x87DD400 VA: 0x87E1400
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag : ContainerPropertyBag<Vector3> // TypeDefIndex: 27843
{
	// Methods

	// RVA: 0x87E0598 Offset: 0x87DC598 VA: 0x87E0598
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.XProperty : Property<Vector4, float> // TypeDefIndex: 27844
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1628 Offset: 0x87DD628 VA: 0x87E1628 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1508 Offset: 0x87DD508 VA: 0x87E1508
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.YProperty : Property<Vector4, float> // TypeDefIndex: 27845
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1668 Offset: 0x87DD668 VA: 0x87E1668 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1550 Offset: 0x87DD550 VA: 0x87E1550
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.ZProperty : Property<Vector4, float> // TypeDefIndex: 27846
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E16A8 Offset: 0x87DD6A8 VA: 0x87E16A8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1598 Offset: 0x87DD598 VA: 0x87E1598
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.WProperty : Property<Vector4, float> // TypeDefIndex: 27847
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E16E8 Offset: 0x87DD6E8 VA: 0x87E16E8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E15E0 Offset: 0x87DD5E0 VA: 0x87E15E0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag : ContainerPropertyBag<Vector4> // TypeDefIndex: 27848
{
	// Methods

	// RVA: 0x87E06C4 Offset: 0x87DC6C4 VA: 0x87E06C4
	public void .ctor() { }
}

// Namespace: 
private class Vector2IntPropertyBag.XProperty : Property<Vector2Int, int> // TypeDefIndex: 27849
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E17B8 Offset: 0x87DD7B8 VA: 0x87E17B8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1728 Offset: 0x87DD728 VA: 0x87E1728
	public void .ctor() { }
}

// Namespace: 
private class Vector2IntPropertyBag.YProperty : Property<Vector2Int, int> // TypeDefIndex: 27850
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E17F8 Offset: 0x87DD7F8 VA: 0x87E17F8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1770 Offset: 0x87DD770 VA: 0x87E1770
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int> // TypeDefIndex: 27851
{
	// Methods

	// RVA: 0x87E0824 Offset: 0x87DC824 VA: 0x87E0824
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.XProperty : Property<Vector3Int, int> // TypeDefIndex: 27852
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1910 Offset: 0x87DD910 VA: 0x87E1910 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1838 Offset: 0x87DD838 VA: 0x87E1838
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.YProperty : Property<Vector3Int, int> // TypeDefIndex: 27853
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1950 Offset: 0x87DD950 VA: 0x87E1950 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1880 Offset: 0x87DD880 VA: 0x87E1880
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.ZProperty : Property<Vector3Int, int> // TypeDefIndex: 27854
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1990 Offset: 0x87DD990 VA: 0x87E1990 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E18C8 Offset: 0x87DD8C8 VA: 0x87E18C8
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int> // TypeDefIndex: 27855
{
	// Methods

	// RVA: 0x87E0914 Offset: 0x87DC914 VA: 0x87E0914
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.XProperty : Property<Rect, float> // TypeDefIndex: 27856
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1AF0 Offset: 0x87DDAF0 VA: 0x87E1AF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E19D0 Offset: 0x87DD9D0 VA: 0x87E19D0
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.YProperty : Property<Rect, float> // TypeDefIndex: 27857
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1B30 Offset: 0x87DDB30 VA: 0x87E1B30 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1A18 Offset: 0x87DDA18 VA: 0x87E1A18
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.WidthProperty : Property<Rect, float> // TypeDefIndex: 27858
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1B70 Offset: 0x87DDB70 VA: 0x87E1B70 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1A60 Offset: 0x87DDA60 VA: 0x87E1A60
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.HeightProperty : Property<Rect, float> // TypeDefIndex: 27859
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1BB0 Offset: 0x87DDBB0 VA: 0x87E1BB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1AA8 Offset: 0x87DDAA8 VA: 0x87E1AA8
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag : ContainerPropertyBag<Rect> // TypeDefIndex: 27860
{
	// Methods

	// RVA: 0x87E0A40 Offset: 0x87DCA40 VA: 0x87E0A40
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.XProperty : Property<RectInt, int> // TypeDefIndex: 27861
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1D10 Offset: 0x87DDD10 VA: 0x87E1D10 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1BF0 Offset: 0x87DDBF0 VA: 0x87E1BF0
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.YProperty : Property<RectInt, int> // TypeDefIndex: 27862
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1D50 Offset: 0x87DDD50 VA: 0x87E1D50 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1C38 Offset: 0x87DDC38 VA: 0x87E1C38
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.WidthProperty : Property<RectInt, int> // TypeDefIndex: 27863
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1D90 Offset: 0x87DDD90 VA: 0x87E1D90 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1C80 Offset: 0x87DDC80 VA: 0x87E1C80
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.HeightProperty : Property<RectInt, int> // TypeDefIndex: 27864
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1DD0 Offset: 0x87DDDD0 VA: 0x87E1DD0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1CC8 Offset: 0x87DDCC8 VA: 0x87E1CC8
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag : ContainerPropertyBag<RectInt> // TypeDefIndex: 27865
{
	// Methods

	// RVA: 0x87E0BA0 Offset: 0x87DCBA0 VA: 0x87E0BA0
	public void .ctor() { }
}

// Namespace: 
private class BoundsPropertyBag.CenterProperty : Property<Bounds, Vector3> // TypeDefIndex: 27866
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1EA0 Offset: 0x87DDEA0 VA: 0x87E1EA0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1E10 Offset: 0x87DDE10 VA: 0x87E1E10
	public void .ctor() { }
}

// Namespace: 
private class BoundsPropertyBag.ExtentsProperty : Property<Bounds, Vector3> // TypeDefIndex: 27867
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1EE0 Offset: 0x87DDEE0 VA: 0x87E1EE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1E58 Offset: 0x87DDE58 VA: 0x87E1E58
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds> // TypeDefIndex: 27868
{
	// Methods

	// RVA: 0x87E0D00 Offset: 0x87DCD00 VA: 0x87E0D00
	public void .ctor() { }
}

// Namespace: 
private class BoundsIntPropertyBag.PositionProperty : Property<BoundsInt, Vector3Int> // TypeDefIndex: 27869
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1FB0 Offset: 0x87DDFB0 VA: 0x87E1FB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1F20 Offset: 0x87DDF20 VA: 0x87E1F20
	public void .ctor() { }
}

// Namespace: 
private class BoundsIntPropertyBag.SizeProperty : Property<BoundsInt, Vector3Int> // TypeDefIndex: 27870
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E1FF0 Offset: 0x87DDFF0 VA: 0x87E1FF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x87E1F68 Offset: 0x87DDF68 VA: 0x87E1F68
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt> // TypeDefIndex: 27871
{
	// Methods

	// RVA: 0x87E0DF0 Offset: 0x87DCDF0 VA: 0x87E0DF0
	public void .ctor() { }
}

// Namespace: 
private class SystemVersionPropertyBag.MajorProperty : Property<Version, int> // TypeDefIndex: 27872
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E2030 Offset: 0x87DE030 VA: 0x87E2030
	public void .ctor() { }

	// RVA: 0x87E22B0 Offset: 0x87DE2B0 VA: 0x87E22B0 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.MinorProperty : Property<Version, int> // TypeDefIndex: 27873
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E20D0 Offset: 0x87DE0D0 VA: 0x87E20D0
	public void .ctor() { }

	// RVA: 0x87E22F0 Offset: 0x87DE2F0 VA: 0x87E22F0 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.BuildProperty : Property<Version, int> // TypeDefIndex: 27874
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E2170 Offset: 0x87DE170 VA: 0x87E2170
	public void .ctor() { }

	// RVA: 0x87E2330 Offset: 0x87DE330 VA: 0x87E2330 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.RevisionProperty : Property<Version, int> // TypeDefIndex: 27875
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x87E2210 Offset: 0x87DE210 VA: 0x87E2210
	public void .ctor() { }

	// RVA: 0x87E2370 Offset: 0x87DE370 VA: 0x87E2370 Slot: 7
	public override string get_Name() { }
}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version> // TypeDefIndex: 27876
{
	// Methods

	// RVA: 0x87E0EE0 Offset: 0x87DCEE0 VA: 0x87E0EE0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister // TypeDefIndex: 27877
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register();
}

// Namespace: 
internal struct PropertyBagStore.TypedStore<TContainer> // TypeDefIndex: 27878
{
	// Fields
	public static IPropertyBag<TContainer> PropertyBag; // 0x0
}

// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore // TypeDefIndex: 27879
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Type, IPropertyBag> NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Methods

	// RVA: 0x87E23B0 Offset: 0x87DE3B0 VA: 0x87E23B0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A6100 Offset: 0x46A2100 VA: 0x46A6100
	|-PropertyBagStore.AddPropertyBag<Bounds>
	|
	|-RVA: 0x46A66B8 Offset: 0x46A26B8 VA: 0x46A66B8
	|-PropertyBagStore.AddPropertyBag<BoundsInt>
	|
	|-RVA: 0x46A6C70 Offset: 0x46A2C70 VA: 0x46A6C70
	|-PropertyBagStore.AddPropertyBag<Color>
	|
	|-RVA: 0x46A7228 Offset: 0x46A3228 VA: 0x46A7228
	|-PropertyBagStore.AddPropertyBag<object>
	|
	|-RVA: 0x46A77E0 Offset: 0x46A37E0 VA: 0x46A77E0
	|-PropertyBagStore.AddPropertyBag<Rect>
	|
	|-RVA: 0x46A7D98 Offset: 0x46A3D98 VA: 0x46A7D98
	|-PropertyBagStore.AddPropertyBag<RectInt>
	|
	|-RVA: 0x46A8350 Offset: 0x46A4350 VA: 0x46A8350
	|-PropertyBagStore.AddPropertyBag<Vector2>
	|
	|-RVA: 0x46A8908 Offset: 0x46A4908 VA: 0x46A8908
	|-PropertyBagStore.AddPropertyBag<Vector2Int>
	|
	|-RVA: 0x46A8EC0 Offset: 0x46A4EC0 VA: 0x46A8EC0
	|-PropertyBagStore.AddPropertyBag<Vector3>
	|
	|-RVA: 0x46A9478 Offset: 0x46A5478 VA: 0x46A9478
	|-PropertyBagStore.AddPropertyBag<Vector3Int>
	|
	|-RVA: 0x46A9A30 Offset: 0x46A5A30 VA: 0x46A9A30
	|-PropertyBagStore.AddPropertyBag<Vector4>
	|
	|-RVA: 0x46A9FE8 Offset: 0x46A5FE8 VA: 0x46A9FE8
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46AA4F8 Offset: 0x46A64F8 VA: 0x46AA4F8
	|-PropertyBagStore.GetPropertyBag<Bounds>
	|
	|-RVA: 0x46AA640 Offset: 0x46A6640 VA: 0x46AA640
	|-PropertyBagStore.GetPropertyBag<BoundsInt>
	|
	|-RVA: 0x46AA788 Offset: 0x46A6788 VA: 0x46AA788
	|-PropertyBagStore.GetPropertyBag<Color>
	|
	|-RVA: 0x46AA8D0 Offset: 0x46A68D0 VA: 0x46AA8D0
	|-PropertyBagStore.GetPropertyBag<object>
	|
	|-RVA: 0x46AAA18 Offset: 0x46A6A18 VA: 0x46AAA18
	|-PropertyBagStore.GetPropertyBag<Rect>
	|
	|-RVA: 0x46AAB60 Offset: 0x46A6B60 VA: 0x46AAB60
	|-PropertyBagStore.GetPropertyBag<RectInt>
	|
	|-RVA: 0x46AACA8 Offset: 0x46A6CA8 VA: 0x46AACA8
	|-PropertyBagStore.GetPropertyBag<Vector2>
	|
	|-RVA: 0x46AADF0 Offset: 0x46A6DF0 VA: 0x46AADF0
	|-PropertyBagStore.GetPropertyBag<Vector2Int>
	|
	|-RVA: 0x46AAF38 Offset: 0x46A6F38 VA: 0x46AAF38
	|-PropertyBagStore.GetPropertyBag<Vector3>
	|
	|-RVA: 0x46AB080 Offset: 0x46A7080 VA: 0x46AB080
	|-PropertyBagStore.GetPropertyBag<Vector3Int>
	|
	|-RVA: 0x46AB1C8 Offset: 0x46A71C8 VA: 0x46AB1C8
	|-PropertyBagStore.GetPropertyBag<Vector4>
	|
	|-RVA: 0x46AB310 Offset: 0x46A7310 VA: 0x46AB310
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87DF7E4 Offset: 0x87DB7E4 VA: 0x87DF7E4
	internal static IPropertyBag GetPropertyBag(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute : Attribute // TypeDefIndex: 27880
{
	// Methods

	// RVA: 0x87E2A2C Offset: 0x87DEA2C VA: 0x87E2A2C
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
[ReflectedPropertyBag]
internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer> // TypeDefIndex: 27881
{
	// Methods

	// RVA: -1 Offset: -1
	internal void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347F64 Offset: 0x4343F64 VA: 0x4347F64
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495A2C Offset: 0x5491A2C VA: 0x5495A2C
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectedPropertyBagProvider.<>c // TypeDefIndex: 27882
{
	// Fields
	public static readonly ReflectedPropertyBagProvider.<>c <>9; // 0x0
	public static Func<MethodInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, int> <>9__22_0; // 0x10

	// Methods

	// RVA: 0x87E2D10 Offset: 0x87DED10 VA: 0x87E2D10
	private static void .cctor() { }

	// RVA: 0x87E2D78 Offset: 0x87DED78 VA: 0x87E2D78
	public void .ctor() { }

	// RVA: 0x87E2D80 Offset: 0x87DED80 VA: 0x87E2D80
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x87E2E0C Offset: 0x87DEE0C VA: 0x87E2E0C
	internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectedPropertyBagProvider.<GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable // TypeDefIndex: 27883
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private IOrderedEnumerable<MemberInfo> <members>5__1; // 0x38
	private IEnumerator<MemberInfo> <>s__2; // 0x40
	private MemberInfo <member>5__3; // 0x48
	private bool <hasDontCreatePropertyAttribute>5__4; // 0x50
	private bool <hasCreatePropertyAttribute>5__5; // 0x51
	private bool <hasNonSerializedAttribute>5__6; // 0x52
	private bool <hasSerializedFieldAttribute>5__7; // 0x53
	private FieldInfo <field>5__8; // 0x58

	// Properties
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x87E2AB0 Offset: 0x87DEAB0 VA: 0x87E2AB0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x87E2E34 Offset: 0x87DEE34 VA: 0x87E2E34 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x87E2E60 Offset: 0x87DEE60 VA: 0x87E2E60 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x87E365C Offset: 0x87DF65C VA: 0x87E365C
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x87E370C Offset: 0x87DF70C VA: 0x87E370C Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x87E3714 Offset: 0x87DF714 VA: 0x87E3714 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x87E374C Offset: 0x87DF74C VA: 0x87E374C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x87E3754 Offset: 0x87DF754 VA: 0x87E3754 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x87E37F8 Offset: 0x87DF7F8 VA: 0x87E37F8 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider // TypeDefIndex: 27884
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x87E24F0 Offset: 0x87DE4F0 VA: 0x87E24F0
	public void .ctor() { }

	// RVA: 0x87E28FC Offset: 0x87DE8FC VA: 0x87E28FC
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B87F8 Offset: 0x46B47F8 VA: 0x46B87F8
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B8690 Offset: 0x46B4690 VA: 0x46B8690
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B8550 Offset: 0x46B4550 VA: 0x46B8550
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B9AFC Offset: 0x46B5AFC VA: 0x46B9AFC
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B85A0 Offset: 0x46B45A0 VA: 0x46B85A0
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B85F0 Offset: 0x46B45F0 VA: 0x46B85F0
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B8460 Offset: 0x46B4460 VA: 0x46B8460
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B8640 Offset: 0x46B4640 VA: 0x46B8640
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B8500 Offset: 0x46B4500 VA: 0x46B8500
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B84B0 Offset: 0x46B44B0 VA: 0x46B84B0
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x87E2A34 Offset: 0x87DEA34 VA: 0x87E2A34
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x87E2AE4 Offset: 0x87DEAE4 VA: 0x87E2AE4
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x87E2C1C Offset: 0x87DEC1C VA: 0x87E2C1C
	private static bool IsValidPropertyType(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities // TypeDefIndex: 27885
{
	// Methods

	// RVA: 0x87DE200 Offset: 0x87DA200 VA: 0x87DE200
	public static string SanitizeMemberName(MemberInfo info) { }
}

