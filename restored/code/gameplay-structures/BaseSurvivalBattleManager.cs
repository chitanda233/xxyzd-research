// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal abstract class BaseSurvivalBattleManager : SinglePlayerBattleManager // TypeDefIndex: 10461
{
	// Fields
	protected const int MaxCreateMonsterCount = 600;
	protected readonly BaseSurvivalBattleManager.CreateMonsterData[] MonsterCreateData; // 0xA0
	protected int CreateMonsterCount; // 0xA8
	protected bool OnlyNpcMission; // 0xAC
	protected FP RefreshNextMissionTime; // 0xB0
	private FP _nextNoticeTime; // 0xB8
	private int _nextMissionType; // 0xC0
	private int[] _nextShowSpecialUIType; // 0xC8
	public int _refreshNextMissionEnemyCount; // 0xD0
	private bool _lastMissionRefreshStarted; // 0xD4
	private RefreshStateMachine _refreshMachine; // 0xD8
	protected int CurMissionType; // 0xE0
	protected int LastMissionType; // 0xE4
	protected FP _battleTime; // 0xE8
	public int _battleResultType; // 0xF0
	public FP _battleResultParam; // 0xF8
	private const int RefreshStateNone = 0;
	private const int RefreshStateNotice = 1;
	private const int RefreshStateRefresh = 2;
	private const int RefreshStateDevil = 3;
	private const int RefreshStateFirst = 4;
	private const int RefreshStateFortune = 5;
	protected const int RefreshStatePunchboard = 6;
	protected const int RefreshStateWaveShowStartUI = 7;
	protected const int RefreshStateWaveEnd = 8;
	protected const int RefreshStateWaveShowStarUI = 9;
	protected const int RefreshStateWaveShowEndUI = 10;
	private bool _hasSendBossAppearEvent; // 0x100
	private bool _hasSendEnemyAppearEvent; // 0x101
	protected bool CurrentIsLastMission; // 0x102

	// Properties
	public override int BattleChapterType { get; }
	private int _refreshState { get; }
	protected bool InRefreshState { get; }
	protected bool IsFirstRefresh { get; }
	public bool IsStateWaveShowEnd { get; }
	protected bool IsWaitingForWaveStartUIProgress { get; }
	internal override int MissionType { get; }
	protected override bool CheckDropClear { get; }

	// Methods

	// RVA: 0x6585D60 Offset: 0x6581D60 VA: 0x6585D60 Slot: 6
	public override int get_BattleChapterType() { }

	// RVA: 0x6585DC4 Offset: 0x6581DC4 VA: 0x6585DC4 Slot: 66
	public override bool IsLastBossWave() { }

	// RVA: 0x6585E3C Offset: 0x6581E3C VA: 0x6585E3C
	public int GetRealChapterType() { }

	// RVA: 0x6585F54 Offset: 0x6581F54 VA: 0x6585F54 Slot: 48
	public override void OnChapterEnd() { }

	// RVA: 0x6585FC4 Offset: 0x6581FC4 VA: 0x6585FC4 Slot: 49
	public override void OnMissionClear() { }

	// RVA: 0x6586024 Offset: 0x6582024 VA: 0x6586024 Slot: 21
	public override void OnProgressFinish() { }

	// RVA: 0x6586084 Offset: 0x6582084 VA: 0x6586084 Slot: 52
	protected override void OnUpdateHook(FP deltaTime) { }

	// RVA: 0x65871B0 Offset: 0x65831B0 VA: 0x65871B0
	private int get__refreshState() { }

	// RVA: 0x6587254 Offset: 0x6583254 VA: 0x6587254
	protected bool get_InRefreshState() { }

	// RVA: 0x65872C4 Offset: 0x65832C4 VA: 0x65872C4
	protected bool get_IsFirstRefresh() { }

	// RVA: 0x6587334 Offset: 0x6583334 VA: 0x6587334
	public bool get_IsStateWaveShowEnd() { }

	// RVA: 0x65873A4 Offset: 0x65833A4 VA: 0x65873A4
	protected bool get_IsWaitingForWaveStartUIProgress() { }

	// RVA: 0x6587414 Offset: 0x6583414 VA: 0x6587414 Slot: 73
	protected virtual bool CheckIsPauseState() { }

	// RVA: 0x6587478 Offset: 0x6583478 VA: 0x6587478
	public void WaterfallProgressFinishGoNext() { }

	// RVA: 0x65875AC Offset: 0x65835AC VA: 0x65875AC
	public void EnemySpecialDie() { }

	// RVA: 0x6587518 Offset: 0x6583518 VA: 0x6587518
	private void SetRefreshState(int state, bool force = False) { }

	// RVA: 0x6587048 Offset: 0x6583048 VA: 0x6587048
	private void UpdateBattleTime(FP deltaTime) { }

	// RVA: 0x6587618 Offset: 0x6583618 VA: 0x6587618
	private void DispatchTimeEvent() { }

	// RVA: 0x65863C8 Offset: 0x65823C8 VA: 0x65863C8
	private void UpdateRefreshTime(FP deltaTime) { }

	// RVA: 0x658783C Offset: 0x658383C VA: 0x658783C
	public void ClearMonsterCreateData() { }

	// RVA: 0x65878A0 Offset: 0x65838A0 VA: 0x65878A0
	protected void ResetLastMissionRefreshStarted() { }

	// RVA: 0x6587904 Offset: 0x6583904 VA: 0x6587904
	protected void MarkLastMissionRefreshStarted() { }

	// RVA: 0x6586450 Offset: 0x6582450 VA: 0x6586450
	private void UpdateCreateMonsters(FP deltaTime) { }

	// RVA: 0x6587AA8 Offset: 0x6583AA8 VA: 0x6587AA8 Slot: 55
	public override void OnLoadEnd() { }

	// RVA: 0x6587B08 Offset: 0x6583B08 VA: 0x6587B08 Slot: 74
	protected virtual void InitRefreshStateMachine() { }

	// RVA: 0x6587E64 Offset: 0x6583E64 VA: 0x6587E64
	internal bool CheckIsPauseStateInternal() { }

	// RVA: 0x6587EC8 Offset: 0x6583EC8 VA: 0x6587EC8
	internal FP GetNextNoticeTime() { }

	// RVA: 0x6587F2C Offset: 0x6583F2C VA: 0x6587F2C
	internal bool GetCurrentIsLastMission() { }

	// RVA: 0x6587F90 Offset: 0x6583F90 VA: 0x6587F90
	internal FP GetRefreshNextMissionTime() { }

	// RVA: 0x6587FF4 Offset: 0x6583FF4 VA: 0x6587FF4
	internal int GetCurMissionType() { }

	// RVA: 0x6588058 Offset: 0x6584058 VA: 0x6588058
	internal void NextWaveInternal() { }

	// RVA: 0x65882B4 Offset: 0x65842B4 VA: 0x65882B4
	internal void ResetEnemyAppearFlag() { }

	// RVA: 0x6588318 Offset: 0x6584318 VA: 0x6588318
	internal EntityHeroNormal GetCurPlayer() { }

	// RVA: 0x658837C Offset: 0x658437C VA: 0x658837C
	internal void TriggerWaveFinishEventInternal(int missionType) { }

	// RVA: 0x65883FC Offset: 0x65843FC VA: 0x65883FC Slot: 8
	internal override int get_MissionType() { }

	// RVA: 0x6588460 Offset: 0x6584460 VA: 0x6588460
	protected void SetNextMissionData(int missionType) { }

	// RVA: 0x65884D8 Offset: 0x65844D8 VA: 0x65884D8
	protected void InitWaterfall() { }

	// RVA: 0x658853C Offset: 0x658453C VA: 0x658853C
	protected void InitNoticeTime() { }

	// RVA: 0x65885A0 Offset: 0x65845A0 VA: 0x65885A0
	private void InitNormalNoticeTime() { }

	// RVA: 0x658861C Offset: 0x658461C VA: 0x658861C Slot: 75
	protected virtual void FixNoticeTime(ref FP noticeTime) { }

	// RVA: 0x6588698 Offset: 0x6584698 VA: 0x6588698
	protected void CreateMissionNpc(FP delayTime) { }

	// RVA: 0x6588BE0 Offset: 0x6584BE0 VA: 0x6588BE0
	protected void CreatePunchboard(FP delayTime) { }

	// RVA: 0x6588C68 Offset: 0x6584C68 VA: 0x6588C68 Slot: 34
	public override void OnEnemyDie(EntityCharacter entityMonster, TakeDamageData damage) { }

	// RVA: 0x6588F5C Offset: 0x6584F5C VA: 0x6588F5C Slot: 76
	public virtual void EnemyDieSpecialLogic(EntityCharacter entityMonster) { }

	// RVA: 0x65890C8 Offset: 0x65850C8 VA: 0x65890C8
	private void CheckSendDisappearEvent() { }

	// RVA: 0x6587974 Offset: 0x6583974 VA: 0x6587974
	private void CheckSendAppearEvent() { }

	// RVA: 0x658918C Offset: 0x658518C VA: 0x658918C
	private bool IsPassed() { }

	// RVA: 0x65893A4 Offset: 0x65853A4 VA: 0x65893A4 Slot: 33
	public override void OnEnemeyDieStart(EntityCharacter monster, TakeDamageData damage) { }

	// RVA: 0x6589794 Offset: 0x6585794 VA: 0x6589794 Slot: 14
	internal override void CheckEnemyAllDie() { }

	// RVA: 0x6589ABC Offset: 0x6585ABC VA: 0x6589ABC Slot: 77
	protected virtual void CheckGoNextMission() { }

	// RVA: 0x6589BC8 Offset: 0x6585BC8 VA: 0x6589BC8
	protected void GoNextWave() { }

	// RVA: 0x6589C54 Offset: 0x6585C54 VA: 0x6589C54 Slot: 78
	protected virtual bool CheckContractDevil() { }

	// RVA: 0x6589DEC Offset: 0x6585DEC VA: 0x6589DEC Slot: 38
	protected override bool get_CheckDropClear() { }

	// RVA: 0x6589E50 Offset: 0x6585E50 VA: 0x6589E50 Slot: 72
	protected override void OnRemoveNpc(EntityNpc npc) { }

	// RVA: 0x658A004 Offset: 0x6586004 VA: 0x658A004 Slot: 79
	protected virtual void SaveBattleRecord() { }

	// RVA: -1 Offset: -1 Slot: 80
	public abstract void TrackerWaveEvent(bool isEnd = False);

	// RVA: 0x658A0E8 Offset: 0x65860E8 VA: 0x658A0E8
	private void NextWave() { }

	// RVA: 0x658A14C Offset: 0x658614C VA: 0x658A14C Slot: 81
	protected virtual void TryClearBullet() { }

	// RVA: 0x658A204 Offset: 0x6586204 VA: 0x658A204 Slot: 43
	internal override void TriggerWaveEvent() { }

	// RVA: 0x6587A40 Offset: 0x6583A40 VA: 0x6587A40
	internal void TriggerEnemyFirstCreateInWaveEvent() { }

	// RVA: 0x658A270 Offset: 0x6586270 VA: 0x658A270 Slot: 64
	public override void OnFirstEnterBattle() { }

	// RVA: 0x658A3A8 Offset: 0x65863A8 VA: 0x658A3A8 Slot: 22
	public override bool IsLastMission() { }

	// RVA: 0x658A40C Offset: 0x658640C VA: 0x658A40C Slot: 82
	public virtual bool IsWaveLastMission() { }

	// RVA: 0x658A470 Offset: 0x6586470 VA: 0x658A470 Slot: 83
	public virtual bool IsWaveShowStartUIMission() { }

	// RVA: 0x658A4D4 Offset: 0x65864D4 VA: 0x658A4D4 Slot: 84
	public virtual bool CheckWaveShowStartUI() { }

	// RVA: 0x658A538 Offset: 0x6586538 VA: 0x658A538 Slot: 85
	public virtual bool CheckWaveShowEndUI() { }

	// RVA: 0x658A59C Offset: 0x658659C VA: 0x658A59C Slot: 86
	public virtual int WaveShowStartUIHandle() { }

	// RVA: 0x658A600 Offset: 0x6586600 VA: 0x658A600 Slot: 87
	public virtual void WaveEndHandle() { }

	// RVA: 0x658A660 Offset: 0x6586660 VA: 0x658A660
	protected void .ctor() { }
}

