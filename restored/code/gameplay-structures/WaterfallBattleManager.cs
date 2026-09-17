// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class WaterfallBattleManager : BaseSurvivalBattleManager // TypeDefIndex: 10593
{
	// Fields
	private FP m_FightTime; // 0x108
	private int m_LastFightTime; // 0x110
	private int m_MaxFightTime; // 0x114
	private bool m_IsZero; // 0x118
	private FP m_InitBattleMissionTime; // 0x120
	public int m_PunchboardMissCount; // 0x128
	private int _curShowWaveIndex; // 0x12C
	private int _curWave; // 0x130
	private int _curWaveFirstMissionId; // 0x134
	private int _curWaveLastMissionId; // 0x138
	private int _curWaveShowStartUIMissionId; // 0x13C
	private ChapterWave_Waves _curWaveSections; // 0x140
	private int _remainSpecialMonsterCount; // 0x148
	private int _remainAllMonsterCount; // 0x14C
	private int _expCount; // 0x150
	private FP _perExp; // 0x158
	private FP _addExp; // 0x160
	private OrderedDictionary<int, int> _dropType2GoldWeightCount; // 0x168
	private FP _perGold; // 0x170
	private int _addGoldCoinMonsterCount; // 0x178
	private int _curWaveMonsterIndex; // 0x17C
	private bool _needUploadBattleData; // 0x180
	private IWaterfallMission _curMissionData; // 0x188
	private List<BeeMonsterCreator> _beeMonsterCreators; // 0x190
	private int _showUIIndex; // 0x198
	private int _lastBossNoticeTriggerMissionIndex; // 0x19C
	private int _lastBossNoticeTriggerNoticeIndex; // 0x1A0
	private bool _isInMissileBoostDuration; // 0x1A4
	private bool _executeBoostStart; // 0x1A5
	private bool _executeBoostEnd; // 0x1A6
	private int _missileBoostCount; // 0x1A8
	private FP _missileBoostDuration; // 0x1B0
	private int _missileBoostEntityId; // 0x1B8
	private FP _waveElapsedTime; // 0x1C0
	public int curWaveUpLevelCount; // 0x1C8
	private int _needUpLevelCount; // 0x1CC
	private WaterfallBattleManager.WaveEndUpLevelProgressState _waveEndUpLevelProgressState; // 0x1D0
	private bool isInUplevelAbsorbAll; // 0x1D4
	private FP delayOpenLevelUpTime; // 0x1D8
	private FP curOpenLevelUpTime; // 0x1E0
	private int[] _curDoSpecialUIs; // 0x1E8
	private Dictionary<int, WaveMissionRandomData> _curWaveMissionRandomDatas; // 0x1F0
	private List<int> _randomWaveGoldMonsterIndex; // 0x1F8
	private readonly List<WaterfallBattleManager.IWaveUpdateListener> _waveUpdateListeners; // 0x200
	private FP testGoldValue; // 0x208
	private bool isWaveFirstSelectSkill; // 0x210

	// Properties
	public int CurShowWaveIndex { get; set; }
	public override int BattleChapterType { get; }
	public bool IsInMissileBoostDuration { get; }
	public FP WaveElapsedTime { get; }
	public int NeedUpLevelCount { get; }

	// Methods

	// RVA: 0x65C7558 Offset: 0x65C3558 VA: 0x65C7558
	public int get_CurShowWaveIndex() { }

	// RVA: 0x65C75BC Offset: 0x65C35BC VA: 0x65C75BC
	public void set_CurShowWaveIndex(int value) { }

	// RVA: 0x65C7648 Offset: 0x65C3648 VA: 0x65C7648 Slot: 6
	public override int get_BattleChapterType() { }

	// RVA: 0x65C76AC Offset: 0x65C36AC VA: 0x65C76AC
	public bool get_IsInMissileBoostDuration() { }

	// RVA: 0x65C7710 Offset: 0x65C3710 VA: 0x65C7710
	public FP get_WaveElapsedTime() { }

	// RVA: 0x65C7774 Offset: 0x65C3774 VA: 0x65C7774
	public int get_NeedUpLevelCount() { }

	// RVA: 0x65C77D8 Offset: 0x65C37D8 VA: 0x65C77D8
	public void RegisterWaveUpdateListener(WaterfallBattleManager.IWaveUpdateListener listener) { }

	// RVA: 0x65C7908 Offset: 0x65C3908 VA: 0x65C7908
	public void UnregisterWaveUpdateListener(WaterfallBattleManager.IWaveUpdateListener listener) { }

	// RVA: 0x65C79A4 Offset: 0x65C39A4 VA: 0x65C79A4 Slot: 50
	protected override void OnInit() { }

	// RVA: 0x65C8890 Offset: 0x65C4890 VA: 0x65C8890
	public void AddUpLevel() { }

	// RVA: 0x65C88FC Offset: 0x65C48FC VA: 0x65C88FC
	public void DelUpLevel() { }

	// RVA: 0x65C8978 Offset: 0x65C4978 VA: 0x65C8978
	internal bool ShouldApplyLevelOnSelectSkillEnter() { }

	// RVA: 0x65C8A00 Offset: 0x65C4A00 VA: 0x65C8A00
	internal bool MarkWaveEndSelectSkillFinished() { }

	// RVA: 0x65C8A88 Offset: 0x65C4A88 VA: 0x65C8A88
	internal void OnWaveEndSelectSkillExit(bool selectFinished, int nextStateId) { }

	// RVA: 0x65C8B28 Offset: 0x65C4B28 VA: 0x65C8B28
	internal bool TryContinueWaveEndUpLevelAfterSelection() { }

	// RVA: 0x65C8C14 Offset: 0x65C4C14 VA: 0x65C8C14
	internal void TryResumeWaveEndUpLevelProgress() { }

	// RVA: 0x65C8CD0 Offset: 0x65C4CD0 VA: 0x65C8CD0
	private bool IsCurrentUpLevelUI() { }

	// RVA: 0x65C8D70 Offset: 0x65C4D70 VA: 0x65C8D70
	private bool CanRunUpLevelProgress() { }

	// RVA: 0x65C8E98 Offset: 0x65C4E98 VA: 0x65C8E98
	private void QueueSelectSkill() { }

	// RVA: 0x65C8F4C Offset: 0x65C4F4C VA: 0x65C8F4C Slot: 71
	public override void OnStart() { }

	// RVA: 0x65C9218 Offset: 0x65C5218 VA: 0x65C9218 Slot: 79
	protected override void SaveBattleRecord() { }

	// RVA: 0x65C9388 Offset: 0x65C5388 VA: 0x65C9388 Slot: 18
	public override void OnBattleEnd(int winPlayerId) { }

	// RVA: 0x65C9420 Offset: 0x65C5420 VA: 0x65C9420 Slot: 68
	public override void UploadBattleData() { }

	// RVA: 0x65CA5A8 Offset: 0x65C65A8 VA: 0x65CA5A8 Slot: 80
	public override void TrackerWaveEvent(bool isEnd = False) { }

	// RVA: 0x65CA828 Offset: 0x65C6828 VA: 0x65CA828 Slot: 13
	internal override void AddExpAndGold() { }

	// RVA: 0x65CAD14 Offset: 0x65C6D14 VA: 0x65CAD14 Slot: 56
	public override void RefreshBattleData() { }

	// RVA: 0x65CC3F8 Offset: 0x65C83F8 VA: 0x65CC3F8 Slot: 44
	protected override int GetMissionType(int missionId) { }

	// RVA: 0x65CC5E0 Offset: 0x65C85E0 VA: 0x65CC5E0 Slot: 12
	internal override void OnMissionIncrease() { }

	// RVA: 0x65CC838 Offset: 0x65C8838 VA: 0x65CC838 Slot: 21
	public override void OnProgressFinish() { }

	// RVA: 0x65CCEDC Offset: 0x65C8EDC VA: 0x65CCEDC
	private void TriggerBossNoticeStart() { }

	// RVA: 0x65CD0F0 Offset: 0x65C90F0 VA: 0x65CD0F0 Slot: 27
	public override bool CheckIsWaveFirstSelectSkill() { }

	// RVA: 0x65CC650 Offset: 0x65C8650 VA: 0x65CC650
	private void tryClearBeeMonsterCreators() { }

	// RVA: 0x65CD158 Offset: 0x65C9158 VA: 0x65CD158 Slot: 46
	public override void RefreshMonsters() { }

	// RVA: 0x65CE628 Offset: 0x65CA628 VA: 0x65CE628
	private void tryStartMissileBoostOnWaveStart() { }

	// RVA: 0x65CE6F0 Offset: 0x65CA6F0 VA: 0x65CE6F0
	public void HeroMissileBoostStart() { }

	// RVA: 0x65CE3F4 Offset: 0x65CA3F4 VA: 0x65CE3F4
	private void CreateIntervalMonster() { }

	// RVA: 0x65CE8E8 Offset: 0x65CA8E8 VA: 0x65CE8E8
	private void CreateTileMonster(FP intervalDelay) { }

	// RVA: 0x65CDB00 Offset: 0x65C9B00 VA: 0x65CDB00
	private void CreateTileNpc() { }

	// RVA: 0x65CB634 Offset: 0x65C7634 VA: 0x65CB634
	private void InitNewWaveData() { }

	// RVA: 0x65D0EC0 Offset: 0x65CCEC0 VA: 0x65D0EC0
	private void InitWaveGoldData() { }

	// RVA: 0x65D0C70 Offset: 0x65CCC70 VA: 0x65D0C70
	private void CalSpecialMonsterCount(IWaterfallMission calMissionData) { }

	// RVA: 0x65D2244 Offset: 0x65CE244 VA: 0x65D2244
	private CalMonsterCountData CalPositionGroupSpecialMonsterCount(IWaterfallMission calMissionData, int repeatCount) { }

	// RVA: 0x65D3844 Offset: 0x65CF844 VA: 0x65D3844
	private void AddDropType2Count(Character_entity charData, bool isStopByEliteOrBossKilled, int repeatCount) { }

	// RVA: 0x65D0B58 Offset: 0x65CCB58 VA: 0x65D0B58
	private bool AddGoldMonster(Character_entity charData) { }

	// RVA: 0x65D1854 Offset: 0x65CD854 VA: 0x65D1854
	private CalMonsterCountData CalTileSpecialMonsterCount(IWaterfallMission calMissionData, int repeatCount) { }

	// RVA: 0x65D2D9C Offset: 0x65CED9C VA: 0x65D2D9C
	private CalMonsterCountData CalRandomMonster(IWaterfallMission calMissionData, int repeatCount) { }

	// RVA: 0x65D3784 Offset: 0x65CF784 VA: 0x65D3784
	private bool CheckStopByEliteOrBossKilled() { }

	// RVA: 0x65CF35C Offset: 0x65CB35C VA: 0x65CF35C
	private void CreateTileGroupMonster(FP intervalDelay) { }

	// RVA: 0x65CFF58 Offset: 0x65CBF58 VA: 0x65CFF58
	private void CreateRandomMonster(FP intervalDelay) { }

	// RVA: 0x65D3A78 Offset: 0x65CFA78 VA: 0x65D3A78
	private FPVector3 RandomPos(FP width, int height, MapManager mapMgr, int curIndex) { }

	// RVA: 0x65D3C88 Offset: 0x65CFC88 VA: 0x65D3C88
	private bool CheckPosValid(int index, FPVector3 randomPos) { }

	// RVA: 0x65CE0B0 Offset: 0x65CA0B0 VA: 0x65CE0B0
	private void CreateBeeMonsterCreator() { }

	// RVA: 0x65D3DEC Offset: 0x65CFDEC VA: 0x65D3DEC
	private void onSetFlushId(int flushId) { }

	// RVA: 0x65D404C Offset: 0x65D004C VA: 0x65D404C Slot: 78
	protected override bool CheckContractDevil() { }

	// RVA: 0x65D41D0 Offset: 0x65D01D0 VA: 0x65D41D0 Slot: 52
	protected override void OnUpdateHook(FP deltaTime) { }

	// RVA: 0x65D47BC Offset: 0x65D07BC VA: 0x65D47BC Slot: 73
	protected override bool CheckIsPauseState() { }

	// RVA: 0x65D4824 Offset: 0x65D0824 VA: 0x65D4824
	private bool CheckNeedPause(bool isEnter) { }

	// RVA: 0x65CC05C Offset: 0x65C805C VA: 0x65CC05C
	private void UpdateFightTime() { }

	// RVA: 0x65D4928 Offset: 0x65D0928 VA: 0x65D4928 Slot: 63
	public override int GetBattleShowWave() { }

	// RVA: 0x65D49C0 Offset: 0x65D09C0 VA: 0x65D49C0 Slot: 37
	protected override bool IsDropClear() { }

	// RVA: 0x65D4B34 Offset: 0x65D0B34 VA: 0x65D4B34 Slot: 36
	internal override bool CanTriggerSkill() { }

	// RVA: 0x65D4C18 Offset: 0x65D0C18 VA: 0x65D4C18 Slot: 77
	protected override void CheckGoNextMission() { }

	// RVA: 0x65CD7C4 Offset: 0x65C97C4 VA: 0x65CD7C4
	private void CreatePunchboardNpc() { }

	// RVA: 0x65CD8EC Offset: 0x65C98EC VA: 0x65CD8EC
	protected void RefreshRandomNpc() { }

	// RVA: 0x65D4DC0 Offset: 0x65D0DC0 VA: 0x65D4DC0
	public void StartMissileBoost(int missileCount, FP duration, int secondWeaponEntityId) { }

	// RVA: 0x65D4E80 Offset: 0x65D0E80 VA: 0x65D4E80 Slot: 76
	public override void EnemyDieSpecialLogic(EntityCharacter entityMonster) { }

	// RVA: 0x65D5144 Offset: 0x65D1144 VA: 0x65D5144 Slot: 31
	public override FP GetCharacterDropExp(EntityCharacterData characterData, Item_battle tableData, FP deltaExpPercent) { }

	// RVA: 0x65D56C4 Offset: 0x65D16C4 VA: 0x65D56C4 Slot: 29
	public override int GetCharacterDropCoinCount(EntityCharacterData characterData) { }

	// RVA: 0x65D57E0 Offset: 0x65D17E0 VA: 0x65D57E0 Slot: 30
	public override int GetCharacterDropExpCount(EntityCharacterData characterData) { }

	// RVA: 0x65D563C Offset: 0x65D163C VA: 0x65D563C
	private bool CheckIsSpecialMonster(int monsterType) { }

	// RVA: 0x65D5990 Offset: 0x65D1990 VA: 0x65D5990 Slot: 82
	public override bool IsWaveLastMission() { }

	// RVA: 0x65D5AA0 Offset: 0x65D1AA0 VA: 0x65D5AA0 Slot: 83
	public override bool IsWaveShowStartUIMission() { }

	// RVA: 0x65D5BB0 Offset: 0x65D1BB0 VA: 0x65D5BB0
	private void InitSpecialUIArr(bool isStartUI) { }

	// RVA: 0x65D5CE0 Offset: 0x65D1CE0 VA: 0x65D5CE0 Slot: 84
	public override bool CheckWaveShowStartUI() { }

	// RVA: 0x65D5E38 Offset: 0x65D1E38 VA: 0x65D5E38 Slot: 85
	public override bool CheckWaveShowEndUI() { }

	// RVA: 0x65D5F90 Offset: 0x65D1F90 VA: 0x65D5F90 Slot: 86
	public override int WaveShowStartUIHandle() { }

	// RVA: 0x65D6148 Offset: 0x65D2148 VA: 0x65D6148 Slot: 87
	public override void WaveEndHandle() { }

	// RVA: 0x65D61AC Offset: 0x65D21AC VA: 0x65D61AC Slot: 69
	public override int[] GetCurMissionMultHp(int missionId) { }

	// RVA: 0x65D63B4 Offset: 0x65D23B4 VA: 0x65D63B4
	public bool CheckShowExpAnim() { }

	// RVA: 0x65D64F8 Offset: 0x65D24F8 VA: 0x65D64F8
	public bool WaveModelLevelUp() { }

	// RVA: 0x65D6588 Offset: 0x65D2588 VA: 0x65D6588 Slot: 32
	public override BattleDropItemData GetCharacterDropGold(EntityCharacterData characterData) { }

	// RVA: 0x65D163C Offset: 0x65CD63C VA: 0x65D163C
	private List<int> ShuffleWithFisherYates(int goldMonsterCount, int takeCount) { }

	// RVA: 0x65D6AF0 Offset: 0x65D2AF0 VA: 0x65D6AF0 Slot: 70
	public override int GetCurWave() { }

	// RVA: 0x65D6BC8 Offset: 0x65D2BC8 VA: 0x65D6BC8
	public void .ctor() { }
}

