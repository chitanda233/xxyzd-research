// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27178
{}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJvalue")]
public struct jvalue // TypeDefIndex: 27179
{
	// Fields
	public bool z; // 0x0
	public sbyte b; // 0x0
	public char c; // 0x0
	public short s; // 0x0
	public int i; // 0x0
	public long j; // 0x0
	public float f; // 0x0
	public double d; // 0x0
	public IntPtr l; // 0x0
}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJNINativeMethod")]
public struct JNINativeMethod // TypeDefIndex: 27180
{
	// Fields
	public string name; // 0x0
	public string signature; // 0x8
	public IntPtr fnPtr; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[NativeConditional("PLATFORM_ANDROID")]
[UsedByNativeCode]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
public static class AndroidJNIHelper // TypeDefIndex: 27181
{
	// Properties
	public static bool debug { get; set; }

	// Methods

	// RVA: 0x86BD9C8 Offset: 0x86B99C8 VA: 0x86BD9C8
	public static bool get_debug() { }

	// RVA: 0x86BD9F0 Offset: 0x86B99F0 VA: 0x86BD9F0
	public static void set_debug(bool value) { }

	// RVA: 0x86BDA2C Offset: 0x86B9A2C VA: 0x86BDA2C
	public static IntPtr GetConstructorID(IntPtr javaClass) { }

	// RVA: 0x86BDA74 Offset: 0x86B9A74 VA: 0x86BDA74
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x86BDC40 Offset: 0x86B9C40 VA: 0x86BDC40
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName) { }

	// RVA: 0x86BDCA4 Offset: 0x86B9CA4 VA: 0x86BDCA4
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature) { }

	// RVA: 0x86BDC9C Offset: 0x86B9C9C VA: 0x86BDC9C
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x86BDE84 Offset: 0x86B9E84 VA: 0x86BDE84
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName) { }

	// RVA: 0x86BDEE8 Offset: 0x86B9EE8 VA: 0x86BDEE8
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature) { }

	// RVA: 0x86BDEE0 Offset: 0x86B9EE0 VA: 0x86BDEE0
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x86BE1C8 Offset: 0x86BA1C8 VA: 0x86BE1C8
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x86BE224 Offset: 0x86BA224 VA: 0x86BE224
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x86BE3C8 Offset: 0x86BA3C8 VA: 0x86BE3C8
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x86BEF9C Offset: 0x86BAF9C VA: 0x86BEF9C
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x86BF5AC Offset: 0x86BB5AC VA: 0x86BF5AC
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x86BF6BC Offset: 0x86BB6BC VA: 0x86BF6BC
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x86BF880 Offset: 0x86BB880 VA: 0x86BF880
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x86BF884 Offset: 0x86BB884 VA: 0x86BF884
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x86BF8C4 Offset: 0x86BB8C4 VA: 0x86BF8C4
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x86BF934 Offset: 0x86BB934 VA: 0x86BF934
	public static string GetSignature(object obj) { }

	// RVA: 0x86C0854 Offset: 0x86BC854 VA: 0x86C0854
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B0F8 Offset: 0x46070F8 VA: 0x460B0F8
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x460B130 Offset: 0x4607130 VA: 0x460B130
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x460B168 Offset: 0x4607168 VA: 0x460B168
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x460B1A0 Offset: 0x46071A0 VA: 0x460B1A0
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x460B1D8 Offset: 0x46071D8 VA: 0x460B1D8
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x460B210 Offset: 0x4607210 VA: 0x460B210
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x460B248 Offset: 0x4607248 VA: 0x460B248
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x460B280 Offset: 0x4607280 VA: 0x460B280
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x460B2B8 Offset: 0x46072B8 VA: 0x460B2B8
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x460B2F0 Offset: 0x46072F0 VA: 0x460B2F0
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B53C Offset: 0x460753C VA: 0x460B53C
	|-AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x460B594 Offset: 0x4607594 VA: 0x460B594
	|-AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x460B5EC Offset: 0x46075EC VA: 0x460B5EC
	|-AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x460B644 Offset: 0x4607644 VA: 0x460B644
	|-AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x460B69C Offset: 0x460769C VA: 0x460B69C
	|-AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x460B6F4 Offset: 0x46076F4 VA: 0x460B6F4
	|-AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x460B74C Offset: 0x460774C VA: 0x460B74C
	|-AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x460B7A4 Offset: 0x46077A4 VA: 0x460B7A4
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x460B7FC Offset: 0x46077FC VA: 0x460B7FC
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x460B854 Offset: 0x4607854 VA: 0x460B854
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B3F8 Offset: 0x46073F8 VA: 0x460B3F8
	|-AndroidJNIHelper.GetFieldID<bool>
	|
	|-RVA: 0x460B448 Offset: 0x4607448 VA: 0x460B448
	|-AndroidJNIHelper.GetFieldID<int>
	|
	|-RVA: 0x460B498 Offset: 0x4607498 VA: 0x460B498
	|-AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x460B4E8 Offset: 0x46074E8 VA: 0x460B4E8
	|-AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B8B0 Offset: 0x46078B0 VA: 0x460B8B0
	|-AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86C097C Offset: 0x86BC97C VA: 0x86C097C
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x86C0C4C Offset: 0x86BCC4C VA: 0x86C0C4C
	public static IntPtr Box(sbyte value) { }

	// RVA: 0x86C0CB4 Offset: 0x86BCCB4 VA: 0x86C0CB4
	public static IntPtr Box(short value) { }

	// RVA: 0x86C0D1C Offset: 0x86BCD1C VA: 0x86C0D1C
	public static IntPtr Box(int value) { }

	// RVA: 0x86C0D84 Offset: 0x86BCD84 VA: 0x86C0D84
	public static IntPtr Box(long value) { }

	// RVA: 0x86C0DEC Offset: 0x86BCDEC VA: 0x86C0DEC
	public static IntPtr Box(float value) { }

	// RVA: 0x86C0E54 Offset: 0x86BCE54 VA: 0x86C0E54
	public static IntPtr Box(double value) { }

	// RVA: 0x86C0EBC Offset: 0x86BCEBC VA: 0x86C0EBC
	public static IntPtr Box(char value) { }

	// RVA: 0x86C0F24 Offset: 0x86BCF24 VA: 0x86C0F24
	public static IntPtr Box(bool value) { }

	// RVA: 0x86C0F8C Offset: 0x86BCF8C VA: 0x86C0F8C
	private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature) { }

	// RVA: 0x86C1180 Offset: 0x86BD180 VA: 0x86C1180
	public static void Unbox(IntPtr obj, out sbyte value) { }

	// RVA: 0x86C1280 Offset: 0x86BD280 VA: 0x86C1280
	public static void Unbox(IntPtr obj, out short value) { }

	// RVA: 0x86C1380 Offset: 0x86BD380 VA: 0x86C1380
	public static void Unbox(IntPtr obj, out int value) { }

	// RVA: 0x86C1480 Offset: 0x86BD480 VA: 0x86C1480
	public static void Unbox(IntPtr obj, out long value) { }

	// RVA: 0x86C1580 Offset: 0x86BD580 VA: 0x86C1580
	public static void Unbox(IntPtr obj, out float value) { }

	// RVA: 0x86C168C Offset: 0x86BD68C VA: 0x86C168C
	public static void Unbox(IntPtr obj, out double value) { }

	// RVA: 0x86C1798 Offset: 0x86BD798 VA: 0x86C1798
	public static void Unbox(IntPtr obj, out char value) { }

	// RVA: 0x86C1898 Offset: 0x86BD898 VA: 0x86C1898
	public static void Unbox(IntPtr obj, out bool value) { }
}

// Namespace: UnityEngine
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
public static class AndroidJNI // TypeDefIndex: 27182
{
	// Methods

	[StaticAccessor("jni", 2)]
	[ThreadSafe]
	// RVA: 0x86C199C Offset: 0x86BD99C VA: 0x86C199C
	public static IntPtr GetJavaVM() { }

	[ThreadSafe]
	// RVA: 0x86C19C4 Offset: 0x86BD9C4 VA: 0x86C19C4
	public static int AttachCurrentThread() { }

	[ThreadSafe]
	// RVA: 0x86C19EC Offset: 0x86BD9EC VA: 0x86C19EC
	public static int DetachCurrentThread() { }

	[ThreadSafe]
	// RVA: 0x86C1A14 Offset: 0x86BDA14 VA: 0x86C1A14
	public static int GetVersion() { }

	[ThreadSafe]
	// RVA: 0x86C1A3C Offset: 0x86BDA3C VA: 0x86C1A3C
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x86C1A78 Offset: 0x86BDA78 VA: 0x86C1A78
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x86C1AB4 Offset: 0x86BDAB4 VA: 0x86C1AB4
	public static IntPtr FromReflectedField(IntPtr refField) { }

	[ThreadSafe]
	// RVA: 0x86C1AF0 Offset: 0x86BDAF0 VA: 0x86C1AF0
	public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x86C1B44 Offset: 0x86BDB44 VA: 0x86C1B44
	public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x86C1B98 Offset: 0x86BDB98 VA: 0x86C1B98
	public static IntPtr GetSuperclass(IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x86C1BD4 Offset: 0x86BDBD4 VA: 0x86C1BD4
	public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2) { }

	[ThreadSafe]
	// RVA: 0x86C1C18 Offset: 0x86BDC18 VA: 0x86C1C18
	public static int Throw(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1C54 Offset: 0x86BDC54 VA: 0x86C1C54
	public static int ThrowNew(IntPtr clazz, string message) { }

	[ThreadSafe]
	// RVA: 0x86C1C98 Offset: 0x86BDC98 VA: 0x86C1C98
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x86C1CC0 Offset: 0x86BDCC0 VA: 0x86C1CC0
	public static void ExceptionDescribe() { }

	[ThreadSafe]
	// RVA: 0x86C1CE8 Offset: 0x86BDCE8 VA: 0x86C1CE8
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x86C1D10 Offset: 0x86BDD10 VA: 0x86C1D10
	public static void FatalError(string message) { }

	[ThreadSafe]
	// RVA: 0x86C1D4C Offset: 0x86BDD4C VA: 0x86C1D4C
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	// RVA: 0x86C1D88 Offset: 0x86BDD88 VA: 0x86C1D88
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	// RVA: 0x86C1DC4 Offset: 0x86BDDC4 VA: 0x86C1DC4
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1E00 Offset: 0x86BDE00 VA: 0x86C1E00
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1E3C Offset: 0x86BDE3C VA: 0x86C1E3C
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1E78 Offset: 0x86BDE78 VA: 0x86C1E78
	internal static uint GetQueueGlobalRefsCount() { }

	[ThreadSafe]
	// RVA: 0x86C1EA0 Offset: 0x86BDEA0 VA: 0x86C1EA0
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1EDC Offset: 0x86BDEDC VA: 0x86C1EDC
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1F18 Offset: 0x86BDF18 VA: 0x86C1F18
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1F54 Offset: 0x86BDF54 VA: 0x86C1F54
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C1F90 Offset: 0x86BDF90 VA: 0x86C1F90
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[ThreadSafe]
	// RVA: 0x86C1FD4 Offset: 0x86BDFD4 VA: 0x86C1FD4
	public static int EnsureLocalCapacity(int capacity) { }

	[ThreadSafe]
	// RVA: 0x86C2010 Offset: 0x86BE010 VA: 0x86C2010
	public static IntPtr AllocObject(IntPtr clazz) { }

	// RVA: 0x86C204C Offset: 0x86BE04C VA: 0x86C204C
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C20B4 Offset: 0x86BE0B4 VA: 0x86C20B4
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C214C Offset: 0x86BE14C VA: 0x86C214C
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x86C21A0 Offset: 0x86BE1A0 VA: 0x86C21A0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C21DC Offset: 0x86BE1DC VA: 0x86C21DC
	public static bool IsInstanceOf(IntPtr obj, IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x86C2220 Offset: 0x86BE220 VA: 0x86C2220
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x86C2274 Offset: 0x86BE274 VA: 0x86C2274
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x86C22C8 Offset: 0x86BE2C8 VA: 0x86C22C8
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x86C231C Offset: 0x86BE31C VA: 0x86C231C
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x86C2370 Offset: 0x86BE370 VA: 0x86C2370
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x86C23AC Offset: 0x86BE3AC VA: 0x86C23AC
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	// RVA: 0x86C23E8 Offset: 0x86BE3E8 VA: 0x86C23E8
	public static IntPtr NewString(char[] chars) { }

	[ThreadSafe]
	// RVA: 0x86C2424 Offset: 0x86BE424 VA: 0x86C2424
	public static IntPtr NewStringUTF(string bytes) { }

	[ThreadSafe]
	// RVA: 0x86C2460 Offset: 0x86BE460 VA: 0x86C2460
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x86C249C Offset: 0x86BE49C VA: 0x86C249C
	public static int GetStringLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x86C24D8 Offset: 0x86BE4D8 VA: 0x86C24D8
	public static int GetStringUTFLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x86C2514 Offset: 0x86BE514 VA: 0x86C2514
	public static string GetStringUTFChars(IntPtr str) { }

	// RVA: 0x86C2550 Offset: 0x86BE550 VA: 0x86C2550
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C25B8 Offset: 0x86BE5B8 VA: 0x86C25B8
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2650 Offset: 0x86BE650 VA: 0x86C2650
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C26A4 Offset: 0x86BE6A4 VA: 0x86C26A4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C270C Offset: 0x86BE70C VA: 0x86C270C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C27A4 Offset: 0x86BE7A4 VA: 0x86C27A4
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C27F8 Offset: 0x86BE7F8 VA: 0x86C27F8
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2860 Offset: 0x86BE860 VA: 0x86C2860
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C28F8 Offset: 0x86BE8F8 VA: 0x86C28F8
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C294C Offset: 0x86BE94C VA: 0x86C294C
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C29B4 Offset: 0x86BE9B4 VA: 0x86C29B4
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2A50 Offset: 0x86BEA50 VA: 0x86C2A50
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C2AA4 Offset: 0x86BEAA4 VA: 0x86C2AA4
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2B0C Offset: 0x86BEB0C VA: 0x86C2B0C
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2BA4 Offset: 0x86BEBA4 VA: 0x86C2BA4
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
	// RVA: 0x86C2BF8 Offset: 0x86BEBF8 VA: 0x86C2BF8
	public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2BFC Offset: 0x86BEBFC VA: 0x86C2BFC
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2C64 Offset: 0x86BEC64 VA: 0x86C2C64
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2CFC Offset: 0x86BECFC VA: 0x86C2CFC
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C2D50 Offset: 0x86BED50 VA: 0x86C2D50
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2DB8 Offset: 0x86BEDB8 VA: 0x86C2DB8
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2E50 Offset: 0x86BEE50 VA: 0x86C2E50
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C2EA4 Offset: 0x86BEEA4 VA: 0x86C2EA4
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C2F0C Offset: 0x86BEF0C VA: 0x86C2F0C
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C2FA4 Offset: 0x86BEFA4 VA: 0x86C2FA4
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C2FF8 Offset: 0x86BEFF8 VA: 0x86C2FF8
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3060 Offset: 0x86BF060 VA: 0x86C3060
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C30F8 Offset: 0x86BF0F8 VA: 0x86C30F8
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C314C Offset: 0x86BF14C VA: 0x86C314C
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C31B4 Offset: 0x86BF1B4 VA: 0x86C31B4
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C324C Offset: 0x86BF24C VA: 0x86C324C
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C32A0 Offset: 0x86BF2A0 VA: 0x86C32A0
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3308 Offset: 0x86BF308 VA: 0x86C3308
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C33A0 Offset: 0x86BF3A0 VA: 0x86C33A0
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x86C33F4 Offset: 0x86BF3F4 VA: 0x86C33F4
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C3438 Offset: 0x86BF438 VA: 0x86C3438
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C347C Offset: 0x86BF47C VA: 0x86C347C
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
	// RVA: 0x86C34C0 Offset: 0x86BF4C0 VA: 0x86C34C0
	public static byte GetByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C3504 Offset: 0x86BF504 VA: 0x86C3504
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C3548 Offset: 0x86BF548 VA: 0x86C3548
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C358C Offset: 0x86BF58C VA: 0x86C358C
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C35D0 Offset: 0x86BF5D0 VA: 0x86C35D0
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C3614 Offset: 0x86BF614 VA: 0x86C3614
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C3658 Offset: 0x86BF658 VA: 0x86C3658
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C369C Offset: 0x86BF69C VA: 0x86C369C
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C36E0 Offset: 0x86BF6E0 VA: 0x86C36E0
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x86C3734 Offset: 0x86BF734 VA: 0x86C3734
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x86C3788 Offset: 0x86BF788 VA: 0x86C3788
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
	// RVA: 0x86C37DC Offset: 0x86BF7DC VA: 0x86C37DC
	public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x86C3830 Offset: 0x86BF830 VA: 0x86C3830
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x86C3884 Offset: 0x86BF884 VA: 0x86C3884
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x86C38D8 Offset: 0x86BF8D8 VA: 0x86C38D8
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x86C392C Offset: 0x86BF92C VA: 0x86C392C
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x86C3980 Offset: 0x86BF980 VA: 0x86C3980
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x86C39D4 Offset: 0x86BF9D4 VA: 0x86C39D4
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x86C3A28 Offset: 0x86BFA28 VA: 0x86C3A28
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x86C3A7C Offset: 0x86BFA7C VA: 0x86C3A7C
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3AE4 Offset: 0x86BFAE4 VA: 0x86C3AE4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C3B7C Offset: 0x86BFB7C VA: 0x86C3B7C
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C3BD0 Offset: 0x86BFBD0 VA: 0x86C3BD0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3C38 Offset: 0x86BFC38 VA: 0x86C3C38
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C3CD0 Offset: 0x86BFCD0 VA: 0x86C3CD0
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C3D24 Offset: 0x86BFD24 VA: 0x86C3D24
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3D8C Offset: 0x86BFD8C VA: 0x86C3D8C
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C3E24 Offset: 0x86BFE24 VA: 0x86C3E24
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C3E78 Offset: 0x86BFE78 VA: 0x86C3E78
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C3EE0 Offset: 0x86BFEE0 VA: 0x86C3EE0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C3F7C Offset: 0x86BFF7C VA: 0x86C3F7C
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C3FD0 Offset: 0x86BFFD0 VA: 0x86C3FD0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C4038 Offset: 0x86C0038 VA: 0x86C4038
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C40D0 Offset: 0x86C00D0 VA: 0x86C40D0
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
	// RVA: 0x86C4124 Offset: 0x86C0124 VA: 0x86C4124
	public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C4128 Offset: 0x86C0128 VA: 0x86C4128
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C4190 Offset: 0x86C0190 VA: 0x86C4190
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C4228 Offset: 0x86C0228 VA: 0x86C4228
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C427C Offset: 0x86C027C VA: 0x86C427C
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C42E4 Offset: 0x86C02E4 VA: 0x86C42E4
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C437C Offset: 0x86C037C VA: 0x86C437C
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C43D0 Offset: 0x86C03D0 VA: 0x86C43D0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C4438 Offset: 0x86C0438 VA: 0x86C4438
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C44D0 Offset: 0x86C04D0 VA: 0x86C44D0
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C4524 Offset: 0x86C0524 VA: 0x86C4524
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C458C Offset: 0x86C058C VA: 0x86C458C
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C4624 Offset: 0x86C0624 VA: 0x86C4624
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C4678 Offset: 0x86C0678 VA: 0x86C4678
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C46E0 Offset: 0x86C06E0 VA: 0x86C46E0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C4778 Offset: 0x86C0778 VA: 0x86C4778
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x86C47CC Offset: 0x86C07CC VA: 0x86C47CC
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C4834 Offset: 0x86C0834 VA: 0x86C4834
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x86C48CC Offset: 0x86C08CC VA: 0x86C48CC
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x86C4920 Offset: 0x86C0920 VA: 0x86C4920
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4964 Offset: 0x86C0964 VA: 0x86C4964
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C49A8 Offset: 0x86C09A8 VA: 0x86C49A8
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
	// RVA: 0x86C49EC Offset: 0x86C09EC VA: 0x86C49EC
	public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4A30 Offset: 0x86C0A30 VA: 0x86C4A30
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4A74 Offset: 0x86C0A74 VA: 0x86C4A74
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4AB8 Offset: 0x86C0AB8 VA: 0x86C4AB8
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4AFC Offset: 0x86C0AFC VA: 0x86C4AFC
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4B40 Offset: 0x86C0B40 VA: 0x86C4B40
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4B84 Offset: 0x86C0B84 VA: 0x86C4B84
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4BC8 Offset: 0x86C0BC8 VA: 0x86C4BC8
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x86C4C0C Offset: 0x86C0C0C VA: 0x86C4C0C
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x86C4C60 Offset: 0x86C0C60 VA: 0x86C4C60
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x86C4CB4 Offset: 0x86C0CB4 VA: 0x86C4CB4
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
	// RVA: 0x86C4D08 Offset: 0x86C0D08 VA: 0x86C4D08
	public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x86C4D5C Offset: 0x86C0D5C VA: 0x86C4D5C
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x86C4DB0 Offset: 0x86C0DB0 VA: 0x86C4DB0
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x86C4E04 Offset: 0x86C0E04 VA: 0x86C4E04
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x86C4E58 Offset: 0x86C0E58 VA: 0x86C4E58
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x86C4EAC Offset: 0x86C0EAC VA: 0x86C4EAC
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x86C4F00 Offset: 0x86C0F00 VA: 0x86C4F00
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x86C4F54 Offset: 0x86C0F54 VA: 0x86C4F54
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	[ThreadSafe]
	// RVA: 0x86C4FA8 Offset: 0x86C0FA8 VA: 0x86C4FA8
	private static IntPtr ConvertToBooleanArray(bool[] array) { }

	// RVA: 0x86C4FE4 Offset: 0x86C0FE4 VA: 0x86C4FE4
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	// RVA: 0x86C5028 Offset: 0x86C1028 VA: 0x86C5028
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x86C5064 Offset: 0x86C1064 VA: 0x86C5064
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x86C50B8 Offset: 0x86C10B8 VA: 0x86C50B8
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x86C50FC Offset: 0x86C10FC VA: 0x86C50FC
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x86C5150 Offset: 0x86C1150 VA: 0x86C5150
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x86C5194 Offset: 0x86C1194 VA: 0x86C5194
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x86C51E8 Offset: 0x86C11E8 VA: 0x86C51E8
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x86C522C Offset: 0x86C122C VA: 0x86C522C
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x86C5280 Offset: 0x86C1280 VA: 0x86C5280
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x86C52C4 Offset: 0x86C12C4 VA: 0x86C52C4
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x86C5318 Offset: 0x86C1318 VA: 0x86C5318
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x86C535C Offset: 0x86C135C VA: 0x86C535C
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x86C53B0 Offset: 0x86C13B0 VA: 0x86C53B0
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x86C53F4 Offset: 0x86C13F4 VA: 0x86C53F4
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x86C5448 Offset: 0x86C1448 VA: 0x86C5448
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x86C548C Offset: 0x86C148C VA: 0x86C548C
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x86C54E0 Offset: 0x86C14E0 VA: 0x86C54E0
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x86C5544 Offset: 0x86C1544 VA: 0x86C5544
	public static IntPtr ToObjectArray(IntPtr[] array) { }

	[ThreadSafe]
	// RVA: 0x86C554C Offset: 0x86C154C VA: 0x86C554C
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	// RVA: 0x86C5588 Offset: 0x86C1588 VA: 0x86C5588
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C55C4 Offset: 0x86C15C4 VA: 0x86C55C4
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C5600 Offset: 0x86C1600 VA: 0x86C5600
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C563C Offset: 0x86C163C VA: 0x86C563C
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C5678 Offset: 0x86C1678 VA: 0x86C5678
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C56B4 Offset: 0x86C16B4 VA: 0x86C56B4
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C56F0 Offset: 0x86C16F0 VA: 0x86C56F0
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C572C Offset: 0x86C172C VA: 0x86C572C
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C5768 Offset: 0x86C1768 VA: 0x86C5768
	public static IntPtr[] FromObjectArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C57A4 Offset: 0x86C17A4 VA: 0x86C57A4
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x86C57E0 Offset: 0x86C17E0 VA: 0x86C57E0
	public static IntPtr NewBooleanArray(int size) { }

	[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
	// RVA: 0x86C581C Offset: 0x86C181C VA: 0x86C581C
	public static IntPtr NewByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C5858 Offset: 0x86C1858 VA: 0x86C5858
	public static IntPtr NewSByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C5894 Offset: 0x86C1894 VA: 0x86C5894
	public static IntPtr NewCharArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C58D0 Offset: 0x86C18D0 VA: 0x86C58D0
	public static IntPtr NewShortArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C590C Offset: 0x86C190C VA: 0x86C590C
	public static IntPtr NewIntArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C5948 Offset: 0x86C1948 VA: 0x86C5948
	public static IntPtr NewLongArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C5984 Offset: 0x86C1984 VA: 0x86C5984
	public static IntPtr NewFloatArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C59C0 Offset: 0x86C19C0 VA: 0x86C59C0
	public static IntPtr NewDoubleArray(int size) { }

	[ThreadSafe]
	// RVA: 0x86C59FC Offset: 0x86C19FC VA: 0x86C59FC
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C5A50 Offset: 0x86C1A50 VA: 0x86C5A50
	public static bool GetBooleanArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
	// RVA: 0x86C5A94 Offset: 0x86C1A94 VA: 0x86C5A94
	public static byte GetByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5AD8 Offset: 0x86C1AD8 VA: 0x86C5AD8
	public static sbyte GetSByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5B1C Offset: 0x86C1B1C VA: 0x86C5B1C
	public static char GetCharArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5B60 Offset: 0x86C1B60 VA: 0x86C5B60
	public static short GetShortArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5BA4 Offset: 0x86C1BA4 VA: 0x86C5BA4
	public static int GetIntArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5BE8 Offset: 0x86C1BE8 VA: 0x86C5BE8
	public static long GetLongArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5C2C Offset: 0x86C1C2C VA: 0x86C5C2C
	public static float GetFloatArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5C70 Offset: 0x86C1C70 VA: 0x86C5C70
	public static double GetDoubleArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x86C5CB4 Offset: 0x86C1CB4 VA: 0x86C5CB4
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
	// RVA: 0x86C5CF8 Offset: 0x86C1CF8 VA: 0x86C5CF8
	public static void SetBooleanArrayElement(IntPtr array, int index, byte val) { }

	[ThreadSafe]
	// RVA: 0x86C5D50 Offset: 0x86C1D50 VA: 0x86C5D50
	public static void SetBooleanArrayElement(IntPtr array, int index, bool val) { }

	[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
	// RVA: 0x86C5DA4 Offset: 0x86C1DA4 VA: 0x86C5DA4
	public static void SetByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x86C5DF8 Offset: 0x86C1DF8 VA: 0x86C5DF8
	public static void SetSByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x86C5E4C Offset: 0x86C1E4C VA: 0x86C5E4C
	public static void SetCharArrayElement(IntPtr array, int index, char val) { }

	[ThreadSafe]
	// RVA: 0x86C5EA0 Offset: 0x86C1EA0 VA: 0x86C5EA0
	public static void SetShortArrayElement(IntPtr array, int index, short val) { }

	[ThreadSafe]
	// RVA: 0x86C5EF4 Offset: 0x86C1EF4 VA: 0x86C5EF4
	public static void SetIntArrayElement(IntPtr array, int index, int val) { }

	[ThreadSafe]
	// RVA: 0x86C5F48 Offset: 0x86C1F48 VA: 0x86C5F48
	public static void SetLongArrayElement(IntPtr array, int index, long val) { }

	[ThreadSafe]
	// RVA: 0x86C5F9C Offset: 0x86C1F9C VA: 0x86C5F9C
	public static void SetFloatArrayElement(IntPtr array, int index, float val) { }

	[ThreadSafe]
	// RVA: 0x86C5FF0 Offset: 0x86C1FF0 VA: 0x86C5FF0
	public static void SetDoubleArrayElement(IntPtr array, int index, double val) { }

	[ThreadSafe]
	// RVA: 0x86C6044 Offset: 0x86C2044 VA: 0x86C6044
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x86C6098 Offset: 0x86C2098 VA: 0x86C6098
	public static IntPtr NewDirectByteBuffer(byte* buffer, long capacity) { }

	// RVA: 0x86C60DC Offset: 0x86C20DC VA: 0x86C60DC
	public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer) { }

	// RVA: 0x86C6134 Offset: 0x86C2134 VA: 0x86C6134
	public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer) { }

	// RVA: -1 Offset: -1
	private static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460AF74 Offset: 0x4606F74 VA: 0x460AF74
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<byte>
	|
	|-RVA: 0x460AFE4 Offset: 0x4606FE4 VA: 0x460AFE4
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<sbyte>
	|
	|-RVA: 0x460B054 Offset: 0x4607054 VA: 0x460B054
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[ThreadSafe]
	// RVA: 0x86C618C Offset: 0x86C218C VA: 0x86C618C
	public static sbyte* GetDirectBufferAddress(IntPtr buffer) { }

	[ThreadSafe]
	// RVA: 0x86C61C8 Offset: 0x86C21C8 VA: 0x86C61C8
	public static long GetDirectBufferCapacity(IntPtr buffer) { }

	// RVA: -1 Offset: -1
	private static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460ABF8 Offset: 0x4606BF8 VA: 0x460ABF8
	|-AndroidJNI.GetDirectBuffer<byte>
	|
	|-RVA: 0x460AD20 Offset: 0x4606D20 VA: 0x460AD20
	|-AndroidJNI.GetDirectBuffer<sbyte>
	|
	|-RVA: 0x460AE48 Offset: 0x4606E48 VA: 0x460AE48
	|-AndroidJNI.GetDirectBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x86C6204 Offset: 0x86C2204 VA: 0x86C6204
	public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer) { }

	// RVA: 0x86C624C Offset: 0x86C224C VA: 0x86C624C
	public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer) { }

	// RVA: 0x86C6294 Offset: 0x86C2294 VA: 0x86C6294
	public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods) { }

	[ThreadSafe]
	// RVA: 0x86C6424 Offset: 0x86C2424 VA: 0x86C6424
	private static IntPtr RegisterNativesAllocate(int length) { }

	[ThreadSafe]
	// RVA: 0x86C6460 Offset: 0x86C2460 VA: 0x86C6460
	private static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr) { }

	[ThreadSafe]
	// RVA: 0x86C64CC Offset: 0x86C24CC VA: 0x86C64CC
	private static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n) { }

	[ThreadSafe]
	// RVA: 0x86C6520 Offset: 0x86C2520 VA: 0x86C6520
	public static int UnregisterNatives(IntPtr clazz) { }
}

// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 27183
{
	// Methods

	// RVA: 0x86C655C Offset: 0x86C255C VA: 0x86C655C
	public static void CheckException() { }

	// RVA: 0x86C68AC Offset: 0x86C28AC VA: 0x86C68AC
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x86C6904 Offset: 0x86C2904 VA: 0x86C6904
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x86C695C Offset: 0x86C295C VA: 0x86C695C
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x86C69B4 Offset: 0x86C29B4 VA: 0x86C69B4
	public static IntPtr NewString(string chars) { }

	// RVA: 0x86C6A54 Offset: 0x86C2A54 VA: 0x86C6A54
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x86C1028 Offset: 0x86BD028 VA: 0x86C1028
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x86C0B1C Offset: 0x86BCB1C VA: 0x86C0B1C
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x86C10C8 Offset: 0x86BD0C8 VA: 0x86C10C8
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x86C6AF4 Offset: 0x86C2AF4 VA: 0x86C6AF4
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x86C6BAC Offset: 0x86C2BAC VA: 0x86C6BAC
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x86C6C64 Offset: 0x86C2C64 VA: 0x86C6C64
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x86C0A7C Offset: 0x86BCA7C VA: 0x86C0A7C
	public static IntPtr FindClass(string name) { }

	// RVA: 0x86C6D04 Offset: 0x86C2D04 VA: 0x86C6D04
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C6D7C Offset: 0x86C2D7C VA: 0x86C6D7C
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x86C6E38 Offset: 0x86C2E38 VA: 0x86C6E38
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	// RVA: 0x86C6EF4 Offset: 0x86C2EF4 VA: 0x86C6EF4
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	// RVA: 0x86C6FB0 Offset: 0x86C2FB0 VA: 0x86C6FB0
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	// RVA: 0x86C706C Offset: 0x86C306C VA: 0x86C706C
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	// RVA: 0x86C7128 Offset: 0x86C3128 VA: 0x86C7128
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	// RVA: 0x86C71E4 Offset: 0x86C31E4 VA: 0x86C71E4
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	// RVA: 0x86C72A0 Offset: 0x86C32A0 VA: 0x86C72A0
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	// RVA: 0x86C735C Offset: 0x86C335C VA: 0x86C735C
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	// RVA: 0x86C7418 Offset: 0x86C3418 VA: 0x86C7418
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	// RVA: 0x86C74D4 Offset: 0x86C34D4 VA: 0x86C74D4
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C757C Offset: 0x86C357C VA: 0x86C757C
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7624 Offset: 0x86C3624 VA: 0x86C7624
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C76CC Offset: 0x86C36CC VA: 0x86C76CC
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7780 Offset: 0x86C3780 VA: 0x86C7780
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7834 Offset: 0x86C3834 VA: 0x86C7834
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C78DC Offset: 0x86C38DC VA: 0x86C78DC
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7984 Offset: 0x86C3984 VA: 0x86C7984
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7A2C Offset: 0x86C3A2C VA: 0x86C7A2C
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7AD4 Offset: 0x86C3AD4 VA: 0x86C7AD4
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x86C7B7C Offset: 0x86C3B7C VA: 0x86C7B7C
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7BF4 Offset: 0x86C3BF4 VA: 0x86C7BF4
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C0BD4 Offset: 0x86BCBD4 VA: 0x86C0BD4
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7C5C Offset: 0x86C3C5C VA: 0x86C7C5C
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C7CC4 Offset: 0x86C3CC4 VA: 0x86C7CC4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7D3C Offset: 0x86C3D3C VA: 0x86C7D3C
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7DB4 Offset: 0x86C3DB4 VA: 0x86C7DB4
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7E38 Offset: 0x86C3E38 VA: 0x86C7E38
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7EBC Offset: 0x86C3EBC VA: 0x86C7EBC
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7F34 Offset: 0x86C3F34 VA: 0x86C7F34
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C7FAC Offset: 0x86C3FAC VA: 0x86C7FAC
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C8024 Offset: 0x86C4024 VA: 0x86C8024
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C809C Offset: 0x86C409C VA: 0x86C809C
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C8114 Offset: 0x86C4114 VA: 0x86C8114
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x86C81D0 Offset: 0x86C41D0 VA: 0x86C81D0
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	// RVA: 0x86C828C Offset: 0x86C428C VA: 0x86C828C
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	// RVA: 0x86C8348 Offset: 0x86C4348 VA: 0x86C8348
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x86C8404 Offset: 0x86C4404 VA: 0x86C8404
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	// RVA: 0x86C84C0 Offset: 0x86C44C0 VA: 0x86C84C0
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	// RVA: 0x86C857C Offset: 0x86C457C VA: 0x86C857C
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	// RVA: 0x86C8638 Offset: 0x86C4638 VA: 0x86C8638
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	// RVA: 0x86C86F4 Offset: 0x86C46F4 VA: 0x86C86F4
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	// RVA: 0x86C87B0 Offset: 0x86C47B0 VA: 0x86C87B0
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	// RVA: 0x86C886C Offset: 0x86C486C VA: 0x86C886C
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8914 Offset: 0x86C4914 VA: 0x86C8914
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C89BC Offset: 0x86C49BC VA: 0x86C89BC
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8A64 Offset: 0x86C4A64 VA: 0x86C8A64
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8B18 Offset: 0x86C4B18 VA: 0x86C8B18
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8BCC Offset: 0x86C4BCC VA: 0x86C8BCC
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8C74 Offset: 0x86C4C74 VA: 0x86C8C74
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8D1C Offset: 0x86C4D1C VA: 0x86C8D1C
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8DC4 Offset: 0x86C4DC4 VA: 0x86C8DC4
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8E6C Offset: 0x86C4E6C VA: 0x86C8E6C
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x86C8F14 Offset: 0x86C4F14 VA: 0x86C8F14
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C8F8C Offset: 0x86C4F8C VA: 0x86C8F8C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x86C8FF4 Offset: 0x86C4FF4 VA: 0x86C8FF4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C906C Offset: 0x86C506C VA: 0x86C906C
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1820 Offset: 0x86BD820 VA: 0x86C1820
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1714 Offset: 0x86BD714 VA: 0x86C1714
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1608 Offset: 0x86BD608 VA: 0x86C1608
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1508 Offset: 0x86BD508 VA: 0x86C1508
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1308 Offset: 0x86BD308 VA: 0x86C1308
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1208 Offset: 0x86BD208 VA: 0x86C1208
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1924 Offset: 0x86BD924 VA: 0x86C1924
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C1408 Offset: 0x86BD408 VA: 0x86C1408
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x86C90E4 Offset: 0x86C50E4 VA: 0x86C90E4
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x86C9184 Offset: 0x86C5184 VA: 0x86C9184
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x86C9224 Offset: 0x86C5224 VA: 0x86C9224
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x86C92C4 Offset: 0x86C52C4 VA: 0x86C92C4
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x86C9364 Offset: 0x86C5364 VA: 0x86C9364
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x86C9404 Offset: 0x86C5404 VA: 0x86C9404
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x86C94A4 Offset: 0x86C54A4 VA: 0x86C94A4
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x86C9544 Offset: 0x86C5544 VA: 0x86C9544
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x86C95E4 Offset: 0x86C55E4 VA: 0x86C95E4
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x86C9684 Offset: 0x86C5684 VA: 0x86C9684
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x86C96FC Offset: 0x86C56FC VA: 0x86C96FC
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x86C9774 Offset: 0x86C5774 VA: 0x86C9774
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x86C97EC Offset: 0x86C57EC VA: 0x86C97EC
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x86C9864 Offset: 0x86C5864 VA: 0x86C9864
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x86C98DC Offset: 0x86C58DC VA: 0x86C98DC
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x86C9954 Offset: 0x86C5954 VA: 0x86C9954
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x86C99F4 Offset: 0x86C59F4 VA: 0x86C99F4
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x86C9A6C Offset: 0x86C5A6C VA: 0x86C9A6C
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x86C9B10 Offset: 0x86C5B10 VA: 0x86C9B10
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x86C9B88 Offset: 0x86C5B88 VA: 0x86C9B88
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x86C9C30 Offset: 0x86C5C30 VA: 0x86C9C30
	public static int GetArrayLength(IntPtr array) { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 27184
{
	// Methods

	// RVA: 0x86C9CD0 Offset: 0x86C5CD0 VA: 0x86C9CD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86C9D6C Offset: 0x86C5D6C VA: 0x86C9D6C Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception // TypeDefIndex: 27185
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x86C6830 Offset: 0x86C2830 VA: 0x86C6830
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x86C9D80 Offset: 0x86C5D80 VA: 0x86C9D80 Slot: 10
	public override string get_StackTrace() { }
}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef // TypeDefIndex: 27186
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x86C9DA4 Offset: 0x86C5DA4 VA: 0x86C9DA4
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x86C9E14 Offset: 0x86C5E14 VA: 0x86C9E14 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x86C9EE8 Offset: 0x86C5EE8 VA: 0x86C9EE8
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x86C9EA8 Offset: 0x86C5EA8 VA: 0x86C9EA8
	public void Dispose() { }
}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 27187
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x86C9F00 Offset: 0x86C5F00 VA: 0x86C9F00
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x86CA010 Offset: 0x86C6010 VA: 0x86CA010
	public void run() { }

	// RVA: 0x86CA034 Offset: 0x86C6034 VA: 0x86CA034 Slot: 6
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }
}

// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 27188
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x86C9F88 Offset: 0x86C5F88 VA: 0x86C9F88
	public void .ctor(string javaInterface) { }

	// RVA: 0x86CA530 Offset: 0x86C6530 VA: 0x86CA530
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x86CA564 Offset: 0x86C6564 VA: 0x86CA564 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x86CA5FC Offset: 0x86C65FC VA: 0x86CA5FC Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x86CBC48 Offset: 0x86C7C48 VA: 0x86CBC48 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x86CA0F4 Offset: 0x86C60F4 VA: 0x86CA0F4 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x86CCAC0 Offset: 0x86C8AC0 VA: 0x86CCAC0 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x86CCB18 Offset: 0x86C8B18 VA: 0x86CCB18 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x86CCCCC Offset: 0x86C8CCC VA: 0x86CCCCC Slot: 9
	public virtual string toString() { }

	// RVA: 0x86CCD30 Offset: 0x86C8D30 VA: 0x86CCD30
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x86CCBD4 Offset: 0x86C8BD4 VA: 0x86CCBD4
	internal IntPtr GetRawProxy() { }

	// RVA: 0x86CCD40 Offset: 0x86C8D40 VA: 0x86CCD40
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 27189
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x86CCE48 Offset: 0x86C8E48 VA: 0x86CCE48
	public void .ctor(string className, string[] args) { }

	// RVA: 0x86CD010 Offset: 0x86C9010 VA: 0x86CD010
	public void .ctor(string className, AndroidJavaObject[] args) { }

	// RVA: 0x86CD0D0 Offset: 0x86C90D0 VA: 0x86CD0D0
	public void .ctor(string className, AndroidJavaClass[] args) { }

	// RVA: 0x86CD190 Offset: 0x86C9190 VA: 0x86CD190
	public void .ctor(string className, AndroidJavaProxy[] args) { }

	// RVA: 0x86CD250 Offset: 0x86C9250 VA: 0x86CD250
	public void .ctor(string className, AndroidJavaRunnable[] args) { }

	// RVA: 0x86CD310 Offset: 0x86C9310 VA: 0x86CD310
	public void .ctor(string className, object[] args) { }

	// RVA: 0x86CBB38 Offset: 0x86C7B38 VA: 0x86CBB38
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x86CD344 Offset: 0x86C9344 VA: 0x86CD344
	public void .ctor(IntPtr clazz, IntPtr constructorID, object[] args) { }

	// RVA: 0x86CC980 Offset: 0x86C8980 VA: 0x86CC980 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	public void Call<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460BFE0 Offset: 0x4607FE0 VA: 0x460BFE0
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Call<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460BF28 Offset: 0x4607F28 VA: 0x460BF28
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CD5C4 Offset: 0x86C95C4 VA: 0x86CD5C4
	public void Call(string methodName, object[] args) { }

	// RVA: 0x86CD628 Offset: 0x86C9628 VA: 0x86CD628
	public void Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public void CallStatic<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C8C8 Offset: 0x46088C8 VA: 0x460C8C8
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void CallStatic<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C810 Offset: 0x4608810 VA: 0x460C810
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CD7C0 Offset: 0x86C97C0 VA: 0x86CD7C0
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x86CD824 Offset: 0x86C9824 VA: 0x86CD824
	public void CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460D9D4 Offset: 0x46099D4 VA: 0x460D9D4
	|-AndroidJavaObject.Get<bool>
	|
	|-RVA: 0x460DA54 Offset: 0x4609A54 VA: 0x460DA54
	|-AndroidJavaObject.Get<int>
	|
	|-RVA: 0x460DB14 Offset: 0x4609B14 VA: 0x460DB14
	|-AndroidJavaObject.Get<object>
	|
	|-RVA: 0x460DC60 Offset: 0x4609C60 VA: 0x460DC60
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460DA14 Offset: 0x4609A14 VA: 0x460DA14
	|-AndroidJavaObject.Get<int>
	|
	|-RVA: 0x460DA94 Offset: 0x4609A94 VA: 0x460DA94
	|-AndroidJavaObject.Get<long>
	|
	|-RVA: 0x460DAD4 Offset: 0x4609AD4 VA: 0x460DAD4
	|-AndroidJavaObject.Get<object>
	|
	|-RVA: 0x460DB54 Offset: 0x4609B54 VA: 0x460DB54
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460E0D4 Offset: 0x460A0D4 VA: 0x460E0D4
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460DFF4 Offset: 0x4609FF4 VA: 0x460DFF4
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460DD64 Offset: 0x4609D64 VA: 0x460DD64
	|-AndroidJavaObject.GetStatic<int>
	|
	|-RVA: 0x460DDA4 Offset: 0x4609DA4 VA: 0x460DDA4
	|-AndroidJavaObject.GetStatic<object>
	|
	|-RVA: 0x460DEF0 Offset: 0x4609EF0 VA: 0x460DEF0
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460DDE4 Offset: 0x4609DE4 VA: 0x460DDE4
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460E28C Offset: 0x460A28C VA: 0x460E28C
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460E1AC Offset: 0x460A1AC VA: 0x460E1AC
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CCAA8 Offset: 0x86C8AA8 VA: 0x86CCAA8
	public IntPtr GetRawObject() { }

	// RVA: 0x86CD9D4 Offset: 0x86C99D4 VA: 0x86CD9D4
	public IntPtr GetRawClass() { }

	// RVA: 0x86CDA0C Offset: 0x86C9A0C VA: 0x86CDA0C
	public AndroidJavaObject CloneReference() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C228 Offset: 0x4608228 VA: 0x460C228
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C098 Offset: 0x4608098 VA: 0x460C098
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B93C Offset: 0x460793C VA: 0x460B93C
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x460B98C Offset: 0x460798C VA: 0x460B98C
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0x460B9DC Offset: 0x46079DC VA: 0x460B9DC
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x460BA2C Offset: 0x4607A2C VA: 0x460BA2C
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x460BACC Offset: 0x4607ACC VA: 0x460BACC
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x460BB6C Offset: 0x4607B6C VA: 0x460BB6C
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x460BC0C Offset: 0x4607C0C VA: 0x460BC0C
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x460BC5C Offset: 0x4607C5C VA: 0x460BC5C
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x460BCAC Offset: 0x4607CAC VA: 0x460BCAC
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0x460BE14 Offset: 0x4607E14 VA: 0x460BE14
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460B8EC Offset: 0x46078EC VA: 0x460B8EC
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x460BA7C Offset: 0x4607A7C VA: 0x460BA7C
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x460BB1C Offset: 0x4607B1C VA: 0x460BB1C
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x460BBBC Offset: 0x4607BBC VA: 0x460BBBC
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x460BCFC Offset: 0x4607CFC VA: 0x460BCFC
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460CB10 Offset: 0x4608B10 VA: 0x460CB10
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C980 Offset: 0x4608980 VA: 0x460C980
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C3B4 Offset: 0x46083B4 VA: 0x460C3B4
	|-AndroidJavaObject.CallStatic<bool>
	|
	|-RVA: 0x460C454 Offset: 0x4608454 VA: 0x460C454
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x460C4A4 Offset: 0x46084A4 VA: 0x460C4A4
	|-AndroidJavaObject.CallStatic<long>
	|
	|-RVA: 0x460C544 Offset: 0x4608544 VA: 0x460C544
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x460C594 Offset: 0x4608594 VA: 0x460C594
	|-AndroidJavaObject.CallStatic<float>
	|
	|-RVA: 0x460C6FC Offset: 0x46086FC VA: 0x460C6FC
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460C404 Offset: 0x4608404 VA: 0x460C404
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x460C4F4 Offset: 0x46084F4 VA: 0x460C4F4
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x460C5E4 Offset: 0x46085E4 VA: 0x460C5E4
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CDC4C Offset: 0x86C9C4C VA: 0x86CDC4C
	protected void DebugPrint(string msg) { }

	// RVA: 0x86CDCD4 Offset: 0x86C9CD4 VA: 0x86CDCD4
	protected void DebugPrint(string call, string methodName, string signature, object[] args) { }

	// RVA: 0x86CCF10 Offset: 0x86C8F10 VA: 0x86CCF10
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x86CD3DC Offset: 0x86C93DC VA: 0x86CD3DC
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x86CCF08 Offset: 0x86C8F08 VA: 0x86CCF08
	internal void .ctor() { }

	// RVA: 0x86CDFDC Offset: 0x86C9FDC VA: 0x86CDFDC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x86CE07C Offset: 0x86CA07C VA: 0x86CE07C Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x86CD5C8 Offset: 0x86C95C8 VA: 0x86CD5C8
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x86CD62C Offset: 0x86C962C VA: 0x86CD62C
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460F3F4 Offset: 0x460B3F4 VA: 0x460F3F4
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x46104F0 Offset: 0x460C4F0 VA: 0x46104F0
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x46115F4 Offset: 0x460D5F4 VA: 0x46115F4
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x46126F0 Offset: 0x460E6F0 VA: 0x46126F0
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x46137EC Offset: 0x460F7EC VA: 0x46137EC
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x46148E4 Offset: 0x46108E4 VA: 0x46148E4
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x4615948 Offset: 0x4611948 VA: 0x4615948
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x4616A44 Offset: 0x4612A44 VA: 0x4616A44
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x4617B48 Offset: 0x4613B48 VA: 0x4617B48
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x4618C68 Offset: 0x4614C68 VA: 0x4618C68
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460E364 Offset: 0x460A364 VA: 0x460E364
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x460F468 Offset: 0x460B468 VA: 0x460F468
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x4610564 Offset: 0x460C564 VA: 0x4610564
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x4611668 Offset: 0x460D668 VA: 0x4611668
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x4612764 Offset: 0x460E764 VA: 0x4612764
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x4613860 Offset: 0x460F860 VA: 0x4613860
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x4614958 Offset: 0x4610958 VA: 0x4614958
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x46159BC Offset: 0x46119BC VA: 0x46159BC
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x4616AB8 Offset: 0x4612AB8 VA: 0x4616AB8
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x4617BBC Offset: 0x4613BBC VA: 0x4617BBC
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x461FDD0 Offset: 0x461BDD0 VA: 0x461FDD0
	|-AndroidJavaObject._Get<bool>
	|
	|-RVA: 0x46207F4 Offset: 0x461C7F4 VA: 0x46207F4
	|-AndroidJavaObject._Get<int>
	|
	|-RVA: 0x4621BC4 Offset: 0x461DBC4 VA: 0x4621BC4
	|-AndroidJavaObject._Get<object>
	|
	|-RVA: 0x4622834 Offset: 0x461E834 VA: 0x4622834
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x461F404 Offset: 0x461B404 VA: 0x461F404
	|-AndroidJavaObject._Get<bool>
	|
	|-RVA: 0x461FE30 Offset: 0x461BE30 VA: 0x461FE30
	|-AndroidJavaObject._Get<int>
	|
	|-RVA: 0x4620854 Offset: 0x461C854 VA: 0x4620854
	|-AndroidJavaObject._Get<long>
	|
	|-RVA: 0x4621228 Offset: 0x461D228 VA: 0x4621228
	|-AndroidJavaObject._Get<object>
	|
	|-RVA: 0x4621C24 Offset: 0x461DC24 VA: 0x4621C24
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475DD80 Offset: 0x4759D80 VA: 0x475DD80
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475CDDC Offset: 0x4758DDC VA: 0x475CDDC
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CD7C4 Offset: 0x86C97C4 VA: 0x86CD7C4
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x86CD828 Offset: 0x86C9828 VA: 0x86CD828
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4619E40 Offset: 0x4615E40 VA: 0x4619E40
	|-AndroidJavaObject._CallStatic<bool>
	|
	|-RVA: 0x461AF3C Offset: 0x4616F3C VA: 0x461AF3C
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x461C034 Offset: 0x4618034 VA: 0x461C034
	|-AndroidJavaObject._CallStatic<long>
	|
	|-RVA: 0x461D098 Offset: 0x4619098 VA: 0x461D098
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x461E19C Offset: 0x461A19C VA: 0x461E19C
	|-AndroidJavaObject._CallStatic<float>
	|
	|-RVA: 0x461F2BC Offset: 0x461B2BC VA: 0x461F2BC
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4618DB0 Offset: 0x4614DB0 VA: 0x4618DB0
	|-AndroidJavaObject._CallStatic<bool>
	|
	|-RVA: 0x4619EB4 Offset: 0x4615EB4 VA: 0x4619EB4
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x461AFB0 Offset: 0x4616FB0 VA: 0x461AFB0
	|-AndroidJavaObject._CallStatic<long>
	|
	|-RVA: 0x461C0A8 Offset: 0x46180A8 VA: 0x461C0A8
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x461D10C Offset: 0x461910C VA: 0x461D10C
	|-AndroidJavaObject._CallStatic<float>
	|
	|-RVA: 0x461E210 Offset: 0x461A210 VA: 0x461E210
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475B638 Offset: 0x4757638 VA: 0x475B638
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x475C034 Offset: 0x4758034 VA: 0x475C034
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x475CCA4 Offset: 0x4758CA4 VA: 0x475CCA4
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462296C Offset: 0x461E96C VA: 0x462296C
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x475B698 Offset: 0x4757698 VA: 0x475B698
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x475C094 Offset: 0x4758094 VA: 0x475C094
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475EE40 Offset: 0x475AE40 VA: 0x475EE40
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475DE9C Offset: 0x4759E9C VA: 0x475DE9C
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CC9EC Offset: 0x86C89EC VA: 0x86CC9EC
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x86CE0D8 Offset: 0x86CA0D8 VA: 0x86CE0D8
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x460CC9C Offset: 0x4608C9C VA: 0x460CC9C
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<bool>
	|
	|-RVA: 0x460CDE4 Offset: 0x4608DE4 VA: 0x460CDE4
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<char>
	|
	|-RVA: 0x460CF20 Offset: 0x4608F20 VA: 0x460CF20
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<double>
	|
	|-RVA: 0x460D058 Offset: 0x4609058 VA: 0x460D058
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<short>
	|
	|-RVA: 0x460D194 Offset: 0x4609194 VA: 0x460D194
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<int>
	|
	|-RVA: 0x460D2D0 Offset: 0x46092D0 VA: 0x460D2D0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<long>
	|
	|-RVA: 0x460D40C Offset: 0x460940C VA: 0x460D40C
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<object>
	|
	|-RVA: 0x460D528 Offset: 0x4609528 VA: 0x460D528
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<sbyte>
	|
	|-RVA: 0x460D664 Offset: 0x4609664 VA: 0x460D664
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<float>
	|
	|-RVA: 0x460D79C Offset: 0x460979C VA: 0x460D79C
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CD9BC Offset: 0x86C99BC VA: 0x86CD9BC
	protected IntPtr _GetRawObject() { }

	// RVA: 0x86CD9F0 Offset: 0x86C99F0 VA: 0x86CD9F0
	protected IntPtr _GetRawClass() { }
}

// Namespace: UnityEngine
public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 27190
{
	// Methods

	// RVA: 0x86CA504 Offset: 0x86C6504 VA: 0x86CA504
	public void .ctor(string className) { }

	// RVA: 0x86CE194 Offset: 0x86CA194 VA: 0x86CE194
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x86CDB70 Offset: 0x86C9B70 VA: 0x86CDB70
	internal void .ctor(IntPtr jclass) { }
}

// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 27191
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x86CE26C Offset: 0x86CA26C VA: 0x86CE26C
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x86CE280 Offset: 0x86CA280 VA: 0x86CE280
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x86CE2A0 Offset: 0x86CA2A0 VA: 0x86CE2A0
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x86CE33C Offset: 0x86CA33C VA: 0x86CE33C
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x86CE3D8 Offset: 0x86CA3D8 VA: 0x86CE3D8
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x86CE560 Offset: 0x86CA560 VA: 0x86CE560
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x86CE75C Offset: 0x86CA75C VA: 0x86CE75C
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x86CE958 Offset: 0x86CA958 VA: 0x86CE958
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x86CE9BC Offset: 0x86CA9BC VA: 0x86CE9BC
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x86CEA64 Offset: 0x86CAA64 VA: 0x86CEA64
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x86CBA4C Offset: 0x86C7A4C VA: 0x86CBA4C
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x86CEB48 Offset: 0x86CAB48 VA: 0x86CEB48
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper // TypeDefIndex: 27192
{
	// Methods

	// RVA: 0x86BE340 Offset: 0x86BA340 VA: 0x86BE340
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x86BE1CC Offset: 0x86BA1CC VA: 0x86BE1CC
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x86CEDFC Offset: 0x86CADFC VA: 0x86CEDFC
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x86BF02C Offset: 0x86BB02C VA: 0x86BF02C
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x86CEF14 Offset: 0x86CAF14 VA: 0x86CEF14
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x86CBDD0 Offset: 0x86C7DD0 VA: 0x86CBDD0
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x86CB02C Offset: 0x86C702C VA: 0x86CB02C
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x86BF728 Offset: 0x86BB728 VA: 0x86BF728
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x86BE3CC Offset: 0x86BA3CC VA: 0x86BE3CC
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x478E6DC Offset: 0x478A6DC VA: 0x478E6DC
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x478EE18 Offset: 0x478AE18 VA: 0x478EE18
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x478F54C Offset: 0x478B54C VA: 0x478F54C
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x478FC7C Offset: 0x478BC7C VA: 0x478FC7C
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x47903B0 Offset: 0x478C3B0 VA: 0x47903B0
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x4790AE4 Offset: 0x478CAE4 VA: 0x4790AE4
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x4791218 Offset: 0x478D218 VA: 0x4791218
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x4791978 Offset: 0x478D978 VA: 0x4791978
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x47920AC Offset: 0x478E0AC VA: 0x47920AC
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x47927DC Offset: 0x478E7DC VA: 0x47927DC
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86BF8A4 Offset: 0x86BB8A4 VA: 0x86BF8A4
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x86BF8FC Offset: 0x86BB8FC VA: 0x86BF8FC
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47932E8 Offset: 0x478F2E8 VA: 0x47932E8
	|-_AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x479334C Offset: 0x478F34C VA: 0x479334C
	|-_AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x47933B0 Offset: 0x478F3B0 VA: 0x47933B0
	|-_AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x4793414 Offset: 0x478F414 VA: 0x4793414
	|-_AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x4793478 Offset: 0x478F478 VA: 0x4793478
	|-_AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x47934DC Offset: 0x478F4DC VA: 0x47934DC
	|-_AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x4793540 Offset: 0x478F540 VA: 0x4793540
	|-_AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x47935A4 Offset: 0x478F5A4 VA: 0x47935A4
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x4793608 Offset: 0x478F608 VA: 0x4793608
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x479366C Offset: 0x478F66C VA: 0x479366C
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4793088 Offset: 0x478F088 VA: 0x4793088
	|-_AndroidJNIHelper.GetFieldID<bool>
	|
	|-RVA: 0x4793120 Offset: 0x478F120 VA: 0x4793120
	|-_AndroidJNIHelper.GetFieldID<int>
	|
	|-RVA: 0x47931B8 Offset: 0x478F1B8 VA: 0x47931B8
	|-_AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x4793250 Offset: 0x478F250 VA: 0x4793250
	|-_AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86BDA78 Offset: 0x86B9A78 VA: 0x86BDA78
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x86BDCAC Offset: 0x86B9CAC VA: 0x86BDCAC
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x86CF6D0 Offset: 0x86CB6D0 VA: 0x86CF6D0
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x86BDEF0 Offset: 0x86B9EF0 VA: 0x86BDEF0
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x86BF938 Offset: 0x86BB938 VA: 0x86BF938
	public static string GetSignature(object obj) { }

	// RVA: 0x86C0858 Offset: 0x86BC858 VA: 0x86C0858
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47936D4 Offset: 0x478F6D4 VA: 0x47936D4
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0x4793884 Offset: 0x478F884 VA: 0x4793884
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0x4793A34 Offset: 0x478FA34 VA: 0x4793A34
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0x4793BE4 Offset: 0x478FBE4 VA: 0x4793BE4
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0x4793D94 Offset: 0x478FD94 VA: 0x4793D94
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0x4793F44 Offset: 0x478FF44 VA: 0x4793F44
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0x47940F4 Offset: 0x47900F4 VA: 0x47940F4
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0x47942A4 Offset: 0x47902A4 VA: 0x47942A4
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0x4794454 Offset: 0x4790454 VA: 0x4794454
	|-_AndroidJNIHelper.GetSignature<float>
	|
	|-RVA: 0x4794604 Offset: 0x4790604 VA: 0x4794604
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86CF764 Offset: 0x86CB764 VA: 0x86CF764
	public void .ctor() { }
}

// Namespace: UnityEngine.Android
[NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
[StaticAccessor("AndroidApp", 2)]
[NativeConditional("PLATFORM_ANDROID")]
internal static class AndroidApp // TypeDefIndex: 27193
{
	// Fields
	private static AndroidJavaObject m_Context; // 0x0
	private static AndroidJavaObject m_Activity; // 0x8

	// Properties
	public static AndroidJavaObject Context { get; }
	public static AndroidJavaObject Activity { get; }
	public static IntPtr UnityPlayerRaw { get; }

	// Methods

	// RVA: 0x86CF76C Offset: 0x86CB76C VA: 0x86CF76C
	public static AndroidJavaObject get_Context() { }

	// RVA: 0x86CFA14 Offset: 0x86CBA14 VA: 0x86CFA14
	public static AndroidJavaObject get_Activity() { }

	// RVA: 0x86CF7B8 Offset: 0x86CB7B8 VA: 0x86CF7B8
	private static void AcquireContextAndActivity() { }

	[ThreadSafe]
	// RVA: 0x86BE318 Offset: 0x86BA318 VA: 0x86BE318
	public static IntPtr get_UnityPlayerRaw() { }
}

// Namespace: UnityEngine.Android
public enum AndroidAssetPackStatus // TypeDefIndex: 27194
{
	// Fields
	public int value__; // 0x0
	public const AndroidAssetPackStatus Unknown = 0;
	public const AndroidAssetPackStatus Pending = 1;
	public const AndroidAssetPackStatus Downloading = 2;
	public const AndroidAssetPackStatus Transferring = 3;
	public const AndroidAssetPackStatus Completed = 4;
	public const AndroidAssetPackStatus Failed = 5;
	public const AndroidAssetPackStatus Canceled = 6;
	public const AndroidAssetPackStatus WaitingForWifi = 7;
	public const AndroidAssetPackStatus NotInstalled = 8;
}

// Namespace: UnityEngine.Android
public enum AndroidAssetPackError // TypeDefIndex: 27195
{
	// Fields
	public int value__; // 0x0
	public const AndroidAssetPackError NoError = 0;
	public const AndroidAssetPackError AppUnavailable = -1;
	public const AndroidAssetPackError PackUnavailable = -2;
	public const AndroidAssetPackError InvalidRequest = -3;
	public const AndroidAssetPackError DownloadNotFound = -4;
	public const AndroidAssetPackError ApiNotAvailable = -5;
	public const AndroidAssetPackError NetworkError = -6;
	public const AndroidAssetPackError AccessDenied = -7;
	public const AndroidAssetPackError InsufficientStorage = -10;
	public const AndroidAssetPackError PlayStoreNotFound = -11;
	public const AndroidAssetPackError NetworkUnrestricted = -12;
	public const AndroidAssetPackError AppNotOwned = -13;
	public const AndroidAssetPackError InternalError = -100;
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackInfo // TypeDefIndex: 27196
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <size>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <bytesDownloaded>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly float <transferProgress>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x34

	// Methods

	// RVA: 0x86CFA60 Offset: 0x86CBA60 VA: 0x86CFA60
	internal void .ctor(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error) { }
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackState // TypeDefIndex: 27197
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x86CFAD0 Offset: 0x86CBAD0 VA: 0x86CFAD0
	internal void .ctor(string name, AndroidAssetPackStatus status, AndroidAssetPackError error) { }
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackUseMobileDataRequestResult // TypeDefIndex: 27198
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <allowed>k__BackingField; // 0x10

	// Methods

	// RVA: 0x86CFB18 Offset: 0x86CBB18 VA: 0x86CFB18
	internal void .ctor(bool allowed) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerDownloadStatusCallback : AndroidJavaProxy // TypeDefIndex: 27199
{
	// Fields
	private Action<AndroidAssetPackInfo> m_Callback; // 0x20
	private string[] m_AssetPacks; // 0x28

	// Methods

	// RVA: 0x86CFEF4 Offset: 0x86CBEF4 VA: 0x86CFEF4
	public void .ctor(Action<AndroidAssetPackInfo> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x86CFF90 Offset: 0x86CBF90 VA: 0x86CFF90
	private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy // TypeDefIndex: 27200
{
	// Fields
	private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback; // 0x20

	// Methods

	// RVA: 0x86D00A8 Offset: 0x86CC0A8 VA: 0x86D00A8
	public void .ctor(Action<AndroidAssetPackUseMobileDataRequestResult> callback) { }

	[Preserve]
	// RVA: 0x86D0130 Offset: 0x86CC130 VA: 0x86D0130
	private void onMobileDataConfirmationResult(bool allowed) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerStatusQueryCallback : AndroidJavaProxy // TypeDefIndex: 27201
{
	// Fields
	private Action<ulong, AndroidAssetPackState[]> m_Callback; // 0x20
	private List<string> m_AssetPackNames; // 0x28
	private List<AndroidAssetPackState> m_States; // 0x30
	private long m_Size; // 0x38

	// Methods

	// RVA: 0x86D01B4 Offset: 0x86CC1B4 VA: 0x86D01B4
	public void .ctor(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x86D02CC Offset: 0x86CC2CC VA: 0x86D02CC
	private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes) { }
}

// Namespace: UnityEngine.Android
[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
[StaticAccessor("AndroidAssetPacksBindingsHelpers", 2)]
public static class AndroidAssetPacks // TypeDefIndex: 27202
{
	// Fields
	private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper; // 0x0
	private static bool s_ApiMissing; // 0x8

	// Methods

	// RVA: 0x86CFB40 Offset: 0x86CBB40 VA: 0x86CFB40
	private static AndroidJavaObject GetAssetPackManager() { }
}

// Namespace: UnityEngine.Android
public class PermissionCallbacks : AndroidJavaProxy // TypeDefIndex: 27203
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<string> PermissionGranted; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<string> PermissionDenied; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<string> PermissionDeniedAndDontAskAgain; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x86D0664 Offset: 0x86CC664 VA: 0x86D0664
	public void add_PermissionGranted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x86D0714 Offset: 0x86CC714 VA: 0x86D0714
	public void remove_PermissionGranted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x86D07C4 Offset: 0x86CC7C4 VA: 0x86D07C4
	public void add_PermissionDenied(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x86D0874 Offset: 0x86CC874 VA: 0x86D0874
	public void remove_PermissionDenied(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x86D0924 Offset: 0x86CC924 VA: 0x86D0924
	public void add_PermissionDeniedAndDontAskAgain(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x86D09D4 Offset: 0x86CC9D4 VA: 0x86D09D4
	public void remove_PermissionDeniedAndDontAskAgain(Action<string> value) { }

	// RVA: 0x86D0A84 Offset: 0x86CCA84 VA: 0x86D0A84
	public void .ctor() { }

	[Preserve]
	// RVA: 0x86D0AF0 Offset: 0x86CCAF0 VA: 0x86D0AF0
	private void onPermissionGranted(string permissionName) { }

	[Preserve]
	// RVA: 0x86D0B0C Offset: 0x86CCB0C VA: 0x86D0B0C
	private void onPermissionDenied(string permissionName) { }

	[Preserve]
	// RVA: 0x86D0B28 Offset: 0x86CCB28 VA: 0x86D0B28
	private void onPermissionDeniedAndDontAskAgain(string permissionName) { }
}

// Namespace: UnityEngine.Android
public struct Permission // TypeDefIndex: 27204
{
	// Fields
	private static AndroidJavaObject m_UnityPermissions; // 0x0

	// Methods

	// RVA: 0x86D0B4C Offset: 0x86CCB4C VA: 0x86D0B4C
	private static AndroidJavaObject GetUnityPermissions() { }

	// RVA: 0x86D0C0C Offset: 0x86CCC0C VA: 0x86D0C0C
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x86D0D44 Offset: 0x86CCD44 VA: 0x86D0D44
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x86D0DD0 Offset: 0x86CCDD0 VA: 0x86D0DD0
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }
}

