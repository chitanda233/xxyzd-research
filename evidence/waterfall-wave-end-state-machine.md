# Waterfall 波末升级与硬门槛 native 证据摘记

本文件只保存可复核的 implementation 级证据，策划结论见 `research/battle/wave-analysis.md`。

## 波末升级状态机

关键字段来自 `WaterfallBattleManager.cs`：

- `curWaveUpLevelCount`：0x1C8
- `_needUpLevelCount`：0x1CC
- `_waveEndUpLevelProgressState`：0x1D0
- `isInUplevelAbsorbAll`：0x1D4

关键 native：

- `AddUpLevel` RVA 0x65C8890：`_needUpLevelCount += 1`。
- `DelUpLevel` RVA 0x65C88FC：先尝试 `_needUpLevelCount - 1`；结果非负时写回，并执行 `curWaveUpLevelCount += 1`。
- `QueueSelectSkill` RVA 0x65C8E98：先过 `CanRunUpLevelProgress`；处于波末且状态为 0 时写为 1，然后进入 `ActiveState(3)`。
- `ShouldApplyLevelOnSelectSkillEnter` RVA 0x65C8978：状态 1 时写为 2 并返回 true。
- `MarkWaveEndSelectSkillFinished` RVA 0x65C8A00：仅状态 2 可完成；写为 3，调用 `DelUpLevel`，因此一次完成只消费一个待处理升级。
- `TryContinueWaveEndUpLevelAfterSelection` RVA 0x65C8B28：仅状态 3 可继续；先归零状态，再检查 `CheckNeedOpenSpecialSkill`，需要时进入 state 12，否则继续波末处理。
- `TryResumeWaveEndUpLevelProgress` RVA 0x65C8C14：只在“波末状态 + 当前特殊 UI 是升级 UI + 非 AbsorbAll 中 + CanRunUpLevelProgress”时恢复；若状态为 3，转 `TryContinueWaveEndUpLevelAfterSelection`。
- `OnProgressFinish` RVA 0x65CC838：在升级选择之前显式检查装备掉落、经验掉落、经验吸收动画；有未吸收经验时调用 `DropMgr.AbsorbAll`，之后才进入 `QueueSelectSkill`。

可以把状态值按行为命名为：

`0 Idle → 1 Queued → 2 Selecting → 3 FinishedPendingContinue → 0`

这不是源码枚举名，而是根据 native 行为给出的分析命名。

## 精英/Boss 死亡锁

- `CheckStopByEliteOrBossKilled` RVA 0x65D3784：读取当前 `ChapterWave_Waves` 对象的布尔字段并返回是否等于 1。
- `EnemyDieSpecialLogic` RVA 0x65D4E80：只有上述开关为真时才进入特殊死亡逻辑，并明确比较怪物类型 `0xC9 (=201)` 与 `3`。
- 第一章第 10 波的 310008 为 `Type=201`；第 15 波 340002 为 `Type=3`。第 5 波开关为 0。

因此第 10 / 15 波的死亡锁不是从 UI 表象推断，而是配置开关、实体类型与死亡处理代码三方闭环。


## 每波经验预算的 native 实现

这部分补足“为什么 `WaveAllExp` 能与升级阈值精确一一对应”。

`WaterfallBattleManager` 的相关字段：

- `_expCount`：0x150，本波参与经验分配的计数。
- `_perExp`：0x158，本波按预算计算的单体经验基准。
- `_addExp`：0x160，本波已经发出的累计经验。

`InitNewWaveData` 每波先清零这些状态。完成本波怪物计数后，0x65CBFF0～0x65CC030 一段读取当前波 `WaveAllExp`，并按 `WaveAllExp / _expCount` 计算 `_perExp`，再通过 `FPMath.Max` 保证下限。

`GetCharacterDropExp`（RVA 0x65D5144）随后使用 `_perExp` 和 `_addExp` 动态决定每次死亡的经验发放，而不是直接把 `Character_entity.exp` 当最终值。0x65D5540 之后可以看到它持续用当前 `WaveAllExp` 与 `_addExp` 比较；如果正常发放会越过本波预算，则把最后一笔截成剩余差额，并将 `_addExp` 更新到预算上限。硬门槛波还会读取 `_remainSpecialMonsterCount` / `_remainAllMonsterCount`，让特殊怪死亡与尾部预算闭合配合。

对第一章逐波把静态 `Character_entity.exp × 数量` 求和，得到 346、226、219、296、522、178、520、760、77、811、500、909、101、361、975；它们与对应的 `WaveAllExp` 200、550、600、600、700、800、800、950、1000、1100、1200、1200、1400、1700、2000 明显不一致。这是额外的反证：经验总量确实由波预算重分配，而不是静态怪物经验自然相加。

策划层结论：`WaveAllExp` 是强约束的“每波成长预算”，怪物掉落只是这个预算在战斗中的表现载体。
