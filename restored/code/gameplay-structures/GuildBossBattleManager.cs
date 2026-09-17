// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class GuildBossBattleManager : WaterfallBattleManager // TypeDefIndex: 10565
{
	// Fields
	private int _fightTime; // 0x214
	private bool _hasFinalDamage; // 0x218
	private long _finalDamage; // 0x220

	// Properties
	public override int BattleChapterType { get; }

	// Methods

	// RVA: 0x65BBBA4 Offset: 0x65B7BA4 VA: 0x65BBBA4 Slot: 6
	public override int get_BattleChapterType() { }

	// RVA: 0x65BBC08 Offset: 0x65B7C08 VA: 0x65BBC08
	public void SetFightTime(int fightTime) { }

	// RVA: 0x65BBC80 Offset: 0x65B7C80 VA: 0x65BBC80
	public int GetFightTime() { }

	// RVA: 0x65A9FF0 Offset: 0x65A5FF0 VA: 0x65A9FF0
	public void SetFinalDamage(long damage) { }

	// RVA: 0x65BBCE4 Offset: 0x65B7CE4 VA: 0x65BBCE4
	public long GetFinalDamage() { }

	// RVA: 0x65BBDA8 Offset: 0x65B7DA8 VA: 0x65BBDA8 Slot: 62
	public override int GetBattleWave() { }

	// RVA: 0x65BBE0C Offset: 0x65B7E0C VA: 0x65BBE0C Slot: 21
	public override void OnProgressFinish() { }

	// RVA: 0x65BBF18 Offset: 0x65B7F18 VA: 0x65BBF18 Slot: 52
	protected override void OnUpdateHook(FP deltaTime) { }

	// RVA: 0x65BC08C Offset: 0x65B808C VA: 0x65BC08C Slot: 36
	internal override bool CanTriggerSkill() { }

	// RVA: 0x65BC1E8 Offset: 0x65B81E8 VA: 0x65BC1E8 Slot: 50
	protected override void OnInit() { }

	// RVA: 0x65BCB10 Offset: 0x65B8B10 VA: 0x65BCB10
	public void .ctor() { }
}

