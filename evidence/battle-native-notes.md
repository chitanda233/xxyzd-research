# Battle native evidence notes

本文件只记录支撑策划结论的关键 native 证据，避免最终报告堆汇编。

## 波末升级状态机

### AddUpLevel

`WaterfallBattleManager.AddUpLevel`：

- 读取字段 `0x1cc`
- `+1`
- 写回 `0x1cc`

可确认该字段就是“待处理升级次数”一类计数。

### DelUpLevel

`WaterfallBattleManager.DelUpLevel`：

- `0x1cc - 1`
- 若结果不小于 0，则写回 `0x1cc`
- 同时将 `0x1c8 + 1`

因此一次升级选择完成后，会消耗一个待升级计数，并累计本波已处理升级次数。

### SelectSkill 状态

`ShouldApplyLevelOnSelectSkillEnter`：
- state=1 时改成 2，并返回 true。

`MarkWaveEndSelectSkillFinished`：
- 仅在 state=2 时生效；
- state 2→3；
- 调用 `DelUpLevel`。

`QueueSelectSkill`：
- 先检查 `CanRunUpLevelProgress`；
- 若处于 WaveEnd 且 state=0，则 state 0→1；
- 激活选择状态。

`TryResumeWaveEndUpLevelProgress`：
- 只在 WaveEnd；
- 当前确实是升级 UI；
- 没有经验吸收阻塞；
- `CanRunUpLevelProgress=true`；
- state=3 时进入 `TryContinueWaveEndUpLevelAfterSelection`。

`TryContinueWaveEndUpLevelAfterSelection`：
- state=3 才执行；
- state 清 0；
- 检查是否需要开启特殊技能；
- 否则恢复原波末进度函数。

### OnProgressFinish

可确认顺序包含：

- `DropMgr.HaveDropExp`
- `ExpAnimProcessor.IsAdding`
- `DropMgr.AbsorbAll`
- `ExpAnimProcessor.IsIdle`
- `ExpAnimProcessor.CanLevelUp`
- `QueueSelectSkill`

策划结论：经验在波内产生，但三选一被串行化到波末流程；跨多个等级时按待升级计数逐次消费。

## 三选一动态类型权重

`InitRandomSkill`：
- `HeroSkillCreator.InitRandomSkill`
- `GroupSkillsByType`
- `RecalculateAllWeight`

`UpdateLearnedSkillCount`：
- 类型已存在则 count+1；
- 不存在则置 1。

`DecreaseLearnedSkillCount`：
- 类型已存在则 count-1；
- 不存在则置 0。

`GetSkillCountByType`：
- 直接读取上述类型计数字典。

`GetDeltaWeightPercent`：
- 调用 `GetSkill_SkillTypeWeight`；
- 调用 `GetSkillCountByType`；
- 计算同类数量 × 每技能加权；
- 与最大加权值取较小值。

当前主流配置：
- `AddWeightPerSkill = 50`
- `AddWeightMax = 500`

因此在配置单位上：
`delta = min(typeCount × 50, 500)`。

`WeightRandom.UpdateWeightPercent`：
- 遍历候选；
- 判断目标 ID；
- 更新命中项的 weight percent。

策划结论：当前 Build 的技能类型构成会反馈到后续随机权重，形成软 Build 收敛。


## 随机怪生成数量

`WaterfallBattleManager.CreateRandomMonster`（RVA 0x65CFF58）：

- 读取当前 mission 的随机生成数量；
- 受 `MaxCreateMonsterCount = 600` 上限保护；
- 循环中每次生成/写入一条 `MonsterCreateData`；
- 循环索引逐次 +1，直到达到随机生成数量；
- 结束时 `CreateMonsterCount += randomCount`。

结论：该路径上 **1 次 random draw = 1 个实际生成实体**。第一章用到的随机池候选全部归于 330006，因此可以把 `numberRandom` 直接换算成额外杂兵数量。
