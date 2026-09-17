// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 20917
{}

// Namespace: 
[ExecuteInEditMode]
[RequireComponent(typeof(VertIndexAsUV))]
public class UIShaderGradientRampAdd : MonoBehaviour // TypeDefIndex: 20918
{
	// Fields
	public float _Intensity; // 0x20
	public float _RampScale; // 0x24
	public float _RampOffset; // 0x28
	public float _RampSpeed; // 0x2C
	public float _Angle; // 0x30
	public Vector2 _GradientOffset; // 0x34
	private Image m_Image; // 0x40
	public Material mat; // 0x48

	// Methods

	// RVA: 0x41501B0 Offset: 0x414C1B0 VA: 0x41501B0
	private void Start() { }

	// RVA: 0x4150278 Offset: 0x414C278 VA: 0x4150278
	private void Update() { }

	// RVA: 0x41504B0 Offset: 0x414C4B0 VA: 0x41504B0
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
public class VertIndexAsUV : BaseMeshEffect // TypeDefIndex: 20919
{
	// Methods

	// RVA: 0x4150510 Offset: 0x414C510 VA: 0x4150510 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x41505F8 Offset: 0x414C5F8 VA: 0x41505F8
	public void .ctor() { }
}

// Namespace: 
public class ATTManager // TypeDefIndex: 20920
{
	// Fields
	private ATTStatus m_state; // 0x10
	private string m_id; // 0x18
	private bool m_isFinished; // 0x20
	private bool m_isWait; // 0x21
	private Action m_onFinished; // 0x28

	// Methods

	// RVA: 0x4150600 Offset: 0x414C600 VA: 0x4150600
	public void OnInit(Action onFinished) { }

	// RVA: 0x415061C Offset: 0x414C61C VA: 0x415061C
	private void NotifyFinished() { }

	// RVA: 0x4150650 Offset: 0x414C650 VA: 0x4150650
	private bool CheckShowIDFA() { }

	// RVA: 0x4150844 Offset: 0x414C844 VA: 0x4150844
	private void ReportATTResult(ATTStatus status) { }

	// RVA: 0x4150A80 Offset: 0x414CA80 VA: 0x4150A80
	public void OnUpdate() { }

	// RVA: 0x4150AF0 Offset: 0x414CAF0 VA: 0x4150AF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4150B50 Offset: 0x414CB50 VA: 0x4150B50
	private void <CheckShowIDFA>b__7_0(ATTStatus status, string idfa) { }
}

// Namespace: 
public static class Vibration // TypeDefIndex: 20921
{
	// Fields
	public static AndroidJavaClass unityPlayer; // 0x0
	public static AndroidJavaObject currentActivity; // 0x8
	public static AndroidJavaObject vibrator; // 0x10
	public static AndroidJavaObject context; // 0x18
	public static AndroidJavaClass vibrationEffect; // 0x20
	private static bool initialized; // 0x28
	private static bool _isOpen; // 0x29

	// Properties
	public static int AndroidVersion { get; }

	// Methods

	// RVA: 0x4150D94 Offset: 0x414CD94 VA: 0x4150D94
	public static void Init() { }

	// RVA: 0x4151300 Offset: 0x414D300 VA: 0x4151300
	public static void SetOpen(bool value) { }

	// RVA: 0x4151360 Offset: 0x414D360 VA: 0x4151360
	public static void VibratePop() { }

	// RVA: 0x4151760 Offset: 0x414D760 VA: 0x4151760
	public static void VibratePeek() { }

	// RVA: 0x415180C Offset: 0x414D80C VA: 0x415180C
	public static void VibrateNope() { }

	// RVA: 0x415140C Offset: 0x414D40C VA: 0x415140C
	public static void Vibrate(long milliseconds) { }

	// RVA: 0x4151900 Offset: 0x414D900 VA: 0x4151900
	public static void Vibrate(long[] pattern, int repeat) { }

	// RVA: 0x4151C44 Offset: 0x414DC44 VA: 0x4151C44
	public static void Cancel() { }

	// RVA: 0x4151D84 Offset: 0x414DD84 VA: 0x4151D84
	public static bool HasVibrator() { }

	// RVA: 0x415218C Offset: 0x414E18C VA: 0x415218C
	public static void Vibrate() { }

	// RVA: 0x4151238 Offset: 0x414D238 VA: 0x4151238
	public static int get_AndroidVersion() { }

	// RVA: 0x4152228 Offset: 0x414E228 VA: 0x4152228
	private static void .cctor() { }
}

// Namespace: 
public class AndroidBackManager // TypeDefIndex: 20922
{
	// Fields
	private List<BaseViewModule> m_list; // 0x10

	// Methods

	// RVA: 0x4152274 Offset: 0x414E274 VA: 0x4152274
	public void Update() { }

	// RVA: 0x4152558 Offset: 0x414E558 VA: 0x4152558
	public void Clear() { }

	// RVA: 0x41525C8 Offset: 0x414E5C8 VA: 0x41525C8
	public void AddBack(BaseViewModule view) { }

	// RVA: 0x41524C8 Offset: 0x414E4C8 VA: 0x41524C8
	public void RemoveBack(BaseViewModule view) { }

	// RVA: 0x415277C Offset: 0x414E77C VA: 0x415277C
	public void .ctor() { }
}

// Namespace: 
public class UIClickEffect : MonoBehaviour // TypeDefIndex: 20923
{
	// Fields
	[Tooltip("特效挂载的父节点 (通常是一个全屏的透明 Panel)")]
	[Header("必须设置")]
	public RectTransform effectRoot; // 0x20
	[Tooltip("UI 特效预制体 (可以是粒子或图片动画)")]
	public GameObject effectPrefab; // 0x28
	[Tooltip("渲染 UI 的摄像机 (Canvas模式为 Overlay 时可不填，Camera 模式时必填)")]
	public Camera uiCamera; // 0x30
	private GameObject _currentInstance; // 0x38
	private ParticleSystem _ps; // 0x40
	private RectTransform _instanceRect; // 0x48

	// Methods

	// RVA: 0x4152804 Offset: 0x414E804 VA: 0x4152804
	private void Start() { }

	// RVA: 0x415293C Offset: 0x414E93C VA: 0x415293C
	private void Update() { }

	// RVA: 0x4152968 Offset: 0x414E968 VA: 0x4152968
	private void PlayUIEffect() { }

	// RVA: 0x4152AA8 Offset: 0x414EAA8 VA: 0x4152AA8
	public void .ctor() { }
}

// Namespace: 
public class CameraFieldOfView : MonoBehaviour // TypeDefIndex: 20924
{
	// Methods

	// RVA: 0x4152AB0 Offset: 0x414EAB0 VA: 0x4152AB0
	private void Awake() { }

	// RVA: 0x4152C00 Offset: 0x414EC00 VA: 0x4152C00
	public void .ctor() { }
}

// Namespace: 
public static class DebugDraw // TypeDefIndex: 20925
{
	// Methods

	// RVA: 0x4152C08 Offset: 0x414EC08 VA: 0x4152C08
	public static void DrawBounds(Bounds b, float delay = 0) { }

	// RVA: 0x4152EE8 Offset: 0x414EEE8 VA: 0x4152EE8
	public static void DrawBox(Vector3 pos, Quaternion rot, Vector3 scale, Color c, float duration) { }
}

// Namespace: 
public class UIPointEvent : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 20926
{
	// Fields
	[CompilerGenerated]
	private Action<PointerEventData> OnPointerDownHandler; // 0x20
	[CompilerGenerated]
	private Action<PointerEventData> OnDragHandler; // 0x28
	[CompilerGenerated]
	private Action<PointerEventData> OnPointerUpHandler; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x41532F8 Offset: 0x414F2F8 VA: 0x41532F8
	public void add_OnPointerDownHandler(Action<PointerEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x41533A8 Offset: 0x414F3A8 VA: 0x41533A8
	public void remove_OnPointerDownHandler(Action<PointerEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x4153458 Offset: 0x414F458 VA: 0x4153458
	public void add_OnDragHandler(Action<PointerEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x4153508 Offset: 0x414F508 VA: 0x4153508
	public void remove_OnDragHandler(Action<PointerEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x41535B8 Offset: 0x414F5B8 VA: 0x41535B8
	public void add_OnPointerUpHandler(Action<PointerEventData> value) { }

	[CompilerGenerated]
	// RVA: 0x4153668 Offset: 0x414F668 VA: 0x4153668
	public void remove_OnPointerUpHandler(Action<PointerEventData> value) { }

	// RVA: 0x4153718 Offset: 0x414F718 VA: 0x4153718 Slot: 4
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x4153734 Offset: 0x414F734 VA: 0x4153734 Slot: 5
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x4153750 Offset: 0x414F750 VA: 0x4153750 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x415376C Offset: 0x414F76C VA: 0x415376C
	public void .ctor() { }
}

// Namespace: 
public enum LogLevel // TypeDefIndex: 20927
{
	// Fields
	public int value__; // 0x0
	public const LogLevel Info = 0;
	public const LogLevel Warning = 1;
	public const LogLevel Error = 2;
}

// Namespace: 
public struct GMDebugPage.LogMessage // TypeDefIndex: 20928
{
	// Fields
	public string Message; // 0x0
	public LogLevel Level; // 0x8

	// Methods

	// RVA: 0x41538C4 Offset: 0x414F8C4 VA: 0x41538C4
	public void .ctor(string message, LogLevel level) { }
}

// Namespace: 
public class GMDebugPage : GMPage // TypeDefIndex: 20929
{
	// Fields
	private static List<GMDebugPage.LogMessage> logMessages; // 0x0
	private static Vector2 scrollPosition; // 0x8
	private int logFontSize; // 0x14

	// Properties
	public override string PageName { get; }

	// Methods

	// RVA: 0x4153774 Offset: 0x414F774 VA: 0x4153774 Slot: 4
	public override string get_PageName() { }

	[Conditional("GM")]
	// RVA: 0x41537B4 Offset: 0x414F7B4 VA: 0x41537B4
	public static void Console(string message, LogLevel level = 0) { }

	// RVA: 0x41538EC Offset: 0x414F8EC VA: 0x41538EC Slot: 5
	public override void RenderPage() { }

	// RVA: 0x415400C Offset: 0x415000C VA: 0x415400C
	public void .ctor() { }

	// RVA: 0x4154080 Offset: 0x4150080 VA: 0x4154080
	private static void .cctor() { }
}

// Namespace: 
public class GMFunctionPage : GMPage // TypeDefIndex: 20930
{
	// Fields
	private static GMFunctionPage _gmFunctionPage; // 0x0
	private Vector2 scrollPosition; // 0x14
	private static Dictionary<string, Action> actions; // 0x8
	private static GMFunctionPage _page; // 0x10

	// Properties
	public override string PageName { get; }

	// Methods

	// RVA: 0x415415C Offset: 0x415015C VA: 0x415415C
	private void .ctor() { }

	// RVA: 0x41541CC Offset: 0x41501CC VA: 0x41541CC Slot: 4
	public override string get_PageName() { }

	// RVA: 0x415420C Offset: 0x415020C VA: 0x415420C
	public static void Init() { }

	// RVA: 0x41542A0 Offset: 0x41502A0 VA: 0x41542A0 Slot: 5
	public override void RenderPage() { }

	// RVA: 0x41545FC Offset: 0x41505FC VA: 0x41545FC
	public static void AddFunction(string functionName, Action function) { }

	// RVA: 0x41546E4 Offset: 0x41506E4 VA: 0x41546E4
	private static void .cctor() { }
}

// Namespace: 
public class GMManager : MonoSingleton<GMManager> // TypeDefIndex: 20931
{
	// Fields
	private static List<GMPage> pages; // 0x0
	private int currentPageIndex; // 0x20
	private bool isGMActive; // 0x24
	private Rect gmButtonRect; // 0x28
	private Vector2 dragOffset; // 0x38
	private bool isDragging; // 0x40

	// Methods

	// RVA: 0x4154774 Offset: 0x4150774 VA: 0x4154774
	private void DrawGMButtonWindow(int windowID) { }

	// RVA: 0x4154ABC Offset: 0x4150ABC VA: 0x4154ABC
	public void RegisterPage(GMPage page) { }

	// RVA: 0x4154B90 Offset: 0x4150B90 VA: 0x4154B90
	public void ClearAll() { }

	// RVA: 0x4154C28 Offset: 0x4150C28 VA: 0x4154C28
	public void .ctor() { }

	// RVA: 0x4154C7C Offset: 0x4150C7C VA: 0x4154C7C
	private static void .cctor() { }
}

// Namespace: 
public abstract class GMPage // TypeDefIndex: 20932
{
	// Fields
	public bool isShow; // 0x10

	// Properties
	public abstract string PageName { get; }

	// Methods

	// RVA: 0x4154018 Offset: 0x4150018 VA: 0x4154018
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_PageName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RenderPage();

	// RVA: 0x4154D14 Offset: 0x4150D14 VA: 0x4154D14 Slot: 6
	public virtual void RefreshPage() { }
}

// Namespace: 
public class DirToAngle : MonoBehaviour // TypeDefIndex: 20933
{
	// Fields
	public RectTransform root; // 0x20
	public Vector2 Dir; // 0x28

	// Methods

	// RVA: 0x4154D18 Offset: 0x4150D18 VA: 0x4154D18
	private void ToAngle() { }

	// RVA: 0x4154D58 Offset: 0x4150D58 VA: 0x4154D58
	private void Start() { }

	// RVA: 0x4154D5C Offset: 0x4150D5C VA: 0x4154D5C
	private void Update() { }

	// RVA: 0x4154D60 Offset: 0x4150D60 VA: 0x4154D60
	public void .ctor() { }
}

// Namespace: 
public class LogMeshVetext : MonoBehaviour // TypeDefIndex: 20934
{
	// Fields
	public MeshFilter meshFilter; // 0x20

	// Methods

	// RVA: 0x4154D68 Offset: 0x4150D68 VA: 0x4154D68
	private void Start() { }

	// RVA: 0x4155034 Offset: 0x4151034 VA: 0x4155034
	private void Update() { }

	// RVA: 0x4155038 Offset: 0x4151038 VA: 0x4155038
	public void .ctor() { }
}

// Namespace: 
public class EntityBody : MonoBehaviour // TypeDefIndex: 20935
{
	// Fields
	public AnimatorType animatorType; // 0x20
	public Transform m_center; // 0x28
	public Transform m_centerStay; // 0x30
	public Transform m_back; // 0x38
	public Transform m_centerFront; // 0x40
	public Transform m_foot; // 0x48
	public Transform m_head; // 0x50
	public List<Transform> FirePosList; // 0x58
	public Transform m_leftHand; // 0x60
	public Transform m_rightHand; // 0x68
	public Transform m_health; // 0x70
	public WeaponBody m_weaponLeftBody; // 0x78
	public WeaponBody m_weaponRightBody; // 0x80
	public Transform m_footOut; // 0x88
	public Transform m_centerView; // 0x90
	public LineRenderer m_npcPickupProcess; // 0x98
	public SkeletonAnimation m_bodySkeletonAnim; // 0xA0
	private SpriteSequenceAnimator _spriteSequenceAnimator; // 0xA8

	// Methods

	// RVA: 0x4155040 Offset: 0x4151040 VA: 0x4155040
	private void Awake() { }

	// RVA: 0x41552FC Offset: 0x41512FC VA: 0x41552FC
	private void OnEnable() { }

	// RVA: 0x41553DC Offset: 0x41513DC VA: 0x41553DC
	public void .ctor() { }
}

// Namespace: 
public class WeaponBody : MonoBehaviour // TypeDefIndex: 20936
{
	// Fields
	public Transform m_bulletNode; // 0x20
	public Transform m_center; // 0x28
	public Transform m_localCenter; // 0x30
	public Transform m_head; // 0x38
	public Transform m_tail; // 0x40
	public Animator m_animator; // 0x48

	// Methods

	// RVA: 0x41553E4 Offset: 0x41513E4 VA: 0x41553E4
	public Transform GetTransform(WeaponBodyPosType posType) { }

	// RVA: 0x4155430 Offset: 0x4151430 VA: 0x4155430
	public void PlayAnimation(string triggerName) { }

	// RVA: 0x41554D8 Offset: 0x41514D8 VA: 0x41554D8
	public void SetAnimatorSpeed(float speed) { }

	// RVA: 0x4155570 Offset: 0x4151570 VA: 0x4155570
	public void StopAnimation() { }

	// RVA: 0x41555F4 Offset: 0x41515F4 VA: 0x41555F4
	public void ResetAnimation(string triggerName) { }

	// RVA: 0x415569C Offset: 0x415169C VA: 0x415569C
	public void .ctor() { }
}

// Namespace: 
public enum WeaponBodyPosType // TypeDefIndex: 20937
{
	// Fields
	public int value__; // 0x0
	public const WeaponBodyPosType BulletNode = 0;
	public const WeaponBodyPosType Center = 1;
	public const WeaponBodyPosType LocalCenter = 2;
	public const WeaponBodyPosType Head = 3;
	public const WeaponBodyPosType Tail = 4;
}

// Namespace: 
public class AnimatedMeshAnimator : MonoBehaviour // TypeDefIndex: 20938
{
	// Fields
	[SerializeField]
	private List<AnimationFrameInfo> FrameInformations; // 0x20
	[SerializeField]
	private MaterialPropertyBlockController PropertyBlockController; // 0x28
	private static float _singleFrameTime; // 0x0
	[SerializeField]
	public float Speed; // 0x30
	public bool enable; // 0x34
	private int _currentFrame; // 0x38
	private AnimationFrameInfo _currentAnimation; // 0x40
	private bool _loop; // 0x48
	private bool _isPlaying; // 0x49
	private bool _pause; // 0x4A
	private float _currentTime; // 0x4C
	private int m_currentFrameKeyIndex; // 0x50
	private Action<GameObject, string> m_onListen; // 0x58
	private static int _propertyId; // 0x4

	// Properties
	public float singleFrameTime { get; }

	// Methods

	// RVA: 0x41556A4 Offset: 0x41516A4 VA: 0x41556A4
	public float get_singleFrameTime() { }

	// RVA: 0x415571C Offset: 0x415171C VA: 0x415571C
	public MaterialPropertyBlockController GetMaterialPropertyBlockController() { }

	// RVA: 0x4155724 Offset: 0x4151724 VA: 0x4155724
	public void Setup(List<AnimationFrameInfo> frameInformations, MaterialPropertyBlockController propertyBlockController) { }

	// RVA: 0x4155754 Offset: 0x4151754 VA: 0x4155754
	public bool IsHaveAnimator(string name) { }

	// RVA: 0x415581C Offset: 0x415181C VA: 0x415581C
	public void ResetLastAnimation() { }

	// RVA: 0x4155840 Offset: 0x4151840 VA: 0x4155840
	public void Play(string animationName, bool loop, float speed) { }

	// RVA: 0x4155B70 Offset: 0x4151B70 VA: 0x4155B70
	public bool IsPlaying(string animationName) { }

	// RVA: 0x4155BA0 Offset: 0x4151BA0 VA: 0x4155BA0
	private void Update() { }

	// RVA: 0x4155DA4 Offset: 0x4151DA4 VA: 0x4155DA4
	public void Stop() { }

	// RVA: 0x4155AD8 Offset: 0x4151AD8 VA: 0x4155AD8
	private void SetFrame(int frame) { }

	// RVA: 0x4155C04 Offset: 0x4151C04 VA: 0x4155C04
	private void GetNextFrame() { }

	// RVA: 0x4155B6C Offset: 0x4151B6C VA: 0x4155B6C
	private void SendAnimationStartEvent(string animationName) { }

	// RVA: 0x4155E6C Offset: 0x4151E6C VA: 0x4155E6C
	private void SendAnimationEndEvent(string animationName) { }

	// RVA: 0x4155E70 Offset: 0x4151E70 VA: 0x4155E70
	public float GetCurrentNormalizedTime() { }

	// RVA: 0x4155EA0 Offset: 0x4151EA0 VA: 0x4155EA0
	public float GetCurrentLength() { }

	// RVA: 0x4155ED4 Offset: 0x4151ED4 VA: 0x4155ED4
	public void PauseAnimation(bool pause) { }

	// RVA: 0x4155EE0 Offset: 0x4151EE0 VA: 0x4155EE0
	public void SetSpeed(float speed) { }

	// RVA: 0x4155EE8 Offset: 0x4151EE8 VA: 0x4155EE8
	public void AddAnimationListen(Action<GameObject, string> listen) { }

	// RVA: 0x4155F90 Offset: 0x4151F90 VA: 0x4155F90
	public void RemoveAnimationListen(Action<GameObject, string> listen) { }

	// RVA: 0x4156038 Offset: 0x4152038 VA: 0x4156038
	public void .ctor() { }

	// RVA: 0x4156050 Offset: 0x4152050 VA: 0x4156050
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class AnimationFrameInfo // TypeDefIndex: 20939
{
	// Fields
	public string Name; // 0x10
	public int StartFrame; // 0x18
	public int EndFrame; // 0x1C
	public int FrameCount; // 0x20
	public float Speed; // 0x24
	public List<AnimationFrameInfoKey> Keys; // 0x28

	// Methods

	// RVA: 0x41560CC Offset: 0x41520CC VA: 0x41560CC
	public void .ctor(string name, int startFrame, int endFrame, int frameCount, float speed) { }
}

// Namespace: 
[Serializable]
public class AnimationFrameInfoKey // TypeDefIndex: 20940
{
	// Fields
	public int frame; // 0x10
	public string name; // 0x18

	// Methods

	// RVA: 0x4156140 Offset: 0x4152140 VA: 0x4156140
	public void .ctor() { }
}

// Namespace: 
public class MaterialPropertyBlockController : MonoBehaviour // TypeDefIndex: 20941
{
	// Fields
	private Renderer _renderer; // 0x20
	private MaterialPropertyBlock _materialPropertyBlock; // 0x28

	// Properties
	private Renderer Renderer { get; }
	private MaterialPropertyBlock MaterialPropertyBlock { get; }

	// Methods

	// RVA: 0x4156148 Offset: 0x4152148 VA: 0x4156148
	private Renderer get_Renderer() { }

	// RVA: 0x41561B8 Offset: 0x41521B8 VA: 0x41561B8
	private MaterialPropertyBlock get_MaterialPropertyBlock() { }

	// RVA: 0x4155DC0 Offset: 0x4151DC0 VA: 0x4155DC0
	public void RefreshBlock() { }

	// RVA: 0x4156228 Offset: 0x4152228 VA: 0x4156228
	public void SetColor(string propertyName, Color color) { }

	// RVA: 0x415627C Offset: 0x415227C VA: 0x415627C
	public void SetColor(int propertyId, Color color) { }

	// RVA: 0x41562D0 Offset: 0x41522D0 VA: 0x41562D0
	public Color GetColor(int propertyId) { }

	// RVA: 0x41562F4 Offset: 0x41522F4 VA: 0x41562F4
	public Color GetColor(string propertyName) { }

	// RVA: 0x4156318 Offset: 0x4152318 VA: 0x4156318
	public void SetFloat(string propertyName, float value) { }

	// RVA: 0x415634C Offset: 0x415234C VA: 0x415634C
	public void SetFloat(int propertyId, float value) { }

	// RVA: 0x4156380 Offset: 0x4152380 VA: 0x4156380
	public float GetFloat(int propertyId) { }

	// RVA: 0x41563A4 Offset: 0x41523A4 VA: 0x41563A4
	public float GetFloat(string propertyName) { }

	// RVA: 0x4155DFC Offset: 0x4151DFC VA: 0x4155DFC
	public void SetInt(int propertyId, int value) { }

	// RVA: 0x4155E30 Offset: 0x4151E30 VA: 0x4155E30
	public void Apply() { }

	// RVA: 0x41563C8 Offset: 0x41523C8 VA: 0x41563C8
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(Animator))]
[AddComponentMenu("UICustom/CustomToggle", 26)]
public class CustomToggle : Toggle // TypeDefIndex: 20942
{
	// Fields
	[Header("Intervals Setting")]
	public float m_intervals; // 0x124
	[SerializeField]
	private float m_lastClickTime; // 0x128
	[SerializeField]
	private float m_currentTime; // 0x12C
	[Header("Audio Setting")]
	public string m_audioPath; // 0x130
	private Animator _buttonAnimator; // 0x138

	// Properties
	private bool IsCanClick { get; }

	// Methods

	// RVA: 0x41563D0 Offset: 0x41523D0 VA: 0x41563D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x41564CC Offset: 0x41524CC VA: 0x41564CC Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x415657C Offset: 0x415257C VA: 0x415657C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4156640 Offset: 0x4152640 VA: 0x4156640
	private bool get_IsCanClick() { }

	// RVA: 0x415667C Offset: 0x415267C VA: 0x415667C Slot: 49
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4156728 Offset: 0x4152728 VA: 0x4156728
	private void PlayAudio() { }

	// RVA: 0x415659C Offset: 0x415259C VA: 0x415659C
	private void OnToggle(bool on) { }

	// RVA: 0x41567EC Offset: 0x41527EC VA: 0x41567EC
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x415681C Offset: 0x415281C VA: 0x415681C
	public void .ctor() { }
}

// Namespace: 
public class PathDebugger : MonoBehaviour // TypeDefIndex: 20943
{
	// Methods

	// RVA: 0x4156880 Offset: 0x4152880 VA: 0x4156880
	public void .ctor() { }
}

// Namespace: 
public class ClickableLink : MonoBehaviour, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 20944
{
	// Fields
	private TMP_Text _tmpText; // 0x20
	private Canvas _canvas; // 0x28
	private Camera _uiCamera; // 0x30
	private Action<string> _onClick; // 0x38

	// Methods

	// RVA: 0x4156888 Offset: 0x4152888 VA: 0x4156888
	private void Awake() { }

	// RVA: 0x41569B8 Offset: 0x41529B8 VA: 0x41569B8
	public void SetAction(Action<string> onClickAction) { }

	// RVA: 0x41569C0 Offset: 0x41529C0 VA: 0x41569C0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4156AE0 Offset: 0x4152AE0 VA: 0x4156AE0
	private void HandleLinkClick(string id) { }

	// RVA: 0x4156AFC Offset: 0x4152AFC VA: 0x4156AFC
	public void .ctor() { }
}

// Namespace: 
public class UIButtonGray : MonoBehaviour // TypeDefIndex: 20945
{
	// Fields
	[Header("Target Setting")]
	public Graphic[] m_targets; // 0x20
	[Header("Materail Setting")]
	public Material m_grayMat; // 0x28
	[Label]
	public bool m_isGray; // 0x30
	private const string GrayMatAddress = "Assets/_Resources/Shared/Shaders/Materials/SpriteGrayMat.mat";
	private static Material s_sharedGrayMat; // 0x0

	// Methods

	// RVA: 0x4156B04 Offset: 0x4152B04 VA: 0x4156B04
	private Material GetGrayMat() { }

	// RVA: 0x4156D5C Offset: 0x4152D5C VA: 0x4156D5C
	public void SetUIGray() { }

	// RVA: 0x4156F30 Offset: 0x4152F30 VA: 0x4156F30
	public void Recovery() { }

	[ContextMenu("Find Graphic")]
	// RVA: 0x4156EC4 Offset: 0x4152EC4 VA: 0x4156EC4
	public void FindGraphic() { }

	// RVA: 0x4157058 Offset: 0x4153058 VA: 0x4157058
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 20946
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 20947
{
	// Methods

	// RVA: 0x4157060 Offset: 0x4153060 VA: 0x4157060
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x4157158 Offset: 0x4153158 VA: 0x4157158
	public void .ctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class AppleStoreKitTestTangle // TypeDefIndex: 20948
{
	// Fields
	private static byte[] data; // 0x0
	private static int[] order; // 0x8
	private static int key; // 0x10
	public static readonly bool IsPopulated; // 0x14

	// Methods

	// RVA: 0x4157160 Offset: 0x4153160 VA: 0x4157160
	public static byte[] Data() { }

	// RVA: 0x41571EC Offset: 0x41531EC VA: 0x41571EC
	public void .ctor() { }

	// RVA: 0x41571F4 Offset: 0x41531F4 VA: 0x41571F4
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class AppleTangle // TypeDefIndex: 20949
{
	// Fields
	private static byte[] data; // 0x0
	private static int[] order; // 0x8
	private static int key; // 0x10
	public static readonly bool IsPopulated; // 0x14

	// Methods

	// RVA: 0x4157308 Offset: 0x4153308 VA: 0x4157308
	public static byte[] Data() { }

	// RVA: 0x4157394 Offset: 0x4153394 VA: 0x4157394
	public void .ctor() { }

	// RVA: 0x415739C Offset: 0x415339C VA: 0x415739C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Purchasing.Security
public class GooglePlayTangle // TypeDefIndex: 20950
{
	// Fields
	private static byte[] data; // 0x0
	private static int[] order; // 0x8
	private static int key; // 0x10
	public static readonly bool IsPopulated; // 0x14

	// Methods

	// RVA: 0x41574B0 Offset: 0x41534B0 VA: 0x41574B0
	public static byte[] Data() { }

	// RVA: 0x415753C Offset: 0x415353C VA: 0x415753C
	public void .ctor() { }

	// RVA: 0x4157544 Offset: 0x4153544 VA: 0x4157544
	private static void .cctor() { }
}

// Namespace: Dxx.UI
[DisallowMultipleComponent]
[RequireComponent(typeof(Graphic))]
[AddComponentMenu("UICustom/Effects/UI Flip")]
public class UIFlip : BaseMeshEffect // TypeDefIndex: 20951
{
	// Fields
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Veritical; // 0x29

	// Properties
	public bool horizontal { get; set; }
	public bool vertical { get; set; }

	// Methods

	// RVA: 0x4157658 Offset: 0x4153658 VA: 0x4157658
	public bool get_horizontal() { }

	// RVA: 0x4157660 Offset: 0x4153660 VA: 0x4157660
	public void set_horizontal(bool value) { }

	// RVA: 0x415766C Offset: 0x415366C VA: 0x415766C
	public bool get_vertical() { }

	// RVA: 0x4157674 Offset: 0x4153674 VA: 0x4157674
	public void set_vertical(bool value) { }

	// RVA: 0x4157680 Offset: 0x4153680 VA: 0x4157680 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x415777C Offset: 0x415377C VA: 0x415777C
	public void .ctor() { }
}

// Namespace: Dxx.UI
[DisallowMultipleComponent]
[RequireComponent(typeof(Graphic))]
[AddComponentMenu("UICustom/Effects/UI Mirror")]
public class UIMirror : BaseMeshEffect // TypeDefIndex: 20952
{
	// Fields
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29

	// Methods

	// RVA: 0x4157784 Offset: 0x4153784 VA: 0x4157784 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x4157908 Offset: 0x4153908 VA: 0x4157908
	public void .ctor() { }
}

// Namespace: HotFix
public class NetLoadingViewModule : BaseViewModule // TypeDefIndex: 20953
{
	// Fields
	public CanvasGroup m_canvasGroup; // 0x38
	public RectTransform m_rotate; // 0x40
	public float m_delayTime; // 0x48
	public float m_fadeTime; // 0x4C
	private SequencePool m_seqPool; // 0x50

	// Methods

	// RVA: 0x4157910 Offset: 0x4153910 VA: 0x4157910 Slot: 11
	public override void OnCreate(object data) { }

	// RVA: 0x4157914 Offset: 0x4153914 VA: 0x4157914 Slot: 13
	public override void OnOpen(object data) { }

	// RVA: 0x41579E8 Offset: 0x41539E8 VA: 0x41579E8 Slot: 14
	public override void OnClose() { }

	// RVA: 0x4157A04 Offset: 0x4153A04 VA: 0x4157A04 Slot: 12
	public override void OnDelete() { }

	// RVA: 0x4157A08 Offset: 0x4153A08 VA: 0x4157A08 Slot: 15
	public override void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x4157A6C Offset: 0x4153A6C VA: 0x4157A6C Slot: 9
	public override void RegisterEvents(EventSystemManager manager) { }

	// RVA: 0x4157A70 Offset: 0x4153A70 VA: 0x4157A70 Slot: 10
	public override void UnRegisterEvents(EventSystemManager manager) { }

	// RVA: 0x4157A74 Offset: 0x4153A74 VA: 0x4157A74
	public void .ctor() { }
}

// Namespace: HotFix
public class NetLoadingViewModuleOpenData // TypeDefIndex: 20954
{
	// Fields
	public float m_delayTime; // 0x10
	public float m_fadeTime; // 0x14

	// Methods

	// RVA: 0x4157B18 Offset: 0x4153B18 VA: 0x4157B18
	public void .ctor() { }
}

// Namespace: Habby
public enum ATTStatus // TypeDefIndex: 20955
{
	// Fields
	public int value__; // 0x0
	public const ATTStatus NotDetermined = 0;
	public const ATTStatus Restricted = 1;
	public const ATTStatus Denied = 2;
	public const ATTStatus Authorized = 3;
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class ATTControl.CallbackHandler : MulticastDelegate // TypeDefIndex: 20956
{
	// Methods

	// RVA: 0x4150724 Offset: 0x414C724 VA: 0x4150724
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4157BE4 Offset: 0x4153BE4 VA: 0x4157BE4 Slot: 13
	public virtual void Invoke(ATTStatus status, string idfa) { }

	// RVA: 0x4157BF8 Offset: 0x4153BF8 VA: 0x4157BF8 Slot: 14
	public virtual IAsyncResult BeginInvoke(ATTStatus status, string idfa, AsyncCallback callback, object object) { }

	// RVA: 0x4157C8C Offset: 0x4153C8C VA: 0x4157C8C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Habby
public class ATTControl // TypeDefIndex: 20957
{
	// Fields
	private static ATTControl.CallbackHandler _callback; // 0x0

	// Properties
	public static bool AuthorizationAvailable { get; }

	// Methods

	// RVA: 0x4157BC0 Offset: 0x4153BC0 VA: 0x4157BC0
	public static bool get_AuthorizationAvailable() { }

	// RVA: 0x4157BC8 Offset: 0x4153BC8 VA: 0x4157BC8
	public static bool IsAdvertisingTrackingEnabled() { }

	// RVA: 0x415071C Offset: 0x414C71C VA: 0x415071C
	public static ATTStatus GetAuthorizationStatus(bool compatible = True) { }

	[MonoPInvokeCallback(typeof(ATTControl.CallbackHandler))]
	// RVA: 0x4157B30 Offset: 0x4153B30 VA: 0x4157B30
	private static void Callback(ATTStatus status, string idfa) { }

	// RVA: 0x41507C4 Offset: 0x414C7C4 VA: 0x41507C4
	public static void RequestAdvertisingIdentifier(bool compatible, ATTControl.CallbackHandler callback) { }

	// RVA: 0x4157BD0 Offset: 0x4153BD0 VA: 0x4157BD0
	public static void RequestAdvertisingIdentifier(ATTControl.CallbackHandler callback) { }

	// RVA: 0x4157BDC Offset: 0x4153BDC VA: 0x4157BDC
	public void .ctor() { }
}

// Namespace: Framework
public class AOTReferences // TypeDefIndex: 20958
{
	// Methods

	// RVA: 0x4157C98 Offset: 0x4153C98 VA: 0x4157C98
	public void Reference() { }

	// RVA: 0x415891C Offset: 0x415491C VA: 0x415891C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GameAdsManager.<>c // TypeDefIndex: 20959
{
	// Fields
	public static readonly GameAdsManager.<>c <>9; // 0x0
	public static Action<AdPaidEventData> <>9__21_3; // 0x8

	// Methods

	// RVA: 0x415AE98 Offset: 0x4156E98 VA: 0x415AE98
	private static void .cctor() { }

	// RVA: 0x415AF00 Offset: 0x4156F00 VA: 0x415AF00
	public void .ctor() { }

	// RVA: 0x415AF08 Offset: 0x4156F08 VA: 0x415AF08
	internal void <CheckAndPlayVideo>b__21_3(AdPaidEventData data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<>c__DisplayClass21_0 // TypeDefIndex: 20960
{
	// Fields
	public Action<string> onPlayFail; // 0x10
	public GameAdsManager <>4__this; // 0x18
	public Action onShow; // 0x20
	public Action<bool> onClose; // 0x28

	// Methods

	// RVA: 0x415A78C Offset: 0x415678C VA: 0x415A78C
	public void .ctor() { }

	// RVA: 0x415B0F8 Offset: 0x41570F8 VA: 0x415B0F8
	internal void <CheckAndPlayVideo>b__4() { }

	// RVA: 0x415B15C Offset: 0x415715C VA: 0x415B15C
	internal void <CheckAndPlayVideo>b__0(AdUnitConfig showedAdUnitConfig) { }

	// RVA: 0x415B264 Offset: 0x4157264 VA: 0x415B264
	internal void <CheckAndPlayVideo>b__1(int code, string message) { }

	// RVA: 0x415B430 Offset: 0x4157430 VA: 0x415B430
	internal void <CheckAndPlayVideo>b__2(bool isRewarded) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<>c__DisplayClass21_1 // TypeDefIndex: 20961
{
	// Fields
	public AdUnitConfig showedAdUnitConfig; // 0x10
	public GameAdsManager.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x415B25C Offset: 0x415725C VA: 0x415B25C
	public void .ctor() { }

	// RVA: 0x415B644 Offset: 0x4157644 VA: 0x415B644
	internal void <CheckAndPlayVideo>b__5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<>c__DisplayClass21_2 // TypeDefIndex: 20962
{
	// Fields
	public string message; // 0x10
	public GameAdsManager.<>c__DisplayClass21_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x415B428 Offset: 0x4157428 VA: 0x415B428
	public void .ctor() { }

	// RVA: 0x415B698 Offset: 0x4157698 VA: 0x415B698
	internal void <CheckAndPlayVideo>b__6() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<>c__DisplayClass21_3 // TypeDefIndex: 20963
{
	// Fields
	public bool isRewarded; // 0x10
	public GameAdsManager.<>c__DisplayClass21_0 CS$<>8__locals3; // 0x18

	// Methods

	// RVA: 0x415B63C Offset: 0x415763C VA: 0x415B63C
	public void .ctor() { }

	// RVA: 0x415B6D0 Offset: 0x41576D0 VA: 0x415B6D0
	internal void <CheckAndPlayVideo>b__7() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<GetAdUnitConfigs>d__26 : IEnumerable<AdUnitConfig>, IEnumerable, IEnumerator<AdUnitConfig>, IEnumerator, IDisposable // TypeDefIndex: 20964
{
	// Fields
	private int <>1__state; // 0x10
	private AdUnitConfig <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private AdConfig config; // 0x28
	public AdConfig <>3__config; // 0x30
	private List.Enumerator<AdUnitConfig> <>7__wrap1; // 0x38
	private IEnumerator<AdUnitConfig> <>7__wrap2; // 0x50

	// Properties
	private AdUnitConfig System.Collections.Generic.IEnumerator<GorillaAd.Runtime.AdUnitConfig>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x415AD44 Offset: 0x4156D44 VA: 0x415AD44
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x415B850 Offset: 0x4157850 VA: 0x415B850 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x415B88C Offset: 0x415788C VA: 0x415B88C Slot: 8
	private bool MoveNext() { }

	// RVA: 0x415C074 Offset: 0x4158074 VA: 0x415C074
	private void <>m__Finally1() { }

	// RVA: 0x415C0C4 Offset: 0x41580C4 VA: 0x415C0C4
	private void <>m__Finally2() { }

	// RVA: 0x415C174 Offset: 0x4158174 VA: 0x415C174
	private void <>m__Finally3() { }

	// RVA: 0x415C224 Offset: 0x4158224 VA: 0x415C224
	private void <>m__Finally4() { }

	[DebuggerHidden]
	// RVA: 0x415C2D4 Offset: 0x41582D4 VA: 0x415C2D4 Slot: 6
	private AdUnitConfig System.Collections.Generic.IEnumerator<GorillaAd.Runtime.AdUnitConfig>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x415C2DC Offset: 0x41582DC VA: 0x415C2DC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x415C314 Offset: 0x4158314 VA: 0x415C314 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x415C31C Offset: 0x415831C VA: 0x415C31C Slot: 4
	private IEnumerator<AdUnitConfig> System.Collections.Generic.IEnumerable<GorillaAd.Runtime.AdUnitConfig>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x415C3C0 Offset: 0x41583C0 VA: 0x415C3C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameAdsManager.<GetAdUnitConfigs>d__27 : IEnumerable<AdUnitConfig>, IEnumerable, IEnumerator<AdUnitConfig>, IEnumerator, IDisposable // TypeDefIndex: 20965
{
	// Fields
	private int <>1__state; // 0x10
	private AdUnitConfig <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IEnumerable<AdUnitConfig> configs; // 0x28
	public IEnumerable<AdUnitConfig> <>3__configs; // 0x30
	private IEnumerator<AdUnitConfig> <>7__wrap1; // 0x38

	// Properties
	private AdUnitConfig System.Collections.Generic.IEnumerator<GorillaAd.Runtime.AdUnitConfig>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x415ADF4 Offset: 0x4156DF4 VA: 0x415ADF4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x415C3C4 Offset: 0x41583C4 VA: 0x415C3C4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x415C3E0 Offset: 0x41583E0 VA: 0x415C3E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x415C670 Offset: 0x4158670 VA: 0x415C670
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x415C720 Offset: 0x4158720 VA: 0x415C720 Slot: 6
	private AdUnitConfig System.Collections.Generic.IEnumerator<GorillaAd.Runtime.AdUnitConfig>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x415C728 Offset: 0x4158728 VA: 0x415C728 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x415C760 Offset: 0x4158760 VA: 0x415C760 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x415C768 Offset: 0x4158768 VA: 0x415C768 Slot: 4
	private IEnumerator<AdUnitConfig> System.Collections.Generic.IEnumerable<GorillaAd.Runtime.AdUnitConfig>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x415C80C Offset: 0x415880C VA: 0x415C80C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Framework
public class GameAdsManager // TypeDefIndex: 20966
{
	// Fields
	private const string Tag = "[GameAdsManager]";
	public static readonly GameAdsManager Instance; // 0x0
	private const string AdWatchEventName = "ad_watch";
	private const string DefaultAdUnitName = "Default";
	private const string CoinShopAdUnitName = "钻石兑换金币商店";
	private const string QuickHangUpAdUnitName = "快速游猎";
	private const string ReliveAdUnitName = "复活";
	private static AdConfig _gorillaAdConfig; // 0x8
	private static Dictionary<string, string> _rewardAdUnitIdsBySource; // 0x10
	private bool _noAds; // 0x10
	private AdUnitConfig _lastShowedAdUnitConfig; // 0x18

	// Properties
	private static AdConfig GorillaAdConfig { get; }

	// Methods

	// RVA: 0x4158924 Offset: 0x4154924 VA: 0x4158924
	private static AdConfig get_GorillaAdConfig() { }

	// RVA: 0x41590C4 Offset: 0x41550C4 VA: 0x41590C4
	public void InitAds(string userId) { }

	// RVA: 0x415934C Offset: 0x415534C VA: 0x415934C
	public void SetNoAds(bool isNoAds) { }

	// RVA: 0x4150CEC Offset: 0x414CCEC VA: 0x4150CEC
	public void InitUmp(bool isShow) { }

	// RVA: 0x4159434 Offset: 0x4155434 VA: 0x4159434
	public void IsShowFallbackRewardedVideo(bool isSkip) { }

	// RVA: 0x415958C Offset: 0x415558C VA: 0x415958C
	public void TrackAdReward(bool success, List<ValueTuple<int, int>> items, string source, int code = 0, string message = "") { }

	// RVA: 0x4159D30 Offset: 0x4155D30 VA: 0x4159D30
	public void TrackADRelive(string battleId, string source, int code = 0) { }

	// RVA: 0x4159F40 Offset: 0x4155F40 VA: 0x4159F40
	public void TrackAdButtonShow(string source) { }

	// RVA: 0x41598A8 Offset: 0x41558A8 VA: 0x41598A8
	private static List<Dictionary<string, object>> BuildRewardList(List<ValueTuple<int, int>> rewards) { }

	// RVA: 0x415A0D8 Offset: 0x41560D8 VA: 0x415A0D8
	public bool CheckAndPlayVideo(Action<bool> onClose, Action onShow, Action<string> onPlayFail, Func<string> getSource) { }

	// RVA: 0x415A794 Offset: 0x4156794 VA: 0x415A794
	private static string GetRewardAdUnitId(string source) { }

	// RVA: 0x415AB20 Offset: 0x4156B20 VA: 0x415AB20
	private static string GetTargetAdUnitName(string source) { }

	// RVA: 0x4158C3C Offset: 0x4154C3C VA: 0x4158C3C
	private static Dictionary<string, string> BuildRewardAdUnitIdCache(AdConfig config) { }

	// RVA: 0x415AC70 Offset: 0x4156C70 VA: 0x415AC70
	private static bool IsCachedRewardAdUnitName(string adUnitName) { }

	[IteratorStateMachine(typeof(GameAdsManager.<GetAdUnitConfigs>d__26))]
	// RVA: 0x415ABF4 Offset: 0x4156BF4 VA: 0x415ABF4
	private static IEnumerable<AdUnitConfig> GetAdUnitConfigs(AdConfig config) { }

	[IteratorStateMachine(typeof(GameAdsManager.<GetAdUnitConfigs>d__27))]
	// RVA: 0x415AD78 Offset: 0x4156D78 VA: 0x415AD78
	private static IEnumerable<AdUnitConfig> GetAdUnitConfigs(IEnumerable<AdUnitConfig> configs) { }

	// RVA: 0x415AB04 Offset: 0x4156B04 VA: 0x415AB04
	private static bool IsValidAdUnitId(string adUnitId) { }

	// RVA: 0x4159BB4 Offset: 0x4155BB4 VA: 0x4159BB4
	private static void HandleAdEvent(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x415AE28 Offset: 0x4156E28 VA: 0x415AE28
	public void .ctor() { }

	// RVA: 0x415AE30 Offset: 0x4156E30 VA: 0x415AE30
	private static void .cctor() { }
}

// Namespace: Framework
[CreateAssetMenu]
public class GameAppConfigData : ScriptableObject // TypeDefIndex: 20967
{
	// Fields
	public List<GameAppConfigInfo> m_gameAppConfigInfoList; // 0x18
	public Dictionary<string, GameAppConfigInfo> m_gameAppConfigInfoDic; // 0x20

	// Methods

	// RVA: 0x415C810 Offset: 0x4158810 VA: 0x415C810
	private void OnEnable() { }

	// RVA: 0x415C930 Offset: 0x4158930 VA: 0x415C930
	private void OnDestroy() { }

	// RVA: 0x415C98C Offset: 0x415898C VA: 0x415C98C
	public string GetConfigInfo(string name) { }

	// RVA: 0x415CA28 Offset: 0x4158A28 VA: 0x415CA28
	public void .ctor() { }
}

// Namespace: Framework
[Serializable]
public class GameAppConfigInfo // TypeDefIndex: 20968
{
	// Fields
	public string name; // 0x10
	public string info; // 0x18

	// Methods

	// RVA: 0x415CAB0 Offset: 0x4158AB0 VA: 0x415CAB0
	public void .ctor() { }
}

// Namespace: Framework
[CreateAssetMenu(fileName = "GameNetWorkSwitchConfig")]
public class GameNetWorkSwitchConfig : ScriptableObject // TypeDefIndex: 20969
{
	// Fields
	public ServerInfo CurServerInfo; // 0x18
	public ServerInfo CurServerInfoCN; // 0x28

	// Properties
	private IEnumerable getServerInfoDropdownList { get; }

	// Methods

	// RVA: 0x415CAB8 Offset: 0x4158AB8 VA: 0x415CAB8
	private IEnumerable get_getServerInfoDropdownList() { }

	// RVA: 0x415CBC4 Offset: 0x4158BC4 VA: 0x415CBC4
	public void .ctor() { }
}

// Namespace: Framework
public class PathManager : Singleton<PathManager> // TypeDefIndex: 20970
{
	// Fields
	public const string AppStore = "AppStore";
	public const string GoogleStore = "GoogleStore";
	public const string GorillaStoreCN = "GorillaStoreCN";

	// Methods

	// RVA: 0x415CD14 Offset: 0x4158D14 VA: 0x415CD14
	public string GetCdnUrl(CdnType cdnType) { }

	// RVA: 0x415CDD4 Offset: 0x4158DD4 VA: 0x415CDD4
	public string GetCdnUrl(CdnType cdnType, string channelName) { }

	// RVA: 0x415D0AC Offset: 0x41590AC VA: 0x415D0AC
	public string GetHotUpdateConfigUrl(CdnType cdnType, string channelName, string version) { }

	// RVA: 0x415D354 Offset: 0x4159354 VA: 0x415D354
	public string GetHotUpdateIsForceUrl(CdnType cdnType, string channelName, string version) { }

	// RVA: 0x415D568 Offset: 0x4159568 VA: 0x415D568
	public string GetAppUrl(string channelName) { }

	// RVA: 0x415D66C Offset: 0x415966C VA: 0x415D66C
	public string GetAndroidApkUrl(CdnType cdnType, string version) { }

	// RVA: 0x415D7E4 Offset: 0x41597E4 VA: 0x415D7E4
	public static string GetAndroidApkObjectPath(CdnType cdnType, string channelName, string version) { }

	// RVA: 0x415D9B4 Offset: 0x41599B4 VA: 0x415D9B4
	public string GetResourcesSeverVersion(CdnType cdnType, string channelName) { }

	// RVA: 0x415DB84 Offset: 0x4159B84 VA: 0x415DB84
	public string GetResourcesSeverVersionNew(CdnType cdnType, string channelName) { }

	// RVA: 0x415D05C Offset: 0x415905C VA: 0x415D05C
	private static bool IsXXYZDChannel(string channelName) { }

	// RVA: 0x415CF1C Offset: 0x4158F1C VA: 0x415CF1C
	private static bool GetUseChinaServer() { }

	// RVA: 0x415DD54 Offset: 0x4159D54 VA: 0x415DD54
	public void .ctor() { }
}

// Namespace: Framework
public class Singleton<T> // TypeDefIndex: 20971
{
	// Fields
	private static T instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAC0C Offset: 0x54E6C0C VA: 0x54EAC0C
	|-Singleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAD04 Offset: 0x54E6D04 VA: 0x54EAD04
	|-Singleton<object>..ctor
	*/
}

// Namespace: Framework
public static class DictionaryExtensions // TypeDefIndex: 20972
{}

// Namespace: Framework
[Serializable]
public struct ServerInfo // TypeDefIndex: 20973
{
	// Fields
	[SerializeField]
	public string Name; // 0x0
	[SerializeField]
	public string NetworkUrl; // 0x8

	// Methods

	// RVA: 0x415CCE4 Offset: 0x4158CE4 VA: 0x415CCE4
	public void .ctor(string cname, string networkUrl) { }
}

// Namespace: Framework
public static class FrameworkConst // TypeDefIndex: 20974
{
	// Fields
	public const string TestCdnUrl = "https://test-dataupdate-skyblitz.skyblitzsvc.com/";
	public const string ReleaseCdnUrl = "https://prod-dataupdate-skyblitz.skyblitzsvc.com/";
	public const string TestCdnUrlSurvivorAceCN = "https://test-dataupdate-survivor-ace-cn.fantasyfuns.com/";
	public const string ReleaseCdnUrlSurvivorAceCN = "https://prod-dataupdate-survivor-ace-cn.fantasyfuns.com/";
	public const string TestCdnUrlXXYZDCN = "https://test-dataupdate-survivor-ace-cn.fantasyfuns.com/";
	public const string ReleaseCdnUrlXXYZDCN = "https://prod-dataupdate-xxyzd-cn.fantasyfuns.com/";
	public const string TestCdnUrlCN = "https://test-dataupdate-survivor-ace-cn.fantasyfuns.com/";
	public const string ReleaseCdnUrlCN = "https://prod-dataupdate-survivor-ace-cn.fantasyfuns.com/";
	public const string SurvivorAceChannelCN = "SurvivorAceStoreCN";
	public const string XXYZDChannelCN = "XXYZDStoreCN";
	public const string SurvivorAceAndroidApkNameCN = "SurvivorAce";
	public const string XXYZDAndroidApkNameCN = "XXYZD";
	public const string SurvivorAceAndroidApkPathCN = "package/SurvivorAce.apk";
	public const string XXYZDAndroidApkPathCN = "package/XXYZD.apk";
	public const float GamePreloadStartProgress = 0.1;
	public const uint GameProdSwitchServicesFunction = 900001;
	public const string PreReleaseServerUrl = "https://en-pre.skyblitzsvc.com";
	public const string ReleaseServerUrl = "https://en-prod1.skyblitzsvc.com";
	public const string TestServerUrl = "https://test.skyblitzsvc.com";
	public const string QA1ServerUrl = "https://en-qa1.skyblitzsvc.com";
	public const string QA2ServerUrl = "https://en-qa2.skyblitzsvc.com";
	public const string Design1ServerUrl = "https://en-design1.skyblitzsvc.com";
	public const string Review1ServerUrl = "https://en-review1.skyblitzsvc.com";
	public const string PreReleaseServerUrlCN = "https://cn-pre.fantasyfuns.com";
	public const string ReleaseServerUrlCN = "https://cn-prod.fantasyfuns.com";
	public const string TestServerUrlCN = "https://cn-test.fantasyfuns.com";
	public const string QA1ServerUrlCN = "https://cn-qa1.fantasyfuns.com";
	public const string PreReleaseCdnSwitchKey = "PreReleaseCdnSwitchKey";
	public const string InitSRDebugKey = "InitSRDebugKey";
	public const string ServerEnvKey = "ServerEnvKey";
	public const string ServerUrlOverrideKey = "ServerUrlOverrideKey";
	public const string GorillaImUrl = "wss://test-im-ws.gorillasvc.com/ws";
	public const string PreReleaseGorillaImUrl = "wss://pre-im-ws.gorillasvc.com/ws";
	public const string ReleaseGorillaImUrl = "wss://prod-im-ws.gorillasvc.com/ws";
	public const string GorillaImUrlCN = "wss://test-im-ws.dxxsvc.com/ws";
	public const string PreReleaseGorillaImUrlCN = "wss://pre-im-ws.dxxsvc.com/ws";
	public const string ReleaseGorillaImUrlCN = "wss://prod-im-ws.dxxsvc.com/ws";
	public const string CloudServerUrl = "https://gm-test-api.gorillasvc.com";
	public const string CloudServiceToken = "6rcUl+Pgt7hsxueX4q/URtO56cx9Qe1MoAHXuwBe0EI=";
	public const string CloudFeedbackUrl = "https://test-feedback.survivor-ace.com";
	public const string PreReleaseCloudServerUrl = "https://gm-api.gorillasvc.com";
	public const string PreReleaseCloudServiceToken = "69hIaMk2LuQlA7jvBOt619O56cx9Qe1MoAHXuwBe0EI=";
	public const string PreReleaseCloudFeedbackUrl = "https://feedback.survivor-ace.com";
	public const string ReleaseCloudServerUrl = "https://gm-api.gorillasvc.com";
	public const string ReleaseCloudServiceToken = "69hIaMk2LuQlA7jvBOt619O56cx9Qe1MoAHXuwBe0EI=";
	public const string ReleaseCloudFeedbackUrl = "https://feedback.survivor-ace.com";
	public const string CloudServerUrlCN = "https://gm-test-api.dxxsvc.com";
	public const string CloudServiceTokenCN = "6rcUl+Pgt7hsxueX4q/URjGOt+8bd5eKY/O1zxgFaQM=";
	public const string CloudFeedbackUrlCN = "https://test-feedback.fantasyfuns.com";
	public const string PreReleaseCloudServerUrlCN = "https://gm-api.dxxsvc.com";
	public const string PreReleaseCloudServiceTokenCN = "69hIaMk2LuQlA7jvBOt61zGOt+8bd5eKY/O1zxgFaQM=";
	public const string PreReleaseCloudFeedbackUrlCN = "https://feedback.fantasyfuns.com";
	public const string ReleaseCloudServerUrlCN = "https://gm-api.dxxsvc.com";
	public const string ReleaseCloudServiceTokenCN = "69hIaMk2LuQlA7jvBOt61zGOt+8bd5eKY/O1zxgFaQM=";
	public const string ReleaseCloudFeedbackUrlCN = "https://feedback.fantasyfuns.com";
	public const string LocalZhangbinServerUrl = "http://local-zhangbin.dxx.cld.pub:8010";
	public const string LocalHuangjieServerUrl1 = "http://local-huangjie.dxx.cld.pub:8010";
	public const string LocalHuangjieServerUrl2 = "http://local-huangjie.dxx.cld.pub:8020";
	public const string LocalHuangjieServerUrl3 = "http://local-huangjie.dxx.cld.pub:8030";
	public const string LocalHostServerUrl = "http://localHost:8010";
	public static readonly ServerInfo[] ServerList; // 0x0

	// Methods

	// RVA: 0x415DD9C Offset: 0x4159D9C VA: 0x415DD9C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameApp.<>c__DisplayClass146_0 // TypeDefIndex: 20975
{
	// Fields
	public GameApp <>4__this; // 0x10
	public float waitTime; // 0x18

	// Methods

	// RVA: 0x41616DC Offset: 0x415D6DC VA: 0x41616DC
	public void .ctor() { }

	// RVA: 0x41616E4 Offset: 0x415D6E4 VA: 0x41616E4
	internal bool <OnStartupSetting>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct GameApp.<OnRestart>d__144 : IAsyncStateMachine // TypeDefIndex: 20976
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public GameApp <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x4161740 Offset: 0x415D740 VA: 0x4161740 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x4161A48 Offset: 0x415DA48 VA: 0x4161A48 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameApp.<OnStartupSetting>d__146 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 20977
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameApp <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x416107C Offset: 0x415D07C VA: 0x416107C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x4161A54 Offset: 0x415DA54 VA: 0x4161A54 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4161A58 Offset: 0x415DA58 VA: 0x4161A58 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x4161E8C Offset: 0x415DE8C VA: 0x4161E8C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x4161E94 Offset: 0x415DE94 VA: 0x4161E94 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x4161ECC Offset: 0x415DECC VA: 0x4161ECC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Framework
public class GameApp : MonoBehaviour // TypeDefIndex: 20978
{
	// Fields
	public const int MockRoleId = 10100;
	public const int MockEntityId = 100001;
	public const int MockMissionId = 1;
	public const long MockUserId = 55555;
	public const string CombatId = "66666";
	public const int MockUserLevel = 1;
	public const int MockUserExp = 0;
	public const int MockFirstSkillCount = 0;
	public const int MockStartWave = 1;
	public const bool MockUseJoy = False;
	public static bool MockScroll; // 0x0
	[SerializeField]
	public GameAppConfigManager m_config; // 0x20
	[SerializeField]
	public EventSystemManager m_event; // 0x28
	[SerializeField]
	private DataModuleManager m_data; // 0x30
	[SerializeField]
	public CoroutineManager m_coroutine; // 0x38
	[SerializeField]
	public ViewModuleManager m_view; // 0x40
	[SerializeField]
	public StateManager m_state; // 0x48
	[SerializeField]
	public TableManager m_table; // 0x50
	[SerializeField]
	public ResourcesManager m_resources; // 0x58
	[SerializeField]
	public SceneManager m_scene; // 0x60
	[SerializeField]
	public AudioManager m_sound; // 0x68
	[SerializeField]
	public HttpManager m_http; // 0x70
	[SerializeField]
	public NetWorkManager m_netWork; // 0x78
	[SerializeField]
	public RunTimeManager m_runTime; // 0x80
	[SerializeField]
	public SDKManager m_sdk; // 0x88
	[SerializeField]
	public UnityGlobalManager m_unityGlobal; // 0x90
	[SerializeField]
	public GuildConfig m_guild; // 0x98
	[SerializeField]
	public MailManager m_mail; // 0xA0
	[SerializeField]
	public MobileNotificationHost m_mobileNotification; // 0xA8
	[SerializeField]
	public PurchaseManager m_purchase; // 0xB0
	[SerializeField]
	public PersistentDataManager m_persistentData; // 0xB8
	[SerializeField]
	private GameObject _monitor; // 0xC0
	[CompilerGenerated]
	private static GameAppConfigManager <Config>k__BackingField; // 0x8
	[CompilerGenerated]
	private static EventSystemManager <Event>k__BackingField; // 0x10
	[CompilerGenerated]
	private static DataModuleManager <Data>k__BackingField; // 0x18
	[CompilerGenerated]
	private static CoroutineManager <CoroutineSystem>k__BackingField; // 0x20
	[CompilerGenerated]
	private static ViewModuleManager <View>k__BackingField; // 0x28
	[CompilerGenerated]
	private static StateManager <State>k__BackingField; // 0x30
	[CompilerGenerated]
	private static TableManager <Table>k__BackingField; // 0x38
	[CompilerGenerated]
	private static ResourcesManager <Resources>k__BackingField; // 0x40
	[CompilerGenerated]
	private static SceneManager <Scene>k__BackingField; // 0x48
	[CompilerGenerated]
	private static AudioManager <Sound>k__BackingField; // 0x50
	[CompilerGenerated]
	private static HttpManager <Http>k__BackingField; // 0x58
	[CompilerGenerated]
	private static NetWorkManager <NetWork>k__BackingField; // 0x60
	[CompilerGenerated]
	private static RunTimeManager <RunTime>k__BackingField; // 0x68
	[CompilerGenerated]
	private static SDKManager <SDK>k__BackingField; // 0x70
	[CompilerGenerated]
	private static UnityGlobalManager <UnityGlobal>k__BackingField; // 0x78
	[CompilerGenerated]
	private static GuildConfig <GuildConfig>k__BackingField; // 0x80
	[CompilerGenerated]
	private static MailManager <Mail>k__BackingField; // 0x88
	[CompilerGenerated]
	private static MobileNotificationHost <MobileNotification>k__BackingField; // 0x90
	[CompilerGenerated]
	private static AnnouncementManager <Announcement>k__BackingField; // 0x98
	[CompilerGenerated]
	private static ISocketNet <SocketNet>k__BackingField; // 0xA0
	[CompilerGenerated]
	private static PurchaseManager <Purchase>k__BackingField; // 0xA8
	[CompilerGenerated]
	private static PersistentDataManager <PersistentData>k__BackingField; // 0xB0
	[CompilerGenerated]
	private static Camera <BaseCamera>k__BackingField; // 0xB8
	[CompilerGenerated]
	private static long <GameStartTimestamp>k__BackingField; // 0xC0
	private static long _lastPhaseTimestamp; // 0xC8
	private static int m_pauseCount; // 0xD0
	private static float m_timeScale; // 0xD4

	// Properties
	public static GameAppConfigManager Config { get; set; }
	public static EventSystemManager Event { get; set; }
	public static DataModuleManager Data { get; set; }
	public static CoroutineManager CoroutineSystem { get; set; }
	public static ViewModuleManager View { get; set; }
	public static StateManager State { get; set; }
	public static TableManager Table { get; set; }
	public static ResourcesManager Resources { get; set; }
	public static SceneManager Scene { get; set; }
	public static AudioManager Sound { get; set; }
	public static HttpManager Http { get; set; }
	public static NetWorkManager NetWork { get; set; }
	public static RunTimeManager RunTime { get; set; }
	public static SDKManager SDK { get; set; }
	public static UnityGlobalManager UnityGlobal { get; set; }
	public static GuildConfig GuildConfig { get; set; }
	public static MailManager Mail { get; set; }
	public static MobileNotificationHost MobileNotification { get; set; }
	public static AnnouncementManager Announcement { get; set; }
	public static ISocketNet SocketNet { get; set; }
	public static PurchaseManager Purchase { get; set; }
	public static PersistentDataManager PersistentData { get; set; }
	public static Camera BaseCamera { get; set; }
	public static long GameStartTimestamp { get; set; }
	public static bool IsPause { get; }
	public static float TimeScale { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x415E534 Offset: 0x415A534 VA: 0x415E534
	public static GameAppConfigManager get_Config() { }

	[CompilerGenerated]
	// RVA: 0x415E58C Offset: 0x415A58C VA: 0x415E58C
	private static void set_Config(GameAppConfigManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E5EC Offset: 0x415A5EC VA: 0x415E5EC
	public static EventSystemManager get_Event() { }

	[CompilerGenerated]
	// RVA: 0x415E644 Offset: 0x415A644 VA: 0x415E644
	private static void set_Event(EventSystemManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E6A4 Offset: 0x415A6A4 VA: 0x415E6A4
	public static DataModuleManager get_Data() { }

	[CompilerGenerated]
	// RVA: 0x415E6FC Offset: 0x415A6FC VA: 0x415E6FC
	private static void set_Data(DataModuleManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E75C Offset: 0x415A75C VA: 0x415E75C
	public static CoroutineManager get_CoroutineSystem() { }

	[CompilerGenerated]
	// RVA: 0x415E7B4 Offset: 0x415A7B4 VA: 0x415E7B4
	private static void set_CoroutineSystem(CoroutineManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E814 Offset: 0x415A814 VA: 0x415E814
	public static ViewModuleManager get_View() { }

	[CompilerGenerated]
	// RVA: 0x415E86C Offset: 0x415A86C VA: 0x415E86C
	private static void set_View(ViewModuleManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E8CC Offset: 0x415A8CC VA: 0x415E8CC
	public static StateManager get_State() { }

	[CompilerGenerated]
	// RVA: 0x415E924 Offset: 0x415A924 VA: 0x415E924
	private static void set_State(StateManager value) { }

	[CompilerGenerated]
	// RVA: 0x415E984 Offset: 0x415A984 VA: 0x415E984
	public static TableManager get_Table() { }

	[CompilerGenerated]
	// RVA: 0x415E9DC Offset: 0x415A9DC VA: 0x415E9DC
	private static void set_Table(TableManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EA3C Offset: 0x415AA3C VA: 0x415EA3C
	public static ResourcesManager get_Resources() { }

	[CompilerGenerated]
	// RVA: 0x415EA94 Offset: 0x415AA94 VA: 0x415EA94
	private static void set_Resources(ResourcesManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EAF4 Offset: 0x415AAF4 VA: 0x415EAF4
	public static SceneManager get_Scene() { }

	[CompilerGenerated]
	// RVA: 0x415EB4C Offset: 0x415AB4C VA: 0x415EB4C
	private static void set_Scene(SceneManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EBAC Offset: 0x415ABAC VA: 0x415EBAC
	public static AudioManager get_Sound() { }

	[CompilerGenerated]
	// RVA: 0x415EC04 Offset: 0x415AC04 VA: 0x415EC04
	public static void set_Sound(AudioManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EC64 Offset: 0x415AC64 VA: 0x415EC64
	public static HttpManager get_Http() { }

	[CompilerGenerated]
	// RVA: 0x415ECBC Offset: 0x415ACBC VA: 0x415ECBC
	public static void set_Http(HttpManager value) { }

	[CompilerGenerated]
	// RVA: 0x415ED1C Offset: 0x415AD1C VA: 0x415ED1C
	public static NetWorkManager get_NetWork() { }

	[CompilerGenerated]
	// RVA: 0x415ED74 Offset: 0x415AD74 VA: 0x415ED74
	public static void set_NetWork(NetWorkManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EDD4 Offset: 0x415ADD4 VA: 0x415EDD4
	public static RunTimeManager get_RunTime() { }

	[CompilerGenerated]
	// RVA: 0x415EE2C Offset: 0x415AE2C VA: 0x415EE2C
	private static void set_RunTime(RunTimeManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EE8C Offset: 0x415AE8C VA: 0x415EE8C
	public static SDKManager get_SDK() { }

	[CompilerGenerated]
	// RVA: 0x415EEE4 Offset: 0x415AEE4 VA: 0x415EEE4
	private static void set_SDK(SDKManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EF44 Offset: 0x415AF44 VA: 0x415EF44
	public static UnityGlobalManager get_UnityGlobal() { }

	[CompilerGenerated]
	// RVA: 0x415EF9C Offset: 0x415AF9C VA: 0x415EF9C
	private static void set_UnityGlobal(UnityGlobalManager value) { }

	[CompilerGenerated]
	// RVA: 0x415EFFC Offset: 0x415AFFC VA: 0x415EFFC
	public static GuildConfig get_GuildConfig() { }

	[CompilerGenerated]
	// RVA: 0x415F054 Offset: 0x415B054 VA: 0x415F054
	private static void set_GuildConfig(GuildConfig value) { }

	[CompilerGenerated]
	// RVA: 0x415F0B4 Offset: 0x415B0B4 VA: 0x415F0B4
	public static MailManager get_Mail() { }

	[CompilerGenerated]
	// RVA: 0x415F10C Offset: 0x415B10C VA: 0x415F10C
	private static void set_Mail(MailManager value) { }

	[CompilerGenerated]
	// RVA: 0x415F16C Offset: 0x415B16C VA: 0x415F16C
	public static MobileNotificationHost get_MobileNotification() { }

	[CompilerGenerated]
	// RVA: 0x415F1C4 Offset: 0x415B1C4 VA: 0x415F1C4
	private static void set_MobileNotification(MobileNotificationHost value) { }

	[CompilerGenerated]
	// RVA: 0x415F224 Offset: 0x415B224 VA: 0x415F224
	public static AnnouncementManager get_Announcement() { }

	[CompilerGenerated]
	// RVA: 0x415F27C Offset: 0x415B27C VA: 0x415F27C
	private static void set_Announcement(AnnouncementManager value) { }

	[CompilerGenerated]
	// RVA: 0x415F2DC Offset: 0x415B2DC VA: 0x415F2DC
	public static ISocketNet get_SocketNet() { }

	[CompilerGenerated]
	// RVA: 0x415F334 Offset: 0x415B334 VA: 0x415F334
	private static void set_SocketNet(ISocketNet value) { }

	[CompilerGenerated]
	// RVA: 0x415F394 Offset: 0x415B394 VA: 0x415F394
	public static PurchaseManager get_Purchase() { }

	[CompilerGenerated]
	// RVA: 0x415F3EC Offset: 0x415B3EC VA: 0x415F3EC
	private static void set_Purchase(PurchaseManager value) { }

	[CompilerGenerated]
	// RVA: 0x415F44C Offset: 0x415B44C VA: 0x415F44C
	public static PersistentDataManager get_PersistentData() { }

	[CompilerGenerated]
	// RVA: 0x415F4A4 Offset: 0x415B4A4 VA: 0x415F4A4
	private static void set_PersistentData(PersistentDataManager value) { }

	[CompilerGenerated]
	// RVA: 0x415F504 Offset: 0x415B504 VA: 0x415F504
	public static Camera get_BaseCamera() { }

	[CompilerGenerated]
	// RVA: 0x415F55C Offset: 0x415B55C VA: 0x415F55C
	private static void set_BaseCamera(Camera value) { }

	[CompilerGenerated]
	// RVA: 0x415F5BC Offset: 0x415B5BC VA: 0x415F5BC
	public static long get_GameStartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x415F614 Offset: 0x415B614 VA: 0x415F614
	private static void set_GameStartTimestamp(long value) { }

	// RVA: 0x415F670 Offset: 0x415B670 VA: 0x415F670
	public static void LogStartupPhase(string phase) { }

	// RVA: 0x415F7BC Offset: 0x415B7BC VA: 0x415F7BC
	public static bool get_IsPause() { }

	// RVA: 0x415F81C Offset: 0x415B81C VA: 0x415F81C
	public static float get_TimeScale() { }

	// RVA: 0x415F874 Offset: 0x415B874 VA: 0x415F874
	private static void set_TimeScale(float value) { }

	// RVA: 0x415F8D8 Offset: 0x415B8D8 VA: 0x415F8D8
	public void OnStarUp() { }

	// RVA: 0x4160760 Offset: 0x415C760 VA: 0x4160760
	public void OnUpdate() { }

	// RVA: 0x41609A0 Offset: 0x415C9A0 VA: 0x41609A0
	public void OnLateUpdate() { }

	// RVA: 0x4160AAC Offset: 0x415CAAC VA: 0x4160AAC
	public void OnFixedUpdate() { }

	// RVA: 0x4160B40 Offset: 0x415CB40 VA: 0x4160B40
	public void OnAppShutdown() { }

	// RVA: 0x4160E84 Offset: 0x415CE84 VA: 0x4160E84
	public void OnAppFocus(bool hasFocus) { }

	// RVA: 0x4160EA4 Offset: 0x415CEA4 VA: 0x4160EA4
	public void OnAppPause(bool pauseStatus) { }

	[AsyncStateMachine(typeof(GameApp.<OnRestart>d__144))]
	// RVA: 0x4160EC4 Offset: 0x415CEC4 VA: 0x4160EC4
	public void OnRestart() { }

	// RVA: 0x41602DC Offset: 0x415C2DC VA: 0x41602DC
	private void setNetworkUsing() { }

	[IteratorStateMachine(typeof(GameApp.<OnStartupSetting>d__146))]
	// RVA: 0x41606F4 Offset: 0x415C6F4 VA: 0x41606F4
	private IEnumerator OnStartupSetting() { }

	// RVA: 0x41610A4 Offset: 0x415D0A4 VA: 0x41610A4
	private void TryPreSDKLogin() { }

	// RVA: 0x41604AC Offset: 0x415C4AC VA: 0x41604AC
	private static void RegisterAllMessage(EventSystemManager events) { }

	// RVA: 0x41604B0 Offset: 0x415C4B0 VA: 0x41604B0
	private static void RegisterAllDataModules(DataModuleManager datas) { }

	// RVA: 0x4160518 Offset: 0x415C518 VA: 0x4160518
	private static void RegisterAllViewModules(ViewModuleManager views) { }

	// RVA: 0x416068C Offset: 0x415C68C VA: 0x416068C
	private static void RegisterAllStates(StateManager states) { }

	// RVA: 0x4161298 Offset: 0x415D298 VA: 0x4161298
	public static void SetTimeScale(float value) { }

	// RVA: 0x416141C Offset: 0x415D41C VA: 0x416141C
	public static void SetTimeScaleSafe(float value) { }

	// RVA: 0x4161510 Offset: 0x415D510 VA: 0x4161510
	public static void SetPause(bool value) { }

	// RVA: 0x4161618 Offset: 0x415D618 VA: 0x4161618
	public static void Quit() { }

	// RVA: 0x4161668 Offset: 0x415D668 VA: 0x4161668
	public void .ctor() { }

	// RVA: 0x4161670 Offset: 0x415D670 VA: 0x4161670
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x41616C4 Offset: 0x415D6C4 VA: 0x41616C4
	private void <OnRestart>b__144_0(AsyncOperation s) { }
}

// Namespace: Framework
public class GameLauncher : MonoBehaviour // TypeDefIndex: 20979
{
	// Fields
	[SerializeField]
	private GameApp m_gameApp; // 0x20
	[Header("Language Setting")]
	public bool m_isReadyLanguage; // 0x28
	public LanguageType m_languageType; // 0x2C
	[Header("Log Setting")]
	public bool m_enableULog; // 0x30
	public bool m_enableHLog; // 0x31
	public static GameLauncher Builder; // 0x0

	// Methods

	// RVA: 0x4161ED4 Offset: 0x415DED4 VA: 0x4161ED4
	private void Awake() { }

	// RVA: 0x41620E0 Offset: 0x415E0E0 VA: 0x41620E0
	private void Update() { }

	// RVA: 0x41620F8 Offset: 0x415E0F8 VA: 0x41620F8
	private void LateUpdate() { }

	// RVA: 0x4162110 Offset: 0x415E110 VA: 0x4162110
	private void FixedUpdate() { }

	// RVA: 0x4162128 Offset: 0x415E128 VA: 0x4162128
	private void OnApplicationQuit() { }

	// RVA: 0x4162154 Offset: 0x415E154 VA: 0x4162154
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x416217C Offset: 0x415E17C VA: 0x416217C
	private void OnApplicationPause(bool pauseStatus) { }

	[ContextMenu("OnShutdown")]
	// RVA: 0x41621A4 Offset: 0x415E1A4 VA: 0x41621A4
	public void OnShutdown() { }

	[ContextMenu("OnRestart")]
	// RVA: 0x41621BC Offset: 0x415E1BC VA: 0x41621BC
	public void OnRestart() { }

	// RVA: 0x41621D4 Offset: 0x415E1D4 VA: 0x41621D4
	public void .ctor() { }
}

// Namespace: Framework
[Usage(12)]
public class RuntimeCustomSerializedPropertyAttribute : RuntimeDefaultSerializedPropertyAttribute // TypeDefIndex: 20980
{
	// Fields
	public string TypeFullName; // 0x10

	// Methods

	// RVA: 0x41621E4 Offset: 0x415E1E4 VA: 0x41621E4
	public void .ctor(string typeFullName) { }
}

// Namespace: Framework
[Usage(12)]
public class RuntimeDefaultSerializedPropertyAttribute : Attribute // TypeDefIndex: 20981
{
	// Methods

	// RVA: 0x4162214 Offset: 0x415E214 VA: 0x4162214
	public void .ctor() { }
}

// Namespace: 
public static class Utility.File // TypeDefIndex: 20982
{
	// Methods

	// RVA: 0x41632C8 Offset: 0x415F2C8 VA: 0x41632C8
	public static string ReadAllText(string path) { }

	// RVA: 0x4163428 Offset: 0x415F428 VA: 0x4163428
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x4163544 Offset: 0x415F544 VA: 0x4163544
	public static void CreateDirectory(string path) { }

	// RVA: 0x4163704 Offset: 0x415F704 VA: 0x4163704
	public static void CopyDirectory(string from, string to) { }

	// RVA: 0x4163CF8 Offset: 0x415FCF8 VA: 0x4163CF8
	public static void MoveFile(string from, string to) { }

	// RVA: 0x4163EE8 Offset: 0x415FEE8 VA: 0x4163EE8
	public static void CopyFile(string from, string to) { }

	// RVA: 0x41640EC Offset: 0x41600EC VA: 0x41640EC
	public static void WriteAllBytes(string path, string info, Encoding enconding) { }

	// RVA: 0x4164230 Offset: 0x4160230 VA: 0x4164230
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x4164374 Offset: 0x4160374 VA: 0x4164374
	public static void WriteAllText(string path, string info) { }

	// RVA: 0x41644B8 Offset: 0x41604B8 VA: 0x41644B8
	public static void WriteAllText(string path, string info, Encoding encoding) { }

	// RVA: 0x41645FC Offset: 0x41605FC VA: 0x41645FC
	public static void DeleteDirectory(string path) { }

	// RVA: 0x4163BE4 Offset: 0x415FBE4 VA: 0x4163BE4
	public static void DeleteFile(string path) { }

	// RVA: 0x416493C Offset: 0x416093C VA: 0x416493C
	public static void DeleteFile(string[] paths) { }

	// RVA: 0x4164A80 Offset: 0x4160A80 VA: 0x4164A80
	public static void DeleteFiles(string directoryName, string[] searchPatterns) { }

	// RVA: 0x4164C30 Offset: 0x4160C30 VA: 0x4164C30
	private static List<FileInfo> GetFiles(string directoryName, string[] searchPatterns) { }

	// RVA: 0x4164DE4 Offset: 0x4160DE4 VA: 0x4164DE4
	public static long GetLength(string path) { }

	// RVA: 0x4164E4C Offset: 0x4160E4C VA: 0x4164E4C
	public static byte[] GetBytesByString(string info) { }

	// RVA: 0x4164E7C Offset: 0x4160E7C VA: 0x4164E7C
	public static string GetStringByBytes(byte[] bytes) { }

	// RVA: 0x4164EAC Offset: 0x4160EAC VA: 0x4164EAC
	public static string GetMD5String(byte[] bytes) { }
}

// Namespace: 
public static class Utility.Math // TypeDefIndex: 20983
{
	// Methods

	// RVA: 0x4164FB4 Offset: 0x4160FB4 VA: 0x4164FB4
	public static int CeilToInt(float value) { }

	// RVA: 0x4165020 Offset: 0x4161020 VA: 0x4165020
	public static int FloorToInt(float value) { }

	// RVA: 0x416508C Offset: 0x416108C VA: 0x416508C
	public static int CeilBig(float value) { }

	// RVA: 0x4165104 Offset: 0x4161104 VA: 0x4165104
	public static int GetSymbol(float value) { }

	// RVA: 0x4165114 Offset: 0x4161114 VA: 0x4165114
	public static int GetSymbol(int value) { }

	// RVA: 0x4165124 Offset: 0x4161124 VA: 0x4165124
	public static int GetSymbol(long value) { }

	// RVA: 0x4165134 Offset: 0x4161134 VA: 0x4165134
	public static int GetSymbol(string s) { }

	// RVA: 0x41651B8 Offset: 0x41611B8 VA: 0x41651B8
	public static string GetSymbolString(long value) { }

	// RVA: 0x4165220 Offset: 0x4161220 VA: 0x4165220
	public static string GetSymbolString(float value) { }

	// RVA: 0x4165288 Offset: 0x4161288 VA: 0x4165288
	public static float Sin(float angle) { }

	// RVA: 0x41652A4 Offset: 0x41612A4 VA: 0x41652A4
	public static float Cos(float angle) { }

	// RVA: 0x41652C0 Offset: 0x41612C0 VA: 0x41652C0
	public static int Abs(int value) { }

	// RVA: 0x4165318 Offset: 0x4161318 VA: 0x4165318
	public static float Abs(float value) { }

	// RVA: 0x4165320 Offset: 0x4161320 VA: 0x4165320
	public static long Abs(long value) { }

	// RVA: 0x416532C Offset: 0x416132C VA: 0x416532C
	public static float MoveTowardsAngle(float current, float target, float maxDelta) { }

	// RVA: 0x41653B0 Offset: 0x41613B0 VA: 0x41653B0
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x41653C4 Offset: 0x41613C4 VA: 0x41653C4
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x41653D8 Offset: 0x41613D8 VA: 0x41653D8
	public static long Clamp(long value, long min, long max) { }

	// RVA: 0x41653F4 Offset: 0x41613F4 VA: 0x41653F4
	public static Vector3 Clamp(Vector3 value, float min, float max) { }

	// RVA: 0x4165428 Offset: 0x4161428 VA: 0x4165428
	public static float Clamp01(float value) { }

	// RVA: 0x4165440 Offset: 0x4161440 VA: 0x4165440
	public static float Pow(float f, float p) { }

	// RVA: 0x4165444 Offset: 0x4161444 VA: 0x4165444
	public static int Random(int min, int max) { }

	// RVA: 0x416544C Offset: 0x416144C VA: 0x416544C
	public static float Random(float min, float max) { }

	// RVA: 0x4165454 Offset: 0x4161454 VA: 0x4165454
	public static int RandomSymbol() { }

	// RVA: 0x416547C Offset: 0x416147C VA: 0x416547C
	public static bool RandomBool() { }

	// RVA: 0x41654A0 Offset: 0x41614A0 VA: 0x41654A0
	public static int RoundToInt(float value) { }

	// RVA: 0x416557C Offset: 0x416157C VA: 0x416557C
	public static float Min(float a, float b) { }

	// RVA: 0x4165588 Offset: 0x4161588 VA: 0x4165588
	public static int Min(int a, int b) { }

	// RVA: 0x4165594 Offset: 0x4161594 VA: 0x4165594
	public static long Min(long a, long b) { }

	// RVA: 0x41655A0 Offset: 0x41615A0 VA: 0x41655A0
	public static float Max(float a, float b) { }

	// RVA: 0x41655AC Offset: 0x41615AC VA: 0x41655AC
	public static int Max(int a, int b) { }

	// RVA: 0x41655B8 Offset: 0x41615B8 VA: 0x41655B8
	public static long Max(long a, long b) { }

	// RVA: 0x41655C4 Offset: 0x41615C4 VA: 0x41655C4
	public static Color RandomColor() { }

	// RVA: 0x4165620 Offset: 0x4161620 VA: 0x4165620
	public static int GetLine(int count, int lineCount) { }

	// RVA: 0x416574C Offset: 0x416174C VA: 0x416574C
	public static float GetFloat1(float f) { }

	// RVA: 0x416577C Offset: 0x416177C VA: 0x416577C
	public static float GetFloat2(float f) { }

	// RVA: 0x41657B0 Offset: 0x41617B0 VA: 0x41657B0
	public static float GetFloat3(float f) { }

	// RVA: 0x41657E4 Offset: 0x41617E4 VA: 0x41657E4
	public static string GetTime3String(long second) { }

	// RVA: 0x4165904 Offset: 0x4161904 VA: 0x4165904
	public static string GetTime2String(long second) { }

	// RVA: 0x41659C4 Offset: 0x41619C4 VA: 0x41659C4
	public static Vector3 GetDirection(float angle) { }
}

// Namespace: 
public static class Utility.PlayerPrefs // TypeDefIndex: 20984
{
	// Fields
	private static bool m_enable; // 0x0
	private static string m_userId; // 0x8

	// Methods

	// RVA: 0x41659FC Offset: 0x41619FC VA: 0x41659FC
	public static void DeleteAll() { }

	// RVA: 0x4165A68 Offset: 0x4161A68 VA: 0x4165A68
	public static void DeleteKey(string key) { }

	// RVA: 0x4165ADC Offset: 0x4161ADC VA: 0x4165ADC
	public static float GetFloat(string key) { }

	// RVA: 0x4165B54 Offset: 0x4161B54 VA: 0x4165B54
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x4165BE0 Offset: 0x4161BE0 VA: 0x4165BE0
	public static int GetInt(string key) { }

	// RVA: 0x4160FF0 Offset: 0x415CFF0 VA: 0x4160FF0
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x4165C58 Offset: 0x4161C58 VA: 0x4165C58
	public static string GetString(string key) { }

	// RVA: 0x4165CEC Offset: 0x4161CEC VA: 0x4165CEC
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x4160F78 Offset: 0x415CF78 VA: 0x4160F78
	public static bool HasKey(string key) { }

	// RVA: 0x4165D94 Offset: 0x4161D94 VA: 0x4165D94
	public static void SetFloat(string key, float value) { }

	// RVA: 0x4165E24 Offset: 0x4161E24 VA: 0x4165E24
	public static void SetInt(string key, int value) { }

	// RVA: 0x4165EB4 Offset: 0x4161EB4 VA: 0x4165EB4
	public static void SetString(string key, string value) { }

	// RVA: 0x4165F44 Offset: 0x4161F44 VA: 0x4165F44
	public static void SetBool(string key, bool value) { }

	// RVA: 0x415D2C0 Offset: 0x41592C0 VA: 0x415D2C0
	public static bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x4165FD8 Offset: 0x4161FD8 VA: 0x4165FD8
	private static string getUserKey(string key) { }

	// RVA: 0x4166054 Offset: 0x4162054 VA: 0x4166054
	public static void SetUserId(string id) { }

	// RVA: 0x41660E0 Offset: 0x41620E0 VA: 0x41660E0
	public static bool HasUserKey(string key) { }

	// RVA: 0x4166164 Offset: 0x4162164 VA: 0x4166164
	public static void SetUserInt(string key, int value) { }

	// RVA: 0x41661F8 Offset: 0x41621F8 VA: 0x41661F8
	public static int GetUserInt(string key, int defaultValue) { }

	// RVA: 0x4166290 Offset: 0x4162290 VA: 0x4166290
	public static void SetUserFloat(string key, float value) { }

	// RVA: 0x4166324 Offset: 0x4162324 VA: 0x4166324
	public static float GetUserFloat(string key, float defaultValue) { }

	// RVA: 0x41663BC Offset: 0x41623BC VA: 0x41663BC
	public static void SetUserBool(string key, bool value) { }

	// RVA: 0x416646C Offset: 0x416246C VA: 0x416646C
	public static bool GetUserBool(string key, bool defaultValue) { }

	// RVA: 0x4166504 Offset: 0x4162504 VA: 0x4166504
	public static void SetUserString(string key, string value) { }

	// RVA: 0x4166598 Offset: 0x4162598 VA: 0x4166598
	public static string GetUserString(string key, string defaultValue) { }

	// RVA: 0x4166630 Offset: 0x4162630 VA: 0x4166630
	public static void DeleteUserKey(string key) { }

	// RVA: 0x41666B0 Offset: 0x41626B0 VA: 0x41666B0
	private static void .cctor() { }
}

// Namespace: 
public static class Utility.UI // TypeDefIndex: 20985
{
	// Fields
	public static int Width; // 0x0
	public static int Height; // 0x4
	public static int ScreenWidth; // 0x8
	public static int ScreenHeight; // 0xC
	public static int DesignWidth; // 0x10
	public static int DesignHeight; // 0x14
	public static float ScreenRatio; // 0x18
	public static Vector2 UISize; // 0x1C
	private static Vector2 m_windowSize; // 0x24
	public const string ATLAS_COMMON = "uicommonhot";
	public const string ATLAS_EQUIP = "uiequipshot";
	private static readonly Vector3[] moveUIInScreenUiCorners; // 0x30

	// Properties
	public static bool IsScreenLong { get; }

	// Methods

	// RVA: 0x4166718 Offset: 0x4162718 VA: 0x4166718
	public static Vector2 GetWindowSize() { }

	// RVA: 0x41667DC Offset: 0x41627DC VA: 0x41667DC
	public static float GetAddHeight() { }

	// RVA: 0x4166828 Offset: 0x4162828 VA: 0x4166828
	public static bool get_IsScreenLong() { }

	// RVA: 0x4166890 Offset: 0x4162890 VA: 0x4166890
	public static Vector2 GetUISize() { }

	// RVA: 0x41669BC Offset: 0x41629BC VA: 0x41669BC
	public static Vector2 ScreenPosToUIPos(Vector2 pos) { }

	// RVA: 0x4166A50 Offset: 0x4162A50 VA: 0x4166A50
	public static Vector2 WorldPos2UIPos(Vector3 pos) { }

	// RVA: 0x4166BAC Offset: 0x4162BAC VA: 0x4166BAC
	public static Vector2 World2Screen(Vector3 worldPosition, Camera camera) { }

	// RVA: 0x4166AC8 Offset: 0x4162AC8 VA: 0x4166AC8
	public static Vector2 World2Screen(Vector3 worldPosition) { }

	// RVA: 0x4166C5C Offset: 0x4162C5C VA: 0x4166C5C
	public static Vector2 WorldToUILocalPos(Vector3 worldPosition, RectTransform parent) { }

	// RVA: 0x4166DC4 Offset: 0x4162DC4 VA: 0x4166DC4
	public static void GetSprite(string atlasName, string spriteName, Action<Sprite> onFinish) { }

	// RVA: 0x4166DC8 Offset: 0x4162DC8 VA: 0x4166DC8
	public static void MoveUIInScreen(RectTransform targetTran, Vector2 offset, Vector2 padding) { }

	// RVA: 0x41670F0 Offset: 0x41630F0 VA: 0x41670F0
	private static bool CalculateInScreenPos(float offsetValue, float originValue, float cornersMin, float cornersMax, float screenValue, float paddingValue, out float endValue) { }

	// RVA: 0x4167180 Offset: 0x4163180 VA: 0x4167180
	private static void .cctor() { }
}

// Namespace: Framework.Logic
[Extension]
public static class Utility // TypeDefIndex: 20986
{
	// Methods

	[Extension]
	// RVA: 0x416221C Offset: 0x415E21C VA: 0x416221C
	public static string GetFourPaddingString(RectTransform t) { }

	[Extension]
	// RVA: 0x4162420 Offset: 0x415E420 VA: 0x4162420
	public static void SetLeft(RectTransform t, float value) { }

	[Extension]
	// RVA: 0x4162458 Offset: 0x415E458 VA: 0x4162458
	public static void SetRight(RectTransform t, float value) { }

	[Extension]
	// RVA: 0x4162490 Offset: 0x415E490 VA: 0x4162490
	public static void SetTop(RectTransform t, float value) { }

	[Extension]
	// RVA: 0x41624C8 Offset: 0x415E4C8 VA: 0x41624C8
	public static void SetBottom(RectTransform t, float value) { }

	[Extension]
	// RVA: 0x4162500 Offset: 0x415E500 VA: 0x4162500
	public static void SetForPadding(RectTransform t) { }

	// RVA: 0x41627A8 Offset: 0x415E7A8 VA: 0x41627A8
	private static float GetTopHeight() { }

	// RVA: 0x41627F4 Offset: 0x415E7F4 VA: 0x41627F4
	private static float GetBottomHeight() { }

	[Extension]
	// RVA: 0x416280C Offset: 0x415E80C VA: 0x416280C
	public static void SetFourPadding(RectTransform t, float left, float right, float top, float bottom) { }

	[Extension]
	// RVA: 0x4162850 Offset: 0x415E850 VA: 0x4162850
	public static float GetTop(RectTransform t) { }

	[Extension]
	// RVA: 0x4162870 Offset: 0x415E870 VA: 0x4162870
	public static float GetBottom(RectTransform t) { }

	[Extension]
	// RVA: 0x4162890 Offset: 0x415E890 VA: 0x4162890
	public static float GetLeft(RectTransform t) { }

	[Extension]
	// RVA: 0x41628A4 Offset: 0x415E8A4 VA: 0x41628A4
	public static float GetRight(RectTransform t) { }

	// RVA: 0x41628C4 Offset: 0x415E8C4 VA: 0x41628C4
	public static string GetSecond2String(int second) { }

	[Extension]
	// RVA: 0x4162988 Offset: 0x415E988 VA: 0x4162988
	public static Transform FindDeepChild(Transform parent, string childName, bool onlyActive = False) { }

	[Extension]
	// RVA: 0x4162DC4 Offset: 0x415EDC4 VA: 0x4162DC4
	public static Transform[] FindDeepChildren(Transform parent, string childName, bool onlyActive = False) { }
}

// Namespace: Framework.Logic.XNode
public class ChineseLabelAttribute : HeaderAttribute // TypeDefIndex: 20987
{
	// Methods

	// RVA: 0x4167270 Offset: 0x4163270 VA: 0x4167270
	public void .ctor(string header) { }
}

// Namespace: Framework.Logic.XNode
public class EnumLabelAttribute : HeaderAttribute // TypeDefIndex: 20988
{
	// Methods

	// RVA: 0x4167278 Offset: 0x4163278 VA: 0x4167278
	public void .ctor(string header) { }
}

// Namespace: Framework.Logic.XNode
[NodeTint(161, 85, 78)]
public class GameEventBattleNode : Node // TypeDefIndex: 20989
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	[Output(0, 0, 0, False)]
	public Empty exit; // 0x38
	public int specifiedId; // 0x40

	// Methods

	// RVA: 0x4167280 Offset: 0x4163280 VA: 0x4167280 Slot: 4
	protected override void Init() { }

	// RVA: 0x4167288 Offset: 0x4163288 VA: 0x4167288 Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x4167290 Offset: 0x4163290 VA: 0x4167290
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
[NodeTint(78, 161, 89)]
public class GameEventBoxNode : Node // TypeDefIndex: 20990
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30

	// Methods

	// RVA: 0x4167298 Offset: 0x4163298 VA: 0x4167298 Slot: 4
	protected override void Init() { }

	// RVA: 0x41672A0 Offset: 0x41632A0 VA: 0x41672A0 Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x41672A8 Offset: 0x41632A8 VA: 0x41672A8
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
[CreateAssetMenu(fileName = "New Event Graph", menuName = "战斗事件/创建新事件")]
public class GameEventGraph : NodeGraph // TypeDefIndex: 20991
{
	// Methods

	// RVA: 0x41672B0 Offset: 0x41632B0 VA: 0x41672B0
	public Node GetRootNode() { }

	// RVA: 0x41673EC Offset: 0x41633EC VA: 0x41673EC
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
public enum IFEnum // TypeDefIndex: 20992
{
	// Fields
	public int value__; // 0x0
	public const IFEnum WEIGHT = 0;
	public const IFEnum ATK = 1;
	public const IFEnum DEF = 2;
	public const IFEnum RHP = 3;
	public const IFEnum HP = 4;
	public const IFEnum EXP_LV = 5;
	public const IFEnum SHELL = 6;
	public const IFEnum HAS_SKILL = 7;
}

// Namespace: Framework.Logic.XNode
public enum OPEnum // TypeDefIndex: 20993
{
	// Fields
	public int value__; // 0x0
	public const OPEnum GREATER = 0;
	public const OPEnum LESS = 1;
}

// Namespace: Framework.Logic.XNode
[NodeTint("#846244")]
public class GameEventIFNode : Node // TypeDefIndex: 20994
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	[Output(0, 0, 0, False)]
	public bool ifTrue; // 0x38
	[Output(0, 0, 0, False)]
	public bool ifFalse; // 0x39
	public IFEnum ifType; // 0x3C
	public OPEnum opType; // 0x40
	public float num; // 0x44

	// Methods

	// RVA: 0x41673F4 Offset: 0x41633F4 VA: 0x41673F4 Slot: 4
	protected override void Init() { }

	// RVA: 0x41673FC Offset: 0x41633FC VA: 0x41673FC Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x4167404 Offset: 0x4163404 VA: 0x4167404
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
public enum AttEnum // TypeDefIndex: 20995
{
	// Fields
	public int value__; // 0x0
	[Header("攻击")]
	public const AttEnum Attack = 0;
	[Header("攻击百分比-累乘")]
	public const AttEnum AttackMul = 1;
	[Header("血量")]
	public const AttEnum Rhp = 2;
	[Header("血量百分比")]
	public const AttEnum RhpRate = 3;
	[Header("血上限")]
	public const AttEnum Hp = 4;
	[Header("血上限百分比-累乘")]
	public const AttEnum HpMul = 5;
	[Header("经验")]
	public const AttEnum Exp = 6;
	[Header("贝壳")]
	public const AttEnum Shell = 7;
	[Header("技能")]
	public const AttEnum Skill = 8;
	[Header("防御")]
	public const AttEnum Defense = 9;
	[Header("防御百分比-累乘")]
	public const AttEnum DefenseMul = 10;
	[Header("玩家金币")]
	public const AttEnum PlayerCoin = 11;
	[Header("营地回复血量百分百")]
	public const AttEnum CampHpRate = 12;
	[Header("攻击百分比-累加")]
	public const AttEnum AttackRate = 13;
	[Header("血上限百分比-累加")]
	public const AttEnum HPMaxRate = 14;
	[Header("防御百分比-累加")]
	public const AttEnum DefenceRate = 15;
}

// Namespace: Framework.Logic.XNode
public enum NPCOption // TypeDefIndex: 20996
{
	// Fields
	public int value__; // 0x0
	public const NPCOption None = 0;
	public const NPCOption AddNpc = 1;
	public const NPCOption RemoveNpc = 2;
	public const NPCOption RandomBox = 3;
	public const NPCOption FixedBox = 4;
}

// Namespace: Framework.Logic.XNode
[Serializable]
public class Empty // TypeDefIndex: 20997
{
	// Methods

	// RVA: 0x416740C Offset: 0x416340C VA: 0x416740C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct GameEventNormalNode.AttStruct // TypeDefIndex: 20998
{
	// Fields
	public AttEnum type; // 0x0
	public float num; // 0x4
}

// Namespace: Framework.Logic.XNode
public class GameEventNormalNode : Node // TypeDefIndex: 20999
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	[Output(0, 0, 0, False)]
	public Empty exit; // 0x38
	public int languageId; // 0x40
	[TextArea]
	public string info; // 0x48
	public NPCOption npcOption; // 0x50
	public int npcId; // 0x54
	[Output(0, 0, 0, False, dynamicPortList = True)]
	public GameEventNormalNode.AttStruct[] elements; // 0x58

	// Methods

	// RVA: 0x4167414 Offset: 0x4163414 VA: 0x4167414 Slot: 4
	protected override void Init() { }

	// RVA: 0x416741C Offset: 0x416341C VA: 0x416741C Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x4167424 Offset: 0x4163424 VA: 0x4167424
	public string GetAtt() { }

	// RVA: 0x4167698 Offset: 0x4163698 VA: 0x4167698
	private string GetChinese(AttEnum type) { }

	// RVA: 0x4167760 Offset: 0x4163760 VA: 0x4167760
	private bool IsRate(AttEnum type) { }

	// RVA: 0x4167784 Offset: 0x4163784 VA: 0x4167784
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
public enum ButtonEnum // TypeDefIndex: 21000
{
	// Fields
	public int value__; // 0x0
	public const ButtonEnum NORMAL = 0;
	public const ButtonEnum BUY = 1;
}

// Namespace: Framework.Logic.XNode
[NodeTint(80, 116, 162)]
public class GameEventSelectNode : Node // TypeDefIndex: 21001
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	[Output(0, 0, 0, False)]
	public Empty exit; // 0x38
	public int languageId; // 0x40
	[TextArea]
	public string info; // 0x48
	public ButtonEnum buttonType; // 0x50
	public int num; // 0x54

	// Methods

	// RVA: 0x416778C Offset: 0x416378C VA: 0x416778C Slot: 4
	protected override void Init() { }

	// RVA: 0x4167794 Offset: 0x4163794 VA: 0x4167794 Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x416779C Offset: 0x416379C VA: 0x416779C
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
[NodeTint(78, 161, 89)]
public class GameEventShopNode : Node // TypeDefIndex: 21002
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	public int npcId; // 0x38

	// Methods

	// RVA: 0x41677A4 Offset: 0x41637A4 VA: 0x41677A4 Slot: 4
	protected override void Init() { }

	// RVA: 0x41677AC Offset: 0x41637AC VA: 0x41677AC Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x41677B4 Offset: 0x41637B4 VA: 0x41677B4
	public void .ctor() { }
}

// Namespace: Framework.Logic.XNode
[NodeTint(78, 161, 89)]
public class GameEventSkillNode : Node // TypeDefIndex: 21003
{
	// Fields
	[Input(1, 0, 0, False)]
	public Empty enter; // 0x30
	public int randomNum; // 0x38
	public int selectNum; // 0x3C

	// Methods

	// RVA: 0x41677BC Offset: 0x41637BC VA: 0x41677BC Slot: 4
	protected override void Init() { }

	// RVA: 0x41677C4 Offset: 0x41637C4 VA: 0x41677C4 Slot: 5
	public override object GetValue(NodePort port) { }

	// RVA: 0x41677CC Offset: 0x41637CC VA: 0x41677CC
	public void .ctor() { }
}

// Namespace: 
private enum TestNode.TestEnum // TypeDefIndex: 21004
{
	// Fields
	public int value__; // 0x0
	public const TestNode.TestEnum a = 0;
	public const TestNode.TestEnum b = 0;
	public const TestNode.TestEnum c = 1;
}

// Namespace: Framework.Logic.XNode
public class TestNode : MonoBehaviour // TypeDefIndex: 21005
{
	// Fields
	public GameEventGraph graph; // 0x20

	// Methods

	// RVA: 0x41677D4 Offset: 0x41637D4 VA: 0x41677D4
	private void Start() { }

	// RVA: 0x4167864 Offset: 0x4163864 VA: 0x4167864
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class ButtonCurrencyCtrl : CustomButton // TypeDefIndex: 21006
{
	// Fields
	public CustomImage Image_Icon; // 0x158
	public CustomText Text_Value; // 0x160
	private RectTransform m_parent; // 0x168

	// Properties
	private RectTransform parentTransform { get; }

	// Methods

	// RVA: 0x416786C Offset: 0x416386C VA: 0x416786C
	private RectTransform get_parentTransform() { }

	// RVA: 0x4167948 Offset: 0x4163948 VA: 0x4167948
	public void SetValue(int value) { }

	// RVA: 0x41679F0 Offset: 0x41639F0 VA: 0x41679F0
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomButton : Button // TypeDefIndex: 21007
{
	// Fields
	private static int AnimationTrigger_Normal; // 0x0
	private static int AnimationTrigger_Pressed; // 0x4
	[Header("Intervals Setting")]
	public float m_intervals; // 0x108
	public bool m_setDefaultAnim; // 0x10C
	[Label]
	[SerializeField]
	private float m_lastClickTime; // 0x110
	[SerializeField]
	[Label]
	private float m_currentTime; // 0x114
	[Header("Audio Setting")]
	public string m_audioPath; // 0x118
	public Action m_onClick; // 0x120
	[CompilerGenerated]
	private Action <onDown>k__BackingField; // 0x128
	[CompilerGenerated]
	private Action <onUp>k__BackingField; // 0x130
	private Dictionary<long, Color> _colorCache; // 0x138
	[CompilerGenerated]
	private bool <IsGray>k__BackingField; // 0x140
	private const string OutLineEffectColor = "outLineEffectColor";
	private const string TextColor = "textColor";
	private Animator _animator; // 0x148
	private bool _isDown; // 0x150

	// Properties
	public Action onDown { get; set; }
	public Action onUp { get; set; }
	public bool IsGray { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4167B04 Offset: 0x4163B04 VA: 0x4167B04
	public Action get_onDown() { }

	[CompilerGenerated]
	// RVA: 0x4167B0C Offset: 0x4163B0C VA: 0x4167B0C
	public void set_onDown(Action value) { }

	[CompilerGenerated]
	// RVA: 0x4167B1C Offset: 0x4163B1C VA: 0x4167B1C
	public Action get_onUp() { }

	[CompilerGenerated]
	// RVA: 0x4167B24 Offset: 0x4163B24 VA: 0x4167B24
	public void set_onUp(Action value) { }

	[CompilerGenerated]
	// RVA: 0x4167B34 Offset: 0x4163B34 VA: 0x4167B34
	public bool get_IsGray() { }

	[CompilerGenerated]
	// RVA: 0x4167B3C Offset: 0x4163B3C VA: 0x4167B3C
	private void set_IsGray(bool value) { }

	// RVA: 0x4167B48 Offset: 0x4163B48 VA: 0x4167B48 Slot: 4
	protected override void Awake() { }

	// RVA: 0x4167DE8 Offset: 0x4163DE8 VA: 0x4167DE8
	public void SetEnable(bool isEnable) { }

	// RVA: 0x4167DF4 Offset: 0x4163DF4 VA: 0x4167DF4
	public void SetNormal() { }

	// RVA: 0x4167FE8 Offset: 0x4163FE8 VA: 0x4167FE8
	public void SetGray() { }

	// RVA: 0x4167BBC Offset: 0x4163BBC VA: 0x4167BBC
	private void SetDefaultAnim() { }

	// RVA: 0x4168270 Offset: 0x4164270 VA: 0x4168270
	private bool IsPrefab() { }

	// RVA: 0x4168278 Offset: 0x4164278 VA: 0x4168278 Slot: 41
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4168324 Offset: 0x4164324 VA: 0x4168324
	private void PlayAudio() { }

	// RVA: 0x41683E8 Offset: 0x41643E8 VA: 0x41683E8 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x4168424 Offset: 0x4164424 VA: 0x4168424 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x416845C Offset: 0x416445C VA: 0x416845C Slot: 34
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x416851C Offset: 0x416451C VA: 0x416851C Slot: 35
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x4167A44 Offset: 0x4163A44 VA: 0x4167A44
	public void .ctor() { }

	// RVA: 0x41685DC Offset: 0x41645DC VA: 0x41685DC
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class CustomChooseButton.SelectChangedEvent : UnityEvent<bool> // TypeDefIndex: 21008
{
	// Methods

	// RVA: 0x4168C08 Offset: 0x4164C08 VA: 0x4168C08
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomChooseButton : Button // TypeDefIndex: 21009
{
	// Fields
	[Header("Intervals Setting")]
	public float m_intervals; // 0x108
	[Label]
	[SerializeField]
	private float m_lastClickTime; // 0x10C
	[Label]
	[SerializeField]
	private float m_currentTime; // 0x110
	[Header("Image Setting")]
	public Image m_imageTarget; // 0x118
	public Sprite m_unSelectSprite; // 0x120
	public Sprite m_selectSprite; // 0x128
	public Text m_unSelectText; // 0x130
	public Text m_selectText; // 0x138
	public bool m_isCoercionSelect; // 0x140
	[Label]
	[SerializeField]
	private bool m_isSelect; // 0x141
	public GameObject m_SelectObj; // 0x148
	public GameObject m_UnSelectObj; // 0x150
	[Header("Audio Setting")]
	public string m_audioPath; // 0x158
	public Action<CustomChooseButton> OnClickButton; // 0x160
	public CustomChooseButton.SelectChangedEvent onSelectChanged; // 0x168

	// Properties
	public bool IsSelected { get; }

	// Methods

	// RVA: 0x4168678 Offset: 0x4164678 VA: 0x4168678
	public bool get_IsSelected() { }

	// RVA: 0x4168680 Offset: 0x4164680 VA: 0x4168680 Slot: 4
	protected override void Awake() { }

	// RVA: 0x41689AC Offset: 0x41649AC VA: 0x41689AC Slot: 41
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4168A7C Offset: 0x4164A7C VA: 0x4168A7C
	private void PlayAudio() { }

	// RVA: 0x41688E8 Offset: 0x41648E8 VA: 0x41688E8
	public void EnableOnClickButton() { }

	// RVA: 0x4168B40 Offset: 0x4164B40 VA: 0x4168B40
	private void InternalClickButton() { }

	// RVA: 0x41686B0 Offset: 0x41646B0 VA: 0x41686B0
	public void SetSelect(bool isSelect) { }

	// RVA: 0x4168B60 Offset: 0x4164B60 VA: 0x4168B60
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomChooseButtonGroup : MonoBehaviour // TypeDefIndex: 21010
{
	// Fields
	public List<CustomChooseButton> Buttons; // 0x20
	public Action<CustomChooseButton> OnSwitch; // 0x28
	private Dictionary<string, CustomChooseButton> _dic; // 0x30

	// Properties
	public CustomChooseButton CurrentButton { get; }
	public string CurrentButtonName { get; }

	// Methods

	// RVA: 0x4168C50 Offset: 0x4164C50 VA: 0x4168C50
	public CustomChooseButton get_CurrentButton() { }

	// RVA: 0x4168D3C Offset: 0x4164D3C VA: 0x4168D3C
	public string get_CurrentButtonName() { }

	// RVA: 0x4168E5C Offset: 0x4164E5C VA: 0x4168E5C
	private void Awake() { }

	// RVA: 0x4168E60 Offset: 0x4164E60 VA: 0x4168E60
	public void CollectChildButtons() { }

	// RVA: 0x4169090 Offset: 0x4165090 VA: 0x4169090
	private void OnClickSwitchButton(CustomChooseButton button) { }

	// RVA: 0x41691C0 Offset: 0x41651C0 VA: 0x41691C0
	public void ChooseButton(CustomChooseButton button) { }

	// RVA: 0x41691C4 Offset: 0x41651C4 VA: 0x41691C4
	public void ChooseButtonName(string name) { }

	// RVA: 0x41692FC Offset: 0x41652FC VA: 0x41692FC
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomFitContentLanguageText : CustomLanguageText // TypeDefIndex: 21011
{
	// Fields
	[CompilerGenerated]
	private int <VisibleLines>k__BackingField; // 0x130
	private readonly UIVertex[] _tmpVerts; // 0x138

	// Properties
	public int VisibleLines { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4169384 Offset: 0x4165384 VA: 0x4169384
	public int get_VisibleLines() { }

	[CompilerGenerated]
	// RVA: 0x416938C Offset: 0x416538C VA: 0x416938C
	private void set_VisibleLines(int value) { }

	// RVA: 0x4169394 Offset: 0x4165394 VA: 0x4169394
	private void _UseFitSettings() { }

	// RVA: 0x4169668 Offset: 0x4165668 VA: 0x4169668 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x4169C30 Offset: 0x4165C30 VA: 0x4169C30
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomFitContentText : CustomText // TypeDefIndex: 21012
{
	// Fields
	[CompilerGenerated]
	private int <VisibleLines>k__BackingField; // 0x120
	private readonly UIVertex[] _tmpVerts; // 0x128

	// Properties
	public int VisibleLines { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4169C94 Offset: 0x4165C94 VA: 0x4169C94
	public int get_VisibleLines() { }

	[CompilerGenerated]
	// RVA: 0x4169C9C Offset: 0x4165C9C VA: 0x4169C9C
	private void set_VisibleLines(int value) { }

	// RVA: 0x4169CA4 Offset: 0x4165CA4 VA: 0x4169CA4
	private void _UseFitSettings() { }

	// RVA: 0x4169F78 Offset: 0x4165F78 VA: 0x4169F78 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x416A540 Offset: 0x4166540 VA: 0x416A540
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct CustomImageSpriteCache.<LoadAtlas>d__8 : IAsyncStateMachine // TypeDefIndex: 21013
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string atlasPath; // 0x20
	public string spriteName; // 0x28
	private TaskAwaiter<AssetData> <>u__1; // 0x30

	// Methods

	// RVA: 0x416B034 Offset: 0x4167034 VA: 0x416B034 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x416B690 Offset: 0x4167690 VA: 0x416B690 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.UI
public static class CustomImageSpriteCache // TypeDefIndex: 21014
{
	// Fields
	private static readonly Dictionary<string, SpriteAtlas> SpriteAtlasMap; // 0x0
	private static readonly Dictionary<string, AssetData> HandleMap; // 0x8
	private static readonly Dictionary<string, int> RefCountMap; // 0x10
	private static readonly Dictionary<string, Dictionary<string, Sprite>> SpriteMap; // 0x18

	// Methods

	// RVA: 0x416A5A4 Offset: 0x41665A4 VA: 0x416A5A4
	public static SpriteAtlas GetSpriteAtlas(string atlasPath) { }

	// RVA: 0x416A61C Offset: 0x416661C VA: 0x416A61C
	public static void TryUnloadAtlas(string atlasPath) { }

	// RVA: 0x416AAD8 Offset: 0x4166AD8 VA: 0x416AAD8
	public static Sprite GetSprite(string atlasPath, SpriteAtlas atlas, string spriteName) { }

	// RVA: 0x416AC78 Offset: 0x4166C78 VA: 0x416AC78
	public static SpriteAtlas TryGetAtlas(string atlasPath) { }

	[AsyncStateMachine(typeof(CustomImageSpriteCache.<LoadAtlas>d__8))]
	// RVA: 0x416AD98 Offset: 0x4166D98 VA: 0x416AD98
	public static Task LoadAtlas(string atlasPath, string spriteName) { }

	// RVA: 0x416AE94 Offset: 0x4166E94 VA: 0x416AE94
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class CustomImage.FinishedEvent : UnityEvent<string, string> // TypeDefIndex: 21015
{
	// Methods

	// RVA: 0x4186888 Offset: 0x4182888 VA: 0x4186888
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CustomImage.<OnGetTexture>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21016
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public CustomImage <>4__this; // 0x28
	private UnityWebRequest <uwr>5__2; // 0x30
	private DownloadHandlerTexture <downloadTexture>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41868D0 Offset: 0x41828D0 VA: 0x41868D0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41868F8 Offset: 0x41828F8 VA: 0x41868F8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41868FC Offset: 0x41828FC VA: 0x41868FC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x4186BFC Offset: 0x4182BFC VA: 0x4186BFC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x4186C04 Offset: 0x4182C04 VA: 0x4186C04 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x4186C3C Offset: 0x4182C3C VA: 0x4186C3C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private struct CustomImage.<SetImageSingleSpriteTask>d__20 : IAsyncStateMachine // TypeDefIndex: 21017
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string imgpath; // 0x20
	public CustomImage <>4__this; // 0x28
	private TaskAwaiter<AssetData> <>u__1; // 0x30

	// Methods

	// RVA: 0x4186C44 Offset: 0x4182C44 VA: 0x4186C44 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x418717C Offset: 0x418317C VA: 0x418717C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CustomImage.<SetImageSingleTask>d__18 : IAsyncStateMachine // TypeDefIndex: 21018
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string imgpath; // 0x20
	public CustomImage <>4__this; // 0x28
	private TaskAwaiter<AssetData> <>u__1; // 0x30

	// Methods

	// RVA: 0x41871E4 Offset: 0x41831E4 VA: 0x41871E4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41877C0 Offset: 0x41837C0 VA: 0x41877C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CustomImage.<SetImageTask>d__16 : IAsyncStateMachine // TypeDefIndex: 21019
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string atlasPath; // 0x20
	public string spriteName; // 0x28
	public CustomImage <>4__this; // 0x30
	public int version; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x4187828 Offset: 0x4183828 VA: 0x4187828 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x4187B48 Offset: 0x4183B48 VA: 0x4187B48 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.UI
public class CustomImage : Image // TypeDefIndex: 21020
{
	// Fields
	private string m_atlasPath; // 0x110
	private SpriteAtlas m_atlas; // 0x118
	private Texture2D m_textureSingle; // 0x120
	private string m_pathSingle; // 0x128
	private AssetData m_handleSingle; // 0x130
	private Texture2D m_textureUrl; // 0x160
	private string m_pathUrl; // 0x168
	private IEnumerator m_handleUrl; // 0x170
	[Header("自适应图片尺寸")]
	public bool KeepNativeSize; // 0x178
	public CustomImage.FinishedEvent onFinished; // 0x180
	private int m_setImageVersion; // 0x188

	// Methods

	// RVA: 0x416B6F8 Offset: 0x41676F8 VA: 0x416B6F8
	public bool EndsWithClone(string text) { }

	// RVA: 0x416B760 Offset: 0x4167760 VA: 0x416B760
	private void SetSprite(Sprite spriteValue) { }

	// RVA: 0x416B834 Offset: 0x4167834 VA: 0x416B834
	public void SetImage(string atlasPath, string spriteName) { }

	// RVA: 0x416B884 Offset: 0x4167884 VA: 0x416B884
	private bool PreSetImage(string atlasPath, string spriteName) { }

	[AsyncStateMachine(typeof(CustomImage.<SetImageTask>d__16))]
	// RVA: 0x416BA34 Offset: 0x4167A34 VA: 0x416BA34
	private Task SetImageTask(string atlasPath, string spriteName, int version) { }

	// RVA: 0x416BDA8 Offset: 0x4167DA8 VA: 0x416BDA8
	public void SetImageSingle(string imgpath) { }

	[AsyncStateMachine(typeof(CustomImage.<SetImageSingleTask>d__18))]
	// RVA: 0x416BDAC Offset: 0x4167DAC VA: 0x416BDAC
	public Task SetImageSingleTask(string imgpath) { }

	// RVA: 0x416BEA8 Offset: 0x4167EA8 VA: 0x416BEA8
	public void SetImageSingleSprite(string imgpath) { }

	[AsyncStateMachine(typeof(CustomImage.<SetImageSingleSpriteTask>d__20))]
	// RVA: 0x416BEAC Offset: 0x4167EAC VA: 0x416BEAC
	public Task SetImageSingleSpriteTask(string imgpath) { }

	// RVA: 0x416BFA8 Offset: 0x4167FA8 VA: 0x416BFA8
	public void SetImageUrl(string url) { }

	[IteratorStateMachine(typeof(CustomImage.<OnGetTexture>d__22))]
	// RVA: 0x416C084 Offset: 0x4168084 VA: 0x416C084
	private IEnumerator OnGetTexture(string url) { }

	// RVA: 0x416C114 Offset: 0x4168114 VA: 0x416C114 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x416BB54 Offset: 0x4167B54 VA: 0x416BB54
	private void UnLoad() { }

	// RVA: 0x416C130 Offset: 0x4168130 VA: 0x416C130
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
[AddComponentMenu("UI/CustomLanguageText", 21)]
public class CustomLanguageText : Text // TypeDefIndex: 21021
{
	// Fields
	[Header("Language Setting")]
	[SerializeField]
	private int m_languageId; // 0x108
	[SerializeField]
	private LanguageType m_language; // 0x10C
	[SerializeField]
	private bool m_autoChangeLanguage; // 0x110
	[SerializeField]
	private string m_languageIdStr; // 0x118
	private bool m_autoLine; // 0x120
	private bool m_autoSpace; // 0x121
	private string m_sourceText; // 0x128

	// Methods

	// RVA: 0x4187BB0 Offset: 0x4183BB0 VA: 0x4187BB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4187E9C Offset: 0x4183E9C VA: 0x4187E9C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4188034 Offset: 0x4184034 VA: 0x4188034
	private void OnLanguageChanged(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x4188038 Offset: 0x4184038 VA: 0x4188038
	public void SetContentByStr() { }

	// RVA: 0x4188228 Offset: 0x4184228 VA: 0x4188228
	public void SetContent() { }

	// RVA: 0x4187D50 Offset: 0x4183D50 VA: 0x4187D50
	public void OnRefresh() { }

	// RVA: 0x418843C Offset: 0x418443C VA: 0x418843C
	public void SetText(string str) { }

	// RVA: 0x4188584 Offset: 0x4184584 VA: 0x4188584
	public void SetText(int languageid) { }

	// RVA: 0x4188444 Offset: 0x4184444 VA: 0x4188444
	private void SetString(string str) { }

	// RVA: 0x418858C Offset: 0x418458C VA: 0x418858C
	public void ChangeLanguageID(int languageid) { }

	// RVA: 0x41885D0 Offset: 0x41845D0 VA: 0x41885D0
	public void ChangeLanguageID(string languageid) { }

	// RVA: 0x41885F0 Offset: 0x41845F0 VA: 0x41885F0
	public void .ctor() { }
}

// Namespace: 
private static class CustomOutLine.ListPool<T> // TypeDefIndex: 21022
{
	// Fields
	private static readonly CustomOutLine.ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void Clear(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B696F0 Offset: 0x4B656F0 VA: 0x4B696F0
	|-CustomOutLine.ListPool<UIVertex>.Clear
	|
	|-RVA: 0x4B6A124 Offset: 0x4B66124 VA: 0x4B6A124
	|-CustomOutLine.ListPool<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B69724 Offset: 0x4B65724 VA: 0x4B69724
	|-CustomOutLine.ListPool<UIVertex>.Get
	|
	|-RVA: 0x4B6A1A4 Offset: 0x4B661A4 VA: 0x4B6A1A4
	|-CustomOutLine.ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B697BC Offset: 0x4B657BC VA: 0x4B697BC
	|-CustomOutLine.ListPool<UIVertex>.Release
	|
	|-RVA: 0x4B6A28C Offset: 0x4B6628C VA: 0x4B6A28C
	|-CustomOutLine.ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B69864 Offset: 0x4B65864 VA: 0x4B69864
	|-CustomOutLine.ListPool<UIVertex>..cctor
	|
	|-RVA: 0x4B6A388 Offset: 0x4B66388 VA: 0x4B6A388
	|-CustomOutLine.ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
private class CustomOutLine.ObjectPool<T> // TypeDefIndex: 21023
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD078 Offset: 0x51F9078 VA: 0x51FD078
	|-CustomOutLine.ObjectPool<object>.get_countAll
	|
	|-RVA: 0x51FD938 Offset: 0x51F9938 VA: 0x51FD938
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD080 Offset: 0x51F9080 VA: 0x51FD080
	|-CustomOutLine.ObjectPool<object>.set_countAll
	|
	|-RVA: 0x51FD940 Offset: 0x51F9940 VA: 0x51FD940
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD088 Offset: 0x51F9088 VA: 0x51FD088
	|-CustomOutLine.ObjectPool<object>.get_countActive
	|
	|-RVA: 0x51FD948 Offset: 0x51F9948 VA: 0x51FD948
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD0AC Offset: 0x51F90AC VA: 0x51FD0AC
	|-CustomOutLine.ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x51FD998 Offset: 0x51F9998 VA: 0x51FD998
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD0C8 Offset: 0x51F90C8 VA: 0x51FD0C8
	|-CustomOutLine.ObjectPool<object>..ctor
	|
	|-RVA: 0x51FD9C0 Offset: 0x51F99C0 VA: 0x51FD9C0
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD168 Offset: 0x51F9168 VA: 0x51FD168
	|-CustomOutLine.ObjectPool<object>.Get
	|
	|-RVA: 0x51FDA64 Offset: 0x51F9A64 VA: 0x51FDA64
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FD1E4 Offset: 0x51F91E4 VA: 0x51FD1E4
	|-CustomOutLine.ObjectPool<object>.Release
	|
	|-RVA: 0x51FDC40 Offset: 0x51F9C40 VA: 0x51FDC40
	|-CustomOutLine.ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: Framework.Logic.UI
[AddComponentMenu("UI/CustomOutLine", 23)]
[RequireComponent(typeof(Text))]
public class CustomOutLine : Shadow // TypeDefIndex: 21024
{
	// Fields
	private float effectscale; // 0x44
	private float distanceScale; // 0x48
	private const float xScale = 1;
	private const float DownHeight = 3.5;
	private const float DownDensity = 2;
	private static Vector2 distance; // 0x0
	private Text m_Text; // 0x50

	// Properties
	public Text text { get; }

	// Methods

	// RVA: 0x4188664 Offset: 0x4184664 VA: 0x4188664
	public Text get_text() { }

	// RVA: 0x418870C Offset: 0x418470C VA: 0x418870C Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x4188C44 Offset: 0x4184C44 VA: 0x4188C44
	public void .ctor() { }

	// RVA: 0x4188C58 Offset: 0x4184C58 VA: 0x4188C58
	private static void .cctor() { }
}

// Namespace: 
public enum CustomScrollRect.Direction // TypeDefIndex: 21025
{
	// Fields
	public int value__; // 0x0
	public const CustomScrollRect.Direction Horizontal = 0;
	public const CustomScrollRect.Direction Vertical = 1;
}

// Namespace: Framework.Logic.UI
public class CustomScrollRect : ScrollRect // TypeDefIndex: 21026
{
	// Fields
	public CustomScrollRect m_parentScrollRect; // 0x130
	private CustomScrollRect.Direction m_direction; // 0x138
	private CustomScrollRect.Direction m_beginDragDirection; // 0x13C

	// Methods

	// RVA: 0x4188CD4 Offset: 0x4184CD4 VA: 0x4188CD4 Slot: 4
	protected override void Awake() { }

	// RVA: 0x4188DD0 Offset: 0x4184DD0 VA: 0x4188DD0 Slot: 44
	public override void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x4188F24 Offset: 0x4184F24 VA: 0x4188F24 Slot: 46
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x418905C Offset: 0x418505C VA: 0x418905C Slot: 45
	public override void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x4189194 Offset: 0x4185194 VA: 0x4189194 Slot: 42
	public override void OnScroll(PointerEventData data) { }

	// RVA: 0x41892CC Offset: 0x41852CC VA: 0x41892CC
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
[AddComponentMenu("UI/CustomText", 22)]
public class CustomText : Text // TypeDefIndex: 21027
{
	// Fields
	private LanguageDataModule m_languageDataModule; // 0x108
	private bool m_autoLine; // 0x110
	private bool m_autoSpace; // 0x111
	private string m_sourceText; // 0x118

	// Properties
	public override string text { get; set; }

	// Methods

	// RVA: 0x41892D4 Offset: 0x41852D4 VA: 0x41892D4 Slot: 74
	public override string get_text() { }

	// RVA: 0x41892DC Offset: 0x41852DC VA: 0x41892DC Slot: 75
	public override void set_text(string value) { }

	// RVA: 0x41894B8 Offset: 0x41854B8 VA: 0x41894B8
	public void SetText(int tableID, object[] args) { }

	// RVA: 0x41894F4 Offset: 0x41854F4 VA: 0x41894F4
	public void SetText(string tableID, object[] args) { }

	// RVA: 0x4189730 Offset: 0x4185730 VA: 0x4189730
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class CustomTextHelper : BaseMeshEffect // TypeDefIndex: 21028
{
	// Fields
	[Header("是否使用渐变色")]
	public bool useGradientColor; // 0x28
	[Header("左上颜色,右上颜色,左下颜色,右下颜色")]
	public Color32 gradientColor1; // 0x2C
	public Color32 gradientColor2; // 0x30
	public Color32 gradientColor3; // 0x34
	public Color32 gradientColor4; // 0x38
	[Header("是否开启对齐")]
	public bool useAlign; // 0x3C
	[Header("字间距")]
	public float wordSpace; // 0x40
	[Header("行间距")]
	public float lineSpace; // 0x44
	[Header("是否显示下划线")]
	public bool useUnderline; // 0x48
	[Header("下划线是否忽略换行符")]
	public bool ignoreBreakSign; // 0x49
	[SerializeField]
	[Range(0, 100)]
	[Header("下划线宽度")]
	private float _lineHeight; // 0x4C
	private float _lineHeightHalf; // 0x50
	[Header("行高是否两端扩展,否则向下扩展")]
	public bool lineHeightJustify; // 0x54
	public float lineOffset; // 0x58
	public Color32 lineColor; // 0x5C
	[Header("横线对齐到行的上下中间")]
	public bool lineAlignToMiddle; // 0x60
	[Header("是否使用customLineIndexArray来作为显示线的起止依据,否则是全文字段显示")]
	public bool useCustomLineIndexArray; // 0x61
	public Vector2Int[] customLineIndexArray; // 0x68
	private Text text; // 0x70
	private UICharInfo[] characters; // 0x78
	private UILineInfo[] lines; // 0x80
	private Color[] gradientColors; // 0x88
	private char[] textChars; // 0x90
	private List<UIVertex> stream; // 0x98
	private int characterCountVisible; // 0xA0
	private UIVertex[] underlineUIVertexs; // 0xA8

	// Properties
	public float lineHeight { get; set; }

	// Methods

	// RVA: 0x4189740 Offset: 0x4185740 VA: 0x4189740
	public float get_lineHeight() { }

	// RVA: 0x4189748 Offset: 0x4185748 VA: 0x4189748
	public void set_lineHeight(float value) { }

	// RVA: 0x4189758 Offset: 0x4185758 VA: 0x4189758 Slot: 4
	protected override void Awake() { }

	// RVA: 0x4189868 Offset: 0x4185868 VA: 0x4189868
	private void OnFontMaterialChanged() { }

	// RVA: 0x4189904 Offset: 0x4185904 VA: 0x4189904 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x41899A0 Offset: 0x41859A0 VA: 0x41899A0
	private Vector2 GetUnderlineCharUV() { }

	// RVA: 0x4189B2C Offset: 0x4185B2C VA: 0x4189B2C Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x4189F24 Offset: 0x4185F24 VA: 0x4189F24
	private void SetGradientColors(int i, int j) { }

	// RVA: 0x418A2A8 Offset: 0x41862A8 VA: 0x418A2A8
	private void DoAlign(int i, int j, float offx, float offy) { }

	// RVA: 0x4189E74 Offset: 0x4185E74 VA: 0x4189E74
	private int GetCharInLineIndex(int charIndex) { }

	// RVA: 0x418A3B8 Offset: 0x41863B8 VA: 0x418A3B8
	private void DrawAllLinesLine(VertexHelper vh) { }

	// RVA: 0x418A4A8 Offset: 0x41864A8 VA: 0x418A4A8
	private void DrawCustomLine(VertexHelper vh) { }

	// RVA: 0x418A6D0 Offset: 0x41866D0 VA: 0x418A6D0
	private float GetLineBottomY(int lineIndex) { }

	// RVA: 0x418AC98 Offset: 0x4186C98 VA: 0x418AC98
	private Vector2 GetCharCursorPos(int charIdx, float firstCharOff) { }

	// RVA: 0x418A76C Offset: 0x418676C VA: 0x418A76C
	private void AddUnderlineVertTriangle(VertexHelper vh, int startIndex, int endIndex, float firstCharOff, float bottomY, Vector2 uv0) { }

	// RVA: 0x418AD3C Offset: 0x4186D3C VA: 0x418AD3C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
[AddComponentMenu("UI/Effects/Gradient")]
public class Gradient : BaseMeshEffect // TypeDefIndex: 21029
{
	// Fields
	[SerializeField]
	private Color32 topColor; // 0x28
	[SerializeField]
	private Color32 bottomColor; // 0x2C
	private List<UIVertex> mVertexList; // 0x30

	// Methods

	// RVA: 0x418AE7C Offset: 0x4186E7C VA: 0x418AE7C Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x418AF6C Offset: 0x4186F6C VA: 0x418AF6C
	private void ApplyGradient(List<UIVertex> vertexList) { }

	// RVA: 0x418B168 Offset: 0x4187168 VA: 0x418B168
	private void ChangeColor(List<UIVertex> verList, int index, Color color) { }

	// RVA: 0x418B290 Offset: 0x4187290 VA: 0x418B290
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class LineTextCtrl : MonoBehaviour // TypeDefIndex: 21030
{
	// Fields
	public float Interval; // 0x20
	public float LeftRightPadding; // 0x24
	public Image Image_LeftLine; // 0x28
	public Image Image_RightLine; // 0x30
	public Text Text_Content; // 0x38
	[Tooltip("开启后自动在 LateUpdate 中检测文本变化并刷新布局，但是可能会有延时，如果需要立即刷新请调用ForceLayout()")]
	public bool AutoRefresh; // 0x40
	private string m_tempText; // 0x48
	private RectTransform m_rectTransform; // 0x50
	private float allWidth; // 0x58

	// Methods

	// RVA: 0x418B2E0 Offset: 0x41872E0 VA: 0x418B2E0
	private void Awake() { }

	// RVA: 0x418B2E4 Offset: 0x41872E4 VA: 0x418B2E4
	private void OnRefresh() { }

	// RVA: 0x418B498 Offset: 0x4187498 VA: 0x418B498
	private void LateUpdate() { }

	// RVA: 0x418B764 Offset: 0x4187764 VA: 0x418B764
	private void OnDestroy() { }

	// RVA: 0x418B578 Offset: 0x4187578 VA: 0x418B578
	private void onRefreshLayout() { }

	// RVA: 0x418B768 Offset: 0x4187768 VA: 0x418B768
	public void ForceLayout() { }

	// RVA: 0x418B76C Offset: 0x418776C VA: 0x418B76C
	public void SetText(string text) { }

	// RVA: 0x418B888 Offset: 0x4187888 VA: 0x418B888
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("Layout/Extensions/NonDrawingGraphic")]
public class NonDrawingGraphic : MaskableGraphic // TypeDefIndex: 21031
{
	// Methods

	// RVA: 0x418B8EC Offset: 0x41878EC VA: 0x418B8EC Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x418B8F0 Offset: 0x41878F0 VA: 0x418B8F0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x418B8F4 Offset: 0x41878F4 VA: 0x418B8F4 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x418B90C Offset: 0x418790C VA: 0x418B90C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class OutlineEx : BaseMeshEffect // TypeDefIndex: 21032
{
	// Fields
	protected float m_outlineWidth; // 0x28
	private static List<UIVertex> m_VetexList; // 0x0
	private static Material _mat; // 0x8
	private static int m_minFont; // 0x10
	private static int m_maxFont; // 0x14
	private Vector4 m_min; // 0x2C
	private Vector4 m_max; // 0x3C
	public Vector4 m_offset; // 0x4C
	public Text m_text; // 0x60
	private bool isRfresh; // 0x68
	private bool m_isSeting; // 0x69
	private float accept; // 0x6C

	// Methods

	// RVA: 0x418B914 Offset: 0x4187914 VA: 0x418B914
	private static Material GetMat() { }

	// RVA: 0x418BA40 Offset: 0x4187A40 VA: 0x418BA40
	public void ForceRefreshCanvas() { }

	// RVA: 0x418BA48 Offset: 0x4187A48 VA: 0x418BA48 Slot: 4
	protected override void Awake() { }

	// RVA: 0x418BB04 Offset: 0x4187B04 VA: 0x418BB04 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x418BB20 Offset: 0x4187B20 VA: 0x418BB20 Slot: 21
	protected virtual float GetOutlineWidth() { }

	// RVA: 0x418BB28 Offset: 0x4187B28 VA: 0x418BB28 Slot: 22
	protected virtual Vector4 GetMin() { }

	// RVA: 0x418BB34 Offset: 0x4187B34 VA: 0x418BB34 Slot: 23
	protected virtual Vector4 GetMax() { }

	// RVA: 0x418BB40 Offset: 0x4187B40 VA: 0x418BB40 Slot: 6
	protected override void Start() { }

	// RVA: 0x418BB44 Offset: 0x4187B44 VA: 0x418BB44
	private void SetCanvas() { }

	// RVA: 0x418BD68 Offset: 0x4187D68 VA: 0x418BD68
	private void refreshOffset() { }

	// RVA: 0x418BF88 Offset: 0x4187F88 VA: 0x418BF88
	private void _Refresh() { }

	// RVA: 0x418BFD4 Offset: 0x4187FD4 VA: 0x418BFD4 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x418C088 Offset: 0x4188088 VA: 0x418C088
	private void _ProcessVertices() { }

	// RVA: 0x418CC94 Offset: 0x4188C94 VA: 0x418CC94
	private static UIVertex _SetNewPosAndUV(UIVertex pVertex, float pOutLineWidth, Vector2 pPosCenter, Vector2 pTriangleX, Vector2 pTriangleY, Vector2 pUVX, Vector2 pUVY, Vector2 pUVOriginMin, Vector2 pUVOriginMax) { }

	// RVA: 0x418CB34 Offset: 0x4188B34 VA: 0x418CB34
	private static float _Min(float pA, float pB, float pC) { }

	// RVA: 0x418CB48 Offset: 0x4188B48 VA: 0x418CB48
	private static float _Max(float pA, float pB, float pC) { }

	// RVA: 0x418CB5C Offset: 0x4188B5C VA: 0x418CB5C
	private static Vector2 _Min(Vector2 pA, Vector2 pB, Vector2 pC) { }

	// RVA: 0x418CBF8 Offset: 0x4188BF8 VA: 0x418CBF8
	private static Vector2 _Max(Vector2 pA, Vector2 pB, Vector2 pC) { }

	// RVA: 0x418CED4 Offset: 0x4188ED4 VA: 0x418CED4
	public void .ctor() { }

	// RVA: 0x418CF44 Offset: 0x4188F44 VA: 0x418CF44
	private static void .cctor() { }
}

// Namespace: Framework.Logic.UI
public class OutlineEx_Custom : OutlineEx // TypeDefIndex: 21033
{
	// Fields
	public float m_width; // 0x70
	public Vector4 m_customMin; // 0x74
	public Vector4 m_customMax; // 0x84

	// Methods

	// RVA: 0x418D008 Offset: 0x4189008 VA: 0x418D008 Slot: 21
	protected override float GetOutlineWidth() { }

	// RVA: 0x418D010 Offset: 0x4189010 VA: 0x418D010 Slot: 22
	protected override Vector4 GetMin() { }

	// RVA: 0x418D01C Offset: 0x418901C VA: 0x418D01C Slot: 23
	protected override Vector4 GetMax() { }

	// RVA: 0x418D028 Offset: 0x4189028 VA: 0x418D028
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class SimpleGrayButton : CustomButton // TypeDefIndex: 21034
{
	// Fields
	private Image _grayImage; // 0x158

	// Methods

	// RVA: 0x418D094 Offset: 0x4189094 VA: 0x418D094
	public void SetImageGray(bool setGray, bool setInteractable = True) { }

	// RVA: 0x418D2EC Offset: 0x41892EC VA: 0x418D2EC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct TapToCloseCtrl.<OnShow>d__10 : IAsyncStateMachine // TypeDefIndex: 21035
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public TapToCloseCtrl <>4__this; // 0x28
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x418D5D8 Offset: 0x41895D8 VA: 0x418D5D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x418D924 Offset: 0x4189924 VA: 0x418D924 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.UI
public class TapToCloseCtrl : MonoBehaviour // TypeDefIndex: 21036
{
	// Fields
	public GameObject child; // 0x20
	public CustomButton Button_Close; // 0x28
	public Animator m_idleAni; // 0x30
	public Text Text_Content; // 0x38
	public Action OnClose; // 0x40

	// Methods

	// RVA: 0x418D344 Offset: 0x4189344 VA: 0x418D344
	private void Awake() { }

	// RVA: 0x418D420 Offset: 0x4189420 VA: 0x418D420 Slot: 4
	protected virtual void OnAwake() { }

	// RVA: 0x418D424 Offset: 0x4189424 VA: 0x418D424
	private void InternalClick() { }

	// RVA: 0x418D440 Offset: 0x4189440 VA: 0x418D440
	private void HideText() { }

	// RVA: 0x418D4E4 Offset: 0x41894E4 VA: 0x418D4E4
	private void OnEnable() { }

	[AsyncStateMachine(typeof(TapToCloseCtrl.<OnShow>d__10))]
	// RVA: 0x418D4FC Offset: 0x41894FC VA: 0x418D4FC
	private void OnShow() { }

	// RVA: 0x418D5B0 Offset: 0x41895B0 VA: 0x418D5B0
	public void Show(bool value) { }

	// RVA: 0x418D5D0 Offset: 0x41895D0 VA: 0x418D5D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct TextAlphaPingPong.<onShow>d__5 : IAsyncStateMachine // TypeDefIndex: 21037
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public TextAlphaPingPong <>4__this; // 0x28
	private YieldAwaitable.YieldAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x418DB1C Offset: 0x4189B1C VA: 0x418DB1C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x418DD20 Offset: 0x4189D20 VA: 0x418DD20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.UI
public class TextAlphaPingPong : MonoBehaviour // TypeDefIndex: 21038
{
	// Fields
	public Text Text_Content; // 0x20
	public Animator m_idleAni; // 0x28
	public GameObject m_child; // 0x30

	// Methods

	// RVA: 0x418D930 Offset: 0x4189930 VA: 0x418D930
	private void hideText() { }

	// RVA: 0x418D9D4 Offset: 0x41899D4 VA: 0x418D9D4
	private void OnEnable() { }

	[AsyncStateMachine(typeof(TextAlphaPingPong.<onShow>d__5))]
	// RVA: 0x418DA60 Offset: 0x4189A60 VA: 0x418DA60
	private void onShow() { }

	// RVA: 0x418DB14 Offset: 0x4189B14 VA: 0x418DB14
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class UIBgText : MonoBehaviour // TypeDefIndex: 21039
{
	// Fields
	public Text m_text; // 0x20

	// Methods

	// RVA: 0x418DD2C Offset: 0x4189D2C VA: 0x418DD2C
	public void SetText(string info) { }

	// RVA: 0x418DE70 Offset: 0x4189E70 VA: 0x418DE70
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class UIGray : MonoBehaviour // TypeDefIndex: 21040
{
	// Fields
	[Header("Target Setting")]
	public Graphic m_target; // 0x20
	[Header("Materail Setting")]
	public Material m_grayMat; // 0x28
	public Material m_defalutMat; // 0x30

	// Methods

	// RVA: 0x418DE78 Offset: 0x4189E78 VA: 0x418DE78
	private Material GetGrayMat() { }

	// RVA: 0x418DFB8 Offset: 0x4189FB8 VA: 0x418DFB8
	public void SetUIGray() { }

	// RVA: 0x418E06C Offset: 0x418A06C VA: 0x418E06C
	public void Recovery() { }

	// RVA: 0x418E0FC Offset: 0x418A0FC VA: 0x418E0FC
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class UIGrays : MonoBehaviour // TypeDefIndex: 21041
{
	// Fields
	[Header("Target Setting")]
	public Graphic[] m_targets; // 0x20
	[Header("Materail Setting")]
	public Material m_grayMat; // 0x28
	[Label]
	public bool m_isGray; // 0x30

	// Methods

	// RVA: 0x418E104 Offset: 0x418A104 VA: 0x418E104
	private Material GetGrayMat() { }

	// RVA: 0x418E244 Offset: 0x418A244 VA: 0x418E244
	public void SetUIGray() { }

	// RVA: 0x418E3B4 Offset: 0x418A3B4 VA: 0x418E3B4
	public void Recovery() { }

	[ContextMenu("Find Graphic")]
	// RVA: 0x418E34C Offset: 0x418A34C VA: 0x418E34C
	public void FindGraphic() { }

	// RVA: 0x418E43C Offset: 0x418A43C VA: 0x418E43C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
[Obsolete("Use UINetLoading instead")]
public class UILoadingCtrl : MonoBehaviour // TypeDefIndex: 21042
{
	// Fields
	public const string Path = "UI/GuildUI/UI_Loading";
	public RectTransform rotate; // 0x20
	public GameObject wifiObj; // 0x28
	public GameObject retryObj; // 0x30
	public CustomButton buttonRetry; // 0x38
	public CustomText textRetry; // 0x40
	public float inteval; // 0x48
	private SequencePool mSeqPool; // 0x50
	private Action retryCallback; // 0x58

	// Methods

	// RVA: 0x418E444 Offset: 0x418A444 VA: 0x418E444
	public void OnInit() { }

	// RVA: 0x418E4D4 Offset: 0x418A4D4 VA: 0x418E4D4
	public void OnDeInit() { }

	// RVA: 0x418E5AC Offset: 0x418A5AC VA: 0x418E5AC
	private void OnRetry() { }

	// RVA: 0x418E5F4 Offset: 0x418A5F4 VA: 0x418E5F4
	public void OnShow() { }

	// RVA: 0x418E718 Offset: 0x418A718 VA: 0x418E718
	public void OnClose() { }

	// RVA: 0x418E734 Offset: 0x418A734 VA: 0x418E734
	public void Hide() { }

	// RVA: 0x418E758 Offset: 0x418A758 VA: 0x418E758
	public void ShowRetry(Action callback) { }

	// RVA: 0x418E7A8 Offset: 0x418A7A8 VA: 0x418E7A8
	public void SetRetryText(string retrystr) { }

	// RVA: 0x418E7CC Offset: 0x418A7CC VA: 0x418E7CC
	public void SetText(string retrystr, string loadingstr) { }

	// RVA: 0x418E7F0 Offset: 0x418A7F0 VA: 0x418E7F0
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class UIPopClose : MonoBehaviour // TypeDefIndex: 21043
{
	// Fields
	private List<RaycastResult> _cacheList; // 0x20

	// Methods

	// RVA: 0x418E864 Offset: 0x418A864 VA: 0x418E864
	private void Update() { }

	// RVA: 0x418E92C Offset: 0x418A92C VA: 0x418E92C
	private void Check(Vector2 pos) { }

	// RVA: 0x418EB34 Offset: 0x418AB34 VA: 0x418EB34
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class UISortOrder : MonoBehaviour // TypeDefIndex: 21044
{
	// Fields
	public Graphic target; // 0x20
	public GameObject particleParent; // 0x28
	public Canvas canvas; // 0x30
	public int orderOffset; // 0x38
	private int _cur_order; // 0x3C
	private Canvas parentCanvas; // 0x40

	// Properties
	private int curOrder { get; set; }
	private Canvas targetCanvas { get; }

	// Methods

	// RVA: 0x418EBBC Offset: 0x418ABBC VA: 0x418EBBC
	private int get_curOrder() { }

	// RVA: 0x418ED1C Offset: 0x418AD1C VA: 0x418ED1C
	private void set_curOrder(int value) { }

	// RVA: 0x418EC64 Offset: 0x418AC64 VA: 0x418EC64
	private Canvas get_targetCanvas() { }

	// RVA: 0x418ED24 Offset: 0x418AD24 VA: 0x418ED24
	private void Start() { }

	// RVA: 0x418EFD0 Offset: 0x418AFD0 VA: 0x418EFD0
	private void Update() { }

	// RVA: 0x418EDDC Offset: 0x418ADDC VA: 0x418EDDC
	private void UpdateSortOrder() { }

	// RVA: 0x418F0A8 Offset: 0x418B0A8 VA: 0x418F0A8
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI
public class ViewTools // TypeDefIndex: 21045
{
	// Methods

	// RVA: 0x418F0B8 Offset: 0x418B0B8 VA: 0x418F0B8
	public static Dictionary<string, GameObject> CollectAllGameObjects(GameObject rootGameObject) { }

	// RVA: 0x418F138 Offset: 0x418B138 VA: 0x418F138
	private static void CollectAllGameObject(Dictionary<string, GameObject> objectMap, GameObject gameObject) { }

	// RVA: 0x418F274 Offset: 0x418B274 VA: 0x418F274
	public static List<GameObject> GetAllGameObjects(GameObject rootGameObject) { }

	// RVA: 0x418F2F4 Offset: 0x418B2F4 VA: 0x418F2F4
	private static void CollectAllGameObject(List<GameObject> objectMap, GameObject gameObject) { }

	// RVA: -1 Offset: -1
	public static T GetRegComponent<T>(ComponentRegister cr, string regedname) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x477FFAC Offset: 0x477BFAC VA: 0x477FFAC
	|-ViewTools.GetRegComponent<object>
	*/

	// RVA: 0x418F40C Offset: 0x418B40C VA: 0x418F40C
	public static GameObject GetRegedGameObject(ComponentRegister cr, string regedname) { }

	// RVA: -1 Offset: -1
	public static T GetChildComponent<T>(GameObject gobj, string pathname) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x477FE9C Offset: 0x477BE9C VA: 0x477FE9C
	|-ViewTools.GetChildComponent<object>
	*/

	// RVA: 0x418F544 Offset: 0x418B544 VA: 0x418F544
	public static Transform GetFindChild(Transform tf, string pathname) { }

	// RVA: 0x418F680 Offset: 0x418B680 VA: 0x418F680
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.WindowHelper
public class UGUIBottomWindowHelper : MonoBehaviour // TypeDefIndex: 21046
{
	// Fields
	public List<RectTransform> list; // 0x20

	// Methods

	// RVA: 0x418F688 Offset: 0x418B688 VA: 0x418F688
	private void Awake() { }

	// RVA: 0x418F68C Offset: 0x418B68C VA: 0x418F68C
	public void OnRefresh() { }

	// RVA: 0x418F7D0 Offset: 0x418B7D0 VA: 0x418F7D0
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.WindowHelper
public class UGUIFullWindowHelper : MonoBehaviour // TypeDefIndex: 21047
{
	// Fields
	public List<RectTransform> list; // 0x20

	// Methods

	// RVA: 0x418F7D8 Offset: 0x418B7D8 VA: 0x418F7D8
	private void Awake() { }

	// RVA: 0x418F8F0 Offset: 0x418B8F0 VA: 0x418F8F0
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.WindowHelper
public class UGUIPaddingWindowHelper : MonoBehaviour // TypeDefIndex: 21048
{
	// Fields
	public RectTransform m_target; // 0x20
	public RectOffset m_addPadding; // 0x28
	private Vector2 m_offsetMin; // 0x30
	private Vector2 m_offectMax; // 0x38
	[Header("忽略顶部")]
	public bool m_ignoreTop; // 0x40
	[Header("忽略底部")]
	public bool m_ignoreBottom; // 0x41

	// Methods

	// RVA: 0x418F8F8 Offset: 0x418B8F8 VA: 0x418F8F8
	private void Awake() { }

	// RVA: 0x418F8FC Offset: 0x418B8FC VA: 0x418F8FC
	public void OnRefresh() { }

	// RVA: 0x418FAE4 Offset: 0x418BAE4 VA: 0x418FAE4
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.WindowHelper
public class UGUITopWindowHelper : MonoBehaviour // TypeDefIndex: 21049
{
	// Fields
	public List<RectTransform> list; // 0x20

	// Methods

	// RVA: 0x418FB50 Offset: 0x418BB50 VA: 0x418FB50
	private void Awake() { }

	// RVA: 0x418FB54 Offset: 0x418BB54 VA: 0x418FB54
	public void OnRefresh() { }

	// RVA: 0x418FC98 Offset: 0x418BC98 VA: 0x418FC98
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UEventDelegate.Parameter // TypeDefIndex: 21050
{
	// Fields
	public Object obj; // 0x10
	public string field; // 0x18
	private object mValue; // 0x20
	public Type expectedType; // 0x28
	public bool cached; // 0x30
	public PropertyInfo propInfo; // 0x38
	public FieldInfo fieldInfo; // 0x40

	// Properties
	public object value { get; set; }
	public Type type { get; }

	// Methods

	// RVA: 0x4190B58 Offset: 0x418CB58 VA: 0x4190B58
	public void .ctor() { }

	// RVA: 0x41923B0 Offset: 0x418E3B0 VA: 0x41923B0
	public void .ctor(Object obj, string field) { }

	// RVA: 0x4192474 Offset: 0x418E474 VA: 0x4192474
	public void .ctor(object val) { }

	// RVA: 0x41912BC Offset: 0x418D2BC VA: 0x41912BC
	public object get_value() { }

	// RVA: 0x419251C Offset: 0x418E51C VA: 0x419251C
	public void set_value(object value) { }

	// RVA: 0x4191538 Offset: 0x418D538 VA: 0x4191538
	public Type get_type() { }
}

// Namespace: 
public sealed class UEventDelegate.Callback : MulticastDelegate // TypeDefIndex: 21051
{
	// Methods

	// RVA: 0x4192524 Offset: 0x418E524 VA: 0x4192524
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x41925C0 Offset: 0x418E5C0 VA: 0x41925C0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x41925D4 Offset: 0x418E5D4 VA: 0x41925D4 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x41925F4 Offset: 0x418E5F4 VA: 0x41925F4 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Framework.Logic.UI.UTweener
[Serializable]
public class UEventDelegate // TypeDefIndex: 21052
{
	// Fields
	[SerializeField]
	private MonoBehaviour mTarget; // 0x10
	[SerializeField]
	private string mMethodName; // 0x18
	[SerializeField]
	private UEventDelegate.Parameter[] mParameters; // 0x20
	public bool oneShot; // 0x28
	private UEventDelegate.Callback mCachedCallback; // 0x30
	private bool mRawDelegate; // 0x38
	private bool mCached; // 0x39
	private MethodInfo mMethod; // 0x40
	private ParameterInfo[] mParameterInfos; // 0x48
	private object[] mArgs; // 0x50
	private static int s_Hash; // 0x0

	// Properties
	public MonoBehaviour target { get; set; }
	public string methodName { get; set; }
	public UEventDelegate.Parameter[] parameters { get; }
	public bool isValid { get; }
	public bool isEnabled { get; }

	// Methods

	// RVA: 0x418FCA0 Offset: 0x418BCA0 VA: 0x418FCA0
	public MonoBehaviour get_target() { }

	// RVA: 0x418FCA8 Offset: 0x418BCA8 VA: 0x418FCA8
	public void set_target(MonoBehaviour value) { }

	// RVA: 0x418FD00 Offset: 0x418BD00 VA: 0x418FD00
	public string get_methodName() { }

	// RVA: 0x418FD08 Offset: 0x418BD08 VA: 0x418FD08
	public void set_methodName(string value) { }

	// RVA: 0x418FD60 Offset: 0x418BD60 VA: 0x418FD60
	public UEventDelegate.Parameter[] get_parameters() { }

	// RVA: 0x419046C Offset: 0x418C46C VA: 0x419046C
	public bool get_isValid() { }

	// RVA: 0x4190518 Offset: 0x418C518 VA: 0x4190518
	public bool get_isEnabled() { }

	// RVA: 0x41905F0 Offset: 0x418C5F0 VA: 0x41905F0
	public void .ctor() { }

	// RVA: 0x41905F8 Offset: 0x418C5F8 VA: 0x41905F8
	public void .ctor(UEventDelegate.Callback call) { }

	// RVA: 0x41907E0 Offset: 0x418C7E0 VA: 0x41907E0
	public void .ctor(MonoBehaviour target, string methodName) { }

	// RVA: 0x4190854 Offset: 0x418C854 VA: 0x4190854
	private static string GetMethodName(UEventDelegate.Callback callback) { }

	// RVA: 0x4190880 Offset: 0x418C880 VA: 0x4190880
	private static bool IsValid(UEventDelegate.Callback callback) { }

	// RVA: 0x41908A4 Offset: 0x418C8A4 VA: 0x41908A4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4190A80 Offset: 0x418CA80 VA: 0x4190A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4190624 Offset: 0x418C624 VA: 0x4190624
	private void Set(UEventDelegate.Callback call) { }

	// RVA: 0x4190814 Offset: 0x418C814 VA: 0x4190814
	public void Set(MonoBehaviour target, string methodName) { }

	// RVA: 0x418FD84 Offset: 0x418BD84 VA: 0x418FD84
	private void Cache() { }

	// RVA: 0x4190BEC Offset: 0x418CBEC VA: 0x4190BEC
	public bool Execute() { }

	// RVA: 0x4190AD8 Offset: 0x418CAD8 VA: 0x4190AD8
	public void Clear() { }

	// RVA: 0x4191608 Offset: 0x418D608 VA: 0x4191608 Slot: 3
	public override string ToString() { }

	// RVA: 0x4191754 Offset: 0x418D754 VA: 0x4191754
	public static void Execute(List<UEventDelegate> list) { }

	// RVA: 0x4191924 Offset: 0x418D924 VA: 0x4191924
	public static bool IsValid(List<UEventDelegate> list) { }

	// RVA: 0x41919C0 Offset: 0x418D9C0 VA: 0x41919C0
	public static UEventDelegate Set(List<UEventDelegate> list, UEventDelegate.Callback callback) { }

	// RVA: 0x4191AE4 Offset: 0x418DAE4 VA: 0x4191AE4
	public static void Set(List<UEventDelegate> list, UEventDelegate del) { }

	// RVA: 0x4191BCC Offset: 0x418DBCC VA: 0x4191BCC
	public static UEventDelegate Add(List<UEventDelegate> list, UEventDelegate.Callback callback) { }

	// RVA: 0x4191C34 Offset: 0x418DC34 VA: 0x4191C34
	public static UEventDelegate Add(List<UEventDelegate> list, UEventDelegate.Callback callback, bool oneShot) { }

	// RVA: 0x4191DE8 Offset: 0x418DDE8 VA: 0x4191DE8
	public static void Add(List<UEventDelegate> list, UEventDelegate ev) { }

	// RVA: 0x4191E58 Offset: 0x418DE58 VA: 0x4191E58
	public static void Add(List<UEventDelegate> list, UEventDelegate ev, bool oneShot) { }

	// RVA: 0x419219C Offset: 0x418E19C VA: 0x419219C
	public static bool Remove(List<UEventDelegate> list, UEventDelegate.Callback callback) { }

	// RVA: 0x419226C Offset: 0x418E26C VA: 0x419226C
	public static bool Remove(List<UEventDelegate> list, UEventDelegate ev) { }

	// RVA: 0x419233C Offset: 0x418E33C VA: 0x419233C
	private static void .cctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
public class URealTime : MonoBehaviour // TypeDefIndex: 21053
{
	// Properties
	public static float time { get; }
	public static float deltaTime { get; }

	// Methods

	// RVA: 0x4192600 Offset: 0x418E600 VA: 0x4192600
	public static float get_time() { }

	// RVA: 0x4192608 Offset: 0x418E608 VA: 0x4192608
	public static float get_deltaTime() { }

	// RVA: 0x4192610 Offset: 0x418E610 VA: 0x4192610
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
[AddComponentMenu("Tools/UGUI/Tween/Tween Color")]
public class UTweenColor : UTweener // TypeDefIndex: 21054
{
	// Fields
	public Color from; // 0x80
	public Color to; // 0x90
	private bool mCached; // 0xA0
	private Material mMat; // 0xA8
	private Light mLight; // 0xB0
	private SpriteRenderer mSr; // 0xB8
	private CanvasRenderer mCanvas; // 0xC0

	// Properties
	[Obsolete("Use 'value' instead")]
	public Color color { get; set; }
	public Color value { get; set; }

	// Methods

	// RVA: 0x4192618 Offset: 0x418E618 VA: 0x4192618
	private void Cache() { }

	// RVA: 0x4192768 Offset: 0x418E768 VA: 0x4192768
	public Color get_color() { }

	// RVA: 0x41928D0 Offset: 0x418E8D0 VA: 0x41928D0
	public void set_color(Color value) { }

	// RVA: 0x419276C Offset: 0x418E76C VA: 0x419276C
	public Color get_value() { }

	// RVA: 0x41928D4 Offset: 0x418E8D4 VA: 0x41928D4
	public void set_value(Color value) { }

	// RVA: 0x4192AD0 Offset: 0x418EAD0 VA: 0x4192AD0 Slot: 5
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x4192B04 Offset: 0x418EB04 VA: 0x4192B04
	public static UTweenColor Begin(GameObject go, float duration, Color color) { }

	[ContextMenu("Set 'From' to current value")]
	// RVA: 0x4192D34 Offset: 0x418ED34 VA: 0x4192D34 Slot: 6
	public override void SetStartToCurrentValue() { }

	[ContextMenu("Set 'To' to current value")]
	// RVA: 0x4192D50 Offset: 0x418ED50 VA: 0x4192D50 Slot: 7
	public override void SetEndToCurrentValue() { }

	[ContextMenu("Assume value of 'From'")]
	// RVA: 0x4192D6C Offset: 0x418ED6C VA: 0x4192D6C
	private void SetCurrentValueToStart() { }

	[ContextMenu("Assume value of 'To'")]
	// RVA: 0x4192D78 Offset: 0x418ED78 VA: 0x4192D78
	private void SetCurrentValueToEnd() { }

	// RVA: 0x4192D84 Offset: 0x418ED84 VA: 0x4192D84
	public void .ctor() { }
}

// Namespace: 
public enum UTweener.Method // TypeDefIndex: 21055
{
	// Fields
	public int value__; // 0x0
	public const UTweener.Method Linear = 0;
	public const UTweener.Method EaseIn = 1;
	public const UTweener.Method EaseOut = 2;
	public const UTweener.Method EaseInOut = 3;
	public const UTweener.Method BounceIn = 4;
	public const UTweener.Method BounceOut = 5;
}

// Namespace: 
public enum UTweener.Style // TypeDefIndex: 21056
{
	// Fields
	public int value__; // 0x0
	public const UTweener.Style Once = 0;
	public const UTweener.Style Loop = 1;
	public const UTweener.Style PingPong = 2;
}

// Namespace: 
public enum UTweener.Direction // TypeDefIndex: 21057
{
	// Fields
	public int value__; // 0x0
	public const UTweener.Direction Reverse = -1;
	public const UTweener.Direction Toggle = 0;
	public const UTweener.Direction Forward = 1;
}

// Namespace: Framework.Logic.UI.UTweener
public abstract class UTweener : MonoBehaviour // TypeDefIndex: 21058
{
	// Fields
	public static UTweener current; // 0x0
	[HideInInspector]
	public UTweener.Method method; // 0x20
	public UTweener.Style style; // 0x24
	public AnimationCurve animationCurve; // 0x28
	public bool ignoreTimeScale; // 0x30
	public float delay; // 0x34
	public float duration; // 0x38
	[HideInInspector]
	public bool steeperCurves; // 0x3C
	public int tweenGroup; // 0x40
	public List<UEventDelegate> onFinished; // 0x48
	[HideInInspector]
	public GameObject eventReceiver; // 0x50
	[HideInInspector]
	public string callWhenFinished; // 0x58
	private bool mStarted; // 0x60
	private float mStartTime; // 0x64
	private float mDuration; // 0x68
	private float mAmountPerDelta; // 0x6C
	private float mFactor; // 0x70
	private List<UEventDelegate> mTemp; // 0x78

	// Properties
	public float amountPerDelta { get; }
	public float tweenFactor { get; set; }
	public UTweener.Direction direction { get; }

	// Methods

	// RVA: 0x4192F4C Offset: 0x418EF4C VA: 0x4192F4C
	public float get_amountPerDelta() { }

	// RVA: 0x4192F98 Offset: 0x418EF98 VA: 0x4192F98
	public float get_tweenFactor() { }

	// RVA: 0x4192FA0 Offset: 0x418EFA0 VA: 0x4192FA0
	public void set_tweenFactor(float value) { }

	// RVA: 0x4192FBC Offset: 0x418EFBC VA: 0x4192FBC
	public UTweener.Direction get_direction() { }

	// RVA: 0x4193014 Offset: 0x418F014 VA: 0x4193014
	private void Reset() { }

	// RVA: 0x419304C Offset: 0x418F04C VA: 0x419304C Slot: 4
	protected virtual void Start() { }

	// RVA: 0x4193050 Offset: 0x418F050 VA: 0x4193050
	private void Update() { }

	// RVA: 0x41934BC Offset: 0x418F4BC VA: 0x41934BC
	public void SetOnFinished(UEventDelegate.Callback del) { }

	// RVA: 0x4193524 Offset: 0x418F524 VA: 0x4193524
	public void SetOnFinished(UEventDelegate del) { }

	// RVA: 0x419358C Offset: 0x418F58C VA: 0x419358C
	public void AddOnFinished(UEventDelegate.Callback del) { }

	// RVA: 0x41935F4 Offset: 0x418F5F4 VA: 0x41935F4
	public void AddOnFinished(UEventDelegate del) { }

	// RVA: 0x419365C Offset: 0x418F65C VA: 0x419365C
	public void RemoveOnFinished(UEventDelegate del) { }

	// RVA: 0x41936D0 Offset: 0x418F6D0 VA: 0x41936D0
	private void OnDisable() { }

	// RVA: 0x4192BCC Offset: 0x418EBCC VA: 0x4192BCC
	public void Sample(float factor, bool isFinished) { }

	// RVA: 0x41936D8 Offset: 0x418F6D8 VA: 0x41936D8
	private float BounceLogic(float val) { }

	[Obsolete("Use PlayForward() instead")]
	// RVA: 0x4193790 Offset: 0x418F790 VA: 0x4193790
	public void Play() { }

	// RVA: 0x4193818 Offset: 0x418F818 VA: 0x4193818
	public void PlayForward() { }

	// RVA: 0x4193820 Offset: 0x418F820 VA: 0x4193820
	public void PlayReverse() { }

	// RVA: 0x4193798 Offset: 0x418F798 VA: 0x4193798
	public void Play(bool forward) { }

	// RVA: 0x4193828 Offset: 0x418F828 VA: 0x4193828
	public void ResetToBeginning() { }

	// RVA: 0x4193890 Offset: 0x418F890 VA: 0x4193890
	public void Toggle() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnUpdate(float factor, bool isFinished);

	// RVA: 0x41938FC Offset: 0x418F8FC VA: 0x41938FC Slot: 6
	public virtual void SetStartToCurrentValue() { }

	// RVA: 0x4193900 Offset: 0x418F900 VA: 0x4193900 Slot: 7
	public virtual void SetEndToCurrentValue() { }

	// RVA: -1 Offset: -1
	public static T Begin<T>(GameObject go, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x473C194 Offset: 0x4738194 VA: 0x473C194
	|-UTweener.Begin<object>
	*/

	// RVA: 0x4192D90 Offset: 0x418ED90 VA: 0x4192D90
	protected void .ctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
public enum TweenPositionType // TypeDefIndex: 21059
{
	// Fields
	public int value__; // 0x0
	public const TweenPositionType Position = 0;
	public const TweenPositionType LocalPosition = 1;
	public const TweenPositionType AnchoredPosition = 2;
}

// Namespace: Framework.Logic.UI.UTweener
[AddComponentMenu("Tools/UGUI/Tween/Tween Position")]
public class UTweenPosition : UTweener // TypeDefIndex: 21060
{
	// Fields
	public Vector3 from; // 0x80
	public Vector3 to; // 0x8C
	public TweenPositionType PositionType; // 0x98
	private Transform mTrans; // 0xA0
	private RectTransform mRectTrans; // 0xA8

	// Properties
	public Transform cachedTransform { get; }
	public RectTransform cachedRectTransform { get; }
	public Vector3 value { get; set; }

	// Methods

	// RVA: 0x4193904 Offset: 0x418F904 VA: 0x4193904
	public Transform get_cachedTransform() { }

	// RVA: 0x4193998 Offset: 0x418F998 VA: 0x4193998
	public RectTransform get_cachedRectTransform() { }

	// RVA: 0x4193A40 Offset: 0x418FA40 VA: 0x4193A40
	public Vector3 get_value() { }

	// RVA: 0x4193AE8 Offset: 0x418FAE8 VA: 0x4193AE8
	public void set_value(Vector3 value) { }

	// RVA: 0x4193BA8 Offset: 0x418FBA8 VA: 0x4193BA8
	private void Awake() { }

	// RVA: 0x4193BAC Offset: 0x418FBAC VA: 0x4193BAC Slot: 5
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x4193BE4 Offset: 0x418FBE4 VA: 0x4193BE4
	public static UTweenPosition Begin(GameObject go, float duration, Vector3 pos) { }

	// RVA: 0x4193C9C Offset: 0x418FC9C VA: 0x4193C9C
	public static UTweenPosition Begin(GameObject go, float duration, Vector3 pos, TweenPositionType positionType) { }

	[ContextMenu("Set 'From' to current value")]
	// RVA: 0x4193D64 Offset: 0x418FD64 VA: 0x4193D64 Slot: 6
	public override void SetStartToCurrentValue() { }

	[ContextMenu("Set 'To' to current value")]
	// RVA: 0x4193D80 Offset: 0x418FD80 VA: 0x4193D80 Slot: 7
	public override void SetEndToCurrentValue() { }

	[ContextMenu("Assume value of 'From'")]
	// RVA: 0x4193D9C Offset: 0x418FD9C VA: 0x4193D9C
	private void SetCurrentValueToStart() { }

	[ContextMenu("Assume value of 'To'")]
	// RVA: 0x4193DA8 Offset: 0x418FDA8 VA: 0x4193DA8
	private void SetCurrentValueToEnd() { }

	// RVA: 0x4193DB4 Offset: 0x418FDB4 VA: 0x4193DB4
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
[AddComponentMenu("Tools/UGUI/Tween/Tween Rotation")]
public class UTweenRotation : UTweener // TypeDefIndex: 21061
{
	// Fields
	public Vector3 from; // 0x80
	public Vector3 to; // 0x8C
	public bool quaternionLerp; // 0x98
	private Transform mTrans; // 0xA0

	// Properties
	public Transform cachedTransform { get; }
	[Obsolete("Use 'value' instead")]
	public Quaternion rotation { get; set; }
	public Quaternion value { get; set; }

	// Methods

	// RVA: 0x4193DB8 Offset: 0x418FDB8 VA: 0x4193DB8
	public Transform get_cachedTransform() { }

	// RVA: 0x4193E4C Offset: 0x418FE4C VA: 0x4193E4C
	public Quaternion get_rotation() { }

	// RVA: 0x4193E6C Offset: 0x418FE6C VA: 0x4193E6C
	public void set_rotation(Quaternion value) { }

	// RVA: 0x4193E50 Offset: 0x418FE50 VA: 0x4193E50
	public Quaternion get_value() { }

	// RVA: 0x4193E70 Offset: 0x418FE70 VA: 0x4193E70
	public void set_value(Quaternion value) { }

	// RVA: 0x4193EBC Offset: 0x418FEBC VA: 0x4193EBC Slot: 5
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x4193FE0 Offset: 0x418FFE0 VA: 0x4193FE0
	public static UTweenRotation Begin(GameObject go, float duration, Quaternion rot) { }

	[ContextMenu("Set 'From' to current value")]
	// RVA: 0x41940F8 Offset: 0x41900F8 VA: 0x41940F8 Slot: 6
	public override void SetStartToCurrentValue() { }

	[ContextMenu("Set 'To' to current value")]
	// RVA: 0x4194138 Offset: 0x4190138 VA: 0x4194138 Slot: 7
	public override void SetEndToCurrentValue() { }

	[ContextMenu("Assume value of 'From'")]
	// RVA: 0x4194178 Offset: 0x4190178 VA: 0x4194178
	private void SetCurrentValueToStart() { }

	[ContextMenu("Assume value of 'To'")]
	// RVA: 0x41941B0 Offset: 0x41901B0 VA: 0x41941B0
	private void SetCurrentValueToEnd() { }

	// RVA: 0x41941E8 Offset: 0x41901E8 VA: 0x41941E8
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
[AddComponentMenu("Tools/UGUI/Tween/Tween Scale")]
public class UTweenScale : UTweener // TypeDefIndex: 21062
{
	// Fields
	public Vector3 from; // 0x80
	public Vector3 to; // 0x8C
	private Transform mTrans; // 0x98

	// Properties
	public Transform cachedTransform { get; }
	public Vector3 value { get; set; }
	[Obsolete("Use 'value' instead")]
	public Vector3 scale { get; set; }

	// Methods

	// RVA: 0x41941EC Offset: 0x41901EC VA: 0x41941EC
	public Transform get_cachedTransform() { }

	// RVA: 0x4194280 Offset: 0x4190280 VA: 0x4194280
	public Vector3 get_value() { }

	// RVA: 0x419429C Offset: 0x419029C VA: 0x419429C
	public void set_value(Vector3 value) { }

	// RVA: 0x41942E0 Offset: 0x41902E0 VA: 0x41942E0
	public Vector3 get_scale() { }

	// RVA: 0x41942E4 Offset: 0x41902E4 VA: 0x41942E4
	public void set_scale(Vector3 value) { }

	// RVA: 0x41942E8 Offset: 0x41902E8 VA: 0x41942E8 Slot: 5
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x4194320 Offset: 0x4190320 VA: 0x4194320
	public static UTweenScale Begin(GameObject go, float duration, Vector3 scale) { }

	[ContextMenu("Set 'From' to current value")]
	// RVA: 0x41943D8 Offset: 0x41903D8 VA: 0x41943D8 Slot: 6
	public override void SetStartToCurrentValue() { }

	[ContextMenu("Set 'To' to current value")]
	// RVA: 0x41943F4 Offset: 0x41903F4 VA: 0x41943F4 Slot: 7
	public override void SetEndToCurrentValue() { }

	[ContextMenu("Assume value of 'From'")]
	// RVA: 0x4194410 Offset: 0x4190410 VA: 0x4194410
	private void SetCurrentValueToStart() { }

	[ContextMenu("Assume value of 'To'")]
	// RVA: 0x419441C Offset: 0x419041C VA: 0x419441C
	private void SetCurrentValueToEnd() { }

	// RVA: 0x4194428 Offset: 0x4190428 VA: 0x4194428
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UTweener
[AddComponentMenu("Tools/UGUI/Tween/Tween Transform")]
public class UTweenTransform : UTweener // TypeDefIndex: 21063
{
	// Fields
	public Transform from; // 0x80
	public Transform to; // 0x88
	public bool parentWhenFinished; // 0x90
	private Transform mTrans; // 0x98
	private Vector3 mPos; // 0xA0
	private Quaternion mRot; // 0xAC
	private Vector3 mScale; // 0xBC

	// Methods

	// RVA: 0x4194498 Offset: 0x4190498 VA: 0x4194498 Slot: 5
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x4194850 Offset: 0x4190850 VA: 0x4194850
	public static UTweenTransform Begin(GameObject go, float duration, Transform to) { }

	// RVA: 0x419485C Offset: 0x419085C VA: 0x419485C
	public static UTweenTransform Begin(GameObject go, float duration, Transform from, Transform to) { }

	// RVA: 0x419491C Offset: 0x419091C VA: 0x419491C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UIParticleSystem
internal static class SetPropertyUtility // TypeDefIndex: 21064
{
	// Methods

	// RVA: 0x4194920 Offset: 0x4190920 VA: 0x4194920
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F219C Offset: 0x46EE19C VA: 0x46F219C
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x46F2238 Offset: 0x46EE238 VA: 0x46F2238
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F2140 Offset: 0x46EE140 VA: 0x46F2140
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: Framework.Logic.UI.UIParticleSystem
[RequireComponent(typeof(ParticleSystem), typeof(CanvasRenderer))]
public class UIParticleSystem : MaskableGraphic // TypeDefIndex: 21065
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_ParticleSystem")]
	private ParticleSystem m_ParticleSystem; // 0xD8
	[FormerlySerializedAs("m_RenderMode")]
	[SerializeField]
	[Tooltip("Render mode of particles")]
	private UiParticleRenderMode m_RenderMode; // 0xE0
	[FormerlySerializedAs("m_StretchedSpeedScale")]
	[SerializeField]
	[Tooltip("Speed Scale for streched billboards")]
	private float m_StretchedSpeedScale; // 0xE4
	[FormerlySerializedAs("m_StretchedLenghScale")]
	[SerializeField]
	[Tooltip("Speed Scale for streched billboards")]
	private float m_StretchedLenghScale; // 0xE8
	[FormerlySerializedAs("m_IgnoreTimescale")]
	[SerializeField]
	[Tooltip("If true, particles ignore timescale")]
	private bool m_IgnoreTimescale; // 0xEC
	private ParticleSystemRenderer m_ParticleSystemRenderer; // 0xF0
	private ParticleSystem.Particle[] m_Particles; // 0xF8

	// Properties
	public ParticleSystem ParticleSystem { get; set; }
	public override Texture mainTexture { get; }
	public UiParticleRenderMode RenderMode { get; set; }

	// Methods

	// RVA: 0x4194968 Offset: 0x4190968 VA: 0x4194968
	public ParticleSystem get_ParticleSystem() { }

	// RVA: 0x4194970 Offset: 0x4190970 VA: 0x4194970
	public void set_ParticleSystem(ParticleSystem value) { }

	// RVA: 0x41949F0 Offset: 0x41909F0 VA: 0x41949F0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x4194B18 Offset: 0x4190B18 VA: 0x4194B18
	public UiParticleRenderMode get_RenderMode() { }

	// RVA: 0x4194B20 Offset: 0x4190B20 VA: 0x4194B20
	public void set_RenderMode(UiParticleRenderMode value) { }

	// RVA: 0x4194BA0 Offset: 0x4190BA0 VA: 0x4194BA0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x4194CD0 Offset: 0x4190CD0 VA: 0x4194CD0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x4194D64 Offset: 0x4190D64 VA: 0x4194D64 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x4194EB4 Offset: 0x4190EB4 VA: 0x4194EB4 Slot: 65
	protected virtual void Update() { }

	// RVA: 0x4194FE0 Offset: 0x4190FE0 VA: 0x4194FE0
	private void InitParticlesBuffer() { }

	// RVA: 0x4194DFC Offset: 0x4190DFC VA: 0x4194DFC
	private void GenerateParticlesBillboards(VertexHelper vh) { }

	// RVA: 0x41950A8 Offset: 0x41910A8 VA: 0x41950A8
	private void DrawParticleBillboard(ParticleSystem.Particle particle, VertexHelper vh) { }

	// RVA: 0x419587C Offset: 0x419187C VA: 0x419587C
	private void EvaluateQuadUVs(Vector2[] uvs) { }

	// RVA: 0x41958D8 Offset: 0x41918D8 VA: 0x41958D8
	private void EvaluateTexturesheetUVs(ParticleSystem.Particle particle, float timeAlive, Vector2[] uvs) { }

	// RVA: 0x4195530 Offset: 0x4191530 VA: 0x4195530
	private void GetStrechedBillboardsSizeAndRotation(ParticleSystem.Particle particle, float timeAlive01, ref Vector3 size3D, out Quaternion rotation) { }

	// RVA: 0x4195B8C Offset: 0x4191B8C VA: 0x4195B8C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UIParticleSystem
public enum UiParticleRenderMode // TypeDefIndex: 21066
{
	// Fields
	public int value__; // 0x0
	public const UiParticleRenderMode Billboard = 0;
	public const UiParticleRenderMode StreachedBillboard = 1;
}

// Namespace: Framework.Logic.UI.UIAtlas
public class UAtlasData : ScriptableObject // TypeDefIndex: 21067
{
	// Fields
	public int m_padding; // 0x18
	public bool m_unityPacker; // 0x1C
	public bool m_forceSquare; // 0x1D
	public bool m_texturePacker; // 0x1E
	public Texture2D m_texture; // 0x20
	public Material m_material; // 0x28
	public USpriteData[] m_sprites; // 0x30
	private Dictionary<string, USpriteData> m_spriteDataDic; // 0x38

	// Methods

	// RVA: 0x4195B9C Offset: 0x4191B9C VA: 0x4195B9C
	private void OnEnable() { }

	// RVA: 0x4195C98 Offset: 0x4191C98 VA: 0x4195C98
	private void OnDestroy() { }

	// RVA: 0x4195CE8 Offset: 0x4191CE8 VA: 0x4195CE8
	public USpriteData GetSpriteDataByName(string name) { }

	// RVA: 0x4195DCC Offset: 0x4191DCC VA: 0x4195DCC
	public Sprite GetSpriteByName(string spriteName) { }

	// RVA: 0x4195DE4 Offset: 0x4191DE4 VA: 0x4195DE4
	public Sprite GetSpriteByNameOrRect(string spriteName) { }

	// RVA: 0x4195ED8 Offset: 0x4191ED8 VA: 0x4195ED8
	public Texture2D GetSpriteTextureByUISpriteData(USpriteData spriteData) { }

	// RVA: 0x4195F90 Offset: 0x4191F90 VA: 0x4195F90
	public Texture2D GetSpriteTextureBySprite(Sprite sprite) { }

	// RVA: 0x41963EC Offset: 0x41923EC VA: 0x41963EC
	public Texture2D GetSpriteTextureByName(string spriteName) { }

	// RVA: 0x4196484 Offset: 0x4192484 VA: 0x4196484
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UIAtlas
public class UDynamicTexturePacker // TypeDefIndex: 21068
{
	// Methods

	// RVA: 0x419649C Offset: 0x419249C VA: 0x419649C
	public static UAtlasData DynamicTexturePacker(ref Texture2D texture, Texture2D[] textures, int padding, int maxSize, bool forceSquare) { }

	// RVA: 0x41970FC Offset: 0x41930FC VA: 0x41970FC
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.UIAtlas
[Serializable]
public class USpriteData // TypeDefIndex: 21069
{
	// Fields
	public string m_name; // 0x10
	public Rect m_rect; // 0x18
	public Vector2 m_pivot; // 0x28
	public Vector2[] m_uv; // 0x30
	public Sprite m_sprite; // 0x38
	public string m_sourceTextureGuid; // 0x40

	// Methods

	// RVA: 0x41970F4 Offset: 0x41930F4 VA: 0x41970F4
	public void .ctor() { }
}

// Namespace: 
public enum UTexturePacker.FreeRectChoiceHeuristic // TypeDefIndex: 21070
{
	// Fields
	public int value__; // 0x0
	public const UTexturePacker.FreeRectChoiceHeuristic RectBestShortSideFit = 0;
	public const UTexturePacker.FreeRectChoiceHeuristic RectBestLongSideFit = 1;
	public const UTexturePacker.FreeRectChoiceHeuristic RectBestAreaFit = 2;
	public const UTexturePacker.FreeRectChoiceHeuristic RectBottomLeftRule = 3;
	public const UTexturePacker.FreeRectChoiceHeuristic RectContactPointRule = 4;
}

// Namespace: 
private struct UTexturePacker.Storage // TypeDefIndex: 21071
{
	// Fields
	public Rect rect; // 0x0
	public bool paddingX; // 0x10
	public bool paddingY; // 0x11
}

// Namespace: Framework.Logic.UI.UIAtlas
public class UTexturePacker // TypeDefIndex: 21072
{
	// Fields
	public int binWidth; // 0x10
	public int binHeight; // 0x14
	public bool allowRotations; // 0x18
	public List<Rect> usedRectangles; // 0x20
	public List<Rect> freeRectangles; // 0x28

	// Methods

	// RVA: 0x4197104 Offset: 0x4193104 VA: 0x4197104
	public void .ctor(int width, int height, bool rotations) { }

	// RVA: 0x41971D8 Offset: 0x41931D8 VA: 0x41971D8
	public void Init(int width, int height, bool rotations) { }

	// RVA: 0x4196B44 Offset: 0x4192B44 VA: 0x4196B44
	public static Rect[] PackTextures(Texture2D texture, Texture2D[] textures, int width, int height, int padding, int maxSize, bool forceSquareAtlas = True) { }

	// RVA: 0x41972C0 Offset: 0x41932C0 VA: 0x41972C0
	public Rect Insert(int width, int height, UTexturePacker.FreeRectChoiceHeuristic method) { }

	// RVA: 0x4198B5C Offset: 0x4194B5C VA: 0x4198B5C
	public void Insert(List<Rect> rects, List<Rect> dst, UTexturePacker.FreeRectChoiceHeuristic method) { }

	// RVA: 0x4198E20 Offset: 0x4194E20 VA: 0x4198E20
	private void PlaceRect(Rect node) { }

	// RVA: 0x4198D5C Offset: 0x4194D5C VA: 0x4198D5C
	private Rect ScoreRect(int width, int height, UTexturePacker.FreeRectChoiceHeuristic method, ref int score1, ref int score2) { }

	// RVA: 0x4198F80 Offset: 0x4194F80 VA: 0x4198F80
	public float Occupancy() { }

	// RVA: 0x41978C8 Offset: 0x41938C8 VA: 0x41978C8
	private Rect FindPositionForNewNodeBottomLeft(int width, int height, ref int bestY, ref int bestX) { }

	// RVA: 0x4197500 Offset: 0x4193500 VA: 0x4197500
	private Rect FindPositionForNewNodeBestShortSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit) { }

	// RVA: 0x4197EA8 Offset: 0x4193EA8 VA: 0x4197EA8
	private Rect FindPositionForNewNodeBestLongSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit) { }

	// RVA: 0x4198270 Offset: 0x4194270 VA: 0x4198270
	private Rect FindPositionForNewNodeBestAreaFit(int width, int height, ref int bestAreaFit, ref int bestShortSideFit) { }

	// RVA: 0x419906C Offset: 0x419506C VA: 0x419906C
	private int CommonIntervalLength(int i1start, int i1end, int i2start, int i2end) { }

	// RVA: 0x4199098 Offset: 0x4195098 VA: 0x4199098
	private int ContactPointScoreNode(int x, int y, int width, int height) { }

	// RVA: 0x4197BB4 Offset: 0x4193BB4 VA: 0x4197BB4
	private Rect FindPositionForNewNodeContactPoint(int width, int height, ref int bestContactScore) { }

	// RVA: 0x41986A0 Offset: 0x41946A0 VA: 0x41986A0
	private bool SplitFreeNode(Rect freeNode, ref Rect usedNode) { }

	// RVA: 0x4198984 Offset: 0x4194984 VA: 0x4198984
	private void PruneFreeList() { }

	// RVA: 0x419938C Offset: 0x419538C VA: 0x419938C
	private bool IsContainedIn(Rect a, Rect b) { }
}

// Namespace: Framework.Logic.UI.SuperScrollUI
public class SuperScrollBottomLoadingItem : MonoBehaviour // TypeDefIndex: 21073
{
	// Fields
	public RectTransform RotateRTF; // 0x20
	public RectTransform ScaleRTF; // 0x28
	public float RotateSpeed; // 0x30
	public float MaxScaleSize; // 0x34
	public GameObject ObjNoMoreData; // 0x38
	public GameObject ObjLoading; // 0x40
	private LoopListViewItem2 mCurrentItem; // 0x48
	private LoopListView2 mScroll; // 0x50
	private RectTransform mView; // 0x58

	// Methods

	// RVA: 0x4199690 Offset: 0x4195690 VA: 0x4199690
	public void SetActive(bool show) { }

	// RVA: 0x4199768 Offset: 0x4195768 VA: 0x4199768
	public void SetAsNoMoreData() { }

	// RVA: 0x41997A0 Offset: 0x41957A0 VA: 0x41997A0
	public void SetAsLoading() { }

	// RVA: 0x41997D8 Offset: 0x41957D8 VA: 0x41997D8
	public void SetScroll(LoopListView2 scroll) { }

	// RVA: 0x4199874 Offset: 0x4195874 VA: 0x4199874
	private void LateUpdate() { }

	// RVA: 0x41999B4 Offset: 0x41959B4 VA: 0x41999B4
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.Guild
public class UIGuildListBottomLoadingItem : MonoBehaviour // TypeDefIndex: 21074
{
	// Fields
	public RectTransform RotateRTF; // 0x20
	public RectTransform ScaleRTF; // 0x28
	public float RotateSpeed; // 0x30
	public float MaxScaleSize; // 0x34
	public GameObject ObjNoMoreData; // 0x38
	public GameObject ObjLoading; // 0x40
	private LoopListViewItem2 mCurrentItem; // 0x48
	private LoopListView2 mScroll; // 0x50
	private RectTransform mView; // 0x58

	// Methods

	// RVA: 0x41999C8 Offset: 0x41959C8 VA: 0x41999C8
	public void SetActive(bool show) { }

	// RVA: 0x4199AA0 Offset: 0x4195AA0 VA: 0x4199AA0
	public void SetAsNoMoreData() { }

	// RVA: 0x4199AD8 Offset: 0x4195AD8 VA: 0x4199AD8
	public void SetAsLoading() { }

	// RVA: 0x4199B10 Offset: 0x4195B10 VA: 0x4199B10
	public void SetScroll(LoopListView2 scroll) { }

	// RVA: 0x4199BAC Offset: 0x4195BAC VA: 0x4199BAC
	private void LateUpdate() { }

	// RVA: 0x4199CEC Offset: 0x4195CEC VA: 0x4199CEC
	public void .ctor() { }
}

// Namespace: 
public sealed class EventTriggerListener.VoidDelegate : MulticastDelegate // TypeDefIndex: 21075
{
	// Methods

	// RVA: 0x4199F50 Offset: 0x4195F50 VA: 0x4199F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x419A000 Offset: 0x4196000 VA: 0x419A000 Slot: 13
	public virtual void Invoke(GameObject go) { }

	// RVA: 0x419A014 Offset: 0x4196014 VA: 0x419A014 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

	// RVA: 0x419A034 Offset: 0x4196034 VA: 0x419A034 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Framework.Logic.UI.EventTriggerListener
public class EventTriggerListener : EventTrigger // TypeDefIndex: 21076
{
	// Fields
	public EventTriggerListener.VoidDelegate onClick; // 0x28
	public EventTriggerListener.VoidDelegate onDown; // 0x30
	public EventTriggerListener.VoidDelegate onEnter; // 0x38
	public EventTriggerListener.VoidDelegate onExit; // 0x40
	public EventTriggerListener.VoidDelegate onUp; // 0x48
	public EventTriggerListener.VoidDelegate onSelect; // 0x50
	public EventTriggerListener.VoidDelegate onUpdateSelect; // 0x58

	// Methods

	// RVA: 0x4199D00 Offset: 0x4195D00 VA: 0x4199D00
	public static EventTriggerListener Get(GameObject go) { }

	// RVA: 0x4199DC0 Offset: 0x4195DC0 VA: 0x4199DC0 Slot: 27
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4199DF8 Offset: 0x4195DF8 VA: 0x4199DF8 Slot: 25
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x4199E30 Offset: 0x4195E30 VA: 0x4199E30 Slot: 21
	public override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x4199E68 Offset: 0x4195E68 VA: 0x4199E68 Slot: 22
	public override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x4199EA0 Offset: 0x4195EA0 VA: 0x4199EA0 Slot: 26
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x4199ED8 Offset: 0x4195ED8 VA: 0x4199ED8
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x4199F10 Offset: 0x4195F10 VA: 0x4199F10
	public void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x4199F48 Offset: 0x4195F48 VA: 0x4199F48
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.Chat
public class ChatInputCtrl : MonoBehaviour // TypeDefIndex: 21077
{
	// Fields
	public InputField MainInput; // 0x20
	public Action<float> OnKeyboardHeightChange; // 0x28
	private float mLastKeyboardHeight; // 0x30
	public Action OnEndEdit; // 0x38
	public Action<bool> OnInputFocus; // 0x40
	private bool mInputFocus; // 0x48
	private TouchScreenKeyboard.Status mTouchScreenKeyboardStatus; // 0x4C

	// Properties
	public TouchScreenKeyboard.Status LastTouchScreenKeyboardStatus { get; }

	// Methods

	// RVA: 0x419A040 Offset: 0x4196040 VA: 0x419A040
	public TouchScreenKeyboard.Status get_LastTouchScreenKeyboardStatus() { }

	// RVA: 0x419A048 Offset: 0x4196048 VA: 0x419A048
	public void OnEnable() { }

	// RVA: 0x419A14C Offset: 0x419614C VA: 0x419A14C
	private void OnInputEndEdit(string text) { }

	// RVA: 0x419A168 Offset: 0x4196168 VA: 0x419A168
	public string GetInputContent() { }

	// RVA: 0x419A1FC Offset: 0x41961FC VA: 0x419A1FC
	private void Update() { }

	// RVA: 0x419A35C Offset: 0x419635C VA: 0x419A35C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.Chat
public class ChatItem_LoadingMono : MonoBehaviour // TypeDefIndex: 21078
{
	// Fields
	public RectTransform RotateRTF; // 0x20
	public RectTransform ScaleRTF; // 0x28
	public float RotateSpeed; // 0x30
	public float MaxScaleSize; // 0x34
	public GameObject ObjNoMoreData; // 0x38
	public GameObject ObjLoading; // 0x40
	[HideInInspector]
	public RectTransform RTFView; // 0x48
	[HideInInspector]
	public LoopListViewItem2 CurrentItem; // 0x50
	[HideInInspector]
	public LoopListView2 Scroll; // 0x58
	public bool CheckRTFViewSize; // 0x60

	// Methods

	// RVA: 0x419A364 Offset: 0x4196364 VA: 0x419A364
	public void SetActive(bool show) { }

	// RVA: 0x419A43C Offset: 0x419643C VA: 0x419A43C
	public void SetAsNoMoreData() { }

	// RVA: 0x419A474 Offset: 0x4196474 VA: 0x419A474
	public void SetAsLoading() { }

	// RVA: 0x419A4AC Offset: 0x41964AC VA: 0x419A4AC
	public void SetScroll(LoopListView2 scroll, LoopListViewItem2 item2) { }

	// RVA: 0x419A508 Offset: 0x4196508 VA: 0x419A508
	private void LateUpdate() { }

	// RVA: 0x419A59C Offset: 0x419659C VA: 0x419A59C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.ChapterMapCloud
public class ChapterMapCloudMoveGroup : MonoBehaviour // TypeDefIndex: 21079
{
	// Fields
	public List<RectTransform> Clouds; // 0x20
	public Vector2 MoveSpeed; // 0x28
	public Vector2 RandomPosOffsetMin; // 0x30
	public Vector2 RandomPosOffsetMax; // 0x38
	private int screenWidth; // 0x40
	private int screenHeight; // 0x44

	// Methods

	// RVA: 0x419A5B8 Offset: 0x41965B8 VA: 0x419A5B8
	private void Awake() { }

	// RVA: 0x419A7BC Offset: 0x41967BC VA: 0x419A7BC
	private void Update() { }

	// RVA: 0x419A980 Offset: 0x4196980 VA: 0x419A980
	public void ClearChildList() { }

	// RVA: 0x419A9F0 Offset: 0x41969F0 VA: 0x419A9F0
	public void SetChildList(List<RectTransform> childs) { }

	// RVA: 0x419A5C0 Offset: 0x41965C0 VA: 0x419A5C0
	private void RandomPosOffset(List<RectTransform> cloudRectTransforms) { }

	// RVA: 0x419AA8C Offset: 0x4196A8C VA: 0x419AA8C
	public void .ctor() { }
}

// Namespace: Framework.Logic.UI.ChapterMapCloud
public class CloudMoveController : MonoBehaviour // TypeDefIndex: 21080
{
	// Fields
	public List<GameObject> m_prefabs; // 0x20
	public Transform m_topLeft; // 0x28
	public Transform m_bottomRight; // 0x30
	public float m_scaleMin; // 0x38
	public float m_scaleMax; // 0x3C
	public int m_count; // 0x40
	public Vector3 m_speed; // 0x44
	public List<GameObject> m_clouds; // 0x50
	public Random m_random; // 0x58

	// Methods

	// RVA: 0x419AB24 Offset: 0x4196B24 VA: 0x419AB24
	private void Start() { }

	// RVA: 0x419AFE8 Offset: 0x4196FE8 VA: 0x419AFE8
	private void Update() { }

	// RVA: 0x419B3F0 Offset: 0x41973F0 VA: 0x419B3F0
	private void OnDestroy() { }

	// RVA: 0x419ADC4 Offset: 0x4196DC4 VA: 0x419ADC4
	private Vector3 MathfPosOnSurface(Random random) { }

	// RVA: 0x419B2A4 Offset: 0x41972A4 VA: 0x419B2A4
	private Vector3 MathfPosOnEdge(Random random) { }

	// RVA: 0x419AF4C Offset: 0x4196F4C VA: 0x419AF4C
	private Vector3 MathfScale(Random random) { }

	// RVA: 0x419B1C0 Offset: 0x41971C0 VA: 0x419B1C0
	public bool IsResetToLeft(Vector3 pos) { }

	// RVA: 0x419B510 Offset: 0x4197510 VA: 0x419B510
	public void .ctor() { }
}

// Namespace: Framework.Logic.Tweening
public class SequencePool // TypeDefIndex: 21081
{
	// Fields
	private List<Sequence> mList; // 0x10

	// Methods

	// RVA: 0x419B5E0 Offset: 0x41975E0 VA: 0x419B5E0
	public void Add(Sequence seq) { }

	// RVA: 0x419B68C Offset: 0x419768C VA: 0x419B68C
	public Sequence Get() { }

	// RVA: 0x419B768 Offset: 0x4197768 VA: 0x419B768
	public void Clear() { }

	// RVA: 0x419B840 Offset: 0x4197840 VA: 0x419B840
	public void .ctor() { }
}

// Namespace: Framework.Logic.Platform
public class PlatformHelper : Singleton<PlatformHelper> // TypeDefIndex: 21082
{
	// Fields
	private const float TopHeight = -110;
	private const float BottomHeight = 90;

	// Methods

	// RVA: 0x419B8C8 Offset: 0x41978C8 VA: 0x419B8C8
	public bool IsFringe() { }

	// RVA: 0x419B900 Offset: 0x4197900 VA: 0x419B900
	private bool IsFringeByScreen() { }

	// RVA: 0x419B938 Offset: 0x4197938 VA: 0x419B938
	private bool IsFringeByDeviceForIOS() { }

	// RVA: 0x419BA60 Offset: 0x4197A60 VA: 0x419BA60
	public float GetTopHeight() { }

	// RVA: 0x419BAA4 Offset: 0x4197AA4 VA: 0x419BAA4
	public float GetBottomHeight() { }

	// RVA: 0x419BAE8 Offset: 0x4197AE8 VA: 0x419BAE8
	public int GetKeyboardHeight() { }

	// RVA: 0x419BB9C Offset: 0x4197B9C VA: 0x419BB9C
	public int AndroidGetKeyboardHeight(bool includeInput = True) { }

	// RVA: 0x419C3B0 Offset: 0x41983B0 VA: 0x419C3B0
	public int IOSGetKeyboardHeight() { }

	// RVA: 0x419C3DC Offset: 0x41983DC VA: 0x419C3DC
	public bool IsEditor() { }

	// RVA: 0x419C3E4 Offset: 0x41983E4 VA: 0x419C3E4
	public bool IsAndroid() { }

	// RVA: 0x419C3EC Offset: 0x41983EC VA: 0x419C3EC
	public bool IsIOS() { }

	// RVA: 0x419C3F4 Offset: 0x41983F4 VA: 0x419C3F4
	public string GetDeviceModel() { }

	// RVA: 0x419C3FC Offset: 0x41983FC VA: 0x419C3FC
	public int GetSystemMemorySize() { }

	// RVA: 0x419C404 Offset: 0x4198404 VA: 0x419C404
	public string GetOperationSystem() { }

	// RVA: 0x419C40C Offset: 0x419840C VA: 0x419C40C
	public string GetGraphicsDeviceName() { }

	// RVA: 0x419C414 Offset: 0x4198414 VA: 0x419C414
	public bool GetIsRoot() { }

	// RVA: 0x419C41C Offset: 0x419841C VA: 0x419C41C
	public string GetAppVersion() { }

	// RVA: 0x419C4C8 Offset: 0x41984C8 VA: 0x419C4C8
	public string GetAppVersionCode() { }

	// RVA: 0x419C574 Offset: 0x4198574 VA: 0x419C574
	public string GetDisplayVersion() { }

	// RVA: 0x419C620 Offset: 0x4198620 VA: 0x419C620
	public string GetVersion() { }

	// RVA: 0x419C678 Offset: 0x4198678 VA: 0x419C678
	public string GetPlatformID() { }

	// RVA: 0x419C704 Offset: 0x4198704 VA: 0x419C704
	public static string GetUUID() { }

	// RVA: 0x419C70C Offset: 0x419870C VA: 0x419C70C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class CheckAssetsStaticData.LanguageData // TypeDefIndex: 21083
{
	// Fields
	public int id; // 0x10
	public string english; // 0x18
	public string spanish; // 0x20
	public string chinesesimplified; // 0x28
	public string chinesetraditional; // 0x30
	public string japanese; // 0x38
	public string french; // 0x40
	public string german; // 0x48
	public string italian; // 0x50
	public string russian; // 0x58
	public string korean; // 0x60
	public string thai; // 0x68
	public string portuguese; // 0x70
	public string indonesian; // 0x78
	public string vietnamese; // 0x80
	public string turkish; // 0x88

	// Methods

	// RVA: 0x419C940 Offset: 0x4198940 VA: 0x419C940
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
[CreateAssetMenu]
public class CheckAssetsStaticData : ScriptableObject // TypeDefIndex: 21084
{
	// Fields
	public List<CheckAssetsStaticData.LanguageData> LanguageList; // 0x18

	// Methods

	// RVA: 0x419C754 Offset: 0x4198754 VA: 0x419C754
	public string GetLanguageListString(LanguageType languageType, int id) { }

	// RVA: 0x419C8B8 Offset: 0x41988B8 VA: 0x419C8B8
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public enum CoroutineName // TypeDefIndex: 21085
{
	// Fields
	public int value__; // 0x0
	public const CoroutineName System = 0;
	public const CoroutineName UI = 1;
	public const CoroutineName WebRequest = 2;
}

// Namespace: Framework.Logic.Modules
public enum DataName // TypeDefIndex: 21086
{
	// Fields
	public int value__; // 0x0
	public const DataName LanguageDataModule = 1;
}

// Namespace: Framework.Logic.Modules
public class EventArgLanguageType : BaseEventArgs // TypeDefIndex: 21087
{
	// Fields
	private LanguageType m_languageType; // 0x18

	// Properties
	public LanguageType LanguageType { get; }

	// Methods

	// RVA: 0x419C948 Offset: 0x4198948 VA: 0x419C948
	public LanguageType get_LanguageType() { }

	// RVA: 0x419C950 Offset: 0x4198950 VA: 0x419C950
	public EventArgLanguageType SetData(LanguageType languageType) { }

	// RVA: 0x419C958 Offset: 0x4198958 VA: 0x419C958 Slot: 4
	public override void Clear() { }

	// RVA: 0x419C960 Offset: 0x4198960 VA: 0x419C960
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public class LanguageDataModule : IDataModule // TypeDefIndex: 21088
{
	// Fields
	private const string CURRENT_LANGUAGETYPE_KEY = "CurrentLanguageType";
	private LanguageType m_currentLanguageType; // 0x10
	[TupleElementNames(new[] { "abbr", "name" })]
	private static Dictionary<LanguageType, ValueTuple<string, string>> languagedic; // 0x0

	// Properties
	public LanguageType GetCurrentLanguageType { get; }

	// Methods

	// RVA: 0x419C968 Offset: 0x4198968 VA: 0x419C968
	public LanguageType get_GetCurrentLanguageType() { }

	// RVA: 0x419C970 Offset: 0x4198970 VA: 0x419C970 Slot: 4
	public int GetName() { }

	// RVA: 0x419C978 Offset: 0x4198978 VA: 0x419C978 Slot: 5
	public void RegisterEvents(EventSystemManager manager) { }

	// RVA: 0x419CA20 Offset: 0x4198A20 VA: 0x419CA20 Slot: 6
	public void UnRegisterEvents(EventSystemManager manager) { }

	// RVA: 0x419CAC8 Offset: 0x4198AC8 VA: 0x419CAC8 Slot: 7
	public void Clear() { }

	// RVA: 0x419CACC Offset: 0x4198ACC VA: 0x419CACC
	private void RefreshLanguageHandle(int type, BaseEventArgs eventObject) { }

	// RVA: 0x419CC10 Offset: 0x4198C10 VA: 0x419CC10
	public void CheckLanguage() { }

	// RVA: 0x419CD14 Offset: 0x4198D14 VA: 0x419CD14
	public void SetLanguageNameAndAbbr(LanguageType type, string name, string abbr) { }

	// RVA: 0x419CDE4 Offset: 0x4198DE4 VA: 0x419CDE4
	public string GetLanguageName(LanguageType type) { }

	// RVA: 0x419CEA0 Offset: 0x4198EA0 VA: 0x419CEA0
	public string GetLanguageAbbr(LanguageType type) { }

	// RVA: 0x419CF58 Offset: 0x4198F58 VA: 0x419CF58
	public void .ctor() { }

	// RVA: 0x419CF68 Offset: 0x4198F68 VA: 0x419CF68
	private static void .cctor() { }
}

// Namespace: Framework.Logic.Modules
public enum LocalMessageName // TypeDefIndex: 21089
{
	// Fields
	public int value__; // 0x0
	public const LocalMessageName None = 0;
	public const LocalMessageName CC_REFRESH_LANGUAGE = 1;
	public const LocalMessageName CC_REFRESH_LANGUAGE_FINISH = 2;
	public const LocalMessageName CC_TipViewModule_AddTextTipNode = 3;
	public const LocalMessageName CC_ViewOpen = 4;
	public const LocalMessageName CC_ViewClose = 5;
	public const LocalMessageName CC_PreloadProgress = 6;
	public const LocalMessageName CC_PreloadUIProgressComplete = 7;
	public const LocalMessageName CC_TimeScaleChanged = 8;
}

// Namespace: 
[CompilerGenerated]
private struct FrameworkExpand.<OpenView>d__6 : IAsyncStateMachine // TypeDefIndex: 21090
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ViewModuleManager manager; // 0x20
	public ViewName name; // 0x28
	public object data; // 0x30
	public UILayers layer; // 0x38
	public Action<GameObject> loadedCallBack; // 0x40
	public Action<GameObject> openedCallBack; // 0x48
	private TaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x419DEF4 Offset: 0x4199EF4 VA: 0x419DEF4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x419E220 Offset: 0x419A220 VA: 0x419E220 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.Modules
[Extension]
public static class FrameworkExpand // TypeDefIndex: 21091
{
	// Methods

	[Extension]
	// RVA: 0x419CA0C Offset: 0x4198A0C VA: 0x419CA0C
	public static void RegisterEvent(EventSystemManager manager, LocalMessageName name, HandlerEvent handle) { }

	[Extension]
	// RVA: 0x419CAB4 Offset: 0x4198AB4 VA: 0x419CAB4
	public static void UnRegisterEvent(EventSystemManager manager, LocalMessageName name, HandlerEvent handle) { }

	[Extension]
	// RVA: 0x419D540 Offset: 0x4199540 VA: 0x419D540
	public static void Dispatch(EventSystemManager manager, LocalMessageName name, BaseEventArgs eventArgs) { }

	[Extension]
	// RVA: 0x419D554 Offset: 0x4199554 VA: 0x419D554
	public static void DispatchNow(EventSystemManager manager, LocalMessageName name, BaseEventArgs eventArgs) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetDataModule<T>(DataModuleManager manager, DataName name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462BD10 Offset: 0x4627D10 VA: 0x462BD10
	|-FrameworkExpand.GetDataModule<object>
	|
	|-RVA: 0x462BD58 Offset: 0x4627D58 VA: 0x462BD58
	|-FrameworkExpand.GetDataModule<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetViewModule<T>(ViewModuleManager manager, ViewName name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462BE70 Offset: 0x4627E70 VA: 0x462BE70
	|-FrameworkExpand.GetViewModule<object>
	*/

	[AsyncStateMachine(typeof(FrameworkExpand.<OpenView>d__6))]
	[Extension]
	// RVA: 0x419D568 Offset: 0x4199568 VA: 0x419D568
	public static Task OpenView(ViewModuleManager manager, ViewName name, object data, UILayers layer = 0, Action<GameObject> loadedCallBack, Action<GameObject> openedCallBack) { }

	[Extension]
	// RVA: 0x419D6B0 Offset: 0x41996B0 VA: 0x419D6B0
	public static void CloseView(ViewModuleManager manager, ViewName name) { }

	[Extension]
	// RVA: 0x419DB9C Offset: 0x4199B9C VA: 0x419DB9C
	public static bool IsOpened(ViewModuleManager manager, ViewName name) { }

	[Extension]
	// RVA: 0x419DCEC Offset: 0x4199CEC VA: 0x419DCEC
	public static bool IsLoading(ViewModuleManager manager, ViewName name) { }

	[Extension]
	// RVA: 0x419DE3C Offset: 0x4199E3C VA: 0x419DE3C
	public static bool IsOpenedOrLoading(ViewModuleManager manager, ViewName name) { }

	[Extension]
	// RVA: 0x419DED8 Offset: 0x4199ED8 VA: 0x419DED8
	public static void ActiveState(StateManager manager, StateName name) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetState<T>(StateManager manager, StateName name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462BE28 Offset: 0x4627E28 VA: 0x462BE28
	|-FrameworkExpand.GetState<object>
	*/

	[Extension]
	// RVA: 0x419DEEC Offset: 0x4199EEC VA: 0x419DEEC
	public static string ToHex(Color color) { }
}

// Namespace: Framework.Logic.Modules
[Extension]
public static class GameObjectExpand // TypeDefIndex: 21092
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4630CA4 Offset: 0x462CCA4 VA: 0x4630CA4
	|-GameObjectExpand.GetOrAddComponent<object>
	*/

	[Extension]
	// RVA: 0x419E288 Offset: 0x419A288 VA: 0x419E288
	public static void SetLayer(GameObject gameObject, int layer, bool children = True) { }

	[Extension]
	// RVA: 0x419E364 Offset: 0x419A364 VA: 0x419E364
	public static void SetLayer(GameObject[] gameObjects, int layer) { }

	[Extension]
	// RVA: 0x419E430 Offset: 0x419A430 VA: 0x419E430
	public static void SetLayer(Transform[] gameObjects, int layer) { }

	[Extension]
	// RVA: 0x419E508 Offset: 0x419A508 VA: 0x419E508
	public static void SetLayer(List<GameObject> gameObjects, int layer) { }

	[Extension]
	// RVA: 0x419E5F4 Offset: 0x419A5F4 VA: 0x419E5F4
	public static void SetLayer(List<Transform> gameObjects, int layer) { }
}

// Namespace: Framework.Logic.Modules
[Extension]
public static class ParticleSystemExpand // TypeDefIndex: 21093
{
	// Methods

	[Extension]
	// RVA: 0x419E6EC Offset: 0x419A6EC VA: 0x419E6EC
	public static void ParticlePlay(ParticleSystem particleSystem, bool withChildren = True) { }

	[Extension]
	// RVA: 0x419E704 Offset: 0x419A704 VA: 0x419E704
	public static void ParticleStop(ParticleSystem particleSystem, bool withChildren = True, ParticleSystemStopBehavior particleSystemStopBehavior = 1) { }

	[Extension]
	// RVA: 0x419E71C Offset: 0x419A71C VA: 0x419E71C
	public static void ParticlePause(ParticleSystem particleSystem, bool withChildren = True) { }

	[Extension]
	// RVA: 0x419E764 Offset: 0x419A764 VA: 0x419E764
	public static void ParticleUnPause(ParticleSystem particleSystem, bool withChildren = True) { }

	[Extension]
	// RVA: 0x419E7BC Offset: 0x419A7BC VA: 0x419E7BC
	public static void ParticlePlay(ParticleSystem[] particleSystems, bool withChildren = True) { }

	[Extension]
	// RVA: 0x419E824 Offset: 0x419A824 VA: 0x419E824
	public static void ParticleStop(ParticleSystem[] particleSystems, bool withChildren = True, ParticleSystemStopBehavior particleSystemStopBehavior = 1) { }

	[Extension]
	// RVA: 0x419E89C Offset: 0x419A89C VA: 0x419E89C
	public static void ParticlePause(ParticleSystem[] particleSystems, bool withChildren = True) { }

	[Extension]
	// RVA: 0x419E908 Offset: 0x419A908 VA: 0x419E908
	public static void ParticleUnPause(ParticleSystem[] particleSystems, bool withChildren = True) { }
}

// Namespace: Framework.Logic.Modules
public class LanguageManager : Singleton<LanguageManager> // TypeDefIndex: 21094
{
	// Fields
	private LanguageDataModule m_data; // 0x10
	public SystemLanguage m_systemLanguage; // 0x18

	// Methods

	// RVA: 0x419E974 Offset: 0x419A974 VA: 0x419E974
	public string GetInfoByID(LanguageType languageType, string id) { }

	// RVA: 0x419EA20 Offset: 0x419AA20 VA: 0x419EA20
	public string GetInfoByID(string id) { }

	// RVA: 0x419EA40 Offset: 0x419AA40 VA: 0x419EA40
	public string GetInfoByID(string id, object[] args) { }

	// RVA: 0x419EA70 Offset: 0x419AA70 VA: 0x419EA70
	public void CheckLanguage() { }

	// RVA: 0x419EB38 Offset: 0x419AB38 VA: 0x419EB38
	public string GetCurrentLanguage() { }

	// RVA: 0x419EBAC Offset: 0x419ABAC VA: 0x419EBAC
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public enum LanguageType // TypeDefIndex: 21095
{
	// Fields
	public int value__; // 0x0
	public const LanguageType Normal = -1;
	public const LanguageType English = 0;
	public const LanguageType Spanish = 1;
	public const LanguageType ChineseSimplified = 2;
	public const LanguageType ChineseTraditional = 3;
	public const LanguageType Japanese = 4;
	public const LanguageType French = 5;
	public const LanguageType German = 6;
	public const LanguageType Italian = 7;
	public const LanguageType Russian = 9;
	public const LanguageType Korean = 11;
	public const LanguageType Thai = 12;
	public const LanguageType Portuguese = 13;
	public const LanguageType Indonesian = 14;
	public const LanguageType Vietnamese = 15;
	public const LanguageType Turkish = 16;
}

// Namespace: Framework.Logic.Modules
public class LocalDataName // TypeDefIndex: 21096
{
	// Fields
	public const string APPKEY = "App_key";
	public const string CURRENTLANGUAGETYPEKEY = "CurrentLanguageType_Key";
	public const string PUCHASECACHE = "PUCHASECACHE_Key";
	public const string DOWNLOADED_PACKAGE = "DOWNLOADED_PACKAGE_Key";

	// Methods

	// RVA: 0x419EBFC Offset: 0x419ABFC VA: 0x419EBFC
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public class MyCertificate : CertificateHandler // TypeDefIndex: 21097
{
	// Fields
	private NetWorkUsingType m_usingType; // 0x18
	private string[] m_pubKeys; // 0x20
	private string[] m_certHashs; // 0x28

	// Methods

	// RVA: 0x419EC04 Offset: 0x419AC04 VA: 0x419EC04
	public void .ctor(NetWorkUsingType usingType, string[] pubKeys, string[] certHashs) { }

	// RVA: 0x419EC64 Offset: 0x419AC64 VA: 0x419EC64 Slot: 5
	protected override bool ValidateCertificate(byte[] certificateData) { }
}

// Namespace: Framework.Logic.Modules
public enum SoundName // TypeDefIndex: 21098
{
	// Fields
	public int value__; // 0x0
	public const SoundName Background = 0;
	public const SoundName SoundEffect = 1;
}

// Namespace: Framework.Logic.Modules
[RequireComponent(typeof(AudioSource))]
public class SoundNameController : MonoBehaviour // TypeDefIndex: 21099
{
	// Fields
	public AudioSource m_audioSource; // 0x20
	public SoundName m_soundName; // 0x28

	// Methods

	// RVA: 0x419EC6C Offset: 0x419AC6C VA: 0x419EC6C
	private void Awake() { }

	// RVA: 0x419EDFC Offset: 0x419ADFC VA: 0x419EDFC
	private AudioMixerGroup GetAudioMixerGroup(SoundName souncname) { }

	// RVA: 0x419EF0C Offset: 0x419AF0C VA: 0x419EF0C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CheckAssetsState.<>c // TypeDefIndex: 21100
{
	// Fields
	public static readonly CheckAssetsState.<>c <>9; // 0x0
	public static Action<AsyncOperation> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x419F080 Offset: 0x419B080 VA: 0x419F080
	private static void .cctor() { }

	// RVA: 0x419F0E8 Offset: 0x419B0E8 VA: 0x419F0E8
	public void .ctor() { }

	// RVA: 0x419F0F0 Offset: 0x419B0F0 VA: 0x419F0F0
	internal void <OnEnter>b__1_0(AsyncOperation s) { }
}

// Namespace: Framework.Logic.Modules
public class CheckAssetsState : State // TypeDefIndex: 21101
{
	// Methods

	// RVA: 0x419EF1C Offset: 0x419AF1C VA: 0x419EF1C Slot: 4
	public override int GetName() { }

	// RVA: 0x419EF24 Offset: 0x419AF24 VA: 0x419EF24 Slot: 5
	public override void OnEnter() { }

	// RVA: 0x419F05C Offset: 0x419B05C VA: 0x419F05C Slot: 10
	public override void OnAppPause(bool pauseStatus) { }

	// RVA: 0x419F060 Offset: 0x419B060 VA: 0x419F060 Slot: 11
	public override void OnExit() { }

	// RVA: 0x419F064 Offset: 0x419B064 VA: 0x419F064 Slot: 6
	public override void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x419F068 Offset: 0x419B068 VA: 0x419F068 Slot: 8
	public override void OnShutDown() { }

	// RVA: 0x419F06C Offset: 0x419B06C VA: 0x419F06C Slot: 9
	public override void OnAppFocus(bool hasFocus) { }

	// RVA: 0x419F070 Offset: 0x419B070 VA: 0x419F070 Slot: 12
	public override void RegisterEvents(EventSystemManager manager) { }

	// RVA: 0x419F074 Offset: 0x419B074 VA: 0x419F074 Slot: 13
	public override void UnRegisterEvents(EventSystemManager manager) { }

	// RVA: 0x419F078 Offset: 0x419B078 VA: 0x419F078
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public enum StateName // TypeDefIndex: 21102
{
	// Fields
	public int value__; // 0x0
	public const StateName CheckAssetsState = 1;
}

// Namespace: Framework.Logic.Modules
public enum UpdateCheckPoint // TypeDefIndex: 21103
{
	// Fields
	public int value__; // 0x0
	public const UpdateCheckPoint Begin = 0;
	public const UpdateCheckPoint AppUpdateCheckFinish = 1;
	public const UpdateCheckPoint OpenAppUpdateWindow = 2;
	public const UpdateCheckPoint ClickAppUpdateWindow = 3;
	public const UpdateCheckPoint CheckResourceUpdateBegin = 4;
	public const UpdateCheckPoint CheckResourceUpdateFinish = 5;
	public const UpdateCheckPoint UpdateResourceFinish = 6;
	public const UpdateCheckPoint OpenResourceUpdateNotice = 7;
	public const UpdateCheckPoint ClickResourceUpdateNotice = 8;
	public const UpdateCheckPoint LoadResourceFinish = 9;
	public const UpdateCheckPoint DllLoadFinish = 10;
}

// Namespace: 
public enum CheckAssetsViewModule.State // TypeDefIndex: 21104
{
	// Fields
	public int value__; // 0x0
	public const CheckAssetsViewModule.State CheckVersion = 0;
	public const CheckAssetsViewModule.State CheckResource = 1;
	public const CheckAssetsViewModule.State PrepareResource = 2;
	public const CheckAssetsViewModule.State Download = 3;
	public const CheckAssetsViewModule.State LoadResource = 4;
}

// Namespace: 
public enum CheckAssetsViewModule.TipState // TypeDefIndex: 21105
{
	// Fields
	public int value__; // 0x0
	public const CheckAssetsViewModule.TipState UpdateVersion = 0;
	public const CheckAssetsViewModule.TipState UpdateResources = 1;
	public const CheckAssetsViewModule.TipState UpdateVersionHttpError = 2;
	public const CheckAssetsViewModule.TipState UpdateResourcesHttpError = 3;
}

// Namespace: 
[CompilerGenerated]
private struct CheckAssetsViewModule.<<ShowUpdateResources>b__58_0>d : IAsyncStateMachine // TypeDefIndex: 21106
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CheckAssetsViewModule <>4__this; // 0x28

	// Methods

	// RVA: 0x41A349C Offset: 0x419F49C VA: 0x41A349C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41A3814 Offset: 0x419F814 VA: 0x41A3814 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.Logic.Modules
public class CheckAssetsViewModule : BaseViewModule // TypeDefIndex: 21107
{
	// Fields
	private float _startCheckTime; // 0x34
	[Label]
	public CheckAssetsViewModule.State m_state; // 0x38
	[Label]
	public CheckAssetsViewModule.TipState m_tipState; // 0x3C
	public Slider m_progress; // 0x40
	public CustomText m_progressTxt; // 0x48
	public RectTransform m_tipGroup; // 0x50
	public CustomText m_tipTitleTxt; // 0x58
	public CustomText m_tipConentTxt; // 0x60
	public CustomButton m_tipOkBt; // 0x68
	public CustomText m_tipOkBtTxt; // 0x70
	public CustomText versionText; // 0x78
	public CheckAssetsStaticData m_checkAssetsStaticData; // 0x80
	public LanguageDataModule m_languageDataModule; // 0x88
	private float m_percent; // 0x90
	private float _curProgress; // 0x94
	private bool m_isPlaying; // 0x98
	private Action m_onClickTipOkBt; // 0xA0
	private bool m_isUpdate; // 0xA8
	private float _curPreloadSpeed; // 0xAC
	private float _targetProgress; // 0xB0
	private string _remoteAppVersion; // 0xB8
	private int _counter; // 0xC0
	private float _checkTime; // 0xC4
	private float _checkUpdateInterval; // 0xC8

	// Methods

	// RVA: 0x419F194 Offset: 0x419B194 VA: 0x419F194 Slot: 11
	public override void OnCreate(object data) { }

	// RVA: 0x419F198 Offset: 0x419B198 VA: 0x419F198
	public void Start() { }

	// RVA: 0x419F398 Offset: 0x419B398 VA: 0x419F398 Slot: 13
	public override void OnOpen(object data) { }

	// RVA: 0x41A01A4 Offset: 0x419C1A4 VA: 0x41A01A4
	private void OnEvent(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x41A0240 Offset: 0x419C240 VA: 0x41A0240 Slot: 15
	public override void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41A07C8 Offset: 0x419C7C8 VA: 0x41A07C8 Slot: 14
	public override void OnClose() { }

	// RVA: 0x41A0960 Offset: 0x419C960 VA: 0x41A0960 Slot: 12
	public override void OnDelete() { }

	// RVA: 0x41A0964 Offset: 0x419C964 VA: 0x41A0964 Slot: 9
	public override void RegisterEvents(EventSystemManager manager) { }

	// RVA: 0x41A0968 Offset: 0x419C968 VA: 0x41A0968 Slot: 10
	public override void UnRegisterEvents(EventSystemManager manager) { }

	// RVA: 0x41A096C Offset: 0x419C96C VA: 0x41A096C
	private void OnClickTipOkBt() { }

	// RVA: 0x419FBB4 Offset: 0x419BBB4 VA: 0x419FBB4
	private void OnCheckAsset() { }

	// RVA: 0x41A0DCC Offset: 0x419CDCC VA: 0x41A0DCC
	private void OnAppCheckSuccess(string content) { }

	// RVA: 0x41A1244 Offset: 0x419D244 VA: 0x41A1244
	private void OnAppCheckFail(string sendCode, string severCode) { }

	// RVA: 0x41A0988 Offset: 0x419C988 VA: 0x41A0988
	private void OnCheckResourcesUpdate() { }

	// RVA: 0x41A1AA0 Offset: 0x419DAA0 VA: 0x41A1AA0
	private void OnCheckFinish(bool isUpdate, float downloadSize) { }

	// RVA: 0x41A1EE4 Offset: 0x419DEE4 VA: 0x41A1EE4
	private void OnDownPrompt(long downPrompt) { }

	// RVA: 0x41A228C Offset: 0x419E28C VA: 0x41A228C
	private void OnCheckUpdateProgress(float progress, long current, long all) { }

	// RVA: 0x41A2444 Offset: 0x419E444 VA: 0x41A2444
	private void OnCheckUpdateFinished(bool isOk, ResourcesUpdateErrorCode errorCode) { }

	// RVA: 0x41A2B44 Offset: 0x419EB44 VA: 0x41A2B44
	private void OnRunTimeFinished() { }

	// RVA: 0x419F728 Offset: 0x419B728 VA: 0x419F728
	public void SwitchState(CheckAssetsViewModule.State state, object args) { }

	// RVA: 0x41A2E70 Offset: 0x419EE70 VA: 0x41A2E70
	private void PlayProgress() { }

	// RVA: 0x41A2E68 Offset: 0x419EE68 VA: 0x41A2E68
	private void StopProgress() { }

	// RVA: 0x41A07A4 Offset: 0x419C7A4 VA: 0x41A07A4
	public void SetPercent(float percent) { }

	// RVA: 0x41A2290 Offset: 0x419E290 VA: 0x41A2290
	public void SetPercent(float percent, long currentSize, long maxSize) { }

	// RVA: 0x419F2C8 Offset: 0x419B2C8 VA: 0x419F2C8
	public void SetProgressTxt(int id, object[] args) { }

	// RVA: 0x41A0704 Offset: 0x419C704 VA: 0x41A0704
	public void SetProgressTxt(string content) { }

	// RVA: 0x419F684 Offset: 0x419B684 VA: 0x419F684
	private void ShowTip(bool value) { }

	// RVA: 0x41A2E80 Offset: 0x419EE80 VA: 0x41A2E80
	public void SetTipOkBtTxt(int id) { }

	// RVA: 0x41A2F40 Offset: 0x419EF40 VA: 0x41A2F40
	public void SetTipOkBtTxt(string content) { }

	// RVA: 0x41A1550 Offset: 0x419D550 VA: 0x41A1550
	private void ShowUpdateVersion() { }

	// RVA: 0x41A1884 Offset: 0x419D884 VA: 0x41A1884
	private void StartCnApkDownload(string upgradeUri) { }

	// RVA: 0x41A2FE0 Offset: 0x419EFE0 VA: 0x41A2FE0
	private void OnApkDownloadResult(int code, string message) { }

	// RVA: 0x41A1EFC Offset: 0x419DEFC VA: 0x41A1EFC
	private void ShowUpdateResources(float mb) { }

	// RVA: 0x41A1908 Offset: 0x419D908 VA: 0x41A1908
	private void ShowUpdateVersionHttpError(string code) { }

	// RVA: 0x41A29AC Offset: 0x419E9AC VA: 0x41A29AC
	private void ShowUpdateResourcesHttpError(string code) { }

	// RVA: 0x41A30F4 Offset: 0x419F0F4 VA: 0x41A30F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41A3194 Offset: 0x419F194 VA: 0x41A3194
	private void <ShowUpdateVersion>b__55_0() { }

	[CompilerGenerated]
	[AsyncStateMachine(typeof(CheckAssetsViewModule.<<ShowUpdateResources>b__58_0>d))]
	// RVA: 0x41A33B4 Offset: 0x419F3B4 VA: 0x41A33B4
	private void <ShowUpdateResources>b__58_0() { }

	[CompilerGenerated]
	// RVA: 0x41A3464 Offset: 0x419F464 VA: 0x41A3464
	private void <ShowUpdateVersionHttpError>b__59_0() { }

	[CompilerGenerated]
	// RVA: 0x41A3480 Offset: 0x419F480 VA: 0x41A3480
	private void <ShowUpdateResourcesHttpError>b__60_0() { }
}

// Namespace: Framework.Logic.Modules
public class EventArgsPreloadProgress : BaseEventArgs // TypeDefIndex: 21108
{
	// Fields
	private float _progress; // 0x18

	// Properties
	public float Value { get; }

	// Methods

	// RVA: 0x41A3820 Offset: 0x419F820 VA: 0x41A3820
	public float get_Value() { }

	// RVA: 0x41A3828 Offset: 0x419F828 VA: 0x41A3828
	public EventArgsPreloadProgress SetData(float progress) { }

	// RVA: 0x41A3830 Offset: 0x419F830 VA: 0x41A3830 Slot: 4
	public override void Clear() { }

	// RVA: 0x41A3838 Offset: 0x419F838 VA: 0x41A3838
	public void .ctor() { }
}

// Namespace: Framework.Logic.Modules
public enum ViewName // TypeDefIndex: 21109
{
	// Fields
	public int value__; // 0x0
	public const ViewName CheckAssetsViewModule = 1;
	public const ViewName NetLoadingViewModule = 2;
}

// Namespace: Framework.Logic.GameTestTools
public class GameTestTool // TypeDefIndex: 21110
{
	// Fields
	public static List<GameTestGUIInfoGroup> HotFixTestList; // 0x0
	public static Action<GameTestGUIInfo> OnHotFixTestAction; // 0x8
	public static List<GameTestGUIInfoGroup> CSharpsTestList; // 0x10
	public static Action<GameTestGUIInfo> OnCSharpsTestAction; // 0x18
	public static List<GameTestGUIInfoGroup> EditorTestList; // 0x20
	public static Action<GameTestGUIInfo> OnEditorTestAction; // 0x28

	// Methods

	// RVA: 0x41A3840 Offset: 0x419F840 VA: 0x41A3840
	public static void SetHotFixTestList(List<GameTestGUIInfo> list, Action<GameTestGUIInfo> action) { }

	// RVA: 0x41A3844 Offset: 0x419F844 VA: 0x41A3844
	public static void SetCSharpsTestList(List<GameTestGUIInfo> list, Action<GameTestGUIInfo> action) { }

	// RVA: 0x41A3848 Offset: 0x419F848 VA: 0x41A3848
	public static void SetEditorTestList(List<GameTestGUIInfo> list, Action<GameTestGUIInfo> action) { }

	// RVA: 0x41A384C Offset: 0x419F84C VA: 0x41A384C
	private static void AddTestToListGroup(List<GameTestGUIInfo> list, List<GameTestGUIInfoGroup> grouplist) { }

	// RVA: 0x41A3B18 Offset: 0x419FB18 VA: 0x41A3B18
	public void .ctor() { }

	// RVA: 0x41A3B20 Offset: 0x419FB20 VA: 0x41A3B20
	private static void .cctor() { }
}

// Namespace: Framework.Logic.GameTestTools
public class GameTestGUIInfoGroup // TypeDefIndex: 21111
{
	// Fields
	public string Head; // 0x10
	public List<GameTestGUIInfo> List; // 0x18

	// Methods

	// RVA: 0x41A3C08 Offset: 0x419FC08 VA: 0x41A3C08
	public static int SortGroup(GameTestGUIInfoGroup x, GameTestGUIInfoGroup y) { }

	// RVA: 0x41A3A90 Offset: 0x419FA90 VA: 0x41A3A90
	public void .ctor() { }
}

// Namespace: Framework.Logic.GameTestTools
public class GameTestGUIInfo // TypeDefIndex: 21112
{
	// Fields
	public string TypeName; // 0x10
	public string FuncName; // 0x18
	public string ShowName; // 0x20
	public string ShowTips; // 0x28
	public string Head; // 0x30
	public string[] ParamsDef; // 0x38
	public object[] Params; // 0x40

	// Methods

	// RVA: 0x41A3C30 Offset: 0x419FC30 VA: 0x41A3C30
	public void .ctor() { }
}

// Namespace: Framework.Logic.GameTestTools
public class GameTestMethodVO // TypeDefIndex: 21113
{
	// Fields
	private GameTestMethodAttribute TestAttribute; // 0x10
	private Type ClassType; // 0x18
	private MethodInfo MInfo; // 0x20
	private GameTestGUIInfo Info; // 0x28

	// Properties
	public int Order { get; }
	public string Name { get; }
	public string Tips { get; }
	public string TypeName { get; }
	public string FuncName { get; }

	// Methods

	// RVA: 0x41A3C38 Offset: 0x419FC38 VA: 0x41A3C38
	public int get_Order() { }

	// RVA: 0x41A3C50 Offset: 0x419FC50 VA: 0x41A3C50
	public string get_Name() { }

	// RVA: 0x41A3CA4 Offset: 0x419FCA4 VA: 0x41A3CA4
	public string get_Tips() { }

	// RVA: 0x41A3CF8 Offset: 0x419FCF8 VA: 0x41A3CF8
	public string get_TypeName() { }

	// RVA: 0x41A3D9C Offset: 0x419FD9C VA: 0x41A3D9C
	public string get_FuncName() { }

	// RVA: 0x41A3E18 Offset: 0x419FE18 VA: 0x41A3E18
	public void .ctor(Type type, MethodInfo mi, GameTestMethodAttribute testattribute) { }

	// RVA: 0x41A4024 Offset: 0x41A0024 VA: 0x41A4024
	public void DoTest(GameTestGUIInfo info) { }

	// RVA: 0x41A4260 Offset: 0x41A0260 VA: 0x41A4260
	public GameTestGUIInfo MakeInfo() { }

	// RVA: 0x41A4268 Offset: 0x41A0268 VA: 0x41A4268
	public bool TryDoTest(GameTestGUIInfo info) { }

	// RVA: 0x41A42D8 Offset: 0x41A02D8 VA: 0x41A42D8
	public static int Sort(GameTestMethodVO x, GameTestMethodVO y) { }
}

// Namespace: Framework.Logic.GameTestTools
public class GameTestMethodAttribute : Attribute // TypeDefIndex: 21114
{
	// Fields
	public string Name; // 0x10
	public string Tips; // 0x18
	public string Head; // 0x20
	public int Order; // 0x28

	// Methods

	// RVA: 0x41A4320 Offset: 0x41A0320 VA: 0x41A4320
	public void .ctor() { }

	// RVA: 0x41A4344 Offset: 0x41A0344 VA: 0x41A4344
	public void .ctor(string head = "", string name = "", string tips = "", int order = 0) { }
}

// Namespace: Framework.Logic.Easing
public enum EaseType // TypeDefIndex: 21115
{
	// Fields
	public int value__; // 0x0
	public const EaseType Linear = 0;
	public const EaseType InOutCubic = 1;
	public const EaseType InOutQuintic = 2;
	public const EaseType InQuintic = 3;
	public const EaseType InQuartic = 4;
	public const EaseType InCubic = 5;
	public const EaseType InQuadratic = 6;
	public const EaseType OutQuintic = 7;
	public const EaseType OutQuartic = 8;
	public const EaseType OutCubic = 9;
	public const EaseType OutInCubic = 10;
	public const EaseType BackInCubic = 11;
	public const EaseType BackInQuartic = 12;
	public const EaseType OutBackCubic = 13;
	public const EaseType OutBackQuartic = 14;
	public const EaseType OutElasticSmall = 15;
	public const EaseType OutElasticBig = 16;
	public const EaseType InElasticSmall = 17;
	public const EaseType InElasticBig = 18;
}

// Namespace: Framework.Logic.Easing
public enum EaseProcess // TypeDefIndex: 21116
{
	// Fields
	public int value__; // 0x0
	public const EaseProcess Once = 0;
	public const EaseProcess PingPong = 1;
}

// Namespace: Framework.Logic.Easing
public class Easing // TypeDefIndex: 21117
{
	// Methods

	// RVA: 0x41A43D4 Offset: 0x41A03D4 VA: 0x41A43D4
	public static Vector2 EasingVector2(float t, Vector2 from, Vector2 to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A4780 Offset: 0x41A0780 VA: 0x41A4780
	public static Color EasingColor(float t, Color from, Color to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A4818 Offset: 0x41A0818 VA: 0x41A4818
	public static Vector3 EasingVector3(float t, Vector3 from, Vector3 to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A48A4 Offset: 0x41A08A4 VA: 0x41A48A4
	public static Quaternion EasingQuaternion(float t, Vector3 from, Vector3 to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A497C Offset: 0x41A097C VA: 0x41A497C
	public static Quaternion EasingQuaternion(float t, Quaternion from, Quaternion to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A443C Offset: 0x41A043C VA: 0x41A443C
	public static float EasingFloat(float t, float from, float to, float d, EaseType easeType = 0) { }

	// RVA: 0x41A49F8 Offset: 0x41A09F8 VA: 0x41A49F8
	private static float Linear(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4A08 Offset: 0x41A0A08 VA: 0x41A4A08
	private static float InOutCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4A30 Offset: 0x41A0A30 VA: 0x41A4A30
	private static float InOutQuintic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4A70 Offset: 0x41A0A70 VA: 0x41A4A70
	private static float InQuintic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4A8C Offset: 0x41A0A8C VA: 0x41A4A8C
	private static float InQuartic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4AA4 Offset: 0x41A0AA4 VA: 0x41A4AA4
	private static float InCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4ABC Offset: 0x41A0ABC VA: 0x41A4ABC
	private static float InQuadratic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4AD0 Offset: 0x41A0AD0 VA: 0x41A4AD0
	private static float OutQuintic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4B18 Offset: 0x41A0B18 VA: 0x41A4B18
	private static float OutQuartic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4B54 Offset: 0x41A0B54 VA: 0x41A4B54
	private static float OutCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4B80 Offset: 0x41A0B80 VA: 0x41A4B80
	private static float OutInCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4E14 Offset: 0x41A0E14 VA: 0x41A4E14
	private static float OutInQuartic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4BB8 Offset: 0x41A0BB8 VA: 0x41A4BB8
	private static float BackInCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4BE4 Offset: 0x41A0BE4 VA: 0x41A4BE4
	private static float BackInQuartic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4C18 Offset: 0x41A0C18 VA: 0x41A4C18
	private static float OutBackCubic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4C50 Offset: 0x41A0C50 VA: 0x41A4C50
	private static float OutBackQuartic(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4C94 Offset: 0x41A0C94 VA: 0x41A4C94
	private static float OutElasticSmall(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4CFC Offset: 0x41A0CFC VA: 0x41A4CFC
	private static float OutElasticBig(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4D64 Offset: 0x41A0D64 VA: 0x41A4D64
	private static float InElasticSmall(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4DBC Offset: 0x41A0DBC VA: 0x41A4DBC
	private static float InElasticBig(float time, float begion, float change, float duration) { }

	// RVA: 0x41A4E4C Offset: 0x41A0E4C VA: 0x41A4E4C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AnimatorListen.ListenEvent : UnityEvent<GameObject, string> // TypeDefIndex: 21118
{
	// Methods

	// RVA: 0x41A5010 Offset: 0x41A1010 VA: 0x41A5010
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class AnimatorListen : MonoBehaviour // TypeDefIndex: 21119
{
	// Fields
	public AnimatorListen.ListenEvent onListen; // 0x20

	// Methods

	// RVA: 0x41A4E54 Offset: 0x41A0E54 VA: 0x41A4E54
	public void Listen(string eventParameter) { }

	// RVA: 0x41A4EC0 Offset: 0x41A0EC0 VA: 0x41A4EC0
	public static AnimatorListen Get(GameObject obj) { }

	// RVA: 0x41A4FA8 Offset: 0x41A0FA8 VA: 0x41A4FA8
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class GuardBallGroup : MonoBehaviour // TypeDefIndex: 21120
{
	// Fields
	public Transform m_transform; // 0x20
	public float m_rotationSpeed; // 0x28
	public bool m_isPause; // 0x2C
	public float m_radius; // 0x30
	public bool debuglayout; // 0x34

	// Methods

	// RVA: 0x41A5058 Offset: 0x41A1058 VA: 0x41A5058
	private void Awake() { }

	// RVA: 0x41A507C Offset: 0x41A107C VA: 0x41A507C
	private void Update() { }

	// RVA: 0x41A50F0 Offset: 0x41A10F0 VA: 0x41A50F0
	public void LayoutChildren() { }

	// RVA: 0x41A5314 Offset: 0x41A1314 VA: 0x41A5314
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class MemberBody : MonoBehaviour // TypeDefIndex: 21121
{
	// Fields
	public Transform m_center; // 0x20
	public Transform m_leftHand; // 0x28
	public Transform m_rightHand; // 0x30
	public Transform m_head; // 0x38
	public Transform m_health; // 0x40
	public Transform m_headTop; // 0x48
	public SkinnedMeshRenderer m_bodyMesh; // 0x50
	public WeaponBody m_weaponLeftBody; // 0x58
	public WeaponBody m_weaponRightBody; // 0x60
	private Transform m_root; // 0x68

	// Methods

	// RVA: 0x41A5324 Offset: 0x41A1324 VA: 0x41A5324
	public void SetRoot(Transform root) { }

	// RVA: 0x41A532C Offset: 0x41A132C VA: 0x41A532C
	public Transform GetTransform(MemberBodyPosType posType) { }

	// RVA: 0x41A564C Offset: 0x41A164C VA: 0x41A564C
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public enum MemberBodyPosType // TypeDefIndex: 21122
{
	// Fields
	public int value__; // 0x0
	public const MemberBodyPosType Foot = 0;
	public const MemberBodyPosType Center = 1;
	public const MemberBodyPosType LeftHand = 2;
	public const MemberBodyPosType RightHand = 3;
	public const MemberBodyPosType Head = 4;
	public const MemberBodyPosType Health = 5;
	public const MemberBodyPosType HeadTop = 6;
	public const MemberBodyPosType RootParent = 7;
	public const MemberBodyPosType WeaponLeftCenter = 100;
	public const MemberBodyPosType WeaponLeftLocalCenter = 101;
	public const MemberBodyPosType WeaponLeftHead = 102;
	public const MemberBodyPosType WeaponLeftTail = 103;
	public const MemberBodyPosType WeaponRightCenter = 200;
	public const MemberBodyPosType WeaponRightLocalCenter = 201;
	public const MemberBodyPosType WeaponRightHead = 202;
	public const MemberBodyPosType WeaponRightTail = 203;
}

// Namespace: Framework.Logic.Component
public class ReplaceSlot : MonoBehaviour // TypeDefIndex: 21123
{
	// Fields
	[SpineSkin("", "", True, False, False)]
	public string templateAttachmentsSkin; // 0x20
	public Material sourceMaterial; // 0x28
	[Header("Runtime Repack")]
	public bool repack; // 0x30
	public BoundingBoxFollower bbFollower; // 0x38
	[Header("Do not assign")]
	public Texture2D runtimeAtlas; // 0x40
	public Material runtimeMaterial; // 0x48
	[Header("换装部位")]
	public List<SlotsInfo> SlotsInfos; // 0x50
	private SkeletonAnimation skeletonAnimation; // 0x58
	private Skeleton skeleton; // 0x60
	private Skin templateSkin; // 0x68
	private Skin customSkin; // 0x70

	// Methods

	// RVA: 0x41A5654 Offset: 0x41A1654 VA: 0x41A5654
	private void Start() { }

	// RVA: 0x41A5758 Offset: 0x41A1758 VA: 0x41A5758
	private void Update() { }

	// RVA: 0x41A575C Offset: 0x41A175C VA: 0x41A575C
	public void Apply() { }

	// RVA: 0x41A5764 Offset: 0x41A1764 VA: 0x41A5764
	public void Apply(List<SlotsInfo> slots) { }

	// RVA: 0x41A5BD8 Offset: 0x41A1BD8 VA: 0x41A5BD8
	public void SetSkinName(string skinName) { }

	// RVA: 0x41A5BE0 Offset: 0x41A1BE0 VA: 0x41A5BE0
	public void ClearSkin() { }

	// RVA: 0x41A5C50 Offset: 0x41A1C50 VA: 0x41A5C50
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
[Serializable]
public struct SlotsInfo // TypeDefIndex: 21124
{
	// Fields
	[Header("换装")]
	public Sprite 图片; // 0x0
	[SpineSlot("", "", False, True, False)]
	public string SlotName; // 0x8
	[SpineAttachment(True, False, False, "SlotName", "", "baseSkinName", True, False)]
	public string SkinKey; // 0x10
}

// Namespace: Framework.Logic.Component
public class WeaponBody : MonoBehaviour // TypeDefIndex: 21125
{
	// Fields
	public Transform m_center; // 0x20
	public Transform m_localCenter; // 0x28
	public Transform m_head; // 0x30
	public Transform m_tail; // 0x38
	public Animator m_animator; // 0x40

	// Methods

	// RVA: 0x41A5610 Offset: 0x41A1610 VA: 0x41A5610
	public Transform GetTransform(WeaponBodyPosType posType) { }

	// RVA: 0x41A5D04 Offset: 0x41A1D04 VA: 0x41A5D04
	public void PlayAnimation(string triggerName) { }

	// RVA: 0x41A5DAC Offset: 0x41A1DAC VA: 0x41A5DAC
	public void SetAnimatorSpeed(float speed) { }

	// RVA: 0x41A5E44 Offset: 0x41A1E44 VA: 0x41A5E44
	public void StopAnimation() { }

	// RVA: 0x41A5EC8 Offset: 0x41A1EC8 VA: 0x41A5EC8
	public void ResetAnimation(string triggerName) { }

	// RVA: 0x41A5F70 Offset: 0x41A1F70 VA: 0x41A5F70
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public enum WeaponBodyPosType // TypeDefIndex: 21126
{
	// Fields
	public int value__; // 0x0
	public const WeaponBodyPosType Center = 0;
	public const WeaponBodyPosType LocalCenter = 1;
	public const WeaponBodyPosType Head = 2;
	public const WeaponBodyPosType Tail = 3;
}

// Namespace: 
[Serializable]
public class ComponentRegister.GameObjectRegisterData // TypeDefIndex: 21127
{
	// Fields
	public string m_name; // 0x10
	public GameObject m_object; // 0x18

	// Methods

	// RVA: 0x41A6184 Offset: 0x41A2184 VA: 0x41A6184
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class ComponentRegister : MonoBehaviour // TypeDefIndex: 21128
{
	// Fields
	[SerializeField]
	private ComponentRegister.GameObjectRegisterData[] m_gameObjectDatas; // 0x20
	private Dictionary<string, GameObject> m_gameObjectDic; // 0x28

	// Methods

	// RVA: 0x41A5F78 Offset: 0x41A1F78 VA: 0x41A5F78
	private void LoadGameObject() { }

	// RVA: 0x41A6070 Offset: 0x41A2070 VA: 0x41A6070
	public GameObject GetGameObject(string name) { }

	// RVA: 0x41A60F0 Offset: 0x41A20F0 VA: 0x41A60F0
	public Dictionary<string, GameObject> GetDic() { }

	// RVA: 0x41A6114 Offset: 0x41A2114 VA: 0x41A6114
	public bool Contains(string name) { }

	// RVA: 0x41A617C Offset: 0x41A217C VA: 0x41A617C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ComponentRegisterScriptable.GameObjectRegisterData // TypeDefIndex: 21129
{
	// Fields
	public string m_name; // 0x10
	public ScriptableObject m_object; // 0x18

	// Methods

	// RVA: 0x41A6330 Offset: 0x41A2330 VA: 0x41A6330
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class ComponentRegisterScriptable : MonoBehaviour // TypeDefIndex: 21130
{
	// Fields
	[SerializeField]
	private ComponentRegisterScriptable.GameObjectRegisterData[] m_gameObjectDatas; // 0x20
	private Dictionary<string, ScriptableObject> m_gameObjectDic; // 0x28

	// Methods

	// RVA: 0x41A618C Offset: 0x41A218C VA: 0x41A618C
	private void LoadGameObject() { }

	// RVA: 0x41A6284 Offset: 0x41A2284 VA: 0x41A6284
	public ScriptableObject GetGameObject(string name) { }

	// RVA: 0x41A6304 Offset: 0x41A2304 VA: 0x41A6304
	public Dictionary<string, ScriptableObject> GetDic() { }

	// RVA: 0x41A6328 Offset: 0x41A2328 VA: 0x41A6328
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class DropItemRefBinder : MonoBehaviour // TypeDefIndex: 21131
{
	// Fields
	public List<GameObject> WithModel; // 0x20
	public List<GameObject> WithTrail; // 0x28
	public SpriteRenderer ItemIcon; // 0x30
	public Animator Animator; // 0x38

	// Methods

	// RVA: 0x41A6338 Offset: 0x41A2338 VA: 0x41A6338
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public abstract class CustomBehaviour : MonoBehaviour // TypeDefIndex: 21132
{
	// Fields
	private RunTimeIDConnecterData m_idData; // 0x20

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x41A6340 Offset: 0x41A2340 VA: 0x41A6340
	public RectTransform get_rectTransform() { }

	// RVA: 0x41A6404 Offset: 0x41A2404 VA: 0x41A6404
	public void SetActive(bool active) { }

	// RVA: 0x41A642C Offset: 0x41A242C VA: 0x41A642C
	public int GetObjectInstanceID() { }

	// RVA: 0x41A644C Offset: 0x41A244C VA: 0x41A644C
	public void Init() { }

	// RVA: 0x41A6458 Offset: 0x41A2458 VA: 0x41A6458 Slot: 4
	public virtual void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41A645C Offset: 0x41A245C VA: 0x41A645C
	public void DeInit() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnDeInit();

	// RVA: 0x41A6468 Offset: 0x41A2468 VA: 0x41A6468
	protected void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class DontDestory : MonoBehaviour // TypeDefIndex: 21133
{
	// Methods

	// RVA: 0x41A6470 Offset: 0x41A2470 VA: 0x41A6470
	private void Awake() { }

	// RVA: 0x41A64EC Offset: 0x41A24EC VA: 0x41A64EC
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class FPSCounter : MonoBehaviour // TypeDefIndex: 21134
{
	// Fields
	private const string display = "<color=#eb112a> FPS：{0} </color>";
	private const float fpsMeasurePeriod = 1;
	private int m_FpsAccumulator; // 0x20
	private float m_FpsMeasureStartTime; // 0x24
	private int m_CurrentFps; // 0x28
	public FontStyle fontStyle; // 0x2C
	public int fontSize; // 0x30
	public float PositionX; // 0x34
	public float PositionY; // 0x38
	private float Width; // 0x3C
	private float Height; // 0x40
	private GUIStyle myStyle; // 0x48

	// Methods

	// RVA: 0x41A64F4 Offset: 0x41A24F4 VA: 0x41A64F4
	private void Start() { }

	// RVA: 0x41A6510 Offset: 0x41A2510 VA: 0x41A6510
	private void Update() { }

	// RVA: 0x41A6580 Offset: 0x41A2580 VA: 0x41A6580
	private void OnGUI() { }

	// RVA: 0x41A6698 Offset: 0x41A2698 VA: 0x41A6698
	public void .ctor() { }
}

// Namespace: 
public enum MeshOrder.SortingLayers // TypeDefIndex: 21135
{
	// Fields
	public int value__; // 0x0
	public const MeshOrder.SortingLayers None = 0;
	public const MeshOrder.SortingLayers BackGround = 1;
	public const MeshOrder.SortingLayers EffectFar = 2;
	public const MeshOrder.SortingLayers Member = 3;
	public const MeshOrder.SortingLayers EffectNear = 4;
}

// Namespace: Framework.Logic.Component
public class MeshOrder : MonoBehaviour // TypeDefIndex: 21136
{
	// Fields
	public int order; // 0x20
	public MeshOrder.SortingLayers sortlayer; // 0x24

	// Methods

	// RVA: 0x41A6718 Offset: 0x41A2718 VA: 0x41A6718
	private void Start() { }

	// RVA: 0x41A6874 Offset: 0x41A2874 VA: 0x41A6874
	public void .ctor() { }
}

// Namespace: 
protected class LocalUnityObjectPool.Cache // TypeDefIndex: 21137
{
	// Fields
	public GameObject copyItem; // 0x10
	private List<GameObject> collection; // 0x18
	private Queue<GameObject> cache; // 0x20
	private Transform rootParent; // 0x28

	// Methods

	// RVA: 0x41A6CB4 Offset: 0x41A2CB4 VA: 0x41A6CB4
	public void .ctor(Transform rootParent, GameObject copyItem) { }

	// RVA: 0x41A7160 Offset: 0x41A3160 VA: 0x41A7160
	public void EnQueue(GameObject item) { }

	// RVA: 0x41A6E20 Offset: 0x41A2E20 VA: 0x41A6E20
	public GameObject Dequeue() { }

	// RVA: 0x41A6ECC Offset: 0x41A2ECC VA: 0x41A6ECC
	public GameObject Dequeue(string name) { }

	// RVA: 0x41A6AC0 Offset: 0x41A2AC0 VA: 0x41A6AC0
	public void Collect() { }

	// RVA: 0x41A73A0 Offset: 0x41A33A0 VA: 0x41A73A0
	public void Destroy() { }
}

// Namespace: Framework.Logic.Component
public class LocalUnityObjectPool : MonoBehaviour // TypeDefIndex: 21138
{
	// Fields
	protected Dictionary<string, LocalUnityObjectPool.Cache> m_Cache; // 0x20

	// Methods

	// RVA: 0x41A687C Offset: 0x41A287C VA: 0x41A687C
	public static LocalUnityObjectPool Create(GameObject parent) { }

	// RVA: -1 Offset: -1
	public void CreateCache<T>(GameObject copyItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C45C Offset: 0x466845C VA: 0x466C45C
	|-LocalUnityObjectPool.CreateCache<object>
	*/

	// RVA: -1 Offset: -1
	public void CreateCache<T>(GameObject parent, GameObject copyItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C4B4 Offset: 0x46684B4 VA: 0x466C4B4
	|-LocalUnityObjectPool.CreateCache<object>
	*/

	// RVA: -1 Offset: -1
	public T DeQueue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C570 Offset: 0x4668570 VA: 0x466C570
	|-LocalUnityObjectPool.DeQueue<object>
	*/

	// RVA: -1 Offset: -1
	public T DeQueueWithName<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C680 Offset: 0x4668680 VA: 0x466C680
	|-LocalUnityObjectPool.DeQueueWithName<object>
	*/

	// RVA: -1 Offset: -1
	public void EnQueue<T>(GameObject item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C7B0 Offset: 0x46687B0 VA: 0x466C7B0
	|-LocalUnityObjectPool.EnQueue<object>
	*/

	// RVA: -1 Offset: -1
	public void Collect<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C3CC Offset: 0x46683CC VA: 0x466C3CC
	|-LocalUnityObjectPool.Collect<object>
	*/

	// RVA: 0x41A6968 Offset: 0x41A2968 VA: 0x41A6968
	public void CollectAll() { }

	// RVA: -1 Offset: -1
	public void ClearCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C33C Offset: 0x466833C VA: 0x466C33C
	|-LocalUnityObjectPool.ClearCache<object>
	*/

	// RVA: -1 Offset: -1
	public bool IsHavePool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C848 Offset: 0x4668848 VA: 0x466C848
	|-LocalUnityObjectPool.IsHavePool<object>
	*/

	// RVA: 0x41A6B80 Offset: 0x41A2B80 VA: 0x41A6B80
	public bool IsHavePool(string name) { }

	// RVA: 0x41A6BD8 Offset: 0x41A2BD8 VA: 0x41A6BD8
	public void CreateCache(string cacheName, GameObject copyItem) { }

	// RVA: 0x41A6C10 Offset: 0x41A2C10 VA: 0x41A6C10
	public void CreateCache(string cacheName, Transform parent, GameObject copyItem) { }

	// RVA: -1 Offset: -1
	public T DeQueue<T>(string cacheName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C604 Offset: 0x4668604 VA: 0x466C604
	|-LocalUnityObjectPool.DeQueue<object>
	*/

	// RVA: 0x41A6DC0 Offset: 0x41A2DC0 VA: 0x41A6DC0
	public GameObject DeQueue(string cacheName) { }

	// RVA: 0x41A6E68 Offset: 0x41A2E68 VA: 0x41A6E68
	public GameObject DeQueueWithName(string cacheName) { }

	// RVA: -1 Offset: -1
	public T DeQueueWithName<T>(string cacheName, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466C724 Offset: 0x4668724 VA: 0x466C724
	|-LocalUnityObjectPool.DeQueueWithName<object>
	*/

	// RVA: 0x41A7044 Offset: 0x41A3044 VA: 0x41A7044
	public void EnQueue(string cacheName, GameObject item) { }

	// RVA: 0x41A7270 Offset: 0x41A3270 VA: 0x41A7270
	public void Collect(string cacheName) { }

	// RVA: 0x41A7308 Offset: 0x41A3308 VA: 0x41A7308
	public void ClearCache(string cacheName) { }

	// RVA: 0x41A745C Offset: 0x41A345C VA: 0x41A745C
	public void ClearAllCache() { }

	// RVA: 0x41A75F0 Offset: 0x41A35F0 VA: 0x41A75F0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PopAnimationSequence.Data // TypeDefIndex: 21139
{
	// Fields
	public Transform transform; // 0x10
	public float playTime; // 0x18
	public float delayTime; // 0x1C

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x41A7B08 Offset: 0x41A3B08 VA: 0x41A7B08
	public bool get_IsValid() { }

	// RVA: 0x41A7C40 Offset: 0x41A3C40 VA: 0x41A7C40
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PopAnimationSequence.<>c__DisplayClass11_0 // TypeDefIndex: 21140
{
	// Fields
	public PopAnimationSequence.Data data; // 0x10

	// Methods

	// RVA: 0x41A7B00 Offset: 0x41A3B00 VA: 0x41A7B00
	public void .ctor() { }

	// RVA: 0x41A7C54 Offset: 0x41A3C54 VA: 0x41A7C54
	internal void <Play>b__1() { }
}

// Namespace: Framework.Logic.Component
public class PopAnimationSequence : MonoBehaviour // TypeDefIndex: 21141
{
	// Fields
	[Header("初始等待时间")]
	public float StartDelayTime; // 0x20
	public List<PopAnimationSequence.Data> m_list; // 0x28
	[Header("自动播放")]
	public bool AutoPlay; // 0x30
	private List<PopAnimationSequence.Data> m_currentList; // 0x38
	private Action m_onFinish; // 0x40
	private SequencePool m_seqPool; // 0x48

	// Methods

	// RVA: 0x41A7678 Offset: 0x41A3678 VA: 0x41A7678
	public void AddData(PopAnimationSequence.Data data) { }

	// RVA: 0x41A7724 Offset: 0x41A3724 VA: 0x41A7724
	public void SetFinish(Action onFinish) { }

	// RVA: 0x41A772C Offset: 0x41A372C VA: 0x41A772C
	private void OnEnable() { }

	// RVA: 0x41A7AE8 Offset: 0x41A3AE8 VA: 0x41A7AE8
	private void OnDisable() { }

	// RVA: 0x41A77F8 Offset: 0x41A37F8 VA: 0x41A77F8
	public void Play() { }

	// RVA: 0x41A7B68 Offset: 0x41A3B68 VA: 0x41A7B68
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41A7C24 Offset: 0x41A3C24 VA: 0x41A7C24
	private void <Play>b__11_0() { }
}

// Namespace: Framework.Logic.Component
public class RimPower : MonoBehaviour // TypeDefIndex: 21142
{
	// Fields
	public float m_durtion; // 0x20
	public AnimationCurve m_curve; // 0x28
	public float m_maxIntensity; // 0x30
	public const string m_rimPowerName = "_RimPower";
	public const string m_rimScaleName = "_RimScale";
	public const string m_rimMainColorName = "_MainColor";
	private Renderer[] m_renderers; // 0x38
	private MaterialPropertyBlock m_block; // 0x40
	[Label]
	public bool m_isPlaying; // 0x48
	[Label]
	public float m_currentTime; // 0x4C
	[Label]
	public float m_currentProgress; // 0x50

	// Methods

	// RVA: 0x41A7CCC Offset: 0x41A3CCC VA: 0x41A7CCC
	public void OnInit(Renderer[] renderers) { }

	// RVA: 0x41A7CEC Offset: 0x41A3CEC VA: 0x41A7CEC
	private void initBlock() { }

	// RVA: 0x41A7D60 Offset: 0x41A3D60 VA: 0x41A7D60
	public void OnUpdate(float deltaTime) { }

	// RVA: 0x41A7E94 Offset: 0x41A3E94 VA: 0x41A7E94
	public void OnDeInit() { }

	// RVA: 0x41A7E98 Offset: 0x41A3E98 VA: 0x41A7E98
	public void Play(float progress = 0) { }

	// RVA: 0x41A7EB8 Offset: 0x41A3EB8 VA: 0x41A7EB8
	public void Stop() { }

	// RVA: 0x41A7DD4 Offset: 0x41A3DD4 VA: 0x41A7DD4
	public void SetRimPower(float value) { }

	// RVA: 0x41A7EC0 Offset: 0x41A3EC0 VA: 0x41A7EC0
	public void SetRimScale(float value) { }

	// RVA: 0x41A7F80 Offset: 0x41A3F80 VA: 0x41A7F80
	public void SetRimColor(Color color) { }

	// RVA: 0x41A8060 Offset: 0x41A4060 VA: 0x41A8060
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class AlwaysRotateToCamera : MonoBehaviour // TypeDefIndex: 21143
{
	// Fields
	private Camera _camera; // 0x20

	// Methods

	// RVA: 0x41A807C Offset: 0x41A407C VA: 0x41A807C
	private void Awake() { }

	// RVA: 0x41A80A0 Offset: 0x41A40A0 VA: 0x41A80A0
	private void LateUpdate() { }

	// RVA: 0x41A8154 Offset: 0x41A4154 VA: 0x41A8154
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class RotationCtrl : MonoBehaviour // TypeDefIndex: 21144
{
	// Fields
	public Vector3 m_diration; // 0x20
	public float m_speed; // 0x2C

	// Methods

	// RVA: 0x41A815C Offset: 0x41A415C VA: 0x41A815C
	private void Update() { }

	// RVA: 0x41A81E0 Offset: 0x41A41E0 VA: 0x41A81E0
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class SortingOrderController : MonoBehaviour // TypeDefIndex: 21145
{
	// Fields
	public int m_sortingOrder; // 0x20
	public Renderer m_render; // 0x28

	// Methods

	// RVA: 0x41A8248 Offset: 0x41A4248 VA: 0x41A8248
	private void OnEnable() { }

	// RVA: 0x41A82D0 Offset: 0x41A42D0 VA: 0x41A82D0
	private void OnDisable() { }

	// RVA: 0x41A8358 Offset: 0x41A4358 VA: 0x41A8358
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
[RequireComponent(typeof(BoneFollower))]
public class BoneFollowHelper : MonoBehaviour // TypeDefIndex: 21146
{
	// Fields
	public string boneName; // 0x20

	// Methods

	// RVA: 0x41A8368 Offset: 0x41A4368 VA: 0x41A8368
	public void AutoSet() { }

	// RVA: 0x41A8538 Offset: 0x41A4538 VA: 0x41A8538
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class ColorRender : MonoBehaviour // TypeDefIndex: 21147
{
	// Fields
	public const string m_fillColorName = "_FillColor";
	public const string m__fillPhaseName = "_FillPhase";
	public float m_durtion; // 0x20
	public AnimationCurve m_curve; // 0x28
	public float m_maxIntensity; // 0x30
	private Renderer[] m_renderers; // 0x38
	private MaterialPropertyBlock m_block; // 0x40
	[Label]
	public bool m_isPlaying; // 0x48
	[Label]
	public float m_currentTime; // 0x4C
	[Label]
	public float m_currentProgress; // 0x50

	// Methods

	// RVA: 0x41A8598 Offset: 0x41A4598 VA: 0x41A8598
	public void OnInit(Renderer[] renderers) { }

	// RVA: 0x41A85B8 Offset: 0x41A45B8 VA: 0x41A85B8
	private void InitBlock() { }

	// RVA: 0x41A862C Offset: 0x41A462C VA: 0x41A862C
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41A8778 Offset: 0x41A4778 VA: 0x41A8778
	public void OnDeInit() { }

	// RVA: 0x41A877C Offset: 0x41A477C VA: 0x41A877C
	public void Play(float progress = 0) { }

	// RVA: 0x41A879C Offset: 0x41A479C VA: 0x41A879C
	public void Stop() { }

	// RVA: 0x41A86B8 Offset: 0x41A46B8 VA: 0x41A86B8
	public void SetFillPhase(float value) { }

	// RVA: 0x41A87A4 Offset: 0x41A47A4 VA: 0x41A87A4
	public void SetFillColor(Color c) { }

	// RVA: 0x41A8884 Offset: 0x41A4884 VA: 0x41A8884
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class SpriteRegister.RegisterData // TypeDefIndex: 21148
{
	// Fields
	public string m_name; // 0x10
	public Sprite m_object; // 0x18

	// Methods

	// RVA: 0x41A8A84 Offset: 0x41A4A84 VA: 0x41A8A84
	public void .ctor() { }
}

// Namespace: Framework.Logic.Component
public class SpriteRegister : MonoBehaviour // TypeDefIndex: 21149
{
	// Fields
	[SerializeField]
	private SpriteRegister.RegisterData[] m_datas; // 0x20
	private Dictionary<string, Sprite> m_dic; // 0x28

	// Methods

	// RVA: 0x41A88D8 Offset: 0x41A48D8 VA: 0x41A88D8
	private void LoadGameObject() { }

	// RVA: 0x41A89D8 Offset: 0x41A49D8 VA: 0x41A89D8
	public Sprite GetSprite(string name) { }

	// RVA: 0x41A8A58 Offset: 0x41A4A58 VA: 0x41A8A58
	public Dictionary<string, Sprite> GetDic() { }

	// RVA: 0x41A8A7C Offset: 0x41A4A7C VA: 0x41A8A7C
	public void .ctor() { }
}

// Namespace: 
private enum Bson.ValueType // TypeDefIndex: 21150
{
	// Fields
	public byte value__; // 0x0
	public const Bson.ValueType Bool = 1;
	public const Bson.ValueType SByte = 2;
	public const Bson.ValueType Byte = 3;
	public const Bson.ValueType Char = 4;
	public const Bson.ValueType Short = 5;
	public const Bson.ValueType UShort = 6;
	public const Bson.ValueType Int = 7;
	public const Bson.ValueType UInt = 8;
	public const Bson.ValueType Int64 = 9;
	public const Bson.ValueType UInt64 = 10;
	public const Bson.ValueType Decimal = 11;
	public const Bson.ValueType Float = 12;
	public const Bson.ValueType Double = 13;
	public const Bson.ValueType DateTime = 14;
	public const Bson.ValueType Enum = 15;
	public const Bson.ValueType String = 16;
	public const Bson.ValueType Array = 17;
	public const Bson.ValueType Vector2 = 18;
	public const Bson.ValueType Vector3 = 19;
	public const Bson.ValueType Vector4 = 20;
	public const Bson.ValueType Color = 21;
	public const Bson.ValueType Color32 = 22;
	public const Bson.ValueType Quaternion = 23;
	public const Bson.ValueType Bounds = 24;
	public const Bson.ValueType Rect = 25;
	public const Bson.ValueType Matrix = 26;
	public const Bson.ValueType Object = 27;
}

// Namespace: 
private struct Bson.PropertyMeta // TypeDefIndex: 21151
{
	// Fields
	[CompilerGenerated]
	private MemberInfo <Info>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsField>k__BackingField; // 0x8
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x10

	// Properties
	public MemberInfo Info { get; set; }
	public bool IsField { get; set; }
	public Type Type { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41AA880 Offset: 0x41A6880 VA: 0x41AA880
	public MemberInfo get_Info() { }

	[CompilerGenerated]
	// RVA: 0x41AA888 Offset: 0x41A6888 VA: 0x41AA888
	public void set_Info(MemberInfo value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41AA890 Offset: 0x41A6890 VA: 0x41AA890
	public bool get_IsField() { }

	[CompilerGenerated]
	// RVA: 0x41AA898 Offset: 0x41A6898 VA: 0x41AA898
	public void set_IsField(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA8A4 Offset: 0x41A68A4 VA: 0x41AA8A4
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x41AA8AC Offset: 0x41A68AC VA: 0x41AA8AC
	public void set_Type(Type value) { }
}

// Namespace: 
private struct Bson.ArrayMeta // TypeDefIndex: 21152
{
	// Fields
	[CompilerGenerated]
	private Type <ItemType>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsArray>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <IsList>k__BackingField; // 0x9

	// Properties
	public Type ItemType { get; set; }
	public bool IsArray { get; set; }
	public bool IsList { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA8B4 Offset: 0x41A68B4 VA: 0x41AA8B4
	public Type get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x41AA8BC Offset: 0x41A68BC VA: 0x41AA8BC
	public void set_ItemType(Type value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA8C4 Offset: 0x41A68C4 VA: 0x41AA8C4
	public bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x41AA8CC Offset: 0x41A68CC VA: 0x41AA8CC
	public void set_IsArray(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA8D8 Offset: 0x41A68D8 VA: 0x41AA8D8
	public bool get_IsList() { }

	[CompilerGenerated]
	// RVA: 0x41AA8E0 Offset: 0x41A68E0 VA: 0x41AA8E0
	public void set_IsList(bool value) { }
}

// Namespace: 
private struct Bson.ObjectMeta // TypeDefIndex: 21153
{
	// Fields
	[CompilerGenerated]
	private Type <ElemType>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsDict>k__BackingField; // 0x8
	[CompilerGenerated]
	private IDictionary<string, Bson.PropertyMeta> <Properties>k__BackingField; // 0x10

	// Properties
	public Type ElemType { get; set; }
	public bool IsDict { get; set; }
	public IDictionary<string, Bson.PropertyMeta> Properties { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41AA8EC Offset: 0x41A68EC VA: 0x41AA8EC
	public Type get_ElemType() { }

	[CompilerGenerated]
	// RVA: 0x41AA8F4 Offset: 0x41A68F4 VA: 0x41AA8F4
	public void set_ElemType(Type value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA8FC Offset: 0x41A68FC VA: 0x41AA8FC
	public bool get_IsDict() { }

	[CompilerGenerated]
	// RVA: 0x41AA904 Offset: 0x41A6904 VA: 0x41AA904
	public void set_IsDict(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AA910 Offset: 0x41A6910 VA: 0x41AA910
	public IDictionary<string, Bson.PropertyMeta> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x41AA918 Offset: 0x41A6918 VA: 0x41AA918
	public void set_Properties(IDictionary<string, Bson.PropertyMeta> value) { }
}

// Namespace: 
private sealed class Bson.ByteArrayComparer : IEqualityComparer<byte[]> // TypeDefIndex: 21154
{
	// Properties
	public static Bson.ByteArrayComparer Default { get; }

	// Methods

	// RVA: 0x41AA82C Offset: 0x41A682C VA: 0x41AA82C
	public static Bson.ByteArrayComparer get_Default() { }

	// RVA: 0x41AA928 Offset: 0x41A6928 VA: 0x41AA928 Slot: 4
	public bool Equals(byte[] left, byte[] right) { }

	// RVA: 0x41AA9D0 Offset: 0x41A69D0 VA: 0x41AA9D0 Slot: 5
	public int GetHashCode(byte[] obj) { }

	// RVA: 0x41AA920 Offset: 0x41A6920 VA: 0x41AA920
	public void .ctor() { }
}

// Namespace: 
public sealed class Bson.Reader : IDisposable // TypeDefIndex: 21155
{
	// Fields
	private readonly MemoryStream _stream; // 0x10
	private readonly BinaryReader _reader; // 0x18
	private bool _isDisposed; // 0x20

	// Methods

	// RVA: 0x41AAA80 Offset: 0x41A6A80 VA: 0x41AAA80
	public void .ctor(byte[] bson) { }

	// RVA: 0x41AAAEC Offset: 0x41A6AEC VA: 0x41AAAEC
	public void .ctor(MemoryStream stream) { }

	// RVA: 0x41AABB4 Offset: 0x41A6BB4 VA: 0x41AABB4
	public object Decode(Type type) { }

	// RVA: 0x41AC144 Offset: 0x41A8144 VA: 0x41AC144
	private DateTime ReadDateTime() { }

	// RVA: 0x41AC204 Offset: 0x41A8204 VA: 0x41AC204
	private object ReadEnum(Type type) { }

	// RVA: 0x41AC288 Offset: 0x41A8288 VA: 0x41AC288
	private object ReadArray(Type type) { }

	// RVA: 0x41AC664 Offset: 0x41A8664 VA: 0x41AC664
	private Vector2 ReadVector2() { }

	// RVA: 0x41AC6BC Offset: 0x41A86BC VA: 0x41AC6BC
	private Vector3 ReadVector3() { }

	// RVA: 0x41AC734 Offset: 0x41A8734 VA: 0x41AC734
	private Vector4 ReadVector4() { }

	// RVA: 0x41AC7D4 Offset: 0x41A87D4 VA: 0x41AC7D4
	private Color ReadColor() { }

	// RVA: 0x41AC874 Offset: 0x41A8874 VA: 0x41AC874
	private Color32 ReadColor32() { }

	// RVA: 0x41AC914 Offset: 0x41A8914 VA: 0x41AC914
	private Quaternion ReadQuaternion() { }

	// RVA: 0x41AC9B4 Offset: 0x41A89B4 VA: 0x41AC9B4
	private Bounds ReadBounds() { }

	// RVA: 0x41ACA9C Offset: 0x41A8A9C VA: 0x41ACA9C
	private Rect ReadRect() { }

	// RVA: 0x41ACB3C Offset: 0x41A8B3C VA: 0x41ACB3C
	private Matrix4x4 ReadMatrix() { }

	// RVA: 0x41ACD94 Offset: 0x41A8D94 VA: 0x41ACD94
	private object ReadObject(Type type) { }

	// RVA: 0x41AD1B4 Offset: 0x41A91B4 VA: 0x41AD1B4 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public sealed class Bson.Writer : IDisposable // TypeDefIndex: 21156
{
	// Fields
	private readonly MemoryStream _stream; // 0x10
	private readonly BinaryWriter _writer; // 0x18
	private bool _isDisposed; // 0x20

	// Properties
	public byte[] Bytes { get; }

	// Methods

	// RVA: 0x41A9498 Offset: 0x41A5498 VA: 0x41A9498
	public byte[] get_Bytes() { }

	// RVA: 0x41A8C40 Offset: 0x41A4C40 VA: 0x41A8C40
	public void .ctor(MemoryStream stream) { }

	// RVA: 0x41A8D08 Offset: 0x41A4D08 VA: 0x41A8D08
	public void Encode(object obj) { }

	// RVA: 0x41AD1F8 Offset: 0x41A91F8 VA: 0x41AD1F8
	private void Write(bool value) { }

	// RVA: 0x41AD24C Offset: 0x41A924C VA: 0x41AD24C
	private void Write(sbyte value) { }

	// RVA: 0x41AD2A0 Offset: 0x41A92A0 VA: 0x41AD2A0
	private void Write(byte value) { }

	// RVA: 0x41AD2F4 Offset: 0x41A92F4 VA: 0x41AD2F4
	private void Write(char value) { }

	// RVA: 0x41AD348 Offset: 0x41A9348 VA: 0x41AD348
	private void Write(short value) { }

	// RVA: 0x41AD39C Offset: 0x41A939C VA: 0x41AD39C
	private void Write(ushort value) { }

	// RVA: 0x41AD3F0 Offset: 0x41A93F0 VA: 0x41AD3F0
	private void Write(int value) { }

	// RVA: 0x41AD444 Offset: 0x41A9444 VA: 0x41AD444
	private void Write(uint value) { }

	// RVA: 0x41AD498 Offset: 0x41A9498 VA: 0x41AD498
	private void Write(long value) { }

	// RVA: 0x41AD4EC Offset: 0x41A94EC VA: 0x41AD4EC
	private void Write(ulong value) { }

	// RVA: 0x41AD540 Offset: 0x41A9540 VA: 0x41AD540
	private void Write(Decimal value) { }

	// RVA: 0x41AD59C Offset: 0x41A959C VA: 0x41AD59C
	private void Write(float value) { }

	// RVA: 0x41AD5F0 Offset: 0x41A95F0 VA: 0x41AD5F0
	private void Write(double value) { }

	// RVA: 0x41AD644 Offset: 0x41A9644 VA: 0x41AD644
	private void Write(DateTime value) { }

	// RVA: 0x41AD7F4 Offset: 0x41A97F4 VA: 0x41AD7F4
	private void WriteEnum(object value) { }

	// RVA: 0x41AD89C Offset: 0x41A989C VA: 0x41AD89C
	private void Write(string value) { }

	// RVA: 0x41AD8F0 Offset: 0x41A98F0 VA: 0x41AD8F0
	private void Write(IList value) { }

	// RVA: 0x41ADDF0 Offset: 0x41A9DF0 VA: 0x41ADDF0
	private void Write(IDictionary value) { }

	// RVA: 0x41AE38C Offset: 0x41AA38C VA: 0x41AE38C
	private void Write(Vector2 value) { }

	// RVA: 0x41AE400 Offset: 0x41AA400 VA: 0x41AE400
	private void Write(Vector3 value) { }

	// RVA: 0x41AE49C Offset: 0x41AA49C VA: 0x41AE49C
	private void Write(Vector4 value) { }

	// RVA: 0x41AE558 Offset: 0x41AA558 VA: 0x41AE558
	private void Write(Color value) { }

	// RVA: 0x41AE614 Offset: 0x41AA614 VA: 0x41AE614
	private void Write(Color32 value) { }

	// RVA: 0x41AE6BC Offset: 0x41AA6BC VA: 0x41AE6BC
	private void Write(Quaternion value) { }

	// RVA: 0x41AE778 Offset: 0x41AA778 VA: 0x41AE778
	private void Write(Bounds value) { }

	// RVA: 0x41AE858 Offset: 0x41AA858 VA: 0x41AE858
	private void Write(Rect value) { }

	// RVA: 0x41AE914 Offset: 0x41AA914 VA: 0x41AE914
	private void Write(Matrix4x4 value) { }

	// RVA: 0x41AEB0C Offset: 0x41AAB0C VA: 0x41AEB0C
	private void Write(object value) { }

	// RVA: 0x41AF27C Offset: 0x41AB27C VA: 0x41AF27C Slot: 4
	public void Dispose() { }
}

// Namespace: Framework.Logic.Bson
public sealed class Bson // TypeDefIndex: 21157
{
	// Fields
	private static readonly Dictionary<byte[], object> _bsonObjects; // 0x0
	private static readonly IDictionary<Type, IList<Bson.PropertyMeta>> _propertyMetas; // 0x8
	private static readonly IDictionary<Type, Bson.ArrayMeta> _arrayMetas; // 0x10
	private static readonly IDictionary<Type, Bson.ObjectMeta> _objectMetas; // 0x18

	// Methods

	// RVA: 0x41A8A8C Offset: 0x41A4A8C VA: 0x41A8A8C
	public static byte[] ToBson(object obj, bool cache = False) { }

	// RVA: 0x41A954C Offset: 0x41A554C VA: 0x41A954C
	public static void ToBson(object obj, Bson.Writer writer) { }

	// RVA: -1 Offset: -1
	public static T ToObject<T>(byte[] bson) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4548E18 Offset: 0x4544E18 VA: 0x4548E18
	|-Bson.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObject<T>(Bson.Reader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45491B4 Offset: 0x45451B4 VA: 0x45491B4
	|-Bson.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41A9568 Offset: 0x41A5568 VA: 0x41A9568
	public static void Clear() { }

	// RVA: 0x41A9760 Offset: 0x41A5760 VA: 0x41A9760
	private static IList<Bson.PropertyMeta> AddPropertyMetas(Type type) { }

	// RVA: 0x41A9BB4 Offset: 0x41A5BB4 VA: 0x41A9BB4
	private static Bson.ArrayMeta AddArrayMeta(Type type) { }

	// RVA: 0x41A9F70 Offset: 0x41A5F70 VA: 0x41A9F70
	private static Bson.ObjectMeta AddObjectMeta(Type type) { }

	// RVA: 0x41AA674 Offset: 0x41A6674 VA: 0x41AA674
	public void .ctor() { }

	// RVA: 0x41AA67C Offset: 0x41A667C VA: 0x41AA67C
	private static void .cctor() { }
}

// Namespace: Framework.Logic.AttributeExpansion
[Usage(32767, Inherited = True)]
public class ConditionalHideAttribute : PropertyAttribute // TypeDefIndex: 21158
{
	// Fields
	public string ConditionalSourceField; // 0x10
	public string ConditionalSourceField2; // 0x18
	public bool HideInInspector; // 0x20
	public bool Inverse; // 0x21

	// Methods

	// RVA: 0x41AF2C0 Offset: 0x41AB2C0 VA: 0x41AF2C0
	public void .ctor(string conditionalSourceField) { }

	// RVA: 0x41AF350 Offset: 0x41AB350 VA: 0x41AF350
	public void .ctor(string conditionalSourceField, bool hideInInspector) { }

	// RVA: 0x41AF3EC Offset: 0x41AB3EC VA: 0x41AF3EC
	public void .ctor(string conditionalSourceField, bool hideInInspector, bool inverse) { }
}

// Namespace: Framework.Logic.AttributeExpansion
[Usage(256)]
public sealed class LabelAttribute : PropertyAttribute // TypeDefIndex: 21159
{
	// Methods

	// RVA: 0x41AF498 Offset: 0x41AB498 VA: 0x41AF498
	public void .ctor() { }
}

// Namespace: Framework.Logic.AssetReference
[Serializable]
public class AssetReferenceMaterial : AssetReferenceT<Material> // TypeDefIndex: 21160
{
	// Methods

	// RVA: 0x41AF4A0 Offset: 0x41AB4A0 VA: 0x41AF4A0
	public void .ctor(string guid) { }
}

// Namespace: Framework.Logic.AssetReference
[Serializable]
public class AssetReferenceScriptableObject : AssetReferenceT<ScriptableObject> // TypeDefIndex: 21161
{
	// Methods

	// RVA: 0x41AF4F8 Offset: 0x41AB4F8 VA: 0x41AF4F8
	public void .ctor(string guid) { }
}

// Namespace: Framework.Logic.AssetReference
public class ComponentReference<TComponent> : AssetReference // TypeDefIndex: 21162
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA8D88 Offset: 0x5CA4D88 VA: 0x5CA8D88
	|-ComponentReference<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TComponent> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA8D90 Offset: 0x5CA4D90 VA: 0x5CA8D90
	|-ComponentReference<__Il2CppFullySharedGenericType>.InstantiateAsync
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TComponent> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA8F24 Offset: 0x5CA4F24 VA: 0x5CA8F24
	|-ComponentReference<__Il2CppFullySharedGenericType>.InstantiateAsync
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TComponent> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9060 Offset: 0x5CA5060 VA: 0x5CA9060
	|-ComponentReference<__Il2CppFullySharedGenericType>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TComponent> GameObjectReady(AsyncOperationHandle<GameObject> arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9188 Offset: 0x5CA5188 VA: 0x5CA9188
	|-ComponentReference<__Il2CppFullySharedGenericType>.GameObjectReady
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA935C Offset: 0x5CA535C VA: 0x5CA935C
	|-ComponentReference<__Il2CppFullySharedGenericType>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9494 Offset: 0x5CA5494 VA: 0x5CA9494
	|-ComponentReference<__Il2CppFullySharedGenericType>.ValidateAsset
	*/

	// RVA: -1 Offset: -1
	public void ReleaseInstance(AsyncOperationHandle<TComponent> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA949C Offset: 0x5CA549C VA: 0x5CA949C
	|-ComponentReference<__Il2CppFullySharedGenericType>.ReleaseInstance
	*/
}

// Namespace: Framework.GorillaSDK
[CreateAssetMenu(fileName = "GorillaSDKConfig", menuName = "GorillaSDK/GorillaSDKConfig")]
public class GorillaSDKConfig : ScriptableObject // TypeDefIndex: 21163
{
	// Fields
	public const string ResourcePath = "GorillaSDK/GorillaSDKConfig";
	public const string AssetPath = "Assets/Resources/GorillaSDK/GorillaSDKConfig.asset";
	public SDKConfig test; // 0x18
	public SDKConfig production; // 0x20

	// Methods

	// RVA: 0x41AF550 Offset: 0x41AB550 VA: 0x41AF550
	public static SDKConfig Load(bool isRelease) { }

	// RVA: 0x41AF658 Offset: 0x41AB658 VA: 0x41AF658
	public void .ctor() { }
}

// Namespace: Framework.CoordinatedUnits
public class PreGroupSlot : PreSlotBase // TypeDefIndex: 21164
{
	// Methods

	// RVA: 0x41AF660 Offset: 0x41AB660 VA: 0x41AF660
	private void Start() { }

	// RVA: 0x41AF664 Offset: 0x41AB664 VA: 0x41AF664
	private void Update() { }

	// RVA: 0x41AF668 Offset: 0x41AB668 VA: 0x41AF668
	public void .ctor() { }
}

// Namespace: Framework.CoordinatedUnits
public class PreSlot : PreSlotBase // TypeDefIndex: 21165
{
	// Methods

	// RVA: 0x41AF678 Offset: 0x41AB678 VA: 0x41AF678
	private void Start() { }

	// RVA: 0x41AF67C Offset: 0x41AB67C VA: 0x41AF67C
	private void Update() { }

	// RVA: 0x41AF680 Offset: 0x41AB680 VA: 0x41AF680
	public void .ctor() { }
}

// Namespace: Framework.CoordinatedUnits
public class PreSlotBase : MonoBehaviour // TypeDefIndex: 21166
{
	// Fields
	public int PosIndex; // 0x20
	public int RankOrder; // 0x24
	public int AttackPriority; // 0x28

	// Methods

	// RVA: 0x41AF688 Offset: 0x41AB688 VA: 0x41AF688
	private void Start() { }

	// RVA: 0x41AF68C Offset: 0x41AB68C VA: 0x41AF68C
	private void Update() { }

	// RVA: 0x41AF670 Offset: 0x41AB670 VA: 0x41AF670
	public void .ctor() { }
}

// Namespace: Framework.CoordinatedUnits
public class PreVirtualLeaderSlot : PreSlotBase // TypeDefIndex: 21167
{
	// Methods

	// RVA: 0x41AF690 Offset: 0x41AB690 VA: 0x41AF690
	private void Start() { }

	// RVA: 0x41AF694 Offset: 0x41AB694 VA: 0x41AF694
	private void Update() { }

	// RVA: 0x41AF698 Offset: 0x41AB698 VA: 0x41AF698
	public void .ctor() { }
}

// Namespace: Framework.ViewModule
public abstract class BaseViewModule : MonoBehaviour // TypeDefIndex: 21168
{
	// Fields
	public UIViewType m_ViewType; // 0x20
	[CompilerGenerated]
	private int <m_viewName>k__BackingField; // 0x24
	private BaseViewModuleLoader m_loader; // 0x28
	internal static readonly int hideHash; // 0x0
	[CompilerGenerated]
	private bool <m_isAddBack>k__BackingField; // 0x30

	// Properties
	public int m_viewName { get; set; }
	public BaseViewModuleLoader Loader { get; }
	public bool m_isAddBack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41AF6A0 Offset: 0x41AB6A0 VA: 0x41AF6A0
	public int get_m_viewName() { }

	[CompilerGenerated]
	// RVA: 0x41AF6A8 Offset: 0x41AB6A8 VA: 0x41AF6A8
	private void set_m_viewName(int value) { }

	// RVA: 0x41AF6B0 Offset: 0x41AB6B0 VA: 0x41AF6B0
	public BaseViewModuleLoader get_Loader() { }

	// RVA: 0x41AF6B8 Offset: 0x41AB6B8 VA: 0x41AF6B8
	public void SetViewData(int viewName) { }

	// RVA: 0x41AF6C0 Offset: 0x41AB6C0 VA: 0x41AF6C0
	internal void SetLoader(BaseViewModuleLoader loader) { }

	// RVA: 0x41AF6C8 Offset: 0x41AB6C8 VA: 0x41AF6C8 Slot: 4
	public virtual void OnLateUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41AF6CC Offset: 0x41AB6CC VA: 0x41AF6CC Slot: 5
	public virtual void AddDefaultListener() { }

	// RVA: 0x41AF7E8 Offset: 0x41AB7E8 VA: 0x41AF7E8 Slot: 6
	protected virtual void OnAnimatorListen(GameObject obj, string eventName) { }

	// RVA: 0x41AFA6C Offset: 0x41ABA6C VA: 0x41AFA6C Slot: 7
	public virtual void RemoveDefaultListener() { }

	// RVA: 0x41AFB88 Offset: 0x41ABB88 VA: 0x41AFB88 Slot: 8
	public virtual void OnPopShowFinish() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void RegisterEvents(EventSystemManager manager);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void UnRegisterEvents(EventSystemManager manager);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnCreate(object data);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnDelete();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnOpen(object data);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnClose();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnUpdate(float deltaTime, float unscaledDeltaTime);

	// RVA: 0x41AFB8C Offset: 0x41ABB8C VA: 0x41AFB8C Slot: 16
	public virtual bool IsAddBack() { }

	// RVA: 0x41AFB94 Offset: 0x41ABB94 VA: 0x41AFB94
	public void SetAddBack(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41AFBA0 Offset: 0x41ABBA0 VA: 0x41AFBA0
	public bool get_m_isAddBack() { }

	[CompilerGenerated]
	// RVA: 0x41AFBA8 Offset: 0x41ABBA8 VA: 0x41AFBA8
	private void set_m_isAddBack(bool value) { }

	// RVA: 0x41AFBB4 Offset: 0x41ABBB4 VA: 0x41AFBB4
	protected void CloseSelf() { }

	// RVA: 0x41AF8D4 Offset: 0x41AB8D4 VA: 0x41AF8D4
	protected void CloseSelf(bool force, Animator animator) { }

	// RVA: 0x41A318C Offset: 0x419F18C VA: 0x41A318C
	protected void .ctor() { }

	// RVA: 0x41AFCFC Offset: 0x41ABCFC VA: 0x41AFCFC
	private static void .cctor() { }
}

// Namespace: Framework.ViewModule
public abstract class BaseViewModuleLoader // TypeDefIndex: 21169
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Task OnLoad(object data);

	// RVA: 0x41AFD64 Offset: 0x41ABD64 VA: 0x41AFD64 Slot: 5
	public virtual void OnInstantiate(GameObject gameObject) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnUnLoad();

	// RVA: 0x41AFD68 Offset: 0x41ABD68 VA: 0x41AFD68
	protected void .ctor() { }
}

// Namespace: Framework.ViewModule
public enum UILayers // TypeDefIndex: 21170
{
	// Fields
	public int value__; // 0x0
	public const UILayers First = 0;
	public const UILayers Second = 1;
	public const UILayers Third = 2;
	public const UILayers Four = 3;
}

// Namespace: Framework.ViewModule
public class UIPool : MonoBehaviour // TypeDefIndex: 21171
{
	// Fields
	public GameObject m_checkAssetsUI; // 0x20
	public GameObject m_netloadingUI; // 0x28
	public RuntimeAnimatorController m_buttonAnimatorController; // 0x30
	public RuntimeAnimatorController m_popAnimatorController; // 0x38

	// Methods

	// RVA: 0x41AFD70 Offset: 0x41ABD70 VA: 0x41AFD70
	public void .ctor() { }
}

// Namespace: Framework.ViewModule
public enum UIViewType // TypeDefIndex: 21172
{
	// Fields
	public int value__; // 0x0
	public const UIViewType FullView = 0;
	public const UIViewType PopView = 1;
}

// Namespace: Framework.ViewModule
public class ViewEventArgs : BaseEventArgs // TypeDefIndex: 21173
{
	// Fields
	public int ViewName; // 0x18

	// Methods

	// RVA: 0x41AFD78 Offset: 0x41ABD78 VA: 0x41AFD78
	public ViewEventArgs SetData(int viewName) { }

	// RVA: 0x41AFD80 Offset: 0x41ABD80 VA: 0x41AFD80 Slot: 4
	public override void Clear() { }

	// RVA: 0x41AFD88 Offset: 0x41ABD88 VA: 0x41AFD88
	public void .ctor() { }
}

// Namespace: Framework.ViewModule
public enum DestoryType // TypeDefIndex: 21174
{
	// Fields
	public int value__; // 0x0
	public const DestoryType Dont = 0;
	public const DestoryType Immediate = 1;
	public const DestoryType Auto = 2;
}

// Namespace: Framework.ViewModule
public class ViewModuleData // TypeDefIndex: 21175
{
	// Fields
	public int m_id; // 0x10
	public string m_assetPath; // 0x18
	public GameObject m_gameObject; // 0x20
	public BaseViewModuleLoader m_loader; // 0x28
	public GameObject m_prefab; // 0x30
	public BaseViewModule m_viewModule; // 0x38
	public bool m_isCanDestory; // 0x40
	public ViewState m_viewState; // 0x44
	[CompilerGenerated]
	private bool <SetPadding>k__BackingField; // 0x48

	// Properties
	public bool SetPadding { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41AFD90 Offset: 0x41ABD90 VA: 0x41AFD90
	public bool get_SetPadding() { }

	[CompilerGenerated]
	// RVA: 0x41AFD98 Offset: 0x41ABD98 VA: 0x41AFD98
	private void set_SetPadding(bool value) { }

	// RVA: 0x41AFDA4 Offset: 0x41ABDA4 VA: 0x41AFDA4
	public void .ctor(int viewID, GameObject gameObject, bool isCanDestory = True, bool setPadding = True) { }

	// RVA: 0x41AFDFC Offset: 0x41ABDFC VA: 0x41AFDFC
	public void .ctor(int viewID, BaseViewModuleLoader loader, string assetPath, bool isCanDestory = True, bool setPadding = True) { }
}

// Namespace: 
public struct ViewModuleManager.MaskDisposer : IDisposable // TypeDefIndex: 21176
{
	// Fields
	private ViewModuleManager m_viewModuleManager; // 0x0

	// Methods

	// RVA: 0x41B2540 Offset: 0x41AE540 VA: 0x41B2540
	public void .ctor(ViewModuleManager viewModuleManager) { }

	// RVA: 0x41B2548 Offset: 0x41AE548 VA: 0x41B2548
	public void PopMask() { }

	// RVA: 0x41B2564 Offset: 0x41AE564 VA: 0x41B2564 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
private struct ViewModuleManager.<OpenView>d__23 : IAsyncStateMachine // TypeDefIndex: 21177
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ViewModuleManager <>4__this; // 0x20
	public int viewName; // 0x28
	public object data; // 0x30
	public UILayers layer; // 0x38
	public Action<GameObject> loadedCallBack; // 0x40
	public Action<GameObject> openedCallBack; // 0x48
	private TaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x41B2580 Offset: 0x41AE580 VA: 0x41B2580 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B2768 Offset: 0x41AE768 VA: 0x41B2768 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ViewModuleManager.<OpenViewInternal>d__24 : IAsyncStateMachine // TypeDefIndex: 21178
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ViewModuleManager <>4__this; // 0x20
	public int viewName; // 0x28
	public UILayers layer; // 0x2C
	public object data; // 0x30
	public Action<GameObject> loadedCallBack; // 0x38
	public Action<GameObject> openedCallBack; // 0x40
	private ViewModuleData <_viewModuleData>5__2; // 0x48
	private AsyncOperationHandle<GameObject> <_handler>5__3; // 0x50
	private TaskAwaiter<GameObject> <>u__1; // 0x68
	private TaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x41B27D0 Offset: 0x41AE7D0 VA: 0x41B27D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B384C Offset: 0x41AF84C VA: 0x41B384C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ViewModule
public sealed class ViewModuleManager : MonoBehaviour // TypeDefIndex: 21179
{
	// Fields
	private readonly Dictionary<int, int> _viewOpenTimestamps; // 0x20
	private readonly HashSet<int> _reportedViews; // 0x28
	private Dictionary<int, ViewModuleData> m_viewModuleDatas; // 0x30
	private Dictionary<int, UILayers> m_layers; // 0x38
	[Header("View Setting")]
	[SerializeField]
	private UIPool m_uiPool; // 0x40
	[SerializeField]
	private EventSystemManager m_eventSystemManager; // 0x48
	[SerializeField]
	private ResourcesManager m_resourcesManager; // 0x50
	[SerializeField]
	private Camera m_uiCamera; // 0x58
	[Header("Mask Setting")]
	[SerializeField]
	private GameObject m_maskUI; // 0x60
	[Label]
	[SerializeField]
	private int m_maskCount; // 0x68
	public Func<int, string> m_funcAnalysisViewName; // 0x70
	private AndroidBackManager m_backManager; // 0x78
	public GameObject[] m_layerObjects; // 0x80
	private int m_netLoadingCount; // 0x88

	// Properties
	public UIPool Pool { get; }
	public Camera UICamera { get; set; }

	// Methods

	// RVA: 0x41AFE70 Offset: 0x41ABE70 VA: 0x41AFE70
	public UIPool get_Pool() { }

	// RVA: 0x41AFE78 Offset: 0x41ABE78 VA: 0x41AFE78
	public Camera get_UICamera() { }

	// RVA: 0x41AFE80 Offset: 0x41ABE80 VA: 0x41AFE80
	private void set_UICamera(Camera value) { }

	// RVA: 0x41AFE88 Offset: 0x41ABE88 VA: 0x41AFE88
	public void RegisterViewModule(ViewModuleData viewModuleData) { }

	// RVA: 0x41AFEF4 Offset: 0x41ABEF4 VA: 0x41AFEF4
	public void UnRegisterViewModule(ViewModuleData viewModuleData) { }

	// RVA: 0x41AFF5C Offset: 0x41ABF5C VA: 0x41AFF5C
	public void UnRegisterAllViewModule(int[] ignoreIDs) { }

	// RVA: 0x41B0224 Offset: 0x41AC224 VA: 0x41B0224
	public ViewModuleData GetViewModuleData(int viewName) { }

	// RVA: -1 Offset: -1
	public T GetViewModule<T>(int viewName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x477FDEC Offset: 0x477BDEC VA: 0x477FDEC
	|-ViewModuleManager.GetViewModule<object>
	*/

	[AsyncStateMachine(typeof(ViewModuleManager.<OpenView>d__23))]
	// RVA: 0x419E0D8 Offset: 0x419A0D8 VA: 0x419E0D8
	public Task OpenView(int viewName, object data, UILayers layer = 0, Action<GameObject> loadedCallBack, Action<GameObject> openedCallBack) { }

	[AsyncStateMachine(typeof(ViewModuleManager.<OpenViewInternal>d__24))]
	// RVA: 0x41B0294 Offset: 0x41AC294 VA: 0x41B0294
	private Task OpenViewInternal(int viewName, object data, UILayers layer = 0, Action<GameObject> loadedCallBack, Action<GameObject> openedCallBack) { }

	// RVA: 0x41B03E0 Offset: 0x41AC3E0 VA: 0x41B03E0
	private GameObject InstantiateByPrefab(int viewName, GameObject prefab, UILayers layer, bool setPadding) { }

	// RVA: 0x41B0810 Offset: 0x41AC810 VA: 0x41B0810
	private void SetLayer(int viewName, GameObject obj, UILayers layer, bool setPadding) { }

	// RVA: 0x41B0B68 Offset: 0x41ACB68 VA: 0x41B0B68
	private void OpenViewByGameObject(ViewModuleData viewData, object data, Action<GameObject> openedCallBack, UILayers layer) { }

	// RVA: 0x419D6C0 Offset: 0x41996C0 VA: 0x419D6C0
	public void CloseView(int viewName) { }

	// RVA: 0x41B1128 Offset: 0x41AD128 VA: 0x41B1128
	public void ForceDestroyView(int viewName) { }

	// RVA: 0x41B0764 Offset: 0x41AC764 VA: 0x41B0764
	public GameObject GetGameObjectByUILayers(UILayers uilayer) { }

	// RVA: 0x41B1344 Offset: 0x41AD344 VA: 0x41B1344
	public void CloseAllView(int[] ignoreIDs) { }

	// RVA: 0x41B145C Offset: 0x41AD45C VA: 0x41B145C
	public void CloseAllView(UILayers[] layers, int[] ignoreIDs) { }

	// RVA: 0x419DBAC Offset: 0x4199BAC VA: 0x419DBAC
	public bool IsOpened(int viewName) { }

	// RVA: 0x419DCFC Offset: 0x4199CFC VA: 0x419DCFC
	public bool IsLoading(int viewName) { }

	// RVA: 0x419DE4C Offset: 0x4199E4C VA: 0x419DE4C
	public bool IsOpenedOrLoading(int viewName) { }

	// RVA: 0x41B15F0 Offset: 0x41AD5F0 VA: 0x41B15F0
	public bool HasOpenedOrLoadingViewInLayer(UILayers layer) { }

	// RVA: 0x41B17D4 Offset: 0x41AD7D4 VA: 0x41B17D4
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41B1A10 Offset: 0x41ADA10 VA: 0x41B1A10
	public void OnLateUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41B1C30 Offset: 0x41ADC30 VA: 0x41B1C30
	public string GetViewNameString(int viewName) { }

	// RVA: 0x41B1C68 Offset: 0x41ADC68 VA: 0x41B1C68
	public int[] GetRegisteredViewIds() { }

	// RVA: 0x41B1E58 Offset: 0x41ADE58 VA: 0x41B1E58
	public void RefreshCurrencyLayer(int currencyViewName) { }

	// RVA: 0x41B2000 Offset: 0x41AE000 VA: 0x41B2000
	private void OnViewOpenBeginInternal(int viewName) { }

	// RVA: 0x41B0DB0 Offset: 0x41ACDB0 VA: 0x41B0DB0
	private void OnViewOpenEndInternal(int viewName) { }

	// RVA: 0x41B20A0 Offset: 0x41AE0A0 VA: 0x41B20A0
	public ViewModuleManager.MaskDisposer PushMask() { }

	// RVA: 0x41B2184 Offset: 0x41AE184 VA: 0x41B2184
	public void PopMask() { }

	// RVA: 0x41B20D4 Offset: 0x41AE0D4 VA: 0x41B20D4
	private void SetMask(bool active) { }

	// RVA: 0x41B218C Offset: 0x41AE18C VA: 0x41B218C
	public void ShowNetLoading(bool value) { }

	// RVA: 0x41B2384 Offset: 0x41AE384 VA: 0x41B2384
	public void .ctor() { }
}

// Namespace: Framework.ViewModule
public enum ViewState // TypeDefIndex: 21180
{
	// Fields
	public int value__; // 0x0
	public const ViewState Null = 0;
	public const ViewState Loading = 1;
	public const ViewState Opened = 2;
	public const ViewState Closed = 3;
}

// Namespace: 
[Serializable]
public class CurveScriptable.CurveData // TypeDefIndex: 21181
{
	// Fields
	public int m_id; // 0x10
	public AnimationCurve m_curve; // 0x18

	// Methods

	// RVA: 0x41B3A2C Offset: 0x41AFA2C VA: 0x41B3A2C
	public void .ctor() { }
}

// Namespace: Framework.UnityGlobalManager
public class CurveScriptable : ScriptableObject // TypeDefIndex: 21182
{
	// Fields
	[SerializeField]
	private CurveScriptable.CurveData[] m_curves; // 0x18
	private Dictionary<int, AnimationCurve> DicCurves; // 0x20

	// Methods

	// RVA: 0x41B38B4 Offset: 0x41AF8B4 VA: 0x41B38B4
	public AnimationCurve GetAnimationCurve(int id) { }

	// RVA: 0x41B3934 Offset: 0x41AF934 VA: 0x41B3934
	private void LoadAsset() { }

	// RVA: 0x41B3A24 Offset: 0x41AFA24 VA: 0x41B3A24
	public void .ctor() { }
}

// Namespace: Framework.UnityGlobalManager
public interface IUnityGlobalManager // TypeDefIndex: 21183
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CurveScriptable GetCurve();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract GameObject GetGlobalGameObject(string path);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Load(Action finished);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UnLoad(Action finished);
}

// Namespace: Framework.UnityGlobalManager
public class UnityGlobalManager : MonoBehaviour // TypeDefIndex: 21184
{
	// Fields
	private IUnityGlobalManager m_manager; // 0x20

	// Properties
	public CurveScriptable Curve { get; }

	// Methods

	// RVA: 0x41B3A34 Offset: 0x41AFA34 VA: 0x41B3A34
	public void SetManager(IUnityGlobalManager manager) { }

	// RVA: 0x41B3A3C Offset: 0x41AFA3C VA: 0x41B3A3C
	public CurveScriptable get_Curve() { }

	// RVA: 0x41B3AE8 Offset: 0x41AFAE8 VA: 0x41B3AE8
	public GameObject GetGlobalGameObject(string path) { }

	// RVA: 0x41B3BA0 Offset: 0x41AFBA0 VA: 0x41B3BA0
	public void Load(Action finished) { }

	// RVA: 0x41B3C54 Offset: 0x41AFC54 VA: 0x41B3C54
	public void UnLoad(Action finished) { }

	// RVA: 0x41B3D08 Offset: 0x41AFD08 VA: 0x41B3D08
	public void OnInit() { }

	// RVA: 0x41B3D0C Offset: 0x41AFD0C VA: 0x41B3D0C
	public void OnDeInit() { }

	// RVA: 0x41B3D18 Offset: 0x41AFD18 VA: 0x41B3D18
	public void .ctor() { }
}

// Namespace: Framework.TableModule
public interface ITableManager // TypeDefIndex: 21185
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void InitialiseLocalModels();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Load(string fileName, Action callBack);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LoadAll(Action callBack);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Loads(List<string> fileNames, Action callBack);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UnLoad(string fileName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void UnLoadALl();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DeInitialiseLocalModels();
}

// Namespace: Framework.TableModule
public class TableManager : MonoBehaviour // TypeDefIndex: 21186
{
	// Fields
	private ITableManager m_manager; // 0x20

	// Methods

	// RVA: 0x41B3D20 Offset: 0x41AFD20 VA: 0x41B3D20
	public void SetITableManager(ITableManager manager) { }

	// RVA: 0x41B3D28 Offset: 0x41AFD28 VA: 0x41B3D28
	public ITableManager GetITableManager() { }

	// RVA: 0x41B3D30 Offset: 0x41AFD30 VA: 0x41B3D30
	public void .ctor() { }
}

// Namespace: Framework.State
public abstract class State // TypeDefIndex: 21187
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnEnter();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnUpdate(float deltaTime, float unscaledDeltaTime);

	// RVA: 0x41B3D38 Offset: 0x41AFD38 VA: 0x41B3D38 Slot: 7
	public virtual void OnLateUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnShutDown();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnAppFocus(bool hasFocus);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnAppPause(bool pauseStatus);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnExit();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void RegisterEvents(EventSystemManager manager);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UnRegisterEvents(EventSystemManager manager);

	// RVA: 0x41B3D3C Offset: 0x41AFD3C VA: 0x41B3D3C
	protected void .ctor() { }
}

// Namespace: Framework.State
public class StateManager : MonoBehaviour // TypeDefIndex: 21188
{
	// Fields
	private State m_currentState; // 0x20
	private Dictionary<int, State> m_states; // 0x28
	[SerializeField]
	private EventSystemManager m_eventSystemManager; // 0x30

	// Methods

	// RVA: 0x41B3D44 Offset: 0x41AFD44 VA: 0x41B3D44
	public void ActiveState(int stateName) { }

	// RVA: 0x41B3E14 Offset: 0x41AFE14 VA: 0x41B3E14
	public int GetCurrentStateName() { }

	// RVA: -1 Offset: -1
	public T GetState<T>(int stateName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47010B8 Offset: 0x46FD0B8 VA: 0x47010B8
	|-StateManager.GetState<object>
	*/

	// RVA: 0x41B3E30 Offset: 0x41AFE30 VA: 0x41B3E30
	public void RegisterState(State state) { }

	// RVA: 0x41B3EB0 Offset: 0x41AFEB0 VA: 0x41B3EB0
	public void UnRegisterState(State state) { }

	// RVA: 0x41B3F2C Offset: 0x41AFF2C VA: 0x41B3F2C
	public void UnRegisterStateByName(int stateName) { }

	// RVA: 0x41B3F84 Offset: 0x41AFF84 VA: 0x41B3F84
	public void UnRegisterAllState(int[] ignoreIDs) { }

	// RVA: 0x41B4268 Offset: 0x41B0268 VA: 0x41B4268
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41B4280 Offset: 0x41B0280 VA: 0x41B4280
	public void OnLateUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41B4298 Offset: 0x41B0298 VA: 0x41B4298
	public void OnShutDown() { }

	// RVA: 0x41B42B0 Offset: 0x41B02B0 VA: 0x41B42B0
	public void OnAppFocus(bool hasFocus) { }

	// RVA: 0x41B42CC Offset: 0x41B02CC VA: 0x41B42CC
	public void OnAppPause(bool pauseStatus) { }

	// RVA: 0x41B42E8 Offset: 0x41B02E8 VA: 0x41B42E8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct SoundManager.<PlayBackground>d__22 : IAsyncStateMachine // TypeDefIndex: 21189
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string path; // 0x28
	public SoundManager <>4__this; // 0x30
	public float volume; // 0x38
	private TaskAwaiter<AssetData> <>u__1; // 0x40

	// Methods

	// RVA: 0x41B5B1C Offset: 0x41B1B1C VA: 0x41B5B1C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B5FC4 Offset: 0x41B1FC4 VA: 0x41B5FC4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SoundManager.<PlayLoopSound>d__32 : IAsyncStateMachine // TypeDefIndex: 21190
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string path; // 0x28
	public AudioSource audioSource; // 0x30
	public SoundManager <>4__this; // 0x38
	public float volume; // 0x40
	private TaskAwaiter<AssetData> <>u__1; // 0x48

	// Methods

	// RVA: 0x41B5FD0 Offset: 0x41B1FD0 VA: 0x41B5FD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B63FC Offset: 0x41B23FC VA: 0x41B63FC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SoundManager.<PlaySoundEffect>d__29 : IAsyncStateMachine // TypeDefIndex: 21191
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SoundManager <>4__this; // 0x28
	public string path; // 0x30
	public bool check; // 0x38
	public float volume; // 0x3C
	private AudioSource <audioSource>5__2; // 0x40
	private int <id>5__3; // 0x48
	private TaskAwaiter<AssetData> <>u__1; // 0x50
	private TaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x41B6408 Offset: 0x41B2408 VA: 0x41B6408 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B6B44 Offset: 0x41B2B44 VA: 0x41B6B44 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.SoundModule
public class SoundManager : MonoBehaviour // TypeDefIndex: 21192
{
	// Fields
	[Header("AudioMixer")]
	public AudioMixer m_audioMixer; // 0x20
	[Header("Background")]
	public AudioSource m_backgroundAudioSource; // 0x28
	public AudioMixerGroup m_backgroundMixerGroup; // 0x30
	public string m_backgroundVolumeName; // 0x38
	[Header("SoundEffect")]
	public GameObject m_soundNodePrefab; // 0x40
	public AudioMixerGroup m_soundEffectMixerGroup; // 0x48
	public string m_soundEffectVolumeName; // 0x50
	[Space(10)]
	public int m_soundEffectPoolCount; // 0x58
	[Label]
	[SerializeField]
	private int m_soundEffectCurrentFrame; // 0x5C
	private Dictionary<int, AudioSource> m_audioSources; // 0x60
	private List<int> m_inIDs; // 0x68
	private List<int> m_outIDs; // 0x70
	private Dictionary<string, float> m_playTimeRecord; // 0x78
	private List<string> _tmp; // 0x80
	private const float PlayTimeMin = 0.1;
	private int _lastFrameCounter; // 0x88
	private bool m_isSoundEffectOpen; // 0x8C
	private Dictionary<int, AssetData> m_assetDatas; // 0x90

	// Methods

	// RVA: 0x41B4370 Offset: 0x41B0370 VA: 0x41B4370
	public void OnInit() { }

	// RVA: 0x41B44A8 Offset: 0x41B04A8 VA: 0x41B44A8
	public void OnDeInit() { }

	// RVA: 0x41B492C Offset: 0x41B092C VA: 0x41B492C
	public void SetMasterVolume(float volume) { }

	// RVA: 0x41B49DC Offset: 0x41B09DC VA: 0x41B49DC
	public AudioMixerGroup GetAudioMixerGroup(SoundName souncname) { }

	[AsyncStateMachine(typeof(SoundManager.<PlayBackground>d__22))]
	// RVA: 0x41B4A04 Offset: 0x41B0A04 VA: 0x41B4A04
	public void PlayBackground(string path, float volume = 1) { }

	// RVA: 0x41B475C Offset: 0x41B075C VA: 0x41B475C
	public void StopBackground() { }

	// RVA: 0x41B4AE8 Offset: 0x41B0AE8 VA: 0x41B4AE8
	public void PauseBackground() { }

	// RVA: 0x41B4B6C Offset: 0x41B0B6C VA: 0x41B4B6C
	public void UnPauseBackground() { }

	// RVA: 0x41B4BF0 Offset: 0x41B0BF0 VA: 0x41B4BF0
	public void SetBackgroundVolume(float volume) { }

	// RVA: 0x41B4CB4 Offset: 0x41B0CB4 VA: 0x41B4CB4
	public void SetSoundEffectOpen(bool open) { }

	// RVA: 0x41B4CC0 Offset: 0x41B0CC0 VA: 0x41B4CC0
	public bool IsSoundEffectOpen() { }

	[AsyncStateMachine(typeof(SoundManager.<PlaySoundEffect>d__29))]
	// RVA: 0x41B4CC8 Offset: 0x41B0CC8 VA: 0x41B4CC8
	public void PlaySoundEffect(string path, float volume = 1, bool check = True) { }

	// RVA: 0x41B4DB8 Offset: 0x41B0DB8 VA: 0x41B4DB8
	private bool CheckSoundPlay(string path) { }

	// RVA: 0x41B517C Offset: 0x41B117C VA: 0x41B517C
	public void PlayLoopSound(string path, out int audioId, float volume = 1) { }

	[AsyncStateMachine(typeof(SoundManager.<PlayLoopSound>d__32))]
	// RVA: 0x41B5410 Offset: 0x41B1410 VA: 0x41B5410
	private void PlayLoopSound(AudioSource audioSource, string path, float volume = 1) { }

	// RVA: 0x41B5508 Offset: 0x41B1508 VA: 0x41B5508
	public void StopLoopSound(int id) { }

	// RVA: 0x41B484C Offset: 0x41B084C VA: 0x41B484C
	public void Release(AudioClip clip) { }

	// RVA: 0x41B5768 Offset: 0x41B1768 VA: 0x41B5768
	public void SetSoundEffectVolume(float volume) { }

	// RVA: 0x41B5278 Offset: 0x41B1278 VA: 0x41B5278
	private AudioSource Out(out int id) { }

	// RVA: 0x41B5654 Offset: 0x41B1654 VA: 0x41B5654
	private void Put(AudioSource audioSource, int id) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x41B582C Offset: 0x41B182C VA: 0x41B582C
	private static void Test(string path) { }

	// RVA: 0x41B58D4 Offset: 0x41B18D4 VA: 0x41B58D4
	public void .ctor() { }
}

// Namespace: Framework.SocketNet
public interface ISocketNet // TypeDefIndex: 21193
{
	// Properties
	public abstract ISocketGameProxyBase GameProxy { get; }
	public abstract bool Connected { get; }
	public abstract bool LoginSuccess { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Init();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DeInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ISocketGameProxyBase get_GameProxy();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_Connected();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void CheckReconnect(string whyneed);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_LoginSuccess();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetSocketGroup(int kind, string groupName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetSocketGameHandler(ISocketGameProxyBase proxy);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetTokenAfterLogin(long userid, string token, string imToken);
}

// Namespace: Framework.SocketNet
public interface ISocketGameProxyBase // TypeDefIndex: 21194
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnUnInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetSocketGroup(int kind, string groupName);
}

// Namespace: Framework.SocketNet
public interface ISocketNetGame : ISocketNet // TypeDefIndex: 21195
{
	// Properties
	public abstract DateTime LastRecvHeartTime { get; set; }
	public abstract string UserToken { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddMessageHandler(int msgid, Action<IMessage> handler);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RemoveMessageHandler(int msgid, Action<IMessage> handler);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetSocketMessageHandler(ISocketMessageHandler handler);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetMessageToQueue(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnSetLoginSuccess();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnLoginRepeat();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnLoginReconnect();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DateTime get_LastRecvHeartTime();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_LastRecvHeartTime(DateTime value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_UserToken();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Send(IMessage msg);
}

// Namespace: 
private class SocketNet.RecvMsgHandler // TypeDefIndex: 21196
{
	// Fields
	private List<Action<IMessage>> mActions; // 0x10
	private List<Action<IMessage>> mCallList; // 0x18

	// Methods

	// RVA: 0x41B8544 Offset: 0x41B4544 VA: 0x41B8544
	public void Add(Action<IMessage> handler) { }

	// RVA: 0x41B8718 Offset: 0x41B4718 VA: 0x41B8718
	public void Remove(Action<IMessage> handler) { }

	// RVA: 0x41B7EBC Offset: 0x41B3EBC VA: 0x41B7EBC
	public void Invoke(IMessage msg) { }

	// RVA: 0x41B8498 Offset: 0x41B4498 VA: 0x41B8498
	public void .ctor() { }
}

// Namespace: 
private class SocketNet.NetRecvBuffer // TypeDefIndex: 21197
{
	// Fields
	public byte[] Bytes; // 0x10
	public int DataLength; // 0x18
	public DateTime LastRecvData; // 0x20

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x41B9268 Offset: 0x41B5268 VA: 0x41B9268
	public void .ctor(int size) { }

	// RVA: 0x41B90BC Offset: 0x41B50BC VA: 0x41B90BC
	public int get_Length() { }

	// RVA: 0x41B90D8 Offset: 0x41B50D8 VA: 0x41B90D8
	public void CheckSize(int size) { }

	// RVA: 0x41B8B08 Offset: 0x41B4B08 VA: 0x41B8B08
	public void Clear() { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<InternalCheckReconnect>d__74 : IAsyncStateMachine // TypeDefIndex: 21198
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x20
	public string whyneed; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41B92D8 Offset: 0x41B52D8 VA: 0x41B92D8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B95A8 Offset: 0x41B55A8 VA: 0x41B95A8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<InternalConnect>d__71 : IAsyncStateMachine // TypeDefIndex: 21199
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x20
	private long <taskversion>5__2; // 0x28
	private TaskAwaiter<IPHostEntry> <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x41B9610 Offset: 0x41B5610 VA: 0x41B9610 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41B9F80 Offset: 0x41B5F80 VA: 0x41B9F80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<InternalThreadStartConnect>d__70 : IAsyncStateMachine // TypeDefIndex: 21200
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41B9FE8 Offset: 0x41B5FE8 VA: 0x41B9FE8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BA250 Offset: 0x41B6250 VA: 0x41BA250 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<OnSendData>d__79 : IAsyncStateMachine // TypeDefIndex: 21201
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public byte[] data; // 0x28
	public uint startindex; // 0x30
	public int len; // 0x34
	public SocketNet <>4__this; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x41BA25C Offset: 0x41B625C VA: 0x41BA25C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BA550 Offset: 0x41B6550 VA: 0x41BA550 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<RecvDataAsync>d__77 : IAsyncStateMachine // TypeDefIndex: 21202
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x28
	private NetworkStream <netstream>5__2; // 0x30
	private long <taskversion>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40
	private TaskAwaiter<int> <>u__2; // 0x48

	// Methods

	// RVA: 0x41BA55C Offset: 0x41B655C VA: 0x41BA55C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BADB0 Offset: 0x41B6DB0 VA: 0x41BADB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<SendLogin>d__36 : IAsyncStateMachine // TypeDefIndex: 21203
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x41BADBC Offset: 0x41B6DBC VA: 0x41BADBC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BB010 Offset: 0x41B7010 VA: 0x41BB010 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<StartConnect>d__69 : IAsyncStateMachine // TypeDefIndex: 21204
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x20
	public int delaymilsec; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41BB078 Offset: 0x41B7078 VA: 0x41BB078 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BB3CC Offset: 0x41B73CC VA: 0x41BB3CC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SocketNet.<WaitConnect>d__76 : IAsyncStateMachine // TypeDefIndex: 21205
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SocketNet <>4__this; // 0x20
	private float <wait>5__2; // 0x28
	private long <taskversion>5__3; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x41BB434 Offset: 0x41B7434 VA: 0x41BB434 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41BB6CC Offset: 0x41B76CC VA: 0x41BB6CC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.SocketNet
public class SocketNet : ISocketNet, ISocketNetGame // TypeDefIndex: 21206
{
	// Fields
	public GameObject SocketObject; // 0x10
	public SocketNetMessageQueue MessageQueue; // 0x18
	public SocketNetConnectCtrl ConnectCtrl; // 0x20
	private SocketNetConfig mConfig; // 0x28
	private long mUserID; // 0x30
	private string mToken; // 0x38
	public bool IsSocketEnable; // 0x40
	private ISocketGameProxy mGameProxy; // 0x48
	[CompilerGenerated]
	private bool <LoginSuccess>k__BackingField; // 0x50
	private DateTime mLastSendHeartTime; // 0x58
	private DateTime mLastRecvHeartTime; // 0x60
	public float SendHeartInterval; // 0x68
	private ISocketMessageHandler mMessageHandler; // 0x70
	private Dictionary<int, SocketNet.RecvMsgHandler> mRecvMsgHandlerDic; // 0x78
	private ConcurrentQueue<IMessage> mRecvMessageQueue; // 0x80
	private TcpClient mCurrentClient; // 0x88
	private long mRecvTaskVersion; // 0x90
	private SocketNet.NetRecvBuffer mRecvBuf; // 0x98
	private int mConnectThreadID; // 0xA0
	private int mRecvThreadID; // 0xA4

	// Properties
	public string UserToken { get; }
	public ISocketGameProxyBase GameProxy { get; }
	public bool LoginSuccess { get; set; }
	public DateTime LastSendHeartTime { get; }
	public DateTime LastRecvHeartTime { get; set; }
	public bool Connected { get; }
	private bool mIsConnecting { get; }

	// Methods

	// RVA: 0x41B6B50 Offset: 0x41B2B50 VA: 0x41B6B50 Slot: 22
	public string get_UserToken() { }

	// RVA: 0x41B6B58 Offset: 0x41B2B58 VA: 0x41B6B58 Slot: 4
	public bool Init() { }

	// RVA: 0x41B70D0 Offset: 0x41B30D0 VA: 0x41B70D0 Slot: 5
	public void DeInit() { }

	// RVA: 0x41B7384 Offset: 0x41B3384 VA: 0x41B7384
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41B6EF0 Offset: 0x41B2EF0 VA: 0x41B6EF0
	public GameObject CreateSubGameObject(string name) { }

	// RVA: 0x41B7388 Offset: 0x41B3388 VA: 0x41B7388 Slot: 12
	public void SetTokenAfterLogin(long userid, string token, string imToken) { }

	// RVA: 0x41B767C Offset: 0x41B367C VA: 0x41B767C
	private void OnMainThreadUpdate() { }

	// RVA: 0x41B7044 Offset: 0x41B3044 VA: 0x41B7044
	private void Log(string message) { }

	// RVA: 0x41B7728 Offset: 0x41B3728 VA: 0x41B7728
	private void LogWarning(string message) { }

	// RVA: 0x41B6E64 Offset: 0x41B2E64 VA: 0x41B6E64
	private void LogError(string message) { }

	// RVA: 0x41B77B4 Offset: 0x41B37B4 VA: 0x41B77B4 Slot: 6
	public ISocketGameProxyBase get_GameProxy() { }

	[CompilerGenerated]
	// RVA: 0x41B77BC Offset: 0x41B37BC VA: 0x41B77BC Slot: 9
	public bool get_LoginSuccess() { }

	[CompilerGenerated]
	// RVA: 0x41B77C4 Offset: 0x41B37C4 VA: 0x41B77C4
	private void set_LoginSuccess(bool value) { }

	// RVA: 0x41B77D0 Offset: 0x41B37D0 VA: 0x41B77D0
	public DateTime get_LastSendHeartTime() { }

	// RVA: 0x41B77D8 Offset: 0x41B37D8 VA: 0x41B77D8 Slot: 20
	public DateTime get_LastRecvHeartTime() { }

	// RVA: 0x41B77E0 Offset: 0x41B37E0 VA: 0x41B77E0 Slot: 21
	public void set_LastRecvHeartTime(DateTime value) { }

	// RVA: 0x41B77E8 Offset: 0x41B37E8 VA: 0x41B77E8
	public void SetSocketMessageHandler(ISocketGameProxy proxy) { }

	// RVA: 0x41B78AC Offset: 0x41B38AC VA: 0x41B78AC Slot: 11
	public void SetSocketGameHandler(ISocketGameProxyBase proxy) { }

	// RVA: 0x41B72D0 Offset: 0x41B32D0 VA: 0x41B72D0
	private void DeleteGameProxy() { }

	[AsyncStateMachine(typeof(SocketNet.<SendLogin>d__36))]
	// RVA: 0x41B74A8 Offset: 0x41B34A8 VA: 0x41B74A8
	public Task SendLogin() { }

	// RVA: 0x41B7920 Offset: 0x41B3920 VA: 0x41B7920 Slot: 17
	public void OnSetLoginSuccess() { }

	// RVA: 0x41B792C Offset: 0x41B392C VA: 0x41B792C Slot: 18
	public void OnLoginRepeat() { }

	// RVA: 0x41B7980 Offset: 0x41B3980 VA: 0x41B7980 Slot: 19
	public void OnLoginReconnect() { }

	// RVA: 0x41B79D8 Offset: 0x41B39D8 VA: 0x41B79D8
	private void CheckSendHeart() { }

	// RVA: 0x41B7B3C Offset: 0x41B3B3C VA: 0x41B7B3C Slot: 10
	public void SetSocketGroup(int kind, string groupName) { }

	// RVA: 0x41B7C04 Offset: 0x41B3C04 VA: 0x41B7C04
	private void AddJoinGroupHandler(Action<int, string> handler) { }

	// RVA: 0x41B7C08 Offset: 0x41B3C08 VA: 0x41B7C08
	private void RemoveJoinGroupHandler(Action<int, string> handler) { }

	// RVA: 0x41B7C0C Offset: 0x41B3C0C VA: 0x41B7C0C
	private void AddQuitGroupHandler(Action<int, string> handler) { }

	// RVA: 0x41B7C10 Offset: 0x41B3C10 VA: 0x41B7C10
	private void RemoveQuitGroupHandler(Action<int, string> handler) { }

	// RVA: 0x41B7C14 Offset: 0x41B3C14 VA: 0x41B7C14 Slot: 15
	public void SetSocketMessageHandler(ISocketMessageHandler handler) { }

	// RVA: 0x41B7C1C Offset: 0x41B3C1C VA: 0x41B7C1C Slot: 16
	public void SetMessageToQueue(IMessage msg) { }

	// RVA: 0x41B7680 Offset: 0x41B3680 VA: 0x41B7680
	public void MainThreadHandleMessage() { }

	// RVA: 0x41B7E04 Offset: 0x41B3E04 VA: 0x41B7E04
	private int TryGetMsgID(IMessage msg) { }

	// RVA: 0x41B7C74 Offset: 0x41B3C74 VA: 0x41B7C74
	private void HandleMessage(IMessage msg) { }

	// RVA: 0x41B80B4 Offset: 0x41B40B4 VA: 0x41B80B4 Slot: 23
	public void Send(IMessage msg) { }

	// RVA: 0x41B83B0 Offset: 0x41B43B0 VA: 0x41B83B0 Slot: 13
	public void AddMessageHandler(int msgid, Action<IMessage> handler) { }

	// RVA: 0x41B8694 Offset: 0x41B4694 VA: 0x41B8694 Slot: 14
	public void RemoveMessageHandler(int msgid, Action<IMessage> handler) { }

	// RVA: 0x41B8894 Offset: 0x41B4894 VA: 0x41B8894
	public void ClearMessageHandler() { }

	// RVA: 0x41B7494 Offset: 0x41B3494 VA: 0x41B7494 Slot: 7
	public bool get_Connected() { }

	// RVA: 0x41B88E4 Offset: 0x41B48E4 VA: 0x41B88E4
	private bool get_mIsConnecting() { }

	[AsyncStateMachine(typeof(SocketNet.<StartConnect>d__69))]
	// RVA: 0x41B758C Offset: 0x41B358C VA: 0x41B758C
	public Task StartConnect(int delaymilsec) { }

	[AsyncStateMachine(typeof(SocketNet.<InternalThreadStartConnect>d__70))]
	// RVA: 0x41B88F4 Offset: 0x41B48F4 VA: 0x41B88F4
	private void InternalThreadStartConnect(object obj) { }

	[AsyncStateMachine(typeof(SocketNet.<InternalConnect>d__71))]
	// RVA: 0x41B89A8 Offset: 0x41B49A8 VA: 0x41B89A8
	private Task InternalConnect() { }

	// RVA: 0x41B7180 Offset: 0x41B3180 VA: 0x41B7180
	public void StopSocket() { }

	// RVA: 0x41B8A8C Offset: 0x41B4A8C VA: 0x41B8A8C
	public void PrepareReConnect() { }

	[AsyncStateMachine(typeof(SocketNet.<InternalCheckReconnect>d__74))]
	// RVA: 0x41B8B68 Offset: 0x41B4B68 VA: 0x41B8B68
	private Task InternalCheckReconnect(string whyneed) { }

	// RVA: 0x41B79D4 Offset: 0x41B39D4 VA: 0x41B79D4 Slot: 8
	public void CheckReconnect(string whyneed) { }

	[AsyncStateMachine(typeof(SocketNet.<WaitConnect>d__76))]
	// RVA: 0x41B8C64 Offset: 0x41B4C64 VA: 0x41B8C64
	private Task WaitConnect() { }

	[AsyncStateMachine(typeof(SocketNet.<RecvDataAsync>d__77))]
	// RVA: 0x41B8D48 Offset: 0x41B4D48 VA: 0x41B8D48
	private void RecvDataAsync(object obj) { }

	// RVA: 0x41B8DFC Offset: 0x41B4DFC VA: 0x41B8DFC
	private void OnRecvData(SocketNet.NetRecvBuffer buffer, int readlength) { }

	[AsyncStateMachine(typeof(SocketNet.<OnSendData>d__79))]
	// RVA: 0x41B82D4 Offset: 0x41B42D4 VA: 0x41B82D4
	private void OnSendData(byte[] data, uint startindex, int len) { }

	// RVA: 0x41B914C Offset: 0x41B514C VA: 0x41B914C
	public void .ctor() { }
}

// Namespace: Framework.SocketNet
public interface ISocketGameProxy : ISocketGameProxyBase // TypeDefIndex: 21207
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnUnInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task SendLogin();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetSocketGroup(int kind, string groupName);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SendHeart();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetSocketMsgID(IMessage msg);
}

// Namespace: Framework.SocketNet
public interface ISocketMessageHandler // TypeDefIndex: 21208
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HandleByteMessage(byte[] bytes, int startindex);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] ConvertMessageToByteArray(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetMsgID(IMessage msg);
}

// Namespace: Framework.SocketNet
public class SocketNetConfig : ScriptableObject // TypeDefIndex: 21209
{
	// Fields
	public const string Config_Resources_PATH = "socket_config";
	public const string Config_PATH = "Assets/Resources/socket_config.asset";
	public string Host; // 0x18
	public uint Port; // 0x20
	public string DebugHost; // 0x28
	public uint DebugPort; // 0x30

	// Methods

	// RVA: 0x41BB734 Offset: 0x41B7734 VA: 0x41BB734
	public string GetHost() { }

	// RVA: 0x41BB73C Offset: 0x41B773C VA: 0x41BB73C
	public uint GetPort() { }

	// RVA: 0x41B6D9C Offset: 0x41B2D9C VA: 0x41B6D9C
	public static SocketNetConfig GetConfig() { }

	// RVA: 0x41BB804 Offset: 0x41B7804 VA: 0x41BB804
	private static void Log(string message) { }

	// RVA: 0x41BB808 Offset: 0x41B7808 VA: 0x41BB808
	private static void LogWarning(string message) { }

	// RVA: 0x41BB744 Offset: 0x41B7744 VA: 0x41BB744
	private static void LogError(string message) { }

	// RVA: 0x41BB80C Offset: 0x41B780C VA: 0x41BB80C
	public void .ctor() { }
}

// Namespace: Framework.SocketNet
public class SocketNetConnectCtrl : MonoBehaviour // TypeDefIndex: 21210
{
	// Fields
	public SocketNet BindSocketNet; // 0x20

	// Methods

	// RVA: 0x41BB880 Offset: 0x41B7880 VA: 0x41BB880
	private void OnApplicationPause(bool pause) { }

	// RVA: 0x41BB884 Offset: 0x41B7884 VA: 0x41BB884
	private void OnApplicationFocus(bool focus) { }

	// RVA: 0x41BB8E4 Offset: 0x41B78E4 VA: 0x41BB8E4
	private void OnApplicationQuit() { }

	// RVA: 0x41BB8E8 Offset: 0x41B78E8 VA: 0x41BB8E8
	public void .ctor() { }
}

// Namespace: Framework.SocketNet
public class SocketNetMessageQueue : MonoBehaviour // TypeDefIndex: 21211
{
	// Fields
	public Action OnUpdate; // 0x20

	// Methods

	// RVA: 0x41BB8F0 Offset: 0x41B78F0 VA: 0x41BB8F0
	private void Update() { }

	// RVA: 0x41BB90C Offset: 0x41B790C VA: 0x41BB90C
	public void .ctor() { }
}

// Namespace: Framework.SocketNet
public class SocketNet_GorillaImAdapter : ISocketNet // TypeDefIndex: 21212
{
	// Fields
	private ISocketGameProxyBase mGameProxy; // 0x10
	private ulong mUserID; // 0x18
	private string mToken; // 0x20
	private string mImToken; // 0x28
	private string mClientVersion; // 0x30
	private string mSocketUrl; // 0x38

	// Properties
	public bool Connected { get; }
	public bool LoginSuccess { get; }
	public ISocketGameProxyBase GameProxy { get; }

	// Methods

	// RVA: 0x41BB914 Offset: 0x41B7914 VA: 0x41BB914 Slot: 4
	public bool Init() { }

	// RVA: 0x41BBA3C Offset: 0x41B7A3C VA: 0x41BBA3C Slot: 5
	public void DeInit() { }

	// RVA: 0x41BBA70 Offset: 0x41B7A70 VA: 0x41BBA70 Slot: 7
	public bool get_Connected() { }

	// RVA: 0x41BBA9C Offset: 0x41B7A9C VA: 0x41BBA9C Slot: 8
	public void CheckReconnect(string whyneed) { }

	// RVA: 0x41BBB8C Offset: 0x41B7B8C VA: 0x41BBB8C Slot: 9
	public bool get_LoginSuccess() { }

	// RVA: 0x41BBBB8 Offset: 0x41B7BB8 VA: 0x41BBBB8 Slot: 10
	public void SetSocketGroup(int kind, string groupName) { }

	// RVA: 0x41BBC80 Offset: 0x41B7C80 VA: 0x41BBC80 Slot: 11
	public void SetSocketGameHandler(ISocketGameProxyBase proxy) { }

	// RVA: 0x41BBD48 Offset: 0x41B7D48 VA: 0x41BBD48 Slot: 12
	public void SetTokenAfterLogin(long userid, string token, string imToken) { }

	// RVA: 0x41BBF18 Offset: 0x41B7F18 VA: 0x41BBF18
	public void SetClientInfo(string clientVersion) { }

	// RVA: 0x41BBF60 Offset: 0x41B7F60 VA: 0x41BBF60 Slot: 6
	public ISocketGameProxyBase get_GameProxy() { }

	// RVA: 0x41BBC84 Offset: 0x41B7C84 VA: 0x41BBC84
	public void SetSocketMessageHandler(ISocketGameProxyBase proxy) { }

	// RVA: 0x41BBF68 Offset: 0x41B7F68 VA: 0x41BBF68
	private void DeleteGameProxy() { }

	// RVA: 0x41BC018 Offset: 0x41B8018 VA: 0x41BC018
	public void .ctor() { }
}

// Namespace: Framework.SDKManager
public class DataBlackBoard // TypeDefIndex: 21213
{
	// Fields
	[JsonIgnore]
	private Dictionary<string, object> mBlackBoard; // 0x10

	// Methods

	// RVA: 0x41BC020 Offset: 0x41B8020 VA: 0x41BC020
	public void SetupBlackBoard(Dictionary<string, object> data) { }

	// RVA: 0x41BC044 Offset: 0x41B8044 VA: 0x41BC044 Slot: 4
	protected virtual void OnDataRefresh() { }

	// RVA: -1 Offset: -1
	public T Get<T>(string key, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45661F4 Offset: 0x45621F4 VA: 0x45661F4
	|-DataBlackBoard.Get<bool>
	|
	|-RVA: 0x4566794 Offset: 0x4562794 VA: 0x4566794
	|-DataBlackBoard.Get<int>
	|
	|-RVA: 0x4566D2C Offset: 0x4562D2C VA: 0x4566D2C
	|-DataBlackBoard.Get<long>
	|
	|-RVA: 0x45672C4 Offset: 0x45632C4 VA: 0x45672C4
	|-DataBlackBoard.Get<object>
	|
	|-RVA: 0x4567840 Offset: 0x4563840 VA: 0x4567840
	|-DataBlackBoard.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41BC048 Offset: 0x41B8048 VA: 0x41BC048
	public void FromJson(string jsonStr) { }

	// RVA: 0x41BC1C4 Offset: 0x41B81C4 VA: 0x41BC1C4
	public void .ctor() { }
}

// Namespace: Framework.SDKManager
public class SDKCloudConfigData : DataBlackBoard // TypeDefIndex: 21214
{
	// Properties
	public bool IfEnableDeleteAccount { get; }
	public bool IfEnableLogOut { get; }
	public string PreReleaseVersion { get; }
	public string ServerMaintainTime { get; }
	public bool IsEnabledReview { get; }
	public bool IsEnabledAnnouncement { get; }
	public bool IsEnabledShare { get; }
	public bool IsEnabledRedeemCode { get; }
	public bool IsEnabledVideoReward { get; }
	public bool IfEnableGiftCode { get; }
	public string LoginTip { get; }
	public bool IfBlockLogin { get; }
	public bool IfEnableAd { get; }
	public long ServerTime { get; }
	public bool IfEnablePhoneUnBind { get; }
	public bool IsWeixinLoginEnable { get; }
	public bool IsQQLoginEnable { get; }
	public string upgradeURI { get; }
	public string upgradeTip { get; }
	public int upgradeType { get; }
	public bool IfWeChetAppleReviewMode { get; }
	public bool IfShowWechatFriends { get; }
	public bool IfLockPay { get; }
	public bool PreReleaseServerEnable { get; }
	public bool IsShowPrivacyAgreement { get; }
	public string UserPolicyUrl { get; }
	public string PrivacyPolicyUrl { get; }
	public int AdSDKDelaySeconds { get; }
	public bool ShowEditNameBtn { get; }
	public bool NeedJumpAd { get; }
	public bool IsShowFallbackRewardedVideo { get; }
	public bool IfEnableRateApp { get; }
	public int RateAppTriggerChapter { get; }
	public bool IfEnableMobileNotification { get; }
	public bool EnableDownloadApk { get; }
	public bool GorillaOpenDebugger { get; }

	// Methods

	// RVA: 0x41BC24C Offset: 0x41B824C VA: 0x41BC24C
	public bool get_IfEnableDeleteAccount() { }

	// RVA: 0x41BC2B8 Offset: 0x41B82B8 VA: 0x41BC2B8
	public bool get_IfEnableLogOut() { }

	// RVA: 0x41BC324 Offset: 0x41B8324 VA: 0x41BC324
	public string get_PreReleaseVersion() { }

	// RVA: 0x41BC3A4 Offset: 0x41B83A4 VA: 0x41BC3A4
	public string get_ServerMaintainTime() { }

	// RVA: 0x41BC424 Offset: 0x41B8424 VA: 0x41BC424
	public bool get_IsEnabledReview() { }

	// RVA: 0x41BC490 Offset: 0x41B8490 VA: 0x41BC490
	public bool get_IsEnabledAnnouncement() { }

	// RVA: 0x41BC4FC Offset: 0x41B84FC VA: 0x41BC4FC
	public bool get_IsEnabledShare() { }

	// RVA: 0x41BC568 Offset: 0x41B8568 VA: 0x41BC568
	public bool get_IsEnabledRedeemCode() { }

	// RVA: 0x41BC5D4 Offset: 0x41B85D4 VA: 0x41BC5D4
	public bool get_IsEnabledVideoReward() { }

	// RVA: 0x41BC640 Offset: 0x41B8640 VA: 0x41BC640
	public bool get_IfEnableGiftCode() { }

	// RVA: 0x41BC6AC Offset: 0x41B86AC VA: 0x41BC6AC
	public string get_LoginTip() { }

	// RVA: 0x41BC72C Offset: 0x41B872C VA: 0x41BC72C
	public bool get_IfBlockLogin() { }

	// RVA: 0x41BC798 Offset: 0x41B8798 VA: 0x41BC798
	public bool get_IfEnableAd() { }

	// RVA: 0x41BC804 Offset: 0x41B8804 VA: 0x41BC804
	public long get_ServerTime() { }

	// RVA: 0x41BC870 Offset: 0x41B8870 VA: 0x41BC870
	public bool get_IfEnablePhoneUnBind() { }

	// RVA: 0x41BC8DC Offset: 0x41B88DC VA: 0x41BC8DC
	public bool get_IsWeixinLoginEnable() { }

	// RVA: 0x41BC948 Offset: 0x41B8948 VA: 0x41BC948
	public bool get_IsQQLoginEnable() { }

	// RVA: 0x41BC9B4 Offset: 0x41B89B4 VA: 0x41BC9B4
	public string get_upgradeURI() { }

	// RVA: 0x41BCA34 Offset: 0x41B8A34 VA: 0x41BCA34
	public string get_upgradeTip() { }

	// RVA: 0x41BCAB4 Offset: 0x41B8AB4 VA: 0x41BCAB4
	public int get_upgradeType() { }

	// RVA: 0x41BCB20 Offset: 0x41B8B20 VA: 0x41BCB20
	public bool get_IfWeChetAppleReviewMode() { }

	// RVA: 0x41BCB8C Offset: 0x41B8B8C VA: 0x41BCB8C
	public bool get_IfShowWechatFriends() { }

	// RVA: 0x41BCBF8 Offset: 0x41B8BF8 VA: 0x41BCBF8
	public bool get_IfLockPay() { }

	// RVA: 0x41BCC64 Offset: 0x41B8C64 VA: 0x41BCC64
	public bool get_PreReleaseServerEnable() { }

	// RVA: 0x41BCCD0 Offset: 0x41B8CD0 VA: 0x41BCCD0
	public bool get_IsShowPrivacyAgreement() { }

	// RVA: 0x41BCD3C Offset: 0x41B8D3C VA: 0x41BCD3C
	public string get_UserPolicyUrl() { }

	// RVA: 0x41BCDBC Offset: 0x41B8DBC VA: 0x41BCDBC
	public string get_PrivacyPolicyUrl() { }

	// RVA: 0x41BCE3C Offset: 0x41B8E3C VA: 0x41BCE3C
	public int get_AdSDKDelaySeconds() { }

	// RVA: 0x41BCEA8 Offset: 0x41B8EA8 VA: 0x41BCEA8
	public bool get_ShowEditNameBtn() { }

	// RVA: 0x41BCF14 Offset: 0x41B8F14 VA: 0x41BCF14
	public bool get_NeedJumpAd() { }

	// RVA: 0x41BCF80 Offset: 0x41B8F80 VA: 0x41BCF80
	public bool get_IsShowFallbackRewardedVideo() { }

	// RVA: 0x41BCFEC Offset: 0x41B8FEC VA: 0x41BCFEC
	public bool get_IfEnableRateApp() { }

	// RVA: 0x41BD058 Offset: 0x41B9058 VA: 0x41BD058
	public int get_RateAppTriggerChapter() { }

	// RVA: 0x41BD0C4 Offset: 0x41B90C4 VA: 0x41BD0C4
	public bool get_IfEnableMobileNotification() { }

	// RVA: 0x41BD130 Offset: 0x41B9130 VA: 0x41BD130
	public bool get_EnableDownloadApk() { }

	// RVA: 0x41BD19C Offset: 0x41B919C VA: 0x41BD19C
	public bool get_GorillaOpenDebugger() { }

	// RVA: 0x41BD208 Offset: 0x41B9208 VA: 0x41BD208
	public void .ctor() { }
}

// Namespace: Framework.SDKManager
public class DynamicSuperPropertiesGetter : TDDynamicSuperPropertiesHandler // TypeDefIndex: 21215
{
	// Fields
	public APropertiesGetter Getter; // 0x10
	private Dictionary<string, object> _empty; // 0x18

	// Methods

	// RVA: 0x41BD20C Offset: 0x41B920C VA: 0x41BD20C Slot: 4
	public Dictionary<string, object> GetDynamicSuperProperties() { }

	// RVA: 0x41BD22C Offset: 0x41B922C VA: 0x41BD22C
	public void .ctor() { }
}

// Namespace: Framework.SDKManager
public abstract class APropertiesGetter // TypeDefIndex: 21216
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Dictionary<string, object> GetDynamicSuperProperties();

	// RVA: 0x41BD2B4 Offset: 0x41B92B4 VA: 0x41BD2B4
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SDKManager.SDKAdjust.<>c__DisplayClass5_0 // TypeDefIndex: 21217
{
	// Fields
	public Action<string> callback; // 0x10

	// Methods

	// RVA: 0x41BF87C Offset: 0x41BB87C VA: 0x41BF87C
	public void .ctor() { }

	// RVA: 0x41BF884 Offset: 0x41BB884 VA: 0x41BF884
	internal void <GetDeepLink>b__0(string url) { }
}

// Namespace: 
public class SDKManager.SDKAdjust // TypeDefIndex: 21218
{
	// Fields
	private SDKManager _mgr; // 0x10

	// Methods

	// RVA: 0x41BD9F8 Offset: 0x41B99F8 VA: 0x41BD9F8
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41BDC4C Offset: 0x41B9C4C VA: 0x41BDC4C
	public void TrackEvent(string eventToken, string currency = "", double amount = 0) { }

	// RVA: 0x41BF504 Offset: 0x41BB504 VA: 0x41BF504
	public void SetTGAAccountId(string accountId) { }

	// RVA: 0x41BF60C Offset: 0x41BB60C VA: 0x41BF60C
	public string GetAdjustId() { }

	// RVA: 0x41BF6FC Offset: 0x41BB6FC VA: 0x41BF6FC
	public void GetDeepLink(Action<string> callback) { }
}

// Namespace: 
public class SDKManager.AdjustEventToken // TypeDefIndex: 21219
{
	// Fields
	public const string CreateRole = "tqw10t";
	public const string Guidance = "dmt8ls";
	public const string MainChapterStart = "tso9po";
	public const string MainChapterFinish = "mcl2x8";
	public const string AdButtonClick = "2d8u4x";
	public const string AdShowFinish = "hl25c5";
	public const string GameLogin = "899jks";
	public const string FirstLaunch = "wvunm2";
	public const string FirstRegister = "ah27n7";
	public const string AdRevenue = "hu5bix";
	public const string PaySuccess = "222vap";

	// Methods

	// RVA: 0x41BF8A0 Offset: 0x41BB8A0 VA: 0x41BF8A0
	public void .ctor() { }
}

// Namespace: 
public class SDKManager.SDKAppsFlyer // TypeDefIndex: 21220
{
	// Fields
	private SDKManager mMgr; // 0x10

	// Methods

	// RVA: 0x41BD9C0 Offset: 0x41B99C0 VA: 0x41BD9C0
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41BF8A8 Offset: 0x41BB8A8 VA: 0x41BF8A8
	public string GetAppsFlyerId() { }

	// RVA: 0x41BF994 Offset: 0x41BB994 VA: 0x41BF994
	public void SetCustomerUserId(string id) { }

	// RVA: 0x41BFA70 Offset: 0x41BBA70 VA: 0x41BFA70
	public void setConsentData() { }

	// RVA: 0x41BFB48 Offset: 0x41BBB48 VA: 0x41BFB48
	public void sendEvent(string eventName, Dictionary<string, string> properties) { }

	// RVA: 0x41BFC38 Offset: 0x41BBC38 VA: 0x41BFC38
	public void Track_Purchase(string currency, Decimal revenue, string contentId) { }
}

// Namespace: 
public static class SDKManager.FB // TypeDefIndex: 21221
{
	// Methods

	// RVA: 0x41BFD60 Offset: 0x41BBD60 VA: 0x41BFD60
	public static void LogPurchase(Decimal amount, string currencyCode) { }
}

// Namespace: 
public class SDKManager.SDKFirebase // TypeDefIndex: 21222
{
	// Methods

	// RVA: 0x41BD9F0 Offset: 0x41B99F0 VA: 0x41BD9F0
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41BFD64 Offset: 0x41BBD64 VA: 0x41BFD64
	public void SetCustomKey(string key, string value) { }

	// RVA: 0x41BFE54 Offset: 0x41BBE54 VA: 0x41BFE54
	public void ReportException(Exception e) { }

	// RVA: 0x41BFF30 Offset: 0x41BBF30 VA: 0x41BFF30
	public void ReportLog(string log) { }

	// RVA: 0x41BDD50 Offset: 0x41B9D50 VA: 0x41BDD50
	public void TrackEvent(string eventName, Dictionary<string, string> properties) { }

	// RVA: 0x41C000C Offset: 0x41BC00C VA: 0x41C000C
	public void SetUserId(string id) { }
}

// Namespace: 
public static class SDKManager.FirebaseEventName // TypeDefIndex: 21223
{
	// Fields
	public const string CreateRole = "Firebase_CreateProfile";
	public const string Guidance = "Firebase_Guild";
	public const string MainChapterStart = "Firebase_ChapterStart";
	public const string MainChapterFinish = "Firebase_ChapterlFinish";
	public const string AdButtonClick = "Firebase_ad_click";
	public const string AdShowFinish = "Firebase_ad_watch";
	public const string GameLogin = "Firebase_Login";
	public const string FirstLaunch = "Firebase_first_open";
	public const string FirstRegister = "Firebase_first_active";
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SDKManager.GorillaDebugOptions.<>c // TypeDefIndex: 21224
{
	// Fields
	public static readonly SDKManager.GorillaDebugOptions.<>c <>9; // 0x0
	public static Action<int, string> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x41C02D0 Offset: 0x41BC2D0 VA: 0x41C02D0
	private static void .cctor() { }

	// RVA: 0x41C0338 Offset: 0x41BC338 VA: 0x41C0338
	public void .ctor() { }

	// RVA: 0x41C0340 Offset: 0x41BC340 VA: 0x41C0340
	internal void <OpenDebugger>b__1_0(int code, string message) { }
}

// Namespace: 
private sealed class SDKManager.GorillaDebugOptions // TypeDefIndex: 21225
{
	// Methods

	[Category("Gorilla")]
	[DisplayName("删除SDK账号")]
	// RVA: 0x41C00E8 Offset: 0x41BC0E8 VA: 0x41C00E8
	public void DeleteAccount() { }

	[DisplayName("Ad Open Debug Tool")]
	[Category("Gorilla")]
	// RVA: 0x41C0180 Offset: 0x41BC180 VA: 0x41C0180
	public void OpenDebugger() { }

	// RVA: 0x41BEAD4 Offset: 0x41BAAD4 VA: 0x41BEAD4
	public void .ctor() { }
}

// Namespace: 
public class SDKManager.SDKLogin // TypeDefIndex: 21226
{
	// Fields
	public string m_account; // 0x10
	public string m_account2; // 0x18
	[CompilerGenerated]
	private string <Verification>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsInitOver>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsLoginSuccess>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsLoginStarted>k__BackingField; // 0x2A
	private bool _isLoginInProgress; // 0x2B
	private Action<string> mActionLogin; // 0x30
	private Action<int, string> m_onFailure; // 0x38
	private Action m_onCancel; // 0x40
	private SDKManager mMgr; // 0x48

	// Properties
	public string Verification { get; set; }
	public string m_deviceId { get; }
	public bool IsInitOver { get; set; }
	public bool IsLoginSuccess { get; set; }
	public bool IsLoginStarted { get; set; }
	public bool IsLoginViaSDK { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41C0408 Offset: 0x41BC408 VA: 0x41C0408
	public string get_Verification() { }

	[CompilerGenerated]
	// RVA: 0x41C0410 Offset: 0x41BC410 VA: 0x41C0410
	private void set_Verification(string value) { }

	// RVA: 0x41C0418 Offset: 0x41BC418 VA: 0x41C0418
	public string get_m_deviceId() { }

	[CompilerGenerated]
	// RVA: 0x41C04E0 Offset: 0x41BC4E0 VA: 0x41C04E0
	public bool get_IsInitOver() { }

	[CompilerGenerated]
	// RVA: 0x41C04E8 Offset: 0x41BC4E8 VA: 0x41C04E8
	private void set_IsInitOver(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41C04F4 Offset: 0x41BC4F4 VA: 0x41C04F4
	public bool get_IsLoginSuccess() { }

	[CompilerGenerated]
	// RVA: 0x41C04FC Offset: 0x41BC4FC VA: 0x41C04FC
	private void set_IsLoginSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41C0508 Offset: 0x41BC508 VA: 0x41C0508
	public bool get_IsLoginStarted() { }

	[CompilerGenerated]
	// RVA: 0x41C0510 Offset: 0x41BC510 VA: 0x41C0510
	private void set_IsLoginStarted(bool value) { }

	// RVA: 0x41C051C Offset: 0x41BC51C VA: 0x41C051C
	public bool get_IsLoginViaSDK() { }

	// RVA: 0x41BDA28 Offset: 0x41B9A28 VA: 0x41BDA28
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41C0524 Offset: 0x41BC524 VA: 0x41C0524
	public void OnSDKLogin(Action<string> onSuccess, Action<int, string> onFailure, Action onCancel) { }

	// RVA: 0x41C0698 Offset: 0x41BC698 VA: 0x41C0698
	private void LoginWithGorillaSDK() { }

	// RVA: 0x41C0660 Offset: 0x41BC660 VA: 0x41C0660
	private void ClearLoginCallbacks() { }

	// RVA: 0x41C0878 Offset: 0x41BC878 VA: 0x41C0878
	private void OpenDebuggerConsoleIfNeeded() { }

	[CompilerGenerated]
	// RVA: 0x41C0A40 Offset: 0x41BCA40 VA: 0x41C0A40
	private void <LoginWithGorillaSDK>b__29_0(LoginResult result) { }

	[CompilerGenerated]
	// RVA: 0x41C0BC0 Offset: 0x41BCBC0 VA: 0x41C0BC0
	private void <LoginWithGorillaSDK>b__29_1(int code, string message) { }

	[CompilerGenerated]
	// RVA: 0x41C0CC4 Offset: 0x41BCCC4 VA: 0x41C0CC4
	private void <LoginWithGorillaSDK>b__29_2() { }
}

// Namespace: 
public class SDKManager.SDKTGA // TypeDefIndex: 21227
{
	// Fields
	[CompilerGenerated]
	private bool <IsThinkingInitSuccess>k__BackingField; // 0x10
	public readonly DynamicSuperPropertiesGetter DynamicSuperPropertiesGetter; // 0x18
	private SDKManager mMgr; // 0x20
	private string mTGALoginID; // 0x28

	// Properties
	public bool IsThinkingInitSuccess { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41C0CFC Offset: 0x41BCCFC VA: 0x41C0CFC
	public bool get_IsThinkingInitSuccess() { }

	[CompilerGenerated]
	// RVA: 0x41C0D04 Offset: 0x41BCD04 VA: 0x41C0D04
	private void set_IsThinkingInitSuccess(bool value) { }

	// RVA: 0x41BD918 Offset: 0x41B9918 VA: 0x41BD918
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41BEF70 Offset: 0x41BAF70 VA: 0x41BEF70
	public void InitTGA() { }

	// RVA: 0x41C0D10 Offset: 0x41BCD10 VA: 0x41C0D10
	private void SetStaticSuperProperties() { }

	// RVA: 0x41C0EEC Offset: 0x41BCEEC VA: 0x41C0EEC
	public void TrackFirstActive(string accountKey, Dictionary<string, object> dic) { }

	// RVA: 0x41BEC18 Offset: 0x41BAC18 VA: 0x41BEC18
	public void Track(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x41C1160 Offset: 0x41BD160 VA: 0x41C1160
	private void ShowLoggerTrack(string eventName, Dictionary<string, object> properties) { }

	// RVA: 0x41C1348 Offset: 0x41BD348 VA: 0x41C1348
	private static void AppendValue(StringBuilder builder, object value) { }

	// RVA: 0x41C1C7C Offset: 0x41BDC7C VA: 0x41C1C7C
	public void Login(string id, string type = "sdk登录") { }

	// RVA: 0x41C1D30 Offset: 0x41BDD30 VA: 0x41C1D30
	public void Track_HabbyIDBind(string eventName, Dictionary<string, object> dic) { }

	// RVA: 0x41C1DD4 Offset: 0x41BDDD4 VA: 0x41C1DD4
	public void Track_HabbyIDShow() { }

	// RVA: 0x41C1F04 Offset: 0x41BDF04 VA: 0x41C1F04
	public void Logout() { }

	// RVA: 0x41C1FB8 Offset: 0x41BDFB8 VA: 0x41C1FB8
	public void ClearSuperProperties() { }

	// RVA: 0x41C0E64 Offset: 0x41BCE64 VA: 0x41C0E64
	public void SetSuperProperties(Dictionary<string, object> superProperties) { }

	// RVA: 0x41C2038 Offset: 0x41BE038 VA: 0x41C2038
	public void TimeEvent(string eventName) { }

	// RVA: 0x41C20C0 Offset: 0x41BE0C0 VA: 0x41C20C0
	public void UnsetSuperProperty(string superPropertyName) { }

	// RVA: 0x41C2148 Offset: 0x41BE148 VA: 0x41C2148
	public void UserAdd(Dictionary<string, object> properties) { }

	// RVA: 0x41C21D0 Offset: 0x41BE1D0 VA: 0x41C21D0
	public void UserDelete() { }

	// RVA: 0x41C2250 Offset: 0x41BE250 VA: 0x41C2250
	public void UserSet(Dictionary<string, object> properties) { }

	// RVA: 0x41C22DC Offset: 0x41BE2DC VA: 0x41C22DC
	public void UserSetOnce(Dictionary<string, object> properties) { }

	// RVA: 0x41C2368 Offset: 0x41BE368 VA: 0x41C2368
	public string GetDeviceID() { }

	// RVA: 0x41C23B8 Offset: 0x41BE3B8 VA: 0x41C23B8
	public string GetDistinctID() { }
}

// Namespace: 
public class SDKManager.SDKWebView // TypeDefIndex: 21228
{
	// Fields
	private SDKManager mMgr; // 0x10
	[CompilerGenerated]
	private long <ServerUserid>k__BackingField; // 0x18
	private GameFeedbackWebview _gameFeedbackWebview; // 0x20

	// Properties
	public long ServerUserid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41C2420 Offset: 0x41BE420 VA: 0x41C2420
	public long get_ServerUserid() { }

	[CompilerGenerated]
	// RVA: 0x41C2428 Offset: 0x41BE428 VA: 0x41C2428
	private void set_ServerUserid(long value) { }

	// RVA: 0x41BDC1C Offset: 0x41B9C1C VA: 0x41BDC1C
	public void .ctor(SDKManager mgr) { }

	// RVA: 0x41C2430 Offset: 0x41BE430 VA: 0x41C2430
	public void OpenFeedbackWebview(string url, Action<bool> onFinished) { }

	// RVA: 0x41C2600 Offset: 0x41BE600 VA: 0x41C2600
	public void SetServerUserid(long serverUserid) { }
}

// Namespace: 
[CompilerGenerated]
private struct SDKManager.<<InitGorillaCloudConfig>b__20_1>d : IAsyncStateMachine // TypeDefIndex: 21229
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SDKManager <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41C2608 Offset: 0x41BE608 VA: 0x41C2608 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C27D4 Offset: 0x41BE7D4 VA: 0x41C27D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SDKManager.<>c // TypeDefIndex: 21230
{
	// Fields
	public static readonly SDKManager.<>c <>9; // 0x0
	public static Action<JuLiangAttributionFailure> <>9__38_1; // 0x8

	// Methods

	// RVA: 0x41C27E0 Offset: 0x41BE7E0 VA: 0x41C27E0
	private static void .cctor() { }

	// RVA: 0x41C2848 Offset: 0x41BE848 VA: 0x41C2848
	public void .ctor() { }

	// RVA: 0x41C2850 Offset: 0x41BE850 VA: 0x41C2850
	internal void <BindGorillaCallbacks>b__38_1(JuLiangAttributionFailure error) { }
}

// Namespace: 
[CompilerGenerated]
private struct SDKManager.<InitAds>d__24 : IAsyncStateMachine // TypeDefIndex: 21231
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SDKManager <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41C28F0 Offset: 0x41BE8F0 VA: 0x41C28F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C2BEC Offset: 0x41BEBEC VA: 0x41C2BEC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.SDKManager
public class SDKManager : MonoBehaviour // TypeDefIndex: 21232
{
	// Fields
	public SDKManager.SDKAdjust AdjustSDK; // 0x20
	public SDKManager.SDKAppsFlyer AppsFlyerSDK; // 0x28
	public ATTManager AttManager; // 0x30
	[CompilerGenerated]
	private SDKCloudConfigData <CloudConfigData>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <CloudConfigRequestEnd>k__BackingField; // 0x40
	private Dictionary<string, bool> _tgaTrackedDic; // 0x48
	private int _cloudConfigRetryCount; // 0x50
	private const int CloudConfigMaxRetryCount = 3;
	public bool IsRelease; // 0x54
	public SDKManager.SDKFirebase FirebaseSDK; // 0x58
	private const float DuplicateOpenDeepLinkInterval = 2;
	private SDKConfig _gorillaConfig; // 0x60
	private string _lastReportedOpenDeepLinkUrl; // 0x68
	private float _lastReportedOpenDeepLinkTime; // 0x70
	private SDKManager.GorillaDebugOptions _gorillaDebugOptions; // 0x78
	public SDKManager.SDKLogin Login; // 0x80
	public SDKManager.SDKTGA TGA; // 0x88
	public SDKManager.SDKWebView WebView; // 0x90

	// Properties
	public SDKCloudConfigData CloudConfigData { get; set; }
	public bool CloudConfigRequestEnd { get; set; }

	// Methods

	// RVA: 0x41BD2BC Offset: 0x41B92BC VA: 0x41BD2BC
	public void InitATT(Action onFinished) { }

	[CompilerGenerated]
	// RVA: 0x41BD340 Offset: 0x41B9340 VA: 0x41BD340
	public SDKCloudConfigData get_CloudConfigData() { }

	[CompilerGenerated]
	// RVA: 0x41BD348 Offset: 0x41B9348 VA: 0x41BD348
	public void set_CloudConfigData(SDKCloudConfigData value) { }

	[CompilerGenerated]
	// RVA: 0x41BD350 Offset: 0x41B9350 VA: 0x41BD350
	public bool get_CloudConfigRequestEnd() { }

	[CompilerGenerated]
	// RVA: 0x41BD358 Offset: 0x41B9358 VA: 0x41BD358
	private void set_CloudConfigRequestEnd(bool value) { }

	// RVA: 0x41BD364 Offset: 0x41B9364 VA: 0x41BD364
	public void InitCloudConfig() { }

	// RVA: 0x41BD5BC Offset: 0x41B95BC VA: 0x41BD5BC
	public int GetChannelID() { }

	// RVA: 0x41BD36C Offset: 0x41B936C VA: 0x41BD36C
	private void InitGorillaCloudConfig() { }

	// RVA: 0x41BD6C4 Offset: 0x41B96C4 VA: 0x41BD6C4
	public void Init() { }

	// RVA: 0x41BE050 Offset: 0x41BA050 VA: 0x41BE050
	internal void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	[AsyncStateMachine(typeof(SDKManager.<InitAds>d__24))]
	// RVA: 0x41BE064 Offset: 0x41BA064 VA: 0x41BE064
	public void InitAds() { }

	// RVA: 0x41BE118 Offset: 0x41BA118 VA: 0x41BE118
	private void WaitForAdPrivacyFlowThenContinue(Action onFinished) { }

	// RVA: 0x41BE130 Offset: 0x41BA130 VA: 0x41BE130
	private void InitATTThenMobileNotification() { }

	// RVA: 0x41BE218 Offset: 0x41BA218 VA: 0x41BE218
	private void InitMobileNotification() { }

	// RVA: 0x41BDAEC Offset: 0x41B9AEC VA: 0x41BDAEC
	public void InitGorillaSDK() { }

	// RVA: 0x41BE4C4 Offset: 0x41BA4C4 VA: 0x41BE4C4
	private void BindGorillaCallbacks() { }

	// RVA: 0x41BE9D4 Offset: 0x41BA9D4 VA: 0x41BE9D4
	public void RegisterGorillaDebugOptions() { }

	// RVA: 0x41BEADC Offset: 0x41BAADC VA: 0x41BEADC
	private void OnDeepLinkCallback(string url) { }

	// RVA: 0x41BED88 Offset: 0x41BAD88 VA: 0x41BED88
	private void OnDeepLinkActivated(string url) { }

	// RVA: 0x41BE400 Offset: 0x41BA400 VA: 0x41BE400
	private void ReportInitialOpenDeepLinkIfNeeded() { }

	// RVA: 0x41BEE24 Offset: 0x41BAE24 VA: 0x41BEE24
	private void ReportOpenDeepLink(string url) { }

	// RVA: 0x41BE334 Offset: 0x41BA334 VA: 0x41BE334
	private void EnsureGorillaConfig() { }

	// RVA: 0x41BDAD4 Offset: 0x41B9AD4 VA: 0x41BDAD4
	private void InitTGA() { }

	// RVA: 0x41BF134 Offset: 0x41BB134 VA: 0x41BF134
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41BF1F0 Offset: 0x41BB1F0 VA: 0x41BF1F0
	private void <InitGorillaCloudConfig>b__20_0(Dictionary<string, object> objects) { }

	[AsyncStateMachine(typeof(SDKManager.<<InitGorillaCloudConfig>b__20_1>d))]
	[CompilerGenerated]
	// RVA: 0x41BF300 Offset: 0x41BB300 VA: 0x41BF300
	private void <InitGorillaCloudConfig>b__20_1(int code, string message) { }

	[CompilerGenerated]
	// RVA: 0x41BF3B4 Offset: 0x41BB3B4 VA: 0x41BF3B4
	private void <InitATTThenMobileNotification>b__26_0() { }

	[CompilerGenerated]
	// RVA: 0x41BF434 Offset: 0x41BB434 VA: 0x41BF434
	private void <BindGorillaCallbacks>b__38_0(Dictionary<string, object> attribution) { }
}

// Namespace: Framework.SceneModule
public class SceneManager : MonoBehaviour // TypeDefIndex: 21233
{
	// Methods

	// RVA: 0x41C2BF8 Offset: 0x41BEBF8 VA: 0x41C2BF8
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x41C2C9C Offset: 0x41BEC9C VA: 0x41C2C9C
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x41C2D40 Offset: 0x41BED40 VA: 0x41C2D40
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x41C2DD8 Offset: 0x41BEDD8 VA: 0x41C2DD8
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x41C2E84 Offset: 0x41BEE84 VA: 0x41C2E84
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x41C2F30 Offset: 0x41BEF30 VA: 0x41C2F30
	public void .ctor() { }
}

// Namespace: Framework.RunTimeManager
public abstract class BaseRunTimeModel // TypeDefIndex: 21234
{
	// Fields
	public Action m_onFinished; // 0x10
	[Label]
	[SerializeField]
	protected bool m_isLoadingFinished; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnFixedUpdate();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnStarUp();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnShutDown();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnApplicationFocus(bool hasFocus);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnApplicationPause(bool pauseStatus);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnApplicationQuit();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string GetLanguageInfoByID(LanguageType languageType, string id);

	// RVA: 0x41C2F38 Offset: 0x41BEF38 VA: 0x41C2F38
	protected void .ctor() { }
}

// Namespace: Framework.RunTimeManager
public class RunTimeIDConnecterData // TypeDefIndex: 21235
{
	// Fields
	public int m_id; // 0x10
	public object m_obj; // 0x18
	public Type m_type; // 0x20

	// Methods

	// RVA: 0x41C2F40 Offset: 0x41BEF40 VA: 0x41C2F40
	public void .ctor(int id, object obj, Type type) { }
}

// Namespace: Framework.RunTimeManager
public class RunTimeManager : MonoBehaviour // TypeDefIndex: 21236
{
	// Fields
	public Action m_onFinished; // 0x20
	public BaseRunTimeModel m_model; // 0x28

	// Methods

	// RVA: 0x41C2F94 Offset: 0x41BEF94 VA: 0x41C2F94
	public void Load() { }

	// RVA: 0x41C3028 Offset: 0x41BF028 VA: 0x41C3028
	public void OnFixedUpdate() { }

	// RVA: 0x41C3040 Offset: 0x41BF040 VA: 0x41C3040
	public void OnUpdate() { }

	// RVA: 0x41C3058 Offset: 0x41BF058 VA: 0x41C3058
	private void OnStarUp() { }

	// RVA: 0x41C3070 Offset: 0x41BF070 VA: 0x41C3070
	public void OnShutDown() { }

	// RVA: 0x41C30C8 Offset: 0x41BF0C8 VA: 0x41C30C8
	public void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x41C30E4 Offset: 0x41BF0E4 VA: 0x41C30E4
	public void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x41C3100 Offset: 0x41BF100 VA: 0x41C3100
	public void OnApplicationQuit() { }

	// RVA: 0x41C3118 Offset: 0x41BF118 VA: 0x41C3118
	public string GetInfoByID(LanguageType languageType, string id) { }

	// RVA: 0x41C319C Offset: 0x41BF19C VA: 0x41C319C
	public void AddIDConnecter(RunTimeIDConnecterData data) { }

	// RVA: 0x41C31A0 Offset: 0x41BF1A0 VA: 0x41C31A0
	public void RemoveIDConnecter(RunTimeIDConnecterData data) { }

	// RVA: 0x41C31A4 Offset: 0x41BF1A4 VA: 0x41C31A4
	public void RemoveAllIDConnecters() { }

	// RVA: 0x41C31A8 Offset: 0x41BF1A8 VA: 0x41C31A8
	public List<RunTimeIDConnecterData> GetIDConnecterDatas(int id) { }

	// RVA: 0x41C31B0 Offset: 0x41BF1B0 VA: 0x41C31B0
	public Dictionary<int, List<RunTimeIDConnecterData>> GetAllConnecterDatas() { }

	// RVA: 0x41C3218 Offset: 0x41BF218 VA: 0x41C3218
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RunTimeModel_HyBridCLR.<>c // TypeDefIndex: 21237
{
	// Fields
	public static readonly RunTimeModel_HyBridCLR.<>c <>9; // 0x0
	public static Func<Assembly, bool> <>9__15_0; // 0x8

	// Methods

	// RVA: 0x41C3D18 Offset: 0x41BFD18 VA: 0x41C3D18
	private static void .cctor() { }

	// RVA: 0x41C3D80 Offset: 0x41BFD80 VA: 0x41C3D80
	public void .ctor() { }

	// RVA: 0x41C3D88 Offset: 0x41BFD88 VA: 0x41C3D88
	internal bool <LoadAssembly>b__15_0(Assembly assembly) { }
}

// Namespace: 
[CompilerGenerated]
private struct RunTimeModel_HyBridCLR.<Load>d__14 : IAsyncStateMachine // TypeDefIndex: 21238
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RunTimeModel_HyBridCLR <>4__this; // 0x28
	private UniTask.Awaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41C3DF4 Offset: 0x41BFDF4 VA: 0x41C3DF4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C4148 Offset: 0x41C0148 VA: 0x41C4148 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct RunTimeModel_HyBridCLR.<LoadAssembly>d__15 : IAsyncStateMachine // TypeDefIndex: 21239
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public RunTimeModel_HyBridCLR <>4__this; // 0x18
	private TaskAwaiter <>u__1; // 0x20
	private UniTask.Awaiter <>u__2; // 0x28

	// Methods

	// RVA: 0x41C4154 Offset: 0x41C0154 VA: 0x41C4154 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C4B10 Offset: 0x41C0B10 VA: 0x41C4B10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct RunTimeModel_HyBridCLR.<LoadDifferentialHybridAssembly>d__16 : IAsyncStateMachine // TypeDefIndex: 21240
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string assName; // 0x20
	private string <assAdKey>5__2; // 0x28
	private AsyncOperationHandle<TextAsset> <asshandler>5__3; // 0x30
	private TaskAwaiter<TextAsset> <>u__1; // 0x48
	private string <cmetaKey>5__4; // 0x50
	private AsyncOperationHandle<TextAsset> <cmvHandler>5__5; // 0x58
	private string <originMetaKey>5__6; // 0x70
	private AsyncOperationHandle<TextAsset> <omvHandler>5__7; // 0x78

	// Methods

	// RVA: 0x41C4B1C Offset: 0x41C0B1C VA: 0x41C4B1C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C5664 Offset: 0x41C1664 VA: 0x41C5664 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.RunTimeManager
public class RunTimeModel_HyBridCLR : BaseRunTimeModel // TypeDefIndex: 21241
{
	// Fields
	public const string HotUpdateDir = "Assets/_Resources/HotUpdateSnapshot";
	public const string OriginalMetaVersionsDir = "Assets/_Resources/OriginalMetaVersions";
	private Assembly m_hotAssembly; // 0x20
	private AsyncOperationHandle<TextAsset> m_handleHotAssembly; // 0x28
	private AsyncOperationHandle<IList<TextAsset>> m_handleAot; // 0x40
	private object m_mainClass; // 0x58
	private Type m_appType; // 0x60
	private MethodInfo m_onStarUp; // 0x68
	private MethodInfo m_onShutDown; // 0x70
	private MethodInfo m_onUpdate; // 0x78
	private MethodInfo m_applicationFocus; // 0x80
	private MethodInfo m_onApplicationPause; // 0x88
	private MethodInfo m_onApplicationQuit; // 0x90
	private MethodInfo m_getLanguageInfoByID; // 0x98

	// Methods

	[AsyncStateMachine(typeof(RunTimeModel_HyBridCLR.<Load>d__14))]
	// RVA: 0x41C3220 Offset: 0x41BF220 VA: 0x41C3220 Slot: 4
	public override void Load() { }

	[AsyncStateMachine(typeof(RunTimeModel_HyBridCLR.<LoadAssembly>d__15))]
	// RVA: 0x41C32D0 Offset: 0x41BF2D0 VA: 0x41C32D0
	private UniTask LoadAssembly() { }

	[AsyncStateMachine(typeof(RunTimeModel_HyBridCLR.<LoadDifferentialHybridAssembly>d__16))]
	// RVA: 0x41C3380 Offset: 0x41BF380 VA: 0x41C3380
	private Task LoadDifferentialHybridAssembly(string assName) { }

	// RVA: 0x41C3468 Offset: 0x41BF468 VA: 0x41C3468 Slot: 5
	public override void OnUpdate() { }

	// RVA: 0x41C34B4 Offset: 0x41BF4B4 VA: 0x41C34B4 Slot: 6
	public override void OnFixedUpdate() { }

	// RVA: 0x41C34B8 Offset: 0x41BF4B8 VA: 0x41C34B8 Slot: 7
	public override void OnStarUp() { }

	// RVA: 0x41C34FC Offset: 0x41BF4FC VA: 0x41C34FC Slot: 8
	public override void OnShutDown() { }

	// RVA: 0x41C37A0 Offset: 0x41BF7A0 VA: 0x41C37A0 Slot: 9
	public override void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x41C38AC Offset: 0x41BF8AC VA: 0x41C38AC Slot: 10
	public override void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x41C39B8 Offset: 0x41BF9B8 VA: 0x41C39B8 Slot: 11
	public override void OnApplicationQuit() { }

	// RVA: 0x41C3A04 Offset: 0x41BFA04 VA: 0x41C3A04 Slot: 12
	public override string GetLanguageInfoByID(LanguageType languageType, string id) { }

	// RVA: 0x41C3B88 Offset: 0x41BFB88 VA: 0x41C3B88
	private void LoadMetadataForAOTAssemblies(IList<TextAsset> textAssets) { }

	// RVA: 0x41C3020 Offset: 0x41BF020 VA: 0x41C3020
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct AaInitFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21242
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	private AsyncOperationHandle<IResourceLocator> <initHandle>5__2; // 0x28
	private TaskAwaiter<IResourceLocator> <>u__1; // 0x40

	// Methods

	// RVA: 0x41C57B0 Offset: 0x41C17B0 VA: 0x41C57B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C5C14 Offset: 0x41C1C14 VA: 0x41C5C14 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class AaInitFlow : IResUpdateFlow // TypeDefIndex: 21243
{
	// Methods

	[AsyncStateMachine(typeof(AaInitFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41C56CC Offset: 0x41C16CC VA: 0x41C56CC Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41C57A8 Offset: 0x41C17A8 VA: 0x41C57A8
	public void .ctor() { }
}

// Namespace: Framework.ResUpdateFlow
public interface IResUpdateDownPromptReply // TypeDefIndex: 21244
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDownPromptReply(bool isDown);
}

// Namespace: Framework.ResUpdateFlow
public interface IResUpdateFlow // TypeDefIndex: 21245
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UniTask<bool> Execute(ResUpdateFlowContext context);
}

// Namespace: Framework.ResUpdateFlow
public class ResUpdateFlowContext // TypeDefIndex: 21246
{
	// Fields
	[CompilerGenerated]
	private HashSet<string> <BundleSet>k__BackingField; // 0x10
	[CompilerGenerated]
	private Action<bool, float> <NeedUpdateCb>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<float, long, long> <ProgressSizeCb>k__BackingField; // 0x20
	[CompilerGenerated]
	private Action<long> <DownPromptCb>k__BackingField; // 0x28
	[CompilerGenerated]
	private Action<bool, ResourcesUpdateErrorCode> <FinishedCb>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsUpdating>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <TotalDownloadSize>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <CurrentDownloadSize>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <DownloadedPacakgesSize>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <AgreeNotReachableDownload>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <RetryIntervalTime>k__BackingField; // 0x5C
	[CompilerGenerated]
	private AsyncOperationHandle <DownHandle>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<string> <DownloadedPacakges>k__BackingField; // 0x78
	[CompilerGenerated]
	private IList<IResourceLocation> <AllLocations>k__BackingField; // 0x80

	// Properties
	public HashSet<string> BundleSet { get; set; }
	public bool EditorUseAssetDatabase { get; }
	public Action<bool, float> NeedUpdateCb { get; set; }
	public Action<float, long, long> ProgressSizeCb { get; set; }
	public Action<long> DownPromptCb { get; set; }
	public Action<bool, ResourcesUpdateErrorCode> FinishedCb { get; set; }
	public bool IsUpdating { get; set; }
	public long TotalDownloadSize { get; set; }
	public long CurrentDownloadSize { get; set; }
	public long DownloadedPacakgesSize { get; set; }
	public bool AgreeNotReachableDownload { get; set; }
	public int RetryIntervalTime { get; set; }
	public AsyncOperationHandle DownHandle { get; set; }
	public List<string> DownloadedPacakges { get; set; }
	public IList<IResourceLocation> AllLocations { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41C5C6C Offset: 0x41C1C6C VA: 0x41C5C6C
	public HashSet<string> get_BundleSet() { }

	[CompilerGenerated]
	// RVA: 0x41C5C74 Offset: 0x41C1C74 VA: 0x41C5C74
	public void set_BundleSet(HashSet<string> value) { }

	// RVA: 0x41C5C7C Offset: 0x41C1C7C VA: 0x41C5C7C
	public bool get_EditorUseAssetDatabase() { }

	[CompilerGenerated]
	// RVA: 0x41C5C84 Offset: 0x41C1C84 VA: 0x41C5C84
	public Action<bool, float> get_NeedUpdateCb() { }

	[CompilerGenerated]
	// RVA: 0x41C5C8C Offset: 0x41C1C8C VA: 0x41C5C8C
	public void set_NeedUpdateCb(Action<bool, float> value) { }

	[CompilerGenerated]
	// RVA: 0x41C5C94 Offset: 0x41C1C94 VA: 0x41C5C94
	public Action<float, long, long> get_ProgressSizeCb() { }

	[CompilerGenerated]
	// RVA: 0x41C5C9C Offset: 0x41C1C9C VA: 0x41C5C9C
	public void set_ProgressSizeCb(Action<float, long, long> value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CA4 Offset: 0x41C1CA4 VA: 0x41C5CA4
	public Action<long> get_DownPromptCb() { }

	[CompilerGenerated]
	// RVA: 0x41C5CAC Offset: 0x41C1CAC VA: 0x41C5CAC
	public void set_DownPromptCb(Action<long> value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CB4 Offset: 0x41C1CB4 VA: 0x41C5CB4
	public Action<bool, ResourcesUpdateErrorCode> get_FinishedCb() { }

	[CompilerGenerated]
	// RVA: 0x41C5CBC Offset: 0x41C1CBC VA: 0x41C5CBC
	public void set_FinishedCb(Action<bool, ResourcesUpdateErrorCode> value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CC4 Offset: 0x41C1CC4 VA: 0x41C5CC4
	public bool get_IsUpdating() { }

	[CompilerGenerated]
	// RVA: 0x41C5CCC Offset: 0x41C1CCC VA: 0x41C5CCC
	public void set_IsUpdating(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CD8 Offset: 0x41C1CD8 VA: 0x41C5CD8
	public long get_TotalDownloadSize() { }

	[CompilerGenerated]
	// RVA: 0x41C5CE0 Offset: 0x41C1CE0 VA: 0x41C5CE0
	public void set_TotalDownloadSize(long value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CE8 Offset: 0x41C1CE8 VA: 0x41C5CE8
	public long get_CurrentDownloadSize() { }

	[CompilerGenerated]
	// RVA: 0x41C5CF0 Offset: 0x41C1CF0 VA: 0x41C5CF0
	public void set_CurrentDownloadSize(long value) { }

	[CompilerGenerated]
	// RVA: 0x41C5CF8 Offset: 0x41C1CF8 VA: 0x41C5CF8
	public long get_DownloadedPacakgesSize() { }

	[CompilerGenerated]
	// RVA: 0x41C5D00 Offset: 0x41C1D00 VA: 0x41C5D00
	public void set_DownloadedPacakgesSize(long value) { }

	[CompilerGenerated]
	// RVA: 0x41C5D08 Offset: 0x41C1D08 VA: 0x41C5D08
	public bool get_AgreeNotReachableDownload() { }

	[CompilerGenerated]
	// RVA: 0x41C5D10 Offset: 0x41C1D10 VA: 0x41C5D10
	public void set_AgreeNotReachableDownload(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41C5D1C Offset: 0x41C1D1C VA: 0x41C5D1C
	public int get_RetryIntervalTime() { }

	[CompilerGenerated]
	// RVA: 0x41C5D24 Offset: 0x41C1D24 VA: 0x41C5D24
	public void set_RetryIntervalTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x41C5D2C Offset: 0x41C1D2C VA: 0x41C5D2C
	public AsyncOperationHandle get_DownHandle() { }

	[CompilerGenerated]
	// RVA: 0x41C5D40 Offset: 0x41C1D40 VA: 0x41C5D40
	public void set_DownHandle(AsyncOperationHandle value) { }

	[CompilerGenerated]
	// RVA: 0x41C5D60 Offset: 0x41C1D60 VA: 0x41C5D60
	public List<string> get_DownloadedPacakges() { }

	[CompilerGenerated]
	// RVA: 0x41C5D68 Offset: 0x41C1D68 VA: 0x41C5D68
	public void set_DownloadedPacakges(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x41C5D70 Offset: 0x41C1D70 VA: 0x41C5D70
	public IList<IResourceLocation> get_AllLocations() { }

	[CompilerGenerated]
	// RVA: 0x41C5D78 Offset: 0x41C1D78 VA: 0x41C5D78
	public void set_AllLocations(IList<IResourceLocation> value) { }

	// RVA: 0x41C5D80 Offset: 0x41C1D80 VA: 0x41C5D80
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct BeforeDownloadCheckFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__2 : IAsyncStateMachine // TypeDefIndex: 21247
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	public BeforeDownloadCheckFlow <>4__this; // 0x28
	private UniTask.Awaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x41C5EA8 Offset: 0x41C1EA8 VA: 0x41C5EA8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C642C Offset: 0x41C242C VA: 0x41C642C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class BeforeDownloadCheckFlow : IResUpdateFlow, IResUpdateDownPromptReply // TypeDefIndex: 21248
{
	// Fields
	private bool _reply; // 0x10
	private bool _isDown; // 0x11

	// Methods

	[AsyncStateMachine(typeof(BeforeDownloadCheckFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__2))]
	// RVA: 0x41C5D90 Offset: 0x41C1D90 VA: 0x41C5D90 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41C5E84 Offset: 0x41C1E84 VA: 0x41C5E84 Slot: 5
	private void Framework.ResUpdateFlow.IResUpdateDownPromptReply.OnDownPromptReply(bool isDown) { }

	// RVA: 0x41C5E98 Offset: 0x41C1E98 VA: 0x41C5E98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41C5EA0 Offset: 0x41C1EA0 VA: 0x41C5EA0
	private bool <Framework.ResUpdateFlow.IResUpdateFlow.Execute>b__2_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct CheckForCatalogUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21249
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	private AsyncOperationHandle<List<string>> <checkHandle>5__2; // 0x28
	private TaskAwaiter<List<string>> <>u__1; // 0x40
	private AsyncOperationHandle<List<IResourceLocator>> <updateHandle>5__3; // 0x48
	private TaskAwaiter<List<IResourceLocator>> <>u__2; // 0x60

	// Methods

	// RVA: 0x41C656C Offset: 0x41C256C VA: 0x41C656C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C6D5C Offset: 0x41C2D5C VA: 0x41C6D5C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class CheckForCatalogUpdateFlow : IResUpdateFlow // TypeDefIndex: 21250
{
	// Methods

	[AsyncStateMachine(typeof(CheckForCatalogUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41C6484 Offset: 0x41C2484 VA: 0x41C6484 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41C6564 Offset: 0x41C2564 VA: 0x41C6564
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct CheckNeedUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21251
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20

	// Methods

	// RVA: 0x41C6E90 Offset: 0x41C2E90 VA: 0x41C6E90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C71C4 Offset: 0x41C31C4 VA: 0x41C71C4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class CheckNeedUpdateFlow : IResUpdateFlow // TypeDefIndex: 21252
{
	// Methods

	[AsyncStateMachine(typeof(CheckNeedUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41C6DB4 Offset: 0x41C2DB4 VA: 0x41C6DB4 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41C6E88 Offset: 0x41C2E88 VA: 0x41C6E88
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct DownloadUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__3 : IAsyncStateMachine // TypeDefIndex: 21253
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	public DownloadUpdateFlow <>4__this; // 0x28
	private AsyncOperationHandle<IList<IResourceLocation>> <loadHandle>5__2; // 0x30
	private TaskAwaiter<IList<IResourceLocation>> <>u__1; // 0x48
	private UniTask.Awaiter<bool> <>u__2; // 0x50

	// Methods

	// RVA: 0x41C7440 Offset: 0x41C3440 VA: 0x41C7440 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C7FB4 Offset: 0x41C3FB4 VA: 0x41C7FB4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct DownloadUpdateFlow.<InternalDownload>d__4 : IAsyncStateMachine // TypeDefIndex: 21254
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	public DownloadUpdateFlow <>4__this; // 0x28
	public int i; // 0x30
	private TaskAwaiter<object> <>u__1; // 0x38
	private UniTask.Awaiter <>u__2; // 0x40
	private UniTask.Awaiter<bool> <>u__3; // 0x50

	// Methods

	// RVA: 0x41C800C Offset: 0x41C400C VA: 0x41C800C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C8DE0 Offset: 0x41C4DE0 VA: 0x41C8DE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class DownloadUpdateFlow : IResUpdateFlow, IResUpdateDownPromptReply // TypeDefIndex: 21255
{
	// Fields
	private IList<IResourceLocation> _allLocationList; // 0x10
	private bool _reply; // 0x18
	private bool _isDown; // 0x19

	// Methods

	[AsyncStateMachine(typeof(DownloadUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__3))]
	// RVA: 0x41C721C Offset: 0x41C321C VA: 0x41C721C Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	[AsyncStateMachine(typeof(DownloadUpdateFlow.<InternalDownload>d__4))]
	// RVA: 0x41C7314 Offset: 0x41C3314 VA: 0x41C7314
	private UniTask<bool> InternalDownload(ResUpdateFlowContext context, int i) { }

	// RVA: 0x41C741C Offset: 0x41C341C VA: 0x41C741C Slot: 5
	private void Framework.ResUpdateFlow.IResUpdateDownPromptReply.OnDownPromptReply(bool isDown) { }

	// RVA: 0x41C7430 Offset: 0x41C3430 VA: 0x41C7430
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41C7438 Offset: 0x41C3438 VA: 0x41C7438
	private bool <InternalDownload>b__4_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct GetUpdateSizeFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21256
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	private AsyncOperationHandle<long> <sizeHandle>5__2; // 0x28
	private TaskAwaiter<long> <>u__1; // 0x40
	private UniTask.Awaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x41C8FD4 Offset: 0x41C4FD4 VA: 0x41C8FD4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41C977C Offset: 0x41C577C VA: 0x41C977C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct GetUpdateSizeFlow.<LogPerLocationDownloadSizesAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 21257
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public string label; // 0x18
	private AsyncOperationHandle<IList<IResourceLocation>> <loadHandle>5__2; // 0x20
	private IList<IResourceLocation> <list>5__3; // 0x38
	private long <sum>5__4; // 0x40
	private TaskAwaiter<IList<IResourceLocation>> <>u__1; // 0x48
	private int <i>5__5; // 0x50
	private IResourceLocation <loc>5__6; // 0x58
	private AsyncOperationHandle<long> <h>5__7; // 0x60
	private TaskAwaiter<long> <>u__2; // 0x78

	// Methods

	// RVA: 0x41C97D4 Offset: 0x41C57D4 VA: 0x41C97D4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41CA230 Offset: 0x41C6230 VA: 0x41CA230 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class GetUpdateSizeFlow : IResUpdateFlow // TypeDefIndex: 21258
{
	// Methods

	[AsyncStateMachine(typeof(GetUpdateSizeFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41C8E38 Offset: 0x41C4E38 VA: 0x41C8E38 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	[AsyncStateMachine(typeof(GetUpdateSizeFlow.<LogPerLocationDownloadSizesAsync>d__1))]
	// RVA: 0x41C8F18 Offset: 0x41C4F18 VA: 0x41C8F18
	private static UniTask LogPerLocationDownloadSizesAsync(string label, long labelTotalBytes) { }

	// RVA: 0x41C8FCC Offset: 0x41C4FCC VA: 0x41C8FCC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct LoadBuiltinListFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21259
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	private string <result>5__2; // 0x28
	private UnityWebRequest <www>5__3; // 0x30
	private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x41CA320 Offset: 0x41C6320 VA: 0x41CA320 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41CABD0 Offset: 0x41C6BD0 VA: 0x41CABD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class LoadBuiltinListFlow : IResUpdateFlow // TypeDefIndex: 21260
{
	// Methods

	[AsyncStateMachine(typeof(LoadBuiltinListFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41CA23C Offset: 0x41C623C VA: 0x41CA23C Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41CA318 Offset: 0x41C6318 VA: 0x41CA318
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageSpilit_DownloadUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__3 : IAsyncStateMachine // TypeDefIndex: 21261
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	public PackageSpilit_DownloadUpdateFlow <>4__this; // 0x28
	private UniTask.Awaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x41CAE48 Offset: 0x41C6E48 VA: 0x41CAE48 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41CB430 Offset: 0x41C7430 VA: 0x41CB430 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageSpilit_DownloadUpdateFlow.<InternalDownload>d__4 : IAsyncStateMachine // TypeDefIndex: 21262
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	public PackageSpilit_DownloadUpdateFlow <>4__this; // 0x28
	public int i; // 0x30
	private TaskAwaiter<object> <>u__1; // 0x38
	private UniTask.Awaiter <>u__2; // 0x40
	private UniTask.Awaiter<bool> <>u__3; // 0x50

	// Methods

	// RVA: 0x41CB488 Offset: 0x41C7488 VA: 0x41CB488 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41CC25C Offset: 0x41C825C VA: 0x41CC25C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class PackageSpilit_DownloadUpdateFlow : IResUpdateFlow, IResUpdateDownPromptReply // TypeDefIndex: 21263
{
	// Fields
	private IList<IResourceLocation> _allLocationList; // 0x10
	private bool _reply; // 0x18
	private bool _isDown; // 0x19

	// Methods

	[AsyncStateMachine(typeof(PackageSpilit_DownloadUpdateFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__3))]
	// RVA: 0x41CAC28 Offset: 0x41C6C28 VA: 0x41CAC28 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	[AsyncStateMachine(typeof(PackageSpilit_DownloadUpdateFlow.<InternalDownload>d__4))]
	// RVA: 0x41CAD1C Offset: 0x41C6D1C VA: 0x41CAD1C
	private UniTask<bool> InternalDownload(ResUpdateFlowContext context, int i) { }

	// RVA: 0x41CAE24 Offset: 0x41C6E24 VA: 0x41CAE24 Slot: 5
	private void Framework.ResUpdateFlow.IResUpdateDownPromptReply.OnDownPromptReply(bool isDown) { }

	// RVA: 0x41CAE38 Offset: 0x41C6E38 VA: 0x41CAE38
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41CAE40 Offset: 0x41C6E40 VA: 0x41CAE40
	private bool <InternalDownload>b__4_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageSpilit_GetUpdateSizeFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0 : IAsyncStateMachine // TypeDefIndex: 21264
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ResUpdateFlowContext context; // 0x20
	private AsyncOperationHandle<IList<IResourceLocation>> <handle>5__2; // 0x28
	private AsyncOperationHandle<long> <sizeHandle>5__3; // 0x40
	private UniTask.Awaiter <>u__1; // 0x58
	private TaskAwaiter<long> <>u__2; // 0x68

	// Methods

	// RVA: 0x41CDC6C Offset: 0x41C9C6C VA: 0x41CDC6C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41CE740 Offset: 0x41CA740 VA: 0x41CE740 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResUpdateFlow
public class PackageSpilit_GetUpdateSizeFlow : IResUpdateFlow // TypeDefIndex: 21265
{
	// Methods

	[AsyncStateMachine(typeof(PackageSpilit_GetUpdateSizeFlow.<Framework-ResUpdateFlow-IResUpdateFlow-Execute>d__0))]
	// RVA: 0x41CDB84 Offset: 0x41C9B84 VA: 0x41CDB84 Slot: 4
	private UniTask<bool> Framework.ResUpdateFlow.IResUpdateFlow.Execute(ResUpdateFlowContext context) { }

	// RVA: 0x41CDC64 Offset: 0x41C9C64 VA: 0x41CDC64
	public void .ctor() { }
}

// Namespace: Framework.ResourcesModule
public enum UpdateForceLevel // TypeDefIndex: 21266
{
	// Fields
	public int value__; // 0x0
	public const UpdateForceLevel Weak = 0;
	public const UpdateForceLevel Medium = 1;
	public const UpdateForceLevel Strong = 2;
}

// Namespace: Framework.ResourcesModule
public enum ApkDownloadStartState // TypeDefIndex: 21267
{
	// Fields
	public int value__; // 0x0
	public const ApkDownloadStartState Unsupported = -2;
	public const ApkDownloadStartState Invalid = -1;
	public const ApkDownloadStartState Started = 0;
	public const ApkDownloadStartState AlreadyRunning = 1;
	public const ApkDownloadStartState ReplacedPrevious = 2;
}

// Namespace: Framework.ResourcesModule
public static class ApkDownloadResultCode // TypeDefIndex: 21268
{
	// Fields
	public const int Failed = -1;
	public const int DownloadComplete = 0;
	public const int InstallStarted = 1;
}

// Namespace: 
[Preserve]
private sealed class AndroidAppDownloadManager.DownloadResultProxy : AndroidJavaProxy // TypeDefIndex: 21269
{
	// Fields
	private readonly AndroidAppDownloadManager _owner; // 0x20

	// Methods

	// RVA: 0x41CFD2C Offset: 0x41CBD2C VA: 0x41CFD2C
	public void .ctor(AndroidAppDownloadManager owner) { }

	[Preserve]
	// RVA: 0x41CFFD0 Offset: 0x41CBFD0 VA: 0x41CFFD0
	public void OnResult(int code, string message) { }
}

// Namespace: 
[Preserve]
private sealed class AndroidAppDownloadManager.DownloadProgressProxy : AndroidJavaProxy // TypeDefIndex: 21270
{
	// Fields
	private readonly AndroidAppDownloadManager _owner; // 0x20

	// Methods

	// RVA: 0x41CFDB8 Offset: 0x41CBDB8 VA: 0x41CFDB8
	public void .ctor(AndroidAppDownloadManager owner) { }

	[Preserve]
	// RVA: 0x41D0004 Offset: 0x41CC004 VA: 0x41D0004
	public void OnProgress(int progress) { }
}

// Namespace: Framework.ResourcesModule
public sealed class AndroidAppDownloadManager : Singleton<AndroidAppDownloadManager> // TypeDefIndex: 21271
{
	// Fields
	private const string ResultCallbackInterface = "com.gorilla.appdownload.IDownloadResult";
	private const string ProgressCallbackInterface = "com.gorilla.appdownload.IDownloadProgress";
	private AndroidAppDownloadManager.DownloadResultProxy _resultProxy; // 0x10
	private AndroidAppDownloadManager.DownloadProgressProxy _progressProxy; // 0x18
	[CompilerGenerated]
	private Action<int, string> DownloadResult; // 0x20
	[CompilerGenerated]
	private Action<int> DownloadProgress; // 0x28
	[CompilerGenerated]
	private string <ActiveUrl>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <ActiveVersion>k__BackingField; // 0x38

	// Properties
	public string ActiveUrl { get; set; }
	public string ActiveVersion { get; set; }
	public bool IsRunning { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41CE798 Offset: 0x41CA798 VA: 0x41CE798
	public void add_DownloadResult(Action<int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x41CE848 Offset: 0x41CA848 VA: 0x41CE848
	public void remove_DownloadResult(Action<int, string> value) { }

	[CompilerGenerated]
	// RVA: 0x41CE8F8 Offset: 0x41CA8F8 VA: 0x41CE8F8
	public void add_DownloadProgress(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x41CE9A8 Offset: 0x41CA9A8 VA: 0x41CE9A8
	public void remove_DownloadProgress(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x41CEA58 Offset: 0x41CAA58 VA: 0x41CEA58
	public string get_ActiveUrl() { }

	[CompilerGenerated]
	// RVA: 0x41CEA60 Offset: 0x41CAA60 VA: 0x41CEA60
	private void set_ActiveUrl(string value) { }

	[CompilerGenerated]
	// RVA: 0x41CEA68 Offset: 0x41CAA68 VA: 0x41CEA68
	public string get_ActiveVersion() { }

	[CompilerGenerated]
	// RVA: 0x41CEA70 Offset: 0x41CAA70 VA: 0x41CEA70
	private void set_ActiveVersion(string value) { }

	// RVA: 0x41CEA78 Offset: 0x41CAA78 VA: 0x41CEA78
	public bool get_IsRunning() { }

	// RVA: 0x41CEF60 Offset: 0x41CAF60 VA: 0x41CEF60
	public string GetDownloadUrl(string version) { }

	// RVA: 0x41CF34C Offset: 0x41CB34C VA: 0x41CF34C
	public ApkDownloadStartState StartDownloadApk(string url, string version) { }

	// RVA: 0x41CFE44 Offset: 0x41CBE44 VA: 0x41CFE44
	public bool ShouldReplaceRunningDownload(string url, string version) { }

	// RVA: 0x41CFBDC Offset: 0x41CBBDC VA: 0x41CFBDC
	public static bool IsValidDownloadUrl(string url) { }

	// RVA: 0x41CFD10 Offset: 0x41CBD10 VA: 0x41CFD10
	private void NotifyResult(int code, string message) { }

	// RVA: 0x41CFF20 Offset: 0x41CBF20 VA: 0x41CFF20
	private void NotifyProgress(int progress) { }

	// RVA: 0x41CFF3C Offset: 0x41CBF3C VA: 0x41CFF3C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class APP_Update.<>c__DisplayClass5_0 // TypeDefIndex: 21272
{
	// Fields
	public Action<string, UpdateForceLevel> success; // 0x10
	public APP_Update <>4__this; // 0x18
	public string versionUrl; // 0x20
	public string currentVersion; // 0x28
	public Action<string, string> fail; // 0x30

	// Methods

	// RVA: 0x41D0504 Offset: 0x41CC504 VA: 0x41D0504
	public void .ctor() { }

	// RVA: 0x41D0CE0 Offset: 0x41CCCE0 VA: 0x41D0CE0
	internal void <CheckUpdateWithFallback>b__0(string content) { }

	// RVA: 0x41D0E04 Offset: 0x41CCE04 VA: 0x41D0E04
	internal void <CheckUpdateWithFallback>b__1(string sendCode, string severCode) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class APP_Update.<>c__DisplayClass9_0 // TypeDefIndex: 21273
{
	// Fields
	public Action<string, UpdateForceLevel> success; // 0x10
	public Action<string, string> fail; // 0x18

	// Methods

	// RVA: 0x41D0AB4 Offset: 0x41CCAB4 VA: 0x41D0AB4
	public void .ctor() { }

	// RVA: 0x41D0F0C Offset: 0x41CCF0C VA: 0x41D0F0C
	internal void <CheckLegacyVersion>b__0(string content) { }
}

// Namespace: Framework.ResourcesModule
public class APP_Update : Singleton<APP_Update> // TypeDefIndex: 21274
{
	// Fields
	private string m_url; // 0x10
	private string m_currentVersion; // 0x18
	private Action<string> m_success; // 0x20
	private Action<string, string> m_fail; // 0x28

	// Methods

	// RVA: 0x41D0038 Offset: 0x41CC038 VA: 0x41D0038
	public void CheckUpdate(string url, string currentVersion, Action<string> success, Action<string, string> fail) { }

	// RVA: 0x41D02B4 Offset: 0x41CC2B4 VA: 0x41D02B4
	public void CheckUpdateWithFallback(string versionNewUrl, string versionUrl, string currentVersion, Action<string, UpdateForceLevel> success, Action<string, string> fail) { }

	// RVA: 0x41D05C8 Offset: 0x41CC5C8 VA: 0x41D05C8
	internal static bool TryParseVersion(string content, out string version) { }

	// RVA: 0x41D0778 Offset: 0x41CC778 VA: 0x41D0778
	public static bool TryParseVersionInfo(string content, out string version, out UpdateForceLevel updateForceLevel) { }

	// RVA: 0x41D07F0 Offset: 0x41CC7F0 VA: 0x41D07F0
	public static UpdateForceLevel ParseUpdateForceLevel(string value) { }

	// RVA: 0x41D09B4 Offset: 0x41CC9B4 VA: 0x41D09B4
	private void CheckLegacyVersion(string versionUrl, string currentVersion, Action<string, UpdateForceLevel> success, Action<string, string> fail) { }

	// RVA: 0x41D00A0 Offset: 0x41CC0A0 VA: 0x41D00A0
	private void Check() { }

	// RVA: 0x41D0ABC Offset: 0x41CCABC VA: 0x41D0ABC
	private void OnCheckVersion(string version) { }

	// RVA: 0x41D0AF8 Offset: 0x41CCAF8 VA: 0x41D0AF8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x41D0B8C Offset: 0x41CCB8C VA: 0x41D0B8C
	private void <Check>b__10_0(UnityWebRequest x) { }
}

// Namespace: Framework.ResourcesModule
public class HotUpdateConfig // TypeDefIndex: 21275
{
	// Fields
	public List<string> hotUpdateList; // 0x10

	// Methods

	// RVA: 0x41D0FB8 Offset: 0x41CCFB8 VA: 0x41D0FB8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageDownloader.<Download>d__22 : IAsyncStateMachine // TypeDefIndex: 21276
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public PackageDownloader <>4__this; // 0x28
	public Action downloadFinish; // 0x30
	public Action<PackageDownloaderErrorCode> downloadError; // 0x38
	public bool highSpeed; // 0x40
	private AsyncOperationHandle<IList<IResourceLocation>> <loadHandle>5__2; // 0x48
	private List<IResourceLocation> <_allLocationList>5__3; // 0x60
	private List<IResourceLocation> <list>5__4; // 0x68
	private UniTask.Awaiter<long> <>u__1; // 0x70
	private TaskAwaiter<IList<IResourceLocation>> <>u__2; // 0x88
	private int <downloadCount>5__5; // 0x90
	private TaskAwaiter<object> <>u__3; // 0x98

	// Methods

	// RVA: 0x41D1CF8 Offset: 0x41CDCF8 VA: 0x41D1CF8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D3098 Offset: 0x41CF098 VA: 0x41D3098 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageDownloader.<GetDownloadTotalSize>d__20 : IAsyncStateMachine // TypeDefIndex: 21277
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<long> <>t__builder; // 0x8
	public PackageDownloader <>4__this; // 0x20
	private AsyncOperationHandle<long> <sizeHandle>5__2; // 0x28
	private TaskAwaiter<long> <>u__1; // 0x40

	// Methods

	// RVA: 0x41D30A4 Offset: 0x41CF0A4 VA: 0x41D30A4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D3530 Offset: 0x41CF530 VA: 0x41D3530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PackageDownloader.<StopDownload>d__25 : IAsyncStateMachine // TypeDefIndex: 21278
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public PackageDownloader <>4__this; // 0x18
	private UniTask.Awaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x41D3588 Offset: 0x41CF588 VA: 0x41D3588 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D3C90 Offset: 0x41CFC90 VA: 0x41D3C90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResourcesModule
public class PackageDownloader // TypeDefIndex: 21279
{
	// Fields
	private const int NormalConcurrentDownloadCount = 1;
	private const int HighSpeedConcurrentDownloadCount = 4;
	private const int NormalMaxConcurrentWebRequestCount = 3;
	private const int HighSpeedMaxConcurrentWebRequestCount = 4;
	private string _labelName; // 0x10
	private Action _downloadFinish; // 0x18
	private Action<PackageDownloaderErrorCode> _downloadError; // 0x20
	[CompilerGenerated]
	private bool <IsDownloading>k__BackingField; // 0x28
	private AsyncOperationHandle _downloadHandle; // 0x30
	private bool _stopDownloadFlag; // 0x48
	private long _totalBytes; // 0x50
	private long _downloadedBytes; // 0x58
	private bool _isHighSpeed; // 0x60

	// Properties
	public string Label { get; }
	public bool IsDownloading { get; set; }

	// Methods

	// RVA: 0x41D0FC0 Offset: 0x41CCFC0 VA: 0x41D0FC0
	public string get_Label() { }

	[CompilerGenerated]
	// RVA: 0x41D0FC8 Offset: 0x41CCFC8 VA: 0x41D0FC8
	public bool get_IsDownloading() { }

	[CompilerGenerated]
	// RVA: 0x41D0FD0 Offset: 0x41CCFD0 VA: 0x41D0FD0
	private void set_IsDownloading(bool value) { }

	// RVA: 0x41D0FDC Offset: 0x41CCFDC VA: 0x41D0FDC
	public void .ctor(string labelName) { }

	// RVA: 0x41D1014 Offset: 0x41CD014 VA: 0x41D1014
	public void SetHighSpeed(bool highSpeed) { }

	[AsyncStateMachine(typeof(PackageDownloader.<GetDownloadTotalSize>d__20))]
	// RVA: 0x41D109C Offset: 0x41CD09C VA: 0x41D109C
	public UniTask<long> GetDownloadTotalSize() { }

	// RVA: 0x41D1198 Offset: 0x41CD198 VA: 0x41D1198
	public void GetDownloadSize(out long totalBytes, out long downloadedBytes) { }

	[AsyncStateMachine(typeof(PackageDownloader.<Download>d__22))]
	// RVA: 0x41D1200 Offset: 0x41CD200 VA: 0x41D1200
	public void Download(bool highSpeed, Action downloadFinish, Action<PackageDownloaderErrorCode> downloadError) { }

	// RVA: 0x41D12F8 Offset: 0x41CD2F8 VA: 0x41D12F8
	private int GetConcurrentDownloadCount() { }

	// RVA: 0x41D1088 Offset: 0x41CD088 VA: 0x41D1088
	private int GetMaxConcurrentWebRequestCount() { }

	[AsyncStateMachine(typeof(PackageDownloader.<StopDownload>d__25))]
	// RVA: 0x41D130C Offset: 0x41CD30C VA: 0x41D130C
	public UniTask StopDownload() { }

	// RVA: 0x41D13B8 Offset: 0x41CD3B8 VA: 0x41D13B8
	private static List<IResourceLocation> GatherBundleLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x41D1704 Offset: 0x41CD704 VA: 0x41D1704
	private static void AddBundleLocation(IResourceLocation loc, List<IResourceLocation> result, HashSet<string> added) { }

	[CompilerGenerated]
	// RVA: 0x41D1CE8 Offset: 0x41CDCE8 VA: 0x41D1CE8
	private bool <StopDownload>b__25_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourcesManager.<>c__DisplayClass60_0 // TypeDefIndex: 21280
{
	// Fields
	public ResourcesManager <>4__this; // 0x10
	public PackageDownloader loader; // 0x18
	public Action downloadFinish; // 0x20
	public Action<PackageDownloaderErrorCode> downloadError; // 0x28

	// Methods

	// RVA: 0x41D5668 Offset: 0x41D1668 VA: 0x41D5668
	public void .ctor() { }

	// RVA: 0x41D6EA8 Offset: 0x41D2EA8 VA: 0x41D6EA8
	internal void <Download>b__0() { }

	// RVA: 0x41D6F8C Offset: 0x41D2F8C VA: 0x41D6F8C
	internal void <Download>b__1(PackageDownloaderErrorCode error) { }
}

// Namespace: 
[CompilerGenerated]
private struct ResourcesManager.<CheckUpdate>d__73 : IAsyncStateMachine // TypeDefIndex: 21281
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ResourcesManager <>4__this; // 0x28
	public Action<float, long, long> downloadProgressCallback; // 0x30
	public Action<long> downPrompt; // 0x38
	public Action<bool, float> checkFinish; // 0x40
	public Action<bool, ResourcesUpdateErrorCode> updateFinished; // 0x48
	private List.Enumerator<IResUpdateFlow> <>7__wrap1; // 0x50
	private UniTask.Awaiter<bool> <>u__1; // 0x68

	// Methods

	// RVA: 0x41D6FE4 Offset: 0x41D2FE4 VA: 0x41D6FE4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D76D4 Offset: 0x41D36D4 VA: 0x41D76D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ResourcesManager.<GetDownloadTotalSize>d__64 : IAsyncStateMachine // TypeDefIndex: 21282
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<long> <>t__builder; // 0x8
	public ResourcesManager <>4__this; // 0x20
	public string label; // 0x28
	private UniTask.Awaiter<long> <>u__1; // 0x30

	// Methods

	// RVA: 0x41D76E0 Offset: 0x41D36E0 VA: 0x41D76E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D7AFC Offset: 0x41D3AFC VA: 0x41D7AFC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ResourcesManager.<StopPackageDownloader>d__65 : IAsyncStateMachine // TypeDefIndex: 21283
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public ResourcesManager <>4__this; // 0x18
	public string label; // 0x20
	private UniTask.Awaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x41D7B54 Offset: 0x41D3B54 VA: 0x41D7B54 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41D7FE8 Offset: 0x41D3FE8 VA: 0x41D7FE8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Framework.ResourcesModule
public class ResourcesManager : MonoBehaviour // TypeDefIndex: 21284
{
	// Fields
	private HashSet<string> m_DownloadedPacakges; // 0x20
	private Dictionary<string, PackageDownloader> m_PackageDownloaderDic; // 0x28
	private const bool CanDownloadMultyPackage = False;
	private PackageDownloader m_curDownloader; // 0x30
	public const string AddressableCheckUpdateLabel = "CheckUpdate";
	public const string FirstPackageLabel = "FirstPackage";
	protected readonly List<IResUpdateFlow> Flows; // 0x38
	private ResUpdateFlowContext _context; // 0x40
	private readonly HashSet<string> _bundleSet; // 0x48
	private IResUpdateFlow _currentFlow; // 0x50
	private bool isPreRelease; // 0x58

	// Properties
	public IInstanceProvider InstanceProvider { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }

	// Methods

	// RVA: 0x41D3C9C Offset: 0x41CFC9C VA: 0x41D3C9C
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x41D3CEC Offset: 0x41CFCEC VA: 0x41D3CEC
	public string ResolveInternalId(string id) { }

	// RVA: 0x41D3D44 Offset: 0x41CFD44 VA: 0x41D3D44
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x41D3D94 Offset: 0x41CFD94 VA: 0x41D3D94
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x41D3DEC Offset: 0x41CFDEC VA: 0x41D3DEC
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x41D3E3C Offset: 0x41CFE3C VA: 0x41D3E3C
	public string get_BuildPath() { }

	// RVA: 0x41D3E8C Offset: 0x41CFE8C VA: 0x41D3E8C
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x41D3EDC Offset: 0x41CFEDC VA: 0x41D3EDC
	public string get_RuntimePath() { }

	// RVA: 0x41D3F2C Offset: 0x41CFF2C VA: 0x41D3F2C
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x41D3FA0 Offset: 0x41CFFA0 VA: 0x41D3FA0
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x41D4030 Offset: 0x41D0030 VA: 0x41D4030
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3918 Offset: 0x46BF918 VA: 0x46C3918
	|-ResourcesManager.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3890 Offset: 0x46BF890 VA: 0x46C3890
	|-ResourcesManager.LoadAssetAsync<object>
	|
	|-RVA: 0x46C39A4 Offset: 0x46BF9A4 VA: 0x46C39A4
	|-ResourcesManager.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x41D40C8 Offset: 0x41D00C8 VA: 0x41D40C8
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x41D4160 Offset: 0x41D0160 VA: 0x41D4160
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3AC8 Offset: 0x46BFAC8 VA: 0x46C3AC8
	|-ResourcesManager.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3C00 Offset: 0x46BFC00 VA: 0x46C3C00
	|-ResourcesManager.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3D48 Offset: 0x46BFD48 VA: 0x46C3D48
	|-ResourcesManager.LoadAssetsAsync<object>
	|
	|-RVA: 0x46C3DF4 Offset: 0x46BFDF4 VA: 0x46C3DF4
	|-ResourcesManager.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3A30 Offset: 0x46BFA30 VA: 0x46C3A30
	|-ResourcesManager.LoadAssetsAsync<object>
	|
	|-RVA: 0x46C3B64 Offset: 0x46BFB64 VA: 0x46C3B64
	|-ResourcesManager.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3CA4 Offset: 0x46BFCA4 VA: 0x46C3CA4
	|-ResourcesManager.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41D41EC Offset: 0x41D01EC VA: 0x41D41EC
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3EA4 Offset: 0x46BFEA4 VA: 0x46C3EA4
	|-ResourcesManager.Release<object>
	|
	|-RVA: 0x46C3F98 Offset: 0x46BFF98 VA: 0x46C3F98
	|-ResourcesManager.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C3F08 Offset: 0x46BFF08 VA: 0x46C3F08
	|-ResourcesManager.Release<object>
	|
	|-RVA: 0x46C4098 Offset: 0x46C0098 VA: 0x46C4098
	|-ResourcesManager.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41D4290 Offset: 0x41D0290 VA: 0x41D4290
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x41D4314 Offset: 0x41D0314 VA: 0x41D4314
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x41D436C Offset: 0x41D036C VA: 0x41D436C
	public bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x41D43F4 Offset: 0x41D03F4 VA: 0x41D43F4
	public bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	// RVA: 0x41D447C Offset: 0x41D047C VA: 0x41D447C
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	[Obsolete]
	// RVA: 0x41D44FC Offset: 0x41D04FC VA: 0x41D44FC
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x41D457C Offset: 0x41D057C VA: 0x41D457C
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x41D4608 Offset: 0x41D0608 VA: 0x41D4608
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[Obsolete]
	// RVA: 0x41D4694 Offset: 0x41D0694 VA: 0x41D4694
	public AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x41D472C Offset: 0x41D072C VA: 0x41D472C
	public void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x41D4784 Offset: 0x41D0784 VA: 0x41D4784
	public void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[Obsolete]
	// RVA: 0x41D47DC Offset: 0x41D07DC VA: 0x41D47DC
	public void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x41D4834 Offset: 0x41D0834 VA: 0x41D4834
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x41D4904 Offset: 0x41D0904 VA: 0x41D4904
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x41D49F8 Offset: 0x41D09F8 VA: 0x41D49F8
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x41D4A9C Offset: 0x41D0A9C VA: 0x41D4A9C
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x41D4B90 Offset: 0x41D0B90 VA: 0x41D4B90
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x41D4C4C Offset: 0x41D0C4C VA: 0x41D4C4C
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x41D4D08 Offset: 0x41D0D08 VA: 0x41D4D08
	public AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x41D4D88 Offset: 0x41D0D88 VA: 0x41D4D88
	public AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x41D4E14 Offset: 0x41D0E14 VA: 0x41D4E14
	public void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x41D4E84 Offset: 0x41D0E84 VA: 0x41D4E84
	public void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x41D4EDC Offset: 0x41D0EDC VA: 0x41D4EDC
	public void ClearResourceLocators() { }

	// RVA: 0x41D4F2C Offset: 0x41D0F2C VA: 0x41D4F2C
	private void InitDownloadedPacakges() { }

	// RVA: 0x41D5398 Offset: 0x41D1398 VA: 0x41D5398
	private string[] GetDownloadedPacakges() { }

	// RVA: 0x41D52A4 Offset: 0x41D12A4 VA: 0x41D52A4
	private void SavePacakge() { }

	// RVA: 0x41D53E0 Offset: 0x41D13E0 VA: 0x41D53E0
	public bool IsDownloaded(string label) { }

	// RVA: 0x41D5438 Offset: 0x41D1438 VA: 0x41D5438
	public void Download(string label, bool highSpeed, Action downloadFinish, Action<PackageDownloaderErrorCode> downloadError) { }

	// RVA: 0x41D58A0 Offset: 0x41D18A0 VA: 0x41D58A0
	public void SetPackageDownloaderHighSpeed(string label, bool highSpeed) { }

	// RVA: 0x41D57A8 Offset: 0x41D17A8 VA: 0x41D57A8
	private PackageDownloader GetPackageDownloader(string label) { }

	// RVA: 0x41D594C Offset: 0x41D194C VA: 0x41D594C
	public void GetCurDownloadSize(string label, out long totalBytes, out long downloadedBytes) { }

	[AsyncStateMachine(typeof(ResourcesManager.<GetDownloadTotalSize>d__64))]
	// RVA: 0x41D59B4 Offset: 0x41D19B4 VA: 0x41D59B4
	public UniTask<long> GetDownloadTotalSize(string label) { }

	[AsyncStateMachine(typeof(ResourcesManager.<StopPackageDownloader>d__65))]
	// RVA: 0x41D5ACC Offset: 0x41D1ACC VA: 0x41D5ACC
	public UniTask StopPackageDownloader(string label) { }

	[AsyncStateMachine(typeof(ResourcesManager.<CheckUpdate>d__73))]
	// RVA: 0x41D5B9C Offset: 0x41D1B9C VA: 0x41D5B9C
	public void CheckUpdate(Action<bool, float> checkFinish, Action<long> downPrompt, Action<float, long, long> downloadProgressCallback, Action<bool, ResourcesUpdateErrorCode> updateFinished) { }

	// RVA: 0x41D5CC8 Offset: 0x41D1CC8 VA: 0x41D5CC8
	protected ResUpdateFlowContext CreateContext() { }

	// RVA: 0x41D5D1C Offset: 0x41D1D1C VA: 0x41D5D1C
	protected void CreateFlows() { }

	// RVA: 0x41D6300 Offset: 0x41D2300 VA: 0x41D6300
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41D63F0 Offset: 0x41D23F0 VA: 0x41D63F0
	public void SwitchToPreReleaseCdn() { }

	// RVA: 0x41D63FC Offset: 0x41D23FC VA: 0x41D63FC
	private static string ReplaceUrl(string internalId) { }

	// RVA: 0x41D648C Offset: 0x41D248C VA: 0x41D648C
	private static string LoadFunc(IResourceLocation location) { }

	// RVA: 0x41D68B4 Offset: 0x41D28B4 VA: 0x41D68B4
	protected string LocationTransformPath(IResourceLocation location) { }

	// RVA: 0x41D6C78 Offset: 0x41D2C78 VA: 0x41D6C78
	public void AgreeNotReachableDownload() { }

	// RVA: 0x41D6C98 Offset: 0x41D2C98 VA: 0x41D6C98
	public void OnDownAssets() { }

	// RVA: 0x41D6D54 Offset: 0x41D2D54 VA: 0x41D6D54
	public void .ctor() { }
}

// Namespace: Framework.ResourcesModule
public enum PackageDownloaderErrorCode // TypeDefIndex: 21285
{
	// Fields
	public int value__; // 0x0
	public const PackageDownloaderErrorCode FindResourcesError = 0;
	public const PackageDownloaderErrorCode NoResourcesFound = 1;
	public const PackageDownloaderErrorCode DownloadError = 2;
	public const PackageDownloaderErrorCode StopDownload = 3;
	public const PackageDownloaderErrorCode OtherPackageDownloading = 4;
}

// Namespace: Framework.ResourcesModule
public enum CdnType // TypeDefIndex: 21286
{
	// Fields
	public int value__; // 0x0
	public const CdnType Debug = 1;
	public const CdnType Release = 3;
}

// Namespace: Framework.ResourcesModule
public enum ResourcesUpdateErrorCode // TypeDefIndex: 21287
{
	// Fields
	public ushort value__; // 0x0
	public const ResourcesUpdateErrorCode None = 0;
	public const ResourcesUpdateErrorCode InitializeAsync = 501;
	public const ResourcesUpdateErrorCode CheckForCatalogUpdates = 502;
	public const ResourcesUpdateErrorCode NotReachable = 503;
	public const ResourcesUpdateErrorCode UpdateCatalogs = 504;
	public const ResourcesUpdateErrorCode LoadResourceLocationsAsync = 505;
	public const ResourcesUpdateErrorCode GetDownloadSizeAsync = 506;
	public const ResourcesUpdateErrorCode DownloadDependenciesAsync = 507;
}

// Namespace: Framework.ResourcesModule.BundleProvider
public static class AddressableWebrequestOverride // TypeDefIndex: 21288
{
	// Fields
	private static readonly Dictionary<string, string> s_LabelByRequestUrl; // 0x0
	private static readonly Dictionary<string, List<UnityWebRequest>> s_RequestsByLabel; // 0x8
	private static readonly HashSet<string> s_CancelledLabels; // 0x10
	private static readonly List<string> s_TempList; // 0x18
	private static bool s_IsInstalled; // 0x20

	// Methods

	// RVA: 0x41D5670 Offset: 0x41D1670 VA: 0x41D5670
	public static void Init() { }

	// RVA: 0x41D7FF4 Offset: 0x41D3FF4 VA: 0x41D7FF4
	public static void RegisterBundleRequest(string label, IResourceLocation location) { }

	// RVA: 0x41D2B1C Offset: 0x41CEB1C VA: 0x41D2B1C
	public static void RegisterBundleRequests(string label, IList<IResourceLocation> locations) { }

	// RVA: 0x41D3A3C Offset: 0x41CFA3C VA: 0x41D3A3C
	public static int AbortRequests(string label) { }

	// RVA: 0x41D2C98 Offset: 0x41CEC98 VA: 0x41D2C98
	public static void ClearLabel(string label) { }

	// RVA: 0x41D83A0 Offset: 0x41D43A0 VA: 0x41D83A0
	private static void OnWebRequestOverride(UnityWebRequest request) { }

	// RVA: 0x41D80E4 Offset: 0x41D40E4 VA: 0x41D80E4
	private static void RegisterUrl(string label, string url) { }

	// RVA: 0x41D86D0 Offset: 0x41D46D0 VA: 0x41D86D0
	private static string NormalizeUrl(string url) { }

	// RVA: 0x41D8750 Offset: 0x41D4750 VA: 0x41D8750
	private static void .cctor() { }
}

// Namespace: Framework.PurchaseManager
public abstract class BasePurchaseCaches // TypeDefIndex: 21289
{
	// Fields
	public CachesData m_data; // 0x10
	protected bool m_isChecking; // 0x18

	// Methods

	// RVA: 0x41D88F0 Offset: 0x41D48F0 VA: 0x41D88F0
	public void OnInit() { }

	// RVA: 0x41D8AA8 Offset: 0x41D4AA8 VA: 0x41D8AA8
	public void OnDeInit() { }

	// RVA: 0x41D8ACC Offset: 0x41D4ACC VA: 0x41D8ACC Slot: 4
	public virtual void Add(ProductMessageData data) { }

	// RVA: 0x41D8B9C Offset: 0x41D4B9C VA: 0x41D8B9C Slot: 5
	public virtual void Remove(ProductMessageData data) { }

	// RVA: 0x41D8C1C Offset: 0x41D4C1C VA: 0x41D8C1C Slot: 6
	public virtual void Save() { }

	// RVA: 0x41D8CE0 Offset: 0x41D4CE0 VA: 0x41D8CE0
	public void CheckCaches(Action finished) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnCheckNext(Action finished);

	// RVA: 0x41D8D10 Offset: 0x41D4D10 VA: 0x41D8D10
	protected void .ctor() { }
}

// Namespace: Framework.PurchaseManager
public interface IPurchaseManager // TypeDefIndex: 21290
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDeInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetPriceByProductID(string productID);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetIsoCodeForProductID(string productID, string defaultValue = "");

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool GetProductDataForProductID(string productID, out Product product);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Buy(int shopId, int goodsId, int number, MapField<string, string> extraInfo, Action<bool, List<ValueTuple<int, int>>, int> isSuccess, bool isAD = False, string iapType, int activityType = 0, int actId = 0);
}

// Namespace: Framework.PurchaseManager
public class CachesData // TypeDefIndex: 21291
{
	// Fields
	public List<ProductMessageData> m_datas; // 0x10

	// Methods

	// RVA: 0x41D8A20 Offset: 0x41D4A20 VA: 0x41D8A20
	public void .ctor() { }
}

// Namespace: Framework.PurchaseManager
public class ProductMessageData // TypeDefIndex: 21292
{
	// Fields
	public string ProductID; // 0x10
	public string Receipt; // 0x18
	public string PreorderId; // 0x20

	// Methods

	// RVA: 0x41D8D18 Offset: 0x41D4D18 VA: 0x41D8D18
	public void .ctor() { }
}

// Namespace: Framework.PurchaseManager
public class PurchaseManager : MonoBehaviour // TypeDefIndex: 21293
{
	// Fields
	[SerializeField]
	private bool m_isEnable; // 0x20
	private IPurchaseManager m_manager; // 0x28
	private BasePurchaseCaches m_caches; // 0x30

	// Properties
	public bool IsEnable { get; }
	public IPurchaseManager Manager { get; }
	public BasePurchaseCaches Caches { get; }

	// Methods

	// RVA: 0x41D8D20 Offset: 0x41D4D20 VA: 0x41D8D20
	public bool get_IsEnable() { }

	// RVA: 0x41D8D28 Offset: 0x41D4D28 VA: 0x41D8D28
	public IPurchaseManager get_Manager() { }

	// RVA: 0x41D8D30 Offset: 0x41D4D30 VA: 0x41D8D30
	public BasePurchaseCaches get_Caches() { }

	// RVA: 0x41D8D38 Offset: 0x41D4D38 VA: 0x41D8D38
	public void SetManager(IPurchaseManager purchaseManager) { }

	// RVA: 0x41D8D40 Offset: 0x41D4D40 VA: 0x41D8D40
	public void SetCaches(BasePurchaseCaches caches) { }

	// RVA: 0x41D8D48 Offset: 0x41D4D48 VA: 0x41D8D48
	public void OnInit() { }

	// RVA: 0x41D8DFC Offset: 0x41D4DFC VA: 0x41D8DFC
	public void OnDeInit() { }

	// RVA: 0x41D8EDC Offset: 0x41D4EDC VA: 0x41D8EDC
	public string GetPriceForProductID(string productID) { }

	// RVA: 0x41D8FB0 Offset: 0x41D4FB0 VA: 0x41D8FB0
	public void .ctor() { }
}

// Namespace: Framework.PersistentData
public enum GameDbOp // TypeDefIndex: 21294
{
	// Fields
	public int value__; // 0x0
	public const GameDbOp None = 0;
	public const GameDbOp Insert = 1;
	public const GameDbOp Update = 2;
	public const GameDbOp Delete = 3;
	public const GameDbOp UpOrInsert = 4;
}

// Namespace: Framework.PersistentData
public struct GameDbOpCmd // TypeDefIndex: 21295
{
	// Fields
	public GameDbOp op; // 0x0
	public string colName; // 0x8
	public ulong id; // 0x10
	public BsonDocument doc; // 0x18
}

// Namespace: Framework.PersistentData
public class GameDbMgr : Singleton<GameDbMgr> // TypeDefIndex: 21296
{
	// Fields
	private const string EncryptKey = "MKM0Xjw1FLVkz9A1v2Oxud2m9uK9Nux";
	private readonly object _writeLocker; // 0x10
	private static string _localPath; // 0x0
	private static string _filesDir; // 0x8
	private static string _cacheDir; // 0x10
	private static string _externalFilesDir; // 0x18
	private static string _externalCacheDir; // 0x20
	private bool _init; // 0x18
	private bool _requireQuit; // 0x19
	private UltraLiteDatabase _database; // 0x20
	private Dictionary<string, UltraLiteCollection<BsonDocument>> _cacheCollections; // 0x28
	private Queue<GameDbOpCmd> _cmdQueue; // 0x30
	private Thread _writeThread; // 0x38

	// Properties
	private static string DBPath { get; }

	// Methods

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x41D8FB8 Offset: 0x41D4FB8 VA: 0x41D8FB8
	private static void RunOnStart() { }

	// RVA: 0x41D9058 Offset: 0x41D5058 VA: 0x41D9058
	private static void Quit() { }

	// RVA: 0x41D90AC Offset: 0x41D50AC VA: 0x41D90AC
	private static string get_DBPath() { }

	// RVA: 0x41D917C Offset: 0x41D517C VA: 0x41D917C
	private static string GetDataFolder() { }

	// RVA: 0x41D9FD0 Offset: 0x41D5FD0 VA: 0x41D9FD0
	public void Init() { }

	// RVA: 0x41DA25C Offset: 0x41D625C VA: 0x41DA25C
	private void WaitOpQueueEmpty() { }

	// RVA: 0x41DA380 Offset: 0x41D6380 VA: 0x41DA380
	private UltraLiteCollection<BsonDocument> GetCollection(string colName) { }

	// RVA: -1 Offset: -1
	public T GetData<T>(string colName, ulong id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462C688 Offset: 0x4628688 VA: 0x462C688
	|-GameDbMgr.GetData<object>
	|
	|-RVA: 0x462C9F4 Offset: 0x46289F4 VA: 0x462C9F4
	|-GameDbMgr.GetData<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41DA44C Offset: 0x41D644C VA: 0x41DA44C
	public bool ExistData(string colName, ulong id) { }

	// RVA: 0x41DA640 Offset: 0x41D6640 VA: 0x41DA640
	public void SaveData(Type type, object data, string colName, ulong id) { }

	// RVA: -1 Offset: -1
	public void SaveData<T>(T data, string colName, ulong id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x462CE04 Offset: 0x4628E04 VA: 0x462CE04
	|-GameDbMgr.SaveData<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41DA184 Offset: 0x41D6184 VA: 0x41DA184
	private void StartWriteThread() { }

	// RVA: 0x41DA86C Offset: 0x41D686C VA: 0x41DA86C
	private void ExitWriteThread() { }

	// RVA: 0x41DA950 Offset: 0x41D6950 VA: 0x41DA950
	public void DropAllCollection() { }

	// RVA: 0x41DAA10 Offset: 0x41D6A10 VA: 0x41DAA10
	public void .ctor() { }

	// RVA: 0x41DAA98 Offset: 0x41D6A98 VA: 0x41DAA98
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x41DAB08 Offset: 0x41D6B08 VA: 0x41DAB08
	private void <StartWriteThread>b__25_0() { }
}

// Namespace: Framework.PersistentData
public abstract class PersistentDataBase // TypeDefIndex: 21297
{
	// Fields
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x10
	[BsonIgnore]
	public ulong UserId; // 0x18

	// Properties
	[BsonIgnore]
	public bool IsDirty { get; set; }
	[BsonIgnore]
	public abstract string CollectionName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41DAEE0 Offset: 0x41D6EE0 VA: 0x41DAEE0
	private void set_IsDirty(bool value) { }

	[CompilerGenerated]
	// RVA: 0x41DAEEC Offset: 0x41D6EEC VA: 0x41DAEEC
	public bool get_IsDirty() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_CollectionName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnCreate();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnInit();

	// RVA: 0x41DAEF4 Offset: 0x41D6EF4 VA: 0x41DAEF4
	public void Dirty() { }

	// RVA: 0x41DAF00 Offset: 0x41D6F00 VA: 0x41DAF00
	public void SaveData() { }

	// RVA: 0x41DAF8C Offset: 0x41D6F8C VA: 0x41DAF8C
	protected void .ctor() { }
}

// Namespace: Framework.PersistentData
public class PersistentDataManager : MonoBehaviour // TypeDefIndex: 21298
{
	// Fields
	private const float LocalSaveInterval = 0.1;
	private readonly Dictionary<string, PersistentDataBase> _localSaveDic; // 0x20
	private float _tickTime; // 0x28
	private ulong _userId; // 0x30

	// Properties
	public ulong UserId { get; }

	// Methods

	// RVA: 0x41DAF94 Offset: 0x41D6F94 VA: 0x41DAF94
	public void OnInit() { }

	// RVA: 0x41DAFEC Offset: 0x41D6FEC VA: 0x41DAFEC
	public void SetUserId(ulong userId) { }

	// RVA: 0x41DAFF4 Offset: 0x41D6FF4 VA: 0x41DAFF4
	public ulong get_UserId() { }

	// RVA: 0x41DAFFC Offset: 0x41D6FFC VA: 0x41DAFFC
	public void OnUpdate(float deltaTime) { }

	// RVA: 0x41DB194 Offset: 0x41D7194 VA: 0x41DB194
	private void AddData(string dataName, PersistentDataBase data) { }

	// RVA: -1 Offset: -1
	public T GetData<T>(string dataName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468FDD8 Offset: 0x468BDD8 VA: 0x468FDD8
	|-PersistentDataManager.GetData<object>
	*/

	// RVA: 0x41DB328 Offset: 0x41D7328 VA: 0x41DB328
	public void Reset() { }

	// RVA: 0x41DB380 Offset: 0x41D7380 VA: 0x41DB380
	public void OnDeInit() { }

	// RVA: 0x41DB3D0 Offset: 0x41D73D0 VA: 0x41DB3D0
	public void SaveAll() { }

	// RVA: -1 Offset: -1
	public T RegisterLocalData<T>(string collectionName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468FEBC Offset: 0x468BEBC VA: 0x468FEBC
	|-PersistentDataManager.RegisterLocalData<object>
	*/

	// RVA: 0x41DB534 Offset: 0x41D7534 VA: 0x41DB534
	public void RemoveLocalData(string collectionName) { }

	// RVA: 0x41DB5C4 Offset: 0x41D75C4 VA: 0x41DB5C4
	public void .ctor() { }
}

// Namespace: Framework.NetWork
public interface INetWorkManager // TypeDefIndex: 21299
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetData(string url, int version, NetWorkUsingType usingType);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsNetConnect();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerator SendWebRequest(NetWorkSendData data, int tryTime = 0);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void HandleCommonData(IMessage msg);
}

// Namespace: Framework.NetWork
public class NetWorkManager : MonoBehaviour // TypeDefIndex: 21300
{
	// Fields
	public GameNetWorkSwitchConfig networkSwitchConfig; // 0x20
	public NetWorkUsingType m_netWorkUsingType; // 0x28
	[Label]
	[SerializeField]
	private string m_url; // 0x30
	public string m_account; // 0x38
	public string m_deviceID; // 0x40
	public string m_account2; // 0x48
	public string m_userID; // 0x50
	public string m_verification; // 0x58
	private const int m_version = 3;
	public long m_transId; // 0x60
	public int m_serverID; // 0x68
	private INetWorkManager m_networkManager; // 0x70
	public static readonly ServerInfo[] ServerInfoDropdownInfos; // 0x0

	// Properties
	public string Url { get; }
	public string ImWsUrl { get; }
	public string GCServerUrl { get; }
	public string GCServiceToken { get; }
	public string GCFeedBackUrl { get; }
	public bool UseChinaServer { get; }
	public int Version { get; }
	public bool IsNetConnect { get; }

	// Methods

	// RVA: 0x41DB64C Offset: 0x41D764C VA: 0x41DB64C
	public void SetNetworkManager(INetWorkManager netWorkManager) { }

	// RVA: 0x41DB95C Offset: 0x41D795C VA: 0x41DB95C
	public string get_Url() { }

	// RVA: 0x41DBD00 Offset: 0x41D7D00 VA: 0x41DBD00
	public void ClearCachedUrl() { }

	// RVA: 0x41DBD54 Offset: 0x41D7D54 VA: 0x41DBD54
	public string get_ImWsUrl() { }

	// RVA: 0x41DBE68 Offset: 0x41D7E68 VA: 0x41DBE68
	public string get_GCServerUrl() { }

	// RVA: 0x41DBF4C Offset: 0x41D7F4C VA: 0x41DBF4C
	public string get_GCServiceToken() { }

	// RVA: 0x41DC030 Offset: 0x41D8030 VA: 0x41DC030
	public string get_GCFeedBackUrl() { }

	// RVA: 0x41DBB00 Offset: 0x41D7B00 VA: 0x41DBB00
	public bool get_UseChinaServer() { }

	// RVA: 0x41DC114 Offset: 0x41D8114 VA: 0x41DC114
	public int get_Version() { }

	// RVA: 0x41DC11C Offset: 0x41D811C VA: 0x41DC11C
	public bool get_IsNetConnect() { }

	// RVA: 0x41DC1CC Offset: 0x41D81CC VA: 0x41DC1CC
	public void SetTransID(long transid) { }

	// RVA: 0x41DC1D4 Offset: 0x41D81D4 VA: 0x41DC1D4
	public void Send(IMessage message, Action<int, IMessage, IMessage> callBack, bool isShowMask, bool isCache, string key, bool isShowError = True) { }

	// RVA: 0x41DC44C Offset: 0x41D844C VA: 0x41DC44C
	public void HandleCommonData(IMessage msg) { }

	// RVA: 0x41DBC3C Offset: 0x41D7C3C VA: 0x41DBC3C
	private ServerInfo GetCurrentDebugServerInfo() { }

	// RVA: 0x41DB754 Offset: 0x41D7754 VA: 0x41DB754
	private void LogNetworkConfig(string context) { }

	// RVA: 0x41DC5B8 Offset: 0x41D85B8 VA: 0x41DC5B8
	private static string FormatServerInfo(ServerInfo info) { }

	// RVA: 0x41DC62C Offset: 0x41D862C VA: 0x41DC62C
	public void .ctor() { }

	// RVA: 0x41DC71C Offset: 0x41D871C VA: 0x41DC71C
	private static void .cctor() { }
}

// Namespace: Framework.NetWork
public class NetWorkSendData // TypeDefIndex: 21301
{
	// Fields
	public IMessage m_message; // 0x10
	public Action<int, IMessage, IMessage> m_callBack; // 0x18
	public bool m_isShowMask; // 0x20
	public bool m_isCache; // 0x21
	public bool m_isShowError; // 0x22
	public string m_key; // 0x28

	// Methods

	// RVA: 0x41DC3CC Offset: 0x41D83CC VA: 0x41DC3CC
	public void Clear() { }

	// RVA: 0x41DC3BC Offset: 0x41D83BC VA: 0x41DC3BC
	public void .ctor() { }
}

// Namespace: Framework.NetWork
public enum NetWorkUsingType // TypeDefIndex: 21302
{
	// Fields
	public int value__; // 0x0
	public const NetWorkUsingType Debug = 1;
	public const NetWorkUsingType PreRelease = 2;
	public const NetWorkUsingType Release = 3;
}

// Namespace: Framework.NetWork
[Extension]
public static class NetWorkUsingTypeExtensions // TypeDefIndex: 21303
{
	// Methods

	[Extension]
	// RVA: 0x41DC79C Offset: 0x41D879C VA: 0x41DC79C
	public static bool IsReleaseServer(NetWorkUsingType type) { }
}

// Namespace: Framework.NetWork
public class ProtocolRateLimiter // TypeDefIndex: 21304
{
	// Fields
	private readonly TimeSpan _interval; // 0x10
	private readonly int _maxCount; // 0x18
	private readonly Queue<DateTime> timestamps; // 0x20
	private Type _messageType; // 0x28
	private Dictionary<string, object> _dicTemp; // 0x30

	// Methods

	// RVA: 0x41DC7A8 Offset: 0x41D87A8 VA: 0x41DC7A8
	public void .ctor(TimeSpan interval, int maxCount, Type messageType) { }

	// RVA: 0x41DC8B0 Offset: 0x41D88B0 VA: 0x41DC8B0
	public bool Record() { }

	// RVA: 0x41DCB30 Offset: 0x41D8B30 VA: 0x41DCB30
	private void TriggerAlarm() { }
}

// Namespace: Framework.NetWork
public class ProtocolRateLimiterManager : Singleton<ProtocolRateLimiterManager> // TypeDefIndex: 21305
{
	// Fields
	private readonly TimeSpan _interval; // 0x10
	private readonly int _maxCount; // 0x18
	private Dictionary<Type, ProtocolRateLimiter> _rateLimiters; // 0x20

	// Methods

	// RVA: 0x41DCC68 Offset: 0x41D8C68 VA: 0x41DCC68
	public bool Record(Type messageType) { }

	// RVA: 0x41DCD70 Offset: 0x41D8D70 VA: 0x41DCD70
	public void .ctor() { }
}

// Namespace: Framework.MobileNotification
public interface IMobileNotificationManager // TypeDefIndex: 21306
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDeInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ScheduleAllNotifications();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CancelAllNotifications();
}

// Namespace: Framework.MobileNotification
public class MobileNotificationHost : MonoBehaviour // TypeDefIndex: 21307
{
	// Fields
	private IMobileNotificationManager m_manager; // 0x20
	public const string AndroidChannelId = "game_default_channel";

	// Methods

	// RVA: 0x41DCE48 Offset: 0x41D8E48 VA: 0x41DCE48
	public void SetManager(IMobileNotificationManager manager) { }

	// RVA: 0x41DCE50 Offset: 0x41D8E50 VA: 0x41DCE50
	public void OnInit() { }

	// RVA: 0x41DCEF8 Offset: 0x41D8EF8 VA: 0x41DCEF8
	public void OnDeInit() { }

	// RVA: 0x41DCFA8 Offset: 0x41D8FA8 VA: 0x41DCFA8
	public void ScheduleAllNotifications() { }

	// RVA: 0x41DD054 Offset: 0x41D9054 VA: 0x41DD054
	public void CancelAllNotifications() { }

	// RVA: 0x41DD100 Offset: 0x41D9100 VA: 0x41DD100
	public void InitializeAllNotifications() { }

	// RVA: 0x41DD104 Offset: 0x41D9104 VA: 0x41DD104
	private void InitializeAndroid() { }

	// RVA: 0x41DD234 Offset: 0x41D9234 VA: 0x41DD234
	private void RequestAndroidNotificationPermission() { }

	// RVA: 0x41DD294 Offset: 0x41D9294 VA: 0x41DD294
	public void .ctor() { }
}

// Namespace: Framework.MailManager
public interface IMailManager // TypeDefIndex: 21308
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetData(string version, string url);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDeInit();
}

// Namespace: Framework.MailManager
public class MailManager : MonoBehaviour // TypeDefIndex: 21309
{
	// Fields
	[SerializeField]
	private bool m_isEnable; // 0x20
	private IMailManager m_manager; // 0x28

	// Properties
	public bool IsEnable { get; }
	public IMailManager Manager { get; }

	// Methods

	// RVA: 0x41DD29C Offset: 0x41D929C VA: 0x41DD29C
	public bool get_IsEnable() { }

	// RVA: 0x41DD2A4 Offset: 0x41D92A4 VA: 0x41DD2A4
	public void SetManager(IMailManager manager) { }

	// RVA: 0x41DD380 Offset: 0x41D9380 VA: 0x41DD380
	public IMailManager get_Manager() { }

	// RVA: 0x41DD388 Offset: 0x41D9388 VA: 0x41DD388
	public void OnInit() { }

	// RVA: 0x41DD434 Offset: 0x41D9434 VA: 0x41DD434
	public void OnDeInit() { }

	// RVA: 0x41DD4E4 Offset: 0x41D94E4 VA: 0x41DD4E4
	public void .ctor() { }
}

// Namespace: Framework.MailManager
public enum MailServerType // TypeDefIndex: 21310
{
	// Fields
	public int value__; // 0x0
	public const MailServerType Debug = 0;
	public const MailServerType Release = 1;
}

// Namespace: Framework.Interface
public interface IAgent<T> // TypeDefIndex: 21311
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T CurrentTask();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAgent<__Il2CppFullySharedGenericType>.CurrentTask
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddTask(T task);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAgent<__Il2CppFullySharedGenericType>.AddTask
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnUpdate(float deltaTime, float unscaledDeltaTime);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAgent<__Il2CppFullySharedGenericType>.OnUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RemoveTask();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAgent<__Il2CppFullySharedGenericType>.RemoveTask
	*/
}

// Namespace: Framework.Interface
public interface ITask // TypeDefIndex: 21312
{}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnDownloadFile>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21313
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public string downloadFilePathAndName; // 0x28
	public Action<UnityWebRequest> actionResult; // 0x30
	private UnityWebRequest <uwr>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDA1C Offset: 0x41D9A1C VA: 0x41DDA1C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DDB14 Offset: 0x41D9B14 VA: 0x41DDB14 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DDB18 Offset: 0x41D9B18 VA: 0x41DDB18 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41DDC60 Offset: 0x41D9C60 VA: 0x41DDC60 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DDC68 Offset: 0x41D9C68 VA: 0x41DDC68 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DDCA0 Offset: 0x41D9CA0 VA: 0x41DDCA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnGet>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21314
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public Action<UnityWebRequest> actionResult; // 0x28
	private UnityWebRequest <uwr>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DD9F4 Offset: 0x41D99F4 VA: 0x41DD9F4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DDCA8 Offset: 0x41D9CA8 VA: 0x41DDCA8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DDCC4 Offset: 0x41D9CC4 VA: 0x41DDCC4 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x41DDE08 Offset: 0x41D9E08 VA: 0x41DDE08
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x41DDEB8 Offset: 0x41D9EB8 VA: 0x41DDEB8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DDEC0 Offset: 0x41D9EC0 VA: 0x41DDEC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DDEF8 Offset: 0x41D9EF8 VA: 0x41DDEF8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnGetAssetBundle>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21315
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public Action<AssetBundle> actionResult; // 0x28
	private UnityWebRequest <www>5__2; // 0x30
	private DownloadHandlerAssetBundle <handler>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDA6C Offset: 0x41D9A6C VA: 0x41DDA6C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DDF00 Offset: 0x41D9F00 VA: 0x41DDF00 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DDF04 Offset: 0x41D9F04 VA: 0x41DDF04 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41DE088 Offset: 0x41DA088 VA: 0x41DE088 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DE090 Offset: 0x41DA090 VA: 0x41DE090 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DE0C8 Offset: 0x41DA0C8 VA: 0x41DE0C8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnGetAudioClip>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21316
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public AudioType audioType; // 0x28
	public Action<AudioClip> actionResult; // 0x30
	private UnityWebRequest <uwr>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDA94 Offset: 0x41D9A94 VA: 0x41DDA94
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DE0D0 Offset: 0x41DA0D0 VA: 0x41DE0D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DE0EC Offset: 0x41DA0EC VA: 0x41DE0EC Slot: 6
	private bool MoveNext() { }

	// RVA: 0x41DE26C Offset: 0x41DA26C VA: 0x41DE26C
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x41DE31C Offset: 0x41DA31C VA: 0x41DE31C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DE324 Offset: 0x41DA324 VA: 0x41DE324 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DE35C Offset: 0x41DA35C VA: 0x41DE35C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnGetTexture>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21317
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public Action<Texture2D> actionResult; // 0x28
	private UnityWebRequest <uwr>5__2; // 0x30
	private DownloadHandlerTexture <downloadTexture>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDA44 Offset: 0x41D9A44 VA: 0x41DDA44
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DE364 Offset: 0x41DA364 VA: 0x41DE364 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DE368 Offset: 0x41DA368 VA: 0x41DE368 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41DE4D0 Offset: 0x41DA4D0 VA: 0x41DE4D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DE4D8 Offset: 0x41DA4D8 VA: 0x41DE4D8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DE510 Offset: 0x41DA510 VA: 0x41DE510 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnPost>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21318
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string serverURL; // 0x20
	public List<IMultipartFormSection> lstformData; // 0x28
	public Action<UnityWebRequest> actionResult; // 0x30
	private UnityWebRequest <uwr>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDABC Offset: 0x41D9ABC VA: 0x41DDABC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DE518 Offset: 0x41DA518 VA: 0x41DE518 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DE51C Offset: 0x41DA51C VA: 0x41DE51C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41DE5C4 Offset: 0x41DA5C4 VA: 0x41DE5C4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DE5CC Offset: 0x41DA5CC VA: 0x41DE5CC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DE604 Offset: 0x41DA604 VA: 0x41DE604 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpManager.<OnUploadByPut>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21319
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public byte[] contentBytes; // 0x20
	public string contentType; // 0x28
	public Action<bool> actionResult; // 0x30
	private UnityWebRequest <uwr>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x41DDAE4 Offset: 0x41D9AE4 VA: 0x41DDAE4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x41DE60C Offset: 0x41DA60C VA: 0x41DE60C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x41DE610 Offset: 0x41DA610 VA: 0x41DE610 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x41DE760 Offset: 0x41DA760 VA: 0x41DE760 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x41DE768 Offset: 0x41DA768 VA: 0x41DE768 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x41DE7A0 Offset: 0x41DA7A0 VA: 0x41DE7A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Framework.Http
public class HttpManager : MonoBehaviour // TypeDefIndex: 21320
{
	// Methods

	// RVA: 0x41D0AD8 Offset: 0x41CCAD8 VA: 0x41D0AD8
	public void Get(string url, Action<UnityWebRequest> actionResult) { }

	// RVA: 0x41DD574 Offset: 0x41D9574 VA: 0x41DD574
	public void DownloadFile(string url, string downloadFilePathAndName, Action<UnityWebRequest> actionResult) { }

	// RVA: 0x41DD630 Offset: 0x41D9630 VA: 0x41DD630
	public void GetTexture(string url, Action<Texture2D> actionResult) { }

	// RVA: 0x41DD6D8 Offset: 0x41D96D8 VA: 0x41DD6D8
	public void GetAssetBundle(string url, Action<AssetBundle> actionResult) { }

	// RVA: 0x41DD780 Offset: 0x41D9780 VA: 0x41DD780
	public void GetAudioClip(string url, Action<AudioClip> actionResult, AudioType audioType = 20) { }

	// RVA: 0x41DD830 Offset: 0x41D9830 VA: 0x41DD830
	public void Post(string serverURL, List<IMultipartFormSection> lstformData, Action<UnityWebRequest> actionResult) { }

	// RVA: 0x41DD8EC Offset: 0x41D98EC VA: 0x41DD8EC
	public void UploadByPut(string url, byte[] contentBytes, Action<bool> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnGet>d__7))]
	// RVA: 0x41DD4EC Offset: 0x41D94EC VA: 0x41DD4EC
	private IEnumerator OnGet(string url, Action<UnityWebRequest> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnDownloadFile>d__8))]
	// RVA: 0x41DD594 Offset: 0x41D9594 VA: 0x41DD594
	private IEnumerator OnDownloadFile(string url, string downloadFilePathAndName, Action<UnityWebRequest> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnGetTexture>d__9))]
	// RVA: 0x41DD650 Offset: 0x41D9650 VA: 0x41DD650
	private IEnumerator OnGetTexture(string url, Action<Texture2D> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnGetAssetBundle>d__10))]
	// RVA: 0x41DD6F8 Offset: 0x41D96F8 VA: 0x41DD6F8
	private IEnumerator OnGetAssetBundle(string url, Action<AssetBundle> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnGetAudioClip>d__11))]
	// RVA: 0x41DD7A0 Offset: 0x41D97A0 VA: 0x41DD7A0
	private IEnumerator OnGetAudioClip(string url, Action<AudioClip> actionResult, AudioType audioType = 20) { }

	[IteratorStateMachine(typeof(HttpManager.<OnPost>d__12))]
	// RVA: 0x41DD850 Offset: 0x41D9850 VA: 0x41DD850
	private IEnumerator OnPost(string serverURL, List<IMultipartFormSection> lstformData, Action<UnityWebRequest> actionResult) { }

	[IteratorStateMachine(typeof(HttpManager.<OnUploadByPut>d__13))]
	// RVA: 0x41DD958 Offset: 0x41D9958 VA: 0x41DD958
	private IEnumerator OnUploadByPut(string url, byte[] contentBytes, Action<bool> actionResult, string contentType = "application/octet-stream") { }

	// RVA: 0x41DDB0C Offset: 0x41D9B0C VA: 0x41DDB0C
	public void .ctor() { }
}

// Namespace: Framework.HabbyTimerManager
public class HabbyTimer : MonoBehaviour // TypeDefIndex: 21321
{
	// Fields
	private static int mTimerId; // 0x0
	private static Dictionary<int, HabbyTimer> mTimersDict; // 0x8
	private static Dictionary<int, HabbyTimer> mTempDict; // 0x10
	private static List<int> mTempList; // 0x18
	private static Stack<HabbyTimer> mReusable; // 0x20
	public static int MAXIMUM_REUSABLE_COUNT; // 0x28
	protected static HabbyTimer _instance; // 0x30
	[CompilerGenerated]
	private bool <Active>k__BackingField; // 0x20
	private Action<int> OnTrigger; // 0x28
	private int mId; // 0x30
	private float mInterval; // 0x34
	private int mTotlaCount; // 0x38
	private int mCount; // 0x3C
	private float mTime; // 0x40
	private float mTimeScale; // 0x44

	// Properties
	public static HabbyTimer Instance { get; }
	internal bool Active { get; set; }

	// Methods

	// RVA: 0x41DE7A8 Offset: 0x41DA7A8 VA: 0x41DE7A8
	public static HabbyTimer get_Instance() { }

	// RVA: 0x41DEA4C Offset: 0x41DAA4C VA: 0x41DEA4C
	private void Update() { }

	// RVA: 0x41DEAD8 Offset: 0x41DAAD8 VA: 0x41DEAD8
	private static void Loop(float aDeltaTime) { }

	[CompilerGenerated]
	// RVA: 0x41DF508 Offset: 0x41DB508 VA: 0x41DF508
	internal bool get_Active() { }

	[CompilerGenerated]
	// RVA: 0x41DF510 Offset: 0x41DB510 VA: 0x41DF510
	private void set_Active(bool value) { }

	// RVA: 0x41DF51C Offset: 0x41DB51C VA: 0x41DF51C
	private static HabbyTimer Get(int aTimerId) { }

	// RVA: 0x41DF648 Offset: 0x41DB648 VA: 0x41DF648
	public int Execute(Action<int> TimerAction, float aInterval, int aCount = 1, bool aExecuteNow = False, float aTimeScale = 1) { }

	// RVA: 0x41DF89C Offset: 0x41DB89C VA: 0x41DF89C
	public static void Cancel(int aTimerId) { }

	// RVA: 0x41DFAA4 Offset: 0x41DBAA4 VA: 0x41DFAA4
	public static void SetTimeScale(int aTimerId, float aTimeScale) { }

	// RVA: 0x41DFBDC Offset: 0x41DBBDC VA: 0x41DFBDC
	private bool IntervalStep(float aDeltaTime) { }

	// RVA: 0x41DF374 Offset: 0x41DB374 VA: 0x41DF374
	internal void Step(float aDeltaTime) { }

	// RVA: 0x41DF764 Offset: 0x41DB764 VA: 0x41DF764
	internal void Trigger(int count) { }

	// RVA: 0x41DF9B8 Offset: 0x41DB9B8 VA: 0x41DF9B8
	internal void Cancel() { }

	// RVA: 0x41DFBCC Offset: 0x41DBBCC VA: 0x41DFBCC
	internal void SetTimeScale(float aTimeScale) { }

	// RVA: 0x41DF3D4 Offset: 0x41DB3D4 VA: 0x41DF3D4
	internal static void Truncate() { }

	// RVA: 0x41DFC10 Offset: 0x41DBC10 VA: 0x41DFC10
	internal static void Clear() { }

	// RVA: 0x41DF638 Offset: 0x41DB638 VA: 0x41DF638
	public void .ctor() { }

	// RVA: 0x41DFEFC Offset: 0x41DBEFC VA: 0x41DFEFC
	private static void .cctor() { }
}

// Namespace: Framework.HabbyTimerManager
public class MainThreadTaskQueue // TypeDefIndex: 21322
{
	// Fields
	private static readonly Queue<Action> tasks; // 0x0
	private static readonly object queueLock; // 0x8

	// Methods

	// RVA: 0x41E0090 Offset: 0x41DC090 VA: 0x41E0090
	public static void EnqueueTask(Action action) { }

	// RVA: 0x41DF08C Offset: 0x41DB08C VA: 0x41DF08C
	public static void ExecuteTasks() { }

	// RVA: 0x41E01CC Offset: 0x41DC1CC VA: 0x41E01CC
	public void .ctor() { }

	// RVA: 0x41E01D4 Offset: 0x41DC1D4 VA: 0x41E01D4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FullScreenWebView.<>c__DisplayClass22_0 // TypeDefIndex: 21323
{
	// Fields
	public Action<string> onSuccess; // 0x10

	// Methods

	// RVA: 0x41E1000 Offset: 0x41DD000 VA: 0x41E1000
	public void .ctor() { }

	// RVA: 0x41E14E8 Offset: 0x41DD4E8 VA: 0x41E14E8
	internal void <EvaluateJavaScript>b__0(UniWebViewNativeResultPayload payload) { }
}

// Namespace: Framework.HabbyWebview
public class FullScreenWebView // TypeDefIndex: 21324
{
	// Fields
	protected HabbyWebviewWindowUI _webviewWindowUI; // 0x10
	private readonly string webviewPrefabPath; // 0x18
	protected UniWebView webView; // 0x20
	protected string loadedWebUrl; // 0x28
	protected string tryloadUrl; // 0x30
	protected string webViewObjName; // 0x38
	protected bool mIsMaskMode; // 0x40
	protected int webviewFrameWidth; // 0x44
	protected int webviewFrameTopAndBottomSpace; // 0x48
	protected bool _isLoaded; // 0x4C
	protected int _timer; // 0x50

	// Methods

	// RVA: 0x41E02A8 Offset: 0x41DC2A8 VA: 0x41E02A8
	public void .ctor() { }

	// RVA: 0x41E032C Offset: 0x41DC32C VA: 0x41E032C
	protected GameObject FullScreenWebMode() { }

	// RVA: 0x41E0384 Offset: 0x41DC384 VA: 0x41E0384
	protected GameObject FullScreenMaskWebMode() { }

	// RVA: 0x41E03DC Offset: 0x41DC3DC VA: 0x41E03DC
	protected void HideWebviewObj() { }

	// RVA: 0x41E0424 Offset: 0x41DC424 VA: 0x41E0424
	protected void StartOutTimer(float time) { }

	// RVA: 0x41E04F4 Offset: 0x41DC4F4 VA: 0x41E04F4
	public static string GetValueFromMessageByKey(UniWebViewMessage message, string key) { }

	// RVA: 0x41E05F4 Offset: 0x41DC5F4 VA: 0x41E05F4
	public static int GetIntFromMessageByKey(UniWebViewMessage message, string key) { }

	// RVA: 0x41E0718 Offset: 0x41DC718 VA: 0x41E0718
	public static string GetNewValueIfNotEmpty(string str, string value) { }

	// RVA: 0x41E0748 Offset: 0x41DC748 VA: 0x41E0748
	public void InitWebView() { }

	// RVA: 0x41E0D4C Offset: 0x41DCD4C VA: 0x41E0D4C Slot: 4
	public virtual void ShowWebView() { }

	// RVA: 0x41E0E00 Offset: 0x41DCE00 VA: 0x41E0E00 Slot: 5
	public virtual void HideWebView() { }

	// RVA: 0x41E0EE0 Offset: 0x41DCEE0 VA: 0x41E0EE0
	public void EvaluateJavaScript(string jsCode, Action<string> onSuccess) { }

	// RVA: 0x41E1008 Offset: 0x41DD008 VA: 0x41E1008 Slot: 6
	public virtual void OnPageFinished(UniWebView view, int statusCode, string url) { }

	// RVA: 0x41E101C Offset: 0x41DD01C VA: 0x41E101C Slot: 7
	public virtual bool OnShouldClose(UniWebView view) { }

	// RVA: 0x41E1024 Offset: 0x41DD024 VA: 0x41E1024 Slot: 8
	public virtual void OnMessageReceived(UniWebView view, UniWebViewMessage message) { }

	// RVA: 0x41E1028 Offset: 0x41DD028 VA: 0x41E1028 Slot: 9
	public virtual void OnPageErrorReceived(UniWebView webView, int errorCode, string errorMessage) { }

	// RVA: 0x41E10E0 Offset: 0x41DD0E0 VA: 0x41E10E0
	public void Restart() { }

	// RVA: 0x41E1164 Offset: 0x41DD164 VA: 0x41E1164
	public void CleanCache() { }

	// RVA: 0x41E11E4 Offset: 0x41DD1E4 VA: 0x41E11E4 Slot: 10
	public virtual void Clean() { }

	[CompilerGenerated]
	// RVA: 0x41E14D0 Offset: 0x41DD4D0 VA: 0x41E14D0
	private void <StartOutTimer>b__15_0(int time) { }
}

// Namespace: 
[Serializable]
public class GameFeedbackWebview.PlayerInfo // TypeDefIndex: 21325
{
	// Fields
	public string serveruserid; // 0x10
	public string serveruseridsub; // 0x18
	public string uuid; // 0x20
	public string platform; // 0x28
	public string sdklogintype; // 0x30
	public string sdkloginid; // 0x38
	public string devicemodel; // 0x40
	public int memorysize; // 0x48
	public string appversion; // 0x50
	public string operationsystem; // 0x58
	public string graphicsDeviceName; // 0x60
	public string nettype; // 0x68
	public string tga_deviceid; // 0x70
	public string tga_distinctid; // 0x78
	public string ip; // 0x80
	public string packageName; // 0x88

	// Methods

	// RVA: 0x41E1B10 Offset: 0x41DDB10 VA: 0x41E1B10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GameFeedbackWebview.<>c // TypeDefIndex: 21326
{
	// Fields
	public static readonly GameFeedbackWebview.<>c <>9; // 0x0
	public static Action<UniWebViewNativeResultPayload> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x41E1EBC Offset: 0x41DDEBC VA: 0x41E1EBC
	private static void .cctor() { }

	// RVA: 0x41E1F24 Offset: 0x41DDF24 VA: 0x41E1F24
	public void .ctor() { }

	// RVA: 0x41E1F2C Offset: 0x41DDF2C VA: 0x41E1F2C
	internal void <OnPageFinished>b__9_0(UniWebViewNativeResultPayload response) { }
}

// Namespace: Framework.HabbyWebview
public class GameFeedbackWebview : FullScreenWebView // TypeDefIndex: 21327
{
	// Fields
	public Action<bool> OnClose; // 0x58
	private bool mDisposed; // 0x60
	protected int _keyTimer; // 0x64

	// Methods

	// RVA: 0x41E1604 Offset: 0x41DD604 VA: 0x41E1604
	public void .ctor(string url) { }

	// RVA: 0x41E1638 Offset: 0x41DD638 VA: 0x41E1638
	public void Show() { }

	// RVA: 0x41E1670 Offset: 0x41DD670 VA: 0x41E1670
	private void StartBackKeyCheck() { }

	// RVA: 0x41E1748 Offset: 0x41DD748 VA: 0x41E1748
	private void RemoveBackCheckTimer() { }

	// RVA: 0x41E17B0 Offset: 0x41DD7B0 VA: 0x41E17B0
	public static string GetPlayerInfo() { }

	// RVA: 0x41E1B18 Offset: 0x41DDB18 VA: 0x41E1B18 Slot: 6
	public override void OnPageFinished(UniWebView view, int statusCode, string url) { }

	// RVA: 0x41E1CE8 Offset: 0x41DDCE8 VA: 0x41E1CE8 Slot: 9
	public override void OnPageErrorReceived(UniWebView webView, int errorCode, string errorMessage) { }

	// RVA: 0x41E1D28 Offset: 0x41DDD28 VA: 0x41E1D28 Slot: 8
	public override void OnMessageReceived(UniWebView view, UniWebViewMessage message) { }

	// RVA: 0x41E1DCC Offset: 0x41DDDCC VA: 0x41E1DCC Slot: 10
	public override void Clean() { }

	[CompilerGenerated]
	// RVA: 0x41E1DF0 Offset: 0x41DDDF0 VA: 0x41E1DF0
	private void <StartBackKeyCheck>b__5_0(int time) { }
}

// Namespace: Framework.HabbyWebview
public class HabbyWebviewWindowUI : MonoBehaviour // TypeDefIndex: 21328
{
	// Fields
	public GameObject customWebviewObj; // 0x20
	public GameObject customWebviewObjMask; // 0x28
	public GameObject customWebviewObjFullScreen; // 0x30
	public int defaultTopAndButtom; // 0x38

	// Methods

	// RVA: 0x41E2104 Offset: 0x41DE104 VA: 0x41E2104
	public void .ctor() { }
}

// Namespace: Framework.HabbyWebview
public class WebViewConst // TypeDefIndex: 21329
{
	// Fields
	public const string AgePolicy_CN = "https://h5-survivorio.lezuan.net/login/index.html?page=suitable";
	public const string OfficePolicy_CN = "https://h5-survivorio.lezuan.net/login/index.html?page=agreement&isSure=1";
	public const string PrivacyPolicy_CN = "https://h5-survivorio.lezuan.net/agreement/index.html";
	public const string H5_CHOOSE = "https://h5-survivorio.lezuan.net/login/index.html";
	public const string H5_PHONE = "https://h5-survivorio.lezuan.net/login/index.html?page=phone";
	public const string feed_back = "https://feedback-danke.lezuan.net";

	// Methods

	// RVA: 0x41E210C Offset: 0x41DE10C VA: 0x41E210C
	public void .ctor() { }
}

// Namespace: Framework.GameAppConfig
public class GameAppConfigManager : MonoBehaviour // TypeDefIndex: 21330
{
	// Fields
	[SerializeField]
	private GameAppConfigData m_gameAppConfigData; // 0x20

	// Methods

	// RVA: 0x41D050C Offset: 0x41CC50C VA: 0x41D050C
	public bool GetBool(string key) { }

	// RVA: 0x41CF29C Offset: 0x41CB29C VA: 0x41CF29C
	public int GetInt(string key) { }

	// RVA: 0x41DC500 Offset: 0x41D8500 VA: 0x41DC500
	public string GetString(string key) { }

	// RVA: 0x41E2114 Offset: 0x41DE114 VA: 0x41E2114
	public void .ctor() { }
}

// Namespace: Framework.GameAppConfig
public class GameAppConfigNames // TypeDefIndex: 21331
{
	// Fields
	public const string Version = "Version";
	public const string VersionCode = "VersionCode";
	public const string DisplayVersion = "DisplayVersion";
	public const string ServerType = "ServerType";
	public const string CdnType = "CdnType";
	public const string IsBuildIn = "IsBuildIn";
	public const string IsLoadHost = "IsLoadHost";
	public const string ChannelName = "ChannelName";
	public const string IsCNServer = "IsCNServer";
	public const string IsSpilitPackage = "IsSpilitPackage";

	// Methods

	// RVA: 0x41E211C Offset: 0x41DE11C VA: 0x41E211C
	public void .ctor() { }
}

// Namespace: Framework.EventSystem
public abstract class BaseEventArgs // TypeDefIndex: 21332
{
	// Fields
	private EventPool _pool; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: 0x41E2124 Offset: 0x41DE124 VA: 0x41E2124
	public void SetPool(EventPool pool) { }

	// RVA: 0x41E212C Offset: 0x41DE12C VA: 0x41E212C
	public void Release() { }

	// RVA: 0x41E2170 Offset: 0x41DE170 VA: 0x41E2170
	protected void .ctor() { }
}

// Namespace: Framework.EventSystem
public abstract class EventPool // TypeDefIndex: 21333
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Push(BaseEventArgs t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();

	// RVA: 0x41E2178 Offset: 0x41DE178 VA: 0x41E2178
	protected void .ctor() { }
}

// Namespace: 
private class EventPoolHelper.Pool<T> : EventPool // TypeDefIndex: 21334
{
	// Fields
	private Stack<BaseEventArgs> _cacheList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Init(int initCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5269EE4 Offset: 0x5265EE4 VA: 0x5269EE4
	|-EventPoolHelper.Pool<object>.Init
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5269F74 Offset: 0x5265F74 VA: 0x5269F74
	|-EventPoolHelper.Pool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Push(BaseEventArgs t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A088 Offset: 0x5266088 VA: 0x526A088
	|-EventPoolHelper.Pool<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A0E0 Offset: 0x52660E0 VA: 0x526A0E0
	|-EventPoolHelper.Pool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Check() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A130 Offset: 0x5266130 VA: 0x526A130
	|-EventPoolHelper.Pool<object>.Check
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A134 Offset: 0x5266134 VA: 0x526A134
	|-EventPoolHelper.Pool<object>..ctor
	*/
}

// Namespace: Framework.EventSystem
public class EventPoolHelper // TypeDefIndex: 21335
{
	// Fields
	private readonly Dictionary<Type, EventPool> _pools; // 0x10
	private const int PoolItemMaxCount = 4;

	// Methods

	// RVA: -1 Offset: -1
	public T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE740 Offset: 0x45EA740 VA: 0x45EE740
	|-EventPoolHelper.Get<object>
	*/

	// RVA: -1 Offset: -1
	public void Push<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE908 Offset: 0x45EA908 VA: 0x45EE908
	|-EventPoolHelper.Push<object>
	*/

	// RVA: -1 Offset: -1
	public void Clear<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE6B0 Offset: 0x45EA6B0 VA: 0x45EE6B0
	|-EventPoolHelper.Clear<object>
	*/

	// RVA: 0x41E2180 Offset: 0x41DE180 VA: 0x41E2180
	public void ClearAllPool() { }

	// RVA: -1 Offset: -1
	private EventPoolHelper.Pool<T> GetPool<T>(Type tType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE7D0 Offset: 0x45EA7D0 VA: 0x45EE7D0
	|-EventPoolHelper.GetPool<object>
	*/

	// RVA: 0x41E231C Offset: 0x41DE31C VA: 0x41E231C
	public void .ctor() { }
}

// Namespace: Framework.EventSystem
public struct DispatchData // TypeDefIndex: 21336
{
	// Fields
	public int EventType; // 0x0
	public BaseEventArgs EventArgs; // 0x8
}

// Namespace: Framework.EventSystem
public class DispatchDataList // TypeDefIndex: 21337
{
	// Fields
	private const int DefaultSize = 4;
	public DispatchData[] Data; // 0x10
	private int _count; // 0x18
	private int _size; // 0x1C

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x41E23A4 Offset: 0x41DE3A4 VA: 0x41E23A4
	public int get_Count() { }

	// RVA: 0x41E23AC Offset: 0x41DE3AC VA: 0x41E23AC
	public void AddData(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x41E2480 Offset: 0x41DE480 VA: 0x41E2480
	public void Clear() { }

	// RVA: 0x41E2488 Offset: 0x41DE488 VA: 0x41E2488
	public void .ctor() { }
}

// Namespace: Framework.EventSystem
public sealed class HandlerEvent : MulticastDelegate // TypeDefIndex: 21338
{
	// Methods

	// RVA: 0x41E24F4 Offset: 0x41DE4F4 VA: 0x41E24F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x41E2594 Offset: 0x41DE594 VA: 0x41E2594 Slot: 13
	public virtual void Invoke(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x41E25A8 Offset: 0x41DE5A8 VA: 0x41E25A8 Slot: 14
	public virtual IAsyncResult BeginInvoke(int type, BaseEventArgs eventArgs, AsyncCallback callback, object object) { }

	// RVA: 0x41E263C Offset: 0x41DE63C VA: 0x41E263C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class EventSystemManager.Bucket // TypeDefIndex: 21339
{
	// Fields
	private const int BuffLen = 16;
	internal readonly int BuffSize; // 0x10
	private readonly HandlerEvent[][] _buffers; // 0x18
	private int _index; // 0x20

	// Methods

	// RVA: 0x41E2D74 Offset: 0x41DED74 VA: 0x41E2D74
	internal void .ctor(int buffSize) { }

	// RVA: 0x41E2E54 Offset: 0x41DEE54 VA: 0x41E2E54
	internal HandlerEvent[] Rent() { }

	// RVA: 0x41E2EF8 Offset: 0x41DEEF8 VA: 0x41E2EF8
	internal void Return(HandlerEvent[] array) { }
}

// Namespace: Framework.EventSystem
public class EventSystemManager : MonoBehaviour // TypeDefIndex: 21340
{
	// Fields
	private readonly Dictionary<int, List<HandlerEvent>> _handles; // 0x20
	private readonly EventPoolHelper _eventPoolHelper; // 0x28
	private readonly DispatchDataList _dispatchDataList; // 0x30
	private readonly EventSystemManager.Bucket[] _buckets; // 0x38

	// Methods

	// RVA: 0x41E2648 Offset: 0x41DE648 VA: 0x41E2648
	private void Awake() { }

	// RVA: -1 Offset: -1
	public T GetEvent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE9A8 Offset: 0x45EA9A8 VA: 0x45EE9A8
	|-EventSystemManager.GetEvent<object>
	*/

	// RVA: 0x41E2738 Offset: 0x41DE738 VA: 0x41E2738
	public void RegisterEvent(int type, HandlerEvent handle) { }

	// RVA: 0x41E28F8 Offset: 0x41DE8F8 VA: 0x41E28F8
	public void UnRegisterEvent(int type, HandlerEvent handle) { }

	// RVA: 0x41E2990 Offset: 0x41DE990 VA: 0x41E2990
	public void UnRegisterAllEvent() { }

	// RVA: 0x41E29F0 Offset: 0x41DE9F0 VA: 0x41E29F0
	public void DispatchNow(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x41E2CC0 Offset: 0x41DECC0 VA: 0x41E2CC0
	public void Dispatch(int type, BaseEventArgs eventArgs) { }

	// RVA: 0x41E2CD8 Offset: 0x41DECD8 VA: 0x41E2CD8
	public void OnUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x41E264C Offset: 0x41DE64C VA: 0x41E264C
	private void InitBucket() { }

	// RVA: 0x41E2B3C Offset: 0x41DEB3C VA: 0x41E2B3C
	private HandlerEvent[] GetTmpHandleEvent(int count) { }

	// RVA: 0x41E2C24 Offset: 0x41DEC24 VA: 0x41E2C24
	private void ReturnTmpHandles(HandlerEvent[] array) { }

	// RVA: 0x41E2DE8 Offset: 0x41DEDE8 VA: 0x41E2DE8
	private static int SelectBucketIndex(int bufferSize) { }

	// RVA: 0x41E2D68 Offset: 0x41DED68 VA: 0x41E2D68
	private static int GetMaxSizeForBucket(int binIndex) { }

	// RVA: 0x41E2F40 Offset: 0x41DEF40 VA: 0x41E2F40
	private static int Log2(int n) { }

	// RVA: 0x41E2FA0 Offset: 0x41DEFA0 VA: 0x41E2FA0
	public void .ctor() { }
}

// Namespace: 
public enum GuildConfig.EDebugType // TypeDefIndex: 21341
{
	// Fields
	public int value__; // 0x0
	public const GuildConfig.EDebugType Release = 0;
	public const GuildConfig.EDebugType Debug = 1;
	public const GuildConfig.EDebugType Disable = 15;
}

// Namespace: Framework.DxxGuild
public class GuildConfig : MonoBehaviour // TypeDefIndex: 21342
{
	// Fields
	[Header("调试模式")]
	public GuildConfig.EDebugType DebugType; // 0x20

	// Properties
	public bool IsDebug { get; }
	public bool IsEnable { get; }

	// Methods

	// RVA: 0x41E30C8 Offset: 0x41DF0C8 VA: 0x41E30C8
	public bool get_IsDebug() { }

	// RVA: 0x41E30D8 Offset: 0x41DF0D8 VA: 0x41E30D8
	public bool get_IsEnable() { }

	// RVA: 0x41E30E8 Offset: 0x41DF0E8 VA: 0x41E30E8
	public void .ctor() { }
}

// Namespace: Framework.DataModule
public class DataModuleManager : MonoBehaviour // TypeDefIndex: 21343
{
	// Fields
	private Dictionary<int, IDataModule> m_dataModules; // 0x20
	[SerializeField]
	private EventSystemManager m_eventSystemManager; // 0x28

	// Methods

	// RVA: 0x41E30F0 Offset: 0x41DF0F0 VA: 0x41E30F0
	public void Clear() { }

	// RVA: 0x41E32C4 Offset: 0x41DF2C4 VA: 0x41E32C4
	public void RegisterDataModule(IDataModule dataModule) { }

	// RVA: 0x41E3410 Offset: 0x41DF410 VA: 0x41E3410
	public void UnRegisterDataModule(IDataModule dataModule) { }

	// RVA: 0x41E3558 Offset: 0x41DF558 VA: 0x41E3558
	public void UnRegisterAllDataModule(int[] ignoreIDs) { }

	// RVA: -1 Offset: -1
	public T GetDataModule<T>(int dataName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456B7EC Offset: 0x45677EC VA: 0x456B7EC
	|-DataModuleManager.GetDataModule<object>
	|
	|-RVA: 0x456B8A8 Offset: 0x45678A8 VA: 0x456B8A8
	|-DataModuleManager.GetDataModule<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x41E3820 Offset: 0x41DF820 VA: 0x41E3820
	public void .ctor() { }
}

// Namespace: Framework.DataModule
public interface IDataModule // TypeDefIndex: 21344
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RegisterEvents(EventSystemManager manager);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnRegisterEvents(EventSystemManager manager);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
}

// Namespace: Framework.Coroutine
public class CoroutineManager : MonoBehaviour // TypeDefIndex: 21345
{
	// Fields
	public CoroutionAgent[] m_agents; // 0x20

	// Methods

	// RVA: 0x41E38A8 Offset: 0x41DF8A8 VA: 0x41E38A8
	public void AddTask(int type, IEnumerator routine) { }

	// RVA: 0x41E38EC Offset: 0x41DF8EC VA: 0x41E38EC
	public void RemoveTask(int type, IEnumerator routine) { }

	// RVA: 0x41E3930 Offset: 0x41DF930 VA: 0x41E3930
	public void RemoveAllTask(int type) { }

	// RVA: 0x41E3970 Offset: 0x41DF970 VA: 0x41E3970
	public void RemoveAllTask() { }

	// RVA: 0x41E39D0 Offset: 0x41DF9D0 VA: 0x41E39D0
	public void .ctor() { }
}

// Namespace: Framework.Coroutine
public class CoroutionAgent : MonoBehaviour // TypeDefIndex: 21346
{
	// Methods

	// RVA: 0x41E38E4 Offset: 0x41DF8E4 VA: 0x41E38E4
	public void AddTask(IEnumerator routine) { }

	// RVA: 0x41E3928 Offset: 0x41DF928 VA: 0x41E3928
	public void RemoveTask(IEnumerator routine) { }

	// RVA: 0x41E3968 Offset: 0x41DF968 VA: 0x41E3968
	public void RemoveAllTask() { }

	// RVA: 0x41E3A34 Offset: 0x41DFA34 VA: 0x41E3A34
	public void .ctor() { }
}

// Namespace: Framework.Announcement
public class AnnouncementManager // TypeDefIndex: 21347
{
	// Fields
	private IAnnouncementManager m_Manager; // 0x10

	// Properties
	public IAnnouncementManager Manager { get; }

	// Methods

	// RVA: 0x41E3A3C Offset: 0x41DFA3C VA: 0x41E3A3C
	public void SetManager(IAnnouncementManager manager) { }

	// RVA: 0x41E3A44 Offset: 0x41DFA44 VA: 0x41E3A44
	public IAnnouncementManager get_Manager() { }

	// RVA: 0x41E3A4C Offset: 0x41DFA4C VA: 0x41E3A4C
	public void OnInit() { }

	// RVA: 0x41E3AF4 Offset: 0x41DFAF4 VA: 0x41E3AF4
	public void OnDeInit() { }

	// RVA: 0x41E3BA4 Offset: 0x41DFBA4 VA: 0x41E3BA4
	public void .ctor() { }
}

// Namespace: Framework.Announcement
public interface IAnnouncementManager // TypeDefIndex: 21348
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDeInit();
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 21349
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 // TypeDefIndex: 21350
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=180 // TypeDefIndex: 21351
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=244 // TypeDefIndex: 21352
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=13920 // TypeDefIndex: 21353
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18952 // TypeDefIndex: 21354
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 21355
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=180 15CB13EE02FB054AF694230CE1C26E39ED14DAE23CDB79A71615F36CCF38FF0B /*Metadata offset 0xF0C1B0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=244 337F18EE2549A749A89C2E61A5C6E2254F51D8A40E964289E019879A8884DE4E /*Metadata offset 0xF0C268*/; // 0xB4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18952 4DE53F0F0FB30600E633AB6A123F2FD6C18C18A1029DCFFADF085C6CBADC636C /*Metadata offset 0xF0C360*/; // 0x1A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=13920 92D97AE6585409AD4E96609AF0AF80FB2FA9A55E9B93CC223F72CB299A594E2C /*Metadata offset 0xF10D70*/; // 0x4BB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 A2A8DD75F69E97F29AA19AC7CC8D92488B30DA5B1A316485505E41C33DF5C944 /*Metadata offset 0xF143D8*/; // 0x8210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 FA99786BA4D946A38F43D6C851557B041F1D653A734F23157F46162449D185AE /*Metadata offset 0xF14418*/; // 0x824C
}

