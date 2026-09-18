// Extracted structure subset for battle skill-selection state.
// Source: restored/code/il2cpp/assemblies/HotFixBattle.dll.cs
// This file is intentionally partial and is not meant to compile standalone.
// Read the corresponding native evidence before treating method bodies as known.

namespace HotFix.BattleLogic
{
    internal struct BattleData // TypeDefIndex: 10468
    {
        // Other BattleData fields omitted.
        public int InitSkillGroupCount; // 0x34
    }

    [System.Serializable]
    public class BattleSaveData // TypeDefIndex: 12692
    {
        // Other BattleSaveData fields omitted.
        public int initSkillGroupCount; // 0x20

        // RVA: 0x6A4EB34
        internal void SaveAllBattleData(
            int wave,
            int killCount,
            int gold,
            int missionIndex,
            int hp,
            int exp,
            int lv,
            int maxExp,
            int floor,
            int exNeedSelectCount,
            int entityId,
            System.Collections.Generic.List<int> skills,
            System.Collections.Generic.List<int> removeSkills,
            System.Collections.Generic.Dictionary<int, int> waveGold,
            int dropGold,
            int realKillCount,
            int enemyCount,
            int initSkillGroupCount,
            int reliveCount,
            int beHitCount,
            int reliveType,
            int randomSkillCount,
            int refreshCount,
            string[] triggerActionStates,
            int adReliveCount,
            int reliveUsedCount,
            long missionTimeRaw = 0,
            BattleSaveDataSerializeSource caller = 0)
        { }
    }

    internal class BattleWorldContext
    {
        // Structure-only declarations relevant to the init skill-group counter.

        // RVA: 0x6A033B4
        public int get_InitSkillGroupCount() { return default; }

        // RVA: 0x6A035C0
        public void DoInitSkillGroup() { }

        // RVA: 0x6A0362C
        public void DoInitSkillGroupCount(int count) { }
    }
}
