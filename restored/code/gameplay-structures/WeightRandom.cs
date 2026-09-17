// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class WeightRandom : PooledWorldElement // TypeDefIndex: 10758
{
	// Fields
	private bool showLog; // 0x28
	private const int DefaultSize = 50;
	private int _allWeight; // 0x2C
	private int _count; // 0x30
	private int _size; // 0x34
	private int _needFlag; // 0x38
	private WeightRandomData[] _allData; // 0x40

	// Properties
	public int AllWeight { get; }

	// Methods

	// RVA: 0x6632760 Offset: 0x662E760 VA: 0x6632760
	public int get_AllWeight() { }

	// RVA: 0x66327C4 Offset: 0x662E7C4 VA: 0x66327C4
	public void UpdateWeightPercent(int[] skillIds, FP value) { }

	// RVA: 0x6632A18 Offset: 0x662EA18 VA: 0x6632A18
	public string GetInfo() { }

	// RVA: 0x6632BD0 Offset: 0x662EBD0 VA: 0x6632BD0
	public int GetCount(List<int> resultList) { }

	// RVA: 0x6632CE4 Offset: 0x662ECE4 VA: 0x6632CE4
	public int RemoveRandom(int id, bool realRemove = False) { }

	// RVA: 0x6632E88 Offset: 0x662EE88 VA: 0x6632E88
	public void Add(int id, int weight, int needFlag, int[] skillFlag, int[] needSkills, List<int> learnedSkills) { }

	// RVA: 0x66332B0 Offset: 0x662F2B0 VA: 0x66332B0
	public void OnAddRejectFlag(int rejectFlag) { }

	// RVA: 0x66333AC Offset: 0x662F3AC VA: 0x66333AC
	public void OnAddRejectSkills(int[] rejectSkills) { }

	// RVA: 0x66334D8 Offset: 0x662F4D8 VA: 0x66334D8
	public void OnAddFlag(int flag) { }

	// RVA: 0x66335E8 Offset: 0x662F5E8 VA: 0x66335E8
	public void OnCheckNeedSkills(int addSkill) { }

	// RVA: 0x66336DC Offset: 0x662F6DC VA: 0x66336DC
	public void OnRemoveFlag(int flag) { }

	// RVA: 0x6633750 Offset: 0x662F750 VA: 0x6633750
	public void RecalculateAllWeight() { }

	// RVA: 0x6633824 Offset: 0x662F824 VA: 0x6633824
	public int BoostWeightByPercent(int id, int percent) { }

	// RVA: 0x6633908 Offset: 0x662F908 VA: 0x6633908
	public void RevertWeightBoost(int id, int increment) { }

	// RVA: 0x66339E8 Offset: 0x662F9E8 VA: 0x66339E8
	public int GetRandom() { }

	// RVA: 0x6633C0C Offset: 0x662FC0C VA: 0x6633C0C
	public void GetRandomCount(int count, List<int> resultList, List<int> allSkills, List<int> banSkills) { }

	// RVA: 0x6634F18 Offset: 0x6630F18 VA: 0x6634F18
	public int GetAlreadyStudySkill(WeightRandom resule) { }

	// RVA: 0x6635318 Offset: 0x6631318 VA: 0x6635318
	public int GetReadyStudySkill(WeightRandom resule) { }

	// RVA: 0x6635690 Offset: 0x6631690 VA: 0x6635690
	public int GetOneStarSkill(WeightRandom resule) { }

	// RVA: 0x6635A1C Offset: 0x6631A1C VA: 0x6635A1C
	public void CopyWeightRandom(WeightRandom resule) { }

	// RVA: 0x6635C50 Offset: 0x6631C50 VA: 0x6635C50
	public void CopyWeightRandomFull(WeightRandom resule) { }

	// RVA: 0x6635E90 Offset: 0x6631E90 VA: 0x6635E90
	public void RestoreMissing(WeightRandom source) { }

	// RVA: 0x66346A0 Offset: 0x66306A0 VA: 0x66346A0
	protected void RandomOneSubSkillByParent(int parendId, List<int> resultList, List<int> allSkills, List<int> banSkills) { }

	// RVA: 0x66360D4 Offset: 0x66320D4 VA: 0x66360D4 Slot: 8
	protected override void OnRelease() { }

	// RVA: 0x66352B0 Offset: 0x66312B0 VA: 0x66352B0
	public void Clear() { }

	// RVA: 0x66331E4 Offset: 0x662F1E4 VA: 0x66331E4
	private bool Exist(int id) { }

	// RVA: 0x6636154 Offset: 0x6632154 VA: 0x6636154
	public void LogAllId() { }

	// RVA: 0x66345B4 Offset: 0x66305B4 VA: 0x66345B4
	private void LogError(string logContent) { }

	// RVA: 0x66362B8 Offset: 0x66322B8 VA: 0x66362B8
	public void InitAllSkillWeight(List<int> result, List<int> allSkills) { }

	// RVA: 0x66365C8 Offset: 0x66325C8 VA: 0x66365C8
	public void .ctor() { }
}

