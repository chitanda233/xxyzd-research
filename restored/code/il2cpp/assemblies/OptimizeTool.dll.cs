// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25279
{}

// Namespace: 
[CompilerGenerated]
private sealed class CaptureParticleEffect.<CaptureParticle>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25280
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CaptureParticleEffect <>4__this; // 0x20
	private RenderTexture <renderTexture>5__2; // 0x28
	private RenderTexture <previousTarget>5__3; // 0x30
	private RenderTexture <previousActive>5__4; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D16818 Offset: 0x7D12818 VA: 0x7D16818
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D168C4 Offset: 0x7D128C4 VA: 0x7D168C4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D168C8 Offset: 0x7D128C8 VA: 0x7D168C8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D16CE8 Offset: 0x7D12CE8 VA: 0x7D16CE8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D16CF0 Offset: 0x7D12CF0 VA: 0x7D16CF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D16D28 Offset: 0x7D12D28 VA: 0x7D16D28 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CaptureParticleEffect.<Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25281
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CaptureParticleEffect <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D16784 Offset: 0x7D12784 VA: 0x7D16784
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D16D30 Offset: 0x7D12D30 VA: 0x7D16D30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D16D34 Offset: 0x7D12D34 VA: 0x7D16D34 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D16DFC Offset: 0x7D12DFC VA: 0x7D16DFC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D16E04 Offset: 0x7D12E04 VA: 0x7D16E04 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D16E3C Offset: 0x7D12E3C VA: 0x7D16E3C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CaptureParticleEffect : MonoBehaviour // TypeDefIndex: 25282
{
	// Fields
	[Header("Capture Sources")]
	public Camera targetCamera; // 0x20
	[Header("Save Settings")]
	public string folder; // 0x28
	public string fileName; // 0x30

	// Methods

	[IteratorStateMachine(typeof(CaptureParticleEffect.<Start>d__3))]
	// RVA: 0x7D16718 Offset: 0x7D12718 VA: 0x7D16718
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(CaptureParticleEffect.<CaptureParticle>d__4))]
	// RVA: 0x7D167AC Offset: 0x7D127AC VA: 0x7D167AC
	public IEnumerator CaptureParticle() { }

	// RVA: 0x7D16840 Offset: 0x7D12840 VA: 0x7D16840
	public void .ctor() { }
}

// Namespace: 
public enum PrefabCategory // TypeDefIndex: 25283
{
	// Fields
	public int value__; // 0x0
	public const PrefabCategory Entity = 0;
	public const PrefabCategory BulletEnemy = 1;
	public const PrefabCategory BulletHero = 2;
}

// Namespace: 
[ExecuteInEditMode]
public class CreatePrefab : MonoBehaviour // TypeDefIndex: 25284
{
	// Methods

	// RVA: 0x7D16E44 Offset: 0x7D12E44 VA: 0x7D16E44
	public void .ctor() { }
}

// Namespace: 
public enum AnimatorType // TypeDefIndex: 25285
{
	// Fields
	public int value__; // 0x0
	public const AnimatorType Animator = 0;
	public const AnimatorType SequenceFrame = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SpriteSequenceAnimator.<>c // TypeDefIndex: 25286
{
	// Fields
	public static readonly SpriteSequenceAnimator.<>c <>9; // 0x0
	public static Comparison<Sprite> <>9__36_0; // 0x8

	// Methods

	// RVA: 0x7D17CDC Offset: 0x7D13CDC VA: 0x7D17CDC
	private static void .cctor() { }

	// RVA: 0x7D17D44 Offset: 0x7D13D44 VA: 0x7D17D44
	public void .ctor() { }

	// RVA: 0x7D17D4C Offset: 0x7D13D4C VA: 0x7D17D4C
	internal int <BuildFrames>b__36_0(Sprite a, Sprite b) { }
}

// Namespace: 
[CompilerGenerated]
private struct SpriteSequenceAnimator.<Init>d__31 : IAsyncStateMachine // TypeDefIndex: 25287
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SpriteSequenceAnimator <>4__this; // 0x28
	public string address; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7D17D9C Offset: 0x7D13D9C VA: 0x7D17D9C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D18098 Offset: 0x7D14098 VA: 0x7D18098 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SpriteSequenceAnimator.<LoadAtlasAsync>d__34 : IAsyncStateMachine // TypeDefIndex: 25288
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SpriteSequenceAnimator <>4__this; // 0x20
	public string address; // 0x28
	private string <cacheKey>5__2; // 0x30
	private TaskAwaiter<AssetData> <>u__1; // 0x38

	// Methods

	// RVA: 0x7D180A4 Offset: 0x7D140A4 VA: 0x7D180A4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D18828 Offset: 0x7D14828 VA: 0x7D18828 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class SpriteSequenceAnimator : MonoBehaviour // TypeDefIndex: 25289
{
	// Fields
	public bool isPlayAwake; // 0x20
	[Header("SpriteAtlas Address/key")]
	public string AtlasAddress; // 0x28
	[Header("序列帧名前缀，例如 MyFx -> MyFx_0000")]
	public string ObjectName; // 0x30
	[Header("序列帧数量，>0 时按名称+序号加载")]
	public int FrameCount; // 0x38
	[Header("播放帧率 (帧/秒)")]
	public float FrameRate; // 0x3C
	[Header("随机起始帧区间，x为最小帧，y为最大帧（包含）")]
	public Vector2Int randomRange; // 0x40
	[Min(0)]
	[Header("Delay before playback (seconds)")]
	public float Delay; // 0x48
	[Header("是否循环播放")]
	public bool Loop; // 0x4C
	private bool isFromBeginning; // 0x4D
	private static Dictionary<string, List<Sprite>> _spriteDict; // 0x0
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x4E
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; // 0x4F
	[CompilerGenerated]
	private int <CurrentFrame>k__BackingField; // 0x50
	public Action OnComplete; // 0x58
	public SpriteRenderer model; // 0x60
	private float _timer; // 0x68
	private float _delayTimer; // 0x6C
	private bool _delayPending; // 0x70
	private List<Sprite> _frames; // 0x78

	// Properties
	public bool IsPlaying { get; set; }
	public bool IsPaused { get; set; }
	public int CurrentFrame { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D16E4C Offset: 0x7D12E4C VA: 0x7D16E4C
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x7D16E54 Offset: 0x7D12E54 VA: 0x7D16E54
	private void set_IsPlaying(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D16E60 Offset: 0x7D12E60 VA: 0x7D16E60
	public bool get_IsPaused() { }

	[CompilerGenerated]
	// RVA: 0x7D16E68 Offset: 0x7D12E68 VA: 0x7D16E68
	private void set_IsPaused(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D16E74 Offset: 0x7D12E74 VA: 0x7D16E74
	public int get_CurrentFrame() { }

	[CompilerGenerated]
	// RVA: 0x7D16E7C Offset: 0x7D12E7C VA: 0x7D16E7C
	private void set_CurrentFrame(int value) { }

	// RVA: 0x7D16E84 Offset: 0x7D12E84 VA: 0x7D16E84
	private void Awake() { }

	// RVA: 0x7D16F5C Offset: 0x7D12F5C VA: 0x7D16F5C
	private void Update() { }

	// RVA: 0x7D17094 Offset: 0x7D13094 VA: 0x7D17094
	private void TryAdvanceFramesFromTimer() { }

	[AsyncStateMachine(typeof(SpriteSequenceAnimator.<Init>d__31))]
	// RVA: 0x7D16E8C Offset: 0x7D12E8C VA: 0x7D16E8C
	public void Init(string address) { }

	// RVA: 0x7D1729C Offset: 0x7D1329C VA: 0x7D1729C
	private void OnEnable() { }

	// RVA: 0x7D1731C Offset: 0x7D1331C VA: 0x7D1731C
	private void OnDisable() { }

	[AsyncStateMachine(typeof(SpriteSequenceAnimator.<LoadAtlasAsync>d__34))]
	// RVA: 0x7D17344 Offset: 0x7D13344 VA: 0x7D17344
	private Task LoadAtlasAsync(string address) { }

	// RVA: 0x7D1743C Offset: 0x7D1343C VA: 0x7D1743C
	private string BuildCacheKey(string address, string name, int count) { }

	// RVA: 0x7D1750C Offset: 0x7D1350C VA: 0x7D1750C
	private List<Sprite> BuildFrames(SpriteAtlas atlas) { }

	// RVA: 0x7D172C0 Offset: 0x7D132C0 VA: 0x7D172C0
	public void Play(bool fromBeginning = True) { }

	// RVA: 0x7D17330 Offset: 0x7D13330 VA: 0x7D17330
	public void Pause() { }

	// RVA: 0x7D1780C Offset: 0x7D1380C VA: 0x7D1780C
	public void Resume() { }

	// RVA: 0x7D17824 Offset: 0x7D13824 VA: 0x7D17824
	public void Stop() { }

	// RVA: 0x7D1785C Offset: 0x7D1385C VA: 0x7D1785C
	public void GoToFrame(int index) { }

	// RVA: 0x7D17900 Offset: 0x7D13900 VA: 0x7D17900
	public void SetFrameRate(float fps) { }

	// RVA: 0x7D177E4 Offset: 0x7D137E4 VA: 0x7D177E4
	private void ResetToFirstFrame(bool resetTimer = True) { }

	// RVA: 0x7D16FFC Offset: 0x7D12FFC VA: 0x7D16FFC
	private void SetRendererEnabled(bool value) { }

	// RVA: 0x7D17A10 Offset: 0x7D13A10 VA: 0x7D17A10
	private void ApplyCurrentFrameSprite() { }

	// RVA: 0x7D17914 Offset: 0x7D13914 VA: 0x7D17914
	private int GetStartFrameIndex() { }

	// RVA: 0x7D17168 Offset: 0x7D13168 VA: 0x7D17168
	private void AdvanceFrames(int frameStepCount) { }

	// RVA: 0x7D17AEC Offset: 0x7D13AEC VA: 0x7D17AEC
	private void CompletePlayback() { }

	// RVA: 0x7D17BDC Offset: 0x7D13BDC VA: 0x7D17BDC
	public void .ctor() { }

	// RVA: 0x7D17C44 Offset: 0x7D13C44 VA: 0x7D17C44
	private static void .cctor() { }
}

// Namespace: 
public enum LocalOrWorld // TypeDefIndex: 25290
{
	// Fields
	public int value__; // 0x0
	public const LocalOrWorld Local = 0;
	public const LocalOrWorld World = 1;
}

// Namespace: 
[Flags]
public enum StatusEnum // TypeDefIndex: 25291
{
	// Fields
	public int value__; // 0x0
	public const StatusEnum FristLoadToSuccess = 0;
	public const StatusEnum FristLoadToFailed = 1;
	public const StatusEnum WaitUntilToSuccess = 2;
	public const StatusEnum WaitUntilToFailed = 3;
	public const StatusEnum Success = 4;
	public const StatusEnum Failed = 5;
	public const StatusEnum Loading = 6;
	public const StatusEnum UnValid = 7;
}

// Namespace: 
public struct AssetData // TypeDefIndex: 25292
{
	// Fields
	private string path; // 0x0
	private AsyncOperationHandle handle; // 0x8
	private Object asset; // 0x20
	private int count; // 0x28
	private bool isGroupAsset; // 0x2C
	private bool isPersistence; // 0x2D

	// Properties
	public bool IsPersistence { get; }
	public bool IsGroupAsset { get; }
	public AsyncOperationHandle Handle { get; }
	public string Path { get; }
	public Object Result { get; set; }
	public int Count { get; }
	public bool IsDone { get; }
	public AsyncOperationStatus Status { get; }
	public Exception OperationException { get; }

	// Methods

	// RVA: 0x7D18890 Offset: 0x7D14890 VA: 0x7D18890
	public void .ctor(string path, AsyncOperationHandle handle, bool isPersistence, bool isGroupAsset, int count = 1) { }

	// RVA: 0x7D18900 Offset: 0x7D14900 VA: 0x7D18900
	public bool get_IsPersistence() { }

	// RVA: 0x7D18908 Offset: 0x7D14908 VA: 0x7D18908
	public bool get_IsGroupAsset() { }

	// RVA: 0x7D18910 Offset: 0x7D14910 VA: 0x7D18910
	public AsyncOperationHandle get_Handle() { }

	// RVA: 0x7D18924 Offset: 0x7D14924 VA: 0x7D18924
	public string get_Path() { }

	// RVA: 0x7D184C4 Offset: 0x7D144C4 VA: 0x7D184C4
	public Object get_Result() { }

	// RVA: 0x7D1892C Offset: 0x7D1492C VA: 0x7D1892C
	public void set_Result(Object value) { }

	// RVA: 0x7D18934 Offset: 0x7D14934 VA: 0x7D18934
	public int get_Count() { }

	// RVA: 0x7D1893C Offset: 0x7D1493C VA: 0x7D1893C
	public bool get_IsDone() { }

	// RVA: 0x7D18948 Offset: 0x7D14948 VA: 0x7D18948
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x7D18954 Offset: 0x7D14954 VA: 0x7D18954
	public Exception get_OperationException() { }

	// RVA: 0x7D18960 Offset: 0x7D14960 VA: 0x7D18960
	public bool IsValid() { }

	// RVA: 0x7D1896C Offset: 0x7D1496C VA: 0x7D1896C
	public void AddChannel() { }

	// RVA: 0x7D1897C Offset: 0x7D1497C VA: 0x7D1897C
	public void RemoveChannel() { }

	// RVA: 0x7D18990 Offset: 0x7D14990 VA: 0x7D18990
	public void ClearChannel() { }
}

// Namespace: 
public struct AssetData<T> // TypeDefIndex: 25293
{
	// Methods

	// RVA: -1 Offset: -1
	public static AssetData op_Implicit(AssetData<T> assetData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x548DA0C Offset: 0x5489A0C VA: 0x548DA0C
	|-AssetData<object>.op_Implicit
	*/
}

// Namespace: 
public enum AssetsPoolManager.CheckAssetType // TypeDefIndex: 25294
{
	// Fields
	public int value__; // 0x0
	public const AssetsPoolManager.CheckAssetType Prepare = 0;
	public const AssetsPoolManager.CheckAssetType Get = 1;
	public const AssetsPoolManager.CheckAssetType Release = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AssetsPoolManager.<>c // TypeDefIndex: 25295
{
	// Fields
	public static readonly AssetsPoolManager.<>c <>9; // 0x0
	public static Func<MethodInfo, bool> <>9__68_1; // 0x8

	// Methods

	// RVA: 0x7D1DE54 Offset: 0x7D19E54 VA: 0x7D1DE54
	private static void .cctor() { }

	// RVA: 0x7D1DEBC Offset: 0x7D19EBC VA: 0x7D1DEBC
	public void .ctor() { }

	// RVA: 0x7D1DEC4 Offset: 0x7D19EC4 VA: 0x7D1DEC4
	internal bool <PrepareAssetGroup>b__68_1(MethodInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AssetsPoolManager.<>c__DisplayClass51_0 // TypeDefIndex: 25296
{
	// Fields
	public AssetsPoolManager <>4__this; // 0x10
	public AsyncInstantiateOperation<GameObject> instantiateOperation; // 0x18
	public TaskCompletionSource<GameObject[]> tcs; // 0x20

	// Methods

	// RVA: 0x7D1BA98 Offset: 0x7D17A98 VA: 0x7D1BA98
	public void .ctor() { }

	// RVA: 0x7D1DF98 Offset: 0x7D19F98 VA: 0x7D1DF98
	internal void <AwaitInstantiateOperationBatch>b__0(AsyncOperation operation) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AssetsPoolManager.<>c__DisplayClass68_0 // TypeDefIndex: 25297
{
	// Fields
	public AssetsPoolManager <>4__this; // 0x10
	public string groupName; // 0x18

	// Methods

	// RVA: 0x7D1DFB4 Offset: 0x7D19FB4 VA: 0x7D1DFB4
	public void .ctor() { }

	// RVA: 0x7D1DFBC Offset: 0x7D19FBC VA: 0x7D1DFBC
	internal bool <PrepareAssetGroup>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<CacheAssetAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 25298
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string address; // 0x20
	public AssetsPoolManager <>4__this; // 0x28
	private TaskAwaiter<StatusEnum> <>u__1; // 0x30

	// Methods

	// RVA: 0x7D1E030 Offset: 0x7D1A030 VA: 0x7D1E030 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D1EA6C Offset: 0x7D1AA6C VA: 0x7D1EA6C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<CacheAssetsGroupAsync>d__65 : IAsyncStateMachine // TypeDefIndex: 25299
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HashSet<string> group; // 0x20
	public AssetsPoolManager <>4__this; // 0x28
	private HashSet<string> <textAsset>5__2; // 0x30
	private HashSet<string> <gameObjectAsset>5__3; // 0x38
	private HashSet<string> <scriptableObjectAsset>5__4; // 0x40
	private HashSet<string> <spriteAtlasAsset>5__5; // 0x48
	private HashSet<string> <textureAsset>5__6; // 0x50
	private HashSet<string> <audioAsset>5__7; // 0x58
	private HashSet<string> <materialAsset>5__8; // 0x60
	private List<Task> <tasks>5__9; // 0x68
	private TaskAwaiter <>u__1; // 0x70

	// Methods

	// RVA: 0x7D1EAD4 Offset: 0x7D1AAD4 VA: 0x7D1EAD4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D1FA3C Offset: 0x7D1BA3C VA: 0x7D1FA3C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<CacheInstances>d__44 : IAsyncStateMachine // TypeDefIndex: 25300
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string path; // 0x28
	private Queue<ValueTuple<GameObject, float>> <objectQueue>5__2; // 0x30
	private TaskAwaiter<AssetData> <>u__1; // 0x38

	// Methods

	// RVA: 0x7D1FAA4 Offset: 0x7D1BAA4 VA: 0x7D1FAA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D1FF44 Offset: 0x7D1BF44 VA: 0x7D1FF44 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<CacheInstances>d__45 : IAsyncStateMachine // TypeDefIndex: 25301
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string path; // 0x28
	public int count; // 0x30
	private Queue<ValueTuple<GameObject, float>> <objectQueue>5__2; // 0x38
	private int <len>5__3; // 0x40
	private TaskAwaiter<AssetData> <>u__1; // 0x48
	private TaskAwaiter<GameObject[]> <>u__2; // 0x50

	// Methods

	// RVA: 0x7D1FFAC Offset: 0x7D1BFAC VA: 0x7D1FFAC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D205EC Offset: 0x7D1C5EC VA: 0x7D205EC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<GetAsyncBatch>d__42 : IAsyncStateMachine // TypeDefIndex: 25302
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<GameObject[]> <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string path; // 0x28
	public int count; // 0x30
	public Transform parent; // 0x38
	public bool isResetTransform; // 0x40
	private GameObject[] <objects>5__2; // 0x48
	private TaskAwaiter<AssetData> <>u__1; // 0x50
	private TaskAwaiter<GameObject[]> <>u__2; // 0x58

	// Methods

	// RVA: 0x7D20654 Offset: 0x7D1C654 VA: 0x7D20654 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D20D28 Offset: 0x7D1CD28 VA: 0x7D20D28 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<GetAsyne>d__41 : IAsyncStateMachine // TypeDefIndex: 25303
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<GameObject> <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string path; // 0x28
	public Transform parent; // 0x30
	public bool isResetTransform; // 0x38
	private TaskAwaiter<AssetData> <>u__1; // 0x40

	// Methods

	// RVA: 0x7D20DA4 Offset: 0x7D1CDA4 VA: 0x7D20DA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D214B8 Offset: 0x7D1D4B8 VA: 0x7D214B8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<InstantiateAsyncBatch>d__52 : IAsyncStateMachine // TypeDefIndex: 25304
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<GameObject[]> <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public GameObject prefab; // 0x28
	public int count; // 0x30
	private TaskAwaiter<GameObject[]> <>u__1; // 0x38

	// Methods

	// RVA: 0x7D21534 Offset: 0x7D1D534 VA: 0x7D21534 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D217D4 Offset: 0x7D1D7D4 VA: 0x7D217D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<LoadAssetAsync>d__73<T> : IAsyncStateMachine // TypeDefIndex: 25305
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AssetData> <>t__builder; // 0x0
	public AssetsPoolManager <>4__this; // 0x0
	public string path; // 0x0
	public bool isPersistence; // 0x0
	public Action<AssetData> complete; // 0x0
	private TaskAwaiter<StatusEnum> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3739C Offset: 0x5D3339C VA: 0x5D3739C
	|-AssetsPoolManager.<LoadAssetAsync>d__73<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D376D0 Offset: 0x5D336D0 VA: 0x5D376D0
	|-AssetsPoolManager.<LoadAssetAsync>d__73<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<LoadAssetsAsync>d__70<T> : IAsyncStateMachine // TypeDefIndex: 25306
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<AssetData>> <>t__builder; // 0x0
	public HashSet<string> paths; // 0x0
	public AssetsPoolManager <>4__this; // 0x0
	public bool isPersistence; // 0x0
	public Action<Object> onComplete; // 0x0
	private TaskAwaiter <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3774C Offset: 0x5D3374C VA: 0x5D3774C
	|-AssetsPoolManager.<LoadAssetsAsync>d__70<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D37CE4 Offset: 0x5D33CE4 VA: 0x5D37CE4
	|-AssetsPoolManager.<LoadAssetsAsync>d__70<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<LoadSceneAsync>d__74 : IAsyncStateMachine // TypeDefIndex: 25307
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string path; // 0x28
	public LoadSceneMode loadMode; // 0x30
	public bool activateOnLoad; // 0x34
	public int priority; // 0x38
	private TaskAwaiter<SceneInstance> <>u__1; // 0x40

	// Methods

	// RVA: 0x7D21850 Offset: 0x7D1D850 VA: 0x7D21850 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D2209C Offset: 0x7D1E09C VA: 0x7D2209C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<PrepareAsset>d__72<T> : IAsyncStateMachine // TypeDefIndex: 25308
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<StatusEnum> <>t__builder; // 0x0
	public string path; // 0x0
	public AssetsPoolManager <>4__this; // 0x0
	public Action complete; // 0x0
	public bool isPersistence; // 0x0
	private AssetData <op>5__2; // 0x0
	private TaskAwaiter<object> <>u__1; // 0x0
	private AsyncOperationHandle<T> <handle>5__3; // 0x0
	private TaskAwaiter<T> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3A3B0 Offset: 0x5D363B0 VA: 0x5D3A3B0
	|-AssetsPoolManager.<PrepareAsset>d__72<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3B28C Offset: 0x5D3728C VA: 0x5D3B28C
	|-AssetsPoolManager.<PrepareAsset>d__72<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<PrepareAssetGroup>d__68 : IAsyncStateMachine // TypeDefIndex: 25309
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public AssetsPoolManager <>4__this; // 0x20
	public string groupName; // 0x28
	private AssetsPoolManager.<>c__DisplayClass68_0 <>8__1; // 0x30
	public bool isPersistence; // 0x38
	public Action<Object> onComplete; // 0x40
	private UniTask.Awaiter <>u__1; // 0x48
	private AsyncOperationHandle<IList<IResourceLocation>> <_handle>5__2; // 0x58
	private List<Task> <tasks>5__3; // 0x70
	private TaskAwaiter<IList<IResourceLocation>> <>u__2; // 0x78
	private TaskAwaiter <>u__3; // 0x80

	// Methods

	// RVA: 0x7D22104 Offset: 0x7D1E104 VA: 0x7D22104 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D237FC Offset: 0x7D1F7FC VA: 0x7D237FC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AssetsPoolManager.<PrepareAssetGroup>d__69<T> : IAsyncStateMachine // TypeDefIndex: 25310
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x0
	public HashSet<string> paths; // 0x0
	public AssetsPoolManager <>4__this; // 0x0
	public Action<Object> onComplete; // 0x0
	public bool isPersistence; // 0x0
	private List<string> <tempList>5__2; // 0x0
	private HashSet<Task> <handles>5__3; // 0x0
	private AsyncOperationHandle<IList<T>> <handle>5__4; // 0x0
	private TaskAwaiter <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3B308 Offset: 0x5D37308 VA: 0x5D3B308
	|-AssetsPoolManager.<PrepareAssetGroup>d__69<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3CA24 Offset: 0x5D38A24 VA: 0x5D3CA24
	|-AssetsPoolManager.<PrepareAssetGroup>d__69<object>.SetStateMachine
	*/
}

// Namespace: 
public class AssetsPoolManager : MonoSingleton<AssetsPoolManager> // TypeDefIndex: 25311
{
	// Fields
	[Tooltip("获取对象")]
	[Header("对象池调试")]
	public bool isOpenGetObjectDebug; // 0x20
	[Tooltip("对象还回对象池")]
	public bool isOpenGiveBackObjectDebug; // 0x21
	[Tooltip("对象彻底销毁")]
	public bool isOpenDestroyObjectDebug; // 0x22
	[InspectorReadOnly]
	[Header("资源调试")]
	public int loadingCount; // 0x24
	[Tooltip("加载资源调试")]
	public bool isOpenLoadAssetDebug; // 0x28
	[Tooltip("释放资源调试")]
	public bool isOpenReleaseAssetDebug; // 0x29
	[Header("追踪资源调试")]
	public bool isOpenTraceAssetsDebug; // 0x2A
	[Tooltip("需要追踪的资源路径")]
	public List<string> traceAssetPaths; // 0x30
	[Header("WebGL调试")]
	public bool isOpenWebGLDebug; // 0x38
	[Header("内存调试")]
	public bool isOpenMemeryDebug; // 0x39
	private float _nextPollTime; // 0x3C
	private float memoryCheckInterval; // 0x40
	private float _nextMemoryCheckTime; // 0x44
	private float memoryThresholdMB; // 0x48
	private float totalSystemMemoryMB; // 0x4C
	private float instanceTimeout; // 0x50
	public Transform trParentRoot; // 0x58
	private Dictionary<string, Queue<ValueTuple<GameObject, float>>> _objectPool; // 0x60
	private Dictionary<GameObject, string> _objectToPath; // 0x68
	private Dictionary<string, AssetData> cachedResources; // 0x70
	private bool isCanSilentCache; // 0x78
	private Queue<string> silentCacheAssets; // 0x80
	private LinkedList<AsyncOperationHandle> _lru; // 0x88
	private Dictionary<AsyncOperationHandle, LinkedListNode<AsyncOperationHandle>> _lruNodes; // 0x90
	private Dictionary<AsyncOperationHandle, Dictionary<string, int>> _handlePaths; // 0x98
	private Dictionary<string, bool> _cacheGroup; // 0xA0
	private MethodInfo _prepMethodDef; // 0xA8

	// Properties
	public IReadOnlyDictionary<string, AssetData> CachedResources { get; }
	public IReadOnlyDictionary<AsyncOperationHandle, Dictionary<string, int>> HandlePaths { get; }
	public IReadOnlyCollection<AsyncOperationHandle> LRUHandles { get; }
	public float InstanceTimeout { get; }
	public IReadOnlyDictionary<string, Queue<ValueTuple<GameObject, float>>> ObjectPool { get; }
	public IReadOnlyDictionary<GameObject, string> ObjectToPath { get; }
	public bool IsCanSilentCache { set; }

	// Methods

	// RVA: 0x7D18998 Offset: 0x7D14998 VA: 0x7D18998
	public IReadOnlyDictionary<string, AssetData> get_CachedResources() { }

	// RVA: 0x7D189A0 Offset: 0x7D149A0 VA: 0x7D189A0
	public IReadOnlyDictionary<AsyncOperationHandle, Dictionary<string, int>> get_HandlePaths() { }

	// RVA: 0x7D189A8 Offset: 0x7D149A8 VA: 0x7D189A8
	public IReadOnlyCollection<AsyncOperationHandle> get_LRUHandles() { }

	// RVA: 0x7D189F8 Offset: 0x7D149F8 VA: 0x7D189F8
	public float get_InstanceTimeout() { }

	// RVA: 0x7D18A00 Offset: 0x7D14A00 VA: 0x7D18A00
	public IReadOnlyDictionary<string, Queue<ValueTuple<GameObject, float>>> get_ObjectPool() { }

	// RVA: 0x7D18A08 Offset: 0x7D14A08 VA: 0x7D18A08
	public IReadOnlyDictionary<GameObject, string> get_ObjectToPath() { }

	// RVA: 0x7D18A10 Offset: 0x7D14A10 VA: 0x7D18A10
	public void ReleaseHandle(AsyncOperationHandle handle) { }

	// RVA: 0x7D19178 Offset: 0x7D15178 VA: 0x7D19178
	public void Awake() { }

	// RVA: 0x7D1944C Offset: 0x7D1544C VA: 0x7D1944C
	private void Update() { }

	// RVA: 0x7D192DC Offset: 0x7D152DC VA: 0x7D192DC
	public void InitializeMemoryThreshold() { }

	// RVA: 0x7D19804 Offset: 0x7D15804 VA: 0x7D19804
	private float GetIosMemoryThreshold() { }

	// RVA: 0x7D1976C Offset: 0x7D1576C VA: 0x7D1976C
	private float GetAndroidMemoryThreshold() { }

	// RVA: 0x7D19884 Offset: 0x7D15884 VA: 0x7D19884
	private void CheckMemory() { }

	// RVA: 0x7D1A064 Offset: 0x7D16064 VA: 0x7D1A064
	public GameObject Get(GameObject prefab, Transform parent, bool isResetTransform = False) { }

	// RVA: 0x7D1A560 Offset: 0x7D16560 VA: 0x7D1A560
	public GameObject Get(string path, Transform parent, bool isResetTransform = False) { }

	// RVA: 0x7D1A390 Offset: 0x7D16390 VA: 0x7D1A390
	private void SetTargetParent(GameObject target, Transform targetParent, bool isResetTransform = False) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<GetAsyne>d__41))]
	// RVA: 0x7D1ABF4 Offset: 0x7D16BF4 VA: 0x7D1ABF4
	public Task<GameObject> GetAsyne(string path, Transform parent, bool isResetTransform = False) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<GetAsyncBatch>d__42))]
	// RVA: 0x7D1AD38 Offset: 0x7D16D38 VA: 0x7D1AD38
	public Task<GameObject[]> GetAsyncBatch(string path, int count, Transform parent, bool isResetTransform = False) { }

	// RVA: 0x7D1AE84 Offset: 0x7D16E84 VA: 0x7D1AE84
	public void GiveBack(GameObject target, bool setPoolParent = True) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<CacheInstances>d__44))]
	// RVA: 0x7D1B200 Offset: 0x7D17200 VA: 0x7D1B200
	public Task CacheInstances(string path) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<CacheInstances>d__45))]
	// RVA: 0x7D1B2F8 Offset: 0x7D172F8 VA: 0x7D1B2F8
	public Task CacheInstances(string path, int count) { }

	// RVA: 0x7D19B50 Offset: 0x7D15B50 VA: 0x7D19B50
	public void ClearUnUseInstances() { }

	// RVA: 0x7D1B528 Offset: 0x7D17528 VA: 0x7D1B528
	public void GiveBackAllUsedInstances(bool isSetParent = True) { }

	// RVA: 0x7D1B408 Offset: 0x7D17408 VA: 0x7D1B408
	private void DestoryInstance(GameObject obj, string path) { }

	// RVA: 0x7D19520 Offset: 0x7D15520 VA: 0x7D19520
	private void CheckInstanceUseTime() { }

	// RVA: 0x7D1A508 Offset: 0x7D16508 VA: 0x7D1A508
	private void DontDestroy(GameObject target) { }

	// RVA: 0x7D1B92C Offset: 0x7D1792C VA: 0x7D1B92C
	private Task<GameObject[]> AwaitInstantiateOperationBatch(AsyncInstantiateOperation<GameObject> instantiateOperation) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<InstantiateAsyncBatch>d__52))]
	// RVA: 0x7D1BAA0 Offset: 0x7D17AA0 VA: 0x7D1BAA0
	private Task<GameObject[]> InstantiateAsyncBatch(GameObject prefab, int count) { }

	// RVA: 0x7D1A49C Offset: 0x7D1649C VA: 0x7D1A49C
	private GameObject Instantiate(GameObject prefab) { }

	// RVA: 0x7D1BBC0 Offset: 0x7D17BC0 VA: 0x7D1BBC0
	private void OnInstantiateOperationCompletedBatch(AsyncInstantiateOperation<GameObject> instantiateOperation, TaskCompletionSource<GameObject[]> tcs) { }

	// RVA: 0x7D1BC3C Offset: 0x7D17C3C VA: 0x7D1BC3C
	public void set_IsCanSilentCache(bool value) { }

	// RVA: 0x7D1BC48 Offset: 0x7D17C48 VA: 0x7D1BC48
	public void SilentCacheAsset(string path) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<CacheAssetAsync>d__64))]
	// RVA: 0x7D1BCA0 Offset: 0x7D17CA0 VA: 0x7D1BCA0
	public Task CacheAssetAsync(string address) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<CacheAssetsGroupAsync>d__65))]
	// RVA: 0x7D1BD9C Offset: 0x7D17D9C VA: 0x7D1BD9C
	public Task CacheAssetsGroupAsync(HashSet<string> group) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<PrepareAssetGroup>d__68))]
	// RVA: 0x7D1BEA0 Offset: 0x7D17EA0 VA: 0x7D1BEA0
	public Task PrepareAssetGroup(string groupName, bool isPersistence = False, Action<Object> onComplete) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<PrepareAssetGroup>d__69<T>))]
	// RVA: -1 Offset: -1
	public Task PrepareAssetGroup<T>(HashSet<string> paths, bool isPersistence = False, Action<Object> onComplete) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4503424 Offset: 0x44FF424 VA: 0x4503424
	|-AssetsPoolManager.PrepareAssetGroup<object>
	*/

	[AsyncStateMachine(typeof(AssetsPoolManager.<LoadAssetsAsync>d__70<T>))]
	// RVA: -1 Offset: -1
	public Task<List<AssetData>> LoadAssetsAsync<T>(HashSet<string> paths, bool isPersistence = False, Action<Object> onComplete) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45031BC Offset: 0x44FF1BC VA: 0x45031BC
	|-AssetsPoolManager.LoadAssetsAsync<object>
	*/

	// RVA: 0x7D1BFC4 Offset: 0x7D17FC4 VA: 0x7D1BFC4
	private string GetFileName(string path) { }

	[AsyncStateMachine(typeof(AssetsPoolManager.<PrepareAsset>d__72<T>))]
	// RVA: -1 Offset: -1
	public Task<StatusEnum> PrepareAsset<T>(string path, bool isPersistence = False, Action complete) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45032F0 Offset: 0x44FF2F0 VA: 0x45032F0
	|-AssetsPoolManager.PrepareAsset<object>
	*/

	[AsyncStateMachine(typeof(AssetsPoolManager.<LoadAssetAsync>d__73<T>))]
	// RVA: -1 Offset: -1
	public Task<AssetData> LoadAssetAsync<T>(string path, bool isPersistence = False, Action<AssetData> complete) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4502FE4 Offset: 0x44FEFE4 VA: 0x4502FE4
	|-AssetsPoolManager.LoadAssetAsync<object>
	*/

	[AsyncStateMachine(typeof(AssetsPoolManager.<LoadSceneAsync>d__74))]
	// RVA: 0x7D1C108 Offset: 0x7D18108 VA: 0x7D1C108
	public Task LoadSceneAsync(string path, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: -1 Offset: -1
	public StatusEnum PrepareAssetWaitForCompletion<T>(string path, bool isPersistence = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4503540 Offset: 0x44FF540 VA: 0x4503540
	|-AssetsPoolManager.PrepareAssetWaitForCompletion<object>
	*/

	// RVA: -1 Offset: -1
	public AssetData LoadAssetWaitForCompletion<T>(string path, bool isPersistence = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4503128 Offset: 0x44FF128 VA: 0x4503128
	|-AssetsPoolManager.LoadAssetWaitForCompletion<object>
	*/

	// RVA: 0x7D1C230 Offset: 0x7D18230 VA: 0x7D1C230
	public bool IsHaveAsset(string path) { }

	// RVA: 0x7D1A9DC Offset: 0x7D169DC VA: 0x7D1A9DC
	public bool GetAsset(string path, out AssetData assetData, bool isDebug = True) { }

	// RVA: 0x7D1C630 Offset: 0x7D18630 VA: 0x7D1C630
	public bool CheckCached(string path) { }

	// RVA: 0x7D1C688 Offset: 0x7D18688 VA: 0x7D1C688
	public void ReleaseGroup(List<AssetData> assets, bool isForce = False) { }

	// RVA: 0x7D1B874 Offset: 0x7D17874 VA: 0x7D1B874
	public void Release(string path, bool isForce = False) { }

	// RVA: 0x7D1CDB0 Offset: 0x7D18DB0 VA: 0x7D1CDB0
	private void Release(AsyncOperationHandle handle, bool isForce = False, bool isDebug = True) { }

	// RVA: 0x7D1D098 Offset: 0x7D19098 VA: 0x7D1D098
	private void EnqueueLRU(AsyncOperationHandle handle, bool isDebug = True) { }

	// RVA: 0x7D1C800 Offset: 0x7D18800 VA: 0x7D1C800
	public void Release(AssetData assetData, bool isForce = False, bool isDebug = True) { }

	// RVA: 0x7D1D28C Offset: 0x7D1928C VA: 0x7D1D28C
	private void EnqueueLRU(AssetData assetData, bool isDebug = True) { }

	// RVA: 0x7D1C2E8 Offset: 0x7D182E8 VA: 0x7D1C2E8
	private void TouchReference(AsyncOperationHandle key) { }

	// RVA: 0x7D19DFC Offset: 0x7D15DFC VA: 0x7D19DFC
	public void ReleaseLRU(float percent) { }

	// RVA: 0x7D1D49C Offset: 0x7D1949C VA: 0x7D1D49C
	public void ForceReleaseAll() { }

	// RVA: 0x7D1D700 Offset: 0x7D19700 VA: 0x7D1D700
	public void AddAssetDebug(string path) { }

	// RVA: 0x7D18A3C Offset: 0x7D14A3C VA: 0x7D18A3C
	private void ReleaseAddressable(AsyncOperationHandle handle) { }

	// RVA: 0x7D1948C Offset: 0x7D1548C VA: 0x7D1948C
	private void SilentCache() { }

	// RVA: 0x7D1C3E4 Offset: 0x7D183E4 VA: 0x7D1C3E4
	private void CheckAssetDebug(string path, AssetData assetData, AssetsPoolManager.CheckAssetType checkAssetType, bool isDebug = True) { }

	// RVA: 0x7D1D7EC Offset: 0x7D197EC VA: 0x7D1D7EC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7D1DB24 Offset: 0x7D19B24 VA: 0x7D1DB24
	private void <ReleaseAddressable>b__90_0(AsyncOperationHandle handle) { }
}

// Namespace: 
[CompilerGenerated]
private struct CacheManager.<CacheJsonAssetsAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 25312
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string key; // 0x20
	private List<string> <handles>5__2; // 0x28
	private List<Task> <tasks>5__3; // 0x30
	private TaskAwaiter<List<string>> <>u__1; // 0x38
	private TaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x7D244CC Offset: 0x7D204CC VA: 0x7D244CC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D250A0 Offset: 0x7D210A0 VA: 0x7D250A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CacheManager.<CacheTextAssetAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 25313
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string path; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x7D25108 Offset: 0x7D21108 VA: 0x7D25108 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D252FC Offset: 0x7D212FC VA: 0x7D252FC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CacheManager.<GetCachePaths>d__9 : IAsyncStateMachine // TypeDefIndex: 25314
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<string>> <>t__builder; // 0x8
	public string key; // 0x20
	private TaskAwaiter<List<string>> <>u__1; // 0x28

	// Methods

	// RVA: 0x7D25364 Offset: 0x7D21364 VA: 0x7D25364 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D255CC Offset: 0x7D215CC VA: 0x7D255CC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CacheManager.<LoadJsonData>d__13 : IAsyncStateMachine // TypeDefIndex: 25315
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<string>> <>t__builder; // 0x8
	public string jsonPath; // 0x20
	private TaskAwaiter<AssetData> <>u__1; // 0x28

	// Methods

	// RVA: 0x7D25648 Offset: 0x7D21648 VA: 0x7D25648 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D259D4 Offset: 0x7D219D4 VA: 0x7D259D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public static class CacheManager // TypeDefIndex: 25316
{
	// Fields
	private static readonly List<string> FindSubFolders; // 0x0
	private static readonly List<string> NoFindSubCacheFolders; // 0x8
	private static Dictionary<string, List<string>> cachedHandlesByFolder; // 0x10
	private static int count; // 0x18

	// Properties
	public static List<string> CacheFolders { get; }

	// Methods

	// RVA: 0x7D23864 Offset: 0x7D1F864 VA: 0x7D23864
	public static List<string> get_CacheFolders() { }

	// RVA: 0x7D23B10 Offset: 0x7D1FB10 VA: 0x7D23B10
	public static string GetJsonPath(string folderName) { }

	// RVA: 0x7D23B7C Offset: 0x7D1FB7C VA: 0x7D23B7C
	public static string FolderPathToJsonPath(string folderPath) { }

	[AsyncStateMachine(typeof(CacheManager.<CacheTextAssetAsync>d__8))]
	// RVA: 0x7D23C08 Offset: 0x7D1FC08 VA: 0x7D23C08
	public static Task CacheTextAssetAsync(string path) { }

	[AsyncStateMachine(typeof(CacheManager.<GetCachePaths>d__9))]
	// RVA: 0x7D23CEC Offset: 0x7D1FCEC VA: 0x7D23CEC
	public static Task<List<string>> GetCachePaths(string key) { }

	[AsyncStateMachine(typeof(CacheManager.<CacheJsonAssetsAsync>d__10))]
	// RVA: 0x7D23DE8 Offset: 0x7D1FDE8 VA: 0x7D23DE8
	public static Task CacheJsonAssetsAsync(string key) { }

	// RVA: 0x7D23ED0 Offset: 0x7D1FED0 VA: 0x7D23ED0
	public static void Release(string key) { }

	// RVA: 0x7D24194 Offset: 0x7D20194 VA: 0x7D24194
	public static string RemoveBrackets(string input) { }

	[AsyncStateMachine(typeof(CacheManager.<LoadJsonData>d__13))]
	// RVA: 0x7D24230 Offset: 0x7D20230 VA: 0x7D24230
	private static Task<List<string>> LoadJsonData(string jsonPath, string tag) { }

	// RVA: 0x7D2432C Offset: 0x7D2032C VA: 0x7D2432C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct CombinBytesManager.<InitBytes>d__3 : IAsyncStateMachine // TypeDefIndex: 25317
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string path; // 0x20
	public CombinBytesManager <>4__this; // 0x28
	[TupleElementNames(new[] { "rootPath", "filePath", "fileType", "fileText", "fileBytes" })]
	private TaskAwaiter<List<ValueTuple<string, string, string, string, byte[]>>> <>u__1; // 0x30

	// Methods

	// RVA: 0x7D26574 Offset: 0x7D22574 VA: 0x7D26574 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D26974 Offset: 0x7D22974 VA: 0x7D26974 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class CombinBytesManager : MonoSingleton<CombinBytesManager> // TypeDefIndex: 25318
{
	// Fields
	[Header("释放调试")]
	public bool isOpenReleaseDebug; // 0x20
	[TupleElementNames(new[] { "rootPath", "filePath", "fileType", "fileText", "fileBytes" })]
	private Dictionary<string, ValueTuple<string, string, string, string, byte[]>> _combinedBytes; // 0x28
	private Dictionary<string, ScriptableObject> _scriptableObjects; // 0x30

	// Methods

	[AsyncStateMachine(typeof(CombinBytesManager.<InitBytes>d__3))]
	// RVA: 0x7D25A50 Offset: 0x7D21A50 VA: 0x7D25A50
	public Task InitBytes(string path) { }

	// RVA: 0x7D25B4C Offset: 0x7D21B4C VA: 0x7D25B4C
	public void ReleaseBytes(string path) { }

	// RVA: 0x7D26000 Offset: 0x7D22000 VA: 0x7D26000
	public void InitBytes(string rootPath, TextAsset textAsset) { }

	// RVA: 0x7D261B8 Offset: 0x7D221B8 VA: 0x7D261B8
	public void AddValue(string path, ValueTuple<string, string, byte[]> value) { }

	// RVA: 0x7D2627C Offset: 0x7D2227C VA: 0x7D2627C
	public ValueTuple<string, string, string, string, byte[]> GetBytes(string path) { }

	// RVA: 0x7D26300 Offset: 0x7D22300 VA: 0x7D26300
	public ScriptableObject GetScriptableObject(string path) { }

	// RVA: 0x7D26484 Offset: 0x7D22484 VA: 0x7D26484
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AudioManager.<>c__DisplayClass46_0 // TypeDefIndex: 25319
{
	// Fields
	public AudioSource audioSource; // 0x10

	// Methods

	// RVA: 0x7D284F0 Offset: 0x7D244F0 VA: 0x7D284F0
	public void .ctor() { }

	// RVA: 0x7D284F8 Offset: 0x7D244F8 VA: 0x7D284F8
	internal bool <AutoRelease>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct AudioManager.<AutoRelease>d__46 : IAsyncStateMachine // TypeDefIndex: 25320
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public AudioSource audioSource; // 0x18
	public string path; // 0x20
	public AudioManager <>4__this; // 0x28
	public int cId; // 0x30
	private AudioManager.<>c__DisplayClass46_0 <>8__1; // 0x38
	private UniTask.Awaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x7D28520 Offset: 0x7D24520 VA: 0x7D28520 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D28BC4 Offset: 0x7D24BC4 VA: 0x7D28BC4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AudioManager.<PlayAudioClip>d__45 : IAsyncStateMachine // TypeDefIndex: 25321
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public string path; // 0x18
	public Action<long> getPlayID; // 0x20
	public AudioManager <>4__this; // 0x28
	public bool isCheckIntervalTime; // 0x30
	public bool isLoop; // 0x31
	public AudioMixerGroup audioMixerGroup; // 0x38
	public bool isBackground; // 0x40
	public float volume; // 0x44
	private int <curId>5__2; // 0x48
	private TaskAwaiter<StatusEnum> <>u__1; // 0x50
	private AudioClip <audioClip>5__3; // 0x58
	private UniTask.Awaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x7D28BD0 Offset: 0x7D24BD0 VA: 0x7D28BD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D29714 Offset: 0x7D25714 VA: 0x7D29714 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AudioManager.<PlayBackground>d__36 : IAsyncStateMachine // TypeDefIndex: 25322
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public string path; // 0x18
	public AudioManager <>4__this; // 0x20
	public float volume; // 0x28
	private UniTask.Awaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x7D29720 Offset: 0x7D25720 VA: 0x7D29720 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D29C30 Offset: 0x7D25C30 VA: 0x7D29C30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class AudioManager : MonoBehaviour // TypeDefIndex: 25323
{
	// Fields
	private static int id; // 0x0
	[Header("音量开关(仅Editor有效)")]
	public bool OnOff; // 0x20
	[SerializeField]
	[Header("日志开关")]
	private bool IsDebug; // 0x21
	private const int EchoThresholdFrame = 1;
	private const float UnusedAudioSourceLifeTime = 60;
	[Header("AudioMixer")]
	public AudioMixer m_audioMixer; // 0x28
	public AudioMixerGroup m_backgroundMixerGroup; // 0x30
	public AudioMixerGroup m_soundEffectMixerGroup; // 0x38
	[TupleElementNames(new[] { "audioSource", "lastPlayedTime" })]
	private readonly List<ValueTuple<AudioSource, float>> _audioSources; // 0x40
	private readonly Dictionary<string, int> _playFrameCount; // 0x48
	[TupleElementNames(new[] { "audioSource", "path" })]
	private Dictionary<long, ValueTuple<AudioSource, string>> playing; // 0x50
	private AudioSource _backgroundMusicSource; // 0x58
	private bool _mIsSoundEffectOpen; // 0x60
	private const string MSoundEffectVolumeName = "SoundEffectVolume";
	private const string MBackgroundVolumeName = "MusicVolume";
	private const string MAudioMixerVolumeName = "MasterVolume";
	private string _currentBackgroundMusicPath; // 0x68
	private const int CheckTime = 1;
	private float _lastCheckTime; // 0x70
	private readonly List<long> _pausedSoundEffectIds; // 0x78
	private long _playBackGroundID; // 0x80

	// Properties
	public AudioMixerGroup BackgroundMixerGroup { get; }
	public AudioMixerGroup SoundEffectMixerGroup { get; }

	// Methods

	// RVA: 0x7D269DC Offset: 0x7D229DC VA: 0x7D269DC
	public AudioMixerGroup get_BackgroundMixerGroup() { }

	// RVA: 0x7D269E4 Offset: 0x7D229E4 VA: 0x7D269E4
	public AudioMixerGroup get_SoundEffectMixerGroup() { }

	// RVA: 0x7D269EC Offset: 0x7D229EC VA: 0x7D269EC
	public void OnInit() { }

	// RVA: 0x7D269F0 Offset: 0x7D229F0 VA: 0x7D269F0
	public void SetMasterVolume(float volume) { }

	// RVA: 0x7D26AA0 Offset: 0x7D22AA0 VA: 0x7D26AA0
	public void PlayUnLoopSound(string path, float volume = 1, Action<long> onComplete, bool isCheckIntervalTime = True) { }

	// RVA: 0x7D26C38 Offset: 0x7D22C38 VA: 0x7D26C38
	public void PlayLoopSound(string path, float volume = 1, Action<long> onComplete, bool isCheckIntervalTime = True) { }

	// RVA: 0x7D26C90 Offset: 0x7D22C90 VA: 0x7D26C90
	public void SetSoundEffectOpen(bool open) { }

	// RVA: 0x7D26C9C Offset: 0x7D22C9C VA: 0x7D26C9C
	public bool IsSoundEffectOpen() { }

	// RVA: 0x7D26CA4 Offset: 0x7D22CA4 VA: 0x7D26CA4
	public void SetSoundEffectVolume(float volume) { }

	// RVA: 0x7D26D7C Offset: 0x7D22D7C VA: 0x7D26D7C
	public void StopAllSoundEffects() { }

	// RVA: 0x7D27040 Offset: 0x7D23040 VA: 0x7D27040
	public void PauseAllSoundEffects() { }

	// RVA: 0x7D272F0 Offset: 0x7D232F0 VA: 0x7D272F0
	public void ResumeAllSoundEffects(bool soundEffectOpen) { }

	// RVA: 0x7D2756C Offset: 0x7D2356C VA: 0x7D2756C
	public void StopLoopSound(long cId) { }

	[AsyncStateMachine(typeof(AudioManager.<PlayBackground>d__36))]
	// RVA: 0x7D2766C Offset: 0x7D2366C VA: 0x7D2766C
	public UniTask PlayBackground(string path, float volume = 1) { }

	// RVA: 0x7D27748 Offset: 0x7D23748 VA: 0x7D27748
	public void StopBackground() { }

	// RVA: 0x7D27854 Offset: 0x7D23854 VA: 0x7D27854
	public void PauseBackground() { }

	// RVA: 0x7D278FC Offset: 0x7D238FC VA: 0x7D278FC
	public void UnPauseBackground() { }

	// RVA: 0x7D27A10 Offset: 0x7D23A10 VA: 0x7D27A10
	public void SetBackgroundVolume(float volume) { }

	// RVA: 0x7D27AE8 Offset: 0x7D23AE8 VA: 0x7D27AE8
	public void OnDeInit() { }

	// RVA: 0x7D27D2C Offset: 0x7D23D2C VA: 0x7D27D2C
	private void Update() { }

	// RVA: 0x7D27D68 Offset: 0x7D23D68 VA: 0x7D27D68
	private void CheckAudioSources(float currentTime) { }

	// RVA: 0x7D27F48 Offset: 0x7D23F48 VA: 0x7D27F48
	private AudioSource GetAvailableAudioSource(bool isLoop, AudioMixerGroup audioMixerGroup, bool isBackground) { }

	[AsyncStateMachine(typeof(AudioManager.<PlayAudioClip>d__45))]
	// RVA: 0x7D26AF8 Offset: 0x7D22AF8 VA: 0x7D26AF8
	private UniTask PlayAudioClip(string path, float volume, bool isLoop, AudioMixerGroup audioMixerGroup, bool isBackground, Action<long> getPlayID, bool isCheckIntervalTime = True) { }

	[AsyncStateMachine(typeof(AudioManager.<AutoRelease>d__46))]
	// RVA: 0x7D2825C Offset: 0x7D2425C VA: 0x7D2825C
	private UniTask AutoRelease(int cId, string path, AudioSource audioSource) { }

	// RVA: 0x7D281B8 Offset: 0x7D241B8 VA: 0x7D281B8
	private AudioSource CreateAudioSource(bool loop, AudioMixerGroup outputGroup) { }

	// RVA: 0x7D28350 Offset: 0x7D24350 VA: 0x7D28350
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7D284E8 Offset: 0x7D244E8 VA: 0x7D284E8
	private void <PlayBackground>b__36_0(long i) { }
}

// Namespace: 
[DisallowMultipleComponent]
public class LockRotation : MonoBehaviour // TypeDefIndex: 25324
{
	// Fields
	[Header("是否在开始时记录当前世界旋转")]
	public bool useInitialWorldRotation; // 0x20
	private Quaternion _lockedWorldRotation; // 0x24

	// Methods

	// RVA: 0x7D29C3C Offset: 0x7D25C3C VA: 0x7D29C3C
	private void Awake() { }

	// RVA: 0x7D29C74 Offset: 0x7D25C74 VA: 0x7D29C74
	private void LateUpdate() { }

	// RVA: 0x7D29CA0 Offset: 0x7D25CA0 VA: 0x7D29CA0
	public void SetLockedWorldRotation(Quaternion worldRotation) { }

	// RVA: 0x7D29CAC Offset: 0x7D25CAC VA: 0x7D29CAC
	public void SetLockedWorldRotationEuler(Vector3 eulerAngles) { }

	// RVA: 0x7D29CE0 Offset: 0x7D25CE0 VA: 0x7D29CE0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct SimpleDoScale.ScaleKeyFrame // TypeDefIndex: 25325
{
	// Fields
	[Tooltip("时间轴（秒）")]
	public float time; // 0x0
	[Tooltip("对应的本地缩放")]
	public Vector3 scale; // 0x4

	// Methods

	// RVA: 0x7D2A020 Offset: 0x7D26020 VA: 0x7D2A020
	public void .ctor(float time, Vector3 scale) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SimpleDoScale.<>c // TypeDefIndex: 25326
{
	// Fields
	public static readonly SimpleDoScale.<>c <>9; // 0x0
	public static Comparison<SimpleDoScale.ScaleKeyFrame> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x7D2A02C Offset: 0x7D2602C VA: 0x7D2A02C
	private static void .cctor() { }

	// RVA: 0x7D2A094 Offset: 0x7D26094 VA: 0x7D2A094
	public void .ctor() { }

	// RVA: 0x7D2A09C Offset: 0x7D2609C VA: 0x7D2A09C
	internal int <PlayScale>b__10_0(SimpleDoScale.ScaleKeyFrame a, SimpleDoScale.ScaleKeyFrame b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimpleDoScale.<PlayScale>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 25327
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimpleDoScale <>4__this; // 0x20
	public Transform t; // 0x28
	private int <i>5__2; // 0x30
	private SimpleDoScale.ScaleKeyFrame <from>5__3; // 0x34
	private SimpleDoScale.ScaleKeyFrame <to>5__4; // 0x44
	private float <duration>5__5; // 0x54
	private float <elapsed>5__6; // 0x58

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D29F68 Offset: 0x7D25F68 VA: 0x7D29F68
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D2A0C8 Offset: 0x7D260C8 VA: 0x7D2A0C8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D2A0CC Offset: 0x7D260CC VA: 0x7D2A0CC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D2A428 Offset: 0x7D26428 VA: 0x7D2A428 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D2A430 Offset: 0x7D26430 VA: 0x7D2A430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D2A468 Offset: 0x7D26468 VA: 0x7D2A468 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class SimpleDoScale : MonoBehaviour // TypeDefIndex: 25328
{
	// Fields
	[Header("目标，不填则作用于自身")]
	public Transform target; // 0x20
	[Header("关键帧列表（按时间先后执行）")]
	public List<SimpleDoScale.ScaleKeyFrame> keyFrames; // 0x28
	[Header("播放控制")]
	public bool playOnEnable; // 0x30
	public bool loop; // 0x31
	public bool useUnscaledTime; // 0x32
	private Coroutine _playRoutine; // 0x38

	// Methods

	// RVA: 0x7D29CF0 Offset: 0x7D25CF0 VA: 0x7D29CF0
	private void OnEnable() { }

	// RVA: 0x7D29D00 Offset: 0x7D25D00 VA: 0x7D29D00
	public void Play() { }

	// RVA: 0x7D29DD4 Offset: 0x7D25DD4 VA: 0x7D29DD4
	public void Stop() { }

	[IteratorStateMachine(typeof(SimpleDoScale.<PlayScale>d__10))]
	// RVA: 0x7D29EE0 Offset: 0x7D25EE0 VA: 0x7D29EE0
	private IEnumerator PlayScale(Transform t) { }

	// RVA: 0x7D29F90 Offset: 0x7D25F90 VA: 0x7D29F90
	public void .ctor() { }
}

// Namespace: 
[Flags]
public enum HLogRedirect.OutLogType // TypeDefIndex: 25329
{
	// Fields
	public uint value__; // 0x0
	public const HLogRedirect.OutLogType Error = 1;
	public const HLogRedirect.OutLogType Assert = 2;
	public const HLogRedirect.OutLogType AllFormAssert = 3;
	public const HLogRedirect.OutLogType Warning = 4;
	public const HLogRedirect.OutLogType AllFormWarning = 7;
	public const HLogRedirect.OutLogType Log = 8;
	public const HLogRedirect.OutLogType AllFormLog = 15;
	public const HLogRedirect.OutLogType Exception = 16;
	public const HLogRedirect.OutLogType AllFormException = 31;
	public const HLogRedirect.OutLogType Any = 4294967295;
}

// Namespace: 
private struct HLogRedirect.RedirectInfo // TypeDefIndex: 25330
{
	// Fields
	public HLogRedirect.OutLogType Type; // 0x0
	public string LogName; // 0x8
	public StreamWriter Stream; // 0x10
	public bool OutputStacktrace; // 0x18
	public string[] LogStarts; // 0x20
}

// Namespace: 
public static class HLogRedirect // TypeDefIndex: 25331
{
	// Fields
	private static string _outputDir; // 0x0
	private static readonly Dictionary<string, HLogRedirect.RedirectInfo> RedirectInfos; // 0x8
	private static readonly StringBuilder StringBuilder; // 0x10

	// Methods

	// RVA: 0x7D2A470 Offset: 0x7D26470 VA: 0x7D2A470
	private static void .cctor() { }

	// RVA: 0x7D2A690 Offset: 0x7D26690 VA: 0x7D2A690
	public static void SetOutputDirectory(string dir) { }

	// RVA: 0x7D2A6F8 Offset: 0x7D266F8 VA: 0x7D2A6F8
	public static void Start(HLogRedirect.OutLogType type, string logName, bool outputStacktrace, string[] logStarts) { }

	// RVA: 0x7D2AAF8 Offset: 0x7D26AF8 VA: 0x7D2AAF8
	public static void Close(string logName) { }

	// RVA: 0x7D2ACCC Offset: 0x7D26CCC VA: 0x7D2ACCC
	public static void CloseIfStarted(string logName) { }

	// RVA: 0x7D2AE60 Offset: 0x7D26E60 VA: 0x7D2AE60
	public static void CloseAll() { }

	// RVA: 0x7D2B0A4 Offset: 0x7D270A4 VA: 0x7D2B0A4
	private static void HandleLog(string condition, string stacktrace, LogType type) { }

	// RVA: 0x7D2B560 Offset: 0x7D27560 VA: 0x7D2B560
	private static bool HasLogType(HLogRedirect.OutLogType outLogType, LogType logType) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebGLDebug.<Wait>d__4 : IAsyncStateMachine // TypeDefIndex: 25332
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int seconds; // 0x20
	public WebGLDebug <>4__this; // 0x28
	private int <i>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x7D2BA50 Offset: 0x7D27A50 VA: 0x7D2BA50 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D2BE08 Offset: 0x7D27E08 VA: 0x7D2BE08 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class WebGLDebug : MonoSingleton<WebGLDebug> // TypeDefIndex: 25333
{
	// Fields
	[SerializeField]
	private Text text; // 0x20
	private Dictionary<string, Stopwatch> watches; // 0x28

	// Methods

	// RVA: 0x7D2B5FC Offset: 0x7D275FC VA: 0x7D2B5FC
	public void Clear() { }

	// RVA: 0x7D2B6A0 Offset: 0x7D276A0 VA: 0x7D2B6A0
	public void AddLog(string log) { }

	[AsyncStateMachine(typeof(WebGLDebug.<Wait>d__4))]
	// RVA: 0x7D2B77C Offset: 0x7D2777C VA: 0x7D2B77C
	public Task Wait(int seconds) { }

	// RVA: 0x7D2B868 Offset: 0x7D27868 VA: 0x7D2B868
	public void AddLogAllocateMemory() { }

	// RVA: 0x7D2B914 Offset: 0x7D27914 VA: 0x7D2B914
	public void SetLog(string log) { }

	// RVA: 0x7D21D84 Offset: 0x7D1DD84 VA: 0x7D21D84
	public void StartStopwatch(string key, bool isLog = True, ColorEnum color = 98) { }

	// RVA: 0x7D21F10 Offset: 0x7D1DF10 VA: 0x7D21F10
	public void StopStopwatch(string key, ColorEnum color = 111) { }

	// RVA: 0x7D2B9B4 Offset: 0x7D279B4 VA: 0x7D2B9B4
	public void .ctor() { }
}

// Namespace: 
public enum EntityName // TypeDefIndex: 25334
{
	// Fields
	public int value__; // 0x0
	public const EntityName None = 0;
	public const EntityName 维修英雄 = 1;
	public const EntityName 农民 = 2;
	public const EntityName 士兵 = 3;
	public const EntityName 工人 = 4;
	public const EntityName 树木资源 = 5;
	public const EntityName 普通宝箱1 = 6;
	public const EntityName 普通宝箱2 = 7;
	public const EntityName 普通宝箱3 = 8;
	public const EntityName 普通宝箱4 = 9;
	public const EntityName 普通宝箱5 = 10;
	public const EntityName 图纸宝箱 = 11;
	public const EntityName 普通迷雾节点 = 12;
	public const EntityName 首领迷雾节点 = 13;
	public const EntityName 测试地形1 = 14;
	public const EntityName 测试地形2 = 15;
	public const EntityName 测试地形3 = 16;
	public const EntityName 野外祭坛 = 17;
	public const EntityName 野外近战巢穴 = 18;
	public const EntityName 野外远程巢穴 = 19;
	public const EntityName 基地核心 = 20;
	public const EntityName 扩展核心 = 21;
	public const EntityName 污染的月亮井 = 22;
	public const EntityName 月亮井 = 23;
	public const EntityName 银月树屋 = 24;
	public const EntityName 探索工会 = 25;
	public const EntityName 牛头人图腾 = 26;
	public const EntityName 娜迦宝库 = 27;
	public const EntityName 娜迦神像 = 28;
	public const EntityName 光明塔 = 29;
	public const EntityName 人鱼祭坛 = 30;
	public const EntityName 海洋之心 = 31;
	public const EntityName 奥法漩涡 = 32;
	public const EntityName 母树 = 33;
	public const EntityName 世界树 = 34;
	public const EntityName 菌塔 = 35;
	public const EntityName 停尸房 = 36;
	public const EntityName 鼠人祭坛 = 37;
	public const EntityName 鼠人神像 = 38;
	public const EntityName 瓦房 = 39;
	public const EntityName 住宅 = 40;
	public const EntityName 豪宅 = 41;
	public const EntityName 武装堡垒 = 42;
	public const EntityName 战争堡垒 = 43;
	public const EntityName 碧藤堡垒 = 44;
	public const EntityName 风暴堡垒 = 45;
	public const EntityName 初级堡垒 = 46;
	public const EntityName 次级堡垒 = 47;
	public const EntityName 邪气城墙 = 48;
	public const EntityName 毒雾城墙 = 49;
	public const EntityName 重装城墙 = 50;
	public const EntityName 爆破城墙 = 51;
	public const EntityName 减伤城墙 = 52;
	public const EntityName 守护城墙 = 53;
	public const EntityName 魔盾城墙 = 54;
	public const EntityName 抗魔城墙 = 55;
	public const EntityName 钢铁城墙 = 56;
	public const EntityName 钻石城墙 = 57;
	public const EntityName 恢复城墙 = 58;
	public const EntityName 再生城墙 = 59;
	public const EntityName 宝藏城墙 = 60;
	public const EntityName 闪避城墙 = 61;
	public const EntityName 石墙 = 62;
	public const EntityName 铁墙 = 63;
	public const EntityName 箭塔 = 64;
	public const EntityName 皇家箭塔 = 65;
	public const EntityName 连射塔 = 66;
	public const EntityName 重装连射塔 = 67;
	public const EntityName 三相射手塔 = 68;
	public const EntityName 三重射手塔 = 69;
	public const EntityName 三变射手塔 = 70;
	public const EntityName 唤魂塔 = 71;
	public const EntityName 龙魂塔 = 72;
	public const EntityName 冲锋塔 = 73;
	public const EntityName 火神塔 = 74;
	public const EntityName 弹射塔 = 75;
	public const EntityName 增伤弹射塔 = 76;
	public const EntityName 灼烧弹射塔 = 77;
	public const EntityName 治愈塔 = 78;
	public const EntityName 圣疗塔 = 79;
	public const EntityName 风暴塔 = 80;
	public const EntityName 雷霆塔 = 81;
	public const EntityName 恶灵召唤塔 = 82;
	public const EntityName 地狱召唤塔 = 83;
	public const EntityName 蓄能塔 = 84;
	public const EntityName 充能塔 = 85;
	public const EntityName 劲弩射手塔 = 86;
	public const EntityName 巨弩射手塔 = 87;
	public const EntityName 普通炮塔 = 88;
	public const EntityName 火焰炮塔 = 89;
	public const EntityName 雷电炮塔 = 90;
	public const EntityName 光线照射塔 = 91;
	public const EntityName 激光射线塔 = 92;
	public const EntityName 机械要塞 = 93;
	public const EntityName 不灭要塞 = 94;
	public const EntityName 石头 = 95;
	public const EntityName 巨神兵 = 96;
	public const EntityName 小兵 = 97;
	public const EntityName 红色十字 = 98;
	public const EntityName 炎帝 = 99;
	public const EntityName 先祖武士 = 100;
	public const EntityName 灵魂武士 = 101;
	public const EntityName 白熊 = 102;
	public const EntityName 棕熊 = 103;
	public const EntityName 黑熊 = 104;
	public const EntityName 血骑士 = 105;
	public const EntityName 狮锤 = 106;
	public const EntityName 月光使徒 = 107;
	public const EntityName 时光法师 = 108;
	public const EntityName 黑铁卫士 = 109;
	public const EntityName 苍翠之盾 = 110;
	public const EntityName 白狼 = 111;
	public const EntityName 雪狼王 = 112;
	public const EntityName 蝙蝠 = 113;
	public const EntityName 猪脸蝙蝠 = 114;
	public const EntityName 禁卫统领 = 115;
	public const EntityName 奥法元帅 = 116;
	public const EntityName 巫师 = 117;
	public const EntityName 督军 = 118;
	public const EntityName 巡林地 = 119;
	public const EntityName 暗影阁楼 = 120;
	public const EntityName 沙漠祠堂 = 121;
	public const EntityName 蛇神祭坛 = 122;
	public const EntityName 红龙巢穴 = 123;
	public const EntityName 黑龙巢穴 = 124;
	public const EntityName 巨魔洞穴 = 125;
	public const EntityName 黄魔洞穴 = 126;
	public const EntityName 绿魔洞穴 = 127;
	public const EntityName 族灵祠堂 = 128;
	public const EntityName 魂灵祠堂 = 129;
	public const EntityName 翠岭窟穴 = 130;
	public const EntityName 毒痕窟穴 = 131;
	public const EntityName 寒霜圣殿 = 132;
	public const EntityName 法神领域 = 133;
	public const EntityName 白熊巢穴 = 134;
	public const EntityName 棕熊洞窟 = 135;
	public const EntityName 黑熊巢穴 = 136;
	public const EntityName 弓箭营地 = 137;
	public const EntityName 幻射场地 = 138;
	public const EntityName 烈火营地 = 139;
	public const EntityName 蜘蛛巢穴 = 140;
	public const EntityName 巫毒庙宇 = 141;
	public const EntityName 巫毒阁楼 = 142;
	public const EntityName 亡魂祠堂 = 143;
	public const EntityName 死神殿堂 = 144;
	public const EntityName 诅咒营地 = 145;
	public const EntityName 痛苦营地 = 146;
	public const EntityName 魔王营地 = 147;
	public const EntityName 影剑营地 = 148;
	public const EntityName 暗影营地 = 149;
	public const EntityName 浪人营地 = 150;
	public const EntityName 狂君庭院 = 151;
	public const EntityName 鹰嘴场地 = 152;
	public const EntityName 弹射场馆 = 153;
	public const EntityName 天使营地 = 154;
	public const EntityName 守卫营地 = 155;
	public const EntityName 庇护所 = 156;
	public const EntityName 魔盾营地 = 157;
	public const EntityName 抗魔营地 = 158;
	public const EntityName 铁甲营地 = 159;
	public const EntityName 钢铁营地 = 160;
	public const EntityName 野法林地 = 161;
	public const EntityName 炮灰营地 = 162;
	public const EntityName 法师馆舍 = 163;
	public const EntityName 枪兵营地 = 164;
	public const EntityName 链甲营地 = 165;
	public const EntityName 北地住所 = 166;
	public const EntityName 奴隶住所 = 167;
	public const EntityName 勇卫营地 = 168;
	public const EntityName 光辉圣殿 = 169;
	public const EntityName 绿龙巢穴 = 170;
	public const EntityName 天空龙穴 = 171;
	public const EntityName 海盗船 = 172;
	public const EntityName 鬼盗船 = 173;
	public const EntityName 蓝鹰巢穴 = 174;
	public const EntityName 蓝龙巢穴 = 175;
	public const EntityName 金龙祭坛 = 176;
	public const EntityName 魔龙祭坛 = 177;
	public const EntityName 幼鸡庄园 = 178;
	public const EntityName 野火领域 = 179;
	public const EntityName 雄鸡场地 = 180;
	public const EntityName 水兵营地 = 181;
	public const EntityName 冰魔宫殿 = 182;
	public const EntityName 食魔穴洞 = 183;
	public const EntityName 领袖营地 = 184;
	public const EntityName 焰猪园地 = 185;
	public const EntityName 雪牙窟穴 = 186;
	public const EntityName 逃兵营地 = 187;
	public const EntityName 法术院校 = 188;
	public const EntityName 箭师场地 = 189;
	public const EntityName 战士营地 = 190;
	public const EntityName 召唤阁楼 = 191;
	public const EntityName 糖果屋舍 = 192;
	public const EntityName 剑舞场地 = 193;
	public const EntityName 幻舞场馆 = 194;
	public const EntityName 野祭坛场 = 195;
	public const EntityName 野王营地 = 196;
	public const EntityName 黑剑场地 = 197;
	public const EntityName 暗牙领域 = 198;
	public const EntityName 地主庄园 = 199;
	public const EntityName 金矿 = 200;
	public const EntityName 红虫巢穴 = 201;
	public const EntityName 镰刀坑穴 = 202;
	public const EntityName 蜥蜴巢穴 = 203;
	public const EntityName 宝石穴洞 = 204;
	public const EntityName 法师高校 = 205;
	public const EntityName 烈焰学院 = 206;
	public const EntityName 天象学院 = 207;
	public const EntityName 斗技场 = 208;
	public const EntityName 狂风营地 = 209;
	public const EntityName 轻装步兵营 = 210;
	public const EntityName 重装步兵营 = 211;
	public const EntityName 黄鬃马厩 = 212;
	public const EntityName 汗血马舍 = 213;
	public const EntityName 猎人小屋 = 214;
	public const EntityName 暗影林地 = 215;
	public const EntityName 裁决所 = 216;
	public const EntityName 神圣教庭 = 217;
	public const EntityName 石头人 = 218;
	public const EntityName 恶犬 = 219;
	public const EntityName 看门犬 = 220;
	public const EntityName 魔豹 = 221;
	public const EntityName 月豹 = 222;
	public const EntityName 怨龙 = 223;
	public const EntityName 小怨龙 = 224;
	public const EntityName 灰狼 = 225;
	public const EntityName 骨龙 = 226;
	public const EntityName 小骨龙 = 227;
	public const EntityName 恐狼 = 228;
	public const EntityName 先祖武士灵魂 = 229;
	public const EntityName 灵魂武士灵魂 = 230;
	public const EntityName 影剑士复制者 = 231;
	public const EntityName 暗影骑士复制者 = 232;
	public const EntityName 枪兵 = 233;
	public const EntityName 链甲枪兵 = 234;
	public const EntityName 金龙 = 235;
	public const EntityName 魔龙 = 236;
	public const EntityName 维京武士 = 237;
	public const EntityName 奴隶主 = 238;
	public const EntityName 巫毒信徒 = 239;
	public const EntityName 巫毒守卫 = 240;
	public const EntityName 游侠 = 241;
	public const EntityName 死亡射手 = 242;
	public const EntityName 红卫士 = 243;
	public const EntityName 圣光骑士 = 244;
	public const EntityName 翡翠龙 = 245;
	public const EntityName 毒龙 = 246;
	public const EntityName 幼鸡 = 247;
	public const EntityName 火鸡 = 248;
	public const EntityName 雄鸡 = 249;
	public const EntityName 水战士 = 250;
	public const EntityName 不朽蓝魔 = 251;
	public const EntityName 食人魔 = 252;
	public const EntityName 统领 = 253;
	public const EntityName 冰雪法师 = 254;
	public const EntityName 法神 = 255;
	public const EntityName 沙漠弓手 = 256;
	public const EntityName 幻想射手 = 257;
	public const EntityName 烈焰射手 = 258;
	public const EntityName 蜘蛛 = 259;
	public const EntityName 火猪 = 260;
	public const EntityName 白牙 = 261;
	public const EntityName 逃兵 = 262;
	public const EntityName 法师 = 263;
	public const EntityName 射手 = 264;
	public const EntityName 战士 = 265;
	public const EntityName 守卫 = 266;
	public const EntityName 教廷守卫 = 267;
	public const EntityName 召唤师 = 268;
	public const EntityName 糖果少女 = 269;
	public const EntityName 剑舞者 = 270;
	public const EntityName 幻舞者 = 271;
	public const EntityName 亡灵法师 = 272;
	public const EntityName 死神 = 273;
	public const EntityName 野法师 = 274;
	public const EntityName 炮灰法师 = 275;
	public const EntityName 法师英雄 = 276;
	public const EntityName 野人矛手 = 277;
	public const EntityName 野人祭祀 = 278;
	public const EntityName 野人王 = 279;
	public const EntityName 绿龙 = 280;
	public const EntityName 天空龙 = 281;
	public const EntityName 诅咒剑士 = 282;
	public const EntityName 痛苦盾卫 = 283;
	public const EntityName 魔王禁卫 = 284;
	public const EntityName 影剑士 = 285;
	public const EntityName 暗影骑士 = 286;
	public const EntityName 黑剑 = 287;
	public const EntityName 暗牙 = 288;
	public const EntityName 地主 = 289;
	public const EntityName 黄金手 = 290;
	public const EntityName 维京海盗 = 291;
	public const EntityName 幽影死神 = 292;
	public const EntityName 红虫 = 293;
	public const EntityName 镰刀虫 = 294;
	public const EntityName 浪人 = 295;
	public const EntityName 狂君 = 296;
	public const EntityName 巨魔 = 297;
	public const EntityName 黄魔 = 298;
	public const EntityName 绿魔 = 299;
	public const EntityName 沙漠信徒 = 300;
	public const EntityName 蛇神使者 = 301;
	public const EntityName 魔盾士兵 = 302;
	public const EntityName 抗魔卫士 = 303;
	public const EntityName 蜥蜴 = 304;
	public const EntityName 宝石蜥蜴 = 305;
	public const EntityName 鹰嘴射手 = 306;
	public const EntityName 弹射射手 = 307;
	public const EntityName 天使射手 = 308;
	public const EntityName 飞鹰 = 309;
	public const EntityName 蓝龙 = 310;
	public const EntityName 铁甲战士 = 311;
	public const EntityName 钢铁战将 = 312;
	public const EntityName 红龙 = 313;
	public const EntityName 黑龙 = 314;
	public const EntityName 盾卫 = 315;
	public const EntityName 重装战士 = 316;
	public const EntityName 黄鬃马 = 317;
	public const EntityName 汗血马 = 318;
	public const EntityName 精英猎人 = 319;
	public const EntityName 暗夜射手 = 320;
	public const EntityName 惩戒神官 = 321;
	public const EntityName 主教 = 322;
	public const EntityName 法师学徒 = 323;
	public const EntityName 火焰法师 = 324;
	public const EntityName 天象法师 = 325;
	public const EntityName 角斗士 = 326;
	public const EntityName 狂战士 = 327;
	public const EntityName 腐尸鼠 = 328;
	public const EntityName 恶鼠 = 329;
	public const EntityName 青翠蠕兵 = 330;
	public const EntityName 邪眼红 = 331;
	public const EntityName 青翠蠕将 = 332;
	public const EntityName 青翠蠕王 = 333;
	public const EntityName 混沌鼠 = 334;
	public const EntityName 母蛛 = 335;
	public const EntityName 子蛛 = 336;
	public const EntityName 混沌恶猪 = 337;
	public const EntityName 混沌恶犬 = 338;
	public const EntityName 蜘蛛皇阿纳卓斯 = 339;
	public const EntityName 混沌豪猪 = 340;
	public const EntityName 混沌座狼 = 341;
	public const EntityName 混沌士兵 = 342;
	public const EntityName 混沌座熊 = 343;
	public const EntityName 地龙铁 = 344;
	public const EntityName 地龙王加尔贡 = 345;
	public const EntityName 腐尸冠军鼠 = 346;
	public const EntityName 邪眼暗 = 347;
	public const EntityName 豹帝萨瓦隆 = 348;
	public const EntityName 地狱双头犬 = 349;
	public const EntityName 邪眼王尼克萨斯 = 350;
	public const EntityName 混沌屠夫 = 351;
	public const EntityName 混沌守卫黑卡托斯 = 352;
}

// Namespace: 
public enum PropertyName // TypeDefIndex: 25335
{
	// Fields
	public int value__; // 0x0
}

// Namespace: 
public abstract class GameEntity : MonoBehaviour, IResettable // TypeDefIndex: 25336
{
	// Fields
	private static uint currentId; // 0x0
	private uint id; // 0x20
	[CompilerGenerated]
	private EntityName <EntityName>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsStart>k__BackingField; // 0x29
	private readonly Dictionary<EventName, IFastEvent> _events; // 0x30
	private BitSet _Traits; // 0x38
	private readonly Dictionary<TraitName, ITrait> _components; // 0x40
	private readonly List<IFlatValueTrait> _flatValues; // 0x48
	private readonly List<IPersentValueTrait> _persentValues; // 0x50
	private readonly List<IInitTrait> _initComponents; // 0x58
	private readonly List<IUpdateTrait> _updateComponents; // 0x60
	private readonly List<ILateUpdateTrait> _lateUpdateComponents; // 0x68
	private readonly List<IEventTrait> _eventComponents; // 0x70
	private readonly List<IEventSubscriber> _eventSubscribers; // 0x78
	private Transform rotateTransform; // 0x80

	// Properties
	public uint ID { get; }
	public EntityName EntityName { get; set; }
	public bool IsDead { get; set; }
	public bool IsStart { get; set; }
	public IReadOnlyDictionary<TraitName, ITrait> Components { get; }
	public IReadOnlyList<IFlatValueTrait> FlatValues { get; }
	public IReadOnlyList<IPersentValueTrait> PersentValues { get; }
	public IReadOnlyList<IInitTrait> InitComponents { get; }
	public IReadOnlyList<IUpdateTrait> UpdateComponents { get; }
	public IReadOnlyList<ILateUpdateTrait> LateUpdateComponents { get; }
	public IReadOnlyList<IEventTrait> EventComponents { get; }
	public IReadOnlyList<IEventSubscriber> EventSubscribers { get; }
	public virtual Transform RotateTransform { get; }

	// Methods

	// RVA: 0x7D2BE70 Offset: 0x7D27E70 VA: 0x7D2BE70
	public uint get_ID() { }

	[CompilerGenerated]
	// RVA: 0x7D2BED0 Offset: 0x7D27ED0 VA: 0x7D2BED0
	public EntityName get_EntityName() { }

	[CompilerGenerated]
	// RVA: 0x7D2BED8 Offset: 0x7D27ED8 VA: 0x7D2BED8
	public void set_EntityName(EntityName value) { }

	[CompilerGenerated]
	// RVA: 0x7D2BEE0 Offset: 0x7D27EE0 VA: 0x7D2BEE0
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x7D2BEE8 Offset: 0x7D27EE8 VA: 0x7D2BEE8
	public void set_IsDead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D2BEF4 Offset: 0x7D27EF4 VA: 0x7D2BEF4
	public bool get_IsStart() { }

	[CompilerGenerated]
	// RVA: 0x7D2BEFC Offset: 0x7D27EFC VA: 0x7D2BEFC
	public void set_IsStart(bool value) { }

	// RVA: 0x7D2BF08 Offset: 0x7D27F08 VA: 0x7D2BF08
	private void Update() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnUpdate();

	// RVA: 0x7D2C0D8 Offset: 0x7D280D8 VA: 0x7D2C0D8
	private void LateUpdate() { }

	// RVA: 0x7D2C298 Offset: 0x7D28298 VA: 0x7D2C298
	public void RegisterEvent(EventName evt, Action handler) { }

	// RVA: 0x7D2C518 Offset: 0x7D28518 VA: 0x7D2C518
	public void UnregisterEvent(EventName evt, Action handler) { }

	// RVA: 0x7D2C6F4 Offset: 0x7D286F4 VA: 0x7D2C6F4
	public void Send(EventName evt) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1>(EventName evt, Action<T1> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D0DC Offset: 0x46290DC VA: 0x462D0DC
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1>(EventName evt, Action<T1> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462ED78 Offset: 0x462AD78 VA: 0x462ED78
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1>(EventName evt, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462DA54 Offset: 0x4629A54 VA: 0x462DA54
	|-GameEntity.Send<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1, T2>(EventName evt, Action<T1, T2> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D270 Offset: 0x4629270 VA: 0x462D270
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1, T2>(EventName evt, Action<T1, T2> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462EEA8 Offset: 0x462AEA8 VA: 0x462EEA8
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1, T2>(EventName evt, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462DC24 Offset: 0x4629C24 VA: 0x462DC24
	|-GameEntity.Send<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1, T2, T3>(EventName evt, Action<T1, T2, T3> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D404 Offset: 0x4629404 VA: 0x462D404
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1, T2, T3>(EventName evt, Action<T1, T2, T3> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462EFD8 Offset: 0x462AFD8 VA: 0x462EFD8
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1, T2, T3>(EventName evt, T1 a1, T2 a2, T3 a3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462DE48 Offset: 0x4629E48 VA: 0x462DE48
	|-GameEntity.Send<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1, T2, T3, T4>(EventName evt, Action<T1, T2, T3, T4> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D598 Offset: 0x4629598 VA: 0x462D598
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1, T2, T3, T4>(EventName evt, Action<T1, T2, T3, T4> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F108 Offset: 0x462B108 VA: 0x462F108
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1, T2, T3, T4>(EventName evt, T1 a1, T2 a2, T3 a3, T4 a4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462E0E4 Offset: 0x462A0E4 VA: 0x462E0E4
	|-GameEntity.Send<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1, T2, T3, T4, T5>(EventName evt, Action<T1, T2, T3, T4, T5> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D72C Offset: 0x462972C VA: 0x462D72C
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1, T2, T3, T4, T5>(EventName evt, Action<T1, T2, T3, T4, T5> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F238 Offset: 0x462B238 VA: 0x462F238
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1, T2, T3, T4, T5>(EventName evt, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462E3DC Offset: 0x462A3DC VA: 0x462E3DC
	|-GameEntity.Send<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T1, T2, T3, T4, T5, T6>(EventName evt, Action<T1, T2, T3, T4, T5, T6> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462D8C0 Offset: 0x46298C0 VA: 0x462D8C0
	|-GameEntity.RegisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T1, T2, T3, T4, T5, T6>(EventName evt, Action<T1, T2, T3, T4, T5, T6> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462F368 Offset: 0x462B368 VA: 0x462F368
	|-GameEntity.UnregisterEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Send<T1, T2, T3, T4, T5, T6>(EventName evt, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462E73C Offset: 0x462A73C VA: 0x462E73C
	|-GameEntity.Send<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D2C84C Offset: 0x7D2884C VA: 0x7D2C84C
	private void ClearEvent() { }

	// RVA: 0x7D2CA0C Offset: 0x7D28A0C VA: 0x7D2CA0C
	public IReadOnlyDictionary<TraitName, ITrait> get_Components() { }

	// RVA: 0x7D2CA14 Offset: 0x7D28A14 VA: 0x7D2CA14
	public IReadOnlyList<IFlatValueTrait> get_FlatValues() { }

	// RVA: 0x7D2CA1C Offset: 0x7D28A1C VA: 0x7D2CA1C
	public IReadOnlyList<IPersentValueTrait> get_PersentValues() { }

	// RVA: 0x7D2CA24 Offset: 0x7D28A24 VA: 0x7D2CA24
	public IReadOnlyList<IInitTrait> get_InitComponents() { }

	// RVA: 0x7D2CA2C Offset: 0x7D28A2C VA: 0x7D2CA2C
	public IReadOnlyList<IUpdateTrait> get_UpdateComponents() { }

	// RVA: 0x7D2CA34 Offset: 0x7D28A34 VA: 0x7D2CA34
	public IReadOnlyList<ILateUpdateTrait> get_LateUpdateComponents() { }

	// RVA: 0x7D2CA3C Offset: 0x7D28A3C VA: 0x7D2CA3C
	public IReadOnlyList<IEventTrait> get_EventComponents() { }

	// RVA: 0x7D2CA44 Offset: 0x7D28A44 VA: 0x7D2CA44
	public IReadOnlyList<IEventSubscriber> get_EventSubscribers() { }

	// RVA: 0x7D2CA4C Offset: 0x7D28A4C VA: 0x7D2CA4C
	public ValueTuple<ITrait, bool> AddOrGetTrait(TraitName f) { }

	// RVA: 0x7D2D534 Offset: 0x7D29534 VA: 0x7D2D534
	public bool HasTrait(TraitName f) { }

	// RVA: -1 Offset: -1
	public bool TryGetTrait<T>(TraitName traitName, out T trait) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462EAFC Offset: 0x462AAFC VA: 0x462EAFC
	|-GameEntity.TryGetTrait<object>
	|
	|-RVA: 0x462EC24 Offset: 0x462AC24 VA: 0x462EC24
	|-GameEntity.TryGetTrait<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D2D578 Offset: 0x7D29578 VA: 0x7D2D578
	public bool TryGetTraitData(TraitName traitName, out TraitData traitData) { }

	// RVA: 0x7D2D684 Offset: 0x7D29684 VA: 0x7D2D684
	public void AddOrChangeTraitData(TraitName traitName, Func<TraitData, TraitData> change) { }

	// RVA: 0x7D2D80C Offset: 0x7D2980C VA: 0x7D2D80C
	public void RemoveTrait(TraitName f) { }

	// RVA: 0x7D2D8C0 Offset: 0x7D298C0 VA: 0x7D2D8C0
	public void RemoveTrait(ITrait comp) { }

	// RVA: 0x7D2E054 Offset: 0x7D2A054 VA: 0x7D2E054
	public void RemoveAllTrait() { }

	// RVA: 0x7D2E750 Offset: 0x7D2A750 VA: 0x7D2E750 Slot: 6
	public virtual Transform get_RotateTransform() { }

	// RVA: 0x7D2E7E4 Offset: 0x7D2A7E4 VA: 0x7D2E7E4
	public void Init(EntityName entityName) { }

	// RVA: 0x7D2EA60 Offset: 0x7D2AA60 VA: 0x7D2EA60 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x7D2EA80 Offset: 0x7D2AA80 VA: 0x7D2EA80
	public int GetAllFlatValue(PropertyName name) { }

	// RVA: 0x7D2EDE4 Offset: 0x7D2ADE4 VA: 0x7D2EDE4
	public int GetAllPersentValue(PropertyName name) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnInit(EntityName entityName);

	// RVA: 0x7D2F148 Offset: 0x7D2B148 VA: 0x7D2F148
	protected void .ctor() { }
}

// Namespace: 
public enum EventName // TypeDefIndex: 25337
{
	// Fields
	public int value__; // 0x0
}

// Namespace: 
public interface IFastEvent : IResettable // TypeDefIndex: 25338
{}

// Namespace: 
public class FastEvent0 : IFastEvent, IResettable // TypeDefIndex: 25339
{
	// Fields
	private readonly List<Action> _listeners; // 0x10

	// Methods

	// RVA: 0x7D2C434 Offset: 0x7D28434 VA: 0x7D2C434
	public void Add(Action cb) { }

	// RVA: 0x7D2C5E0 Offset: 0x7D285E0 VA: 0x7D2C5E0
	public void Remove(Action cb) { }

	// RVA: 0x7D2C7B4 Offset: 0x7D287B4 VA: 0x7D2C7B4
	public void Invoke() { }

	// RVA: 0x7D2F58C Offset: 0x7D2B58C VA: 0x7D2F58C Slot: 4
	public void Reset() { }

	// RVA: 0x7D2C3A8 Offset: 0x7D283A8 VA: 0x7D2C3A8
	public void .ctor() { }
}

// Namespace: 
public class FastEvent<T1> : IFastEvent, IResettable // TypeDefIndex: 25340
{
	// Fields
	private readonly List<Action<T1>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633BC38 Offset: 0x6337C38 VA: 0x633BC38
	|-FastEvent<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633BCC4 Offset: 0x6337CC4 VA: 0x633BCC4
	|-FastEvent<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633BDE4 Offset: 0x6337DE4 VA: 0x633BDE4
	|-FastEvent<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633BF64 Offset: 0x6337F64 VA: 0x633BF64
	|-FastEvent<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633BF8C Offset: 0x6337F8C VA: 0x633BF8C
	|-FastEvent<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2> : IFastEvent, IResettable // TypeDefIndex: 25341
{
	// Fields
	private readonly List<Action<T1, T2>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C004 Offset: 0x6338004 VA: 0x633C004
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C090 Offset: 0x6338090 VA: 0x633C090
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C1B0 Offset: 0x63381B0 VA: 0x633C1B0
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C388 Offset: 0x6338388 VA: 0x633C388
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C3B0 Offset: 0x63383B0 VA: 0x633C3B0
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3> : IFastEvent, IResettable // TypeDefIndex: 25342
{
	// Fields
	private readonly List<Action<T1, T2, T3>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C428 Offset: 0x6338428 VA: 0x633C428
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C4B4 Offset: 0x63384B4 VA: 0x633C4B4
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C5D4 Offset: 0x63385D4 VA: 0x633C5D4
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C80C Offset: 0x633880C VA: 0x633C80C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C834 Offset: 0x6338834 VA: 0x633C834
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3, T4> : IFastEvent, IResettable // TypeDefIndex: 25343
{
	// Fields
	private readonly List<Action<T1, T2, T3, T4>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3, T4> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C8AC Offset: 0x63388AC VA: 0x633C8AC
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3, T4> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633C938 Offset: 0x6338938 VA: 0x633C938
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CA58 Offset: 0x6338A58 VA: 0x633CA58
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CCF0 Offset: 0x6338CF0 VA: 0x633CCF0
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CD18 Offset: 0x6338D18 VA: 0x633CD18
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3, T4, T5> : IFastEvent, IResettable // TypeDefIndex: 25344
{
	// Fields
	private readonly List<Action<T1, T2, T3, T4, T5>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3, T4, T5> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CD90 Offset: 0x6338D90 VA: 0x633CD90
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3, T4, T5> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CE1C Offset: 0x6338E1C VA: 0x633CE1C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633CF3C Offset: 0x6338F3C VA: 0x633CF3C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D234 Offset: 0x6339234 VA: 0x633D234
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D25C Offset: 0x633925C VA: 0x633D25C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3, T4, T5, T6> : IFastEvent, IResettable // TypeDefIndex: 25345
{
	// Fields
	private readonly List<Action<T1, T2, T3, T4, T5, T6>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3, T4, T5, T6> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D2D4 Offset: 0x63392D4 VA: 0x633D2D4
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3, T4, T5, T6> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D360 Offset: 0x6339360 VA: 0x633D360
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D480 Offset: 0x6339480 VA: 0x633D480
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D7E8 Offset: 0x63397E8 VA: 0x633D7E8
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D810 Offset: 0x6339810 VA: 0x633D810
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3, T4, T5, T6, T7> : IFastEvent, IResettable // TypeDefIndex: 25346
{
	// Fields
	private readonly List<Action<T1, T2, T3, T4, T5, T6, T7>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3, T4, T5, T6, T7> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D888 Offset: 0x6339888 VA: 0x633D888
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3, T4, T5, T6, T7> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633D914 Offset: 0x6339914 VA: 0x633D914
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633DA34 Offset: 0x6339A34 VA: 0x633DA34
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633DE34 Offset: 0x6339E34 VA: 0x633DE34
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633DE5C Offset: 0x6339E5C VA: 0x633DE5C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class FastEvent<T1, T2, T3, T4, T5, T6, T7, T8> : IFastEvent, IResettable // TypeDefIndex: 25347
{
	// Fields
	private readonly List<Action<T1, T2, T3, T4, T5, T6, T7, T8>> _listeners; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<T1, T2, T3, T4, T5, T6, T7, T8> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633DED4 Offset: 0x6339ED4 VA: 0x633DED4
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T1, T2, T3, T4, T5, T6, T7, T8> cb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633DF60 Offset: 0x6339F60 VA: 0x633DF60
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633E080 Offset: 0x633A080 VA: 0x633E080
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633E504 Offset: 0x633A504 VA: 0x633E504
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633E52C Offset: 0x633A52C VA: 0x633E52C
	|-FastEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public struct TraitData // TypeDefIndex: 25348
{}

// Namespace: 
public interface ITrait : IResettable // TypeDefIndex: 25349
{
	// Properties
	public abstract TraitName TraitName { get; set; }
	public abstract GameEntity Owner { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraitName get_TraitName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TraitName(TraitName value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract GameEntity get_Owner();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Owner(GameEntity value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Destroy();
}

// Namespace: 
public interface IFlatValueTrait : ITrait, IResettable // TypeDefIndex: 25350
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetFlatValue(PropertyName name);
}

// Namespace: 
public interface IPersentValueTrait : ITrait, IResettable // TypeDefIndex: 25351
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetPercentValue(PropertyName name);
}

// Namespace: 
public interface IInitTrait : ITrait, IResettable // TypeDefIndex: 25352
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init();
}

// Namespace: 
public interface IInitDataTrait : ITrait, IResettable // TypeDefIndex: 25353
{
	// Properties
	public abstract TraitData TraitData { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraitData get_TraitData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TraitData(TraitData value);
}

// Namespace: 
public interface IUpdateTrait : ITrait, IResettable // TypeDefIndex: 25354
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();
}

// Namespace: 
public interface ILateUpdateTrait : ITrait, IResettable // TypeDefIndex: 25355
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LateUpdate();
}

// Namespace: 
public interface IEventTrait : ITrait, IResettable // TypeDefIndex: 25356
{
	// Properties
	public abstract EventName EventName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventName get_EventName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEvent();
}

// Namespace: 
public interface IEventSubscriber : IEventTrait, ITrait, IResettable // TypeDefIndex: 25357
{
	// Properties
	public abstract GameEntity Target { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameEntity get_Target();
}

// Namespace: 
public enum TraitName // TypeDefIndex: 25358
{
	// Fields
	public int value__; // 0x0
	public const TraitName None = 0;
}

// Namespace: 
public class BitSet // TypeDefIndex: 25359
{
	// Fields
	private readonly ulong[] _data; // 0x10

	// Methods

	// RVA: 0x7D2F518 Offset: 0x7D2B518 VA: 0x7D2F518
	public void .ctor(int flagCount) { }

	// RVA: 0x7D2F5FC Offset: 0x7D2B5FC VA: 0x7D2F5FC
	public void Add(int flagIndex) { }

	// RVA: 0x7D2F640 Offset: 0x7D2B640 VA: 0x7D2F640
	public void Remove(int flagIndex) { }

	// RVA: 0x7D2F684 Offset: 0x7D2B684 VA: 0x7D2F684
	public bool Has(int flagIndex) { }

	// RVA: 0x7D2E700 Offset: 0x7D2A700 VA: 0x7D2E700
	public void ClearAll() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
public class SerializableArray<T> : IResettable // TypeDefIndex: 25360
{
	// Fields
	[SerializeField]
	private T[] _runtimeArray; // 0x0

	// Properties
	public T[] RuntimeArray { get; set; }
	public int Lenght { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T[] get_RuntimeArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC8A0 Offset: 0x54D88A0 VA: 0x54DC8A0
	|-SerializableArray<__Il2CppFullySharedGenericType>.get_RuntimeArray
	*/

	// RVA: -1 Offset: -1
	public void set_RuntimeArray(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC8A8 Offset: 0x54D88A8 VA: 0x54DC8A8
	|-SerializableArray<__Il2CppFullySharedGenericType>.set_RuntimeArray
	*/

	// RVA: -1 Offset: -1
	public int get_Lenght() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC8B0 Offset: 0x54D88B0 VA: 0x54DC8B0
	|-SerializableArray<__Il2CppFullySharedGenericType>.get_Lenght
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC8CC Offset: 0x54D88CC VA: 0x54DC8CC
	|-SerializableArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC988 Offset: 0x54D8988 VA: 0x54DC988
	|-SerializableArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCAAC Offset: 0x54D8AAC VA: 0x54DCAAC
	|-SerializableArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCAC8 Offset: 0x54D8AC8 VA: 0x54DCAC8
	|-SerializableArray<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCAD4 Offset: 0x54D8AD4 VA: 0x54DCAD4
	|-SerializableArray<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver // TypeDefIndex: 25361
{
	// Fields
	[SerializeField]
	private List<TKey> _keys; // 0x0
	[SerializeField]
	private List<TValue> _values; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public Dictionary<TKey, TValue> Dictionary { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCADC Offset: 0x54D8ADC VA: 0x54DCADC
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCAE4 Offset: 0x54D8AE4 VA: 0x54DCAE4
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DCEC8 Offset: 0x54D8EC8 VA: 0x54DCEC8
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD148 Offset: 0x54D9148 VA: 0x54DD148
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD274 Offset: 0x54D9274 VA: 0x54DD274
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD354 Offset: 0x54D9354 VA: 0x54DD354
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD428 Offset: 0x54D9428 VA: 0x54DD428
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD450 Offset: 0x54D9450 VA: 0x54DD450
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD524 Offset: 0x54D9524 VA: 0x54DD524
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD54C Offset: 0x54D954C VA: 0x54DD54C
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
public class SerializableHashSet<T> : ISerializationCallbackReceiver // TypeDefIndex: 25362
{
	// Fields
	[SerializeField]
	private List<T> _items; // 0x0
	private HashSet<T> _set; // 0x0

	// Properties
	public HashSet<T> HashSet { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public HashSet<T> get_HashSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DF66C Offset: 0x54DB66C VA: 0x54DF66C
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.get_HashSet
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DF674 Offset: 0x54DB674 VA: 0x54DF674
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DF968 Offset: 0x54DB968 VA: 0x54DF968
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFC98 Offset: 0x54DBC98 VA: 0x54DFC98
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFD6C Offset: 0x54DBD6C VA: 0x54DFD6C
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFE40 Offset: 0x54DBE40 VA: 0x54DFE40
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFF14 Offset: 0x54DBF14 VA: 0x54DFF14
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFF3C Offset: 0x54DBF3C VA: 0x54DFF3C
	|-SerializableHashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DFF64 Offset: 0x54DBF64 VA: 0x54DFF64
	|-SerializableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
public class SerializableLinkedList<T> : ISerializationCallbackReceiver // TypeDefIndex: 25363
{
	// Fields
	[SerializeField]
	private List<T> _items; // 0x0
	private LinkedList<T> _linkedList; // 0x0

	// Properties
	public LinkedList<T> LinkedList { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedList<T> get_LinkedList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E001C Offset: 0x54DC01C VA: 0x54E001C
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.get_LinkedList
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0024 Offset: 0x54DC024 VA: 0x54E0024
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0318 Offset: 0x54DC318 VA: 0x54E0318
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void AddLast(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E048C Offset: 0x54DC48C VA: 0x54E048C
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddFirst(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0554 Offset: 0x54DC554 VA: 0x54E0554
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E061C Offset: 0x54DC61C VA: 0x54E061C
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E06F0 Offset: 0x54DC6F0 VA: 0x54E06F0
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0718 Offset: 0x54DC718 VA: 0x54E0718
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0740 Offset: 0x54DC740 VA: 0x54E0740
	|-SerializableLinkedList<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
public class SerializableList<T> : IResettable // TypeDefIndex: 25364
{
	// Fields
	[SerializeField]
	private List<T> _initialList; // 0x0
	private List<T> _runtimeList; // 0x0

	// Properties
	public List<T> List { get; set; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E07F8 Offset: 0x54DC7F8 VA: 0x54E07F8
	|-SerializableList<object>..ctor
	|
	|-RVA: 0x54E0A98 Offset: 0x54DCA98 VA: 0x54E0A98
	|-SerializableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public List<T> get_List() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E087C Offset: 0x54DC87C VA: 0x54E087C
	|-SerializableList<object>.get_List
	|
	|-RVA: 0x54E0B20 Offset: 0x54DCB20 VA: 0x54E0B20
	|-SerializableList<__Il2CppFullySharedGenericType>.get_List
	*/

	// RVA: -1 Offset: -1
	public void set_List(List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0884 Offset: 0x54DC884 VA: 0x54E0884
	|-SerializableList<object>.set_List
	|
	|-RVA: 0x54E0B28 Offset: 0x54DCB28 VA: 0x54E0B28
	|-SerializableList<__Il2CppFullySharedGenericType>.set_List
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E088C Offset: 0x54DC88C VA: 0x54E088C
	|-SerializableList<object>.Add
	|
	|-RVA: 0x54E0B30 Offset: 0x54DCB30 VA: 0x54E0B30
	|-SerializableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E08FC Offset: 0x54DC8FC VA: 0x54E08FC
	|-SerializableList<object>.Remove
	|
	|-RVA: 0x54E0BF4 Offset: 0x54DCBF4 VA: 0x54E0BF4
	|-SerializableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0920 Offset: 0x54DC920 VA: 0x54E0920
	|-SerializableList<object>.Contains
	|
	|-RVA: 0x54E0CC8 Offset: 0x54DCCC8 VA: 0x54E0CC8
	|-SerializableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0944 Offset: 0x54DC944 VA: 0x54E0944
	|-SerializableList<object>.Clear
	|
	|-RVA: 0x54E0D9C Offset: 0x54DCD9C VA: 0x54E0D9C
	|-SerializableList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0984 Offset: 0x54DC984 VA: 0x54E0984
	|-SerializableList<object>.get_Count
	|
	|-RVA: 0x54E0DC4 Offset: 0x54DCDC4 VA: 0x54E0DC4
	|-SerializableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E09A0 Offset: 0x54DC9A0 VA: 0x54E09A0
	|-SerializableList<object>.get_Item
	|
	|-RVA: 0x54E0DEC Offset: 0x54DCDEC VA: 0x54E0DEC
	|-SerializableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E09C4 Offset: 0x54DC9C4 VA: 0x54E09C4
	|-SerializableList<object>.set_Item
	|
	|-RVA: 0x54E0EA0 Offset: 0x54DCEA0 VA: 0x54E0EA0
	|-SerializableList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E09E8 Offset: 0x54DC9E8 VA: 0x54E09E8
	|-SerializableList<object>.GetEnumerator
	|
	|-RVA: 0x54E0F80 Offset: 0x54DCF80 VA: 0x54E0F80
	|-SerializableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E0A4C Offset: 0x54DCA4C VA: 0x54E0A4C
	|-SerializableList<object>.Reset
	|
	|-RVA: 0x54E102C Offset: 0x54DD02C VA: 0x54E102C
	|-SerializableList<__Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[Serializable]
public class SerializableQueue<T> : ISerializationCallbackReceiver // TypeDefIndex: 25365
{
	// Fields
	[SerializeField]
	private List<T> _items; // 0x0
	private Queue<T> _queue; // 0x0

	// Properties
	public Queue<T> Queue { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Queue<T> get_Queue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1068 Offset: 0x54DD068 VA: 0x54E1068
	|-SerializableQueue<__Il2CppFullySharedGenericType>.get_Queue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1070 Offset: 0x54DD070 VA: 0x54E1070
	|-SerializableQueue<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1364 Offset: 0x54DD364 VA: 0x54E1364
	|-SerializableQueue<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E14D4 Offset: 0x54DD4D4 VA: 0x54E14D4
	|-SerializableQueue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E159C Offset: 0x54DD59C VA: 0x54E159C
	|-SerializableQueue<__Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1644 Offset: 0x54DD644 VA: 0x54E1644
	|-SerializableQueue<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E16EC Offset: 0x54DD6EC VA: 0x54E16EC
	|-SerializableQueue<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E17C0 Offset: 0x54DD7C0 VA: 0x54E17C0
	|-SerializableQueue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E17E8 Offset: 0x54DD7E8 VA: 0x54E17E8
	|-SerializableQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1810 Offset: 0x54DD810 VA: 0x54E1810
	|-SerializableQueue<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
public class SerializableStack<T> : ISerializationCallbackReceiver // TypeDefIndex: 25366
{
	// Fields
	[SerializeField]
	private List<T> _items; // 0x0
	private Stack<T> _stack; // 0x0

	// Properties
	public Stack<T> Stack { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Stack<T> get_Stack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E18C8 Offset: 0x54DD8C8 VA: 0x54E18C8
	|-SerializableStack<__Il2CppFullySharedGenericType>.get_Stack
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E18D0 Offset: 0x54DD8D0 VA: 0x54E18D0
	|-SerializableStack<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1BC4 Offset: 0x54DDBC4 VA: 0x54E1BC4
	|-SerializableStack<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1D34 Offset: 0x54DDD34 VA: 0x54E1D34
	|-SerializableStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1DFC Offset: 0x54DDDFC VA: 0x54E1DFC
	|-SerializableStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1EA4 Offset: 0x54DDEA4 VA: 0x54E1EA4
	|-SerializableStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E1F4C Offset: 0x54DDF4C VA: 0x54E1F4C
	|-SerializableStack<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2020 Offset: 0x54DE020 VA: 0x54E2020
	|-SerializableStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2048 Offset: 0x54DE048 VA: 0x54E2048
	|-SerializableStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2070 Offset: 0x54DE070 VA: 0x54E2070
	|-SerializableStack<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class TraitParamParser.Schema // TypeDefIndex: 25367
{
	// Fields
	public TraitParamParser.FieldParser[] Parsers; // 0x10
	public int FieldCount; // 0x18

	// Methods

	// RVA: 0x7D2FB90 Offset: 0x7D2BB90 VA: 0x7D2FB90
	public void .ctor() { }
}

// Namespace: 
public sealed class TraitParamParser.FieldParser : MulticastDelegate // TypeDefIndex: 25368
{
	// Methods

	// RVA: 0x7D3007C Offset: 0x7D2C07C VA: 0x7D3007C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7D30228 Offset: 0x7D2C228 VA: 0x7D30228 Slot: 13
	public virtual object Invoke(string input) { }

	// RVA: 0x7D3023C Offset: 0x7D2C23C VA: 0x7D3023C Slot: 14
	public virtual IAsyncResult BeginInvoke(string input, AsyncCallback callback, object object) { }

	// RVA: 0x7D3025C Offset: 0x7D2C25C VA: 0x7D3025C Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TraitParamParser.<>c // TypeDefIndex: 25369
{
	// Fields
	public static readonly TraitParamParser.<>c <>9; // 0x0
	public static TraitParamParser.FieldParser <>9__5_0; // 0x8
	public static TraitParamParser.FieldParser <>9__5_1; // 0x10
	public static TraitParamParser.FieldParser <>9__5_2; // 0x18
	public static TraitParamParser.FieldParser <>9__5_3; // 0x20

	// Methods

	// RVA: 0x7D30268 Offset: 0x7D2C268 VA: 0x7D30268
	private static void .cctor() { }

	// RVA: 0x7D302D0 Offset: 0x7D2C2D0 VA: 0x7D302D0
	public void .ctor() { }

	// RVA: 0x7D302D8 Offset: 0x7D2C2D8 VA: 0x7D302D8
	internal object <CreateParser>b__5_0(string s) { }

	// RVA: 0x7D30340 Offset: 0x7D2C340 VA: 0x7D30340
	internal object <CreateParser>b__5_1(string s) { }

	// RVA: 0x7D303A4 Offset: 0x7D2C3A4 VA: 0x7D303A4
	internal object <CreateParser>b__5_2(string s) { }

	// RVA: 0x7D30420 Offset: 0x7D2C420 VA: 0x7D30420
	internal object <CreateParser>b__5_3(string s) { }
}

// Namespace: 
public static class TraitParamParser // TypeDefIndex: 25370
{
	// Fields
	private static readonly Dictionary<string, TraitParamParser.Schema> _schemas; // 0x0

	// Methods

	// RVA: 0x7D2F6C0 Offset: 0x7D2B6C0 VA: 0x7D2F6C0
	public static void RegisterSchema(string traitId, Type[] types) { }

	// RVA: 0x7D2FB98 Offset: 0x7D2BB98 VA: 0x7D2FB98
	public static object[] Parse(string traitId, string rawParams) { }

	// RVA: 0x7D2F850 Offset: 0x7D2B850 VA: 0x7D2F850
	private static TraitParamParser.FieldParser CreateParser(Type t) { }

	// RVA: 0x7D2FDC0 Offset: 0x7D2BDC0 VA: 0x7D2FDC0
	private static string[] SplitToPool(string str, int expectedCount) { }

	// RVA: 0x7D2FFA0 Offset: 0x7D2BFA0 VA: 0x7D2FFA0
	private static void ReturnPool(string[] arr) { }

	// RVA: 0x7D3012C Offset: 0x7D2C12C VA: 0x7D3012C
	private static void .cctor() { }
}

// Namespace: 
public class InspectorReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 25371
{
	// Methods

	// RVA: 0x7D30428 Offset: 0x7D2C428 VA: 0x7D30428
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InstantiateExtension.<>c__DisplayClass0_0 // TypeDefIndex: 25372
{
	// Fields
	public TaskCompletionSource<GameObject[]> tcs; // 0x10
	public AsyncInstantiateOperation<GameObject> instantiateOperation; // 0x18

	// Methods

	// RVA: 0x7D305D4 Offset: 0x7D2C5D4 VA: 0x7D305D4
	public void .ctor() { }

	// RVA: 0x7D30790 Offset: 0x7D2C790 VA: 0x7D30790
	internal void <InstantiateAsync>b__0(AsyncOperation operation) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InstantiateExtension.<>c__DisplayClass1_0 // TypeDefIndex: 25373
{
	// Fields
	public TaskCompletionSource<GameObject[]> tcs; // 0x10
	public AsyncInstantiateOperation<GameObject> instantiateOperation; // 0x18

	// Methods

	// RVA: 0x7D30788 Offset: 0x7D2C788 VA: 0x7D30788
	public void .ctor() { }

	// RVA: 0x7D3080C Offset: 0x7D2C80C VA: 0x7D3080C
	internal void <InstantiateAsync>b__0(AsyncOperation operation) { }
}

// Namespace: 
public static class InstantiateExtension // TypeDefIndex: 25374
{
	// Methods

	// RVA: 0x7D30430 Offset: 0x7D2C430 VA: 0x7D30430
	public static Task<GameObject[]> InstantiateAsync(GameObject prefab, int count) { }

	// RVA: 0x7D305DC Offset: 0x7D2C5DC VA: 0x7D305DC
	public static Task<GameObject[]> InstantiateAsync(GameObject prefab, Transform parent, int count) { }
}

// Namespace: 
public class MonoSingleton<T> : MonoBehaviour // TypeDefIndex: 25375
{
	// Fields
	private static T _instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51007F4 Offset: 0x50FC7F4 VA: 0x51007F4
	|-MonoSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnMonoSingleToonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5100B98 Offset: 0x50FCB98 VA: 0x5100B98
	|-MonoSingleton<object>.OnMonoSingleToonInit
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5100B9C Offset: 0x50FCB9C VA: 0x5100B9C
	|-MonoSingleton<object>..ctor
	*/
}

// Namespace: 
public class PlayerPrefsExtension // TypeDefIndex: 25376
{
	// Fields
	private static bool m_enable; // 0x0
	private static string m_userId; // 0x8

	// Methods

	// RVA: 0x7D30888 Offset: 0x7D2C888 VA: 0x7D30888
	public static void DeleteAll() { }

	// RVA: 0x7D308F4 Offset: 0x7D2C8F4 VA: 0x7D308F4
	public static void DeleteKey(string key) { }

	// RVA: 0x7D30968 Offset: 0x7D2C968 VA: 0x7D30968
	public static float GetFloat(string key, float defaultValue = 0) { }

	// RVA: 0x7D309F4 Offset: 0x7D2C9F4 VA: 0x7D309F4
	public static int GetInt(string key, int defaultValue = 0) { }

	// RVA: 0x7D30A80 Offset: 0x7D2CA80 VA: 0x7D30A80
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x7D30B28 Offset: 0x7D2CB28 VA: 0x7D30B28
	public static bool GetBool(string key, bool defaultValue = False) { }

	// RVA: 0x7D30BBC Offset: 0x7D2CBBC VA: 0x7D30BBC
	public static bool HasKey(string key) { }

	// RVA: 0x7D30C34 Offset: 0x7D2CC34 VA: 0x7D30C34
	public static void Save() { }

	// RVA: 0x7D30CA0 Offset: 0x7D2CCA0 VA: 0x7D30CA0
	public static void SetFloat(string key, float value) { }

	// RVA: 0x7D30D3C Offset: 0x7D2CD3C VA: 0x7D30D3C
	public static void SetInt(string key, int value) { }

	// RVA: 0x7D30DD8 Offset: 0x7D2CDD8 VA: 0x7D30DD8
	public static void SetString(string key, string value) { }

	// RVA: 0x7D30E74 Offset: 0x7D2CE74 VA: 0x7D30E74
	public static void SetBool(string key, bool value) { }

	// RVA: 0x7D30F08 Offset: 0x7D2CF08 VA: 0x7D30F08
	private static string getUserKey(string key) { }

	// RVA: 0x7D30F6C Offset: 0x7D2CF6C VA: 0x7D30F6C
	public static void SetUserId(string id) { }

	// RVA: 0x7D30FF8 Offset: 0x7D2CFF8 VA: 0x7D30FF8
	public static bool HasUserKey(string key) { }

	// RVA: 0x7D3107C Offset: 0x7D2D07C VA: 0x7D3107C
	public static void SetUserInt(string key, int value) { }

	// RVA: 0x7D31110 Offset: 0x7D2D110 VA: 0x7D31110
	public static int GetUserInt(string key, int defaultValue) { }

	// RVA: 0x7D311A8 Offset: 0x7D2D1A8 VA: 0x7D311A8
	public static void SetUserFloat(string key, float value) { }

	// RVA: 0x7D3123C Offset: 0x7D2D23C VA: 0x7D3123C
	public static float GetUserFloat(string key, float defaultValue) { }

	// RVA: 0x7D312D4 Offset: 0x7D2D2D4 VA: 0x7D312D4
	public static void SetUserBool(string key, bool value) { }

	// RVA: 0x7D31384 Offset: 0x7D2D384 VA: 0x7D31384
	public static bool GetUserBool(string key, bool defaultValue) { }

	// RVA: 0x7D3141C Offset: 0x7D2D41C VA: 0x7D3141C
	public static void SetUserString(string key, string value) { }

	// RVA: 0x7D314B0 Offset: 0x7D2D4B0 VA: 0x7D314B0
	public static string GetUserString(string key, string defaultValue) { }

	// RVA: 0x7D31548 Offset: 0x7D2D548 VA: 0x7D31548
	public void .ctor() { }

	// RVA: 0x7D31550 Offset: 0x7D2D550 VA: 0x7D31550
	private static void .cctor() { }
}

// Namespace: 
public static class RenderTextureExtension // TypeDefIndex: 25377
{
	// Methods

	// RVA: 0x7D315B8 Offset: 0x7D2D5B8 VA: 0x7D315B8
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x7D3160C Offset: 0x7D2D60C VA: 0x7D3160C
	public static void ReleaseTemporary(RenderTexture texture) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskExpand.<Delay>d__0 : IAsyncStateMachine // TypeDefIndex: 25378
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int millionSecond; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x7D31A78 Offset: 0x7D2DA78 VA: 0x7D31A78 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D31C78 Offset: 0x7D2DC78 VA: 0x7D31C78 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskExpand.<Run>d__3 : IAsyncStateMachine // TypeDefIndex: 25379
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Action action; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x7D31CE0 Offset: 0x7D2DCE0 VA: 0x7D31CE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D31EE0 Offset: 0x7D2DEE0 VA: 0x7D31EE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskExpand.<WhenAll>d__2 : IAsyncStateMachine // TypeDefIndex: 25380
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public IEnumerable<Task> tasks; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x7D31F48 Offset: 0x7D2DF48 VA: 0x7D31F48 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D32148 Offset: 0x7D2E148 VA: 0x7D32148 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskExpand.<WhenAny>d__4 : IAsyncStateMachine // TypeDefIndex: 25381
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Task> <>t__builder; // 0x8
	public Task[] tasks; // 0x20
	private TaskAwaiter<Task> <>u__1; // 0x28

	// Methods

	// RVA: 0x7D321B0 Offset: 0x7D2E1B0 VA: 0x7D321B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D32414 Offset: 0x7D2E414 VA: 0x7D32414 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskExpand.<Yield>d__1 : IAsyncStateMachine // TypeDefIndex: 25382
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x7D32490 Offset: 0x7D2E490 VA: 0x7D32490 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D326B4 Offset: 0x7D2E6B4 VA: 0x7D326B4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class TaskExpand // TypeDefIndex: 25383
{
	// Methods

	[AsyncStateMachine(typeof(TaskExpand.<Delay>d__0))]
	// RVA: 0x7D31614 Offset: 0x7D2D614 VA: 0x7D31614
	public static Task Delay(int millionSecond, bool ignoreTimeScale = False) { }

	[AsyncStateMachine(typeof(TaskExpand.<Yield>d__1))]
	// RVA: 0x7D316E4 Offset: 0x7D2D6E4 VA: 0x7D316E4
	public static Task Yield() { }

	[AsyncStateMachine(typeof(TaskExpand.<WhenAll>d__2))]
	// RVA: 0x7D317AC Offset: 0x7D2D7AC VA: 0x7D317AC
	public static Task WhenAll(IEnumerable<Task> tasks) { }

	[AsyncStateMachine(typeof(TaskExpand.<Run>d__3))]
	// RVA: 0x7D31890 Offset: 0x7D2D890 VA: 0x7D31890
	public static Task Run(Action action) { }

	[AsyncStateMachine(typeof(TaskExpand.<WhenAny>d__4))]
	// RVA: 0x7D31974 Offset: 0x7D2D974 VA: 0x7D31974
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x7D31A70 Offset: 0x7D2DA70 VA: 0x7D31A70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct RestoreHurtData // TypeDefIndex: 25384
{
	// Fields
	public int HurtValue; // 0x0
	public int skillIconId; // 0x4
	public int uniqueSkillId; // 0x8
}

// Namespace: 
[Serializable]
public class SaveBattleData.SaveData // TypeDefIndex: 25385
{
	// Fields
	public int wave; // 0x10
	public int killCount; // 0x14
	public int realKillCount; // 0x18
	public int enemyCount; // 0x1C
	public int randomSkillCount; // 0x20
	public int initSkillGroupCount; // 0x24
	public int adReliveCount; // 0x28
	public int reliveCount; // 0x2C
	public int reliveUsedCount; // 0x30
	public int reliveType; // 0x34
	public int beHitCount; // 0x38
	public int gold; // 0x3C
	public int dropGold; // 0x40
	public int missionIndex; // 0x44
	public int hp; // 0x48
	public int exp; // 0x4C
	public int lv; // 0x50
	public int maxExp; // 0x54
	public int floor; // 0x58
	public int exNeedSelectCount; // 0x5C
	public int entityId; // 0x60
	public string skills; // 0x68
	public string removeSkills; // 0x70
	public string hurtData; // 0x78
	public string waveGold; // 0x80
	public int refreshCount; // 0x88
	public string[] triggerActionStates; // 0x90
	public long missionTimeRaw; // 0x98

	// Methods

	// RVA: 0x7D333CC Offset: 0x7D2F3CC VA: 0x7D333CC
	public void Clear() { }

	// RVA: 0x7D32798 Offset: 0x7D2E798 VA: 0x7D32798
	public void .ctor() { }
}

// Namespace: 
public class SaveBattleData // TypeDefIndex: 25386
{
	// Fields
	private static SaveBattleData.SaveData _data; // 0x0
	public static List<RestoreHurtData> restoreHurtData; // 0x8

	// Methods

	// RVA: 0x7D3271C Offset: 0x7D2E71C VA: 0x7D3271C
	private static void .cctor() { }

	// RVA: 0x7D327A0 Offset: 0x7D2E7A0 VA: 0x7D327A0
	public static void Init() { }

	// RVA: 0x7D32FC0 Offset: 0x7D2EFC0 VA: 0x7D32FC0
	public static void ClearAll() { }

	// RVA: 0x7D33448 Offset: 0x7D2F448 VA: 0x7D33448
	public static void SaveAll(int wave, int killCount, int gold, int missionIndex, int hp, int exp, int lv, int maxExp, int floor, int exNeedSelectCount, int entityId, List<int> skills, List<int> removeSkills, List<RestoreHurtData> hurtData, Dictionary<int, int> waveGold, int dropGold, int realKillCount, int enemyCount, int initSkillGroupCount, int reliveCount, int beHitCount, int reliveType, int randomSkillCount, int refreshCount, string[] triggerActionStates, int adReliveCount, int reliveUsedCount, long missionTimeRaw = 0) { }

	[Obsolete("使用 GetAllBattleData() 替代")]
	// RVA: 0x7D33C34 Offset: 0x7D2FC34 VA: 0x7D33C34
	public static ValueTuple<int, int, int, int, int> GetInitBattleData() { }

	[Obsolete("使用 GetAllBattleData() 替代")]
	// RVA: 0x7D33E0C Offset: 0x7D2FE0C VA: 0x7D33E0C
	public static ValueTuple<int, int, int, int> GetExpAndLevel() { }

	[Obsolete("使用 GetAllBattleData() 替代")]
	// RVA: 0x7D33F48 Offset: 0x7D2FF48 VA: 0x7D33F48
	public static List<RestoreHurtData> GetHurtData() { }

	// RVA: 0x7D34054 Offset: 0x7D30054 VA: 0x7D34054
	public static SaveBattleData.SaveData GetAllBattleData() { }

	// RVA: 0x7D346D8 Offset: 0x7D306D8 VA: 0x7D346D8
	public static int GetShowWaveIndex() { }

	// RVA: 0x7D34744 Offset: 0x7D30744 VA: 0x7D34744
	public static string GetPlayerSkillsJson() { }

	// RVA: 0x7D347B0 Offset: 0x7D307B0 VA: 0x7D347B0
	private static string FormatSaveData(SaveBattleData.SaveData data) { }

	// RVA: 0x7D35090 Offset: 0x7D31090 VA: 0x7D35090
	public void .ctor() { }
}

// Namespace: 
public class ArrayTool // TypeDefIndex: 25387
{
	// Methods

	// RVA: -1 Offset: -1
	public static T[] MergeArrays<T>(T[] a, T[] b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FA038 Offset: 0x44F6038 VA: 0x44FA038
	|-ArrayTool.MergeArrays<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> MergeLists<T>(List<T> a, List<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FA660 Offset: 0x44F6660 VA: 0x44FA660
	|-ArrayTool.MergeLists<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] MergeDistinctArrays<T>(T[] source, T[] other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FA0B0 Offset: 0x44F60B0 VA: 0x44FA0B0
	|-ArrayTool.MergeDistinctArrays<int>
	|
	|-RVA: 0x44FA2D0 Offset: 0x44F62D0 VA: 0x44FA2D0
	|-ArrayTool.MergeDistinctArrays<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D35098 Offset: 0x7D31098 VA: 0x7D35098
	public void .ctor() { }
}

// Namespace: 
public static class DrawLineTool // TypeDefIndex: 25388
{
	// Methods

	[Conditional("UnityLog")]
	// RVA: 0x7D350A0 Offset: 0x7D310A0 VA: 0x7D350A0
	public static void DrawLine(Vector3 start, Vector3 end) { }

	[Conditional("UnityLog")]
	// RVA: 0x7D35138 Offset: 0x7D31138 VA: 0x7D35138
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[Conditional("UnityLog")]
	// RVA: 0x7D35228 Offset: 0x7D31228 VA: 0x7D35228
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileTool.<>c // TypeDefIndex: 25389
{
	// Fields
	public static readonly FileTool.<>c <>9; // 0x0
	public static Func<IPAddress, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x7D3684C Offset: 0x7D3284C VA: 0x7D3684C
	private static void .cctor() { }

	// RVA: 0x7D368B4 Offset: 0x7D328B4 VA: 0x7D368B4
	public void .ctor() { }

	// RVA: 0x7D368BC Offset: 0x7D328BC VA: 0x7D368BC
	internal bool <GetLocalIPAddress>b__3_0(IPAddress ip) { }
}

// Namespace: 
[CompilerGenerated]
private struct FileTool.<LoadAndAnalysisAllBytes>d__4 : IAsyncStateMachine // TypeDefIndex: 25390
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "rootPath", "filePath", "fileType", "fileText", "fileBytes" })]
	public AsyncTaskMethodBuilder<List<ValueTuple<string, string, string, string, byte[]>>> <>t__builder; // 0x8
	public string path; // 0x20
	private TaskAwaiter<AssetData> <>u__1; // 0x28

	// Methods

	// RVA: 0x7D36944 Offset: 0x7D32944 VA: 0x7D36944 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D36C88 Offset: 0x7D32C88 VA: 0x7D36C88 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public static class FileTool // TypeDefIndex: 25391
{
	// Methods

	// RVA: 0x7D35338 Offset: 0x7D31338 VA: 0x7D35338
	public static void RenameCsToCsTxt(string directoryPath) { }

	// RVA: 0x7D356D0 Offset: 0x7D316D0 VA: 0x7D356D0
	public static void RenameCsTxtToCs(string directoryPath) { }

	// RVA: 0x7D35A28 Offset: 0x7D31A28 VA: 0x7D35A28
	public static void CopyDirectory(string sourceDir, string destinationDir) { }

	// RVA: 0x7D35C1C Offset: 0x7D31C1C VA: 0x7D35C1C
	public static string GetLocalIPAddress() { }

	[AsyncStateMachine(typeof(FileTool.<LoadAndAnalysisAllBytes>d__4))]
	// RVA: 0x7D36020 Offset: 0x7D32020 VA: 0x7D36020
	public static Task<List<ValueTuple<string, string, string, string, byte[]>>> LoadAndAnalysisAllBytes(string path) { }

	// RVA: 0x7D3611C Offset: 0x7D3211C VA: 0x7D3611C
	public static List<ValueTuple<string, string, string, string, byte[]>> AnalysisAllBytes(string rootPath, TextAsset textAsset) { }

	// RVA: 0x7D3650C Offset: 0x7D3250C VA: 0x7D3650C
	public static MemoryStream UnzipBytesToMemory(byte[] compressedBytes) { }
}

// Namespace: 
public static class LayerTool // TypeDefIndex: 25392
{
	// Methods

	// RVA: 0x7D36D04 Offset: 0x7D32D04 VA: 0x7D36D04
	public static string LayerToName(int index) { }
}

// Namespace: 
public interface IResettable // TypeDefIndex: 25393
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();
}

// Namespace: 
public static class Pool // TypeDefIndex: 25394
{
	// Fields
	private static readonly Dictionary<string, Func<object>> _creatorCache; // 0x0

	// Methods

	// RVA: 0x7D36D0C Offset: 0x7D32D0C VA: 0x7D36D0C
	public static object CreateByClassName(string className) { }

	// RVA: -1 Offset: -1
	public static T CreateByClassName<T>(string className) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A49F8 Offset: 0x46A09F8 VA: 0x46A49F8
	|-Pool.CreateByClassName<object>
	*/

	// RVA: 0x7D3702C Offset: 0x7D3302C VA: 0x7D3702C
	private static void .cctor() { }
}

// Namespace: 
public static class Pool<T> // TypeDefIndex: 25395
{
	// Fields
	private static readonly ConcurrentStack<T> _stack; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5269C30 Offset: 0x5265C30 VA: 0x5269C30
	|-Pool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5269CFC Offset: 0x5265CFC VA: 0x5269CFC
	|-Pool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5269E20 Offset: 0x5265E20 VA: 0x5269E20
	|-Pool<object>..cctor
	*/
}

// Namespace: 
public static class P // TypeDefIndex: 25396
{
	// Fields
	private static readonly Dictionary<string, string> _sampleNameCache; // 0x0

	// Methods

	// RVA: 0x7D370C4 Offset: 0x7D330C4 VA: 0x7D370C4
	private static string GetCachedSampleName(string name) { }

	[Conditional("ProfilerControl")]
	// RVA: 0x7D371D0 Offset: 0x7D331D0 VA: 0x7D371D0
	public static void OpenProfiler(string profilerName) { }

	[Conditional("ProfilerControl")]
	// RVA: 0x7D371DC Offset: 0x7D331DC VA: 0x7D371DC
	public static void CloseProfiler() { }

	[Conditional("ProfilerBinaryLog")]
	// RVA: 0x7D371E8 Offset: 0x7D331E8 VA: 0x7D371E8
	public static void OpenBinaryLog() { }

	[Conditional("ProfilerBinaryLog")]
	// RVA: 0x7D3726C Offset: 0x7D3326C VA: 0x7D3726C
	public static void CloseBinaryLog() { }

	[Conditional("Profiler")]
	// RVA: 0x7D3728C Offset: 0x7D3328C VA: 0x7D3728C
	public static void BeginSample(string name) { }

	[Conditional("Profiler")]
	// RVA: 0x7D37290 Offset: 0x7D33290 VA: 0x7D37290
	public static void EndSample() { }

	[Conditional("ProfilerGetType")]
	// RVA: 0x7D37294 Offset: 0x7D33294 VA: 0x7D37294
	public static void BeginSampleGetType(string title, object o, string tag) { }

	[Conditional("ProfilerGetType")]
	// RVA: 0x7D37298 Offset: 0x7D33298 VA: 0x7D37298
	public static void BeginSampleGetType(object o, string tag) { }

	[Conditional("ProfilerGetType")]
	// RVA: 0x7D3729C Offset: 0x7D3329C VA: 0x7D3729C
	public static void EndSampleGetType() { }

	[Conditional("ProfilerGetType")]
	// RVA: 0x7D372A0 Offset: 0x7D332A0 VA: 0x7D372A0
	public static void BeginSampleDelegate(string tag, Delegate handler) { }

	[Conditional("ProfilerGetType")]
	// RVA: 0x7D373B8 Offset: 0x7D333B8 VA: 0x7D373B8
	public static void EndSampleDelegate() { }

	// RVA: 0x7D373BC Offset: 0x7D333BC VA: 0x7D373BC
	private static void .cctor() { }
}

// Namespace: 
[Extension]
public static class SpriteAtlasTool // TypeDefIndex: 25397
{
	// Methods

	[Extension]
	// RVA: 0x7D37458 Offset: 0x7D33458 VA: 0x7D37458
	public static List<Sprite> GetSpriteList(SpriteAtlas atlas) { }
}

// Namespace: 
[Extension]
public static class TransformTool // TypeDefIndex: 25398
{
	// Methods

	[Extension]
	// RVA: 0x7D3751C Offset: 0x7D3351C VA: 0x7D3751C
	public static void SetTransform(Transform t, Vector3 position, Quaternion rotation, LocalOrWorld localOrWorld) { }

	[Extension]
	// RVA: 0x7D3753C Offset: 0x7D3353C VA: 0x7D3753C
	public static void SetTransform(Transform t, Vector3 position, Quaternion rotation, Vector3 scale, LocalOrWorld localOrWorld) { }

	[Extension]
	// RVA: 0x7D37578 Offset: 0x7D33578 VA: 0x7D37578
	public static void SetScale(Transform t, Vector3 scale) { }

	[Extension]
	// RVA: 0x7D37608 Offset: 0x7D33608 VA: 0x7D37608
	public static void SetParentAndTransform(Transform t, Transform parent, Vector3 scale) { }

	[Extension]
	// RVA: 0x7D376CC Offset: 0x7D336CC VA: 0x7D376CC
	public static void SetParentAndTransform(Transform t, Transform parent, Vector3 position, Quaternion rotation, LocalOrWorld localOrWorld) { }

	[Extension]
	// RVA: 0x7D377D0 Offset: 0x7D337D0 VA: 0x7D377D0
	public static void SetParentAndTransform(Transform t, Transform parent, Vector3 position, Quaternion rotation, Vector3 scale, LocalOrWorld localOrWorld) { }

	[Extension]
	// RVA: 0x7D378E8 Offset: 0x7D338E8 VA: 0x7D378E8
	public static void SetParentAndReset(Transform t, Transform parent) { }

	[Extension]
	// RVA: 0x7D37AAC Offset: 0x7D33AAC VA: 0x7D37AAC
	public static void SetReset(Transform t) { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 25399
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
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 25400
{
	// Methods

	// RVA: 0x7D37BDC Offset: 0x7D33BDC VA: 0x7D37BDC
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7D37CD4 Offset: 0x7D33CD4 VA: 0x7D37CD4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RecordHitFeedbackBehaviour.<>c // TypeDefIndex: 25401
{
	// Fields
	public static readonly RecordHitFeedbackBehaviour.<>c <>9; // 0x0
	public static Func<Assembly, Type> <>9__10_0; // 0x8
	public static Func<Type, bool> <>9__10_1; // 0x10
	public static Func<Assembly, Type> <>9__11_0; // 0x18
	public static Func<Type, bool> <>9__11_1; // 0x20

	// Methods

	// RVA: 0x7D38D90 Offset: 0x7D34D90 VA: 0x7D38D90
	private static void .cctor() { }

	// RVA: 0x7D38DF8 Offset: 0x7D34DF8 VA: 0x7D38DF8
	public void .ctor() { }

	// RVA: 0x7D38E00 Offset: 0x7D34E00 VA: 0x7D38E00
	internal Type <GetHitFeedbackManagerInstance>b__10_0(Assembly a) { }

	// RVA: 0x7D38E60 Offset: 0x7D34E60 VA: 0x7D38E60
	internal bool <GetHitFeedbackManagerInstance>b__10_1(Type t) { }

	// RVA: 0x7D38EBC Offset: 0x7D34EBC VA: 0x7D38EBC
	internal Type <GetHotFixHitFeedbackEnumType>b__11_0(Assembly a) { }

	// RVA: 0x7D38F1C Offset: 0x7D34F1C VA: 0x7D38F1C
	internal bool <GetHotFixHitFeedbackEnumType>b__11_1(Type t) { }
}

// Namespace: ProjectX.Battle
[DisallowMultipleComponent]
public class RecordHitFeedbackBehaviour : MonoBehaviour // TypeDefIndex: 25402
{
	// Fields
	private static readonly int RimRangePropertyID; // 0x0
	[Tooltip("在录制时使用的受击反馈类型（与 HotFix 的 HitFeedbackType 枚举值的 int 对应）。")]
	public int HitFeedbackType; // 0x20
	[SerializeField]
	[Tooltip("若未手动指定，将自动收集当前对象及子节点上的所有 Renderer。")]
	private List<Renderer> _renderers; // 0x28
	private List<MaterialPropertyBlock> _mpbs; // 0x30
	private Vector3 _baseLocalScale; // 0x38
	private Vector3 _baseLocalPos; // 0x44
	private bool _prepared; // 0x50

	// Methods

	// RVA: 0x7D37CDC Offset: 0x7D33CDC VA: 0x7D37CDC
	private void Awake() { }

	// RVA: 0x7D37CE0 Offset: 0x7D33CE0 VA: 0x7D37CE0
	private void AutoCollectRenderersIfNeeded() { }

	// RVA: 0x7D37DC0 Offset: 0x7D33DC0 VA: 0x7D37DC0
	private void EnsureMPBs() { }

	// RVA: 0x7D37F58 Offset: 0x7D33F58 VA: 0x7D37F58
	private static object GetHitFeedbackManagerInstance() { }

	// RVA: 0x7D381CC Offset: 0x7D341CC VA: 0x7D381CC
	private static Type GetHotFixHitFeedbackEnumType() { }

	// RVA: 0x7D383A4 Offset: 0x7D343A4 VA: 0x7D383A4
	public void PrepareForRecording() { }

	// RVA: 0x7D384E4 Offset: 0x7D344E4 VA: 0x7D384E4
	public void ApplyByPercent(float percent) { }

	// RVA: 0x7D38B74 Offset: 0x7D34B74 VA: 0x7D38B74
	public void RestoreAfterRecording() { }

	// RVA: 0x7D38CA0 Offset: 0x7D34CA0 VA: 0x7D38CA0
	public void .ctor() { }

	// RVA: 0x7D38D28 Offset: 0x7D34D28 VA: 0x7D38D28
	private static void .cctor() { }
}

// Namespace: ProjectX.Battle
[DisallowMultipleComponent]
[ExecuteAlways]
[AddComponentMenu("OptimizeTool/Material/Two Texture Additive Lit Property Block")]
public class TwoTextureAdditiveLitPropertyBlock : MonoBehaviour // TypeDefIndex: 25403
{
	// Fields
	public const string TargetShaderName = "Particles/TwoTextureAdditiveLit";
	private static readonly int PropertyTintColor; // 0x0
	private static readonly int PropertyOverlayColor; // 0x4
	private static readonly int PropertyOverlayWScale; // 0x8
	private static readonly int PropertyOverlayHScale; // 0xC
	[SerializeField]
	private Renderer m_renderer; // 0x20
	[SerializeField]
	private int m_materialIndex; // 0x28
	[SerializeField]
	private Color m_tintColor; // 0x2C
	[SerializeField]
	private Color m_overlayColor; // 0x3C
	[SerializeField]
	private float m_overlayWScale; // 0x4C
	[SerializeField]
	private float m_overlayHScale; // 0x50
	private MaterialPropertyBlock m_propertyBlock; // 0x58

	// Properties
	public Renderer TargetRenderer { get; }

	// Methods

	// RVA: 0x7D38F78 Offset: 0x7D34F78 VA: 0x7D38F78
	public Renderer get_TargetRenderer() { }

	// RVA: 0x7D38F80 Offset: 0x7D34F80 VA: 0x7D38F80
	public void Reset() { }

	// RVA: 0x7D394E4 Offset: 0x7D354E4 VA: 0x7D394E4
	private void OnEnable() { }

	// RVA: 0x7D394FC Offset: 0x7D354FC VA: 0x7D394FC
	private void OnValidate() { }

	// RVA: 0x7D38FA0 Offset: 0x7D34FA0 VA: 0x7D38FA0
	public void AutoAssignRenderer() { }

	[ContextMenu("Read From Shared Material")]
	// RVA: 0x7D39050 Offset: 0x7D35050 VA: 0x7D39050
	public void SyncFromSharedMaterial() { }

	[ContextMenu("Apply Property Block")]
	// RVA: 0x7D39294 Offset: 0x7D35294 VA: 0x7D39294
	public void ApplyPropertyBlock() { }

	// RVA: 0x7D395AC Offset: 0x7D355AC VA: 0x7D395AC
	public bool TryGetSharedMaterial(out Material material) { }

	// RVA: 0x7D397AC Offset: 0x7D357AC VA: 0x7D397AC
	public bool IsUsingTargetShader() { }

	// RVA: 0x7D396B4 Offset: 0x7D356B4 VA: 0x7D396B4
	private bool TryGetTargetRenderer(out Renderer targetRenderer) { }

	// RVA: 0x7D39738 Offset: 0x7D35738 VA: 0x7D39738
	private void EnsurePropertyBlock() { }

	// RVA: 0x7D3956C Offset: 0x7D3556C VA: 0x7D3956C
	private void ClampSerializedValues() { }

	// RVA: 0x7D39888 Offset: 0x7D35888 VA: 0x7D39888
	public void .ctor() { }

	// RVA: 0x7D398A4 Offset: 0x7D358A4 VA: 0x7D398A4
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1372 // TypeDefIndex: 25404
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2936 // TypeDefIndex: 25405
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 25406
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2936 80D1E9875805164C49F90A26D4E16329D532089AE84C8891EF5E239BEA8FAB86 /*Metadata offset 0xF40698*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1372 EEE56DFF55D4CF306741A12AB0B3A8CFC47FED229E0B885E2BCCB861693AC7C9 /*Metadata offset 0xF41218*/; // 0xB78
}

