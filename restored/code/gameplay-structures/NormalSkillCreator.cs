// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class NormalSkillCreator : SinglePlayerSkillCreator // TypeDefIndex: 11807
{
	// Fields
	private WeightRandom[] _angelRandom; // 0x78
	private WeightRandom[] _initBoxRandoms; // 0x80
	private readonly WeightRandom[] _devilRandoms; // 0x88

	// Properties
	protected virtual bool UseInitBox { get; }

	// Methods

	// RVA: 0x6872CFC Offset: 0x686ECFC VA: 0x6872CFC Slot: 27
	protected virtual bool get_UseInitBox() { }

	// RVA: 0x6872D70 Offset: 0x686ED70 VA: 0x6872D70 Slot: 19
	public override void GetBoxRandomSkills(ref BoxSkillResult boxSkillResult, int[] skillWeights, bool qualityUp) { }

	// RVA: 0x68730F0 Offset: 0x686F0F0 VA: 0x68730F0
	public int AngelRandomSkillQuality() { }

	// RVA: 0x6873358 Offset: 0x686F358 VA: 0x6873358 Slot: 20
	public override void GetRandomAngleSkills(List<int> result, List<int> curAllSkills, int count) { }

	// RVA: 0x68735FC Offset: 0x686F5FC VA: 0x68735FC Slot: 21
	public override int RandomAngelSkill() { }

	// RVA: 0x6860EA0 Offset: 0x685CEA0 VA: 0x6860EA0 Slot: 22
	public override void AddSkillChangeRandomPool(int skillId, List<int> allSkills) { }

	// RVA: 0x6873690 Offset: 0x686F690 VA: 0x6873690 Slot: 23
	public override bool OpenSelectSpecialSkill(List<int> result, List<int> allSkills, out int specialParentSkillId) { }

	// RVA: 0x6873728 Offset: 0x686F728 VA: 0x6873728 Slot: 24
	public override bool CheckNeedOpenSpecialSkill() { }

	// RVA: 0x687378C Offset: 0x686F78C VA: 0x687378C Slot: 25
	public override Dictionary<int, int> GetRandomPunchboardSkills(List<int> haveSkillResult, List<int> newSkillResult, List<int> replenishSkillResult, int count, int[] skillWeights, bool qualityUp, bool isRefresh, List<int> curAllSkills) { }

	// RVA: 0x6873E44 Offset: 0x686FE44 VA: 0x6873E44 Slot: 6
	public override int RandomDevilSkill(ref int randomIndex, bool qualityUp) { }

	// RVA: 0x685CECC Offset: 0x6858ECC VA: 0x685CECC Slot: 12
	protected override void OnCreateRandoms() { }

	// RVA: 0x68743A4 Offset: 0x68703A4 VA: 0x68743A4 Slot: 14
	protected override void OnRemoveRandomSkill(int skillId) { }

	// RVA: 0x6874638 Offset: 0x6870638 VA: 0x6874638 Slot: 11
	protected override void OnDeInit() { }

	// RVA: 0x6874740 Offset: 0x6870740 VA: 0x6874740 Slot: 7
	protected override void OnAddSkillFlag(int flag) { }

	// RVA: 0x6874984 Offset: 0x6870984 VA: 0x6874984 Slot: 8
	protected override void OnAddRejectFlag(int rejectFlag) { }

	// RVA: 0x6865D44 Offset: 0x6861D44 VA: 0x6865D44 Slot: 9
	protected override void OnCheckNeedSkills(int addSkill) { }

	// RVA: 0x6874CF4 Offset: 0x6870CF4 VA: 0x6874CF4 Slot: 10
	protected override void OnAddRejectSkills(int[] rejectSkills) { }

	// RVA: 0x68741FC Offset: 0x68701FC VA: 0x68741FC
	protected void CreateAngelRandoms() { }

	// RVA: 0x6874F38 Offset: 0x6870F38 VA: 0x6874F38 Slot: 26
	protected override void OnInitRandomSkill(int chapterType, int[] bindSkills) { }

	// RVA: 0x6866460 Offset: 0x6862460 VA: 0x6866460
	public void .ctor() { }
}

