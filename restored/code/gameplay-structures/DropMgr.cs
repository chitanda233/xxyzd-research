// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal abstract class DropMgr : IWorldContextOwner // TypeDefIndex: 10873
{
	// Fields
	[CompilerGenerated]
	private BattleWorldContext <WorldContext>k__BackingField; // 0x10
	private FP _hpRandomAdd; // 0x18
	private FP _expRandomAdd; // 0x20
	private FP dropRadius; // 0x28
	private FP dropHeight; // 0x30
	private int _dropItemCount; // 0x38
	private int _dropExpCount; // 0x3C
	private int _dropEquipCount; // 0x40
	private int _dropHpCount; // 0x44
	private int _dropGoldCount; // 0x48

	// Properties
	public BattleWorldContext WorldContext { get; set; }
	public virtual int WaveGold { get; }
	public virtual int WaveExp { get; }
	public int ExpCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x666A320 Offset: 0x6666320 VA: 0x666A320 Slot: 4
	public BattleWorldContext get_WorldContext() { }

	[CompilerGenerated]
	// RVA: 0x666A384 Offset: 0x6666384 VA: 0x666A384 Slot: 5
	public void set_WorldContext(BattleWorldContext value) { }

	// RVA: 0x666A404 Offset: 0x6666404 VA: 0x666A404
	public void Init(BattleWorldContext worldContext, IChapter chapterData) { }

	// RVA: 0x666A4EC Offset: 0x66664EC VA: 0x666A4EC Slot: 6
	public virtual void InitByPlayerInfo(BattlePlayerInfo player) { }

	// RVA: 0x666A560 Offset: 0x6666560 VA: 0x666A560 Slot: 7
	public virtual void OnMonsterCreate(int count) { }

	// RVA: 0x666A5D4 Offset: 0x66665D4 VA: 0x666A5D4 Slot: 8
	public virtual int get_WaveGold() { }

	// RVA: 0x666A638 Offset: 0x6666638 VA: 0x666A638 Slot: 9
	public virtual int get_WaveExp() { }

	// RVA: 0x666A69C Offset: 0x666669C VA: 0x666A69C Slot: 10
	protected virtual void OnSetChapterData(IChapter chapter) { }

	// RVA: 0x666A710 Offset: 0x6666710 VA: 0x666A710
	public void DeInit() { }

	// RVA: 0x66653A0 Offset: 0x66613A0 VA: 0x66653A0
	public void RemoveDropItem(DropItemEntity drop) { }

	// RVA: 0x666A770 Offset: 0x6666770 VA: 0x666A770
	private void ForceRemoveDropItem(DropItemEntity drop) { }

	// RVA: 0x666A808 Offset: 0x6666808 VA: 0x666A808
	public void DropItems(List<DropItemData> dropList) { }

	// RVA: 0x6666358 Offset: 0x6662358 VA: 0x6666358
	public void ReduceItemCount(bool isExp, bool isEquip) { }

	// RVA: 0x666AF44 Offset: 0x6666F44 VA: 0x666AF44
	private void AddItemCount(bool isExp, bool isEquip) { }

	// RVA: 0x666AFEC Offset: 0x6666FEC VA: 0x666AFEC
	private void AddGoldCount() { }

	// RVA: 0x6667C10 Offset: 0x6663C10 VA: 0x6667C10
	public void ReduceGoldCount() { }

	// RVA: 0x666B064 Offset: 0x6667064 VA: 0x666B064
	private void AddHpCount() { }

	// RVA: 0x6668AE0 Offset: 0x6664AE0 VA: 0x6668AE0
	public void ReduceHpCount() { }

	// RVA: 0x666A994 Offset: 0x6666994 VA: 0x666A994
	public DropItemEntity DropItem(DropItemData dropItemData) { }

	// RVA: 0x666B0DC Offset: 0x66670DC VA: 0x666B0DC
	public void DropItems(EntityCharacterData targetEntityData, EntityCharacter attacker) { }

	// RVA: 0x666B958 Offset: 0x6667958 VA: 0x666B958
	public void DropItemsByAbsorbDropItem() { }

	// RVA: 0x666BB3C Offset: 0x6667B3C VA: 0x666BB3C Slot: 11
	protected virtual void OnDropItem(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	[Conditional("GM_CMD_OPEN")]
	// RVA: 0x666BBD4 Offset: 0x6667BD4 VA: 0x666BBD4
	public void GmCreateDropByItemBattleId(int itemBattleId, int count) { }

	// RVA: 0x666BF24 Offset: 0x6667F24 VA: 0x666BF24
	protected FPVector3 GetRandomDirByIndex(int i) { }

	// RVA: 0x666B400 Offset: 0x6667400 VA: 0x666B400
	private void AddDropHp(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x666C5EC Offset: 0x66685EC VA: 0x666C5EC
	private void tryCreateHPDrop(EntityCharacterData characterData, EntityCharacter attacker, FP hpDropRate, ref int index, ref List<DropItemData> list) { }

	// RVA: 0x666C84C Offset: 0x666884C VA: 0x666C84C
	private DropItemData createHPDrop(EntityCharacterData characterData, EntityCharacter attacker, int index) { }

	// RVA: 0x666C448 Offset: 0x6668448 VA: 0x666C448
	private FP getDropRate(EntityCharacterData characterData, EntityCharacter attacker, FP baseRate) { }

	// RVA: 0x666CDF8 Offset: 0x6668DF8 VA: 0x666CDF8
	internal void AddDropExpOnPos(int playerId, FPVector3 pos, int totalExp) { }

	// RVA: 0x666CFB0 Offset: 0x6668FB0 VA: 0x666CFB0
	internal void AddDropExpAroundPos(int playerId, FPVector3 pos, int totalExp, FP miniRange, FP maxRange, bool forceAbsorb = False) { }

	// RVA: 0x666D5B4 Offset: 0x66695B4 VA: 0x666D5B4
	internal void AddDropExp(int playerId, FPVector3 pos, int totalExp, bool forceAbsorb = False) { }

	// RVA: 0x666DA2C Offset: 0x6669A2C VA: 0x666DA2C
	internal void AddDropHp(int playerId, FPVector3 pos, int count, bool forceAbsorb = False, bool ignoreDropRestrictions = False) { }

	// RVA: 0x666DEB0 Offset: 0x6669EB0 VA: 0x666DEB0
	internal void AddDropNpc(int dropId, int playerId, FPVector3 pos, int count, bool forceAbsorb = False) { }

	// RVA: 0x666E3D8 Offset: 0x666A3D8 VA: 0x666E3D8 Slot: 12
	protected virtual void AddDropGold(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x666EA88 Offset: 0x666AA88 VA: 0x666EA88 Slot: 13
	protected virtual void AddDropExp(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x666F5AC Offset: 0x666B5AC VA: 0x666F5AC
	private bool DropAbsorbExp() { }

	// RVA: 0x666F6DC Offset: 0x666B6DC VA: 0x666F6DC
	private void addDropItemData2List(EntityCharacterData characterData, EntityCharacter attacker, bool isBoss, ref int index, List<DropItemData> list, int dropItemId) { }

	// RVA: 0x666E5B8 Offset: 0x666A5B8 VA: 0x666E5B8
	private void addDropItemData2List(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list, int dropItemId, int dropValue, bool isBoss) { }

	// RVA: 0x666CB60 Offset: 0x6668B60 VA: 0x666CB60
	public DropItemData CreteDropData(int playerId, FPVector3 startPos, Item_battle tableData, int index, FP speedScale, FP speedYScale, bool disableDelayDropTime = False) { }

	// RVA: 0x666C230 Offset: 0x6668230 VA: 0x666C230
	protected DropItemData CreteDropData(int playerId, FPVector3 startPos, FPVector3 dir, Item_battle tableData, int index, bool disableDelayDropTime = False) { }

	// RVA: 0x666FCF8 Offset: 0x666BCF8 VA: 0x666FCF8
	public bool IsEmpty() { }

	// RVA: 0x666FD64 Offset: 0x666BD64 VA: 0x666FD64
	public bool HaveDropExp() { }

	// RVA: 0x666FDD0 Offset: 0x666BDD0 VA: 0x666FDD0
	public bool EquipIsClear() { }

	// RVA: 0x666FE3C Offset: 0x666BE3C VA: 0x666FE3C
	public bool ExpIsClear() { }

	// RVA: 0x666FEA8 Offset: 0x666BEA8 VA: 0x666FEA8
	public bool HasEquip() { }

	// RVA: 0x666FF14 Offset: 0x666BF14 VA: 0x666FF14
	public int get_ExpCount() { }

	// RVA: 0x666FF78 Offset: 0x666BF78 VA: 0x666FF78
	public void AbsorbAll() { }

	// RVA: 0x6670384 Offset: 0x666C384 VA: 0x6670384
	public void AbsorbAllExp() { }

	// RVA: 0x66703E4 Offset: 0x666C3E4 VA: 0x66703E4
	public void AbsorbAllEquip() { }

	// RVA: 0x66707EC Offset: 0x666C7EC VA: 0x66707EC
	public void RemoveAllMagic() { }

	// RVA: 0x6670BEC Offset: 0x666CBEC VA: 0x6670BEC
	public DropItemEntity GetNotNearMagic(FPVector3 pos) { }

	// RVA: 0x6660484 Offset: 0x665C484 VA: 0x6660484
	protected void .ctor() { }
}

