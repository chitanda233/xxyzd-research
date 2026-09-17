// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28346
{}

// Namespace: UnityEngine
public enum AudioDataLoadState // TypeDefIndex: 28347
{
	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;
}

// Namespace: UnityEngine
public enum AudioClipLoadType // TypeDefIndex: 28348
{
	// Fields
	public int value__; // 0x0
	public const AudioClipLoadType DecompressOnLoad = 0;
	public const AudioClipLoadType CompressedInMemory = 1;
	public const AudioClipLoadType Streaming = 2;
}

// Namespace: UnityEngine
public enum AudioVelocityUpdateMode // TypeDefIndex: 28349
{
	// Fields
	public int value__; // 0x0
	public const AudioVelocityUpdateMode Auto = 0;
	public const AudioVelocityUpdateMode Fixed = 1;
	public const AudioVelocityUpdateMode Dynamic = 2;
}

// Namespace: UnityEngine
public enum FFTWindow // TypeDefIndex: 28350
{
	// Fields
	public int value__; // 0x0
	public const FFTWindow Rectangular = 0;
	public const FFTWindow Triangle = 1;
	public const FFTWindow Hamming = 2;
	public const FFTWindow Hanning = 3;
	public const FFTWindow Blackman = 4;
	public const FFTWindow BlackmanHarris = 5;
}

// Namespace: UnityEngine
public enum AudioRolloffMode // TypeDefIndex: 28351
{
	// Fields
	public int value__; // 0x0
	public const AudioRolloffMode Logarithmic = 0;
	public const AudioRolloffMode Linear = 1;
	public const AudioRolloffMode Custom = 2;
}

// Namespace: UnityEngine
public enum AudioSourceCurveType // TypeDefIndex: 28352
{
	// Fields
	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;
}

// Namespace: 
public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 28353
{
	// Methods

	// RVA: 0x86DDA84 Offset: 0x86D9A84 VA: 0x86DDA84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86DDB24 Offset: 0x86D9B24 VA: 0x86DDB24 Slot: 13
	public virtual void Invoke(bool deviceWasChanged) { }
}

// Namespace: 
public static class AudioSettings.Mobile // TypeDefIndex: 28354
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> OnMuteStateChanged; // 0x8

	// Properties
	public static bool muteState { get; set; }
	public static bool stopAudioOutputOnMute { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86DDB3C Offset: 0x86D9B3C VA: 0x86DDB3C
	public static bool get_muteState() { }

	[CompilerGenerated]
	// RVA: 0x86DDB84 Offset: 0x86D9B84 VA: 0x86DDB84
	private static void set_muteState(bool value) { }

	// RVA: 0x86DDBD4 Offset: 0x86D9BD4 VA: 0x86DDBD4
	public static bool get_stopAudioOutputOnMute() { }

	[RequiredByNativeCode]
	// RVA: 0x86DDC1C Offset: 0x86D9C1C VA: 0x86DDC1C
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	[RequiredByNativeCode]
	// RVA: 0x86DDDEC Offset: 0x86D9DEC VA: 0x86DDDEC
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x86DDDC4 Offset: 0x86D9DC4 VA: 0x86DDDC4
	public static void StartAudioOutput() { }

	// RVA: 0x86DDD9C Offset: 0x86D9D9C VA: 0x86DDD9C
	public static void StopAudioOutput() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", 0)]
public sealed class AudioSettings // TypeDefIndex: 28355
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x86DD900 Offset: 0x86D9900 VA: 0x86DD900
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x86DD96C Offset: 0x86D996C VA: 0x86DD96C
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x86DD9D0 Offset: 0x86D99D0 VA: 0x86DD9D0
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x86DDA34 Offset: 0x86D9A34 VA: 0x86DDA34
	internal static bool StartAudioOutput() { }

	// RVA: 0x86DDA5C Offset: 0x86D9A5C VA: 0x86DDA5C
	internal static bool StopAudioOutput() { }
}

// Namespace: 
public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 28356
{
	// Methods

	// RVA: 0x86DEB54 Offset: 0x86DAB54 VA: 0x86DEB54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86DEC04 Offset: 0x86DAC04 VA: 0x86DEC04 Slot: 13
	public virtual void Invoke(float[] data) { }
}

// Namespace: 
public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 28357
{
	// Methods

	// RVA: 0x86DEC18 Offset: 0x86DAC18 VA: 0x86DEC18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86DECB8 Offset: 0x86DACB8 VA: 0x86DECB8 Slot: 13
	public virtual void Invoke(int position) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", 2)]
public sealed class AudioClip : Object // TypeDefIndex: 28358
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }
	[NativeProperty("SampleCount")]
	public int samples { get; }
	[NativeProperty("ChannelCount")]
	public int channels { get; }
	public int frequency { get; }
	[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
	public bool isReadyToPlay { get; }
	public AudioClipLoadType loadType { get; }
	public bool preloadAudioData { get; }
	public bool ambisonic { get; }
	public bool loadInBackground { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x86DDE34 Offset: 0x86D9E34 VA: 0x86DDE34
	private void .ctor() { }

	// RVA: 0x86DDEAC Offset: 0x86D9EAC VA: 0x86DDEAC
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x86DDF08 Offset: 0x86D9F08 VA: 0x86DDF08
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x86DDF64 Offset: 0x86D9F64 VA: 0x86DDF64
	private static AudioClip Construct_Internal() { }

	// RVA: 0x86DDF8C Offset: 0x86D9F8C VA: 0x86DDF8C
	private string GetName() { }

	// RVA: 0x86DDFC8 Offset: 0x86D9FC8 VA: 0x86DDFC8
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x86DE03C Offset: 0x86DA03C VA: 0x86DE03C
	public float get_length() { }

	// RVA: 0x86DE078 Offset: 0x86DA078 VA: 0x86DE078
	public int get_samples() { }

	// RVA: 0x86DE0B4 Offset: 0x86DA0B4 VA: 0x86DE0B4
	public int get_channels() { }

	// RVA: 0x86DE0F0 Offset: 0x86DA0F0 VA: 0x86DE0F0
	public int get_frequency() { }

	[NativeName("ReadyToPlay")]
	// RVA: 0x86DE12C Offset: 0x86DA12C VA: 0x86DE12C
	public bool get_isReadyToPlay() { }

	// RVA: 0x86DE168 Offset: 0x86DA168 VA: 0x86DE168
	public AudioClipLoadType get_loadType() { }

	// RVA: 0x86DE1A4 Offset: 0x86DA1A4 VA: 0x86DE1A4
	public bool LoadAudioData() { }

	// RVA: 0x86DE1E0 Offset: 0x86DA1E0 VA: 0x86DE1E0
	public bool UnloadAudioData() { }

	// RVA: 0x86DE21C Offset: 0x86DA21C VA: 0x86DE21C
	public bool get_preloadAudioData() { }

	// RVA: 0x86DE258 Offset: 0x86DA258 VA: 0x86DE258
	public bool get_ambisonic() { }

	// RVA: 0x86DE294 Offset: 0x86DA294 VA: 0x86DE294
	public bool get_loadInBackground() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	// RVA: 0x86DE2D0 Offset: 0x86DA2D0 VA: 0x86DE2D0
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x86DE30C Offset: 0x86DA30C VA: 0x86DE30C
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x86DE494 Offset: 0x86DA494 VA: 0x86DE494
	public bool SetData(float[] data, int offsetSamples) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x86DE6B8 Offset: 0x86DA6B8 VA: 0x86DE6B8
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x86DE6D8 Offset: 0x86DA6D8 VA: 0x86DE6D8
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	// RVA: 0x86DE890 Offset: 0x86DA890 VA: 0x86DE890
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	// RVA: 0x86DE6C8 Offset: 0x86DA6C8 VA: 0x86DE6C8
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x86DE8A0 Offset: 0x86DA8A0 VA: 0x86DE8A0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x86DE6E8 Offset: 0x86DA6E8 VA: 0x86DE6E8
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGenerated]
	// RVA: 0x86DE8AC Offset: 0x86DA8AC VA: 0x86DE8AC
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x86DE9E4 Offset: 0x86DA9E4 VA: 0x86DE9E4
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGenerated]
	// RVA: 0x86DE948 Offset: 0x86DA948 VA: 0x86DE948
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGenerated]
	// RVA: 0x86DEA80 Offset: 0x86DAA80 VA: 0x86DEA80
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCode]
	// RVA: 0x86DEB1C Offset: 0x86DAB1C VA: 0x86DEB1C
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x86DEB38 Offset: 0x86DAB38 VA: 0x86DEB38
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}

// Namespace: UnityEngine
public class AudioBehaviour : Behaviour // TypeDefIndex: 28359
{
	// Methods

	// RVA: 0x86DECCC Offset: 0x86DACCC VA: 0x86DECCC
	public void .ctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioListenerBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 28360
{
	// Properties
	public static float volume { get; set; }
	[NativeProperty("ListenerPause")]
	public static bool pause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }

	// Methods

	[NativeThrows]
	// RVA: 0x86DECD4 Offset: 0x86DACD4 VA: 0x86DECD4
	private static void GetOutputDataHelper([Out] float[] samples, int channel) { }

	[NativeThrows]
	// RVA: 0x86DED18 Offset: 0x86DAD18 VA: 0x86DED18
	private static void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x86DED6C Offset: 0x86DAD6C VA: 0x86DED6C
	public static float get_volume() { }

	// RVA: 0x86DED94 Offset: 0x86DAD94 VA: 0x86DED94
	public static void set_volume(float value) { }

	// RVA: 0x86DEDCC Offset: 0x86DADCC VA: 0x86DEDCC
	public static bool get_pause() { }

	// RVA: 0x86DEDF4 Offset: 0x86DADF4 VA: 0x86DEDF4
	public static void set_pause(bool value) { }

	// RVA: 0x86DEE30 Offset: 0x86DAE30 VA: 0x86DEE30
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x86DEE6C Offset: 0x86DAE6C VA: 0x86DEE6C
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	// RVA: 0x86DEEB0 Offset: 0x86DAEB0 VA: 0x86DEEB0
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x86DEF3C Offset: 0x86DAF3C VA: 0x86DEF3C
	public static void GetOutputData(float[] samples, int channel) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	// RVA: 0x86DEF80 Offset: 0x86DAF80 VA: 0x86DEF80
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x86DF014 Offset: 0x86DB014 VA: 0x86DF014
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x86DF068 Offset: 0x86DB068 VA: 0x86DF068
	public void .ctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioSourceBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 28361
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativeProperty("SecPosition")]
	public float time { get; set; }
	[NativeProperty("SamplePosition")]
	public int timeSamples { get; set; }
	[NativeProperty("AudioClip")]
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativeProperty("StereoPan")]
	public float panStereo { get; set; }
	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float minVolume { get; set; }
	[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float maxVolume { get; set; }
	[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x86DF070 Offset: 0x86DB070 VA: 0x86DF070
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x86DF0AC Offset: 0x86DB0AC VA: 0x86DF0AC
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x86DF0F8 Offset: 0x86DB0F8 VA: 0x86DF0F8
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x86DF13C Offset: 0x86DB13C VA: 0x86DF13C
	private void Play(double delay) { }

	// RVA: 0x86DF188 Offset: 0x86DB188 VA: 0x86DF188
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x86DF1DC Offset: 0x86DB1DC VA: 0x86DF1DC
	private void Stop(bool stopOneShots) { }

	[NativeThrows]
	// RVA: 0x86DF220 Offset: 0x86DB220 VA: 0x86DF220
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x86DF274 Offset: 0x86DB274 VA: 0x86DF274
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x86DF2B8 Offset: 0x86DB2B8 VA: 0x86DF2B8
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrows]
	// RVA: 0x86DF30C Offset: 0x86DB30C VA: 0x86DF30C
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x86DF368 Offset: 0x86DB368 VA: 0x86DF368
	public float get_volume() { }

	// RVA: 0x86DF3A4 Offset: 0x86DB3A4 VA: 0x86DF3A4
	public void set_volume(float value) { }

	// RVA: 0x86DF3F0 Offset: 0x86DB3F0 VA: 0x86DF3F0
	public float get_pitch() { }

	// RVA: 0x86DF42C Offset: 0x86DB42C VA: 0x86DF42C
	public void set_pitch(float value) { }

	// RVA: 0x86DF478 Offset: 0x86DB478 VA: 0x86DF478
	public float get_time() { }

	// RVA: 0x86DF4B4 Offset: 0x86DB4B4 VA: 0x86DF4B4
	public void set_time(float value) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x86DF500 Offset: 0x86DB500 VA: 0x86DF500
	public int get_timeSamples() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x86DF53C Offset: 0x86DB53C VA: 0x86DF53C
	public void set_timeSamples(int value) { }

	// RVA: 0x86DF580 Offset: 0x86DB580 VA: 0x86DF580
	public AudioClip get_clip() { }

	// RVA: 0x86DF5BC Offset: 0x86DB5BC VA: 0x86DF5BC
	public void set_clip(AudioClip value) { }

	// RVA: 0x86DF600 Offset: 0x86DB600 VA: 0x86DF600
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x86DF63C Offset: 0x86DB63C VA: 0x86DF63C
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocs]
	// RVA: 0x86DF680 Offset: 0x86DB680 VA: 0x86DF680
	public void Play() { }

	// RVA: 0x86DF6C0 Offset: 0x86DB6C0 VA: 0x86DF6C0
	public void Play(ulong delay) { }

	// RVA: 0x86DF704 Offset: 0x86DB704 VA: 0x86DF704
	public void PlayDelayed(float delay) { }

	// RVA: 0x86DF768 Offset: 0x86DB768 VA: 0x86DF768
	public void PlayScheduled(double time) { }

	[ExcludeFromDocs]
	// RVA: 0x86DF7C0 Offset: 0x86DB7C0 VA: 0x86DF7C0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x86DF7C8 Offset: 0x86DB7C8 VA: 0x86DF7C8
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x86DF8C4 Offset: 0x86DB8C4 VA: 0x86DF8C4
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x86DF910 Offset: 0x86DB910 VA: 0x86DF910
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x86DF95C Offset: 0x86DB95C VA: 0x86DF95C
	public void Stop() { }

	// RVA: 0x86DF99C Offset: 0x86DB99C VA: 0x86DF99C
	public void Pause() { }

	// RVA: 0x86DF9D8 Offset: 0x86DB9D8 VA: 0x86DF9D8
	public void UnPause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x86DFA14 Offset: 0x86DBA14 VA: 0x86DFA14
	public bool get_isPlaying() { }

	[NativeName("GetLastVirtualState")]
	// RVA: 0x86DFA50 Offset: 0x86DBA50 VA: 0x86DFA50
	public bool get_isVirtual() { }

	[ExcludeFromDocs]
	// RVA: 0x86DFA8C Offset: 0x86DBA8C VA: 0x86DFA8C
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x86DFA94 Offset: 0x86DBA94 VA: 0x86DFA94
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x86DFD60 Offset: 0x86DBD60 VA: 0x86DFD60
	public bool get_loop() { }

	// RVA: 0x86DFD9C Offset: 0x86DBD9C VA: 0x86DFD9C
	public void set_loop(bool value) { }

	// RVA: 0x86DFDE0 Offset: 0x86DBDE0 VA: 0x86DFDE0
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x86DFE1C Offset: 0x86DBE1C VA: 0x86DFE1C
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x86DFE60 Offset: 0x86DBE60 VA: 0x86DFE60
	public bool get_playOnAwake() { }

	// RVA: 0x86DFE9C Offset: 0x86DBE9C VA: 0x86DFE9C
	public void set_playOnAwake(bool value) { }

	// RVA: 0x86DFEE0 Offset: 0x86DBEE0 VA: 0x86DFEE0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x86DFF1C Offset: 0x86DBF1C VA: 0x86DFF1C
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x86DFF60 Offset: 0x86DBF60 VA: 0x86DFF60
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x86DFF9C Offset: 0x86DBF9C VA: 0x86DFF9C
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x86DFFE0 Offset: 0x86DBFE0 VA: 0x86DFFE0
	public float get_panStereo() { }

	// RVA: 0x86E001C Offset: 0x86DC01C VA: 0x86E001C
	public void set_panStereo(float value) { }

	// RVA: 0x86E0068 Offset: 0x86DC068 VA: 0x86E0068
	public float get_spatialBlend() { }

	// RVA: 0x86DFD14 Offset: 0x86DBD14 VA: 0x86DFD14
	public void set_spatialBlend(float value) { }

	// RVA: 0x86E00A4 Offset: 0x86DC0A4 VA: 0x86E00A4
	public bool get_spatialize() { }

	// RVA: 0x86E00E0 Offset: 0x86DC0E0 VA: 0x86E00E0
	public void set_spatialize(bool value) { }

	// RVA: 0x86E0124 Offset: 0x86DC124 VA: 0x86E0124
	public bool get_spatializePostEffects() { }

	// RVA: 0x86E0160 Offset: 0x86DC160 VA: 0x86E0160
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x86E01A4 Offset: 0x86DC1A4 VA: 0x86E01A4
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x86E01F8 Offset: 0x86DC1F8 VA: 0x86E01F8
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x86E023C Offset: 0x86DC23C VA: 0x86E023C
	public float get_reverbZoneMix() { }

	// RVA: 0x86E0278 Offset: 0x86DC278 VA: 0x86E0278
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x86E02C4 Offset: 0x86DC2C4 VA: 0x86E02C4
	public bool get_bypassEffects() { }

	// RVA: 0x86E0300 Offset: 0x86DC300 VA: 0x86E0300
	public void set_bypassEffects(bool value) { }

	// RVA: 0x86E0344 Offset: 0x86DC344 VA: 0x86E0344
	public bool get_bypassListenerEffects() { }

	// RVA: 0x86E0380 Offset: 0x86DC380 VA: 0x86E0380
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x86E03C4 Offset: 0x86DC3C4 VA: 0x86E03C4
	public bool get_bypassReverbZones() { }

	// RVA: 0x86E0400 Offset: 0x86DC400 VA: 0x86E0400
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x86E0444 Offset: 0x86DC444 VA: 0x86E0444
	public float get_dopplerLevel() { }

	// RVA: 0x86E0480 Offset: 0x86DC480 VA: 0x86E0480
	public void set_dopplerLevel(float value) { }

	// RVA: 0x86E04CC Offset: 0x86DC4CC VA: 0x86E04CC
	public float get_spread() { }

	// RVA: 0x86E0508 Offset: 0x86DC508 VA: 0x86E0508
	public void set_spread(float value) { }

	// RVA: 0x86E0554 Offset: 0x86DC554 VA: 0x86E0554
	public int get_priority() { }

	// RVA: 0x86E0590 Offset: 0x86DC590 VA: 0x86E0590
	public void set_priority(int value) { }

	// RVA: 0x86E05D4 Offset: 0x86DC5D4 VA: 0x86E05D4
	public bool get_mute() { }

	// RVA: 0x86E0610 Offset: 0x86DC610 VA: 0x86E0610
	public void set_mute(bool value) { }

	// RVA: 0x86E0654 Offset: 0x86DC654 VA: 0x86E0654
	public float get_minDistance() { }

	// RVA: 0x86E0690 Offset: 0x86DC690 VA: 0x86E0690
	public void set_minDistance(float value) { }

	// RVA: 0x86E06DC Offset: 0x86DC6DC VA: 0x86E06DC
	public float get_maxDistance() { }

	// RVA: 0x86E0718 Offset: 0x86DC718 VA: 0x86E0718
	public void set_maxDistance(float value) { }

	// RVA: 0x86E0764 Offset: 0x86DC764 VA: 0x86E0764
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x86E07A0 Offset: 0x86DC7A0 VA: 0x86E07A0
	public void set_rolloffMode(AudioRolloffMode value) { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	// RVA: 0x86E07E4 Offset: 0x86DC7E4 VA: 0x86E07E4
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x86E0878 Offset: 0x86DC878 VA: 0x86E0878
	public void GetOutputData(float[] samples, int channel) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	// RVA: 0x86E08CC Offset: 0x86DC8CC VA: 0x86E08CC
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x86E0970 Offset: 0x86DC970 VA: 0x86E0970
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x86E09CC Offset: 0x86DC9CC VA: 0x86E09CC
	public float get_minVolume() { }

	// RVA: 0x86E0A3C Offset: 0x86DCA3C VA: 0x86E0A3C
	public void set_minVolume(float value) { }

	// RVA: 0x86E0AA4 Offset: 0x86DCAA4 VA: 0x86E0AA4
	public float get_maxVolume() { }

	// RVA: 0x86E0B14 Offset: 0x86DCB14 VA: 0x86E0B14
	public void set_maxVolume(float value) { }

	// RVA: 0x86E0B7C Offset: 0x86DCB7C VA: 0x86E0B7C
	public float get_rolloffFactor() { }

	// RVA: 0x86E0BEC Offset: 0x86DCBEC VA: 0x86E0BEC
	public void set_rolloffFactor(float value) { }

	// RVA: 0x86E0C54 Offset: 0x86DCC54 VA: 0x86E0C54
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x86E0CA8 Offset: 0x86DCCA8 VA: 0x86E0CA8
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x86E0CFC Offset: 0x86DCCFC VA: 0x86E0CFC
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x86E0D50 Offset: 0x86DCD50 VA: 0x86E0D50
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x86E0DA4 Offset: 0x86DCDA4 VA: 0x86E0DA4
	public void .ctor() { }
}

// Namespace: 
public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 28362
{
	// Methods

	// RVA: 0x86E0DFC Offset: 0x86DCDFC VA: 0x86E0DFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86E0F08 Offset: 0x86DCF08 VA: 0x86E0F08 Slot: 13
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }
}

// Namespace: UnityEngine.Experimental.Audio
[StaticAccessor("AudioSampleProviderBindings", 2)]
[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
public class AudioSampleProvider // TypeDefIndex: 28363
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x86E0DAC Offset: 0x86DCDAC VA: 0x86E0DAC
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x86E0DD4 Offset: 0x86DCDD4 VA: 0x86E0DD4
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[StaticAccessor("AudioClipPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable> // TypeDefIndex: 28364
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x86E0F1C Offset: 0x86DCF1C VA: 0x86E0F1C Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86E0F28 Offset: 0x86DCF28 VA: 0x86E0F28 Slot: 5
	public bool Equals(AudioClipPlayable other) { }
}

// Namespace: UnityEngine.Audio
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
public class AudioMixer : Object // TypeDefIndex: 28365
{
	// Methods

	// RVA: 0x86E0FA0 Offset: 0x86DCFA0 VA: 0x86E0FA0
	internal void .ctor() { }

	[NativeMethod]
	// RVA: 0x86E0FF8 Offset: 0x86DCFF8 VA: 0x86E0FF8
	public bool SetFloat(string name, float value) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object // TypeDefIndex: 28366
{
	// Methods

	// RVA: 0x86E104C Offset: 0x86DD04C VA: 0x86E104C
	internal void .ctor() { }
}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable> // TypeDefIndex: 28367
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x86E10A4 Offset: 0x86DD0A4 VA: 0x86E10A4 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x86E10B0 Offset: 0x86DD0B0 VA: 0x86E10B0 Slot: 5
	public bool Equals(AudioMixerPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object // TypeDefIndex: 28368
{}

// Namespace: UnityEngine.Audio
[StaticAccessor("AudioPlayableOutputBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 28369
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x86E1128 Offset: 0x86DD128 VA: 0x86E1128
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x86E1218 Offset: 0x86DD218 VA: 0x86E1218 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x86E1224 Offset: 0x86DD224 VA: 0x86E1224
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x86E12A8 Offset: 0x86DD2A8 VA: 0x86E12A8
	public void SetEvaluateOnSeek(bool value) { }

	[NativeThrows]
	// RVA: 0x86E12EC Offset: 0x86DD2EC VA: 0x86E12EC
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }
}

