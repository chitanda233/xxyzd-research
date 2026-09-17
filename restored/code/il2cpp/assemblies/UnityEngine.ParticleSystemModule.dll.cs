// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27206
{}

// Namespace: UnityEngine
[Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", False)]
public enum ParticleSystemEmissionType // TypeDefIndex: 27207
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemEmissionType Time = 0;
	public const ParticleSystemEmissionType Distance = 1;
}

// Namespace: 
public struct ParticleSystem.MainModule // TypeDefIndex: 27208
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", False)]
	public float randomizeRotationDirection { get; set; }
	public Vector3 emitterVelocity { get; set; }
	public float duration { get; set; }
	public bool loop { get; set; }
	public bool prewarm { get; set; }
	public ParticleSystem.MinMaxCurve startDelay { get; set; }
	public float startDelayMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSpeed { get; set; }
	public float startSpeedMultiplier { get; set; }
	public bool startSize3D { get; set; }
	[NativeName("StartSizeX")]
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeName("StartSizeXMultiplier")]
	public float startSizeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSizeX { get; set; }
	public float startSizeXMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSizeY { get; set; }
	public float startSizeYMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSizeZ { get; set; }
	public float startSizeZMultiplier { get; set; }
	public bool startRotation3D { get; set; }
	[NativeName("StartRotationZ")]
	public ParticleSystem.MinMaxCurve startRotation { get; set; }
	[NativeName("StartRotationZMultiplier")]
	public float startRotationMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startRotationX { get; set; }
	public float startRotationXMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startRotationY { get; set; }
	public float startRotationYMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startRotationZ { get; set; }
	public float startRotationZMultiplier { get; set; }
	public float flipRotation { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public ParticleSystemGravitySource gravitySource { get; set; }
	public ParticleSystem.MinMaxCurve gravityModifier { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public Transform customSimulationSpace { get; set; }
	public float simulationSpeed { get; set; }
	public bool useUnscaledTime { get; set; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public bool playOnAwake { get; set; }
	public int maxParticles { get; set; }
	public ParticleSystemEmitterVelocityMode emitterVelocityMode { get; set; }
	public ParticleSystemStopAction stopAction { get; set; }
	public ParticleSystemRingBufferMode ringBufferMode { get; set; }
	public Vector2 ringBufferLoopRange { get; set; }
	public ParticleSystemCullingMode cullingMode { get; set; }

	// Methods

	// RVA: 0x87B9470 Offset: 0x87B5470 VA: 0x87B9470
	public float get_randomizeRotationDirection() { }

	// RVA: 0x87B94E8 Offset: 0x87B54E8 VA: 0x87B94E8
	public void set_randomizeRotationDirection(float value) { }

	// RVA: 0x87B9110 Offset: 0x87B5110 VA: 0x87B9110
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87B9580 Offset: 0x87B5580 VA: 0x87B9580
	public Vector3 get_emitterVelocity() { }

	[NativeThrows]
	// RVA: 0x87B9620 Offset: 0x87B5620 VA: 0x87B9620
	public void set_emitterVelocity(Vector3 value) { }

	// RVA: 0x87B624C Offset: 0x87B224C VA: 0x87B624C
	public float get_duration() { }

	[NativeThrows]
	// RVA: 0x87B96F4 Offset: 0x87B56F4 VA: 0x87B96F4
	public void set_duration(float value) { }

	// RVA: 0x87B5FD8 Offset: 0x87B1FD8 VA: 0x87B5FD8
	public bool get_loop() { }

	[NativeThrows]
	// RVA: 0x87B6078 Offset: 0x87B2078 VA: 0x87B6078
	public void set_loop(bool value) { }

	// RVA: 0x87B980C Offset: 0x87B580C VA: 0x87B980C
	public bool get_prewarm() { }

	[NativeThrows]
	// RVA: 0x87B9884 Offset: 0x87B5884 VA: 0x87B9884
	public void set_prewarm(bool value) { }

	// RVA: 0x87B990C Offset: 0x87B590C VA: 0x87B990C
	public ParticleSystem.MinMaxCurve get_startDelay() { }

	[NativeThrows]
	// RVA: 0x87B99B0 Offset: 0x87B59B0 VA: 0x87B99B0
	public void set_startDelay(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B5E90 Offset: 0x87B1E90 VA: 0x87B5E90
	public float get_startDelayMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B5F34 Offset: 0x87B1F34 VA: 0x87B5F34
	public void set_startDelayMultiplier(float value) { }

	// RVA: 0x87B9AC0 Offset: 0x87B5AC0 VA: 0x87B9AC0
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	[NativeThrows]
	// RVA: 0x87B9B64 Offset: 0x87B5B64 VA: 0x87B9B64
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B70A4 Offset: 0x87B30A4 VA: 0x87B70A4
	public float get_startLifetimeMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B7148 Offset: 0x87B3148 VA: 0x87B7148
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x87B9C74 Offset: 0x87B5C74 VA: 0x87B9C74
	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	[NativeThrows]
	// RVA: 0x87B9D18 Offset: 0x87B5D18 VA: 0x87B9D18
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6730 Offset: 0x87B2730 VA: 0x87B6730
	public float get_startSpeedMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B67D4 Offset: 0x87B27D4 VA: 0x87B67D4
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x87B9E28 Offset: 0x87B5E28 VA: 0x87B9E28
	public bool get_startSize3D() { }

	[NativeThrows]
	// RVA: 0x87B9EA0 Offset: 0x87B5EA0 VA: 0x87B9EA0
	public void set_startSize3D(bool value) { }

	// RVA: 0x87B9F28 Offset: 0x87B5F28 VA: 0x87B9F28
	public ParticleSystem.MinMaxCurve get_startSize() { }

	[NativeThrows]
	// RVA: 0x87B9FCC Offset: 0x87B5FCC VA: 0x87B9FCC
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6874 Offset: 0x87B2874 VA: 0x87B6874
	public float get_startSizeMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B6918 Offset: 0x87B2918 VA: 0x87B6918
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x87BA0DC Offset: 0x87B60DC VA: 0x87BA0DC
	public ParticleSystem.MinMaxCurve get_startSizeX() { }

	[NativeThrows]
	// RVA: 0x87BA180 Offset: 0x87B6180 VA: 0x87BA180
	public void set_startSizeX(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA208 Offset: 0x87B6208 VA: 0x87BA208
	public float get_startSizeXMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BA280 Offset: 0x87B6280 VA: 0x87BA280
	public void set_startSizeXMultiplier(float value) { }

	// RVA: 0x87BA318 Offset: 0x87B6318 VA: 0x87BA318
	public ParticleSystem.MinMaxCurve get_startSizeY() { }

	[NativeThrows]
	// RVA: 0x87BA3BC Offset: 0x87B63BC VA: 0x87BA3BC
	public void set_startSizeY(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA444 Offset: 0x87B6444 VA: 0x87BA444
	public float get_startSizeYMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BA4BC Offset: 0x87B64BC VA: 0x87BA4BC
	public void set_startSizeYMultiplier(float value) { }

	// RVA: 0x87BA554 Offset: 0x87B6554 VA: 0x87BA554
	public ParticleSystem.MinMaxCurve get_startSizeZ() { }

	[NativeThrows]
	// RVA: 0x87BA5F8 Offset: 0x87B65F8 VA: 0x87BA5F8
	public void set_startSizeZ(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA680 Offset: 0x87B6680 VA: 0x87BA680
	public float get_startSizeZMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BA6F8 Offset: 0x87B66F8 VA: 0x87BA6F8
	public void set_startSizeZMultiplier(float value) { }

	// RVA: 0x87BA790 Offset: 0x87B6790 VA: 0x87BA790
	public bool get_startRotation3D() { }

	[NativeThrows]
	// RVA: 0x87BA808 Offset: 0x87B6808 VA: 0x87BA808
	public void set_startRotation3D(bool value) { }

	// RVA: 0x87BA890 Offset: 0x87B6890 VA: 0x87BA890
	public ParticleSystem.MinMaxCurve get_startRotation() { }

	[NativeThrows]
	// RVA: 0x87BA934 Offset: 0x87B6934 VA: 0x87BA934
	public void set_startRotation(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6BFC Offset: 0x87B2BFC VA: 0x87B6BFC
	public float get_startRotationMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B6CA0 Offset: 0x87B2CA0 VA: 0x87B6CA0
	public void set_startRotationMultiplier(float value) { }

	// RVA: 0x87BAA44 Offset: 0x87B6A44 VA: 0x87BAA44
	public ParticleSystem.MinMaxCurve get_startRotationX() { }

	[NativeThrows]
	// RVA: 0x87BAAE8 Offset: 0x87B6AE8 VA: 0x87BAAE8
	public void set_startRotationX(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6DE8 Offset: 0x87B2DE8 VA: 0x87B6DE8
	public float get_startRotationXMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B6F6C Offset: 0x87B2F6C VA: 0x87B6F6C
	public void set_startRotationXMultiplier(float value) { }

	// RVA: 0x87BABF8 Offset: 0x87B6BF8 VA: 0x87BABF8
	public ParticleSystem.MinMaxCurve get_startRotationY() { }

	[NativeThrows]
	// RVA: 0x87BAC9C Offset: 0x87B6C9C VA: 0x87BAC9C
	public void set_startRotationY(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6E24 Offset: 0x87B2E24 VA: 0x87B6E24
	public float get_startRotationYMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B6FB8 Offset: 0x87B2FB8 VA: 0x87B6FB8
	public void set_startRotationYMultiplier(float value) { }

	// RVA: 0x87BADAC Offset: 0x87B6DAC VA: 0x87BADAC
	public ParticleSystem.MinMaxCurve get_startRotationZ() { }

	[NativeThrows]
	// RVA: 0x87BAE50 Offset: 0x87B6E50 VA: 0x87BAE50
	public void set_startRotationZ(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B6E60 Offset: 0x87B2E60 VA: 0x87B6E60
	public float get_startRotationZMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B7004 Offset: 0x87B3004 VA: 0x87B7004
	public void set_startRotationZMultiplier(float value) { }

	// RVA: 0x87B94AC Offset: 0x87B54AC VA: 0x87B94AC
	public float get_flipRotation() { }

	[NativeThrows]
	// RVA: 0x87B9534 Offset: 0x87B5534 VA: 0x87B9534
	public void set_flipRotation(float value) { }

	// RVA: 0x87B69D4 Offset: 0x87B29D4 VA: 0x87B69D4
	public ParticleSystem.MinMaxGradient get_startColor() { }

	[NativeThrows]
	// RVA: 0x87B6B64 Offset: 0x87B2B64 VA: 0x87B6B64
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x87BB070 Offset: 0x87B7070 VA: 0x87BB070
	public ParticleSystemGravitySource get_gravitySource() { }

	[NativeThrows]
	// RVA: 0x87BB0E8 Offset: 0x87B70E8 VA: 0x87BB0E8
	public void set_gravitySource(ParticleSystemGravitySource value) { }

	// RVA: 0x87BB170 Offset: 0x87B7170 VA: 0x87BB170
	public ParticleSystem.MinMaxCurve get_gravityModifier() { }

	[NativeThrows]
	// RVA: 0x87BB214 Offset: 0x87B7214 VA: 0x87BB214
	public void set_gravityModifier(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B71E8 Offset: 0x87B31E8 VA: 0x87B71E8
	public float get_gravityModifierMultiplier() { }

	[NativeThrows]
	// RVA: 0x87B728C Offset: 0x87B328C VA: 0x87B728C
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x87B7464 Offset: 0x87B3464 VA: 0x87B7464
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	[NativeThrows]
	// RVA: 0x87B7504 Offset: 0x87B3504 VA: 0x87B7504
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x87BB3A4 Offset: 0x87B73A4 VA: 0x87BB3A4
	public Transform get_customSimulationSpace() { }

	[NativeThrows]
	// RVA: 0x87BB41C Offset: 0x87B741C VA: 0x87BB41C
	public void set_customSimulationSpace(Transform value) { }

	// RVA: 0x87B62DC Offset: 0x87B22DC VA: 0x87B62DC
	public float get_simulationSpeed() { }

	[NativeThrows]
	// RVA: 0x87B6380 Offset: 0x87B2380 VA: 0x87B6380
	public void set_simulationSpeed(float value) { }

	// RVA: 0x87BB52C Offset: 0x87B752C VA: 0x87BB52C
	public bool get_useUnscaledTime() { }

	[NativeThrows]
	// RVA: 0x87BB5A4 Offset: 0x87B75A4 VA: 0x87BB5A4
	public void set_useUnscaledTime(bool value) { }

	// RVA: 0x87B759C Offset: 0x87B359C VA: 0x87B759C
	public ParticleSystemScalingMode get_scalingMode() { }

	[NativeThrows]
	// RVA: 0x87B763C Offset: 0x87B363C VA: 0x87B763C
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x87B6114 Offset: 0x87B2114 VA: 0x87B6114
	public bool get_playOnAwake() { }

	[NativeThrows]
	// RVA: 0x87B61B4 Offset: 0x87B21B4 VA: 0x87B61B4
	public void set_playOnAwake(bool value) { }

	// RVA: 0x87B732C Offset: 0x87B332C VA: 0x87B732C
	public int get_maxParticles() { }

	[NativeThrows]
	// RVA: 0x87B73CC Offset: 0x87B33CC VA: 0x87B73CC
	public void set_maxParticles(int value) { }

	// RVA: 0x87BB7AC Offset: 0x87B77AC VA: 0x87BB7AC
	public ParticleSystemEmitterVelocityMode get_emitterVelocityMode() { }

	[NativeThrows]
	// RVA: 0x87BB824 Offset: 0x87B7824 VA: 0x87BB824
	public void set_emitterVelocityMode(ParticleSystemEmitterVelocityMode value) { }

	// RVA: 0x87BB8AC Offset: 0x87B78AC VA: 0x87BB8AC
	public ParticleSystemStopAction get_stopAction() { }

	[NativeThrows]
	// RVA: 0x87BB924 Offset: 0x87B7924 VA: 0x87BB924
	public void set_stopAction(ParticleSystemStopAction value) { }

	// RVA: 0x87BB9AC Offset: 0x87B79AC VA: 0x87BB9AC
	public ParticleSystemRingBufferMode get_ringBufferMode() { }

	[NativeThrows]
	// RVA: 0x87BBA24 Offset: 0x87B7A24 VA: 0x87BBA24
	public void set_ringBufferMode(ParticleSystemRingBufferMode value) { }

	// RVA: 0x87BBAAC Offset: 0x87B7AAC VA: 0x87BBAAC
	public Vector2 get_ringBufferLoopRange() { }

	[NativeThrows]
	// RVA: 0x87BBB3C Offset: 0x87B7B3C VA: 0x87BBB3C
	public void set_ringBufferLoopRange(Vector2 value) { }

	// RVA: 0x87BBBC8 Offset: 0x87B7BC8 VA: 0x87BBBC8
	public ParticleSystemCullingMode get_cullingMode() { }

	[NativeThrows]
	// RVA: 0x87BBC40 Offset: 0x87B7C40 VA: 0x87BBC40
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x87B95DC Offset: 0x87B55DC VA: 0x87B95DC
	private static void get_emitterVelocity_Injected(ref ParticleSystem.MainModule _unity_self, out Vector3 ret) { }

	// RVA: 0x87B9674 Offset: 0x87B5674 VA: 0x87B9674
	private static void set_emitterVelocity_Injected(ref ParticleSystem.MainModule _unity_self, ref Vector3 value) { }

	// RVA: 0x87B96B8 Offset: 0x87B56B8 VA: 0x87B96B8
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B9740 Offset: 0x87B5740 VA: 0x87B9740
	private static void set_duration_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87B978C Offset: 0x87B578C VA: 0x87B978C
	private static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B97C8 Offset: 0x87B57C8 VA: 0x87B97C8
	private static void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87B9848 Offset: 0x87B5848 VA: 0x87B9848
	private static bool get_prewarm_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B98C8 Offset: 0x87B58C8 VA: 0x87B98C8
	private static void set_prewarm_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87B996C Offset: 0x87B596C VA: 0x87B996C
	private static void get_startDelay_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87B99F4 Offset: 0x87B59F4 VA: 0x87B99F4
	private static void set_startDelay_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B9A38 Offset: 0x87B5A38 VA: 0x87B9A38
	private static float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B9A74 Offset: 0x87B5A74 VA: 0x87B9A74
	private static void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87B9B20 Offset: 0x87B5B20 VA: 0x87B9B20
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87B9BA8 Offset: 0x87B5BA8 VA: 0x87B9BA8
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B9BEC Offset: 0x87B5BEC VA: 0x87B9BEC
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B9C28 Offset: 0x87B5C28 VA: 0x87B9C28
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87B9CD4 Offset: 0x87B5CD4 VA: 0x87B9CD4
	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87B9D5C Offset: 0x87B5D5C VA: 0x87B9D5C
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B9DA0 Offset: 0x87B5DA0 VA: 0x87B9DA0
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B9DDC Offset: 0x87B5DDC VA: 0x87B9DDC
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87B9E64 Offset: 0x87B5E64 VA: 0x87B9E64
	private static bool get_startSize3D_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87B9EE4 Offset: 0x87B5EE4 VA: 0x87B9EE4
	private static void set_startSize3D_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87B9F88 Offset: 0x87B5F88 VA: 0x87B9F88
	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BA010 Offset: 0x87B6010 VA: 0x87BA010
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA054 Offset: 0x87B6054 VA: 0x87BA054
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA090 Offset: 0x87B6090 VA: 0x87BA090
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BA13C Offset: 0x87B613C VA: 0x87BA13C
	private static void get_startSizeX_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BA1C4 Offset: 0x87B61C4 VA: 0x87BA1C4
	private static void set_startSizeX_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA244 Offset: 0x87B6244 VA: 0x87BA244
	private static float get_startSizeXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA2CC Offset: 0x87B62CC VA: 0x87BA2CC
	private static void set_startSizeXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BA378 Offset: 0x87B6378 VA: 0x87BA378
	private static void get_startSizeY_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BA400 Offset: 0x87B6400 VA: 0x87BA400
	private static void set_startSizeY_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA480 Offset: 0x87B6480 VA: 0x87BA480
	private static float get_startSizeYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA508 Offset: 0x87B6508 VA: 0x87BA508
	private static void set_startSizeYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BA5B4 Offset: 0x87B65B4 VA: 0x87BA5B4
	private static void get_startSizeZ_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BA63C Offset: 0x87B663C VA: 0x87BA63C
	private static void set_startSizeZ_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA6BC Offset: 0x87B66BC VA: 0x87BA6BC
	private static float get_startSizeZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA744 Offset: 0x87B6744 VA: 0x87BA744
	private static void set_startSizeZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BA7CC Offset: 0x87B67CC VA: 0x87BA7CC
	private static bool get_startRotation3D_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA84C Offset: 0x87B684C VA: 0x87BA84C
	private static void set_startRotation3D_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87BA8F0 Offset: 0x87B68F0 VA: 0x87BA8F0
	private static void get_startRotation_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BA978 Offset: 0x87B6978 VA: 0x87BA978
	private static void set_startRotation_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BA9BC Offset: 0x87B69BC VA: 0x87BA9BC
	private static float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BA9F8 Offset: 0x87B69F8 VA: 0x87BA9F8
	private static void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BAAA4 Offset: 0x87B6AA4 VA: 0x87BAAA4
	private static void get_startRotationX_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BAB2C Offset: 0x87B6B2C VA: 0x87BAB2C
	private static void set_startRotationX_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BAB70 Offset: 0x87B6B70 VA: 0x87BAB70
	private static float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BABAC Offset: 0x87B6BAC VA: 0x87BABAC
	private static void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BAC58 Offset: 0x87B6C58 VA: 0x87BAC58
	private static void get_startRotationY_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BACE0 Offset: 0x87B6CE0 VA: 0x87BACE0
	private static void set_startRotationY_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BAD24 Offset: 0x87B6D24 VA: 0x87BAD24
	private static float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BAD60 Offset: 0x87B6D60 VA: 0x87BAD60
	private static void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BAE0C Offset: 0x87B6E0C VA: 0x87BAE0C
	private static void get_startRotationZ_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BAE94 Offset: 0x87B6E94 VA: 0x87BAE94
	private static void set_startRotationZ_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BAED8 Offset: 0x87B6ED8 VA: 0x87BAED8
	private static float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BAF14 Offset: 0x87B6F14 VA: 0x87BAF14
	private static void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BAF60 Offset: 0x87B6F60 VA: 0x87BAF60
	private static float get_flipRotation_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BAF9C Offset: 0x87B6F9C VA: 0x87BAF9C
	private static void set_flipRotation_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BAFE8 Offset: 0x87B6FE8 VA: 0x87BAFE8
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x87BB02C Offset: 0x87B702C VA: 0x87BB02C
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x87BB0AC Offset: 0x87B70AC VA: 0x87BB0AC
	private static ParticleSystemGravitySource get_gravitySource_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB12C Offset: 0x87B712C VA: 0x87BB12C
	private static void set_gravitySource_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemGravitySource value) { }

	// RVA: 0x87BB1D0 Offset: 0x87B71D0 VA: 0x87BB1D0
	private static void get_gravityModifier_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BB258 Offset: 0x87B7258 VA: 0x87BB258
	private static void set_gravityModifier_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BB29C Offset: 0x87B729C VA: 0x87BB29C
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB2D8 Offset: 0x87B72D8 VA: 0x87BB2D8
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BB324 Offset: 0x87B7324 VA: 0x87BB324
	private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB360 Offset: 0x87B7360 VA: 0x87BB360
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x87BB3E0 Offset: 0x87B73E0 VA: 0x87BB3E0
	private static Transform get_customSimulationSpace_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB460 Offset: 0x87B7460 VA: 0x87BB460
	private static void set_customSimulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, Transform value) { }

	// RVA: 0x87BB4A4 Offset: 0x87B74A4 VA: 0x87BB4A4
	private static float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB4E0 Offset: 0x87B74E0 VA: 0x87BB4E0
	private static void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x87BB568 Offset: 0x87B7568 VA: 0x87BB568
	private static bool get_useUnscaledTime_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB5E8 Offset: 0x87B75E8 VA: 0x87BB5E8
	private static void set_useUnscaledTime_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87BB62C Offset: 0x87B762C VA: 0x87BB62C
	private static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB668 Offset: 0x87B7668 VA: 0x87BB668
	private static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value) { }

	// RVA: 0x87BB6AC Offset: 0x87B76AC VA: 0x87BB6AC
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB6E8 Offset: 0x87B76E8 VA: 0x87BB6E8
	private static void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x87BB72C Offset: 0x87B772C VA: 0x87BB72C
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB768 Offset: 0x87B7768 VA: 0x87BB768
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x87BB7E8 Offset: 0x87B77E8 VA: 0x87BB7E8
	private static ParticleSystemEmitterVelocityMode get_emitterVelocityMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB868 Offset: 0x87B7868 VA: 0x87BB868
	private static void set_emitterVelocityMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemEmitterVelocityMode value) { }

	// RVA: 0x87BB8E8 Offset: 0x87B78E8 VA: 0x87BB8E8
	private static ParticleSystemStopAction get_stopAction_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BB968 Offset: 0x87B7968 VA: 0x87BB968
	private static void set_stopAction_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemStopAction value) { }

	// RVA: 0x87BB9E8 Offset: 0x87B79E8 VA: 0x87BB9E8
	private static ParticleSystemRingBufferMode get_ringBufferMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BBA68 Offset: 0x87B7A68 VA: 0x87BBA68
	private static void set_ringBufferMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemRingBufferMode value) { }

	// RVA: 0x87BBAF8 Offset: 0x87B7AF8 VA: 0x87BBAF8
	private static void get_ringBufferLoopRange_Injected(ref ParticleSystem.MainModule _unity_self, out Vector2 ret) { }

	// RVA: 0x87BBB84 Offset: 0x87B7B84 VA: 0x87BBB84
	private static void set_ringBufferLoopRange_Injected(ref ParticleSystem.MainModule _unity_self, ref Vector2 value) { }

	// RVA: 0x87BBC04 Offset: 0x87B7C04 VA: 0x87BBC04
	private static ParticleSystemCullingMode get_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x87BBC84 Offset: 0x87B7C84 VA: 0x87BBC84
	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }
}

// Namespace: 
public struct ParticleSystem.EmissionModule // TypeDefIndex: 27209
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", False)]
	public ParticleSystemEmissionType type { get; set; }
	[Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", False)]
	public ParticleSystem.MinMaxCurve rate { get; set; }
	[Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", False)]
	public float rateMultiplier { get; set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve rateOverDistance { get; set; }
	public float rateOverDistanceMultiplier { get; set; }
	public int burstCount { get; set; }

	// Methods

	// RVA: 0x87BBCC8 Offset: 0x87B7CC8 VA: 0x87BBCC8
	public ParticleSystemEmissionType get_type() { }

	// RVA: 0x87BBCD0 Offset: 0x87B7CD0 VA: 0x87BBCD0
	public void set_type(ParticleSystemEmissionType value) { }

	// RVA: 0x87BBCD4 Offset: 0x87B7CD4 VA: 0x87BBCD4
	public ParticleSystem.MinMaxCurve get_rate() { }

	// RVA: 0x87BBD98 Offset: 0x87B7D98 VA: 0x87BBD98
	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BBDEC Offset: 0x87B7DEC VA: 0x87BBDEC
	public float get_rateMultiplier() { }

	// RVA: 0x87BBE28 Offset: 0x87B7E28 VA: 0x87BBE28
	public void set_rateMultiplier(float value) { }

	// RVA: 0x87B9118 Offset: 0x87B5118 VA: 0x87B9118
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87B6444 Offset: 0x87B2444 VA: 0x87B6444
	public bool get_enabled() { }

	[NativeThrows]
	// RVA: 0x87B64E4 Offset: 0x87B24E4 VA: 0x87B64E4
	public void set_enabled(bool value) { }

	// RVA: 0x87BBD38 Offset: 0x87B7D38 VA: 0x87BBD38
	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	[NativeThrows]
	// RVA: 0x87B6698 Offset: 0x87B2698 VA: 0x87B6698
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87B657C Offset: 0x87B257C VA: 0x87B657C
	public float get_rateOverTimeMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BBE74 Offset: 0x87B7E74 VA: 0x87BBE74
	public void set_rateOverTimeMultiplier(float value) { }

	// RVA: 0x87BC050 Offset: 0x87B8050 VA: 0x87BC050
	public ParticleSystem.MinMaxCurve get_rateOverDistance() { }

	[NativeThrows]
	// RVA: 0x87BC0F4 Offset: 0x87B80F4 VA: 0x87BC0F4
	public void set_rateOverDistance(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BC17C Offset: 0x87B817C VA: 0x87BC17C
	public float get_rateOverDistanceMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BC1F4 Offset: 0x87B81F4 VA: 0x87BC1F4
	public void set_rateOverDistanceMultiplier(float value) { }

	// RVA: 0x87BC28C Offset: 0x87B828C VA: 0x87BC28C
	public void SetBursts(ParticleSystem.Burst[] bursts) { }

	// RVA: 0x87BC2A4 Offset: 0x87B82A4 VA: 0x87BC2A4
	public void SetBursts(ParticleSystem.Burst[] bursts, int size) { }

	// RVA: 0x87BC428 Offset: 0x87B8428 VA: 0x87BC428
	public int GetBursts(ParticleSystem.Burst[] bursts) { }

	[NativeThrows]
	// RVA: 0x87BC3D4 Offset: 0x87B83D4 VA: 0x87BC3D4
	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	[NativeThrows]
	// RVA: 0x87BC5A4 Offset: 0x87B85A4 VA: 0x87BC5A4
	public ParticleSystem.Burst GetBurst(int index) { }

	// RVA: 0x87BC568 Offset: 0x87B8568 VA: 0x87BC568
	public int get_burstCount() { }

	[NativeThrows]
	// RVA: 0x87BC390 Offset: 0x87B8390 VA: 0x87BC390
	public void set_burstCount(int value) { }

	// RVA: 0x87BBEC0 Offset: 0x87B7EC0 VA: 0x87BBEC0
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x87BBEFC Offset: 0x87B7EFC VA: 0x87BBEFC
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x87BBF40 Offset: 0x87B7F40 VA: 0x87BBF40
	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BBF84 Offset: 0x87B7F84 VA: 0x87BBF84
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BBFC8 Offset: 0x87B7FC8 VA: 0x87BBFC8
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x87BC004 Offset: 0x87B8004 VA: 0x87BC004
	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x87BC0B0 Offset: 0x87B80B0 VA: 0x87BC0B0
	private static void get_rateOverDistance_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BC138 Offset: 0x87B8138 VA: 0x87BC138
	private static void set_rateOverDistance_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BC1B8 Offset: 0x87B81B8 VA: 0x87BC1B8
	private static float get_rateOverDistanceMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x87BC240 Offset: 0x87B8240 VA: 0x87BC240
	private static void set_rateOverDistanceMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x87BC62C Offset: 0x87B862C VA: 0x87BC62C
	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	// RVA: 0x87BC680 Offset: 0x87B8680 VA: 0x87BC680
	private static void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret) { }

	// RVA: 0x87BC6D4 Offset: 0x87B86D4 VA: 0x87BC6D4
	private static int get_burstCount_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x87BC710 Offset: 0x87B8710 VA: 0x87BC710
	private static void set_burstCount_Injected(ref ParticleSystem.EmissionModule _unity_self, int value) { }
}

// Namespace: 
public struct ParticleSystem.ShapeModule // TypeDefIndex: 27210
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", False)]
	public Vector3 box { get; set; }
	[Obsolete("meshScale property is deprecated.Please use scale instead.", False)]
	public float meshScale { get; set; }
	[Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", False)]
	public bool randomDirection { get; set; }
	public bool enabled { get; set; }
	public ParticleSystemShapeType shapeType { get; set; }
	public float randomDirectionAmount { get; set; }
	public float sphericalDirectionAmount { get; set; }
	public float randomPositionAmount { get; set; }
	public bool alignToDirection { get; set; }
	public float radius { get; set; }
	public ParticleSystemShapeMultiModeValue radiusMode { get; set; }
	public float radiusSpread { get; set; }
	public ParticleSystem.MinMaxCurve radiusSpeed { get; set; }
	public float radiusSpeedMultiplier { get; set; }
	public float radiusThickness { get; set; }
	public float angle { get; set; }
	public float length { get; set; }
	public Vector3 boxThickness { get; set; }
	public ParticleSystemMeshShapeType meshShapeType { get; set; }
	public Mesh mesh { get; set; }
	public MeshRenderer meshRenderer { get; set; }
	public SkinnedMeshRenderer skinnedMeshRenderer { get; set; }
	public Sprite sprite { get; set; }
	public SpriteRenderer spriteRenderer { get; set; }
	public bool useMeshMaterialIndex { get; set; }
	public int meshMaterialIndex { get; set; }
	public bool useMeshColors { get; set; }
	public float normalOffset { get; set; }
	public ParticleSystemShapeMultiModeValue meshSpawnMode { get; set; }
	public float meshSpawnSpread { get; set; }
	public ParticleSystem.MinMaxCurve meshSpawnSpeed { get; set; }
	public float meshSpawnSpeedMultiplier { get; set; }
	public float arc { get; set; }
	public ParticleSystemShapeMultiModeValue arcMode { get; set; }
	public float arcSpread { get; set; }
	public ParticleSystem.MinMaxCurve arcSpeed { get; set; }
	public float arcSpeedMultiplier { get; set; }
	public float donutRadius { get; set; }
	public Vector3 position { get; set; }
	public Vector3 rotation { get; set; }
	public Vector3 scale { get; set; }
	public Texture2D texture { get; set; }
	public ParticleSystemShapeTextureChannel textureClipChannel { get; set; }
	public float textureClipThreshold { get; set; }
	public bool textureColorAffectsParticles { get; set; }
	public bool textureAlphaAffectsParticles { get; set; }
	public bool textureBilinearFiltering { get; set; }
	public int textureUVChannel { get; set; }

	// Methods

	// RVA: 0x87BC754 Offset: 0x87B8754 VA: 0x87BC754
	public Vector3 get_box() { }

	// RVA: 0x87BC7B4 Offset: 0x87B87B4 VA: 0x87BC7B4
	public void set_box(Vector3 value) { }

	// RVA: 0x87BC80C Offset: 0x87B880C VA: 0x87BC80C
	public float get_meshScale() { }

	// RVA: 0x87BC810 Offset: 0x87B8810 VA: 0x87BC810
	public void set_meshScale(float value) { }

	// RVA: 0x87BC81C Offset: 0x87B881C VA: 0x87BC81C
	public bool get_randomDirection() { }

	// RVA: 0x87BC8A4 Offset: 0x87B88A4 VA: 0x87BC8A4
	public void set_randomDirection(bool value) { }

	// RVA: 0x87B9140 Offset: 0x87B5140 VA: 0x87B9140
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87BC940 Offset: 0x87B8940 VA: 0x87BC940
	public bool get_enabled() { }

	[NativeThrows]
	// RVA: 0x87BC9B8 Offset: 0x87B89B8 VA: 0x87BC9B8
	public void set_enabled(bool value) { }

	// RVA: 0x87BCA40 Offset: 0x87B8A40 VA: 0x87BCA40
	public ParticleSystemShapeType get_shapeType() { }

	[NativeThrows]
	// RVA: 0x87BCAB8 Offset: 0x87B8AB8 VA: 0x87BCAB8
	public void set_shapeType(ParticleSystemShapeType value) { }

	// RVA: 0x87BC868 Offset: 0x87B8868 VA: 0x87BC868
	public float get_randomDirectionAmount() { }

	[NativeThrows]
	// RVA: 0x87BC8F4 Offset: 0x87B88F4 VA: 0x87BC8F4
	public void set_randomDirectionAmount(float value) { }

	// RVA: 0x87BCBC8 Offset: 0x87B8BC8 VA: 0x87BCBC8
	public float get_sphericalDirectionAmount() { }

	[NativeThrows]
	// RVA: 0x87BCC40 Offset: 0x87B8C40 VA: 0x87BCC40
	public void set_sphericalDirectionAmount(float value) { }

	// RVA: 0x87BCCD8 Offset: 0x87B8CD8 VA: 0x87BCCD8
	public float get_randomPositionAmount() { }

	[NativeThrows]
	// RVA: 0x87BCD50 Offset: 0x87B8D50 VA: 0x87BCD50
	public void set_randomPositionAmount(float value) { }

	// RVA: 0x87BCDE8 Offset: 0x87B8DE8 VA: 0x87BCDE8
	public bool get_alignToDirection() { }

	[NativeThrows]
	// RVA: 0x87BCE60 Offset: 0x87B8E60 VA: 0x87BCE60
	public void set_alignToDirection(bool value) { }

	// RVA: 0x87BCEE8 Offset: 0x87B8EE8 VA: 0x87BCEE8
	public float get_radius() { }

	[NativeThrows]
	// RVA: 0x87BCF60 Offset: 0x87B8F60 VA: 0x87BCF60
	public void set_radius(float value) { }

	// RVA: 0x87BCFF8 Offset: 0x87B8FF8 VA: 0x87BCFF8
	public ParticleSystemShapeMultiModeValue get_radiusMode() { }

	[NativeThrows]
	// RVA: 0x87BD070 Offset: 0x87B9070 VA: 0x87BD070
	public void set_radiusMode(ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BD0F8 Offset: 0x87B90F8 VA: 0x87BD0F8
	public float get_radiusSpread() { }

	[NativeThrows]
	// RVA: 0x87BD170 Offset: 0x87B9170 VA: 0x87BD170
	public void set_radiusSpread(float value) { }

	// RVA: 0x87BD208 Offset: 0x87B9208 VA: 0x87BD208
	public ParticleSystem.MinMaxCurve get_radiusSpeed() { }

	[NativeThrows]
	// RVA: 0x87BD2AC Offset: 0x87B92AC VA: 0x87BD2AC
	public void set_radiusSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BD334 Offset: 0x87B9334 VA: 0x87BD334
	public float get_radiusSpeedMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BD3AC Offset: 0x87B93AC VA: 0x87BD3AC
	public void set_radiusSpeedMultiplier(float value) { }

	// RVA: 0x87BD444 Offset: 0x87B9444 VA: 0x87BD444
	public float get_radiusThickness() { }

	[NativeThrows]
	// RVA: 0x87BD4BC Offset: 0x87B94BC VA: 0x87BD4BC
	public void set_radiusThickness(float value) { }

	// RVA: 0x87BD554 Offset: 0x87B9554 VA: 0x87BD554
	public float get_angle() { }

	[NativeThrows]
	// RVA: 0x87BD5CC Offset: 0x87B95CC VA: 0x87BD5CC
	public void set_angle(float value) { }

	// RVA: 0x87BD664 Offset: 0x87B9664 VA: 0x87BD664
	public float get_length() { }

	[NativeThrows]
	// RVA: 0x87BD6DC Offset: 0x87B96DC VA: 0x87BD6DC
	public void set_length(float value) { }

	// RVA: 0x87BD774 Offset: 0x87B9774 VA: 0x87BD774
	public Vector3 get_boxThickness() { }

	[NativeThrows]
	// RVA: 0x87BD814 Offset: 0x87B9814 VA: 0x87BD814
	public void set_boxThickness(Vector3 value) { }

	// RVA: 0x87BD8AC Offset: 0x87B98AC VA: 0x87BD8AC
	public ParticleSystemMeshShapeType get_meshShapeType() { }

	[NativeThrows]
	// RVA: 0x87BD924 Offset: 0x87B9924 VA: 0x87BD924
	public void set_meshShapeType(ParticleSystemMeshShapeType value) { }

	// RVA: 0x87BD9AC Offset: 0x87B99AC VA: 0x87BD9AC
	public Mesh get_mesh() { }

	[NativeThrows]
	// RVA: 0x87BDA24 Offset: 0x87B9A24 VA: 0x87BDA24
	public void set_mesh(Mesh value) { }

	// RVA: 0x87BDAAC Offset: 0x87B9AAC VA: 0x87BDAAC
	public MeshRenderer get_meshRenderer() { }

	[NativeThrows]
	// RVA: 0x87BDB24 Offset: 0x87B9B24 VA: 0x87BDB24
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x87BDBAC Offset: 0x87B9BAC VA: 0x87BDBAC
	public SkinnedMeshRenderer get_skinnedMeshRenderer() { }

	[NativeThrows]
	// RVA: 0x87BDC24 Offset: 0x87B9C24 VA: 0x87BDC24
	public void set_skinnedMeshRenderer(SkinnedMeshRenderer value) { }

	// RVA: 0x87BDCAC Offset: 0x87B9CAC VA: 0x87BDCAC
	public Sprite get_sprite() { }

	[NativeThrows]
	// RVA: 0x87BDD24 Offset: 0x87B9D24 VA: 0x87BDD24
	public void set_sprite(Sprite value) { }

	// RVA: 0x87BDDAC Offset: 0x87B9DAC VA: 0x87BDDAC
	public SpriteRenderer get_spriteRenderer() { }

	[NativeThrows]
	// RVA: 0x87BDE24 Offset: 0x87B9E24 VA: 0x87BDE24
	public void set_spriteRenderer(SpriteRenderer value) { }

	// RVA: 0x87BDEAC Offset: 0x87B9EAC VA: 0x87BDEAC
	public bool get_useMeshMaterialIndex() { }

	[NativeThrows]
	// RVA: 0x87BDF24 Offset: 0x87B9F24 VA: 0x87BDF24
	public void set_useMeshMaterialIndex(bool value) { }

	// RVA: 0x87BDFAC Offset: 0x87B9FAC VA: 0x87BDFAC
	public int get_meshMaterialIndex() { }

	[NativeThrows]
	// RVA: 0x87BE024 Offset: 0x87BA024 VA: 0x87BE024
	public void set_meshMaterialIndex(int value) { }

	// RVA: 0x87BE0AC Offset: 0x87BA0AC VA: 0x87BE0AC
	public bool get_useMeshColors() { }

	[NativeThrows]
	// RVA: 0x87BE124 Offset: 0x87BA124 VA: 0x87BE124
	public void set_useMeshColors(bool value) { }

	// RVA: 0x87BE1AC Offset: 0x87BA1AC VA: 0x87BE1AC
	public float get_normalOffset() { }

	[NativeThrows]
	// RVA: 0x87BE224 Offset: 0x87BA224 VA: 0x87BE224
	public void set_normalOffset(float value) { }

	// RVA: 0x87BE2BC Offset: 0x87BA2BC VA: 0x87BE2BC
	public ParticleSystemShapeMultiModeValue get_meshSpawnMode() { }

	[NativeThrows]
	// RVA: 0x87BE334 Offset: 0x87BA334 VA: 0x87BE334
	public void set_meshSpawnMode(ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BE3BC Offset: 0x87BA3BC VA: 0x87BE3BC
	public float get_meshSpawnSpread() { }

	[NativeThrows]
	// RVA: 0x87BE434 Offset: 0x87BA434 VA: 0x87BE434
	public void set_meshSpawnSpread(float value) { }

	// RVA: 0x87BE4CC Offset: 0x87BA4CC VA: 0x87BE4CC
	public ParticleSystem.MinMaxCurve get_meshSpawnSpeed() { }

	[NativeThrows]
	// RVA: 0x87BE570 Offset: 0x87BA570 VA: 0x87BE570
	public void set_meshSpawnSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BE5F8 Offset: 0x87BA5F8 VA: 0x87BE5F8
	public float get_meshSpawnSpeedMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BE670 Offset: 0x87BA670 VA: 0x87BE670
	public void set_meshSpawnSpeedMultiplier(float value) { }

	// RVA: 0x87BE708 Offset: 0x87BA708 VA: 0x87BE708
	public float get_arc() { }

	[NativeThrows]
	// RVA: 0x87BE780 Offset: 0x87BA780 VA: 0x87BE780
	public void set_arc(float value) { }

	// RVA: 0x87BE818 Offset: 0x87BA818 VA: 0x87BE818
	public ParticleSystemShapeMultiModeValue get_arcMode() { }

	[NativeThrows]
	// RVA: 0x87BE890 Offset: 0x87BA890 VA: 0x87BE890
	public void set_arcMode(ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BE918 Offset: 0x87BA918 VA: 0x87BE918
	public float get_arcSpread() { }

	[NativeThrows]
	// RVA: 0x87BE990 Offset: 0x87BA990 VA: 0x87BE990
	public void set_arcSpread(float value) { }

	// RVA: 0x87BEA28 Offset: 0x87BAA28 VA: 0x87BEA28
	public ParticleSystem.MinMaxCurve get_arcSpeed() { }

	[NativeThrows]
	// RVA: 0x87BEACC Offset: 0x87BAACC VA: 0x87BEACC
	public void set_arcSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BEB54 Offset: 0x87BAB54 VA: 0x87BEB54
	public float get_arcSpeedMultiplier() { }

	[NativeThrows]
	// RVA: 0x87BEBCC Offset: 0x87BABCC VA: 0x87BEBCC
	public void set_arcSpeedMultiplier(float value) { }

	// RVA: 0x87BEC64 Offset: 0x87BAC64 VA: 0x87BEC64
	public float get_donutRadius() { }

	[NativeThrows]
	// RVA: 0x87BECDC Offset: 0x87BACDC VA: 0x87BECDC
	public void set_donutRadius(float value) { }

	// RVA: 0x87BED74 Offset: 0x87BAD74 VA: 0x87BED74
	public Vector3 get_position() { }

	[NativeThrows]
	// RVA: 0x87BEE14 Offset: 0x87BAE14 VA: 0x87BEE14
	public void set_position(Vector3 value) { }

	// RVA: 0x87BEEAC Offset: 0x87BAEAC VA: 0x87BEEAC
	public Vector3 get_rotation() { }

	[NativeThrows]
	// RVA: 0x87BEF4C Offset: 0x87BAF4C VA: 0x87BEF4C
	public void set_rotation(Vector3 value) { }

	// RVA: 0x87BC758 Offset: 0x87B8758 VA: 0x87BC758
	public Vector3 get_scale() { }

	[NativeThrows]
	// RVA: 0x87BC7B8 Offset: 0x87B87B8 VA: 0x87BC7B8
	public void set_scale(Vector3 value) { }

	// RVA: 0x87BF06C Offset: 0x87BB06C VA: 0x87BF06C
	public Texture2D get_texture() { }

	[NativeThrows]
	// RVA: 0x87BF0E4 Offset: 0x87BB0E4 VA: 0x87BF0E4
	public void set_texture(Texture2D value) { }

	// RVA: 0x87BF16C Offset: 0x87BB16C VA: 0x87BF16C
	public ParticleSystemShapeTextureChannel get_textureClipChannel() { }

	[NativeThrows]
	// RVA: 0x87BF1E4 Offset: 0x87BB1E4 VA: 0x87BF1E4
	public void set_textureClipChannel(ParticleSystemShapeTextureChannel value) { }

	// RVA: 0x87BF26C Offset: 0x87BB26C VA: 0x87BF26C
	public float get_textureClipThreshold() { }

	[NativeThrows]
	// RVA: 0x87BF2E4 Offset: 0x87BB2E4 VA: 0x87BF2E4
	public void set_textureClipThreshold(float value) { }

	// RVA: 0x87BF37C Offset: 0x87BB37C VA: 0x87BF37C
	public bool get_textureColorAffectsParticles() { }

	[NativeThrows]
	// RVA: 0x87BF3F4 Offset: 0x87BB3F4 VA: 0x87BF3F4
	public void set_textureColorAffectsParticles(bool value) { }

	// RVA: 0x87BF47C Offset: 0x87BB47C VA: 0x87BF47C
	public bool get_textureAlphaAffectsParticles() { }

	[NativeThrows]
	// RVA: 0x87BF4F4 Offset: 0x87BB4F4 VA: 0x87BF4F4
	public void set_textureAlphaAffectsParticles(bool value) { }

	// RVA: 0x87BF57C Offset: 0x87BB57C VA: 0x87BF57C
	public bool get_textureBilinearFiltering() { }

	[NativeThrows]
	// RVA: 0x87BF5F4 Offset: 0x87BB5F4 VA: 0x87BF5F4
	public void set_textureBilinearFiltering(bool value) { }

	// RVA: 0x87BF67C Offset: 0x87BB67C VA: 0x87BF67C
	public int get_textureUVChannel() { }

	[NativeThrows]
	// RVA: 0x87BF6F4 Offset: 0x87BB6F4 VA: 0x87BF6F4
	public void set_textureUVChannel(int value) { }

	// RVA: 0x87BC97C Offset: 0x87B897C VA: 0x87BC97C
	private static bool get_enabled_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BC9FC Offset: 0x87B89FC VA: 0x87BC9FC
	private static void set_enabled_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BCA7C Offset: 0x87B8A7C VA: 0x87BCA7C
	private static ParticleSystemShapeType get_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCAFC Offset: 0x87B8AFC VA: 0x87BCAFC
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x87BCB40 Offset: 0x87B8B40 VA: 0x87BCB40
	private static float get_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCB7C Offset: 0x87B8B7C VA: 0x87BCB7C
	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BCC04 Offset: 0x87B8C04 VA: 0x87BCC04
	private static float get_sphericalDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCC8C Offset: 0x87B8C8C VA: 0x87BCC8C
	private static void set_sphericalDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BCD14 Offset: 0x87B8D14 VA: 0x87BCD14
	private static float get_randomPositionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCD9C Offset: 0x87B8D9C VA: 0x87BCD9C
	private static void set_randomPositionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BCE24 Offset: 0x87B8E24 VA: 0x87BCE24
	private static bool get_alignToDirection_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCEA4 Offset: 0x87B8EA4 VA: 0x87BCEA4
	private static void set_alignToDirection_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BCF24 Offset: 0x87B8F24 VA: 0x87BCF24
	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BCFAC Offset: 0x87B8FAC VA: 0x87BCFAC
	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD034 Offset: 0x87B9034 VA: 0x87BD034
	private static ParticleSystemShapeMultiModeValue get_radiusMode_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD0B4 Offset: 0x87B90B4 VA: 0x87BD0B4
	private static void set_radiusMode_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BD134 Offset: 0x87B9134 VA: 0x87BD134
	private static float get_radiusSpread_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD1BC Offset: 0x87B91BC VA: 0x87BD1BC
	private static void set_radiusSpread_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD268 Offset: 0x87B9268 VA: 0x87BD268
	private static void get_radiusSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BD2F0 Offset: 0x87B92F0 VA: 0x87BD2F0
	private static void set_radiusSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BD370 Offset: 0x87B9370 VA: 0x87BD370
	private static float get_radiusSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD3F8 Offset: 0x87B93F8 VA: 0x87BD3F8
	private static void set_radiusSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD480 Offset: 0x87B9480 VA: 0x87BD480
	private static float get_radiusThickness_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD508 Offset: 0x87B9508 VA: 0x87BD508
	private static void set_radiusThickness_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD590 Offset: 0x87B9590 VA: 0x87BD590
	private static float get_angle_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD618 Offset: 0x87B9618 VA: 0x87BD618
	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD6A0 Offset: 0x87B96A0 VA: 0x87BD6A0
	private static float get_length_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD728 Offset: 0x87B9728 VA: 0x87BD728
	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BD7D0 Offset: 0x87B97D0 VA: 0x87BD7D0
	private static void get_boxThickness_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x87BD868 Offset: 0x87B9868 VA: 0x87BD868
	private static void set_boxThickness_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x87BD8E8 Offset: 0x87B98E8 VA: 0x87BD8E8
	private static ParticleSystemMeshShapeType get_meshShapeType_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BD968 Offset: 0x87B9968 VA: 0x87BD968
	private static void set_meshShapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemMeshShapeType value) { }

	// RVA: 0x87BD9E8 Offset: 0x87B99E8 VA: 0x87BD9E8
	private static Mesh get_mesh_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDA68 Offset: 0x87B9A68 VA: 0x87BDA68
	private static void set_mesh_Injected(ref ParticleSystem.ShapeModule _unity_self, Mesh value) { }

	// RVA: 0x87BDAE8 Offset: 0x87B9AE8 VA: 0x87BDAE8
	private static MeshRenderer get_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDB68 Offset: 0x87B9B68 VA: 0x87BDB68
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	// RVA: 0x87BDBE8 Offset: 0x87B9BE8 VA: 0x87BDBE8
	private static SkinnedMeshRenderer get_skinnedMeshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDC68 Offset: 0x87B9C68 VA: 0x87BDC68
	private static void set_skinnedMeshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, SkinnedMeshRenderer value) { }

	// RVA: 0x87BDCE8 Offset: 0x87B9CE8 VA: 0x87BDCE8
	private static Sprite get_sprite_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDD68 Offset: 0x87B9D68 VA: 0x87BDD68
	private static void set_sprite_Injected(ref ParticleSystem.ShapeModule _unity_self, Sprite value) { }

	// RVA: 0x87BDDE8 Offset: 0x87B9DE8 VA: 0x87BDDE8
	private static SpriteRenderer get_spriteRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDE68 Offset: 0x87B9E68 VA: 0x87BDE68
	private static void set_spriteRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, SpriteRenderer value) { }

	// RVA: 0x87BDEE8 Offset: 0x87B9EE8 VA: 0x87BDEE8
	private static bool get_useMeshMaterialIndex_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BDF68 Offset: 0x87B9F68 VA: 0x87BDF68
	private static void set_useMeshMaterialIndex_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BDFE8 Offset: 0x87B9FE8 VA: 0x87BDFE8
	private static int get_meshMaterialIndex_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE068 Offset: 0x87BA068 VA: 0x87BE068
	private static void set_meshMaterialIndex_Injected(ref ParticleSystem.ShapeModule _unity_self, int value) { }

	// RVA: 0x87BE0E8 Offset: 0x87BA0E8 VA: 0x87BE0E8
	private static bool get_useMeshColors_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE168 Offset: 0x87BA168 VA: 0x87BE168
	private static void set_useMeshColors_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BE1E8 Offset: 0x87BA1E8 VA: 0x87BE1E8
	private static float get_normalOffset_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE270 Offset: 0x87BA270 VA: 0x87BE270
	private static void set_normalOffset_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BE2F8 Offset: 0x87BA2F8 VA: 0x87BE2F8
	private static ParticleSystemShapeMultiModeValue get_meshSpawnMode_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE378 Offset: 0x87BA378 VA: 0x87BE378
	private static void set_meshSpawnMode_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BE3F8 Offset: 0x87BA3F8 VA: 0x87BE3F8
	private static float get_meshSpawnSpread_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE480 Offset: 0x87BA480 VA: 0x87BE480
	private static void set_meshSpawnSpread_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BE52C Offset: 0x87BA52C VA: 0x87BE52C
	private static void get_meshSpawnSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BE5B4 Offset: 0x87BA5B4 VA: 0x87BE5B4
	private static void set_meshSpawnSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BE634 Offset: 0x87BA634 VA: 0x87BE634
	private static float get_meshSpawnSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE6BC Offset: 0x87BA6BC VA: 0x87BE6BC
	private static void set_meshSpawnSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BE744 Offset: 0x87BA744 VA: 0x87BE744
	private static float get_arc_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE7CC Offset: 0x87BA7CC VA: 0x87BE7CC
	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BE854 Offset: 0x87BA854 VA: 0x87BE854
	private static ParticleSystemShapeMultiModeValue get_arcMode_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE8D4 Offset: 0x87BA8D4 VA: 0x87BE8D4
	private static void set_arcMode_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeMultiModeValue value) { }

	// RVA: 0x87BE954 Offset: 0x87BA954 VA: 0x87BE954
	private static float get_arcSpread_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BE9DC Offset: 0x87BA9DC VA: 0x87BE9DC
	private static void set_arcSpread_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BEA88 Offset: 0x87BAA88 VA: 0x87BEA88
	private static void get_arcSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BEB10 Offset: 0x87BAB10 VA: 0x87BEB10
	private static void set_arcSpeed_Injected(ref ParticleSystem.ShapeModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x87BEB90 Offset: 0x87BAB90 VA: 0x87BEB90
	private static float get_arcSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BEC18 Offset: 0x87BAC18 VA: 0x87BEC18
	private static void set_arcSpeedMultiplier_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BECA0 Offset: 0x87BACA0 VA: 0x87BECA0
	private static float get_donutRadius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BED28 Offset: 0x87BAD28 VA: 0x87BED28
	private static void set_donutRadius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BEDD0 Offset: 0x87BADD0 VA: 0x87BEDD0
	private static void get_position_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x87BEE68 Offset: 0x87BAE68 VA: 0x87BEE68
	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x87BEF08 Offset: 0x87BAF08 VA: 0x87BEF08
	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x87BEFA0 Offset: 0x87BAFA0 VA: 0x87BEFA0
	private static void set_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x87BEFE4 Offset: 0x87BAFE4 VA: 0x87BEFE4
	private static void get_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x87BF028 Offset: 0x87BB028 VA: 0x87BF028
	private static void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x87BF0A8 Offset: 0x87BB0A8 VA: 0x87BF0A8
	private static Texture2D get_texture_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF128 Offset: 0x87BB128 VA: 0x87BF128
	private static void set_texture_Injected(ref ParticleSystem.ShapeModule _unity_self, Texture2D value) { }

	// RVA: 0x87BF1A8 Offset: 0x87BB1A8 VA: 0x87BF1A8
	private static ParticleSystemShapeTextureChannel get_textureClipChannel_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF228 Offset: 0x87BB228 VA: 0x87BF228
	private static void set_textureClipChannel_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeTextureChannel value) { }

	// RVA: 0x87BF2A8 Offset: 0x87BB2A8 VA: 0x87BF2A8
	private static float get_textureClipThreshold_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF330 Offset: 0x87BB330 VA: 0x87BF330
	private static void set_textureClipThreshold_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x87BF3B8 Offset: 0x87BB3B8 VA: 0x87BF3B8
	private static bool get_textureColorAffectsParticles_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF438 Offset: 0x87BB438 VA: 0x87BF438
	private static void set_textureColorAffectsParticles_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BF4B8 Offset: 0x87BB4B8 VA: 0x87BF4B8
	private static bool get_textureAlphaAffectsParticles_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF538 Offset: 0x87BB538 VA: 0x87BF538
	private static void set_textureAlphaAffectsParticles_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BF5B8 Offset: 0x87BB5B8 VA: 0x87BF5B8
	private static bool get_textureBilinearFiltering_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF638 Offset: 0x87BB638 VA: 0x87BF638
	private static void set_textureBilinearFiltering_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x87BF6B8 Offset: 0x87BB6B8 VA: 0x87BF6B8
	private static int get_textureUVChannel_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x87BF738 Offset: 0x87BB738 VA: 0x87BF738
	private static void set_textureUVChannel_Injected(ref ParticleSystem.ShapeModule _unity_self, int value) { }
}

// Namespace: 
public struct ParticleSystem.CollisionModule // TypeDefIndex: 27211
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9370 Offset: 0x87B5370 VA: 0x87B9370
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TriggerModule // TypeDefIndex: 27212
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9398 Offset: 0x87B5398 VA: 0x87B9398
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SubEmittersModule // TypeDefIndex: 27213
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B93C0 Offset: 0x87B53C0 VA: 0x87B93C0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TextureSheetAnimationModule // TypeDefIndex: 27214
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; }
	public ParticleSystemAnimationMode mode { get; }
	public int numTilesX { get; }
	public int numTilesY { get; }
	public ParticleSystemAnimationType animation { get; }
	public ParticleSystemAnimationRowMode rowMode { get; }
	public ParticleSystem.MinMaxCurve frameOverTime { get; }
	public int cycleCount { get; }
	public int rowIndex { get; }
	public UVChannelFlags uvChannelMask { get; set; }
	public int spriteCount { get; }

	// Methods

	// RVA: 0x87B93E8 Offset: 0x87B53E8 VA: 0x87B93E8
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87BF77C Offset: 0x87BB77C VA: 0x87BF77C
	public bool get_enabled() { }

	// RVA: 0x87BF7F4 Offset: 0x87BB7F4 VA: 0x87BF7F4
	public ParticleSystemAnimationMode get_mode() { }

	// RVA: 0x87BF86C Offset: 0x87BB86C VA: 0x87BF86C
	public int get_numTilesX() { }

	// RVA: 0x87BF8E4 Offset: 0x87BB8E4 VA: 0x87BF8E4
	public int get_numTilesY() { }

	// RVA: 0x87BF95C Offset: 0x87BB95C VA: 0x87BF95C
	public ParticleSystemAnimationType get_animation() { }

	// RVA: 0x87BF9D4 Offset: 0x87BB9D4 VA: 0x87BF9D4
	public ParticleSystemAnimationRowMode get_rowMode() { }

	// RVA: 0x87BFA4C Offset: 0x87BBA4C VA: 0x87BFA4C
	public ParticleSystem.MinMaxCurve get_frameOverTime() { }

	// RVA: 0x87BFAF0 Offset: 0x87BBAF0 VA: 0x87BFAF0
	public int get_cycleCount() { }

	// RVA: 0x87BFB68 Offset: 0x87BBB68 VA: 0x87BFB68
	public int get_rowIndex() { }

	// RVA: 0x87BFBE0 Offset: 0x87BBBE0 VA: 0x87BFBE0
	public UVChannelFlags get_uvChannelMask() { }

	[NativeThrows]
	// RVA: 0x87BFC58 Offset: 0x87BBC58 VA: 0x87BFC58
	public void set_uvChannelMask(UVChannelFlags value) { }

	// RVA: 0x87BFCE0 Offset: 0x87BBCE0 VA: 0x87BFCE0
	public int get_spriteCount() { }

	[NativeThrows]
	// RVA: 0x87BFD58 Offset: 0x87BBD58 VA: 0x87BFD58
	public Sprite GetSprite(int index) { }

	// RVA: 0x87BF7B8 Offset: 0x87BB7B8 VA: 0x87BF7B8
	private static bool get_enabled_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BF830 Offset: 0x87BB830 VA: 0x87BF830
	private static ParticleSystemAnimationMode get_mode_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BF8A8 Offset: 0x87BB8A8 VA: 0x87BF8A8
	private static int get_numTilesX_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BF920 Offset: 0x87BB920 VA: 0x87BF920
	private static int get_numTilesY_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BF998 Offset: 0x87BB998 VA: 0x87BF998
	private static ParticleSystemAnimationType get_animation_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFA10 Offset: 0x87BBA10 VA: 0x87BFA10
	private static ParticleSystemAnimationRowMode get_rowMode_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFAAC Offset: 0x87BBAAC VA: 0x87BFAAC
	private static void get_frameOverTime_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87BFB2C Offset: 0x87BBB2C VA: 0x87BFB2C
	private static int get_cycleCount_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFBA4 Offset: 0x87BBBA4 VA: 0x87BFBA4
	private static int get_rowIndex_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFC1C Offset: 0x87BBC1C VA: 0x87BFC1C
	private static UVChannelFlags get_uvChannelMask_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFC9C Offset: 0x87BBC9C VA: 0x87BFC9C
	private static void set_uvChannelMask_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, UVChannelFlags value) { }

	// RVA: 0x87BFD1C Offset: 0x87BBD1C VA: 0x87BFD1C
	private static int get_spriteCount_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self) { }

	// RVA: 0x87BFD9C Offset: 0x87BBD9C VA: 0x87BFD9C
	private static Sprite GetSprite_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, int index) { }
}

// Namespace: 
[RequiredByNativeCode("particleSystemParticle", Optional = True)]
public struct ParticleSystem.Particle // TypeDefIndex: 27215
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
	public float lifetime { set; }
	public Vector3 position { get; set; }
	public Vector3 velocity { get; set; }
	public float remainingLifetime { get; set; }
	public float startLifetime { get; set; }
	public Color32 startColor { set; }
	public uint randomSeed { get; set; }
	public float startSize { set; }
	public Vector3 rotation3D { get; set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x87B5D10 Offset: 0x87B1D10 VA: 0x87B5D10
	public void set_lifetime(float value) { }

	// RVA: 0x87BFDE8 Offset: 0x87BBDE8 VA: 0x87BFDE8
	public Vector3 get_position() { }

	// RVA: 0x87B5CF8 Offset: 0x87B1CF8 VA: 0x87B5CF8
	public void set_position(Vector3 value) { }

	// RVA: 0x87BFDF4 Offset: 0x87BBDF4 VA: 0x87BFDF4
	public Vector3 get_velocity() { }

	// RVA: 0x87B5D04 Offset: 0x87B1D04 VA: 0x87B5D04
	public void set_velocity(Vector3 value) { }

	// RVA: 0x87BFE00 Offset: 0x87BBE00 VA: 0x87BFE00
	public float get_remainingLifetime() { }

	// RVA: 0x87BFDE0 Offset: 0x87BBDE0 VA: 0x87BFDE0
	public void set_remainingLifetime(float value) { }

	// RVA: 0x87BFE08 Offset: 0x87BBE08 VA: 0x87BFE08
	public float get_startLifetime() { }

	// RVA: 0x87B5D18 Offset: 0x87B1D18 VA: 0x87B5D18
	public void set_startLifetime(float value) { }

	// RVA: 0x87B5D84 Offset: 0x87B1D84 VA: 0x87B5D84
	public void set_startColor(Color32 value) { }

	// RVA: 0x87BFE10 Offset: 0x87BBE10 VA: 0x87BFE10
	public uint get_randomSeed() { }

	// RVA: 0x87B5D8C Offset: 0x87B1D8C VA: 0x87B5D8C
	public void set_randomSeed(uint value) { }

	// RVA: 0x87B5D20 Offset: 0x87B1D20 VA: 0x87B5D20
	public void set_startSize(float value) { }

	// RVA: 0x87BFE18 Offset: 0x87BBE18 VA: 0x87BFE18
	public Vector3 get_rotation3D() { }

	// RVA: 0x87B5D2C Offset: 0x87B1D2C VA: 0x87B5D2C
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x87B5D58 Offset: 0x87B1D58 VA: 0x87B5D58
	public void set_angularVelocity3D(Vector3 value) { }

	// RVA: 0x87BFE38 Offset: 0x87BBE38 VA: 0x87BFE38
	public Vector3 GetCurrentSize3D(ParticleSystem system) { }

	// RVA: 0x87BFE54 Offset: 0x87BBE54 VA: 0x87BFE54
	public Color32 GetCurrentColor(ParticleSystem system) { }
}

// Namespace: 
[NativeType(1, "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
public struct ParticleSystem.Burst // TypeDefIndex: 27216
{
	// Fields
	private float m_Time; // 0x0
	private ParticleSystem.MinMaxCurve m_Count; // 0x8
	private int m_RepeatCount; // 0x28
	private float m_RepeatInterval; // 0x2C
	private float m_InvProbability; // 0x30
}

// Namespace: 
[NativeType(1, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 27217
{
	// Fields
	[SerializeField]
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField]
	private float m_CurveMultiplier; // 0x4
	[SerializeField]
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField]
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField]
	private float m_ConstantMin; // 0x18
	[SerializeField]
	private float m_ConstantMax; // 0x1C

	// Properties
	public ParticleSystemCurveMode mode { get; set; }
	public float curveMultiplier { get; set; }
	public AnimationCurve curveMax { get; set; }
	public AnimationCurve curveMin { get; set; }
	public float constantMax { get; set; }
	public float constantMin { get; set; }
	public float constant { get; set; }
	public AnimationCurve curve { get; set; }

	// Methods

	// RVA: 0x87BFEB8 Offset: 0x87BBEB8 VA: 0x87BFEB8
	public void .ctor(float constant) { }

	// RVA: 0x87BFEFC Offset: 0x87BBEFC VA: 0x87BFEFC
	public void .ctor(float multiplier, AnimationCurve curve) { }

	// RVA: 0x87BFF44 Offset: 0x87BBF44 VA: 0x87BFF44
	public void .ctor(float multiplier, AnimationCurve min, AnimationCurve max) { }

	// RVA: 0x87BFF88 Offset: 0x87BBF88 VA: 0x87BFF88
	public void .ctor(float min, float max) { }

	// RVA: 0x87BFFD0 Offset: 0x87BBFD0 VA: 0x87BFFD0
	public ParticleSystemCurveMode get_mode() { }

	// RVA: 0x87BFFD8 Offset: 0x87BBFD8 VA: 0x87BFFD8
	public void set_mode(ParticleSystemCurveMode value) { }

	// RVA: 0x87BFFE0 Offset: 0x87BBFE0 VA: 0x87BFFE0
	public float get_curveMultiplier() { }

	// RVA: 0x87BFFE8 Offset: 0x87BBFE8 VA: 0x87BFFE8
	public void set_curveMultiplier(float value) { }

	// RVA: 0x87BFFF0 Offset: 0x87BBFF0 VA: 0x87BFFF0
	public AnimationCurve get_curveMax() { }

	// RVA: 0x87BFFF8 Offset: 0x87BBFF8 VA: 0x87BFFF8
	public void set_curveMax(AnimationCurve value) { }

	// RVA: 0x87C0000 Offset: 0x87BC000 VA: 0x87C0000
	public AnimationCurve get_curveMin() { }

	// RVA: 0x87C0008 Offset: 0x87BC008 VA: 0x87C0008
	public void set_curveMin(AnimationCurve value) { }

	// RVA: 0x87C0010 Offset: 0x87BC010 VA: 0x87C0010
	public float get_constantMax() { }

	// RVA: 0x87C0018 Offset: 0x87BC018 VA: 0x87C0018
	public void set_constantMax(float value) { }

	// RVA: 0x87C0020 Offset: 0x87BC020 VA: 0x87C0020
	public float get_constantMin() { }

	// RVA: 0x87C0028 Offset: 0x87BC028 VA: 0x87C0028
	public void set_constantMin(float value) { }

	// RVA: 0x87C0030 Offset: 0x87BC030 VA: 0x87C0030
	public float get_constant() { }

	// RVA: 0x87C0038 Offset: 0x87BC038 VA: 0x87C0038
	public void set_constant(float value) { }

	// RVA: 0x87C0040 Offset: 0x87BC040 VA: 0x87C0040
	public AnimationCurve get_curve() { }

	// RVA: 0x87C0048 Offset: 0x87BC048 VA: 0x87C0048
	public void set_curve(AnimationCurve value) { }

	// RVA: 0x87C0050 Offset: 0x87BC050 VA: 0x87C0050
	public float Evaluate(float time) { }

	// RVA: 0x87C0058 Offset: 0x87BC058 VA: 0x87C0058
	public float Evaluate(float time, float lerpFactor) { }

	// RVA: 0x87B662C Offset: 0x87B262C VA: 0x87B662C
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }
}

// Namespace: 
[NativeType(1, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 27218
{
	// Fields
	[SerializeField]
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField]
	private Gradient m_GradientMin; // 0x8
	[SerializeField]
	private Gradient m_GradientMax; // 0x10
	[SerializeField]
	private Color m_ColorMin; // 0x18
	[SerializeField]
	private Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x87C0140 Offset: 0x87BC140 VA: 0x87C0140
	public void .ctor(Color color) { }

	// RVA: 0x87C01A4 Offset: 0x87BC1A4 VA: 0x87C01A4
	public void .ctor(Gradient gradient) { }

	// RVA: 0x87B6A4C Offset: 0x87B2A4C VA: 0x87B6A4C
	public Color get_color() { }

	// RVA: 0x87B6B10 Offset: 0x87B2B10 VA: 0x87B6B10
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	// RVA: 0x87C01F4 Offset: 0x87BC1F4 VA: 0x87C01F4
	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }
}

// Namespace: 
public struct ParticleSystem.EmitParams // TypeDefIndex: 27219
{
	// Fields
	[NativeName("particle")]
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeName("positionSet")]
	private bool m_PositionSet; // 0x84
	[NativeName("velocitySet")]
	private bool m_VelocitySet; // 0x85
	[NativeName("axisOfRotationSet")]
	private bool m_AxisOfRotationSet; // 0x86
	[NativeName("rotationSet")]
	private bool m_RotationSet; // 0x87
	[NativeName("rotationalSpeedSet")]
	private bool m_AngularVelocitySet; // 0x88
	[NativeName("startSizeSet")]
	private bool m_StartSizeSet; // 0x89
	[NativeName("startColorSet")]
	private bool m_StartColorSet; // 0x8A
	[NativeName("randomSeedSet")]
	private bool m_RandomSeedSet; // 0x8B
	[NativeName("startLifetimeSet")]
	private bool m_StartLifetimeSet; // 0x8C
	[NativeName("meshIndexSet")]
	private bool m_MeshIndexSet; // 0x8D
	[NativeName("applyShapeToPosition")]
	private bool m_ApplyShapeToPosition; // 0x8E
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed // TypeDefIndex: 27220
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed4 // TypeDefIndex: 27221
{
	// Fields
	public ParticleSystem.PlaybackState.Seed x; // 0x0
	public ParticleSystem.PlaybackState.Seed y; // 0x10
	public ParticleSystem.PlaybackState.Seed z; // 0x20
	public ParticleSystem.PlaybackState.Seed w; // 0x30
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Emission // TypeDefIndex: 27222
{
	// Fields
	public float m_ParticleSpacing; // 0x0
	public float m_ToEmitAccumulator; // 0x4
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x8
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Initial // TypeDefIndex: 27223
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Shape // TypeDefIndex: 27224
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
	public float m_RadiusTimer; // 0x40
	public float m_RadiusTimerPrev; // 0x44
	public float m_ArcTimer; // 0x48
	public float m_ArcTimerPrev; // 0x4C
	public float m_MeshSpawnTimer; // 0x50
	public float m_MeshSpawnTimerPrev; // 0x54
	public int m_OrderedMeshVertexIndex; // 0x58
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Force // TypeDefIndex: 27225
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Collision // TypeDefIndex: 27226
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Noise // TypeDefIndex: 27227
{
	// Fields
	public float m_ScrollOffset; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Lights // TypeDefIndex: 27228
{
	// Fields
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x0
	public float m_ParticleEmissionCounter; // 0x10
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Trail // TypeDefIndex: 27229
{
	// Fields
	public float m_Timer; // 0x0
}

// Namespace: 
public struct ParticleSystem.PlaybackState // TypeDefIndex: 27230
{
	// Fields
	internal float m_AccumulatedDt; // 0x0
	internal float m_StartDelay; // 0x4
	internal float m_PlaybackTime; // 0x8
	internal int m_RingBufferIndex; // 0xC
	internal ParticleSystem.PlaybackState.Emission m_Emission; // 0x10
	internal ParticleSystem.PlaybackState.Initial m_Initial; // 0x28
	internal ParticleSystem.PlaybackState.Shape m_Shape; // 0x68
	internal ParticleSystem.PlaybackState.Force m_Force; // 0xC4
	internal ParticleSystem.PlaybackState.Collision m_Collision; // 0x104
	internal ParticleSystem.PlaybackState.Noise m_Noise; // 0x144
	internal ParticleSystem.PlaybackState.Lights m_Lights; // 0x148
	internal ParticleSystem.PlaybackState.Trail m_Trail; // 0x15C
}

// Namespace: 
[NativeType(1, "MonoParticleTrails")]
public struct ParticleSystem.Trails // TypeDefIndex: 27231
{
	// Fields
	internal List<Vector4> positions; // 0x0
	internal List<int> frontPositions; // 0x8
	internal List<int> backPositions; // 0x10
	internal List<int> positionCounts; // 0x18
	internal List<float> textureOffsets; // 0x20
	internal int maxTrailCount; // 0x28
	internal int maxPositionsPerTrailCount; // 0x2C

	// Methods

	// RVA: 0x87B82DC Offset: 0x87B42DC VA: 0x87B82DC
	internal void Allocate() { }
}

// Namespace: 
public struct ParticleSystem.VelocityOverLifetimeModule // TypeDefIndex: 27232
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; }
	public ParticleSystem.MinMaxCurve x { get; }
	public ParticleSystem.MinMaxCurve y { get; }
	public ParticleSystem.MinMaxCurve z { get; }

	// Methods

	// RVA: 0x87B9168 Offset: 0x87B5168 VA: 0x87B9168
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87C024C Offset: 0x87BC24C VA: 0x87C024C
	public bool get_enabled() { }

	// RVA: 0x87C02C4 Offset: 0x87BC2C4 VA: 0x87C02C4
	public ParticleSystem.MinMaxCurve get_x() { }

	// RVA: 0x87C0368 Offset: 0x87BC368 VA: 0x87C0368
	public ParticleSystem.MinMaxCurve get_y() { }

	// RVA: 0x87C040C Offset: 0x87BC40C VA: 0x87C040C
	public ParticleSystem.MinMaxCurve get_z() { }

	// RVA: 0x87C0288 Offset: 0x87BC288 VA: 0x87C0288
	private static bool get_enabled_Injected(ref ParticleSystem.VelocityOverLifetimeModule _unity_self) { }

	// RVA: 0x87C0324 Offset: 0x87BC324 VA: 0x87C0324
	private static void get_x_Injected(ref ParticleSystem.VelocityOverLifetimeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87C03C8 Offset: 0x87BC3C8 VA: 0x87C03C8
	private static void get_y_Injected(ref ParticleSystem.VelocityOverLifetimeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x87C046C Offset: 0x87BC46C VA: 0x87C046C
	private static void get_z_Injected(ref ParticleSystem.VelocityOverLifetimeModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }
}

// Namespace: 
public struct ParticleSystem.LimitVelocityOverLifetimeModule // TypeDefIndex: 27233
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9190 Offset: 0x87B5190 VA: 0x87B9190
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.InheritVelocityModule // TypeDefIndex: 27234
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B91B8 Offset: 0x87B51B8 VA: 0x87B91B8
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LifetimeByEmitterSpeedModule // TypeDefIndex: 27235
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B91E0 Offset: 0x87B51E0 VA: 0x87B91E0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ForceOverLifetimeModule // TypeDefIndex: 27236
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9208 Offset: 0x87B5208 VA: 0x87B9208
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 27237
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystem.MinMaxGradient color { set; }

	// Methods

	// RVA: 0x87B9230 Offset: 0x87B5230 VA: 0x87B9230
	internal void .ctor(ParticleSystem particleSystem) { }

	[NativeThrows]
	// RVA: 0x87C04B0 Offset: 0x87BC4B0 VA: 0x87C04B0
	public void set_color(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x87C04F4 Offset: 0x87BC4F4 VA: 0x87C04F4
	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }
}

// Namespace: 
public struct ParticleSystem.ColorBySpeedModule // TypeDefIndex: 27238
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9258 Offset: 0x87B5258 VA: 0x87B9258
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeOverLifetimeModule // TypeDefIndex: 27239
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9280 Offset: 0x87B5280 VA: 0x87B9280
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeBySpeedModule // TypeDefIndex: 27240
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B92A8 Offset: 0x87B52A8 VA: 0x87B92A8
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationOverLifetimeModule // TypeDefIndex: 27241
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B92D0 Offset: 0x87B52D0 VA: 0x87B92D0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationBySpeedModule // TypeDefIndex: 27242
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B92F8 Offset: 0x87B52F8 VA: 0x87B92F8
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ExternalForcesModule // TypeDefIndex: 27243
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9320 Offset: 0x87B5320 VA: 0x87B9320
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.NoiseModule // TypeDefIndex: 27244
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9348 Offset: 0x87B5348 VA: 0x87B9348
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LightsModule // TypeDefIndex: 27245
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9410 Offset: 0x87B5410 VA: 0x87B9410
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TrailModule // TypeDefIndex: 27246
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; }
	public bool worldSpace { get; }

	// Methods

	// RVA: 0x87B9438 Offset: 0x87B5438 VA: 0x87B9438
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x87C0538 Offset: 0x87BC538 VA: 0x87C0538
	public bool get_enabled() { }

	// RVA: 0x87C05B0 Offset: 0x87BC5B0 VA: 0x87C05B0
	public bool get_worldSpace() { }

	// RVA: 0x87C0574 Offset: 0x87BC574 VA: 0x87C0574
	private static bool get_enabled_Injected(ref ParticleSystem.TrailModule _unity_self) { }

	// RVA: 0x87C05EC Offset: 0x87BC5EC VA: 0x87C05EC
	private static bool get_worldSpace_Injected(ref ParticleSystem.TrailModule _unity_self) { }
}

// Namespace: 
public struct ParticleSystem.CustomDataModule // TypeDefIndex: 27247
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x87B9460 Offset: 0x87B5460 VA: 0x87B9460
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UsedByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
public sealed class ParticleSystem : Component // TypeDefIndex: 27248
{
	// Properties
	[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
	public float startDelay { get; set; }
	[Obsolete("loop property is deprecated. Use main.loop instead.", False)]
	public bool loop { get; set; }
	[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
	public bool playOnAwake { get; set; }
	[Obsolete("duration property is deprecated. Use main.duration instead.", False)]
	public float duration { get; }
	[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
	public float playbackSpeed { get; set; }
	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	public bool enableEmission { get; set; }
	[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
	public float emissionRate { get; set; }
	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	public float startSpeed { get; set; }
	[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
	public float startSize { get; set; }
	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor { get; set; }
	[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
	public float startRotation { get; set; }
	[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
	public Vector3 startRotation3D { get; set; }
	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	public float startLifetime { get; set; }
	[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
	public float gravityModifier { get; set; }
	[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
	public int maxParticles { get; set; }
	[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
	public ParticleSystemScalingMode scalingMode { get; set; }
	[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
	public bool automaticCullingEnabled { get; }
	public bool isPlaying { get; }
	public bool isEmitting { get; }
	public bool isStopped { get; }
	public bool isPaused { get; }
	public int particleCount { get; }
	public float time { get; set; }
	public float totalTime { get; }
	public uint randomSeed { get; set; }
	public bool useAutoRandomSeed { get; set; }
	public bool proceduralSimulationSupported { get; }
	public bool has3DParticleRotations { get; }
	public bool hasNonUniformParticleSizes { get; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
	public ParticleSystem.InheritVelocityModule inheritVelocity { get; }
	public ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; }
	public ParticleSystem.ForceOverLifetimeModule forceOverLifetime { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.ColorBySpeedModule colorBySpeed { get; }
	public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime { get; }
	public ParticleSystem.SizeBySpeedModule sizeBySpeed { get; }
	public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime { get; }
	public ParticleSystem.RotationBySpeedModule rotationBySpeed { get; }
	public ParticleSystem.ExternalForcesModule externalForces { get; }
	public ParticleSystem.NoiseModule noise { get; }
	public ParticleSystem.CollisionModule collision { get; }
	public ParticleSystem.TriggerModule trigger { get; }
	public ParticleSystem.SubEmittersModule subEmitters { get; }
	public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
	public ParticleSystem.LightsModule lights { get; }
	public ParticleSystem.TrailModule trails { get; }
	public ParticleSystem.CustomDataModule customData { get; }

	// Methods

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x87B5BF4 Offset: 0x87B1BF4 VA: 0x87B5BF4
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x87B5DD8 Offset: 0x87B1DD8 VA: 0x87B5DD8
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x87B5E1C Offset: 0x87B1E1C VA: 0x87B5E1C
	public float get_startDelay() { }

	// RVA: 0x87B5ECC Offset: 0x87B1ECC VA: 0x87B5ECC
	public void set_startDelay(float value) { }

	// RVA: 0x87B5F80 Offset: 0x87B1F80 VA: 0x87B5F80
	public bool get_loop() { }

	// RVA: 0x87B6014 Offset: 0x87B2014 VA: 0x87B6014
	public void set_loop(bool value) { }

	// RVA: 0x87B60BC Offset: 0x87B20BC VA: 0x87B60BC
	public bool get_playOnAwake() { }

	// RVA: 0x87B6150 Offset: 0x87B2150 VA: 0x87B6150
	public void set_playOnAwake(bool value) { }

	// RVA: 0x87B61F8 Offset: 0x87B21F8 VA: 0x87B61F8
	public float get_duration() { }

	// RVA: 0x87B6288 Offset: 0x87B2288 VA: 0x87B6288
	public float get_playbackSpeed() { }

	// RVA: 0x87B6318 Offset: 0x87B2318 VA: 0x87B6318
	public void set_playbackSpeed(float value) { }

	// RVA: 0x87B63CC Offset: 0x87B23CC VA: 0x87B63CC
	public bool get_enableEmission() { }

	// RVA: 0x87B6480 Offset: 0x87B2480 VA: 0x87B6480
	public void set_enableEmission(bool value) { }

	// RVA: 0x87B6528 Offset: 0x87B2528 VA: 0x87B6528
	public float get_emissionRate() { }

	// RVA: 0x87B65B8 Offset: 0x87B25B8 VA: 0x87B65B8
	public void set_emissionRate(float value) { }

	// RVA: 0x87B66DC Offset: 0x87B26DC VA: 0x87B66DC
	public float get_startSpeed() { }

	// RVA: 0x87B676C Offset: 0x87B276C VA: 0x87B676C
	public void set_startSpeed(float value) { }

	// RVA: 0x87B6820 Offset: 0x87B2820 VA: 0x87B6820
	public float get_startSize() { }

	// RVA: 0x87B68B0 Offset: 0x87B28B0 VA: 0x87B68B0
	public void set_startSize(float value) { }

	// RVA: 0x87B6964 Offset: 0x87B2964 VA: 0x87B6964
	public Color get_startColor() { }

	// RVA: 0x87B6A58 Offset: 0x87B2A58 VA: 0x87B6A58
	public void set_startColor(Color value) { }

	// RVA: 0x87B6BA8 Offset: 0x87B2BA8 VA: 0x87B6BA8
	public float get_startRotation() { }

	// RVA: 0x87B6C38 Offset: 0x87B2C38 VA: 0x87B6C38
	public void set_startRotation(float value) { }

	// RVA: 0x87B6CEC Offset: 0x87B2CEC VA: 0x87B6CEC
	public Vector3 get_startRotation3D() { }

	// RVA: 0x87B6E9C Offset: 0x87B2E9C VA: 0x87B6E9C
	public void set_startRotation3D(Vector3 value) { }

	// RVA: 0x87B7050 Offset: 0x87B3050 VA: 0x87B7050
	public float get_startLifetime() { }

	// RVA: 0x87B70E0 Offset: 0x87B30E0 VA: 0x87B70E0
	public void set_startLifetime(float value) { }

	// RVA: 0x87B7194 Offset: 0x87B3194 VA: 0x87B7194
	public float get_gravityModifier() { }

	// RVA: 0x87B7224 Offset: 0x87B3224 VA: 0x87B7224
	public void set_gravityModifier(float value) { }

	// RVA: 0x87B72D8 Offset: 0x87B32D8 VA: 0x87B72D8
	public int get_maxParticles() { }

	// RVA: 0x87B7368 Offset: 0x87B3368 VA: 0x87B7368
	public void set_maxParticles(int value) { }

	// RVA: 0x87B7410 Offset: 0x87B3410 VA: 0x87B7410
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x87B74A0 Offset: 0x87B34A0 VA: 0x87B74A0
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x87B7548 Offset: 0x87B3548 VA: 0x87B7548
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x87B75D8 Offset: 0x87B35D8 VA: 0x87B75D8
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x87B7680 Offset: 0x87B3680 VA: 0x87B7680
	public bool get_automaticCullingEnabled() { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	// RVA: 0x87B76F8 Offset: 0x87B36F8 VA: 0x87B76F8
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->IsEmitting")]
	// RVA: 0x87B7734 Offset: 0x87B3734 VA: 0x87B7734
	public bool get_isEmitting() { }

	[NativeName("SyncJobs(false)->IsStopped")]
	// RVA: 0x87B7770 Offset: 0x87B3770 VA: 0x87B7770
	public bool get_isStopped() { }

	[NativeName("SyncJobs(false)->IsPaused")]
	// RVA: 0x87B77AC Offset: 0x87B37AC VA: 0x87B77AC
	public bool get_isPaused() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	// RVA: 0x87B77E8 Offset: 0x87B37E8 VA: 0x87B77E8
	public int get_particleCount() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	// RVA: 0x87B7824 Offset: 0x87B3824 VA: 0x87B7824
	public float get_time() { }

	[NativeName("SyncJobs(false)->SetSecPosition")]
	// RVA: 0x87B7860 Offset: 0x87B3860 VA: 0x87B7860
	public void set_time(float value) { }

	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	// RVA: 0x87B78AC Offset: 0x87B38AC VA: 0x87B78AC
	public float get_totalTime() { }

	[NativeName("GetRandomSeed")]
	// RVA: 0x87B78E8 Offset: 0x87B38E8 VA: 0x87B78E8
	public uint get_randomSeed() { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	// RVA: 0x87B7924 Offset: 0x87B3924 VA: 0x87B7924
	public void set_randomSeed(uint value) { }

	[NativeName("GetAutoRandomSeed")]
	// RVA: 0x87B7968 Offset: 0x87B3968 VA: 0x87B7968
	public bool get_useAutoRandomSeed() { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	// RVA: 0x87B79A4 Offset: 0x87B39A4 VA: 0x87B79A4
	public void set_useAutoRandomSeed(bool value) { }

	// RVA: 0x87B76BC Offset: 0x87B36BC VA: 0x87B76BC
	public bool get_proceduralSimulationSupported() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	// RVA: 0x87B79E8 Offset: 0x87B39E8 VA: 0x87B79E8
	internal float GetParticleCurrentSize(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = True)]
	// RVA: 0x87B7A2C Offset: 0x87B3A2C VA: 0x87B7A2C
	internal Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	// RVA: 0x87B7AE4 Offset: 0x87B3AE4 VA: 0x87B7AE4
	internal Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = True)]
	// RVA: 0x87B7B94 Offset: 0x87B3B94 VA: 0x87B7B94
	internal int GetParticleMeshIndex(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B7BD8 Offset: 0x87B3BD8 VA: 0x87B7BD8
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x87B7C34 Offset: 0x87B3C34 VA: 0x87B7C34
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x87B7C8C Offset: 0x87B3C8C VA: 0x87B7C8C
	public void SetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B7CD8 Offset: 0x87B3CD8 VA: 0x87B7CD8
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x87B7D44 Offset: 0x87B3D44 VA: 0x87B7D44
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x87B7DF4 Offset: 0x87B3DF4 VA: 0x87B7DF4
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x87B7DFC Offset: 0x87B3DFC VA: 0x87B7DFC
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B7E08 Offset: 0x87B3E08 VA: 0x87B7E08
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x87B7E64 Offset: 0x87B3E64 VA: 0x87B7E64
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x87B7EBC Offset: 0x87B3EBC VA: 0x87B7EBC
	public int GetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B7F08 Offset: 0x87B3F08 VA: 0x87B7F08
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x87B7F74 Offset: 0x87B3F74 VA: 0x87B7F74
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x87B8024 Offset: 0x87B4024 VA: 0x87B8024
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x87B802C Offset: 0x87B402C VA: 0x87B802C
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B8038 Offset: 0x87B4038 VA: 0x87B8038
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x87B808C Offset: 0x87B408C VA: 0x87B808C
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x87B80E0 Offset: 0x87B40E0 VA: 0x87B80E0
	public ParticleSystem.PlaybackState GetPlaybackState() { }

	// RVA: 0x87B819C Offset: 0x87B419C VA: 0x87B819C
	public void SetPlaybackState(ParticleSystem.PlaybackState playbackState) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = True)]
	// RVA: 0x87B8224 Offset: 0x87B4224 VA: 0x87B8224
	private void GetTrailDataInternal(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x87B8268 Offset: 0x87B4268 VA: 0x87B8268
	public ParticleSystem.Trails GetTrails() { }

	// RVA: 0x87B8490 Offset: 0x87B4490 VA: 0x87B8490
	public int GetTrails(ref ParticleSystem.Trails trailData) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
	// RVA: 0x87B8510 Offset: 0x87B4510 VA: 0x87B8510
	public void SetTrails(ParticleSystem.Trails trailData) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	// RVA: 0x87B8598 Offset: 0x87B4598 VA: 0x87B8598
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x87B8604 Offset: 0x87B4604 VA: 0x87B8604
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x87B866C Offset: 0x87B466C VA: 0x87B866C
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x87B86C8 Offset: 0x87B46C8 VA: 0x87B86C8
	public void Simulate(float t) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	// RVA: 0x87B8720 Offset: 0x87B4720 VA: 0x87B8720
	public void Play(bool withChildren) { }

	// RVA: 0x87B8764 Offset: 0x87B4764 VA: 0x87B8764
	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	// RVA: 0x87B87A4 Offset: 0x87B47A4 VA: 0x87B87A4
	public void Pause(bool withChildren) { }

	// RVA: 0x87B87E8 Offset: 0x87B47E8 VA: 0x87B87E8
	public void Pause() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	// RVA: 0x87B8828 Offset: 0x87B4828 VA: 0x87B8828
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x87B887C Offset: 0x87B487C VA: 0x87B887C
	public void Stop(bool withChildren) { }

	// RVA: 0x87B88C4 Offset: 0x87B48C4 VA: 0x87B88C4
	public void Stop() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	// RVA: 0x87B8908 Offset: 0x87B4908 VA: 0x87B8908
	public void Clear(bool withChildren) { }

	// RVA: 0x87B894C Offset: 0x87B494C VA: 0x87B894C
	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	// RVA: 0x87B898C Offset: 0x87B498C VA: 0x87B898C
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x87B89D0 Offset: 0x87B49D0 VA: 0x87B89D0
	public bool IsAlive() { }

	[RequiredByNativeCode]
	// RVA: 0x87B8A10 Offset: 0x87B4A10 VA: 0x87B8A10
	public void Emit(int count) { }

	[NativeName("SyncJobs()->Emit")]
	// RVA: 0x87B8A54 Offset: 0x87B4A54 VA: 0x87B8A54
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	// RVA: 0x87B8A98 Offset: 0x87B4A98 VA: 0x87B8A98
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	// RVA: 0x87B5D94 Offset: 0x87B1D94 VA: 0x87B5D94
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x87B8B40 Offset: 0x87B4B40 VA: 0x87B8B40
	public void TriggerSubEmitter(int subEmitterIndex) { }

	// RVA: 0x87B8BDC Offset: 0x87B4BDC VA: 0x87B8BDC
	public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = True)]
	// RVA: 0x87B8C44 Offset: 0x87B4C44 VA: 0x87B8C44
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = True)]
	// RVA: 0x87B8B88 Offset: 0x87B4B88 VA: 0x87B8B88
	public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
	// RVA: 0x87B8CEC Offset: 0x87B4CEC VA: 0x87B8CEC
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
	// RVA: 0x87B8D14 Offset: 0x87B4D14 VA: 0x87B8D14
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	[NativeName("SetUsesAxisOfRotation")]
	// RVA: 0x87B8D58 Offset: 0x87B4D58 VA: 0x87B8D58
	public void AllocateAxisOfRotationAttribute() { }

	[NativeName("SetUsesMeshIndex")]
	// RVA: 0x87B8D94 Offset: 0x87B4D94 VA: 0x87B8D94
	public void AllocateMeshIndexAttribute() { }

	[NativeName("SetUsesCustomData")]
	// RVA: 0x87B8DD0 Offset: 0x87B4DD0 VA: 0x87B8DD0
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	[NativeName("Has3DParticleRotations")]
	// RVA: 0x87B8E14 Offset: 0x87B4E14 VA: 0x87B8E14
	public bool get_has3DParticleRotations() { }

	[NativeName("HasNonUniformParticleSizes")]
	// RVA: 0x87B8E50 Offset: 0x87B4E50 VA: 0x87B8E50
	public bool get_hasNonUniformParticleSizes() { }

	// RVA: 0x87B8E8C Offset: 0x87B4E8C VA: 0x87B8E8C
	internal void* GetManagedJobData() { }

	// RVA: 0x87B8EC8 Offset: 0x87B4EC8 VA: 0x87B8EC8
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x87B8F60 Offset: 0x87B4F60 VA: 0x87B8F60
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunction("ScheduleManagedJob", ThrowsException = True)]
	// RVA: 0x87B8FF4 Offset: 0x87B4FF4 VA: 0x87B8FF4
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafe]
	// RVA: 0x87B90A4 Offset: 0x87B50A4 VA: 0x87B90A4
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x87B90E8 Offset: 0x87B50E8 VA: 0x87B90E8
	internal static bool UserJobCanBeScheduled() { }

	// RVA: 0x87B5E70 Offset: 0x87B1E70 VA: 0x87B5E70
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x87B6424 Offset: 0x87B2424 VA: 0x87B6424
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x87B9120 Offset: 0x87B5120 VA: 0x87B9120
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x87B9148 Offset: 0x87B5148 VA: 0x87B9148
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x87B9170 Offset: 0x87B5170 VA: 0x87B9170
	public ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0x87B9198 Offset: 0x87B5198 VA: 0x87B9198
	public ParticleSystem.InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0x87B91C0 Offset: 0x87B51C0 VA: 0x87B91C0
	public ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	// RVA: 0x87B91E8 Offset: 0x87B51E8 VA: 0x87B91E8
	public ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0x87B9210 Offset: 0x87B5210 VA: 0x87B9210
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x87B9238 Offset: 0x87B5238 VA: 0x87B9238
	public ParticleSystem.ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0x87B9260 Offset: 0x87B5260 VA: 0x87B9260
	public ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0x87B9288 Offset: 0x87B5288 VA: 0x87B9288
	public ParticleSystem.SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0x87B92B0 Offset: 0x87B52B0 VA: 0x87B92B0
	public ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0x87B92D8 Offset: 0x87B52D8 VA: 0x87B92D8
	public ParticleSystem.RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0x87B9300 Offset: 0x87B5300 VA: 0x87B9300
	public ParticleSystem.ExternalForcesModule get_externalForces() { }

	// RVA: 0x87B9328 Offset: 0x87B5328 VA: 0x87B9328
	public ParticleSystem.NoiseModule get_noise() { }

	// RVA: 0x87B9350 Offset: 0x87B5350 VA: 0x87B9350
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x87B9378 Offset: 0x87B5378 VA: 0x87B9378
	public ParticleSystem.TriggerModule get_trigger() { }

	// RVA: 0x87B93A0 Offset: 0x87B53A0 VA: 0x87B93A0
	public ParticleSystem.SubEmittersModule get_subEmitters() { }

	// RVA: 0x87B93C8 Offset: 0x87B53C8 VA: 0x87B93C8
	public ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x87B93F0 Offset: 0x87B53F0 VA: 0x87B93F0
	public ParticleSystem.LightsModule get_lights() { }

	// RVA: 0x87B9418 Offset: 0x87B5418 VA: 0x87B9418
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x87B9440 Offset: 0x87B5440 VA: 0x87B9440
	public ParticleSystem.CustomDataModule get_customData() { }

	// RVA: 0x87B9468 Offset: 0x87B5468 VA: 0x87B9468
	public void .ctor() { }

	// RVA: 0x87B7A90 Offset: 0x87B3A90 VA: 0x87B7A90
	private void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret) { }

	// RVA: 0x87B7B40 Offset: 0x87B3B40 VA: 0x87B7B40
	private void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret) { }

	// RVA: 0x87B8158 Offset: 0x87B4158 VA: 0x87B8158
	private void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret) { }

	// RVA: 0x87B81E0 Offset: 0x87B41E0 VA: 0x87B81E0
	private void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState) { }

	// RVA: 0x87B8554 Offset: 0x87B4554 VA: 0x87B8554
	private void SetTrails_Injected(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x87B8AEC Offset: 0x87B4AEC VA: 0x87B8AEC
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x87B8C98 Offset: 0x87B4C98 VA: 0x87B8C98
	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	// RVA: 0x87B8F1C Offset: 0x87B4F1C VA: 0x87B8F1C
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x87B8FB0 Offset: 0x87B4FB0 VA: 0x87B8FB0
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x87B9050 Offset: 0x87B5050 VA: 0x87B9050
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }
}

// Namespace: UnityEngine
[Extension]
public static class ParticlePhysicsExtensions // TypeDefIndex: 27249
{
	// Methods

	[Extension]
	// RVA: 0x87C0628 Offset: 0x87BC628 VA: 0x87C0628
	public static int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents) { }
}

// Namespace: UnityEngine
public enum ParticleSystemRenderMode // TypeDefIndex: 27250
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRenderMode Billboard = 0;
	public const ParticleSystemRenderMode Stretch = 1;
	public const ParticleSystemRenderMode HorizontalBillboard = 2;
	public const ParticleSystemRenderMode VerticalBillboard = 3;
	public const ParticleSystemRenderMode Mesh = 4;
	public const ParticleSystemRenderMode None = 5;
}

// Namespace: UnityEngine
public enum ParticleSystemMeshDistribution // TypeDefIndex: 27251
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemMeshDistribution UniformRandom = 0;
	public const ParticleSystemMeshDistribution NonUniformRandom = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemSortMode // TypeDefIndex: 27252
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSortMode None = 0;
	public const ParticleSystemSortMode Distance = 1;
	public const ParticleSystemSortMode OldestInFront = 2;
	public const ParticleSystemSortMode YoungestInFront = 3;
	public const ParticleSystemSortMode Depth = 4;
	public const ParticleSystemSortMode DistanceReverse = 5;
	public const ParticleSystemSortMode DepthReverse = 6;
}

// Namespace: UnityEngine
public enum ParticleSystemRenderSpace // TypeDefIndex: 27253
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRenderSpace View = 0;
	public const ParticleSystemRenderSpace World = 1;
	public const ParticleSystemRenderSpace Local = 2;
	public const ParticleSystemRenderSpace Facing = 3;
	public const ParticleSystemRenderSpace Velocity = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode // TypeDefIndex: 27254
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode // TypeDefIndex: 27255
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemShapeType // TypeDefIndex: 27256
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemShapeType Sphere = 0;
	[Obsolete("SphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType SphereShell = 1;
	public const ParticleSystemShapeType Hemisphere = 2;
	[Obsolete("HemisphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType HemisphereShell = 3;
	public const ParticleSystemShapeType Cone = 4;
	public const ParticleSystemShapeType Box = 5;
	public const ParticleSystemShapeType Mesh = 6;
	[Obsolete("ConeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType ConeShell = 7;
	public const ParticleSystemShapeType ConeVolume = 8;
	[Obsolete("ConeVolumeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType ConeVolumeShell = 9;
	public const ParticleSystemShapeType Circle = 10;
	[Obsolete("CircleEdge is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType CircleEdge = 11;
	public const ParticleSystemShapeType SingleSidedEdge = 12;
	public const ParticleSystemShapeType MeshRenderer = 13;
	public const ParticleSystemShapeType SkinnedMeshRenderer = 14;
	public const ParticleSystemShapeType BoxShell = 15;
	public const ParticleSystemShapeType BoxEdge = 16;
	public const ParticleSystemShapeType Donut = 17;
	public const ParticleSystemShapeType Rectangle = 18;
	public const ParticleSystemShapeType Sprite = 19;
	public const ParticleSystemShapeType SpriteRenderer = 20;
}

// Namespace: UnityEngine
public enum ParticleSystemMeshShapeType // TypeDefIndex: 27257
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemMeshShapeType Vertex = 0;
	public const ParticleSystemMeshShapeType Edge = 1;
	public const ParticleSystemMeshShapeType Triangle = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemShapeTextureChannel // TypeDefIndex: 27258
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemShapeTextureChannel Red = 0;
	public const ParticleSystemShapeTextureChannel Green = 1;
	public const ParticleSystemShapeTextureChannel Blue = 2;
	public const ParticleSystemShapeTextureChannel Alpha = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemAnimationMode // TypeDefIndex: 27259
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemAnimationMode Grid = 0;
	public const ParticleSystemAnimationMode Sprites = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemAnimationType // TypeDefIndex: 27260
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemAnimationType WholeSheet = 0;
	public const ParticleSystemAnimationType SingleRow = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemAnimationRowMode // TypeDefIndex: 27261
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemAnimationRowMode Custom = 0;
	public const ParticleSystemAnimationRowMode Random = 1;
	public const ParticleSystemAnimationRowMode MeshIndex = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace // TypeDefIndex: 27262
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior // TypeDefIndex: 27263
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode // TypeDefIndex: 27264
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopAction // TypeDefIndex: 27265
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemStopAction None = 0;
	public const ParticleSystemStopAction Disable = 1;
	public const ParticleSystemStopAction Destroy = 2;
	public const ParticleSystemStopAction Callback = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemCullingMode // TypeDefIndex: 27266
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCullingMode Automatic = 0;
	public const ParticleSystemCullingMode PauseAndCatchup = 1;
	public const ParticleSystemCullingMode Pause = 2;
	public const ParticleSystemCullingMode AlwaysSimulate = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemEmitterVelocityMode // TypeDefIndex: 27267
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemEmitterVelocityMode Transform = 0;
	public const ParticleSystemEmitterVelocityMode Rigidbody = 1;
	public const ParticleSystemEmitterVelocityMode Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemGravitySource // TypeDefIndex: 27268
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemGravitySource Physics3D = 0;
	public const ParticleSystemGravitySource Physics2D = 1;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public enum ParticleSystemVertexStream // TypeDefIndex: 27269
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemVertexStream Position = 0;
	public const ParticleSystemVertexStream Normal = 1;
	public const ParticleSystemVertexStream Tangent = 2;
	public const ParticleSystemVertexStream Color = 3;
	public const ParticleSystemVertexStream UV = 4;
	public const ParticleSystemVertexStream UV2 = 5;
	public const ParticleSystemVertexStream UV3 = 6;
	public const ParticleSystemVertexStream UV4 = 7;
	public const ParticleSystemVertexStream AnimBlend = 8;
	public const ParticleSystemVertexStream AnimFrame = 9;
	public const ParticleSystemVertexStream Center = 10;
	public const ParticleSystemVertexStream VertexID = 11;
	public const ParticleSystemVertexStream SizeX = 12;
	public const ParticleSystemVertexStream SizeXY = 13;
	public const ParticleSystemVertexStream SizeXYZ = 14;
	public const ParticleSystemVertexStream Rotation = 15;
	public const ParticleSystemVertexStream Rotation3D = 16;
	public const ParticleSystemVertexStream RotationSpeed = 17;
	public const ParticleSystemVertexStream RotationSpeed3D = 18;
	public const ParticleSystemVertexStream Velocity = 19;
	public const ParticleSystemVertexStream Speed = 20;
	public const ParticleSystemVertexStream AgePercent = 21;
	public const ParticleSystemVertexStream InvStartLifetime = 22;
	public const ParticleSystemVertexStream StableRandomX = 23;
	public const ParticleSystemVertexStream StableRandomXY = 24;
	public const ParticleSystemVertexStream StableRandomXYZ = 25;
	public const ParticleSystemVertexStream StableRandomXYZW = 26;
	public const ParticleSystemVertexStream VaryingRandomX = 27;
	public const ParticleSystemVertexStream VaryingRandomXY = 28;
	public const ParticleSystemVertexStream VaryingRandomXYZ = 29;
	public const ParticleSystemVertexStream VaryingRandomXYZW = 30;
	public const ParticleSystemVertexStream Custom1X = 31;
	public const ParticleSystemVertexStream Custom1XY = 32;
	public const ParticleSystemVertexStream Custom1XYZ = 33;
	public const ParticleSystemVertexStream Custom1XYZW = 34;
	public const ParticleSystemVertexStream Custom2X = 35;
	public const ParticleSystemVertexStream Custom2XY = 36;
	public const ParticleSystemVertexStream Custom2XYZ = 37;
	public const ParticleSystemVertexStream Custom2XYZW = 38;
	public const ParticleSystemVertexStream NoiseSumX = 39;
	public const ParticleSystemVertexStream NoiseSumXY = 40;
	public const ParticleSystemVertexStream NoiseSumXYZ = 41;
	public const ParticleSystemVertexStream NoiseImpulseX = 42;
	public const ParticleSystemVertexStream NoiseImpulseXY = 43;
	public const ParticleSystemVertexStream NoiseImpulseXYZ = 44;
	public const ParticleSystemVertexStream MeshIndex = 45;
	public const ParticleSystemVertexStream ParticleIndex = 46;
	public const ParticleSystemVertexStream ColorPackedAsTwoFloats = 47;
	public const ParticleSystemVertexStream MeshAxisOfRotation = 48;
	public const ParticleSystemVertexStream NextTrailCenter = 49;
	public const ParticleSystemVertexStream PreviousTrailCenter = 50;
	public const ParticleSystemVertexStream PercentageAlongTrail = 51;
	public const ParticleSystemVertexStream TrailWidth = 52;
}

// Namespace: UnityEngine
public enum ParticleSystemCustomData // TypeDefIndex: 27270
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCustomData Custom1 = 0;
	public const ParticleSystemCustomData Custom2 = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemShapeMultiModeValue // TypeDefIndex: 27271
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemShapeMultiModeValue Random = 0;
	public const ParticleSystemShapeMultiModeValue Loop = 1;
	public const ParticleSystemShapeMultiModeValue PingPong = 2;
	public const ParticleSystemShapeMultiModeValue BurstSpread = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemRingBufferMode // TypeDefIndex: 27272
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRingBufferMode Disabled = 0;
	public const ParticleSystemRingBufferMode PauseUntilReplaced = 1;
	public const ParticleSystemRingBufferMode LoopUntilReplaced = 2;
}

// Namespace: UnityEngine
[Flags]
public enum ParticleSystemBakeMeshOptions // TypeDefIndex: 27273
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemBakeMeshOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeMeshOptions BakePosition = 2;
	public const ParticleSystemBakeMeshOptions Default = 0;
}

// Namespace: UnityEngine
[Flags]
public enum ParticleSystemBakeTextureOptions // TypeDefIndex: 27274
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemBakeTextureOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeTextureOptions BakePosition = 2;
	public const ParticleSystemBakeTextureOptions PerVertex = 4;
	public const ParticleSystemBakeTextureOptions PerParticle = 8;
	public const ParticleSystemBakeTextureOptions IncludeParticleIndices = 16;
	public const ParticleSystemBakeTextureOptions Default = 4;
}

// Namespace: UnityEngine
[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", False)]
[Flags]
public enum ParticleSystemVertexStreams // TypeDefIndex: 27275
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemVertexStreams Position = 1;
	public const ParticleSystemVertexStreams Normal = 2;
	public const ParticleSystemVertexStreams Tangent = 4;
	public const ParticleSystemVertexStreams Color = 8;
	public const ParticleSystemVertexStreams UV = 16;
	public const ParticleSystemVertexStreams UV2BlendAndFrame = 32;
	public const ParticleSystemVertexStreams CenterAndVertexID = 64;
	public const ParticleSystemVertexStreams Size = 128;
	public const ParticleSystemVertexStreams Rotation = 256;
	public const ParticleSystemVertexStreams Velocity = 512;
	public const ParticleSystemVertexStreams Lifetime = 1024;
	public const ParticleSystemVertexStreams Custom1 = 2048;
	public const ParticleSystemVertexStreams Custom2 = 4096;
	public const ParticleSystemVertexStreams Random = 8192;
	public const ParticleSystemVertexStreams None = 0;
	public const ParticleSystemVertexStreams All = 2147483647;
}

// Namespace: 
internal struct ParticleSystemRenderer.BakeTextureOutput // TypeDefIndex: 27276
{
	// Fields
	[NativeName("first")]
	internal Texture2D vertices; // 0x0
	[NativeName("second")]
	internal Texture2D indices; // 0x8
}

// Namespace: UnityEngine
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 27277
{
	// Properties
	[NativeName("RenderAlignment")]
	public ParticleSystemRenderSpace alignment { get; set; }
	public ParticleSystemRenderMode renderMode { get; set; }
	public ParticleSystemMeshDistribution meshDistribution { get; set; }
	public ParticleSystemSortMode sortMode { get; set; }
	public float lengthScale { get; set; }
	public float velocityScale { get; set; }
	public float cameraVelocityScale { get; set; }
	public float normalDirection { get; set; }
	public float shadowBias { get; set; }
	public float sortingFudge { get; set; }
	public float minParticleSize { get; set; }
	public float maxParticleSize { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 flip { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Material trailMaterial { get; set; }
	internal Material oldTrailMaterial { set; }
	public bool enableGPUInstancing { get; set; }
	public bool allowRoll { get; set; }
	public bool freeformStretching { get; set; }
	public bool rotateWithStretchDirection { get; set; }
	public Mesh mesh { get; set; }
	public int meshCount { get; }
	public int activeVertexStreamsCount { get; }
	public int activeTrailVertexStreamsCount { get; }

	// Methods

	[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x87C06D0 Offset: 0x87BC6D0 VA: 0x87C06D0
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x87C13A0 Offset: 0x87BD3A0 VA: 0x87C13A0
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x87C13A8 Offset: 0x87BD3A8 VA: 0x87C13A8
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x87C1640 Offset: 0x87BD640 VA: 0x87C1640
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x87C06D8 Offset: 0x87BC6D8 VA: 0x87C06D8
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x87C13C4 Offset: 0x87BD3C4 VA: 0x87C13C4
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x87C1708 Offset: 0x87BD708 VA: 0x87C1708
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x87C1740 Offset: 0x87BD740 VA: 0x87C1740
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x87C1800 Offset: 0x87BD800 VA: 0x87C1800
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = False) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x87C1838 Offset: 0x87BD838 VA: 0x87C1838
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x87C18F8 Offset: 0x87BD8F8 VA: 0x87C18F8
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0x87C1934 Offset: 0x87BD934 VA: 0x87C1934
	public void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0x87C1978 Offset: 0x87BD978 VA: 0x87C1978
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x87C19B4 Offset: 0x87BD9B4 VA: 0x87C19B4
	public void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0x87C19F8 Offset: 0x87BD9F8 VA: 0x87C19F8
	public ParticleSystemMeshDistribution get_meshDistribution() { }

	// RVA: 0x87C1A34 Offset: 0x87BDA34 VA: 0x87C1A34
	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	// RVA: 0x87C1A78 Offset: 0x87BDA78 VA: 0x87C1A78
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0x87C1AB4 Offset: 0x87BDAB4 VA: 0x87C1AB4
	public void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0x87C1AF8 Offset: 0x87BDAF8 VA: 0x87C1AF8
	public float get_lengthScale() { }

	// RVA: 0x87C1B34 Offset: 0x87BDB34 VA: 0x87C1B34
	public void set_lengthScale(float value) { }

	// RVA: 0x87C1B80 Offset: 0x87BDB80 VA: 0x87C1B80
	public float get_velocityScale() { }

	// RVA: 0x87C1BBC Offset: 0x87BDBBC VA: 0x87C1BBC
	public void set_velocityScale(float value) { }

	// RVA: 0x87C1C08 Offset: 0x87BDC08 VA: 0x87C1C08
	public float get_cameraVelocityScale() { }

	// RVA: 0x87C1C44 Offset: 0x87BDC44 VA: 0x87C1C44
	public void set_cameraVelocityScale(float value) { }

	// RVA: 0x87C1C90 Offset: 0x87BDC90 VA: 0x87C1C90
	public float get_normalDirection() { }

	// RVA: 0x87C1CCC Offset: 0x87BDCCC VA: 0x87C1CCC
	public void set_normalDirection(float value) { }

	// RVA: 0x87C1D18 Offset: 0x87BDD18 VA: 0x87C1D18
	public float get_shadowBias() { }

	// RVA: 0x87C1D54 Offset: 0x87BDD54 VA: 0x87C1D54
	public void set_shadowBias(float value) { }

	// RVA: 0x87C1DA0 Offset: 0x87BDDA0 VA: 0x87C1DA0
	public float get_sortingFudge() { }

	// RVA: 0x87C1DDC Offset: 0x87BDDDC VA: 0x87C1DDC
	public void set_sortingFudge(float value) { }

	// RVA: 0x87C1E28 Offset: 0x87BDE28 VA: 0x87C1E28
	public float get_minParticleSize() { }

	// RVA: 0x87C1E64 Offset: 0x87BDE64 VA: 0x87C1E64
	public void set_minParticleSize(float value) { }

	// RVA: 0x87C1EB0 Offset: 0x87BDEB0 VA: 0x87C1EB0
	public float get_maxParticleSize() { }

	// RVA: 0x87C1EEC Offset: 0x87BDEEC VA: 0x87C1EEC
	public void set_maxParticleSize(float value) { }

	// RVA: 0x87C1F38 Offset: 0x87BDF38 VA: 0x87C1F38
	public Vector3 get_pivot() { }

	// RVA: 0x87C1FD8 Offset: 0x87BDFD8 VA: 0x87C1FD8
	public void set_pivot(Vector3 value) { }

	// RVA: 0x87C2070 Offset: 0x87BE070 VA: 0x87C2070
	public Vector3 get_flip() { }

	// RVA: 0x87C2110 Offset: 0x87BE110 VA: 0x87C2110
	public void set_flip(Vector3 value) { }

	// RVA: 0x87C21A8 Offset: 0x87BE1A8 VA: 0x87C21A8
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x87C21E4 Offset: 0x87BE1E4 VA: 0x87C21E4
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x87C2228 Offset: 0x87BE228 VA: 0x87C2228
	public Material get_trailMaterial() { }

	// RVA: 0x87C2264 Offset: 0x87BE264 VA: 0x87C2264
	public void set_trailMaterial(Material value) { }

	// RVA: 0x87C22A8 Offset: 0x87BE2A8 VA: 0x87C22A8
	internal void set_oldTrailMaterial(Material value) { }

	// RVA: 0x87C22EC Offset: 0x87BE2EC VA: 0x87C22EC
	public bool get_enableGPUInstancing() { }

	// RVA: 0x87C2328 Offset: 0x87BE328 VA: 0x87C2328
	public void set_enableGPUInstancing(bool value) { }

	// RVA: 0x87C236C Offset: 0x87BE36C VA: 0x87C236C
	public bool get_allowRoll() { }

	// RVA: 0x87C23A8 Offset: 0x87BE3A8 VA: 0x87C23A8
	public void set_allowRoll(bool value) { }

	// RVA: 0x87C23EC Offset: 0x87BE3EC VA: 0x87C23EC
	public bool get_freeformStretching() { }

	// RVA: 0x87C2428 Offset: 0x87BE428 VA: 0x87C2428
	public void set_freeformStretching(bool value) { }

	// RVA: 0x87C246C Offset: 0x87BE46C VA: 0x87C246C
	public bool get_rotateWithStretchDirection() { }

	// RVA: 0x87C24A8 Offset: 0x87BE4A8 VA: 0x87C24A8
	public void set_rotateWithStretchDirection(bool value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	// RVA: 0x87C24EC Offset: 0x87BE4EC VA: 0x87C24EC
	public Mesh get_mesh() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
	// RVA: 0x87C2528 Offset: 0x87BE528 VA: 0x87C2528
	public void set_mesh(Mesh value) { }

	[RequiredByNativeCode]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	// RVA: 0x87C256C Offset: 0x87BE56C VA: 0x87C256C
	public int GetMeshes([Out] Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
	// RVA: 0x87C25B0 Offset: 0x87BE5B0 VA: 0x87C25B0
	public void SetMeshes(Mesh[] meshes, int size) { }

	// RVA: 0x87C2604 Offset: 0x87BE604 VA: 0x87C2604
	public void SetMeshes(Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
	// RVA: 0x87C2660 Offset: 0x87BE660 VA: 0x87C2660
	public int GetMeshWeightings([Out] float[] weightings) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
	// RVA: 0x87C26A4 Offset: 0x87BE6A4 VA: 0x87C26A4
	public void SetMeshWeightings(float[] weightings, int size) { }

	// RVA: 0x87C26F8 Offset: 0x87BE6F8 VA: 0x87C26F8
	public void SetMeshWeightings(float[] weightings) { }

	// RVA: 0x87C2754 Offset: 0x87BE754 VA: 0x87C2754
	public int get_meshCount() { }

	// RVA: 0x87C2790 Offset: 0x87BE790 VA: 0x87C2790
	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x87C17A4 Offset: 0x87BD7A4 VA: 0x87C17A4
	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x87C27F4 Offset: 0x87BE7F4 VA: 0x87C27F4
	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x87C189C Offset: 0x87BD89C VA: 0x87C189C
	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x87C2858 Offset: 0x87BE858 VA: 0x87C2858
	public int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x87C2890 Offset: 0x87BE890 VA: 0x87C2890
	public int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTextureNoIndices", HasExplicitThis = True)]
	// RVA: 0x87C2990 Offset: 0x87BE990 VA: 0x87C2990
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x87C29FC Offset: 0x87BE9FC VA: 0x87C29FC
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x87C2A44 Offset: 0x87BEA44 VA: 0x87C2A44
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTexture", HasExplicitThis = True)]
	// RVA: 0x87C2AA8 Offset: 0x87BEAA8 VA: 0x87C2AA8
	private ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x87C2BB8 Offset: 0x87BEBB8 VA: 0x87C2BB8
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x87C2C00 Offset: 0x87BEC00 VA: 0x87C2C00
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTrailsTexture", HasExplicitThis = True)]
	// RVA: 0x87C2C64 Offset: 0x87BEC64 VA: 0x87C2C64
	private ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x87C1644 Offset: 0x87BD644 VA: 0x87C1644
	public int get_activeVertexStreamsCount() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
	// RVA: 0x87C16C4 Offset: 0x87BD6C4 VA: 0x87C16C4
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
	// RVA: 0x87C1680 Offset: 0x87BD680 VA: 0x87C1680
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x87C2D74 Offset: 0x87BED74 VA: 0x87C2D74
	public int get_activeTrailVertexStreamsCount() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveTrailVertexStreams", HasExplicitThis = True)]
	// RVA: 0x87C2DB0 Offset: 0x87BEDB0 VA: 0x87C2DB0
	public void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveTrailVertexStreams", HasExplicitThis = True)]
	// RVA: 0x87C2DF4 Offset: 0x87BEDF4 VA: 0x87C2DF4
	public void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x87C2E38 Offset: 0x87BEE38 VA: 0x87C2E38
	public void .ctor() { }

	// RVA: 0x87C1F94 Offset: 0x87BDF94 VA: 0x87C1F94
	private void get_pivot_Injected(out Vector3 ret) { }

	// RVA: 0x87C202C Offset: 0x87BE02C VA: 0x87C202C
	private void set_pivot_Injected(ref Vector3 value) { }

	// RVA: 0x87C20CC Offset: 0x87BE0CC VA: 0x87C20CC
	private void get_flip_Injected(out Vector3 ret) { }

	// RVA: 0x87C2164 Offset: 0x87BE164 VA: 0x87C2164
	private void set_flip_Injected(ref Vector3 value) { }

	// RVA: 0x87C2B34 Offset: 0x87BEB34 VA: 0x87C2B34
	private void BakeTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret) { }

	// RVA: 0x87C2CF0 Offset: 0x87BECF0 VA: 0x87C2CF0
	private void BakeTrailsTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True)]
public struct ParticleCollisionEvent // TypeDefIndex: 27278
{
	// Fields
	internal Vector3 m_Intersection; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Velocity; // 0x18
	internal int m_ColliderInstanceID; // 0x24

	// Properties
	public Vector3 intersection { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x87C2E40 Offset: 0x87BEE40 VA: 0x87C2E40
	public Vector3 get_intersection() { }

	// RVA: 0x87C2E4C Offset: 0x87BEE4C VA: 0x87C2E4C
	public Vector3 get_normal() { }
}

// Namespace: UnityEngine
internal class ParticleSystemExtensionsImpl // TypeDefIndex: 27279
{
	// Methods

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCollisionEvents")]
	// RVA: 0x87C067C Offset: 0x87BC67C VA: 0x87C067C
	internal static int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents) { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum UVChannelFlags // TypeDefIndex: 27280
{
	// Fields
	public int value__; // 0x0
	public const UVChannelFlags UV0 = 1;
	public const UVChannelFlags UV1 = 2;
	public const UVChannelFlags UV2 = 4;
	public const UVChannelFlags UV3 = 8;
}

// Namespace: UnityEngine.ParticleSystemJobs
[DefaultMember("Item")]
public struct ParticleSystemNativeArray3 // TypeDefIndex: 27281
{
	// Fields
	public NativeArray<float> x; // 0x0
	public NativeArray<float> y; // 0x10
	public NativeArray<float> z; // 0x20
}

// Namespace: UnityEngine.ParticleSystemJobs
[DefaultMember("Item")]
public struct ParticleSystemNativeArray4 // TypeDefIndex: 27282
{
	// Fields
	public NativeArray<float> x; // 0x0
	public NativeArray<float> y; // 0x10
	public NativeArray<float> z; // 0x20
	public NativeArray<float> w; // 0x30
}

// Namespace: UnityEngine.ParticleSystemJobs
public struct ParticleSystemJobData // TypeDefIndex: 27283
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <count>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ParticleSystemNativeArray3 <axisOfRotations>k__BackingField; // 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; // 0x98
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; // 0xF8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly NativeArray<Color32> <startColors>k__BackingField; // 0x128
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; // 0x138
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; // 0x148
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; // 0x158
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x168
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x1A8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly NativeArray<int> <meshIndices>k__BackingField; // 0x1E8
}

// Namespace: 
internal struct NativeParticleData.Array3 // TypeDefIndex: 27284
{
	// Fields
	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10
}

// Namespace: 
internal struct NativeParticleData.Array4 // TypeDefIndex: 27285
{
	// Fields
	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10
	internal float* w; // 0x18
}

// Namespace: UnityEngine.ParticleSystemJobs
internal struct NativeParticleData // TypeDefIndex: 27286
{
	// Fields
	internal int count; // 0x0
	internal NativeParticleData.Array3 positions; // 0x8
	internal NativeParticleData.Array3 velocities; // 0x20
	internal NativeParticleData.Array3 axisOfRotations; // 0x38
	internal NativeParticleData.Array3 rotations; // 0x50
	internal NativeParticleData.Array3 rotationalSpeeds; // 0x68
	internal NativeParticleData.Array3 sizes; // 0x80
	internal void* startColors; // 0x98
	internal void* aliveTimePercent; // 0xA0
	internal void* inverseStartLifetimes; // 0xA8
	internal void* randomSeeds; // 0xB0
	internal NativeParticleData.Array4 customData1; // 0xB8
	internal NativeParticleData.Array4 customData2; // 0xD8
	internal void* meshIndices; // 0xF8
}

