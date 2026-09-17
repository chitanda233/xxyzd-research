// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal abstract class SinglePlayerSkillCreator : HeroSkillCreator // TypeDefIndex: 11809
{
	// Fields
	protected int _initSkillGroupCount; // 0x64
	private List<int> _tempList; // 0x68
	protected readonly List<NewPlayerBoostRecord> _newPlayerBoostRecords; // 0x70

	// Methods

	// RVA: 0x6875450 Offset: 0x6871450 VA: 0x6875450 Slot: 16
	public override bool GetNormalSkill(List<int> result, bool isRefresh, int[] skillWeights, bool qualityUp, List<int> curAllSkills, ref int star, int[] randomSkillFactor) { }

	// RVA: 0x6875AAC Offset: 0x6871AAC VA: 0x6875AAC Slot: 4
	protected override void OnInitRandoms() { }

	// RVA: 0x68740D8 Offset: 0x68700D8 VA: 0x68740D8 Slot: 12
	protected override void OnCreateRandoms() { }

	// RVA: 0x6875BFC Offset: 0x6871BFC VA: 0x6875BFC Slot: 13
	protected override void OnInitRandomSkill(int[] bindSkills) { }

	// RVA: 0x68744C4 Offset: 0x68704C4 VA: 0x68744C4 Slot: 14
	protected override void OnRemoveRandomSkill(int skillId) { }

	// RVA: 0x68746CC Offset: 0x68706CC VA: 0x68746CC Slot: 11
	protected override void OnDeInit() { }

	// RVA: 0x6874878 Offset: 0x6870878 VA: 0x6874878 Slot: 7
	protected override void OnAddSkillFlag(int flag) { }

	// RVA: 0x6874ABC Offset: 0x6870ABC VA: 0x6874ABC Slot: 8
	protected override void OnAddRejectFlag(int rejectFlag) { }

	// RVA: 0x6874BC8 Offset: 0x6870BC8 VA: 0x6874BC8 Slot: 9
	protected override void OnCheckNeedSkills(int addSkill) { }

	// RVA: 0x6874E2C Offset: 0x6870E2C VA: 0x6874E2C Slot: 10
	protected override void OnAddRejectSkills(int[] rejectSkills) { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void OnInitRandomSkill(int chapterType, int[] bindSkills);

	// RVA: 0x6875D08 Offset: 0x6871D08 VA: 0x6875D08
	private void InitRandoms(int chapterType, int[] bindSkills) { }

	// RVA: 0x68606EC Offset: 0x685C6EC VA: 0x68606EC
	public void GetInginiteSkill(List<int> result, List<int> curAllSkills, int count) { }

	// RVA: 0x685CB68 Offset: 0x6858B68 VA: 0x685CB68
	protected void .ctor() { }
}

