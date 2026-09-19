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
