// Namespace: HotFix.BattleLogic
internal abstract class HeroSkillCreator // TypeDefIndex: 11806
{
	// Fields
	private HeroComponentRandomSkill _heroSkillComponent; // 0x10
	internal WeightRandom[] _initRandoms; // 0x18
	internal WeightRandom[] BoxRandoms; // 0x20
	internal WeightRandom[] PunchboardRandoms; // 0x28
	internal WeightRandom[] DankeTempRandoms; // 0x30
	internal WeightRandom[] DankeTemp1Randoms; // 0x38
	internal WeightRandom InginiteSkillRandoms; // 0x40
	internal WeightRandom[] DefaultRandoms; // 0x48
	internal WeightRandom[] DoRandomLogic; // 0x50
	protected EntityHero Player; // 0x58
	public static WeightRandom SmallSuperSkillRandom; // 0x0
	protected int DefaultRandomIndex; // 0x60

	// Properties
	protected BattleWorldContext WorldContext { get; }
	public int RandomIndex { get; }

	// Methods

	// RVA: 0x685B324 Offset: 0x6857324 VA: 0x685B324
	protected BattleWorldContext get_WorldContext() { }

	// RVA: 0x6871DC0 Offset: 0x686DDC0 VA: 0x6871DC0 Slot: 4
	protected virtual void OnInitRandoms() { }

	// RVA: 0x685DE88 Offset: 0x6859E88 VA: 0x685DE88 Slot: 5
	public virtual void DoSomethingOnGuide() { }

	// RVA: 0x6871F00 Offset: 0x686DF00 VA: 0x6871F00
	public WeightRandom[] GetDefaultRandoms() { }

	// RVA: 0x686F820 Offset: 0x686B820 VA: 0x686F820
	public void ShowDefaultRandomSkills() { }

	// RVA: 0x6871F64 Offset: 0x686DF64 VA: 0x6871F64
	public void SetHeroSkillComponent(HeroComponentRandomSkill heroSkillComponent) { }

	// RVA: 0x686BD20 Offset: 0x6867D20 VA: 0x686BD20
	public void InitRandomSkill(int[] bindSkills, EntityHero player) { }

	// RVA: 0x686C7C0 Offset: 0x68687C0 VA: 0x686C7C0
	public void DeInit() { }

	// RVA: 0x6872310 Offset: 0x686E310 VA: 0x6872310
	public void RedistributeWeight() { }

	// RVA: 0x686B6FC Offset: 0x68676FC VA: 0x686B6FC
	public void AddSkillFlag(int flag) { }

	// RVA: 0x686B7BC Offset: 0x68677BC VA: 0x686B7BC
	public void AddSkillRejectFlag(int rejectFlag) { }

	// RVA: 0x686B87C Offset: 0x686787C VA: 0x686B87C
	public void AddRejectSkills(int[] rejectSkills) { }

	// RVA: 0x686B93C Offset: 0x686793C VA: 0x686B93C
	public void AddNewSkill(int addSkill) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int RandomDevilSkill(ref int randomIndex, bool qualityUp);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnAddSkillFlag(int flag);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnAddRejectFlag(int rejectFlag);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnCheckNeedSkills(int addSkill);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnAddRejectSkills(int[] rejectSkills);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnDeInit();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnCreateRandoms();

	// RVA: 0x6863690 Offset: 0x685F690 VA: 0x6863690
	protected int GetEffectiveWeight(ISkillGroup skillGroup) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnInitRandomSkill(int[] bindSkills);

	// RVA: 0x686B9FC Offset: 0x68679FC VA: 0x686B9FC
	public void RemoveRandomSkill(int skillId) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnRemoveRandomSkill(int skillId);

	// RVA: 0x6871FE4 Offset: 0x686DFE4 VA: 0x6871FE4
	protected void CreateRandoms(WeightRandom[] weightRandoms) { }

	// RVA: 0x6872370 Offset: 0x686E370 VA: 0x6872370
	protected void AddSkillGroupToNormalRandom(WeightRandom[] randoms, ISkillGroup skillGroup, int[] bindSkills) { }

	// RVA: 0x687260C Offset: 0x686E60C VA: 0x687260C
	protected void AddDankeSkillGroupToRandom(WeightRandom[] randoms, ISkillGroup skillGroup, int[] bindSkills) { }

	// RVA: 0x6872808 Offset: 0x686E808 VA: 0x6872808
	protected void AddSkillGroupToRandom(WeightRandom random, ISkillGroup skillGroup, int[] bindSkills) { }

	// RVA: 0x6872970 Offset: 0x686E970 VA: 0x6872970
	protected void AddSkillGroupToBoxRandoms(ISkillGroup skillGroup, WeightRandom[] randoms, int[] bindSkills) { }

	// RVA: 0x686606C Offset: 0x686206C VA: 0x686606C Slot: 15
	protected virtual void AddSkillToRandom(WeightRandom random, int skillId, int skillWeight, List<int> learnedSkills) { }

	// RVA: 0x685B6B8 Offset: 0x68576B8 VA: 0x685B6B8
	protected static bool IsContain(int[] array, int value) { }

	// RVA: 0x6872230 Offset: 0x686E230 VA: 0x6872230
	protected void ReleaseRandoms(WeightRandom[] weightRandoms) { }

	// RVA: 0x6872BC0 Offset: 0x686EBC0 VA: 0x6872BC0
	public int get_RandomIndex() { }

	// RVA: 0x685B9C4 Offset: 0x68579C4 VA: 0x685B9C4
	protected void GetRandomSkills(List<int> result, List<int> curAllSkills, WeightRandom[] randoms, int skillCount, ref int randomIndex, int[] skillWeights, bool qualityUp, bool isRefresh) { }

	// RVA: 0x68633D4 Offset: 0x685F3D4 VA: 0x68633D4
	protected void GetBanSkill(List<int> banSkills, List<int> allSkills) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool GetNormalSkill(List<int> result, bool isRefresh, int[] skillWeights, bool skillUp, List<int> curAllSkills, ref int star, int[] randomSkillFactor);

	// RVA: 0x6872C24 Offset: 0x686EC24 VA: 0x6872C24 Slot: 17
	public virtual bool IsFirst() { }

	// RVA: 0x6872C88 Offset: 0x686EC88 VA: 0x6872C88 Slot: 18
	public virtual void CheckIsSpecialSkill(int skillId) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void GetBoxRandomSkills(ref BoxSkillResult boxSkillResult, int[] skillWeights, bool skillUp);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void GetRandomAngleSkills(List<int> result, List<int> curAllSkills, int count);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int RandomAngelSkill();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void AddSkillChangeRandomPool(int skillId, List<int> allSkills);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool OpenSelectSpecialSkill(List<int> result, List<int> allSkills, out int specialParentSkillId);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool CheckNeedOpenSpecialSkill();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Dictionary<int, int> GetRandomPunchboardSkills(List<int> haveSkillResult, List<int> newSkillResult, List<int> replenishSkillResult, int count, int[] skillWeights, bool qualityUp, bool isRefresh, List<int> curAllSkills);

	// RVA: 0x687216C Offset: 0x686E16C VA: 0x687216C
	private void BuildGroupToBaseSkillMap() { }

	// RVA: 0x685C358 Offset: 0x6858358 VA: 0x685C358
	protected void .ctor() { }
}
