// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28782
{}

// Namespace: UnityEngine.Playables
[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour, IExposedPropertyTable // TypeDefIndex: 28783
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> played; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> paused; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> stopped; // 0x28

	// Properties
	public PlayState state { get; }
	public DirectorWrapMode extrapolationMode { get; set; }
	public PlayableAsset playableAsset { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool playOnAwake { get; set; }
	public DirectorUpdateMode timeUpdateMode { get; set; }
	public double time { get; set; }
	public double initialTime { get; set; }
	public double duration { get; }

	// Methods

	// RVA: 0x8780868 Offset: 0x877C868 VA: 0x8780868
	public PlayState get_state() { }

	// RVA: 0x87808E0 Offset: 0x877C8E0 VA: 0x87808E0
	public void set_extrapolationMode(DirectorWrapMode value) { }

	// RVA: 0x8780968 Offset: 0x877C968 VA: 0x8780968
	public DirectorWrapMode get_extrapolationMode() { }

	// RVA: 0x87809E0 Offset: 0x877C9E0 VA: 0x87809E0
	public PlayableAsset get_playableAsset() { }

	// RVA: 0x8780ABC Offset: 0x877CABC VA: 0x8780ABC
	public void set_playableAsset(PlayableAsset value) { }

	// RVA: 0x8780B44 Offset: 0x877CB44 VA: 0x8780B44
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x8780B9C Offset: 0x877CB9C VA: 0x8780B9C
	public bool get_playOnAwake() { }

	// RVA: 0x8780C14 Offset: 0x877CC14 VA: 0x8780C14
	public void set_playOnAwake(bool value) { }

	// RVA: 0x8780C9C Offset: 0x877CC9C VA: 0x8780C9C
	public void DeferredEvaluate() { }

	// RVA: 0x8780D14 Offset: 0x877CD14 VA: 0x8780D14
	internal void Play(FrameRate frameRate) { }

	// RVA: 0x8780DA4 Offset: 0x877CDA4 VA: 0x8780DA4
	public void Play(PlayableAsset asset) { }

	// RVA: 0x8780E90 Offset: 0x877CE90 VA: 0x8780E90
	public void Play(PlayableAsset asset, DirectorWrapMode mode) { }

	// RVA: 0x8781004 Offset: 0x877D004 VA: 0x8781004
	public void SetGenericBinding(Object key, Object value) { }

	// RVA: 0x87810AC Offset: 0x877D0AC VA: 0x87810AC
	public void set_timeUpdateMode(DirectorUpdateMode value) { }

	// RVA: 0x87810F0 Offset: 0x877D0F0 VA: 0x87810F0
	public DirectorUpdateMode get_timeUpdateMode() { }

	// RVA: 0x878112C Offset: 0x877D12C VA: 0x878112C
	public void set_time(double value) { }

	// RVA: 0x8781178 Offset: 0x877D178 VA: 0x8781178
	public double get_time() { }

	// RVA: 0x87811B4 Offset: 0x877D1B4 VA: 0x87811B4
	public void set_initialTime(double value) { }

	// RVA: 0x8781200 Offset: 0x877D200 VA: 0x8781200
	public double get_initialTime() { }

	// RVA: 0x878123C Offset: 0x877D23C VA: 0x878123C
	public double get_duration() { }

	[NativeThrows]
	// RVA: 0x8781278 Offset: 0x877D278 VA: 0x8781278
	public void Evaluate() { }

	[NativeThrows]
	// RVA: 0x8780D5C Offset: 0x877CD5C VA: 0x8780D5C
	private void PlayOnFrame(FrameRate frameRate) { }

	[NativeThrows]
	// RVA: 0x8780FC8 Offset: 0x877CFC8 VA: 0x8780FC8
	public void Play() { }

	// RVA: 0x87812F8 Offset: 0x877D2F8 VA: 0x87812F8
	public void Stop() { }

	// RVA: 0x8781334 Offset: 0x877D334 VA: 0x8781334
	public void Pause() { }

	// RVA: 0x8781370 Offset: 0x877D370 VA: 0x8781370
	public void Resume() { }

	[NativeThrows]
	// RVA: 0x87813AC Offset: 0x877D3AC VA: 0x87813AC
	public void RebuildGraph() { }

	// RVA: 0x87813E8 Offset: 0x877D3E8 VA: 0x87813E8 Slot: 4
	public void ClearReferenceValue(PropertyName id) { }

	// RVA: 0x8781474 Offset: 0x877D474 VA: 0x8781474 Slot: 5
	public void SetReferenceValue(PropertyName id, Object value) { }

	// RVA: 0x8781520 Offset: 0x877D520 VA: 0x8781520 Slot: 6
	public Object GetReferenceValue(PropertyName id, out bool idValid) { }

	[NativeMethod("GetBindingFor")]
	// RVA: 0x87815CC Offset: 0x877D5CC VA: 0x87815CC
	public Object GetGenericBinding(Object key) { }

	[NativeMethod("ClearBindingFor")]
	// RVA: 0x8781610 Offset: 0x877D610 VA: 0x8781610
	public void ClearGenericBinding(Object key) { }

	[NativeThrows]
	// RVA: 0x8781654 Offset: 0x877D654 VA: 0x8781654
	public void RebindPlayableGraphOutputs() { }

	// RVA: 0x8781690 Offset: 0x877D690 VA: 0x8781690
	internal void ProcessPendingGraphChanges() { }

	[NativeMethod("HasBinding")]
	// RVA: 0x87816CC Offset: 0x877D6CC VA: 0x87816CC
	internal bool HasGenericBinding(Object key) { }

	// RVA: 0x87808A4 Offset: 0x877C8A4 VA: 0x87808A4
	private PlayState GetPlayState() { }

	// RVA: 0x8780924 Offset: 0x877C924 VA: 0x8780924
	private void SetWrapMode(DirectorWrapMode mode) { }

	// RVA: 0x87809A4 Offset: 0x877C9A4 VA: 0x87809A4
	private DirectorWrapMode GetWrapMode() { }

	[NativeThrows]
	// RVA: 0x8780CD8 Offset: 0x877CCD8 VA: 0x8780CD8
	private void EvaluateNextFrame() { }

	// RVA: 0x8780B48 Offset: 0x877CB48 VA: 0x8780B48
	private PlayableGraph GetGraphHandle() { }

	// RVA: 0x8780C58 Offset: 0x877CC58 VA: 0x8780C58
	private void SetPlayOnAwake(bool on) { }

	// RVA: 0x8780BD8 Offset: 0x877CBD8 VA: 0x8780BD8
	private bool GetPlayOnAwake() { }

	[NativeThrows]
	// RVA: 0x8781058 Offset: 0x877D058 VA: 0x8781058
	private void Internal_SetGenericBinding(Object key, Object value) { }

	// RVA: 0x8780B00 Offset: 0x877CB00 VA: 0x8780B00
	private void SetPlayableAsset(ScriptableObject asset) { }

	// RVA: 0x8780A80 Offset: 0x877CA80 VA: 0x8780A80
	private ScriptableObject Internal_GetPlayableAsset() { }

	[CompilerGenerated]
	// RVA: 0x8781754 Offset: 0x877D754 VA: 0x8781754
	public void add_played(Action<PlayableDirector> value) { }

	[CompilerGenerated]
	// RVA: 0x8781804 Offset: 0x877D804 VA: 0x8781804
	public void remove_played(Action<PlayableDirector> value) { }

	[CompilerGenerated]
	// RVA: 0x87818B4 Offset: 0x877D8B4 VA: 0x87818B4
	public void add_paused(Action<PlayableDirector> value) { }

	[CompilerGenerated]
	// RVA: 0x8781964 Offset: 0x877D964 VA: 0x8781964
	public void remove_paused(Action<PlayableDirector> value) { }

	[CompilerGenerated]
	// RVA: 0x8781A14 Offset: 0x877DA14 VA: 0x8781A14
	public void add_stopped(Action<PlayableDirector> value) { }

	[CompilerGenerated]
	// RVA: 0x8781AC4 Offset: 0x877DAC4 VA: 0x8781AC4
	public void remove_stopped(Action<PlayableDirector> value) { }

	[StaticAccessor("GetDirectorManager()", 0)]
	[NativeHeader("Runtime/Director/Core/DirectorManager.h")]
	// RVA: 0x8781B74 Offset: 0x877DB74 VA: 0x8781B74
	internal static void ResetFrameTiming() { }

	[RequiredByNativeCode]
	// RVA: 0x8781B9C Offset: 0x877DB9C VA: 0x8781B9C
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	// RVA: 0x8781BBC Offset: 0x877DBBC VA: 0x8781BBC
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	// RVA: 0x8781BDC Offset: 0x877DBDC VA: 0x8781BDC
	private void SendOnPlayableDirectorStop() { }

	// RVA: 0x8781BFC Offset: 0x877DBFC VA: 0x8781BFC
	public void .ctor() { }

	// RVA: 0x87812B4 Offset: 0x877D2B4 VA: 0x87812B4
	private void PlayOnFrame_Injected(ref FrameRate frameRate) { }

	// RVA: 0x8781430 Offset: 0x877D430 VA: 0x8781430 Slot: 7
	private void ClearReferenceValue_Injected(ref PropertyName id) { }

	// RVA: 0x87814CC Offset: 0x877D4CC VA: 0x87814CC Slot: 8
	private void SetReferenceValue_Injected(ref PropertyName id, Object value) { }

	// RVA: 0x8781578 Offset: 0x877D578 VA: 0x8781578 Slot: 9
	private Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) { }

	// RVA: 0x8781710 Offset: 0x877D710 VA: 0x8781710
	private void GetGraphHandle_Injected(out PlayableGraph ret) { }
}

