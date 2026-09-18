# Native 关键证据索引：第一章节奏与三选一

本文件的目的不是把 ARM64 汇编搬进策划报告，而是给后续同事一个“结论从哪里来”的最短路径。原始反编译仍保留在 `restored/code/native-evidence/`。

## Waterfall 波次与经验

### InitNewWaveData — RVA 0x65CB634

来源：`HotFix.BattleLogic.WaterfallBattleManager.asm`

关键行为：

1. 读取当前 `ChapterWave_Waves`。
2. 清零 `_expCount`（对象偏移约 0x150）、`_addExp` 等波内统计。
3. 调用 `CalSpecialMonsterCount` 扫描本波任务。
4. 从当前 Wave 配置偏移 0x28 读取 `WaveAllExp`。
5. 用 `WaveAllExp / _expCount` 计算 `_perExp`（约 0x158），最后用 `FPMath.Max(1, ...)` 保底。

可读伪代码：

```csharp
_expCount = 0;
_addExp = 0;
CalSpecialMonsterCount(firstMissionOfWave);

if (WaveAllExp >= 1) {
    _perExp = Max(FP.One, FP.FromInt(WaveAllExp) / _expCount);
}
```

这证明第一章的经验核心是“每波总预算”，不是把所有怪物固定经验简单相加。

### CalSpecialMonsterCount — RVA 0x65D0C70

来源同上。它会展开普通、位置组、随机组等刷新形式，累计三类计数。其中对象偏移 0x150 的第三类累计值被 `InitNewWaveData` 用作经验预算分母。结合 Character 的 `expWeight` 与 `GetCharacterDropExp`，可确认这不是简单任务条目数，而是经验分配权重统计。

### GetCharacterDropExp — RVA 0x65D5144

来源同上。

关键行为：

- 读取怪物类型/Character 数据；
- 在硬门槛波额外判断 `CheckIsSpecialMonster`；
- 使用 `_perExp`、Character 经验权重与 `_addExp` 计算本次掉落；
- 对接近波总预算尾部的情况做剩余量修正，避免总经验漂移。

因此 `expWeight` 应理解成“从本波预算中分多少份”，而不是单独决定这一章升级速度的绝对经验值。

### CheckStopByEliteOrBossKilled — RVA 0x65D3784

直接读取当前 Wave 配置偏移 0x24，并判断是否等于 1。对照 `ChapterWave_Waves` 可确认第一章只有 W10、W15 为真；W5 为假。

### OnProgressFinish — RVA 0x65CC838

波末进度处理器。关键路径：

```text
HasEquip / HaveDropExp
    ↓
仍有经验掉落 -> DropMgr.AbsorbAll
    ↓
ExpAnimProcessor.IsIdle / CanLevelUp
    ↓
_needUpLevelCount > 0
    ↓
QueueSelectSkill
```

所以 Waterfall 的升级选择被纳入“波末收束流程”，不是经验一满就无条件即时打断。

### QueueSelectSkill — RVA 0x65C8E98

当 `CanRunUpLevelProgress` 成立后，进入 BattleManager 的选技能状态（`ActiveState(..., 3, ...)`）。同时维护 `WaveEndUpLevelProgressState`，避免波末流程重复进入。

### AddUpLevel / DelUpLevel — RVA 0x65C8890 / 0x65C88FC

`AddUpLevel` 增加 `_needUpLevelCount`；`DelUpLevel` 消耗 1 次待升级，并把 `curWaveUpLevelCount` 加 1。说明代码原生支持“一波内积压多次升级”，但第一章基础经验预算被校准为每波约一升。

## 三选一动态随机

### GroupSkillsByType — HeroComponentRandomSkill

来源：`HotFix.BattleLogic.HeroComponentRandomSkill.asm`

遍历技能数据，把技能 ID 按 `Skill_Main` 偏移 0x68（即 SkillType）分组到 `_skillGroupsByType`，并初始化 `_learnedSkillCountsByType`。这直接证明动态学习计数的粒度是 SkillType，而不是 BattleSkillGroup。

### UpdateLearnedSkillCount / AddSkill / RemoveSkill

每次技能加入或移除都会取技能的 SkillType，并更新对应类型计数，随后重新计算/调整权重。因此这个修正会跟着当前 Build 变化，而不是首抽时一次性确定。

### GetDeltaWeightPercent

来源：`HotFix.BattleLogic.HeroComponentRandomSkill.asm`

可读伪代码：

```csharp
var cfg = GetSkill_SkillTypeWeight(skillType);
var count = GetSkillCountByType(skillType);
var add = cfg.AddWeightPerSkill / 100f;
var cap = cfg.AddWeightMax / 100f;
return Min(add * count, cap);
```

Type 1 配置：`AddWeightPerSkill=50`，`AddWeightMax=500`。

### PracticalWeight — WeightRandomData RVA 0x6632120

来源：`HotFix.BattleLogic.WeightRandomData.asm`

ARM64 直接把 delta 与 `FP.One(0x10000)` 相加，再乘基础权重：

```csharp
PracticalWeight = BaseWeight * (FP.One + DeltaWeightPercent);
```

所以 Type 1 的 50/500 是“+50% / +500%”，最终分别相当于 1.5x 与最高 6.0x 基础权重。

### WeightRandom.GetAlreadyStudySkill / GetReadyStudySkill / GetOneStarSkill

来源：`HotFix.BattleLogic.WeightRandom.asm`。

三个独立入口表明候选构造会区分：

- 已学且还能成长；
- 当前可学习；
- 一星/新入口。

因此“已有技能升级”和“新技能出现”并不是同一个扁平随机列表。

### RandomOneSubSkillByParent

当抽到的父技能满足对应升级类型时，读取父技能的 `UpgradeSkillId`，逐个走 `GameUtils.CheckCanStudySkill`，构造临时 WeightRandom，再抽一个子技能。

对照 `Skill_Main`：例如速射机炮 10000102 的 `UpgradeSkillId` 是 10400101/10400102/10400105；这些 104 条目是该武器的局部分支强化。因此武器主线升级过程中还嵌套了“父技能 → 合法子分支”的二次随机。

### Need / Reject / Flag

`WeightRandomData` 保存 NeedSkills、RejectSkills、NeedFlags、SkillFlags 等，`WeightRandom` 在候选加入/筛选时使用这些条件。它们是候选资格硬约束；动态权重只在“已经有资格进入池”的项目之间改变相对概率。

### HeroSkillCreator.GetRandomSkills

来源：`HotFix.BattleLogic.HeroSkillCreator.asm`。

该方法会先根据一组“池权重”随机选择 WeightRandom 池，再调用目标池的 `GetRandomCount` 抽实际条目，并维护去重/ban 列表。三选一因此至少是“两段随机”：池级选择 + 池内选择。

### SinglePlayerSkillCreator.GetNormalSkill

来源：`HotFix.BattleLogic.SinglePlayerSkillCreator.asm`。

存在 `NewPlayerBoostRecord` 路径：抽取前调用 `WeightRandom.BoostWeightByPercent`，生成后调用 `RevertWeightBoost`。这说明系统支持一次性/场景化扶正，而不改变永久基础权重。

## 配置层对应关系

标准局内四个可见层：

- `SkillGroup_SurvivorGroup`：11 个 Type 1 武器入口 + 7 个 Type 2 通用模块。
- `SkillGroup_BranchSurvivorGroup`：57 个 Type 4 武器分支。
- `SkillGroup_UpgradeSurvivorGroup`：111 个 Type 3 深层强化。
- `SkillGroup_UpgradeSkillGroup`：22 个 Type 3 突破父节点。

`Skill_SkillTypeWeight` 中当前标准类型只有 Type 1 有 50/500 的有效加权；Type 2/3/4 没有同样的普通键。因此不要把这条公式错误描述成“每个具体 Build 家族都自动 +50%”。
