// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class CharacterComponentBuff : CharacterComponentBase // TypeDefIndex: 10913
{
	// Fields
	private FP _lastExploreTime; // 0x40
	private bool _needCheckExplore; // 0x48
	private readonly OrderedDictionary<int, BuffBase> m_buffs; // 0x50
	private readonly List<BuffBase> _shields; // 0x58
	private readonly Dictionary<BuffType, List<BuffBase>> m_buffsForType; // 0x60
	private readonly byte[] _buffFlags; // 0x68

	// Methods

	// RVA: 0x669367C Offset: 0x668F67C VA: 0x669367C Slot: 11
	public override void Init() { }

	// RVA: 0x66936E4 Offset: 0x668F6E4 VA: 0x66936E4 Slot: 12
	public override void DeInit() { }

	// RVA: 0x6693748 Offset: 0x668F748 VA: 0x6693748
	private void ClearAllBuff() { }

	// RVA: 0x6693A40 Offset: 0x668FA40 VA: 0x6693A40 Slot: 14
	public override void OnUpdate(FP deltaTime) { }

	// RVA: 0x6694320 Offset: 0x6690320 VA: 0x6694320 Slot: 15
	public override void OnLateUpdate(FP deltaTime) { }

	// RVA: 0x6694394 Offset: 0x6690394 VA: 0x6694394 Slot: 16
	public override void OnEvent(EntityComponentEventId id, object[] args) { }

	// RVA: 0x6694410 Offset: 0x6690410 VA: 0x6694410
	public bool CheckShield(bool isMiss, HurtAttackerType hurtAttackerType) { }

	// RVA: 0x66940A0 Offset: 0x66900A0 VA: 0x66940A0
	private void RemoveBuffInternal(BuffBase buff, bool isReplace) { }

	// RVA: 0x6694280 Offset: 0x6690280 VA: 0x6694280
	internal bool CheckBuffFLag(int flag) { }

	// RVA: 0x66946D0 Offset: 0x66906D0 VA: 0x66946D0
	public List<int> GetAllBuffFlags() { }

	// RVA: 0x6694828 Offset: 0x6690828 VA: 0x6694828
	private void AddBuffFlag(int flag) { }

	// RVA: 0x6694630 Offset: 0x6690630 VA: 0x6694630
	private void RemoveBuffFlag(int flag) { }

	// RVA: 0x66948C8 Offset: 0x66908C8 VA: 0x66948C8
	internal BuffBase AddBuff(EntityRef caster, AttributeData attackerAttr, FP attackerCurrentHp, int id, bool checkSpecial, bool forceAdd = False, int sourceWeaponId = 0) { }

	// RVA: 0x6695B54 Offset: 0x6691B54 VA: 0x6695B54
	private void CheckTriggerAddBuff(EntityRef caster, int buffId) { }

	// RVA: 0x66958E8 Offset: 0x66918E8 VA: 0x66958E8
	private void AddShield(BuffBase buff) { }

	// RVA: 0x6695E84 Offset: 0x6691E84 VA: 0x6695E84
	public void ClearBuffsByType(BuffType type) { }

	// RVA: 0x669607C Offset: 0x669207C VA: 0x669607C
	internal void AddInvBuffTime(FP time, FP timeScale) { }

	// RVA: 0x66962D8 Offset: 0x66922D8 VA: 0x66962D8
	public void OnWaveEnd() { }

	// RVA: 0x6696418 Offset: 0x6692418 VA: 0x6696418
	public void EndBuffById(int buffId) { }

	// RVA: 0x6695FA0 Offset: 0x6691FA0 VA: 0x6695FA0
	public void RemoveBuffs(List<BuffBase> buffs) { }

	// RVA: 0x66964D4 Offset: 0x66924D4 VA: 0x66964D4
	public bool HasBuffOfHurtType(HurtType type) { }

	// RVA: 0x669677C Offset: 0x669277C VA: 0x669677C
	public bool HasNegativeBuff() { }

	// RVA: 0x669687C Offset: 0x669287C VA: 0x669687C
	internal IEnumerable<BuffBase> GetAllBuffs() { }

	// RVA: 0x6696900 Offset: 0x6692900 VA: 0x6696900
	public void .ctor() { }
}

