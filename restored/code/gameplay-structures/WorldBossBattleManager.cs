// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class WorldBossBattleManager : WaterfallBattleManager // TypeDefIndex: 10596
{
	// Fields
	private int _fightTime; // 0x214

	// Properties
	public override int BattleChapterType { get; }

	// Methods

	// RVA: 0x65E0864 Offset: 0x65DC864 VA: 0x65E0864 Slot: 6
	public override int get_BattleChapterType() { }

	// RVA: 0x65E08C8 Offset: 0x65DC8C8 VA: 0x65E08C8 Slot: 50
	protected override void OnInit() { }

	// RVA: 0x65E1214 Offset: 0x65DD214 VA: 0x65E1214
	public void SetFightTime(int fightTime) { }

	// RVA: 0x65E128C Offset: 0x65DD28C VA: 0x65E128C
	public int GetFightTime() { }

	// RVA: 0x65E12F0 Offset: 0x65DD2F0 VA: 0x65E12F0 Slot: 62
	public override int GetBattleWave() { }

	// RVA: 0x65E1354 Offset: 0x65DD354 VA: 0x65E1354
	public void .ctor() { }
}

