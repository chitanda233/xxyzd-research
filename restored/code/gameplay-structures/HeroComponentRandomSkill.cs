// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class HeroComponentRandomSkill : HeroComponentBase // TypeDefIndex: 11805
{
	// Fields
	private readonly Dictionary<int, int> _replaceSkillDic; // 0x40
	private readonly OrderedDictionary<int, HeroSkillCount> _skills; // 0x48
	private readonly OrderedHashSet<int> _allBattleSkills; // 0x50
	private List<int> _allSkills; // 0x58
	private BoxSkillResult _boxSkillResult; // 0x60
	private readonly RandomSkillResult _randomSkillResult; // 0x80
	private HeroSkillCreator _skillCreator; // 0x88
	public bool isInSpecialSkill; // 0x90
	[CompilerGenerated]
	private Skill_Main <MaxStarSkill>k__BackingField; // 0x98
	private readonly List<int> _skillList; // 0xA0
	private readonly int[] _skillWeights; // 0xA8
	private readonly int[] _dankeSkillWeights; // 0xB0
	private OrderedDictionary<int, OrderedHashSet<int>> _skillGroupsByType; // 0xB8
	private OrderedDictionary<int, int> _learnedSkillCountsByType; // 0xC0
	public static string dynamicWeightLOG; // 0x0

	// Properties
	public Dictionary<int, int> ReplaceSkillDic { get; }
	public RandomSkillResult RandomSkillResult { get; }
	public HeroSkillCreator SkillCreator { get; }
	public BoxSkillResult BoxSkillResult { get; }
	public List<int> AllSkills { get; }
	public Skill_Main MaxStarSkill { get; set; }

	// Methods

	// RVA: 0x6867E70 Offset: 0x6863E70 VA: 0x6867E70
	public Dictionary<int, int> get_ReplaceSkillDic() { }

	// RVA: 0x6867ED4 Offset: 0x6863ED4 VA: 0x6867ED4
	public RandomSkillResult get_RandomSkillResult() { }

	// RVA: 0x6867F38 Offset: 0x6863F38 VA: 0x6867F38
	public HeroSkillCreator get_SkillCreator() { }

	// RVA: 0x6867F9C Offset: 0x6863F9C VA: 0x6867F9C
	public ref BoxSkillResult get_BoxSkillResult() { }

	// RVA: 0x6868000 Offset: 0x6864000 VA: 0x6868000
	public List<int> get_AllSkills() { }

	[CompilerGenerated]
	// RVA: 0x6868064 Offset: 0x6864064 VA: 0x6868064
	public Skill_Main get_MaxStarSkill() { }

	[CompilerGenerated]
	// RVA: 0x68680C8 Offset: 0x68640C8 VA: 0x68680C8
	private void set_MaxStarSkill(Skill_Main value) { }

	// RVA: 0x6868148 Offset: 0x6864148 VA: 0x6868148
	public int GetBoxSkillByIndex(int index) { }

	// RVA: 0x68681CC Offset: 0x68641CC VA: 0x68681CC
	public void AddReplaceSkill(int skillId, int replaceSkillId) { }

	// RVA: 0x6868274 Offset: 0x6864274 VA: 0x6868274
	private void OnAddSkill(int id) { }

	// RVA: 0x686872C Offset: 0x686472C VA: 0x686872C
	private void OnRemoveSkill(int id) { }

	// RVA: 0x6869018 Offset: 0x6865018 VA: 0x6869018
	public void AddSkill(int id) { }

	// RVA: 0x6869104 Offset: 0x6865104 VA: 0x6869104
	public void AddSkillSurvior(int id) { }

	// RVA: 0x68691F0 Offset: 0x68651F0 VA: 0x68691F0
	public void RemoveSkillInSTG(int id) { }

	// RVA: 0x6869298 Offset: 0x6865298 VA: 0x6869298
	public void RemoveSkillInSurvior(int id) { }

	// RVA: 0x6869340 Offset: 0x6865340 VA: 0x6869340
	public bool HasSkill(int id) { }

	// RVA: 0x68693DC Offset: 0x68653DC VA: 0x68693DC
	public void RemoveSkillInSurvior(Skill_Main skillData) { }

	// RVA: 0x6869554 Offset: 0x6865554 VA: 0x6869554
	public void RemoveSkillInSTG(Skill_Main skillData) { }

	// RVA: 0x686A2AC Offset: 0x68662AC VA: 0x686A2AC
	public void AddSkillSurvior(Skill_Main skillData) { }

	// RVA: 0x686A53C Offset: 0x686653C VA: 0x686A53C
	public void AddSkill(Skill_Main skillData) { }

	// RVA: 0x686B2F8 Offset: 0x68672F8 VA: 0x686B2F8
	public void TryRemoveSkill(int id) { }

	// RVA: 0x686B5A0 Offset: 0x68675A0 VA: 0x686B5A0
	private void RemoveSkill(int id) { }

	// RVA: 0x686B3F4 Offset: 0x68673F4 VA: 0x686B3F4
	private void RemoveAllSkill() { }

	// RVA: 0x686AFF8 Offset: 0x6866FF8 VA: 0x686AFF8
	internal void AddSkillFlags(int[] flags) { }

	// RVA: 0x686B0B8 Offset: 0x68670B8 VA: 0x686B0B8
	internal void AddSkillRejectFlags(int rejectFlag) { }

	// RVA: 0x686B1C0 Offset: 0x68671C0 VA: 0x686B1C0
	internal void AddRejectSkills(int[] rejectSkills) { }

	// RVA: 0x686B13C Offset: 0x686713C VA: 0x686B13C
	internal void AddNeedSkill(int addSkill) { }

	// RVA: 0x6869E18 Offset: 0x6865E18 VA: 0x6869E18
	private void RemoveRandomSkill(int skillId) { }

	// RVA: 0x686BAC4 Offset: 0x6867AC4 VA: 0x686BAC4 Slot: 11
	public override void Init() { }

	// RVA: 0x686BC80 Offset: 0x6867C80 VA: 0x686BC80
	public void InitRandomSkill(int[] bindSkills, EntityHero player) { }

	// RVA: 0x686C6B4 Offset: 0x68686B4 VA: 0x686C6B4 Slot: 12
	public override void DeInit() { }

	// RVA: 0x686C834 Offset: 0x6868834 VA: 0x686C834 Slot: 14
	public override void OnUpdate(FP deltaTime) { }

	// RVA: 0x686C8A8 Offset: 0x68688A8 VA: 0x686C8A8 Slot: 15
	public override void OnLateUpdate(FP deltaTime) { }

	// RVA: 0x686C91C Offset: 0x686891C VA: 0x686C91C Slot: 16
	public override void OnEvent(EntityComponentEventId id, object[] args) { }

	// RVA: 0x686C998 Offset: 0x6868998 VA: 0x686C998
	public void RandomSkill(bool isRefresh, int skillType = 0, int lastSkillSelectCount = 0, int needSelectCount = 1, bool showUI = True) { }

	// RVA: 0x686DE10 Offset: 0x6869E10 VA: 0x686DE10
	private bool CheckQualityUp() { }

	// RVA: 0x686E568 Offset: 0x686A568 VA: 0x686E568
	public void FillNormalSkill(List<int> result) { }

	// RVA: 0x686E828 Offset: 0x686A828 VA: 0x686E828
	public void PauseGame() { }

	// RVA: 0x686ECAC Offset: 0x686ACAC VA: 0x686ECAC
	public List<int> ForcePauseGame() { }

	// RVA: 0x686EA5C Offset: 0x686AA5C VA: 0x686EA5C
	internal void FillSkillList(List<int> skillList) { }

	// RVA: 0x686ED1C Offset: 0x686AD1C VA: 0x686ED1C
	internal int GetSkillRemainCount(int skillId) { }

	// RVA: 0x686EEF0 Offset: 0x686AEF0 VA: 0x686EEF0
	internal void AppendSkillList(List<int> skillList) { }

	// RVA: 0x686E0A0 Offset: 0x686A0A0 VA: 0x686E0A0
	public bool GetNormalSkill(List<int> result, bool qualityUp, bool isRefresh, int curLevel, ref int star) { }

	// RVA: 0x686F134 Offset: 0x686B134 VA: 0x686F134
	public void GetBoxRandomSkills() { }

	// RVA: 0x686F394 Offset: 0x686B394 VA: 0x686F394
	public void GetRandomAngleSkills(List<int> result, int count) { }

	// RVA: 0x686F480 Offset: 0x686B480 VA: 0x686F480
	public int RandomAngelSkill() { }

	// RVA: 0x686F4F0 Offset: 0x686B4F0 VA: 0x686F4F0
	public int RandomDevilSkill() { }

	// RVA: 0x686F750 Offset: 0x686B750 VA: 0x686F750
	public OrderedHashSet<int> GetAllBattleSkill() { }

	// RVA: 0x686F7B4 Offset: 0x686B7B4 VA: 0x686F7B4
	public void ShowDefaultRandomSkills() { }

	// RVA: 0x686F88C Offset: 0x686B88C VA: 0x686F88C
	public int GetPunchboardRandomCount() { }

	// RVA: 0x686FFA8 Offset: 0x686BFA8 VA: 0x686FFA8
	public int ResolveSkillIconId(int uniqueSkillId) { }

	// RVA: 0x6870404 Offset: 0x686C404 VA: 0x6870404
	public bool CheckNeedOpenSpecialSkill() { }

	// RVA: 0x6870474 Offset: 0x686C474 VA: 0x6870474
	public bool OpenSelectSpecialSkill(bool needOpenUI = True) { }

	// RVA: 0x686BEAC Offset: 0x6867EAC VA: 0x686BEAC
	private void GroupSkillsByType() { }

	// RVA: 0x686AEF4 Offset: 0x6866EF4 VA: 0x686AEF4
	private void UpdateLearnedSkillCount(int skillType) { }

	// RVA: 0x6869D14 Offset: 0x6865D14 VA: 0x6869D14
	private void DecreaseLearnedSkillCount(int skillType) { }

	// RVA: 0x6871660 Offset: 0x686D660 VA: 0x6871660
	public int GetSkillCountByType(int skillType) { }

	// RVA: 0x687173C Offset: 0x686D73C VA: 0x687173C
	public int[] GetSkillIdsByType(int skillType) { }

	// RVA: 0x686A17C Offset: 0x686617C VA: 0x686A17C
	private void AdjustWeightsForSkillGroup(int skillType, FP weightPercent) { }

	// RVA: 0x686C5B4 Offset: 0x68685B4 VA: 0x686C5B4
	private void RecalculateAllWeight() { }

	// RVA: 0x6869E9C Offset: 0x6865E9C VA: 0x6869E9C
	private FP GetDeltaWeightPercent(int skillType) { }

	// RVA: 0x6871264 Offset: 0x686D264 VA: 0x6871264
	private void LogSkillGroupsByType() { }

	// RVA: 0x6871424 Offset: 0x686D424 VA: 0x6871424
	private void LogLearnedSkillCountsByType() { }

	// RVA: 0x68715A8 Offset: 0x686D5A8 VA: 0x68715A8
	private void LogAllWeightInfo() { }

	// RVA: 0x687184C Offset: 0x686D84C VA: 0x687184C
	public void .ctor() { }

	// RVA: 0x6871B64 Offset: 0x686DB64 VA: 0x6871B64
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x686A1F8 Offset: 0x68661F8 VA: 0x686A1F8
	private bool <RemoveSkillInSTG>g__SkillSuit|32_0(int skill) { }

	[CompilerGenerated]
	// RVA: 0x686B244 Offset: 0x6867244 VA: 0x686B244
	private bool <AddSkill>g__SkillSuit|34_0(int skill) { }
}

