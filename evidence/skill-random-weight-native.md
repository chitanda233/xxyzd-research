# 三选一动态权重 native 证据摘记

本文件保存 implementation 级证据，策划解释见 `research/battle/skill-random-analysis.md`。

## 类型学习计数

- `UpdateLearnedSkillCount` RVA 0x686AEF4：按 skillType 在字典中 `ContainsKey → get_Item → +1 → set_Item`，首次为 1。
- `DecreaseLearnedSkillCount` RVA 0x6869D14：同一字典执行 -1。
- `GetSkillCountByType` RVA 0x6871660：返回该 skillType 当前学习数量，不存在返回 0。

## 动态增权公式

`GetDeltaWeightPercent` RVA 0x6869E9C：

1. 按 skillType 读取 `Skill_SkillTypeWeight`。
2. 调用 `GetSkillCountByType`。
3. 读取配置偏移 0x24 / 0x28 的两个整数。
4. native 整数→FP 转换可复算为：50 → 0.5，500 → 5.0。
5. 计算“每技能增量 × 已学习数量”。
6. 与最大增量比较并通过 `csel` 取较小值。

因此传入权重修正层的公式可以写成：

`delta = min(learnedCount × 0.5, 5.0)`

即配置语义上的“每个同类型技能 +50 个百分点，最多 +500 个百分点”。最终有效 Weight 如何把这个 delta 与基础权重组合，仍需 `WeightRandomData.Weight` implementation 补证。

## 分组与权重落地

- `InitRandomSkill` RVA 0x686BC80：初始化后依次执行 `GroupSkillsByType` → `RecalculateAllWeight`。
- `AdjustWeightsForSkillGroup` RVA 0x686A17C：接收 skillType 与 FP delta。
- `WeightRandom.UpdateWeightPercent` RVA 0x66327C4：遍历随机项，按 ID 数组命中后修改该条目的权重百分比字段。
- `WeightRandom.RecalculateAllWeight` RVA 0x6633750：重新汇总当前有效权重。

直接证据链为：

`学习/移除技能 → 类型计数变化 → GetDeltaWeightPercent → AdjustWeightsForSkillGroup → UpdateWeightPercent → 后续抽取总权重变化`

## 候选池不是一个扁平池

- `GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill` 都先 Clear 目标 `WeightRandom`，逐条读取 `Skill_Main` 与当前 `WeightRandomData.Weight`，再把符合条件的条目 Add 到新随机池。
- `RandomOneSubSkillByParent` 会检查父技能升级链、分支组、`GameUtils.CheckCanStudySkill` 与 ban list，然后调用 `GetRandomCount`；该路径一次最多抽 1 个子技能。

因此更接近真实实现的模型是：先按语义和合法性构造多个子池，再在保留动态权重的子池内抽取，最后汇总成三选一。

## Boost / Revert 的证据边界

`WeightRandom` 存在 `BoostWeightByPercent` / `RevertWeightBoost`，但当前保存的 `HeroComponentRandomSkill.asm` 中没有找到两者 RVA 的直接调用。它们证明通用随机器支持临时 Boost，却不能作为 Build 收敛的直接证据。除非后续定位到真实调用方，否则不应写成“保底”“首选同类”或“三选一临时增权”。
