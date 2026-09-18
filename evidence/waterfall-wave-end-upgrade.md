# Waterfall 波末升级状态机证据

研究对象：客户端 1.0.16 / versionCode 40。这里保存可支撑策划结论的 native 证据摘要，正文见 `research/battle/wave-analysis.md`。

## 状态定义

`HotFixBattle.dll.cs` 中恢复出的枚举：

```text
WaterfallBattleManager.WaveEndUpLevelProgressState
None = 0
PendingEnter = 1
LevelApplied = 2
SkillSelected = 3
```

对应字段：

- `curWaveUpLevelCount`：0x1C8
- `_needUpLevelCount`：0x1CC
- `_waveEndUpLevelProgressState`：0x1D0
- `isInUplevelAbsorbAll`：0x1D4

## 关键 native

来源：`restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm`

- `AddUpLevel` — RVA `0x65C8890`：`_needUpLevelCount += 1`。
- `DelUpLevel` — RVA `0x65C88FC`：每次把 `_needUpLevelCount` 减 1，并把 `curWaveUpLevelCount` 加 1。
- `ShouldApplyLevelOnSelectSkillEnter` — RVA `0x65C8978`：当状态为 `PendingEnter` 时切到 `LevelApplied`，避免同一次选择重复应用等级。
- `MarkWaveEndSelectSkillFinished` — RVA `0x65C8A00`：仅在 `LevelApplied` 时切到 `SkillSelected`，随后调用 `DelUpLevel`，因此一次三选一只消费一个待升级次数。
- `TryContinueWaveEndUpLevelAfterSelection` — RVA `0x65C8B28`：只接受 `SkillSelected` 状态，清回 `None`，检查是否需要插入特殊技能选择，否则继续波末流程。
- `TryResumeWaveEndUpLevelProgress` — RVA `0x65C8C14`：只在波末 UI 状态、当前为升级 UI、没有处在强制吸收流程且允许升级推进时恢复；状态为 `SkillSelected` 时继续上一条流程。
- `QueueSelectSkill` — RVA `0x65C8E98`：在波末状态下把 `None → PendingEnter`，随后激活状态 ID 3（三选一状态）；状态为 `SkillSelected` 时不会重复排队。
- `OnProgressFinish` — RVA `0x65CC838`：波末流程先检查装备掉落、经验掉落和经验动画。场上仍有经验时会调用 `DropMgr.AbsorbAll` 并设置 `isInUplevelAbsorbAll`；经验流程稳定后，如果 `_needUpLevelCount != 0`，转入 `QueueSelectSkill`。
- `WaveModelLevelUp` — RVA `0x65D64F8`：只有处于 `WaveShowEnd` 状态才执行波末等级推进。

## 可以写进策划报告的结论

经验本身由怪物掉落/吸收产生，但 `WaitUpLevel=1` 的主线模式把三选一选择编排到波末流程里。达到升级线时先累计“待处理升级次数”；波末先处理剩余经验与经验动画，再按待升级次数串行打开技能选择。每完成一次选择只消费一个 pending level，如果一波因为额外经验跨了多个等级，就会连续处理多次选择，而不是合并成一次。

第一章的标准经验预算又恰好满足“每波 WaveAllExp = 下一等级阈值差”，因此正常路径表现为非常整齐的“一波一次成长”。

## 尚未捕获的调用点

当前筛选出的 `WaterfallBattleManager.asm` 内没有保存到 `AddUpLevel` 的直接调用者。它很可能来自经验动画/角色升级相关状态或其他未筛选函数。现有证据已经证明 pending-level 的消费与波末串行处理，但如果需要做到函数调用链完全闭合，下一步应把 `ExpAnimProcessor`、选择技能状态和升级事件监听相关 native 一并筛出。

## 补充：随机刷怪的 numberRandom 是“实体目标数”

此前最容易误算的是第 8 / 11 / 12 波的随机怪。不能把 `numberRandom` 理解成“把随机配置完整执行 N 次”。

`CalRandomMonster` 会先保存本条 mission 的随机选择结果，`CreateRandomMonster` 再按保存结果逐个取 `Mission_RandomMonsterFlushConfig.entityId` 创建实体。创建循环里有一个已生成实体计数，生成每个实体后 +1，并直接和 mission 的目标数比较；达到目标数就退出当前随机生成流程。对应 native 关键段在 `CreateRandomMonster` RVA 0x65CFF58 内：

```text
... create one entity ...
emittedCount += 1
if emittedCount < numberRandom:
    continue
else:
    stop
```

因此 `numberRandom=2` 的语义是“这一条随机刷新最终补 2 个实体”，而不是“随机组选 2 次并完整生成每组所有 entityId”。即使抽到的随机配置内部含 3 个相同 entityId，也会在第 2 个实体处截断。

第一章所引用的随机配置 2 / 5 / 13 最终都只包含 `330006`，所以虽然具体选中了哪个随机配置可能不同，**实际怪物种类与数量仍可精确还原**：

- 第 8 波：随机部分共 6 个 `330006`，整波 18 只；
- 第 10 波：随机部分共 8 个 `330006`，配置上限 18 只；
- 第 11 波：随机部分共 4 个 `330006`，整波 8 只；
- 第 12 波：随机部分共 12 个 `330006`，整波 21 只。

这条解释已经同步进 `research/battle/chapter1-wave-summary.json` 与压缩脚本。
