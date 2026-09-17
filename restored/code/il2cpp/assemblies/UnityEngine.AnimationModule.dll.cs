// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27468
{}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = False)]
[RequiredByNativeCode]
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 27469
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 27470
{
	// Methods

	// RVA: 0x86D0F2C Offset: 0x86CCF2C VA: 0x86D0F2C Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x86D0F30 Offset: 0x86CCF30 VA: 0x86D0F30 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x86D0F34 Offset: 0x86CCF34 VA: 0x86D0F34 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x86D0F38 Offset: 0x86CCF38 VA: 0x86D0F38 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x86D0F3C Offset: 0x86CCF3C VA: 0x86D0F3C Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x86D0F40 Offset: 0x86CCF40 VA: 0x86D0F40 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x86D0F44 Offset: 0x86CCF44 VA: 0x86D0F44 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x86D0F48 Offset: 0x86CCF48 VA: 0x86D0F48 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F4C Offset: 0x86CCF4C VA: 0x86D0F4C Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F50 Offset: 0x86CCF50 VA: 0x86D0F50 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F54 Offset: 0x86CCF54 VA: 0x86D0F54 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F58 Offset: 0x86CCF58 VA: 0x86D0F58 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F5C Offset: 0x86CCF5C VA: 0x86D0F5C Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F60 Offset: 0x86CCF60 VA: 0x86D0F60 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x86D0F64 Offset: 0x86CCF64 VA: 0x86D0F64
	protected void .ctor() { }
}

// Namespace: UnityEngine
public enum PlayMode // TypeDefIndex: 27471
{
	// Fields
	public int value__; // 0x0
	public const PlayMode StopSameLayer = 0;
	public const PlayMode StopAll = 4;
}

// Namespace: UnityEngine
public enum QueueMode // TypeDefIndex: 27472
{
	// Fields
	public int value__; // 0x0
	public const QueueMode CompleteOthers = 0;
	public const QueueMode PlayNow = 2;
}

// Namespace: UnityEngine
public enum AnimationPlayMode // TypeDefIndex: 27473
{
	// Fields
	public int value__; // 0x0
	public const AnimationPlayMode Stop = 0;
	public const AnimationPlayMode Queue = 1;
	public const AnimationPlayMode Mix = 2;
}

// Namespace: UnityEngine
public enum AnimationCullingType // TypeDefIndex: 27474
{
	// Fields
	public int value__; // 0x0
	public const AnimationCullingType AlwaysAnimate = 0;
	public const AnimationCullingType BasedOnRenderers = 1;
	[Obsolete("Enum member AnimatorCullingMode.BasedOnClipBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
	public const AnimationCullingType BasedOnClipBounds = 2;
	[Obsolete("Enum member AnimatorCullingMode.BasedOnUserBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
	public const AnimationCullingType BasedOnUserBounds = 3;
}

// Namespace: UnityEngine
internal enum AnimationEventSource // TypeDefIndex: 27475
{
	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: 
private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 27476
{
	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x86D1D4C Offset: 0x86CDD4C VA: 0x86D1D4C
	internal void .ctor(Animation outer) { }

	// RVA: 0x86D2190 Offset: 0x86CE190 VA: 0x86D2190 Slot: 5
	public object get_Current() { }

	// RVA: 0x86D21DC Offset: 0x86CE1DC VA: 0x86D21DC Slot: 4
	public bool MoveNext() { }

	// RVA: 0x86D223C Offset: 0x86CE23C VA: 0x86D223C Slot: 6
	public void Reset() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Animation.h")]
[DefaultMember("Item")]
public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 27477
{
	// Properties
	public AnimationClip clip { get; set; }
	public bool playAutomatically { get; set; }
	public WrapMode wrapMode { get; set; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }
	public bool animatePhysics { get; set; }
	[Obsolete("Use cullingType instead")]
	public bool animateOnlyIfVisible { get; set; }
	public AnimationCullingType cullingType { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x86D0F6C Offset: 0x86CCF6C VA: 0x86D0F6C
	public AnimationClip get_clip() { }

	// RVA: 0x86D0FA8 Offset: 0x86CCFA8 VA: 0x86D0FA8
	public void set_clip(AnimationClip value) { }

	// RVA: 0x86D0FEC Offset: 0x86CCFEC VA: 0x86D0FEC
	public bool get_playAutomatically() { }

	// RVA: 0x86D1028 Offset: 0x86CD028 VA: 0x86D1028
	public void set_playAutomatically(bool value) { }

	// RVA: 0x86D106C Offset: 0x86CD06C VA: 0x86D106C
	public WrapMode get_wrapMode() { }

	// RVA: 0x86D10A8 Offset: 0x86CD0A8 VA: 0x86D10A8
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x86D10EC Offset: 0x86CD0EC VA: 0x86D10EC
	public void Stop() { }

	// RVA: 0x86D1128 Offset: 0x86CD128 VA: 0x86D1128
	public void Stop(string name) { }

	[NativeName("Stop")]
	// RVA: 0x86D116C Offset: 0x86CD16C VA: 0x86D116C
	private void StopNamed(string name) { }

	// RVA: 0x86D11B0 Offset: 0x86CD1B0 VA: 0x86D11B0
	public void Rewind() { }

	// RVA: 0x86D11EC Offset: 0x86CD1EC VA: 0x86D11EC
	public void Rewind(string name) { }

	[NativeName("Rewind")]
	// RVA: 0x86D1230 Offset: 0x86CD230 VA: 0x86D1230
	private void RewindNamed(string name) { }

	// RVA: 0x86D1274 Offset: 0x86CD274 VA: 0x86D1274
	public void Sample() { }

	[NativeName("IsPlaying")]
	// RVA: 0x86D12B0 Offset: 0x86CD2B0 VA: 0x86D12B0
	public bool get_isPlaying() { }

	// RVA: 0x86D12EC Offset: 0x86CD2EC VA: 0x86D12EC
	public bool IsPlaying(string name) { }

	// RVA: 0x86D1330 Offset: 0x86CD330 VA: 0x86D1330
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocs]
	// RVA: 0x86D13B8 Offset: 0x86CD3B8 VA: 0x86D13B8
	public bool Play() { }

	// RVA: 0x86D13F8 Offset: 0x86CD3F8 VA: 0x86D13F8
	public bool Play(PlayMode mode) { }

	[NativeName("Play")]
	// RVA: 0x86D143C Offset: 0x86CD43C VA: 0x86D143C
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1480 Offset: 0x86CD480 VA: 0x86D1480
	public bool Play(string animation) { }

	// RVA: 0x86D14C8 Offset: 0x86CD4C8 VA: 0x86D14C8
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x86D151C Offset: 0x86CD51C VA: 0x86D151C
	public void CrossFade(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x86D156C Offset: 0x86CD56C VA: 0x86D156C
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x86D15C4 Offset: 0x86CD5C4 VA: 0x86D15C4
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1628 Offset: 0x86CD628 VA: 0x86D1628
	public void Blend(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1678 Offset: 0x86CD678 VA: 0x86D1678
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x86D16D4 Offset: 0x86CD6D4 VA: 0x86D16D4
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1730 Offset: 0x86CD730 VA: 0x86D1730
	public AnimationState CrossFadeQueued(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1784 Offset: 0x86CD784 VA: 0x86D1784
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[ExcludeFromDocs]
	// RVA: 0x86D17E0 Offset: 0x86CD7E0 VA: 0x86D17E0
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = True)]
	// RVA: 0x86D1848 Offset: 0x86CD848 VA: 0x86D1848
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x86D18B4 Offset: 0x86CD8B4 VA: 0x86D18B4
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1900 Offset: 0x86CD900 VA: 0x86D1900
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = True)]
	// RVA: 0x86D1958 Offset: 0x86CD958 VA: 0x86D1958
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x86D19B4 Offset: 0x86CD9B4 VA: 0x86D19B4
	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocs]
	// RVA: 0x86D1A14 Offset: 0x86CDA14 VA: 0x86D1A14
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x86D1A84 Offset: 0x86CDA84 VA: 0x86D1A84
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x86D1AF8 Offset: 0x86CDAF8 VA: 0x86D1AF8
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x86D1B3C Offset: 0x86CDB3C VA: 0x86D1B3C
	public void RemoveClip(string clipName) { }

	[NativeName("RemoveClip")]
	// RVA: 0x86D1B80 Offset: 0x86CDB80 VA: 0x86D1B80
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x86D1BC4 Offset: 0x86CDBC4 VA: 0x86D1BC4
	public int GetClipCount() { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	// RVA: 0x86D1C00 Offset: 0x86CDC00 VA: 0x86D1C00
	public bool Play(AnimationPlayMode mode) { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	// RVA: 0x86D1C44 Offset: 0x86CDC44 VA: 0x86D1C44
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x86D1C98 Offset: 0x86CDC98 VA: 0x86D1C98
	public void SyncLayer(int layer) { }

	// RVA: 0x86D1CDC Offset: 0x86CDCDC VA: 0x86D1CDC Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	// RVA: 0x86D1374 Offset: 0x86CD374 VA: 0x86D1374
	internal AnimationState GetState(string name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x86D1D84 Offset: 0x86CDD84 VA: 0x86D1D84
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeName("GetAnimationStateCount")]
	// RVA: 0x86D1DC8 Offset: 0x86CDDC8 VA: 0x86D1DC8
	internal int GetStateCount() { }

	// RVA: 0x86D1E04 Offset: 0x86CDE04 VA: 0x86D1E04
	public AnimationClip GetClip(string name) { }

	// RVA: 0x86D1ED4 Offset: 0x86CDED4 VA: 0x86D1ED4
	public bool get_animatePhysics() { }

	// RVA: 0x86D1F10 Offset: 0x86CDF10 VA: 0x86D1F10
	public void set_animatePhysics(bool value) { }

	[FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = True)]
	// RVA: 0x86D1F54 Offset: 0x86CDF54 VA: 0x86D1F54
	public bool get_animateOnlyIfVisible() { }

	[FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = True)]
	// RVA: 0x86D1F90 Offset: 0x86CDF90 VA: 0x86D1F90
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x86D1FD4 Offset: 0x86CDFD4 VA: 0x86D1FD4
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x86D2010 Offset: 0x86CE010 VA: 0x86D2010
	public void set_cullingType(AnimationCullingType value) { }

	[NativeName("GetLocalAABB")]
	// RVA: 0x86D2054 Offset: 0x86CE054 VA: 0x86D2054
	public Bounds get_localBounds() { }

	[NativeName("SetLocalAABB")]
	// RVA: 0x86D2100 Offset: 0x86CE100 VA: 0x86D2100
	public void set_localBounds(Bounds value) { }

	// RVA: 0x86D2188 Offset: 0x86CE188 VA: 0x86D2188
	public void .ctor() { }

	// RVA: 0x86D20BC Offset: 0x86CE0BC VA: 0x86D20BC
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x86D2144 Offset: 0x86CE144 VA: 0x86D2144
	private void set_localBounds_Injected(ref Bounds value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference // TypeDefIndex: 27478
{
	// Properties
	public AnimationClip clip { get; }

	// Methods

	// RVA: 0x86D1E98 Offset: 0x86CDE98 VA: 0x86D1E98
	public AnimationClip get_clip() { }

	// RVA: 0x86D2248 Offset: 0x86CE248 VA: 0x86D2248
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public sealed class AnimationEvent // TypeDefIndex: 27479
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Methods

	// RVA: 0x86D2250 Offset: 0x86CE250 VA: 0x86D2250
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion // TypeDefIndex: 27480
{
	// Properties
	[NativeProperty("Length", False, 0)]
	public float length { get; }
	[NativeProperty("StartTime", False, 0)]
	internal float startTime { get; }
	[NativeProperty("StopTime", False, 0)]
	internal float stopTime { get; }
	[NativeProperty("SampleRate", False, 0)]
	public float frameRate { get; set; }
	[NativeProperty("WrapMode", False, 0)]
	public WrapMode wrapMode { get; set; }
	[NativeProperty("Bounds", False, 0)]
	public Bounds localBounds { get; set; }
	public bool legacy { get; set; }
	public bool humanMotion { get; }
	public bool empty { get; }
	public bool hasGenericRootTransform { get; }
	public bool hasMotionFloatCurves { get; }
	public bool hasMotionCurves { get; }
	public bool hasRootCurves { get; }
	internal bool hasRootMotion { get; }
	public AnimationEvent[] events { get; set; }

	// Methods

	// RVA: 0x86D22E0 Offset: 0x86CE2E0 VA: 0x86D22E0
	public void .ctor() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	// RVA: 0x86D2378 Offset: 0x86CE378 VA: 0x86D2378
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x86D23B4 Offset: 0x86CE3B4 VA: 0x86D23B4
	public void SampleAnimation(GameObject go, float time) { }

	[FreeFunction]
	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	// RVA: 0x86D247C Offset: 0x86CE47C VA: 0x86D247C
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x86D24E0 Offset: 0x86CE4E0 VA: 0x86D24E0
	public float get_length() { }

	// RVA: 0x86D251C Offset: 0x86CE51C VA: 0x86D251C
	internal float get_startTime() { }

	// RVA: 0x86D2558 Offset: 0x86CE558 VA: 0x86D2558
	internal float get_stopTime() { }

	// RVA: 0x86D2594 Offset: 0x86CE594 VA: 0x86D2594
	public float get_frameRate() { }

	// RVA: 0x86D25D0 Offset: 0x86CE5D0 VA: 0x86D25D0
	public void set_frameRate(float value) { }

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	// RVA: 0x86D261C Offset: 0x86CE61C VA: 0x86D261C
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	// RVA: 0x86D2688 Offset: 0x86CE688 VA: 0x86D2688
	public void EnsureQuaternionContinuity() { }

	// RVA: 0x86D26C4 Offset: 0x86CE6C4 VA: 0x86D26C4
	public void ClearCurves() { }

	// RVA: 0x86D2440 Offset: 0x86CE440 VA: 0x86D2440
	public WrapMode get_wrapMode() { }

	// RVA: 0x86D2700 Offset: 0x86CE700 VA: 0x86D2700
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x86D2744 Offset: 0x86CE744 VA: 0x86D2744
	public Bounds get_localBounds() { }

	// RVA: 0x86D27F0 Offset: 0x86CE7F0 VA: 0x86D27F0
	public void set_localBounds(Bounds value) { }

	[NativeMethod("IsLegacy")]
	// RVA: 0x86D2878 Offset: 0x86CE878 VA: 0x86D2878
	public bool get_legacy() { }

	[NativeMethod("SetLegacy")]
	// RVA: 0x86D28B4 Offset: 0x86CE8B4 VA: 0x86D28B4
	public void set_legacy(bool value) { }

	[NativeMethod("IsHumanMotion")]
	// RVA: 0x86D28F8 Offset: 0x86CE8F8 VA: 0x86D28F8
	public bool get_humanMotion() { }

	[NativeMethod("IsEmpty")]
	// RVA: 0x86D2934 Offset: 0x86CE934 VA: 0x86D2934
	public bool get_empty() { }

	[NativeMethod("HasGenericRootTransform")]
	// RVA: 0x86D2970 Offset: 0x86CE970 VA: 0x86D2970
	public bool get_hasGenericRootTransform() { }

	[NativeMethod("HasMotionFloatCurves")]
	// RVA: 0x86D29AC Offset: 0x86CE9AC VA: 0x86D29AC
	public bool get_hasMotionFloatCurves() { }

	[NativeMethod("HasMotionCurves")]
	// RVA: 0x86D29E8 Offset: 0x86CE9E8 VA: 0x86D29E8
	public bool get_hasMotionCurves() { }

	[NativeMethod("HasRootCurves")]
	// RVA: 0x86D2A24 Offset: 0x86CEA24 VA: 0x86D2A24
	public bool get_hasRootCurves() { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	// RVA: 0x86D2A60 Offset: 0x86CEA60 VA: 0x86D2A60
	internal bool get_hasRootMotion() { }

	// RVA: 0x86D2A9C Offset: 0x86CEA9C VA: 0x86D2A9C
	public void AddEvent(AnimationEvent evt) { }

	[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = True)]
	// RVA: 0x86D2B2C Offset: 0x86CEB2C VA: 0x86D2B2C
	private void AddEventInternal(object evt) { }

	// RVA: 0x86D2B70 Offset: 0x86CEB70 VA: 0x86D2B70
	public AnimationEvent[] get_events() { }

	// RVA: 0x86D2C38 Offset: 0x86CEC38 VA: 0x86D2C38
	public void set_events(AnimationEvent[] value) { }

	[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x86D2C7C Offset: 0x86CEC7C VA: 0x86D2C7C
	private void SetEventsInternal(Array value) { }

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	// RVA: 0x86D2BFC Offset: 0x86CEBFC VA: 0x86D2BFC
	private Array GetEventsInternal() { }

	// RVA: 0x86D27AC Offset: 0x86CE7AC VA: 0x86D27AC
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x86D2834 Offset: 0x86CE834 VA: 0x86D2834
	private void set_localBounds_Injected(ref Bounds value) { }
}

// Namespace: UnityEngine
public enum AvatarTarget // TypeDefIndex: 27481
{
	// Fields
	public int value__; // 0x0
	public const AvatarTarget Root = 0;
	public const AvatarTarget Body = 1;
	public const AvatarTarget LeftFoot = 2;
	public const AvatarTarget RightFoot = 3;
	public const AvatarTarget LeftHand = 4;
	public const AvatarTarget RightHand = 5;
}

// Namespace: UnityEngine
public enum AvatarIKGoal // TypeDefIndex: 27482
{
	// Fields
	public int value__; // 0x0
	public const AvatarIKGoal LeftFoot = 0;
	public const AvatarIKGoal RightFoot = 1;
	public const AvatarIKGoal LeftHand = 2;
	public const AvatarIKGoal RightHand = 3;
}

// Namespace: UnityEngine
public enum AvatarIKHint // TypeDefIndex: 27483
{
	// Fields
	public int value__; // 0x0
	public const AvatarIKHint LeftKnee = 0;
	public const AvatarIKHint RightKnee = 1;
	public const AvatarIKHint LeftElbow = 2;
	public const AvatarIKHint RightElbow = 3;
}

// Namespace: UnityEngine
public enum AnimatorControllerParameterType // TypeDefIndex: 27484
{
	// Fields
	public int value__; // 0x0
	public const AnimatorControllerParameterType Float = 1;
	public const AnimatorControllerParameterType Int = 3;
	public const AnimatorControllerParameterType Bool = 4;
	public const AnimatorControllerParameterType Trigger = 9;
}

// Namespace: UnityEngine
internal enum StateInfoIndex // TypeDefIndex: 27485
{
	// Fields
	public int value__; // 0x0
	public const StateInfoIndex CurrentState = 0;
	public const StateInfoIndex NextState = 1;
	public const StateInfoIndex ExitState = 2;
	public const StateInfoIndex InterruptedState = 3;
}

// Namespace: UnityEngine
public enum AnimatorRecorderMode // TypeDefIndex: 27486
{
	// Fields
	public int value__; // 0x0
	public const AnimatorRecorderMode Offline = 0;
	public const AnimatorRecorderMode Playback = 1;
	public const AnimatorRecorderMode Record = 2;
}

// Namespace: UnityEngine
public enum AnimatorCullingMode // TypeDefIndex: 27487
{
	// Fields
	public int value__; // 0x0
	public const AnimatorCullingMode AlwaysAnimate = 0;
	public const AnimatorCullingMode CullUpdateTransforms = 1;
	public const AnimatorCullingMode CullCompletely = 2;
}

// Namespace: UnityEngine
public enum AnimatorUpdateMode // TypeDefIndex: 27488
{
	// Fields
	public int value__; // 0x0
	public const AnimatorUpdateMode Normal = 0;
	public const AnimatorUpdateMode AnimatePhysics = 1;
	public const AnimatorUpdateMode UnscaledTime = 2;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorClipInfo // TypeDefIndex: 27489
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	// Properties
	public AnimationClip clip { get; }
	public float weight { get; }

	// Methods

	// RVA: 0x86D2CC0 Offset: 0x86CECC0 VA: 0x86D2CC0
	public AnimationClip get_clip() { }

	// RVA: 0x86D2D4C Offset: 0x86CED4C VA: 0x86D2D4C
	public float get_weight() { }

	[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
	// RVA: 0x86D2D10 Offset: 0x86CED10 VA: 0x86D2D10
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorStateInfo // TypeDefIndex: 27490
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public int fullPathHash { get; }
	[Obsolete("AnimatorStateInfo.nameHash has been deprecated. Use AnimatorStateInfo.fullPathHash instead.")]
	public int nameHash { get; }
	public int shortNameHash { get; }
	public float normalizedTime { get; }
	public float length { get; }
	public float speed { get; }
	public float speedMultiplier { get; }
	public int tagHash { get; }
	public bool loop { get; }

	// Methods

	// RVA: 0x86D2D54 Offset: 0x86CED54 VA: 0x86D2D54
	public bool IsName(string name) { }

	// RVA: 0x86D2E00 Offset: 0x86CEE00 VA: 0x86D2E00
	public int get_fullPathHash() { }

	// RVA: 0x86D2E08 Offset: 0x86CEE08 VA: 0x86D2E08
	public int get_nameHash() { }

	// RVA: 0x86D2E10 Offset: 0x86CEE10 VA: 0x86D2E10
	public int get_shortNameHash() { }

	// RVA: 0x86D2E18 Offset: 0x86CEE18 VA: 0x86D2E18
	public float get_normalizedTime() { }

	// RVA: 0x86D2E20 Offset: 0x86CEE20 VA: 0x86D2E20
	public float get_length() { }

	// RVA: 0x86D2E28 Offset: 0x86CEE28 VA: 0x86D2E28
	public float get_speed() { }

	// RVA: 0x86D2E30 Offset: 0x86CEE30 VA: 0x86D2E30
	public float get_speedMultiplier() { }

	// RVA: 0x86D2E38 Offset: 0x86CEE38 VA: 0x86D2E38
	public int get_tagHash() { }

	// RVA: 0x86D2E40 Offset: 0x86CEE40 VA: 0x86D2E40
	public bool IsTag(string tag) { }

	// RVA: 0x86D2E90 Offset: 0x86CEE90 VA: 0x86D2E90
	public bool get_loop() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorTransitionInfo // TypeDefIndex: 27491
{
	// Fields
	[NativeName("fullPathHash")]
	private int m_FullPath; // 0x0
	[NativeName("userNameHash")]
	private int m_UserName; // 0x4
	[NativeName("nameHash")]
	private int m_Name; // 0x8
	[NativeName("hasFixedDuration")]
	private bool m_HasFixedDuration; // 0xC
	[NativeName("duration")]
	private float m_Duration; // 0x10
	[NativeName("normalizedTime")]
	private float m_NormalizedTime; // 0x14
	[NativeName("anyState")]
	private bool m_AnyState; // 0x18
	[NativeName("transitionType")]
	private int m_TransitionType; // 0x1C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Animator.h")]
public struct MatchTargetWeightMask // TypeDefIndex: 27492
{
	// Fields
	private Vector3 m_PositionXYZWeight; // 0x0
	private float m_RotationWeight; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
public class Animator : Behaviour // TypeDefIndex: 27493
{
	// Properties
	public bool isOptimizable { get; }
	public bool isHuman { get; }
	public bool hasRootMotion { get; }
	internal bool isRootPositionOrRotationControlledByCurves { get; }
	public float humanScale { get; }
	public bool isInitialized { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public Vector3 velocity { get; }
	public Vector3 angularVelocity { get; }
	public Vector3 rootPosition { get; set; }
	public Quaternion rootRotation { get; set; }
	public bool applyRootMotion { get; set; }
	[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
	public bool linearVelocityBlending { get; set; }
	[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
	public bool animatePhysics { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public bool hasTransformHierarchy { get; }
	internal bool allowConstantClipSamplingOptimization { get; set; }
	public float gravityWeight { get; }
	public Vector3 bodyPosition { get; set; }
	internal Vector3 bodyPositionInternal { get; set; }
	public Quaternion bodyRotation { get; set; }
	internal Quaternion bodyRotationInternal { get; set; }
	public bool stabilizeFeet { get; set; }
	public int layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public int parameterCount { get; }
	public float feetPivotActive { get; set; }
	public float pivotWeight { get; }
	public Vector3 pivotPosition { get; }
	public bool isMatchingTarget { get; }
	public float speed { get; set; }
	public Vector3 targetPosition { get; }
	public Quaternion targetRotation { get; }
	public Transform avatarRoot { get; }
	public AnimatorCullingMode cullingMode { get; set; }
	public float playbackTime { get; set; }
	public float recorderStartTime { get; set; }
	public float recorderStopTime { get; set; }
	public AnimatorRecorderMode recorderMode { get; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool layersAffectMassCenter { get; set; }
	public float leftFeetBottomHeight { get; }
	public float rightFeetBottomHeight { get; }
	[NativeConditional("UNITY_EDITOR")]
	internal bool supportsOnAnimatorMove { get; }
	public bool logWarnings { get; set; }
	public bool fireEvents { get; set; }
	[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
	public bool keepAnimatorControllerStateOnDisable { get; set; }
	public bool keepAnimatorStateOnDisable { get; set; }
	public bool writeDefaultValuesOnDisable { get; set; }

	// Methods

	[NativeMethod("IsOptimizable")]
	// RVA: 0x86D2EA0 Offset: 0x86CEEA0 VA: 0x86D2EA0
	public bool get_isOptimizable() { }

	[NativeMethod("IsHuman")]
	// RVA: 0x86D2EDC Offset: 0x86CEEDC VA: 0x86D2EDC
	public bool get_isHuman() { }

	[NativeMethod("HasRootMotion")]
	// RVA: 0x86D2F18 Offset: 0x86CEF18 VA: 0x86D2F18
	public bool get_hasRootMotion() { }

	[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
	// RVA: 0x86D2F54 Offset: 0x86CEF54 VA: 0x86D2F54
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x86D2F90 Offset: 0x86CEF90 VA: 0x86D2F90
	public float get_humanScale() { }

	[NativeMethod("IsInitialized")]
	// RVA: 0x86D2FCC Offset: 0x86CEFCC VA: 0x86D2FCC
	public bool get_isInitialized() { }

	// RVA: 0x86D3008 Offset: 0x86CF008 VA: 0x86D3008
	public float GetFloat(string name) { }

	// RVA: 0x86D3090 Offset: 0x86CF090 VA: 0x86D3090
	public float GetFloat(int id) { }

	// RVA: 0x86D3118 Offset: 0x86CF118 VA: 0x86D3118
	public void SetFloat(string name, float value) { }

	// RVA: 0x86D31C0 Offset: 0x86CF1C0 VA: 0x86D31C0
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x86D3298 Offset: 0x86CF298 VA: 0x86D3298
	public void SetFloat(int id, float value) { }

	// RVA: 0x86D3340 Offset: 0x86CF340 VA: 0x86D3340
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x86D3418 Offset: 0x86CF418 VA: 0x86D3418
	public bool GetBool(string name) { }

	// RVA: 0x86D34A0 Offset: 0x86CF4A0 VA: 0x86D34A0
	public bool GetBool(int id) { }

	// RVA: 0x86D3528 Offset: 0x86CF528 VA: 0x86D3528
	public void SetBool(string name, bool value) { }

	// RVA: 0x86D35D0 Offset: 0x86CF5D0 VA: 0x86D35D0
	public void SetBool(int id, bool value) { }

	// RVA: 0x86D3678 Offset: 0x86CF678 VA: 0x86D3678
	public int GetInteger(string name) { }

	// RVA: 0x86D3700 Offset: 0x86CF700 VA: 0x86D3700
	public int GetInteger(int id) { }

	// RVA: 0x86D3788 Offset: 0x86CF788 VA: 0x86D3788
	public void SetInteger(string name, int value) { }

	// RVA: 0x86D3830 Offset: 0x86CF830 VA: 0x86D3830
	public void SetInteger(int id, int value) { }

	// RVA: 0x86D38D8 Offset: 0x86CF8D8 VA: 0x86D38D8
	public void SetTrigger(string name) { }

	// RVA: 0x86D3960 Offset: 0x86CF960 VA: 0x86D3960
	public void SetTrigger(int id) { }

	// RVA: 0x86D39E8 Offset: 0x86CF9E8 VA: 0x86D39E8
	public void ResetTrigger(string name) { }

	// RVA: 0x86D3A70 Offset: 0x86CFA70 VA: 0x86D3A70
	public void ResetTrigger(int id) { }

	// RVA: 0x86D3AF8 Offset: 0x86CFAF8 VA: 0x86D3AF8
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x86D3B80 Offset: 0x86CFB80 VA: 0x86D3B80
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x86D3C08 Offset: 0x86CFC08 VA: 0x86D3C08
	public Vector3 get_deltaPosition() { }

	// RVA: 0x86D3CA8 Offset: 0x86CFCA8 VA: 0x86D3CA8
	public Quaternion get_deltaRotation() { }

	// RVA: 0x86D3D44 Offset: 0x86CFD44 VA: 0x86D3D44
	public Vector3 get_velocity() { }

	// RVA: 0x86D3DE4 Offset: 0x86CFDE4 VA: 0x86D3DE4
	public Vector3 get_angularVelocity() { }

	[NativeMethod("GetAvatarPosition")]
	// RVA: 0x86D3E84 Offset: 0x86CFE84 VA: 0x86D3E84
	public Vector3 get_rootPosition() { }

	[NativeMethod("SetAvatarPosition")]
	// RVA: 0x86D3F24 Offset: 0x86CFF24 VA: 0x86D3F24
	public void set_rootPosition(Vector3 value) { }

	[NativeMethod("GetAvatarRotation")]
	// RVA: 0x86D3FBC Offset: 0x86CFFBC VA: 0x86D3FBC
	public Quaternion get_rootRotation() { }

	[NativeMethod("SetAvatarRotation")]
	// RVA: 0x86D4058 Offset: 0x86D0058 VA: 0x86D4058
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x86D40F0 Offset: 0x86D00F0 VA: 0x86D40F0
	public bool get_applyRootMotion() { }

	// RVA: 0x86D412C Offset: 0x86D012C VA: 0x86D412C
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x86D4170 Offset: 0x86D0170 VA: 0x86D4170
	public bool get_linearVelocityBlending() { }

	// RVA: 0x86D41AC Offset: 0x86D01AC VA: 0x86D41AC
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x86D41F0 Offset: 0x86D01F0 VA: 0x86D41F0
	public bool get_animatePhysics() { }

	// RVA: 0x86D4274 Offset: 0x86D0274 VA: 0x86D4274
	public void set_animatePhysics(bool value) { }

	// RVA: 0x86D4238 Offset: 0x86D0238 VA: 0x86D4238
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x86D42C0 Offset: 0x86D02C0 VA: 0x86D42C0
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x86D4304 Offset: 0x86D0304 VA: 0x86D4304
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x86D4340 Offset: 0x86D0340 VA: 0x86D4340
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x86D437C Offset: 0x86D037C VA: 0x86D437C
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x86D43C0 Offset: 0x86D03C0 VA: 0x86D43C0
	public float get_gravityWeight() { }

	// RVA: 0x86D43FC Offset: 0x86D03FC VA: 0x86D43FC
	public Vector3 get_bodyPosition() { }

	// RVA: 0x86D4540 Offset: 0x86D0540 VA: 0x86D4540
	public void set_bodyPosition(Vector3 value) { }

	[NativeMethod("GetBodyPosition")]
	// RVA: 0x86D44E4 Offset: 0x86D04E4 VA: 0x86D44E4
	internal Vector3 get_bodyPositionInternal() { }

	[NativeMethod("SetBodyPosition")]
	// RVA: 0x86D4580 Offset: 0x86D0580 VA: 0x86D4580
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x86D465C Offset: 0x86D065C VA: 0x86D465C
	public Quaternion get_bodyRotation() { }

	// RVA: 0x86D46CC Offset: 0x86D06CC VA: 0x86D46CC
	public void set_bodyRotation(Quaternion value) { }

	[NativeMethod("GetBodyRotation")]
	// RVA: 0x86D4674 Offset: 0x86D0674 VA: 0x86D4674
	internal Quaternion get_bodyRotationInternal() { }

	[NativeMethod("SetBodyRotation")]
	// RVA: 0x86D4714 Offset: 0x86D0714 VA: 0x86D4714
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x86D47F0 Offset: 0x86D07F0 VA: 0x86D47F0
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x86D4818 Offset: 0x86D0818 VA: 0x86D4818
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x86D48D0 Offset: 0x86D08D0 VA: 0x86D48D0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x86D4920 Offset: 0x86D0920 VA: 0x86D4920
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x86D49D0 Offset: 0x86D09D0 VA: 0x86D49D0
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x86D49F8 Offset: 0x86D09F8 VA: 0x86D49F8
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x86D4AAC Offset: 0x86D0AAC VA: 0x86D4AAC
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x86D4B04 Offset: 0x86D0B04 VA: 0x86D4B04
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x86D4BB4 Offset: 0x86D0BB4 VA: 0x86D4BB4
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x86D4BFC Offset: 0x86D0BFC VA: 0x86D4BFC
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x86D4C40 Offset: 0x86D0C40 VA: 0x86D4C40
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x86D4C98 Offset: 0x86D0C98 VA: 0x86D4C98
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x86D4CEC Offset: 0x86D0CEC VA: 0x86D4CEC
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x86D4D34 Offset: 0x86D0D34 VA: 0x86D4D34
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x86D4D78 Offset: 0x86D0D78 VA: 0x86D4D78
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x86D4DD0 Offset: 0x86D0DD0 VA: 0x86D4DD0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x86D4E24 Offset: 0x86D0E24 VA: 0x86D4E24
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x86D4E4C Offset: 0x86D0E4C VA: 0x86D4E4C
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x86D4F04 Offset: 0x86D0F04 VA: 0x86D4F04
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x86D4F54 Offset: 0x86D0F54 VA: 0x86D4F54
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x86D5004 Offset: 0x86D1004 VA: 0x86D5004
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x86D504C Offset: 0x86D104C VA: 0x86D504C
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x86D5090 Offset: 0x86D1090 VA: 0x86D5090
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x86D50E8 Offset: 0x86D10E8 VA: 0x86D50E8
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x86D513C Offset: 0x86D113C VA: 0x86D513C
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod("SetLookAtPosition")]
	// RVA: 0x86D517C Offset: 0x86D117C VA: 0x86D517C
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x86D5214 Offset: 0x86D1214 VA: 0x86D5214
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x86D52F0 Offset: 0x86D12F0 VA: 0x86D52F0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x86D5354 Offset: 0x86D1354 VA: 0x86D5354
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x86D53C4 Offset: 0x86D13C4 VA: 0x86D53C4
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x86D5438 Offset: 0x86D1438 VA: 0x86D5438
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethod("SetLookAtWeight")]
	// RVA: 0x86D5274 Offset: 0x86D1274 VA: 0x86D5274
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x86D54B8 Offset: 0x86D14B8 VA: 0x86D54B8
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethod("SetBoneLocalRotation")]
	// RVA: 0x86D5574 Offset: 0x86D1574 VA: 0x86D5574
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x86D5624 Offset: 0x86D1624 VA: 0x86D5624
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: -1 Offset: -1
	public T GetBehaviour<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475FB60 Offset: 0x475BB60 VA: 0x475FB60
	|-Animator.GetBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475FA3C Offset: 0x475BA3C VA: 0x475FA3C
	|-Animator.ConvertStateMachineBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetBehaviours<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475FC48 Offset: 0x475BC48 VA: 0x475FC48
	|-Animator.GetBehaviours<object>
	*/

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	// RVA: 0x86D5668 Offset: 0x86D1668 VA: 0x86D5668
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x86D56AC Offset: 0x86D16AC VA: 0x86D56AC
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = True)]
	// RVA: 0x86D5788 Offset: 0x86D1788 VA: 0x86D5788
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x86D57E4 Offset: 0x86D17E4 VA: 0x86D57E4
	public bool get_stabilizeFeet() { }

	// RVA: 0x86D5820 Offset: 0x86D1820 VA: 0x86D5820
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x86D5864 Offset: 0x86D1864 VA: 0x86D5864
	public int get_layerCount() { }

	// RVA: 0x86D58A0 Offset: 0x86D18A0 VA: 0x86D58A0
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x86D58E4 Offset: 0x86D18E4 VA: 0x86D58E4
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x86D5928 Offset: 0x86D1928 VA: 0x86D5928
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x86D596C Offset: 0x86D196C VA: 0x86D596C
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x86D59C0 Offset: 0x86D19C0 VA: 0x86D59C0
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x86D5A1C Offset: 0x86D1A1C VA: 0x86D5A1C
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x86D5A9C Offset: 0x86D1A9C VA: 0x86D5A9C
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x86D5B1C Offset: 0x86D1B1C VA: 0x86D5B1C
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x86D5B70 Offset: 0x86D1B70 VA: 0x86D5B70
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x86D5BE0 Offset: 0x86D1BE0 VA: 0x86D5BE0
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x86D5C34 Offset: 0x86D1C34 VA: 0x86D5C34
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x86D5C7C Offset: 0x86D1C7C VA: 0x86D5C7C
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
	// RVA: 0x86D5CC4 Offset: 0x86D1CC4 VA: 0x86D5CC4
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
	// RVA: 0x86D5D08 Offset: 0x86D1D08 VA: 0x86D5D08
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x86D5D4C Offset: 0x86D1D4C VA: 0x86D5D4C
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	// RVA: 0x86D5DF0 Offset: 0x86D1DF0 VA: 0x86D5DF0
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x86D5E4C Offset: 0x86D1E4C VA: 0x86D5E4C
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	// RVA: 0x86D5EF0 Offset: 0x86D1EF0 VA: 0x86D5EF0
	public bool IsInTransition(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	// RVA: 0x86D5F34 Offset: 0x86D1F34 VA: 0x86D5F34
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x86D5F70 Offset: 0x86D1F70 VA: 0x86D5F70
	public int get_parameterCount() { }

	[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = True)]
	// RVA: 0x86D5FAC Offset: 0x86D1FAC VA: 0x86D5FAC
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x86D5FF0 Offset: 0x86D1FF0 VA: 0x86D5FF0
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x86D60C0 Offset: 0x86D20C0 VA: 0x86D60C0
	public float get_feetPivotActive() { }

	// RVA: 0x86D60FC Offset: 0x86D20FC VA: 0x86D60FC
	public void set_feetPivotActive(float value) { }

	// RVA: 0x86D6148 Offset: 0x86D2148 VA: 0x86D6148
	public float get_pivotWeight() { }

	// RVA: 0x86D6184 Offset: 0x86D2184 VA: 0x86D6184
	public Vector3 get_pivotPosition() { }

	// RVA: 0x86D6224 Offset: 0x86D2224 VA: 0x86D6224
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x86D634C Offset: 0x86D234C VA: 0x86D634C
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x86D6380 Offset: 0x86D2380 VA: 0x86D6380
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x86D63A0 Offset: 0x86D23A0 VA: 0x86D63A0
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x86D63C0 Offset: 0x86D23C0 VA: 0x86D63C0
	public void InterruptMatchTarget() { }

	// RVA: 0x86D6400 Offset: 0x86D2400 VA: 0x86D6400
	public void InterruptMatchTarget(bool completeMatch) { }

	[NativeMethod("IsMatchingTarget")]
	// RVA: 0x86D6444 Offset: 0x86D2444 VA: 0x86D6444
	public bool get_isMatchingTarget() { }

	// RVA: 0x86D6480 Offset: 0x86D2480 VA: 0x86D6480
	public float get_speed() { }

	// RVA: 0x86D64BC Offset: 0x86D24BC VA: 0x86D64BC
	public void set_speed(float value) { }

	[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
	// RVA: 0x86D6508 Offset: 0x86D2508 VA: 0x86D6508
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x86D65C0 Offset: 0x86D25C0 VA: 0x86D65C0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x86D66C8 Offset: 0x86D26C8 VA: 0x86D66C8
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x86D6760 Offset: 0x86D2760 VA: 0x86D6760
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x86D67FC Offset: 0x86D27FC VA: 0x86D67FC
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x86D68A4 Offset: 0x86D28A4 VA: 0x86D68A4
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x86D6914 Offset: 0x86D2914 VA: 0x86D6914
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x86D6980 Offset: 0x86D2980 VA: 0x86D6980
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	// RVA: 0x86D664C Offset: 0x86D264C VA: 0x86D664C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
	// RVA: 0x86D69E0 Offset: 0x86D29E0 VA: 0x86D69E0
	public void WriteDefaultValues() { }

	// RVA: 0x86D6A1C Offset: 0x86D2A1C VA: 0x86D6A1C
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x86D6ACC Offset: 0x86D2ACC VA: 0x86D6ACC
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x86D6ADC Offset: 0x86D2ADC VA: 0x86D6ADC
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x86D6A24 Offset: 0x86D2A24 VA: 0x86D6A24
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	// RVA: 0x86D6AF0 Offset: 0x86D2AF0 VA: 0x86D6AF0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x86D6B6C Offset: 0x86D2B6C VA: 0x86D6B6C
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x86D6BDC Offset: 0x86D2BDC VA: 0x86D6BDC
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x86D6C4C Offset: 0x86D2C4C VA: 0x86D6C4C
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x86D6CB0 Offset: 0x86D2CB0 VA: 0x86D6CB0
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x86D6D4C Offset: 0x86D2D4C VA: 0x86D6D4C
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x86D6CBC Offset: 0x86D2CBC VA: 0x86D6CBC
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	// RVA: 0x86D6D5C Offset: 0x86D2D5C VA: 0x86D6D5C
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x86D6DC0 Offset: 0x86D2DC0 VA: 0x86D6DC0
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x86D6E1C Offset: 0x86D2E1C VA: 0x86D6E1C
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x86D6E6C Offset: 0x86D2E6C VA: 0x86D6E6C
	public void Play(string stateName, int layer) { }

	// RVA: 0x86D6F08 Offset: 0x86D2F08 VA: 0x86D6F08
	public void Play(string stateName) { }

	// RVA: 0x86D6E78 Offset: 0x86D2E78 VA: 0x86D6E78
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	// RVA: 0x86D655C Offset: 0x86D255C VA: 0x86D655C
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x86D6F18 Offset: 0x86D2F18 VA: 0x86D6F18
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x86D6F74 Offset: 0x86D2F74 VA: 0x86D6F74
	public void Play(int stateNameHash) { }

	// RVA: 0x86D6FC4 Offset: 0x86D2FC4 VA: 0x86D6FC4
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x86D7018 Offset: 0x86D3018 VA: 0x86D7018
	public Vector3 get_targetPosition() { }

	// RVA: 0x86D70B8 Offset: 0x86D30B8 VA: 0x86D70B8
	public Quaternion get_targetRotation() { }

	[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x86D7154 Offset: 0x86D3154 VA: 0x86D7154
	public bool IsControlled(Transform transform) { }

	// RVA: 0x86D715C Offset: 0x86D315C VA: 0x86D715C
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x86D71A0 Offset: 0x86D31A0 VA: 0x86D71A0
	public Transform get_avatarRoot() { }

	// RVA: 0x86D71DC Offset: 0x86D31DC VA: 0x86D71DC
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	// RVA: 0x86D7550 Offset: 0x86D3550 VA: 0x86D7550
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x86D7594 Offset: 0x86D3594 VA: 0x86D7594
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x86D75D0 Offset: 0x86D35D0 VA: 0x86D75D0
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x86D7614 Offset: 0x86D3614 VA: 0x86D7614
	public void StartPlayback() { }

	// RVA: 0x86D7650 Offset: 0x86D3650 VA: 0x86D7650
	public void StopPlayback() { }

	// RVA: 0x86D768C Offset: 0x86D368C VA: 0x86D768C
	public float get_playbackTime() { }

	// RVA: 0x86D76C8 Offset: 0x86D36C8 VA: 0x86D76C8
	public void set_playbackTime(float value) { }

	// RVA: 0x86D7714 Offset: 0x86D3714 VA: 0x86D7714
	public void StartRecording(int frameCount) { }

	// RVA: 0x86D7758 Offset: 0x86D3758 VA: 0x86D7758
	public void StopRecording() { }

	// RVA: 0x86D7794 Offset: 0x86D3794 VA: 0x86D7794
	public float get_recorderStartTime() { }

	// RVA: 0x86D780C Offset: 0x86D380C VA: 0x86D780C
	public void set_recorderStartTime(float value) { }

	// RVA: 0x86D77D0 Offset: 0x86D37D0 VA: 0x86D77D0
	private float GetRecorderStartTime() { }

	// RVA: 0x86D7810 Offset: 0x86D3810 VA: 0x86D7810
	public float get_recorderStopTime() { }

	// RVA: 0x86D7888 Offset: 0x86D3888 VA: 0x86D7888
	public void set_recorderStopTime(float value) { }

	// RVA: 0x86D784C Offset: 0x86D384C VA: 0x86D784C
	private float GetRecorderStopTime() { }

	// RVA: 0x86D788C Offset: 0x86D388C VA: 0x86D788C
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x86D78C8 Offset: 0x86D38C8 VA: 0x86D78C8
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x86D7904 Offset: 0x86D3904 VA: 0x86D7904
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethod("HasBoundPlayables")]
	// RVA: 0x86D7948 Offset: 0x86D3948 VA: 0x86D7948
	public bool get_hasBoundPlayables() { }

	// RVA: 0x86D7984 Offset: 0x86D3984 VA: 0x86D7984
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x86D79C0 Offset: 0x86D39C0 VA: 0x86D79C0
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	// RVA: 0x86D2DC4 Offset: 0x86CEDC4 VA: 0x86D2DC4
	public static int StringToHash(string name) { }

	// RVA: 0x86D749C Offset: 0x86D349C VA: 0x86D749C
	public Avatar get_avatar() { }

	// RVA: 0x86D7A14 Offset: 0x86D3A14 VA: 0x86D7A14
	public void set_avatar(Avatar value) { }

	// RVA: 0x86D7A58 Offset: 0x86D3A58 VA: 0x86D7A58
	internal string GetStats() { }

	// RVA: 0x86D7A94 Offset: 0x86D3A94 VA: 0x86D7A94
	public PlayableGraph get_playableGraph() { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = True)]
	// RVA: 0x86D7AE8 Offset: 0x86D3AE8 VA: 0x86D7AE8
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0x86D4414 Offset: 0x86D0414 VA: 0x86D4414
	private void CheckIfInIKPass() { }

	// RVA: 0x86D7B68 Offset: 0x86D3B68 VA: 0x86D7B68
	private bool IsInIKPass() { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	// RVA: 0x86D316C Offset: 0x86CF16C VA: 0x86D316C
	private void SetFloatString(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	// RVA: 0x86D32EC Offset: 0x86CF2EC VA: 0x86D32EC
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	// RVA: 0x86D304C Offset: 0x86CF04C VA: 0x86D304C
	private float GetFloatString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	// RVA: 0x86D30D4 Offset: 0x86CF0D4 VA: 0x86D30D4
	private float GetFloatID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	// RVA: 0x86D357C Offset: 0x86CF57C VA: 0x86D357C
	private void SetBoolString(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	// RVA: 0x86D3624 Offset: 0x86CF624 VA: 0x86D3624
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	// RVA: 0x86D345C Offset: 0x86CF45C VA: 0x86D345C
	private bool GetBoolString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	// RVA: 0x86D34E4 Offset: 0x86CF4E4 VA: 0x86D34E4
	private bool GetBoolID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	// RVA: 0x86D37DC Offset: 0x86CF7DC VA: 0x86D37DC
	private void SetIntegerString(string name, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	// RVA: 0x86D3884 Offset: 0x86CF884 VA: 0x86D3884
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	// RVA: 0x86D36BC Offset: 0x86CF6BC VA: 0x86D36BC
	private int GetIntegerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	// RVA: 0x86D3744 Offset: 0x86CF744 VA: 0x86D3744
	private int GetIntegerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	// RVA: 0x86D391C Offset: 0x86CF91C VA: 0x86D391C
	private void SetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	// RVA: 0x86D39A4 Offset: 0x86CF9A4 VA: 0x86D39A4
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	// RVA: 0x86D3A2C Offset: 0x86CFA2C VA: 0x86D3A2C
	private void ResetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	// RVA: 0x86D3AB4 Offset: 0x86CFAB4 VA: 0x86D3AB4
	private void ResetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	// RVA: 0x86D3B3C Offset: 0x86CFB3C VA: 0x86D3B3C
	private bool IsParameterControlledByCurveString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	// RVA: 0x86D3BC4 Offset: 0x86CFBC4 VA: 0x86D3BC4
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = True)]
	// RVA: 0x86D322C Offset: 0x86CF22C VA: 0x86D322C
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	// RVA: 0x86D33AC Offset: 0x86CF3AC VA: 0x86D33AC
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x86D7BA4 Offset: 0x86D3BA4 VA: 0x86D7BA4
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x86D7BE0 Offset: 0x86D3BE0 VA: 0x86D7BE0
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x86D7C24 Offset: 0x86D3C24 VA: 0x86D7C24
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x86D7C60 Offset: 0x86D3C60 VA: 0x86D7C60
	public float get_rightFeetBottomHeight() { }

	[NativeMethod("SupportsOnAnimatorMove")]
	// RVA: 0x86D7C9C Offset: 0x86D3C9C VA: 0x86D7C9C
	internal bool get_supportsOnAnimatorMove() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7CD8 Offset: 0x86D3CD8 VA: 0x86D7CD8
	internal void OnUpdateModeChanged() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7D14 Offset: 0x86D3D14 VA: 0x86D7D14
	internal void OnCullingModeChanged() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7D50 Offset: 0x86D3D50 VA: 0x86D7D50
	internal void WriteDefaultPose() { }

	[NativeMethod("UpdateWithDelta")]
	// RVA: 0x86D7D8C Offset: 0x86D3D8C VA: 0x86D7D8C
	public void Update(float deltaTime) { }

	// RVA: 0x86D7DD8 Offset: 0x86D3DD8 VA: 0x86D7DD8
	public void Rebind() { }

	// RVA: 0x86D7E18 Offset: 0x86D3E18 VA: 0x86D7E18
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x86D7E5C Offset: 0x86D3E5C VA: 0x86D7E5C
	public void ApplyBuiltinRootMotion() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7E98 Offset: 0x86D3E98 VA: 0x86D7E98
	internal void EvaluateController() { }

	// RVA: 0x86D7ED8 Offset: 0x86D3ED8 VA: 0x86D7ED8
	private void EvaluateController(float deltaTime) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7F24 Offset: 0x86D3F24 VA: 0x86D7F24
	internal string GetCurrentStateName(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7FC0 Offset: 0x86D3FC0 VA: 0x86D7FC0
	internal string GetNextStateName(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x86D7F6C Offset: 0x86D3F6C VA: 0x86D7F6C
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x86D8008 Offset: 0x86D4008 VA: 0x86D8008
	internal string ResolveHash(int hash) { }

	// RVA: 0x86D7B2C Offset: 0x86D3B2C VA: 0x86D7B2C
	public bool get_logWarnings() { }

	// RVA: 0x86D804C Offset: 0x86D404C VA: 0x86D804C
	public void set_logWarnings(bool value) { }

	// RVA: 0x86D8090 Offset: 0x86D4090 VA: 0x86D8090
	public bool get_fireEvents() { }

	// RVA: 0x86D80CC Offset: 0x86D40CC VA: 0x86D80CC
	public void set_fireEvents(bool value) { }

	// RVA: 0x86D8110 Offset: 0x86D4110 VA: 0x86D8110
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x86D8188 Offset: 0x86D4188 VA: 0x86D8188
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x86D814C Offset: 0x86D414C VA: 0x86D814C
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x86D81CC Offset: 0x86D41CC VA: 0x86D81CC
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x86D8210 Offset: 0x86D4210 VA: 0x86D8210
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x86D824C Offset: 0x86D424C VA: 0x86D824C
	public void set_writeDefaultValuesOnDisable(bool value) { }

	[Obsolete("GetVector is deprecated.")]
	// RVA: 0x86D8290 Offset: 0x86D4290 VA: 0x86D8290
	public Vector3 GetVector(string name) { }

	[Obsolete("GetVector is deprecated.")]
	// RVA: 0x86D82D4 Offset: 0x86D42D4 VA: 0x86D82D4
	public Vector3 GetVector(int id) { }

	[Obsolete("SetVector is deprecated.")]
	// RVA: 0x86D8318 Offset: 0x86D4318 VA: 0x86D8318
	public void SetVector(string name, Vector3 value) { }

	[Obsolete("SetVector is deprecated.")]
	// RVA: 0x86D831C Offset: 0x86D431C VA: 0x86D831C
	public void SetVector(int id, Vector3 value) { }

	[Obsolete("GetQuaternion is deprecated.")]
	// RVA: 0x86D8320 Offset: 0x86D4320 VA: 0x86D8320
	public Quaternion GetQuaternion(string name) { }

	[Obsolete("GetQuaternion is deprecated.")]
	// RVA: 0x86D8364 Offset: 0x86D4364 VA: 0x86D8364
	public Quaternion GetQuaternion(int id) { }

	[Obsolete("SetQuaternion is deprecated.")]
	// RVA: 0x86D83A8 Offset: 0x86D43A8 VA: 0x86D83A8
	public void SetQuaternion(string name, Quaternion value) { }

	[Obsolete("SetQuaternion is deprecated.")]
	// RVA: 0x86D83AC Offset: 0x86D43AC VA: 0x86D83AC
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x86D83B0 Offset: 0x86D43B0 VA: 0x86D83B0
	public void .ctor() { }

	// RVA: 0x86D3C64 Offset: 0x86CFC64 VA: 0x86D3C64
	private void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x86D3D00 Offset: 0x86CFD00 VA: 0x86D3D00
	private void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x86D3DA0 Offset: 0x86CFDA0 VA: 0x86D3DA0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x86D3E40 Offset: 0x86CFE40 VA: 0x86D3E40
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x86D3EE0 Offset: 0x86CFEE0 VA: 0x86D3EE0
	private void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0x86D3F78 Offset: 0x86CFF78 VA: 0x86D3F78
	private void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0x86D4014 Offset: 0x86D0014 VA: 0x86D4014
	private void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0x86D40AC Offset: 0x86D00AC VA: 0x86D40AC
	private void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0x86D45D4 Offset: 0x86D05D4 VA: 0x86D45D4
	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0x86D4618 Offset: 0x86D0618 VA: 0x86D4618
	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0x86D4768 Offset: 0x86D0768 VA: 0x86D4768
	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0x86D47AC Offset: 0x86D07AC VA: 0x86D47AC
	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0x86D487C Offset: 0x86D087C VA: 0x86D487C
	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0x86D497C Offset: 0x86D097C VA: 0x86D497C
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x86D4A58 Offset: 0x86D0A58 VA: 0x86D4A58
	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0x86D4B60 Offset: 0x86D0B60 VA: 0x86D4B60
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x86D4EB0 Offset: 0x86D0EB0 VA: 0x86D4EB0
	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0x86D4FB0 Offset: 0x86D0FB0 VA: 0x86D4FB0
	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0x86D51D0 Offset: 0x86D11D0 VA: 0x86D51D0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x86D55D0 Offset: 0x86D15D0 VA: 0x86D55D0
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	// RVA: 0x86D61E0 Offset: 0x86D21E0 VA: 0x86D61E0
	private void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0x86D62C0 Offset: 0x86D22C0 VA: 0x86D62C0
	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x86D7074 Offset: 0x86D3074 VA: 0x86D7074
	private void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x86D7110 Offset: 0x86D3110 VA: 0x86D7110
	private void get_targetRotation_Injected(out Quaternion ret) { }
}

// Namespace: UnityEngine
[NativeAsStruct]
[UsedByNativeCode]
[NativeType(1, "MonoAnimatorControllerParameter")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
public class AnimatorControllerParameter // TypeDefIndex: 27494
{
	// Fields
	internal string m_Name; // 0x10
	internal AnimatorControllerParameterType m_Type; // 0x18
	internal float m_DefaultFloat; // 0x1C
	internal int m_DefaultInt; // 0x20
	internal bool m_DefaultBool; // 0x24

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x86D83B8 Offset: 0x86D43B8 VA: 0x86D83B8
	public string get_name() { }

	// RVA: 0x86D83C0 Offset: 0x86D43C0 VA: 0x86D83C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x86D849C Offset: 0x86D449C VA: 0x86D849C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x86D84BC Offset: 0x86D44BC VA: 0x86D84BC
	public void .ctor() { }
}

// Namespace: 
internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 27495
{
	// Methods

	// RVA: 0x86D8544 Offset: 0x86D4544 VA: 0x86D8544
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86D85E0 Offset: 0x86D45E0 VA: 0x86D85E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[DefaultMember("Item")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 27496
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	// RVA: 0x86D8514 Offset: 0x86D4514 VA: 0x86D8514
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

// Namespace: UnityEngine
public enum HumanBodyBones // TypeDefIndex: 27497
{
	// Fields
	public int value__; // 0x0
	public const HumanBodyBones Hips = 0;
	public const HumanBodyBones LeftUpperLeg = 1;
	public const HumanBodyBones RightUpperLeg = 2;
	public const HumanBodyBones LeftLowerLeg = 3;
	public const HumanBodyBones RightLowerLeg = 4;
	public const HumanBodyBones LeftFoot = 5;
	public const HumanBodyBones RightFoot = 6;
	public const HumanBodyBones Spine = 7;
	public const HumanBodyBones Chest = 8;
	public const HumanBodyBones UpperChest = 54;
	public const HumanBodyBones Neck = 9;
	public const HumanBodyBones Head = 10;
	public const HumanBodyBones LeftShoulder = 11;
	public const HumanBodyBones RightShoulder = 12;
	public const HumanBodyBones LeftUpperArm = 13;
	public const HumanBodyBones RightUpperArm = 14;
	public const HumanBodyBones LeftLowerArm = 15;
	public const HumanBodyBones RightLowerArm = 16;
	public const HumanBodyBones LeftHand = 17;
	public const HumanBodyBones RightHand = 18;
	public const HumanBodyBones LeftToes = 19;
	public const HumanBodyBones RightToes = 20;
	public const HumanBodyBones LeftEye = 21;
	public const HumanBodyBones RightEye = 22;
	public const HumanBodyBones Jaw = 23;
	public const HumanBodyBones LeftThumbProximal = 24;
	public const HumanBodyBones LeftThumbIntermediate = 25;
	public const HumanBodyBones LeftThumbDistal = 26;
	public const HumanBodyBones LeftIndexProximal = 27;
	public const HumanBodyBones LeftIndexIntermediate = 28;
	public const HumanBodyBones LeftIndexDistal = 29;
	public const HumanBodyBones LeftMiddleProximal = 30;
	public const HumanBodyBones LeftMiddleIntermediate = 31;
	public const HumanBodyBones LeftMiddleDistal = 32;
	public const HumanBodyBones LeftRingProximal = 33;
	public const HumanBodyBones LeftRingIntermediate = 34;
	public const HumanBodyBones LeftRingDistal = 35;
	public const HumanBodyBones LeftLittleProximal = 36;
	public const HumanBodyBones LeftLittleIntermediate = 37;
	public const HumanBodyBones LeftLittleDistal = 38;
	public const HumanBodyBones RightThumbProximal = 39;
	public const HumanBodyBones RightThumbIntermediate = 40;
	public const HumanBodyBones RightThumbDistal = 41;
	public const HumanBodyBones RightIndexProximal = 42;
	public const HumanBodyBones RightIndexIntermediate = 43;
	public const HumanBodyBones RightIndexDistal = 44;
	public const HumanBodyBones RightMiddleProximal = 45;
	public const HumanBodyBones RightMiddleIntermediate = 46;
	public const HumanBodyBones RightMiddleDistal = 47;
	public const HumanBodyBones RightRingProximal = 48;
	public const HumanBodyBones RightRingIntermediate = 49;
	public const HumanBodyBones RightRingDistal = 50;
	public const HumanBodyBones RightLittleProximal = 51;
	public const HumanBodyBones RightLittleIntermediate = 52;
	public const HumanBodyBones RightLittleDistal = 53;
	public const HumanBodyBones LastBone = 55;
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Avatar.h")]
[UsedByNativeCode]
public class Avatar : Object // TypeDefIndex: 27498
{
	// Properties
	public bool isValid { get; }
	public bool isHuman { get; }
	public HumanDescription humanDescription { get; }

	// Methods

	// RVA: 0x86D85F4 Offset: 0x86D45F4 VA: 0x86D85F4
	private void .ctor() { }

	[NativeMethod("IsValid")]
	// RVA: 0x86D74D8 Offset: 0x86D34D8 VA: 0x86D74D8
	public bool get_isValid() { }

	[NativeMethod("IsHuman")]
	// RVA: 0x86D7514 Offset: 0x86D3514 VA: 0x86D7514
	public bool get_isHuman() { }

	// RVA: 0x86D864C Offset: 0x86D464C VA: 0x86D864C
	public HumanDescription get_humanDescription() { }

	// RVA: 0x86D86FC Offset: 0x86D46FC VA: 0x86D86FC
	internal void SetMuscleMinMax(int muscleId, float min, float max) { }

	// RVA: 0x86D8758 Offset: 0x86D4758 VA: 0x86D8758
	internal void SetParameter(int parameterId, float value) { }

	// RVA: 0x86D87AC Offset: 0x86D47AC VA: 0x86D87AC
	internal float GetAxisLength(int humanId) { }

	// RVA: 0x86D8860 Offset: 0x86D4860 VA: 0x86D8860
	internal Quaternion GetPreRotation(int humanId) { }

	// RVA: 0x86D890C Offset: 0x86D490C VA: 0x86D890C
	internal Quaternion GetPostRotation(int humanId) { }

	// RVA: 0x86D89B8 Offset: 0x86D49B8 VA: 0x86D89B8
	internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	// RVA: 0x86D8ADC Offset: 0x86D4ADC VA: 0x86D8ADC
	internal Quaternion GetZYRoll(int humanId, Vector3 uvw) { }

	// RVA: 0x86D8BBC Offset: 0x86D4BBC VA: 0x86D8BBC
	internal Vector3 GetLimitSign(int humanId) { }

	[NativeMethod("GetAxisLength")]
	// RVA: 0x86D881C Offset: 0x86D481C VA: 0x86D881C
	internal float Internal_GetAxisLength(int humanId) { }

	[NativeMethod("GetPreRotation")]
	// RVA: 0x86D88AC Offset: 0x86D48AC VA: 0x86D88AC
	internal Quaternion Internal_GetPreRotation(int humanId) { }

	[NativeMethod("GetPostRotation")]
	// RVA: 0x86D8958 Offset: 0x86D4958 VA: 0x86D8958
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	[NativeMethod("GetZYPostQ")]
	// RVA: 0x86D8A64 Offset: 0x86D4A64 VA: 0x86D8A64
	internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	[NativeMethod("GetZYRoll")]
	// RVA: 0x86D8B50 Offset: 0x86D4B50 VA: 0x86D8B50
	internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) { }

	[NativeMethod("GetLimitSign")]
	// RVA: 0x86D8C08 Offset: 0x86D4C08 VA: 0x86D8C08
	internal Vector3 Internal_GetLimitSign(int humanId) { }

	// RVA: 0x86D86B8 Offset: 0x86D46B8 VA: 0x86D86B8
	private void get_humanDescription_Injected(out HumanDescription ret) { }

	// RVA: 0x86D8C6C Offset: 0x86D4C6C VA: 0x86D8C6C
	private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x86D8CC0 Offset: 0x86D4CC0 VA: 0x86D8CC0
	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x86D8D14 Offset: 0x86D4D14 VA: 0x86D8D14
	private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) { }

	// RVA: 0x86D8D80 Offset: 0x86D4D80 VA: 0x86D8D80
	private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) { }

	// RVA: 0x86D8DDC Offset: 0x86D4DDC VA: 0x86D8DDC
	private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanDescription.h")]
[RequiredByNativeCode]
[NativeType(1, "MonoSkeletonBone")]
public struct SkeletonBone // TypeDefIndex: 27499
{
	// Fields
	[NativeName("m_Name")]
	public string name; // 0x0
	[NativeName("m_ParentName")]
	internal string parentName; // 0x8
	[NativeName("m_Position")]
	public Vector3 position; // 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; // 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; // 0x2C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeType(1, "MonoHumanLimit")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanLimit // TypeDefIndex: 27500
{
	// Fields
	private Vector3 m_Min; // 0x0
	private Vector3 m_Max; // 0xC
	private Vector3 m_Center; // 0x18
	private float m_AxisLength; // 0x24
	private int m_UseDefaultValues; // 0x28
}

// Namespace: UnityEngine
[NativeType(1, "MonoHumanBone")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[RequiredByNativeCode]
public struct HumanBone // TypeDefIndex: 27501
{
	// Fields
	private string m_BoneName; // 0x0
	private string m_HumanName; // 0x8
	[NativeName("m_Limit")]
	public HumanLimit limit; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanDescription // TypeDefIndex: 27502
{
	// Fields
	[NativeName("m_Human")]
	public HumanBone[] human; // 0x0
	[NativeName("m_Skeleton")]
	public SkeletonBone[] skeleton; // 0x8
	internal float m_ArmTwist; // 0x10
	internal float m_ForeArmTwist; // 0x14
	internal float m_UpperLegTwist; // 0x18
	internal float m_LegTwist; // 0x1C
	internal float m_ArmStretch; // 0x20
	internal float m_LegStretch; // 0x24
	internal float m_FeetSpacing; // 0x28
	internal float m_GlobalScale; // 0x2C
	internal string m_RootMotionBoneName; // 0x30
	internal bool m_HasTranslationDoF; // 0x38
	internal bool m_HasExtraRoot; // 0x39
	internal bool m_SkeletonHasParents; // 0x3A
}

// Namespace: UnityEngine
[MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
public enum AvatarMaskBodyPart // TypeDefIndex: 27503
{
	// Fields
	public int value__; // 0x0
	public const AvatarMaskBodyPart Root = 0;
	public const AvatarMaskBodyPart Body = 1;
	public const AvatarMaskBodyPart Head = 2;
	public const AvatarMaskBodyPart LeftLeg = 3;
	public const AvatarMaskBodyPart RightLeg = 4;
	public const AvatarMaskBodyPart LeftArm = 5;
	public const AvatarMaskBodyPart RightArm = 6;
	public const AvatarMaskBodyPart LeftFingers = 7;
	public const AvatarMaskBodyPart RightFingers = 8;
	public const AvatarMaskBodyPart LeftFootIK = 9;
	public const AvatarMaskBodyPart RightFootIK = 10;
	public const AvatarMaskBodyPart LeftHandIK = 11;
	public const AvatarMaskBodyPart RightHandIK = 12;
	public const AvatarMaskBodyPart LastBodyPart = 13;
}

// Namespace: UnityEngine
[MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AvatarMask.h")]
public sealed class AvatarMask : Object // TypeDefIndex: 27504
{
	// Properties
	public int transformCount { get; }

	// Methods

	// RVA: 0x86D8E30 Offset: 0x86D4E30 VA: 0x86D8E30
	public void .ctor() { }

	[FreeFunction("AnimationBindings::CreateAvatarMask")]
	// RVA: 0x86D8EB0 Offset: 0x86D4EB0 VA: 0x86D8EB0
	private static void Internal_Create(AvatarMask self) { }

	[NativeMethod("GetBodyPart")]
	// RVA: 0x86D8EEC Offset: 0x86D4EEC VA: 0x86D8EEC
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	// RVA: 0x86D8F30 Offset: 0x86D4F30 VA: 0x86D8F30
	public int get_transformCount() { }

	// RVA: 0x86D8F6C Offset: 0x86D4F6C VA: 0x86D8F6C
	public string GetTransformPath(int index) { }

	// RVA: 0x86D8FB0 Offset: 0x86D4FB0 VA: 0x86D8FB0
	private float GetTransformWeight(int index) { }

	// RVA: 0x86D8FF4 Offset: 0x86D4FF4 VA: 0x86D8FF4
	public bool GetTransformActive(int index) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanTrait.h")]
public class HumanTrait // TypeDefIndex: 27505
{
	// Methods

	// RVA: 0x86D5538 Offset: 0x86D1538 VA: 0x86D5538
	internal static int GetBoneIndexFromMono(int humanId) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : Object // TypeDefIndex: 27506
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Properties
	public bool isLooping { get; }

	// Methods

	// RVA: 0x86D2320 Offset: 0x86CE320 VA: 0x86D2320
	protected void .ctor() { }

	[NativeMethod("IsLooping")]
	// RVA: 0x86D9048 Offset: 0x86D5048 VA: 0x86D9048
	public bool get_isLooping() { }
}

// Namespace: UnityEngine
[ExcludeFromObjectFactory]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
public class RuntimeAnimatorController : Object // TypeDefIndex: 27507
{
	// Properties
	public AnimationClip[] animationClips { get; }

	// Methods

	// RVA: 0x86D9084 Offset: 0x86D5084 VA: 0x86D9084
	protected void .ctor() { }

	// RVA: 0x86D90DC Offset: 0x86D50DC VA: 0x86D90DC
	public AnimationClip[] get_animationClips() { }
}

// Namespace: UnityEngine.Animations
public static class AnimationPlayableBinding // TypeDefIndex: 27508
{
	// Methods

	// RVA: 0x86D9118 Offset: 0x86D5118 VA: 0x86D9118
	public static PlayableBinding Create(string name, Object key) { }

	// RVA: 0x86D9244 Offset: 0x86D5244 VA: 0x86D9244
	private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name) { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(256)]
public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 27509
{}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(260)]
public class NotKeyableAttribute : Attribute // TypeDefIndex: 27510
{}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[StaticAccessor("AnimationClipPlayableBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[RequiredByNativeCode]
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 27511
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x86D935C Offset: 0x86D535C VA: 0x86D935C
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x86D9394 Offset: 0x86D5394 VA: 0x86D9394
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x86D9440 Offset: 0x86D5440 VA: 0x86D9440
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86D958C Offset: 0x86D558C VA: 0x86D958C Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86D9598 Offset: 0x86D5598 VA: 0x86D9598
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	// RVA: 0x86D95C8 Offset: 0x86D55C8 VA: 0x86D95C8 Slot: 5
	public bool Equals(AnimationClipPlayable other) { }

	// RVA: 0x86D9640 Offset: 0x86D5640 VA: 0x86D9640
	public void SetApplyFootIK(bool value) { }

	// RVA: 0x86D96C8 Offset: 0x86D56C8 VA: 0x86D96C8
	internal void SetRemoveStartOffset(bool value) { }

	// RVA: 0x86D9750 Offset: 0x86D5750 VA: 0x86D9750
	internal void SetOverrideLoopTime(bool value) { }

	// RVA: 0x86D97D8 Offset: 0x86D57D8 VA: 0x86D97D8
	internal void SetLoopTime(bool value) { }

	[NativeThrows]
	// RVA: 0x86D9530 Offset: 0x86D5530 VA: 0x86D9530
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x86D9684 Offset: 0x86D5684 VA: 0x86D9684
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x86D970C Offset: 0x86D570C VA: 0x86D970C
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x86D9794 Offset: 0x86D5794 VA: 0x86D9794
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x86D981C Offset: 0x86D581C VA: 0x86D981C
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x86D9860 Offset: 0x86D5860 VA: 0x86D9860
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
public struct AnimationHumanStream // TypeDefIndex: 27512
{
	// Fields
	private IntPtr stream; // 0x0
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 27513
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86D98B4 Offset: 0x86D58B4 VA: 0x86D98B4
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) { }

	// RVA: 0x86D995C Offset: 0x86D595C VA: 0x86D995C
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x86D9A48 Offset: 0x86D5A48 VA: 0x86D9A48
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x86D9C64 Offset: 0x86D5C64 VA: 0x86D9C64 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86D9C70 Offset: 0x86D5C70 VA: 0x86D9C70
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	// RVA: 0x86D9CF0 Offset: 0x86D5CF0 VA: 0x86D9CF0 Slot: 5
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x86D9D8C Offset: 0x86D5D8C VA: 0x86D9D8C
	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[NativeThrows]
	// RVA: 0x86D9B94 Offset: 0x86D5B94 VA: 0x86D9B94
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x86D9C20 Offset: 0x86D5C20 VA: 0x86D9C20
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x86D9FA0 Offset: 0x86D5FA0 VA: 0x86D9FA0
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	// RVA: 0x86DA038 Offset: 0x86D6038 VA: 0x86DA038
	private static void .cctor() { }

	// RVA: 0x86D9FF4 Offset: 0x86D5FF4 VA: 0x86D9FF4
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationMixerPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 27514
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	[Obsolete("normalizeWeights is obsolete. It has no effect and will be removed.")]
	// RVA: 0x86DA0D8 Offset: 0x86D60D8 VA: 0x86DA0D8
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights) { }

	// RVA: 0x86DA144 Offset: 0x86D6144 VA: 0x86DA144
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x86DA1DC Offset: 0x86D61DC VA: 0x86DA1DC
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x86DA2C8 Offset: 0x86D62C8 VA: 0x86DA2C8
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DA444 Offset: 0x86D6444 VA: 0x86DA444 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DA450 Offset: 0x86D6450 VA: 0x86DA450
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

	// RVA: 0x86DA4D0 Offset: 0x86D64D0 VA: 0x86DA4D0 Slot: 5
	public bool Equals(AnimationMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x86DA3B8 Offset: 0x86D63B8 VA: 0x86DA3B8
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x86DA5B0 Offset: 0x86D65B0 VA: 0x86DA5B0
	private static void .cctor() { }

	// RVA: 0x86DA56C Offset: 0x86D656C VA: 0x86DA56C
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 27515
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DA64C Offset: 0x86D664C VA: 0x86DA64C
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	// RVA: 0x86DA6DC Offset: 0x86D66DC VA: 0x86DA6DC
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	// RVA: 0x86DA7C4 Offset: 0x86D67C4 VA: 0x86DA7C4
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DA940 Offset: 0x86D6940 VA: 0x86DA940 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DA94C Offset: 0x86D694C VA: 0x86DA94C
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	// RVA: 0x86DA9CC Offset: 0x86D69CC VA: 0x86DA9CC Slot: 5
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x86DAA68 Offset: 0x86D6A68 VA: 0x86DAA68
	public void SetAbsoluteMotion(bool value) { }

	[NativeThrows]
	// RVA: 0x86DA8B4 Offset: 0x86D68B4 VA: 0x86DA8B4
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x86DAAEC Offset: 0x86D6AEC VA: 0x86DAAEC
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x86DAB74 Offset: 0x86D6B74 VA: 0x86DAB74
	private static void .cctor() { }

	// RVA: 0x86DAB30 Offset: 0x86D6B30 VA: 0x86DAB30
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", 2)]
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 27516
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DAC10 Offset: 0x86D6C10 VA: 0x86DAC10
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x86DAD00 Offset: 0x86D6D00 VA: 0x86DAD00
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x86DAE44 Offset: 0x86D6E44 VA: 0x86DAE44
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DAFD8 Offset: 0x86D6FD8 VA: 0x86DAFD8 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DAFE4 Offset: 0x86D6FE4 VA: 0x86DAFE4
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

	// RVA: 0x86DB064 Offset: 0x86D7064 VA: 0x86DB064 Slot: 5
	public bool Equals(AnimationOffsetPlayable other) { }

	[NativeThrows]
	// RVA: 0x86DAF34 Offset: 0x86D6F34 VA: 0x86DAF34
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	// RVA: 0x86DB174 Offset: 0x86D7174 VA: 0x86DB174
	private static void .cctor() { }

	// RVA: 0x86DB118 Offset: 0x86D7118 VA: 0x86DB118
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
[NativeHeader("Modules/Animation/AnimationClip.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[Extension]
public static class AnimationPlayableExtensions // TypeDefIndex: 27517
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void SetAnimatedProperties<U>(U playable, AnimationClip clip) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475F8C8 Offset: 0x475B8C8 VA: 0x475F8C8
	|-AnimationPlayableExtensions.SetAnimatedProperties<Playable>
	|
	|-RVA: 0x475F954 Offset: 0x475B954 VA: 0x475F954
	|-AnimationPlayableExtensions.SetAnimatedProperties<__Il2CppFullySharedGenericStructType>
	*/

	[NativeThrows]
	// RVA: 0x86DB210 Offset: 0x86D7210 VA: 0x86DB210
	internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableGraphExtensions.bindings.h")]
[StaticAccessor("AnimationPlayableGraphExtensionsBindings", 2)]
[Extension]
internal static class AnimationPlayableGraphExtensions // TypeDefIndex: 27518
{
	// Methods

	[NativeThrows]
	// RVA: 0x86DB254 Offset: 0x86D7254 VA: 0x86DB254
	internal static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }
}

// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationPlayableOutputBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 27519
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AnimationPlayableOutput Null { get; }

	// Methods

	// RVA: 0x86D9284 Offset: 0x86D5284 VA: 0x86D9284
	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	// RVA: 0x86DB324 Offset: 0x86D7324 VA: 0x86DB324
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x86DB2A8 Offset: 0x86D72A8 VA: 0x86DB2A8
	public static AnimationPlayableOutput get_Null() { }

	// RVA: 0x86DB458 Offset: 0x86D7458 VA: 0x86DB458 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x86D932C Offset: 0x86D532C VA: 0x86D932C
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	// RVA: 0x86DB464 Offset: 0x86D7464 VA: 0x86DB464
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x86DB414 Offset: 0x86D7414 VA: 0x86DB414
	public void SetTarget(Animator value) { }

	[NativeThrows]
	// RVA: 0x86DB4E8 Offset: 0x86D74E8 VA: 0x86DB4E8
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable> // TypeDefIndex: 27520
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DB52C Offset: 0x86D752C VA: 0x86DB52C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DB61C Offset: 0x86D761C VA: 0x86DB61C Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DB628 Offset: 0x86D7628 VA: 0x86DB628 Slot: 5
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x86DB6DC Offset: 0x86D76DC VA: 0x86DB6DC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 27521
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DB778 Offset: 0x86D7778 VA: 0x86DB778
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x86DB810 Offset: 0x86D7810 VA: 0x86DB810
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	// RVA: 0x86DB8FC Offset: 0x86D78FC VA: 0x86DB8FC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DBA78 Offset: 0x86D7A78 VA: 0x86DBA78 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DBA84 Offset: 0x86D7A84 VA: 0x86DBA84
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

	// RVA: 0x86DBB04 Offset: 0x86D7B04 VA: 0x86DBB04 Slot: 5
	public bool Equals(AnimationRemoveScalePlayable other) { }

	[NativeThrows]
	// RVA: 0x86DB9EC Offset: 0x86D79EC VA: 0x86DB9EC
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x86DBBFC Offset: 0x86D7BFC VA: 0x86DBBFC
	private static void .cctor() { }

	// RVA: 0x86DBBB8 Offset: 0x86D7BB8 VA: 0x86DBBB8
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 27522
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DBC98 Offset: 0x86D7C98 VA: 0x86DBC98
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DBD88 Offset: 0x86D7D88 VA: 0x86DBD88 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DBD94 Offset: 0x86D7D94 VA: 0x86DBD94 Slot: 5
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x86DBE30 Offset: 0x86D7E30 VA: 0x86DBE30
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
public struct AnimationStream // TypeDefIndex: 27523
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 27524
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x86DBECC Offset: 0x86D7ECC VA: 0x86DBECC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x86DC0AC Offset: 0x86D80AC VA: 0x86DC0AC Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86DBF68 Offset: 0x86D7F68 VA: 0x86DBF68
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x86DC0B8 Offset: 0x86D80B8 VA: 0x86DC0B8 Slot: 5
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x86DC154 Offset: 0x86D8154 VA: 0x86DC154
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[Flags]
[NativeType("Modules/Animation/Constraints/ConstraintEnums.h")]
public enum Axis // TypeDefIndex: 27525
{
	// Fields
	public int value__; // 0x0
	public const Axis None = 0;
	public const Axis X = 1;
	public const Axis Y = 2;
	public const Axis Z = 4;
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
[UsedByNativeCode]
[NativeType(CodegenOptions = 1, Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource")]
[Serializable]
public struct ConstraintSource // TypeDefIndex: 27526
{
	// Fields
	[NativeName("sourceTransform")]
	private Transform m_SourceTransform; // 0x0
	[NativeName("weight")]
	private float m_Weight; // 0x8
}

// Namespace: UnityEngine.Animations
public interface IConstraint // TypeDefIndex: 27527
{}

// Namespace: UnityEngine.Animations
internal interface IConstraintInternal // TypeDefIndex: 27528
{}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/Constraints/ScaleConstraint.h")]
public sealed class ScaleConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 27529
{
	// Properties
	public float weight { get; set; }
	public Vector3 scaleAtRest { get; set; }
	public Vector3 scaleOffset { get; set; }
	public Axis scalingAxis { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }

	// Methods

	// RVA: 0x86DC1F0 Offset: 0x86D81F0 VA: 0x86DC1F0
	private void .ctor() { }

	// RVA: 0x86DC234 Offset: 0x86D8234 VA: 0x86DC234
	private static void Internal_Create(ScaleConstraint self) { }

	// RVA: 0x86DC270 Offset: 0x86D8270 VA: 0x86DC270 Slot: 4
	public float get_weight() { }

	// RVA: 0x86DC2AC Offset: 0x86D82AC VA: 0x86DC2AC Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x86DC2F8 Offset: 0x86D82F8 VA: 0x86DC2F8
	public Vector3 get_scaleAtRest() { }

	// RVA: 0x86DC398 Offset: 0x86D8398 VA: 0x86DC398
	public void set_scaleAtRest(Vector3 value) { }

	// RVA: 0x86DC430 Offset: 0x86D8430 VA: 0x86DC430
	public Vector3 get_scaleOffset() { }

	// RVA: 0x86DC4D0 Offset: 0x86D84D0 VA: 0x86DC4D0
	public void set_scaleOffset(Vector3 value) { }

	// RVA: 0x86DC568 Offset: 0x86D8568 VA: 0x86DC568
	public Axis get_scalingAxis() { }

	// RVA: 0x86DC5A4 Offset: 0x86D85A4 VA: 0x86DC5A4
	public void set_scalingAxis(Axis value) { }

	// RVA: 0x86DC5E8 Offset: 0x86D85E8 VA: 0x86DC5E8 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x86DC624 Offset: 0x86D8624 VA: 0x86DC624 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x86DC668 Offset: 0x86D8668 VA: 0x86DC668 Slot: 8
	public bool get_locked() { }

	// RVA: 0x86DC6A4 Offset: 0x86D86A4 VA: 0x86DC6A4 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x86DC6E8 Offset: 0x86D86E8 VA: 0x86DC6E8 Slot: 10
	public int get_sourceCount() { }

	[FreeFunction("ConstraintBindings::GetSourceCount")]
	// RVA: 0x86DC724 Offset: 0x86D8724 VA: 0x86DC724
	private static int GetSourceCountInternal(ScaleConstraint self) { }

	[FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = True)]
	// RVA: 0x86DC760 Offset: 0x86D8760 VA: 0x86DC760 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x86DC7A4 Offset: 0x86D87A4 VA: 0x86DC7A4 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunction("ConstraintBindings::SetSources", ThrowsException = True)]
	// RVA: 0x86DC834 Offset: 0x86D8834 VA: 0x86DC834
	private static void SetSourcesInternal(ScaleConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x86DC878 Offset: 0x86D8878 VA: 0x86DC878 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x86DC90C Offset: 0x86D890C VA: 0x86DC90C Slot: 14
	public void RemoveSource(int index) { }

	[NativeName("RemoveSource")]
	// RVA: 0x86DCAC8 Offset: 0x86D8AC8 VA: 0x86DCAC8
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x86DCB0C Offset: 0x86D8B0C VA: 0x86DCB0C Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeName("GetSource")]
	// RVA: 0x86DCB34 Offset: 0x86D8B34 VA: 0x86DCB34
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x86DCBE4 Offset: 0x86D8BE4 VA: 0x86DCBE4 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeName("SetSource")]
	// RVA: 0x86DCC24 Offset: 0x86D8C24 VA: 0x86DCC24
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x86DC954 Offset: 0x86D8954 VA: 0x86DC954
	private void ValidateSourceIndex(int index) { }

	// RVA: 0x86DC354 Offset: 0x86D8354 VA: 0x86DC354
	private void get_scaleAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x86DC3EC Offset: 0x86D83EC VA: 0x86DC3EC
	private void set_scaleAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x86DC48C Offset: 0x86D848C VA: 0x86DC48C
	private void get_scaleOffset_Injected(out Vector3 ret) { }

	// RVA: 0x86DC524 Offset: 0x86D8524 VA: 0x86DC524
	private void set_scaleOffset_Injected(ref Vector3 value) { }

	// RVA: 0x86DC8C8 Offset: 0x86D88C8 VA: 0x86DC8C8 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x86DCB90 Offset: 0x86D8B90 VA: 0x86DCB90
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x86DCC7C Offset: 0x86D8C7C VA: 0x86DCC7C
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

