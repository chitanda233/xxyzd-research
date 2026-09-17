// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28492
{}

// Namespace: UnityEngine.Experimental.Video
[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("VideoClipPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable> // TypeDefIndex: 28493
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x89C3828 Offset: 0x89BF828 VA: 0x89C3828 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x89C3834 Offset: 0x89BF834 VA: 0x89C3834 Slot: 5
	public bool Equals(VideoClipPlayable other) { }
}

// Namespace: UnityEngine.Video
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
public sealed class VideoClip : Object // TypeDefIndex: 28494
{
	// Properties
	public string originalPath { get; }
	public ulong frameCount { get; }
	public double frameRate { get; }
	[NativeName("Duration")]
	public double length { get; }
	public uint width { get; }
	public uint height { get; }
	public uint pixelAspectRatioNumerator { get; }
	public uint pixelAspectRatioDenominator { get; }
	public bool sRGB { get; }
	public ushort audioTrackCount { get; }

	// Methods

	// RVA: 0x89C38AC Offset: 0x89BF8AC VA: 0x89C38AC
	private void .ctor() { }

	// RVA: 0x89C3904 Offset: 0x89BF904 VA: 0x89C3904
	public string get_originalPath() { }

	// RVA: 0x89C3940 Offset: 0x89BF940 VA: 0x89C3940
	public ulong get_frameCount() { }

	// RVA: 0x89C397C Offset: 0x89BF97C VA: 0x89C397C
	public double get_frameRate() { }

	// RVA: 0x89C39B8 Offset: 0x89BF9B8 VA: 0x89C39B8
	public double get_length() { }

	// RVA: 0x89C39F4 Offset: 0x89BF9F4 VA: 0x89C39F4
	public uint get_width() { }

	// RVA: 0x89C3A30 Offset: 0x89BFA30 VA: 0x89C3A30
	public uint get_height() { }

	// RVA: 0x89C3A6C Offset: 0x89BFA6C VA: 0x89C3A6C
	public uint get_pixelAspectRatioNumerator() { }

	// RVA: 0x89C3AA8 Offset: 0x89BFAA8 VA: 0x89C3AA8
	public uint get_pixelAspectRatioDenominator() { }

	[NativeName("IssRGB")]
	// RVA: 0x89C3AE4 Offset: 0x89BFAE4 VA: 0x89C3AE4
	public bool get_sRGB() { }

	// RVA: 0x89C3B20 Offset: 0x89BFB20 VA: 0x89C3B20
	public ushort get_audioTrackCount() { }

	// RVA: 0x89C3B5C Offset: 0x89BFB5C VA: 0x89C3B5C
	public ushort GetAudioChannelCount(ushort audioTrackIdx) { }

	// RVA: 0x89C3BA0 Offset: 0x89BFBA0 VA: 0x89C3BA0
	public uint GetAudioSampleRate(ushort audioTrackIdx) { }

	// RVA: 0x89C3BE4 Offset: 0x89BFBE4 VA: 0x89C3BE4
	public string GetAudioLanguage(ushort audioTrackIdx) { }
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoRenderMode // TypeDefIndex: 28495
{
	// Fields
	public int value__; // 0x0
	public const VideoRenderMode CameraFarPlane = 0;
	public const VideoRenderMode CameraNearPlane = 1;
	public const VideoRenderMode RenderTexture = 2;
	public const VideoRenderMode MaterialOverride = 3;
	public const VideoRenderMode APIOnly = 4;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum Video3DLayout // TypeDefIndex: 28496
{
	// Fields
	public int value__; // 0x0
	public const Video3DLayout No3D = 0;
	public const Video3DLayout SideBySide3D = 1;
	public const Video3DLayout OverUnder3D = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAspectRatio // TypeDefIndex: 28497
{
	// Fields
	public int value__; // 0x0
	public const VideoAspectRatio NoScaling = 0;
	public const VideoAspectRatio FitVertically = 1;
	public const VideoAspectRatio FitHorizontally = 2;
	public const VideoAspectRatio FitInside = 3;
	public const VideoAspectRatio FitOutside = 4;
	public const VideoAspectRatio Stretch = 5;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
[Obsolete("VideoTimeSource is deprecated. Use TimeUpdateMode instead. (UnityUpgradable) -> VideoTimeUpdateMode")]
public enum VideoTimeSource // TypeDefIndex: 28498
{
	// Fields
	public int value__; // 0x0
	[Obsolete("AudioDSPTimeSource is deprecated. Use DSPTime instead. (UnityUpgradable) -> DSPTime")]
	public const VideoTimeSource AudioDSPTimeSource = 0;
	[Obsolete("GameTimeSource is deprecated. Use GameTime instead. (UnityUpgradable) -> GameTime")]
	public const VideoTimeSource GameTimeSource = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeReference // TypeDefIndex: 28499
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeReference Freerun = 0;
	public const VideoTimeReference InternalTime = 1;
	public const VideoTimeReference ExternalTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoSource // TypeDefIndex: 28500
{
	// Fields
	public int value__; // 0x0
	public const VideoSource VideoClip = 0;
	public const VideoSource Url = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeUpdateMode // TypeDefIndex: 28501
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeUpdateMode DSPTime = 0;
	public const VideoTimeUpdateMode GameTime = 1;
	public const VideoTimeUpdateMode UnscaledGameTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAudioOutputMode // TypeDefIndex: 28502
{
	// Fields
	public int value__; // 0x0
	public const VideoAudioOutputMode None = 0;
	public const VideoAudioOutputMode AudioSource = 1;
	public const VideoAudioOutputMode Direct = 2;
	public const VideoAudioOutputMode APIOnly = 3;
}

// Namespace: 
public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 28503
{
	// Methods

	// RVA: 0x89C5EA4 Offset: 0x89C1EA4 VA: 0x89C5EA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89C5F54 Offset: 0x89C1F54 VA: 0x89C5F54 Slot: 13
	public virtual void Invoke(VideoPlayer source) { }
}

// Namespace: 
public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 28504
{
	// Methods

	// RVA: 0x89C5F68 Offset: 0x89C1F68 VA: 0x89C5F68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89C601C Offset: 0x89C201C VA: 0x89C601C Slot: 13
	public virtual void Invoke(VideoPlayer source, string message) { }
}

// Namespace: 
public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 28505
{
	// Methods

	// RVA: 0x89C6030 Offset: 0x89C2030 VA: 0x89C6030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89C60E4 Offset: 0x89C20E4 VA: 0x89C60E4 Slot: 13
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }
}

// Namespace: 
public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 28506
{
	// Methods

	// RVA: 0x89C60F8 Offset: 0x89C20F8 VA: 0x89C60F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89C61AC Offset: 0x89C21AC VA: 0x89C61AC Slot: 13
	public virtual void Invoke(VideoPlayer source, double seconds) { }
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 28507
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	public VideoSource source { get; set; }
	public VideoTimeUpdateMode timeUpdateMode { get; set; }
	[NativeName("VideoUrl")]
	public string url { get; set; }
	[NativeName("VideoClip")]
	public VideoClip clip { get; set; }
	public VideoRenderMode renderMode { get; set; }
	public bool canSetTimeUpdateMode { get; }
	[NativeHeader("Runtime/Camera/Camera.h")]
	public Camera targetCamera { get; set; }
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public RenderTexture targetTexture { get; set; }
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public Renderer targetMaterialRenderer { get; set; }
	public string targetMaterialProperty { get; set; }
	public VideoAspectRatio aspectRatio { get; set; }
	public float targetCameraAlpha { get; set; }
	public Video3DLayout targetCamera3DLayout { get; set; }
	[NativeHeader("Runtime/Graphics/Texture.h")]
	public Texture texture { get; }
	public bool isPrepared { get; }
	public bool waitForFirstFrame { get; set; }
	public bool playOnAwake { get; set; }
	public bool isPlaying { get; }
	public bool isPaused { get; }
	public bool canSetTime { get; }
	[NativeName("SecPosition")]
	public double time { get; set; }
	[NativeName("FramePosition")]
	public long frame { get; set; }
	public double clockTime { get; }
	public bool canStep { get; }
	public bool canSetPlaybackSpeed { get; }
	public float playbackSpeed { get; set; }
	[NativeName("Loop")]
	public bool isLooping { get; set; }
	[Obsolete("VideoPlayer.canSetTimeSource is deprecated. Use canSetTimeUpdateMode instead. (UnityUpgradable) -> canSetTimeUpdateMode")]
	public bool canSetTimeSource { get; }
	[Obsolete("VideoPlayer.timeSource is deprecated. Use timeUpdateMode instead. (UnityUpgradable) -> timeUpdateMode")]
	public VideoTimeSource timeSource { get; set; }
	public VideoTimeReference timeReference { get; set; }
	public double externalReferenceTime { get; set; }
	public bool canSetSkipOnDrop { get; }
	public bool skipOnDrop { get; set; }
	public ulong frameCount { get; }
	public float frameRate { get; }
	[NativeName("Duration")]
	public double length { get; }
	public uint width { get; }
	public uint height { get; }
	public uint pixelAspectRatioNumerator { get; }
	public uint pixelAspectRatioDenominator { get; }
	public ushort audioTrackCount { get; }
	public static ushort controlledAudioTrackMaxCount { get; }
	public ushort controlledAudioTrackCount { get; set; }
	public VideoAudioOutputMode audioOutputMode { get; set; }
	public bool canSetDirectAudioVolume { get; }
	public bool sendFrameReadyEvents { get; set; }

	// Methods

	// RVA: 0x89C3C28 Offset: 0x89BFC28 VA: 0x89C3C28
	public VideoSource get_source() { }

	// RVA: 0x89C3C64 Offset: 0x89BFC64 VA: 0x89C3C64
	public void set_source(VideoSource value) { }

	// RVA: 0x89C3CA8 Offset: 0x89BFCA8 VA: 0x89C3CA8
	public VideoTimeUpdateMode get_timeUpdateMode() { }

	// RVA: 0x89C3CE4 Offset: 0x89BFCE4 VA: 0x89C3CE4
	public void set_timeUpdateMode(VideoTimeUpdateMode value) { }

	// RVA: 0x89C3D28 Offset: 0x89BFD28 VA: 0x89C3D28
	public string get_url() { }

	// RVA: 0x89C3D64 Offset: 0x89BFD64 VA: 0x89C3D64
	public void set_url(string value) { }

	// RVA: 0x89C3DA8 Offset: 0x89BFDA8 VA: 0x89C3DA8
	public VideoClip get_clip() { }

	// RVA: 0x89C3DE4 Offset: 0x89BFDE4 VA: 0x89C3DE4
	public void set_clip(VideoClip value) { }

	// RVA: 0x89C3E28 Offset: 0x89BFE28 VA: 0x89C3E28
	public VideoRenderMode get_renderMode() { }

	// RVA: 0x89C3E64 Offset: 0x89BFE64 VA: 0x89C3E64
	public void set_renderMode(VideoRenderMode value) { }

	[NativeName("CanSetTimeUpdateMode")]
	// RVA: 0x89C3EA8 Offset: 0x89BFEA8 VA: 0x89C3EA8
	public bool get_canSetTimeUpdateMode() { }

	// RVA: 0x89C3EE4 Offset: 0x89BFEE4 VA: 0x89C3EE4
	public Camera get_targetCamera() { }

	// RVA: 0x89C3F20 Offset: 0x89BFF20 VA: 0x89C3F20
	public void set_targetCamera(Camera value) { }

	// RVA: 0x89C3F64 Offset: 0x89BFF64 VA: 0x89C3F64
	public RenderTexture get_targetTexture() { }

	// RVA: 0x89C3FA0 Offset: 0x89BFFA0 VA: 0x89C3FA0
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x89C3FE4 Offset: 0x89BFFE4 VA: 0x89C3FE4
	public Renderer get_targetMaterialRenderer() { }

	// RVA: 0x89C4020 Offset: 0x89C0020 VA: 0x89C4020
	public void set_targetMaterialRenderer(Renderer value) { }

	// RVA: 0x89C4064 Offset: 0x89C0064 VA: 0x89C4064
	public string get_targetMaterialProperty() { }

	// RVA: 0x89C40A0 Offset: 0x89C00A0 VA: 0x89C40A0
	public void set_targetMaterialProperty(string value) { }

	// RVA: 0x89C40E4 Offset: 0x89C00E4 VA: 0x89C40E4
	public VideoAspectRatio get_aspectRatio() { }

	// RVA: 0x89C4120 Offset: 0x89C0120 VA: 0x89C4120
	public void set_aspectRatio(VideoAspectRatio value) { }

	// RVA: 0x89C4164 Offset: 0x89C0164 VA: 0x89C4164
	public float get_targetCameraAlpha() { }

	// RVA: 0x89C41A0 Offset: 0x89C01A0 VA: 0x89C41A0
	public void set_targetCameraAlpha(float value) { }

	// RVA: 0x89C41EC Offset: 0x89C01EC VA: 0x89C41EC
	public Video3DLayout get_targetCamera3DLayout() { }

	// RVA: 0x89C4228 Offset: 0x89C0228 VA: 0x89C4228
	public void set_targetCamera3DLayout(Video3DLayout value) { }

	// RVA: 0x89C426C Offset: 0x89C026C VA: 0x89C426C
	public Texture get_texture() { }

	// RVA: 0x89C42A8 Offset: 0x89C02A8 VA: 0x89C42A8
	public void Prepare() { }

	[NativeName("IsPrepared")]
	// RVA: 0x89C42E4 Offset: 0x89C02E4 VA: 0x89C42E4
	public bool get_isPrepared() { }

	// RVA: 0x89C4320 Offset: 0x89C0320 VA: 0x89C4320
	public bool get_waitForFirstFrame() { }

	// RVA: 0x89C435C Offset: 0x89C035C VA: 0x89C435C
	public void set_waitForFirstFrame(bool value) { }

	// RVA: 0x89C43A0 Offset: 0x89C03A0 VA: 0x89C43A0
	public bool get_playOnAwake() { }

	// RVA: 0x89C43DC Offset: 0x89C03DC VA: 0x89C43DC
	public void set_playOnAwake(bool value) { }

	// RVA: 0x89C4420 Offset: 0x89C0420 VA: 0x89C4420
	public void Play() { }

	// RVA: 0x89C445C Offset: 0x89C045C VA: 0x89C445C
	public void Pause() { }

	// RVA: 0x89C4498 Offset: 0x89C0498 VA: 0x89C4498
	public void Stop() { }

	[NativeName("IsPlaying")]
	// RVA: 0x89C44D4 Offset: 0x89C04D4 VA: 0x89C44D4
	public bool get_isPlaying() { }

	[NativeName("IsPaused")]
	// RVA: 0x89C4510 Offset: 0x89C0510 VA: 0x89C4510
	public bool get_isPaused() { }

	[NativeName("CanSetTime")]
	// RVA: 0x89C454C Offset: 0x89C054C VA: 0x89C454C
	public bool get_canSetTime() { }

	// RVA: 0x89C4588 Offset: 0x89C0588 VA: 0x89C4588
	public double get_time() { }

	// RVA: 0x89C45C4 Offset: 0x89C05C4 VA: 0x89C45C4
	public void set_time(double value) { }

	// RVA: 0x89C4610 Offset: 0x89C0610 VA: 0x89C4610
	public long get_frame() { }

	// RVA: 0x89C464C Offset: 0x89C064C VA: 0x89C464C
	public void set_frame(long value) { }

	// RVA: 0x89C4690 Offset: 0x89C0690 VA: 0x89C4690
	public double get_clockTime() { }

	[NativeName("CanStep")]
	// RVA: 0x89C46CC Offset: 0x89C06CC VA: 0x89C46CC
	public bool get_canStep() { }

	// RVA: 0x89C4708 Offset: 0x89C0708 VA: 0x89C4708
	public void StepForward() { }

	[NativeName("CanSetPlaybackSpeed")]
	// RVA: 0x89C4744 Offset: 0x89C0744 VA: 0x89C4744
	public bool get_canSetPlaybackSpeed() { }

	// RVA: 0x89C4780 Offset: 0x89C0780 VA: 0x89C4780
	public float get_playbackSpeed() { }

	// RVA: 0x89C47BC Offset: 0x89C07BC VA: 0x89C47BC
	public void set_playbackSpeed(float value) { }

	// RVA: 0x89C4808 Offset: 0x89C0808 VA: 0x89C4808
	public bool get_isLooping() { }

	// RVA: 0x89C4844 Offset: 0x89C0844 VA: 0x89C4844
	public void set_isLooping(bool value) { }

	[NativeName("CanSetTimeSource")]
	// RVA: 0x89C4888 Offset: 0x89C0888 VA: 0x89C4888
	public bool get_canSetTimeSource() { }

	// RVA: 0x89C48C4 Offset: 0x89C08C4 VA: 0x89C48C4
	public VideoTimeSource get_timeSource() { }

	// RVA: 0x89C4900 Offset: 0x89C0900 VA: 0x89C4900
	public void set_timeSource(VideoTimeSource value) { }

	// RVA: 0x89C4944 Offset: 0x89C0944 VA: 0x89C4944
	public VideoTimeReference get_timeReference() { }

	// RVA: 0x89C4980 Offset: 0x89C0980 VA: 0x89C4980
	public void set_timeReference(VideoTimeReference value) { }

	// RVA: 0x89C49C4 Offset: 0x89C09C4 VA: 0x89C49C4
	public double get_externalReferenceTime() { }

	// RVA: 0x89C4A00 Offset: 0x89C0A00 VA: 0x89C4A00
	public void set_externalReferenceTime(double value) { }

	[NativeName("CanSetSkipOnDrop")]
	// RVA: 0x89C4A4C Offset: 0x89C0A4C VA: 0x89C4A4C
	public bool get_canSetSkipOnDrop() { }

	// RVA: 0x89C4A88 Offset: 0x89C0A88 VA: 0x89C4A88
	public bool get_skipOnDrop() { }

	// RVA: 0x89C4AC4 Offset: 0x89C0AC4 VA: 0x89C4AC4
	public void set_skipOnDrop(bool value) { }

	// RVA: 0x89C4B08 Offset: 0x89C0B08 VA: 0x89C4B08
	public ulong get_frameCount() { }

	// RVA: 0x89C4B44 Offset: 0x89C0B44 VA: 0x89C4B44
	public float get_frameRate() { }

	// RVA: 0x89C4B80 Offset: 0x89C0B80 VA: 0x89C4B80
	public double get_length() { }

	// RVA: 0x89C4BBC Offset: 0x89C0BBC VA: 0x89C4BBC
	public uint get_width() { }

	// RVA: 0x89C4BF8 Offset: 0x89C0BF8 VA: 0x89C4BF8
	public uint get_height() { }

	// RVA: 0x89C4C34 Offset: 0x89C0C34 VA: 0x89C4C34
	public uint get_pixelAspectRatioNumerator() { }

	// RVA: 0x89C4C70 Offset: 0x89C0C70 VA: 0x89C4C70
	public uint get_pixelAspectRatioDenominator() { }

	// RVA: 0x89C4CAC Offset: 0x89C0CAC VA: 0x89C4CAC
	public ushort get_audioTrackCount() { }

	// RVA: 0x89C4CE8 Offset: 0x89C0CE8 VA: 0x89C4CE8
	public string GetAudioLanguageCode(ushort trackIndex) { }

	// RVA: 0x89C4D2C Offset: 0x89C0D2C VA: 0x89C4D2C
	public ushort GetAudioChannelCount(ushort trackIndex) { }

	// RVA: 0x89C4D70 Offset: 0x89C0D70 VA: 0x89C4D70
	public uint GetAudioSampleRate(ushort trackIndex) { }

	// RVA: 0x89C4DB4 Offset: 0x89C0DB4 VA: 0x89C4DB4
	public static ushort get_controlledAudioTrackMaxCount() { }

	// RVA: 0x89C4DDC Offset: 0x89C0DDC VA: 0x89C4DDC
	public ushort get_controlledAudioTrackCount() { }

	// RVA: 0x89C4E54 Offset: 0x89C0E54 VA: 0x89C4E54
	public void set_controlledAudioTrackCount(ushort value) { }

	// RVA: 0x89C4E18 Offset: 0x89C0E18 VA: 0x89C4E18
	private ushort GetControlledAudioTrackCount() { }

	// RVA: 0x89C4F54 Offset: 0x89C0F54 VA: 0x89C4F54
	private void SetControlledAudioTrackCount(ushort value) { }

	// RVA: 0x89C4F98 Offset: 0x89C0F98 VA: 0x89C4F98
	public void EnableAudioTrack(ushort trackIndex, bool enabled) { }

	// RVA: 0x89C4FEC Offset: 0x89C0FEC VA: 0x89C4FEC
	public bool IsAudioTrackEnabled(ushort trackIndex) { }

	// RVA: 0x89C5030 Offset: 0x89C1030 VA: 0x89C5030
	public VideoAudioOutputMode get_audioOutputMode() { }

	// RVA: 0x89C506C Offset: 0x89C106C VA: 0x89C506C
	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	[NativeName("CanSetDirectAudioVolume")]
	// RVA: 0x89C50B0 Offset: 0x89C10B0 VA: 0x89C50B0
	public bool get_canSetDirectAudioVolume() { }

	// RVA: 0x89C50EC Offset: 0x89C10EC VA: 0x89C50EC
	public float GetDirectAudioVolume(ushort trackIndex) { }

	// RVA: 0x89C5130 Offset: 0x89C1130 VA: 0x89C5130
	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	// RVA: 0x89C5184 Offset: 0x89C1184 VA: 0x89C5184
	public bool GetDirectAudioMute(ushort trackIndex) { }

	// RVA: 0x89C51C8 Offset: 0x89C11C8 VA: 0x89C51C8
	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	// RVA: 0x89C521C Offset: 0x89C121C VA: 0x89C521C
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	// RVA: 0x89C5260 Offset: 0x89C1260 VA: 0x89C5260
	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	[CompilerGenerated]
	// RVA: 0x89C52B4 Offset: 0x89C12B4 VA: 0x89C52B4
	public void add_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5350 Offset: 0x89C1350 VA: 0x89C5350
	public void remove_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C53EC Offset: 0x89C13EC VA: 0x89C53EC
	public void add_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5488 Offset: 0x89C1488 VA: 0x89C5488
	public void remove_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5524 Offset: 0x89C1524 VA: 0x89C5524
	public void add_started(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C55C0 Offset: 0x89C15C0 VA: 0x89C55C0
	public void remove_started(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C565C Offset: 0x89C165C VA: 0x89C565C
	public void add_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C56F8 Offset: 0x89C16F8 VA: 0x89C56F8
	public void remove_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5794 Offset: 0x89C1794 VA: 0x89C5794
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5830 Offset: 0x89C1830 VA: 0x89C5830
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C58CC Offset: 0x89C18CC VA: 0x89C58CC
	public void add_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5968 Offset: 0x89C1968 VA: 0x89C5968
	public void remove_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5A04 Offset: 0x89C1A04 VA: 0x89C5A04
	public void add_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5AA0 Offset: 0x89C1AA0 VA: 0x89C5AA0
	public void remove_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[NativeName("AreFrameReadyEventsEnabled")]
	// RVA: 0x89C5B3C Offset: 0x89C1B3C VA: 0x89C5B3C
	public bool get_sendFrameReadyEvents() { }

	[NativeName("EnableFrameReadyEvents")]
	// RVA: 0x89C5B78 Offset: 0x89C1B78 VA: 0x89C5B78
	public void set_sendFrameReadyEvents(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89C5BBC Offset: 0x89C1BBC VA: 0x89C5BBC
	public void add_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x89C5C58 Offset: 0x89C1C58 VA: 0x89C5C58
	public void remove_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5CF4 Offset: 0x89C1CF4 VA: 0x89C5CF4
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5D28 Offset: 0x89C1D28 VA: 0x89C5D28
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5D60 Offset: 0x89C1D60 VA: 0x89C5D60
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5D94 Offset: 0x89C1D94 VA: 0x89C5D94
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5DC8 Offset: 0x89C1DC8 VA: 0x89C5DC8
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5DFC Offset: 0x89C1DFC VA: 0x89C5DFC
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5E34 Offset: 0x89C1E34 VA: 0x89C5E34
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x89C5E68 Offset: 0x89C1E68 VA: 0x89C5E68
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	// RVA: 0x89C5E9C Offset: 0x89C1E9C VA: 0x89C5E9C
	public void .ctor() { }
}

