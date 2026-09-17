// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28508
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28509
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28510
{
	// Methods

	// RVA: 0x4112A44 Offset: 0x410EA44 VA: 0x4112A44
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x4112B3C Offset: 0x410EB3C VA: 0x4112B3C
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[ExecuteAlways]
[RequireComponent(typeof(Animator))]
public abstract class AdaptationBase : MonoBehaviour, INotchSimulatorTarget // TypeDefIndex: 28511
{
	// Fields
	private Rect[] storedSimulatedCutoutsRelative; // 0x20
	private Rect storedSimulatedSafeAreaRelative; // 0x28
	[SerializeField]
	private SupportedOrientations supportedOrientations; // 0x38
	[SerializeField]
	[Space]
	private BlendedClipsAdaptor portraitOrDefaultAdaptation; // 0x40
	[SerializeField]
	private BlendedClipsAdaptor landscapeAdaptation; // 0x48

	// Properties
	private BlendedClipsAdaptor SelectedAdaptation { get; }
	private Animator AnimatorComponent { get; }
	protected Rect SafeAreaRelative { get; }

	// Methods

	// RVA: 0x4112B44 Offset: 0x410EB44 VA: 0x4112B44
	private BlendedClipsAdaptor get_SelectedAdaptation() { }

	// RVA: 0x4112BF8 Offset: 0x410EBF8 VA: 0x4112BF8
	private Animator get_AnimatorComponent() { }

	// RVA: 0x4112C40 Offset: 0x410EC40 VA: 0x4112C40
	protected Rect get_SafeAreaRelative() { }

	// RVA: 0x4112DA0 Offset: 0x410EDA0 VA: 0x4112DA0
	private void Start() { }

	// RVA: 0x4112DAC Offset: 0x410EDAC VA: 0x4112DAC
	private void Update() { }

	// RVA: 0x4112E20 Offset: 0x410EE20 VA: 0x4112E20 Slot: 4
	private void E7.NotchSolution.INotchSimulatorTarget.SimulatorUpdate(Rect simulatedSafeAreaRelative, Rect[] simulatedCutoutsRelative) { }

	// RVA: 0x4112E4C Offset: 0x410EE4C VA: 0x4112E4C
	internal void ResetAdaptationToCurve(AnimationCurve curve) { }

	// RVA: 0x4112F2C Offset: 0x410EF2C VA: 0x4112F2C
	protected void Adapt(float valueForAdaptationCurve) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Adapt();

	// RVA: 0x41131A8 Offset: 0x410F1A8 VA: 0x41131A8
	protected void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class BlendedClipsAdaptor // TypeDefIndex: 28512
{
	// Fields
	[SerializeField]
	private AnimationClip normalState; // 0x10
	[SerializeField]
	private AnimationClip fullyAdaptedState; // 0x18
	[Tooltip("A curve which maps to the current blend percentage between normal and adapted state it should be. (Y axis, 0 to 1, 1 for fully adapted state")]
	[SerializeField]
	private AnimationCurve adaptationCurve; // 0x20

	// Properties
	internal bool Adaptable { get; }

	// Methods

	// RVA: 0x4112EFC Offset: 0x410EEFC VA: 0x4112EFC
	public void .ctor(AnimationCurve defaultCurve) { }

	// RVA: 0x4113228 Offset: 0x410F228 VA: 0x4113228
	internal bool get_Adaptable() { }

	// RVA: 0x4112F74 Offset: 0x410EF74 VA: 0x4112F74
	public void Adapt(float valueForAdaptationCurve, Animator animator) { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class PerEdgeAdaptations : PerEdgeValues<BlendedClipsAdaptor> // TypeDefIndex: 28513
{
	// Methods

	// RVA: 0x41132CC Offset: 0x410F2CC VA: 0x41132CC
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
internal enum EdgeEvaluationMode // TypeDefIndex: 28514
{
	// Fields
	public int value__; // 0x0
	public const EdgeEvaluationMode On = 0;
	public const EdgeEvaluationMode Balanced = 1;
	public const EdgeEvaluationMode Off = 2;
}

// Namespace: E7.NotchSolution
public interface INotchSimulatorTarget // TypeDefIndex: 28515
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SimulatorUpdate(Rect simulatedSafeAreaRelative, Rect[] simulatedCutoutsRelative);
}

// Namespace: 
[CompilerGenerated]
private sealed class NotchSolutionUIBehaviourBase.<DelayedUpdateRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 28516
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NotchSolutionUIBehaviourBase <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41136DC Offset: 0x410F6DC VA: 0x41136DC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41137C4 Offset: 0x410F7C4 VA: 0x41137C4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41137C8 Offset: 0x410F7C8 VA: 0x41137C8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x411382C Offset: 0x410F82C VA: 0x411382C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x4113834 Offset: 0x410F834 VA: 0x4113834 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x411386C Offset: 0x410F86C VA: 0x411386C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: E7.NotchSolution
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public abstract class NotchSolutionUIBehaviourBase : UIBehaviour, ILayoutSelfController, ILayoutController, INotchSimulatorTarget // TypeDefIndex: 28517
{
	// Fields
	private readonly WaitForEndOfFrame eofWait; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Rect[] storedSimulatedCutoutsRelative; // 0x38
	private Rect storedSimulatedSafeAreaRelative; // 0x40

	// Properties
	protected Rect SafeAreaRelative { get; }
	protected RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4113314 Offset: 0x410F314 VA: 0x4113314
	protected Rect get_SafeAreaRelative() { }

	// RVA: 0x4113370 Offset: 0x410F370 VA: 0x4113370
	protected RectTransform get_rectTransform() { }

	// RVA: 0x4113418 Offset: 0x410F418 VA: 0x4113418 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4113464 Offset: 0x410F464 VA: 0x4113464 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x41134E4 Offset: 0x410F4E4 VA: 0x41134E4 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x411353C Offset: 0x410F53C VA: 0x411353C Slot: 17
	private void UnityEngine.UI.ILayoutController.SetLayoutHorizontal() { }

	// RVA: 0x4113540 Offset: 0x410F540 VA: 0x4113540 Slot: 18
	private void UnityEngine.UI.ILayoutController.SetLayoutVertical() { }

	// RVA: 0x4113544 Offset: 0x410F544 VA: 0x4113544 Slot: 19
	private void E7.NotchSolution.INotchSimulatorTarget.SimulatorUpdate(Rect simulatedSafeAreaRelative, Rect[] simulatedCutoutsRelative) { }

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void UpdateRect();

	// RVA: 0x4113568 Offset: 0x410F568 VA: 0x4113568
	protected Rect GetCanvasRect() { }

	// RVA: 0x41134E8 Offset: 0x410F4E8 VA: 0x41134E8
	private void UpdateRectBase() { }

	// RVA: 0x4113444 Offset: 0x410F444 VA: 0x4113444
	private void DelayedUpdate() { }

	[IteratorStateMachine(typeof(NotchSolutionUIBehaviourBase.<DelayedUpdateRoutine>d__19))]
	// RVA: 0x4113670 Offset: 0x410F670 VA: 0x4113670
	private IEnumerator DelayedUpdateRoutine() { }

	// RVA: 0x4113704 Offset: 0x410F704 VA: 0x4113704
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4113618 Offset: 0x410F618 VA: 0x4113618
	private Canvas <GetCanvasRect>g__GetTopLevelCanvas|16_0() { }
}

// Namespace: E7.NotchSolution
public static class NotchSolutionUtility // TypeDefIndex: 28518
{
	// Fields
	internal static Rect defaultSafeArea; // 0x0
	internal static Rect[] defaultCutouts; // 0x10
	internal static Rect cachedScreenSafeArea; // 0x18
	internal static Rect cachedScreenSafeAreaRelative; // 0x28
	internal static bool safeAreaRelativeCached; // 0x38
	internal static Rect[] cachedScreenCutouts; // 0x40
	internal static Rect[] cachedScreenCutoutsRelative; // 0x48
	internal static bool cutoutsRelativeCached; // 0x50

	// Properties
	public static bool ShouldUseNotchSimulatorValue { get; }
	internal static Rect ScreenSafeAreaRelative { get; }
	internal static Rect[] ScreenCutoutsRelative { get; }

	// Methods

	// RVA: 0x4112C9C Offset: 0x410EC9C VA: 0x4112C9C
	public static bool get_ShouldUseNotchSimulatorValue() { }

	// RVA: 0x4112CA4 Offset: 0x410ECA4 VA: 0x4112CA4
	internal static Rect get_ScreenSafeAreaRelative() { }

	// RVA: 0x4113874 Offset: 0x410F874 VA: 0x4113874
	internal static Rect[] get_ScreenCutoutsRelative() { }

	// RVA: 0x4112BCC Offset: 0x410EBCC VA: 0x4112BCC
	internal static ScreenOrientation GetCurrentOrientation() { }

	// RVA: 0x41139B0 Offset: 0x410F9B0 VA: 0x41139B0
	private static Rect ToScreenRelativeRect(Rect absoluteRect) { }

	// RVA: 0x4113A30 Offset: 0x410FA30 VA: 0x4113A30
	private static void .cctor() { }
}

// Namespace: E7.NotchSolution
internal static class NotchSolutionUtilityEditor // TypeDefIndex: 28519
{}

// Namespace: E7.NotchSolution
[Serializable]
internal class PerEdgeEvaluationModes : PerEdgeValues<EdgeEvaluationMode> // TypeDefIndex: 28520
{
	// Methods

	// RVA: 0x4113AB4 Offset: 0x410FAB4 VA: 0x4113AB4
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class PerEdgeValues<T> // TypeDefIndex: 28521
{
	// Fields
	[SerializeField]
	public T left; // 0x0
	[SerializeField]
	public T bottom; // 0x0
	[SerializeField]
	public T top; // 0x0
	[SerializeField]
	public T right; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A310 Offset: 0x5256310 VA: 0x525A310
	|-PerEdgeValues<Int32Enum>..ctor
	|
	|-RVA: 0x525A318 Offset: 0x5256318 VA: 0x525A318
	|-PerEdgeValues<object>..ctor
	|
	|-RVA: 0x525A320 Offset: 0x5256320 VA: 0x525A320
	|-PerEdgeValues<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: E7.NotchSolution
[Serializable]
internal class SimulationDevice // TypeDefIndex: 28522
{
	// Fields
	public MetaData Meta; // 0x10
	public ScreenData[] Screens; // 0x18
	public SystemInfoData SystemInfo; // 0x20

	// Methods

	// RVA: 0x4113AFC Offset: 0x410FAFC VA: 0x4113AFC Slot: 3
	public override string ToString() { }

	// RVA: 0x4113B18 Offset: 0x410FB18 VA: 0x4113B18
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class MetaData // TypeDefIndex: 28523
{
	// Fields
	public string friendlyName; // 0x10
	public string overlay; // 0x18

	// Methods

	// RVA: 0x4113B20 Offset: 0x410FB20 VA: 0x4113B20
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class ScreenData : ISerializationCallbackReceiver // TypeDefIndex: 28524
{
	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public int navigationBarHeight; // 0x18
	public float dpi; // 0x1C
	[SerializeField]
	private ScreenOrientation[] orientationKeys; // 0x20
	[SerializeField]
	private OrientationDependentData[] orientationValues; // 0x28
	public Dictionary<ScreenOrientation, OrientationDependentData> orientations; // 0x30

	// Methods

	// RVA: 0x4113B28 Offset: 0x410FB28 VA: 0x4113B28 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x4113C04 Offset: 0x410FC04 VA: 0x4113C04 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x4113D04 Offset: 0x410FD04 VA: 0x4113D04
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class OrientationDependentData // TypeDefIndex: 28525
{
	// Fields
	public Rect safeArea; // 0x10
	public Rect[] cutouts; // 0x20

	// Methods

	// RVA: 0x4113D0C Offset: 0x410FD0C VA: 0x4113D0C
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class SystemInfoData // TypeDefIndex: 28526
{
	// Fields
	public string deviceModel; // 0x10
	public DeviceType deviceType; // 0x18
	public string operatingSystem; // 0x20
	public OperatingSystemFamily operatingSystemFamily; // 0x28
	public int processorCount; // 0x2C
	public int processorFrequency; // 0x30
	public string processorType; // 0x38
	public bool supportsAccelerometer; // 0x40
	public bool supportsAudio; // 0x41
	public bool supportsGyroscope; // 0x42
	public bool supportsLocationService; // 0x43
	public bool supportsVibration; // 0x44
	public int systemMemorySize; // 0x48
	public string unsupportedIdentifier; // 0x50
	public GraphicsDependentSystemInfoData[] GraphicsDependentData; // 0x58

	// Methods

	// RVA: 0x4113D14 Offset: 0x410FD14 VA: 0x4113D14
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[Serializable]
internal class GraphicsDependentSystemInfoData // TypeDefIndex: 28527
{
	// Fields
	public GraphicsDeviceType graphicsDeviceType; // 0x10
	public int graphicsMemorySize; // 0x14
	public string graphicsDeviceName; // 0x18
	public string graphicsDeviceVendor; // 0x20
	public int graphicsDeviceID; // 0x28
	public int graphicsDeviceVendorID; // 0x2C
	public bool graphicsUVStartsAtTop; // 0x30
	public string graphicsDeviceVersion; // 0x38
	public int graphicsShaderLevel; // 0x40
	public bool graphicsMultiThreaded; // 0x44
	public bool hasHiddenSurfaceRemovalOnGPU; // 0x45
	public bool hasDynamicUniformArrayIndexingInFragmentShaders; // 0x46
	public bool supportsShadows; // 0x47
	public bool supportsRawShadowDepthSampling; // 0x48
	public bool supportsMotionVectors; // 0x49
	public bool supports3DTextures; // 0x4A
	public bool supports2DArrayTextures; // 0x4B
	public bool supports3DRenderTextures; // 0x4C
	public bool supportsCubemapArrayTextures; // 0x4D
	public CopyTextureSupport copyTextureSupport; // 0x50
	public bool supportsComputeShaders; // 0x54
	public bool supportsGeometryShaders; // 0x55
	public bool supportsTessellationShaders; // 0x56
	public bool supportsInstancing; // 0x57
	public bool supportsHardwareQuadTopology; // 0x58
	public bool supports32bitsIndexBuffer; // 0x59
	public bool supportsSparseTextures; // 0x5A
	public int supportedRenderTargetCount; // 0x5C
	public bool supportsSeparatedRenderTargetsBlend; // 0x60
	public int supportedRandomWriteTargetCount; // 0x64
	public int supportsMultisampledTextures; // 0x68
	public bool supportsMultisampleAutoResolve; // 0x6C
	public int supportsTextureWrapMirrorOnce; // 0x70
	public bool usesReversedZBuffer; // 0x74
	public NPOTSupport npotSupport; // 0x78
	public int maxTextureSize; // 0x7C
	public int maxCubemapSize; // 0x80
	public int maxComputeBufferInputsVertex; // 0x84
	public int maxComputeBufferInputsFragment; // 0x88
	public int maxComputeBufferInputsGeometry; // 0x8C
	public int maxComputeBufferInputsDomain; // 0x90
	public int maxComputeBufferInputsHull; // 0x94
	public int maxComputeBufferInputsCompute; // 0x98
	public int maxComputeWorkGroupSize; // 0x9C
	public int maxComputeWorkGroupSizeX; // 0xA0
	public int maxComputeWorkGroupSizeY; // 0xA4
	public int maxComputeWorkGroupSizeZ; // 0xA8
	public bool supportsAsyncCompute; // 0xAC
	public bool supportsGraphicsFence; // 0xAD
	public bool supportsAsyncGPUReadback; // 0xAE
	public bool supportsRayTracing; // 0xAF
	public bool supportsSetConstantBuffer; // 0xB0
	public bool minConstantBufferOffsetAlignment; // 0xB1
	public bool hasMipMaxLevel; // 0xB2
	public bool supportsMipStreaming; // 0xB3
	public bool usesLoadStoreActions; // 0xB4

	// Methods

	// RVA: 0x4113D1C Offset: 0x410FD1C VA: 0x4113D1C
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
internal enum SupportedOrientations // TypeDefIndex: 28528
{
	// Fields
	public int value__; // 0x0
	public const SupportedOrientations Single = 0;
	public const SupportedOrientations Dual = 1;
}

// Namespace: E7.NotchSolution
[HelpURL("https://exceed7.com/notch-solution/components/adaptation/aspect-ratio-adaptation.html")]
public class AspectRatioAdaptation : AdaptationBase // TypeDefIndex: 28529
{
	// Properties
	private float AspectRatio { get; }

	// Methods

	// RVA: 0x4113D24 Offset: 0x410FD24 VA: 0x4113D24
	private float get_AspectRatio() { }

	// RVA: 0x4113D84 Offset: 0x410FD84 VA: 0x4113D84
	private void Reset() { }

	// RVA: 0x4113F4C Offset: 0x410FF4C VA: 0x4113F4C Slot: 5
	public override void Adapt() { }

	// RVA: 0x4113F64 Offset: 0x410FF64 VA: 0x4113F64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4113DA0 Offset: 0x410FDA0 VA: 0x4113DA0
	internal static AnimationCurve <Reset>g__GenDefaultCurve|2_0() { }
}

// Namespace: E7.NotchSolution
[HelpURL("https://exceed7.com/notch-solution/components/adaptation/safe-adaptation.html")]
public class SafeAdaptation : AdaptationBase // TypeDefIndex: 28530
{
	// Fields
	private const float iPhoneXNotchHeightRelative = 0.05418718;
	[SerializeField]
	private RectTransform.Edge adaptToEdge; // 0x50
	[SerializeField]
	private EdgeEvaluationMode evaluationMode; // 0x54

	// Methods

	// RVA: 0x4113F68 Offset: 0x410FF68 VA: 0x4113F68
	private void Reset() { }

	// RVA: 0x4113F9C Offset: 0x410FF9C VA: 0x4113F9C Slot: 5
	public override void Adapt() { }

	// RVA: 0x4113FB4 Offset: 0x410FFB4 VA: 0x4113FB4
	private void AdaptWithRelativeSafeArea(Rect relativeSafeArea) { }

	// RVA: 0x411406C Offset: 0x411006C VA: 0x411406C
	public void .ctor() { }
}

// Namespace: E7.NotchSolution
[HelpURL("https://exceed7.com/notch-solution/components/ui-behaviour/safe-padding.html")]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class SafePadding : NotchSolutionUIBehaviourBase // TypeDefIndex: 28531
{
	// Fields
	public Action OnSafePaddingUpdated; // 0x50
	[SerializeField]
	private SupportedOrientations orientationType; // 0x58
	[SerializeField]
	private PerEdgeEvaluationModes portraitOrDefaultPaddings; // 0x60
	[SerializeField]
	private PerEdgeEvaluationModes landscapePaddings; // 0x68
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Scale down the resulting value read from an edge to be less than an actual value.")]
	private float influence; // 0x70
	[SerializeField]
	[Tooltip("The value read from all edges are applied to the opposite side of a RectTransform instead. Useful when you have rotated or negatively scaled RectTransform.")]
	private bool flipPadding; // 0x74

	// Methods

	// RVA: 0x4114070 Offset: 0x4110070 VA: 0x4114070 Slot: 20
	protected override void UpdateRect() { }

	// RVA: 0x41144CC Offset: 0x41104CC VA: 0x41144CC
	public void SetMode() { }

	// RVA: 0x4114544 Offset: 0x4110544 VA: 0x4114544
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41144C0 Offset: 0x41104C0 VA: 0x41144C0
	internal static bool <UpdateRect>g__LockSide|0_0(EdgeEvaluationMode saem) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=726 // TypeDefIndex: 28532
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1022 // TypeDefIndex: 28533
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28534
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1022 064732FCD07CA7FE5832B54F3ECA03762E9E7ABDDDFA5687DB4C9D2F88D55FC2 /*Metadata offset 0xF53A88*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=726 0EF5492C7FFB3E34905CCE451F7D71F046C46769911986F097CCCAC32380C98F /*Metadata offset 0xF53E88*/; // 0x3FE
}

