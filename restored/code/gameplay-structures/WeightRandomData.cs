// Namespace: HotFix.BattleLogic
internal struct WeightRandomData // TypeDefIndex: 10755
{
	// Fields
	public int Id; // 0x0
	private int _weight; // 0x4
	private int _originalWeight; // 0x8
	private int _needFlag; // 0xC
	private int[] _skillFlags; // 0x10
	private FP _deltaWeightPercent; // 0x18
	private bool _isRejectRemove; // 0x20
	private bool _isRejectSkillRemove; // 0x21
	private List<int> _needSkills; // 0x28
	public bool _isSmallUpgradeSkillEmpty; // 0x30

	// Methods

	// RVA: 0x6631D14 Offset: 0x662DD14 VA: 0x6631D14
	public int GetNeedFlags() { }

	// RVA: 0x6631D78 Offset: 0x662DD78 VA: 0x6631D78
	public int[] GetSkillFlags() { }

	// RVA: 0x6631DDC Offset: 0x662DDDC VA: 0x6631DDC
	public List<int> GetNeedSkills() { }

	// RVA: 0x6631E40 Offset: 0x662DE40 VA: 0x6631E40
	public void Clear() { }

	// RVA: 0x6631EE4 Offset: 0x662DEE4 VA: 0x6631EE4
	public void Init(int id, int weight, int needFlag, int[] skillFlags, int[] needSkills) { }

	// RVA: 0x663206C Offset: 0x662E06C VA: 0x663206C
	public int Weight() { }

	// RVA: 0x6632120 Offset: 0x662E120 VA: 0x6632120
	public int PracticalWeight() { }

	// RVA: 0x6632194 Offset: 0x662E194 VA: 0x6632194
	public void UpdateDeltaWeightPercent(FP value) { }

	// RVA: 0x663220C Offset: 0x662E20C VA: 0x663220C
	public bool AddRejectFlag(int rejectFlag) { }

	// RVA: 0x66322DC Offset: 0x662E2DC VA: 0x66322DC
	public bool TryAddFlag(int flag) { }

	// RVA: 0x663236C Offset: 0x662E36C VA: 0x663236C
	public bool AddRejectSkill() { }

	// RVA: 0x66323E4 Offset: 0x662E3E4 VA: 0x66323E4
	public int BoostWeight(int percent) { }

	// RVA: 0x6632490 Offset: 0x662E490 VA: 0x6632490
	public void RevertWeightBoost(int increment) { }

	// RVA: 0x6632510 Offset: 0x662E510 VA: 0x6632510
	public bool AddNeedSkill(int addSkill) { }

	// RVA: 0x6632604 Offset: 0x662E604 VA: 0x6632604
	public void CopyFrom(ref WeightRandomData other) { }
}
