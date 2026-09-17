// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class BeeMonsterCreator : PooledWorldElement // TypeDefIndex: 10562
{
	// Fields
	[CompilerGenerated]
	private int <FlushId>k__BackingField; // 0x28
	private FP _startTime; // 0x30
	private bool _isFirstFlush; // 0x38
	private bool _isOn; // 0x39
	private int _beeMonsterId; // 0x3C
	private FPVector3 _flushPoint; // 0x40
	private FP _bornInterval; // 0x58
	private int _bornCount; // 0x60
	private int _missionId; // 0x64
	private FP _flushInterval; // 0x68
	private FP _startFlushInterval; // 0x70
	private List<BeeMonsterRefresher> _refreshers; // 0x78
	private List<BeeMonsterRefresher> _refreshers2Remove; // 0x80
	private Dictionary<int, BezierCurve> bezierCurveDict; // 0x88

	// Properties
	public int FlushId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x65B9D28 Offset: 0x65B5D28 VA: 0x65B9D28
	public int get_FlushId() { }

	[CompilerGenerated]
	// RVA: 0x65B9D8C Offset: 0x65B5D8C VA: 0x65B9D8C
	private void set_FlushId(int value) { }

	// RVA: 0x65B9E04 Offset: 0x65B5E04 VA: 0x65B9E04
	public void SetData(int beeMonsterFlushConfigId, int missionId) { }

	// RVA: 0x65BA3D0 Offset: 0x65B63D0 VA: 0x65BA3D0
	public void Update(FP deltaTime) { }

	// RVA: 0x65BAF54 Offset: 0x65B6F54 VA: 0x65BAF54
	private FPVector3 tryGetFlushPoint(int pathId) { }

	// RVA: 0x65BB080 Offset: 0x65B7080 VA: 0x65BB080
	public void SetFlushId(int id) { }

	// RVA: 0x65BB12C Offset: 0x65B712C VA: 0x65BB12C
	public void OnMissionClear() { }

	// RVA: 0x65BB318 Offset: 0x65B7318 VA: 0x65BB318
	public void .ctor() { }
}

