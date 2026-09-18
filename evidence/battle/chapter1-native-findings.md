# Battle native evidence notes

本文件保留策划结论背后的最短 native 证据链，避免最终报告堆程序调用，同时方便后续复核。

## 1. 波末升级队列

`WaterfallBattleManager.AddUpLevel`：`_needUpLevelCount += 1`。

`WaterfallBattleManager.DelUpLevel`：pending 可减时，`_needUpLevelCount -= 1`，同时 `curWaveUpLevelCount += 1`。

`WaterfallBattleManager.OnProgressFinish`：波末会先等待掉落经验/经验动画状态；只要 `_needUpLevelCount != 0`，就跳入 `QueueSelectSkill`。只有 pending 清零且其它波末步骤也完成后，才继续推进。

`QueueSelectSkill` 在 WaveShowEnd 状态维护 `WaveEndUpLevelProgressState` 并激活选择状态；`ShouldApplyLevelOnSelectSkillEnter` 将波末状态 1→2。

`MarkWaveEndSelectSkillFinished` 只在状态 2 生效：状态 2→3，并调用 `DelUpLevel`。所以一次三选一只消费一个 pending level。

`TryContinueWaveEndUpLevelAfterSelection` 在状态 3 恢复波末流程；如果仍有 pending，后续 `OnProgressFinish` 会再次进入 `QueueSelectSkill`。

结论：第一章 `WaitUpLevel=1` 时，升级选择被明确队列化到波末。一波如果累计多级，会逐级连续处理选择，直至 pending 清零。

## 2. 特殊怪击杀门槛

`CheckStopByEliteOrBossKilled` 直接读取当前 `ChapterWave_Waves.StopByEliteOrBossKilled`。

`CalRandomMonster` / 特殊怪统计路径读取 `Character_entity.Type`；Type=201（0xC9）或 Type=3 才计入特殊怪。

`EnemyDieSpecialLogic`：仅当本波开启 StopByEliteOrBossKilled 时，Type=201/3 死亡才递减 `_remainSpecialMonsterCount`；计数归零后调用 `BaseSurvivalBattleManager.EnemySpecialDie`，解除特殊刷新阻塞。

第一章：
- W5：stop=0；没有特殊怪击杀锁。
- W10：stop=1；310008 为 Type=201，构成第一道真实精英门槛。
- W15：stop=1；340002 为 Type=3，构成最终 Boss 门槛。

W10 还有一个重要细节：特殊怪死亡放行后会把当前 mission 推到本波尾部并 `ClearMonsterCreateData`。因此表中后续每 3.5 秒排队生成的支援怪是“最大压力包络”；如果 310008 被提前击杀，尚未执行的刷新可能被取消，18 只是配置上限而非每局必出数量。

## 3. 时间推进骨架

`MissionWaterfallMission_WaterfallMission.time` 是绝对战斗时间。第一章 78 条 mission 的波首形成：

`0, 15, 30, 45, 62, 105, 135, 150, 180, 197, 240, 270, 300, 315, 345` 秒。

`RefreshBattleData` 会读取当前任务与下一任务的绝对 time，计算时间差并写入下一任务刷新计时，随后由刷新状态机更新。因此 15/17/30/43 秒等窗口是 runtime 真正消费的时间结构，不是分析者仅凭相邻行推测出来的。

普通波仍会叠加在场怪、掉落吸收、UI 和暂停状态检查，所以“定时波”不等于“到秒数无条件切换”；但它们没有 W10/W15 的特殊怪死亡锁。

## 4. 随机刷怪语义——numberRandom 是目标怪物数

这是容易误读的一处。

`CalRandomMonster` 先从 mission 的 `randomMonster` 配置 ID 列表随机选一个配置，再展开该 `Mission_RandomMonsterFlushConfig.entityId`。函数维护一个累计生成数，并不断选择配置、遍历其中 entity；**达到 `numberRandom` 后立即停止**。如果本次选中的 entityId 数组会使数量超出目标，也会在目标数处截断，而不是必须完整生成整组。

所以 `numberRandom` 是这条随机刷新指令的**目标怪物总数**，不是“随机配置抽取次数”。

例如 `randomMonster=[5,13], numberRandom=2`，配置 5 含两个 330006，配置 13 含三个 330006；无论随机选到哪一个，运行时都只生成到总数 2 为止。第一章相关随机池 2/5/13 最终都只包含 330006，因此随机部分的数量和怪物类型都可精确还原。

由此第一章的修正总量是：
- W8：18 只（不是 20～22）。
- W11：8 只（不是 12～16）。
- W12：21 只（不是 33）。

## 5. 经验与“一波一级”

第一章各波 `WaveAllExp` 与 `Exp_exp.waveExp` 相邻累计阈值差逐项完全相等。

`InitNewWaveData / GetCharacterDropExp` 又表明总经验预算会按怪物经验权重拆到怪物掉落/吸收流程；`CheckGoNextMission` 在推进前会调用 `DropMgr.AbsorbAllExp`。

因此可写成：经验来自怪物与吸收流程，但第一章的**整波经验预算被精确设计成一个等级跨度**，随后由波末 pending-level 状态机统一处理成长选择。

## 6. SkillType 动态增权：公式存在，但 APK fallback 未应用

`HeroComponentRandomSkill.GetDeltaWeightPercent` 可还原为：

`min(GetSkillCountByType(type) × AddWeightPerSkill / 100, AddWeightMax / 100)`

典型配置 50 / 500 即每个同类型已学技能计划 +50%，封顶 +500%。

`WeightRandomData.PracticalWeight` 支持 `baseWeight × (1 + deltaPercent)`，`WeightRandom.UpdateWeightPercent` 也具备写入 delta 的能力。

但是当前 1.0.16 APK fallback 的 `HeroComponentRandomSkill.AdjustWeightsForSkillGroup`（RVA 0x686A17C）为空实现：调用链会算出 delta，却没有在这个 fallback 中真正遍历技能组并写回 WeightRandom。

因此证据结论必须写成：

**“同 SkillType 越学越增权”的公式和设计接口真实存在，但当前 APK 基线是否实际生效不能确认；fallback 本身没有落地应用。线上热修若覆盖该函数，则可能启用。**

不要再把 +50%/次、+500% 封顶直接写成 1.0.16 主线三选一的已生效规则。当前已经坐实的普通主线随机结构，以 `research/battle/skill-random-analysis.md` 为准。
