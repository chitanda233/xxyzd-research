// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class WaterfallMultiBattleManager : BaseSurvivalMultiBattleManager // TypeDefIndex: 10595
{
	// Fields
	private FP m_FightTime; // 0x118
	private int m_LastFightTime; // 0x120
	private int m_MaxFightTime; // 0x124
	private bool m_IsZero; // 0x128
	private FP m_InitBattleMissionTime; // 0x130
	public int m_PunchboardMissCount; // 0x138
	private int _curShowWaveIndex; // 0x13C
	private int _curWave; // 0x140
	private int _curWaveFirstMissionId; // 0x144
	private int _curWaveLastMissionId; // 0x148
	private int _curWaveShowStartUIMissionId; // 0x14C
	private ChapterWave_Waves _curWaveSections; // 0x150
	private int _remainSpecialMonsterCount; // 0x158
	private int _remainAllMonsterCount; // 0x15C
	private int _expCount; // 0x160
	private int _perExp; // 0x164
	private int _addExp; // 0x168
	private bool _needUploadBattleData; // 0x16C
	private int _punchboardWaveIndex; // 0x170
	private MissionMulti_MultiWaterfallMission _curMissionData; // 0x178
	private List<BeeMonsterCreator> _beeMonsterCreators; // 0x180
	private int _showUIIndex; // 0x188
	private bool _isInMissileBoostDuration; // 0x18C
	private bool _executeBoostStart; // 0x18D
	private bool _executeBoostEnd; // 0x18E
	private int _missileBoostCount; // 0x190
	private FP _missileBoostDuration; // 0x198
	private int _missileBoostEntityId; // 0x1A0
	private FP _waveElapsedTime; // 0x1A8
	private int _needUpLevelCount; // 0x1B0
	private bool isInUplevelAbsorbAll; // 0x1B4
	private FP delayOpenLevelUpTime; // 0x1B8
	private FP curOpenLevelUpTime; // 0x1C0
	private int[] _curDoSpecialUIs; // 0x1C8
	private readonly List<WaterfallMultiBattleManager.IWaveUpdateListener> _waveUpdateListeners; // 0x1D0
	private int _randomSkillShowCount; // 0x1D8

	// Properties
	public ChapterMulti_MultiPlayer ChapterInfo { get; }
	public int CurShowWaveIndex { get; set; }
	public override int BattleChapterType { get; }
	public bool IsInMissileBoostDuration { get; }
	public FP WaveElapsedTime { get; }
	public override bool PauseWhenSelectSkill { get; }
	internal override int RandomSkillShowCount { get; }

	// Methods

	// RVA: 0x65D6DB8 Offset: 0x65D2DB8 VA: 0x65D6DB8
	public ChapterMulti_MultiPlayer get_ChapterInfo() { }

	// RVA: 0x65D6EB8 Offset: 0x65D2EB8 VA: 0x65D6EB8
	public int get_CurShowWaveIndex() { }

	// RVA: 0x65D6F1C Offset: 0x65D2F1C VA: 0x65D6F1C
	public void set_CurShowWaveIndex(int value) { }

	// RVA: 0x65D6FA8 Offset: 0x65D2FA8 VA: 0x65D6FA8 Slot: 6
	public override int get_BattleChapterType() { }

	// RVA: 0x65D700C Offset: 0x65D300C VA: 0x65D700C
	public bool get_IsInMissileBoostDuration() { }

	// RVA: 0x65D7070 Offset: 0x65D3070 VA: 0x65D7070
	public FP get_WaveElapsedTime() { }

	// RVA: 0x65D70D4 Offset: 0x65D30D4 VA: 0x65D70D4 Slot: 7
	public override bool get_PauseWhenSelectSkill() { }

	// RVA: 0x65D7138 Offset: 0x65D3138 VA: 0x65D7138 Slot: 9
	internal override int get_RandomSkillShowCount() { }

	// RVA: 0x65D719C Offset: 0x65D319C VA: 0x65D719C
	public void RegisterWaveUpdateListener(WaterfallMultiBattleManager.IWaveUpdateListener listener) { }

	// RVA: 0x65D72CC Offset: 0x65D32CC VA: 0x65D72CC
	public void UnregisterWaveUpdateListener(WaterfallMultiBattleManager.IWaveUpdateListener listener) { }

	// RVA: 0x65D7368 Offset: 0x65D3368 VA: 0x65D7368 Slot: 50
	protected override void OnInit() { }

	// RVA: 0x65D7A30 Offset: 0x65D3A30 VA: 0x65D7A30 Slot: 15
	public override void SetPlayerLevelAndExp(int playerId, int level, int exp) { }

	// RVA: 0x65D7AC0 Offset: 0x65D3AC0 VA: 0x65D7AC0
	public void AddUpLevel() { }

	// RVA: 0x65D7B2C Offset: 0x65D3B2C VA: 0x65D7B2C
	public void DelUpLevel() { }

	// RVA: 0x65D7B98 Offset: 0x65D3B98 VA: 0x65D7B98 Slot: 71
	public override void OnStart() { }

	// RVA: 0x65D7DE8 Offset: 0x65D3DE8 VA: 0x65D7DE8 Slot: 23
	public override void OnPlayerDie(int playerId) { }

	// RVA: 0x65D7EB4 Offset: 0x65D3EB4 VA: 0x65D7EB4 Slot: 18
	public override void OnBattleEnd(int winPlayerId) { }

	// RVA: 0x65D7F50 Offset: 0x65D3F50 VA: 0x65D7F50 Slot: 68
	public override void UploadBattleData() { }

	// RVA: 0x65D7FB0 Offset: 0x65D3FB0 VA: 0x65D7FB0 Slot: 13
	internal override void AddExpAndGold() { }

	// RVA: 0x65D839C Offset: 0x65D439C VA: 0x65D839C Slot: 56
	public override void RefreshBattleData() { }

	// RVA: 0x65D96A8 Offset: 0x65D56A8 VA: 0x65D96A8 Slot: 44
	protected override int GetMissionType(int missionId) { }

	// RVA: 0x65D981C Offset: 0x65D581C VA: 0x65D981C Slot: 12
	internal override void OnMissionIncrease() { }

	// RVA: 0x65D9A74 Offset: 0x65D5A74 VA: 0x65D9A74 Slot: 21
	public override void OnProgressFinish() { }

	// RVA: 0x65D988C Offset: 0x65D588C VA: 0x65D988C
	private void tryClearBeeMonsterCreators() { }

	// RVA: 0x65D9FD4 Offset: 0x65D5FD4 VA: 0x65D9FD4 Slot: 46
	public override void RefreshMonsters() { }

	// RVA: 0x65DAA04 Offset: 0x65D6A04 VA: 0x65DAA04
	private void tryStartMissileBoostOnWaveStart() { }

	// RVA: 0x65DABF4 Offset: 0x65D6BF4 VA: 0x65DABF4
	public void HeroMissileBoostStart() { }

	// RVA: 0x65DA838 Offset: 0x65D6838 VA: 0x65DA838
	private void CreateIntervalMonster() { }

	// RVA: 0x65DAF70 Offset: 0x65D6F70 VA: 0x65DAF70
	private void CreateTileMonster(FP intervalDelay) { }

	// RVA: 0x65D8C80 Offset: 0x65D4C80 VA: 0x65D8C80
	private void InitNewWaveData() { }

	// RVA: 0x65DD220 Offset: 0x65D9220 VA: 0x65DD220
	private void CalSpecialMonsterCount(MissionMulti_MultiWaterfallMission calMissionData) { }

	// RVA: 0x65DDB54 Offset: 0x65D9B54 VA: 0x65DDB54
	private CalMonsterCountData CalPositionGroupSpecialMonsterCount(MissionMulti_MultiWaterfallMission calMissionData) { }

	// RVA: 0x65DD3A8 Offset: 0x65D93A8 VA: 0x65DD3A8
	private CalMonsterCountData CalTileSpecialMonsterCount(MissionMulti_MultiWaterfallMission calMissionData) { }

	// RVA: 0x65DD160 Offset: 0x65D9160 VA: 0x65DD160
	private bool CheckStopByEliteOrBossKilled() { }

	// RVA: 0x65DBAB8 Offset: 0x65D7AB8 VA: 0x65DBAB8
	private void CreateTileGroupMonster(FP intervalDelay) { }

	// RVA: 0x65DC7A4 Offset: 0x65D87A4 VA: 0x65DC7A4
	private void CreateRandomMonster(FP intervalDelay) { }

	// RVA: 0x65DE464 Offset: 0x65DA464 VA: 0x65DE464
	private FPVector3 RandomPos(FP width, int height, MapManager mapMgr, int curIndex) { }

	// RVA: 0x65DE674 Offset: 0x65DA674 VA: 0x65DE674
	private bool CheckPosValid(int index, FPVector3 randomPos) { }

	// RVA: 0x65DA558 Offset: 0x65D6558 VA: 0x65DA558
	private void CreateBeeMonsterCreator() { }

	// RVA: 0x65DE7D8 Offset: 0x65DA7D8 VA: 0x65DE7D8
	private void onSetFlushId(int flushId) { }

	// RVA: 0x65DEA14 Offset: 0x65DAA14 VA: 0x65DEA14 Slot: 77
	protected override bool CheckContractDevil() { }

	// RVA: 0x65DEB98 Offset: 0x65DAB98 VA: 0x65DEB98 Slot: 79
	public override void TrackerWaveEvent(bool isEnd = False) { }

	// RVA: 0x65DEC0C Offset: 0x65DAC0C VA: 0x65DEC0C Slot: 52
	protected override void OnUpdateHook(FP deltaTime) { }

	// RVA: 0x65DF2FC Offset: 0x65DB2FC VA: 0x65DF2FC Slot: 73
	protected override bool CheckIsPauseState() { }

	// RVA: 0x65DF364 Offset: 0x65DB364 VA: 0x65DF364
	private bool CheckNeedPause(bool isEnter) { }

	// RVA: 0x65D9390 Offset: 0x65D5390 VA: 0x65D9390
	private void UpdateFightTime() { }

	// RVA: 0x65DF468 Offset: 0x65DB468 VA: 0x65DF468 Slot: 63
	public override int GetBattleShowWave() { }

	// RVA: 0x65DF500 Offset: 0x65DB500 VA: 0x65DF500 Slot: 37
	protected override bool IsDropClear() { }

	// RVA: 0x65DF7BC Offset: 0x65DB7BC VA: 0x65DF7BC Slot: 36
	internal override bool CanTriggerSkill() { }

	// RVA: 0x65DA430 Offset: 0x65D6430 VA: 0x65DA430
	private void CreatePunchboardNpc() { }

	// RVA: 0x65DF8A0 Offset: 0x65DB8A0 VA: 0x65DF8A0 Slot: 75
	public override void EnemyDieSpecialLogic(EntityCharacter entityMonster) { }

	// RVA: 0x65DFB58 Offset: 0x65DBB58 VA: 0x65DFB58 Slot: 31
	public override FP GetCharacterDropExp(EntityCharacterData characterData, Item_battle tableData, FP deltaExpPercent) { }

	// RVA: 0x65DFBEC Offset: 0x65DBBEC VA: 0x65DFBEC Slot: 29
	public override int GetCharacterDropCoinCount(EntityCharacterData characterData) { }

	// RVA: 0x65DFD08 Offset: 0x65DBD08 VA: 0x65DFD08 Slot: 30
	public override int GetCharacterDropExpCount(EntityCharacterData characterData) { }

	// RVA: 0x65DFD80 Offset: 0x65DBD80 VA: 0x65DFD80
	private bool CheckIsSpecialMonster(int monsterType) { }

	// RVA: 0x65DFE08 Offset: 0x65DBE08 VA: 0x65DFE08 Slot: 81
	public override bool IsWaveLastMission() { }

	// RVA: 0x65DFF18 Offset: 0x65DBF18 VA: 0x65DFF18 Slot: 82
	public override bool IsWaveShowStartUIMission() { }

	// RVA: 0x65E0028 Offset: 0x65DC028 VA: 0x65E0028
	private void InitSpecialUIArr(bool isStartUI) { }

	// RVA: 0x65E0154 Offset: 0x65DC154 VA: 0x65E0154 Slot: 83
	public override bool CheckWaveShowStartUI() { }

	// RVA: 0x65E01B8 Offset: 0x65DC1B8 VA: 0x65E01B8 Slot: 84
	public override bool CheckWaveShowEndUI() { }

	// RVA: 0x65E02F8 Offset: 0x65DC2F8 VA: 0x65E02F8 Slot: 85
	public override int WaveShowStartUIHandle() { }

	// RVA: 0x65E0488 Offset: 0x65DC488 VA: 0x65E0488 Slot: 86
	public override void WaveEndHandle() { }

	// RVA: 0x65E059C Offset: 0x65DC59C VA: 0x65E059C Slot: 69
	public override int[] GetCurMissionMultHp(int missionId) { }

	// RVA: 0x65E0720 Offset: 0x65DC720 VA: 0x65E0720
	public void .ctor() { }
}

