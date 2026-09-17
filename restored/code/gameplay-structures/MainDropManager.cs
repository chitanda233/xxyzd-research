// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class MainDropManager : DropMgr // TypeDefIndex: 10876
{
	// Fields
	private IMainChapter _chapterData; // 0x50
	private int[] _monsterDropCount; // 0x58
	private int[] _bossDropCount; // 0x60
	private int _monsterDataCount; // 0x68
	private int _bossDataCount; // 0x6C
	private const int SpecialDropId = 4006;
	private const int SpecialDropId2 = 2001;

	// Properties
	public override int WaveGold { get; }
	public override int WaveExp { get; }

	// Methods

	// RVA: 0x667179C Offset: 0x666D79C VA: 0x667179C Slot: 8
	public override int get_WaveGold() { }

	// RVA: 0x6671868 Offset: 0x666D868 VA: 0x6671868 Slot: 9
	public override int get_WaveExp() { }

	// RVA: 0x6671934 Offset: 0x666D934 VA: 0x6671934 Slot: 10
	protected override void OnSetChapterData(IChapter chapter) { }

	// RVA: 0x6671B50 Offset: 0x666DB50 VA: 0x6671B50 Slot: 11
	protected override void OnDropItem(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x6671C2C Offset: 0x666DC2C VA: 0x6671C2C
	private bool CheckSpecialDrop(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x6671CC8 Offset: 0x666DCC8 VA: 0x6671CC8
	private void AddDropItemFromGroup(EntityCharacterData characterData, EntityCharacter attacker, ref int index, List<DropItemData> list) { }

	// RVA: 0x6671D60 Offset: 0x666DD60 VA: 0x6671D60
	public void .ctor() { }
}

