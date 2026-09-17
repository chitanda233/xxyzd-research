// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class EntityMonster : EntityCharacter // TypeDefIndex: 11827
{
	// Fields
	[CompilerGenerated]
	private EntityCharacter <Parent>k__BackingField; // 0x628
	private Dictionary<int, FP> _lastTriggerAdWeaponTime; // 0x630

	// Properties
	public EntityCharacter Parent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68D1B34 Offset: 0x68CDB34 VA: 0x68D1B34
	public EntityCharacter get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x68D1B98 Offset: 0x68CDB98 VA: 0x68D1B98
	public void set_Parent(EntityCharacter value) { }

	// RVA: 0x68D1C18 Offset: 0x68CDC18 VA: 0x68D1C18 Slot: 33
	protected override void OnInit() { }

	// RVA: 0x68D2014 Offset: 0x68CE014 VA: 0x68D2014 Slot: 35
	protected override void OnDeInit() { }

	// RVA: 0x68D2100 Offset: 0x68CE100 VA: 0x68D2100 Slot: 41
	protected override void OnDeath(TakeDamageData damageData) { }

	// RVA: 0x68D2250 Offset: 0x68CE250 VA: 0x68D2250 Slot: 47
	internal override FP GetLastTriggerAddWeaponTime(int weaponId) { }

	// RVA: 0x68D2300 Offset: 0x68CE300 VA: 0x68D2300 Slot: 48
	internal override void SetTriggerAddWeaponTime(int weaponId, FP time) { }

	// RVA: 0x68D2400 Offset: 0x68CE400 VA: 0x68D2400 Slot: 34
	protected override void ClearBullets() { }

	// RVA: 0x68D2894 Offset: 0x68CE894 VA: 0x68D2894
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x68D2920 Offset: 0x68CE920 VA: 0x68D2920
	private bool <ClearBullets>b__10_0(EntityBullet item) { }
}

