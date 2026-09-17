// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 25092
{}

// Namespace: DG.Tweening
public enum AutoPlay // TypeDefIndex: 25093
{
	// Fields
	public int value__; // 0x0
	public const AutoPlay None = 0;
	public const AutoPlay AutoPlaySequences = 1;
	public const AutoPlay AutoPlayTweeners = 2;
	public const AutoPlay All = 3;
}

// Namespace: DG.Tweening
[Flags]
public enum AxisConstraint // TypeDefIndex: 25094
{
	// Fields
	public int value__; // 0x0
	public const AxisConstraint None = 0;
	public const AxisConstraint X = 2;
	public const AxisConstraint Y = 4;
	public const AxisConstraint Z = 8;
	public const AxisConstraint W = 16;
}

// Namespace: DG.Tweening
public struct Color2 // TypeDefIndex: 25095
{
	// Fields
	public Color ca; // 0x0
	public Color cb; // 0x10

	// Methods

	// RVA: 0x40E39C0 Offset: 0x40DF9C0 VA: 0x40E39C0
	public void .ctor(Color ca, Color cb) { }

	// RVA: 0x40E39D4 Offset: 0x40DF9D4 VA: 0x40E39D4
	public static Color2 op_Addition(Color2 c1, Color2 c2) { }

	// RVA: 0x40E39EC Offset: 0x40DF9EC VA: 0x40E39EC
	public static Color2 op_Subtraction(Color2 c1, Color2 c2) { }

	// RVA: 0x40E3A04 Offset: 0x40DFA04 VA: 0x40E3A04
	public static Color2 op_Multiply(Color2 c1, float f) { }
}

// Namespace: DG.Tweening
public sealed class TweenCallback : MulticastDelegate // TypeDefIndex: 25096
{
	// Methods

	// RVA: 0x40E3A18 Offset: 0x40DFA18 VA: 0x40E3A18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x40E3AB4 Offset: 0x40DFAB4 VA: 0x40E3AB4 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x40E3AC8 Offset: 0x40DFAC8 VA: 0x40E3AC8 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x40E3AE8 Offset: 0x40DFAE8 VA: 0x40E3AE8 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: DG.Tweening
public sealed class TweenCallback<T> : MulticastDelegate // TypeDefIndex: 25097
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56663E8 Offset: 0x56623E8 VA: 0x56663E8
	|-TweenCallback<int>..ctor
	|
	|-RVA: 0x566652C Offset: 0x566252C VA: 0x566652C
	|-TweenCallback<float>..ctor
	|
	|-RVA: 0x5666670 Offset: 0x5662670 VA: 0x5666670
	|-TweenCallback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666488 Offset: 0x5662488 VA: 0x5666488
	|-TweenCallback<int>.Invoke
	|
	|-RVA: 0x56665CC Offset: 0x56625CC VA: 0x56665CC
	|-TweenCallback<float>.Invoke
	|
	|-RVA: 0x5666778 Offset: 0x5662778 VA: 0x5666778
	|-TweenCallback<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x566649C Offset: 0x566249C VA: 0x566649C
	|-TweenCallback<int>.BeginInvoke
	|
	|-RVA: 0x56665E0 Offset: 0x56625E0 VA: 0x56665E0
	|-TweenCallback<float>.BeginInvoke
	|
	|-RVA: 0x566678C Offset: 0x566278C VA: 0x566678C
	|-TweenCallback<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666520 Offset: 0x5662520 VA: 0x5666520
	|-TweenCallback<int>.EndInvoke
	|
	|-RVA: 0x5666664 Offset: 0x5662664 VA: 0x5666664
	|-TweenCallback<float>.EndInvoke
	|
	|-RVA: 0x566680C Offset: 0x566280C VA: 0x566680C
	|-TweenCallback<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: DG.Tweening
public sealed class EaseFunction : MulticastDelegate // TypeDefIndex: 25098
{
	// Methods

	// RVA: 0x40E3AF4 Offset: 0x40DFAF4 VA: 0x40E3AF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x40E3B94 Offset: 0x40DFB94 VA: 0x40E3B94 Slot: 13
	public virtual float Invoke(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x40E3BA8 Offset: 0x40DFBA8 VA: 0x40E3BA8 Slot: 14
	public virtual IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, AsyncCallback callback, object object) { }

	// RVA: 0x40E3C74 Offset: 0x40DFC74 VA: 0x40E3C74 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTween.<>c__DisplayClass53_0 // TypeDefIndex: 25099
{
	// Fields
	public float v; // 0x10
	public DOSetter<float> setter; // 0x18

	// Methods

	// RVA: 0x40E559C Offset: 0x40E159C VA: 0x40E559C
	public void .ctor() { }

	// RVA: 0x40E79F4 Offset: 0x40E39F4 VA: 0x40E79F4
	internal float <To>b__0() { }

	// RVA: 0x40E79FC Offset: 0x40E39FC VA: 0x40E79FC
	internal void <To>b__1(float x) { }
}

// Namespace: DG.Tweening
public class DOTween // TypeDefIndex: 25100
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static bool showUnityEditorReport; // 0x9
	public static float timeScale; // 0xC
	public static bool useSmoothDeltaTime; // 0x10
	public static float maxSmoothUnscaledTime; // 0x14
	private static LogBehaviour _logBehaviour; // 0x18
	public static bool drawGizmos; // 0x1C
	public static UpdateType defaultUpdateType; // 0x20
	public static bool defaultTimeScaleIndependent; // 0x24
	public static AutoPlay defaultAutoPlay; // 0x28
	public static bool defaultAutoKill; // 0x2C
	public static LoopType defaultLoopType; // 0x30
	public static bool defaultRecyclable; // 0x34
	public static Ease defaultEaseType; // 0x38
	public static float defaultEaseOvershootOrAmplitude; // 0x3C
	public static float defaultEasePeriod; // 0x40
	internal static DOTweenComponent instance; // 0x48
	internal static bool isUnityEditor; // 0x50
	internal static bool isDebugBuild; // 0x51
	internal static int maxActiveTweenersReached; // 0x54
	internal static int maxActiveSequencesReached; // 0x58
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x60
	internal static bool initialized; // 0x68
	internal static bool isQuitting; // 0x69

	// Properties
	public static LogBehaviour logBehaviour { get; set; }

	// Methods

	// RVA: 0x40E3C9C Offset: 0x40DFC9C VA: 0x40E3C9C
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x40E3CF4 Offset: 0x40DFCF4 VA: 0x40E3CF4
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x40E3D58 Offset: 0x40DFD58 VA: 0x40E3D58
	private static void .cctor() { }

	// RVA: 0x40E3EBC Offset: 0x40DFEBC VA: 0x40E3EBC
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x40E46B4 Offset: 0x40E06B4 VA: 0x40E46B4
	private static void AutoInit() { }

	// RVA: 0x40E4044 Offset: 0x40E0044 VA: 0x40E4044
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x40E4788 Offset: 0x40E0788 VA: 0x40E4788
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x40E47F0 Offset: 0x40E07F0 VA: 0x40E47F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x40E48F0 Offset: 0x40E08F0 VA: 0x40E48F0
	public static void ClearCachedTweens() { }

	// RVA: 0x40E4940 Offset: 0x40E0940 VA: 0x40E4940
	public static int Validate() { }

	// RVA: 0x40E4990 Offset: 0x40E0990 VA: 0x40E4990
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x40E4A28 Offset: 0x40E0A28 VA: 0x40E4A28
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x40E4AC0 Offset: 0x40E0AC0 VA: 0x40E4AC0
	public static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x40E4B58 Offset: 0x40E0B58 VA: 0x40E4B58
	public static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x40E4BF0 Offset: 0x40E0BF0 VA: 0x40E4BF0
	public static Tweener To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x40E4C88 Offset: 0x40E0C88 VA: 0x40E4C88
	public static Tweener To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x40E4D20 Offset: 0x40E0D20 VA: 0x40E4D20
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x40E4DB8 Offset: 0x40E0DB8 VA: 0x40E4DB8
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x40E4E60 Offset: 0x40E0E60 VA: 0x40E4E60
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x40E4F10 Offset: 0x40E0F10 VA: 0x40E4F10
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x40E4FD0 Offset: 0x40E0FD0 VA: 0x40E4FD0
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x40E5080 Offset: 0x40E1080 VA: 0x40E5080
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x40E5140 Offset: 0x40E1140 VA: 0x40E5140
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x40E5200 Offset: 0x40E1200 VA: 0x40E5200
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4565F14 Offset: 0x4561F14 VA: 0x4565F14
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x4565FD0 Offset: 0x4561FD0 VA: 0x4565FD0
	|-DOTween.To<Vector3, object, PathOptions>
	|
	|-RVA: 0x4566064 Offset: 0x4562064 VA: 0x4566064
	|-DOTween.To<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x40E5298 Offset: 0x40E1298 VA: 0x40E5298
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x40E534C Offset: 0x40E134C VA: 0x40E534C
	public static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x40E5420 Offset: 0x40E1420 VA: 0x40E5420
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x40E55A4 Offset: 0x40E15A4 VA: 0x40E55A4
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x40E5BC8 Offset: 0x40E1BC8 VA: 0x40E5BC8
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x40E6344 Offset: 0x40E2344 VA: 0x40E6344
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x40E5C80 Offset: 0x40E1C80 VA: 0x40E5C80
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x40E5994 Offset: 0x40E1994 VA: 0x40E5994
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x40E6408 Offset: 0x40E2408 VA: 0x40E6408
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x40E64BC Offset: 0x40E24BC VA: 0x40E64BC
	public static Sequence Sequence() { }

	// RVA: 0x40E66DC Offset: 0x40E26DC VA: 0x40E66DC
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x40E6758 Offset: 0x40E2758 VA: 0x40E6758
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x40E67FC Offset: 0x40E27FC VA: 0x40E67FC
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x40E6868 Offset: 0x40E2868 VA: 0x40E6868
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x40E68EC Offset: 0x40E28EC VA: 0x40E68EC
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x40E695C Offset: 0x40E295C VA: 0x40E695C
	public static int FlipAll() { }

	// RVA: 0x40E69C8 Offset: 0x40E29C8 VA: 0x40E69C8
	public static int Flip(object targetOrId) { }

	// RVA: 0x40E6A4C Offset: 0x40E2A4C VA: 0x40E6A4C
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x40E6AC8 Offset: 0x40E2AC8 VA: 0x40E6AC8
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x40E6B60 Offset: 0x40E2B60 VA: 0x40E6B60
	public static int KillAll(bool complete = False) { }

	// RVA: 0x40E6BF4 Offset: 0x40E2BF4 VA: 0x40E6BF4
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x40E6CFC Offset: 0x40E2CFC VA: 0x40E6CFC
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x40E6DC0 Offset: 0x40E2DC0 VA: 0x40E6DC0
	public static int PauseAll() { }

	// RVA: 0x40E6E2C Offset: 0x40E2E2C VA: 0x40E6E2C
	public static int Pause(object targetOrId) { }

	// RVA: 0x40E6EB0 Offset: 0x40E2EB0 VA: 0x40E6EB0
	public static int PlayAll() { }

	// RVA: 0x40E6F1C Offset: 0x40E2F1C VA: 0x40E6F1C
	public static int Play(object targetOrId) { }

	// RVA: 0x40E6FA0 Offset: 0x40E2FA0 VA: 0x40E6FA0
	public static int Play(object target, object id) { }

	// RVA: 0x40E702C Offset: 0x40E302C VA: 0x40E702C
	public static int PlayBackwardsAll() { }

	// RVA: 0x40E7098 Offset: 0x40E3098 VA: 0x40E7098
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x40E711C Offset: 0x40E311C VA: 0x40E711C
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x40E71A8 Offset: 0x40E31A8 VA: 0x40E71A8
	public static int PlayForwardAll() { }

	// RVA: 0x40E7214 Offset: 0x40E3214 VA: 0x40E7214
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x40E7298 Offset: 0x40E3298 VA: 0x40E7298
	public static int PlayForward(object target, object id) { }

	// RVA: 0x40E7324 Offset: 0x40E3324 VA: 0x40E7324
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x40E7394 Offset: 0x40E3394 VA: 0x40E7394
	public static int Restart(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x40E741C Offset: 0x40E341C VA: 0x40E741C
	public static int Restart(object target, object id, bool includeDelay = True) { }

	// RVA: 0x40E74B8 Offset: 0x40E34B8 VA: 0x40E74B8
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x40E7528 Offset: 0x40E3528 VA: 0x40E7528
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x40E75B0 Offset: 0x40E35B0 VA: 0x40E75B0
	public static int SmoothRewindAll() { }

	// RVA: 0x40E761C Offset: 0x40E361C VA: 0x40E761C
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x40E76A0 Offset: 0x40E36A0 VA: 0x40E76A0
	public static int TogglePauseAll() { }

	// RVA: 0x40E770C Offset: 0x40E370C VA: 0x40E770C
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x40E7790 Offset: 0x40E3790 VA: 0x40E7790
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x40E7818 Offset: 0x40E3818 VA: 0x40E7818
	public static int TotalPlayingTweens() { }

	// RVA: 0x40E7868 Offset: 0x40E3868 VA: 0x40E7868
	public static List<Tween> PlayingTweens() { }

	// RVA: 0x40E78BC Offset: 0x40E38BC VA: 0x40E78BC
	public static List<Tween> PausedTweens() { }

	// RVA: 0x40E7910 Offset: 0x40E3910 VA: 0x40E7910
	public static List<Tween> TweensById(object id, bool playingOnly = False) { }

	// RVA: 0x40E7984 Offset: 0x40E3984 VA: 0x40E7984
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False) { }

	// RVA: 0x40E6544 Offset: 0x40E2544 VA: 0x40E6544
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4564A20 Offset: 0x4560A20 VA: 0x4564A20
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x4564B48 Offset: 0x4560B48 VA: 0x4564B48
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x4564C68 Offset: 0x4560C68 VA: 0x4564C68
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x4564D68 Offset: 0x4560D68 VA: 0x4564D68
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x4564E70 Offset: 0x4560E70 VA: 0x4564E70
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x4564F78 Offset: 0x4560F78 VA: 0x4564F78
	|-DOTween.ApplyTo<object, object, NoOptions>
	|
	|-RVA: 0x4565080 Offset: 0x4561080 VA: 0x4565080
	|-DOTween.ApplyTo<object, object, StringOptions>
	|
	|-RVA: 0x4565188 Offset: 0x4561188 VA: 0x4565188
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x45652B0 Offset: 0x45612B0 VA: 0x45652B0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x45653C8 Offset: 0x45613C8 VA: 0x45653C8
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x45654F0 Offset: 0x45614F0 VA: 0x45654F0
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x45655F0 Offset: 0x45615F0 VA: 0x45655F0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x45656F8 Offset: 0x45616F8 VA: 0x45656F8
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x4565800 Offset: 0x4561800 VA: 0x4565800
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x4565910 Offset: 0x4561910 VA: 0x4565910
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x4565A18 Offset: 0x4561A18 VA: 0x4565A18
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4565B20 Offset: 0x4561B20 VA: 0x4565B20
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x4565C38 Offset: 0x4561C38 VA: 0x4565C38
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x4565D60 Offset: 0x4561D60 VA: 0x4565D60
	|-DOTween.ApplyTo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x40E79EC Offset: 0x40E39EC VA: 0x40E79EC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOVirtual.<>c__DisplayClass0_0 // TypeDefIndex: 25101
{
	// Fields
	public float val; // 0x10
	public TweenCallback<float> onVirtualUpdate; // 0x18

	// Methods

	// RVA: 0x40E7BF8 Offset: 0x40E3BF8 VA: 0x40E7BF8
	public void .ctor() { }

	// RVA: 0x40E7FB8 Offset: 0x40E3FB8 VA: 0x40E7FB8
	internal float <Float>b__0() { }

	// RVA: 0x40E7FC0 Offset: 0x40E3FC0 VA: 0x40E7FC0
	internal void <Float>b__1(float x) { }

	// RVA: 0x40E7FC8 Offset: 0x40E3FC8 VA: 0x40E7FC8
	internal void <Float>b__2() { }
}

// Namespace: DG.Tweening
public static class DOVirtual // TypeDefIndex: 25102
{
	// Methods

	// RVA: 0x40E7A24 Offset: 0x40E3A24 VA: 0x40E7A24
	public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate) { }

	// RVA: 0x40E7C00 Offset: 0x40E3C00 VA: 0x40E7C00
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) { }

	// RVA: 0x40E7C9C Offset: 0x40E3C9C VA: 0x40E7C9C
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) { }

	// RVA: 0x40E7D40 Offset: 0x40E3D40 VA: 0x40E7D40
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) { }

	// RVA: 0x40E7D84 Offset: 0x40E3D84 VA: 0x40E7D84
	public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) { }

	// RVA: 0x40E7E9C Offset: 0x40E3E9C VA: 0x40E7E9C
	public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = True) { }
}

// Namespace: DG.Tweening
public enum Ease // TypeDefIndex: 25103
{
	// Fields
	public int value__; // 0x0
	public const Ease Unset = 0;
	public const Ease Linear = 1;
	public const Ease InSine = 2;
	public const Ease OutSine = 3;
	public const Ease InOutSine = 4;
	public const Ease InQuad = 5;
	public const Ease OutQuad = 6;
	public const Ease InOutQuad = 7;
	public const Ease InCubic = 8;
	public const Ease OutCubic = 9;
	public const Ease InOutCubic = 10;
	public const Ease InQuart = 11;
	public const Ease OutQuart = 12;
	public const Ease InOutQuart = 13;
	public const Ease InQuint = 14;
	public const Ease OutQuint = 15;
	public const Ease InOutQuint = 16;
	public const Ease InExpo = 17;
	public const Ease OutExpo = 18;
	public const Ease InOutExpo = 19;
	public const Ease InCirc = 20;
	public const Ease OutCirc = 21;
	public const Ease InOutCirc = 22;
	public const Ease InElastic = 23;
	public const Ease OutElastic = 24;
	public const Ease InOutElastic = 25;
	public const Ease InBack = 26;
	public const Ease OutBack = 27;
	public const Ease InOutBack = 28;
	public const Ease InBounce = 29;
	public const Ease OutBounce = 30;
	public const Ease InOutBounce = 31;
	public const Ease Flash = 32;
	public const Ease InFlash = 33;
	public const Ease OutFlash = 34;
	public const Ease InOutFlash = 35;
	public const Ease INTERNAL_Zero = 36;
	public const Ease INTERNAL_Custom = 37;
}

// Namespace: 
[CompilerGenerated]
private sealed class EaseFactory.<>c__DisplayClass2_0 // TypeDefIndex: 25104
{
	// Fields
	public float motionDelay; // 0x10
	public EaseFunction customEase; // 0x18

	// Methods

	// RVA: 0x40E8228 Offset: 0x40E4228 VA: 0x40E8228
	public void .ctor() { }

	// RVA: 0x40E8238 Offset: 0x40E4238 VA: 0x40E8238
	internal float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period) { }
}

// Namespace: DG.Tweening
public class EaseFactory // TypeDefIndex: 25105
{
	// Methods

	// RVA: 0x40E7FF0 Offset: 0x40E3FF0 VA: 0x40E7FF0
	public static EaseFunction StopMotion(int motionFps, Nullable<Ease> ease) { }

	// RVA: 0x40E8174 Offset: 0x40E4174 VA: 0x40E8174
	public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve) { }

	// RVA: 0x40E80A8 Offset: 0x40E40A8 VA: 0x40E80A8
	public static EaseFunction StopMotion(int motionFps, EaseFunction customEase) { }

	// RVA: 0x40E8230 Offset: 0x40E4230 VA: 0x40E8230
	public void .ctor() { }
}

// Namespace: DG.Tweening
public interface IDOTweenInit // TypeDefIndex: 25106
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
}

// Namespace: DG.Tweening
public enum PathMode // TypeDefIndex: 25107
{
	// Fields
	public int value__; // 0x0
	public const PathMode Ignore = 0;
	public const PathMode Full3D = 1;
	public const PathMode TopDown2D = 2;
	public const PathMode Sidescroller2D = 3;
}

// Namespace: DG.Tweening
public enum PathType // TypeDefIndex: 25108
{
	// Fields
	public int value__; // 0x0
	public const PathType Linear = 0;
	public const PathType CatmullRom = 1;
}

// Namespace: DG.Tweening
public enum RotateMode // TypeDefIndex: 25109
{
	// Fields
	public int value__; // 0x0
	public const RotateMode Fast = 0;
	public const RotateMode FastBeyond360 = 1;
	public const RotateMode WorldAxisAdd = 2;
	public const RotateMode LocalAxisAdd = 3;
}

// Namespace: DG.Tweening
public enum ScrambleMode // TypeDefIndex: 25110
{
	// Fields
	public int value__; // 0x0
	public const ScrambleMode None = 0;
	public const ScrambleMode All = 1;
	public const ScrambleMode Uppercase = 2;
	public const ScrambleMode Lowercase = 3;
	public const ScrambleMode Numerals = 4;
	public const ScrambleMode Custom = 5;
}

// Namespace: DG.Tweening
[Extension]
public static class TweenExtensions // TypeDefIndex: 25111
{
	// Methods

	[Extension]
	// RVA: 0x40E82A8 Offset: 0x40E42A8 VA: 0x40E82A8
	public static void Complete(Tween t) { }

	[Extension]
	// RVA: 0x40E82B0 Offset: 0x40E42B0 VA: 0x40E82B0
	public static void Complete(Tween t, bool withCallbacks) { }

	[Extension]
	// RVA: 0x40E83D8 Offset: 0x40E43D8 VA: 0x40E83D8
	public static void Flip(Tween t) { }

	[Extension]
	// RVA: 0x40E84EC Offset: 0x40E44EC VA: 0x40E84EC
	public static void ForceInit(Tween t) { }

	[Extension]
	// RVA: 0x40E8604 Offset: 0x40E4604 VA: 0x40E8604
	public static void Goto(Tween t, float to, bool andPlay = False) { }

	[Extension]
	// RVA: 0x40E874C Offset: 0x40E474C VA: 0x40E874C
	public static void Kill(Tween t, bool complete = False) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T Pause<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4720838 Offset: 0x471C838 VA: 0x4720838
	|-TweenExtensions.Pause<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T Play<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x472093C Offset: 0x471C93C VA: 0x472093C
	|-TweenExtensions.Play<object>
	*/

	[Extension]
	// RVA: 0x40E88C8 Offset: 0x40E48C8 VA: 0x40E88C8
	public static void PlayBackwards(Tween t) { }

	[Extension]
	// RVA: 0x40E89DC Offset: 0x40E49DC VA: 0x40E89DC
	public static void PlayForward(Tween t) { }

	[Extension]
	// RVA: 0x40E8AF0 Offset: 0x40E4AF0 VA: 0x40E8AF0
	public static void Restart(Tween t, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40E8C0C Offset: 0x40E4C0C VA: 0x40E8C0C
	public static void Rewind(Tween t, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40E8D28 Offset: 0x40E4D28 VA: 0x40E8D28
	public static void SmoothRewind(Tween t) { }

	[Extension]
	// RVA: 0x40E8E3C Offset: 0x40E4E3C VA: 0x40E8E3C
	public static void TogglePause(Tween t) { }

	[Extension]
	// RVA: 0x40E8F50 Offset: 0x40E4F50 VA: 0x40E8F50
	public static void GotoWaypoint(Tween t, int waypointIndex, bool andPlay = False) { }

	[Extension]
	// RVA: 0x40E9244 Offset: 0x40E5244 VA: 0x40E9244
	public static YieldInstruction WaitForCompletion(Tween t) { }

	[Extension]
	// RVA: 0x40E9314 Offset: 0x40E5314 VA: 0x40E9314
	public static YieldInstruction WaitForRewind(Tween t) { }

	[Extension]
	// RVA: 0x40E93E4 Offset: 0x40E53E4 VA: 0x40E93E4
	public static YieldInstruction WaitForKill(Tween t) { }

	[Extension]
	// RVA: 0x40E94B4 Offset: 0x40E54B4 VA: 0x40E94B4
	public static YieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[Extension]
	// RVA: 0x40E958C Offset: 0x40E558C VA: 0x40E958C
	public static YieldInstruction WaitForPosition(Tween t, float position) { }

	[Extension]
	// RVA: 0x40E9670 Offset: 0x40E5670 VA: 0x40E9670
	public static Coroutine WaitForStart(Tween t) { }

	[Extension]
	// RVA: 0x40E9740 Offset: 0x40E5740 VA: 0x40E9740
	public static int CompletedLoops(Tween t) { }

	[Extension]
	// RVA: 0x40E97BC Offset: 0x40E57BC VA: 0x40E97BC
	public static float Delay(Tween t) { }

	[Extension]
	// RVA: 0x40E9844 Offset: 0x40E5844 VA: 0x40E9844
	public static float Duration(Tween t, bool includeLoops = True) { }

	[Extension]
	// RVA: 0x40E98FC Offset: 0x40E58FC VA: 0x40E98FC
	public static float Elapsed(Tween t, bool includeLoops = True) { }

	[Extension]
	// RVA: 0x40E99AC Offset: 0x40E59AC VA: 0x40E99AC
	public static float ElapsedPercentage(Tween t, bool includeLoops = True) { }

	[Extension]
	// RVA: 0x40E9A6C Offset: 0x40E5A6C VA: 0x40E9A6C
	public static float ElapsedDirectionalPercentage(Tween t) { }

	[Extension]
	// RVA: 0x40E9B30 Offset: 0x40E5B30 VA: 0x40E9B30
	public static bool IsActive(Tween t) { }

	[Extension]
	// RVA: 0x40E9B48 Offset: 0x40E5B48 VA: 0x40E9B48
	public static bool IsBackwards(Tween t) { }

	[Extension]
	// RVA: 0x40E9BCC Offset: 0x40E5BCC VA: 0x40E9BCC
	public static bool IsComplete(Tween t) { }

	[Extension]
	// RVA: 0x40E9C50 Offset: 0x40E5C50 VA: 0x40E9C50
	public static bool IsInitialized(Tween t) { }

	[Extension]
	// RVA: 0x40E9CD4 Offset: 0x40E5CD4 VA: 0x40E9CD4
	public static bool IsPlaying(Tween t) { }

	[Extension]
	// RVA: 0x40E9D58 Offset: 0x40E5D58 VA: 0x40E9D58
	public static int Loops(Tween t) { }

	[Extension]
	// RVA: 0x40E9DD4 Offset: 0x40E5DD4 VA: 0x40E9DD4
	public static Vector3 PathGetPoint(Tween t, float pathPercentage) { }

	[Extension]
	// RVA: 0x40E9FD0 Offset: 0x40E5FD0 VA: 0x40E9FD0
	public static Vector3[] PathGetDrawPoints(Tween t, int subdivisionsXSegment = 10) { }

	[Extension]
	// RVA: 0x40EA178 Offset: 0x40E6178 VA: 0x40EA178
	public static float PathLength(Tween t) { }
}

// Namespace: DG.Tweening
public enum LoopType // TypeDefIndex: 25112
{
	// Fields
	public int value__; // 0x0
	public const LoopType Restart = 0;
	public const LoopType Yoyo = 1;
	public const LoopType Incremental = 2;
}

// Namespace: DG.Tweening
public sealed class Sequence : Tween // TypeDefIndex: 25113
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x108
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x110
	internal float lastTweenInsertTime; // 0x118

	// Methods

	// RVA: 0x40EA32C Offset: 0x40E632C VA: 0x40EA32C
	internal void .ctor() { }

	// RVA: 0x40EA44C Offset: 0x40E644C VA: 0x40EA44C
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x40EA544 Offset: 0x40E6544 VA: 0x40EA544
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x40EA72C Offset: 0x40E672C VA: 0x40EA72C
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x40EA750 Offset: 0x40E6750 VA: 0x40EA750
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x40EA824 Offset: 0x40E6824 VA: 0x40EA824
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x40EA930 Offset: 0x40E6930 VA: 0x40EA930 Slot: 4
	internal override void Reset() { }

	// RVA: 0x40EAAF8 Offset: 0x40E6AF8 VA: 0x40EAAF8 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x40EABB4 Offset: 0x40E6BB4 VA: 0x40EABB4 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x40EAD94 Offset: 0x40E6D94 VA: 0x40EAD94 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x40E6608 Offset: 0x40E2608 VA: 0x40E6608
	internal static void Setup(Sequence s) { }

	// RVA: 0x40EABB8 Offset: 0x40E6BB8 VA: 0x40EABB8
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x40EAD9C Offset: 0x40E6D9C VA: 0x40EAD9C
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x40EB068 Offset: 0x40E7068 VA: 0x40EB068
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x40EB728 Offset: 0x40E7728 VA: 0x40EB728
	private static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass0_0 // TypeDefIndex: 25114
{
	// Fields
	public AudioSource target; // 0x10

	// Methods

	// RVA: 0x40EB904 Offset: 0x40E7904 VA: 0x40EB904
	public void .ctor() { }

	// RVA: 0x40F5B9C Offset: 0x40F1B9C VA: 0x40F5B9C
	internal float <DOFade>b__0() { }

	// RVA: 0x40F5BB8 Offset: 0x40F1BB8 VA: 0x40F5BB8
	internal void <DOFade>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass1_0 // TypeDefIndex: 25115
{
	// Fields
	public AudioSource target; // 0x10

	// Methods

	// RVA: 0x40EBA80 Offset: 0x40E7A80 VA: 0x40EBA80
	public void .ctor() { }

	// RVA: 0x40F5BD4 Offset: 0x40F1BD4 VA: 0x40F5BD4
	internal float <DOPitch>b__0() { }

	// RVA: 0x40F5BF0 Offset: 0x40F1BF0 VA: 0x40F5BF0
	internal void <DOPitch>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass2_0 // TypeDefIndex: 25116
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EBBFC Offset: 0x40E7BFC VA: 0x40EBBFC
	public void .ctor() { }

	// RVA: 0x40F5C0C Offset: 0x40F1C0C VA: 0x40F5C0C
	internal float <DOAspect>b__0() { }

	// RVA: 0x40F5C28 Offset: 0x40F1C28 VA: 0x40F5C28
	internal void <DOAspect>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass3_0 // TypeDefIndex: 25117
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EBDA0 Offset: 0x40E7DA0 VA: 0x40EBDA0
	public void .ctor() { }

	// RVA: 0x40F5C44 Offset: 0x40F1C44 VA: 0x40F5C44
	internal Color <DOColor>b__0() { }

	// RVA: 0x40F5C60 Offset: 0x40F1C60 VA: 0x40F5C60
	internal void <DOColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass4_0 // TypeDefIndex: 25118
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EBF1C Offset: 0x40E7F1C VA: 0x40EBF1C
	public void .ctor() { }

	// RVA: 0x40F5C7C Offset: 0x40F1C7C VA: 0x40F5C7C
	internal float <DOFarClipPlane>b__0() { }

	// RVA: 0x40F5C98 Offset: 0x40F1C98 VA: 0x40F5C98
	internal void <DOFarClipPlane>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass5_0 // TypeDefIndex: 25119
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC098 Offset: 0x40E8098 VA: 0x40EC098
	public void .ctor() { }

	// RVA: 0x40F5CB4 Offset: 0x40F1CB4 VA: 0x40F5CB4
	internal float <DOFieldOfView>b__0() { }

	// RVA: 0x40F5CD0 Offset: 0x40F1CD0 VA: 0x40F5CD0
	internal void <DOFieldOfView>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass6_0 // TypeDefIndex: 25120
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC214 Offset: 0x40E8214 VA: 0x40EC214
	public void .ctor() { }

	// RVA: 0x40F5CEC Offset: 0x40F1CEC VA: 0x40F5CEC
	internal float <DONearClipPlane>b__0() { }

	// RVA: 0x40F5D08 Offset: 0x40F1D08 VA: 0x40F5D08
	internal void <DONearClipPlane>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass7_0 // TypeDefIndex: 25121
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC390 Offset: 0x40E8390 VA: 0x40EC390
	public void .ctor() { }

	// RVA: 0x40F5D24 Offset: 0x40F1D24 VA: 0x40F5D24
	internal float <DOOrthoSize>b__0() { }

	// RVA: 0x40F5D40 Offset: 0x40F1D40 VA: 0x40F5D40
	internal void <DOOrthoSize>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass8_0 // TypeDefIndex: 25122
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC534 Offset: 0x40E8534 VA: 0x40EC534
	public void .ctor() { }

	// RVA: 0x40F5D5C Offset: 0x40F1D5C VA: 0x40F5D5C
	internal Rect <DOPixelRect>b__0() { }

	// RVA: 0x40F5D78 Offset: 0x40F1D78 VA: 0x40F5D78
	internal void <DOPixelRect>b__1(Rect x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass9_0 // TypeDefIndex: 25123
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC6D8 Offset: 0x40E86D8 VA: 0x40EC6D8
	public void .ctor() { }

	// RVA: 0x40F5D94 Offset: 0x40F1D94 VA: 0x40F5D94
	internal Rect <DORect>b__0() { }

	// RVA: 0x40F5DB0 Offset: 0x40F1DB0 VA: 0x40F5DB0
	internal void <DORect>b__1(Rect x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass10_0 // TypeDefIndex: 25124
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40EC8A0 Offset: 0x40E88A0 VA: 0x40EC8A0
	public void .ctor() { }

	// RVA: 0x40F5DCC Offset: 0x40F1DCC VA: 0x40F5DCC
	internal Vector3 <DOShakePosition>b__0() { }

	// RVA: 0x40F5DF4 Offset: 0x40F1DF4 VA: 0x40F5DF4
	internal void <DOShakePosition>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass11_0 // TypeDefIndex: 25125
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40ECA7C Offset: 0x40E8A7C VA: 0x40ECA7C
	public void .ctor() { }

	// RVA: 0x40F5E44 Offset: 0x40F1E44 VA: 0x40F5E44
	internal Vector3 <DOShakePosition>b__0() { }

	// RVA: 0x40F5E6C Offset: 0x40F1E6C VA: 0x40F5E6C
	internal void <DOShakePosition>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass12_0 // TypeDefIndex: 25126
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40ECC44 Offset: 0x40E8C44 VA: 0x40ECC44
	public void .ctor() { }

	// RVA: 0x40F5EBC Offset: 0x40F1EBC VA: 0x40F5EBC
	internal Vector3 <DOShakeRotation>b__0() { }

	// RVA: 0x40F5EE4 Offset: 0x40F1EE4 VA: 0x40F5EE4
	internal void <DOShakeRotation>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass13_0 // TypeDefIndex: 25127
{
	// Fields
	public Camera target; // 0x10

	// Methods

	// RVA: 0x40ECE20 Offset: 0x40E8E20 VA: 0x40ECE20
	public void .ctor() { }

	// RVA: 0x40F5F4C Offset: 0x40F1F4C VA: 0x40F5F4C
	internal Vector3 <DOShakeRotation>b__0() { }

	// RVA: 0x40F5F74 Offset: 0x40F1F74 VA: 0x40F5F74
	internal void <DOShakeRotation>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass14_0 // TypeDefIndex: 25128
{
	// Fields
	public Light target; // 0x10

	// Methods

	// RVA: 0x40ECFC4 Offset: 0x40E8FC4 VA: 0x40ECFC4
	public void .ctor() { }

	// RVA: 0x40F5FDC Offset: 0x40F1FDC VA: 0x40F5FDC
	internal Color <DOColor>b__0() { }

	// RVA: 0x40F5FF8 Offset: 0x40F1FF8 VA: 0x40F5FF8
	internal void <DOColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass15_0 // TypeDefIndex: 25129
{
	// Fields
	public Light target; // 0x10

	// Methods

	// RVA: 0x40ED140 Offset: 0x40E9140 VA: 0x40ED140
	public void .ctor() { }

	// RVA: 0x40F6014 Offset: 0x40F2014 VA: 0x40F6014
	internal float <DOIntensity>b__0() { }

	// RVA: 0x40F6030 Offset: 0x40F2030 VA: 0x40F6030
	internal void <DOIntensity>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass16_0 // TypeDefIndex: 25130
{
	// Fields
	public Light target; // 0x10

	// Methods

	// RVA: 0x40ED2BC Offset: 0x40E92BC VA: 0x40ED2BC
	public void .ctor() { }

	// RVA: 0x40F604C Offset: 0x40F204C VA: 0x40F604C
	internal float <DOShadowStrength>b__0() { }

	// RVA: 0x40F6068 Offset: 0x40F2068 VA: 0x40F6068
	internal void <DOShadowStrength>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass17_0 // TypeDefIndex: 25131
{
	// Fields
	public Color2 startValue; // 0x10
	public LineRenderer target; // 0x30

	// Methods

	// RVA: 0x40ED46C Offset: 0x40E946C VA: 0x40ED46C
	public void .ctor() { }

	// RVA: 0x40F6084 Offset: 0x40F2084 VA: 0x40F6084
	internal Color2 <DOColor>b__0() { }

	// RVA: 0x40F6090 Offset: 0x40F2090 VA: 0x40F6090
	internal void <DOColor>b__1(Color2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass18_0 // TypeDefIndex: 25132
{
	// Fields
	public Material target; // 0x10

	// Methods

	// RVA: 0x40ED610 Offset: 0x40E9610 VA: 0x40ED610
	public void .ctor() { }

	// RVA: 0x40F60BC Offset: 0x40F20BC VA: 0x40F60BC
	internal Color <DOColor>b__0() { }

	// RVA: 0x40F60D8 Offset: 0x40F20D8 VA: 0x40F60D8
	internal void <DOColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass19_0 // TypeDefIndex: 25133
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40ED828 Offset: 0x40E9828 VA: 0x40ED828
	public void .ctor() { }

	// RVA: 0x40F60F4 Offset: 0x40F20F4 VA: 0x40F60F4
	internal Color <DOColor>b__0() { }

	// RVA: 0x40F6118 Offset: 0x40F2118 VA: 0x40F6118
	internal void <DOColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass20_0 // TypeDefIndex: 25134
{
	// Fields
	public Material target; // 0x10

	// Methods

	// RVA: 0x40ED9A4 Offset: 0x40E99A4 VA: 0x40ED9A4
	public void .ctor() { }

	// RVA: 0x40F613C Offset: 0x40F213C VA: 0x40F613C
	internal Color <DOFade>b__0() { }

	// RVA: 0x40F6158 Offset: 0x40F2158 VA: 0x40F6158
	internal void <DOFade>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass21_0 // TypeDefIndex: 25135
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40EDB8C Offset: 0x40E9B8C VA: 0x40EDB8C
	public void .ctor() { }

	// RVA: 0x40F6174 Offset: 0x40F2174 VA: 0x40F6174
	internal Color <DOFade>b__0() { }

	// RVA: 0x40F6198 Offset: 0x40F2198 VA: 0x40F6198
	internal void <DOFade>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass22_0 // TypeDefIndex: 25136
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40EDD74 Offset: 0x40E9D74 VA: 0x40EDD74
	public void .ctor() { }

	// RVA: 0x40F61BC Offset: 0x40F21BC VA: 0x40F61BC
	internal float <DOFloat>b__0() { }

	// RVA: 0x40F61E0 Offset: 0x40F21E0 VA: 0x40F61E0
	internal void <DOFloat>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass23_0 // TypeDefIndex: 25137
{
	// Fields
	public Material target; // 0x10

	// Methods

	// RVA: 0x40EDF00 Offset: 0x40E9F00 VA: 0x40EDF00
	public void .ctor() { }

	// RVA: 0x40F6204 Offset: 0x40F2204 VA: 0x40F6204
	internal Vector2 <DOOffset>b__0() { }

	// RVA: 0x40F6220 Offset: 0x40F2220 VA: 0x40F6220
	internal void <DOOffset>b__1(Vector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass24_0 // TypeDefIndex: 25138
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40EE0FC Offset: 0x40EA0FC VA: 0x40EE0FC
	public void .ctor() { }

	// RVA: 0x40F623C Offset: 0x40F223C VA: 0x40F623C
	internal Vector2 <DOOffset>b__0() { }

	// RVA: 0x40F6260 Offset: 0x40F2260 VA: 0x40F6260
	internal void <DOOffset>b__1(Vector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass25_0 // TypeDefIndex: 25139
{
	// Fields
	public Material target; // 0x10

	// Methods

	// RVA: 0x40EE288 Offset: 0x40EA288 VA: 0x40EE288
	public void .ctor() { }

	// RVA: 0x40F6284 Offset: 0x40F2284 VA: 0x40F6284
	internal Vector2 <DOTiling>b__0() { }

	// RVA: 0x40F62A0 Offset: 0x40F22A0 VA: 0x40F62A0
	internal void <DOTiling>b__1(Vector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass26_0 // TypeDefIndex: 25140
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40EE484 Offset: 0x40EA484 VA: 0x40EE484
	public void .ctor() { }

	// RVA: 0x40F62BC Offset: 0x40F22BC VA: 0x40F62BC
	internal Vector2 <DOTiling>b__0() { }

	// RVA: 0x40F62E0 Offset: 0x40F22E0 VA: 0x40F62E0
	internal void <DOTiling>b__1(Vector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass27_0 // TypeDefIndex: 25141
{
	// Fields
	public Material target; // 0x10
	public string property; // 0x18

	// Methods

	// RVA: 0x40EE69C Offset: 0x40EA69C VA: 0x40EE69C
	public void .ctor() { }

	// RVA: 0x40F6304 Offset: 0x40F2304 VA: 0x40F6304
	internal Vector4 <DOVector>b__0() { }

	// RVA: 0x40F6328 Offset: 0x40F2328 VA: 0x40F6328
	internal void <DOVector>b__1(Vector4 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass28_0 // TypeDefIndex: 25142
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EE84C Offset: 0x40EA84C VA: 0x40EE84C
	public void .ctor() { }

	// RVA: 0x40F634C Offset: 0x40F234C VA: 0x40F634C
	internal Vector3 <DOMove>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass29_0 // TypeDefIndex: 25143
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EEA0C Offset: 0x40EAA0C VA: 0x40EEA0C
	public void .ctor() { }

	// RVA: 0x40F6368 Offset: 0x40F2368 VA: 0x40F6368
	internal Vector3 <DOMoveX>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass30_0 // TypeDefIndex: 25144
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EEBD0 Offset: 0x40EABD0 VA: 0x40EEBD0
	public void .ctor() { }

	// RVA: 0x40F6384 Offset: 0x40F2384 VA: 0x40F6384
	internal Vector3 <DOMoveY>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass31_0 // TypeDefIndex: 25145
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EED78 Offset: 0x40EAD78 VA: 0x40EED78
	public void .ctor() { }

	// RVA: 0x40F63A0 Offset: 0x40F23A0 VA: 0x40F63A0
	internal Vector3 <DOMoveZ>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass32_0 // TypeDefIndex: 25146
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EEF30 Offset: 0x40EAF30 VA: 0x40EEF30
	public void .ctor() { }

	// RVA: 0x40F63BC Offset: 0x40F23BC VA: 0x40F63BC
	internal Quaternion <DORotate>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass33_0 // TypeDefIndex: 25147
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EF198 Offset: 0x40EB198 VA: 0x40EF198
	public void .ctor() { }

	// RVA: 0x40F63D8 Offset: 0x40F23D8 VA: 0x40F63D8
	internal Quaternion <DOLookAt>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass34_0 // TypeDefIndex: 25148
{
	// Fields
	public Rigidbody target; // 0x10
	public bool offsetYSet; // 0x18
	public float offsetY; // 0x1C
	public Sequence s; // 0x20
	public Vector3 endValue; // 0x28
	public float startPosY; // 0x34

	// Methods

	// RVA: 0x40EF64C Offset: 0x40EB64C VA: 0x40EF64C
	public void .ctor() { }

	// RVA: 0x40F63F4 Offset: 0x40F23F4 VA: 0x40F63F4
	internal Vector3 <DOJump>b__0() { }

	// RVA: 0x40F6410 Offset: 0x40F2410 VA: 0x40F6410
	internal void <DOJump>b__1() { }

	// RVA: 0x40F64B8 Offset: 0x40F24B8 VA: 0x40F64B8
	internal Vector3 <DOJump>b__2() { }

	// RVA: 0x40F64D4 Offset: 0x40F24D4 VA: 0x40F64D4
	internal Vector3 <DOJump>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass35_0 // TypeDefIndex: 25149
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EF910 Offset: 0x40EB910 VA: 0x40EF910
	public void .ctor() { }

	// RVA: 0x40F64F0 Offset: 0x40F24F0 VA: 0x40F64F0
	internal Vector3 <DOPath>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass36_0 // TypeDefIndex: 25150
{
	// Fields
	public Transform trans; // 0x10
	public Rigidbody target; // 0x18

	// Methods

	// RVA: 0x40EFBC4 Offset: 0x40EBBC4 VA: 0x40EFBC4
	public void .ctor() { }

	// RVA: 0x40F650C Offset: 0x40F250C VA: 0x40F650C
	internal Vector3 <DOLocalPath>b__0() { }

	// RVA: 0x40F6528 Offset: 0x40F2528 VA: 0x40F6528
	internal void <DOLocalPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass37_0 // TypeDefIndex: 25151
{
	// Fields
	public Rigidbody target; // 0x10

	// Methods

	// RVA: 0x40EFD8C Offset: 0x40EBD8C VA: 0x40EFD8C
	public void .ctor() { }

	// RVA: 0x40F6614 Offset: 0x40F2614 VA: 0x40F6614
	internal Vector3 <DOPath>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass38_0 // TypeDefIndex: 25152
{
	// Fields
	public Transform trans; // 0x10
	public Rigidbody target; // 0x18

	// Methods

	// RVA: 0x40EFF74 Offset: 0x40EBF74 VA: 0x40EFF74
	public void .ctor() { }

	// RVA: 0x40F6630 Offset: 0x40F2630 VA: 0x40F6630
	internal Vector3 <DOLocalPath>b__0() { }

	// RVA: 0x40F664C Offset: 0x40F264C VA: 0x40F664C
	internal void <DOLocalPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass39_0 // TypeDefIndex: 25153
{
	// Fields
	public TrailRenderer target; // 0x10

	// Methods

	// RVA: 0x40F0100 Offset: 0x40EC100 VA: 0x40F0100
	public void .ctor() { }

	// RVA: 0x40F6738 Offset: 0x40F2738 VA: 0x40F6738
	internal Vector2 <DOResize>b__0() { }

	// RVA: 0x40F6780 Offset: 0x40F2780 VA: 0x40F6780
	internal void <DOResize>b__1(Vector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass40_0 // TypeDefIndex: 25154
{
	// Fields
	public TrailRenderer target; // 0x10

	// Methods

	// RVA: 0x40F027C Offset: 0x40EC27C VA: 0x40F027C
	public void .ctor() { }

	// RVA: 0x40F67C0 Offset: 0x40F27C0 VA: 0x40F67C0
	internal float <DOTime>b__0() { }

	// RVA: 0x40F67DC Offset: 0x40F27DC VA: 0x40F67DC
	internal void <DOTime>b__1(float x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass41_0 // TypeDefIndex: 25155
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0428 Offset: 0x40EC428 VA: 0x40F0428
	public void .ctor() { }

	// RVA: 0x40F67F8 Offset: 0x40F27F8 VA: 0x40F67F8
	internal Vector3 <DOMove>b__0() { }

	// RVA: 0x40F6814 Offset: 0x40F2814 VA: 0x40F6814
	internal void <DOMove>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass42_0 // TypeDefIndex: 25156
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F05CC Offset: 0x40EC5CC VA: 0x40F05CC
	public void .ctor() { }

	// RVA: 0x40F6830 Offset: 0x40F2830 VA: 0x40F6830
	internal Vector3 <DOMoveX>b__0() { }

	// RVA: 0x40F684C Offset: 0x40F284C VA: 0x40F684C
	internal void <DOMoveX>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass43_0 // TypeDefIndex: 25157
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0770 Offset: 0x40EC770 VA: 0x40F0770
	public void .ctor() { }

	// RVA: 0x40F6868 Offset: 0x40F2868 VA: 0x40F6868
	internal Vector3 <DOMoveY>b__0() { }

	// RVA: 0x40F6884 Offset: 0x40F2884 VA: 0x40F6884
	internal void <DOMoveY>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass44_0 // TypeDefIndex: 25158
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0914 Offset: 0x40EC914 VA: 0x40F0914
	public void .ctor() { }

	// RVA: 0x40F68A0 Offset: 0x40F28A0 VA: 0x40F68A0
	internal Vector3 <DOMoveZ>b__0() { }

	// RVA: 0x40F68BC Offset: 0x40F28BC VA: 0x40F68BC
	internal void <DOMoveZ>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass45_0 // TypeDefIndex: 25159
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0AC0 Offset: 0x40ECAC0 VA: 0x40F0AC0
	public void .ctor() { }

	// RVA: 0x40F68D8 Offset: 0x40F28D8 VA: 0x40F68D8
	internal Vector3 <DOLocalMove>b__0() { }

	// RVA: 0x40F68F4 Offset: 0x40F28F4 VA: 0x40F68F4
	internal void <DOLocalMove>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass46_0 // TypeDefIndex: 25160
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0C64 Offset: 0x40ECC64 VA: 0x40F0C64
	public void .ctor() { }

	// RVA: 0x40F6910 Offset: 0x40F2910 VA: 0x40F6910
	internal Vector3 <DOLocalMoveX>b__0() { }

	// RVA: 0x40F692C Offset: 0x40F292C VA: 0x40F692C
	internal void <DOLocalMoveX>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass47_0 // TypeDefIndex: 25161
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0E08 Offset: 0x40ECE08 VA: 0x40F0E08
	public void .ctor() { }

	// RVA: 0x40F6948 Offset: 0x40F2948 VA: 0x40F6948
	internal Vector3 <DOLocalMoveY>b__0() { }

	// RVA: 0x40F6964 Offset: 0x40F2964 VA: 0x40F6964
	internal void <DOLocalMoveY>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass48_0 // TypeDefIndex: 25162
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F0FAC Offset: 0x40ECFAC VA: 0x40F0FAC
	public void .ctor() { }

	// RVA: 0x40F6980 Offset: 0x40F2980 VA: 0x40F6980
	internal Vector3 <DOLocalMoveZ>b__0() { }

	// RVA: 0x40F699C Offset: 0x40F299C VA: 0x40F699C
	internal void <DOLocalMoveZ>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass49_0 // TypeDefIndex: 25163
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1160 Offset: 0x40ED160 VA: 0x40F1160
	public void .ctor() { }

	// RVA: 0x40F69B8 Offset: 0x40F29B8 VA: 0x40F69B8
	internal Quaternion <DORotate>b__0() { }

	// RVA: 0x40F69D4 Offset: 0x40F29D4 VA: 0x40F69D4
	internal void <DORotate>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass50_0 // TypeDefIndex: 25164
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1344 Offset: 0x40ED344 VA: 0x40F1344
	public void .ctor() { }

	// RVA: 0x40F69F0 Offset: 0x40F29F0 VA: 0x40F69F0
	internal Quaternion <DORotateQuaternion>b__0() { }

	// RVA: 0x40F6A0C Offset: 0x40F2A0C VA: 0x40F6A0C
	internal void <DORotateQuaternion>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass51_0 // TypeDefIndex: 25165
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F14F8 Offset: 0x40ED4F8 VA: 0x40F14F8
	public void .ctor() { }

	// RVA: 0x40F6A28 Offset: 0x40F2A28 VA: 0x40F6A28
	internal Quaternion <DOLocalRotate>b__0() { }

	// RVA: 0x40F6A44 Offset: 0x40F2A44 VA: 0x40F6A44
	internal void <DOLocalRotate>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass52_0 // TypeDefIndex: 25166
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F16DC Offset: 0x40ED6DC VA: 0x40F16DC
	public void .ctor() { }

	// RVA: 0x40F6A60 Offset: 0x40F2A60 VA: 0x40F6A60
	internal Quaternion <DOLocalRotateQuaternion>b__0() { }

	// RVA: 0x40F6A7C Offset: 0x40F2A7C VA: 0x40F6A7C
	internal void <DOLocalRotateQuaternion>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass53_0 // TypeDefIndex: 25167
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1870 Offset: 0x40ED870 VA: 0x40F1870
	public void .ctor() { }

	// RVA: 0x40F6A98 Offset: 0x40F2A98 VA: 0x40F6A98
	internal Vector3 <DOScale>b__0() { }

	// RVA: 0x40F6AB4 Offset: 0x40F2AB4 VA: 0x40F6AB4
	internal void <DOScale>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass54_0 // TypeDefIndex: 25168
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F19F4 Offset: 0x40ED9F4 VA: 0x40F19F4
	public void .ctor() { }

	// RVA: 0x40F6AD0 Offset: 0x40F2AD0 VA: 0x40F6AD0
	internal Vector3 <DOScale>b__0() { }

	// RVA: 0x40F6AEC Offset: 0x40F2AEC VA: 0x40F6AEC
	internal void <DOScale>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass55_0 // TypeDefIndex: 25169
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1B90 Offset: 0x40EDB90 VA: 0x40F1B90
	public void .ctor() { }

	// RVA: 0x40F6B08 Offset: 0x40F2B08 VA: 0x40F6B08
	internal Vector3 <DOScaleX>b__0() { }

	// RVA: 0x40F6B24 Offset: 0x40F2B24 VA: 0x40F6B24
	internal void <DOScaleX>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass56_0 // TypeDefIndex: 25170
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1D2C Offset: 0x40EDD2C VA: 0x40F1D2C
	public void .ctor() { }

	// RVA: 0x40F6B40 Offset: 0x40F2B40 VA: 0x40F6B40
	internal Vector3 <DOScaleY>b__0() { }

	// RVA: 0x40F6B5C Offset: 0x40F2B5C VA: 0x40F6B5C
	internal void <DOScaleY>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass57_0 // TypeDefIndex: 25171
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F1EC8 Offset: 0x40EDEC8 VA: 0x40F1EC8
	public void .ctor() { }

	// RVA: 0x40F6B78 Offset: 0x40F2B78 VA: 0x40F6B78
	internal Vector3 <DOScaleZ>b__0() { }

	// RVA: 0x40F6B94 Offset: 0x40F2B94 VA: 0x40F6B94
	internal void <DOScaleZ>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass58_0 // TypeDefIndex: 25172
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F212C Offset: 0x40EE12C VA: 0x40F212C
	public void .ctor() { }

	// RVA: 0x40F6BB0 Offset: 0x40F2BB0 VA: 0x40F6BB0
	internal Quaternion <DOLookAt>b__0() { }

	// RVA: 0x40F6BCC Offset: 0x40F2BCC VA: 0x40F6BCC
	internal void <DOLookAt>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass59_0 // TypeDefIndex: 25173
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F22FC Offset: 0x40EE2FC VA: 0x40F22FC
	public void .ctor() { }

	// RVA: 0x40F6BE8 Offset: 0x40F2BE8 VA: 0x40F6BE8
	internal Vector3 <DOPunchPosition>b__0() { }

	// RVA: 0x40F6C04 Offset: 0x40F2C04 VA: 0x40F6C04
	internal void <DOPunchPosition>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass60_0 // TypeDefIndex: 25174
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F24C8 Offset: 0x40EE4C8 VA: 0x40F24C8
	public void .ctor() { }

	// RVA: 0x40F6C20 Offset: 0x40F2C20 VA: 0x40F6C20
	internal Vector3 <DOPunchScale>b__0() { }

	// RVA: 0x40F6C3C Offset: 0x40F2C3C VA: 0x40F6C3C
	internal void <DOPunchScale>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass61_0 // TypeDefIndex: 25175
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F267C Offset: 0x40EE67C VA: 0x40F267C
	public void .ctor() { }

	// RVA: 0x40F6C58 Offset: 0x40F2C58 VA: 0x40F6C58
	internal Vector3 <DOPunchRotation>b__0() { }

	// RVA: 0x40F6C74 Offset: 0x40F2C74 VA: 0x40F6C74
	internal void <DOPunchRotation>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass62_0 // TypeDefIndex: 25176
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F2864 Offset: 0x40EE864 VA: 0x40F2864
	public void .ctor() { }

	// RVA: 0x40F6CB0 Offset: 0x40F2CB0 VA: 0x40F6CB0
	internal Vector3 <DOShakePosition>b__0() { }

	// RVA: 0x40F6CCC Offset: 0x40F2CCC VA: 0x40F6CCC
	internal void <DOShakePosition>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass63_0 // TypeDefIndex: 25177
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F2A60 Offset: 0x40EEA60 VA: 0x40F2A60
	public void .ctor() { }

	// RVA: 0x40F6CE8 Offset: 0x40F2CE8 VA: 0x40F6CE8
	internal Vector3 <DOShakePosition>b__0() { }

	// RVA: 0x40F6D04 Offset: 0x40F2D04 VA: 0x40F6D04
	internal void <DOShakePosition>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass64_0 // TypeDefIndex: 25178
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F2C28 Offset: 0x40EEC28 VA: 0x40F2C28
	public void .ctor() { }

	// RVA: 0x40F6D20 Offset: 0x40F2D20 VA: 0x40F6D20
	internal Vector3 <DOShakeRotation>b__0() { }

	// RVA: 0x40F6D3C Offset: 0x40F2D3C VA: 0x40F6D3C
	internal void <DOShakeRotation>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass65_0 // TypeDefIndex: 25179
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F2E04 Offset: 0x40EEE04 VA: 0x40F2E04
	public void .ctor() { }

	// RVA: 0x40F6D78 Offset: 0x40F2D78 VA: 0x40F6D78
	internal Vector3 <DOShakeRotation>b__0() { }

	// RVA: 0x40F6D94 Offset: 0x40F2D94 VA: 0x40F6D94
	internal void <DOShakeRotation>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass66_0 // TypeDefIndex: 25180
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F2FCC Offset: 0x40EEFCC VA: 0x40F2FCC
	public void .ctor() { }

	// RVA: 0x40F6DD0 Offset: 0x40F2DD0 VA: 0x40F6DD0
	internal Vector3 <DOShakeScale>b__0() { }

	// RVA: 0x40F6DEC Offset: 0x40F2DEC VA: 0x40F6DEC
	internal void <DOShakeScale>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass67_0 // TypeDefIndex: 25181
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F31A8 Offset: 0x40EF1A8 VA: 0x40F31A8
	public void .ctor() { }

	// RVA: 0x40F6E08 Offset: 0x40F2E08 VA: 0x40F6E08
	internal Vector3 <DOShakeScale>b__0() { }

	// RVA: 0x40F6E24 Offset: 0x40F2E24 VA: 0x40F6E24
	internal void <DOShakeScale>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass68_0 // TypeDefIndex: 25182
{
	// Fields
	public Transform target; // 0x10
	public bool offsetYSet; // 0x18
	public float offsetY; // 0x1C
	public Sequence s; // 0x20
	public Vector3 endValue; // 0x28
	public float startPosY; // 0x34

	// Methods

	// RVA: 0x40F3660 Offset: 0x40EF660 VA: 0x40F3660
	public void .ctor() { }

	// RVA: 0x40F6E40 Offset: 0x40F2E40 VA: 0x40F6E40
	internal Vector3 <DOJump>b__0() { }

	// RVA: 0x40F6E5C Offset: 0x40F2E5C VA: 0x40F6E5C
	internal void <DOJump>b__1(Vector3 x) { }

	// RVA: 0x40F6E78 Offset: 0x40F2E78 VA: 0x40F6E78
	internal void <DOJump>b__2() { }

	// RVA: 0x40F6F20 Offset: 0x40F2F20 VA: 0x40F6F20
	internal Vector3 <DOJump>b__3() { }

	// RVA: 0x40F6F3C Offset: 0x40F2F3C VA: 0x40F6F3C
	internal void <DOJump>b__4(Vector3 x) { }

	// RVA: 0x40F6F58 Offset: 0x40F2F58 VA: 0x40F6F58
	internal Vector3 <DOJump>b__5() { }

	// RVA: 0x40F6F74 Offset: 0x40F2F74 VA: 0x40F6F74
	internal void <DOJump>b__6(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass69_0 // TypeDefIndex: 25183
{
	// Fields
	public Transform target; // 0x10
	public bool offsetYSet; // 0x18
	public float offsetY; // 0x1C
	public Sequence s; // 0x20
	public Vector3 endValue; // 0x28
	public float startPosY; // 0x34

	// Methods

	// RVA: 0x40F3B18 Offset: 0x40EFB18 VA: 0x40F3B18
	public void .ctor() { }

	// RVA: 0x40F6F90 Offset: 0x40F2F90 VA: 0x40F6F90
	internal Vector3 <DOLocalJump>b__0() { }

	// RVA: 0x40F6FAC Offset: 0x40F2FAC VA: 0x40F6FAC
	internal void <DOLocalJump>b__1(Vector3 x) { }

	// RVA: 0x40F6FC8 Offset: 0x40F2FC8 VA: 0x40F6FC8
	internal void <DOLocalJump>b__2() { }

	// RVA: 0x40F706C Offset: 0x40F306C VA: 0x40F706C
	internal Vector3 <DOLocalJump>b__3() { }

	// RVA: 0x40F7088 Offset: 0x40F3088 VA: 0x40F7088
	internal void <DOLocalJump>b__4(Vector3 x) { }

	// RVA: 0x40F70A4 Offset: 0x40F30A4 VA: 0x40F70A4
	internal Vector3 <DOLocalJump>b__5() { }

	// RVA: 0x40F70C0 Offset: 0x40F30C0 VA: 0x40F70C0
	internal void <DOLocalJump>b__6(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass70_0 // TypeDefIndex: 25184
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F3D38 Offset: 0x40EFD38 VA: 0x40F3D38
	public void .ctor() { }

	// RVA: 0x40F70DC Offset: 0x40F30DC VA: 0x40F70DC
	internal Vector3 <DOPath>b__0() { }

	// RVA: 0x40F70F8 Offset: 0x40F30F8 VA: 0x40F70F8
	internal void <DOPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass71_0 // TypeDefIndex: 25185
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F3F60 Offset: 0x40EFF60 VA: 0x40F3F60
	public void .ctor() { }

	// RVA: 0x40F7114 Offset: 0x40F3114 VA: 0x40F7114
	internal Vector3 <DOLocalPath>b__0() { }

	// RVA: 0x40F7130 Offset: 0x40F3130 VA: 0x40F7130
	internal void <DOLocalPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass72_0 // TypeDefIndex: 25186
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F411C Offset: 0x40F011C VA: 0x40F411C
	public void .ctor() { }

	// RVA: 0x40F714C Offset: 0x40F314C VA: 0x40F714C
	internal Vector3 <DOPath>b__0() { }

	// RVA: 0x40F7168 Offset: 0x40F3168 VA: 0x40F7168
	internal void <DOPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass73_0 // TypeDefIndex: 25187
{
	// Fields
	public Transform target; // 0x10

	// Methods

	// RVA: 0x40F42E0 Offset: 0x40F02E0 VA: 0x40F42E0
	public void .ctor() { }

	// RVA: 0x40F7184 Offset: 0x40F3184 VA: 0x40F7184
	internal Vector3 <DOLocalPath>b__0() { }

	// RVA: 0x40F71A0 Offset: 0x40F31A0 VA: 0x40F71A0
	internal void <DOLocalPath>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass74_0 // TypeDefIndex: 25188
{
	// Fields
	public Color to; // 0x10
	public Light target; // 0x20

	// Methods

	// RVA: 0x40F44DC Offset: 0x40F04DC VA: 0x40F44DC
	public void .ctor() { }

	// RVA: 0x40F71BC Offset: 0x40F31BC VA: 0x40F71BC
	internal Color <DOBlendableColor>b__0() { }

	// RVA: 0x40F71C8 Offset: 0x40F31C8 VA: 0x40F71C8
	internal void <DOBlendableColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass75_0 // TypeDefIndex: 25189
{
	// Fields
	public Color to; // 0x10
	public Material target; // 0x20

	// Methods

	// RVA: 0x40F46D8 Offset: 0x40F06D8 VA: 0x40F46D8
	public void .ctor() { }

	// RVA: 0x40F7234 Offset: 0x40F3234 VA: 0x40F7234
	internal Color <DOBlendableColor>b__0() { }

	// RVA: 0x40F7240 Offset: 0x40F3240 VA: 0x40F7240
	internal void <DOBlendableColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass76_0 // TypeDefIndex: 25190
{
	// Fields
	public Color to; // 0x10
	public Material target; // 0x20
	public string property; // 0x28

	// Methods

	// RVA: 0x40F4934 Offset: 0x40F0934 VA: 0x40F4934
	public void .ctor() { }

	// RVA: 0x40F72AC Offset: 0x40F32AC VA: 0x40F72AC
	internal Color <DOBlendableColor>b__0() { }

	// RVA: 0x40F72B8 Offset: 0x40F32B8 VA: 0x40F72B8
	internal void <DOBlendableColor>b__1(Color x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass77_0 // TypeDefIndex: 25191
{
	// Fields
	public Vector3 to; // 0x10
	public Transform target; // 0x20

	// Methods

	// RVA: 0x40F4B3C Offset: 0x40F0B3C VA: 0x40F4B3C
	public void .ctor() { }

	// RVA: 0x40F7338 Offset: 0x40F3338 VA: 0x40F7338
	internal Vector3 <DOBlendableMoveBy>b__0() { }

	// RVA: 0x40F7344 Offset: 0x40F3344 VA: 0x40F7344
	internal void <DOBlendableMoveBy>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass78_0 // TypeDefIndex: 25192
{
	// Fields
	public Vector3 to; // 0x10
	public Transform target; // 0x20

	// Methods

	// RVA: 0x40F4D44 Offset: 0x40F0D44 VA: 0x40F4D44
	public void .ctor() { }

	// RVA: 0x40F73A8 Offset: 0x40F33A8 VA: 0x40F73A8
	internal Vector3 <DOBlendableLocalMoveBy>b__0() { }

	// RVA: 0x40F73B4 Offset: 0x40F33B4 VA: 0x40F73B4
	internal void <DOBlendableLocalMoveBy>b__1(Vector3 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass79_0 // TypeDefIndex: 25193
{
	// Fields
	public Quaternion to; // 0x10
	public Transform target; // 0x20

	// Methods

	// RVA: 0x40F4F24 Offset: 0x40F0F24 VA: 0x40F4F24
	public void .ctor() { }

	// RVA: 0x40F7418 Offset: 0x40F3418 VA: 0x40F7418
	internal Quaternion <DOBlendableRotateBy>b__0() { }

	// RVA: 0x40F7424 Offset: 0x40F3424 VA: 0x40F7424
	internal void <DOBlendableRotateBy>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass80_0 // TypeDefIndex: 25194
{
	// Fields
	public Quaternion to; // 0x10
	public Transform target; // 0x20

	// Methods

	// RVA: 0x40F5104 Offset: 0x40F1104 VA: 0x40F5104
	public void .ctor() { }

	// RVA: 0x40F76C4 Offset: 0x40F36C4 VA: 0x40F76C4
	internal Quaternion <DOBlendableLocalRotateBy>b__0() { }

	// RVA: 0x40F76D0 Offset: 0x40F36D0 VA: 0x40F76D0
	internal void <DOBlendableLocalRotateBy>b__1(Quaternion x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShortcutExtensions.<>c__DisplayClass81_0 // TypeDefIndex: 25195
{
	// Fields
	public Vector3 to; // 0x10
	public Transform target; // 0x20

	// Methods

	// RVA: 0x40F52F4 Offset: 0x40F12F4 VA: 0x40F52F4
	public void .ctor() { }

	// RVA: 0x40F7970 Offset: 0x40F3970 VA: 0x40F7970
	internal Vector3 <DOBlendableScaleBy>b__0() { }

	// RVA: 0x40F797C Offset: 0x40F397C VA: 0x40F797C
	internal void <DOBlendableScaleBy>b__1(Vector3 x) { }
}

// Namespace: DG.Tweening
[Extension]
public static class ShortcutExtensions // TypeDefIndex: 25196
{
	// Methods

	[Extension]
	// RVA: 0x40EB768 Offset: 0x40E7768 VA: 0x40EB768
	public static Tweener DOFade(AudioSource target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EB90C Offset: 0x40E790C VA: 0x40EB90C
	public static Tweener DOPitch(AudioSource target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EBA88 Offset: 0x40E7A88 VA: 0x40EBA88
	public static Tweener DOAspect(Camera target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EBC04 Offset: 0x40E7C04 VA: 0x40EBC04
	public static Tweener DOColor(Camera target, Color endValue, float duration) { }

	[Extension]
	// RVA: 0x40EBDA8 Offset: 0x40E7DA8 VA: 0x40EBDA8
	public static Tweener DOFarClipPlane(Camera target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EBF24 Offset: 0x40E7F24 VA: 0x40EBF24
	public static Tweener DOFieldOfView(Camera target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EC0A0 Offset: 0x40E80A0 VA: 0x40EC0A0
	public static Tweener DONearClipPlane(Camera target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EC21C Offset: 0x40E821C VA: 0x40EC21C
	public static Tweener DOOrthoSize(Camera target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40EC398 Offset: 0x40E8398 VA: 0x40EC398
	public static Tweener DOPixelRect(Camera target, Rect endValue, float duration) { }

	[Extension]
	// RVA: 0x40EC53C Offset: 0x40E853C VA: 0x40EC53C
	public static Tweener DORect(Camera target, Rect endValue, float duration) { }

	[Extension]
	// RVA: 0x40EC6E0 Offset: 0x40E86E0 VA: 0x40EC6E0
	public static Tweener DOShakePosition(Camera target, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40EC8A8 Offset: 0x40E88A8 VA: 0x40EC8A8
	public static Tweener DOShakePosition(Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40ECA84 Offset: 0x40E8A84 VA: 0x40ECA84
	public static Tweener DOShakeRotation(Camera target, float duration, float strength = 90, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40ECC4C Offset: 0x40E8C4C VA: 0x40ECC4C
	public static Tweener DOShakeRotation(Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40ECE28 Offset: 0x40E8E28 VA: 0x40ECE28
	public static Tweener DOColor(Light target, Color endValue, float duration) { }

	[Extension]
	// RVA: 0x40ECFCC Offset: 0x40E8FCC VA: 0x40ECFCC
	public static Tweener DOIntensity(Light target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40ED148 Offset: 0x40E9148 VA: 0x40ED148
	public static Tweener DOShadowStrength(Light target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40ED2C4 Offset: 0x40E92C4 VA: 0x40ED2C4
	public static Tweener DOColor(LineRenderer target, Color2 startValue, Color2 endValue, float duration) { }

	[Extension]
	// RVA: 0x40ED474 Offset: 0x40E9474 VA: 0x40ED474
	public static Tweener DOColor(Material target, Color endValue, float duration) { }

	[Extension]
	// RVA: 0x40ED618 Offset: 0x40E9618 VA: 0x40ED618
	public static Tweener DOColor(Material target, Color endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40ED830 Offset: 0x40E9830 VA: 0x40ED830
	public static Tweener DOFade(Material target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40ED9AC Offset: 0x40E99AC VA: 0x40ED9AC
	public static Tweener DOFade(Material target, float endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40EDB94 Offset: 0x40E9B94 VA: 0x40EDB94
	public static Tweener DOFloat(Material target, float endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40EDD7C Offset: 0x40E9D7C VA: 0x40EDD7C
	public static Tweener DOOffset(Material target, Vector2 endValue, float duration) { }

	[Extension]
	// RVA: 0x40EDF08 Offset: 0x40E9F08 VA: 0x40EDF08
	public static Tweener DOOffset(Material target, Vector2 endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40EE104 Offset: 0x40EA104 VA: 0x40EE104
	public static Tweener DOTiling(Material target, Vector2 endValue, float duration) { }

	[Extension]
	// RVA: 0x40EE290 Offset: 0x40EA290 VA: 0x40EE290
	public static Tweener DOTiling(Material target, Vector2 endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40EE48C Offset: 0x40EA48C VA: 0x40EE48C
	public static Tweener DOVector(Material target, Vector4 endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40EE6A4 Offset: 0x40EA6A4 VA: 0x40EE6A4
	public static Tweener DOMove(Rigidbody target, Vector3 endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EE86C Offset: 0x40EA86C VA: 0x40EE86C
	public static Tweener DOMoveX(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EEA30 Offset: 0x40EAA30 VA: 0x40EEA30
	public static Tweener DOMoveY(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EEBD8 Offset: 0x40EABD8 VA: 0x40EEBD8
	public static Tweener DOMoveZ(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EED80 Offset: 0x40EAD80 VA: 0x40EED80
	public static Tweener DORotate(Rigidbody target, Vector3 endValue, float duration, RotateMode mode = 0) { }

	[Extension]
	// RVA: 0x40EEF38 Offset: 0x40EAF38 VA: 0x40EEF38
	public static Tweener DOLookAt(Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = 0, Nullable<Vector3> up) { }

	[Extension]
	// RVA: 0x40EF1A0 Offset: 0x40EB1A0 VA: 0x40EF1A0
	public static Sequence DOJump(Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EF6CC Offset: 0x40EB6CC VA: 0x40EF6CC
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[Extension]
	// RVA: 0x40EF958 Offset: 0x40EB958 VA: 0x40EF958
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[Extension]
	// RVA: 0x40EFBCC Offset: 0x40EBBCC VA: 0x40EFBCC
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(Rigidbody target, Path path, float duration, PathMode pathMode = 1) { }

	[Extension]
	// RVA: 0x40EFD94 Offset: 0x40EBD94 VA: 0x40EFD94
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Rigidbody target, Path path, float duration, PathMode pathMode = 1) { }

	[Extension]
	// RVA: 0x40EFF7C Offset: 0x40EBF7C VA: 0x40EFF7C
	public static Tweener DOResize(TrailRenderer target, float toStartWidth, float toEndWidth, float duration) { }

	[Extension]
	// RVA: 0x40F0108 Offset: 0x40EC108 VA: 0x40F0108
	public static Tweener DOTime(TrailRenderer target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40F0284 Offset: 0x40EC284 VA: 0x40F0284
	public static Tweener DOMove(Transform target, Vector3 endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0430 Offset: 0x40EC430 VA: 0x40F0430
	public static Tweener DOMoveX(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F05D4 Offset: 0x40EC5D4 VA: 0x40F05D4
	public static Tweener DOMoveY(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0778 Offset: 0x40EC778 VA: 0x40F0778
	public static Tweener DOMoveZ(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F091C Offset: 0x40EC91C VA: 0x40F091C
	public static Tweener DOLocalMove(Transform target, Vector3 endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0AC8 Offset: 0x40ECAC8 VA: 0x40F0AC8
	public static Tweener DOLocalMoveX(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0C6C Offset: 0x40ECC6C VA: 0x40F0C6C
	public static Tweener DOLocalMoveY(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0E10 Offset: 0x40ECE10 VA: 0x40F0E10
	public static Tweener DOLocalMoveZ(Transform target, float endValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F0FB4 Offset: 0x40ECFB4 VA: 0x40F0FB4
	public static Tweener DORotate(Transform target, Vector3 endValue, float duration, RotateMode mode = 0) { }

	[Extension]
	// RVA: 0x40F1168 Offset: 0x40ED168 VA: 0x40F1168
	public static Tweener DORotateQuaternion(Transform target, Quaternion endValue, float duration) { }

	[Extension]
	// RVA: 0x40F134C Offset: 0x40ED34C VA: 0x40F134C
	public static Tweener DOLocalRotate(Transform target, Vector3 endValue, float duration, RotateMode mode = 0) { }

	[Extension]
	// RVA: 0x40F1500 Offset: 0x40ED500 VA: 0x40F1500
	public static Tweener DOLocalRotateQuaternion(Transform target, Quaternion endValue, float duration) { }

	[Extension]
	// RVA: 0x40F16E4 Offset: 0x40ED6E4 VA: 0x40F16E4
	public static Tweener DOScale(Transform target, Vector3 endValue, float duration) { }

	[Extension]
	// RVA: 0x40F1878 Offset: 0x40ED878 VA: 0x40F1878
	public static Tweener DOScale(Transform target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40F19FC Offset: 0x40ED9FC VA: 0x40F19FC
	public static Tweener DOScaleX(Transform target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40F1B98 Offset: 0x40EDB98 VA: 0x40F1B98
	public static Tweener DOScaleY(Transform target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40F1D34 Offset: 0x40EDD34 VA: 0x40F1D34
	public static Tweener DOScaleZ(Transform target, float endValue, float duration) { }

	[Extension]
	// RVA: 0x40F1ED0 Offset: 0x40EDED0 VA: 0x40F1ED0
	public static Tweener DOLookAt(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = 0, Nullable<Vector3> up) { }

	[Extension]
	// RVA: 0x40F2134 Offset: 0x40EE134 VA: 0x40F2134
	public static Tweener DOPunchPosition(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F231C Offset: 0x40EE31C VA: 0x40F231C
	public static Tweener DOPunchScale(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1) { }

	[Extension]
	// RVA: 0x40F24D0 Offset: 0x40EE4D0 VA: 0x40F24D0
	public static Tweener DOPunchRotation(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1) { }

	[Extension]
	// RVA: 0x40F2684 Offset: 0x40EE684 VA: 0x40F2684
	public static Tweener DOShakePosition(Transform target, float duration, float strength = 1, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F286C Offset: 0x40EE86C VA: 0x40F286C
	public static Tweener DOShakePosition(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F2A68 Offset: 0x40EEA68 VA: 0x40F2A68
	public static Tweener DOShakeRotation(Transform target, float duration, float strength = 90, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F2C30 Offset: 0x40EEC30 VA: 0x40F2C30
	public static Tweener DOShakeRotation(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F2E0C Offset: 0x40EEE0C VA: 0x40F2E0C
	public static Tweener DOShakeScale(Transform target, float duration, float strength = 1, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F2FD4 Offset: 0x40EEFD4 VA: 0x40F2FD4
	public static Tweener DOShakeScale(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	[Extension]
	// RVA: 0x40F31B0 Offset: 0x40EF1B0 VA: 0x40F31B0
	public static Sequence DOJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F3668 Offset: 0x40EF668 VA: 0x40F3668
	public static Sequence DOLocalJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F3B20 Offset: 0x40EFB20 VA: 0x40F3B20
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(Transform target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[Extension]
	// RVA: 0x40F3D40 Offset: 0x40EFD40 VA: 0x40F3D40
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Transform target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[Extension]
	// RVA: 0x40F3F68 Offset: 0x40EFF68 VA: 0x40F3F68
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(Transform target, Path path, float duration, PathMode pathMode = 1) { }

	[Extension]
	// RVA: 0x40F4124 Offset: 0x40F0124 VA: 0x40F4124
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Transform target, Path path, float duration, PathMode pathMode = 1) { }

	[Extension]
	// RVA: 0x40F42E8 Offset: 0x40F02E8 VA: 0x40F42E8
	public static Tweener DOBlendableColor(Light target, Color endValue, float duration) { }

	[Extension]
	// RVA: 0x40F44E4 Offset: 0x40F04E4 VA: 0x40F44E4
	public static Tweener DOBlendableColor(Material target, Color endValue, float duration) { }

	[Extension]
	// RVA: 0x40F46E0 Offset: 0x40F06E0 VA: 0x40F46E0
	public static Tweener DOBlendableColor(Material target, Color endValue, string property, float duration) { }

	[Extension]
	// RVA: 0x40F493C Offset: 0x40F093C VA: 0x40F493C
	public static Tweener DOBlendableMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F4B44 Offset: 0x40F0B44 VA: 0x40F4B44
	public static Tweener DOBlendableLocalMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F4D4C Offset: 0x40F0D4C VA: 0x40F4D4C
	public static Tweener DOBlendableRotateBy(Transform target, Vector3 byValue, float duration, RotateMode mode = 0) { }

	[Extension]
	// RVA: 0x40F4F2C Offset: 0x40F0F2C VA: 0x40F4F2C
	public static Tweener DOBlendableLocalRotateBy(Transform target, Vector3 byValue, float duration, RotateMode mode = 0) { }

	[Extension]
	// RVA: 0x40F510C Offset: 0x40F110C VA: 0x40F510C
	public static Tweener DOBlendableScaleBy(Transform target, Vector3 byValue, float duration) { }

	[Extension]
	// RVA: 0x40F52FC Offset: 0x40F12FC VA: 0x40F52FC
	public static int DOComplete(Component target, bool withCallbacks = False) { }

	[Extension]
	// RVA: 0x40F5360 Offset: 0x40F1360 VA: 0x40F5360
	public static int DOComplete(Material target, bool withCallbacks = False) { }

	[Extension]
	// RVA: 0x40F53C4 Offset: 0x40F13C4 VA: 0x40F53C4
	public static int DOKill(Component target, bool complete = False) { }

	[Extension]
	// RVA: 0x40F5428 Offset: 0x40F1428 VA: 0x40F5428
	public static int DOKill(Material target, bool complete = False) { }

	[Extension]
	// RVA: 0x40F548C Offset: 0x40F148C VA: 0x40F548C
	public static int DOFlip(Component target) { }

	[Extension]
	// RVA: 0x40F54E0 Offset: 0x40F14E0 VA: 0x40F54E0
	public static int DOFlip(Material target) { }

	[Extension]
	// RVA: 0x40F5534 Offset: 0x40F1534 VA: 0x40F5534
	public static int DOGoto(Component target, float to, bool andPlay = False) { }

	[Extension]
	// RVA: 0x40F55A8 Offset: 0x40F15A8 VA: 0x40F55A8
	public static int DOGoto(Material target, float to, bool andPlay = False) { }

	[Extension]
	// RVA: 0x40F561C Offset: 0x40F161C VA: 0x40F561C
	public static int DOPause(Component target) { }

	[Extension]
	// RVA: 0x40F5670 Offset: 0x40F1670 VA: 0x40F5670
	public static int DOPause(Material target) { }

	[Extension]
	// RVA: 0x40F56C4 Offset: 0x40F16C4 VA: 0x40F56C4
	public static int DOPlay(Component target) { }

	[Extension]
	// RVA: 0x40F5718 Offset: 0x40F1718 VA: 0x40F5718
	public static int DOPlay(Material target) { }

	[Extension]
	// RVA: 0x40F576C Offset: 0x40F176C VA: 0x40F576C
	public static int DOPlayBackwards(Component target) { }

	[Extension]
	// RVA: 0x40F57C0 Offset: 0x40F17C0 VA: 0x40F57C0
	public static int DOPlayBackwards(Material target) { }

	[Extension]
	// RVA: 0x40F5814 Offset: 0x40F1814 VA: 0x40F5814
	public static int DOPlayForward(Component target) { }

	[Extension]
	// RVA: 0x40F5868 Offset: 0x40F1868 VA: 0x40F5868
	public static int DOPlayForward(Material target) { }

	[Extension]
	// RVA: 0x40F58BC Offset: 0x40F18BC VA: 0x40F58BC
	public static int DORestart(Component target, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40F5920 Offset: 0x40F1920 VA: 0x40F5920
	public static int DORestart(Material target, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40F5984 Offset: 0x40F1984 VA: 0x40F5984
	public static int DORewind(Component target, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40F59E8 Offset: 0x40F19E8 VA: 0x40F59E8
	public static int DORewind(Material target, bool includeDelay = True) { }

	[Extension]
	// RVA: 0x40F5A4C Offset: 0x40F1A4C VA: 0x40F5A4C
	public static int DOSmoothRewind(Component target) { }

	[Extension]
	// RVA: 0x40F5AA0 Offset: 0x40F1AA0 VA: 0x40F5AA0
	public static int DOSmoothRewind(Material target) { }

	[Extension]
	// RVA: 0x40F5AF4 Offset: 0x40F1AF4 VA: 0x40F5AF4
	public static int DOTogglePause(Component target) { }

	[Extension]
	// RVA: 0x40F5B48 Offset: 0x40F1B48 VA: 0x40F5B48
	public static int DOTogglePause(Material target) { }
}

// Namespace: DG.Tweening
public class TweenParams // TypeDefIndex: 25197
{
	// Fields
	public static readonly TweenParams Params; // 0x0
	internal object id; // 0x10
	internal object target; // 0x18
	internal UpdateType updateType; // 0x20
	internal bool isIndependentUpdate; // 0x24
	internal TweenCallback onStart; // 0x28
	internal TweenCallback onPlay; // 0x30
	internal TweenCallback onRewind; // 0x38
	internal TweenCallback onUpdate; // 0x40
	internal TweenCallback onStepComplete; // 0x48
	internal TweenCallback onComplete; // 0x50
	internal TweenCallback onKill; // 0x58
	internal TweenCallback<int> onWaypointChange; // 0x60
	internal bool isRecyclable; // 0x68
	internal bool isSpeedBased; // 0x69
	internal bool autoKill; // 0x6A
	internal int loops; // 0x6C
	internal LoopType loopType; // 0x70
	internal float delay; // 0x74
	internal bool isRelative; // 0x78
	internal Ease easeType; // 0x7C
	internal EaseFunction customEase; // 0x80
	internal float easeOvershootOrAmplitude; // 0x88
	internal float easePeriod; // 0x8C

	// Methods

	// RVA: 0x40F79E0 Offset: 0x40F39E0 VA: 0x40F79E0
	public void .ctor() { }

	// RVA: 0x40F79FC Offset: 0x40F39FC VA: 0x40F79FC
	public TweenParams Clear() { }

	// RVA: 0x40F7B5C Offset: 0x40F3B5C VA: 0x40F7B5C
	public TweenParams SetAutoKill(bool autoKillOnCompletion = True) { }

	// RVA: 0x40F7B68 Offset: 0x40F3B68 VA: 0x40F7B68
	public TweenParams SetId(object id) { }

	// RVA: 0x40F7B84 Offset: 0x40F3B84 VA: 0x40F7B84
	public TweenParams SetTarget(object target) { }

	// RVA: 0x40F7BA0 Offset: 0x40F3BA0 VA: 0x40F7BA0
	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType) { }

	// RVA: 0x40F7C30 Offset: 0x40F3C30 VA: 0x40F7C30
	public TweenParams SetEase(Ease ease, Nullable<float> overshootOrAmplitude, Nullable<float> period) { }

	// RVA: 0x40F7D3C Offset: 0x40F3D3C VA: 0x40F7D3C
	public TweenParams SetEase(AnimationCurve animCurve) { }

	// RVA: 0x40F7E04 Offset: 0x40F3E04 VA: 0x40F7E04
	public TweenParams SetEase(EaseFunction customEase) { }

	// RVA: 0x40F7E28 Offset: 0x40F3E28 VA: 0x40F7E28
	public TweenParams SetRecyclable(bool recyclable = True) { }

	// RVA: 0x40F7E34 Offset: 0x40F3E34 VA: 0x40F7E34
	public TweenParams SetUpdate(bool isIndependentUpdate) { }

	// RVA: 0x40F7EAC Offset: 0x40F3EAC VA: 0x40F7EAC
	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = False) { }

	// RVA: 0x40F7EBC Offset: 0x40F3EBC VA: 0x40F7EBC
	public TweenParams OnStart(TweenCallback action) { }

	// RVA: 0x40F7ED8 Offset: 0x40F3ED8 VA: 0x40F7ED8
	public TweenParams OnPlay(TweenCallback action) { }

	// RVA: 0x40F7EF4 Offset: 0x40F3EF4 VA: 0x40F7EF4
	public TweenParams OnRewind(TweenCallback action) { }

	// RVA: 0x40F7F10 Offset: 0x40F3F10 VA: 0x40F7F10
	public TweenParams OnUpdate(TweenCallback action) { }

	// RVA: 0x40F7F2C Offset: 0x40F3F2C VA: 0x40F7F2C
	public TweenParams OnStepComplete(TweenCallback action) { }

	// RVA: 0x40F7F48 Offset: 0x40F3F48 VA: 0x40F7F48
	public TweenParams OnComplete(TweenCallback action) { }

	// RVA: 0x40F7F64 Offset: 0x40F3F64 VA: 0x40F7F64
	public TweenParams OnKill(TweenCallback action) { }

	// RVA: 0x40F7F80 Offset: 0x40F3F80 VA: 0x40F7F80
	public TweenParams OnWaypointChange(TweenCallback<int> action) { }

	// RVA: 0x40F7F9C Offset: 0x40F3F9C VA: 0x40F7F9C
	public TweenParams SetDelay(float delay) { }

	// RVA: 0x40F7FA4 Offset: 0x40F3FA4 VA: 0x40F7FA4
	public TweenParams SetRelative(bool isRelative = True) { }

	// RVA: 0x40F7FB0 Offset: 0x40F3FB0 VA: 0x40F7FB0
	public TweenParams SetSpeedBased(bool isSpeedBased = True) { }

	// RVA: 0x40F7FBC Offset: 0x40F3FBC VA: 0x40F7FBC
	private static void .cctor() { }
}

// Namespace: DG.Tweening
[Extension]
public static class TweenSettingsExtensions // TypeDefIndex: 25198
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetAutoKill<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727AFC Offset: 0x4723AFC VA: 0x4727AFC
	|-TweenSettingsExtensions.SetAutoKill<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetAutoKill<T>(T t, bool autoKillOnCompletion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727B20 Offset: 0x4723B20 VA: 0x4727B20
	|-TweenSettingsExtensions.SetAutoKill<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetId<T>(T t, object id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727E48 Offset: 0x4723E48 VA: 0x4727E48
	|-TweenSettingsExtensions.SetId<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetTarget<T>(T t, object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4728004 Offset: 0x4724004 VA: 0x4728004
	|-TweenSettingsExtensions.SetTarget<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetLoops<T>(T t, int loops) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727E74 Offset: 0x4723E74 VA: 0x4727E74
	|-TweenSettingsExtensions.SetLoops<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetLoops<T>(T t, int loops, LoopType loopType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727ECC Offset: 0x4723ECC VA: 0x4727ECC
	|-TweenSettingsExtensions.SetLoops<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetEase<T>(T t, Ease ease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727CAC Offset: 0x4723CAC VA: 0x4727CAC
	|-TweenSettingsExtensions.SetEase<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetEase<T>(T t, Ease ease, float overshoot) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727D4C Offset: 0x4723D4C VA: 0x4727D4C
	|-TweenSettingsExtensions.SetEase<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetEase<T>(T t, Ease ease, float amplitude, float period) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727DC8 Offset: 0x4723DC8 VA: 0x4727DC8
	|-TweenSettingsExtensions.SetEase<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetEase<T>(T t, AnimationCurve animCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727BE4 Offset: 0x4723BE4 VA: 0x4727BE4
	|-TweenSettingsExtensions.SetEase<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetEase<T>(T t, EaseFunction customEase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727D18 Offset: 0x4723D18 VA: 0x4727D18
	|-TweenSettingsExtensions.SetEase<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetRecyclable<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727F24 Offset: 0x4723F24 VA: 0x4727F24
	|-TweenSettingsExtensions.SetRecyclable<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetRecyclable<T>(T t, bool recyclable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727F3C Offset: 0x4723F3C VA: 0x4727F3C
	|-TweenSettingsExtensions.SetRecyclable<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetUpdate<T>(T t, bool isIndependentUpdate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4728030 Offset: 0x4724030 VA: 0x4728030
	|-TweenSettingsExtensions.SetUpdate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetUpdate<T>(T t, UpdateType updateType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47280DC Offset: 0x47240DC VA: 0x47280DC
	|-TweenSettingsExtensions.SetUpdate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetUpdate<T>(T t, UpdateType updateType, bool isIndependentUpdate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x472818C Offset: 0x472418C VA: 0x472818C
	|-TweenSettingsExtensions.SetUpdate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnStart<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727680 Offset: 0x4723680 VA: 0x4727680
	|-TweenSettingsExtensions.OnStart<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnPlay<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727628 Offset: 0x4723628 VA: 0x4727628
	|-TweenSettingsExtensions.OnPlay<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnPause<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47275FC Offset: 0x47235FC VA: 0x47275FC
	|-TweenSettingsExtensions.OnPause<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnRewind<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727654 Offset: 0x4723654 VA: 0x4727654
	|-TweenSettingsExtensions.OnRewind<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnUpdate<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47276D8 Offset: 0x47236D8 VA: 0x47276D8
	|-TweenSettingsExtensions.OnUpdate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnStepComplete<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47276AC Offset: 0x47236AC VA: 0x47276AC
	|-TweenSettingsExtensions.OnStepComplete<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnComplete<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47275A4 Offset: 0x47235A4 VA: 0x47275A4
	|-TweenSettingsExtensions.OnComplete<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnKill<T>(T t, TweenCallback action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47275D0 Offset: 0x47235D0 VA: 0x47275D0
	|-TweenSettingsExtensions.OnKill<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T OnWaypointChange<T>(T t, TweenCallback<int> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727704 Offset: 0x4723704 VA: 0x4727704
	|-TweenSettingsExtensions.OnWaypointChange<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetAs<T>(T t, Tween asTween) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727730 Offset: 0x4723730 VA: 0x4727730
	|-TweenSettingsExtensions.SetAs<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetAs<T>(T t, TweenParams tweenParams) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47278FC Offset: 0x47238FC VA: 0x47278FC
	|-TweenSettingsExtensions.SetAs<object>
	*/

	[Extension]
	// RVA: 0x40EF654 Offset: 0x40EB654 VA: 0x40EF654
	public static Sequence Append(Sequence s, Tween t) { }

	[Extension]
	// RVA: 0x40F802C Offset: 0x40F402C VA: 0x40F802C
	public static Sequence Prepend(Sequence s, Tween t) { }

	[Extension]
	// RVA: 0x40EF690 Offset: 0x40EB690 VA: 0x40EF690
	public static Sequence Join(Sequence s, Tween t) { }

	[Extension]
	// RVA: 0x40F8064 Offset: 0x40F4064 VA: 0x40F8064
	public static Sequence Insert(Sequence s, float atPosition, Tween t) { }

	[Extension]
	// RVA: 0x40E7F8C Offset: 0x40E3F8C VA: 0x40E7F8C
	public static Sequence AppendInterval(Sequence s, float interval) { }

	[Extension]
	// RVA: 0x40F809C Offset: 0x40F409C VA: 0x40F809C
	public static Sequence PrependInterval(Sequence s, float interval) { }

	[Extension]
	// RVA: 0x40F80C0 Offset: 0x40F40C0 VA: 0x40F80C0
	public static Sequence AppendCallback(Sequence s, TweenCallback callback) { }

	[Extension]
	// RVA: 0x40F80EC Offset: 0x40F40EC VA: 0x40F80EC
	public static Sequence PrependCallback(Sequence s, TweenCallback callback) { }

	[Extension]
	// RVA: 0x40F8118 Offset: 0x40F4118 VA: 0x40F8118
	public static Sequence InsertCallback(Sequence s, float atPosition, TweenCallback callback) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T From<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47274D8 Offset: 0x47234D8 VA: 0x47274D8
	|-TweenSettingsExtensions.From<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T From<T>(T t, bool isRelative) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727528 Offset: 0x4723528 VA: 0x4727528
	|-TweenSettingsExtensions.From<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetDelay<T>(T t, float delay) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727B44 Offset: 0x4723B44 VA: 0x4727B44
	|-TweenSettingsExtensions.SetDelay<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetRelative<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727F54 Offset: 0x4723F54 VA: 0x4727F54
	|-TweenSettingsExtensions.SetRelative<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetRelative<T>(T t, bool isRelative) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727F88 Offset: 0x4723F88 VA: 0x4727F88
	|-TweenSettingsExtensions.SetRelative<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetSpeedBased<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727FBC Offset: 0x4723FBC VA: 0x4727FBC
	|-TweenSettingsExtensions.SetSpeedBased<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T SetSpeedBased<T>(T t, bool isSpeedBased) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4727FE0 Offset: 0x4723FE0 VA: 0x4727FE0
	|-TweenSettingsExtensions.SetSpeedBased<object>
	*/

	[Extension]
	// RVA: 0x40F8140 Offset: 0x40F4140 VA: 0x40F8140
	public static Tweener SetOptions(TweenerCore<float, float, FloatOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40F8158 Offset: 0x40F4158 VA: 0x40F8158
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40F8170 Offset: 0x40F4170 VA: 0x40F8170
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = False) { }

	[Extension]
	// RVA: 0x40EE854 Offset: 0x40EA854 VA: 0x40EE854
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40EEA14 Offset: 0x40EAA14 VA: 0x40EEA14
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F818C Offset: 0x40F418C VA: 0x40F818C
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40F81A4 Offset: 0x40F41A4 VA: 0x40F81A4
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F81C0 Offset: 0x40F41C0 VA: 0x40F81C0
	public static Tweener SetOptions(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = True) { }

	[Extension]
	// RVA: 0x40E5408 Offset: 0x40E1408 VA: 0x40E5408
	public static Tweener SetOptions(TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly) { }

	[Extension]
	// RVA: 0x40F81DC Offset: 0x40F41DC VA: 0x40F81DC
	public static Tweener SetOptions(TweenerCore<Rect, Rect, RectOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40F81F4 Offset: 0x40F41F4 VA: 0x40F81F4
	public static Tweener SetOptions(TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = 0, string scrambleChars) { }

	[Extension]
	// RVA: 0x40F2304 Offset: 0x40EE304 VA: 0x40F2304
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping) { }

	[Extension]
	// RVA: 0x40F82DC Offset: 0x40F42DC VA: 0x40F82DC
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = False) { }

	[Extension]
	// RVA: 0x40F82F8 Offset: 0x40F42F8 VA: 0x40F82F8
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = 0) { }

	[Extension]
	// RVA: 0x40F8314 Offset: 0x40F4314 VA: 0x40F8314
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = 0, AxisConstraint lockRotation = 0) { }

	[Extension]
	// RVA: 0x40F8334 Offset: 0x40F4334 VA: 0x40F8334
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Nullable<Vector3> forwardDirection, Nullable<Vector3> up) { }

	[Extension]
	// RVA: 0x40F86A0 Offset: 0x40F46A0 VA: 0x40F86A0
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Nullable<Vector3> forwardDirection, Nullable<Vector3> up) { }

	[Extension]
	// RVA: 0x40F870C Offset: 0x40F470C VA: 0x40F870C
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Nullable<Vector3> forwardDirection, Nullable<Vector3> up) { }

	[Extension]
	// RVA: 0x40F8370 Offset: 0x40F4370 VA: 0x40F8370
	private static void SetPathForwardDirection(TweenerCore<Vector3, Path, PathOptions> t, Nullable<Vector3> forwardDirection, Nullable<Vector3> up) { }
}

// Namespace: DG.Tweening
public enum LogBehaviour // TypeDefIndex: 25199
{
	// Fields
	public int value__; // 0x0
	public const LogBehaviour Default = 0;
	public const LogBehaviour Verbose = 1;
	public const LogBehaviour ErrorsOnly = 2;
}

// Namespace: DG.Tweening
public abstract class Tween : ABSSequentiable // TypeDefIndex: 25200
{
	// Fields
	public float timeScale; // 0x28
	public bool isBackwards; // 0x2C
	public object id; // 0x30
	public object target; // 0x38
	internal UpdateType updateType; // 0x40
	internal bool isIndependentUpdate; // 0x44
	internal TweenCallback onPlay; // 0x48
	internal TweenCallback onPause; // 0x50
	internal TweenCallback onRewind; // 0x58
	internal TweenCallback onUpdate; // 0x60
	internal TweenCallback onStepComplete; // 0x68
	internal TweenCallback onComplete; // 0x70
	internal TweenCallback onKill; // 0x78
	internal TweenCallback<int> onWaypointChange; // 0x80
	internal bool isFrom; // 0x88
	internal bool isBlendable; // 0x89
	internal bool isRecyclable; // 0x8A
	internal bool isSpeedBased; // 0x8B
	internal bool autoKill; // 0x8C
	internal float duration; // 0x90
	internal int loops; // 0x94
	internal LoopType loopType; // 0x98
	internal float delay; // 0x9C
	internal bool isRelative; // 0xA0
	internal Ease easeType; // 0xA4
	internal EaseFunction customEase; // 0xA8
	public float easeOvershootOrAmplitude; // 0xB0
	public float easePeriod; // 0xB4
	internal Type typeofT1; // 0xB8
	internal Type typeofT2; // 0xC0
	internal Type typeofTPlugOptions; // 0xC8
	internal bool active; // 0xD0
	internal bool isSequenced; // 0xD1
	internal Sequence sequenceParent; // 0xD8
	internal int activeId; // 0xE0
	internal SpecialStartupMode specialStartupMode; // 0xE4
	internal bool creationLocked; // 0xE8
	internal bool startupDone; // 0xE9
	internal bool playedOnce; // 0xEA
	internal float position; // 0xEC
	internal float fullDuration; // 0xF0
	internal int completedLoops; // 0xF4
	internal bool isPlaying; // 0xF8
	internal bool isComplete; // 0xF9
	internal float elapsedDelay; // 0xFC
	internal bool delayComplete; // 0x100
	internal int miscInt; // 0x104

	// Properties
	public float fullPosition { get; set; }

	// Methods

	// RVA: 0x40F874C Offset: 0x40F474C VA: 0x40F874C
	public float get_fullPosition() { }

	// RVA: 0x40F8754 Offset: 0x40F4754 VA: 0x40F8754
	public void set_fullPosition(float value) { }

	// RVA: 0x40EA9DC Offset: 0x40E69DC VA: 0x40EA9DC Slot: 4
	internal virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Validate();

	// RVA: 0x40F875C Offset: 0x40F475C VA: 0x40F875C Slot: 6
	internal virtual float UpdateDelay(float elapsed) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract bool Startup();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

	// RVA: 0x40F8764 Offset: 0x40F4764 VA: 0x40F8764
	internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) { }

	// RVA: 0x40EB508 Offset: 0x40E7508 VA: 0x40EB508
	internal static bool OnTweenCallback(TweenCallback callback) { }

	// RVA: -1 Offset: -1
	internal static bool OnTweenCallback<T>(TweenCallback<T> callback, T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47204AC Offset: 0x471C4AC VA: 0x47204AC
	|-Tween.OnTweenCallback<int>
	|
	|-RVA: 0x4720608 Offset: 0x471C608 VA: 0x4720608
	|-Tween.OnTweenCallback<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x40EA430 Offset: 0x40E6430 VA: 0x40EA430
	protected void .ctor() { }
}

// Namespace: DG.Tweening
public abstract class Tweener : Tween // TypeDefIndex: 25201
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x108
	internal bool isFromAllowed; // 0x109

	// Methods

	// RVA: 0x40F8A64 Offset: 0x40F4A64 VA: 0x40F8A64
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative);

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4732D60 Offset: 0x472ED60 VA: 0x4732D60
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x4732F18 Offset: 0x472EF18 VA: 0x4732F18
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x47330B0 Offset: 0x472F0B0 VA: 0x47330B0
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x4733240 Offset: 0x472F240 VA: 0x4733240
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x47333D0 Offset: 0x472F3D0 VA: 0x47333D0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x4733560 Offset: 0x472F560 VA: 0x4733560
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x47336FC Offset: 0x472F6FC VA: 0x47336FC
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x4733898 Offset: 0x472F898 VA: 0x4733898
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x4733A50 Offset: 0x472FA50 VA: 0x4733A50
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4733BF8 Offset: 0x472FBF8 VA: 0x4733BF8
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x4733DB0 Offset: 0x472FDB0 VA: 0x4733DB0
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x4733F40 Offset: 0x472FF40 VA: 0x4733F40
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x47340D0 Offset: 0x47300D0 VA: 0x47340D0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x4734260 Offset: 0x4730260 VA: 0x4734260
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x4734400 Offset: 0x4730400 VA: 0x4734400
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x473459C Offset: 0x473059C VA: 0x473459C
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4734738 Offset: 0x4730738 VA: 0x4734738
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x47348E0 Offset: 0x47308E0 VA: 0x47348E0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x4734A98 Offset: 0x4730A98 VA: 0x4734A98
	|-Tweener.Setup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47328EC Offset: 0x472E8EC VA: 0x47328EC
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x4732928 Offset: 0x472E928 VA: 0x4732928
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x4732964 Offset: 0x472E964 VA: 0x4732964
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x47329A0 Offset: 0x472E9A0 VA: 0x47329A0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x47329DC Offset: 0x472E9DC VA: 0x47329DC
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x4732A18 Offset: 0x472EA18 VA: 0x4732A18
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x4732A54 Offset: 0x472EA54 VA: 0x4732A54
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x4732A90 Offset: 0x472EA90 VA: 0x4732A90
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x4732ACC Offset: 0x472EACC VA: 0x4732ACC
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4732B08 Offset: 0x472EB08 VA: 0x4732B08
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x4732B44 Offset: 0x472EB44 VA: 0x4732B44
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x4732B80 Offset: 0x472EB80 VA: 0x4732B80
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x4732BBC Offset: 0x472EBBC VA: 0x4732BBC
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x4732BF8 Offset: 0x472EBF8 VA: 0x4732BF8
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x4732C34 Offset: 0x472EC34 VA: 0x4732C34
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x4732C70 Offset: 0x472EC70 VA: 0x4732C70
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4732CAC Offset: 0x472ECAC VA: 0x4732CAC
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x4732CE8 Offset: 0x472ECE8 VA: 0x4732CE8
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x4732D24 Offset: 0x472ED24 VA: 0x4732D24
	|-Tweener.DoUpdateDelay<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47302BC Offset: 0x472C2BC VA: 0x47302BC
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x47304A4 Offset: 0x472C4A4 VA: 0x47304A4
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x47306E4 Offset: 0x472C6E4 VA: 0x47306E4
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x47308BC Offset: 0x472C8BC VA: 0x47308BC
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x4730A9C Offset: 0x472CA9C VA: 0x4730A9C
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x4730C7C Offset: 0x472CC7C VA: 0x4730C7C
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x4730E78 Offset: 0x472CE78 VA: 0x4730E78
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x4731074 Offset: 0x472D074 VA: 0x4731074
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x473125C Offset: 0x472D25C VA: 0x473125C
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4731440 Offset: 0x472D440 VA: 0x4731440
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x4731628 Offset: 0x472D628 VA: 0x4731628
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x4731800 Offset: 0x472D800 VA: 0x4731800
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x47319E0 Offset: 0x472D9E0 VA: 0x47319E0
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x4731BC0 Offset: 0x472DBC0 VA: 0x4731BC0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x4731DA0 Offset: 0x472DDA0 VA: 0x4731DA0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x4731F98 Offset: 0x472DF98 VA: 0x4731F98
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4732190 Offset: 0x472E190 VA: 0x4732190
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x4732374 Offset: 0x472E374 VA: 0x4732374
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x473255C Offset: 0x472E55C VA: 0x473255C
	|-Tweener.DoStartup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static Tweener DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x472E068 Offset: 0x472A068 VA: 0x472E068
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x472E148 Offset: 0x472A148 VA: 0x472E148
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x472E210 Offset: 0x472A210 VA: 0x472E210
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x472E2C8 Offset: 0x472A2C8 VA: 0x472E2C8
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x472E388 Offset: 0x472A388 VA: 0x472E388
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x472E448 Offset: 0x472A448 VA: 0x472E448
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x472E514 Offset: 0x472A514 VA: 0x472E514
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x472E5E0 Offset: 0x472A5E0 VA: 0x472E5E0
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x472E6C0 Offset: 0x472A6C0 VA: 0x472E6C0
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x472E790 Offset: 0x472A790 VA: 0x472E790
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x472E870 Offset: 0x472A870 VA: 0x472E870
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x472E928 Offset: 0x472A928 VA: 0x472E928
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x472E9E8 Offset: 0x472A9E8 VA: 0x472E9E8
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x472EAA8 Offset: 0x472AAA8 VA: 0x472EAA8
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x472EB70 Offset: 0x472AB70 VA: 0x472EB70
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x472EC3C Offset: 0x472AC3C VA: 0x472EC3C
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x472ED08 Offset: 0x472AD08 VA: 0x472ED08
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x472EDD8 Offset: 0x472ADD8 VA: 0x472EDD8
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x472EEB8 Offset: 0x472AEB8 VA: 0x472EEB8
	|-Tweener.DoChangeStartValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static Tweener DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x472B47C Offset: 0x472747C VA: 0x472B47C
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x472B6C4 Offset: 0x47276C4 VA: 0x472B6C4
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x472B954 Offset: 0x4727954 VA: 0x472B954
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x472BB64 Offset: 0x4727B64 VA: 0x472BB64
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x472BD84 Offset: 0x4727D84 VA: 0x472BD84
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x472BFA4 Offset: 0x4727FA4 VA: 0x472BFA4
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x472C1EC Offset: 0x47281EC VA: 0x472C1EC
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x472C434 Offset: 0x4728434 VA: 0x472C434
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x472C67C Offset: 0x472867C VA: 0x472C67C
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x472C8B0 Offset: 0x47288B0 VA: 0x472C8B0
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x472CAF8 Offset: 0x4728AF8 VA: 0x472CAF8
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x472CD08 Offset: 0x4728D08 VA: 0x472CD08
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x472CF28 Offset: 0x4728F28 VA: 0x472CF28
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x472D148 Offset: 0x4729148 VA: 0x472D148
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x472D370 Offset: 0x4729370 VA: 0x472D370
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x472D5B4 Offset: 0x47295B4 VA: 0x472D5B4
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x472D7F8 Offset: 0x47297F8 VA: 0x472D7F8
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x472DA2C Offset: 0x4729A2C VA: 0x472DA2C
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x472DC74 Offset: 0x4729C74 VA: 0x472DC74
	|-Tweener.DoChangeEndValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static Tweener DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x472F04C Offset: 0x472B04C VA: 0x472F04C
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x472F15C Offset: 0x472B15C VA: 0x472F15C
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x472F23C Offset: 0x472B23C VA: 0x472F23C
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x472F308 Offset: 0x472B308 VA: 0x472F308
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x472F3D8 Offset: 0x472B3D8 VA: 0x472F3D8
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x472F4A4 Offset: 0x472B4A4 VA: 0x472F4A4
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x472F58C Offset: 0x472B58C VA: 0x472F58C
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x472F674 Offset: 0x472B674 VA: 0x472F674
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x472F784 Offset: 0x472B784 VA: 0x472F784
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x472F884 Offset: 0x472B884 VA: 0x472F884
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x472F994 Offset: 0x472B994 VA: 0x472F994
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x472FA64 Offset: 0x472BA64 VA: 0x472FA64
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x472FB34 Offset: 0x472BB34 VA: 0x472FB34
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x472FC00 Offset: 0x472BC00 VA: 0x472FC00
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x472FCE8 Offset: 0x472BCE8 VA: 0x472FCE8
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x472FDD0 Offset: 0x472BDD0 VA: 0x472FDD0
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x472FEB8 Offset: 0x472BEB8 VA: 0x472FEB8
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x472FFB8 Offset: 0x472BFB8 VA: 0x472FFB8
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x47300C8 Offset: 0x472C0C8 VA: 0x47300C8
	|-Tweener.DoChangeValues<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4728C1C Offset: 0x4724C1C VA: 0x4728C1C
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x4728E3C Offset: 0x4724E3C VA: 0x4728E3C
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x472905C Offset: 0x472505C VA: 0x472905C
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x472927C Offset: 0x472527C VA: 0x472927C
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x472949C Offset: 0x472549C VA: 0x472949C
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x47296BC Offset: 0x47256BC VA: 0x47296BC
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x47298DC Offset: 0x47258DC VA: 0x47298DC
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x4729AFC Offset: 0x4725AFC VA: 0x4729AFC
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x4729D1C Offset: 0x4725D1C VA: 0x4729D1C
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4729F3C Offset: 0x4725F3C VA: 0x4729F3C
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x472A15C Offset: 0x472615C VA: 0x472A15C
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x472A37C Offset: 0x472637C VA: 0x472A37C
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x472A59C Offset: 0x472659C VA: 0x472A59C
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x472A7BC Offset: 0x47267BC VA: 0x472A7BC
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x472A9DC Offset: 0x47269DC VA: 0x472A9DC
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x472ABFC Offset: 0x4726BFC VA: 0x472ABFC
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x472AE1C Offset: 0x4726E1C VA: 0x472AE1C
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x472B03C Offset: 0x472703C VA: 0x472B03C
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x472B25C Offset: 0x472725C VA: 0x472B25C
	|-Tweener.DOStartupSpecials<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4728210 Offset: 0x4724210 VA: 0x4728210
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x4728284 Offset: 0x4724284 VA: 0x4728284
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x472830C Offset: 0x472430C VA: 0x472830C
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x4728374 Offset: 0x4724374 VA: 0x4728374
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x47283DC Offset: 0x47243DC VA: 0x47283DC
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x4728444 Offset: 0x4724444 VA: 0x4728444
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x47284AC Offset: 0x47244AC VA: 0x47284AC
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x4728544 Offset: 0x4724544 VA: 0x4728544
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x47285B8 Offset: 0x47245B8 VA: 0x47285B8
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4728654 Offset: 0x4724654 VA: 0x4728654
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x47286C8 Offset: 0x47246C8 VA: 0x47286C8
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x4728730 Offset: 0x4724730 VA: 0x4728730
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x4728798 Offset: 0x4724798 VA: 0x4728798
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x4728800 Offset: 0x4724800 VA: 0x4728800
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x4728870 Offset: 0x4724870 VA: 0x4728870
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x4728930 Offset: 0x4724930 VA: 0x4728930
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4728998 Offset: 0x4724998 VA: 0x4728998
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x4728A08 Offset: 0x4724A08 VA: 0x4728A08
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x4728A80 Offset: 0x4724A80 VA: 0x4728A80
	|-Tweener.DOStartupDurationBased<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: DG.Tweening
public enum TweenType // TypeDefIndex: 25202
{
	// Fields
	public int value__; // 0x0
	public const TweenType Tweener = 0;
	public const TweenType Sequence = 1;
	public const TweenType Callback = 2;
}

// Namespace: DG.Tweening
public enum UpdateType // TypeDefIndex: 25203
{
	// Fields
	public int value__; // 0x0
	public const UpdateType Normal = 0;
	public const UpdateType Late = 1;
	public const UpdateType Fixed = 2;
}

// Namespace: DG.Tweening.Plugins
internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 25204
{
	// Methods

	// RVA: 0x40F8A84 Offset: 0x40F4A84 VA: 0x40F8A84 Slot: 4
	public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t) { }

	// RVA: 0x40F8A88 Offset: 0x40F4A88 VA: 0x40F8A88 Slot: 5
	public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative) { }

	// RVA: 0x40F8BD8 Offset: 0x40F4BD8 VA: 0x40F8BD8 Slot: 6
	public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value) { }

	// RVA: 0x40F8BE4 Offset: 0x40F4BE4 VA: 0x40F8BE4 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t) { }

	// RVA: 0x40F8C10 Offset: 0x40F4C10 VA: 0x40F8C10 Slot: 8
	public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t) { }

	// RVA: 0x40F8C3C Offset: 0x40F4C3C VA: 0x40F8C3C Slot: 9
	public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) { }

	// RVA: 0x40F8C48 Offset: 0x40F4C48 VA: 0x40F8C48 Slot: 10
	public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40F8EBC Offset: 0x40F4EBC VA: 0x40F8EBC
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 25205
{
	// Methods

	// RVA: 0x40F8F04 Offset: 0x40F4F04 VA: 0x40F8F04 Slot: 4
	public override void Reset(TweenerCore<double, double, NoOptions> t) { }

	// RVA: 0x40F8F08 Offset: 0x40F4F08 VA: 0x40F8F08 Slot: 5
	public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative) { }

	// RVA: 0x40F8F78 Offset: 0x40F4F78 VA: 0x40F8F78 Slot: 6
	public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value) { }

	// RVA: 0x40F8F7C Offset: 0x40F4F7C VA: 0x40F8F7C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t) { }

	// RVA: 0x40F8F9C Offset: 0x40F4F9C VA: 0x40F8F9C Slot: 8
	public override void SetChangeValue(TweenerCore<double, double, NoOptions> t) { }

	// RVA: 0x40F8FBC Offset: 0x40F4FBC VA: 0x40F8FBC Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue) { }

	// RVA: 0x40F8FD4 Offset: 0x40F4FD4 VA: 0x40F8FD4 Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40F90AC Offset: 0x40F50AC VA: 0x40F90AC
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 25206
{
	// Methods

	// RVA: 0x40F90F4 Offset: 0x40F50F4 VA: 0x40F90F4 Slot: 4
	public override void Reset(TweenerCore<long, long, NoOptions> t) { }

	// RVA: 0x40F90F8 Offset: 0x40F50F8 VA: 0x40F90F8 Slot: 5
	public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative) { }

	// RVA: 0x40F915C Offset: 0x40F515C VA: 0x40F915C Slot: 6
	public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value) { }

	// RVA: 0x40F9164 Offset: 0x40F5164 VA: 0x40F9164 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t) { }

	// RVA: 0x40F9184 Offset: 0x40F5184 VA: 0x40F9184 Slot: 8
	public override void SetChangeValue(TweenerCore<long, long, NoOptions> t) { }

	// RVA: 0x40F91A4 Offset: 0x40F51A4 VA: 0x40F91A4 Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) { }

	// RVA: 0x40F91BC Offset: 0x40F51BC VA: 0x40F91BC Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40F9374 Offset: 0x40F5374 VA: 0x40F9374
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 25207
{
	// Methods

	// RVA: 0x40F93BC Offset: 0x40F53BC VA: 0x40F93BC Slot: 4
	public override void Reset(TweenerCore<ulong, ulong, NoOptions> t) { }

	// RVA: 0x40F93C0 Offset: 0x40F53C0 VA: 0x40F93C0 Slot: 5
	public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative) { }

	// RVA: 0x40F9424 Offset: 0x40F5424 VA: 0x40F9424 Slot: 6
	public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value) { }

	// RVA: 0x40F942C Offset: 0x40F542C VA: 0x40F942C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t) { }

	// RVA: 0x40F944C Offset: 0x40F544C VA: 0x40F944C Slot: 8
	public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t) { }

	// RVA: 0x40F946C Offset: 0x40F546C VA: 0x40F946C Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue) { }

	// RVA: 0x40F9488 Offset: 0x40F5488 VA: 0x40F9488 Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40F9608 Offset: 0x40F5608 VA: 0x40F9608
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 25208
{
	// Methods

	// RVA: 0x40F9650 Offset: 0x40F5650 VA: 0x40F9650 Slot: 4
	public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x40F9694 Offset: 0x40F5694 VA: 0x40F9694 Slot: 5
	public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative) { }

	// RVA: 0x40F9698 Offset: 0x40F5698 VA: 0x40F9698 Slot: 6
	public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value) { }

	// RVA: 0x40F9798 Offset: 0x40F5798 VA: 0x40F9798 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x40F9880 Offset: 0x40F5880 VA: 0x40F9880 Slot: 8
	public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x40F9980 Offset: 0x40F5980 VA: 0x40F9980 Slot: 9
	public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue) { }

	// RVA: 0x40F9A90 Offset: 0x40F5A90 VA: 0x40F9A90 Slot: 10
	public override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40FA290 Offset: 0x40F6290 VA: 0x40FA290
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 25209
{
	// Fields
	public const float MinLookAhead = 0.0001;

	// Methods

	// RVA: 0x40FA2D8 Offset: 0x40F62D8 VA: 0x40FA2D8 Slot: 4
	public override void Reset(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x40FA338 Offset: 0x40F6338 VA: 0x40FA338 Slot: 5
	public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) { }

	// RVA: 0x40EF918 Offset: 0x40EB918 VA: 0x40EF918
	public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() { }

	// RVA: 0x40FA33C Offset: 0x40F633C VA: 0x40FA33C Slot: 6
	public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) { }

	// RVA: 0x40FA354 Offset: 0x40F6354 VA: 0x40FA354 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x40FA40C Offset: 0x40F640C VA: 0x40FA40C Slot: 8
	public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x40FA72C Offset: 0x40F672C VA: 0x40FA72C Slot: 9
	public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) { }

	// RVA: 0x40FA748 Offset: 0x40F6748 VA: 0x40FA748 Slot: 10
	public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x40FA994 Offset: 0x40F6994 VA: 0x40FA994
	public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) { }

	// RVA: 0x40FB288 Offset: 0x40F7288 VA: 0x40FB288
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions> // TypeDefIndex: 25210
{
	// Methods

	// RVA: 0x4101F70 Offset: 0x40FDF70 VA: 0x4101F70 Slot: 4
	public override void Reset(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x4101F74 Offset: 0x40FDF74 VA: 0x4101F74 Slot: 5
	public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative) { }

	// RVA: 0x4102050 Offset: 0x40FE050 VA: 0x4102050 Slot: 6
	public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value) { }

	// RVA: 0x4102054 Offset: 0x40FE054 VA: 0x4102054 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x4102078 Offset: 0x40FE078 VA: 0x4102078 Slot: 8
	public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x410209C Offset: 0x40FE09C VA: 0x410209C Slot: 9
	public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue) { }

	// RVA: 0x41020A8 Offset: 0x40FE0A8 VA: 0x41020A8 Slot: 10
	public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4102C90 Offset: 0x40FEC90 VA: 0x4102C90
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 25211
{
	// Methods

	// RVA: 0x4102CD8 Offset: 0x40FECD8 VA: 0x4102CD8 Slot: 4
	public override void Reset(TweenerCore<int, int, NoOptions> t) { }

	// RVA: 0x4102CDC Offset: 0x40FECDC VA: 0x4102CDC Slot: 5
	public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative) { }

	// RVA: 0x4102D44 Offset: 0x40FED44 VA: 0x4102D44 Slot: 6
	public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value) { }

	// RVA: 0x4102D4C Offset: 0x40FED4C VA: 0x4102D4C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t) { }

	// RVA: 0x4102D70 Offset: 0x40FED70 VA: 0x4102D70 Slot: 8
	public override void SetChangeValue(TweenerCore<int, int, NoOptions> t) { }

	// RVA: 0x4102D94 Offset: 0x40FED94 VA: 0x4102D94 Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) { }

	// RVA: 0x4102DAC Offset: 0x40FEDAC VA: 0x4102DAC Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4102F58 Offset: 0x40FEF58 VA: 0x4102F58
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 25212
{
	// Methods

	// RVA: 0x4102FA0 Offset: 0x40FEFA0 VA: 0x4102FA0 Slot: 4
	public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x4102FA4 Offset: 0x40FEFA4 VA: 0x4102FA4 Slot: 5
	public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative) { }

	// RVA: 0x410335C Offset: 0x40FF35C VA: 0x410335C Slot: 6
	public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value) { }

	// RVA: 0x4103388 Offset: 0x40FF388 VA: 0x4103388 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x41033C0 Offset: 0x40FF3C0 VA: 0x41033C0 Slot: 8
	public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x410356C Offset: 0x40FF56C VA: 0x410356C Slot: 9
	public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue) { }

	// RVA: 0x41035EC Offset: 0x40FF5EC VA: 0x41035EC Slot: 10
	public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4103A14 Offset: 0x40FFA14 VA: 0x4103A14
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 25213
{
	// Fields
	private static RectOffset _r; // 0x0

	// Methods

	// RVA: 0x4103A5C Offset: 0x40FFA5C VA: 0x4103A5C Slot: 4
	public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

	// RVA: 0x4103AA0 Offset: 0x40FFAA0 VA: 0x4103AA0 Slot: 5
	public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative) { }

	// RVA: 0x4103C1C Offset: 0x40FFC1C VA: 0x4103C1C Slot: 6
	public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value) { }

	// RVA: 0x4103CD8 Offset: 0x40FFCD8 VA: 0x4103CD8 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

	// RVA: 0x4103DE4 Offset: 0x40FFDE4 VA: 0x4103DE4 Slot: 8
	public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

	// RVA: 0x4103F3C Offset: 0x40FFF3C VA: 0x4103F3C Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) { }

	// RVA: 0x4103FF8 Offset: 0x40FFFF8 VA: 0x4103FF8 Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4104718 Offset: 0x4100718 VA: 0x4104718
	public void .ctor() { }

	// RVA: 0x4104760 Offset: 0x4100760 VA: 0x4104760
	private static void .cctor() { }
}

// Namespace: DG.Tweening.Plugins
public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 25214
{
	// Methods

	// RVA: 0x41047DC Offset: 0x41007DC VA: 0x41047DC Slot: 4
	public override void Reset(TweenerCore<Rect, Rect, RectOptions> t) { }

	// RVA: 0x41047E0 Offset: 0x41007E0 VA: 0x41047E0 Slot: 5
	public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative) { }

	// RVA: 0x4104AD8 Offset: 0x4100AD8 VA: 0x4104AD8 Slot: 6
	public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value) { }

	// RVA: 0x4104ADC Offset: 0x4100ADC VA: 0x4104ADC Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t) { }

	// RVA: 0x4104B00 Offset: 0x4100B00 VA: 0x4104B00 Slot: 8
	public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t) { }

	// RVA: 0x4104B24 Offset: 0x4100B24 VA: 0x4104B24 Slot: 9
	public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) { }

	// RVA: 0x4104BA0 Offset: 0x4100BA0 VA: 0x4104BA0 Slot: 10
	public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4104F50 Offset: 0x4100F50 VA: 0x4104F50
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 25215
{
	// Methods

	// RVA: 0x4104F98 Offset: 0x4100F98 VA: 0x4104F98 Slot: 4
	public override void Reset(TweenerCore<uint, uint, UintOptions> t) { }

	// RVA: 0x4104F9C Offset: 0x4100F9C VA: 0x4104F9C Slot: 5
	public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative) { }

	// RVA: 0x4105004 Offset: 0x4101004 VA: 0x4105004 Slot: 6
	public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value) { }

	// RVA: 0x410500C Offset: 0x410100C VA: 0x410500C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t) { }

	// RVA: 0x4105030 Offset: 0x4101030 VA: 0x4105030 Slot: 8
	public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t) { }

	// RVA: 0x4105064 Offset: 0x4101064 VA: 0x4105064 Slot: 9
	public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) { }

	// RVA: 0x410507C Offset: 0x410107C VA: 0x410507C Slot: 10
	public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4105258 Offset: 0x4101258 VA: 0x4105258
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 25216
{
	// Methods

	// RVA: 0x41052A0 Offset: 0x41012A0 VA: 0x41052A0 Slot: 4
	public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x41052A4 Offset: 0x41012A4 VA: 0x41052A4 Slot: 5
	public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative) { }

	// RVA: 0x4105478 Offset: 0x4101478 VA: 0x4105478 Slot: 6
	public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) { }

	// RVA: 0x410547C Offset: 0x410147C VA: 0x410547C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x41054A0 Offset: 0x41014A0 VA: 0x41054A0 Slot: 8
	public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x4105508 Offset: 0x4101508 VA: 0x4105508 Slot: 9
	public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) { }

	// RVA: 0x410557C Offset: 0x410157C VA: 0x410557C Slot: 10
	public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x410595C Offset: 0x410195C VA: 0x410595C
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 25217
{
	// Methods

	// RVA: 0x41059A4 Offset: 0x41019A4 VA: 0x41059A4 Slot: 4
	public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x41059A8 Offset: 0x41019A8 VA: 0x41059A8 Slot: 5
	public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative) { }

	// RVA: 0x4105CC8 Offset: 0x4101CC8 VA: 0x4105CC8 Slot: 6
	public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) { }

	// RVA: 0x4105CCC Offset: 0x4101CCC VA: 0x4105CCC Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x4105CF0 Offset: 0x4101CF0 VA: 0x4105CF0 Slot: 8
	public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x4105DD8 Offset: 0x4101DD8 VA: 0x4105DD8 Slot: 9
	public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) { }

	// RVA: 0x4105E6C Offset: 0x4101E6C VA: 0x4105E6C Slot: 10
	public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x410658C Offset: 0x410258C VA: 0x410658C
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 25218
{
	// Fields
	private static readonly StringBuilder _Buffer; // 0x0
	private static readonly List<char> _OpenedTags; // 0x8

	// Methods

	// RVA: 0x41065D4 Offset: 0x41025D4 VA: 0x41065D4 Slot: 5
	public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative) { }

	// RVA: 0x4106650 Offset: 0x4102650 VA: 0x4106650 Slot: 4
	public override void Reset(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x4106694 Offset: 0x4102694 VA: 0x4106694 Slot: 6
	public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value) { }

	// RVA: 0x410669C Offset: 0x410269C VA: 0x410669C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x41066A0 Offset: 0x41026A0 VA: 0x41066A0 Slot: 8
	public override void SetChangeValue(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x410677C Offset: 0x410277C VA: 0x410677C Slot: 9
	public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) { }

	// RVA: 0x41067BC Offset: 0x41027BC VA: 0x41067BC Slot: 10
	public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4106C34 Offset: 0x4102C34 VA: 0x4106C34
	private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) { }

	// RVA: 0x41072F0 Offset: 0x41032F0 VA: 0x41072F0
	private char[] ScrambledCharsToUse(StringOptions options) { }

	// RVA: 0x410751C Offset: 0x410351C VA: 0x410751C
	public void .ctor() { }

	// RVA: 0x4107564 Offset: 0x4103564 VA: 0x4107564
	private static void .cctor() { }
}

// Namespace: DG.Tweening.Plugins
[Extension]
internal static class StringPluginExtensions // TypeDefIndex: 25219
{
	// Fields
	public static readonly char[] ScrambledCharsAll; // 0x0
	public static readonly char[] ScrambledCharsUppercase; // 0x8
	public static readonly char[] ScrambledCharsLowercase; // 0x10
	public static readonly char[] ScrambledCharsNumerals; // 0x18
	private static int _lastRndSeed; // 0x20

	// Methods

	// RVA: 0x4107638 Offset: 0x4103638 VA: 0x4107638
	private static void .cctor() { }

	[Extension]
	// RVA: 0x41077EC Offset: 0x41037EC VA: 0x41077EC
	internal static void ScrambleChars(char[] chars) { }

	[Extension]
	// RVA: 0x41073F4 Offset: 0x41033F4 VA: 0x41073F4
	internal static StringBuilder AppendScrambledChars(StringBuilder buffer, int length, char[] chars) { }
}

// Namespace: DG.Tweening.Plugins
public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 25220
{
	// Methods

	// RVA: 0x410788C Offset: 0x410388C VA: 0x410788C Slot: 4
	public override void Reset(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x4107890 Offset: 0x4103890 VA: 0x4107890 Slot: 5
	public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative) { }

	// RVA: 0x41079BC Offset: 0x41039BC VA: 0x41079BC Slot: 6
	public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value) { }

	// RVA: 0x41079C0 Offset: 0x41039C0 VA: 0x41079C0 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x41079E4 Offset: 0x41039E4 VA: 0x41079E4 Slot: 8
	public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x4107A08 Offset: 0x4103A08 VA: 0x4107A08 Slot: 9
	public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) { }

	// RVA: 0x4107A1C Offset: 0x4103A1C VA: 0x4107A1C Slot: 10
	public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4107BD0 Offset: 0x4103BD0 VA: 0x4107BD0
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins
public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 25221
{
	// Methods

	// RVA: 0x4107C18 Offset: 0x4103C18 VA: 0x4107C18 Slot: 4
	public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	// RVA: 0x4107C1C Offset: 0x4103C1C VA: 0x4107C1C Slot: 5
	public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative) { }

	// RVA: 0x4107E98 Offset: 0x4103E98 VA: 0x4107E98 Slot: 6
	public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) { }

	// RVA: 0x4107E9C Offset: 0x4103E9C VA: 0x4107E9C Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	// RVA: 0x4107ED4 Offset: 0x4103ED4 VA: 0x4107ED4 Slot: 8
	public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	// RVA: 0x4107F78 Offset: 0x4103F78 VA: 0x4107F78 Slot: 9
	public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) { }

	// RVA: 0x4107FF8 Offset: 0x4103FF8 VA: 0x4107FF8 Slot: 10
	public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x4108570 Offset: 0x4104570 VA: 0x4108570
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins.Options
public interface IPlugOptions // TypeDefIndex: 25222
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();
}

// Namespace: DG.Tweening.Plugins.Options
public enum OrientType // TypeDefIndex: 25223
{
	// Fields
	public int value__; // 0x0
	public const OrientType None = 0;
	public const OrientType ToPath = 1;
	public const OrientType LookAtTransform = 2;
	public const OrientType LookAtPosition = 3;
}

// Namespace: DG.Tweening.Plugins.Options
public struct PathOptions : IPlugOptions // TypeDefIndex: 25224
{
	// Fields
	public PathMode mode; // 0x0
	public OrientType orientType; // 0x4
	public AxisConstraint lockPositionAxis; // 0x8
	public AxisConstraint lockRotationAxis; // 0xC
	public bool isClosedPath; // 0x10
	public Vector3 lookAtPosition; // 0x14
	public Transform lookAtTransform; // 0x20
	public float lookAhead; // 0x28
	public bool hasCustomForwardDirection; // 0x2C
	public Quaternion forward; // 0x30
	public bool useLocalPosition; // 0x40
	public Transform parent; // 0x48
	public bool isRigidbody; // 0x50
	internal Quaternion startupRot; // 0x54
	internal float startupZRot; // 0x64

	// Methods

	// RVA: 0x41085B8 Offset: 0x41045B8 VA: 0x41085B8 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct QuaternionOptions : IPlugOptions // TypeDefIndex: 25225
{
	// Fields
	internal RotateMode rotateMode; // 0x0
	internal AxisConstraint axisConstraint; // 0x4
	internal Vector3 up; // 0x8

	// Methods

	// RVA: 0x41086B0 Offset: 0x41046B0 VA: 0x41086B0 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct UintOptions : IPlugOptions // TypeDefIndex: 25226
{
	// Fields
	public bool isNegativeChangeValue; // 0x0

	// Methods

	// RVA: 0x410870C Offset: 0x410470C VA: 0x410870C Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct Vector3ArrayOptions : IPlugOptions // TypeDefIndex: 25227
{
	// Fields
	public AxisConstraint axisConstraint; // 0x0
	public bool snapping; // 0x4
	internal float[] durations; // 0x8

	// Methods

	// RVA: 0x4108714 Offset: 0x4104714 VA: 0x4108714 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct NoOptions : IPlugOptions // TypeDefIndex: 25228
{
	// Methods

	// RVA: 0x4108728 Offset: 0x4104728 VA: 0x4108728 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct ColorOptions : IPlugOptions // TypeDefIndex: 25229
{
	// Fields
	public bool alphaOnly; // 0x0

	// Methods

	// RVA: 0x410872C Offset: 0x410472C VA: 0x410872C Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct FloatOptions : IPlugOptions // TypeDefIndex: 25230
{
	// Fields
	public bool snapping; // 0x0

	// Methods

	// RVA: 0x4108734 Offset: 0x4104734 VA: 0x4108734 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct RectOptions : IPlugOptions // TypeDefIndex: 25231
{
	// Fields
	public bool snapping; // 0x0

	// Methods

	// RVA: 0x410873C Offset: 0x410473C VA: 0x410873C Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct StringOptions : IPlugOptions // TypeDefIndex: 25232
{
	// Fields
	public bool richTextEnabled; // 0x0
	public ScrambleMode scrambleMode; // 0x4
	public char[] scrambledChars; // 0x8
	internal int startValueStrippedLength; // 0x10
	internal int changeValueStrippedLength; // 0x14

	// Methods

	// RVA: 0x4108744 Offset: 0x4104744 VA: 0x4108744 Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Options
public struct VectorOptions : IPlugOptions // TypeDefIndex: 25233
{
	// Fields
	public AxisConstraint axisConstraint; // 0x0
	public bool snapping; // 0x4

	// Methods

	// RVA: 0x410876C Offset: 0x410476C VA: 0x410876C Slot: 4
	public void Reset() { }
}

// Namespace: DG.Tweening.Plugins.Core
public interface ITPlugin<T1, T2, TPlugOptions, TPlugin> // TypeDefIndex: 25234
{}

// Namespace: DG.Tweening.Plugins.Core
internal static class SpecialPluginsUtils // TypeDefIndex: 25235
{
	// Methods

	// RVA: 0x4108778 Offset: 0x4104778 VA: 0x4108778
	internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x410889C Offset: 0x410489C VA: 0x410889C
	internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x4108A0C Offset: 0x4104A0C VA: 0x4108A0C
	internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x4108A38 Offset: 0x4104A38 VA: 0x4108A38
	internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }
}

// Namespace: DG.Tweening.Plugins.Core
public interface IPlugSetter<T1, T2, TPlugin, TPlugOptions> // TypeDefIndex: 25236
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DOGetter<T1> Getter();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Getter
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DOSetter<T1> Setter();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Setter
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract T2 EndValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TPlugOptions GetOptions();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlugSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOptions
	*/
}

// Namespace: DG.Tweening.Plugins.Core
public interface ITweenPlugin // TypeDefIndex: 25237
{}

// Namespace: DG.Tweening.Plugins.Core
public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 25238
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.SetFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ConvertToStartValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.SetRelativeEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.SetChangeValue
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.GetSpeedBasedDuration
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.EvaluateAndApply
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F347FC Offset: 0x5F307FC VA: 0x5F347FC
	|-ABSTweenPlugin<Color, Color, ColorOptions>..ctor
	|
	|-RVA: 0x5F34804 Offset: 0x5F30804 VA: 0x5F34804
	|-ABSTweenPlugin<Color2, Color2, ColorOptions>..ctor
	|
	|-RVA: 0x5F3480C Offset: 0x5F3080C VA: 0x5F3480C
	|-ABSTweenPlugin<double, double, NoOptions>..ctor
	|
	|-RVA: 0x5F34814 Offset: 0x5F30814 VA: 0x5F34814
	|-ABSTweenPlugin<int, int, NoOptions>..ctor
	|
	|-RVA: 0x5F3481C Offset: 0x5F3081C VA: 0x5F3481C
	|-ABSTweenPlugin<long, long, NoOptions>..ctor
	|
	|-RVA: 0x5F34824 Offset: 0x5F30824 VA: 0x5F34824
	|-ABSTweenPlugin<object, object, NoOptions>..ctor
	|
	|-RVA: 0x5F3482C Offset: 0x5F3082C VA: 0x5F3482C
	|-ABSTweenPlugin<object, object, StringOptions>..ctor
	|
	|-RVA: 0x5F34834 Offset: 0x5F30834 VA: 0x5F34834
	|-ABSTweenPlugin<Quaternion, Quaternion, NoOptions>..ctor
	|
	|-RVA: 0x5F3483C Offset: 0x5F3083C VA: 0x5F3483C
	|-ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>..ctor
	|
	|-RVA: 0x5F34844 Offset: 0x5F30844 VA: 0x5F34844
	|-ABSTweenPlugin<Rect, Rect, RectOptions>..ctor
	|
	|-RVA: 0x5F3484C Offset: 0x5F3084C VA: 0x5F3484C
	|-ABSTweenPlugin<float, float, FloatOptions>..ctor
	|
	|-RVA: 0x5F34854 Offset: 0x5F30854 VA: 0x5F34854
	|-ABSTweenPlugin<uint, uint, UintOptions>..ctor
	|
	|-RVA: 0x5F3485C Offset: 0x5F3085C VA: 0x5F3485C
	|-ABSTweenPlugin<ulong, ulong, NoOptions>..ctor
	|
	|-RVA: 0x5F34864 Offset: 0x5F30864 VA: 0x5F34864
	|-ABSTweenPlugin<Vector2, Vector2, VectorOptions>..ctor
	|
	|-RVA: 0x5F3486C Offset: 0x5F3086C VA: 0x5F3486C
	|-ABSTweenPlugin<Vector3, object, PathOptions>..ctor
	|
	|-RVA: 0x5F34874 Offset: 0x5F30874 VA: 0x5F34874
	|-ABSTweenPlugin<Vector3, object, Vector3ArrayOptions>..ctor
	|
	|-RVA: 0x5F3487C Offset: 0x5F3087C VA: 0x5F3487C
	|-ABSTweenPlugin<Vector3, Vector3, VectorOptions>..ctor
	|
	|-RVA: 0x5F34884 Offset: 0x5F30884 VA: 0x5F34884
	|-ABSTweenPlugin<Vector4, Vector4, VectorOptions>..ctor
	|
	|-RVA: 0x5F3488C Offset: 0x5F3088C VA: 0x5F3488C
	|-ABSTweenPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: DG.Tweening.Plugins.Core
internal static class PluginsManager // TypeDefIndex: 25239
{
	// Fields
	private static ITweenPlugin _floatPlugin; // 0x0
	private static ITweenPlugin _doublePlugin; // 0x8
	private static ITweenPlugin _intPlugin; // 0x10
	private static ITweenPlugin _uintPlugin; // 0x18
	private static ITweenPlugin _longPlugin; // 0x20
	private static ITweenPlugin _ulongPlugin; // 0x28
	private static ITweenPlugin _vector2Plugin; // 0x30
	private static ITweenPlugin _vector3Plugin; // 0x38
	private static ITweenPlugin _vector4Plugin; // 0x40
	private static ITweenPlugin _quaternionPlugin; // 0x48
	private static ITweenPlugin _colorPlugin; // 0x50
	private static ITweenPlugin _rectPlugin; // 0x58
	private static ITweenPlugin _rectOffsetPlugin; // 0x60
	private static ITweenPlugin _stringPlugin; // 0x68
	private static ITweenPlugin _vector3ArrayPlugin; // 0x70
	private static ITweenPlugin _color2Plugin; // 0x78
	private const int _MaxCustomPlugins = 20;
	private static Dictionary<Type, ITweenPlugin> _customPlugins; // 0x80

	// Methods

	// RVA: -1 Offset: -1
	internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46964F4 Offset: 0x46924F4 VA: 0x46964F4
	|-PluginsManager.GetDefaultPlugin<Color, Color, ColorOptions>
	|
	|-RVA: 0x4697050 Offset: 0x4693050 VA: 0x4697050
	|-PluginsManager.GetDefaultPlugin<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x4697BAC Offset: 0x4693BAC VA: 0x4697BAC
	|-PluginsManager.GetDefaultPlugin<double, double, NoOptions>
	|
	|-RVA: 0x4698708 Offset: 0x4694708 VA: 0x4698708
	|-PluginsManager.GetDefaultPlugin<int, int, NoOptions>
	|
	|-RVA: 0x4699264 Offset: 0x4695264 VA: 0x4699264
	|-PluginsManager.GetDefaultPlugin<long, long, NoOptions>
	|
	|-RVA: 0x4699DC0 Offset: 0x4695DC0 VA: 0x4699DC0
	|-PluginsManager.GetDefaultPlugin<object, object, NoOptions>
	|
	|-RVA: 0x469A91C Offset: 0x469691C VA: 0x469A91C
	|-PluginsManager.GetDefaultPlugin<object, object, StringOptions>
	|
	|-RVA: 0x469B478 Offset: 0x4697478 VA: 0x469B478
	|-PluginsManager.GetDefaultPlugin<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x469BFD4 Offset: 0x4697FD4 VA: 0x469BFD4
	|-PluginsManager.GetDefaultPlugin<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x469CB30 Offset: 0x4698B30 VA: 0x469CB30
	|-PluginsManager.GetDefaultPlugin<Rect, Rect, RectOptions>
	|
	|-RVA: 0x469D68C Offset: 0x469968C VA: 0x469D68C
	|-PluginsManager.GetDefaultPlugin<float, float, FloatOptions>
	|
	|-RVA: 0x469E1E8 Offset: 0x469A1E8 VA: 0x469E1E8
	|-PluginsManager.GetDefaultPlugin<uint, uint, UintOptions>
	|
	|-RVA: 0x469F2EC Offset: 0x469B2EC VA: 0x469F2EC
	|-PluginsManager.GetDefaultPlugin<ulong, ulong, NoOptions>
	|
	|-RVA: 0x469FE48 Offset: 0x469BE48 VA: 0x469FE48
	|-PluginsManager.GetDefaultPlugin<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x46A09A4 Offset: 0x469C9A4 VA: 0x46A09A4
	|-PluginsManager.GetDefaultPlugin<Vector3, object, PathOptions>
	|
	|-RVA: 0x46A1500 Offset: 0x469D500 VA: 0x46A1500
	|-PluginsManager.GetDefaultPlugin<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x46A205C Offset: 0x469E05C VA: 0x46A205C
	|-PluginsManager.GetDefaultPlugin<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x46A2BB8 Offset: 0x469EBB8 VA: 0x46A2BB8
	|-PluginsManager.GetDefaultPlugin<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x46A3714 Offset: 0x469F714 VA: 0x46A3714
	|-PluginsManager.GetDefaultPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4696114 Offset: 0x4692114 VA: 0x4696114
	|-PluginsManager.GetCustomPlugin<object, Vector3, object, PathOptions>
	|
	|-RVA: 0x46962C8 Offset: 0x46922C8 VA: 0x46962C8
	|-PluginsManager.GetCustomPlugin<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x4108BE8 Offset: 0x4104BE8 VA: 0x4108BE8
	internal static void PurgeAll() { }
}

// Namespace: DG.Tweening.Plugins.Core.PathCore
[Serializable]
public struct ControlPoint // TypeDefIndex: 25240
{
	// Fields
	public Vector3 a; // 0x0
	public Vector3 b; // 0xC

	// Methods

	// RVA: 0x4108D8C Offset: 0x4104D8C VA: 0x4108D8C
	public void .ctor(Vector3 a, Vector3 b) { }

	// RVA: 0x4108D9C Offset: 0x4104D9C VA: 0x4108D9C
	public static ControlPoint op_Addition(ControlPoint cp, Vector3 v) { }
}

// Namespace: DG.Tweening.Plugins.Core.PathCore
internal abstract class ABSPathDecoder // TypeDefIndex: 25241
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);

	// RVA: 0x4108DCC Offset: 0x4104DCC VA: 0x4108DCC
	protected void .ctor() { }
}

// Namespace: DG.Tweening.Plugins.Core.PathCore
internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 25242
{
	// Methods

	// RVA: 0x4108DD4 Offset: 0x4104DD4 VA: 0x4108DD4 Slot: 4
	internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	// RVA: 0x41095E8 Offset: 0x41055E8 VA: 0x41095E8 Slot: 5
	internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	// RVA: 0x410903C Offset: 0x410503C VA: 0x410903C
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	// RVA: 0x4109244 Offset: 0x4105244 VA: 0x4109244
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

	// RVA: 0x410985C Offset: 0x410585C VA: 0x410985C
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins.Core.PathCore
internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 25243
{
	// Methods

	// RVA: 0x4109864 Offset: 0x4105864 VA: 0x4109864 Slot: 4
	internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	// RVA: 0x4109AD8 Offset: 0x4105AD8 VA: 0x4109AD8 Slot: 5
	internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	// RVA: 0x41098B0 Offset: 0x41058B0 VA: 0x41098B0
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	// RVA: 0x4109C80 Offset: 0x4105C80 VA: 0x4109C80
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

	// RVA: 0x4109C84 Offset: 0x4105C84 VA: 0x4109C84
	public void .ctor() { }
}

// Namespace: DG.Tweening.Plugins.Core.PathCore
[Serializable]
public class Path // TypeDefIndex: 25244
{
	// Fields
	private static CatmullRomDecoder _catmullRomDecoder; // 0x0
	private static LinearDecoder _linearDecoder; // 0x8
	public float[] wpLengths; // 0x10
	[SerializeField]
	internal PathType type; // 0x18
	[SerializeField]
	internal int subdivisionsXSegment; // 0x1C
	[SerializeField]
	internal int subdivisions; // 0x20
	[SerializeField]
	internal Vector3[] wps; // 0x28
	[SerializeField]
	internal ControlPoint[] controlPoints; // 0x30
	[SerializeField]
	internal float length; // 0x38
	[SerializeField]
	internal bool isFinalized; // 0x3C
	[SerializeField]
	internal float[] timesTable; // 0x40
	[SerializeField]
	internal float[] lengthsTable; // 0x48
	internal int linearWPIndex; // 0x50
	private Path _incrementalClone; // 0x58
	private int _incrementalIndex; // 0x60
	private ABSPathDecoder _decoder; // 0x68
	private bool _changed; // 0x70
	internal Vector3[] nonLinearDrawWps; // 0x78
	internal Vector3 targetPosition; // 0x80
	internal Nullable<Vector3> lookAtPosition; // 0x8C
	internal Color gizmoColor; // 0x9C

	// Methods

	// RVA: 0x4109C8C Offset: 0x4105C8C VA: 0x4109C8C
	public void .ctor(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor) { }

	// RVA: 0x410A080 Offset: 0x4106080 VA: 0x410A080
	internal void .ctor() { }

	// RVA: 0x410A09C Offset: 0x410609C VA: 0x410A09C
	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	// RVA: 0x410A140 Offset: 0x4106140 VA: 0x410A140
	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = False) { }

	// RVA: 0x410A178 Offset: 0x4106178 VA: 0x410A178
	internal float ConvertToConstantPathPerc(float perc) { }

	// RVA: 0x410A284 Offset: 0x4106284 VA: 0x410A284
	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	// RVA: 0x410A32C Offset: 0x410632C VA: 0x410A32C
	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	// RVA: 0x410A408 Offset: 0x4106408 VA: 0x410A408
	internal static void RefreshNonLinearDrawWps(Path p) { }

	// RVA: 0x410A510 Offset: 0x4106510 VA: 0x410A510
	internal void Destroy() { }

	// RVA: 0x410A654 Offset: 0x4106654 VA: 0x410A654
	internal Path CloneIncremental(int loopIncrement) { }

	// RVA: 0x4109E78 Offset: 0x4105E78 VA: 0x4109E78
	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = False) { }

	// RVA: 0x4109F70 Offset: 0x4105F70 VA: 0x4109F70
	internal void AssignDecoder(PathType pathType) { }

	// RVA: 0x410AB40 Offset: 0x4106B40 VA: 0x410AB40
	internal void Draw() { }

	// RVA: 0x410AB44 Offset: 0x4106B44 VA: 0x410AB44
	private static void Draw(Path p) { }
}

// Namespace: DG.Tweening.CustomPlugins
public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 25245
{
	// Fields
	private static PureQuaternionPlugin _plug; // 0x0

	// Methods

	// RVA: 0x410AE40 Offset: 0x4106E40 VA: 0x410AE40
	public static PureQuaternionPlugin Plug() { }

	// RVA: 0x410AF0C Offset: 0x4106F0C VA: 0x410AF0C Slot: 4
	public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x410AF10 Offset: 0x4106F10 VA: 0x410AF10 Slot: 5
	public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative) { }

	// RVA: 0x410B024 Offset: 0x4107024 VA: 0x410B024 Slot: 6
	public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value) { }

	// RVA: 0x410B028 Offset: 0x4107028 VA: 0x410B028 Slot: 7
	public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x410B0DC Offset: 0x41070DC VA: 0x410B0DC Slot: 8
	public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x410B100 Offset: 0x4107100 VA: 0x410B100 Slot: 9
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) { }

	// RVA: 0x410B1B4 Offset: 0x41071B4 VA: 0x410B1B4 Slot: 10
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x410AEC4 Offset: 0x4106EC4 VA: 0x410AEC4
	public void .ctor() { }
}

// Namespace: DG.Tweening.Core
public abstract class ABSSequentiable // TypeDefIndex: 25246
{
	// Fields
	internal TweenType tweenType; // 0x10
	internal float sequencedPosition; // 0x14
	internal float sequencedEndPosition; // 0x18
	internal TweenCallback onStart; // 0x20

	// Methods

	// RVA: 0x410B248 Offset: 0x4107248 VA: 0x410B248
	protected void .ctor() { }
}

// Namespace: DG.Tweening.Core
public sealed class DOGetter<T> : MulticastDelegate // TypeDefIndex: 25247
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19F28 Offset: 0x5D15F28 VA: 0x5D19F28
	|-DOGetter<Color>..ctor
	|
	|-RVA: 0x5D1A024 Offset: 0x5D16024 VA: 0x5D1A024
	|-DOGetter<Color2>..ctor
	|
	|-RVA: 0x5D1A124 Offset: 0x5D16124 VA: 0x5D1A124
	|-DOGetter<double>..ctor
	|
	|-RVA: 0x5D1A21C Offset: 0x5D1621C VA: 0x5D1A21C
	|-DOGetter<int>..ctor
	|
	|-RVA: 0x5D1A314 Offset: 0x5D16314 VA: 0x5D1A314
	|-DOGetter<long>..ctor
	|
	|-RVA: 0x5D1A40C Offset: 0x5D1640C VA: 0x5D1A40C
	|-DOGetter<object>..ctor
	|
	|-RVA: 0x5D1A4E8 Offset: 0x5D164E8 VA: 0x5D1A4E8
	|-DOGetter<Quaternion>..ctor
	|
	|-RVA: 0x5D1A5E4 Offset: 0x5D165E4 VA: 0x5D1A5E4
	|-DOGetter<Rect>..ctor
	|
	|-RVA: 0x5D1A6E0 Offset: 0x5D166E0 VA: 0x5D1A6E0
	|-DOGetter<float>..ctor
	|
	|-RVA: 0x5D1A7D8 Offset: 0x5D167D8 VA: 0x5D1A7D8
	|-DOGetter<uint>..ctor
	|
	|-RVA: 0x5D1A8D0 Offset: 0x5D168D0 VA: 0x5D1A8D0
	|-DOGetter<ulong>..ctor
	|
	|-RVA: 0x5D1A9C8 Offset: 0x5D169C8 VA: 0x5D1A9C8
	|-DOGetter<Vector2>..ctor
	|
	|-RVA: 0x5D1AAC0 Offset: 0x5D16AC0 VA: 0x5D1AAC0
	|-DOGetter<Vector3>..ctor
	|
	|-RVA: 0x5D1ABBC Offset: 0x5D16BBC VA: 0x5D1ABBC
	|-DOGetter<Vector4>..ctor
	|
	|-RVA: 0x5D1ACB8 Offset: 0x5D16CB8 VA: 0x5D1ACB8
	|-DOGetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19FC4 Offset: 0x5D15FC4 VA: 0x5D19FC4
	|-DOGetter<Color>.Invoke
	|
	|-RVA: 0x5D1A0C0 Offset: 0x5D160C0 VA: 0x5D1A0C0
	|-DOGetter<Color2>.Invoke
	|
	|-RVA: 0x5D1A1C0 Offset: 0x5D161C0 VA: 0x5D1A1C0
	|-DOGetter<double>.Invoke
	|
	|-RVA: 0x5D1A2B8 Offset: 0x5D162B8 VA: 0x5D1A2B8
	|-DOGetter<int>.Invoke
	|
	|-RVA: 0x5D1A3B0 Offset: 0x5D163B0 VA: 0x5D1A3B0
	|-DOGetter<long>.Invoke
	|
	|-RVA: 0x5D1A4A8 Offset: 0x5D164A8 VA: 0x5D1A4A8
	|-DOGetter<object>.Invoke
	|
	|-RVA: 0x5D1A584 Offset: 0x5D16584 VA: 0x5D1A584
	|-DOGetter<Quaternion>.Invoke
	|
	|-RVA: 0x5D1A680 Offset: 0x5D16680 VA: 0x5D1A680
	|-DOGetter<Rect>.Invoke
	|
	|-RVA: 0x5D1A77C Offset: 0x5D1677C VA: 0x5D1A77C
	|-DOGetter<float>.Invoke
	|
	|-RVA: 0x5D1A874 Offset: 0x5D16874 VA: 0x5D1A874
	|-DOGetter<uint>.Invoke
	|
	|-RVA: 0x5D1A96C Offset: 0x5D1696C VA: 0x5D1A96C
	|-DOGetter<ulong>.Invoke
	|
	|-RVA: 0x5D1AA64 Offset: 0x5D16A64 VA: 0x5D1AA64
	|-DOGetter<Vector2>.Invoke
	|
	|-RVA: 0x5D1AB5C Offset: 0x5D16B5C VA: 0x5D1AB5C
	|-DOGetter<Vector3>.Invoke
	|
	|-RVA: 0x5D1AC58 Offset: 0x5D16C58 VA: 0x5D1AC58
	|-DOGetter<Vector4>.Invoke
	|
	|-RVA: 0x5D1AD58 Offset: 0x5D16D58 VA: 0x5D1AD58
	|-DOGetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19FD8 Offset: 0x5D15FD8 VA: 0x5D19FD8
	|-DOGetter<Color>.BeginInvoke
	|
	|-RVA: 0x5D1A0D4 Offset: 0x5D160D4 VA: 0x5D1A0D4
	|-DOGetter<Color2>.BeginInvoke
	|
	|-RVA: 0x5D1A1D4 Offset: 0x5D161D4 VA: 0x5D1A1D4
	|-DOGetter<double>.BeginInvoke
	|
	|-RVA: 0x5D1A2CC Offset: 0x5D162CC VA: 0x5D1A2CC
	|-DOGetter<int>.BeginInvoke
	|
	|-RVA: 0x5D1A3C4 Offset: 0x5D163C4 VA: 0x5D1A3C4
	|-DOGetter<long>.BeginInvoke
	|
	|-RVA: 0x5D1A4BC Offset: 0x5D164BC VA: 0x5D1A4BC
	|-DOGetter<object>.BeginInvoke
	|
	|-RVA: 0x5D1A598 Offset: 0x5D16598 VA: 0x5D1A598
	|-DOGetter<Quaternion>.BeginInvoke
	|
	|-RVA: 0x5D1A694 Offset: 0x5D16694 VA: 0x5D1A694
	|-DOGetter<Rect>.BeginInvoke
	|
	|-RVA: 0x5D1A790 Offset: 0x5D16790 VA: 0x5D1A790
	|-DOGetter<float>.BeginInvoke
	|
	|-RVA: 0x5D1A888 Offset: 0x5D16888 VA: 0x5D1A888
	|-DOGetter<uint>.BeginInvoke
	|
	|-RVA: 0x5D1A980 Offset: 0x5D16980 VA: 0x5D1A980
	|-DOGetter<ulong>.BeginInvoke
	|
	|-RVA: 0x5D1AA78 Offset: 0x5D16A78 VA: 0x5D1AA78
	|-DOGetter<Vector2>.BeginInvoke
	|
	|-RVA: 0x5D1AB70 Offset: 0x5D16B70 VA: 0x5D1AB70
	|-DOGetter<Vector3>.BeginInvoke
	|
	|-RVA: 0x5D1AC6C Offset: 0x5D16C6C VA: 0x5D1AC6C
	|-DOGetter<Vector4>.BeginInvoke
	|
	|-RVA: 0x5D1AD6C Offset: 0x5D16D6C VA: 0x5D1AD6C
	|-DOGetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19FF8 Offset: 0x5D15FF8 VA: 0x5D19FF8
	|-DOGetter<Color>.EndInvoke
	|
	|-RVA: 0x5D1A0F4 Offset: 0x5D160F4 VA: 0x5D1A0F4
	|-DOGetter<Color2>.EndInvoke
	|
	|-RVA: 0x5D1A1F4 Offset: 0x5D161F4 VA: 0x5D1A1F4
	|-DOGetter<double>.EndInvoke
	|
	|-RVA: 0x5D1A2EC Offset: 0x5D162EC VA: 0x5D1A2EC
	|-DOGetter<int>.EndInvoke
	|
	|-RVA: 0x5D1A3E4 Offset: 0x5D163E4 VA: 0x5D1A3E4
	|-DOGetter<long>.EndInvoke
	|
	|-RVA: 0x5D1A4DC Offset: 0x5D164DC VA: 0x5D1A4DC
	|-DOGetter<object>.EndInvoke
	|
	|-RVA: 0x5D1A5B8 Offset: 0x5D165B8 VA: 0x5D1A5B8
	|-DOGetter<Quaternion>.EndInvoke
	|
	|-RVA: 0x5D1A6B4 Offset: 0x5D166B4 VA: 0x5D1A6B4
	|-DOGetter<Rect>.EndInvoke
	|
	|-RVA: 0x5D1A7B0 Offset: 0x5D167B0 VA: 0x5D1A7B0
	|-DOGetter<float>.EndInvoke
	|
	|-RVA: 0x5D1A8A8 Offset: 0x5D168A8 VA: 0x5D1A8A8
	|-DOGetter<uint>.EndInvoke
	|
	|-RVA: 0x5D1A9A0 Offset: 0x5D169A0 VA: 0x5D1A9A0
	|-DOGetter<ulong>.EndInvoke
	|
	|-RVA: 0x5D1AA98 Offset: 0x5D16A98 VA: 0x5D1AA98
	|-DOGetter<Vector2>.EndInvoke
	|
	|-RVA: 0x5D1AB90 Offset: 0x5D16B90 VA: 0x5D1AB90
	|-DOGetter<Vector3>.EndInvoke
	|
	|-RVA: 0x5D1AC8C Offset: 0x5D16C8C VA: 0x5D1AC8C
	|-DOGetter<Vector4>.EndInvoke
	|
	|-RVA: 0x5D1AD8C Offset: 0x5D16D8C VA: 0x5D1AD8C
	|-DOGetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: DG.Tweening.Core
public sealed class DOSetter<T> : MulticastDelegate // TypeDefIndex: 25248
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AE44 Offset: 0x5D16E44 VA: 0x5D1AE44
	|-DOSetter<Color>..ctor
	|
	|-RVA: 0x5D1AF8C Offset: 0x5D16F8C VA: 0x5D1AF8C
	|-DOSetter<Color2>..ctor
	|
	|-RVA: 0x5D1B0F8 Offset: 0x5D170F8 VA: 0x5D1B0F8
	|-DOSetter<double>..ctor
	|
	|-RVA: 0x5D1B23C Offset: 0x5D1723C VA: 0x5D1B23C
	|-DOSetter<int>..ctor
	|
	|-RVA: 0x5D1B380 Offset: 0x5D17380 VA: 0x5D1B380
	|-DOSetter<long>..ctor
	|
	|-RVA: 0x5D1B4C4 Offset: 0x5D174C4 VA: 0x5D1B4C4
	|-DOSetter<object>..ctor
	|
	|-RVA: 0x5D1B60C Offset: 0x5D1760C VA: 0x5D1B60C
	|-DOSetter<Quaternion>..ctor
	|
	|-RVA: 0x5D1B754 Offset: 0x5D17754 VA: 0x5D1B754
	|-DOSetter<Rect>..ctor
	|
	|-RVA: 0x5D1B89C Offset: 0x5D1789C VA: 0x5D1B89C
	|-DOSetter<float>..ctor
	|
	|-RVA: 0x5D1B9E0 Offset: 0x5D179E0 VA: 0x5D1B9E0
	|-DOSetter<uint>..ctor
	|
	|-RVA: 0x5D1BB24 Offset: 0x5D17B24 VA: 0x5D1BB24
	|-DOSetter<ulong>..ctor
	|
	|-RVA: 0x5D1BC68 Offset: 0x5D17C68 VA: 0x5D1BC68
	|-DOSetter<Vector2>..ctor
	|
	|-RVA: 0x5D1BDAC Offset: 0x5D17DAC VA: 0x5D1BDAC
	|-DOSetter<Vector3>..ctor
	|
	|-RVA: 0x5D1BEF4 Offset: 0x5D17EF4 VA: 0x5D1BEF4
	|-DOSetter<Vector4>..ctor
	|
	|-RVA: 0x5D1C03C Offset: 0x5D1803C VA: 0x5D1C03C
	|-DOSetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T pNewValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AEE4 Offset: 0x5D16EE4 VA: 0x5D1AEE4
	|-DOSetter<Color>.Invoke
	|
	|-RVA: 0x5D1B02C Offset: 0x5D1702C VA: 0x5D1B02C
	|-DOSetter<Color2>.Invoke
	|
	|-RVA: 0x5D1B198 Offset: 0x5D17198 VA: 0x5D1B198
	|-DOSetter<double>.Invoke
	|
	|-RVA: 0x5D1B2DC Offset: 0x5D172DC VA: 0x5D1B2DC
	|-DOSetter<int>.Invoke
	|
	|-RVA: 0x5D1B420 Offset: 0x5D17420 VA: 0x5D1B420
	|-DOSetter<long>.Invoke
	|
	|-RVA: 0x5D1B5CC Offset: 0x5D175CC VA: 0x5D1B5CC
	|-DOSetter<object>.Invoke
	|
	|-RVA: 0x5D1B6AC Offset: 0x5D176AC VA: 0x5D1B6AC
	|-DOSetter<Quaternion>.Invoke
	|
	|-RVA: 0x5D1B7F4 Offset: 0x5D177F4 VA: 0x5D1B7F4
	|-DOSetter<Rect>.Invoke
	|
	|-RVA: 0x5D1B93C Offset: 0x5D1793C VA: 0x5D1B93C
	|-DOSetter<float>.Invoke
	|
	|-RVA: 0x5D1BA80 Offset: 0x5D17A80 VA: 0x5D1BA80
	|-DOSetter<uint>.Invoke
	|
	|-RVA: 0x5D1BBC4 Offset: 0x5D17BC4 VA: 0x5D1BBC4
	|-DOSetter<ulong>.Invoke
	|
	|-RVA: 0x5D1BD08 Offset: 0x5D17D08 VA: 0x5D1BD08
	|-DOSetter<Vector2>.Invoke
	|
	|-RVA: 0x5D1BE4C Offset: 0x5D17E4C VA: 0x5D1BE4C
	|-DOSetter<Vector3>.Invoke
	|
	|-RVA: 0x5D1BF94 Offset: 0x5D17F94 VA: 0x5D1BF94
	|-DOSetter<Vector4>.Invoke
	|
	|-RVA: 0x5D1C144 Offset: 0x5D18144 VA: 0x5D1C144
	|-DOSetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T pNewValue, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AEF8 Offset: 0x5D16EF8 VA: 0x5D1AEF8
	|-DOSetter<Color>.BeginInvoke
	|
	|-RVA: 0x5D1B060 Offset: 0x5D17060 VA: 0x5D1B060
	|-DOSetter<Color2>.BeginInvoke
	|
	|-RVA: 0x5D1B1AC Offset: 0x5D171AC VA: 0x5D1B1AC
	|-DOSetter<double>.BeginInvoke
	|
	|-RVA: 0x5D1B2F0 Offset: 0x5D172F0 VA: 0x5D1B2F0
	|-DOSetter<int>.BeginInvoke
	|
	|-RVA: 0x5D1B434 Offset: 0x5D17434 VA: 0x5D1B434
	|-DOSetter<long>.BeginInvoke
	|
	|-RVA: 0x5D1B5E0 Offset: 0x5D175E0 VA: 0x5D1B5E0
	|-DOSetter<object>.BeginInvoke
	|
	|-RVA: 0x5D1B6C0 Offset: 0x5D176C0 VA: 0x5D1B6C0
	|-DOSetter<Quaternion>.BeginInvoke
	|
	|-RVA: 0x5D1B808 Offset: 0x5D17808 VA: 0x5D1B808
	|-DOSetter<Rect>.BeginInvoke
	|
	|-RVA: 0x5D1B950 Offset: 0x5D17950 VA: 0x5D1B950
	|-DOSetter<float>.BeginInvoke
	|
	|-RVA: 0x5D1BA94 Offset: 0x5D17A94 VA: 0x5D1BA94
	|-DOSetter<uint>.BeginInvoke
	|
	|-RVA: 0x5D1BBD8 Offset: 0x5D17BD8 VA: 0x5D1BBD8
	|-DOSetter<ulong>.BeginInvoke
	|
	|-RVA: 0x5D1BD1C Offset: 0x5D17D1C VA: 0x5D1BD1C
	|-DOSetter<Vector2>.BeginInvoke
	|
	|-RVA: 0x5D1BE60 Offset: 0x5D17E60 VA: 0x5D1BE60
	|-DOSetter<Vector3>.BeginInvoke
	|
	|-RVA: 0x5D1BFA8 Offset: 0x5D17FA8 VA: 0x5D1BFA8
	|-DOSetter<Vector4>.BeginInvoke
	|
	|-RVA: 0x5D1C158 Offset: 0x5D18158 VA: 0x5D1C158
	|-DOSetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AF80 Offset: 0x5D16F80 VA: 0x5D1AF80
	|-DOSetter<Color>.EndInvoke
	|
	|-RVA: 0x5D1B0EC Offset: 0x5D170EC VA: 0x5D1B0EC
	|-DOSetter<Color2>.EndInvoke
	|
	|-RVA: 0x5D1B230 Offset: 0x5D17230 VA: 0x5D1B230
	|-DOSetter<double>.EndInvoke
	|
	|-RVA: 0x5D1B374 Offset: 0x5D17374 VA: 0x5D1B374
	|-DOSetter<int>.EndInvoke
	|
	|-RVA: 0x5D1B4B8 Offset: 0x5D174B8 VA: 0x5D1B4B8
	|-DOSetter<long>.EndInvoke
	|
	|-RVA: 0x5D1B600 Offset: 0x5D17600 VA: 0x5D1B600
	|-DOSetter<object>.EndInvoke
	|
	|-RVA: 0x5D1B748 Offset: 0x5D17748 VA: 0x5D1B748
	|-DOSetter<Quaternion>.EndInvoke
	|
	|-RVA: 0x5D1B890 Offset: 0x5D17890 VA: 0x5D1B890
	|-DOSetter<Rect>.EndInvoke
	|
	|-RVA: 0x5D1B9D4 Offset: 0x5D179D4 VA: 0x5D1B9D4
	|-DOSetter<float>.EndInvoke
	|
	|-RVA: 0x5D1BB18 Offset: 0x5D17B18 VA: 0x5D1BB18
	|-DOSetter<uint>.EndInvoke
	|
	|-RVA: 0x5D1BC5C Offset: 0x5D17C5C VA: 0x5D1BC5C
	|-DOSetter<ulong>.EndInvoke
	|
	|-RVA: 0x5D1BDA0 Offset: 0x5D17DA0 VA: 0x5D1BDA0
	|-DOSetter<Vector2>.EndInvoke
	|
	|-RVA: 0x5D1BEE8 Offset: 0x5D17EE8 VA: 0x5D1BEE8
	|-DOSetter<Vector3>.EndInvoke
	|
	|-RVA: 0x5D1C030 Offset: 0x5D18030 VA: 0x5D1C030
	|-DOSetter<Vector4>.EndInvoke
	|
	|-RVA: 0x5D1C1D8 Offset: 0x5D181D8 VA: 0x5D1C1D8
	|-DOSetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: DG.Tweening.Core
public static class Debugger // TypeDefIndex: 25249
{
	// Fields
	public static int logPriority; // 0x0

	// Methods

	// RVA: 0x410B250 Offset: 0x4107250 VA: 0x410B250
	public static void Log(object message) { }

	// RVA: 0x410B2DC Offset: 0x41072DC VA: 0x410B2DC
	public static void LogWarning(object message) { }

	// RVA: 0x410B368 Offset: 0x4107368 VA: 0x410B368
	public static void LogError(object message) { }

	// RVA: 0x410B3F4 Offset: 0x41073F4 VA: 0x410B3F4
	public static void LogReport(object message) { }

	// RVA: 0x410B498 Offset: 0x4107498 VA: 0x410B498
	public static void LogInvalidTween(Tween t) { }

	// RVA: 0x410B4D8 Offset: 0x41074D8 VA: 0x410B4D8
	public static void LogNestedTween(Tween t) { }

	// RVA: 0x410B518 Offset: 0x4107518 VA: 0x410B518
	public static void LogNullTween(Tween t) { }

	// RVA: 0x410B558 Offset: 0x4107558 VA: 0x410B558
	public static void LogNonPathTween(Tween t) { }

	// RVA: 0x410B598 Offset: 0x4107598 VA: 0x410B598
	public static void LogMissingMaterialProperty(string propertyName) { }

	// RVA: 0x410B5E8 Offset: 0x41075E8 VA: 0x410B5E8
	public static void LogRemoveActiveTweenError(string propertyName) { }

	// RVA: 0x410B638 Offset: 0x4107638 VA: 0x410B638
	public static void SetLogPriority(LogBehaviour logBehaviour) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForCompletion>d__13 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25250
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C670 Offset: 0x4108670 VA: 0x410C670
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CBF4 Offset: 0x4108BF4 VA: 0x410CBF4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CBF8 Offset: 0x4108BF8 VA: 0x410CBF8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CC58 Offset: 0x4108C58 VA: 0x410CC58 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CC60 Offset: 0x4108C60 VA: 0x410CC60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410CC98 Offset: 0x4108C98 VA: 0x410CC98 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForRewind>d__14 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25251
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C704 Offset: 0x4108704 VA: 0x410C704
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CCA0 Offset: 0x4108CA0 VA: 0x410CCA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CCA4 Offset: 0x4108CA4 VA: 0x410CCA4 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CD20 Offset: 0x4108D20 VA: 0x410CD20 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CD28 Offset: 0x4108D28 VA: 0x410CD28 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410CD60 Offset: 0x4108D60 VA: 0x410CD60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForKill>d__15 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25252
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C798 Offset: 0x4108798 VA: 0x410C798
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CD68 Offset: 0x4108D68 VA: 0x410CD68 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CD6C Offset: 0x4108D6C VA: 0x410CD6C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CDC4 Offset: 0x4108DC4 VA: 0x410CDC4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CDCC Offset: 0x4108DCC VA: 0x410CDCC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410CE04 Offset: 0x4108E04 VA: 0x410CE04 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForElapsedLoops>d__16 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25253
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20
	public int elapsedLoops; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C83C Offset: 0x410883C VA: 0x410C83C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CE0C Offset: 0x4108E0C VA: 0x410CE0C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CE10 Offset: 0x4108E10 VA: 0x410CE10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CE78 Offset: 0x4108E78 VA: 0x410CE78 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CE80 Offset: 0x4108E80 VA: 0x410CE80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410CEB8 Offset: 0x4108EB8 VA: 0x410CEB8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForPosition>d__17 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25254
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20
	public float position; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C8E0 Offset: 0x41088E0 VA: 0x410C8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CEC0 Offset: 0x4108EC0 VA: 0x410CEC0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CEC4 Offset: 0x4108EC4 VA: 0x410CEC4 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CF3C Offset: 0x4108F3C VA: 0x410CF3C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CF44 Offset: 0x4108F44 VA: 0x410CF44 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410CF7C Offset: 0x4108F7C VA: 0x410CF7C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DOTweenComponent.<WaitForStart>d__18 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 25255
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Tween t; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x410C974 Offset: 0x4108974 VA: 0x410C974
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x410CF84 Offset: 0x4108F84 VA: 0x410CF84 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x410CF88 Offset: 0x4108F88 VA: 0x410CF88 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x410CFE8 Offset: 0x4108FE8 VA: 0x410CFE8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x410CFF0 Offset: 0x4108FF0 VA: 0x410CFF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x410D028 Offset: 0x4109028 VA: 0x410D028 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: DG.Tweening.Core
[AddComponentMenu("")]
public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 25256
{
	// Fields
	public int inspectorUpdater; // 0x20
	private float _unscaledTime; // 0x24
	private float _unscaledDeltaTime; // 0x28
	private bool _duplicateToDestroy; // 0x2C

	// Methods

	// RVA: 0x410B6AC Offset: 0x41076AC VA: 0x410B6AC
	private void Awake() { }

	// RVA: 0x410B6CC Offset: 0x41076CC VA: 0x410B6CC
	private void Start() { }

	// RVA: 0x410B7A4 Offset: 0x41077A4 VA: 0x410B7A4
	private void Update() { }

	// RVA: 0x410BE10 Offset: 0x4107E10 VA: 0x410BE10
	private void LateUpdate() { }

	// RVA: 0x410BF1C Offset: 0x4107F1C VA: 0x410BF1C
	private void FixedUpdate() { }

	// RVA: 0x410C08C Offset: 0x410808C VA: 0x410C08C
	private void OnDrawGizmos() { }

	// RVA: 0x410C1B0 Offset: 0x41081B0 VA: 0x410C1B0
	private void OnDestroy() { }

	// RVA: 0x410C458 Offset: 0x4108458 VA: 0x410C458
	private void OnApplicationQuit() { }

	// RVA: 0x410C4B4 Offset: 0x41084B4 VA: 0x410C4B4 Slot: 4
	public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x410C604 Offset: 0x4108604 VA: 0x410C604
	internal IEnumerator WaitForCompletion(Tween t) { }

	// RVA: 0x410C698 Offset: 0x4108698 VA: 0x410C698
	internal IEnumerator WaitForRewind(Tween t) { }

	// RVA: 0x410C72C Offset: 0x410872C VA: 0x410C72C
	internal IEnumerator WaitForKill(Tween t) { }

	// RVA: 0x410C7C0 Offset: 0x41087C0 VA: 0x410C7C0
	internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	// RVA: 0x410C864 Offset: 0x4108864 VA: 0x410C864
	internal IEnumerator WaitForPosition(Tween t, float position) { }

	// RVA: 0x410C908 Offset: 0x4108908 VA: 0x410C908
	internal IEnumerator WaitForStart(Tween t) { }

	// RVA: 0x410C99C Offset: 0x410899C VA: 0x410C99C
	internal static void Create() { }

	// RVA: 0x410CAE8 Offset: 0x4108AE8 VA: 0x410CAE8
	internal static void DestroyInstance() { }

	// RVA: 0x410CBEC Offset: 0x4108BEC VA: 0x410CBEC
	public void .ctor() { }
}

// Namespace: 
public enum DOTweenSettings.SettingsLocation // TypeDefIndex: 25257
{
	// Fields
	public int value__; // 0x0
	public const DOTweenSettings.SettingsLocation AssetsDirectory = 0;
	public const DOTweenSettings.SettingsLocation DOTweenDirectory = 1;
	public const DOTweenSettings.SettingsLocation DemigiantDirectory = 2;
}

// Namespace: DG.Tweening.Core
public class DOTweenSettings : ScriptableObject // TypeDefIndex: 25258
{
	// Fields
	public const string AssetName = "DOTweenSettings";
	public bool useSafeMode; // 0x18
	public float timeScale; // 0x1C
	public bool useSmoothDeltaTime; // 0x20
	public float maxSmoothUnscaledTime; // 0x24
	public bool showUnityEditorReport; // 0x28
	public LogBehaviour logBehaviour; // 0x2C
	public bool drawGizmos; // 0x30
	public bool defaultRecyclable; // 0x31
	public AutoPlay defaultAutoPlay; // 0x34
	public UpdateType defaultUpdateType; // 0x38
	public bool defaultTimeScaleIndependent; // 0x3C
	public Ease defaultEaseType; // 0x40
	public float defaultEaseOvershootOrAmplitude; // 0x44
	public float defaultEasePeriod; // 0x48
	public bool defaultAutoKill; // 0x4C
	public LoopType defaultLoopType; // 0x50
	public DOTweenSettings.SettingsLocation storeSettingsLocation; // 0x54

	// Methods

	// RVA: 0x410D030 Offset: 0x4109030 VA: 0x410D030
	public void .ctor() { }
}

// Namespace: DG.Tweening.Core
[Extension]
public static class Extensions // TypeDefIndex: 25259
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static T SetSpecialStartupMode<T>(T t, SpecialStartupMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9920 Offset: 0x45F5920 VA: 0x45F9920
	|-Extensions.SetSpecialStartupMode<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F98D8 Offset: 0x45F58D8 VA: 0x45F98D8
	|-Extensions.NoFrom<float, float, FloatOptions>
	|
	|-RVA: 0x45F98F0 Offset: 0x45F58F0 VA: 0x45F98F0
	|-Extensions.NoFrom<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x45F9908 Offset: 0x45F5908 VA: 0x45F9908
	|-Extensions.NoFrom<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F9868 Offset: 0x45F5868 VA: 0x45F9868
	|-Extensions.Blendable<Color, Color, ColorOptions>
	|
	|-RVA: 0x45F9884 Offset: 0x45F5884 VA: 0x45F9884
	|-Extensions.Blendable<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x45F98A0 Offset: 0x45F58A0 VA: 0x45F98A0
	|-Extensions.Blendable<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x45F98BC Offset: 0x45F58BC VA: 0x45F98BC
	|-Extensions.Blendable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: DG.Tweening.Core
internal class SequenceCallback : ABSSequentiable // TypeDefIndex: 25260
{
	// Methods

	// RVA: 0x410D07C Offset: 0x410907C VA: 0x410D07C
	public void .ctor(float sequencedPosition, TweenCallback callback) { }
}

// Namespace: 
internal enum TweenManager.CapacityIncreaseMode // TypeDefIndex: 25261
{
	// Fields
	public int value__; // 0x0
	public const TweenManager.CapacityIncreaseMode TweenersAndSequences = 0;
	public const TweenManager.CapacityIncreaseMode TweenersOnly = 1;
	public const TweenManager.CapacityIncreaseMode SequencesOnly = 2;
}

// Namespace: DG.Tweening.Core
internal static class TweenManager // TypeDefIndex: 25262
{
	// Fields
	private const int _DefaultMaxTweeners = 200;
	private const int _DefaultMaxSequences = 50;
	private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";
	internal static int maxActive; // 0x0
	internal static int maxTweeners; // 0x4
	internal static int maxSequences; // 0x8
	internal static bool hasActiveTweens; // 0xC
	internal static bool hasActiveDefaultTweens; // 0xD
	internal static bool hasActiveLateTweens; // 0xE
	internal static bool hasActiveFixedTweens; // 0xF
	internal static int totActiveTweens; // 0x10
	internal static int totActiveDefaultTweens; // 0x14
	internal static int totActiveLateTweens; // 0x18
	internal static int totActiveFixedTweens; // 0x1C
	internal static int totActiveTweeners; // 0x20
	internal static int totActiveSequences; // 0x24
	internal static int totPooledTweeners; // 0x28
	internal static int totPooledSequences; // 0x2C
	internal static int totTweeners; // 0x30
	internal static int totSequences; // 0x34
	internal static bool isUpdateLoop; // 0x38
	internal static Tween[] _activeTweens; // 0x40
	private static Tween[] _pooledTweeners; // 0x48
	private static readonly Stack<Tween> _PooledSequences; // 0x50
	private static readonly List<Tween> _KillList; // 0x58
	private static int _maxActiveLookupId; // 0x60
	private static bool _requiresActiveReorganization; // 0x64
	private static int _reorganizeFromId; // 0x68
	private static int _minPooledTweenerId; // 0x6C
	private static int _maxPooledTweenerId; // 0x70
	private static bool _despawnAllCalledFromUpdateLoopCallback; // 0x74

	// Methods

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4720A40 Offset: 0x471CA40 VA: 0x4720A40
	|-TweenManager.GetTweener<Color, Color, ColorOptions>
	|
	|-RVA: 0x4720FDC Offset: 0x471CFDC VA: 0x4720FDC
	|-TweenManager.GetTweener<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x4721578 Offset: 0x471D578 VA: 0x4721578
	|-TweenManager.GetTweener<double, double, NoOptions>
	|
	|-RVA: 0x4721B14 Offset: 0x471DB14 VA: 0x4721B14
	|-TweenManager.GetTweener<int, int, NoOptions>
	|
	|-RVA: 0x47220B0 Offset: 0x471E0B0 VA: 0x47220B0
	|-TweenManager.GetTweener<long, long, NoOptions>
	|
	|-RVA: 0x472264C Offset: 0x471E64C VA: 0x472264C
	|-TweenManager.GetTweener<object, object, NoOptions>
	|
	|-RVA: 0x4722BE8 Offset: 0x471EBE8 VA: 0x4722BE8
	|-TweenManager.GetTweener<object, object, StringOptions>
	|
	|-RVA: 0x4723184 Offset: 0x471F184 VA: 0x4723184
	|-TweenManager.GetTweener<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x4723720 Offset: 0x471F720 VA: 0x4723720
	|-TweenManager.GetTweener<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x4723CBC Offset: 0x471FCBC VA: 0x4723CBC
	|-TweenManager.GetTweener<Rect, Rect, RectOptions>
	|
	|-RVA: 0x4724258 Offset: 0x4720258 VA: 0x4724258
	|-TweenManager.GetTweener<float, float, FloatOptions>
	|
	|-RVA: 0x47247F4 Offset: 0x47207F4 VA: 0x47247F4
	|-TweenManager.GetTweener<uint, uint, UintOptions>
	|
	|-RVA: 0x4724D90 Offset: 0x4720D90 VA: 0x4724D90
	|-TweenManager.GetTweener<ulong, ulong, NoOptions>
	|
	|-RVA: 0x472532C Offset: 0x472132C VA: 0x472532C
	|-TweenManager.GetTweener<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x47258C8 Offset: 0x47218C8 VA: 0x47258C8
	|-TweenManager.GetTweener<Vector3, object, PathOptions>
	|
	|-RVA: 0x4725E64 Offset: 0x4721E64 VA: 0x4725E64
	|-TweenManager.GetTweener<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x4726400 Offset: 0x4722400 VA: 0x4726400
	|-TweenManager.GetTweener<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x472699C Offset: 0x472299C VA: 0x472699C
	|-TweenManager.GetTweener<Vector4, Vector4, VectorOptions>
	|
	|-RVA: 0x4726F38 Offset: 0x4722F38 VA: 0x4726F38
	|-TweenManager.GetTweener<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x410D0C4 Offset: 0x41090C4 VA: 0x410D0C4
	internal static Sequence GetSequence() { }

	// RVA: 0x410D7D8 Offset: 0x41097D8 VA: 0x410D7D8
	internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate) { }

	// RVA: 0x410D978 Offset: 0x4109978 VA: 0x410D978
	internal static void AddActiveTweenToSequence(Tween t) { }

	// RVA: 0x410DD70 Offset: 0x4109D70 VA: 0x410DD70
	internal static int DespawnAll() { }

	// RVA: 0x410DEB4 Offset: 0x4109EB4 VA: 0x410DEB4
	internal static void Despawn(Tween t, bool modifyActiveLists = True) { }

	// RVA: 0x410E40C Offset: 0x410A40C VA: 0x410E40C
	internal static void PurgeAll() { }

	// RVA: 0x410E508 Offset: 0x410A508 VA: 0x410E508
	internal static void PurgePools() { }

	// RVA: 0x410E5B4 Offset: 0x410A5B4 VA: 0x410E5B4
	internal static void ResetCapacities() { }

	// RVA: 0x410C524 Offset: 0x4108524 VA: 0x410C524
	internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x410E608 Offset: 0x410A608 VA: 0x410E608
	internal static int Validate() { }

	// RVA: 0x410BA80 Offset: 0x4107A80 VA: 0x410BA80
	internal static void Update(UpdateType updateType, float deltaTime, float independentTime) { }

	// RVA: 0x410EB24 Offset: 0x410AB24 VA: 0x410EB24
	internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray) { }

	// RVA: 0x410F0D8 Offset: 0x410B0D8 VA: 0x410F0D8
	internal static bool Complete(Tween t, bool modifyActiveLists = True, UpdateMode updateMode = 1) { }

	// RVA: 0x410F1B0 Offset: 0x410B1B0 VA: 0x410F1B0
	internal static bool Flip(Tween t) { }

	// RVA: 0x410F778 Offset: 0x410B778 VA: 0x410F778
	internal static void ForceInit(Tween t, bool isSequenced = False) { }

	// RVA: 0x410F1D8 Offset: 0x410B1D8 VA: 0x410F1D8
	internal static bool Goto(Tween t, float to, bool andPlay = False, UpdateMode updateMode = 1) { }

	// RVA: 0x410F30C Offset: 0x410B30C VA: 0x410F30C
	internal static bool Pause(Tween t) { }

	// RVA: 0x410F348 Offset: 0x410B348 VA: 0x410F348
	internal static bool Play(Tween t) { }

	// RVA: 0x410F3C8 Offset: 0x410B3C8 VA: 0x410F3C8
	internal static bool PlayBackwards(Tween t) { }

	// RVA: 0x410F45C Offset: 0x410B45C VA: 0x410F45C
	internal static bool PlayForward(Tween t) { }

	// RVA: 0x410F4EC Offset: 0x410B4EC VA: 0x410F4EC
	internal static bool Restart(Tween t, bool includeDelay = True) { }

	// RVA: 0x410F590 Offset: 0x410B590 VA: 0x410F590
	internal static bool Rewind(Tween t, bool includeDelay = True) { }

	// RVA: 0x410F65C Offset: 0x410B65C VA: 0x410F65C
	internal static bool SmoothRewind(Tween t) { }

	// RVA: 0x410F708 Offset: 0x410B708 VA: 0x410F708
	internal static bool TogglePause(Tween t) { }

	// RVA: 0x410F828 Offset: 0x410B828 VA: 0x410F828
	internal static int TotalPooledTweens() { }

	// RVA: 0x410F884 Offset: 0x410B884 VA: 0x410F884
	internal static int TotalPlayingTweens() { }

	// RVA: 0x410F990 Offset: 0x410B990 VA: 0x410F990
	internal static List<Tween> GetActiveTweens(bool playing) { }

	// RVA: 0x410FB84 Offset: 0x410BB84 VA: 0x410FB84
	internal static List<Tween> GetTweensById(object id, bool playingOnly) { }

	// RVA: 0x410FDA0 Offset: 0x410BDA0 VA: 0x410FDA0
	internal static List<Tween> GetTweensByTarget(object target, bool playingOnly) { }

	// RVA: 0x410E990 Offset: 0x410A990 VA: 0x410E990
	private static void MarkForKilling(Tween t) { }

	// RVA: 0x410D3BC Offset: 0x41093BC VA: 0x410D3BC
	private static void AddActiveTween(Tween t) { }

	// RVA: 0x410E788 Offset: 0x410A788 VA: 0x410E788
	private static void ReorganizeActiveTweens() { }

	// RVA: 0x410EA6C Offset: 0x410AA6C VA: 0x410EA6C
	private static void DespawnActiveTweens(List<Tween> tweens) { }

	// RVA: 0x410D9CC Offset: 0x41099CC VA: 0x410D9CC
	private static void RemoveActiveTween(Tween t) { }

	// RVA: 0x410E394 Offset: 0x410A394 VA: 0x410E394
	private static void ClearTweenArray(Tween[] tweens) { }

	// RVA: 0x410D5E8 Offset: 0x41095E8 VA: 0x410D5E8
	private static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode) { }

	// RVA: 0x410FFA8 Offset: 0x410BFA8 VA: 0x410FFA8
	private static void .cctor() { }
}

// Namespace: DG.Tweening.Core
internal static class Utils // TypeDefIndex: 25263
{
	// Methods

	// RVA: 0x411012C Offset: 0x410C12C VA: 0x411012C
	internal static Vector3 Vector3FromAngle(float degrees, float magnitude) { }

	// RVA: 0x4110174 Offset: 0x410C174 VA: 0x4110174
	internal static float Angle2D(Vector3 from, Vector3 to) { }
}

// Namespace: DG.Tweening.Core
public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 25264
{
	// Fields
	public T2 startValue; // 0x0
	public T2 endValue; // 0x0
	public T2 changeValue; // 0x0
	public TPlugOptions plugOptions; // 0x0
	public DOGetter<T1> getter; // 0x0
	public DOSetter<T1> setter; // 0x0
	internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin; // 0x0
	private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56677DC Offset: 0x56637DC VA: 0x56677DC
	|-TweenerCore<Color, Color, ColorOptions>..ctor
	|
	|-RVA: 0x5668630 Offset: 0x5664630 VA: 0x5668630
	|-TweenerCore<Color2, Color2, ColorOptions>..ctor
	|
	|-RVA: 0x56694C0 Offset: 0x56654C0 VA: 0x56694C0
	|-TweenerCore<double, double, NoOptions>..ctor
	|
	|-RVA: 0x566A2A8 Offset: 0x56662A8 VA: 0x566A2A8
	|-TweenerCore<int, int, NoOptions>..ctor
	|
	|-RVA: 0x566B098 Offset: 0x5667098 VA: 0x566B098
	|-TweenerCore<long, long, NoOptions>..ctor
	|
	|-RVA: 0x566BE88 Offset: 0x5667E88 VA: 0x566BE88
	|-TweenerCore<object, object, NoOptions>..ctor
	|
	|-RVA: 0x566CC6C Offset: 0x5668C6C VA: 0x566CC6C
	|-TweenerCore<object, object, StringOptions>..ctor
	|
	|-RVA: 0x566DAA4 Offset: 0x5669AA4 VA: 0x566DAA4
	|-TweenerCore<Quaternion, Quaternion, NoOptions>..ctor
	|
	|-RVA: 0x566E8F8 Offset: 0x566A8F8 VA: 0x566E8F8
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>..ctor
	|
	|-RVA: 0x566F770 Offset: 0x566B770 VA: 0x566F770
	|-TweenerCore<Rect, Rect, RectOptions>..ctor
	|
	|-RVA: 0x56705C4 Offset: 0x566C5C4 VA: 0x56705C4
	|-TweenerCore<float, float, FloatOptions>..ctor
	|
	|-RVA: 0x56713AC Offset: 0x566D3AC VA: 0x56713AC
	|-TweenerCore<uint, uint, UintOptions>..ctor
	|
	|-RVA: 0x567219C Offset: 0x566E19C VA: 0x567219C
	|-TweenerCore<ulong, ulong, NoOptions>..ctor
	|
	|-RVA: 0x5672F8C Offset: 0x566EF8C VA: 0x5672F8C
	|-TweenerCore<Vector2, Vector2, VectorOptions>..ctor
	|
	|-RVA: 0x5673D98 Offset: 0x566FD98 VA: 0x5673D98
	|-TweenerCore<Vector3, object, PathOptions>..ctor
	|
	|-RVA: 0x5674C0C Offset: 0x5670C0C VA: 0x5674C0C
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>..ctor
	|
	|-RVA: 0x56759F8 Offset: 0x56719F8 VA: 0x56759F8
	|-TweenerCore<Vector3, Vector3, VectorOptions>..ctor
	|
	|-RVA: 0x5676824 Offset: 0x5672824 VA: 0x5676824
	|-TweenerCore<Vector4, Vector4, VectorOptions>..ctor
	|
	|-RVA: 0x567767C Offset: 0x567367C VA: 0x567767C
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56678C4 Offset: 0x56638C4 VA: 0x56678C4
	|-TweenerCore<Color, Color, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x5668718 Offset: 0x5664718 VA: 0x5668718
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x56695A8 Offset: 0x56655A8 VA: 0x56695A8
	|-TweenerCore<double, double, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x566A390 Offset: 0x5666390 VA: 0x566A390
	|-TweenerCore<int, int, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x566B180 Offset: 0x5667180 VA: 0x566B180
	|-TweenerCore<long, long, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x566BF70 Offset: 0x5667F70 VA: 0x566BF70
	|-TweenerCore<object, object, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x566CD54 Offset: 0x5668D54 VA: 0x566CD54
	|-TweenerCore<object, object, StringOptions>.ChangeStartValue
	|
	|-RVA: 0x566DB8C Offset: 0x5669B8C VA: 0x566DB8C
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x566E9E0 Offset: 0x566A9E0 VA: 0x566E9E0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeStartValue
	|
	|-RVA: 0x566F858 Offset: 0x566B858 VA: 0x566F858
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeStartValue
	|
	|-RVA: 0x56706AC Offset: 0x566C6AC VA: 0x56706AC
	|-TweenerCore<float, float, FloatOptions>.ChangeStartValue
	|
	|-RVA: 0x5671494 Offset: 0x566D494 VA: 0x5671494
	|-TweenerCore<uint, uint, UintOptions>.ChangeStartValue
	|
	|-RVA: 0x5672284 Offset: 0x566E284 VA: 0x5672284
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x5673074 Offset: 0x566F074 VA: 0x5673074
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x5673E80 Offset: 0x566FE80 VA: 0x5673E80
	|-TweenerCore<Vector3, object, PathOptions>.ChangeStartValue
	|
	|-RVA: 0x5674CF4 Offset: 0x5670CF4 VA: 0x5674CF4
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeStartValue
	|
	|-RVA: 0x5675AE0 Offset: 0x5671AE0 VA: 0x5675AE0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x567690C Offset: 0x567290C VA: 0x567690C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x5677764 Offset: 0x5673764 VA: 0x5677764
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ChangeStartValue
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5667BA8 Offset: 0x5663BA8 VA: 0x5667BA8
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x5668A08 Offset: 0x5664A08 VA: 0x5668A08
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x5669888 Offset: 0x5665888 VA: 0x5669888
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566A670 Offset: 0x5666670 VA: 0x566A670
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566B460 Offset: 0x5667460 VA: 0x566B460
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566C24C Offset: 0x566824C VA: 0x566C24C
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566D030 Offset: 0x5669030 VA: 0x566D030
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x566DE70 Offset: 0x5669E70 VA: 0x566DE70
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566ECC4 Offset: 0x566ACC4 VA: 0x566ECC4
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x566FB3C Offset: 0x566BB3C VA: 0x566FB3C
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x567098C Offset: 0x566C98C VA: 0x567098C
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x5671774 Offset: 0x566D774 VA: 0x5671774
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x5672564 Offset: 0x566E564 VA: 0x5672564
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x5673354 Offset: 0x566F354 VA: 0x5673354
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x567415C Offset: 0x567015C VA: 0x567415C
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x5674FD0 Offset: 0x5670FD0 VA: 0x5674FD0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x5675DC4 Offset: 0x5671DC4 VA: 0x5675DC4
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x5676BF0 Offset: 0x5672BF0 VA: 0x5676BF0
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x5677AB0 Offset: 0x5673AB0 VA: 0x5677AB0
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5667BCC Offset: 0x5663BCC VA: 0x5667BCC
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x5668A2C Offset: 0x5664A2C VA: 0x5668A2C
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x56698AC Offset: 0x56658AC VA: 0x56698AC
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566A694 Offset: 0x5666694 VA: 0x566A694
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566B484 Offset: 0x5667484 VA: 0x566B484
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566C270 Offset: 0x5668270 VA: 0x566C270
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566D054 Offset: 0x5669054 VA: 0x566D054
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x566DE94 Offset: 0x5669E94 VA: 0x566DE94
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x566ECE8 Offset: 0x566ACE8 VA: 0x566ECE8
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x566FB60 Offset: 0x566BB60 VA: 0x566FB60
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x56709B0 Offset: 0x566C9B0 VA: 0x56709B0
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x5671798 Offset: 0x566D798 VA: 0x5671798
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x5672588 Offset: 0x566E588 VA: 0x5672588
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x5673378 Offset: 0x566F378 VA: 0x5673378
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x5674180 Offset: 0x5670180 VA: 0x5674180
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x5674FF4 Offset: 0x5670FF4 VA: 0x5674FF4
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x5675DE8 Offset: 0x5671DE8 VA: 0x5675DE8
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x5676C14 Offset: 0x5672C14 VA: 0x5676C14
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x5677AD4 Offset: 0x5673AD4 VA: 0x5677AD4
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5667EC4 Offset: 0x5663EC4 VA: 0x5667EC4
	|-TweenerCore<Color, Color, ColorOptions>.ChangeValues
	|
	|-RVA: 0x5668D2C Offset: 0x5664D2C VA: 0x5668D2C
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeValues
	|
	|-RVA: 0x5669BA0 Offset: 0x5665BA0 VA: 0x5669BA0
	|-TweenerCore<double, double, NoOptions>.ChangeValues
	|
	|-RVA: 0x566A988 Offset: 0x5666988 VA: 0x566A988
	|-TweenerCore<int, int, NoOptions>.ChangeValues
	|
	|-RVA: 0x566B778 Offset: 0x5667778 VA: 0x566B778
	|-TweenerCore<long, long, NoOptions>.ChangeValues
	|
	|-RVA: 0x566C560 Offset: 0x5668560 VA: 0x566C560
	|-TweenerCore<object, object, NoOptions>.ChangeValues
	|
	|-RVA: 0x566D344 Offset: 0x5669344 VA: 0x566D344
	|-TweenerCore<object, object, StringOptions>.ChangeValues
	|
	|-RVA: 0x566E18C Offset: 0x566A18C VA: 0x566E18C
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeValues
	|
	|-RVA: 0x566EFE0 Offset: 0x566AFE0 VA: 0x566EFE0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeValues
	|
	|-RVA: 0x566FE58 Offset: 0x566BE58 VA: 0x566FE58
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeValues
	|
	|-RVA: 0x5670CA4 Offset: 0x566CCA4 VA: 0x5670CA4
	|-TweenerCore<float, float, FloatOptions>.ChangeValues
	|
	|-RVA: 0x5671A8C Offset: 0x566DA8C VA: 0x5671A8C
	|-TweenerCore<uint, uint, UintOptions>.ChangeValues
	|
	|-RVA: 0x567287C Offset: 0x566E87C VA: 0x567287C
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeValues
	|
	|-RVA: 0x567366C Offset: 0x566F66C VA: 0x567366C
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeValues
	|
	|-RVA: 0x5674470 Offset: 0x5670470 VA: 0x5674470
	|-TweenerCore<Vector3, object, PathOptions>.ChangeValues
	|
	|-RVA: 0x56752E4 Offset: 0x56712E4 VA: 0x56752E4
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeValues
	|
	|-RVA: 0x56760E0 Offset: 0x56720E0 VA: 0x56760E0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeValues
	|
	|-RVA: 0x5676F0C Offset: 0x5672F0C VA: 0x5676F0C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeValues
	|
	|-RVA: 0x5677E34 Offset: 0x5673E34 VA: 0x5677E34
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ChangeValues
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Tweener SetFrom(bool relative) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56682D4 Offset: 0x56642D4 VA: 0x56682D4
	|-TweenerCore<Color, Color, ColorOptions>.SetFrom
	|
	|-RVA: 0x5669138 Offset: 0x5665138 VA: 0x5669138
	|-TweenerCore<Color2, Color2, ColorOptions>.SetFrom
	|
	|-RVA: 0x5669F94 Offset: 0x5665F94 VA: 0x5669F94
	|-TweenerCore<double, double, NoOptions>.SetFrom
	|
	|-RVA: 0x566AD7C Offset: 0x5666D7C VA: 0x566AD7C
	|-TweenerCore<int, int, NoOptions>.SetFrom
	|
	|-RVA: 0x566BB6C Offset: 0x5667B6C VA: 0x566BB6C
	|-TweenerCore<long, long, NoOptions>.SetFrom
	|
	|-RVA: 0x566C950 Offset: 0x5668950 VA: 0x566C950
	|-TweenerCore<object, object, NoOptions>.SetFrom
	|
	|-RVA: 0x566D734 Offset: 0x5669734 VA: 0x566D734
	|-TweenerCore<object, object, StringOptions>.SetFrom
	|
	|-RVA: 0x566E59C Offset: 0x566A59C VA: 0x566E59C
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.SetFrom
	|
	|-RVA: 0x566F3F0 Offset: 0x566B3F0 VA: 0x566F3F0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.SetFrom
	|
	|-RVA: 0x5670268 Offset: 0x566C268 VA: 0x5670268
	|-TweenerCore<Rect, Rect, RectOptions>.SetFrom
	|
	|-RVA: 0x5671098 Offset: 0x566D098 VA: 0x5671098
	|-TweenerCore<float, float, FloatOptions>.SetFrom
	|
	|-RVA: 0x5671E80 Offset: 0x566DE80 VA: 0x5671E80
	|-TweenerCore<uint, uint, UintOptions>.SetFrom
	|
	|-RVA: 0x5672C70 Offset: 0x566EC70 VA: 0x5672C70
	|-TweenerCore<ulong, ulong, NoOptions>.SetFrom
	|
	|-RVA: 0x5673A70 Offset: 0x566FA70 VA: 0x5673A70
	|-TweenerCore<Vector2, Vector2, VectorOptions>.SetFrom
	|
	|-RVA: 0x5674860 Offset: 0x5670860 VA: 0x5674860
	|-TweenerCore<Vector3, object, PathOptions>.SetFrom
	|
	|-RVA: 0x56756D4 Offset: 0x56716D4 VA: 0x56756D4
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.SetFrom
	|
	|-RVA: 0x56764F0 Offset: 0x56724F0 VA: 0x56764F0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.SetFrom
	|
	|-RVA: 0x567731C Offset: 0x567331C VA: 0x567731C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.SetFrom
	|
	|-RVA: 0x5678290 Offset: 0x5674290 VA: 0x5678290
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.SetFrom
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal sealed override void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5668310 Offset: 0x5664310 VA: 0x5668310
	|-TweenerCore<Color, Color, ColorOptions>.Reset
	|
	|-RVA: 0x5669174 Offset: 0x5665174 VA: 0x5669174
	|-TweenerCore<Color2, Color2, ColorOptions>.Reset
	|
	|-RVA: 0x5669FD0 Offset: 0x5665FD0 VA: 0x5669FD0
	|-TweenerCore<double, double, NoOptions>.Reset
	|
	|-RVA: 0x566ADB8 Offset: 0x5666DB8 VA: 0x566ADB8
	|-TweenerCore<int, int, NoOptions>.Reset
	|
	|-RVA: 0x566BBA8 Offset: 0x5667BA8 VA: 0x566BBA8
	|-TweenerCore<long, long, NoOptions>.Reset
	|
	|-RVA: 0x566C98C Offset: 0x566898C VA: 0x566C98C
	|-TweenerCore<object, object, NoOptions>.Reset
	|
	|-RVA: 0x566D770 Offset: 0x5669770 VA: 0x566D770
	|-TweenerCore<object, object, StringOptions>.Reset
	|
	|-RVA: 0x566E5D8 Offset: 0x566A5D8 VA: 0x566E5D8
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Reset
	|
	|-RVA: 0x566F42C Offset: 0x566B42C VA: 0x566F42C
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Reset
	|
	|-RVA: 0x56702A4 Offset: 0x566C2A4 VA: 0x56702A4
	|-TweenerCore<Rect, Rect, RectOptions>.Reset
	|
	|-RVA: 0x56710D4 Offset: 0x566D0D4 VA: 0x56710D4
	|-TweenerCore<float, float, FloatOptions>.Reset
	|
	|-RVA: 0x5671EBC Offset: 0x566DEBC VA: 0x5671EBC
	|-TweenerCore<uint, uint, UintOptions>.Reset
	|
	|-RVA: 0x5672CAC Offset: 0x566ECAC VA: 0x5672CAC
	|-TweenerCore<ulong, ulong, NoOptions>.Reset
	|
	|-RVA: 0x5673AAC Offset: 0x566FAAC VA: 0x5673AAC
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Reset
	|
	|-RVA: 0x567489C Offset: 0x567089C VA: 0x567489C
	|-TweenerCore<Vector3, object, PathOptions>.Reset
	|
	|-RVA: 0x5675710 Offset: 0x5671710 VA: 0x5675710
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Reset
	|
	|-RVA: 0x567652C Offset: 0x567252C VA: 0x567652C
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Reset
	|
	|-RVA: 0x5677358 Offset: 0x5673358 VA: 0x5677358
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Reset
	|
	|-RVA: 0x56782F0 Offset: 0x56742F0 VA: 0x56782F0
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override bool Validate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5668390 Offset: 0x5664390 VA: 0x5668390
	|-TweenerCore<Color, Color, ColorOptions>.Validate
	|
	|-RVA: 0x56691F4 Offset: 0x56651F4 VA: 0x56691F4
	|-TweenerCore<Color2, Color2, ColorOptions>.Validate
	|
	|-RVA: 0x566A050 Offset: 0x5666050 VA: 0x566A050
	|-TweenerCore<double, double, NoOptions>.Validate
	|
	|-RVA: 0x566AE38 Offset: 0x5666E38 VA: 0x566AE38
	|-TweenerCore<int, int, NoOptions>.Validate
	|
	|-RVA: 0x566BC28 Offset: 0x5667C28 VA: 0x566BC28
	|-TweenerCore<long, long, NoOptions>.Validate
	|
	|-RVA: 0x566CA0C Offset: 0x5668A0C VA: 0x566CA0C
	|-TweenerCore<object, object, NoOptions>.Validate
	|
	|-RVA: 0x566D7F0 Offset: 0x56697F0 VA: 0x566D7F0
	|-TweenerCore<object, object, StringOptions>.Validate
	|
	|-RVA: 0x566E658 Offset: 0x566A658 VA: 0x566E658
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Validate
	|
	|-RVA: 0x566F4AC Offset: 0x566B4AC VA: 0x566F4AC
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Validate
	|
	|-RVA: 0x5670324 Offset: 0x566C324 VA: 0x5670324
	|-TweenerCore<Rect, Rect, RectOptions>.Validate
	|
	|-RVA: 0x5671154 Offset: 0x566D154 VA: 0x5671154
	|-TweenerCore<float, float, FloatOptions>.Validate
	|
	|-RVA: 0x5671F3C Offset: 0x566DF3C VA: 0x5671F3C
	|-TweenerCore<uint, uint, UintOptions>.Validate
	|
	|-RVA: 0x5672D2C Offset: 0x566ED2C VA: 0x5672D2C
	|-TweenerCore<ulong, ulong, NoOptions>.Validate
	|
	|-RVA: 0x5673B2C Offset: 0x566FB2C VA: 0x5673B2C
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Validate
	|
	|-RVA: 0x567491C Offset: 0x567091C VA: 0x567491C
	|-TweenerCore<Vector3, object, PathOptions>.Validate
	|
	|-RVA: 0x5675790 Offset: 0x5671790 VA: 0x5675790
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Validate
	|
	|-RVA: 0x56765AC Offset: 0x56725AC VA: 0x56765AC
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Validate
	|
	|-RVA: 0x56773D8 Offset: 0x56733D8 VA: 0x56773D8
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Validate
	|
	|-RVA: 0x5678494 Offset: 0x5674494 VA: 0x5678494
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Validate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override float UpdateDelay(float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5668434 Offset: 0x5664434 VA: 0x5668434
	|-TweenerCore<Color, Color, ColorOptions>.UpdateDelay
	|
	|-RVA: 0x56692A4 Offset: 0x56652A4 VA: 0x56692A4
	|-TweenerCore<Color2, Color2, ColorOptions>.UpdateDelay
	|
	|-RVA: 0x566A0F4 Offset: 0x56660F4 VA: 0x566A0F4
	|-TweenerCore<double, double, NoOptions>.UpdateDelay
	|
	|-RVA: 0x566AEDC Offset: 0x5666EDC VA: 0x566AEDC
	|-TweenerCore<int, int, NoOptions>.UpdateDelay
	|
	|-RVA: 0x566BCCC Offset: 0x5667CCC VA: 0x566BCCC
	|-TweenerCore<long, long, NoOptions>.UpdateDelay
	|
	|-RVA: 0x566CAB0 Offset: 0x5668AB0 VA: 0x566CAB0
	|-TweenerCore<object, object, NoOptions>.UpdateDelay
	|
	|-RVA: 0x566D894 Offset: 0x5669894 VA: 0x566D894
	|-TweenerCore<object, object, StringOptions>.UpdateDelay
	|
	|-RVA: 0x566E6FC Offset: 0x566A6FC VA: 0x566E6FC
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.UpdateDelay
	|
	|-RVA: 0x566F550 Offset: 0x566B550 VA: 0x566F550
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.UpdateDelay
	|
	|-RVA: 0x56703C8 Offset: 0x566C3C8 VA: 0x56703C8
	|-TweenerCore<Rect, Rect, RectOptions>.UpdateDelay
	|
	|-RVA: 0x56711F8 Offset: 0x566D1F8 VA: 0x56711F8
	|-TweenerCore<float, float, FloatOptions>.UpdateDelay
	|
	|-RVA: 0x5671FE0 Offset: 0x566DFE0 VA: 0x5671FE0
	|-TweenerCore<uint, uint, UintOptions>.UpdateDelay
	|
	|-RVA: 0x5672DD0 Offset: 0x566EDD0 VA: 0x5672DD0
	|-TweenerCore<ulong, ulong, NoOptions>.UpdateDelay
	|
	|-RVA: 0x5673BD0 Offset: 0x566FBD0 VA: 0x5673BD0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.UpdateDelay
	|
	|-RVA: 0x56749C0 Offset: 0x56709C0 VA: 0x56749C0
	|-TweenerCore<Vector3, object, PathOptions>.UpdateDelay
	|
	|-RVA: 0x5675834 Offset: 0x5671834 VA: 0x5675834
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.UpdateDelay
	|
	|-RVA: 0x5676650 Offset: 0x5672650 VA: 0x5676650
	|-TweenerCore<Vector3, Vector3, VectorOptions>.UpdateDelay
	|
	|-RVA: 0x567747C Offset: 0x567347C VA: 0x567747C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.UpdateDelay
	|
	|-RVA: 0x56785BC Offset: 0x56745BC VA: 0x56785BC
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.UpdateDelay
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override bool Startup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5668444 Offset: 0x5664444 VA: 0x5668444
	|-TweenerCore<Color, Color, ColorOptions>.Startup
	|
	|-RVA: 0x56692B4 Offset: 0x56652B4 VA: 0x56692B4
	|-TweenerCore<Color2, Color2, ColorOptions>.Startup
	|
	|-RVA: 0x566A104 Offset: 0x5666104 VA: 0x566A104
	|-TweenerCore<double, double, NoOptions>.Startup
	|
	|-RVA: 0x566AEEC Offset: 0x5666EEC VA: 0x566AEEC
	|-TweenerCore<int, int, NoOptions>.Startup
	|
	|-RVA: 0x566BCDC Offset: 0x5667CDC VA: 0x566BCDC
	|-TweenerCore<long, long, NoOptions>.Startup
	|
	|-RVA: 0x566CAC0 Offset: 0x5668AC0 VA: 0x566CAC0
	|-TweenerCore<object, object, NoOptions>.Startup
	|
	|-RVA: 0x566D8A4 Offset: 0x56698A4 VA: 0x566D8A4
	|-TweenerCore<object, object, StringOptions>.Startup
	|
	|-RVA: 0x566E70C Offset: 0x566A70C VA: 0x566E70C
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Startup
	|
	|-RVA: 0x566F560 Offset: 0x566B560 VA: 0x566F560
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Startup
	|
	|-RVA: 0x56703D8 Offset: 0x566C3D8 VA: 0x56703D8
	|-TweenerCore<Rect, Rect, RectOptions>.Startup
	|
	|-RVA: 0x5671208 Offset: 0x566D208 VA: 0x5671208
	|-TweenerCore<float, float, FloatOptions>.Startup
	|
	|-RVA: 0x5671FF0 Offset: 0x566DFF0 VA: 0x5671FF0
	|-TweenerCore<uint, uint, UintOptions>.Startup
	|
	|-RVA: 0x5672DE0 Offset: 0x566EDE0 VA: 0x5672DE0
	|-TweenerCore<ulong, ulong, NoOptions>.Startup
	|
	|-RVA: 0x5673BE0 Offset: 0x566FBE0 VA: 0x5673BE0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Startup
	|
	|-RVA: 0x56749D0 Offset: 0x56709D0 VA: 0x56749D0
	|-TweenerCore<Vector3, object, PathOptions>.Startup
	|
	|-RVA: 0x5675844 Offset: 0x5671844 VA: 0x5675844
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Startup
	|
	|-RVA: 0x5676660 Offset: 0x5672660 VA: 0x5676660
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Startup
	|
	|-RVA: 0x567748C Offset: 0x567348C VA: 0x567748C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Startup
	|
	|-RVA: 0x56785D0 Offset: 0x56745D0 VA: 0x56785D0
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Startup
	*/

	// RVA: -1 Offset: -1 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5668454 Offset: 0x5664454 VA: 0x5668454
	|-TweenerCore<Color, Color, ColorOptions>.ApplyTween
	|
	|-RVA: 0x56692C4 Offset: 0x56652C4 VA: 0x56692C4
	|-TweenerCore<Color2, Color2, ColorOptions>.ApplyTween
	|
	|-RVA: 0x566A114 Offset: 0x5666114 VA: 0x566A114
	|-TweenerCore<double, double, NoOptions>.ApplyTween
	|
	|-RVA: 0x566AEFC Offset: 0x5666EFC VA: 0x566AEFC
	|-TweenerCore<int, int, NoOptions>.ApplyTween
	|
	|-RVA: 0x566BCEC Offset: 0x5667CEC VA: 0x566BCEC
	|-TweenerCore<long, long, NoOptions>.ApplyTween
	|
	|-RVA: 0x566CAD0 Offset: 0x5668AD0 VA: 0x566CAD0
	|-TweenerCore<object, object, NoOptions>.ApplyTween
	|
	|-RVA: 0x566D8B4 Offset: 0x56698B4 VA: 0x566D8B4
	|-TweenerCore<object, object, StringOptions>.ApplyTween
	|
	|-RVA: 0x566E71C Offset: 0x566A71C VA: 0x566E71C
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ApplyTween
	|
	|-RVA: 0x566F570 Offset: 0x566B570 VA: 0x566F570
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ApplyTween
	|
	|-RVA: 0x56703E8 Offset: 0x566C3E8 VA: 0x56703E8
	|-TweenerCore<Rect, Rect, RectOptions>.ApplyTween
	|
	|-RVA: 0x5671218 Offset: 0x566D218 VA: 0x5671218
	|-TweenerCore<float, float, FloatOptions>.ApplyTween
	|
	|-RVA: 0x5672000 Offset: 0x566E000 VA: 0x5672000
	|-TweenerCore<uint, uint, UintOptions>.ApplyTween
	|
	|-RVA: 0x5672DF0 Offset: 0x566EDF0 VA: 0x5672DF0
	|-TweenerCore<ulong, ulong, NoOptions>.ApplyTween
	|
	|-RVA: 0x5673BF0 Offset: 0x566FBF0 VA: 0x5673BF0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ApplyTween
	|
	|-RVA: 0x56749E0 Offset: 0x56709E0 VA: 0x56749E0
	|-TweenerCore<Vector3, object, PathOptions>.ApplyTween
	|
	|-RVA: 0x5675854 Offset: 0x5671854 VA: 0x5675854
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ApplyTween
	|
	|-RVA: 0x5676670 Offset: 0x5672670 VA: 0x5676670
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ApplyTween
	|
	|-RVA: 0x567749C Offset: 0x567349C VA: 0x567749C
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ApplyTween
	|
	|-RVA: 0x56785E4 Offset: 0x56745E4 VA: 0x56785E4
	|-TweenerCore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ApplyTween
	*/
}

// Namespace: DG.Tweening.Core.Enums
internal enum FilterType // TypeDefIndex: 25265
{
	// Fields
	public int value__; // 0x0
	public const FilterType All = 0;
	public const FilterType TargetOrId = 1;
	public const FilterType TargetAndId = 2;
	public const FilterType AllExceptTargetsOrIds = 3;
	public const FilterType DOGetter = 4;
}

// Namespace: DG.Tweening.Core.Enums
internal enum OperationType // TypeDefIndex: 25266
{
	// Fields
	public int value__; // 0x0
	public const OperationType Complete = 0;
	public const OperationType Despawn = 1;
	public const OperationType Flip = 2;
	public const OperationType Goto = 3;
	public const OperationType Pause = 4;
	public const OperationType Play = 5;
	public const OperationType PlayForward = 6;
	public const OperationType PlayBackwards = 7;
	public const OperationType Rewind = 8;
	public const OperationType SmoothRewind = 9;
	public const OperationType Restart = 10;
	public const OperationType TogglePause = 11;
	public const OperationType IsTweening = 12;
}

// Namespace: DG.Tweening.Core.Enums
internal enum SpecialStartupMode // TypeDefIndex: 25267
{
	// Fields
	public int value__; // 0x0
	public const SpecialStartupMode None = 0;
	public const SpecialStartupMode SetLookAt = 1;
	public const SpecialStartupMode SetShake = 2;
	public const SpecialStartupMode SetPunch = 3;
	public const SpecialStartupMode SetCameraShakePosition = 4;
}

// Namespace: DG.Tweening.Core.Enums
public enum UpdateNotice // TypeDefIndex: 25268
{
	// Fields
	public int value__; // 0x0
	public const UpdateNotice None = 0;
	public const UpdateNotice RewindStep = 1;
}

// Namespace: DG.Tweening.Core.Enums
internal enum UpdateMode // TypeDefIndex: 25269
{
	// Fields
	public int value__; // 0x0
	public const UpdateMode Update = 0;
	public const UpdateMode Goto = 1;
	public const UpdateMode IgnoreOnUpdate = 2;
}

// Namespace: DG.Tweening.Core.Easing
public static class Bounce // TypeDefIndex: 25270
{
	// Methods

	// RVA: 0x41102C0 Offset: 0x410C2C0 VA: 0x41102C0
	public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }

	// RVA: 0x41102DC Offset: 0x410C2DC VA: 0x41102DC
	public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }

	// RVA: 0x4110398 Offset: 0x410C398 VA: 0x4110398
	public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EaseManager.<>c // TypeDefIndex: 25271
{
	// Fields
	public static readonly EaseManager.<>c <>9; // 0x0
	public static EaseFunction <>9__4_0; // 0x8
	public static EaseFunction <>9__4_1; // 0x10
	public static EaseFunction <>9__4_2; // 0x18
	public static EaseFunction <>9__4_3; // 0x20
	public static EaseFunction <>9__4_4; // 0x28
	public static EaseFunction <>9__4_5; // 0x30
	public static EaseFunction <>9__4_6; // 0x38
	public static EaseFunction <>9__4_7; // 0x40
	public static EaseFunction <>9__4_8; // 0x48
	public static EaseFunction <>9__4_9; // 0x50
	public static EaseFunction <>9__4_10; // 0x58
	public static EaseFunction <>9__4_11; // 0x60
	public static EaseFunction <>9__4_12; // 0x68
	public static EaseFunction <>9__4_13; // 0x70
	public static EaseFunction <>9__4_14; // 0x78
	public static EaseFunction <>9__4_15; // 0x80
	public static EaseFunction <>9__4_16; // 0x88
	public static EaseFunction <>9__4_17; // 0x90
	public static EaseFunction <>9__4_18; // 0x98
	public static EaseFunction <>9__4_19; // 0xA0
	public static EaseFunction <>9__4_20; // 0xA8
	public static EaseFunction <>9__4_21; // 0xB0
	public static EaseFunction <>9__4_22; // 0xB8
	public static EaseFunction <>9__4_23; // 0xC0
	public static EaseFunction <>9__4_24; // 0xC8
	public static EaseFunction <>9__4_25; // 0xD0
	public static EaseFunction <>9__4_26; // 0xD8
	public static EaseFunction <>9__4_27; // 0xE0
	public static EaseFunction <>9__4_28; // 0xE8
	public static EaseFunction <>9__4_29; // 0xF0
	public static EaseFunction <>9__4_30; // 0xF8
	public static EaseFunction <>9__4_31; // 0x100
	public static EaseFunction <>9__4_32; // 0x108
	public static EaseFunction <>9__4_33; // 0x110
	public static EaseFunction <>9__4_34; // 0x118
	public static EaseFunction <>9__4_35; // 0x120

	// Methods

	// RVA: 0x41117BC Offset: 0x410D7BC VA: 0x41117BC
	private static void .cctor() { }

	// RVA: 0x4111824 Offset: 0x410D824 VA: 0x4111824
	public void .ctor() { }

	// RVA: 0x411182C Offset: 0x410D82C VA: 0x411182C
	internal float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111834 Offset: 0x410D834 VA: 0x4111834
	internal float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41118B4 Offset: 0x410D8B4 VA: 0x41118B4
	internal float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x411192C Offset: 0x410D92C VA: 0x411192C
	internal float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41119B4 Offset: 0x410D9B4 VA: 0x41119B4
	internal float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41119C0 Offset: 0x410D9C0 VA: 0x41119C0
	internal float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41119D8 Offset: 0x410D9D8 VA: 0x41119D8
	internal float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111A1C Offset: 0x410DA1C VA: 0x4111A1C
	internal float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111A2C Offset: 0x410DA2C VA: 0x4111A2C
	internal float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111A4C Offset: 0x410DA4C VA: 0x4111A4C
	internal float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111A94 Offset: 0x410DA94 VA: 0x4111A94
	internal float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111AA8 Offset: 0x410DAA8 VA: 0x4111AA8
	internal float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111ACC Offset: 0x410DACC VA: 0x4111ACC
	internal float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111B18 Offset: 0x410DB18 VA: 0x4111B18
	internal float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111B30 Offset: 0x410DB30 VA: 0x4111B30
	internal float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111B58 Offset: 0x410DB58 VA: 0x4111B58
	internal float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111BB0 Offset: 0x410DBB0 VA: 0x4111BB0
	internal float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111C38 Offset: 0x410DC38 VA: 0x4111C38
	internal float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111CC0 Offset: 0x410DCC0 VA: 0x4111CC0
	internal float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111DB0 Offset: 0x410DDB0 VA: 0x4111DB0
	internal float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111E2C Offset: 0x410DE2C VA: 0x4111E2C
	internal float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111EA4 Offset: 0x410DEA4 VA: 0x4111EA4
	internal float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4111F58 Offset: 0x410DF58 VA: 0x4111F58
	internal float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41120A4 Offset: 0x410E0A4 VA: 0x41120A4
	internal float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41121EC Offset: 0x410E1EC VA: 0x41121EC
	internal float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41123B8 Offset: 0x410E3B8 VA: 0x41123B8
	internal float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41123D8 Offset: 0x410E3D8 VA: 0x41123D8
	internal float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112404 Offset: 0x410E404 VA: 0x4112404
	internal float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112474 Offset: 0x410E474 VA: 0x4112474
	internal float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112490 Offset: 0x410E490 VA: 0x4112490
	internal float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112494 Offset: 0x410E494 VA: 0x4112494
	internal float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112498 Offset: 0x410E498 VA: 0x4112498
	internal float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41124A0 Offset: 0x410E4A0 VA: 0x41124A0
	internal float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41124A8 Offset: 0x410E4A8 VA: 0x41124A8
	internal float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41124B0 Offset: 0x410E4B0 VA: 0x41124B0
	internal float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41124B8 Offset: 0x410E4B8 VA: 0x41124B8
	internal float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period) { }
}

// Namespace: DG.Tweening.Core.Easing
public static class EaseManager // TypeDefIndex: 25272
{
	// Fields
	private const float _PiOver2 = 1.5707964;
	private const float _TwoPi = 6.2831855;

	// Methods

	// RVA: 0x41103E8 Offset: 0x410C3E8 VA: 0x41103E8
	public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4102240 Offset: 0x40FE240 VA: 0x4102240
	public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4110408 Offset: 0x410C408 VA: 0x4110408
	public static EaseFunction ToEaseFunction(Ease ease) { }

	// RVA: 0x41117AC Offset: 0x410D7AC VA: 0x41117AC
	internal static bool IsFlashEase(Ease ease) { }
}

// Namespace: DG.Tweening.Core.Easing
public class EaseCurve // TypeDefIndex: 25273
{
	// Fields
	private readonly AnimationCurve _animCurve; // 0x10

	// Methods

	// RVA: 0x41124D0 Offset: 0x410E4D0 VA: 0x41124D0
	public void .ctor(AnimationCurve animCurve) { }

	// RVA: 0x4112500 Offset: 0x410E500 VA: 0x4112500
	public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod) { }
}

// Namespace: DG.Tweening.Core.Easing
public static class Flash // TypeDefIndex: 25274
{
	// Methods

	// RVA: 0x411259C Offset: 0x410E59C VA: 0x411259C
	public static float Ease(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x41127A4 Offset: 0x410E7A4 VA: 0x41127A4
	public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x411286C Offset: 0x410E86C VA: 0x411286C
	public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112940 Offset: 0x410E940 VA: 0x4112940
	public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x4112660 Offset: 0x410E660 VA: 0x4112660
	private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 25275
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=50 // TypeDefIndex: 25276
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 // TypeDefIndex: 25277
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 25278
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=50 6F98278EFCD257898AD01BE39D1D0AEFB78FC551 /*Metadata offset 0xF40260*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 8C4C6C4E493EC2BEEF5F6F6A9C4472C13BED42E8 /*Metadata offset 0xF40298*/; // 0x32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 9DC5F4D0A1418B4EC71B22D21E93D134922FA735 /*Metadata offset 0xF402B0*/; // 0x46
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=50 FD0BD55CDDDFD0B323012A45F83437763AF58952 /*Metadata offset 0xF40330*/; // 0xBE
}

