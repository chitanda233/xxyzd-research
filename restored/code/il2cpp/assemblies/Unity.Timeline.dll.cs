// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27396
{}

// Namespace: 
private struct AnimationOutputWeightProcessor.WeightInfo // TypeDefIndex: 27397
{
	// Fields
	public Playable mixer; // 0x0
	public Playable parentMixer; // 0x10
	public int port; // 0x20
}

// Namespace: UnityEngine.Timeline
internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 27398
{
	// Fields
	private AnimationPlayableOutput m_Output; // 0x10
	private readonly List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers; // 0x20

	// Methods

	// RVA: 0x86A4BF8 Offset: 0x86A0BF8 VA: 0x86A4BF8
	public void .ctor(AnimationPlayableOutput output) { }

	// RVA: 0x86A4CC4 Offset: 0x86A0CC4 VA: 0x86A4CC4
	private void FindMixers() { }

	// RVA: 0x86A4DAC Offset: 0x86A0DAC VA: 0x86A4DAC
	private void FindMixers(Playable parent, int port, Playable node) { }

	// RVA: 0x86A50A0 Offset: 0x86A10A0 VA: 0x86A50A0 Slot: 4
	public void Evaluate() { }
}

// Namespace: 
public enum AnimationPlayableAsset.LoopMode // TypeDefIndex: 27399
{
	// Fields
	public int value__; // 0x0
	[Tooltip("Use the loop time setting from the source AnimationClip.")]
	public const AnimationPlayableAsset.LoopMode UseSourceAsset = 0;
	[Tooltip("The source AnimationClip loops during playback.")]
	public const AnimationPlayableAsset.LoopMode On = 1;
	[Tooltip("The source AnimationClip does not loop during playback.")]
	public const AnimationPlayableAsset.LoopMode Off = 2;
}

// Namespace: 
private static class AnimationPlayableAsset.AnimationPlayableAssetUpgrade // TypeDefIndex: 27400
{
	// Methods

	// RVA: 0x86A618C Offset: 0x86A218C VA: 0x86A618C
	public static void ConvertRotationToEuler(AnimationPlayableAsset asset) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationPlayableAsset.<get_outputs>d__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 27401
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public AnimationPlayableAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86A592C Offset: 0x86A192C VA: 0x86A592C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x86A6328 Offset: 0x86A2328 VA: 0x86A6328 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x86A632C Offset: 0x86A232C VA: 0x86A632C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86A63C8 Offset: 0x86A23C8 VA: 0x86A63C8 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86A63D8 Offset: 0x86A23D8 VA: 0x86A63D8 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x86A6410 Offset: 0x86A2410 VA: 0x86A6410 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86A6470 Offset: 0x86A2470 VA: 0x86A6470 Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x86A6514 Offset: 0x86A2514 VA: 0x86A6514 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.Timeline
[NotKeyable]
[Serializable]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver // TypeDefIndex: 27402
{
	// Fields
	[SerializeField]
	private AnimationClip m_Clip; // 0x18
	[SerializeField]
	private Vector3 m_Position; // 0x20
	[SerializeField]
	private Vector3 m_EulerAngles; // 0x2C
	[SerializeField]
	private bool m_UseTrackMatchFields; // 0x38
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; // 0x3C
	[SerializeField]
	private bool m_RemoveStartOffset; // 0x40
	[SerializeField]
	private bool m_ApplyFootIK; // 0x41
	[SerializeField]
	private AnimationPlayableAsset.LoopMode m_Loop; // 0x44
	[CompilerGenerated]
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; // 0x48
	private static readonly int k_LatestVersion; // 0x0
	[SerializeField]
	[HideInInspector]
	private int m_Version; // 0x4C
	[Obsolete("Use m_RotationEuler Instead", False)]
	[HideInInspector]
	[SerializeField]
	private Quaternion m_Rotation; // 0x50

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public bool useTrackMatchFields { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public bool removeStartOffset { get; set; }
	public bool applyFootIK { get; set; }
	public AnimationPlayableAsset.LoopMode loop { get; set; }
	internal bool hasRootTransforms { get; }
	internal AppliedOffsetMode appliedOffsetMode { get; set; }
	public AnimationClip clip { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x86A5390 Offset: 0x86A1390 VA: 0x86A5390
	public Vector3 get_position() { }

	// RVA: 0x86A539C Offset: 0x86A139C VA: 0x86A539C
	public void set_position(Vector3 value) { }

	// RVA: 0x86A53A8 Offset: 0x86A13A8 VA: 0x86A53A8
	public Quaternion get_rotation() { }

	// RVA: 0x86A53CC Offset: 0x86A13CC VA: 0x86A53CC
	public void set_rotation(Quaternion value) { }

	// RVA: 0x86A5408 Offset: 0x86A1408 VA: 0x86A5408
	public Vector3 get_eulerAngles() { }

	// RVA: 0x86A5414 Offset: 0x86A1414 VA: 0x86A5414
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x86A5420 Offset: 0x86A1420 VA: 0x86A5420
	public bool get_useTrackMatchFields() { }

	// RVA: 0x86A5428 Offset: 0x86A1428 VA: 0x86A5428
	public void set_useTrackMatchFields(bool value) { }

	// RVA: 0x86A5434 Offset: 0x86A1434 VA: 0x86A5434
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x86A543C Offset: 0x86A143C VA: 0x86A543C
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x86A5444 Offset: 0x86A1444 VA: 0x86A5444
	public bool get_removeStartOffset() { }

	// RVA: 0x86A544C Offset: 0x86A144C VA: 0x86A544C
	public void set_removeStartOffset(bool value) { }

	// RVA: 0x86A5458 Offset: 0x86A1458 VA: 0x86A5458
	public bool get_applyFootIK() { }

	// RVA: 0x86A5460 Offset: 0x86A1460 VA: 0x86A5460
	public void set_applyFootIK(bool value) { }

	// RVA: 0x86A546C Offset: 0x86A146C VA: 0x86A546C
	public AnimationPlayableAsset.LoopMode get_loop() { }

	// RVA: 0x86A5474 Offset: 0x86A1474 VA: 0x86A5474
	public void set_loop(AnimationPlayableAsset.LoopMode value) { }

	// RVA: 0x86A547C Offset: 0x86A147C VA: 0x86A547C
	internal bool get_hasRootTransforms() { }

	[CompilerGenerated]
	// RVA: 0x86A55EC Offset: 0x86A15EC VA: 0x86A55EC
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	[CompilerGenerated]
	// RVA: 0x86A55F4 Offset: 0x86A15F4 VA: 0x86A55F4
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	// RVA: 0x86A55FC Offset: 0x86A15FC VA: 0x86A55FC
	public AnimationClip get_clip() { }

	// RVA: 0x86A5604 Offset: 0x86A1604 VA: 0x86A5604
	public void set_clip(AnimationClip value) { }

	// RVA: 0x86A56CC Offset: 0x86A16CC VA: 0x86A56CC Slot: 7
	public override double get_duration() { }

	[IteratorStateMachine(typeof(AnimationPlayableAsset.<get_outputs>d__45))]
	// RVA: 0x86A58B0 Offset: 0x86A18B0 VA: 0x86A58B0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86A5960 Offset: 0x86A1960 VA: 0x86A5960 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x86A5A38 Offset: 0x86A1A38 VA: 0x86A5A38
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop) { }

	// RVA: 0x86A5E24 Offset: 0x86A1E24 VA: 0x86A5E24
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	// RVA: 0x86A5DFC Offset: 0x86A1DFC VA: 0x86A5DFC
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	// RVA: 0x86A5E98 Offset: 0x86A1E98 VA: 0x86A5E98 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x86A5F80 Offset: 0x86A1F80 VA: 0x86A5F80
	public void ResetOffsets() { }

	// RVA: 0x86A5FEC Offset: 0x86A1FEC VA: 0x86A5FEC Slot: 10
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x86A5520 Offset: 0x86A1520 VA: 0x86A5520
	internal static bool HasRootTransforms(AnimationClip clip) { }

	// RVA: 0x86A6098 Offset: 0x86A2098 VA: 0x86A6098 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x86A60F8 Offset: 0x86A20F8 VA: 0x86A60F8 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x86A617C Offset: 0x86A217C VA: 0x86A617C
	private void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x86A61D8 Offset: 0x86A21D8 VA: 0x86A61D8
	public void .ctor() { }

	// RVA: 0x86A62DC Offset: 0x86A22DC VA: 0x86A62DC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
[Flags]
public enum MatchTargetFields // TypeDefIndex: 27403
{
	// Fields
	public int value__; // 0x0
	public const MatchTargetFields PositionX = 1;
	public const MatchTargetFields PositionY = 2;
	public const MatchTargetFields PositionZ = 4;
	public const MatchTargetFields RotationX = 8;
	public const MatchTargetFields RotationY = 16;
	public const MatchTargetFields RotationZ = 32;
}

// Namespace: UnityEngine.Timeline
public enum TrackOffset // TypeDefIndex: 27404
{
	// Fields
	public int value__; // 0x0
	public const TrackOffset ApplyTransformOffsets = 0;
	public const TrackOffset ApplySceneOffsets = 1;
	public const TrackOffset Auto = 2;
}

// Namespace: UnityEngine.Timeline
internal enum AppliedOffsetMode // TypeDefIndex: 27405
{
	// Fields
	public int value__; // 0x0
	public const AppliedOffsetMode NoRootTransform = 0;
	public const AppliedOffsetMode TransformOffset = 1;
	public const AppliedOffsetMode SceneOffset = 2;
	public const AppliedOffsetMode TransformOffsetLegacy = 3;
	public const AppliedOffsetMode SceneOffsetLegacy = 4;
	public const AppliedOffsetMode SceneOffsetEditor = 5;
	public const AppliedOffsetMode SceneOffsetLegacyEditor = 6;
}

// Namespace: UnityEngine.Timeline
[Extension]
internal static class MatchTargetFieldConstants // TypeDefIndex: 27406
{
	// Fields
	public static MatchTargetFields All; // 0x0
	public static MatchTargetFields None; // 0x4
	public static MatchTargetFields Position; // 0x8
	public static MatchTargetFields Rotation; // 0xC

	// Methods

	// RVA: 0x86A6518 Offset: 0x86A2518 VA: 0x86A6518
	private static void .cctor() { }
}

// Namespace: 
private static class AnimationTrack.AnimationTrackUpgrade // TypeDefIndex: 27407
{
	// Methods

	// RVA: 0x86AA6F4 Offset: 0x86A66F4 VA: 0x86AA6F4
	public static void ConvertRotationsToEuler(AnimationTrack track) { }

	// RVA: 0x86AA790 Offset: 0x86A6790 VA: 0x86AA790
	public static void ConvertRootMotion(AnimationTrack track) { }

	// RVA: 0x86AA814 Offset: 0x86A6814 VA: 0x86AA814
	public static void ConvertInfiniteTrack(AnimationTrack track) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTrack.<get_outputs>d__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 27408
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public AnimationTrack <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86A6814 Offset: 0x86A2814 VA: 0x86A6814
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x86AAB64 Offset: 0x86A6B64 VA: 0x86AAB64 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x86AAB68 Offset: 0x86A6B68 VA: 0x86AAB68 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86AAC04 Offset: 0x86A6C04 VA: 0x86AAC04 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86AAC14 Offset: 0x86A6C14 VA: 0x86AAC14 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x86AAC4C Offset: 0x86A6C4C VA: 0x86AAC4C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86AACAC Offset: 0x86A6CAC VA: 0x86AACAC Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x86AAD50 Offset: 0x86A6D50 VA: 0x86AAD50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.Timeline
[TrackBindingType(typeof(Animator))]
[ExcludeFromPreset]
[TrackClipType(typeof(AnimationPlayableAsset), False)]
[Serializable]
public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 27409
{
	// Fields
	private const string k_DefaultInfiniteClipName = "Recorded";
	private const string k_DefaultRecordableClipName = "Recorded";
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xA0
	[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xA4
	[FormerlySerializedAs("m_OpenClipOffsetPosition")]
	[SerializeField]
	private Vector3 m_InfiniteClipOffsetPosition; // 0xA8
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
	private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
	[FormerlySerializedAs("m_OpenClipTimeOffset")]
	[SerializeField]
	private double m_InfiniteClipTimeOffset; // 0xC0
	[FormerlySerializedAs("m_OpenClipRemoveOffset")]
	[SerializeField]
	private bool m_InfiniteClipRemoveOffset; // 0xC8
	[SerializeField]
	private bool m_InfiniteClipApplyFootIK; // 0xC9
	[SerializeField]
	[HideInInspector]
	private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xCC
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; // 0xD0
	[SerializeField]
	private Vector3 m_Position; // 0xD4
	[SerializeField]
	private Vector3 m_EulerAngles; // 0xE0
	[SerializeField]
	private AvatarMask m_AvatarMask; // 0xF0
	[SerializeField]
	private bool m_ApplyAvatarMask; // 0xF8
	[SerializeField]
	private TrackOffset m_TrackOffset; // 0xFC
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_InfiniteClip; // 0x100
	private static readonly Queue<Transform> s_CachedQueue; // 0x0
	[SerializeField]
	[HideInInspector]
	[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", False)]
	private Quaternion m_OpenClipOffsetRotation; // 0x108
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	private Quaternion m_Rotation; // 0x118
	[SerializeField]
	[HideInInspector]
	[Obsolete("Use m_RootTransformOffsetMode", False)]
	private bool m_ApplyOffsets; // 0x128

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	[Obsolete("applyOffset is deprecated. Use trackOffset instead", True)]
	public bool applyOffsets { get; set; }
	public TrackOffset trackOffset { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public AnimationClip infiniteClip { get; set; }
	internal bool infiniteClipRemoveOffset { get; set; }
	public AvatarMask avatarMask { get; set; }
	public bool applyAvatarMask { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public bool inClipMode { get; }
	public Vector3 infiniteClipOffsetPosition { get; set; }
	public Quaternion infiniteClipOffsetRotation { get; set; }
	public Vector3 infiniteClipOffsetEulerAngles { get; set; }
	internal bool infiniteClipApplyFootIK { get; set; }
	internal double infiniteClipTimeOffset { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
	internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; }
	[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", True)]
	[EditorBrowsable(1)]
	public Vector3 openClipOffsetPosition { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", True)]
	public Quaternion openClipOffsetRotation { get; set; }
	[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", True)]
	[EditorBrowsable(1)]
	public Vector3 openClipOffsetEulerAngles { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", True)]
	public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", True)]
	public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; }

	// Methods

	// RVA: 0x86A6568 Offset: 0x86A2568 VA: 0x86A6568
	public Vector3 get_position() { }

	// RVA: 0x86A6574 Offset: 0x86A2574 VA: 0x86A6574
	public void set_position(Vector3 value) { }

	// RVA: 0x86A6580 Offset: 0x86A2580 VA: 0x86A6580
	public Quaternion get_rotation() { }

	// RVA: 0x86A65A4 Offset: 0x86A25A4 VA: 0x86A65A4
	public void set_rotation(Quaternion value) { }

	// RVA: 0x86A65E0 Offset: 0x86A25E0 VA: 0x86A65E0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x86A65EC Offset: 0x86A25EC VA: 0x86A65EC
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x86A65F8 Offset: 0x86A25F8 VA: 0x86A65F8
	public bool get_applyOffsets() { }

	// RVA: 0x86A6600 Offset: 0x86A2600 VA: 0x86A6600
	public void set_applyOffsets(bool value) { }

	// RVA: 0x86A6604 Offset: 0x86A2604 VA: 0x86A6604
	public TrackOffset get_trackOffset() { }

	// RVA: 0x86A660C Offset: 0x86A260C VA: 0x86A660C
	public void set_trackOffset(TrackOffset value) { }

	// RVA: 0x86A6614 Offset: 0x86A2614 VA: 0x86A6614
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x86A661C Offset: 0x86A261C VA: 0x86A661C
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x86A668C Offset: 0x86A268C VA: 0x86A668C
	public AnimationClip get_infiniteClip() { }

	// RVA: 0x86A6694 Offset: 0x86A2694 VA: 0x86A6694
	internal void set_infiniteClip(AnimationClip value) { }

	// RVA: 0x86A66A4 Offset: 0x86A26A4 VA: 0x86A66A4
	internal bool get_infiniteClipRemoveOffset() { }

	// RVA: 0x86A66AC Offset: 0x86A26AC VA: 0x86A66AC
	internal void set_infiniteClipRemoveOffset(bool value) { }

	// RVA: 0x86A66B8 Offset: 0x86A26B8 VA: 0x86A66B8
	public AvatarMask get_avatarMask() { }

	// RVA: 0x86A66C0 Offset: 0x86A26C0 VA: 0x86A66C0
	public void set_avatarMask(AvatarMask value) { }

	// RVA: 0x86A66C8 Offset: 0x86A26C8 VA: 0x86A66C8
	public bool get_applyAvatarMask() { }

	// RVA: 0x86A66D0 Offset: 0x86A26D0 VA: 0x86A66D0
	public void set_applyAvatarMask(bool value) { }

	// RVA: 0x86A66DC Offset: 0x86A26DC VA: 0x86A66DC Slot: 32
	internal override bool CanCompileClips() { }

	[IteratorStateMachine(typeof(AnimationTrack.<get_outputs>d__49))]
	// RVA: 0x86A6798 Offset: 0x86A2798 VA: 0x86A6798 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86A6848 Offset: 0x86A2848 VA: 0x86A6848
	public bool get_inClipMode() { }

	// RVA: 0x86A694C Offset: 0x86A294C VA: 0x86A694C
	public Vector3 get_infiniteClipOffsetPosition() { }

	// RVA: 0x86A6958 Offset: 0x86A2958 VA: 0x86A6958
	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	// RVA: 0x86A6964 Offset: 0x86A2964 VA: 0x86A6964
	public Quaternion get_infiniteClipOffsetRotation() { }

	// RVA: 0x86A6988 Offset: 0x86A2988 VA: 0x86A6988
	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	// RVA: 0x86A69C4 Offset: 0x86A29C4 VA: 0x86A69C4
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	// RVA: 0x86A69D0 Offset: 0x86A29D0 VA: 0x86A69D0
	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x86A69DC Offset: 0x86A29DC VA: 0x86A69DC
	internal bool get_infiniteClipApplyFootIK() { }

	// RVA: 0x86A69E4 Offset: 0x86A29E4 VA: 0x86A69E4
	internal void set_infiniteClipApplyFootIK(bool value) { }

	// RVA: 0x86A69F0 Offset: 0x86A29F0 VA: 0x86A69F0
	internal double get_infiniteClipTimeOffset() { }

	// RVA: 0x86A69F8 Offset: 0x86A29F8 VA: 0x86A69F8
	internal void set_infiniteClipTimeOffset(double value) { }

	// RVA: 0x86A6A00 Offset: 0x86A2A00 VA: 0x86A6A00
	public TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	// RVA: 0x86A6A08 Offset: 0x86A2A08 VA: 0x86A6A08
	public void set_infiniteClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86A6A10 Offset: 0x86A2A10 VA: 0x86A6A10
	public TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	// RVA: 0x86A6A18 Offset: 0x86A2A18 VA: 0x86A6A18
	public void set_infiniteClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86A6A20 Offset: 0x86A2A20 VA: 0x86A6A20
	internal AnimationPlayableAsset.LoopMode get_infiniteClipLoop() { }

	// RVA: 0x86A6A28 Offset: 0x86A2A28 VA: 0x86A6A28
	internal void set_infiniteClipLoop(AnimationPlayableAsset.LoopMode value) { }

	[ContextMenu("Reset Offsets")]
	// RVA: 0x86A6A30 Offset: 0x86A2A30 VA: 0x86A6A30
	private void ResetOffsets() { }

	// RVA: 0x86A6AA0 Offset: 0x86A2AA0 VA: 0x86A6AA0
	public TimelineClip CreateClip(AnimationClip clip) { }

	// RVA: 0x86A6D7C Offset: 0x86A2D7C VA: 0x86A6D7C
	public void CreateInfiniteClip(string infiniteClipName) { }

	// RVA: 0x86A7048 Offset: 0x86A3048 VA: 0x86A7048
	public TimelineClip CreateRecordableClip(string animClipName) { }

	// RVA: 0x86A7340 Offset: 0x86A3340 VA: 0x86A7340 Slot: 29
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x86A7508 Offset: 0x86A3508 VA: 0x86A7508 Slot: 30
	protected internal override int CalculateItemsHash() { }

	// RVA: 0x86A6A9C Offset: 0x86A2A9C VA: 0x86A6A9C
	internal void UpdateClipOffsets() { }

	// RVA: 0x86A772C Offset: 0x86A372C VA: 0x86A772C
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x86A80F4 Offset: 0x86A40F4 VA: 0x86A80F4 Slot: 35
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x86A8144 Offset: 0x86A4144 VA: 0x86A8144 Slot: 25
	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x86A905C Offset: 0x86A505C VA: 0x86A905C
	private int GetDefaultBlendCount() { }

	// RVA: 0x86A9560 Offset: 0x86A5560 VA: 0x86A9560
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	// RVA: 0x86A957C Offset: 0x86A557C VA: 0x86A957C
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	// RVA: 0x86A9450 Offset: 0x86A5450 VA: 0x86A9450
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	// RVA: 0x86A9564 Offset: 0x86A5564 VA: 0x86A9564
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

	// RVA: 0x86A98B8 Offset: 0x86A58B8 VA: 0x86A98B8
	private bool HasController(GameObject gameObject) { }

	// RVA: 0x86A96D4 Offset: 0x86A56D4 VA: 0x86A96D4
	internal Animator GetBinding(PlayableDirector director) { }

	// RVA: 0x86A9064 Offset: 0x86A5064 VA: 0x86A9064
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x86A90D8 Offset: 0x86A50D8 VA: 0x86A90D8
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x86A7F44 Offset: 0x86A3F44 VA: 0x86A7F44
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	// RVA: 0x86A9A04 Offset: 0x86A5A04 VA: 0x86A9A04 Slot: 26
	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x86A9C90 Offset: 0x86A5C90 VA: 0x86A9C90 Slot: 27
	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x86A6B48 Offset: 0x86A2B48 VA: 0x86A6B48
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	// RVA: 0x86A9EFC Offset: 0x86A5EFC VA: 0x86A9EFC Slot: 28
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x86A9F00 Offset: 0x86A5F00 VA: 0x86A9F00
	private void GetAnimationClips(List<AnimationClip> animClips) { }

	// RVA: 0x86A8F78 Offset: 0x86A4F78 VA: 0x86A8F78
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	// RVA: 0x86A8CFC Offset: 0x86A4CFC VA: 0x86A8CFC
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	// RVA: 0x86A8B14 Offset: 0x86A4B14 VA: 0x86A8B14
	private Transform GetGenericRootNode(GameObject gameObject) { }

	// RVA: 0x86A7B78 Offset: 0x86A3B78 VA: 0x86A7B78
	internal bool AnimatesRootTransform() { }

	// RVA: 0x86AA460 Offset: 0x86A6460 VA: 0x86AA460
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	// RVA: 0x86AA638 Offset: 0x86A6638 VA: 0x86AA638
	public Vector3 get_openClipOffsetPosition() { }

	// RVA: 0x86AA644 Offset: 0x86A6644 VA: 0x86AA644
	public void set_openClipOffsetPosition(Vector3 value) { }

	// RVA: 0x86AA650 Offset: 0x86A6650 VA: 0x86AA650
	public Quaternion get_openClipOffsetRotation() { }

	// RVA: 0x86AA674 Offset: 0x86A6674 VA: 0x86AA674
	public void set_openClipOffsetRotation(Quaternion value) { }

	// RVA: 0x86AA678 Offset: 0x86A6678 VA: 0x86AA678
	public Vector3 get_openClipOffsetEulerAngles() { }

	// RVA: 0x86AA684 Offset: 0x86A6684 VA: 0x86AA684
	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x86AA690 Offset: 0x86A6690 VA: 0x86AA690
	public TimelineClip.ClipExtrapolation get_openClipPreExtrapolation() { }

	// RVA: 0x86AA698 Offset: 0x86A6698 VA: 0x86AA698
	public void set_openClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86AA6A0 Offset: 0x86A66A0 VA: 0x86AA6A0
	public TimelineClip.ClipExtrapolation get_openClipPostExtrapolation() { }

	// RVA: 0x86AA6A8 Offset: 0x86A66A8 VA: 0x86AA6A8
	public void set_openClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86AA6B0 Offset: 0x86A66B0 VA: 0x86AA6B0 Slot: 18
	internal override void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x86AA848 Offset: 0x86A6848 VA: 0x86AA848
	public void .ctor() { }

	// RVA: 0x86AAAC8 Offset: 0x86A6AC8 VA: 0x86AAAC8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
internal interface ICurvesOwner // TypeDefIndex: 27410
{
	// Properties
	public abstract string defaultCurvesName { get; }
	public abstract Object asset { get; }
	public abstract Object assetOwner { get; }
	public abstract TrackAsset targetTrack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_defaultCurvesName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Object get_asset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Object get_assetOwner();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TrackAsset get_targetTrack();
}

// Namespace: 
private static class TimelineClip.TimelineClipUpgrade // TypeDefIndex: 27411
{
	// Methods

	// RVA: 0x86AAD90 Offset: 0x86A6D90 VA: 0x86AAD90
	public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) { }
}

// Namespace: 
public enum TimelineClip.ClipExtrapolation // TypeDefIndex: 27412
{
	// Fields
	public int value__; // 0x0
	public const TimelineClip.ClipExtrapolation None = 0;
	public const TimelineClip.ClipExtrapolation Hold = 1;
	public const TimelineClip.ClipExtrapolation Loop = 2;
	public const TimelineClip.ClipExtrapolation PingPong = 3;
	public const TimelineClip.ClipExtrapolation Continue = 4;
}

// Namespace: 
public enum TimelineClip.BlendCurveMode // TypeDefIndex: 27413
{
	// Fields
	public int value__; // 0x0
	public const TimelineClip.BlendCurveMode Auto = 0;
	public const TimelineClip.BlendCurveMode Manual = 1;
}

// Namespace: UnityEngine.Timeline
[Serializable]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 27414
{
	// Fields
	private const int k_LatestVersion = 1;
	[SerializeField]
	[HideInInspector]
	private int m_Version; // 0x10
	public static readonly ClipCaps kDefaultClipCaps; // 0x0
	public static readonly float kDefaultClipDurationInSeconds; // 0x4
	public static readonly double kTimeScaleMin; // 0x8
	public static readonly double kTimeScaleMax; // 0x10
	internal static readonly string kDefaultCurvesName; // 0x18
	internal static readonly double kMinDuration; // 0x20
	internal static readonly double kMaxTimeValue; // 0x28
	[SerializeField]
	private double m_Start; // 0x18
	[SerializeField]
	private double m_ClipIn; // 0x20
	[SerializeField]
	private Object m_Asset; // 0x28
	[SerializeField]
	[FormerlySerializedAs("m_HackDuration")]
	private double m_Duration; // 0x30
	[SerializeField]
	private double m_TimeScale; // 0x38
	[SerializeField]
	private TrackAsset m_ParentTrack; // 0x40
	[SerializeField]
	private double m_EaseInDuration; // 0x48
	[SerializeField]
	private double m_EaseOutDuration; // 0x50
	[SerializeField]
	private double m_BlendInDuration; // 0x58
	[SerializeField]
	private double m_BlendOutDuration; // 0x60
	[SerializeField]
	private AnimationCurve m_MixInCurve; // 0x68
	[SerializeField]
	private AnimationCurve m_MixOutCurve; // 0x70
	[SerializeField]
	private TimelineClip.BlendCurveMode m_BlendInCurveMode; // 0x78
	[SerializeField]
	private TimelineClip.BlendCurveMode m_BlendOutCurveMode; // 0x7C
	[SerializeField]
	private List<string> m_ExposedParameterNames; // 0x80
	[SerializeField]
	private AnimationClip m_AnimationCurves; // 0x88
	[SerializeField]
	private bool m_Recordable; // 0x90
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_PostExtrapolationMode; // 0x94
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_PreExtrapolationMode; // 0x98
	[SerializeField]
	private double m_PostExtrapolationTime; // 0xA0
	[SerializeField]
	private double m_PreExtrapolationTime; // 0xA8
	[SerializeField]
	private string m_DisplayName; // 0xB0

	// Properties
	public double timeScale { get; }
	public double start { get; set; }
	public double duration { get; set; }
	public double end { get; }
	public double clipIn { get; }
	public string displayName { get; set; }
	public AnimationClip curves { get; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	public Object asset { get; set; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	public double easeInDuration { get; }
	public double easeOutDuration { get; }
	public double blendInDuration { get; }
	public double blendOutDuration { get; }
	public bool hasBlendIn { get; }
	public bool hasBlendOut { get; }
	public AnimationCurve mixInCurve { get; set; }
	public double mixInDuration { get; }
	public AnimationCurve mixOutCurve { get; set; }
	public double mixOutTime { get; }
	public double mixOutDuration { get; }
	public bool recordable { get; set; }
	public ClipCaps clipCaps { get; }
	public TimelineClip.ClipExtrapolation postExtrapolationMode { get; set; }
	public TimelineClip.ClipExtrapolation preExtrapolationMode { get; set; }
	public double extrapolatedStart { get; }
	public double extrapolatedDuration { get; }

	// Methods

	// RVA: 0x86AAD54 Offset: 0x86A6D54 VA: 0x86AAD54
	private void UpgradeToLatestVersion() { }

	// RVA: 0x86AADCC Offset: 0x86A6DCC VA: 0x86AADCC
	internal void .ctor(TrackAsset parent) { }

	// RVA: 0x86AAF10 Offset: 0x86A6F10 VA: 0x86AAF10
	public double get_timeScale() { }

	// RVA: 0x86AB0D8 Offset: 0x86A70D8 VA: 0x86AB0D8
	public double get_start() { }

	// RVA: 0x86A7190 Offset: 0x86A3190 VA: 0x86A7190
	public void set_start(double value) { }

	// RVA: 0x86AB208 Offset: 0x86A7208 VA: 0x86AB208 Slot: 10
	public double get_duration() { }

	// RVA: 0x86A7294 Offset: 0x86A3294 VA: 0x86A7294
	public void set_duration(double value) { }

	// RVA: 0x86AB210 Offset: 0x86A7210 VA: 0x86AB210
	public double get_end() { }

	// RVA: 0x86AB220 Offset: 0x86A7220 VA: 0x86AB220
	public double get_clipIn() { }

	// RVA: 0x86AB240 Offset: 0x86A7240 VA: 0x86AB240
	public string get_displayName() { }

	// RVA: 0x86AB248 Offset: 0x86A7248 VA: 0x86AB248
	public void set_displayName(string value) { }

	// RVA: 0x86AB250 Offset: 0x86A7250 VA: 0x86AB250 Slot: 11
	public AnimationClip get_curves() { }

	// RVA: 0x86AB258 Offset: 0x86A7258 VA: 0x86AB258 Slot: 4
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x86AB2B0 Offset: 0x86A72B0 VA: 0x86AB2B0 Slot: 5
	public Object get_asset() { }

	// RVA: 0x86AB2B8 Offset: 0x86A72B8 VA: 0x86AB2B8
	public void set_asset(Object value) { }

	// RVA: 0x86AB2C0 Offset: 0x86A72C0 VA: 0x86AB2C0 Slot: 6
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x86AB2C8 Offset: 0x86A72C8 VA: 0x86AB2C8 Slot: 7
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x86AB2D0 Offset: 0x86A72D0 VA: 0x86AB2D0
	public TrackAsset GetParentTrack() { }

	// RVA: 0x86AAE08 Offset: 0x86A6E08 VA: 0x86AAE08
	internal void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	// RVA: 0x86AB430 Offset: 0x86A7430 VA: 0x86AB430
	public double get_easeInDuration() { }

	// RVA: 0x86AB518 Offset: 0x86A7518 VA: 0x86AB518
	public double get_easeOutDuration() { }

	// RVA: 0x86AB600 Offset: 0x86A7600 VA: 0x86AB600
	public double get_blendInDuration() { }

	// RVA: 0x86AB620 Offset: 0x86A7620 VA: 0x86AB620
	public double get_blendOutDuration() { }

	// RVA: 0x86AB5D4 Offset: 0x86A75D4 VA: 0x86AB5D4
	public bool get_hasBlendIn() { }

	// RVA: 0x86AB4EC Offset: 0x86A74EC VA: 0x86AB4EC
	public bool get_hasBlendOut() { }

	// RVA: 0x86AB640 Offset: 0x86A7640 VA: 0x86AB640
	public AnimationCurve get_mixInCurve() { }

	// RVA: 0x86AB6EC Offset: 0x86A76EC VA: 0x86AB6EC
	public void set_mixInCurve(AnimationCurve value) { }

	// RVA: 0x86AB6F4 Offset: 0x86A76F4 VA: 0x86AB6F4
	public double get_mixInDuration() { }

	// RVA: 0x86AB738 Offset: 0x86A7738 VA: 0x86AB738
	public AnimationCurve get_mixOutCurve() { }

	// RVA: 0x86AB7E4 Offset: 0x86A77E4 VA: 0x86AB7E4
	public void set_mixOutCurve(AnimationCurve value) { }

	// RVA: 0x86AB7EC Offset: 0x86A77EC VA: 0x86AB7EC
	public double get_mixOutTime() { }

	// RVA: 0x86AB818 Offset: 0x86A7818 VA: 0x86AB818
	public double get_mixOutDuration() { }

	// RVA: 0x86AB85C Offset: 0x86A785C VA: 0x86AB85C
	public bool get_recordable() { }

	// RVA: 0x86AB864 Offset: 0x86A7864 VA: 0x86AB864
	internal void set_recordable(bool value) { }

	// RVA: 0x86AAFE8 Offset: 0x86A6FE8 VA: 0x86AAFE8
	public ClipCaps get_clipCaps() { }

	// RVA: 0x86AB870 Offset: 0x86A7870 VA: 0x86AB870
	internal int Hash() { }

	// RVA: 0x86AB9A4 Offset: 0x86A79A4 VA: 0x86AB9A4
	public float EvaluateMixOut(double time) { }

	// RVA: 0x86ABA98 Offset: 0x86A7A98 VA: 0x86ABA98
	public float EvaluateMixIn(double time) { }

	// RVA: 0x86AB6D4 Offset: 0x86A76D4 VA: 0x86AB6D4
	private static AnimationCurve GetDefaultMixInCurve() { }

	// RVA: 0x86AB7CC Offset: 0x86A77CC VA: 0x86AB7CC
	private static AnimationCurve GetDefaultMixOutCurve() { }

	// RVA: 0x86ABB6C Offset: 0x86A7B6C VA: 0x86ABB6C
	public double ToLocalTime(double time) { }

	// RVA: 0x86AB0E4 Offset: 0x86A70E4 VA: 0x86AB0E4
	private static double SanitizeTimeValue(double value, double defaultValue) { }

	// RVA: 0x86ABE20 Offset: 0x86A7E20 VA: 0x86ABE20
	public TimelineClip.ClipExtrapolation get_postExtrapolationMode() { }

	// RVA: 0x86A74D4 Offset: 0x86A34D4 VA: 0x86A74D4
	internal void set_postExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86ABE44 Offset: 0x86A7E44 VA: 0x86ABE44
	public TimelineClip.ClipExtrapolation get_preExtrapolationMode() { }

	// RVA: 0x86A74A0 Offset: 0x86A34A0 VA: 0x86A74A0
	internal void set_preExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x86ABE68 Offset: 0x86A7E68 VA: 0x86ABE68
	internal void SetPostExtrapolationTime(double time) { }

	// RVA: 0x86ABE70 Offset: 0x86A7E70 VA: 0x86ABE70
	internal void SetPreExtrapolationTime(double time) { }

	// RVA: 0x86ABC5C Offset: 0x86A7C5C VA: 0x86ABC5C
	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x86ABDC8 Offset: 0x86A7DC8 VA: 0x86ABDC8
	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x86ABE78 Offset: 0x86A7E78 VA: 0x86ABE78
	public double get_extrapolatedStart() { }

	// RVA: 0x86ABE90 Offset: 0x86A7E90 VA: 0x86ABE90
	public double get_extrapolatedDuration() { }

	// RVA: 0x86ABCAC Offset: 0x86A7CAC VA: 0x86ABCAC
	private static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration) { }

	// RVA: 0x86ABF5C Offset: 0x86A7F5C VA: 0x86ABF5C Slot: 8
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x86ABF68 Offset: 0x86A7F68 VA: 0x86ABF68 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x86ABFA4 Offset: 0x86A7FA4 VA: 0x86ABFA4 Slot: 3
	public override string ToString() { }

	// RVA: 0x86AB0E0 Offset: 0x86A70E0 VA: 0x86AB0E0
	private void UpdateDirty(double oldValue, double newValue) { }

	// RVA: 0x86AC1BC Offset: 0x86A81BC VA: 0x86AC1BC
	private static void .cctor() { }
}

// Namespace: 
public enum TimelineAsset.DurationMode // TypeDefIndex: 27415
{
	// Fields
	public int value__; // 0x0
	public const TimelineAsset.DurationMode BasedOnClips = 0;
	public const TimelineAsset.DurationMode FixedLength = 1;
}

// Namespace: 
[Serializable]
public class TimelineAsset.EditorSettings // TypeDefIndex: 27416
{
	// Fields
	internal static readonly double kMinFrameRate; // 0x0
	internal static readonly double kMaxFrameRate; // 0x8
	internal static readonly double kDefaultFrameRate; // 0x10
	[SerializeField]
	[HideInInspector]
	[FrameRateField]
	private double m_Framerate; // 0x10
	[SerializeField]
	[HideInInspector]
	private bool m_ScenePreview; // 0x18

	// Properties
	public double frameRate { get; set; }

	// Methods

	// RVA: 0x86B05D0 Offset: 0x86AC5D0 VA: 0x86B05D0
	public double get_frameRate() { }

	// RVA: 0x86AD1A8 Offset: 0x86A91A8 VA: 0x86AD1A8
	public void set_frameRate(double value) { }

	// RVA: 0x86B0560 Offset: 0x86AC560 VA: 0x86B0560
	public void .ctor() { }

	// RVA: 0x86B05D8 Offset: 0x86AC5D8 VA: 0x86B05D8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TimelineAsset.<get_outputs>d__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 27417
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public TimelineAsset <>4__this; // 0x40
	private IEnumerator<TrackAsset> <>7__wrap1; // 0x48
	private IEnumerator<PlayableBinding> <>7__wrap2; // 0x50

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86AC6C0 Offset: 0x86A86C0 VA: 0x86AC6C0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x86B065C Offset: 0x86AC65C VA: 0x86B065C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x86B070C Offset: 0x86AC70C VA: 0x86B070C Slot: 8
	private bool MoveNext() { }

	// RVA: 0x86B0C40 Offset: 0x86ACC40 VA: 0x86B0C40
	private void <>m__Finally1() { }

	// RVA: 0x86B0B90 Offset: 0x86ACB90 VA: 0x86B0B90
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x86B0CF0 Offset: 0x86ACCF0 VA: 0x86B0CF0 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86B0D00 Offset: 0x86ACD00 VA: 0x86B0D00 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x86B0D38 Offset: 0x86ACD38 VA: 0x86B0D38 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86B0D98 Offset: 0x86ACD98 VA: 0x86B0D98 Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x86B0E3C Offset: 0x86ACE3C VA: 0x86B0E3C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.Timeline
[ExcludeFromPreset]
[Serializable]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 27418
{
	// Fields
	private const int k_LatestVersion = 0;
	[SerializeField]
	[HideInInspector]
	private int m_Version; // 0x18
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Tracks; // 0x20
	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration; // 0x28
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks; // 0x30
	[HideInInspector]
	private List<TrackAsset> m_CacheRootTracks; // 0x38
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks; // 0x40
	[SerializeField]
	[HideInInspector]
	private TimelineAsset.EditorSettings m_EditorSettings; // 0x48
	[SerializeField]
	private TimelineAsset.DurationMode m_DurationMode; // 0x50
	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack; // 0x58

	// Properties
	public TimelineAsset.EditorSettings editorSettings { get; }
	public override double duration { get; }
	public double fixedDuration { get; set; }
	public TimelineAsset.DurationMode durationMode { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }
	public int outputTrackCount { get; }
	public int rootTrackCount { get; }
	internal TrackAsset[] flattenedTracks { get; }
	public MarkerTrack markerTrack { get; }
	internal List<ScriptableObject> trackObjects { get; }

	// Methods

	// RVA: 0x86AC24C Offset: 0x86A824C VA: 0x86AC24C
	private void UpgradeToLatestVersion() { }

	// RVA: 0x86AC250 Offset: 0x86A8250 VA: 0x86AC250
	public TimelineAsset.EditorSettings get_editorSettings() { }

	// RVA: 0x86AC258 Offset: 0x86A8258 VA: 0x86AC258 Slot: 7
	public override double get_duration() { }

	// RVA: 0x86AC4F4 Offset: 0x86A84F4 VA: 0x86AC4F4
	public double get_fixedDuration() { }

	// RVA: 0x86AC5C4 Offset: 0x86A85C4 VA: 0x86AC5C4
	public void set_fixedDuration(double value) { }

	// RVA: 0x86AC634 Offset: 0x86A8634 VA: 0x86AC634
	public TimelineAsset.DurationMode get_durationMode() { }

	// RVA: 0x86AC63C Offset: 0x86A863C VA: 0x86AC63C
	public void set_durationMode(TimelineAsset.DurationMode value) { }

	[IteratorStateMachine(typeof(TimelineAsset.<get_outputs>d__27))]
	// RVA: 0x86AC644 Offset: 0x86A8644 VA: 0x86AC644 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86AC6F4 Offset: 0x86A86F4 VA: 0x86AC6F4 Slot: 11
	public ClipCaps get_clipCaps() { }

	// RVA: 0x86ACA58 Offset: 0x86A8A58 VA: 0x86ACA58
	public int get_outputTrackCount() { }

	// RVA: 0x86ACCD4 Offset: 0x86A8CD4 VA: 0x86ACCD4
	public int get_rootTrackCount() { }

	// RVA: 0x86AD0D4 Offset: 0x86A90D4 VA: 0x86AD0D4
	private void OnValidate() { }

	// RVA: 0x86AD1C0 Offset: 0x86A91C0 VA: 0x86AD1C0
	public TrackAsset GetRootTrack(int index) { }

	// RVA: 0x86ACA40 Offset: 0x86A8A40 VA: 0x86ACA40
	public IEnumerable<TrackAsset> GetRootTracks() { }

	// RVA: 0x86AD220 Offset: 0x86A9220 VA: 0x86AD220
	public TrackAsset GetOutputTrack(int index) { }

	// RVA: 0x86AD264 Offset: 0x86A9264 VA: 0x86AD264
	public IEnumerable<TrackAsset> GetOutputTracks() { }

	// RVA: 0x86AD0FC Offset: 0x86A90FC VA: 0x86AD0FC
	private static double GetValidFrameRate(double frameRate) { }

	// RVA: 0x86ACD24 Offset: 0x86A8D24 VA: 0x86ACD24
	private void UpdateRootTrackCache() { }

	// RVA: 0x86ACA7C Offset: 0x86A8A7C VA: 0x86ACA7C
	private void UpdateOutputTrackCache() { }

	// RVA: 0x86AD27C Offset: 0x86A927C VA: 0x86AD27C
	internal TrackAsset[] get_flattenedTracks() { }

	// RVA: 0x86AD730 Offset: 0x86A9730 VA: 0x86AD730
	public MarkerTrack get_markerTrack() { }

	// RVA: 0x86AD738 Offset: 0x86A9738 VA: 0x86AD738
	internal List<ScriptableObject> get_trackObjects() { }

	// RVA: 0x86AD740 Offset: 0x86A9740 VA: 0x86AD740
	internal void AddTrackInternal(TrackAsset track) { }

	// RVA: 0x86AD83C Offset: 0x86A983C VA: 0x86AD83C
	internal void RemoveTrack(TrackAsset track) { }

	// RVA: 0x86AD9C8 Offset: 0x86A99C8 VA: 0x86AD9C8 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x86ADD9C Offset: 0x86A9D9C VA: 0x86ADD9C Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x86ADDA4 Offset: 0x86A9DA4 VA: 0x86ADDA4 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x86ADDA8 Offset: 0x86A9DA8 VA: 0x86ADDA8
	private void __internalAwake() { }

	// RVA: 0x86ADF2C Offset: 0x86A9F2C VA: 0x86ADF2C Slot: 12
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x86AE3E8 Offset: 0x86AA3E8 VA: 0x86AE3E8
	public void CreateMarkerTrack() { }

	// RVA: 0x86AD804 Offset: 0x86A9804 VA: 0x86AD804
	internal void Invalidate() { }

	// RVA: 0x86AE5D0 Offset: 0x86AA5D0 VA: 0x86AE5D0
	internal void UpdateFixedDurationWithItemsDuration() { }

	// RVA: 0x86AC308 Offset: 0x86A8308 VA: 0x86AC308
	private DiscreteTime CalculateItemsDuration() { }

	// RVA: 0x86AD3E0 Offset: 0x86A93E0 VA: 0x86AD3E0
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) { }

	// RVA: 0x86AE76C Offset: 0x86AA76C VA: 0x86AE76C
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(TrackAsset parent, string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471F2F8 Offset: 0x471B2F8 VA: 0x471F2F8
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471F224 Offset: 0x471B224 VA: 0x471F224
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471F15C Offset: 0x471B15C VA: 0x471F15C
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: 0x86AF450 Offset: 0x86AB450 VA: 0x86AF450
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x86AFB88 Offset: 0x86ABB88 VA: 0x86AFB88
	public bool DeleteTrack(TrackAsset track) { }

	// RVA: 0x86B01F4 Offset: 0x86AC1F4 VA: 0x86B01F4
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x86AF1E4 Offset: 0x86AB1E4 VA: 0x86AF1E4
	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	// RVA: 0x86B00C4 Offset: 0x86AC0C4 VA: 0x86B00C4
	private void DeleteRecordedAnimation(TrackAsset track) { }

	// RVA: 0x86AF684 Offset: 0x86AB684 VA: 0x86AF684
	private void DeleteRecordedAnimation(TimelineClip clip) { }

	// RVA: 0x86B04F8 Offset: 0x86AC4F8 VA: 0x86B04F8
	public void .ctor() { }
}

// Namespace: 
private struct TrackAsset.TransientBuildData // TypeDefIndex: 27419
{
	// Fields
	public List<TrackAsset> trackList; // 0x0
	public List<TimelineClip> clipList; // 0x8
	public List<IMarker> markerList; // 0x10

	// Methods

	// RVA: 0x86B738C Offset: 0x86B338C VA: 0x86B738C
	public static TrackAsset.TransientBuildData Create() { }

	// RVA: 0x86B4C60 Offset: 0x86B0C60 VA: 0x86B4C60
	public void Clear() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TrackAsset.<>c // TypeDefIndex: 27420
{
	// Fields
	public static readonly TrackAsset.<>c <>9; // 0x0
	public static Comparison<TimelineClip> <>9__121_0; // 0x8

	// Methods

	// RVA: 0x86B74E0 Offset: 0x86B34E0 VA: 0x86B74E0
	private static void .cctor() { }

	// RVA: 0x86B7548 Offset: 0x86B3548 VA: 0x86B7548
	public void .ctor() { }

	// RVA: 0x86B7550 Offset: 0x86B3550 VA: 0x86B7550
	internal int <SortClips>b__121_0(TimelineClip clip1, TimelineClip clip2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TrackAsset.<get_outputs>d__65 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 27421
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public TrackAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86B1BC8 Offset: 0x86ADBC8 VA: 0x86B1BC8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x86B7580 Offset: 0x86B3580 VA: 0x86B7580 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x86B7584 Offset: 0x86B3584 VA: 0x86B7584 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86B77D4 Offset: 0x86B37D4 VA: 0x86B77D4 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86B77E4 Offset: 0x86B37E4 VA: 0x86B77E4 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x86B781C Offset: 0x86B381C VA: 0x86B781C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86B787C Offset: 0x86B387C VA: 0x86B787C Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x86B7920 Offset: 0x86B3920 VA: 0x86B7920 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.Timeline
[IgnoreOnPlayableTrack]
[Serializable]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner // TypeDefIndex: 27422
{
	// Fields
	private const int k_LatestVersion = 3;
	[SerializeField]
	[HideInInspector]
	private int m_Version; // 0x18
	[FormerlySerializedAs("m_animClip")]
	[HideInInspector]
	[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", False)]
	[SerializeField]
	internal AnimationClip m_AnimClip; // 0x20
	private static TrackAsset.TransientBuildData s_BuildData; // 0x0
	internal const string kDefaultCurvesName = "Track Parameters";
	[CompilerGenerated]
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
	[CompilerGenerated]
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
	[HideInInspector]
	[SerializeField]
	private bool m_Locked; // 0x28
	[HideInInspector]
	[SerializeField]
	private bool m_Muted; // 0x29
	[HideInInspector]
	[SerializeField]
	private string m_CustomPlayableFullTypename; // 0x30
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_Curves; // 0x38
	[HideInInspector]
	[SerializeField]
	private PlayableAsset m_Parent; // 0x40
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Children; // 0x48
	private int m_ItemsHash; // 0x50
	private TimelineClip[] m_ClipsCache; // 0x58
	private DiscreteTime m_Start; // 0x60
	private DiscreteTime m_End; // 0x68
	private bool m_CacheSorted; // 0x70
	private Nullable<bool> m_SupportsNotifications; // 0x71
	private static TrackAsset[] s_EmptyCache; // 0x28
	private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x78
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
	[HideInInspector]
	[SerializeField]
	protected internal List<TimelineClip> m_Clips; // 0x80
	[HideInInspector]
	[SerializeField]
	private MarkerList m_Markers; // 0x88

	// Properties
	public double start { get; }
	public double end { get; }
	public sealed override double duration { get; }
	public bool muted { get; set; }
	public bool mutedInHierarchy { get; }
	public TimelineAsset timelineAsset { get; }
	public PlayableAsset parent { get; set; }
	internal TimelineClip[] clips { get; }
	public virtual bool isEmpty { get; }
	public bool hasClips { get; }
	public bool hasCurves { get; }
	public bool isSubTrack { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	internal string customPlayableTypename { get; set; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.asset { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	internal List<ScriptableObject> subTracksObjects { get; }
	public bool locked { get; set; }
	public bool lockedInHierarchy { get; }
	public bool supportsNotifications { get; }

	// Methods

	// RVA: 0x86B0E40 Offset: 0x86ACE40 VA: 0x86B0E40 Slot: 16
	protected virtual void OnBeforeTrackSerialize() { }

	// RVA: 0x86B0E44 Offset: 0x86ACE44 VA: 0x86B0E44 Slot: 17
	protected virtual void OnAfterTrackDeserialize() { }

	// RVA: 0x86B0E48 Offset: 0x86ACE48 VA: 0x86B0E48 Slot: 18
	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x86B0E4C Offset: 0x86ACE4C VA: 0x86B0E4C Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x86B0FB4 Offset: 0x86ACFB4 VA: 0x86B0FB4 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x86B1414 Offset: 0x86AD414 VA: 0x86B1414
	private void UpgradeToLatestVersion() { }

	[CompilerGenerated]
	// RVA: 0x86B1434 Offset: 0x86AD434 VA: 0x86B1434
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x86B1528 Offset: 0x86AD528 VA: 0x86B1528
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x86B161C Offset: 0x86AD61C VA: 0x86B161C
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x86B1710 Offset: 0x86AD710 VA: 0x86B1710
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	// RVA: 0x86B1804 Offset: 0x86AD804 VA: 0x86B1804
	public double get_start() { }

	// RVA: 0x86AE6A4 Offset: 0x86AA6A4 VA: 0x86AE6A4
	public double get_end() { }

	// RVA: 0x86B196C Offset: 0x86AD96C VA: 0x86B196C Slot: 7
	public sealed override double get_duration() { }

	// RVA: 0x86B19D4 Offset: 0x86AD9D4 VA: 0x86B19D4
	public bool get_muted() { }

	// RVA: 0x86B19DC Offset: 0x86AD9DC VA: 0x86B19DC
	public void set_muted(bool value) { }

	// RVA: 0x86AE244 Offset: 0x86AA244 VA: 0x86AE244
	public bool get_mutedInHierarchy() { }

	// RVA: 0x86AEA68 Offset: 0x86AAA68 VA: 0x86AEA68
	public TimelineAsset get_timelineAsset() { }

	// RVA: 0x86B19E8 Offset: 0x86AD9E8 VA: 0x86B19E8
	public PlayableAsset get_parent() { }

	// RVA: 0x86B19F0 Offset: 0x86AD9F0 VA: 0x86B19F0
	internal void set_parent(PlayableAsset value) { }

	// RVA: 0x86AA634 Offset: 0x86A6634 VA: 0x86AA634
	public IEnumerable<TimelineClip> GetClips() { }

	// RVA: 0x86A687C Offset: 0x86A287C VA: 0x86A687C
	internal TimelineClip[] get_clips() { }

	// RVA: 0x86B19F8 Offset: 0x86AD9F8 VA: 0x86B19F8 Slot: 19
	public virtual bool get_isEmpty() { }

	// RVA: 0x86B1A64 Offset: 0x86ADA64 VA: 0x86B1A64
	public bool get_hasClips() { }

	// RVA: 0x86B1AB8 Offset: 0x86ADAB8 VA: 0x86B1AB8 Slot: 20
	public bool get_hasCurves() { }

	// RVA: 0x86A7380 Offset: 0x86A3380 VA: 0x86A7380
	public bool get_isSubTrack() { }

	[IteratorStateMachine(typeof(TrackAsset.<get_outputs>d__65))]
	// RVA: 0x86B1B4C Offset: 0x86ADB4C VA: 0x86B1B4C Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86A8F60 Offset: 0x86A4F60 VA: 0x86A8F60
	public IEnumerable<TrackAsset> GetChildTracks() { }

	// RVA: 0x86B1E30 Offset: 0x86ADE30 VA: 0x86B1E30
	internal string get_customPlayableTypename() { }

	// RVA: 0x86B1E38 Offset: 0x86ADE38 VA: 0x86B1E38
	internal void set_customPlayableTypename(string value) { }

	// RVA: 0x86B1E40 Offset: 0x86ADE40 VA: 0x86B1E40 Slot: 21
	public AnimationClip get_curves() { }

	// RVA: 0x86B1E48 Offset: 0x86ADE48 VA: 0x86B1E48
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x86B1E50 Offset: 0x86ADE50 VA: 0x86B1E50 Slot: 12
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x86B1E90 Offset: 0x86ADE90 VA: 0x86B1E90 Slot: 13
	private Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	// RVA: 0x86B1E94 Offset: 0x86ADE94 VA: 0x86B1E94 Slot: 14
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x86B1E98 Offset: 0x86ADE98 VA: 0x86B1E98 Slot: 15
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x86B1E9C Offset: 0x86ADE9C VA: 0x86B1E9C
	internal List<ScriptableObject> get_subTracksObjects() { }

	// RVA: 0x86B1EA4 Offset: 0x86ADEA4 VA: 0x86B1EA4
	public bool get_locked() { }

	// RVA: 0x86B1EAC Offset: 0x86ADEAC VA: 0x86B1EAC
	public void set_locked(bool value) { }

	// RVA: 0x86B1EB8 Offset: 0x86ADEB8 VA: 0x86B1EB8
	public bool get_lockedInHierarchy() { }

	// RVA: 0x86B205C Offset: 0x86AE05C VA: 0x86B205C
	public bool get_supportsNotifications() { }

	// RVA: 0x86B2298 Offset: 0x86AE298 VA: 0x86B2298
	private void __internalAwake() { }

	// RVA: 0x86B2388 Offset: 0x86AE388 VA: 0x86B2388 Slot: 22
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x86B2454 Offset: 0x86AE454 VA: 0x86B2454 Slot: 23
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x86B24C4 Offset: 0x86AE4C4 VA: 0x86B24C4 Slot: 6
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x86B2514 Offset: 0x86AE514 VA: 0x86B2514
	public TimelineClip CreateDefaultClip() { }

	// RVA: -1 Offset: -1
	public TimelineClip CreateClip<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471FE2C Offset: 0x471BE2C VA: 0x471FE2C
	|-TrackAsset.CreateClip<object>
	*/

	// RVA: 0x86B2810 Offset: 0x86AE810 VA: 0x86B2810
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x86B2920 Offset: 0x86AE920 VA: 0x86B2920
	public IMarker CreateMarker(Type type, double time) { }

	// RVA: -1 Offset: -1
	public T CreateMarker<T>(double time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471FEA4 Offset: 0x471BEA4 VA: 0x471FEA4
	|-TrackAsset.CreateMarker<object>
	*/

	// RVA: 0x86B2C20 Offset: 0x86AEC20 VA: 0x86B2C20
	public bool DeleteMarker(IMarker marker) { }

	// RVA: 0x86B1418 Offset: 0x86AD418 VA: 0x86B1418
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x86B1B44 Offset: 0x86ADB44 VA: 0x86B1B44
	public int GetMarkerCount() { }

	// RVA: 0x86B2E68 Offset: 0x86AEE68 VA: 0x86B2E68
	public IMarker GetMarker(int idx) { }

	// RVA: 0x86B2ED0 Offset: 0x86AEED0 VA: 0x86B2ED0
	internal TimelineClip CreateClip(Type requestedType) { }

	// RVA: 0x86B27E0 Offset: 0x86AE7E0 VA: 0x86B27E0
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	// RVA: 0x86B3250 Offset: 0x86AF250 VA: 0x86B3250
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	// RVA: 0x86B3680 Offset: 0x86AF680 VA: 0x86B3680
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	// RVA: 0x86B3400 Offset: 0x86AF400 VA: 0x86B3400
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	// RVA: 0x86B3B14 Offset: 0x86AFB14 VA: 0x86B3B14
	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	// RVA: 0x86B3B1C Offset: 0x86AFB1C VA: 0x86B3B1C
	internal void ClearMarkers() { }

	// RVA: 0x86B3B94 Offset: 0x86AFB94 VA: 0x86B3B94
	internal void AddMarker(ScriptableObject e) { }

	// RVA: 0x86B3C90 Offset: 0x86AFC90 VA: 0x86B3C90
	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	// RVA: 0x86B3D60 Offset: 0x86AFD60 VA: 0x86B3D60
	private int GetTimeRangeHash() { }

	// RVA: 0x86AB340 Offset: 0x86A7340 VA: 0x86AB340
	internal void AddClip(TimelineClip newClip) { }

	// RVA: 0x86B4008 Offset: 0x86B0008 VA: 0x86B4008
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	// RVA: 0x86B466C Offset: 0x86B066C VA: 0x86B466C
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x86B4D40 Offset: 0x86B0D40 VA: 0x86B4D40 Slot: 24
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x86B52BC Offset: 0x86B12BC VA: 0x86B52BC
	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	// RVA: 0x86B42DC Offset: 0x86B02DC VA: 0x86B42DC
	private void GatherNotifications(List<IMarker> markers) { }

	// RVA: 0x86B56C0 Offset: 0x86B16C0 VA: 0x86B56C0 Slot: 25
	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x86B5164 Offset: 0x86B1164 VA: 0x86B5164
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	// RVA: 0x86B5C60 Offset: 0x86B1C60 VA: 0x86B5C60
	internal void SortClips() { }

	// RVA: 0x86B5D88 Offset: 0x86B1D88 VA: 0x86B5D88
	internal void ClearClipsInternal() { }

	// RVA: 0x86B5E14 Offset: 0x86B1E14 VA: 0x86B5E14
	internal void ClearSubTracksInternal() { }

	// RVA: 0x86AB200 Offset: 0x86A7200 VA: 0x86AB200
	internal void OnClipMove() { }

	// RVA: 0x86B38D0 Offset: 0x86AF8D0 VA: 0x86B38D0
	internal TimelineClip CreateNewClipContainerInternal() { }

	// RVA: 0x86B03E4 Offset: 0x86AC3E4 VA: 0x86B03E4
	internal void AddChild(TrackAsset child) { }

	// RVA: 0x86B5E98 Offset: 0x86B1E98 VA: 0x86B5E98
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x86AD944 Offset: 0x86A9944 VA: 0x86AD944
	internal bool RemoveSubTrack(TrackAsset child) { }

	// RVA: 0x86AB2D8 Offset: 0x86A72D8 VA: 0x86AB2D8
	internal void RemoveClip(TimelineClip clip) { }

	// RVA: 0x86A9AA0 Offset: 0x86A5AA0 VA: 0x86A9AA0 Slot: 26
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x86A9D88 Offset: 0x86A5D88 VA: 0x86A9D88 Slot: 27
	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x86B60A4 Offset: 0x86B20A4 VA: 0x86B60A4 Slot: 28
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x86B677C Offset: 0x86B277C VA: 0x86B677C
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	// RVA: 0x86B2FD0 Offset: 0x86AEFD0 VA: 0x86B2FD0
	internal bool ValidateClipType(Type clipType) { }

	// RVA: 0x86B68F4 Offset: 0x86B28F4 VA: 0x86B68F4 Slot: 29
	protected virtual void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x86B1864 Offset: 0x86AD864 VA: 0x86B1864
	private void UpdateDuration() { }

	// RVA: 0x86A766C Offset: 0x86A366C VA: 0x86A766C Slot: 30
	protected internal virtual int CalculateItemsHash() { }

	// RVA: 0x86B6A98 Offset: 0x86B2A98 VA: 0x86B6A98 Slot: 31
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	// RVA: 0x86B1378 Offset: 0x86AD378 VA: 0x86B1378
	internal void Invalidate() { }

	// RVA: 0x86A9D98 Offset: 0x86A5D98 VA: 0x86A9D98
	internal double GetNotificationDuration() { }

	// RVA: 0x86B6D34 Offset: 0x86B2D34 VA: 0x86B6D34 Slot: 32
	internal virtual bool CanCompileClips() { }

	// RVA: 0x86B6D90 Offset: 0x86B2D90 VA: 0x86B6D90 Slot: 33
	public virtual bool CanCreateTrackMixer() { }

	// RVA: 0x86B6DA0 Offset: 0x86B2DA0 VA: 0x86B6DA0
	internal bool IsCompilable() { }

	// RVA: 0x86B1BFC Offset: 0x86ADBFC VA: 0x86B1BFC
	private void UpdateChildTrackCache() { }

	// RVA: 0x86B7154 Offset: 0x86B3154 VA: 0x86B7154 Slot: 34
	internal virtual int Hash() { }

	// RVA: 0x86B68F8 Offset: 0x86B28F8 VA: 0x86B68F8
	private int GetClipsHash() { }

	// RVA: 0x86A7588 Offset: 0x86A3588 VA: 0x86A7588
	protected static int GetAnimationClipHash(AnimationClip clip) { }

	// RVA: 0x86B6088 Offset: 0x86B2088 VA: 0x86B6088
	private bool HasNotifications() { }

	// RVA: 0x86B568C Offset: 0x86B168C VA: 0x86B568C
	private bool CanCompileNotifications() { }

	// RVA: 0x86B4944 Offset: 0x86B0944 VA: 0x86B4944
	private bool CanCreateMixerRecursive() { }

	// RVA: 0x86AA9D8 Offset: 0x86A69D8 VA: 0x86AA9D8
	protected void .ctor() { }

	// RVA: 0x86B728C Offset: 0x86B328C VA: 0x86B728C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
[Flags]
public enum ClipCaps // TypeDefIndex: 27423
{
	// Fields
	public int value__; // 0x0
	public const ClipCaps None = 0;
	public const ClipCaps Looping = 1;
	public const ClipCaps Extrapolation = 2;
	public const ClipCaps ClipIn = 4;
	public const ClipCaps SpeedMultiplier = 8;
	public const ClipCaps Blending = 16;
	public const ClipCaps AutoScale = 40;
	public const ClipCaps All = -1;
}

// Namespace: UnityEngine.Timeline
[Extension]
internal static class TimelineClipCapsExtensions // TypeDefIndex: 27424
{
	// Methods

	[Extension]
	// RVA: 0x86B7924 Offset: 0x86B3924 VA: 0x86B7924
	public static bool SupportsExtrapolation(TimelineClip clip) { }

	[Extension]
	// RVA: 0x86AB0CC Offset: 0x86A70CC VA: 0x86AB0CC
	public static bool HasAny(ClipCaps caps, ClipCaps flags) { }
}

// Namespace: UnityEngine.Timeline
internal struct DiscreteTime : IComparable // TypeDefIndex: 27425
{
	// Fields
	private const double k_Tick = 1E-12;
	public static readonly DiscreteTime kMaxTime; // 0x0
	private readonly long m_DiscreteTime; // 0x0

	// Properties
	public static double tickValue { get; }

	// Methods

	// RVA: 0x86B793C Offset: 0x86B393C VA: 0x86B793C
	public static double get_tickValue() { }

	// RVA: 0x86B7948 Offset: 0x86B3948 VA: 0x86B7948
	private void .ctor(long time) { }

	// RVA: 0x86B7950 Offset: 0x86B3950 VA: 0x86B7950
	public void .ctor(double time) { }

	// RVA: 0x86AE63C Offset: 0x86AA63C VA: 0x86AE63C
	public void .ctor(int time) { }

	// RVA: 0x86AC488 Offset: 0x86A8488 VA: 0x86AC488
	public DiscreteTime OneTickBefore() { }

	// RVA: 0x86B7AAC Offset: 0x86B3AAC VA: 0x86B7AAC
	public DiscreteTime OneTickAfter() { }

	// RVA: 0x86B7AB8 Offset: 0x86B3AB8 VA: 0x86B7AB8
	public static DiscreteTime FromTicks(long ticks) { }

	// RVA: 0x86B7ABC Offset: 0x86B3ABC VA: 0x86B7ABC Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x86B7B44 Offset: 0x86B3B44 VA: 0x86B7B44
	public bool Equals(DiscreteTime other) { }

	// RVA: 0x86B7B54 Offset: 0x86B3B54 VA: 0x86B7B54 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x86B79B8 Offset: 0x86B39B8 VA: 0x86B79B8
	private static long DoubleToDiscreteTime(double time) { }

	// RVA: 0x86B7A58 Offset: 0x86B3A58 VA: 0x86B7A58
	private static long IntToDiscreteTime(int time) { }

	// RVA: 0x86B7BFC Offset: 0x86B3BFC VA: 0x86B7BFC
	private static double ToDouble(long time) { }

	// RVA: 0x86AC494 Offset: 0x86A8494 VA: 0x86AC494
	public static double op_Explicit(DiscreteTime b) { }

	// RVA: 0x86AC5A8 Offset: 0x86A85A8 VA: 0x86AC5A8
	public static DiscreteTime op_Explicit(double time) { }

	// RVA: 0x86AC45C Offset: 0x86A845C VA: 0x86AC45C
	public static DiscreteTime op_Implicit(int time) { }

	// RVA: 0x86B7C10 Offset: 0x86B3C10 VA: 0x86B7C10
	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86B7C1C Offset: 0x86B3C1C VA: 0x86B7C1C
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86AC47C Offset: 0x86A847C VA: 0x86AC47C
	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86B7C80 Offset: 0x86B3C80 VA: 0x86B7C80
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86B19CC Offset: 0x86AD9CC VA: 0x86B19CC
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86B7C8C Offset: 0x86B3C8C VA: 0x86B7C8C Slot: 3
	public override string ToString() { }

	// RVA: 0x86B7CAC Offset: 0x86B3CAC VA: 0x86B7CAC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x86AE704 Offset: 0x86AA704 VA: 0x86AE704
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x86B7CCC Offset: 0x86B3CCC VA: 0x86B7CCC
	public static long GetNearestTick(double time) { }

	// RVA: 0x86B7D28 Offset: 0x86B3D28 VA: 0x86B7D28
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 27426
{
	// Fields
	private Playable m_Playable; // 0x18
	private static readonly long kIntervalEnd; // 0x0

	// Properties
	public override long intervalStart { get; }
	public override long intervalEnd { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x86A99D8 Offset: 0x86A59D8 VA: 0x86A99D8
	public void .ctor(Playable playable) { }

	// RVA: 0x86B7D7C Offset: 0x86B3D7C VA: 0x86B7D7C Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x86B7D84 Offset: 0x86B3D84 VA: 0x86B7D84 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x86B7DDC Offset: 0x86B3DDC VA: 0x86B7DDC Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x86B7E50 Offset: 0x86B3E50 VA: 0x86B7E50 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x86B7EA8 Offset: 0x86B3EA8 VA: 0x86B7EA8 Slot: 10
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	// RVA: 0x86B7F14 Offset: 0x86B3F14 VA: 0x86B7F14
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
internal interface IInterval // TypeDefIndex: 27427
{
	// Properties
	public abstract long intervalStart { get; }
	public abstract long intervalEnd { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_intervalStart();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract long get_intervalEnd();
}

// Namespace: UnityEngine.Timeline
internal struct IntervalTreeNode // TypeDefIndex: 27428
{
	// Fields
	public long center; // 0x0
	public int first; // 0x8
	public int last; // 0xC
	public int left; // 0x10
	public int right; // 0x14
}

// Namespace: 
internal struct IntervalTree.Entry<T> // TypeDefIndex: 27429
{
	// Fields
	public long intervalStart; // 0x0
	public long intervalEnd; // 0x0
	public T item; // 0x0
}

// Namespace: UnityEngine.Timeline
internal class IntervalTree<T> // TypeDefIndex: 27430
{
	// Fields
	private readonly List<IntervalTree.Entry<T>> m_Entries; // 0x0
	private readonly List<IntervalTreeNode> m_Nodes; // 0x0
	[CompilerGenerated]
	private bool <dirty>k__BackingField; // 0x0

	// Properties
	public bool dirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_dirty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A56EA4 Offset: 0x4A52EA4 VA: 0x4A56EA4
	|-IntervalTree<object>.get_dirty
	|
	|-RVA: 0x4A57B00 Offset: 0x4A53B00 VA: 0x4A57B00
	|-IntervalTree<__Il2CppFullySharedGenericType>.get_dirty
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_dirty(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A56EAC Offset: 0x4A52EAC VA: 0x4A56EAC
	|-IntervalTree<object>.set_dirty
	|
	|-RVA: 0x4A57B08 Offset: 0x4A53B08 VA: 0x4A57B08
	|-IntervalTree<__Il2CppFullySharedGenericType>.set_dirty
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A56EB8 Offset: 0x4A52EB8 VA: 0x4A56EB8
	|-IntervalTree<object>.Add
	|
	|-RVA: 0x4A57B14 Offset: 0x4A53B14 VA: 0x4A57B14
	|-IntervalTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWith(long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A570A4 Offset: 0x4A530A4 VA: 0x4A570A4
	|-IntervalTree<object>.IntersectsWith
	|
	|-RVA: 0x4A57E44 Offset: 0x4A53E44 VA: 0x4A57E44
	|-IntervalTree<__Il2CppFullySharedGenericType>.IntersectsWith
	*/

	// RVA: -1 Offset: -1
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A5719C Offset: 0x4A5319C VA: 0x4A5719C
	|-IntervalTree<object>.Query
	|
	|-RVA: 0x4A57F84 Offset: 0x4A53F84 VA: 0x4A57F84
	|-IntervalTree<__Il2CppFullySharedGenericType>.Query
	*/

	// RVA: -1 Offset: -1
	private void Rebuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A57398 Offset: 0x4A53398 VA: 0x4A57398
	|-IntervalTree<object>.Rebuild
	|
	|-RVA: 0x4A582C8 Offset: 0x4A542C8 VA: 0x4A582C8
	|-IntervalTree<__Il2CppFullySharedGenericType>.Rebuild
	*/

	// RVA: -1 Offset: -1
	private int Rebuild(int start, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A57454 Offset: 0x4A53454 VA: 0x4A57454
	|-IntervalTree<object>.Rebuild
	|
	|-RVA: 0x4A5839C Offset: 0x4A5439C VA: 0x4A5839C
	|-IntervalTree<__Il2CppFullySharedGenericType>.Rebuild
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A57A34 Offset: 0x4A53A34 VA: 0x4A57A34
	|-IntervalTree<object>..ctor
	|
	|-RVA: 0x4A58CBC Offset: 0x4A54CBC VA: 0x4A58CBC
	|-IntervalTree<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Timeline
internal class RuntimeClip : RuntimeClipBase // TypeDefIndex: 27431
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x86B7FC4 Offset: 0x86B3FC4 VA: 0x86B7FC4 Slot: 11
	public override double get_start() { }

	// RVA: 0x86B7FF0 Offset: 0x86B3FF0 VA: 0x86B7FF0 Slot: 12
	public override double get_duration() { }

	// RVA: 0x86A7B1C Offset: 0x86A3B1C VA: 0x86A7B1C
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x86B8010 Offset: 0x86B4010 VA: 0x86B8010
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x86B80A0 Offset: 0x86B40A0 VA: 0x86B80A0
	public TimelineClip get_clip() { }

	// RVA: 0x86B80A8 Offset: 0x86B40A8 VA: 0x86B80A8
	public Playable get_mixer() { }

	// RVA: 0x86B80B4 Offset: 0x86B40B4 VA: 0x86B80B4
	public Playable get_playable() { }

	// RVA: 0x86B80C0 Offset: 0x86B40C0 VA: 0x86B80C0 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x86B81F4 Offset: 0x86B41F4 VA: 0x86B81F4
	public void SetTime(double time) { }

	// RVA: 0x86B824C Offset: 0x86B424C VA: 0x86B824C
	public void SetDuration(double duration) { }

	// RVA: 0x86B82A4 Offset: 0x86B42A4 VA: 0x86B82A4 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x86B849C Offset: 0x86B449C VA: 0x86B849C Slot: 10
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData) { }
}

// Namespace: UnityEngine.Timeline
internal abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 27432
{
	// Properties
	public abstract double start { get; }
	public abstract double duration { get; }
	public override long intervalStart { get; }
	public override long intervalEnd { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract double get_start();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double get_duration();

	// RVA: 0x86B85F4 Offset: 0x86B45F4 VA: 0x86B85F4 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x86B8664 Offset: 0x86B4664 VA: 0x86B8664 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x86B8008 Offset: 0x86B4008 VA: 0x86B8008
	protected void .ctor() { }
}

// Namespace: UnityEngine.Timeline
internal abstract class RuntimeElement : IInterval // TypeDefIndex: 27433
{
	// Fields
	[CompilerGenerated]
	private int <intervalBit>k__BackingField; // 0x10

	// Properties
	public abstract long intervalStart { get; }
	public abstract long intervalEnd { get; }
	public int intervalBit { get; set; }
	public abstract bool enable { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_intervalStart();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_intervalEnd();

	[CompilerGenerated]
	// RVA: 0x86B86E8 Offset: 0x86B46E8 VA: 0x86B86E8
	public int get_intervalBit() { }

	[CompilerGenerated]
	// RVA: 0x86B86F0 Offset: 0x86B46F0 VA: 0x86B86F0
	public void set_intervalBit(int value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_enable(bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void EvaluateAt(double localTime, FrameData frameData);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);

	// RVA: 0x86B7D74 Offset: 0x86B3D74 VA: 0x86B7D74
	protected void .ctor() { }
}

// Namespace: UnityEngine.Timeline
public interface IMarker // TypeDefIndex: 27434
{
	// Properties
	public abstract double time { get; set; }
	public abstract TrackAsset parent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract double get_time();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_time(double value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TrackAsset get_parent();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Initialize(TrackAsset parent);
}

// Namespace: UnityEngine.Timeline
public interface INotificationOptionProvider // TypeDefIndex: 27435
{
	// Properties
	public abstract NotificationFlags flags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NotificationFlags get_flags();
}

// Namespace: UnityEngine.Timeline
[DefaultMember("Item")]
[Serializable]
internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 27436
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private List<ScriptableObject> m_Objects; // 0x0
	[HideInInspector]
	private List<IMarker> m_Cache; // 0x8
	private bool m_CacheDirty; // 0x10
	private bool m_HasNotifications; // 0x11

	// Properties
	public List<IMarker> markers { get; }
	public int Count { get; }
	public IMarker Item { get; }

	// Methods

	// RVA: 0x86B86F8 Offset: 0x86B46F8 VA: 0x86B86F8
	public List<IMarker> get_markers() { }

	// RVA: 0x86B71A4 Offset: 0x86B31A4 VA: 0x86B71A4
	public void .ctor(int capacity) { }

	// RVA: 0x86B3B9C Offset: 0x86AFB9C VA: 0x86B3B9C
	public void Add(ScriptableObject item) { }

	// RVA: 0x86B2C28 Offset: 0x86AEC28 VA: 0x86B2C28
	public bool Remove(IMarker item) { }

	// RVA: 0x86B3CC0 Offset: 0x86AFCC0 VA: 0x86B3CC0
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	// RVA: 0x86B3B24 Offset: 0x86AFB24 VA: 0x86B3B24
	public void Clear() { }

	// RVA: 0x86B2E00 Offset: 0x86AEE00 VA: 0x86B2E00
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x86B2E18 Offset: 0x86AEE18 VA: 0x86B2E18
	public int get_Count() { }

	// RVA: 0x86B2E70 Offset: 0x86AEE70 VA: 0x86B2E70
	public IMarker get_Item(int idx) { }

	// RVA: 0x86B89F4 Offset: 0x86B49F4 VA: 0x86B89F4
	public List<ScriptableObject> GetRawMarkerList() { }

	// RVA: 0x86B292C Offset: 0x86AE92C VA: 0x86B292C
	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	// RVA: 0x86B718C Offset: 0x86B318C VA: 0x86B718C
	public bool HasNotifications() { }

	// RVA: 0x86B89FC Offset: 0x86B49FC VA: 0x86B89FC Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x86B8A00 Offset: 0x86B4A00 VA: 0x86B8A00 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x86B8710 Offset: 0x86B4710 VA: 0x86B8710
	private void BuildCache() { }
}

// Namespace: UnityEngine.Timeline
[TrackBindingType(typeof(GameObject))]
[HideInMenu]
[ExcludeFromPreset]
[Serializable]
public class MarkerTrack : TrackAsset // TypeDefIndex: 27437
{
	// Properties
	public override IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x86B8A0C Offset: 0x86B4A0C VA: 0x86B8A0C Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86B8BFC Offset: 0x86B4BFC VA: 0x86B8BFC
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
[TrackClipType(typeof(TrackAsset))]
[SupportsChildTracks(null, 2147483647)]
[ExcludeFromPreset]
[Serializable]
public class GroupTrack : TrackAsset // TypeDefIndex: 27438
{
	// Properties
	public override IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x86B8C50 Offset: 0x86B4C50 VA: 0x86B8C50 Slot: 32
	internal override bool CanCompileClips() { }

	// RVA: 0x86B8C58 Offset: 0x86B4C58 VA: 0x86B8C58 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x86B8CB0 Offset: 0x86B4CB0 VA: 0x86B8CB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
public interface ILayerable // TypeDefIndex: 27439
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
}

// Namespace: UnityEngine.Timeline
[Flags]
[Serializable]
public enum NotificationFlags // TypeDefIndex: 27440
{
	// Fields
	public short value__; // 0x0
	public const NotificationFlags TriggerInEditMode = 1;
	public const NotificationFlags Retroactive = 2;
	public const NotificationFlags TriggerOnce = 4;
}

// Namespace: 
private struct TimeNotificationBehaviour.NotificationEntry // TypeDefIndex: 27441
{
	// Fields
	public double time; // 0x0
	public INotification payload; // 0x8
	public bool notificationFired; // 0x10
	public NotificationFlags flags; // 0x12

	// Properties
	public bool triggerInEditor { get; }
	public bool prewarm { get; }
	public bool triggerOnce { get; }

	// Methods

	// RVA: 0x86B9B0C Offset: 0x86B5B0C VA: 0x86B9B0C
	public bool get_triggerInEditor() { }

	// RVA: 0x86B9B00 Offset: 0x86B5B00 VA: 0x86B9B00
	public bool get_prewarm() { }

	// RVA: 0x86B9228 Offset: 0x86B5228 VA: 0x86B9228
	public bool get_triggerOnce() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TimeNotificationBehaviour.<>c // TypeDefIndex: 27442
{
	// Fields
	public static readonly TimeNotificationBehaviour.<>c <>9; // 0x0
	public static Comparison<TimeNotificationBehaviour.NotificationEntry> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x86B9BA0 Offset: 0x86B5BA0 VA: 0x86B9BA0
	private static void .cctor() { }

	// RVA: 0x86B9C08 Offset: 0x86B5C08 VA: 0x86B9C08
	public void .ctor() { }

	// RVA: 0x86B9C10 Offset: 0x86B5C10 VA: 0x86B9C10
	internal int <SortNotifications>b__12_0(TimeNotificationBehaviour.NotificationEntry x, TimeNotificationBehaviour.NotificationEntry y) { }
}

// Namespace: UnityEngine.Timeline
public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 27443
{
	// Fields
	private readonly List<TimeNotificationBehaviour.NotificationEntry> m_Notifications; // 0x10
	private double m_PreviousTime; // 0x18
	private bool m_NeedSortNotifications; // 0x20
	private Playable m_TimeSource; // 0x28

	// Properties
	public Playable timeSource { set; }

	// Methods

	// RVA: 0x86B8D04 Offset: 0x86B4D04 VA: 0x86B8D04
	public void set_timeSource(Playable value) { }

	// RVA: 0x86B8D0C Offset: 0x86B4D0C VA: 0x86B8D0C
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	// RVA: 0x86B8E28 Offset: 0x86B4E28 VA: 0x86B8E28
	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	// RVA: 0x86B8F5C Offset: 0x86B4F5C VA: 0x86B8F5C Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x86B9234 Offset: 0x86B5234 VA: 0x86B9234 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x86B9460 Offset: 0x86B5460 VA: 0x86B9460 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x86B9114 Offset: 0x86B5114 VA: 0x86B9114
	private void SortNotifications() { }

	// RVA: 0x86B9A9C Offset: 0x86B5A9C VA: 0x86B9A9C
	private static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	// RVA: 0x86B98C0 Offset: 0x86B58C0 VA: 0x86B98C0
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

	// RVA: 0x86B97BC Offset: 0x86B57BC VA: 0x86B97BC
	private void SyncDurationWithExternalSource(Playable playable) { }

	// RVA: 0x86B93D8 Offset: 0x86B53D8 VA: 0x86B93D8
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x86B9AF8 Offset: 0x86B5AF8 VA: 0x86B9AF8
	private static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x86B9B18 Offset: 0x86B5B18 VA: 0x86B9B18
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
[Serializable]
public class PlayableTrack : TrackAsset // TypeDefIndex: 27444
{
	// Methods

	// RVA: 0x86B9C20 Offset: 0x86B5C20 VA: 0x86B9C20 Slot: 29
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x86B9CCC Offset: 0x86B5CCC VA: 0x86B9CCC
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
[Usage(4, AllowMultiple = True)]
public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 27445
{
	// Fields
	public readonly Type inspectedType; // 0x10
	public readonly bool allowAutoCreate; // 0x18

	// Methods

	// RVA: 0x86B9D20 Offset: 0x86B5D20 VA: 0x86B9D20
	public void .ctor(Type clipClass) { }

	// RVA: 0x86B9D5C Offset: 0x86B5D5C VA: 0x86B9D5C
	public void .ctor(Type clipClass, bool allowAutoCreate) { }
}

// Namespace: UnityEngine.Timeline
[Usage(260)]
public class NotKeyableAttribute : Attribute // TypeDefIndex: 27446
{
	// Methods

	// RVA: 0x86B9D8C Offset: 0x86B5D8C VA: 0x86B9D8C
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
[Flags]
public enum TrackBindingFlags // TypeDefIndex: 27447
{
	// Fields
	public int value__; // 0x0
	public const TrackBindingFlags None = 0;
	public const TrackBindingFlags AllowCreateComponent = 1;
	public const TrackBindingFlags All = 1;
}

// Namespace: UnityEngine.Timeline
[Usage(4)]
public class TrackBindingTypeAttribute : Attribute // TypeDefIndex: 27448
{
	// Fields
	public readonly Type type; // 0x10
	public readonly TrackBindingFlags flags; // 0x18

	// Methods

	// RVA: 0x86B9D94 Offset: 0x86B5D94 VA: 0x86B9D94
	public void .ctor(Type type) { }
}

// Namespace: UnityEngine.Timeline
[Usage(4, Inherited = False)]
internal class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 27449
{
	// Fields
	public readonly Type childType; // 0x10
	public readonly int levels; // 0x18

	// Methods

	// RVA: 0x86B9DD0 Offset: 0x86B5DD0 VA: 0x86B9DD0
	public void .ctor(Type childType, int levels = 2147483647) { }
}

// Namespace: UnityEngine.Timeline
[Usage(4, AllowMultiple = False, Inherited = True)]
internal class IgnoreOnPlayableTrackAttribute : Attribute // TypeDefIndex: 27450
{
	// Methods

	// RVA: 0x86B9E0C Offset: 0x86B5E0C VA: 0x86B9E0C
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
internal class FrameRateFieldAttribute : PropertyAttribute // TypeDefIndex: 27451
{
	// Methods

	// RVA: 0x86B9E14 Offset: 0x86B5E14 VA: 0x86B9E14
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
[Usage(4, Inherited = False)]
public class HideInMenuAttribute : Attribute // TypeDefIndex: 27452
{
	// Methods

	// RVA: 0x86B9E1C Offset: 0x86B5E1C VA: 0x86B9E1C
	public void .ctor() { }
}

// Namespace: UnityEngine.Timeline
public interface ITimelineClipAsset // TypeDefIndex: 27453
{
	// Properties
	public abstract ClipCaps clipCaps { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ClipCaps get_clipCaps();
}

// Namespace: UnityEngine.Timeline
internal interface ITimelineEvaluateCallback // TypeDefIndex: 27454
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Evaluate();
}

// Namespace: UnityEngine.Timeline
public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 27455
{
	// Fields
	private IntervalTree<RuntimeElement> m_IntervalTree; // 0x10
	private List<RuntimeElement> m_ActiveClips; // 0x18
	private List<RuntimeElement> m_CurrentListOfActiveClips; // 0x20
	private int m_ActiveBit; // 0x28
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x30
	private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0x38
	internal static bool muteAudioScrubbing; // 0x0

	// Methods

	// RVA: 0x86ADB88 Offset: 0x86A9B88 VA: 0x86ADB88
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x86B9E24 Offset: 0x86B5E24 VA: 0x86B9E24
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x86BA0D0 Offset: 0x86B60D0 VA: 0x86BA0D0
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	// RVA: 0x86BA848 Offset: 0x86B6848 VA: 0x86BA848
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	// RVA: 0x86BAEFC Offset: 0x86B6EFC VA: 0x86BAEFC
	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x86BA460 Offset: 0x86B6460 VA: 0x86BA460
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	// RVA: 0x86BB054 Offset: 0x86B7054 VA: 0x86BB054 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x86BB080 Offset: 0x86B7080 VA: 0x86BB080
	private void Evaluate(Playable playable, FrameData frameData) { }

	// RVA: 0x86BAFE4 Offset: 0x86B6FE4 VA: 0x86BAFE4
	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	// RVA: 0x86BB630 Offset: 0x86B7630 VA: 0x86BB630
	public void .ctor() { }

	// RVA: 0x86BB7B4 Offset: 0x86B77B4 VA: 0x86BB7B4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Extrapolation.<>c // TypeDefIndex: 27456
{
	// Fields
	public static readonly Extrapolation.<>c <>9; // 0x0
	public static Comparison<TimelineClip> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x86BB9C4 Offset: 0x86B79C4 VA: 0x86BB9C4
	private static void .cctor() { }

	// RVA: 0x86BBA2C Offset: 0x86B7A2C VA: 0x86BBA2C
	public void .ctor() { }

	// RVA: 0x86BBA34 Offset: 0x86B7A34 VA: 0x86BBA34
	internal int <SortClipsByStartTime>b__2_0(TimelineClip clip1, TimelineClip clip2) { }
}

// Namespace: UnityEngine.Timeline
[Extension]
internal static class Extrapolation // TypeDefIndex: 27457
{
	// Fields
	internal static readonly double kMinExtrapolationTime; // 0x0

	// Methods

	[Extension]
	// RVA: 0x86AF7B4 Offset: 0x86AB7B4 VA: 0x86AF7B4
	internal static void CalculateExtrapolationTimes(TrackAsset asset) { }

	// RVA: 0x86BB800 Offset: 0x86B7800 VA: 0x86BB800
	private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) { }

	// RVA: 0x86BB940 Offset: 0x86B7940 VA: 0x86BB940
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
[Extension]
internal static class HashUtility // TypeDefIndex: 27458
{
	// Methods

	[Extension]
	// RVA: 0x86A7710 Offset: 0x86A3710 VA: 0x86A7710
	public static int CombineHash(int h1, int h2) { }

	// RVA: 0x86B6A6C Offset: 0x86B2A6C VA: 0x86B6A6C
	public static int CombineHash(int h1, int h2, int h3) { }

	// RVA: 0x86BBA64 Offset: 0x86B7A64 VA: 0x86BBA64
	public static int CombineHash(int h1, int h2, int h3, int h4) { }

	// RVA: 0x86BBAA0 Offset: 0x86B7AA0 VA: 0x86BBAA0
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5) { }

	// RVA: 0x86AB948 Offset: 0x86A7948 VA: 0x86AB948
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6) { }
}

// Namespace: UnityEngine.Timeline
public interface IPropertyCollector // TypeDefIndex: 27459
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PushActiveGameObject(GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PopActiveGameObject();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddFromClip(AnimationClip clip);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddObjectProperties(Object obj, AnimationClip clip);
}

// Namespace: UnityEngine.Timeline
public interface IPropertyPreview // TypeDefIndex: 27460
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GatherProperties(PlayableDirector director, IPropertyCollector driver);
}

// Namespace: UnityEngine.Timeline
internal static class NotificationUtilities // TypeDefIndex: 27461
{
	// Methods

	// RVA: 0x86B4658 Offset: 0x86B0658 VA: 0x86B4658
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director) { }

	// RVA: 0x86B4664 Offset: 0x86B0664 VA: 0x86B4664
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset) { }

	// RVA: 0x86BBAEC Offset: 0x86B7AEC VA: 0x86BBAEC
	private static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director) { }

	// RVA: 0x86B210C Offset: 0x86AE10C VA: 0x86B210C
	public static bool TrackTypeSupportsNotifications(Type type) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TimelineCreateUtilities.<>c__DisplayClass0_0 // TypeDefIndex: 27462
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x86BC328 Offset: 0x86B8328 VA: 0x86BC328
	public void .ctor() { }

	// RVA: 0x86BC338 Offset: 0x86B8338 VA: 0x86BC338
	internal bool <GenerateUniqueActorName>b__0(ScriptableObject x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TimelineCreateUtilities.<>c__DisplayClass0_1 // TypeDefIndex: 27463
{
	// Fields
	public string result; // 0x10

	// Methods

	// RVA: 0x86BC330 Offset: 0x86B8330 VA: 0x86BC330
	public void .ctor() { }

	// RVA: 0x86BC368 Offset: 0x86B8368 VA: 0x86BC368
	internal bool <GenerateUniqueActorName>b__1(ScriptableObject x) { }
}

// Namespace: UnityEngine.Timeline
internal static class TimelineCreateUtilities // TypeDefIndex: 27464
{
	// Methods

	// RVA: 0x86AEEE8 Offset: 0x86AAEE8 VA: 0x86AEEE8
	public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name) { }

	// RVA: 0x86AE4E8 Offset: 0x86AA4E8 VA: 0x86AE4E8
	public static void SaveAssetIntoObject(Object childAsset, Object masterAsset) { }

	// RVA: 0x86A6E94 Offset: 0x86A2E94 VA: 0x86A6E94
	public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy) { }

	// RVA: 0x86AEBD4 Offset: 0x86AABD4 VA: 0x86AEBD4
	public static bool ValidateParentTrack(TrackAsset parent, Type childType) { }
}

// Namespace: UnityEngine.Timeline
internal static class TimelineUndo // TypeDefIndex: 27465
{
	// Methods

	// RVA: 0x86AF5FC Offset: 0x86AB5FC VA: 0x86AF5FC
	public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy) { }
}

// Namespace: UnityEngine.Timeline
internal static class TimeUtility // TypeDefIndex: 27466
{
	// Fields
	public static readonly double kTimeEpsilon; // 0x0
	public static readonly double kFrameRateEpsilon; // 0x8
	public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
	public static readonly double kFrameRateRounding; // 0x18

	// Methods

	// RVA: 0x86A574C Offset: 0x86A174C VA: 0x86A574C
	public static double GetAnimationClipLength(AnimationClip clip) { }

	// RVA: 0x86BC398 Offset: 0x86B8398 VA: 0x86BC398
	private static void .cctor() { }
}

// Namespace: UnityEngine.Timeline
internal static class WeightUtility // TypeDefIndex: 27467
{
	// Methods

	// RVA: 0x86A51FC Offset: 0x86A11FC VA: 0x86A51FC
	public static float NormalizeMixer(Playable mixer) { }
}

