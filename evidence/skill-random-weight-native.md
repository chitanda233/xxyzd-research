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

因此动态修正值为：

`delta = min(learnedCount × 0.5, 5.0)`

即配置语义上的“每个同类型技能 +50 个百分点，最多 +500 个百分点”。

## 最终有效权重公式已经闭环

`HotFix.BattleLogic.WeightRandomData.asm` 已保存真实 implementation。

- `WeightRandomData.Weight` RVA 0x663206C：先检查 need/reject/禁用等条件；合法时转入 `PracticalWeight`。
- `WeightRandomData.PracticalWeight` RVA 0x6632120：读取偏移 0x18 的动态 FP 修正和偏移 0x04 的基础 weight；对动态修正执行 `+ 0x10000`（FP 的 1.0），再与基础权重相乘并右移 16 位。
- `WeightRandomData.UpdateDeltaWeightPercent` RVA 0x6632194：把新的 FP delta 写入偏移 0x18。

对应伪代码：

```text
if (!eligible)
    return 0

PracticalWeight:
    return baseWeight * (1.0 + deltaWeightPercent)
```

与 `GetDeltaWeightPercent` 合起来：

```text
effectiveWeight
  = baseWeight × (1 + min(learnedCount × 0.5, 5.0))
```

因此同类型学习数量 0/1/2/3/.../10+ 时，基础权重乘数分别为 1.0/1.5/2.0/2.5/.../6.0。注意这仍是“权重乘数”，不是最终概率乘数；最终概率取决于当次合法池内总权重。

## 分组与权重落地

- `InitRandomSkill` RVA 0x686BC80：初始化后依次执行 `GroupSkillsByType` → `RecalculateAllWeight`。
- `AdjustWeightsForSkillGroup` RVA 0x686A17C：调用点明确接收 skillType 与 FP delta，但当前 ARM64 中这个方法本身是 HotFix 分发壳，静态文件没有暴露真实热更方法体。
- `WeightRandom.UpdateWeightPercent` RVA 0x66327C4：通用随机器支持按一组 ID 更新条目的 delta percent。
- `WeightRandom.RecalculateAllWeight` RVA 0x6633750：重新汇总当前有效权重。
- `WeightRandomData.PracticalWeight` RVA 0x6632120：最终抽取权重直接使用 `base × (1 + delta)`。

所以当前可严格证明的链路应写成：

`学习/移除技能 → 类型计数变化 → GetDeltaWeightPercent 得到精确 delta → AdjustWeightsForSkillGroup(skillType, delta) 被调用`

以及随机器侧独立证明：

`deltaWeightPercent → PracticalWeight → 实际有效权重变化`

两段之间的 HotFix 真实方法体仍未静态还原，不能伪造一条不存在于 ARM64 文件里的直接调用。

## 候选池不是一个扁平池

- `GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill` 都先 Clear 目标 `WeightRandom`，逐条读取 `Skill_Main` 与当前 `WeightRandomData.Weight`，再把符合条件的条目 Add 到新随机池。
- `RandomOneSubSkillByParent` 会检查父技能升级链、分支组、`GameUtils.CheckCanStudySkill` 与 ban list，然后调用 `GetRandomCount`；该路径一次最多抽 1 个子技能。

因此更接近真实实现的模型是：先按语义和合法性构造多个子池，再在保留动态权重的子池内抽取，最后汇总成三选一。

## Boost / Revert 的证据边界

`WeightRandom` 存在 `BoostWeightByPercent` / `RevertWeightBoost`，但当前保存的 `HeroComponentRandomSkill.asm` 中没有找到两者 RVA 的直接调用。它们证明通用随机器支持临时 Boost，却不能作为 Build 收敛的直接证据。除非后续定位到真实调用方，否则不应写成“保底”“首选同类”或“三选一临时增权”。
