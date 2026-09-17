// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class BeeMonsterRefresher : PooledWorldElement // TypeDefIndex: 10563
{
	// Fields
	private int _characterId; // 0x28
	private FP _bornDeltaTime; // 0x30
	private FPVector3 _bornPos; // 0x38
	private int _bornCount; // 0x50
	private int _curveId; // 0x54
	private int _missionId; // 0x58
	private BaseSurvivalBattleManager _battleManager; // 0x60
	private int _hasBornCount; // 0x68
	private FP _lastRefreshTime; // 0x70

	// Methods

	// RVA: 0x65BAB4C Offset: 0x65B6B4C VA: 0x65BAB4C
	public void SetData(int characterId, FP bornDeltaTime, FPVector3 bornPos, int bornCount, int missionId) { }

	// RVA: 0x65BAC44 Offset: 0x65B6C44 VA: 0x65BAC44
	public bool Update(FP deltaTime) { }

	// RVA: 0x65BB380 Offset: 0x65B7380 VA: 0x65BB380
	public void .ctor() { }
}

