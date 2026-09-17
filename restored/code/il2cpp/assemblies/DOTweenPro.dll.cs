// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28803
{}

// Namespace: DG.Tweening
[AddComponentMenu("")]
public class DOTweenVisualManager : MonoBehaviour // TypeDefIndex: 28804
{
	// Fields
	public VisualManagerPreset preset; // 0x20
	public OnEnableBehaviour onEnableBehaviour; // 0x24
	public OnDisableBehaviour onDisableBehaviour; // 0x28
	private bool _requiresRestartFromSpawnPoint; // 0x2C

	// Methods

	// RVA: 0x410071C Offset: 0x40FC71C VA: 0x410071C
	private void Update() { }

	// RVA: 0x41007D8 Offset: 0x40FC7D8 VA: 0x41007D8
	private void OnEnable() { }

	// RVA: 0x4100910 Offset: 0x40FC910 VA: 0x4100910
	private void OnDisable() { }

	// RVA: 0x4100B8C Offset: 0x40FCB8C VA: 0x4100B8C
	public void .ctor() { }
}

// Namespace: DG.Tweening
public enum HandlesDrawMode // TypeDefIndex: 28805
{
	// Fields
	public int value__; // 0x0
	public const HandlesDrawMode Orthographic = 0;
	public const HandlesDrawMode Perspective = 1;
}

// Namespace: DG.Tweening
public enum HandlesType // TypeDefIndex: 28806
{
	// Fields
	public int value__; // 0x0
	public const HandlesType Free = 0;
	public const HandlesType Full = 1;
}

// Namespace: DG.Tweening
public enum DOTweenInspectorMode // TypeDefIndex: 28807
{
	// Fields
	public int value__; // 0x0
	public const DOTweenInspectorMode Default = 0;
	public const DOTweenInspectorMode InfoAndWaypointsOnly = 1;
	public const DOTweenInspectorMode Developer = 2;
	public const DOTweenInspectorMode OnlyPath = 3;
}

// Namespace: DG.Tweening
[AddComponentMenu("DOTween/DOTween Path")]
public class DOTweenPath : ABSAnimationComponent // TypeDefIndex: 28808
{
	// Fields
	public float delay; // 0x70
	public float duration; // 0x74
	public Ease easeType; // 0x78
	public AnimationCurve easeCurve; // 0x80
	public int loops; // 0x88
	public string id; // 0x90
	public LoopType loopType; // 0x98
	public OrientType orientType; // 0x9C
	public Transform lookAtTransform; // 0xA0
	public Vector3 lookAtPosition; // 0xA8
	public float lookAhead; // 0xB4
	public bool autoPlay; // 0xB8
	public bool autoKill; // 0xB9
	public bool relative; // 0xBA
	public bool isLocal; // 0xBB
	public bool isClosedPath; // 0xBC
	public int pathResolution; // 0xC0
	public PathMode pathMode; // 0xC4
	public AxisConstraint lockRotation; // 0xC8
	public bool assignForwardAndUp; // 0xCC
	public Vector3 forwardDirection; // 0xD0
	public Vector3 upDirection; // 0xDC
	public bool tweenRigidbody; // 0xE8
	public List<Vector3> wps; // 0xF0
	public List<Vector3> fullWps; // 0xF8
	public Path path; // 0x100
	public DOTweenInspectorMode inspectorMode; // 0x108
	public PathType pathType; // 0x10C
	public HandlesType handlesType; // 0x110
	public bool livePreview; // 0x114
	public HandlesDrawMode handlesDrawMode; // 0x118
	public float perspectiveHandleSize; // 0x11C
	public bool showIndexes; // 0x120
	public bool showWpLength; // 0x121
	public Color pathColor; // 0x124
	public Vector3 lastSrcPosition; // 0x134
	public bool wpsDropdown; // 0x140
	public float dropToFloorOffset; // 0x144

	// Methods

	// RVA: 0x4100B94 Offset: 0x40FCB94 VA: 0x4100B94
	private void Awake() { }

	// RVA: 0x4101788 Offset: 0x40FD788 VA: 0x4101788
	private void Reset() { }

	// RVA: 0x4101884 Offset: 0x40FD884 VA: 0x4101884
	private void OnDestroy() { }

	// RVA: 0x41018BC Offset: 0x40FD8BC VA: 0x41018BC Slot: 4
	public override void DOPlay() { }

	// RVA: 0x4101904 Offset: 0x40FD904 VA: 0x4101904 Slot: 5
	public override void DOPlayBackwards() { }

	// RVA: 0x4101910 Offset: 0x40FD910 VA: 0x4101910 Slot: 6
	public override void DOPlayForward() { }

	// RVA: 0x410191C Offset: 0x40FD91C VA: 0x410191C Slot: 7
	public override void DOPause() { }

	// RVA: 0x4101964 Offset: 0x40FD964 VA: 0x4101964 Slot: 8
	public override void DOTogglePause() { }

	// RVA: 0x4101970 Offset: 0x40FD970 VA: 0x4101970 Slot: 9
	public override void DORewind() { }

	// RVA: 0x4101980 Offset: 0x40FD980 VA: 0x4101980 Slot: 10
	public override void DORestart(bool fromHere = False) { }

	// RVA: 0x4101A28 Offset: 0x40FDA28 VA: 0x4101A28 Slot: 11
	public override void DOComplete() { }

	// RVA: 0x4101A34 Offset: 0x40FDA34 VA: 0x4101A34 Slot: 12
	public override void DOKill() { }

	// RVA: 0x4101A44 Offset: 0x40FDA44 VA: 0x4101A44
	public Tween GetTween() { }

	// RVA: 0x4101AE0 Offset: 0x40FDAE0 VA: 0x4101AE0
	public Vector3[] GetDrawPoints() { }

	// RVA: 0x4101B5C Offset: 0x40FDB5C VA: 0x4101B5C
	internal Vector3[] GetFullWps() { }

	// RVA: 0x4101624 Offset: 0x40FD624 VA: 0x4101624
	private void ReEvaluateRelativeTween() { }

	// RVA: 0x4101CB4 Offset: 0x40FDCB4 VA: 0x4101CB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4101F64 Offset: 0x40FDF64 VA: 0x4101F64
	private void <Awake>b__38_0() { }
}

// Namespace: DG.Tweening.Core
[AddComponentMenu("")]
public abstract class ABSAnimationComponent : MonoBehaviour // TypeDefIndex: 28809
{
	// Fields
	public UpdateType updateType; // 0x20
	public bool isSpeedBased; // 0x24
	public bool hasOnStart; // 0x25
	public bool hasOnPlay; // 0x26
	public bool hasOnUpdate; // 0x27
	public bool hasOnStepComplete; // 0x28
	public bool hasOnComplete; // 0x29
	public bool hasOnTweenCreated; // 0x2A
	public bool hasOnRewind; // 0x2B
	public UnityEvent onStart; // 0x30
	public UnityEvent onPlay; // 0x38
	public UnityEvent onUpdate; // 0x40
	public UnityEvent onStepComplete; // 0x48
	public UnityEvent onComplete; // 0x50
	public UnityEvent onTweenCreated; // 0x58
	public UnityEvent onRewind; // 0x60
	public Tween tween; // 0x68

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DOPlay();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DOPlayBackwards();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DOPlayForward();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DOPause();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DOTogglePause();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void DORewind();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void DORestart(bool fromHere = False);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DOComplete();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void DOKill();

	// RVA: 0x4101F5C Offset: 0x40FDF5C VA: 0x4101F5C
	protected void .ctor() { }
}

// Namespace: DG.Tweening.Core
public enum DOTweenAnimationType // TypeDefIndex: 28810
{
	// Fields
	public int value__; // 0x0
	public const DOTweenAnimationType None = 0;
	public const DOTweenAnimationType Move = 1;
	public const DOTweenAnimationType LocalMove = 2;
	public const DOTweenAnimationType Rotate = 3;
	public const DOTweenAnimationType LocalRotate = 4;
	public const DOTweenAnimationType Scale = 5;
	public const DOTweenAnimationType Color = 6;
	public const DOTweenAnimationType Fade = 7;
	public const DOTweenAnimationType Text = 8;
	public const DOTweenAnimationType PunchPosition = 9;
	public const DOTweenAnimationType PunchRotation = 10;
	public const DOTweenAnimationType PunchScale = 11;
	public const DOTweenAnimationType ShakePosition = 12;
	public const DOTweenAnimationType ShakeRotation = 13;
	public const DOTweenAnimationType ShakeScale = 14;
	public const DOTweenAnimationType CameraAspect = 15;
	public const DOTweenAnimationType CameraBackgroundColor = 16;
	public const DOTweenAnimationType CameraFieldOfView = 17;
	public const DOTweenAnimationType CameraOrthoSize = 18;
	public const DOTweenAnimationType CameraPixelRect = 19;
	public const DOTweenAnimationType CameraRect = 20;
	public const DOTweenAnimationType UIWidthHeight = 21;
}

// Namespace: DG.Tweening.Core
public enum OnDisableBehaviour // TypeDefIndex: 28811
{
	// Fields
	public int value__; // 0x0
	public const OnDisableBehaviour None = 0;
	public const OnDisableBehaviour Pause = 1;
	public const OnDisableBehaviour Rewind = 2;
	public const OnDisableBehaviour Kill = 3;
	public const OnDisableBehaviour KillAndComplete = 4;
	public const OnDisableBehaviour DestroyGameObject = 5;
}

// Namespace: DG.Tweening.Core
public enum OnEnableBehaviour // TypeDefIndex: 28812
{
	// Fields
	public int value__; // 0x0
	public const OnEnableBehaviour None = 0;
	public const OnEnableBehaviour Play = 1;
	public const OnEnableBehaviour Restart = 2;
	public const OnEnableBehaviour RestartFromSpawnPoint = 3;
}

// Namespace: DG.Tweening.Core
public enum TargetType // TypeDefIndex: 28813
{
	// Fields
	public int value__; // 0x0
	public const TargetType Unset = 0;
	public const TargetType Camera = 1;
	public const TargetType CanvasGroup = 2;
	public const TargetType Image = 3;
	public const TargetType Light = 4;
	public const TargetType RectTransform = 5;
	public const TargetType Renderer = 6;
	public const TargetType SpriteRenderer = 7;
	public const TargetType Rigidbody = 8;
	public const TargetType Rigidbody2D = 9;
	public const TargetType Text = 10;
	public const TargetType Transform = 11;
	public const TargetType tk2dBaseSprite = 12;
	public const TargetType tk2dTextMesh = 13;
	public const TargetType TextMeshPro = 14;
	public const TargetType TextMeshProUGUI = 15;
}

// Namespace: DG.Tweening.Core
public enum VisualManagerPreset // TypeDefIndex: 28814
{
	// Fields
	public int value__; // 0x0
	public const VisualManagerPreset Custom = 0;
	public const VisualManagerPreset PoolingSystem = 1;
}

