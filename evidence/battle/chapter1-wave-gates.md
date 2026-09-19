# 第一章关键波门槛：W5 / W10 / W15 native 证据

研究对象：客户端 1.0.16 / versionCode 40。本文件只保存“第 5 / 10 / 15 波到底是不是同一种硬节点”这一问题的静态证据，策划结论见 `research/battle/wave-analysis.md`。

## 结论

第 5、10、15 波不是三个同性质节点。

| 波次 | 特殊 UI | StopByEliteOrBossKilled | 关键实体 | 实体 Type | native 性质 |
|---|---|---:|---|---:|---|
| W5 | startUI = [1,5] | 0 | 320005 等 | 2 | 软高潮/特殊展示，不构成特殊怪击杀锁 |
| W10 | startUI = [1,5] | 1 | 310008 | 201 | 第一处真正精英击杀硬门 |
| W15 | startUI = [1,2] | 1 | 340002 | 3 | 最终 Boss 击杀硬门 |

因此第一章更准确的结构是：

`1–4 铺垫 → W5 第一次明显高潮 → 6–9 抬压 → W10 精英硬验收 → 11–14 终盘抬压 → W15 Boss 总验收`。

## 1. 停止条件不是根据“第 5/10/15 波编号”硬编码

来源：`restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm`

`WaterfallBattleManager.CheckStopByEliteOrBossKilled` — RVA `0x65D3784`

fallback 路径读取当前 `ChapterWave_Waves` 对象，并取字段偏移 `0x24`，随后只做：

```text
return currentWave.StopByEliteOrBossKilled == 1
```

这直接证明客户端不是把 5/10/15 波统一视为特殊关卡，而是逐波读取配置开关。第一章只有 W10、W15 为 1，W5 为 0。

## 2. 真正的硬门只认 Type=201 和 Type=3

`WaterfallBattleManager.EnemyDieSpecialLogic` — RVA `0x65D4E80`

其关键流程为：

```text
if !CheckStopByEliteOrBossKilled():
    return normal path

type = deadMonster.CharacterData.Type

if type == 201 or type == 3:
    _remainSpecialMonsterCount -= 1

    if _remainSpecialMonsterCount <= 0:
        BaseSurvivalBattleManager.EnemySpecialDie()
        BattleWorldContext.SetCurMissionId(_curWaveLastMissionId)
        BaseSurvivalBattleManager.ClearMonsterCreateData()
```

因此“硬门”的实际语义不是“必须清掉这一波所有怪”，而是：当本波开启特殊怪停止条件时，Type=201 / Type=3 的特殊怪计数必须清零。最后一个特殊怪死亡后，客户端主动把当前任务推到本波末任务并清理尚未执行的刷怪创建数据。

这也解释了为什么 W10 的后续支援怪不是必定全部出现。

## 3. W5 没有代码分类上的精英或 Boss

第一章关键实体在 `Character_entity` 中：

| Entity | Type | HP | exp | DropType | 说明 |
|---|---:|---:|---:|---:|---|
| 320005 | 2 | 2350 | 130 | 2 | W5 的高血量普通怪，但仍是 Type=2 |
| 310008 | 201 | 7000 | 130 | 3 | W10 特殊/精英实体 |
| 340002 | 3 | 40000 | 975 | 4 | W15 Boss |
| 330006 | 2 | 150 | 12 | 1 | 基础杂兵 |

W5 的组合里没有 Type=201 或 Type=3。即便 320005 相比杂兵明显更硬，也不能因为血量高或 UI 特殊就把它写成“精英怪”。从客户端真正参与门槛判断的 Type 分类看，W5 是特殊展示/压力高潮，而非精英硬门。

## 4. W10 的怪量必须写成“配置上限”

W10 从 197 秒开始：

- 197s：310008×1 + 320021×1；
- 200.5s 起，每约 3.5 秒追加一组 320017 / 320019 + 330006；
- 最后一组配置到 225s；
- 下一波名义起点为 240s。

把所有排队刷新都算进去，配置最大组合为：

`310008×1 + 320021×1 + 320017×4 + 320019×4 + 330006×8 = 18`

但由于 310008 是 Type=201，且本波 `StopByEliteOrBossKilled=1`，它死亡后若特殊怪计数归零，`EnemyDieSpecialLogic` 会进入 `EnemySpecialDie → SetCurMissionId(last) → ClearMonsterCreateData`。所以玩家击杀精英越快，越可能截断后续尚未刷出的支援怪。

策划上应把这一波理解为：

> 围绕精英逐步加压的一条“最大压力包络”，而不是固定要求玩家完整击杀 18 只怪后才能过波。

## 5. W15 是最终 Boss 门

W15 的静态节奏：

- 345s：missionType=9 / 波前节点；
- 347s：生成 340002，同时存在 missionType=2 事件；
- 340002 的 `Type=3`；
- `StopByEliteOrBossKilled=1`；
- 本波没有普通的 `WaveEndSpecialUIType=[4]`。

因此 345→347 秒更像最终 Boss 的预告/入场缓冲，347 秒开始真正 Boss 战；Boss 死亡触发特殊怪门槛完成，之后转最终结束流程，而不是像 W1–W14 那样再进入一轮标准“波末成长→下一波”。

## 证据边界

以上能静态坐实的是：W5 非特殊怪击杀门、W10/W15 是特殊怪击杀门、门槛识别 Type=201/3、W10 精英早死可以清掉未执行刷新。

仍需要运行时录像验证的只是表现层：W5 62–105 秒长尾具体用于清场、移动还是演出；W10 精英被秒杀时实际能看到多少后续支援怪；W15 Boss 死亡后的结算演出时长。它们不会改变上述门槛机制本身。
