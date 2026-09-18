# 三选一同 SkillType 动态权重证据

研究对象：客户端 1.0.16 / versionCode 40。这里专门记录“同类型技能越学越容易出现”这一假设的证据边界，正文见 `research/battle/skill-random-analysis.md`。

## 配置

`Skill_SkillTypeWeight` 中有效类型基本统一：

```text
AddWeightPerSkill = 50
AddWeightMax      = 500
```

## 已被 native 证明的计算框架

来源：`restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`

- `UpdateLearnedSkillCount(skillType)` — RVA `0x686AEF4`：维护 `_learnedSkillCountsByType`，同一 SkillType 每学习一次计数 +1。
- `GetDeltaWeightPercent(skillType)` — RVA `0x6869E9C`：
  1. 读取该 SkillType 的 `Skill_SkillTypeWeight`；
  2. 读取已学同类型数量；
  3. 计算 `learnedCount × AddWeightPerSkill`；
  4. 用 `AddWeightMax` 截顶。
- 新增/移除技能相关调用链确实会执行：
  `GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`。

按当前配置，设计公式就是：

```text
delta(type) = min(learnedCount(type) × 50%, 500%)
```

如果最终应用，则 1 / 2 / 3 / 5 / 10 个同类型技能分别对应 +50% / +100% / +150% / +250% / +500%。

## 关键反证：当前 APK fallback 没有真正应用

`AdjustWeightsForSkillGroup` — RVA `0x686A17C`。

当前 APK 的普通 native fallback 分支在完成类型/hotfix 元数据检查后直接返回；没有遍历 `_skillGroupsByType`，也没有把刚才算出的 `delta` 写给任何 `WeightRandom`。只有方法被运行时 hotfix 覆盖时，才会走间接跳转的实现。

同时：

- `HeroComponentRandomSkill.asm` 中没有找到对 `WeightRandom.UpdateWeightPercent` 的直接调用。
- `WeightRandom.UpdateWeightPercent` 本身确实存在（RVA `0x66327C4`），可以给指定 skillIds 写百分比权重修正。
- `WeightRandom.BoostWeightByPercent`（RVA `0x6633824`）和 `RevertWeightBoost`（RVA `0x6633908`）也都存在，说明底层随机器有成熟的临时增权能力。
- 但“底层能力存在”不能替代“主线动态 SkillType 机制实际调用它”的证据。

## 当前应采用的策划表述

**已证实：** 客户端设计了同 SkillType 的 Build 收敛框架，理论参数为“每学一个同类型技能，计划增权 +50%，最多 +500%”。

**未证实：** 1.0.16 APK 基线运行时真的把这项增权应用到主线三选一候选。当前 fallback 应用函数为空实现。

可能性包括：该功能被废弃/暂时关闭，或者线上运行时 hotfix 覆盖了 `AdjustWeightsForSkillGroup`。由于本轮没有下载线上热更，也没有实机统计，不应把“已有 Build 会实际提高同类出现率”写成确定规则。

这条反证非常重要：它把“设计意图”和“当前静态 APK 能证明的运行行为”分开，避免策划报告把未生效逻辑写死。