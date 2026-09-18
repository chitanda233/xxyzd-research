# Battle native evidence notes

本文件记录本轮策划结论背后的最短 native 证据链，避免最终报告堆调用链，同时方便后续同事复核。

## 波末升级队列

`WaterfallBattleManager.AddUpLevel`：`_needUpLevelCount += 1`。

`WaterfallBattleManager.DelUpLevel`：若 pending 可减，则 `_needUpLevelCount -= 1`，同时 `curWaveUpLevelCount += 1`。

`WaterfallBattleManager.QueueSelectSkill`：在允许运行升级流程时激活选择状态；处于 WaveShowEnd 时会维护 `WaveEndUpLevelProgressState`。

`WaterfallBattleManager.MarkWaveEndSelectSkillFinished`：只有波末选择状态处于进行中时才将状态推进，并调用 `DelUpLevel`，因此一次选择只消耗一个 pending level。

`WaterfallBattleManager.TryContinueWaveEndUpLevelAfterSelection`：完成一次选择后恢复波末流程；若需要特殊技能选择则转入对应状态，否则继续通用波末处理。

`WaterfallBattleManager.OnProgressFinish`：在经验动画/掉落吸收流程结束后检查 `_needUpLevelCount`。只要 pending 不为 0，就跳回 `QueueSelectSkill`；pending 清零且没有其它阻塞后才推进波末 UI/下一状态。

结论：在 `WaitUpLevel=1` 的第一章中，升级选择被波末队列化；一波若累计多个等级，会逐个弹选择直至 pending 清零。

## 特殊怪击杀门槛

`WaterfallBattleManager.CheckStopByEliteOrBossKilled` 直接读取当前 `ChapterWave_Waves.StopByEliteOrBossKilled` 并判断是否等于 1。

`WaterfallBattleManager.CalRandomMonster` / 特殊怪统计路径读取 Character_entity.Type；Type=201（0xC9）或 Type=3 会被计入特殊怪数量。

`WaterfallBattleManager.EnemyDieSpecialLogic`：只有当前波启用 StopByEliteOrBossKilled 时，Type=201/3 死亡才会递减 `_remainSpecialMonsterCount`；计数归零后调用 `BaseSurvivalBattleManager.EnemySpecialDie`，重置刷新状态，并将当前 mission 推到本波尾部。

第一章：
- W5 stop=0，没有硬门槛。
- W10 stop=1，310008 Type=201，是特殊怪门槛。
- W15 stop=1，340002 Type=3，是 Boss 门槛。

## 普通波与时间骨架

`MissionWaterfallMission_WaterfallMission.time` 是绝对战斗时间轴；第一章 78 条 mission 的 wave/time 分布形成 0、15、30、45、62、105、135、150、180、197、240、270、300、315、345 秒的波起点。

`BaseSurvivalBattleManager` 通过刷新状态机和 battle time 驱动 mission 刷新；`CheckEnemyAllDie` / `CheckGoNextMission` 同时会检查在场怪、当前任务索引、掉落吸收和 UI 状态。因此不能把普通波简化为“到秒数无条件切波”，但它们没有 W10/W15 那种特殊怪存活锁。

## 随机刷怪语义

`WaterfallBattleManager.CalRandomMonster` 会从 mission 的 `randomMonster` 配置 ID 列表中按 `numberRandom` 次数选取索引，并缓存到 `WaveMissionRandomData`；每次选中的 `Mission_RandomMonsterFlushConfig` 再完整展开其 `entityId` 数组。

因此 `randomMonster=[5,13], numberRandom=2` 的语义是“做两次候选配置选择”，而不是把两个配置都各重复两次。配置 5 含两个 330006，配置 13 含三个 330006，所以该条命令最终生成 4～6 个普通怪。

## 动态技能类型权重

`HeroComponentRandomSkill.GetDeltaWeightPercent`：
`min(GetSkillCountByType(type) × AddWeightPerSkill / 100, AddWeightMax / 100)`。

典型配置 50 / 500 对应每个同类型已学技能 +50%，封顶 +500%。

`HeroComponentRandomSkill.UpdateLearnedSkillCount` 与 `DecreaseLearnedSkillCount` 在更新类型计数后都调用 delta 计算与组权重调整。

`WeightRandom.UpdateWeightPercent` 把 delta percent 写入目标候选的 WeightRandomData。

`WeightRandomData.PracticalWeight`：
`baseWeight × (1 + deltaPercent)`。

`WeightRandom.GetRandom`：
在总有效权重上取随机数并逐项扣减 PracticalWeight，属于标准权重轮盘。

结论：玩家当前已学的某技能类型越多，该类型候选整体越容易出现；典型配置最多达到 6×基础权重，但仍保留非同类技能的抽取可能。
