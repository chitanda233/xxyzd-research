// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 23644
{}

// Namespace: 
public static class SRDebug // TypeDefIndex: 23645
{
	// Fields
	public const string Version = "1.6.2";

	// Properties
	public static IDebugService Instance { get; }

	// Methods

	// RVA: 0x7F82930 Offset: 0x7F7E930 VA: 0x7F82930
	public static IDebugService get_Instance() { }

	// RVA: 0x7F82970 Offset: 0x7F7E970 VA: 0x7F82970
	public static void Init() { }
}

// Namespace: 
[Usage(128)]
public sealed class SROptions.NumberRangeAttribute : Attribute // TypeDefIndex: 23646
{
	// Fields
	public readonly double Max; // 0x10
	public readonly double Min; // 0x18

	// Methods

	// RVA: 0x7F82C1C Offset: 0x7F7EC1C VA: 0x7F82C1C
	public void .ctor(double min, double max) { }
}

// Namespace: 
[Usage(128)]
public sealed class SROptions.IncrementAttribute : Attribute // TypeDefIndex: 23647
{
	// Fields
	public readonly double Increment; // 0x10

	// Methods

	// RVA: 0x7F82C48 Offset: 0x7F7EC48 VA: 0x7F82C48
	public void .ctor(double increment) { }
}

// Namespace: 
[Usage(192)]
public sealed class SROptions.SortAttribute : Attribute // TypeDefIndex: 23648
{
	// Fields
	public readonly int SortPriority; // 0x10

	// Methods

	// RVA: 0x7F82C70 Offset: 0x7F7EC70 VA: 0x7F82C70
	public void .ctor(int priority) { }
}

// Namespace: 
[Usage(192)]
public sealed class SROptions.DisplayNameAttribute : Attribute // TypeDefIndex: 23649
{
	// Fields
	public readonly string Name; // 0x10

	// Methods

	// RVA: 0x7F82C98 Offset: 0x7F7EC98 VA: 0x7F82C98
	public void .ctor(string name) { }
}

// Namespace: 
public class SROptions // TypeDefIndex: 23650
{
	// Fields
	private static readonly SROptions _current; // 0x0
	[CompilerGenerated]
	private SROptionsPropertyChanged PropertyChanged; // 0x10

	// Properties
	public static SROptions Current { get; }

	// Methods

	// RVA: 0x7F829F4 Offset: 0x7F7E9F4 VA: 0x7F829F4
	public static SROptions get_Current() { }

	[CompilerGenerated]
	// RVA: 0x7F82A4C Offset: 0x7F7EA4C VA: 0x7F82A4C
	public void add_PropertyChanged(SROptionsPropertyChanged value) { }

	[CompilerGenerated]
	// RVA: 0x7F82AE8 Offset: 0x7F7EAE8 VA: 0x7F82AE8
	public void remove_PropertyChanged(SROptionsPropertyChanged value) { }

	// RVA: 0x7F82B84 Offset: 0x7F7EB84 VA: 0x7F82B84
	public void OnPropertyChanged(string propertyName) { }

	// RVA: 0x7F82BAC Offset: 0x7F7EBAC VA: 0x7F82BAC
	public void .ctor() { }

	// RVA: 0x7F82BB4 Offset: 0x7F7EBB4 VA: 0x7F82BB4
	private static void .cctor() { }
}

// Namespace: 
public sealed class SROptionsPropertyChanged : MulticastDelegate // TypeDefIndex: 23651
{
	// Methods

	// RVA: 0x7F82CC8 Offset: 0x7F7ECC8 VA: 0x7F82CC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F82DD4 Offset: 0x7F7EDD4 VA: 0x7F82DD4 Slot: 13
	public virtual void Invoke(object sender, string propertyName) { }

	// RVA: 0x7F82DE8 Offset: 0x7F7EDE8 VA: 0x7F82DE8 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, string propertyName, AsyncCallback callback, object object) { }

	// RVA: 0x7F82E10 Offset: 0x7F7EE10 VA: 0x7F82E10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public static class SRDebugUtil // TypeDefIndex: 23652
{
	// Fields
	public const int LineBufferCount = 512;
	[CompilerGenerated]
	private static bool <IsFixedUpdate>k__BackingField; // 0x0

	// Properties
	public static bool IsFixedUpdate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F82E1C Offset: 0x7F7EE1C VA: 0x7F82E1C
	public static bool get_IsFixedUpdate() { }

	[CompilerGenerated]
	// RVA: 0x7F82E64 Offset: 0x7F7EE64 VA: 0x7F82E64
	public static void set_IsFixedUpdate(bool value) { }

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	// RVA: 0x7F82EB4 Offset: 0x7F7EEB4 VA: 0x7F82EB4
	public static void AssertNotNull(object value, string message, MonoBehaviour instance) { }

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	// RVA: 0x7F8305C Offset: 0x7F7F05C VA: 0x7F8305C
	public static void Assert(bool condition, string message, MonoBehaviour instance) { }

	[DebuggerStepThrough]
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	// RVA: 0x7F83168 Offset: 0x7F7F168 VA: 0x7F83168
	public static void EditorAssertNotNull(object value, string message, MonoBehaviour instance) { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x7F8316C Offset: 0x7F7F16C VA: 0x7F8316C
	public static void EditorAssert(bool condition, string message, MonoBehaviour instance) { }
}

// Namespace: 
public static class SRFileUtil // TypeDefIndex: 23653
{
	// Methods

	// RVA: 0x7F83174 Offset: 0x7F7F174 VA: 0x7F83174
	public static void DeleteDirectory(string path) { }

	// RVA: 0x7F83228 Offset: 0x7F7F228 VA: 0x7F83228
	public static string GetBytesReadable(long i) { }
}

// Namespace: 
public static class SRInstantiate // TypeDefIndex: 23654
{
	// Methods

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0C20 Offset: 0x46DCC20 VA: 0x46E0C20
	|-SRInstantiate.Instantiate<object>
	*/

	// RVA: 0x7F8340C Offset: 0x7F7F40C VA: 0x7F8340C
	public static GameObject Instantiate(GameObject prefab) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0C84 Offset: 0x46DCC84 VA: 0x46E0C84
	|-SRInstantiate.Instantiate<object>
	*/
}

// Namespace: 
public enum SRMath.EaseType // TypeDefIndex: 23655
{
	// Fields
	public int value__; // 0x0
	public const SRMath.EaseType Linear = 0;
	public const SRMath.EaseType QuadEaseOut = 1;
	public const SRMath.EaseType QuadEaseIn = 2;
	public const SRMath.EaseType QuadEaseInOut = 3;
	public const SRMath.EaseType QuadEaseOutIn = 4;
	public const SRMath.EaseType ExpoEaseOut = 5;
	public const SRMath.EaseType ExpoEaseIn = 6;
	public const SRMath.EaseType ExpoEaseInOut = 7;
	public const SRMath.EaseType ExpoEaseOutIn = 8;
	public const SRMath.EaseType CubicEaseOut = 9;
	public const SRMath.EaseType CubicEaseIn = 10;
	public const SRMath.EaseType CubicEaseInOut = 11;
	public const SRMath.EaseType CubicEaseOutIn = 12;
	public const SRMath.EaseType QuartEaseOut = 13;
	public const SRMath.EaseType QuartEaseIn = 14;
	public const SRMath.EaseType QuartEaseInOut = 15;
	public const SRMath.EaseType QuartEaseOutIn = 16;
	public const SRMath.EaseType QuintEaseOut = 17;
	public const SRMath.EaseType QuintEaseIn = 18;
	public const SRMath.EaseType QuintEaseInOut = 19;
	public const SRMath.EaseType QuintEaseOutIn = 20;
	public const SRMath.EaseType CircEaseOut = 21;
	public const SRMath.EaseType CircEaseIn = 22;
	public const SRMath.EaseType CircEaseInOut = 23;
	public const SRMath.EaseType CircEaseOutIn = 24;
	public const SRMath.EaseType SineEaseOut = 25;
	public const SRMath.EaseType SineEaseIn = 26;
	public const SRMath.EaseType SineEaseInOut = 27;
	public const SRMath.EaseType SineEaseOutIn = 28;
	public const SRMath.EaseType ElasticEaseOut = 29;
	public const SRMath.EaseType ElasticEaseIn = 30;
	public const SRMath.EaseType ElasticEaseInOut = 31;
	public const SRMath.EaseType ElasticEaseOutIn = 32;
	public const SRMath.EaseType BounceEaseOut = 33;
	public const SRMath.EaseType BounceEaseIn = 34;
	public const SRMath.EaseType BounceEaseInOut = 35;
	public const SRMath.EaseType BounceEaseOutIn = 36;
	public const SRMath.EaseType BackEaseOut = 37;
	public const SRMath.EaseType BackEaseIn = 38;
	public const SRMath.EaseType BackEaseInOut = 39;
	public const SRMath.EaseType BackEaseOutIn = 40;
}

// Namespace: 
private static class SRMath.TweenFunctions // TypeDefIndex: 23656
{
	// Methods

	// RVA: 0x7F841AC Offset: 0x7F801AC VA: 0x7F841AC
	public static float Linear(float t, float b, float c, float d) { }

	// RVA: 0x7F84294 Offset: 0x7F80294 VA: 0x7F84294
	public static float ExpoEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F842E0 Offset: 0x7F802E0 VA: 0x7F842E0
	public static float ExpoEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84328 Offset: 0x7F80328 VA: 0x7F84328
	public static float ExpoEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F843BC Offset: 0x7F803BC VA: 0x7F843BC
	public static float ExpoEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84778 Offset: 0x7F80778 VA: 0x7F84778
	public static float CircEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F847A0 Offset: 0x7F807A0 VA: 0x7F847A0
	public static float CircEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F847C8 Offset: 0x7F807C8 VA: 0x7F847C8
	public static float CircEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F8481C Offset: 0x7F8081C VA: 0x7F8481C
	public static float CircEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F841BC Offset: 0x7F801BC VA: 0x7F841BC
	public static float QuadEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F841D8 Offset: 0x7F801D8 VA: 0x7F841D8
	public static float QuadEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F841EC Offset: 0x7F801EC VA: 0x7F841EC
	public static float QuadEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84240 Offset: 0x7F80240 VA: 0x7F84240
	public static float QuadEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84890 Offset: 0x7F80890 VA: 0x7F84890
	public static float SineEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F848C8 Offset: 0x7F808C8 VA: 0x7F848C8
	public static float SineEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84904 Offset: 0x7F80904 VA: 0x7F84904
	public static float SineEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84988 Offset: 0x7F80988 VA: 0x7F84988
	public static float SineEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84458 Offset: 0x7F80458 VA: 0x7F84458
	public static float CubicEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84480 Offset: 0x7F80480 VA: 0x7F84480
	public static float CubicEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84498 Offset: 0x7F80498 VA: 0x7F84498
	public static float CubicEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F844EC Offset: 0x7F804EC VA: 0x7F844EC
	public static float CubicEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F8454C Offset: 0x7F8054C VA: 0x7F8454C
	public static float QuartEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84574 Offset: 0x7F80574 VA: 0x7F84574
	public static float QuartEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84590 Offset: 0x7F80590 VA: 0x7F84590
	public static float QuartEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F845EC Offset: 0x7F805EC VA: 0x7F845EC
	public static float QuartEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84654 Offset: 0x7F80654 VA: 0x7F84654
	public static float QuintEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84684 Offset: 0x7F80684 VA: 0x7F84684
	public static float QuintEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F846A4 Offset: 0x7F806A4 VA: 0x7F846A4
	public static float QuintEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84708 Offset: 0x7F80708 VA: 0x7F84708
	public static float QuintEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84A04 Offset: 0x7F80A04 VA: 0x7F84A04
	public static float ElasticEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84AA4 Offset: 0x7F80AA4 VA: 0x7F84AA4
	public static float ElasticEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84B48 Offset: 0x7F80B48 VA: 0x7F84B48
	public static float ElasticEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84C50 Offset: 0x7F80C50 VA: 0x7F84C50
	public static float ElasticEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84D80 Offset: 0x7F80D80 VA: 0x7F84D80
	public static float BounceEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84E48 Offset: 0x7F80E48 VA: 0x7F84E48
	public static float BounceEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84E78 Offset: 0x7F80E78 VA: 0x7F84E78
	public static float BounceEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84EF4 Offset: 0x7F80EF4 VA: 0x7F84EF4
	public static float BounceEaseOutIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84F48 Offset: 0x7F80F48 VA: 0x7F84F48
	public static float BackEaseOut(float t, float b, float c, float d) { }

	// RVA: 0x7F84F88 Offset: 0x7F80F88 VA: 0x7F84F88
	public static float BackEaseIn(float t, float b, float c, float d) { }

	// RVA: 0x7F84FB8 Offset: 0x7F80FB8 VA: 0x7F84FB8
	public static float BackEaseInOut(float t, float b, float c, float d) { }

	// RVA: 0x7F85038 Offset: 0x7F81038 VA: 0x7F85038
	public static float BackEaseOutIn(float t, float b, float c, float d) { }
}

// Namespace: 
public static class SRMath // TypeDefIndex: 23657
{
	// Methods

	// RVA: 0x7F83478 Offset: 0x7F7F478 VA: 0x7F83478
	public static float LerpUnclamped(float from, float to, float t) { }

	// RVA: 0x7F83490 Offset: 0x7F7F490 VA: 0x7F83490
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t) { }

	// RVA: 0x7F834C0 Offset: 0x7F7F4C0 VA: 0x7F834C0
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2) { }

	// RVA: 0x7F83678 Offset: 0x7F7F678 VA: 0x7F83678
	public static float WrapAngle(float angle) { }

	// RVA: 0x7F836B0 Offset: 0x7F7F6B0 VA: 0x7F836B0
	public static float NearestAngle(float to, float angle1, float angle2) { }

	// RVA: 0x7F83738 Offset: 0x7F7F738 VA: 0x7F83738
	public static int Wrap(int max, int value) { }

	// RVA: 0x7F837C4 Offset: 0x7F7F7C4 VA: 0x7F837C4
	public static float Wrap(float max, float value) { }

	// RVA: 0x7F837E8 Offset: 0x7F7F7E8 VA: 0x7F837E8
	public static float Average(float v1, float v2) { }

	// RVA: 0x7F837F8 Offset: 0x7F7F7F8 VA: 0x7F837F8
	public static float Angle(Vector2 direction) { }

	// RVA: 0x7F8397C Offset: 0x7F7F97C VA: 0x7F8397C
	public static float Ease(float from, float to, float t, SRMath.EaseType type) { }

	// RVA: 0x7F850C8 Offset: 0x7F810C8 VA: 0x7F850C8
	public static float SpringLerp(float strength, float deltaTime) { }

	// RVA: 0x7F851F8 Offset: 0x7F811F8 VA: 0x7F851F8
	public static float SpringLerp(float from, float to, float strength, float deltaTime) { }

	// RVA: 0x7F85240 Offset: 0x7F81240 VA: 0x7F85240
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) { }

	// RVA: 0x7F852C0 Offset: 0x7F812C0 VA: 0x7F852C0
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) { }

	// RVA: 0x7F85344 Offset: 0x7F81344 VA: 0x7F85344
	public static float SmoothClamp(float value, float min, float max, float scrollMax, SRMath.EaseType easeType = 5) { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 23658
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 23659
{
	// Methods

	// RVA: 0x7F85460 Offset: 0x7F81460 VA: 0x7F85460
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7F85558 Offset: 0x7F81558 VA: 0x7F85558
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRList.<GetEnumerator>d__15<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 23660
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public SRList<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28AAC Offset: 0x5D24AAC VA: 0x5D28AAC
	|-SRList.<GetEnumerator>d__15<int>..ctor
	|
	|-RVA: 0x5D28BD8 Offset: 0x5D24BD8 VA: 0x5D28BD8
	|-SRList.<GetEnumerator>d__15<object>..ctor
	|
	|-RVA: 0x5D28CF0 Offset: 0x5D24CF0 VA: 0x5D28CF0
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28AD4 Offset: 0x5D24AD4 VA: 0x5D28AD4
	|-SRList.<GetEnumerator>d__15<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D28C00 Offset: 0x5D24C00 VA: 0x5D28C00
	|-SRList.<GetEnumerator>d__15<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D28D30 Offset: 0x5D24D30 VA: 0x5D28D30
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28AD8 Offset: 0x5D24AD8 VA: 0x5D28AD8
	|-SRList.<GetEnumerator>d__15<int>.MoveNext
	|
	|-RVA: 0x5D28C04 Offset: 0x5D24C04 VA: 0x5D28C04
	|-SRList.<GetEnumerator>d__15<object>.MoveNext
	|
	|-RVA: 0x5D28D34 Offset: 0x5D24D34 VA: 0x5D28D34
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28B74 Offset: 0x5D24B74 VA: 0x5D28B74
	|-SRList.<GetEnumerator>d__15<int>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D28CAC Offset: 0x5D24CAC VA: 0x5D28CAC
	|-SRList.<GetEnumerator>d__15<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D28F9C Offset: 0x5D24F9C VA: 0x5D28F9C
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28B7C Offset: 0x5D24B7C VA: 0x5D28B7C
	|-SRList.<GetEnumerator>d__15<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D28CB4 Offset: 0x5D24CB4 VA: 0x5D28CB4
	|-SRList.<GetEnumerator>d__15<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D2903C Offset: 0x5D2503C VA: 0x5D2903C
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28BB0 Offset: 0x5D24BB0 VA: 0x5D28BB0
	|-SRList.<GetEnumerator>d__15<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D28CE8 Offset: 0x5D24CE8 VA: 0x5D28CE8
	|-SRList.<GetEnumerator>d__15<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D29070 Offset: 0x5D25070 VA: 0x5D29070
	|-SRList.<GetEnumerator>d__15<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: SRF
[DefaultMember("Item")]
[Serializable]
public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 23661
{
	// Fields
	[SerializeField]
	private T[] _buffer; // 0x0
	[SerializeField]
	private int _count; // 0x0
	private EqualityComparer<T> _equalityComparer; // 0x0
	private ReadOnlyCollection<T> _readOnlyWrapper; // 0x0

	// Properties
	public T[] Buffer { get; set; }
	private EqualityComparer<T> EqualityComparer { get; }
	public int Count { get; set; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D034C Offset: 0x54CC34C VA: 0x54D034C
	|-SRList<int>..ctor
	|
	|-RVA: 0x54D1240 Offset: 0x54CD240 VA: 0x54D1240
	|-SRList<object>..ctor
	|
	|-RVA: 0x54D2240 Offset: 0x54CE240 VA: 0x54D2240
	|-SRList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0354 Offset: 0x54CC354 VA: 0x54D0354
	|-SRList<int>..ctor
	|
	|-RVA: 0x54D1248 Offset: 0x54CD248 VA: 0x54D1248
	|-SRList<object>..ctor
	|
	|-RVA: 0x54D2248 Offset: 0x54CE248 VA: 0x54D2248
	|-SRList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D03A8 Offset: 0x54CC3A8 VA: 0x54D03A8
	|-SRList<int>..ctor
	|
	|-RVA: 0x54D129C Offset: 0x54CD29C VA: 0x54D129C
	|-SRList<object>..ctor
	|
	|-RVA: 0x54D22A8 Offset: 0x54CE2A8 VA: 0x54D22A8
	|-SRList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D03E4 Offset: 0x54CC3E4 VA: 0x54D03E4
	|-SRList<int>.get_Buffer
	|
	|-RVA: 0x54D12D8 Offset: 0x54CD2D8 VA: 0x54D12D8
	|-SRList<object>.get_Buffer
	|
	|-RVA: 0x54D22E8 Offset: 0x54CE2E8 VA: 0x54D22E8
	|-SRList<__Il2CppFullySharedGenericType>.get_Buffer
	*/

	// RVA: -1 Offset: -1
	private void set_Buffer(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D03EC Offset: 0x54CC3EC VA: 0x54D03EC
	|-SRList<int>.set_Buffer
	|
	|-RVA: 0x54D12E0 Offset: 0x54CD2E0 VA: 0x54D12E0
	|-SRList<object>.set_Buffer
	|
	|-RVA: 0x54D22F0 Offset: 0x54CE2F0 VA: 0x54D22F0
	|-SRList<__Il2CppFullySharedGenericType>.set_Buffer
	*/

	// RVA: -1 Offset: -1
	private EqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D03F4 Offset: 0x54CC3F4 VA: 0x54D03F4
	|-SRList<int>.get_EqualityComparer
	|
	|-RVA: 0x54D12E8 Offset: 0x54CD2E8 VA: 0x54D12E8
	|-SRList<object>.get_EqualityComparer
	|
	|-RVA: 0x54D22F8 Offset: 0x54CE2F8 VA: 0x54D22F8
	|-SRList<__Il2CppFullySharedGenericType>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0430 Offset: 0x54CC430 VA: 0x54D0430
	|-SRList<int>.get_Count
	|
	|-RVA: 0x54D1324 Offset: 0x54CD324 VA: 0x54D1324
	|-SRList<object>.get_Count
	|
	|-RVA: 0x54D2338 Offset: 0x54CE338 VA: 0x54D2338
	|-SRList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0438 Offset: 0x54CC438 VA: 0x54D0438
	|-SRList<int>.set_Count
	|
	|-RVA: 0x54D132C Offset: 0x54CD32C VA: 0x54D132C
	|-SRList<object>.set_Count
	|
	|-RVA: 0x54D2340 Offset: 0x54CE340 VA: 0x54D2340
	|-SRList<__Il2CppFullySharedGenericType>.set_Count
	*/

	[IteratorStateMachine(typeof(SRList.<GetEnumerator>d__15<T>))]
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0440 Offset: 0x54CC440 VA: 0x54D0440
	|-SRList<int>.GetEnumerator
	|
	|-RVA: 0x54D1334 Offset: 0x54CD334 VA: 0x54D1334
	|-SRList<object>.GetEnumerator
	|
	|-RVA: 0x54D2348 Offset: 0x54CE348 VA: 0x54D2348
	|-SRList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D04B8 Offset: 0x54CC4B8 VA: 0x54D04B8
	|-SRList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54D13AC Offset: 0x54CD3AC VA: 0x54D13AC
	|-SRList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54D23D4 Offset: 0x54CE3D4 VA: 0x54D23D4
	|-SRList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D04C8 Offset: 0x54CC4C8 VA: 0x54D04C8
	|-SRList<int>.Add
	|
	|-RVA: 0x54D13BC Offset: 0x54CD3BC VA: 0x54D13BC
	|-SRList<object>.Add
	|
	|-RVA: 0x54D23E8 Offset: 0x54CE3E8 VA: 0x54D23E8
	|-SRList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0548 Offset: 0x54CC548 VA: 0x54D0548
	|-SRList<int>.Clear
	|
	|-RVA: 0x54D1440 Offset: 0x54CD440 VA: 0x54D1440
	|-SRList<object>.Clear
	|
	|-RVA: 0x54D25D8 Offset: 0x54CE5D8 VA: 0x54D25D8
	|-SRList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0550 Offset: 0x54CC550 VA: 0x54D0550
	|-SRList<int>.Contains
	|
	|-RVA: 0x54D1448 Offset: 0x54CD448 VA: 0x54D1448
	|-SRList<object>.Contains
	|
	|-RVA: 0x54D25F0 Offset: 0x54CE5F0 VA: 0x54D25F0
	|-SRList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D05FC Offset: 0x54CC5FC VA: 0x54D05FC
	|-SRList<int>.CopyTo
	|
	|-RVA: 0x54D14F4 Offset: 0x54CD4F4 VA: 0x54D14F4
	|-SRList<object>.CopyTo
	|
	|-RVA: 0x54D27E0 Offset: 0x54CE7E0 VA: 0x54D27E0
	|-SRList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0644 Offset: 0x54CC644 VA: 0x54D0644
	|-SRList<int>.Remove
	|
	|-RVA: 0x54D153C Offset: 0x54CD53C VA: 0x54D153C
	|-SRList<object>.Remove
	|
	|-RVA: 0x54D284C Offset: 0x54CE84C VA: 0x54D284C
	|-SRList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D06A0 Offset: 0x54CC6A0 VA: 0x54D06A0
	|-SRList<int>.get_IsReadOnly
	|
	|-RVA: 0x54D1598 Offset: 0x54CD598 VA: 0x54D1598
	|-SRList<object>.get_IsReadOnly
	|
	|-RVA: 0x54D2970 Offset: 0x54CE970 VA: 0x54D2970
	|-SRList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D06A8 Offset: 0x54CC6A8 VA: 0x54D06A8
	|-SRList<int>.IndexOf
	|
	|-RVA: 0x54D15A0 Offset: 0x54CD5A0 VA: 0x54D15A0
	|-SRList<object>.IndexOf
	|
	|-RVA: 0x54D2978 Offset: 0x54CE978 VA: 0x54D2978
	|-SRList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0750 Offset: 0x54CC750 VA: 0x54D0750
	|-SRList<int>.Insert
	|
	|-RVA: 0x54D1648 Offset: 0x54CD648 VA: 0x54D1648
	|-SRList<object>.Insert
	|
	|-RVA: 0x54D2B68 Offset: 0x54CEB68 VA: 0x54D2B68
	|-SRList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0848 Offset: 0x54CC848 VA: 0x54D0848
	|-SRList<int>.RemoveAt
	|
	|-RVA: 0x54D1780 Offset: 0x54CD780 VA: 0x54D1780
	|-SRList<object>.RemoveAt
	|
	|-RVA: 0x54D2EF8 Offset: 0x54CEEF8 VA: 0x54D2EF8
	|-SRList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D08C4 Offset: 0x54CC8C4 VA: 0x54D08C4
	|-SRList<int>.get_Item
	|
	|-RVA: 0x54D1864 Offset: 0x54CD864 VA: 0x54D1864
	|-SRList<object>.get_Item
	|
	|-RVA: 0x54D31DC Offset: 0x54CF1DC VA: 0x54D31DC
	|-SRList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0924 Offset: 0x54CC924 VA: 0x54D0924
	|-SRList<int>.set_Item
	|
	|-RVA: 0x54D18C4 Offset: 0x54CD8C4 VA: 0x54D18C4
	|-SRList<object>.set_Item
	|
	|-RVA: 0x54D3304 Offset: 0x54CF304 VA: 0x54D3304
	|-SRList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0984 Offset: 0x54CC984 VA: 0x54D0984
	|-SRList<int>.OnBeforeSerialize
	|
	|-RVA: 0x54D1928 Offset: 0x54CD928 VA: 0x54D1928
	|-SRList<object>.OnBeforeSerialize
	|
	|-RVA: 0x54D348C Offset: 0x54CF48C VA: 0x54D348C
	|-SRList<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0ACC Offset: 0x54CCACC VA: 0x54D0ACC
	|-SRList<int>.OnAfterDeserialize
	|
	|-RVA: 0x54D1A70 Offset: 0x54CDA70 VA: 0x54D1A70
	|-SRList<object>.OnAfterDeserialize
	|
	|-RVA: 0x54D35D8 Offset: 0x54CF5D8 VA: 0x54D35D8
	|-SRList<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0BF4 Offset: 0x54CCBF4 VA: 0x54D0BF4
	|-SRList<int>.AddRange
	|
	|-RVA: 0x54D1B98 Offset: 0x54CDB98 VA: 0x54D1B98
	|-SRList<object>.AddRange
	|
	|-RVA: 0x54D3700 Offset: 0x54CF700 VA: 0x54D3700
	|-SRList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clean) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0EE4 Offset: 0x54CCEE4 VA: 0x54D0EE4
	|-SRList<int>.Clear
	|
	|-RVA: 0x54D1E88 Offset: 0x54CDE88 VA: 0x54D1E88
	|-SRList<object>.Clear
	|
	|-RVA: 0x54D3AC4 Offset: 0x54CFAC4 VA: 0x54D3AC4
	|-SRList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clean() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0F00 Offset: 0x54CCF00 VA: 0x54D0F00
	|-SRList<int>.Clean
	|
	|-RVA: 0x54D1EA4 Offset: 0x54CDEA4 VA: 0x54D1EA4
	|-SRList<object>.Clean
	|
	|-RVA: 0x54D3B1C Offset: 0x54CFB1C VA: 0x54D3B1C
	|-SRList<__Il2CppFullySharedGenericType>.Clean
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0F48 Offset: 0x54CCF48 VA: 0x54D0F48
	|-SRList<int>.AsReadOnly
	|
	|-RVA: 0x54D1F0C Offset: 0x54CDF0C VA: 0x54D1F0C
	|-SRList<object>.AsReadOnly
	|
	|-RVA: 0x54D3CA0 Offset: 0x54CFCA0 VA: 0x54D3CA0
	|-SRList<__Il2CppFullySharedGenericType>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	private void Expand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0FB8 Offset: 0x54CCFB8 VA: 0x54D0FB8
	|-SRList<int>.Expand
	|
	|-RVA: 0x54D1F7C Offset: 0x54CDF7C VA: 0x54D1F7C
	|-SRList<object>.Expand
	|
	|-RVA: 0x54D3D14 Offset: 0x54CFD14 VA: 0x54D3D14
	|-SRList<__Il2CppFullySharedGenericType>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D105C Offset: 0x54CD05C VA: 0x54D105C
	|-SRList<int>.Trim
	|
	|-RVA: 0x54D2020 Offset: 0x54CE020 VA: 0x54D2020
	|-SRList<object>.Trim
	|
	|-RVA: 0x54D3E3C Offset: 0x54CFE3C VA: 0x54D3E3C
	|-SRList<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D1150 Offset: 0x54CD150 VA: 0x54D1150
	|-SRList<int>.Sort
	|
	|-RVA: 0x54D212C Offset: 0x54CE12C VA: 0x54D212C
	|-SRList<object>.Sort
	|
	|-RVA: 0x54D40B8 Offset: 0x54D00B8 VA: 0x54D40B8
	|-SRList<__Il2CppFullySharedGenericType>.Sort
	*/
}

// Namespace: SRF
public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 23662
{
	// Fields
	private Collider _collider; // 0x20
	private Transform _transform; // 0x28
	private Rigidbody _rigidBody; // 0x30
	private GameObject _gameObject; // 0x38
	private Rigidbody2D _rigidbody2D; // 0x40
	private Collider2D _collider2D; // 0x48

	// Properties
	public Transform CachedTransform { get; }
	public Collider CachedCollider { get; }
	public Collider2D CachedCollider2D { get; }
	public Rigidbody CachedRigidBody { get; }
	public Rigidbody2D CachedRigidBody2D { get; }
	public GameObject CachedGameObject { get; }
	public Transform transform { get; }
	public Collider collider { get; }
	public Collider2D collider2D { get; }
	public Rigidbody rigidbody { get; }
	public Rigidbody2D rigidbody2D { get; }
	public GameObject gameObject { get; }

	// Methods

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F85560 Offset: 0x7F81560 VA: 0x7F85560
	public Transform get_CachedTransform() { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F855F4 Offset: 0x7F815F4 VA: 0x7F855F4
	public Collider get_CachedCollider() { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F8569C Offset: 0x7F8169C VA: 0x7F8569C
	public Collider2D get_CachedCollider2D() { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F85744 Offset: 0x7F81744 VA: 0x7F85744
	public Rigidbody get_CachedRigidBody() { }

	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	// RVA: 0x7F857EC Offset: 0x7F817EC VA: 0x7F857EC
	public Rigidbody2D get_CachedRigidBody2D() { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F85894 Offset: 0x7F81894 VA: 0x7F85894
	public GameObject get_CachedGameObject() { }

	// RVA: 0x7F85928 Offset: 0x7F81928 VA: 0x7F85928
	public Transform get_transform() { }

	// RVA: 0x7F8592C Offset: 0x7F8192C VA: 0x7F8592C
	public Collider get_collider() { }

	// RVA: 0x7F85930 Offset: 0x7F81930 VA: 0x7F85930
	public Collider2D get_collider2D() { }

	// RVA: 0x7F85934 Offset: 0x7F81934 VA: 0x7F85934
	public Rigidbody get_rigidbody() { }

	// RVA: 0x7F85938 Offset: 0x7F81938 VA: 0x7F85938
	public Rigidbody2D get_rigidbody2D() { }

	// RVA: 0x7F8593C Offset: 0x7F8193C VA: 0x7F8593C
	public GameObject get_gameObject() { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F85940 Offset: 0x7F81940 VA: 0x7F85940
	protected void AssertNotNull(object value, string fieldName) { }

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	// RVA: 0x7F85954 Offset: 0x7F81954 VA: 0x7F85954
	protected void Assert(bool condition, string message) { }

	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	// RVA: 0x7F8596C Offset: 0x7F8196C VA: 0x7F8596C
	protected void EditorAssertNotNull(object value, string fieldName) { }

	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	// RVA: 0x7F85980 Offset: 0x7F81980 VA: 0x7F85980
	protected void EditorAssert(bool condition, string message) { }

	// RVA: 0x7F85998 Offset: 0x7F81998 VA: 0x7F85998
	protected void .ctor() { }
}

// Namespace: SRF
[Usage(260)]
public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 23663
{
	// Fields
	private bool _autoCreate; // 0x10
	private bool _autoSearch; // 0x11
	private bool _editorOnly; // 0x12

	// Properties
	public bool AutoSearch { get; set; }
	public bool AutoCreate { get; set; }
	[Obsolete]
	public bool EditorOnly { get; set; }

	// Methods

	// RVA: 0x7F859A0 Offset: 0x7F819A0 VA: 0x7F859A0
	public void .ctor(bool autoSearch) { }

	// RVA: 0x7F859D4 Offset: 0x7F819D4 VA: 0x7F859D4
	public void .ctor() { }

	// RVA: 0x7F859E4 Offset: 0x7F819E4 VA: 0x7F859E4
	public bool get_AutoSearch() { }

	// RVA: 0x7F859EC Offset: 0x7F819EC VA: 0x7F859EC
	public void set_AutoSearch(bool value) { }

	// RVA: 0x7F859F8 Offset: 0x7F819F8 VA: 0x7F859F8
	public bool get_AutoCreate() { }

	// RVA: 0x7F85A00 Offset: 0x7F81A00 VA: 0x7F85A00
	public void set_AutoCreate(bool value) { }

	// RVA: 0x7F85A0C Offset: 0x7F81A0C VA: 0x7F85A0C
	public bool get_EditorOnly() { }

	// RVA: 0x7F85A14 Offset: 0x7F81A14 VA: 0x7F85A14
	public void set_EditorOnly(bool value) { }
}

// Namespace: SRF
[Usage(256)]
public class ImportAttribute : Attribute // TypeDefIndex: 23664
{
	// Fields
	public readonly Type Service; // 0x10

	// Methods

	// RVA: 0x7F85A20 Offset: 0x7F81A20 VA: 0x7F85A20
	public void .ctor() { }

	// RVA: 0x7F85A28 Offset: 0x7F81A28 VA: 0x7F85A28
	public void .ctor(Type serviceType) { }
}

// Namespace: 
private struct SRMonoBehaviourEx.FieldInfo // TypeDefIndex: 23665
{
	// Fields
	public bool AutoCreate; // 0x0
	public bool AutoSet; // 0x1
	public FieldInfo Field; // 0x8
	public bool Import; // 0x10
	public Type ImportType; // 0x18
}

// Namespace: SRF
public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 23666
{
	// Fields
	private static Dictionary<Type, IList<SRMonoBehaviourEx.FieldInfo>> _checkedFields; // 0x0

	// Methods

	// RVA: 0x7F85A58 Offset: 0x7F81A58 VA: 0x7F85A58
	private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = False) { }

	// RVA: 0x7F85E2C Offset: 0x7F81E2C VA: 0x7F85E2C
	private static void PopulateObject(IList<SRMonoBehaviourEx.FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet) { }

	// RVA: 0x7F85BC8 Offset: 0x7F81BC8 VA: 0x7F85BC8
	private static List<SRMonoBehaviourEx.FieldInfo> ScanType(Type t) { }

	// RVA: 0x7F86468 Offset: 0x7F82468 VA: 0x7F86468 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x7F86470 Offset: 0x7F82470 VA: 0x7F86470 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x7F86474 Offset: 0x7F82474 VA: 0x7F86474 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x7F86478 Offset: 0x7F82478 VA: 0x7F86478 Slot: 7
	protected virtual void FixedUpdate() { }

	// RVA: 0x7F8647C Offset: 0x7F8247C VA: 0x7F8647C Slot: 8
	protected virtual void OnEnable() { }

	// RVA: 0x7F86480 Offset: 0x7F82480 VA: 0x7F86480 Slot: 9
	protected virtual void OnDisable() { }

	// RVA: 0x7F86484 Offset: 0x7F82484 VA: 0x7F86484 Slot: 10
	protected virtual void OnDestroy() { }

	// RVA: 0x7F86488 Offset: 0x7F82488 VA: 0x7F86488
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Coroutines.<WaitForSecondsRealTime>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23667
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float time; // 0x20
	private float <endTime>5__2; // 0x24

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7F864F8 Offset: 0x7F824F8 VA: 0x7F864F8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F86520 Offset: 0x7F82520 VA: 0x7F86520 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F86524 Offset: 0x7F82524 VA: 0x7F86524 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F865A0 Offset: 0x7F825A0 VA: 0x7F865A0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F865A8 Offset: 0x7F825A8 VA: 0x7F865A8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F865E0 Offset: 0x7F825E0 VA: 0x7F865E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRF
public static class Coroutines // TypeDefIndex: 23668
{
	// Methods

	[IteratorStateMachine(typeof(Coroutines.<WaitForSecondsRealTime>d__0))]
	// RVA: 0x7F86490 Offset: 0x7F82490 VA: 0x7F86490
	public static IEnumerator WaitForSecondsRealTime(float time) { }
}

// Namespace: SRF
[Extension]
public static class SRFFloatExtensions // TypeDefIndex: 23669
{
	// Methods

	[Extension]
	// RVA: 0x7F865E8 Offset: 0x7F825E8 VA: 0x7F865E8
	public static float Sqr(float f) { }

	[Extension]
	// RVA: 0x7F865F0 Offset: 0x7F825F0 VA: 0x7F865F0
	public static float SqrRt(float f) { }

	[Extension]
	// RVA: 0x7F865F8 Offset: 0x7F825F8 VA: 0x7F865F8
	public static bool ApproxZero(float f) { }

	[Extension]
	// RVA: 0x7F8666C Offset: 0x7F8266C VA: 0x7F8666C
	public static bool Approx(float f, float f2) { }
}

// Namespace: SRF
[Extension]
public static class SRFGameObjectExtensions // TypeDefIndex: 23670
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetIComponent<T>(GameObject t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFC8C Offset: 0x46DBC8C VA: 0x46DFC8C
	|-SRFGameObjectExtensions.GetIComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetComponentOrAdd<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFBE4 Offset: 0x46DBBE4 VA: 0x46DFBE4
	|-SRFGameObjectExtensions.GetComponentOrAdd<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void RemoveComponentIfExists<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFD7C Offset: 0x46DBD7C VA: 0x46DFD7C
	|-SRFGameObjectExtensions.RemoveComponentIfExists<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void RemoveComponentsIfExists<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFE2C Offset: 0x46DBE2C VA: 0x46DFE2C
	|-SRFGameObjectExtensions.RemoveComponentsIfExists<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EnableComponentIfExists<T>(GameObject obj, bool enable = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFB34 Offset: 0x46DBB34 VA: 0x46DFB34
	|-SRFGameObjectExtensions.EnableComponentIfExists<object>
	*/

	[Extension]
	// RVA: 0x7F866F4 Offset: 0x7F826F4 VA: 0x7F866F4
	public static void SetLayerRecursive(GameObject o, int layer) { }

	// RVA: 0x7F86718 Offset: 0x7F82718 VA: 0x7F86718
	private static void SetLayerInternal(Transform t, int layer) { }
}

// Namespace: SRF
[Extension]
public static class SRFIListExtensions // TypeDefIndex: 23671
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T Random<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0780 Offset: 0x46DC780 VA: 0x46E0780
	|-SRFIListExtensions.Random<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T RandomOrDefault<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0AA0 Offset: 0x46DCAA0 VA: 0x46E0AA0
	|-SRFIListExtensions.RandomOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T PopLast<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46DFEF0 Offset: 0x46DBEF0 VA: 0x46DFEF0
	|-SRFIListExtensions.PopLast<int>
	|
	|-RVA: 0x46E01A0 Offset: 0x46DC1A0 VA: 0x46E01A0
	|-SRFIListExtensions.PopLast<object>
	|
	|-RVA: 0x46E0450 Offset: 0x46DC450 VA: 0x46E0450
	|-SRFIListExtensions.PopLast<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: SRF
[Extension]
public static class SRFStringExtensions // TypeDefIndex: 23672
{
	// Methods

	[Extension]
	// RVA: 0x7F83054 Offset: 0x7F7F054 VA: 0x7F83054
	public static string Fmt(string formatString, object[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRFTransformExtensions.<GetChildren>d__0 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable // TypeDefIndex: 23673
{
	// Fields
	private int <>1__state; // 0x10
	private Transform <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Transform t; // 0x28
	public Transform <>3__t; // 0x30
	private int <i>5__2; // 0x38

	// Properties
	private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7F86A7C Offset: 0x7F82A7C VA: 0x7F86A7C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F87044 Offset: 0x7F83044 VA: 0x7F87044 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F87048 Offset: 0x7F83048 VA: 0x7F87048 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F870E8 Offset: 0x7F830E8 VA: 0x7F870E8 Slot: 6
	private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F870F0 Offset: 0x7F830F0 VA: 0x7F870F0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F87128 Offset: 0x7F83128 VA: 0x7F87128 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F87130 Offset: 0x7F83130 VA: 0x7F87130 Slot: 4
	private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7F871D4 Offset: 0x7F831D4 VA: 0x7F871D4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: SRF
[Extension]
public static class SRFTransformExtensions // TypeDefIndex: 23674
{
	// Methods

	[Extension]
	[IteratorStateMachine(typeof(SRFTransformExtensions.<GetChildren>d__0))]
	// RVA: 0x7F86A00 Offset: 0x7F82A00 VA: 0x7F86A00
	public static IEnumerable<Transform> GetChildren(Transform t) { }

	[Extension]
	// RVA: 0x7F86AB0 Offset: 0x7F82AB0 VA: 0x7F86AB0
	public static void ResetLocal(Transform t) { }

	[Extension]
	// RVA: 0x7F86B90 Offset: 0x7F82B90 VA: 0x7F86B90
	public static GameObject CreateChild(Transform t, string name) { }

	[Extension]
	// RVA: 0x7F86C6C Offset: 0x7F82C6C VA: 0x7F86C6C
	public static void SetParentMaintainLocals(Transform t, Transform parent) { }

	[Extension]
	// RVA: 0x7F86C84 Offset: 0x7F82C84 VA: 0x7F86C84
	public static void SetLocals(Transform t, Transform from) { }

	[Extension]
	// RVA: 0x7F86CF0 Offset: 0x7F82CF0 VA: 0x7F86CF0
	public static void Match(Transform t, Transform from) { }

	[Extension]
	// RVA: 0x7F86D44 Offset: 0x7F82D44 VA: 0x7F86D44
	public static void DestroyChildren(Transform t) { }
}

// Namespace: 
private enum Json.Parser.TOKEN // TypeDefIndex: 23675
{
	// Fields
	public int value__; // 0x0
	public const Json.Parser.TOKEN NONE = 0;
	public const Json.Parser.TOKEN CURLY_OPEN = 1;
	public const Json.Parser.TOKEN CURLY_CLOSE = 2;
	public const Json.Parser.TOKEN SQUARED_OPEN = 3;
	public const Json.Parser.TOKEN SQUARED_CLOSE = 4;
	public const Json.Parser.TOKEN COLON = 5;
	public const Json.Parser.TOKEN COMMA = 6;
	public const Json.Parser.TOKEN STRING = 7;
	public const Json.Parser.TOKEN NUMBER = 8;
	public const Json.Parser.TOKEN TRUE = 9;
	public const Json.Parser.TOKEN FALSE = 10;
	public const Json.Parser.TOKEN NULL = 11;
}

// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 23676
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x7F87404 Offset: 0x7F83404 VA: 0x7F87404
	private void .ctor(string jsonString) { }

	// RVA: 0x7F87480 Offset: 0x7F83480 VA: 0x7F87480
	private char get_PeekChar() { }

	// RVA: 0x7F874F8 Offset: 0x7F834F8 VA: 0x7F874F8
	private char get_NextChar() { }

	// RVA: 0x7F87570 Offset: 0x7F83570 VA: 0x7F87570
	private string get_NextWord() { }

	// RVA: 0x7F876C0 Offset: 0x7F836C0 VA: 0x7F876C0
	private Json.Parser.TOKEN get_NextToken() { }

	// RVA: 0x7F87928 Offset: 0x7F83928 VA: 0x7F87928 Slot: 4
	public void Dispose() { }

	// RVA: 0x7F87624 Offset: 0x7F83624 VA: 0x7F87624
	public static bool IsWordBreak(char c) { }

	// RVA: 0x7F871E4 Offset: 0x7F831E4 VA: 0x7F871E4
	public static object Parse(string jsonString) { }

	// RVA: 0x7F87974 Offset: 0x7F83974 VA: 0x7F87974
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x7F87D18 Offset: 0x7F83D18 VA: 0x7F87D18
	private List<object> ParseArray() { }

	// RVA: 0x7F87958 Offset: 0x7F83958 VA: 0x7F87958
	private object ParseValue() { }

	// RVA: 0x7F87E44 Offset: 0x7F83E44 VA: 0x7F87E44
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x7F87A98 Offset: 0x7F83A98 VA: 0x7F87A98
	private string ParseString() { }

	// RVA: 0x7F87F34 Offset: 0x7F83F34 VA: 0x7F87F34
	private object ParseNumber() { }

	// RVA: 0x7F87884 Offset: 0x7F83884 VA: 0x7F87884
	private void EatWhitespace() { }
}

// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 23677
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x7F88004 Offset: 0x7F84004 VA: 0x7F88004
	private void .ctor() { }

	// RVA: 0x7F87390 Offset: 0x7F83390 VA: 0x7F87390
	public static string Serialize(object obj) { }

	// RVA: 0x7F88070 Offset: 0x7F84070 VA: 0x7F88070
	private void SerializeValue(object value) { }

	// RVA: 0x7F8885C Offset: 0x7F8485C VA: 0x7F8885C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x7F884FC Offset: 0x7F844FC VA: 0x7F884FC
	private void SerializeArray(IList anArray) { }

	// RVA: 0x7F88240 Offset: 0x7F84240 VA: 0x7F88240
	private void SerializeString(string str) { }

	// RVA: 0x7F88CE8 Offset: 0x7F84CE8 VA: 0x7F88CE8
	private void SerializeOther(object value) { }
}

// Namespace: SRF
public static class Json // TypeDefIndex: 23678
{
	// Methods

	// RVA: 0x7F871D8 Offset: 0x7F831D8 VA: 0x7F871D8
	public static object Deserialize(string json) { }

	// RVA: 0x7F8738C Offset: 0x7F8338C VA: 0x7F8738C
	public static string Serialize(object obj) { }
}

// Namespace: SRF
[DefaultMember("Item")]
public class Hierarchy // TypeDefIndex: 23679
{
	// Fields
	private static readonly char[] Seperator; // 0x0
	private static readonly Dictionary<string, Transform> Cache; // 0x8

	// Properties
	[Obsolete("Use static Get() instead")]
	public Transform Item { get; }

	// Methods

	// RVA: 0x7F88F6C Offset: 0x7F84F6C VA: 0x7F88F6C
	public Transform get_Item(string key) { }

	// RVA: 0x7F88FC0 Offset: 0x7F84FC0 VA: 0x7F88FC0
	public static Transform Get(string key) { }

	// RVA: 0x7F89240 Offset: 0x7F85240 VA: 0x7F89240
	public void .ctor() { }

	// RVA: 0x7F89248 Offset: 0x7F85248 VA: 0x7F89248
	private static void .cctor() { }
}

// Namespace: SRF.Service
[Usage(4)]
public sealed class ServiceAttribute : Attribute // TypeDefIndex: 23680
{
	// Fields
	[CompilerGenerated]
	private Type <ServiceType>k__BackingField; // 0x10

	// Properties
	public Type ServiceType { get; set; }

	// Methods

	// RVA: 0x7F89328 Offset: 0x7F85328 VA: 0x7F89328
	public void .ctor(Type serviceType) { }

	[CompilerGenerated]
	// RVA: 0x7F89358 Offset: 0x7F85358 VA: 0x7F89358
	public Type get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x7F89360 Offset: 0x7F85360 VA: 0x7F89360
	private void set_ServiceType(Type value) { }
}

// Namespace: SRF.Service
[Usage(64)]
public sealed class ServiceSelectorAttribute : Attribute // TypeDefIndex: 23681
{
	// Fields
	[CompilerGenerated]
	private Type <ServiceType>k__BackingField; // 0x10

	// Properties
	public Type ServiceType { get; set; }

	// Methods

	// RVA: 0x7F89368 Offset: 0x7F85368 VA: 0x7F89368
	public void .ctor(Type serviceType) { }

	[CompilerGenerated]
	// RVA: 0x7F89398 Offset: 0x7F85398 VA: 0x7F89398
	public Type get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x7F893A0 Offset: 0x7F853A0 VA: 0x7F893A0
	private void set_ServiceType(Type value) { }
}

// Namespace: SRF.Service
[Usage(64)]
public sealed class ServiceConstructorAttribute : Attribute // TypeDefIndex: 23682
{
	// Fields
	[CompilerGenerated]
	private Type <ServiceType>k__BackingField; // 0x10

	// Properties
	public Type ServiceType { get; set; }

	// Methods

	// RVA: 0x7F893A8 Offset: 0x7F853A8 VA: 0x7F893A8
	public void .ctor(Type serviceType) { }

	[CompilerGenerated]
	// RVA: 0x7F893D8 Offset: 0x7F853D8 VA: 0x7F893D8
	public Type get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x7F893E0 Offset: 0x7F853E0 VA: 0x7F893E0
	private void set_ServiceType(Type value) { }
}

// Namespace: SRF.Service
public interface IAsyncService // TypeDefIndex: 23683
{
	// Properties
	public abstract bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsLoaded();
}

// Namespace: 
[CompilerGenerated]
private sealed class SRDependencyServiceBase.<LoadDependencies>d__8<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23684
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public SRDependencyServiceBase<T> <>4__this; // 0x0
	private Type[] <>7__wrap1; // 0x0
	private int <>7__wrap2; // 0x0
	private IAsyncService <a>5__4; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38960 Offset: 0x5D34960 VA: 0x5D38960
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38988 Offset: 0x5D34988 VA: 0x5D38988
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3898C Offset: 0x5D3498C VA: 0x5D3898C
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38CE8 Offset: 0x5D34CE8 VA: 0x5D38CE8
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38CF0 Offset: 0x5D34CF0 VA: 0x5D38CF0
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38D24 Offset: 0x5D34D24 VA: 0x5D38D24
	|-SRDependencyServiceBase.<LoadDependencies>d__8<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: SRF.Service
public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 23685
{
	// Fields
	private bool _isLoaded; // 0x0

	// Properties
	protected abstract Type[] Dependencies { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract Type[] get_Dependencies();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRDependencyServiceBase<object>.get_Dependencies
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D020C Offset: 0x54CC20C VA: 0x54D020C
	|-SRDependencyServiceBase<object>.get_IsLoaded
	*/

	[Conditional("ENABLE_LOGGING")]
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0214 Offset: 0x54CC214 VA: 0x54D0214
	|-SRDependencyServiceBase<object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D027C Offset: 0x54CC27C VA: 0x54D027C
	|-SRDependencyServiceBase<object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D02C8 Offset: 0x54CC2C8 VA: 0x54D02C8
	|-SRDependencyServiceBase<object>.OnLoaded
	*/

	[IteratorStateMachine(typeof(SRDependencyServiceBase.<LoadDependencies>d__8<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator LoadDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D02CC Offset: 0x54CC2CC VA: 0x54D02CC
	|-SRDependencyServiceBase<object>.LoadDependencies
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0344 Offset: 0x54CC344 VA: 0x54D0344
	|-SRDependencyServiceBase<object>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23686
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public SRSceneServiceBase<T, TImpl> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38420 Offset: 0x5D34420 VA: 0x5D38420
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38448 Offset: 0x5D34448 VA: 0x5D38448
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3844C Offset: 0x5D3444C VA: 0x5D3844C
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3891C Offset: 0x5D3491C VA: 0x5D3891C
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38924 Offset: 0x5D34924 VA: 0x5D38924
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D38958 Offset: 0x5D34958 VA: 0x5D38958
	|-SRSceneServiceBase.<LoadCoroutine>d__11<object, object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: SRF.Service
public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 23687
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D448C Offset: 0x54D048C VA: 0x54D448C
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4494 Offset: 0x54D0494 VA: 0x54D4494
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[Conditional("ENABLE_LOGGING")]
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D44F4 Offset: 0x54D04F4 VA: 0x54D44F4
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D455C Offset: 0x54D055C VA: 0x54D455C
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D45A8 Offset: 0x54D05A8 VA: 0x54D45A8
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4648 Offset: 0x54D0648 VA: 0x54D4648
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachine(typeof(SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl>))]
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D464C Offset: 0x54D064C VA: 0x54D464C
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D46C4 Offset: 0x54D06C4 VA: 0x54D46C4
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

// Namespace: SRF.Service
public abstract class SRServiceBase<T> : SRMonoBehaviourEx // TypeDefIndex: 23688
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D46CC Offset: 0x54D06CC VA: 0x54D46CC
	|-SRServiceBase<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4708 Offset: 0x54D0708 VA: 0x54D4708
	|-SRServiceBase<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4734 Offset: 0x54D0734 VA: 0x54D4734
	|-SRServiceBase<object>..ctor
	*/
}

// Namespace: 
[Serializable]
private class SRServiceManager.Service // TypeDefIndex: 23689
{
	// Fields
	public object Object; // 0x10
	public Type Type; // 0x18

	// Methods

	// RVA: 0x7F89D1C Offset: 0x7F85D1C VA: 0x7F89D1C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class SRServiceManager.ServiceStub // TypeDefIndex: 23690
{
	// Fields
	public Func<object> Constructor; // 0x10
	public Type InterfaceType; // 0x18
	public Func<Type> Selector; // 0x20
	public Type Type; // 0x28

	// Methods

	// RVA: 0x7F8B09C Offset: 0x7F8709C VA: 0x7F8B09C Slot: 3
	public override string ToString() { }

	// RVA: 0x7F8A4D4 Offset: 0x7F864D4 VA: 0x7F8A4D4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SRServiceManager.<>c // TypeDefIndex: 23691
{
	// Fields
	public static readonly SRServiceManager.<>c <>9; // 0x0
	public static Func<SRServiceManager.ServiceStub, string> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x7F8B208 Offset: 0x7F87208 VA: 0x7F8B208
	private static void .cctor() { }

	// RVA: 0x7F8B270 Offset: 0x7F87270 VA: 0x7F8B270
	public void .ctor() { }

	// RVA: 0x7F8B278 Offset: 0x7F87278 VA: 0x7F8B278
	internal string <UpdateStubs>b__19_0(SRServiceManager.ServiceStub p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRServiceManager.<>c__DisplayClass24_0 // TypeDefIndex: 23692
{
	// Fields
	public ServiceSelectorAttribute attrib; // 0x10

	// Methods

	// RVA: 0x7F8AFF0 Offset: 0x7F86FF0 VA: 0x7F8AFF0
	public void .ctor() { }

	// RVA: 0x7F8B330 Offset: 0x7F87330 VA: 0x7F8B330
	internal bool <ScanTypeForSelectors>b__0(SRServiceManager.ServiceStub p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRServiceManager.<>c__DisplayClass25_0 // TypeDefIndex: 23693
{
	// Fields
	public ServiceConstructorAttribute attrib; // 0x10
	public MethodInfo m; // 0x18

	// Methods

	// RVA: 0x7F8AFF8 Offset: 0x7F86FF8 VA: 0x7F8AFF8
	public void .ctor() { }

	// RVA: 0x7F8B3A8 Offset: 0x7F873A8 VA: 0x7F8B3A8
	internal bool <ScanTypeForConstructors>b__0(SRServiceManager.ServiceStub p) { }

	// RVA: 0x7F8B420 Offset: 0x7F87420 VA: 0x7F8B420
	internal object <ScanTypeForConstructors>b__1() { }
}

// Namespace: SRF.Service
[AddComponentMenu("SRF/Service/Service Manager")]
public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 23694
{
	// Fields
	public const bool EnableLogging = False;
	public static int LoadingCount; // 0x0
	private readonly SRList<SRServiceManager.Service> _services; // 0x50
	private List<SRServiceManager.ServiceStub> _serviceStubs; // 0x58
	private static bool _hasQuit; // 0x4

	// Properties
	public static bool IsLoading { get; }

	// Methods

	// RVA: 0x7F893E8 Offset: 0x7F853E8 VA: 0x7F893E8
	public static bool get_IsLoading() { }

	// RVA: -1 Offset: -1
	public static T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0E28 Offset: 0x46DCE28 VA: 0x46E0E28
	|-SRServiceManager.GetService<object>
	*/

	// RVA: 0x7F862B0 Offset: 0x7F822B0 VA: 0x7F862B0
	public static object GetService(Type t) { }

	// RVA: 0x7F89438 Offset: 0x7F85438 VA: 0x7F89438
	private static object GetServiceInternal(Type t) { }

	// RVA: -1 Offset: -1
	public static bool HasService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E10A0 Offset: 0x46DD0A0 VA: 0x46E10A0
	|-SRServiceManager.HasService<object>
	*/

	// RVA: 0x7F8996C Offset: 0x7F8596C VA: 0x7F8996C
	public static bool HasService(Type t) { }

	// RVA: -1 Offset: -1
	public static void RegisterService<T>(object service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E1104 Offset: 0x46DD104 VA: 0x46E1104
	|-SRServiceManager.RegisterService<object>
	*/

	// RVA: 0x7F89AAC Offset: 0x7F85AAC VA: 0x7F89AAC
	private static void RegisterService(Type t, object service) { }

	// RVA: -1 Offset: -1
	public static void UnRegisterService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E1178 Offset: 0x46DD178 VA: 0x46E1178
	|-SRServiceManager.UnRegisterService<object>
	*/

	// RVA: 0x7F895B4 Offset: 0x7F855B4 VA: 0x7F895B4
	private static void UnRegisterService(Type t) { }

	// RVA: 0x7F89D24 Offset: 0x7F85D24 VA: 0x7F89D24 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F89DF0 Offset: 0x7F85DF0 VA: 0x7F89DF0
	protected void UpdateStubs() { }

	// RVA: 0x7F89718 Offset: 0x7F85718 VA: 0x7F89718
	protected object AutoCreateService(Type t) { }

	// RVA: 0x7F8A488 Offset: 0x7F86488 VA: 0x7F8A488
	protected void OnApplicationQuit() { }

	// RVA: 0x7F8A2E4 Offset: 0x7F862E4 VA: 0x7F8A2E4
	private static object DefaultServiceConstructor(Type serviceIntType, Type implType) { }

	// RVA: 0x7F8A1A8 Offset: 0x7F861A8 VA: 0x7F8A1A8
	private void ScanType(Type type) { }

	// RVA: 0x7F8AA40 Offset: 0x7F86A40 VA: 0x7F8AA40
	private static void ScanTypeForSelectors(Type t, List<SRServiceManager.ServiceStub> stubs) { }

	// RVA: 0x7F8A4DC Offset: 0x7F864DC VA: 0x7F8A4DC
	private static void ScanTypeForConstructors(Type t, List<SRServiceManager.ServiceStub> stubs) { }

	// RVA: 0x7F8AFCC Offset: 0x7F86FCC VA: 0x7F8AFCC
	private static MethodInfo[] GetStaticMethods(Type t) { }

	// RVA: 0x7F8B000 Offset: 0x7F87000 VA: 0x7F8B000
	public void .ctor() { }
}

// Namespace: SRF.Internal
internal static class ComponentMenuPaths // TypeDefIndex: 23695
{
	// Fields
	public const string PathRoot = "SRF";
	public const string SRServiceManager = "SRF/Service/Service Manager";
	public const string BehavioursRoot = "SRF/Behaviours";
	public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable";
	public const string DontDestroyOnLoad = "SRF/Behaviours/Don\'t Destroy On Load";
	public const string MatchTransform = "SRF/Behaviours/Match Transform";
	public const string LookAt = "SRF/Behaviours/LookAt";
	public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction";
	public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)";
	public const string RuntimePosition = "SRF/Behaviours/Runtime Position";
	public const string ScrollTexture = "SRF/Behaviours/Scroll Texture";
	public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float";
	public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)";
	public const string SpringFollow = "SRF/Behaviours/Spring Follow";
	public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)";
	public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab";
	public const string Velocity = "SRF/Behaviours/Velocity";
	public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate";
	public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera";
	public const string ComponentsRoot = "SRF/Components";
	public const string SRLineRenderer = "SRF/Components/SRLineRenderer";
	public const string SelectionRoot = "SRF/Components/Selection Root";
	public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)";
	public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)";
	public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)";
	public const string UIRoot = "SRF/UI";
	public const string TiltOnTouch = "SRF/UI/Tilt On Touch";
	public const string ScaleOnTouch = "SRF/UI/Scale On Touch";
	public const string InheritColour = "SRF/UI/Inherit Colour";
	public const string FlashGraphic = "SRF/UI/Flash Graphic";
	public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size";
	public const string CopyLayoutElement = "SRF/UI/Copy Layout Element";
	public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element";
	public const string SRText = "SRF/UI/SRText";
	public const string Unselectable = "SRF/UI/Unselectable";
	public const string LongPressButton = "SRF/UI/Long Press Button";
	public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour";
	public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group";
	public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)";
	public const string StyleRoot = "SRF/UI/Style Root";
	public const string StyleComponent = "SRF/UI/Style Component";
	public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)";
	public const string ResponsiveResize = "SRF/UI/Responsive (Resize)";
	public const string RetinaScaler = "SRF/UI/Retina Scaler";
	public const string NumberButton = "SRF/UI/SRNumberButton";
	public const string NumberSpinner = "SRF/UI/SRNumberSpinner";
	public const string SRSpinner = "SRF/UI/Spinner";
	public const string ContentFitText = "SRF/UI/Content Fit Text";
}

// Namespace: SRF.Helpers
public static class AssetUtil // TypeDefIndex: 23696
{}

// Namespace: SRF.Helpers
public class MethodReference // TypeDefIndex: 23697
{
	// Fields
	private MethodInfo _method; // 0x10
	private object _target; // 0x18

	// Properties
	public string MethodName { get; }

	// Methods

	// RVA: 0x7F8B444 Offset: 0x7F87444 VA: 0x7F8B444
	public void .ctor(object target, MethodInfo method) { }

	// RVA: 0x7F8B498 Offset: 0x7F87498 VA: 0x7F8B498
	public string get_MethodName() { }

	// RVA: 0x7F8B4BC Offset: 0x7F874BC VA: 0x7F8B4BC
	public object Invoke(object[] parameters) { }
}

// Namespace: SRF.Helpers
public class PropertyReference // TypeDefIndex: 23698
{
	// Fields
	private readonly PropertyInfo _property; // 0x10
	private readonly object _target; // 0x18

	// Properties
	public string PropertyName { get; }
	public Type PropertyType { get; }
	public bool CanRead { get; }
	public bool CanWrite { get; }

	// Methods

	// RVA: 0x7F8B4E4 Offset: 0x7F874E4 VA: 0x7F8B4E4
	public void .ctor(object target, PropertyInfo property) { }

	// RVA: 0x7F8B538 Offset: 0x7F87538 VA: 0x7F8B538
	public string get_PropertyName() { }

	// RVA: 0x7F8B55C Offset: 0x7F8755C VA: 0x7F8B55C
	public Type get_PropertyType() { }

	// RVA: 0x7F8B580 Offset: 0x7F87580 VA: 0x7F8B580
	public bool get_CanRead() { }

	// RVA: 0x7F8B5A8 Offset: 0x7F875A8 VA: 0x7F8B5A8
	public bool get_CanWrite() { }

	// RVA: 0x7F8B5D0 Offset: 0x7F875D0 VA: 0x7F8B5D0
	public object GetValue() { }

	// RVA: 0x7F8B644 Offset: 0x7F87644 VA: 0x7F8B644
	public void SetValue(object value) { }

	// RVA: -1 Offset: -1
	public T GetAttribute<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46AB458 Offset: 0x46A7458 VA: 0x46AB458
	|-PropertyReference.GetAttribute<object>
	*/
}

// Namespace: SRF.Helpers
public static class SRReflection // TypeDefIndex: 23699
{
	// Methods

	// RVA: 0x7F8B6D0 Offset: 0x7F876D0 VA: 0x7F8B6D0
	public static void SetPropertyValue(object obj, PropertyInfo p, object value) { }

	// RVA: 0x7F8B610 Offset: 0x7F87610 VA: 0x7F8B610
	public static object GetPropertyValue(object obj, PropertyInfo p) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(MemberInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E0D40 Offset: 0x46DCD40 VA: 0x46E0D40
	|-SRReflection.GetAttribute<object>
	*/
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/Content Fit Text")]
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 23700
{
	// Fields
	public SRText CopySource; // 0x20
	public Vector2 Padding; // 0x28

	// Properties
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x7F8B7A4 Offset: 0x7F877A4 VA: 0x7F8B7A4 Slot: 19
	public float get_minWidth() { }

	// RVA: 0x7F8B834 Offset: 0x7F87834 VA: 0x7F8B834 Slot: 20
	public float get_preferredWidth() { }

	// RVA: 0x7F8B8C4 Offset: 0x7F878C4 VA: 0x7F8B8C4 Slot: 21
	public float get_flexibleWidth() { }

	// RVA: 0x7F8B954 Offset: 0x7F87954 VA: 0x7F8B954 Slot: 22
	public float get_minHeight() { }

	// RVA: 0x7F8B9E4 Offset: 0x7F879E4 VA: 0x7F8B9E4 Slot: 23
	public float get_preferredHeight() { }

	// RVA: 0x7F8BA74 Offset: 0x7F87A74 VA: 0x7F8BA74 Slot: 24
	public float get_flexibleHeight() { }

	// RVA: 0x7F8BB04 Offset: 0x7F87B04 VA: 0x7F8BB04 Slot: 25
	public int get_layoutPriority() { }

	// RVA: 0x7F8BB0C Offset: 0x7F87B0C VA: 0x7F8BB0C Slot: 17
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x7F8BB30 Offset: 0x7F87B30 VA: 0x7F8BB30 Slot: 18
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x7F8BB54 Offset: 0x7F87B54 VA: 0x7F8BB54 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x7F8BD58 Offset: 0x7F87D58 VA: 0x7F8BD58
	private void CopySourceOnLayoutDirty(SRText srText) { }

	// RVA: 0x7F8BD5C Offset: 0x7F87D5C VA: 0x7F8BD5C Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x7F8BD60 Offset: 0x7F87D60 VA: 0x7F8BD60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7F8BEA8 Offset: 0x7F87EA8 VA: 0x7F8BEA8 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x7F8BEAC Offset: 0x7F87EAC VA: 0x7F8BEAC Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x7F8BBE8 Offset: 0x7F87BE8 VA: 0x7F8BBE8
	protected void SetDirty() { }

	// RVA: 0x7F8BEB0 Offset: 0x7F87EB0 VA: 0x7F8BEB0
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/Copy Layout Element")]
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 23701
{
	// Fields
	public bool CopyMinHeight; // 0x20
	public bool CopyMinWidth; // 0x21
	public bool CopyPreferredHeight; // 0x22
	public bool CopyPreferredWidth; // 0x23
	public RectTransform CopySource; // 0x28
	public float PaddingMinHeight; // 0x30
	public float PaddingMinWidth; // 0x34
	public float PaddingPreferredHeight; // 0x38
	public float PaddingPreferredWidth; // 0x3C

	// Properties
	public float preferredWidth { get; }
	public float preferredHeight { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public int layoutPriority { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }

	// Methods

	// RVA: 0x7F8BEB8 Offset: 0x7F87EB8 VA: 0x7F8BEB8 Slot: 20
	public float get_preferredWidth() { }

	// RVA: 0x7F8BF60 Offset: 0x7F87F60 VA: 0x7F8BF60 Slot: 23
	public float get_preferredHeight() { }

	// RVA: 0x7F8C008 Offset: 0x7F88008 VA: 0x7F8C008 Slot: 19
	public float get_minWidth() { }

	// RVA: 0x7F8C0B0 Offset: 0x7F880B0 VA: 0x7F8C0B0 Slot: 22
	public float get_minHeight() { }

	// RVA: 0x7F8C158 Offset: 0x7F88158 VA: 0x7F8C158 Slot: 25
	public int get_layoutPriority() { }

	// RVA: 0x7F8C160 Offset: 0x7F88160 VA: 0x7F8C160 Slot: 24
	public float get_flexibleHeight() { }

	// RVA: 0x7F8C168 Offset: 0x7F88168 VA: 0x7F8C168 Slot: 21
	public float get_flexibleWidth() { }

	// RVA: 0x7F8C170 Offset: 0x7F88170 VA: 0x7F8C170 Slot: 17
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x7F8C174 Offset: 0x7F88174 VA: 0x7F8C174 Slot: 18
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x7F8C178 Offset: 0x7F88178 VA: 0x7F8C178
	public void .ctor() { }
}

// Namespace: SRF.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Copy Preferred Size")]
public class CopyPreferredSize : LayoutElement // TypeDefIndex: 23702
{
	// Fields
	public RectTransform CopySource; // 0x40
	public float PaddingHeight; // 0x48
	public float PaddingWidth; // 0x4C

	// Properties
	public override float preferredWidth { get; }
	public override float preferredHeight { get; }
	public override int layoutPriority { get; }

	// Methods

	// RVA: 0x7F8C180 Offset: 0x7F88180 VA: 0x7F8C180 Slot: 35
	public override float get_preferredWidth() { }

	// RVA: 0x7F8C220 Offset: 0x7F88220 VA: 0x7F8C220 Slot: 37
	public override float get_preferredHeight() { }

	// RVA: 0x7F8C2C0 Offset: 0x7F882C0 VA: 0x7F8C2C0 Slot: 43
	public override int get_layoutPriority() { }

	// RVA: 0x7F8C2C8 Offset: 0x7F882C8 VA: 0x7F8C2C8
	public void .ctor() { }
}

// Namespace: SRF.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Copy Size Into Layout Element")]
public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 23703
{
	// Fields
	public RectTransform CopySource; // 0x40
	public float PaddingHeight; // 0x48
	public float PaddingWidth; // 0x4C
	public bool SetPreferredSize; // 0x50
	public bool SetMinimumSize; // 0x51

	// Properties
	public override float preferredWidth { get; }
	public override float preferredHeight { get; }
	public override float minWidth { get; }
	public override float minHeight { get; }
	public override int layoutPriority { get; }

	// Methods

	// RVA: 0x7F8C2D0 Offset: 0x7F882D0 VA: 0x7F8C2D0 Slot: 35
	public override float get_preferredWidth() { }

	// RVA: 0x7F8C380 Offset: 0x7F88380 VA: 0x7F8C380 Slot: 37
	public override float get_preferredHeight() { }

	// RVA: 0x7F8C430 Offset: 0x7F88430 VA: 0x7F8C430 Slot: 31
	public override float get_minWidth() { }

	// RVA: 0x7F8C4E0 Offset: 0x7F884E0 VA: 0x7F8C4E0 Slot: 33
	public override float get_minHeight() { }

	// RVA: 0x7F8C590 Offset: 0x7F88590 VA: 0x7F8C590 Slot: 43
	public override int get_layoutPriority() { }

	// RVA: 0x7F8C598 Offset: 0x7F88598 VA: 0x7F8C598
	public void .ctor() { }
}

// Namespace: SRF.UI
public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 23704
{
	// Fields
	private CanvasScaler _canvasScaler; // 0x20
	private float _delta; // 0x28
	private float _startValue; // 0x2C
	public RectTransform.Axis Axis; // 0x30
	public bool Invert; // 0x34
	public float MaxSize; // 0x38
	public LayoutElement TargetLayoutElement; // 0x40
	public RectTransform TargetRectTransform; // 0x48

	// Properties
	private float Mult { get; }

	// Methods

	// RVA: 0x7F8C5A0 Offset: 0x7F885A0 VA: 0x7F8C5A0
	private float get_Mult() { }

	// RVA: 0x7F8C5B8 Offset: 0x7F885B8 VA: 0x7F8C5B8 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7F8C7F0 Offset: 0x7F887F0 VA: 0x7F8C7F0 Slot: 6
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7F8CB00 Offset: 0x7F88B00 VA: 0x7F8CB00 Slot: 5
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7F8CC44 Offset: 0x7F88C44 VA: 0x7F8CC44
	private void Start() { }

	// RVA: 0x7F8C5E0 Offset: 0x7F885E0 VA: 0x7F8C5E0
	private bool Verify() { }

	// RVA: 0x7F8C6D0 Offset: 0x7F886D0 VA: 0x7F8C6D0
	private float GetCurrentValue() { }

	// RVA: 0x7F8C9C4 Offset: 0x7F889C4 VA: 0x7F8C9C4
	private void SetCurrentValue(float value) { }

	// RVA: 0x7F8CB54 Offset: 0x7F88B54 VA: 0x7F8CB54
	private void CommitCurrentValue() { }

	// RVA: 0x7F8C908 Offset: 0x7F88908 VA: 0x7F8C908
	private float GetMinSize() { }

	// RVA: 0x7F8C9AC Offset: 0x7F889AC VA: 0x7F8C9AC
	private float GetMaxSize() { }

	// RVA: 0x7F8CCA4 Offset: 0x7F88CA4 VA: 0x7F8CCA4
	public void .ctor() { }
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Flash Graphic")]
public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 23705
{
	// Fields
	public float DecayTime; // 0x20
	public Color DefaultColor; // 0x24
	public Color FlashColor; // 0x34
	public Graphic Target; // 0x48

	// Methods

	// RVA: 0x7F8CCB4 Offset: 0x7F88CB4 VA: 0x7F8CCB4 Slot: 17
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7F8CCF0 Offset: 0x7F88CF0 VA: 0x7F8CCF0 Slot: 18
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7F8CD2C Offset: 0x7F88D2C VA: 0x7F8CD2C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x7F8CD70 Offset: 0x7F88D70 VA: 0x7F8CD70
	protected void Update() { }

	// RVA: 0x7F8CD74 Offset: 0x7F88D74 VA: 0x7F8CD74
	public void Flash() { }

	// RVA: 0x7F8CDDC Offset: 0x7F88DDC VA: 0x7F8CDDC
	public void .ctor() { }
}

// Namespace: SRF.UI
[RequireComponent(typeof(Graphic))]
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Inherit Colour")]
public class InheritColour : SRMonoBehaviour // TypeDefIndex: 23706
{
	// Fields
	private Graphic _graphic; // 0x50
	public Graphic From; // 0x58

	// Properties
	private Graphic Graphic { get; }

	// Methods

	// RVA: 0x7F8CE00 Offset: 0x7F88E00 VA: 0x7F8CE00
	private Graphic get_Graphic() { }

	// RVA: 0x7F8CEA8 Offset: 0x7F88EA8 VA: 0x7F8CEA8
	private void Refresh() { }

	// RVA: 0x7F8CF60 Offset: 0x7F88F60 VA: 0x7F8CF60
	private void Update() { }

	// RVA: 0x7F8CF64 Offset: 0x7F88F64 VA: 0x7F8CF64
	private void Start() { }

	// RVA: 0x7F8CF68 Offset: 0x7F88F68 VA: 0x7F8CF68
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/Long Press Button")]
public class LongPressButton : Button // TypeDefIndex: 23707
{
	// Fields
	private bool _handled; // 0x108
	[SerializeField]
	private Button.ButtonClickedEvent _onLongPress; // 0x110
	private bool _pressed; // 0x118
	private float _pressedTime; // 0x11C
	public float LongPressDuration; // 0x120

	// Properties
	public Button.ButtonClickedEvent onLongPress { get; set; }

	// Methods

	// RVA: 0x7F8CF70 Offset: 0x7F88F70 VA: 0x7F8CF70
	public Button.ButtonClickedEvent get_onLongPress() { }

	// RVA: 0x7F8CF78 Offset: 0x7F88F78 VA: 0x7F8CF78
	public void set_onLongPress(Button.ButtonClickedEvent value) { }

	// RVA: 0x7F8CF88 Offset: 0x7F88F88 VA: 0x7F8CF88 Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x7F8CFA4 Offset: 0x7F88FA4 VA: 0x7F8CFA4 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7F8CFF0 Offset: 0x7F88FF0 VA: 0x7F8CFF0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7F8D018 Offset: 0x7F89018 VA: 0x7F8D018 Slot: 41
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7F8D02C Offset: 0x7F8902C VA: 0x7F8D02C
	private void Update() { }

	// RVA: 0x7F8D084 Offset: 0x7F89084 VA: 0x7F8D084
	public void .ctor() { }
}

// Namespace: SRF.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 23708
{
	// Fields
	private bool _queueRefresh; // 0x50

	// Properties
	protected RectTransform RectTransform { get; }

	// Methods

	// RVA: 0x7F8D0FC Offset: 0x7F890FC VA: 0x7F8D0FC
	protected RectTransform get_RectTransform() { }

	// RVA: 0x7F8D15C Offset: 0x7F8915C VA: 0x7F8D15C
	protected void OnEnable() { }

	// RVA: 0x7F8D168 Offset: 0x7F89168 VA: 0x7F8D168
	protected void OnRectTransformDimensionsChange() { }

	// RVA: 0x7F8D174 Offset: 0x7F89174 VA: 0x7F8D174
	protected void Update() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Refresh();

	[ContextMenu("Refresh")]
	// RVA: 0x7F8D19C Offset: 0x7F8919C VA: 0x7F8D19C
	private void DoRefresh() { }

	// RVA: 0x7F8D1A8 Offset: 0x7F891A8 VA: 0x7F8D1A8
	protected void .ctor() { }
}

// Namespace: 
public enum ResponsiveEnable.Modes // TypeDefIndex: 23709
{
	// Fields
	public int value__; // 0x0
	public const ResponsiveEnable.Modes EnableAbove = 0;
	public const ResponsiveEnable.Modes EnableBelow = 1;
}

// Namespace: 
[Serializable]
public struct ResponsiveEnable.Entry // TypeDefIndex: 23710
{
	// Fields
	public Behaviour[] Components; // 0x0
	public GameObject[] GameObjects; // 0x8
	public ResponsiveEnable.Modes Mode; // 0x10
	public float ThresholdHeight; // 0x14
	public float ThresholdWidth; // 0x18
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("SRF/UI/Responsive (Enable)")]
public class ResponsiveEnable : ResponsiveBase // TypeDefIndex: 23711
{
	// Fields
	public ResponsiveEnable.Entry[] Entries; // 0x58

	// Methods

	// RVA: 0x7F8D1B0 Offset: 0x7F891B0 VA: 0x7F8D1B0 Slot: 4
	protected override void Refresh() { }

	// RVA: 0x7F8D3E0 Offset: 0x7F893E0 VA: 0x7F8D3E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct ResponsiveResize.Element.SizeDefinition // TypeDefIndex: 23712
{
	// Fields
	[Tooltip("Width to apply when over the threshold width")]
	public float ElementWidth; // 0x0
	[Tooltip("Threshold over which this width will take effect")]
	public float ThresholdWidth; // 0x4
}

// Namespace: 
[Serializable]
public struct ResponsiveResize.Element // TypeDefIndex: 23713
{
	// Fields
	public ResponsiveResize.Element.SizeDefinition[] SizeDefinitions; // 0x0
	public RectTransform Target; // 0x8
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("SRF/UI/Responsive (Enable)")]
public class ResponsiveResize : ResponsiveBase // TypeDefIndex: 23714
{
	// Fields
	public ResponsiveResize.Element[] Elements; // 0x58

	// Methods

	// RVA: 0x7F8D444 Offset: 0x7F89444 VA: 0x7F8D444 Slot: 4
	protected override void Refresh() { }

	// RVA: 0x7F8D600 Offset: 0x7F89600 VA: 0x7F8D600
	public void .ctor() { }
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
public class ScrollToBottomBehaviour : MonoBehaviour // TypeDefIndex: 23715
{
	// Fields
	[SerializeField]
	private ScrollRect _scrollRect; // 0x20
	[SerializeField]
	private CanvasGroup _canvasGroup; // 0x28

	// Methods

	// RVA: 0x7F8D664 Offset: 0x7F89664 VA: 0x7F8D664
	public void Start() { }

	// RVA: 0x7F8D894 Offset: 0x7F89894 VA: 0x7F8D894
	private void OnEnable() { }

	// RVA: 0x7F8D898 Offset: 0x7F89898 VA: 0x7F8D898
	public void Trigger() { }

	// RVA: 0x7F8D8BC Offset: 0x7F898BC VA: 0x7F8D8BC
	private void OnScrollRectValueChanged(Vector2 position) { }

	// RVA: 0x7F8D7F8 Offset: 0x7F897F8 VA: 0x7F8D7F8
	private void Refresh() { }

	// RVA: 0x7F8D8C0 Offset: 0x7F898C0 VA: 0x7F8D8C0
	private void SetVisible(bool truth) { }

	// RVA: 0x7F8D940 Offset: 0x7F89940 VA: 0x7F8D940
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/SRNumberButton")]
public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 23716
{
	// Fields
	private const float ExtraThreshold = 3;
	public const float Delay = 0.4;
	private float _delayTime; // 0x108
	private float _downTime; // 0x10C
	private bool _isDown; // 0x110
	public double Amount; // 0x118
	public SRNumberSpinner TargetField; // 0x120

	// Methods

	// RVA: 0x7F8D948 Offset: 0x7F89948 VA: 0x7F8D948 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7F8DA5C Offset: 0x7F89A5C VA: 0x7F8DA5C Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7F8DA78 Offset: 0x7F89A78 VA: 0x7F8DA78 Slot: 43
	protected virtual void Update() { }

	// RVA: 0x7F8D994 Offset: 0x7F89994 VA: 0x7F8D994
	private void Apply() { }

	// RVA: 0x7F8DBC0 Offset: 0x7F89BC0 VA: 0x7F8DBC0
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/SRNumberSpinner")]
public class SRNumberSpinner : InputField // TypeDefIndex: 23717
{
	// Fields
	private double _currentValue; // 0x220
	private double _dragStartAmount; // 0x228
	private double _dragStep; // 0x230
	public float DragSensitivity; // 0x238
	public double MaxValue; // 0x240
	public double MinValue; // 0x248

	// Methods

	// RVA: 0x7F8DBD0 Offset: 0x7F89BD0 VA: 0x7F8DBD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F8DC74 Offset: 0x7F89C74 VA: 0x7F8DC74 Slot: 71
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7F8DD78 Offset: 0x7F89D78 VA: 0x7F8DD78 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7F8DD7C Offset: 0x7F89D7C VA: 0x7F8DD7C Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7F8DD80 Offset: 0x7F89D80 VA: 0x7F8DD80 Slot: 62
	public override void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7F8DFFC Offset: 0x7F89FFC VA: 0x7F8DFFC Slot: 63
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7F8E1EC Offset: 0x7F8A1EC VA: 0x7F8E1EC Slot: 64
	public override void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7F8E24C Offset: 0x7F8A24C VA: 0x7F8E24C
	public void .ctor() { }
}

// Namespace: SRF.UI
[RequireComponent(typeof(CanvasScaler))]
[AddComponentMenu("SRF/UI/Retina Scaler")]
public class SRRetinaScaler : SRMonoBehaviour // TypeDefIndex: 23718
{
	// Fields
	[SerializeField]
	private float _retinaScale; // 0x50
	[SerializeField]
	private int _thresholdDpi; // 0x54
	[SerializeField]
	private bool _disablePixelPerfect; // 0x58

	// Properties
	public int ThresholdDpi { get; }
	public float RetinaScale { get; }

	// Methods

	// RVA: 0x7F8E2BC Offset: 0x7F8A2BC VA: 0x7F8E2BC
	public int get_ThresholdDpi() { }

	// RVA: 0x7F8E2C4 Offset: 0x7F8A2C4 VA: 0x7F8E2C4
	public float get_RetinaScale() { }

	// RVA: 0x7F8E2CC Offset: 0x7F8A2CC VA: 0x7F8E2CC
	private void Start() { }

	// RVA: 0x7F8E390 Offset: 0x7F8A390 VA: 0x7F8E390
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class SRSpinner.SpinEvent : UnityEvent // TypeDefIndex: 23719
{
	// Methods

	// RVA: 0x7F8E610 Offset: 0x7F8A610 VA: 0x7F8E610
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/Spinner")]
public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler // TypeDefIndex: 23720
{
	// Fields
	private float _dragDelta; // 0x100
	[SerializeField]
	private SRSpinner.SpinEvent _onSpinDecrement; // 0x108
	[SerializeField]
	private SRSpinner.SpinEvent _onSpinIncrement; // 0x110
	public float DragThreshold; // 0x118

	// Properties
	public SRSpinner.SpinEvent OnSpinIncrement { get; set; }
	public SRSpinner.SpinEvent OnSpinDecrement { get; set; }

	// Methods

	// RVA: 0x7F8E3A4 Offset: 0x7F8A3A4 VA: 0x7F8E3A4
	public SRSpinner.SpinEvent get_OnSpinIncrement() { }

	// RVA: 0x7F8E3AC Offset: 0x7F8A3AC VA: 0x7F8E3AC
	public void set_OnSpinIncrement(SRSpinner.SpinEvent value) { }

	// RVA: 0x7F8E3BC Offset: 0x7F8A3BC VA: 0x7F8E3BC
	public SRSpinner.SpinEvent get_OnSpinDecrement() { }

	// RVA: 0x7F8E3C4 Offset: 0x7F8A3C4 VA: 0x7F8E3C4
	public void set_OnSpinDecrement(SRSpinner.SpinEvent value) { }

	// RVA: 0x7F8E3D4 Offset: 0x7F8A3D4 VA: 0x7F8E3D4 Slot: 40
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7F8E3DC Offset: 0x7F8A3DC VA: 0x7F8E3DC Slot: 39
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7F8E4CC Offset: 0x7F8A4CC VA: 0x7F8E4CC
	private void OnIncrement(int amount) { }

	// RVA: 0x7F8E50C Offset: 0x7F8A50C VA: 0x7F8E50C
	private void OnDecrement(int amount) { }

	// RVA: 0x7F8E54C Offset: 0x7F8A54C VA: 0x7F8E54C
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/SRText")]
public class SRText : Text // TypeDefIndex: 23721
{
	// Fields
	[CompilerGenerated]
	private Action<SRText> LayoutDirty; // 0x108

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F8BCA4 Offset: 0x7F87CA4 VA: 0x7F8BCA4
	public void add_LayoutDirty(Action<SRText> value) { }

	[CompilerGenerated]
	// RVA: 0x7F8BDF4 Offset: 0x7F87DF4 VA: 0x7F8BDF4
	public void remove_LayoutDirty(Action<SRText> value) { }

	// RVA: 0x7F8E618 Offset: 0x7F8A618 VA: 0x7F8E618 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x7F8E650 Offset: 0x7F8A650 VA: 0x7F8E650
	public void .ctor() { }
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Style Component")]
public class StyleComponent : SRMonoBehaviour // TypeDefIndex: 23722
{
	// Fields
	private Style _activeStyle; // 0x50
	private StyleRoot _cachedRoot; // 0x58
	private Graphic _graphic; // 0x60
	private bool _hasStarted; // 0x68
	private Image _image; // 0x70
	private Selectable _selectable; // 0x78
	[SerializeField]
	[FormerlySerializedAs("StyleKey")]
	[HideInInspector]
	private string _styleKey; // 0x80
	public bool IgnoreImage; // 0x88

	// Properties
	public string StyleKey { get; set; }

	// Methods

	// RVA: 0x7F8E658 Offset: 0x7F8A658 VA: 0x7F8E658
	public string get_StyleKey() { }

	// RVA: 0x7F8E660 Offset: 0x7F8A660 VA: 0x7F8E660
	public void set_StyleKey(string value) { }

	// RVA: 0x7F8E894 Offset: 0x7F8A894 VA: 0x7F8E894
	private void Start() { }

	// RVA: 0x7F8E8BC Offset: 0x7F8A8BC VA: 0x7F8E8BC
	private void OnEnable() { }

	// RVA: 0x7F8E680 Offset: 0x7F8A680 VA: 0x7F8E680
	public void Refresh(bool invalidateCache) { }

	// RVA: 0x7F8E8D0 Offset: 0x7F8A8D0 VA: 0x7F8E8D0
	private StyleRoot GetStyleRoot() { }

	// RVA: 0x7F8EB2C Offset: 0x7F8AB2C VA: 0x7F8EB2C
	private void ApplyStyle() { }

	// RVA: 0x7F8EE5C Offset: 0x7F8AE5C VA: 0x7F8EE5C
	private void SRStyleDirty() { }

	// RVA: 0x7F8EEA0 Offset: 0x7F8AEA0 VA: 0x7F8EEA0
	public void .ctor() { }
}

// Namespace: SRF.UI
[ExecuteInEditMode]
[AddComponentMenu("SRF/UI/Style Root")]
public sealed class StyleRoot : SRMonoBehaviour // TypeDefIndex: 23723
{
	// Fields
	private StyleSheet _activeStyleSheet; // 0x50
	public StyleSheet StyleSheet; // 0x58

	// Methods

	// RVA: 0x7F8EA48 Offset: 0x7F8AA48 VA: 0x7F8EA48
	public Style GetStyle(string key) { }

	// RVA: 0x7F8EFA8 Offset: 0x7F8AFA8 VA: 0x7F8EFA8
	private void OnEnable() { }

	// RVA: 0x7F8F094 Offset: 0x7F8B094 VA: 0x7F8F094
	private void OnDisable() { }

	// RVA: 0x7F8F098 Offset: 0x7F8B098 VA: 0x7F8F098
	private void Update() { }

	// RVA: 0x7F8F034 Offset: 0x7F8B034 VA: 0x7F8F034
	private void OnStyleSheetChanged() { }

	// RVA: 0x7F8F110 Offset: 0x7F8B110 VA: 0x7F8F110
	public void SetDirty() { }

	// RVA: 0x7F8F11C Offset: 0x7F8B11C VA: 0x7F8F11C
	public void .ctor() { }
}

// Namespace: SRF.UI
[Serializable]
public class Style // TypeDefIndex: 23724
{
	// Fields
	public Color ActiveColor; // 0x10
	public Color DisabledColor; // 0x20
	public Color HoverColor; // 0x30
	public Sprite Image; // 0x40
	public Color NormalColor; // 0x48

	// Methods

	// RVA: 0x7F8F124 Offset: 0x7F8B124 VA: 0x7F8F124
	public Style Copy() { }

	// RVA: 0x7F8F1A4 Offset: 0x7F8B1A4 VA: 0x7F8F1A4
	public void CopyFrom(Style style) { }

	// RVA: 0x7F8F18C Offset: 0x7F8B18C VA: 0x7F8F18C
	public void .ctor() { }
}

// Namespace: SRF.UI
[Serializable]
public class StyleSheet : ScriptableObject // TypeDefIndex: 23725
{
	// Fields
	[SerializeField]
	private List<string> _keys; // 0x18
	[SerializeField]
	private List<Style> _styles; // 0x20
	[SerializeField]
	public StyleSheet Parent; // 0x28

	// Methods

	// RVA: 0x7F8EEA8 Offset: 0x7F8AEA8 VA: 0x7F8EEA8
	public Style GetStyle(string key, bool searchParent = True) { }

	// RVA: 0x7F8F1F8 Offset: 0x7F8B1F8 VA: 0x7F8F1F8
	public void .ctor() { }
}

// Namespace: SRF.UI
[AddComponentMenu("SRF/UI/Unselectable")]
public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler // TypeDefIndex: 23726
{
	// Fields
	private bool _suspectedSelected; // 0x50

	// Methods

	// RVA: 0x7F8F2D4 Offset: 0x7F8B2D4 VA: 0x7F8F2D4 Slot: 4
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x7F8F2E0 Offset: 0x7F8B2E0 VA: 0x7F8F2E0
	private void Update() { }

	// RVA: 0x7F8F3C8 Offset: 0x7F8B3C8 VA: 0x7F8F3C8
	public void .ctor() { }
}

// Namespace: SRF.UI.Layout
[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 23727
{
	// Fields
	private readonly IList<RectTransform> _rowList; // 0x60
	private float _layoutHeight; // 0x68
	public bool ChildForceExpandHeight; // 0x6C
	public bool ChildForceExpandWidth; // 0x6D
	public float Spacing; // 0x70

	// Properties
	protected bool IsCenterAlign { get; }
	protected bool IsRightAlign { get; }
	protected bool IsMiddleAlign { get; }
	protected bool IsLowerAlign { get; }

	// Methods

	// RVA: 0x7F8F3D0 Offset: 0x7F8B3D0 VA: 0x7F8F3D0
	protected bool get_IsCenterAlign() { }

	// RVA: 0x7F8F3F8 Offset: 0x7F8B3F8 VA: 0x7F8F3F8
	protected bool get_IsRightAlign() { }

	// RVA: 0x7F8F420 Offset: 0x7F8B420 VA: 0x7F8F420
	protected bool get_IsMiddleAlign() { }

	// RVA: 0x7F8F434 Offset: 0x7F8B434 VA: 0x7F8F434
	protected bool get_IsLowerAlign() { }

	// RVA: 0x7F8F448 Offset: 0x7F8B448 VA: 0x7F8F448 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x7F8F56C Offset: 0x7F8B56C VA: 0x7F8F56C Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x7F8FAA0 Offset: 0x7F8BAA0 VA: 0x7F8FAA0 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x7F8FAD4 Offset: 0x7F8BAD4 VA: 0x7F8FAD4 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x7F8F5A0 Offset: 0x7F8B5A0 VA: 0x7F8F5A0
	public float SetLayout(float width, int axis, bool layoutInput) { }

	// RVA: 0x7F8FB10 Offset: 0x7F8BB10 VA: 0x7F8FB10
	private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight) { }

	// RVA: 0x7F8FB58 Offset: 0x7F8BB58 VA: 0x7F8FB58
	protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis) { }

	// RVA: 0x7F8F4CC Offset: 0x7F8B4CC VA: 0x7F8F4CC
	public float GetGreatestMinimumChildWidth() { }

	// RVA: 0x7F8FF7C Offset: 0x7F8BF7C VA: 0x7F8FF7C
	public void .ctor() { }
}

// Namespace: SRF.UI.Layout
public interface IVirtualView // TypeDefIndex: 23728
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetDataContext(object data);
}

// Namespace: 
[Serializable]
public class VirtualVerticalLayoutGroup.SelectedItemChangedEvent : UnityEvent<object> // TypeDefIndex: 23729
{
	// Methods

	// RVA: 0x7F91E34 Offset: 0x7F8DE34 VA: 0x7F91E34
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class VirtualVerticalLayoutGroup.Row // TypeDefIndex: 23730
{
	// Fields
	public object Data; // 0x10
	public int Index; // 0x18
	public RectTransform Rect; // 0x20
	public StyleRoot Root; // 0x28
	public IVirtualView View; // 0x30

	// Methods

	// RVA: 0x7F91CBC Offset: 0x7F8DCBC VA: 0x7F91CBC
	public void .ctor() { }
}

// Namespace: SRF.UI.Layout
[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 23731
{
	// Fields
	private readonly SRList<object> _itemList; // 0x60
	private readonly SRList<int> _visibleItemList; // 0x68
	private bool _isDirty; // 0x70
	private SRList<VirtualVerticalLayoutGroup.Row> _rowCache; // 0x78
	private ScrollRect _scrollRect; // 0x80
	private int _selectedIndex; // 0x88
	private object _selectedItem; // 0x90
	[SerializeField]
	private VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged; // 0x98
	private int _visibleItemCount; // 0xA0
	private SRList<VirtualVerticalLayoutGroup.Row> _visibleRows; // 0xA8
	public StyleSheet AltRowStyleSheet; // 0xB0
	public bool EnableSelection; // 0xB8
	public RectTransform ItemPrefab; // 0xC0
	public int RowPadding; // 0xC8
	public StyleSheet RowStyleSheet; // 0xD0
	public StyleSheet SelectedRowStyleSheet; // 0xD8
	public float Spacing; // 0xE0
	public bool StickToBottom; // 0xE4
	private float _itemHeight; // 0xE8

	// Properties
	public VirtualVerticalLayoutGroup.SelectedItemChangedEvent SelectedItemChanged { get; set; }
	public object SelectedItem { get; set; }
	public override float minHeight { get; }
	private ScrollRect ScrollRect { get; }
	private bool AlignBottom { get; }
	private bool AlignTop { get; }
	private float ItemHeight { get; }

	// Methods

	// RVA: 0x7F90004 Offset: 0x7F8C004 VA: 0x7F90004
	public VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged() { }

	// RVA: 0x7F9000C Offset: 0x7F8C00C VA: 0x7F9000C
	public void set_SelectedItemChanged(VirtualVerticalLayoutGroup.SelectedItemChangedEvent value) { }

	// RVA: 0x7F90014 Offset: 0x7F8C014 VA: 0x7F90014
	public object get_SelectedItem() { }

	// RVA: 0x7F9001C Offset: 0x7F8C01C VA: 0x7F9001C
	public void set_SelectedItem(object value) { }

	// RVA: 0x7F9030C Offset: 0x7F8C30C VA: 0x7F9030C Slot: 33
	public override float get_minHeight() { }

	// RVA: 0x7F9055C Offset: 0x7F8C55C VA: 0x7F9055C Slot: 40
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7F90704 Offset: 0x7F8C704 VA: 0x7F90704 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9095C Offset: 0x7F8C95C VA: 0x7F9095C
	private void OnScrollRectValueChanged(Vector2 d) { }

	// RVA: 0x7F909D0 Offset: 0x7F8C9D0 VA: 0x7F909D0 Slot: 6
	protected override void Start() { }

	// RVA: 0x7F90DCC Offset: 0x7F8CDCC VA: 0x7F90DCC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x7F90E0C Offset: 0x7F8CE0C VA: 0x7F90E0C
	protected void Update() { }

	// RVA: 0x7F90190 Offset: 0x7F8C190 VA: 0x7F90190
	protected void InvalidateItem(int itemIndex) { }

	// RVA: 0x7F90F8C Offset: 0x7F8CF8C VA: 0x7F90F8C
	protected void RefreshIndexCache() { }

	// RVA: 0x7F909EC Offset: 0x7F8C9EC VA: 0x7F909EC
	protected void ScrollUpdate() { }

	// RVA: 0x7F91238 Offset: 0x7F8D238 VA: 0x7F91238 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x7F91290 Offset: 0x7F8D290 VA: 0x7F91290 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x7F91424 Offset: 0x7F8D424 VA: 0x7F91424 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x7F902D8 Offset: 0x7F8C2D8 VA: 0x7F902D8
	private void SetDirty() { }

	// RVA: 0x7F91568 Offset: 0x7F8D568 VA: 0x7F91568
	public void AddItem(object item) { }

	// RVA: 0x7F916A4 Offset: 0x7F8D6A4 VA: 0x7F916A4
	public void RemoveItem(object item) { }

	// RVA: 0x7F9177C Offset: 0x7F8D77C VA: 0x7F9177C
	public void ClearItems() { }

	// RVA: 0x7F908B4 Offset: 0x7F8C8B4 VA: 0x7F908B4
	private ScrollRect get_ScrollRect() { }

	// RVA: 0x7F90F10 Offset: 0x7F8CF10 VA: 0x7F90F10
	private bool get_AlignBottom() { }

	// RVA: 0x7F90F24 Offset: 0x7F8CF24 VA: 0x7F90F24
	private bool get_AlignTop() { }

	// RVA: 0x7F903C4 Offset: 0x7F8C3C4 VA: 0x7F903C4
	private float get_ItemHeight() { }

	// RVA: 0x7F91070 Offset: 0x7F8D070 VA: 0x7F91070
	private VirtualVerticalLayoutGroup.Row GetRow(int forIndex) { }

	// RVA: 0x7F90F34 Offset: 0x7F8CF34 VA: 0x7F90F34
	private void RecycleRow(VirtualVerticalLayoutGroup.Row row) { }

	// RVA: 0x7F91A98 Offset: 0x7F8DA98 VA: 0x7F91A98
	private void PopulateRow(int index, VirtualVerticalLayoutGroup.Row row) { }

	// RVA: 0x7F9185C Offset: 0x7F8D85C VA: 0x7F9185C
	private VirtualVerticalLayoutGroup.Row CreateRow() { }

	// RVA: 0x7F91CC4 Offset: 0x7F8DCC4 VA: 0x7F91CC4
	public void .ctor() { }
}

// Namespace: SRF.Components
public abstract class SRAutoSingleton<T> : SRMonoBehaviour // TypeDefIndex: 23732
{
	// Fields
	private static T _instance; // 0x0

	// Properties
	public static T Instance { get; }
	public static bool HasInstance { get; }

	// Methods

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CFCE8 Offset: 0x54CBCE8 VA: 0x54CFCE8
	|-SRAutoSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	public static bool get_HasInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CFEBC Offset: 0x54CBEBC VA: 0x54CFEBC
	|-SRAutoSingleton<object>.get_HasInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CFF48 Offset: 0x54CBF48 VA: 0x54CFF48
	|-SRAutoSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	private void OnApplicationQuit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D01D8 Offset: 0x54CC1D8 VA: 0x54D01D8
	|-SRAutoSingleton<object>.OnApplicationQuit
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D0204 Offset: 0x54CC204 VA: 0x54D0204
	|-SRAutoSingleton<object>..ctor
	*/
}

// Namespace: SRF.Components
public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 23733
{
	// Fields
	private static T _instance; // 0x0

	// Properties
	public static T Instance { get; }
	public static bool HasInstance { get; }

	// Methods

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D473C Offset: 0x54D073C VA: 0x54D473C
	|-SRSingleton<object>.get_Instance
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static bool get_HasInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D48D0 Offset: 0x54D08D0 VA: 0x54D48D0
	|-SRSingleton<object>.get_HasInstance
	*/

	// RVA: -1 Offset: -1
	private void Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D495C Offset: 0x54D095C VA: 0x54D495C
	|-SRSingleton<object>.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4C60 Offset: 0x54D0C60 VA: 0x54D4C60
	|-SRSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4C70 Offset: 0x54D0C70 VA: 0x54D4C70
	|-SRSingleton<object>.OnEnable
	*/

	// RVA: -1 Offset: -1
	private void OnApplicationQuit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4D18 Offset: 0x54D0D18 VA: 0x54D4D18
	|-SRSingleton<object>.OnApplicationQuit
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4D44 Offset: 0x54D0D44 VA: 0x54D4D44
	|-SRSingleton<object>..ctor
	*/
}

// Namespace: SRDebugger
public static class AutoInitialize // TypeDefIndex: 23734
{
	// Methods

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x7F91E7C Offset: 0x7F8DE7C VA: 0x7F91E7C
	public static void OnLoad() { }
}

// Namespace: SRDebugger
[DefaultMember("Item")]
public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 23735
{
	// Properties
	public abstract int Count { get; }
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.get_Item
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class CircularBuffer.<GetEnumerator>d__17<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 23736
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public CircularBuffer<T> <>4__this; // 0x0
	private ArraySegment<T>[] <>7__wrap1; // 0x0
	private int <>7__wrap2; // 0x0
	private ArraySegment<T> <segment>5__4; // 0x0
	private int <i>5__5; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29114 Offset: 0x5D25114 VA: 0x5D29114
	|-CircularBuffer.<GetEnumerator>d__17<object>..ctor
	|
	|-RVA: 0x5D29394 Offset: 0x5D25394 VA: 0x5D29394
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>..ctor
	|
	|-RVA: 0x5D29644 Offset: 0x5D25644 VA: 0x5D29644
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2913C Offset: 0x5D2513C VA: 0x5D2913C
	|-CircularBuffer.<GetEnumerator>d__17<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D293BC Offset: 0x5D253BC VA: 0x5D293BC
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D29684 Offset: 0x5D25684 VA: 0x5D29684
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29140 Offset: 0x5D25140 VA: 0x5D29140
	|-CircularBuffer.<GetEnumerator>d__17<object>.MoveNext
	|
	|-RVA: 0x5D293C0 Offset: 0x5D253C0 VA: 0x5D293C0
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>.MoveNext
	|
	|-RVA: 0x5D29688 Offset: 0x5D25688 VA: 0x5D29688
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29350 Offset: 0x5D25350 VA: 0x5D29350
	|-CircularBuffer.<GetEnumerator>d__17<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D295D0 Offset: 0x5D255D0 VA: 0x5D295D0
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D29B98 Offset: 0x5D25B98 VA: 0x5D29B98
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29358 Offset: 0x5D25358 VA: 0x5D29358
	|-CircularBuffer.<GetEnumerator>d__17<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D295DC Offset: 0x5D255DC VA: 0x5D295DC
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D29C38 Offset: 0x5D25C38 VA: 0x5D29C38
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2938C Offset: 0x5D2538C VA: 0x5D2938C
	|-CircularBuffer.<GetEnumerator>d__17<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D29610 Offset: 0x5D25610 VA: 0x5D29610
	|-CircularBuffer.<GetEnumerator>d__17<ProfilerFrame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D29C6C Offset: 0x5D25C6C VA: 0x5D29C6C
	|-CircularBuffer.<GetEnumerator>d__17<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: SRDebugger
[DefaultMember("Item")]
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 23737
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4540 Offset: 0x5BB0540 VA: 0x5BB4540
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x5BB51A0 Offset: 0x5BB11A0 VA: 0x5BB51A0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x5BB5E0C Offset: 0x5BB1E0C VA: 0x5BB5E0C
	|-CircularBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB45A4 Offset: 0x5BB05A4 VA: 0x5BB45A4
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x5BB5204 Offset: 0x5BB1204 VA: 0x5BB5204
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x5BB5E74 Offset: 0x5BB1E74 VA: 0x5BB5E74
	|-CircularBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB46FC Offset: 0x5BB06FC VA: 0x5BB46FC
	|-CircularBuffer<object>.get_Capacity
	|
	|-RVA: 0x5BB535C Offset: 0x5BB135C VA: 0x5BB535C
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x5BB5FCC Offset: 0x5BB1FCC VA: 0x5BB5FCC
	|-CircularBuffer<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4718 Offset: 0x5BB0718 VA: 0x5BB4718
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x5BB5378 Offset: 0x5BB1378 VA: 0x5BB5378
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	|
	|-RVA: 0x5BB5FE8 Offset: 0x5BB1FE8 VA: 0x5BB5FE8
	|-CircularBuffer<__Il2CppFullySharedGenericType>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4740 Offset: 0x5BB0740 VA: 0x5BB4740
	|-CircularBuffer<object>.get_IsEmpty
	|
	|-RVA: 0x5BB53A0 Offset: 0x5BB13A0 VA: 0x5BB53A0
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x5BB603C Offset: 0x5BB203C VA: 0x5BB603C
	|-CircularBuffer<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4750 Offset: 0x5BB0750 VA: 0x5BB4750
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x5BB53B0 Offset: 0x5BB13B0 VA: 0x5BB53B0
	|-CircularBuffer<ProfilerFrame>.get_Count
	|
	|-RVA: 0x5BB6064 Offset: 0x5BB2064 VA: 0x5BB6064
	|-CircularBuffer<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4758 Offset: 0x5BB0758 VA: 0x5BB4758
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x5BB53B8 Offset: 0x5BB13B8 VA: 0x5BB53B8
	|-CircularBuffer<ProfilerFrame>.get_Item
	|
	|-RVA: 0x5BB606C Offset: 0x5BB206C VA: 0x5BB606C
	|-CircularBuffer<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB48C0 Offset: 0x5BB08C0 VA: 0x5BB48C0
	|-CircularBuffer<object>.set_Item
	|
	|-RVA: 0x5BB5528 Offset: 0x5BB1528 VA: 0x5BB5528
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x5BB6240 Offset: 0x5BB2240 VA: 0x5BB6240
	|-CircularBuffer<__Il2CppFullySharedGenericType>.set_Item
	*/

	[IteratorStateMachine(typeof(CircularBuffer.<GetEnumerator>d__17<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4A2C Offset: 0x5BB0A2C VA: 0x5BB4A2C
	|-CircularBuffer<object>.GetEnumerator
	|
	|-RVA: 0x5BB5698 Offset: 0x5BB1698 VA: 0x5BB5698
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x5BB6474 Offset: 0x5BB2474 VA: 0x5BB6474
	|-CircularBuffer<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4AA4 Offset: 0x5BB0AA4 VA: 0x5BB4AA4
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BB5710 Offset: 0x5BB1710 VA: 0x5BB5710
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BB6500 Offset: 0x5BB2500 VA: 0x5BB6500
	|-CircularBuffer<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4AB4 Offset: 0x5BB0AB4 VA: 0x5BB4AB4
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x5BB5720 Offset: 0x5BB1720 VA: 0x5BB5720
	|-CircularBuffer<ProfilerFrame>.Front
	|
	|-RVA: 0x5BB6514 Offset: 0x5BB2514 VA: 0x5BB6514
	|-CircularBuffer<__Il2CppFullySharedGenericType>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4B40 Offset: 0x5BB0B40 VA: 0x5BB4B40
	|-CircularBuffer<object>.Back
	|
	|-RVA: 0x5BB57B0 Offset: 0x5BB17B0 VA: 0x5BB57B0
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x5BB6620 Offset: 0x5BB2620 VA: 0x5BB6620
	|-CircularBuffer<__Il2CppFullySharedGenericType>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4BE4 Offset: 0x5BB0BE4 VA: 0x5BB4BE4
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x5BB585C Offset: 0x5BB185C VA: 0x5BB585C
	|-CircularBuffer<ProfilerFrame>.PushBack
	|
	|-RVA: 0x5BB6748 Offset: 0x5BB2748 VA: 0x5BB6748
	|-CircularBuffer<__Il2CppFullySharedGenericType>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4C70 Offset: 0x5BB0C70 VA: 0x5BB4C70
	|-CircularBuffer<object>.PushFront
	|
	|-RVA: 0x5BB58DC Offset: 0x5BB18DC VA: 0x5BB58DC
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x5BB68D0 Offset: 0x5BB28D0 VA: 0x5BB68D0
	|-CircularBuffer<__Il2CppFullySharedGenericType>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4CEC Offset: 0x5BB0CEC VA: 0x5BB4CEC
	|-CircularBuffer<object>.PopBack
	|
	|-RVA: 0x5BB595C Offset: 0x5BB195C VA: 0x5BB595C
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x5BB6AE8 Offset: 0x5BB2AE8 VA: 0x5BB6AE8
	|-CircularBuffer<__Il2CppFullySharedGenericType>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4DAC Offset: 0x5BB0DAC VA: 0x5BB4DAC
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x5BB5A1C Offset: 0x5BB1A1C VA: 0x5BB5A1C
	|-CircularBuffer<ProfilerFrame>.PopFront
	|
	|-RVA: 0x5BB6C8C Offset: 0x5BB2C8C VA: 0x5BB6C8C
	|-CircularBuffer<__Il2CppFullySharedGenericType>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4E70 Offset: 0x5BB0E70 VA: 0x5BB4E70
	|-CircularBuffer<object>.ToArray
	|
	|-RVA: 0x5BB5ADC Offset: 0x5BB1ADC VA: 0x5BB5ADC
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x5BB6E3C Offset: 0x5BB2E3C VA: 0x5BB6E3C
	|-CircularBuffer<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB4FFC Offset: 0x5BB0FFC VA: 0x5BB4FFC
	|-CircularBuffer<object>.ThrowIfEmpty
	|
	|-RVA: 0x5BB5C68 Offset: 0x5BB1C68 VA: 0x5BB5C68
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x5BB7060 Offset: 0x5BB3060 VA: 0x5BB7060
	|-CircularBuffer<__Il2CppFullySharedGenericType>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB504C Offset: 0x5BB104C VA: 0x5BB504C
	|-CircularBuffer<object>.Increment
	|
	|-RVA: 0x5BB5CB8 Offset: 0x5BB1CB8 VA: 0x5BB5CB8
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x5BB70C0 Offset: 0x5BB30C0 VA: 0x5BB70C0
	|-CircularBuffer<__Il2CppFullySharedGenericType>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB5080 Offset: 0x5BB1080 VA: 0x5BB5080
	|-CircularBuffer<object>.Decrement
	|
	|-RVA: 0x5BB5CEC Offset: 0x5BB1CEC VA: 0x5BB5CEC
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x5BB7104 Offset: 0x5BB3104 VA: 0x5BB7104
	|-CircularBuffer<__Il2CppFullySharedGenericType>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB50AC Offset: 0x5BB10AC VA: 0x5BB50AC
	|-CircularBuffer<object>.InternalIndex
	|
	|-RVA: 0x5BB5D18 Offset: 0x5BB1D18 VA: 0x5BB5D18
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x5BB713C Offset: 0x5BB313C VA: 0x5BB713C
	|-CircularBuffer<__Il2CppFullySharedGenericType>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB50E0 Offset: 0x5BB10E0 VA: 0x5BB50E0
	|-CircularBuffer<object>.ArrayOne
	|
	|-RVA: 0x5BB5D4C Offset: 0x5BB1D4C VA: 0x5BB5D4C
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x5BB71B0 Offset: 0x5BB31B0 VA: 0x5BB71B0
	|-CircularBuffer<__Il2CppFullySharedGenericType>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB5148 Offset: 0x5BB1148 VA: 0x5BB5148
	|-CircularBuffer<object>.ArrayTwo
	|
	|-RVA: 0x5BB5DB4 Offset: 0x5BB1DB4 VA: 0x5BB5DB4
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x5BB7218 Offset: 0x5BB3218 VA: 0x5BB7218
	|-CircularBuffer<__Il2CppFullySharedGenericType>.ArrayTwo
	*/
}

// Namespace: SRDebugger
public sealed class VisibilityChangedDelegate : MulticastDelegate // TypeDefIndex: 23738
{
	// Methods

	// RVA: 0x7F91F88 Offset: 0x7F8DF88 VA: 0x7F91F88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F92028 Offset: 0x7F8E028 VA: 0x7F92028 Slot: 13
	public virtual void Invoke(bool isVisible) { }

	// RVA: 0x7F92040 Offset: 0x7F8E040 VA: 0x7F92040 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isVisible, AsyncCallback callback, object object) { }

	// RVA: 0x7F920C8 Offset: 0x7F8E0C8 VA: 0x7F920C8 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SRDebugger
public sealed class ActionCompleteCallback : MulticastDelegate // TypeDefIndex: 23739
{
	// Methods

	// RVA: 0x7F920D4 Offset: 0x7F8E0D4 VA: 0x7F920D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F92174 Offset: 0x7F8E174 VA: 0x7F92174 Slot: 13
	public virtual void Invoke(bool success) { }

	// RVA: 0x7F9218C Offset: 0x7F8E18C VA: 0x7F9218C Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, AsyncCallback callback, object object) { }

	// RVA: 0x7F92214 Offset: 0x7F8E214 VA: 0x7F92214 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InfoEntry.<>c__DisplayClass12_0 // TypeDefIndex: 23740
{
	// Fields
	public object value; // 0x10

	// Methods

	// RVA: 0x7F92550 Offset: 0x7F8E550 VA: 0x7F92550
	public void .ctor() { }

	// RVA: 0x7F92558 Offset: 0x7F8E558 VA: 0x7F92558
	internal object <Create>b__0() { }
}

// Namespace: SRDebugger
public sealed class InfoEntry // TypeDefIndex: 23741
{
	// Fields
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsPrivate>k__BackingField; // 0x18
	private Func<object> _valueGetter; // 0x20

	// Properties
	public string Title { get; set; }
	public object Value { get; }
	public bool IsPrivate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F92220 Offset: 0x7F8E220 VA: 0x7F92220
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x7F92228 Offset: 0x7F8E228 VA: 0x7F92228
	public void set_Title(string value) { }

	// RVA: 0x7F92230 Offset: 0x7F8E230 VA: 0x7F92230
	public object get_Value() { }

	[CompilerGenerated]
	// RVA: 0x7F9237C Offset: 0x7F8E37C VA: 0x7F9237C
	public bool get_IsPrivate() { }

	[CompilerGenerated]
	// RVA: 0x7F92384 Offset: 0x7F8E384 VA: 0x7F92384
	private void set_IsPrivate(bool value) { }

	// RVA: 0x7F92390 Offset: 0x7F8E390 VA: 0x7F92390
	public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = False) { }

	// RVA: 0x7F92430 Offset: 0x7F8E430 VA: 0x7F92430
	public static InfoEntry Create(string name, object value, bool isPrivate = False) { }

	// RVA: 0x7F92428 Offset: 0x7F8E428 VA: 0x7F92428
	public void .ctor() { }
}

// Namespace: SRDebugger
public enum DefaultTabs // TypeDefIndex: 23742
{
	// Fields
	public int value__; // 0x0
	public const DefaultTabs SystemInformation = 0;
	public const DefaultTabs Options = 1;
	public const DefaultTabs Console = 2;
	public const DefaultTabs Profiler = 3;
	public const DefaultTabs BugReporter = 4;
}

// Namespace: SRDebugger
public enum PinAlignment // TypeDefIndex: 23743
{
	// Fields
	public int value__; // 0x0
	public const PinAlignment TopLeft = 0;
	public const PinAlignment TopRight = 1;
	public const PinAlignment BottomLeft = 2;
	public const PinAlignment BottomRight = 3;
	public const PinAlignment CenterLeft = 4;
	public const PinAlignment CenterRight = 5;
	public const PinAlignment TopCenter = 6;
	public const PinAlignment BottomCenter = 7;
}

// Namespace: SRDebugger
public enum ConsoleAlignment // TypeDefIndex: 23744
{
	// Fields
	public int value__; // 0x0
	public const ConsoleAlignment Top = 0;
	public const ConsoleAlignment Bottom = 1;
}

// Namespace: 
public enum Settings.ShortcutActions // TypeDefIndex: 23745
{
	// Fields
	public int value__; // 0x0
	public const Settings.ShortcutActions None = 0;
	public const Settings.ShortcutActions OpenSystemInfoTab = 1;
	public const Settings.ShortcutActions OpenConsoleTab = 2;
	public const Settings.ShortcutActions OpenOptionsTab = 3;
	public const Settings.ShortcutActions OpenProfilerTab = 4;
	public const Settings.ShortcutActions OpenBugReporterTab = 5;
	public const Settings.ShortcutActions ClosePanel = 6;
	public const Settings.ShortcutActions OpenPanel = 7;
	public const Settings.ShortcutActions TogglePanel = 8;
	public const Settings.ShortcutActions ShowBugReportPopover = 9;
	public const Settings.ShortcutActions ToggleDockedConsole = 10;
	public const Settings.ShortcutActions ToggleDockedProfiler = 11;
}

// Namespace: 
public enum Settings.TriggerBehaviours // TypeDefIndex: 23746
{
	// Fields
	public int value__; // 0x0
	public const Settings.TriggerBehaviours TripleTap = 0;
	public const Settings.TriggerBehaviours TapAndHold = 1;
	public const Settings.TriggerBehaviours DoubleTap = 2;
}

// Namespace: 
public enum Settings.TriggerEnableModes // TypeDefIndex: 23747
{
	// Fields
	public int value__; // 0x0
	public const Settings.TriggerEnableModes Enabled = 0;
	public const Settings.TriggerEnableModes MobileOnly = 1;
	public const Settings.TriggerEnableModes Off = 2;
	public const Settings.TriggerEnableModes DevelopmentBuildsOnly = 3;
}

// Namespace: 
[Serializable]
public sealed class Settings.KeyboardShortcut // TypeDefIndex: 23748
{
	// Fields
	[SerializeField]
	public Settings.ShortcutActions Action; // 0x10
	[SerializeField]
	public bool Alt; // 0x14
	[SerializeField]
	public bool Control; // 0x15
	[SerializeField]
	public KeyCode Key; // 0x18
	[SerializeField]
	public bool Shift; // 0x1C

	// Methods

	// RVA: 0x7F92A14 Offset: 0x7F8EA14 VA: 0x7F92A14
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Settings.<>c // TypeDefIndex: 23749
{
	// Fields
	public static readonly Settings.<>c <>9; // 0x0
	public static Func<int, bool> <>9__35_0; // 0x8

	// Methods

	// RVA: 0x7F92EC0 Offset: 0x7F8EEC0 VA: 0x7F92EC0
	private static void .cctor() { }

	// RVA: 0x7F92F28 Offset: 0x7F8EF28 VA: 0x7F92F28
	public void .ctor() { }

	// RVA: 0x7F92F30 Offset: 0x7F8EF30 VA: 0x7F92F30
	internal bool <set_EntryCode>b__35_0(int p) { }
}

// Namespace: SRDebugger
public class Settings : ScriptableObject // TypeDefIndex: 23750
{
	// Fields
	private const string ResourcesPath = "/usr/Resources/SRDebugger";
	private const string ResourcesName = "Settings";
	private static Settings _instance; // 0x0
	[SerializeField]
	private bool _isEnabled; // 0x18
	[SerializeField]
	private bool _autoLoad; // 0x19
	[SerializeField]
	private DefaultTabs _defaultTab; // 0x1C
	[SerializeField]
	private Settings.TriggerEnableModes _triggerEnableMode; // 0x20
	[SerializeField]
	private Settings.TriggerBehaviours _triggerBehaviour; // 0x24
	[SerializeField]
	private bool _enableKeyboardShortcuts; // 0x28
	[SerializeField]
	private Settings.KeyboardShortcut[] _keyboardShortcuts; // 0x30
	[SerializeField]
	private Settings.KeyboardShortcut[] _newKeyboardShortcuts; // 0x38
	[SerializeField]
	private bool _keyboardModifierControl; // 0x40
	[SerializeField]
	private bool _keyboardModifierAlt; // 0x41
	[SerializeField]
	private bool _keyboardModifierShift; // 0x42
	[SerializeField]
	private bool _keyboardEscapeClose; // 0x43
	[SerializeField]
	private bool _enableBackgroundTransparency; // 0x44
	[SerializeField]
	private bool _collapseDuplicateLogEntries; // 0x45
	[SerializeField]
	private bool _richTextInConsole; // 0x46
	[SerializeField]
	private bool _requireEntryCode; // 0x47
	[SerializeField]
	private bool _requireEntryCodeEveryTime; // 0x48
	[SerializeField]
	private int[] _entryCode; // 0x50
	[SerializeField]
	private bool _useDebugCamera; // 0x58
	[SerializeField]
	private int _debugLayer; // 0x5C
	[Range(-100, 100)]
	[SerializeField]
	private float _debugCameraDepth; // 0x60
	[SerializeField]
	private string _apiKey; // 0x68
	[SerializeField]
	private bool _enableBugReporter; // 0x70
	[SerializeField]
	private DefaultTabs[] _disabledTabs; // 0x78
	[SerializeField]
	private PinAlignment _profilerAlignment; // 0x80
	[SerializeField]
	private PinAlignment _optionsAlignment; // 0x84
	[SerializeField]
	private ConsoleAlignment _consoleAlignment; // 0x88
	[SerializeField]
	private PinAlignment _triggerPosition; // 0x8C
	[SerializeField]
	private int _maximumConsoleEntries; // 0x90
	[SerializeField]
	private bool _enableEventSystemCreation; // 0x94
	[SerializeField]
	private bool _automaticShowCursor; // 0x95

	// Properties
	public static Settings Instance { get; }
	public bool IsEnabled { get; }
	public bool AutoLoad { get; }
	public DefaultTabs DefaultTab { get; }
	public Settings.TriggerEnableModes EnableTrigger { get; }
	public Settings.TriggerBehaviours TriggerBehaviour { get; }
	public bool EnableKeyboardShortcuts { get; }
	public IList<Settings.KeyboardShortcut> KeyboardShortcuts { get; }
	public bool KeyboardEscapeClose { get; }
	public bool EnableBackgroundTransparency { get; }
	public bool RequireCode { get; }
	public bool RequireEntryCodeEveryTime { get; }
	public IList<int> EntryCode { get; set; }
	public bool UseDebugCamera { get; }
	public int DebugLayer { get; }
	public float DebugCameraDepth { get; }
	public bool CollapseDuplicateLogEntries { get; }
	public bool RichTextInConsole { get; }
	public string ApiKey { get; }
	public bool EnableBugReporter { get; }
	public IList<DefaultTabs> DisabledTabs { get; }
	public PinAlignment TriggerPosition { get; }
	public PinAlignment ProfilerAlignment { get; }
	public PinAlignment OptionsAlignment { get; }
	public ConsoleAlignment ConsoleAlignment { get; set; }
	public int MaximumConsoleEntries { get; set; }
	public bool EnableEventSystemGeneration { get; set; }
	public bool AutomaticallyShowCursor { get; }

	// Methods

	// RVA: 0x7F91EB4 Offset: 0x7F8DEB4 VA: 0x7F91EB4
	public static Settings get_Instance() { }

	// RVA: 0x7F92868 Offset: 0x7F8E868 VA: 0x7F92868
	private static Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts() { }

	// RVA: 0x7F92630 Offset: 0x7F8E630 VA: 0x7F92630
	private void UpgradeKeyboardShortcuts() { }

	// RVA: 0x7F92A1C Offset: 0x7F8EA1C VA: 0x7F92A1C
	public bool get_IsEnabled() { }

	// RVA: 0x7F92A24 Offset: 0x7F8EA24 VA: 0x7F92A24
	public bool get_AutoLoad() { }

	// RVA: 0x7F92A2C Offset: 0x7F8EA2C VA: 0x7F92A2C
	public DefaultTabs get_DefaultTab() { }

	// RVA: 0x7F92A34 Offset: 0x7F8EA34 VA: 0x7F92A34
	public Settings.TriggerEnableModes get_EnableTrigger() { }

	// RVA: 0x7F92A3C Offset: 0x7F8EA3C VA: 0x7F92A3C
	public Settings.TriggerBehaviours get_TriggerBehaviour() { }

	// RVA: 0x7F92A44 Offset: 0x7F8EA44 VA: 0x7F92A44
	public bool get_EnableKeyboardShortcuts() { }

	// RVA: 0x7F92A4C Offset: 0x7F8EA4C VA: 0x7F92A4C
	public IList<Settings.KeyboardShortcut> get_KeyboardShortcuts() { }

	// RVA: 0x7F92A54 Offset: 0x7F8EA54 VA: 0x7F92A54
	public bool get_KeyboardEscapeClose() { }

	// RVA: 0x7F92A5C Offset: 0x7F8EA5C VA: 0x7F92A5C
	public bool get_EnableBackgroundTransparency() { }

	// RVA: 0x7F92A64 Offset: 0x7F8EA64 VA: 0x7F92A64
	public bool get_RequireCode() { }

	// RVA: 0x7F92A6C Offset: 0x7F8EA6C VA: 0x7F92A6C
	public bool get_RequireEntryCodeEveryTime() { }

	// RVA: 0x7F92A74 Offset: 0x7F8EA74 VA: 0x7F92A74
	public IList<int> get_EntryCode() { }

	// RVA: 0x7F92AF0 Offset: 0x7F8EAF0 VA: 0x7F92AF0
	public void set_EntryCode(IList<int> value) { }

	// RVA: 0x7F92D0C Offset: 0x7F8ED0C VA: 0x7F92D0C
	public bool get_UseDebugCamera() { }

	// RVA: 0x7F92D14 Offset: 0x7F8ED14 VA: 0x7F92D14
	public int get_DebugLayer() { }

	// RVA: 0x7F92D1C Offset: 0x7F8ED1C VA: 0x7F92D1C
	public float get_DebugCameraDepth() { }

	// RVA: 0x7F92D24 Offset: 0x7F8ED24 VA: 0x7F92D24
	public bool get_CollapseDuplicateLogEntries() { }

	// RVA: 0x7F92D2C Offset: 0x7F8ED2C VA: 0x7F92D2C
	public bool get_RichTextInConsole() { }

	// RVA: 0x7F92D34 Offset: 0x7F8ED34 VA: 0x7F92D34
	public string get_ApiKey() { }

	// RVA: 0x7F92D3C Offset: 0x7F8ED3C VA: 0x7F92D3C
	public bool get_EnableBugReporter() { }

	// RVA: 0x7F92D44 Offset: 0x7F8ED44 VA: 0x7F92D44
	public IList<DefaultTabs> get_DisabledTabs() { }

	// RVA: 0x7F92D4C Offset: 0x7F8ED4C VA: 0x7F92D4C
	public PinAlignment get_TriggerPosition() { }

	// RVA: 0x7F92D54 Offset: 0x7F8ED54 VA: 0x7F92D54
	public PinAlignment get_ProfilerAlignment() { }

	// RVA: 0x7F92D5C Offset: 0x7F8ED5C VA: 0x7F92D5C
	public PinAlignment get_OptionsAlignment() { }

	// RVA: 0x7F92D64 Offset: 0x7F8ED64 VA: 0x7F92D64
	public ConsoleAlignment get_ConsoleAlignment() { }

	// RVA: 0x7F92D6C Offset: 0x7F8ED6C VA: 0x7F92D6C
	public void set_ConsoleAlignment(ConsoleAlignment value) { }

	// RVA: 0x7F92D74 Offset: 0x7F8ED74 VA: 0x7F92D74
	public int get_MaximumConsoleEntries() { }

	// RVA: 0x7F92D7C Offset: 0x7F8ED7C VA: 0x7F92D7C
	public void set_MaximumConsoleEntries(int value) { }

	// RVA: 0x7F92D84 Offset: 0x7F8ED84 VA: 0x7F92D84
	public bool get_EnableEventSystemGeneration() { }

	// RVA: 0x7F92D8C Offset: 0x7F8ED8C VA: 0x7F92D8C
	public void set_EnableEventSystemGeneration(bool value) { }

	// RVA: 0x7F92D98 Offset: 0x7F8ED98 VA: 0x7F92D98
	public bool get_AutomaticallyShowCursor() { }

	// RVA: 0x7F92560 Offset: 0x7F8E560 VA: 0x7F92560
	private static Settings GetOrCreateInstance() { }

	// RVA: 0x7F92DA0 Offset: 0x7F8EDA0 VA: 0x7F92DA0
	public void .ctor() { }
}

// Namespace: SRDebugger
[AddComponentMenu("SRDebugger Init")]
public class SRDebuggerInit : SRMonoBehaviourEx // TypeDefIndex: 23751
{
	// Methods

	// RVA: 0x7F92F3C Offset: 0x7F8EF3C VA: 0x7F92F3C Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F92F6C Offset: 0x7F8EF6C VA: 0x7F92F6C Slot: 5
	protected override void Start() { }

	// RVA: 0x7F92FD4 Offset: 0x7F8EFD4 VA: 0x7F92FD4
	public void .ctor() { }
}

// Namespace: SRDebugger
public static class VersionInfo // TypeDefIndex: 23752
{
	// Fields
	public const string Version = "1.6.2";
}

// Namespace: SRDebugger.Scripts
public class DebuggerTabController : SRMonoBehaviourEx // TypeDefIndex: 23753
{
	// Fields
	private SRTab _aboutTabInstance; // 0x50
	private Nullable<DefaultTabs> _activeTab; // 0x58
	private bool _hasStarted; // 0x60
	public SRTab AboutTab; // 0x68
	[RequiredField]
	public SRTabController TabController; // 0x70

	// Properties
	public Nullable<DefaultTabs> ActiveTab { get; }

	// Methods

	// RVA: 0x7F92FDC Offset: 0x7F8EFDC VA: 0x7F92FDC
	public Nullable<DefaultTabs> get_ActiveTab() { }

	// RVA: 0x7F9315C Offset: 0x7F8F15C VA: 0x7F9315C Slot: 5
	protected override void Start() { }

	// RVA: 0x7F93670 Offset: 0x7F8F670 VA: 0x7F93670
	public bool OpenTab(DefaultTabs tab) { }

	// RVA: 0x7F93A2C Offset: 0x7F8FA2C VA: 0x7F93A2C
	public void ShowAboutTab() { }

	// RVA: 0x7F93AB4 Offset: 0x7F8FAB4 VA: 0x7F93AB4
	public void .ctor() { }
}

// Namespace: SRDebugger.UI
public class ProfilerFPSLabel : SRMonoBehaviourEx // TypeDefIndex: 23754
{
	// Fields
	private float _nextUpdate; // 0x50
	[Import]
	private IProfilerService _profilerService; // 0x58
	public float UpdateFrequency; // 0x60
	[RequiredField]
	[SerializeField]
	private Text _text; // 0x68

	// Methods

	// RVA: 0x7F93ABC Offset: 0x7F8FABC VA: 0x7F93ABC Slot: 6
	protected override void Update() { }

	// RVA: 0x7F93AEC Offset: 0x7F8FAEC VA: 0x7F93AEC
	private void Refresh() { }

	// RVA: 0x7F93C90 Offset: 0x7F8FC90 VA: 0x7F93C90
	public void .ctor() { }
}

// Namespace: SRDebugger.UI
public class DebugPanelRoot : SRMonoBehaviourEx // TypeDefIndex: 23755
{
	// Fields
	[RequiredField]
	public Canvas Canvas; // 0x50
	[RequiredField]
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredField]
	public DebuggerTabController TabController; // 0x60

	// Methods

	// RVA: 0x7F93CA0 Offset: 0x7F8FCA0 VA: 0x7F93CA0
	public void Close() { }

	// RVA: 0x7F93D5C Offset: 0x7F8FD5C VA: 0x7F93D5C
	public void CloseAndDestroy() { }

	// RVA: 0x7F93E18 Offset: 0x7F8FE18 VA: 0x7F93E18
	public void .ctor() { }
}

// Namespace: SRDebugger.UI
public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 23756
{
	// Fields
	private Button _closeButton; // 0x50
	[SerializeField]
	private float _maxMenuWidth; // 0x58
	[SerializeField]
	private float _peekAmount; // 0x5C
	private float _targetXPosition; // 0x60
	[RequiredField]
	public RectTransform Content; // 0x68
	[RequiredField]
	public RectTransform Menu; // 0x70
	[RequiredField]
	public Button OpenButton; // 0x78
	[RequiredField]
	public SRTabController TabController; // 0x80

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x7F93E20 Offset: 0x7F8FE20 VA: 0x7F93E20
	public float get_PeekAmount() { }

	// RVA: 0x7F93E28 Offset: 0x7F8FE28 VA: 0x7F93E28
	public float get_MaxMenuWidth() { }

	// RVA: 0x7F93E30 Offset: 0x7F8FE30 VA: 0x7F93E30 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F94488 Offset: 0x7F90488 VA: 0x7F94488 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x7F9406C Offset: 0x7F9006C VA: 0x7F9406C
	private void CreateCloseButton() { }

	// RVA: 0x7F945AC Offset: 0x7F905AC VA: 0x7F945AC
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x7F9463C Offset: 0x7F9063C VA: 0x7F9463C
	private void CloseButtonClicked() { }

	// RVA: 0x7F94674 Offset: 0x7F90674 VA: 0x7F94674 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F94734 Offset: 0x7F90734 VA: 0x7F94734
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu("Open")]
	// RVA: 0x7F94738 Offset: 0x7F90738 VA: 0x7F94738
	public void Open() { }

	[ContextMenu("Close")]
	// RVA: 0x7F94640 Offset: 0x7F90640 VA: 0x7F94640
	public void Close() { }

	// RVA: 0x7F9477C Offset: 0x7F9077C VA: 0x7F9477C
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Tabs
public class BugReportTabController : SRMonoBehaviourEx, IEnableTab // TypeDefIndex: 23757
{
	// Fields
	[RequiredField]
	public BugReportSheetController BugReportSheetPrefab; // 0x50
	[RequiredField]
	public RectTransform Container; // 0x58

	// Properties
	public bool IsEnabled { get; }

	// Methods

	// RVA: 0x7F94790 Offset: 0x7F90790 VA: 0x7F94790 Slot: 11
	public bool get_IsEnabled() { }

	// RVA: 0x7F947AC Offset: 0x7F907AC VA: 0x7F947AC Slot: 5
	protected override void Start() { }

	// RVA: 0x7F948C4 Offset: 0x7F908C4 VA: 0x7F948C4
	private void TakingScreenshot() { }

	// RVA: 0x7F94960 Offset: 0x7F90960 VA: 0x7F94960
	private void ScreenshotComplete() { }

	// RVA: 0x7F94A00 Offset: 0x7F90A00 VA: 0x7F94A00
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Tabs
public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 23758
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x50
	private bool _isDirty; // 0x58
	[RequiredField]
	public ConsoleLogControl ConsoleLogControl; // 0x60
	[RequiredField]
	public Toggle PinToggle; // 0x68
	[RequiredField]
	public ScrollRect StackTraceScrollRect; // 0x70
	[RequiredField]
	public Text StackTraceText; // 0x78
	[RequiredField]
	public Toggle ToggleErrors; // 0x80
	[RequiredField]
	public Text ToggleErrorsText; // 0x88
	[RequiredField]
	public Toggle ToggleInfo; // 0x90
	[RequiredField]
	public Text ToggleInfoText; // 0x98
	[RequiredField]
	public Toggle ToggleWarnings; // 0xA0
	[RequiredField]
	public Text ToggleWarningsText; // 0xA8
	[RequiredField]
	public Toggle FilterToggle; // 0xB0
	[RequiredField]
	public InputField FilterField; // 0xB8
	[RequiredField]
	public GameObject FilterBarContainer; // 0xC0

	// Methods

	// RVA: 0x7F94A08 Offset: 0x7F90A08 VA: 0x7F94A08 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F95388 Offset: 0x7F91388 VA: 0x7F95388
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x7F953F8 Offset: 0x7F913F8 VA: 0x7F953F8
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x7F95474 Offset: 0x7F91474 VA: 0x7F95474
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x7F9550C Offset: 0x7F9150C VA: 0x7F9550C
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x7F955BC Offset: 0x7F915BC VA: 0x7F955BC Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x7F956CC Offset: 0x7F916CC VA: 0x7F956CC Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F956D8 Offset: 0x7F916D8 VA: 0x7F956D8
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x7F95758 Offset: 0x7F91758 VA: 0x7F95758 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F94EE4 Offset: 0x7F90EE4 VA: 0x7F94EE4
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x7F9506C Offset: 0x7F9106C VA: 0x7F9506C
	private void Refresh() { }

	// RVA: 0x7F95768 Offset: 0x7F91768 VA: 0x7F95768
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x7F95774 Offset: 0x7F91774 VA: 0x7F95774
	public void Clear() { }

	// RVA: 0x7F9582C Offset: 0x7F9182C VA: 0x7F9582C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7F95834 Offset: 0x7F91834 VA: 0x7F95834
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0x7F95840 Offset: 0x7F91840 VA: 0x7F95840
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0x7F9584C Offset: 0x7F9184C VA: 0x7F9584C
	private void <Start>b__16_2(bool isOn) { }
}

// Namespace: SRDebugger.UI.Tabs
public class InfoTabController : SRMonoBehaviourEx // TypeDefIndex: 23759
{
	// Fields
	public const char Tick = '\x2713';
	public const char Cross = '\xd7';
	public const string NameColor = "#BCBCBC";
	private Dictionary<string, InfoBlock> _infoBlocks; // 0x50
	[RequiredField]
	public InfoBlock InfoBlockPrefab; // 0x58
	[RequiredField]
	public RectTransform LayoutContainer; // 0x60

	// Methods

	// RVA: 0x7F95858 Offset: 0x7F91858 VA: 0x7F95858 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9585C Offset: 0x7F9185C VA: 0x7F9585C
	public void Refresh() { }

	// RVA: 0x7F95E58 Offset: 0x7F91E58 VA: 0x7F95E58
	private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info) { }

	// RVA: 0x7F95DB8 Offset: 0x7F91DB8 VA: 0x7F95DB8
	private InfoBlock CreateBlock(string title) { }

	// RVA: 0x7F96658 Offset: 0x7F92658 VA: 0x7F96658
	public void .ctor() { }
}

// Namespace: 
private class OptionsTabController.CategoryInstance // TypeDefIndex: 23760
{
	// Fields
	[CompilerGenerated]
	private CategoryGroup <CategoryGroup>k__BackingField; // 0x10
	public readonly List<OptionsControlBase> Options; // 0x18

	// Properties
	public CategoryGroup CategoryGroup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F98B6C Offset: 0x7F94B6C VA: 0x7F98B6C
	public CategoryGroup get_CategoryGroup() { }

	[CompilerGenerated]
	// RVA: 0x7F98B74 Offset: 0x7F94B74 VA: 0x7F98B74
	private void set_CategoryGroup(CategoryGroup value) { }

	// RVA: 0x7F98B7C Offset: 0x7F94B7C VA: 0x7F98B7C
	public void .ctor(CategoryGroup group) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OptionsTabController.<>c // TypeDefIndex: 23761
{
	// Fields
	public static readonly OptionsTabController.<>c <>9; // 0x0
	public static Comparison<OptionDefinition> <>9__30_0; // 0x8

	// Methods

	// RVA: 0x7F98C18 Offset: 0x7F94C18 VA: 0x7F98C18
	private static void .cctor() { }

	// RVA: 0x7F98C80 Offset: 0x7F94C80 VA: 0x7F98C80
	public void .ctor() { }

	// RVA: 0x7F98C88 Offset: 0x7F94C88 VA: 0x7F98C88
	internal int <CreateCategory>b__30_0(OptionDefinition d1, OptionDefinition d2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OptionsTabController.<>c__DisplayClass30_0 // TypeDefIndex: 23762
{
	// Fields
	public OptionsTabController <>4__this; // 0x10
	public OptionsTabController.CategoryInstance categoryInstance; // 0x18

	// Methods

	// RVA: 0x7F98CB8 Offset: 0x7F94CB8 VA: 0x7F98CB8
	public void .ctor() { }

	// RVA: 0x7F98CC0 Offset: 0x7F94CC0 VA: 0x7F98CC0
	internal void <CreateCategory>b__1(bool b) { }
}

// Namespace: SRDebugger.UI.Tabs
public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 23763
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x50
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x58
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x60
	private bool _queueRefresh; // 0x68
	private bool _selectionModeEnabled; // 0x69
	private Canvas _optionCanvas; // 0x70
	[RequiredField]
	public ActionControl ActionControlPrefab; // 0x78
	[RequiredField]
	public CategoryGroup CategoryGroupPrefab; // 0x80
	[RequiredField]
	public RectTransform ContentContainer; // 0x88
	[RequiredField]
	public GameObject NoOptionsNotice; // 0x90
	[RequiredField]
	public Toggle PinButton; // 0x98
	[RequiredField]
	public GameObject PinPromptSpacer; // 0xA0
	[RequiredField]
	public GameObject PinPromptText; // 0xA8
	private bool _isTogglingCategory; // 0xB0

	// Methods

	// RVA: 0x7F966E0 Offset: 0x7F926E0 VA: 0x7F966E0 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F9707C Offset: 0x7F9307C VA: 0x7F9707C
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x7F9712C Offset: 0x7F9312C VA: 0x7F9712C
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x7F97370 Offset: 0x7F93370 VA: 0x7F97370
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x7F9737C Offset: 0x7F9337C VA: 0x7F9737C Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9747C Offset: 0x7F9347C VA: 0x7F9747C Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x7F9793C Offset: 0x7F9393C VA: 0x7F9793C Slot: 6
	protected override void Update() { }

	// RVA: 0x7F97ADC Offset: 0x7F93ADC VA: 0x7F97ADC
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x7F97598 Offset: 0x7F93598 VA: 0x7F97598
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x7F97950 Offset: 0x7F93950 VA: 0x7F97950
	private void Refresh() { }

	// RVA: 0x7F97D94 Offset: 0x7F93D94 VA: 0x7F97D94
	private void CommitPinnedOptions() { }

	// RVA: 0x7F97B98 Offset: 0x7F93B98 VA: 0x7F97B98
	private void RefreshCategorySelection() { }

	// RVA: 0x7F98154 Offset: 0x7F94154 VA: 0x7F98154
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x7F9817C Offset: 0x7F9417C VA: 0x7F9817C
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x7F96A28 Offset: 0x7F92A28 VA: 0x7F96A28
	protected void Populate() { }

	// RVA: 0x7F98234 Offset: 0x7F94234 VA: 0x7F98234
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x7F97144 Offset: 0x7F93144 VA: 0x7F97144
	private void Clear() { }

	// RVA: 0x7F98A3C Offset: 0x7F94A3C VA: 0x7F98A3C
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Tabs
public class ProfilerTabController : SRMonoBehaviourEx // TypeDefIndex: 23764
{
	// Fields
	private bool _isDirty; // 0x50
	[RequiredField]
	public Toggle PinToggle; // 0x58

	// Methods

	// RVA: 0x7F98CEC Offset: 0x7F94CEC VA: 0x7F98CEC Slot: 5
	protected override void Start() { }

	// RVA: 0x7F98E70 Offset: 0x7F94E70 VA: 0x7F98E70
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x7F98F20 Offset: 0x7F94F20 VA: 0x7F98F20 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F98F40 Offset: 0x7F94F40 VA: 0x7F98F40 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F98DA4 Offset: 0x7F94DA4 VA: 0x7F98DA4
	private void Refresh() { }

	// RVA: 0x7F98F6C Offset: 0x7F94F6C VA: 0x7F98F6C
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class BugReportPopoverRoot : SRMonoBehaviourEx // TypeDefIndex: 23765
{
	// Fields
	[RequiredField]
	public CanvasGroup CanvasGroup; // 0x50
	[RequiredField]
	public RectTransform Container; // 0x58

	// Methods

	// RVA: 0x7F98F74 Offset: 0x7F94F74 VA: 0x7F98F74
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BugReportSheetController.<SubmitCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23766
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BugReportSheetController <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7F99378 Offset: 0x7F95378 VA: 0x7F99378
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F9961C Offset: 0x7F9561C VA: 0x7F9961C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F99620 Offset: 0x7F95620 VA: 0x7F99620 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F99BC4 Offset: 0x7F95BC4 VA: 0x7F99BC4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F99BCC Offset: 0x7F95BCC VA: 0x7F99BCC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F99C04 Offset: 0x7F95C04 VA: 0x7F99C04 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.UI.Other
public class BugReportSheetController : SRMonoBehaviourEx // TypeDefIndex: 23767
{
	// Fields
	[RequiredField]
	public GameObject ButtonContainer; // 0x50
	[RequiredField]
	public Text ButtonText; // 0x58
	[RequiredField]
	public Button CancelButton; // 0x60
	public Action CancelPressed; // 0x68
	[RequiredField]
	public InputField DescriptionField; // 0x70
	[RequiredField]
	public InputField EmailField; // 0x78
	[RequiredField]
	public Slider ProgressBar; // 0x80
	[RequiredField]
	public Text ResultMessageText; // 0x88
	public Action ScreenshotComplete; // 0x90
	[RequiredField]
	public Button SubmitButton; // 0x98
	public Action<bool, string> SubmitComplete; // 0xA0
	public Action TakingScreenshot; // 0xA8

	// Properties
	public bool IsCancelButtonEnabled { get; set; }

	// Methods

	// RVA: 0x7F98F7C Offset: 0x7F94F7C VA: 0x7F98F7C
	public bool get_IsCancelButtonEnabled() { }

	// RVA: 0x7F98FA4 Offset: 0x7F94FA4 VA: 0x7F98FA4
	public void set_IsCancelButtonEnabled(bool value) { }

	// RVA: 0x7F98FD4 Offset: 0x7F94FD4 VA: 0x7F98FD4 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F99144 Offset: 0x7F95144 VA: 0x7F99144
	public void Submit() { }

	// RVA: 0x7F9935C Offset: 0x7F9535C VA: 0x7F9935C
	public void Cancel() { }

	[IteratorStateMachine(typeof(BugReportSheetController.<SubmitCo>d__18))]
	// RVA: 0x7F992F0 Offset: 0x7F952F0 VA: 0x7F992F0
	private IEnumerator SubmitCo() { }

	// RVA: 0x7F993A0 Offset: 0x7F953A0 VA: 0x7F993A0
	private void OnBugReportProgress(float progress) { }

	// RVA: 0x7F993C4 Offset: 0x7F953C4 VA: 0x7F993C4
	private void OnBugReportComplete(bool didSucceed, string errorMessage) { }

	// RVA: 0x7F99004 Offset: 0x7F95004 VA: 0x7F99004
	protected void SetLoadingSpinnerVisible(bool visible) { }

	// RVA: 0x7F990D4 Offset: 0x7F950D4 VA: 0x7F990D4
	protected void ClearForm() { }

	// RVA: 0x7F99490 Offset: 0x7F95490 VA: 0x7F99490
	protected void ShowErrorMessage(string userMessage, string serverMessage) { }

	// RVA: 0x7F99058 Offset: 0x7F95058 VA: 0x7F99058
	protected void ClearErrorMessage() { }

	// RVA: 0x7F99228 Offset: 0x7F95228 VA: 0x7F99228
	protected void SetFormEnabled(bool e) { }

	// RVA: 0x7F995B8 Offset: 0x7F955B8 VA: 0x7F995B8
	private string GetDefaultEmailFieldContents() { }

	// RVA: 0x7F9929C Offset: 0x7F9529C VA: 0x7F9929C
	private void SetDefaultEmailFieldContents(string value) { }

	// RVA: 0x7F99614 Offset: 0x7F95614 VA: 0x7F99614
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class CategoryGroup : SRMonoBehaviourEx // TypeDefIndex: 23768
{
	// Fields
	[RequiredField]
	public RectTransform Container; // 0x50
	[RequiredField]
	public Text Header; // 0x58
	[RequiredField]
	public GameObject Background; // 0x60
	[RequiredField]
	public Toggle SelectionToggle; // 0x68
	public GameObject[] EnabledDuringSelectionMode; // 0x70
	private bool _selectionModeEnabled; // 0x78

	// Properties
	public bool IsSelected { get; set; }
	public bool SelectionModeEnabled { get; set; }

	// Methods

	// RVA: 0x7F99C0C Offset: 0x7F95C0C VA: 0x7F99C0C
	public bool get_IsSelected() { }

	// RVA: 0x7F99C28 Offset: 0x7F95C28 VA: 0x7F99C28
	public void set_IsSelected(bool value) { }

	// RVA: 0x7F99D04 Offset: 0x7F95D04 VA: 0x7F99D04
	public bool get_SelectionModeEnabled() { }

	// RVA: 0x7F99D0C Offset: 0x7F95D0C VA: 0x7F99D0C
	public void set_SelectionModeEnabled(bool value) { }

	// RVA: 0x7F99D84 Offset: 0x7F95D84 VA: 0x7F99D84
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
[RequireComponent(typeof(Canvas))]
public class ConfigureCanvasFromSettings : SRMonoBehaviour // TypeDefIndex: 23769
{
	// Methods

	// RVA: 0x7F99DF0 Offset: 0x7F95DF0 VA: 0x7F99DF0
	private void Start() { }

	// RVA: 0x7F99E78 Offset: 0x7F95E78 VA: 0x7F99E78
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class ConsoleTabQuickViewControl : SRMonoBehaviourEx // TypeDefIndex: 23770
{
	// Fields
	private const int Max = 1000;
	private static readonly string MaxString; // 0x0
	private int _prevErrorCount; // 0x50
	private int _prevInfoCount; // 0x54
	private int _prevWarningCount; // 0x58
	[Import]
	public IConsoleService ConsoleService; // 0x60
	[RequiredField]
	public Text ErrorCountText; // 0x68
	[RequiredField]
	public Text InfoCountText; // 0x70
	[RequiredField]
	public Text WarningCountText; // 0x78

	// Methods

	// RVA: 0x7F99E80 Offset: 0x7F95E80 VA: 0x7F99E80 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F99F20 Offset: 0x7F95F20 VA: 0x7F99F20 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9A3B0 Offset: 0x7F963B0 VA: 0x7F9A3B0
	private static bool HasChanged(int newCount, ref int oldCount, int max) { }

	// RVA: 0x7F9A3E8 Offset: 0x7F963E8 VA: 0x7F9A3E8
	public void .ctor() { }

	// RVA: 0x7F9A400 Offset: 0x7F96400 VA: 0x7F9A400
	private static void .cctor() { }
}

// Namespace: SRDebugger.UI.Other
[RequireComponent(typeof(StyleComponent))]
public class DebugPanelBackgroundBehaviour : SRMonoBehaviour // TypeDefIndex: 23771
{
	// Fields
	private string _defaultKey; // 0x50
	private bool _isTransparent; // 0x58
	private StyleComponent _styleComponent; // 0x60
	public string TransparentStyleKey; // 0x68

	// Methods

	// RVA: 0x7F9A494 Offset: 0x7F96494 VA: 0x7F9A494
	private void Awake() { }

	// RVA: 0x7F9A514 Offset: 0x7F96514 VA: 0x7F9A514
	private void Update() { }

	// RVA: 0x7F9A59C Offset: 0x7F9659C VA: 0x7F9A59C
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 23772
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x50
	private bool _isDragging; // 0x51
	private int _pointersOver; // 0x54
	[RequiredField]
	public GameObject BottomHandle; // 0x58
	[RequiredField]
	public CanvasGroup CanvasGroup; // 0x60
	[RequiredField]
	public ConsoleLogControl Console; // 0x68
	[RequiredField]
	public GameObject Dropdown; // 0x70
	[RequiredField]
	public Image DropdownToggleSprite; // 0x78
	[RequiredField]
	public Text TextErrors; // 0x80
	[RequiredField]
	public Text TextInfo; // 0x88
	[RequiredField]
	public Text TextWarnings; // 0x90
	[RequiredField]
	public Toggle ToggleErrors; // 0x98
	[RequiredField]
	public Toggle ToggleInfo; // 0xA0
	[RequiredField]
	public Toggle ToggleWarnings; // 0xA8
	[RequiredField]
	public GameObject TopBar; // 0xB0
	[RequiredField]
	public GameObject TopHandle; // 0xB8

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x7F9A5F4 Offset: 0x7F965F4 VA: 0x7F9A5F4
	public bool get_IsVisible() { }

	// RVA: 0x7F9A614 Offset: 0x7F96614 VA: 0x7F9A614
	public void set_IsVisible(bool value) { }

	// RVA: 0x7F9A63C Offset: 0x7F9663C VA: 0x7F9A63C Slot: 5
	protected override void Start() { }

	// RVA: 0x7F9AAD8 Offset: 0x7F96AD8 VA: 0x7F9AAD8 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x7F9ABF0 Offset: 0x7F96BF0 VA: 0x7F9ABF0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9AC14 Offset: 0x7F96C14 VA: 0x7F9AC14 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x7F9AC30 Offset: 0x7F96C30 VA: 0x7F9AC30 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9AC5C Offset: 0x7F96C5C VA: 0x7F9AC5C
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x7F9AC68 Offset: 0x7F96C68 VA: 0x7F9AC68
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x7F9ACE0 Offset: 0x7F96CE0 VA: 0x7F9ACE0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x7F9A85C Offset: 0x7F9685C VA: 0x7F9A85C
	private void Refresh() { }

	// RVA: 0x7F9AA90 Offset: 0x7F96A90 VA: 0x7F9AA90
	private void RefreshAlpha() { }

	// RVA: 0x7F9AE84 Offset: 0x7F96E84 VA: 0x7F9AE84
	public void ToggleDropdownVisible() { }

	// RVA: 0x7F9AEB4 Offset: 0x7F96EB4 VA: 0x7F9AEB4
	public void MenuButtonPressed() { }

	// RVA: 0x7F9AF5C Offset: 0x7F96F5C VA: 0x7F9AF5C
	public void ClearButtonPressed() { }

	// RVA: 0x7F9AFFC Offset: 0x7F96FFC VA: 0x7F9AFFC
	public void TogglesUpdated() { }

	// RVA: 0x7F9B098 Offset: 0x7F97098 VA: 0x7F9B098 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x7F9B0A4 Offset: 0x7F970A4 VA: 0x7F9B0A4 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x7F9B0AC Offset: 0x7F970AC VA: 0x7F9B0AC
	public void OnBeginDrag() { }

	// RVA: 0x7F9B0B8 Offset: 0x7F970B8 VA: 0x7F9B0B8
	public void OnEndDrag() { }

	// RVA: 0x7F9B0C4 Offset: 0x7F970C4 VA: 0x7F9B0C4
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class HandleManager : SRMonoBehaviour // TypeDefIndex: 23773
{
	// Fields
	private bool _hasSet; // 0x50
	public GameObject BottomHandle; // 0x58
	public GameObject BottomLeftHandle; // 0x60
	public GameObject BottomRightHandle; // 0x68
	public PinAlignment DefaultAlignment; // 0x70
	public GameObject LeftHandle; // 0x78
	public GameObject RightHandle; // 0x80
	public GameObject TopHandle; // 0x88
	public GameObject TopLeftHandle; // 0x90
	public GameObject TopRightHandle; // 0x98

	// Methods

	// RVA: 0x7F9B0CC Offset: 0x7F970CC VA: 0x7F9B0CC
	private void Start() { }

	// RVA: 0x7F9B0E0 Offset: 0x7F970E0 VA: 0x7F9B0E0
	public void SetAlignment(PinAlignment alignment) { }

	// RVA: 0x7F9B27C Offset: 0x7F9727C VA: 0x7F9B27C
	private void SetActive(GameObject obj, bool active) { }

	// RVA: 0x7F9B310 Offset: 0x7F97310 VA: 0x7F9B310
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public interface IEnableTab // TypeDefIndex: 23774
{
	// Properties
	public abstract bool IsEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsEnabled();
}

// Namespace: SRDebugger.UI.Other
public class LoadingSpinnerBehaviour : SRMonoBehaviour // TypeDefIndex: 23775
{
	// Fields
	private float _dt; // 0x50
	public int FrameCount; // 0x54
	public float SpinDuration; // 0x58

	// Methods

	// RVA: 0x7F9B318 Offset: 0x7F97318 VA: 0x7F9B318
	private void Update() { }

	// RVA: 0x7F9B424 Offset: 0x7F97424 VA: 0x7F9B424
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class PinnedUIRoot : SRMonoBehaviourEx // TypeDefIndex: 23776
{
	// Fields
	[RequiredField]
	public Canvas Canvas; // 0x50
	[RequiredField]
	public RectTransform Container; // 0x58
	[RequiredField]
	public DockConsoleController DockConsoleController; // 0x60
	[RequiredField]
	public GameObject Options; // 0x68
	[RequiredField]
	public FlowLayoutGroup OptionsLayoutGroup; // 0x70
	[RequiredField]
	public GameObject Profiler; // 0x78
	[RequiredField]
	public HandleManager ProfilerHandleManager; // 0x80
	[RequiredField]
	public VerticalLayoutGroup ProfilerVerticalLayoutGroup; // 0x88

	// Methods

	// RVA: 0x7F9B43C Offset: 0x7F9743C VA: 0x7F9B43C
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
[RequireComponent(typeof(ScrollRect))]
[ExecuteInEditMode]
public class ScrollRectPatch : MonoBehaviour // TypeDefIndex: 23777
{
	// Fields
	public RectTransform Content; // 0x20
	public Mask ReplaceMask; // 0x28
	public RectTransform Viewport; // 0x30

	// Methods

	// RVA: 0x7F9B444 Offset: 0x7F97444 VA: 0x7F9B444
	private void Awake() { }

	// RVA: 0x7F9B5A8 Offset: 0x7F975A8 VA: 0x7F9B5A8
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
[RequireComponent(typeof(ScrollRect))]
public class ScrollSettingsBehaviour : MonoBehaviour // TypeDefIndex: 23778
{
	// Fields
	public const float ScrollSensitivity = 40;

	// Methods

	// RVA: 0x7F9B5B0 Offset: 0x7F975B0 VA: 0x7F9B5B0
	private void Awake() { }

	// RVA: 0x7F9B628 Offset: 0x7F97628 VA: 0x7F9B628
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class SetLayerFromSettings : SRMonoBehaviour // TypeDefIndex: 23779
{
	// Methods

	// RVA: 0x7F9B630 Offset: 0x7F97630 VA: 0x7F9B630
	private void Start() { }

	// RVA: 0x7F9B664 Offset: 0x7F97664 VA: 0x7F9B664
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class SRTab : SRMonoBehaviourEx // TypeDefIndex: 23780
{
	// Fields
	public RectTransform HeaderExtraContent; // 0x50
	[Obsolete]
	[HideInInspector]
	public Sprite Icon; // 0x58
	public RectTransform IconExtraContent; // 0x60
	public string IconStyleKey; // 0x68
	public int SortIndex; // 0x70
	[HideInInspector]
	public SRTabButton TabButton; // 0x78
	[FormerlySerializedAs("Title")]
	[SerializeField]
	private string _title; // 0x80
	[SerializeField]
	private string _longTitle; // 0x88
	[SerializeField]
	private string _key; // 0x90

	// Properties
	public string Title { get; }
	public string LongTitle { get; }
	public string Key { get; }

	// Methods

	// RVA: 0x7F9B66C Offset: 0x7F9766C VA: 0x7F9B66C
	public string get_Title() { }

	// RVA: 0x7F9B674 Offset: 0x7F97674 VA: 0x7F9B674
	public string get_LongTitle() { }

	// RVA: 0x7F9B6A4 Offset: 0x7F976A4 VA: 0x7F9B6A4
	public string get_Key() { }

	// RVA: 0x7F9B6AC Offset: 0x7F976AC VA: 0x7F9B6AC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SRTabController.<>c // TypeDefIndex: 23781
{
	// Fields
	public static readonly SRTabController.<>c <>9; // 0x0
	public static Comparison<SRTab> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x7F9C198 Offset: 0x7F98198 VA: 0x7F9C198
	private static void .cctor() { }

	// RVA: 0x7F9C200 Offset: 0x7F98200 VA: 0x7F9C200
	public void .ctor() { }

	// RVA: 0x7F9C208 Offset: 0x7F98208 VA: 0x7F9C208
	internal int <SortTabs>b__17_0(SRTab t1, SRTab t2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRTabController.<>c__DisplayClass15_0 // TypeDefIndex: 23782
{
	// Fields
	public SRTabController <>4__this; // 0x10
	public SRTab tab; // 0x18

	// Methods

	// RVA: 0x7F9BF14 Offset: 0x7F97F14 VA: 0x7F9BF14
	public void .ctor() { }

	// RVA: 0x7F9C230 Offset: 0x7F98230 VA: 0x7F9C230
	internal void <AddTab>b__0() { }
}

// Namespace: SRDebugger.UI.Other
public class SRTabController : SRMonoBehaviourEx // TypeDefIndex: 23783
{
	// Fields
	private readonly SRList<SRTab> _tabs; // 0x50
	private SRTab _activeTab; // 0x58
	[RequiredField]
	public RectTransform TabButtonContainer; // 0x60
	[RequiredField]
	public SRTabButton TabButtonPrefab; // 0x68
	[RequiredField]
	public RectTransform TabContentsContainer; // 0x70
	[RequiredField]
	public RectTransform TabHeaderContentContainer; // 0x78
	[RequiredField]
	public Text TabHeaderText; // 0x80
	[CompilerGenerated]
	private Action<SRTabController, SRTab> ActiveTabChanged; // 0x88

	// Properties
	public SRTab ActiveTab { get; set; }
	public IList<SRTab> Tabs { get; }

	// Methods

	// RVA: 0x7F9B704 Offset: 0x7F97704 VA: 0x7F9B704
	public SRTab get_ActiveTab() { }

	// RVA: 0x7F9B70C Offset: 0x7F9770C VA: 0x7F9B70C
	public void set_ActiveTab(SRTab value) { }

	// RVA: 0x7F9BA74 Offset: 0x7F97A74 VA: 0x7F9BA74
	public IList<SRTab> get_Tabs() { }

	[CompilerGenerated]
	// RVA: 0x7F9BAC4 Offset: 0x7F97AC4 VA: 0x7F9BAC4
	public void add_ActiveTabChanged(Action<SRTabController, SRTab> value) { }

	[CompilerGenerated]
	// RVA: 0x7F9BB74 Offset: 0x7F97B74 VA: 0x7F9BB74
	public void remove_ActiveTabChanged(Action<SRTabController, SRTab> value) { }

	// RVA: 0x7F9BC24 Offset: 0x7F97C24 VA: 0x7F9BC24
	public void AddTab(SRTab tab, bool visibleInSidebar = True) { }

	// RVA: 0x7F9B710 Offset: 0x7F97710 VA: 0x7F9B710
	private void MakeActive(SRTab tab) { }

	// RVA: 0x7F9BF3C Offset: 0x7F97F3C VA: 0x7F9BF3C
	private void SortTabs() { }

	// RVA: 0x7F9C110 Offset: 0x7F98110 VA: 0x7F9C110
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class TriggerRoot : SRMonoBehaviourEx // TypeDefIndex: 23784
{
	// Fields
	[RequiredField]
	public Canvas Canvas; // 0x50
	[RequiredField]
	public LongPressButton TapHoldButton; // 0x58
	[RequiredField]
	public RectTransform TriggerTransform; // 0x60
	[RequiredField]
	[FormerlySerializedAs("TriggerButton")]
	public MultiTapButton TripleTapButton; // 0x68

	// Methods

	// RVA: 0x7F9C250 Offset: 0x7F98250 VA: 0x7F9C250
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Other
public class VersionTextBehaviour : SRMonoBehaviourEx // TypeDefIndex: 23785
{
	// Fields
	public string Format; // 0x50
	[RequiredField]
	public Text Text; // 0x58

	// Methods

	// RVA: 0x7F9C258 Offset: 0x7F98258 VA: 0x7F9C258 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F9C2D0 Offset: 0x7F982D0 VA: 0x7F9C2D0
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
[RequireComponent(typeof(RectTransform))]
public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView // TypeDefIndex: 23786
{
	// Fields
	public const string ConsoleBlobInfo = "Console_Info_Blob";
	public const string ConsoleBlobWarning = "Console_Warning_Blob";
	public const string ConsoleBlobError = "Console_Error_Blob";
	private int _count; // 0x50
	private bool _hasCount; // 0x54
	private ConsoleEntry _prevData; // 0x58
	private RectTransform _rectTransform; // 0x60
	[RequiredField]
	public Text Count; // 0x68
	[RequiredField]
	public CanvasGroup CountContainer; // 0x70
	[RequiredField]
	public StyleComponent ImageStyle; // 0x78
	[RequiredField]
	public Text Message; // 0x80
	[RequiredField]
	public Text StackTrace; // 0x88

	// Methods

	// RVA: 0x7F9C328 Offset: 0x7F98328 VA: 0x7F9C328 Slot: 11
	public void SetDataContext(object data) { }

	// RVA: 0x7F9C7CC Offset: 0x7F987CC VA: 0x7F9C7CC Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9C89C Offset: 0x7F9889C VA: 0x7F9C89C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ConsoleLogControl.<ScrollToBottom>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23787
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ConsoleLogControl <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7F9CB74 Offset: 0x7F98B74 VA: 0x7F9CB74
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F9D0F8 Offset: 0x7F990F8 VA: 0x7F9D0F8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F9D0FC Offset: 0x7F990FC VA: 0x7F9D0FC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F9D280 Offset: 0x7F99280 VA: 0x7F9D280 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F9D288 Offset: 0x7F99288 VA: 0x7F9D288 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F9D2C0 Offset: 0x7F992C0 VA: 0x7F9D2C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.UI.Controls
public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 23788
{
	// Fields
	[RequiredField]
	[SerializeField]
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x50
	[RequiredField]
	[SerializeField]
	private ScrollRect _consoleScrollRect; // 0x58
	private bool _isDirty; // 0x60
	private Nullable<Vector2> _scrollPosition; // 0x64
	private bool _showErrors; // 0x70
	private bool _showInfo; // 0x71
	private bool _showWarnings; // 0x72
	public Action<ConsoleEntry> SelectedItemChanged; // 0x78
	private string _filter; // 0x80

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x7F9C8A4 Offset: 0x7F988A4 VA: 0x7F9C8A4
	public bool get_ShowErrors() { }

	// RVA: 0x7F9B05C Offset: 0x7F9705C VA: 0x7F9B05C
	public void set_ShowErrors(bool value) { }

	// RVA: 0x7F9C8B8 Offset: 0x7F988B8 VA: 0x7F9C8B8
	public bool get_ShowWarnings() { }

	// RVA: 0x7F9B070 Offset: 0x7F97070 VA: 0x7F9B070
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x7F9C8C0 Offset: 0x7F988C0 VA: 0x7F9C8C0
	public bool get_ShowInfo() { }

	// RVA: 0x7F9B084 Offset: 0x7F97084 VA: 0x7F9B084
	public void set_ShowInfo(bool value) { }

	// RVA: 0x7F9C8C8 Offset: 0x7F988C8 VA: 0x7F9C8C8
	public bool get_EnableSelection() { }

	// RVA: 0x7F9C8E4 Offset: 0x7F988E4 VA: 0x7F9C8E4
	public void set_EnableSelection(bool value) { }

	// RVA: 0x7F9C904 Offset: 0x7F98904 VA: 0x7F9C904
	public string get_Filter() { }

	// RVA: 0x7F9C90C Offset: 0x7F9890C VA: 0x7F9C90C
	public void set_Filter(string value) { }

	// RVA: 0x7F9C954 Offset: 0x7F98954 VA: 0x7F9C954 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9CAD4 Offset: 0x7F98AD4 VA: 0x7F9CAD4 Slot: 5
	protected override void Start() { }

	[IteratorStateMachine(typeof(ConsoleLogControl.<ScrollToBottom>d__26))]
	// RVA: 0x7F9CB08 Offset: 0x7F98B08 VA: 0x7F9CB08
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x7F9CB9C Offset: 0x7F98B9C VA: 0x7F9CB9C Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x7F9CCA8 Offset: 0x7F98CA8 VA: 0x7F9CCA8
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x7F9CD44 Offset: 0x7F98D44 VA: 0x7F9CD44 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9CDEC Offset: 0x7F98DEC VA: 0x7F9CDEC
	private void Refresh() { }

	// RVA: 0x7F9C8AC Offset: 0x7F988AC VA: 0x7F9C8AC
	private void SetIsDirty() { }

	// RVA: 0x7F9D0D4 Offset: 0x7F990D4 VA: 0x7F9D0D4
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x7F9D0E0 Offset: 0x7F990E0 VA: 0x7F9D0E0
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public abstract class DataBoundControl : OptionsControlBase // TypeDefIndex: 23789
{
	// Fields
	private bool _hasStarted; // 0x68
	private bool _isReadOnly; // 0x69
	private object _prevValue; // 0x70
	private PropertyReference _prop; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public PropertyReference Property { get; }
	public bool IsReadOnly { get; }
	public string PropertyName { get; set; }

	// Methods

	// RVA: 0x7F9D2C8 Offset: 0x7F992C8 VA: 0x7F9D2C8
	public PropertyReference get_Property() { }

	// RVA: 0x7F9D2D0 Offset: 0x7F992D0 VA: 0x7F9D2D0
	public bool get_IsReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x7F9D2D8 Offset: 0x7F992D8 VA: 0x7F9D2D8
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x7F9D2E0 Offset: 0x7F992E0 VA: 0x7F9D2E0
	private void set_PropertyName(string value) { }

	// RVA: 0x7F9D2E8 Offset: 0x7F992E8 VA: 0x7F9D2E8
	public void Bind(string propertyName, PropertyReference prop) { }

	// RVA: 0x7F9D370 Offset: 0x7F99370 VA: 0x7F9D370
	protected void UpdateValue(object newValue) { }

	// RVA: 0x7F9D3CC Offset: 0x7F993CC VA: 0x7F9D3CC Slot: 11
	public override void Refresh() { }

	// RVA: 0x7F9D4E4 Offset: 0x7F994E4 VA: 0x7F9D4E4 Slot: 12
	protected virtual void OnBind(string propertyName, Type t) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnValueUpdated(object newValue);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool CanBind(Type type, bool isReadOnly);

	// RVA: 0x7F9D4E8 Offset: 0x7F994E8 VA: 0x7F9D4E8 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F9D518 Offset: 0x7F99518 VA: 0x7F9D518 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9D620 Offset: 0x7F99620 VA: 0x7F9D620
	protected void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public abstract class OptionsControlBase : SRMonoBehaviourEx // TypeDefIndex: 23790
{
	// Fields
	private bool _selectionModeEnabled; // 0x50
	[RequiredField]
	public Toggle SelectionModeToggle; // 0x58
	public OptionDefinition Option; // 0x60

	// Properties
	public bool SelectionModeEnabled { get; set; }
	public bool IsSelected { get; set; }

	// Methods

	// RVA: 0x7F9D630 Offset: 0x7F99630 VA: 0x7F9D630
	public bool get_SelectionModeEnabled() { }

	// RVA: 0x7F9D638 Offset: 0x7F99638 VA: 0x7F9D638
	public void set_SelectionModeEnabled(bool value) { }

	// RVA: 0x7F9D738 Offset: 0x7F99738 VA: 0x7F9D738
	public bool get_IsSelected() { }

	// RVA: 0x7F9D754 Offset: 0x7F99754 VA: 0x7F9D754
	public void set_IsSelected(bool value) { }

	// RVA: 0x7F9D830 Offset: 0x7F99830 VA: 0x7F9D830 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9D548 Offset: 0x7F99548 VA: 0x7F9D548 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9D874 Offset: 0x7F99874 VA: 0x7F9D874 Slot: 11
	public virtual void Refresh() { }

	// RVA: 0x7F9D628 Offset: 0x7F99628 VA: 0x7F9D628
	protected void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public class InfoBlock : SRMonoBehaviourEx // TypeDefIndex: 23791
{
	// Fields
	[RequiredField]
	public Text Content; // 0x50
	[RequiredField]
	public Text Title; // 0x58

	// Methods

	// RVA: 0x7F9D878 Offset: 0x7F99878 VA: 0x7F9D878
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public class MultiTapButton : Button // TypeDefIndex: 23792
{
	// Fields
	private float _lastTap; // 0x108
	private int _tapCount; // 0x10C
	public int RequiredTapCount; // 0x110
	public float ResetTime; // 0x114

	// Methods

	// RVA: 0x7F9D880 Offset: 0x7F99880 VA: 0x7F9D880 Slot: 41
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7F9D8F4 Offset: 0x7F998F4 VA: 0x7F9D8F4
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public sealed class PinEntryControlCallback : MulticastDelegate // TypeDefIndex: 23793
{
	// Methods

	// RVA: 0x7F9D908 Offset: 0x7F99908 VA: 0x7F9D908
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F9DA14 Offset: 0x7F99A14 VA: 0x7F9DA14 Slot: 13
	public virtual void Invoke(IList<int> result, bool didCancel) { }

	// RVA: 0x7F9DA2C Offset: 0x7F99A2C VA: 0x7F9DA2C Slot: 14
	public virtual IAsyncResult BeginInvoke(IList<int> result, bool didCancel, AsyncCallback callback, object object) { }

	// RVA: 0x7F9DAC4 Offset: 0x7F99AC4 VA: 0x7F9DAC4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PinEntryControl.<>c__DisplayClass14_0 // TypeDefIndex: 23794
{
	// Fields
	public int number; // 0x10
	public PinEntryControl <>4__this; // 0x18

	// Methods

	// RVA: 0x7F9DD98 Offset: 0x7F99D98 VA: 0x7F9DD98
	public void .ctor() { }

	// RVA: 0x7F9E4D4 Offset: 0x7F9A4D4 VA: 0x7F9E4D4
	internal void <Awake>b__0() { }
}

// Namespace: SRDebugger.UI.Controls
public class PinEntryControl : SRMonoBehaviourEx // TypeDefIndex: 23795
{
	// Fields
	private bool _isVisible; // 0x50
	private List<int> _numbers; // 0x58
	[RequiredField]
	public Image Background; // 0x60
	public bool CanCancel; // 0x68
	[RequiredField]
	public Button CancelButton; // 0x70
	[RequiredField]
	public Text CancelButtonText; // 0x78
	[RequiredField]
	public CanvasGroup CanvasGroup; // 0x80
	[RequiredField]
	public Animator DotAnimator; // 0x88
	public Button[] NumberButtons; // 0x90
	public Toggle[] NumberDots; // 0x98
	[RequiredField]
	public Text PromptText; // 0xA0
	[CompilerGenerated]
	private PinEntryControlCallback Complete; // 0xA8

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F9DAD0 Offset: 0x7F99AD0 VA: 0x7F9DAD0
	public void add_Complete(PinEntryControlCallback value) { }

	[CompilerGenerated]
	// RVA: 0x7F9DB6C Offset: 0x7F99B6C VA: 0x7F9DB6C
	public void remove_Complete(PinEntryControlCallback value) { }

	// RVA: 0x7F9DC08 Offset: 0x7F99C08 VA: 0x7F9DC08 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9DEC0 Offset: 0x7F99EC0 VA: 0x7F9DEC0 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9E14C Offset: 0x7F9A14C VA: 0x7F9E14C
	public void Show() { }

	// RVA: 0x7F9E1AC Offset: 0x7F9A1AC VA: 0x7F9E1AC
	public void Hide() { }

	// RVA: 0x7F9E208 Offset: 0x7F9A208 VA: 0x7F9E208
	public void Clear() { }

	// RVA: 0x7F9E25C Offset: 0x7F9A25C VA: 0x7F9E25C
	public void PlayInvalidCodeAnimation() { }

	// RVA: 0x7F9E2B0 Offset: 0x7F9A2B0 VA: 0x7F9E2B0
	protected void OnComplete() { }

	// RVA: 0x7F9E348 Offset: 0x7F9A348 VA: 0x7F9E348
	protected void OnCancel() { }

	// RVA: 0x7F9E3C0 Offset: 0x7F9A3C0 VA: 0x7F9E3C0
	private void CancelButtonPressed() { }

	// RVA: 0x7F9E02C Offset: 0x7F9A02C VA: 0x7F9E02C
	public void PushNumber(int number) { }

	// RVA: 0x7F9DDA0 Offset: 0x7F99DA0 VA: 0x7F9DDA0
	private void RefreshState() { }

	// RVA: 0x7F9E43C Offset: 0x7F9A43C VA: 0x7F9E43C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProfilerMemoryBlock.<CleanUp>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23796
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ProfilerMemoryBlock <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7F9E8B8 Offset: 0x7F9A8B8 VA: 0x7F9E8B8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F9E8E8 Offset: 0x7F9A8E8 VA: 0x7F9E8E8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F9E8EC Offset: 0x7F9A8EC VA: 0x7F9E8EC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F9E9C0 Offset: 0x7F9A9C0 VA: 0x7F9E9C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F9E9C8 Offset: 0x7F9A9C8 VA: 0x7F9E9C8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F9EA00 Offset: 0x7F9AA00 VA: 0x7F9EA00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.UI.Controls
public class ProfilerMemoryBlock : SRMonoBehaviourEx // TypeDefIndex: 23797
{
	// Fields
	private float _lastRefresh; // 0x50
	[RequiredField]
	public Text CurrentUsedText; // 0x58
	[RequiredField]
	public Slider Slider; // 0x60
	[RequiredField]
	public Text TotalAllocatedText; // 0x68

	// Methods

	// RVA: 0x7F9E4F4 Offset: 0x7F9A4F4 VA: 0x7F9E4F4 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9E73C Offset: 0x7F9A73C VA: 0x7F9E73C Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9E510 Offset: 0x7F9A510 VA: 0x7F9E510
	public void TriggerRefresh() { }

	// RVA: 0x7F9E82C Offset: 0x7F9A82C VA: 0x7F9E82C
	public void TriggerCleanup() { }

	[IteratorStateMachine(typeof(ProfilerMemoryBlock.<CleanUp>d__8))]
	// RVA: 0x7F9E84C Offset: 0x7F9A84C VA: 0x7F9E84C
	private IEnumerator CleanUp() { }

	// RVA: 0x7F9E8E0 Offset: 0x7F9A8E0 VA: 0x7F9E8E0
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public class ProfilerMonoBlock : SRMonoBehaviourEx // TypeDefIndex: 23798
{
	// Fields
	private float _lastRefresh; // 0x50
	[RequiredField]
	public Text CurrentUsedText; // 0x58
	[RequiredField]
	public GameObject NotSupportedMessage; // 0x60
	[RequiredField]
	public Slider Slider; // 0x68
	[RequiredField]
	public Text TotalAllocatedText; // 0x70
	private bool _isSupported; // 0x78

	// Methods

	// RVA: 0x7F9EA08 Offset: 0x7F9AA08 VA: 0x7F9EA08 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x7F9ECEC Offset: 0x7F9ACEC VA: 0x7F9ECEC Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9EA78 Offset: 0x7F9AA78 VA: 0x7F9EA78
	public void TriggerRefresh() { }

	// RVA: 0x7F9EDDC Offset: 0x7F9ADDC VA: 0x7F9EDDC
	public void TriggerCollection() { }

	// RVA: 0x7F9EE38 Offset: 0x7F9AE38 VA: 0x7F9EE38
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
public class ProfilerEnableControl : SRMonoBehaviourEx // TypeDefIndex: 23799
{
	// Fields
	private bool _previousState; // 0x50
	[RequiredField]
	public Text ButtonText; // 0x58
	[RequiredField]
	public Button EnableButton; // 0x60
	[RequiredField]
	public Text Text; // 0x68

	// Methods

	// RVA: 0x7F9EE40 Offset: 0x7F9AE40 VA: 0x7F9EE40 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F9EF7C Offset: 0x7F9AF7C VA: 0x7F9EF7C
	protected void UpdateLabels() { }

	// RVA: 0x7F9F09C Offset: 0x7F9B09C VA: 0x7F9F09C Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9F0D8 Offset: 0x7F9B0D8 VA: 0x7F9F0D8
	public void ToggleProfiler() { }

	// RVA: 0x7F9F158 Offset: 0x7F9B158 VA: 0x7F9F158
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls
[RequireComponent(typeof(RectTransform))]
public class ProfilerGraphAxisLabel : SRMonoBehaviourEx // TypeDefIndex: 23800
{
	// Fields
	private float _prevFrameTime; // 0x50
	private Nullable<float> _queuedFrameTime; // 0x54
	private float _yPosition; // 0x5C
	[RequiredField]
	public Text Text; // 0x60

	// Methods

	// RVA: 0x7F9F160 Offset: 0x7F9B160 VA: 0x7F9F160 Slot: 6
	protected override void Update() { }

	// RVA: 0x7F9F4D4 Offset: 0x7F9B4D4 VA: 0x7F9F4D4
	public void SetValue(float frameTime, float yPosition) { }

	// RVA: 0x7F9F1D8 Offset: 0x7F9B1D8 VA: 0x7F9F1D8
	private void SetValueInternal(float frameTime) { }

	// RVA: 0x7F9F55C Offset: 0x7F9B55C VA: 0x7F9F55C
	public void .ctor() { }
}

// Namespace: 
public enum ProfilerGraphControl.VerticalAlignments // TypeDefIndex: 23801
{
	// Fields
	public int value__; // 0x0
	public const ProfilerGraphControl.VerticalAlignments Top = 0;
	public const ProfilerGraphControl.VerticalAlignments Bottom = 1;
}

// Namespace: SRDebugger.UI.Controls
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class ProfilerGraphControl : Graphic // TypeDefIndex: 23802
{
	// Fields
	public ProfilerGraphControl.VerticalAlignments VerticalAlignment; // 0xA4
	private static readonly float[] ScaleSteps; // 0x0
	public bool FloatingScale; // 0xA8
	public bool TargetFpsUseApplication; // 0xA9
	public bool DrawAxes; // 0xAA
	public int TargetFps; // 0xAC
	public bool Clip; // 0xB0
	public const float DataPointMargin = 2;
	public const float DataPointVerticalMargin = 2;
	public const float DataPointWidth = 4;
	public int VerticalPadding; // 0xB4
	public const int LineCount = 3;
	public Color[] LineColours; // 0xB8
	private IProfilerService _profilerService; // 0xC0
	private ProfilerGraphAxisLabel[] _axisLabels; // 0xC8
	private Rect _clipBounds; // 0xD0
	private readonly List<Vector3> _meshVertices; // 0xE0
	private readonly List<Color32> _meshVertexColors; // 0xE8
	private readonly List<int> _meshTriangles; // 0xF0

	// Methods

	// RVA: 0x7F9F564 Offset: 0x7F9B564 VA: 0x7F9F564 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F9F5C4 Offset: 0x7F9B5C4 VA: 0x7F9F5C4 Slot: 6
	protected override void Start() { }

	// RVA: 0x7F9F5CC Offset: 0x7F9B5CC VA: 0x7F9F5CC
	protected void Update() { }

	[Obsolete]
	// RVA: 0x7F9F5DC Offset: 0x7F9B5DC VA: 0x7F9F5DC Slot: 43
	protected override void OnPopulateMesh(Mesh m) { }

	// RVA: 0x7F9FD54 Offset: 0x7F9BD54 VA: 0x7F9FD54
	protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame) { }

	// RVA: 0x7FA0040 Offset: 0x7F9C040 VA: 0x7FA0040
	protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label) { }

	// RVA: 0x7FA01BC Offset: 0x7F9C1BC VA: 0x7FA01BC
	protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, Color c) { }

	// RVA: 0x7F9FC88 Offset: 0x7F9BC88 VA: 0x7F9FC88
	protected ProfilerFrame GetFrame(int i) { }

	// RVA: 0x7F9FAD0 Offset: 0x7F9BAD0 VA: 0x7F9FAD0
	protected int CalculateVisibleDataPointCount() { }

	// RVA: 0x7F9FBCC Offset: 0x7F9BBCC VA: 0x7F9FBCC
	protected int GetFrameBufferCurrentSize() { }

	// RVA: 0x7FA08A4 Offset: 0x7F9C8A4 VA: 0x7FA08A4
	protected int GetFrameBufferMaxSize() { }

	// RVA: 0x7F9FA5C Offset: 0x7F9BA5C VA: 0x7F9FA5C
	protected float CalculateMaxFrameTime() { }

	// RVA: 0x7F9FF30 Offset: 0x7F9BF30 VA: 0x7F9FF30
	private ProfilerGraphAxisLabel GetAxisLabel(int index) { }

	// RVA: 0x7FA0968 Offset: 0x7F9C968 VA: 0x7FA0968
	public void .ctor() { }

	// RVA: 0x7FA0B14 Offset: 0x7F9CB14 VA: 0x7FA0B14
	private static void .cctor() { }
}

// Namespace: SRDebugger.UI.Controls
public class SRTabButton : SRMonoBehaviourEx // TypeDefIndex: 23803
{
	// Fields
	[RequiredField]
	public Behaviour ActiveToggle; // 0x50
	[RequiredField]
	public Button Button; // 0x58
	[RequiredField]
	public RectTransform ExtraContentContainer; // 0x60
	[RequiredField]
	public StyleComponent IconStyleComponent; // 0x68
	[RequiredField]
	public Text TitleText; // 0x70

	// Properties
	public bool IsActive { get; set; }

	// Methods

	// RVA: 0x7FA0BB4 Offset: 0x7F9CBB4 VA: 0x7FA0BB4
	public bool get_IsActive() { }

	// RVA: 0x7F9BF1C Offset: 0x7F97F1C VA: 0x7F9BF1C
	public void set_IsActive(bool value) { }

	// RVA: 0x7FA0BD0 Offset: 0x7F9CBD0 VA: 0x7FA0BD0
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls.Data
public class ActionControl : OptionsControlBase // TypeDefIndex: 23804
{
	// Fields
	private MethodReference _method; // 0x68
	[RequiredField]
	public Button Button; // 0x70
	[RequiredField]
	public Text Title; // 0x78

	// Properties
	public MethodReference Method { get; }

	// Methods

	// RVA: 0x7FA0BD8 Offset: 0x7F9CBD8 VA: 0x7FA0BD8
	public MethodReference get_Method() { }

	// RVA: 0x7FA0BE0 Offset: 0x7F9CBE0 VA: 0x7FA0BE0 Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA0C7C Offset: 0x7F9CC7C VA: 0x7FA0C7C
	private void ButtonOnClick() { }

	// RVA: 0x7FA0DBC Offset: 0x7F9CDBC VA: 0x7FA0DBC
	public void SetMethod(string methodName, MethodReference method) { }

	// RVA: 0x7FA0E04 Offset: 0x7F9CE04 VA: 0x7FA0E04
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls.Data
public class BoolControl : DataBoundControl // TypeDefIndex: 23805
{
	// Fields
	[RequiredField]
	public Text Title; // 0x88
	[RequiredField]
	public Toggle Toggle; // 0x90

	// Methods

	// RVA: 0x7FA0E0C Offset: 0x7F9CE0C VA: 0x7FA0E0C Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA0ED4 Offset: 0x7F9CED4 VA: 0x7FA0ED4
	private void ToggleOnValueChanged(bool isOn) { }

	// RVA: 0x7FA0F40 Offset: 0x7F9CF40 VA: 0x7FA0F40 Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x7FA0F84 Offset: 0x7F9CF84 VA: 0x7FA0F84 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x7FA1008 Offset: 0x7F9D008 VA: 0x7FA1008 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x7FA1090 Offset: 0x7F9D090 VA: 0x7FA1090
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls.Data
public class EnumControl : DataBoundControl // TypeDefIndex: 23806
{
	// Fields
	private object _lastValue; // 0x88
	private string[] _names; // 0x90
	private Array _values; // 0x98
	[RequiredField]
	public LayoutElement ContentLayoutElement; // 0xA0
	public GameObject[] DisableOnReadOnly; // 0xA8
	[RequiredField]
	public SRSpinner Spinner; // 0xB0
	[RequiredField]
	public Text Title; // 0xB8
	[RequiredField]
	public Text Value; // 0xC0

	// Methods

	// RVA: 0x7FA1098 Offset: 0x7F9D098 VA: 0x7FA1098 Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA10C8 Offset: 0x7F9D0C8 VA: 0x7FA10C8 Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x7FA1308 Offset: 0x7F9D308 VA: 0x7FA1308 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x7FA1364 Offset: 0x7F9D364 VA: 0x7FA1364 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x7FA138C Offset: 0x7F9D38C VA: 0x7FA138C
	private void SetIndex(int i) { }

	// RVA: 0x7FA13C8 Offset: 0x7F9D3C8 VA: 0x7FA13C8
	public void GoToNext() { }

	// RVA: 0x7FA1420 Offset: 0x7F9D420 VA: 0x7FA1420
	public void GoToPrevious() { }

	// RVA: 0x7FA1478 Offset: 0x7F9D478 VA: 0x7FA1478
	public void .ctor() { }
}

// Namespace: 
public struct NumberControl.ValueRange // TypeDefIndex: 23807
{
	// Fields
	public double MaxValue; // 0x0
	public double MinValue; // 0x8
}

// Namespace: SRDebugger.UI.Controls.Data
public class NumberControl : DataBoundControl // TypeDefIndex: 23808
{
	// Fields
	private static readonly Type[] IntegerTypes; // 0x0
	private static readonly Type[] DecimalTypes; // 0x8
	public static readonly Dictionary<Type, NumberControl.ValueRange> ValueRanges; // 0x10
	private string _lastValue; // 0x88
	private Type _type; // 0x90
	public GameObject[] DisableOnReadOnly; // 0x98
	public SRNumberButton DownNumberButton; // 0xA0
	[RequiredField]
	public SRNumberSpinner NumberSpinner; // 0xA8
	[RequiredField]
	public Text Title; // 0xB0
	public SRNumberButton UpNumberButton; // 0xB8

	// Methods

	// RVA: 0x7FA1480 Offset: 0x7F9D480 VA: 0x7FA1480 Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA1548 Offset: 0x7F9D548 VA: 0x7FA1548
	private void OnValueChanged(string newValue) { }

	// RVA: 0x7FA165C Offset: 0x7F9D65C VA: 0x7FA165C Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x7FA1E54 Offset: 0x7F9DE54 VA: 0x7FA1E54 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x7FA1EF8 Offset: 0x7F9DEF8 VA: 0x7FA1EF8 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x7FA197C Offset: 0x7F9D97C VA: 0x7FA197C
	protected static bool IsIntegerType(Type t) { }

	// RVA: 0x7FA1A7C Offset: 0x7F9DA7C VA: 0x7FA1A7C
	protected static bool IsDecimalType(Type t) { }

	// RVA: 0x7FA1B7C Offset: 0x7F9DB7C VA: 0x7FA1B7C
	protected double GetMaxValue(Type t) { }

	// RVA: 0x7FA1CE8 Offset: 0x7F9DCE8 VA: 0x7FA1CE8
	protected double GetMinValue(Type t) { }

	// RVA: 0x7FA1F78 Offset: 0x7F9DF78 VA: 0x7FA1F78
	public void .ctor() { }

	// RVA: 0x7FA1F80 Offset: 0x7F9DF80 VA: 0x7FA1F80
	private static void .cctor() { }
}

// Namespace: SRDebugger.UI.Controls.Data
public class ReadOnlyControl : DataBoundControl // TypeDefIndex: 23809
{
	// Fields
	[RequiredField]
	public Text ValueText; // 0x88
	[RequiredField]
	public Text Title; // 0x90

	// Methods

	// RVA: 0x7FA2514 Offset: 0x7F9E514 VA: 0x7FA2514 Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA2544 Offset: 0x7F9E544 VA: 0x7FA2544 Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x7FA2568 Offset: 0x7F9E568 VA: 0x7FA2568 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x7FA25F0 Offset: 0x7F9E5F0 VA: 0x7FA25F0 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x7FA2688 Offset: 0x7F9E688 VA: 0x7FA2688
	public void .ctor() { }
}

// Namespace: SRDebugger.UI.Controls.Data
public class StringControl : DataBoundControl // TypeDefIndex: 23810
{
	// Fields
	[RequiredField]
	public InputField InputField; // 0x88
	[RequiredField]
	public Text Title; // 0x90

	// Methods

	// RVA: 0x7FA2690 Offset: 0x7F9E690 VA: 0x7FA2690 Slot: 5
	protected override void Start() { }

	// RVA: 0x7FA2758 Offset: 0x7F9E758 VA: 0x7FA2758
	private void OnValueChanged(string newValue) { }

	// RVA: 0x7FA275C Offset: 0x7F9E75C VA: 0x7FA275C Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x7FA27EC Offset: 0x7F9E7EC VA: 0x7FA27EC Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x7FA2878 Offset: 0x7F9E878 VA: 0x7FA2878 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x7FA2910 Offset: 0x7F9E910 VA: 0x7FA2910
	public void .ctor() { }
}

// Namespace: SRDebugger.Services
public class BugReport // TypeDefIndex: 23811
{
	// Fields
	public List<ConsoleEntry> ConsoleLog; // 0x10
	public string Email; // 0x18
	public byte[] ScreenshotData; // 0x20
	public Dictionary<string, Dictionary<string, object>> SystemInformation; // 0x28
	public string UserDescription; // 0x30

	// Methods

	// RVA: 0x7F99A7C Offset: 0x7F95A7C VA: 0x7F99A7C
	public void .ctor() { }
}

// Namespace: SRDebugger.Services
public sealed class BugReportCompleteCallback : MulticastDelegate // TypeDefIndex: 23812
{
	// Methods

	// RVA: 0x7F99A84 Offset: 0x7F95A84 VA: 0x7F99A84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7FA2918 Offset: 0x7F9E918 VA: 0x7FA2918 Slot: 13
	public virtual void Invoke(bool didSucceed, string errorMessage) { }

	// RVA: 0x7FA2930 Offset: 0x7F9E930 VA: 0x7FA2930 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool didSucceed, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x7FA29C8 Offset: 0x7F9E9C8 VA: 0x7FA29C8 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SRDebugger.Services
public sealed class BugReportProgressCallback : MulticastDelegate // TypeDefIndex: 23813
{
	// Methods

	// RVA: 0x7F99B24 Offset: 0x7F95B24 VA: 0x7F99B24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7FA29D4 Offset: 0x7F9E9D4 VA: 0x7FA29D4 Slot: 13
	public virtual void Invoke(float progress) { }

	// RVA: 0x7FA29E8 Offset: 0x7F9E9E8 VA: 0x7FA29E8 Slot: 14
	public virtual IAsyncResult BeginInvoke(float progress, AsyncCallback callback, object object) { }

	// RVA: 0x7FA2A6C Offset: 0x7F9EA6C VA: 0x7FA2A6C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SRDebugger.Services
public interface IBugReportService // TypeDefIndex: 23814
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, BugReportProgressCallback progressCallback);
}

// Namespace: SRDebugger.Services
public sealed class ConsoleUpdatedEventHandler : MulticastDelegate // TypeDefIndex: 23815
{
	// Methods

	// RVA: 0x7F9A754 Offset: 0x7F96754 VA: 0x7F9A754
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7FA2A78 Offset: 0x7F9EA78 VA: 0x7FA2A78 Slot: 13
	public virtual void Invoke(IConsoleService console) { }

	// RVA: 0x7FA2A8C Offset: 0x7F9EA8C VA: 0x7FA2A8C Slot: 14
	public virtual IAsyncResult BeginInvoke(IConsoleService console, AsyncCallback callback, object object) { }

	// RVA: 0x7FA2AAC Offset: 0x7F9EAAC VA: 0x7FA2AAC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SRDebugger.Services
public interface IConsoleService // TypeDefIndex: 23816
{
	// Properties
	public abstract int ErrorCount { get; }
	public abstract int WarningCount { get; }
	public abstract int InfoCount { get; }
	public abstract IReadOnlyList<ConsoleEntry> Entries { get; }
	public abstract IReadOnlyList<ConsoleEntry> AllEntries { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ErrorCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_WarningCount();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_InfoCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IReadOnlyList<ConsoleEntry> get_Entries();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IReadOnlyList<ConsoleEntry> get_AllEntries();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void add_Updated(ConsoleUpdatedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void remove_Updated(ConsoleUpdatedEventHandler value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();
}

// Namespace: SRDebugger.Services
public class ConsoleEntry // TypeDefIndex: 23817
{
	// Fields
	private const int MessagePreviewLength = 180;
	private const int StackTracePreviewLength = 120;
	private string _messagePreview; // 0x10
	private string _stackTracePreview; // 0x18
	public int Count; // 0x20
	public LogType LogType; // 0x24
	public string Message; // 0x28
	public string StackTrace; // 0x30

	// Properties
	public string MessagePreview { get; }
	public string StackTracePreview { get; }

	// Methods

	// RVA: 0x7FA2AB8 Offset: 0x7F9EAB8 VA: 0x7FA2AB8
	public void .ctor() { }

	// RVA: 0x7FA2AC8 Offset: 0x7F9EAC8 VA: 0x7FA2AC8
	public void .ctor(ConsoleEntry other) { }

	// RVA: 0x7F9C624 Offset: 0x7F98624 VA: 0x7F9C624
	public string get_MessagePreview() { }

	// RVA: 0x7F9C6F8 Offset: 0x7F986F8 VA: 0x7F9C6F8
	public string get_StackTracePreview() { }

	// RVA: 0x7FA2B24 Offset: 0x7F9EB24 VA: 0x7FA2B24
	public bool Matches(ConsoleEntry other) { }
}

// Namespace: SRDebugger.Services
public interface IDebugCameraService // TypeDefIndex: 23818
{
	// Properties
	public abstract Camera Camera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Camera get_Camera();
}

// Namespace: SRDebugger.Services
public interface IDebugPanelService // TypeDefIndex: 23819
{
	// Properties
	public abstract bool IsLoaded { get; }
	public abstract bool IsVisible { get; set; }
	public abstract Nullable<DefaultTabs> ActiveTab { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsLoaded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsVisible();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_IsVisible(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Nullable<DefaultTabs> get_ActiveTab();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_VisibilityChanged(Action<IDebugPanelService, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_VisibilityChanged(Action<IDebugPanelService, bool> value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Unload();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OpenTab(DefaultTabs tab);
}

// Namespace: SRDebugger.Services
public interface IDebugService // TypeDefIndex: 23820
{
	// Properties
	public abstract Settings Settings { get; }
	public abstract bool IsDebugPanelVisible { get; }
	public abstract bool IsTriggerEnabled { get; set; }
	public abstract IDockConsoleService DockConsole { get; }
	public abstract bool IsProfilerDocked { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Settings get_Settings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDebugPanelVisible();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsTriggerEnabled();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_IsTriggerEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDockConsoleService get_DockConsole();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsProfilerDocked();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_IsProfilerDocked(bool value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AddSystemInfo(InfoEntry entry, string category = "Default");

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ShowDebugPanel(bool requireEntryCode = True);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = True);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void HideDebugPanel();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DestroyDebugPanel();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddOptionContainer(object container);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void RemoveOptionContainer(object container);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void PinAllOptions(string category);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void UnpinAllOptions(string category);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void PinOption(string name);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void UnpinOption(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void ClearPinnedOptions();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void ShowBugReportSheet(ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	public abstract void add_PanelVisibilityChanged(VisibilityChangedDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 21
	public abstract void remove_PanelVisibilityChanged(VisibilityChangedDelegate value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract RectTransform EnableWorldSpaceMode();
}

// Namespace: SRDebugger.Services
public interface IDebugTriggerService // TypeDefIndex: 23821
{
	// Properties
	public abstract bool IsEnabled { get; set; }
	public abstract PinAlignment Position { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsEnabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IsEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PinAlignment get_Position();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Position(PinAlignment value);
}

// Namespace: SRDebugger.Services
public interface IDockConsoleService // TypeDefIndex: 23822
{
	// Properties
	public abstract bool IsVisible { get; set; }
	public abstract bool IsExpanded { get; set; }
	public abstract ConsoleAlignment Alignment { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsVisible();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IsVisible(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsExpanded();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_IsExpanded(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ConsoleAlignment get_Alignment();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Alignment(ConsoleAlignment value);
}

// Namespace: SRDebugger.Services
public interface IOptionsService // TypeDefIndex: 23823
{
	// Properties
	public abstract ICollection<OptionDefinition> Options { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OptionsUpdated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OptionsUpdated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ICollection<OptionDefinition> get_Options();

	[Obsolete("Use IOptionsService.AddContainer instead.")]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Scan(object obj);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddContainer(object obj);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void RemoveContainer(object obj);
}

// Namespace: SRDebugger.Services
public sealed class PinEntryCompleteCallback : MulticastDelegate // TypeDefIndex: 23824
{
	// Methods

	// RVA: 0x7FA2B94 Offset: 0x7F9EB94 VA: 0x7FA2B94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7FA2C34 Offset: 0x7F9EC34 VA: 0x7FA2C34 Slot: 13
	public virtual void Invoke(bool validPinEntered) { }

	// RVA: 0x7FA2C4C Offset: 0x7F9EC4C VA: 0x7FA2C4C Slot: 14
	public virtual IAsyncResult BeginInvoke(bool validPinEntered, AsyncCallback callback, object object) { }

	// RVA: 0x7FA2CD4 Offset: 0x7F9ECD4 VA: 0x7FA2CD4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SRDebugger.Services
public interface IPinEntryService // TypeDefIndex: 23825
{
	// Properties
	public abstract bool IsShowingKeypad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsShowingKeypad();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True);

	[Obsolete("blockInput param is deprecated (and ignored), please use overload without it.")]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel);
}

// Namespace: SRDebugger.Services
public interface IPinnedUIService // TypeDefIndex: 23826
{
	// Properties
	public abstract bool IsProfilerPinned { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OptionPinStateChanged(Action<OptionDefinition, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OptionPinStateChanged(Action<OptionDefinition, bool> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsProfilerPinned();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_IsProfilerPinned(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Pin(OptionDefinition option, int order = -1);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Unpin(OptionDefinition option);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnpinAll();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool HasPinned(OptionDefinition option);
}

// Namespace: SRDebugger.Services
public struct ProfilerFrame // TypeDefIndex: 23827
{
	// Fields
	public double FrameTime; // 0x0
	public double OtherTime; // 0x8
	public double RenderTime; // 0x10
	public double UpdateTime; // 0x18
}

// Namespace: SRDebugger.Services
public interface IProfilerService // TypeDefIndex: 23828
{
	// Properties
	public abstract float AverageFrameTime { get; }
	public abstract float LastFrameTime { get; }
	public abstract CircularBuffer<ProfilerFrame> FrameBuffer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_AverageFrameTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_LastFrameTime();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract CircularBuffer<ProfilerFrame> get_FrameBuffer();
}

// Namespace: SRDebugger.Services
public interface ISystemInformationService // TypeDefIndex: 23829
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<string> GetCategories();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<InfoEntry> GetInfo(string category);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(InfoEntry info, string category = "Default");

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = False);
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IBugReportService))]
public class BugReportApiService : SRServiceBase<IBugReportService>, IBugReportService // TypeDefIndex: 23830
{
	// Fields
	public const float Timeout = 12;
	private BugReportCompleteCallback _completeCallback; // 0x50
	private string _errorMessage; // 0x58
	private bool _isBusy; // 0x60
	private float _previousProgress; // 0x64
	private BugReportProgressCallback _progressCallback; // 0x68
	private BugReportApi _reportApi; // 0x70

	// Methods

	// RVA: 0x7FA2CE0 Offset: 0x7F9ECE0 VA: 0x7FA2CE0 Slot: 11
	public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, BugReportProgressCallback progressCallback) { }

	// RVA: 0x7FA2F90 Offset: 0x7F9EF90 VA: 0x7FA2F90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA3050 Offset: 0x7F9F050 VA: 0x7FA3050
	private void OnProgress(float progress) { }

	// RVA: 0x7FA306C Offset: 0x7F9F06C VA: 0x7FA306C
	private void OnComplete() { }

	// RVA: 0x7FA3104 Offset: 0x7F9F104 VA: 0x7FA3104 Slot: 6
	protected override void Update() { }

	// RVA: 0x7FA31F4 Offset: 0x7F9F1F4 VA: 0x7FA31F4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BugReportPopoverService.<OpenCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23831
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool takeScreenshot; // 0x20
	public BugReportPopoverService <>4__this; // 0x28
	public string descriptionText; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7FA3864 Offset: 0x7F9F864 VA: 0x7FA3864
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7FA3CB8 Offset: 0x7F9FCB8 VA: 0x7FA3CB8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7FA3CBC Offset: 0x7F9FCBC VA: 0x7FA3CBC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7FA3E04 Offset: 0x7F9FE04 VA: 0x7FA3E04 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7FA3E0C Offset: 0x7F9FE0C VA: 0x7FA3E0C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7FA3E44 Offset: 0x7F9FE44 VA: 0x7FA3E44 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(BugReportPopoverService))]
public class BugReportPopoverService : SRServiceBase<BugReportPopoverService> // TypeDefIndex: 23832
{
	// Fields
	private BugReportCompleteCallback _callback; // 0x50
	private bool _isVisible; // 0x58
	private BugReportPopoverRoot _popover; // 0x60
	private BugReportSheetController _sheet; // 0x68

	// Properties
	public bool IsShowingPopover { get; }

	// Methods

	// RVA: 0x7FA323C Offset: 0x7F9F23C VA: 0x7FA323C
	public bool get_IsShowingPopover() { }

	// RVA: 0x7FA3244 Offset: 0x7F9F244 VA: 0x7FA3244
	public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = True, string descriptionText) { }

	[IteratorStateMachine(typeof(BugReportPopoverService.<OpenCo>d__7))]
	// RVA: 0x7FA37D0 Offset: 0x7F9F7D0 VA: 0x7FA37D0
	private IEnumerator OpenCo(bool takeScreenshot, string descriptionText) { }

	// RVA: 0x7FA388C Offset: 0x7F9F88C VA: 0x7FA388C
	private void SubmitComplete(bool didSucceed, string errorMessage) { }

	// RVA: 0x7FA3A28 Offset: 0x7F9FA28 VA: 0x7FA3A28
	private void CancelPressed() { }

	// RVA: 0x7FA3898 Offset: 0x7F9F898 VA: 0x7FA3898
	private void OnComplete(bool success, string errorMessage, bool close) { }

	// RVA: 0x7FA3A78 Offset: 0x7F9FA78 VA: 0x7FA3A78
	private void TakingScreenshot() { }

	// RVA: 0x7FA3B14 Offset: 0x7F9FB14 VA: 0x7FA3B14
	private void ScreenshotComplete() { }

	// RVA: 0x7FA3BB0 Offset: 0x7F9FBB0 VA: 0x7FA3BB0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA340C Offset: 0x7F9F40C VA: 0x7FA340C
	private void Load() { }

	// RVA: 0x7FA3C70 Offset: 0x7F9FC70 VA: 0x7FA3C70
	public void .ctor() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IDebugCameraService))]
public class DebugCameraServiceImpl : IDebugCameraService // TypeDefIndex: 23833
{
	// Fields
	private Camera _debugCamera; // 0x10

	// Properties
	public Camera Camera { get; }

	// Methods

	// RVA: 0x7FA3E4C Offset: 0x7F9FE4C VA: 0x7FA3E4C
	public void .ctor() { }

	// RVA: 0x7FA3FEC Offset: 0x7F9FFEC VA: 0x7FA3FEC Slot: 4
	public Camera get_Camera() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IDebugPanelService))]
public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService // TypeDefIndex: 23834
{
	// Fields
	private DebugPanelRoot _debugPanelRootObject; // 0x18
	[CompilerGenerated]
	private Action<IDebugPanelService, bool> VisibilityChanged; // 0x20
	private bool _isVisible; // 0x28
	private Nullable<bool> _cursorWasVisible; // 0x29
	private Nullable<CursorLockMode> _cursorLockMode; // 0x2C

	// Properties
	public DebugPanelRoot RootObject { get; }
	public bool IsLoaded { get; }
	public bool IsVisible { get; set; }
	public Nullable<DefaultTabs> ActiveTab { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7FA3FF4 Offset: 0x7F9FFF4 VA: 0x7FA3FF4 Slot: 8
	public void add_VisibilityChanged(Action<IDebugPanelService, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7FA40A4 Offset: 0x7FA00A4 VA: 0x7FA40A4 Slot: 9
	public void remove_VisibilityChanged(Action<IDebugPanelService, bool> value) { }

	// RVA: 0x7FA4154 Offset: 0x7FA0154 VA: 0x7FA4154
	public DebugPanelRoot get_RootObject() { }

	// RVA: 0x7FA415C Offset: 0x7FA015C VA: 0x7FA415C Slot: 4
	public bool get_IsLoaded() { }

	// RVA: 0x7FA41BC Offset: 0x7FA01BC VA: 0x7FA41BC Slot: 5
	public bool get_IsVisible() { }

	// RVA: 0x7FA41E8 Offset: 0x7FA01E8 VA: 0x7FA41E8 Slot: 6
	public void set_IsVisible(bool value) { }

	// RVA: 0x7FA4644 Offset: 0x7FA0644 VA: 0x7FA4644 Slot: 7
	public Nullable<DefaultTabs> get_ActiveTab() { }

	// RVA: 0x7FA46D4 Offset: 0x7FA06D4 VA: 0x7FA46D4 Slot: 11
	public void OpenTab(DefaultTabs tab) { }

	// RVA: 0x7FA4728 Offset: 0x7FA0728 VA: 0x7FA4728 Slot: 10
	public void Unload() { }

	// RVA: 0x7FA4458 Offset: 0x7FA0458 VA: 0x7FA4458
	private void Load() { }

	// RVA: 0x7FA481C Offset: 0x7FA081C VA: 0x7FA481C
	public void .ctor() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IDebugTriggerService))]
public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService // TypeDefIndex: 23835
{
	// Fields
	private PinAlignment _position; // 0x50
	private TriggerRoot _trigger; // 0x58

	// Properties
	public bool IsEnabled { get; set; }
	public PinAlignment Position { get; set; }

	// Methods

	// RVA: 0x7FA4824 Offset: 0x7FA0824 VA: 0x7FA4824 Slot: 11
	public bool get_IsEnabled() { }

	// RVA: 0x7FA48B8 Offset: 0x7FA08B8 VA: 0x7FA48B8 Slot: 12
	public void set_IsEnabled(bool value) { }

	// RVA: 0x7FA4D0C Offset: 0x7FA0D0C VA: 0x7FA4D0C Slot: 13
	public PinAlignment get_Position() { }

	// RVA: 0x7FA4D14 Offset: 0x7FA0D14 VA: 0x7FA4D14 Slot: 14
	public void set_Position(PinAlignment value) { }

	// RVA: 0x7FA4E30 Offset: 0x7FA0E30 VA: 0x7FA4E30 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA4990 Offset: 0x7FA0990 VA: 0x7FA4990
	private void CreateTrigger() { }

	// RVA: 0x7FA4F5C Offset: 0x7FA0F5C VA: 0x7FA4F5C Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x7FA5020 Offset: 0x7FA1020 VA: 0x7FA5020
	private static void OnActiveSceneChanged(Scene s1, Scene s2) { }

	// RVA: 0x7FA5028 Offset: 0x7FA1028 VA: 0x7FA5028
	private void OnTriggerButtonClick() { }

	// RVA: 0x7FA4DA4 Offset: 0x7FA0DA4 VA: 0x7FA4DA4
	private static void SetTriggerPosition(RectTransform t, PinAlignment position) { }

	// RVA: 0x7FA50CC Offset: 0x7FA10CC VA: 0x7FA50CC
	public void .ctor() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IDockConsoleService))]
public class DockConsoleServiceImpl : IDockConsoleService // TypeDefIndex: 23836
{
	// Fields
	private ConsoleAlignment _alignment; // 0x10
	private DockConsoleController _consoleRoot; // 0x18
	private bool _didSuspendTrigger; // 0x20
	private bool _isExpanded; // 0x21
	private bool _isVisible; // 0x22

	// Properties
	public bool IsVisible { get; set; }
	public bool IsExpanded { get; set; }
	public ConsoleAlignment Alignment { get; set; }

	// Methods

	// RVA: 0x7FA5114 Offset: 0x7FA1114 VA: 0x7FA5114
	public void .ctor() { }

	// RVA: 0x7FA514C Offset: 0x7FA114C VA: 0x7FA514C Slot: 4
	public bool get_IsVisible() { }

	// RVA: 0x7FA5154 Offset: 0x7FA1154 VA: 0x7FA5154 Slot: 5
	public void set_IsVisible(bool value) { }

	// RVA: 0x7FA5674 Offset: 0x7FA1674 VA: 0x7FA5674 Slot: 6
	public bool get_IsExpanded() { }

	// RVA: 0x7FA567C Offset: 0x7FA167C VA: 0x7FA567C Slot: 7
	public void set_IsExpanded(bool value) { }

	// RVA: 0x7FA573C Offset: 0x7FA173C VA: 0x7FA573C Slot: 8
	public ConsoleAlignment get_Alignment() { }

	// RVA: 0x7FA5744 Offset: 0x7FA1744 VA: 0x7FA5744 Slot: 9
	public void set_Alignment(ConsoleAlignment value) { }

	// RVA: 0x7FA5224 Offset: 0x7FA1224 VA: 0x7FA5224
	private void Load() { }

	// RVA: 0x7FA53C4 Offset: 0x7FA13C4 VA: 0x7FA53C4
	private void CheckTrigger() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(KeyboardShortcutListenerService))]
public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService> // TypeDefIndex: 23837
{
	// Fields
	private List<Settings.KeyboardShortcut> _shortcuts; // 0x50

	// Methods

	// RVA: 0x7FA5854 Offset: 0x7FA1854 VA: 0x7FA5854 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA5974 Offset: 0x7FA1974 VA: 0x7FA5974
	private void ToggleTab(DefaultTabs t) { }

	// RVA: 0x7FA5BDC Offset: 0x7FA1BDC VA: 0x7FA5BDC
	private void ExecuteShortcut(Settings.KeyboardShortcut shortcut) { }

	// RVA: 0x7FA6210 Offset: 0x7FA2210 VA: 0x7FA6210 Slot: 6
	protected override void Update() { }

	// RVA: 0x7FA64B8 Offset: 0x7FA24B8 VA: 0x7FA64B8
	public void .ctor() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IOptionsService))]
public class OptionsServiceImpl : IOptionsService // TypeDefIndex: 23838
{
	// Fields
	[CompilerGenerated]
	private EventHandler OptionsUpdated; // 0x10
	[CompilerGenerated]
	private EventHandler<PropertyChangedEventArgs> OptionsValueUpdated; // 0x18
	private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup; // 0x20
	private readonly List<OptionDefinition> _options; // 0x28
	private readonly IList<OptionDefinition> _optionsReadonly; // 0x30

	// Properties
	public ICollection<OptionDefinition> Options { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7FA6500 Offset: 0x7FA2500 VA: 0x7FA6500 Slot: 4
	public void add_OptionsUpdated(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7FA659C Offset: 0x7FA259C VA: 0x7FA659C Slot: 5
	public void remove_OptionsUpdated(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7FA6638 Offset: 0x7FA2638 VA: 0x7FA6638 Slot: 6
	public void add_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x7FA66E8 Offset: 0x7FA26E8 VA: 0x7FA66E8 Slot: 7
	public void remove_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	// RVA: 0x7FA6798 Offset: 0x7FA2798 VA: 0x7FA6798 Slot: 8
	public ICollection<OptionDefinition> get_Options() { }

	// RVA: 0x7FA67A0 Offset: 0x7FA27A0 VA: 0x7FA67A0
	public void .ctor() { }

	// RVA: 0x7FA69D8 Offset: 0x7FA29D8 VA: 0x7FA69D8 Slot: 9
	public void Scan(object obj) { }

	// RVA: 0x7FA69DC Offset: 0x7FA29DC VA: 0x7FA69DC Slot: 10
	public void AddContainer(object obj) { }

	// RVA: 0x7FA6CC8 Offset: 0x7FA2CC8 VA: 0x7FA6CC8 Slot: 11
	public void RemoveContainer(object obj) { }

	// RVA: 0x7FA714C Offset: 0x7FA314C VA: 0x7FA714C
	private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x7FA716C Offset: 0x7FA316C VA: 0x7FA716C
	private void OnSROptionsPropertyChanged(object sender, string propertyName) { }

	// RVA: 0x7FA6C48 Offset: 0x7FA2C48 VA: 0x7FA6C48
	private void OnOptionsUpdated() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IPinEntryService))]
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 23839
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x50
	private bool _isVisible; // 0x58
	private PinEntryControl _pinControl; // 0x60
	private List<int> _requiredPin; // 0x68

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x7FA71FC Offset: 0x7FA31FC VA: 0x7FA71FC Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x7FA7204 Offset: 0x7FA3204 VA: 0x7FA7204 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[Obsolete]
	// RVA: 0x7FA784C Offset: 0x7FA384C VA: 0x7FA784C Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x7FA7854 Offset: 0x7FA3854 VA: 0x7FA7854 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA7688 Offset: 0x7FA3688 VA: 0x7FA7688
	private void Load() { }

	// RVA: 0x7FA7914 Offset: 0x7FA3914 VA: 0x7FA7914
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x7FA7430 Offset: 0x7FA3430 VA: 0x7FA7430
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x7FA79DC Offset: 0x7FA39DC VA: 0x7FA79DC
	public void .ctor() { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IPinnedUIService))]
public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService // TypeDefIndex: 23840
{
	// Fields
	private readonly List<OptionsControlBase> _controlList; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects; // 0x58
	private bool _queueRefresh; // 0x60
	private PinnedUIRoot _uiRoot; // 0x68
	[CompilerGenerated]
	private Action<OptionDefinition, bool> OptionPinStateChanged; // 0x70

	// Properties
	public DockConsoleController DockConsoleController { get; }
	public bool IsProfilerPinned { get; set; }

	// Methods

	// RVA: 0x7FA57D4 Offset: 0x7FA17D4 VA: 0x7FA57D4
	public DockConsoleController get_DockConsoleController() { }

	[CompilerGenerated]
	// RVA: 0x7FA7E30 Offset: 0x7FA3E30 VA: 0x7FA7E30 Slot: 11
	public void add_OptionPinStateChanged(Action<OptionDefinition, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7FA7EE0 Offset: 0x7FA3EE0 VA: 0x7FA7EE0 Slot: 12
	public void remove_OptionPinStateChanged(Action<OptionDefinition, bool> value) { }

	// RVA: 0x7FA7F90 Offset: 0x7FA3F90 VA: 0x7FA7F90 Slot: 13
	public bool get_IsProfilerPinned() { }

	// RVA: 0x7FA8020 Offset: 0x7FA4020 VA: 0x7FA8020 Slot: 14
	public void set_IsProfilerPinned(bool value) { }

	// RVA: 0x7FA80B8 Offset: 0x7FA40B8 VA: 0x7FA80B8 Slot: 15
	public void Pin(OptionDefinition obj, int order = -1) { }

	// RVA: 0x7FA82B4 Offset: 0x7FA42B4 VA: 0x7FA82B4 Slot: 16
	public void Unpin(OptionDefinition obj) { }

	// RVA: 0x7FA8294 Offset: 0x7FA4294 VA: 0x7FA8294
	private void OnPinnedStateChanged(OptionDefinition option, bool isPinned) { }

	// RVA: 0x7FA8404 Offset: 0x7FA4404 VA: 0x7FA8404 Slot: 17
	public void UnpinAll() { }

	// RVA: 0x7FA85F4 Offset: 0x7FA45F4 VA: 0x7FA85F4 Slot: 18
	public bool HasPinned(OptionDefinition option) { }

	// RVA: 0x7FA864C Offset: 0x7FA464C VA: 0x7FA864C Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FA7A7C Offset: 0x7FA3A7C VA: 0x7FA7A7C
	private void Load() { }

	// RVA: 0x7FA870C Offset: 0x7FA470C VA: 0x7FA870C
	private void UpdateAnchors() { }

	// RVA: 0x7FA8940 Offset: 0x7FA4940 VA: 0x7FA8940 Slot: 6
	protected override void Update() { }

	// RVA: 0x7FA8A00 Offset: 0x7FA4A00 VA: 0x7FA8A00
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x7FA8CAC Offset: 0x7FA4CAC VA: 0x7FA8CAC
	private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x7FA8CB8 Offset: 0x7FA4CB8 VA: 0x7FA8CB8
	private void OnDebugPanelVisibilityChanged(bool isVisible) { }

	// RVA: 0x7FA8970 Offset: 0x7FA4970 VA: 0x7FA8970
	private void Refresh() { }

	// RVA: 0x7FA8CC8 Offset: 0x7FA4CC8 VA: 0x7FA8CC8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SRDebugService.<>c__DisplayClass32_0 // TypeDefIndex: 23841
{
	// Fields
	public ActionCompleteCallback onComplete; // 0x10

	// Methods

	// RVA: 0x7FAAFE4 Offset: 0x7FA6FE4 VA: 0x7FAAFE4
	public void .ctor() { }

	// RVA: 0x7FAB568 Offset: 0x7FA7568 VA: 0x7FAB568
	internal void <ShowBugReportSheet>b__0(bool succeed, string message) { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IDebugService))]
public class SRDebugService : IDebugService // TypeDefIndex: 23842
{
	// Fields
	private readonly IDebugPanelService _debugPanelService; // 0x10
	private readonly IDebugTriggerService _debugTrigger; // 0x18
	private readonly ISystemInformationService _informationService; // 0x20
	private readonly IOptionsService _optionsService; // 0x28
	private readonly IPinnedUIService _pinnedUiService; // 0x30
	private bool _entryCodeEnabled; // 0x38
	private bool _hasAuthorised; // 0x39
	private Nullable<DefaultTabs> _queuedTab; // 0x3C
	private RectTransform _worldSpaceTransform; // 0x48
	[CompilerGenerated]
	private VisibilityChangedDelegate PanelVisibilityChanged; // 0x50

	// Properties
	public Settings Settings { get; }
	public bool IsDebugPanelVisible { get; }
	public bool IsTriggerEnabled { get; set; }
	public bool IsProfilerDocked { get; set; }
	public IDockConsoleService DockConsole { get; }

	// Methods

	// RVA: 0x7FA8DB8 Offset: 0x7FA4DB8 VA: 0x7FA8DB8
	public void .ctor() { }

	// RVA: 0x7FA9378 Offset: 0x7FA5378 VA: 0x7FA9378 Slot: 4
	public Settings get_Settings() { }

	// RVA: 0x7FA9380 Offset: 0x7FA5380 VA: 0x7FA9380 Slot: 5
	public bool get_IsDebugPanelVisible() { }

	// RVA: 0x7FA9424 Offset: 0x7FA5424 VA: 0x7FA9424 Slot: 6
	public bool get_IsTriggerEnabled() { }

	// RVA: 0x7FA94C4 Offset: 0x7FA54C4 VA: 0x7FA94C4 Slot: 7
	public void set_IsTriggerEnabled(bool value) { }

	// RVA: 0x7FA9570 Offset: 0x7FA5570 VA: 0x7FA9570 Slot: 9
	public bool get_IsProfilerDocked() { }

	// RVA: 0x7FA9610 Offset: 0x7FA5610 VA: 0x7FA9610 Slot: 10
	public void set_IsProfilerDocked(bool value) { }

	// RVA: 0x7FA96C0 Offset: 0x7FA56C0 VA: 0x7FA96C0 Slot: 11
	public void AddSystemInfo(InfoEntry entry, string category = "Default") { }

	// RVA: 0x7FA977C Offset: 0x7FA577C VA: 0x7FA977C Slot: 12
	public void ShowDebugPanel(bool requireEntryCode = True) { }

	// RVA: 0x7FA99B8 Offset: 0x7FA59B8 VA: 0x7FA99B8 Slot: 13
	public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = True) { }

	// RVA: 0x7FA9B34 Offset: 0x7FA5B34 VA: 0x7FA9B34 Slot: 14
	public void HideDebugPanel() { }

	// RVA: 0x7FA9BDC Offset: 0x7FA5BDC VA: 0x7FA9BDC Slot: 15
	public void DestroyDebugPanel() { }

	// RVA: 0x7FA9CE8 Offset: 0x7FA5CE8 VA: 0x7FA9CE8 Slot: 16
	public void AddOptionContainer(object container) { }

	// RVA: 0x7FA9D94 Offset: 0x7FA5D94 VA: 0x7FA9D94 Slot: 17
	public void RemoveOptionContainer(object container) { }

	// RVA: 0x7FA9E40 Offset: 0x7FA5E40 VA: 0x7FA9E40 Slot: 18
	public void PinAllOptions(string category) { }

	// RVA: 0x7FAA240 Offset: 0x7FA6240 VA: 0x7FAA240 Slot: 19
	public void UnpinAllOptions(string category) { }

	// RVA: 0x7FAA63C Offset: 0x7FA663C VA: 0x7FAA63C Slot: 20
	public void PinOption(string name) { }

	// RVA: 0x7FAAA3C Offset: 0x7FA6A3C VA: 0x7FAAA3C Slot: 21
	public void UnpinOption(string name) { }

	// RVA: 0x7FAAE38 Offset: 0x7FA6E38 VA: 0x7FAAE38 Slot: 22
	public void ClearPinnedOptions() { }

	// RVA: 0x7FAAEDC Offset: 0x7FA6EDC VA: 0x7FAAEDC Slot: 23
	public void ShowBugReportSheet(ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent) { }

	// RVA: 0x7FAAFEC Offset: 0x7FA6FEC VA: 0x7FAAFEC Slot: 8
	public IDockConsoleService get_DockConsole() { }

	[CompilerGenerated]
	// RVA: 0x7FAAFF4 Offset: 0x7FA6FF4 VA: 0x7FAAFF4 Slot: 24
	public void add_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7FAB090 Offset: 0x7FA7090 VA: 0x7FAB090 Slot: 25
	public void remove_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	// RVA: 0x7FAB12C Offset: 0x7FA712C VA: 0x7FAB12C
	private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x7FA984C Offset: 0x7FA584C VA: 0x7FA984C
	private void PromptEntryCode() { }

	// RVA: 0x7FAB204 Offset: 0x7FA7204 VA: 0x7FAB204 Slot: 26
	public RectTransform EnableWorldSpaceMode() { }

	[CompilerGenerated]
	// RVA: 0x7FAB4B8 Offset: 0x7FA74B8 VA: 0x7FAB4B8
	private void <PromptEntryCode>b__39_0(bool entered) { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(IConsoleService))]
public class StandardConsoleService : IConsoleService // TypeDefIndex: 23843
{
	// Fields
	private readonly bool _collapseEnabled; // 0x10
	private bool _hasCleared; // 0x11
	private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries; // 0x18
	private CircularBuffer<ConsoleEntry> _consoleEntries; // 0x20
	private readonly object _threadLock; // 0x28
	[CompilerGenerated]
	private int <ErrorCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <WarningCount>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <InfoCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private ConsoleUpdatedEventHandler Updated; // 0x40

	// Properties
	public int ErrorCount { get; set; }
	public int WarningCount { get; set; }
	public int InfoCount { get; set; }
	public IReadOnlyList<ConsoleEntry> Entries { get; }
	public IReadOnlyList<ConsoleEntry> AllEntries { get; }

	// Methods

	// RVA: 0x7FAB588 Offset: 0x7FA7588 VA: 0x7FAB588
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7FAB710 Offset: 0x7FA7710 VA: 0x7FAB710 Slot: 4
	public int get_ErrorCount() { }

	[CompilerGenerated]
	// RVA: 0x7FAB718 Offset: 0x7FA7718 VA: 0x7FAB718
	private void set_ErrorCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x7FAB720 Offset: 0x7FA7720 VA: 0x7FAB720 Slot: 5
	public int get_WarningCount() { }

	[CompilerGenerated]
	// RVA: 0x7FAB728 Offset: 0x7FA7728 VA: 0x7FAB728
	private void set_WarningCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x7FAB730 Offset: 0x7FA7730 VA: 0x7FAB730 Slot: 6
	public int get_InfoCount() { }

	[CompilerGenerated]
	// RVA: 0x7FAB738 Offset: 0x7FA7738 VA: 0x7FAB738
	private void set_InfoCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x7FAB740 Offset: 0x7FA7740 VA: 0x7FAB740 Slot: 9
	public void add_Updated(ConsoleUpdatedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7FAB7DC Offset: 0x7FA77DC VA: 0x7FAB7DC Slot: 10
	public void remove_Updated(ConsoleUpdatedEventHandler value) { }

	// RVA: 0x7FAB878 Offset: 0x7FA7878 VA: 0x7FAB878 Slot: 7
	public IReadOnlyList<ConsoleEntry> get_Entries() { }

	// RVA: 0x7FAB894 Offset: 0x7FA7894 VA: 0x7FAB894 Slot: 8
	public IReadOnlyList<ConsoleEntry> get_AllEntries() { }

	// RVA: 0x7FAB89C Offset: 0x7FA789C VA: 0x7FAB89C Slot: 11
	public void Clear() { }

	// RVA: 0x7FABAA8 Offset: 0x7FA7AA8 VA: 0x7FABAA8
	protected void OnEntryAdded(ConsoleEntry entry) { }

	// RVA: 0x7FABCD8 Offset: 0x7FA7CD8 VA: 0x7FABCD8
	protected void OnEntryDuplicated(ConsoleEntry entry) { }

	// RVA: 0x7FABA10 Offset: 0x7FA7A10 VA: 0x7FABA10
	private void OnUpdated() { }

	// RVA: 0x7FABD90 Offset: 0x7FA7D90 VA: 0x7FABD90
	private void UnityLogCallback(string condition, string stackTrace, LogType type) { }

	// RVA: 0x7FABC84 Offset: 0x7FA7C84 VA: 0x7FABC84
	private void AdjustCounter(LogType type, int amount) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StandardSystemInformationService.<>c // TypeDefIndex: 23844
{
	// Fields
	public static readonly StandardSystemInformationService.<>c <>9; // 0x0
	public static Func<object> <>9__6_0; // 0x8
	public static Func<object> <>9__6_1; // 0x10
	public static Func<object> <>9__6_2; // 0x18
	public static Func<object> <>9__6_3; // 0x20
	public static Func<object> <>9__6_4; // 0x28
	public static Func<object> <>9__6_5; // 0x30
	public static Func<object> <>9__6_6; // 0x38
	public static Func<object> <>9__6_7; // 0x40

	// Methods

	// RVA: 0x7FAE738 Offset: 0x7FAA738 VA: 0x7FAE738
	private static void .cctor() { }

	// RVA: 0x7FAE7A0 Offset: 0x7FAA7A0 VA: 0x7FAE7A0
	public void .ctor() { }

	// RVA: 0x7FAE7A8 Offset: 0x7FAA7A8 VA: 0x7FAE7A8
	internal object <CreateDefaultSet>b__6_0() { }

	// RVA: 0x7FAE82C Offset: 0x7FAA82C VA: 0x7FAE82C
	internal object <CreateDefaultSet>b__6_1() { }

	// RVA: 0x7FAE880 Offset: 0x7FAA880 VA: 0x7FAE880
	internal object <CreateDefaultSet>b__6_2() { }

	// RVA: 0x7FAE8DC Offset: 0x7FAA8DC VA: 0x7FAE8DC
	internal object <CreateDefaultSet>b__6_3() { }

	// RVA: 0x7FAE934 Offset: 0x7FAA934 VA: 0x7FAE934
	internal object <CreateDefaultSet>b__6_4() { }

	// RVA: 0x7FAE988 Offset: 0x7FAA988 VA: 0x7FAE988
	internal object <CreateDefaultSet>b__6_5() { }

	// RVA: 0x7FAE9DC Offset: 0x7FAA9DC VA: 0x7FAE9DC
	internal object <CreateDefaultSet>b__6_6() { }

	// RVA: 0x7FAEB4C Offset: 0x7FAAB4C VA: 0x7FAEB4C
	internal object <CreateDefaultSet>b__6_7() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StandardSystemInformationService.<>c__DisplayClass4_0 // TypeDefIndex: 23845
{
	// Fields
	public InfoEntry info; // 0x10

	// Methods

	// RVA: 0x7FAE048 Offset: 0x7FAA048 VA: 0x7FAE048
	public void .ctor() { }

	// RVA: 0x7FAEC08 Offset: 0x7FAAC08 VA: 0x7FAEC08
	internal bool <Add>b__0(InfoEntry p) { }
}

// Namespace: SRDebugger.Services.Implementation
[Service(typeof(ISystemInformationService))]
public class StandardSystemInformationService : ISystemInformationService // TypeDefIndex: 23846
{
	// Fields
	private readonly Dictionary<string, IList<InfoEntry>> _info; // 0x10

	// Methods

	// RVA: 0x7FABFEC Offset: 0x7FA7FEC VA: 0x7FABFEC
	public void .ctor() { }

	// RVA: 0x7FADC28 Offset: 0x7FA9C28 VA: 0x7FADC28 Slot: 4
	public IEnumerable<string> GetCategories() { }

	// RVA: 0x7FADC78 Offset: 0x7FA9C78 VA: 0x7FADC78 Slot: 5
	public IList<InfoEntry> GetInfo(string category) { }

	// RVA: 0x7FADDD4 Offset: 0x7FA9DD4 VA: 0x7FADDD4 Slot: 6
	public void Add(InfoEntry info, string category = "Default") { }

	// RVA: 0x7FAE050 Offset: 0x7FAA050 VA: 0x7FAE050 Slot: 7
	public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = False) { }

	// RVA: 0x7FAC07C Offset: 0x7FA807C VA: 0x7FAC07C
	private void CreateDefaultSet() { }

	// RVA: 0x7FAE5B8 Offset: 0x7FAA5B8 VA: 0x7FAE5B8
	private static string GetCloudManifestPrettyName(string name) { }
}

// Namespace: SRDebugger.Profiler
[RequireComponent(typeof(Camera))]
public class ProfilerCameraListener : MonoBehaviour // TypeDefIndex: 23847
{
	// Fields
	private Camera _camera; // 0x20
	private Stopwatch _stopwatch; // 0x28
	public Action<ProfilerCameraListener, double> RenderDurationCallback; // 0x30

	// Properties
	protected Stopwatch Stopwatch { get; }
	public Camera Camera { get; }

	// Methods

	// RVA: 0x7FAEC30 Offset: 0x7FAAC30 VA: 0x7FAEC30
	protected Stopwatch get_Stopwatch() { }

	// RVA: 0x7FAECA0 Offset: 0x7FAACA0 VA: 0x7FAECA0
	public Camera get_Camera() { }

	// RVA: 0x7FAED48 Offset: 0x7FAAD48 VA: 0x7FAED48
	private void OnPreCull() { }

	// RVA: 0x7FAED80 Offset: 0x7FAAD80 VA: 0x7FAED80
	private void OnPostRender() { }

	// RVA: 0x7FAEE98 Offset: 0x7FAAE98 VA: 0x7FAEE98
	public void .ctor() { }
}

// Namespace: SRDebugger.Profiler
public class ProfilerLateUpdateListener : MonoBehaviour // TypeDefIndex: 23848
{
	// Fields
	public Action OnLateUpdate; // 0x20

	// Methods

	// RVA: 0x7FAEEA0 Offset: 0x7FAAEA0 VA: 0x7FAEEA0
	private void LateUpdate() { }

	// RVA: 0x7FAEEBC Offset: 0x7FAAEBC VA: 0x7FAEEBC
	public void .ctor() { }
}

// Namespace: SRDebugger.Profiler
[Service(typeof(IProfilerService))]
public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 23849
{
	// Fields
	private const int FrameBufferSize = 400;
	private readonly SRList<ProfilerCameraListener> _cameraListeners; // 0x50
	private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x58
	private Camera[] _cameraCache; // 0x60
	private ProfilerLateUpdateListener _lateUpdateListener; // 0x68
	private double _renderDuration; // 0x70
	private int _reportedCameras; // 0x78
	private Stopwatch _stopwatch; // 0x80
	private double _updateDuration; // 0x88
	private double _updateToRenderDuration; // 0x90
	[CompilerGenerated]
	private float <AverageFrameTime>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <LastFrameTime>k__BackingField; // 0x9C

	// Properties
	public float AverageFrameTime { get; set; }
	public float LastFrameTime { get; set; }
	public CircularBuffer<ProfilerFrame> FrameBuffer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7FAEEC4 Offset: 0x7FAAEC4 VA: 0x7FAEEC4 Slot: 11
	public float get_AverageFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x7FAEECC Offset: 0x7FAAECC VA: 0x7FAEECC
	private void set_AverageFrameTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x7FAEED4 Offset: 0x7FAAED4 VA: 0x7FAEED4 Slot: 12
	public float get_LastFrameTime() { }

	[CompilerGenerated]
	// RVA: 0x7FAEEDC Offset: 0x7FAAEDC VA: 0x7FAEEDC
	private void set_LastFrameTime(float value) { }

	// RVA: 0x7FAEEE4 Offset: 0x7FAAEE4 VA: 0x7FAEEE4 Slot: 13
	public CircularBuffer<ProfilerFrame> get_FrameBuffer() { }

	// RVA: 0x7FAEEEC Offset: 0x7FAAEEC VA: 0x7FAEEEC
	protected void PushFrame(double totalTime, double updateTime, double renderTime) { }

	// RVA: 0x7FAEF6C Offset: 0x7FAAF6C VA: 0x7FAEF6C Slot: 4
	protected override void Awake() { }

	// RVA: 0x7FAF0E8 Offset: 0x7FAB0E8 VA: 0x7FAF0E8 Slot: 6
	protected override void Update() { }

	// RVA: 0x7FAF5B8 Offset: 0x7FAB5B8 VA: 0x7FAF5B8
	private void OnLateUpdate() { }

	// RVA: 0x7FAF634 Offset: 0x7FAB634 VA: 0x7FAF634
	private void EndFrame() { }

	// RVA: 0x7FAF6E4 Offset: 0x7FAB6E4 VA: 0x7FAF6E4
	private void CameraDurationCallback(ProfilerCameraListener listener, double duration) { }

	// RVA: 0x7FAF794 Offset: 0x7FAB794 VA: 0x7FAF794
	private int GetExpectedCameraCount() { }

	// RVA: 0x7FAF2B4 Offset: 0x7FAB2B4 VA: 0x7FAF2B4
	private void CameraCheck() { }

	// RVA: 0x7FAF8C0 Offset: 0x7FAB8C0 VA: 0x7FAF8C0
	public void .ctor() { }
}

// Namespace: SRDebugger.Internal
public static class SRDebugApi // TypeDefIndex: 23850
{
	// Fields
	public const string Protocol = "http://";
	public const string EndPoint = "http://srdebugger.stompyrobot.uk";
	public const string BugReportEndPoint = "http://srdebugger.stompyrobot.uk/report/submit";
}

// Namespace: SRDebugger.Internal
public static class SRDebugApiUtil // TypeDefIndex: 23851
{
	// Methods

	// RVA: 0x7FAFA24 Offset: 0x7FABA24 VA: 0x7FAFA24
	public static string ParseErrorException(WebException ex) { }

	// RVA: 0x7FAFE08 Offset: 0x7FABE08 VA: 0x7FAFE08
	public static string ParseErrorResponse(string response, string fallback = "Unexpected Response") { }

	// RVA: 0x7FB03A8 Offset: 0x7FAC3A8 VA: 0x7FB03A8
	public static bool ReadResponse(HttpWebRequest request, out string result) { }

	// RVA: 0x7FAFB08 Offset: 0x7FABB08 VA: 0x7FAFB08
	public static string ReadResponseStream(WebResponse stream) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BugReportApi.<Submit>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23852
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BugReportApi <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7FB04C0 Offset: 0x7FAC4C0 VA: 0x7FB04C0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7FB0DB8 Offset: 0x7FACDB8 VA: 0x7FB0DB8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7FB0DBC Offset: 0x7FACDBC VA: 0x7FB0DBC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7FB128C Offset: 0x7FAD28C VA: 0x7FB128C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7FB1294 Offset: 0x7FAD294 VA: 0x7FB1294 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7FB12CC Offset: 0x7FAD2CC VA: 0x7FB12CC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.Internal
public class BugReportApi // TypeDefIndex: 23853
{
	// Fields
	private readonly string _apiKey; // 0x10
	private readonly BugReport _bugReport; // 0x18
	private bool _isBusy; // 0x20
	private WWW _www; // 0x28
	[CompilerGenerated]
	private bool <IsComplete>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <WasSuccessful>k__BackingField; // 0x31
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; // 0x38

	// Properties
	public bool IsComplete { get; set; }
	public bool WasSuccessful { get; set; }
	public string ErrorMessage { get; set; }
	public float Progress { get; }

	// Methods

	// RVA: 0x7FA2EE0 Offset: 0x7F9EEE0 VA: 0x7FA2EE0
	public void .ctor(BugReport report, string apiKey) { }

	[CompilerGenerated]
	// RVA: 0x7FB0488 Offset: 0x7FAC488 VA: 0x7FB0488
	public bool get_IsComplete() { }

	[CompilerGenerated]
	// RVA: 0x7FB0490 Offset: 0x7FAC490 VA: 0x7FB0490
	private void set_IsComplete(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7FB049C Offset: 0x7FAC49C VA: 0x7FB049C
	public bool get_WasSuccessful() { }

	[CompilerGenerated]
	// RVA: 0x7FB04A4 Offset: 0x7FAC4A4 VA: 0x7FB04A4
	private void set_WasSuccessful(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7FB04B0 Offset: 0x7FAC4B0 VA: 0x7FB04B0
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	// RVA: 0x7FB04B8 Offset: 0x7FAC4B8 VA: 0x7FB04B8
	private void set_ErrorMessage(string value) { }

	// RVA: 0x7FA3198 Offset: 0x7F9F198 VA: 0x7FA3198
	public float get_Progress() { }

	[IteratorStateMachine(typeof(BugReportApi.<Submit>d__19))]
	// RVA: 0x7FA2F24 Offset: 0x7F9EF24 VA: 0x7FA2F24
	public IEnumerator Submit() { }

	// RVA: 0x7FB04E8 Offset: 0x7FAC4E8 VA: 0x7FB04E8
	private void SetCompletionState(bool wasSuccessful) { }

	// RVA: 0x7FB05AC Offset: 0x7FAC5AC VA: 0x7FB05AC
	private static string BuildJsonRequest(BugReport report) { }

	// RVA: 0x7FB0748 Offset: 0x7FAC748 VA: 0x7FB0748
	private static IList<IList<string>> CreateConsoleDump() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23854
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7FB132C Offset: 0x7FAD32C VA: 0x7FB132C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7FB135C Offset: 0x7FAD35C VA: 0x7FB135C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7FB1360 Offset: 0x7FAD360 VA: 0x7FB1360 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7FB155C Offset: 0x7FAD55C VA: 0x7FB155C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7FB1564 Offset: 0x7FAD564 VA: 0x7FB1564 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7FB159C Offset: 0x7FAD59C VA: 0x7FB159C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: SRDebugger.Internal
public class BugReportScreenshotUtil // TypeDefIndex: 23855
{
	// Fields
	public static byte[] ScreenshotData; // 0x0

	// Methods

	[IteratorStateMachine(typeof(BugReportScreenshotUtil.<ScreenshotCaptureCo>d__1))]
	// RVA: 0x7FB12D4 Offset: 0x7FAD2D4 VA: 0x7FB12D4
	public static IEnumerator ScreenshotCaptureCo() { }

	// RVA: 0x7FB1354 Offset: 0x7FAD354 VA: 0x7FB1354
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OptionControlFactory.<>c__DisplayClass4_0 // TypeDefIndex: 23856
{
	// Fields
	public OptionDefinition from; // 0x10

	// Methods

	// RVA: 0x7FB1D64 Offset: 0x7FADD64 VA: 0x7FB1D64
	public void .ctor() { }

	// RVA: 0x7FB1D6C Offset: 0x7FADD6C VA: 0x7FB1D6C
	internal bool <CreateDataControl>b__0(DataBoundControl p) { }
}

// Namespace: SRDebugger.Internal
public static class OptionControlFactory // TypeDefIndex: 23857
{
	// Fields
	private static IList<DataBoundControl> _dataControlPrefabs; // 0x0
	private static ActionControl _actionControlPrefab; // 0x8

	// Methods

	// RVA: 0x7FB15A4 Offset: 0x7FAD5A4 VA: 0x7FB15A4
	public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix) { }

	// RVA: 0x7FB1C34 Offset: 0x7FADC34 VA: 0x7FB1C34
	private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix) { }

	// RVA: 0x7FB17E4 Offset: 0x7FAD7E4 VA: 0x7FB17E4
	private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix) { }
}

// Namespace: SRDebugger.Internal
public class OptionDefinition // TypeDefIndex: 23858
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Category>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <SortPriority>k__BackingField; // 0x20
	[CompilerGenerated]
	private MethodReference <Method>k__BackingField; // 0x28
	[CompilerGenerated]
	private PropertyReference <Property>k__BackingField; // 0x30

	// Properties
	public string Name { get; set; }
	public string Category { get; set; }
	public int SortPriority { get; set; }
	public MethodReference Method { get; set; }
	public PropertyReference Property { get; set; }

	// Methods

	// RVA: 0x7FB1DE0 Offset: 0x7FADDE0 VA: 0x7FB1DE0
	private void .ctor(string name, string category, int sortPriority) { }

	// RVA: 0x7FB1E38 Offset: 0x7FADE38 VA: 0x7FB1E38
	public void .ctor(string name, string category, int sortPriority, MethodReference method) { }

	// RVA: 0x7FB1E64 Offset: 0x7FADE64 VA: 0x7FB1E64
	public void .ctor(string name, string category, int sortPriority, PropertyReference property) { }

	[CompilerGenerated]
	// RVA: 0x7FB1E90 Offset: 0x7FADE90 VA: 0x7FB1E90
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x7FB1E98 Offset: 0x7FADE98 VA: 0x7FB1E98
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x7FB1EA0 Offset: 0x7FADEA0 VA: 0x7FB1EA0
	public string get_Category() { }

	[CompilerGenerated]
	// RVA: 0x7FB1EA8 Offset: 0x7FADEA8 VA: 0x7FB1EA8
	private void set_Category(string value) { }

	[CompilerGenerated]
	// RVA: 0x7FB1EB0 Offset: 0x7FADEB0 VA: 0x7FB1EB0
	public int get_SortPriority() { }

	[CompilerGenerated]
	// RVA: 0x7FB1EB8 Offset: 0x7FADEB8 VA: 0x7FB1EB8
	private void set_SortPriority(int value) { }

	[CompilerGenerated]
	// RVA: 0x7FB1EC0 Offset: 0x7FADEC0 VA: 0x7FB1EC0
	public MethodReference get_Method() { }

	[CompilerGenerated]
	// RVA: 0x7FB1EC8 Offset: 0x7FADEC8 VA: 0x7FB1EC8
	private void set_Method(MethodReference value) { }

	[CompilerGenerated]
	// RVA: 0x7FB1ED0 Offset: 0x7FADED0 VA: 0x7FB1ED0
	public PropertyReference get_Property() { }

	[CompilerGenerated]
	// RVA: 0x7FB1ED8 Offset: 0x7FADED8 VA: 0x7FB1ED8
	private void set_Property(PropertyReference value) { }
}

// Namespace: SRDebugger.Internal
public static class SRDebugPaths // TypeDefIndex: 23859
{
	// Fields
	public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options";
	public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger";
	public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel";
	public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI";
	public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole";
	public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry";
	public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover";
	public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet";
	public const string SettingsMenuItemPath = "Window/SRDebugger/Settings Window";
	public const string WelcomeItemPath = "Window/SRDebugger/Welcome Guide";
	public const string SROptionsMenuItemPath = "Window/SRDebugger/SROptions Window";
	public const string EditorLogoPath = "UI/Sprites/Default/Logo.psd";
}

// Namespace: SRDebugger.Internal
public static class Service // TypeDefIndex: 23860
{
	// Fields
	private static IConsoleService _consoleService; // 0x0
	private static IDebugPanelService _debugPanelService; // 0x8
	private static IDebugTriggerService _debugTriggerService; // 0x10
	private static IPinnedUIService _pinnedUiService; // 0x18
	private static IDebugCameraService _debugCameraService; // 0x20
	private static IOptionsService _optionsService; // 0x28
	private static IDockConsoleService _dockConsoleService; // 0x30

	// Properties
	public static IConsoleService Console { get; }
	public static IDockConsoleService DockConsole { get; }
	public static IDebugPanelService Panel { get; }
	public static IDebugTriggerService Trigger { get; }
	public static IPinnedUIService PinnedUI { get; }
	public static IDebugCameraService DebugCamera { get; }
	public static IOptionsService Options { get; }

	// Methods

	// RVA: 0x7FB1EE0 Offset: 0x7FADEE0 VA: 0x7FB1EE0
	public static IConsoleService get_Console() { }

	// RVA: 0x7FB1F70 Offset: 0x7FADF70 VA: 0x7FB1F70
	public static IDockConsoleService get_DockConsole() { }

	// RVA: 0x7FB1FFC Offset: 0x7FADFFC VA: 0x7FB1FFC
	public static IDebugPanelService get_Panel() { }

	// RVA: 0x7FB2088 Offset: 0x7FAE088 VA: 0x7FB2088
	public static IDebugTriggerService get_Trigger() { }

	// RVA: 0x7FB2114 Offset: 0x7FAE114 VA: 0x7FB2114
	public static IPinnedUIService get_PinnedUI() { }

	// RVA: 0x7FB21A0 Offset: 0x7FAE1A0 VA: 0x7FB21A0
	public static IDebugCameraService get_DebugCamera() { }

	// RVA: 0x7FB222C Offset: 0x7FAE22C VA: 0x7FB222C
	public static IOptionsService get_Options() { }
}

// Namespace: SRDebugger.Internal
public class SRDebugStrings // TypeDefIndex: 23861
{
	// Fields
	public static readonly SRDebugStrings Current; // 0x0
	public readonly string Console_MessageTruncated; // 0x10
	public readonly string Console_NoStackTrace; // 0x18
	public readonly string PinEntryPrompt; // 0x20
	public readonly string Profiler_DisableProfilerInfo; // 0x28
	public readonly string Profiler_EnableProfilerInfo; // 0x30
	public readonly string Profiler_NoProInfo; // 0x38
	public readonly string Profiler_NotSupported; // 0x40
	public readonly string ProfilerCameraListenerHelp; // 0x48

	// Methods

	// RVA: 0x7FB22B8 Offset: 0x7FAE2B8 VA: 0x7FB22B8
	public void .ctor() { }

	// RVA: 0x7FB242C Offset: 0x7FAE42C VA: 0x7FB242C
	private static void .cctor() { }
}

// Namespace: SRDebugger.Internal
public static class SRDebuggerUtil // TypeDefIndex: 23862
{
	// Properties
	public static bool IsMobilePlatform { get; }

	// Methods

	// RVA: 0x7FB2490 Offset: 0x7FAE490 VA: 0x7FB2490
	public static bool get_IsMobilePlatform() { }

	// RVA: 0x7FB2514 Offset: 0x7FAE514 VA: 0x7FB2514
	public static bool EnsureEventSystemExists() { }

	// RVA: 0x7FB2684 Offset: 0x7FAE684 VA: 0x7FB2684
	public static void CreateDefaultEventSystem() { }

	// RVA: 0x7FB2730 Offset: 0x7FAE730 VA: 0x7FB2730
	public static ICollection<OptionDefinition> ScanForOptions(object obj) { }

	// RVA: 0x7FB2BBC Offset: 0x7FAEBBC VA: 0x7FB2BBC
	public static string GetNumberString(int value, int max, string exceedsMaxString) { }

	// RVA: 0x7FB2BE8 Offset: 0x7FAEBE8 VA: 0x7FB2BE8
	public static void ConfigureCanvas(Canvas canvas) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 23863
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6537 // TypeDefIndex: 23864
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12039 // TypeDefIndex: 23865
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 23866
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0B92E635AE849B517CA3A2F28C2502AF8675E5C6C01CD75EA9F53120E81DDAAA /*Metadata offset 0xF2C198*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6537 82CFA7DF226CEB62C138414C3DD17A0D1E6AAF42924D38E823A53D25172221FF /*Metadata offset 0xF2C1C0*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12039 957C9865EB1BDF13F78417C4EE67D1BA23DE62ABA9DD2D6349FD951F2D650F61 /*Metadata offset 0xF2DB50*/; // 0x19AD
}

