// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28751
{}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
public class AssetBundle : Object // TypeDefIndex: 28752
{
	// Methods

	// RVA: 0x86DCCD0 Offset: 0x86D8CD0 VA: 0x86DCCD0
	private void .ctor() { }

	[FreeFunction("GetAllAssetBundles")]
	// RVA: 0x86DCD28 Offset: 0x86D8D28 VA: 0x86DCD28
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	// RVA: 0x86DCD50 Offset: 0x86D8D50 VA: 0x86DCD50
	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() { }

	[FreeFunction("LoadFromFileAsync")]
	// RVA: 0x86DCD78 Offset: 0x86D8D78 VA: 0x86DCD78
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x86DCDCC Offset: 0x86D8DCC VA: 0x86DCDCC
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x86DCE10 Offset: 0x86D8E10 VA: 0x86DCE10
	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	[FreeFunction("LoadFromFile")]
	// RVA: 0x86DCE58 Offset: 0x86D8E58 VA: 0x86DCE58
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x86DCEAC Offset: 0x86D8EAC VA: 0x86DCEAC
	public static AssetBundle LoadFromFile(string path) { }

	[FreeFunction("LoadFromMemoryAsync")]
	// RVA: 0x86DCEF0 Offset: 0x86D8EF0 VA: 0x86DCEF0
	internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc) { }

	// RVA: 0x86DCF34 Offset: 0x86D8F34 VA: 0x86DCF34
	public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x450261C Offset: 0x44FE61C VA: 0x450261C
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRule(1)]
	// RVA: 0x86DCF74 Offset: 0x86D8F74 VA: 0x86DCF74
	public Object LoadAsset(string name, Type type) { }

	[TypeInferenceRule(1)]
	[NativeMethod("LoadAsset_Internal")]
	[NativeThrows]
	// RVA: 0x86DD0BC Offset: 0x86D90BC VA: 0x86DD0BC
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45026EC Offset: 0x44FE6EC VA: 0x45026EC
	|-AssetBundle.LoadAssetAsync<object>
	|
	|-RVA: 0x450276C Offset: 0x44FE76C VA: 0x450276C
	|-AssetBundle.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86DD110 Offset: 0x86D9110 VA: 0x86DD110
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502408 Offset: 0x44FE408 VA: 0x4502408
	|-AssetBundle.ConvertObjects<object>
	*/

	// RVA: -1 Offset: -1
	public T[] LoadAssetWithSubAssets<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45027EC Offset: 0x44FE7EC VA: 0x45027EC
	|-AssetBundle.LoadAssetWithSubAssets<object>
	*/

	// RVA: 0x86DD2AC Offset: 0x86D92AC VA: 0x86DD2AC
	public Object[] LoadAssetWithSubAssets(string name, Type type) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502880 Offset: 0x44FE880 VA: 0x4502880
	|-AssetBundle.LoadAssetWithSubAssetsAsync<object>
	|
	|-RVA: 0x4502900 Offset: 0x44FE900 VA: 0x4502900
	|-AssetBundle.LoadAssetWithSubAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86DD448 Offset: 0x86D9448 VA: 0x86DD448
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	// RVA: 0x86DD5E4 Offset: 0x86D95E4 VA: 0x86DD5E4
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAllAssetsAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x450252C Offset: 0x44FE52C VA: 0x450252C
	|-AssetBundle.LoadAllAssetsAsync<object>
	|
	|-RVA: 0x45025A4 Offset: 0x44FE5A4 VA: 0x45025A4
	|-AssetBundle.LoadAllAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86DD668 Offset: 0x86D9668 VA: 0x86DD668
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	[NativeMethod("LoadAssetAsync_Internal")]
	[NativeThrows]
	// RVA: 0x86DD258 Offset: 0x86D9258 VA: 0x86DD258
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeThrows]
	[NativeMethod("Unload")]
	// RVA: 0x86DD764 Offset: 0x86D9764 VA: 0x86DD764
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethod("UnloadAsync")]
	[NativeThrows]
	// RVA: 0x86DD7A8 Offset: 0x86D97A8 VA: 0x86DD7A8
	public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects) { }

	[NativeThrows]
	[NativeMethod("LoadAssetWithSubAssets_Internal")]
	// RVA: 0x86DD3F4 Offset: 0x86D93F4 VA: 0x86DD3F4
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	[NativeThrows]
	[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
	// RVA: 0x86DD590 Offset: 0x86D9590 VA: 0x86DD590
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 28753
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethod("GetAssetBundleBlocking")]
	// RVA: 0x86DD7EC Offset: 0x86D97EC VA: 0x86DD7EC
	public AssetBundle get_assetBundle() { }

	// RVA: 0x86DD828 Offset: 0x86D9828 VA: 0x86DD828
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 28754
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 28755
{
	// Properties
	public Object asset { get; }
	public Object[] allAssets { get; }

	// Methods

	[NativeMethod("GetLoadedAsset")]
	// RVA: 0x86DD830 Offset: 0x86D9830 VA: 0x86DD830 Slot: 4
	protected override Object GetResult() { }

	// RVA: 0x86DD86C Offset: 0x86D986C VA: 0x86DD86C
	public Object get_asset() { }

	[NativeMethod("GetAllLoadedAssets")]
	// RVA: 0x86DD878 Offset: 0x86D9878 VA: 0x86DD878
	public Object[] get_allAssets() { }

	// RVA: 0x86DD8B4 Offset: 0x86D98B4 VA: 0x86DD8B4
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation // TypeDefIndex: 28756
{
	// Methods

	[NativeMethod("WaitForCompletion")]
	// RVA: 0x86DD8BC Offset: 0x86D98BC VA: 0x86DD8BC
	public void WaitForCompletion() { }

	// RVA: 0x86DD8F8 Offset: 0x86D98F8 VA: 0x86DD8F8
	public void .ctor() { }
}

