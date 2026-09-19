# 第一章 Punchboard 节点：独立于波末升级的 Build 介入

> 结论范围：客户端 1.0.16 / versionCode 40 的静态配置、IL2CPP 类型结构与已导出的 native fallback。本文只证明 APK 中能直接追到的机制，不把线上 HotFix 当成已知事实。

## 结论

第一章除“经验达到阈值 → 波末三选一”之外，还插入了另一类独立的技能成长事件：**Punchboard（代码命名）**。

第一章的非零 `missinType` 任务只有四条：

| 波次 | 时间 | mission id | missinType | 实际含义 | 备注 |
|---|---:|---:|---:|---|---|
| W6 | 105s | 1001021 | 9 | Punchboard | 纯事件行，无刷怪 |
| W11 | 240s | 1001048 | 9 | Punchboard | 纯事件行，无刷怪 |
| W15 | 345s | 1001077 | 9 | Punchboard | 纯事件行，无刷怪 |
| W15 | 347s | 1001078 | 2 | Boss | 生成 340002，HP 系数 1.5 |

这里的 `missinType` 不能与网络协议中的 `Proto.Battle.MissionType` 混淆。真正用于局内瀑布流任务的是 `HotFix.BattleLogic.BattleConfig`：其中 `MissionTypeBoss=2`、`MissionTypePunchboard=9`。因此 W6、W11、W15 的 9 都可以直接定性为 Punchboard，而 W15 在 2 秒后进入 Boss 任务。

这会明显修正第一章节奏的策划描述：

> **W5 是第一次战斗高潮；W6 开头紧接一次 Punchboard Build 介入。W10 是精英硬验收；W11 开头再给一次 Punchboard Build 介入。W15 则先在 345s 给第三次 Punchboard，再于 347s 进入最终 Boss。**

也就是说，游戏不是只靠逐波升级让 Build 平滑增长，而是在三个大段落的边界主动插入额外的 Build 调整节点。

## Punchboard 不是普通波末三选一的别名

IL2CPP 结构里它有完整独立状态：

- `BattleDef.StatePunchboard = 11`
- `BattleDef.MissionEventPunchboard = 8`
- `BattleDef.CloseUIPunchboard = 7`
- `BattleState.BattleEventId.PlayerPunchboardFinish = 11`
- `EnterPunchboardParam` 单独保存 `CreateMissionId`
- `BasePunchboardState : SingleState`
- `WaterfallStatePunchboard : BasePunchboardState`

普通升级选择则走 `WaterfallStateSelectSkill` / `QueueSelectSkill` / 波末升级状态机。二者是不同状态、不同事件和不同 UI 生命周期，因此最终报告中应明确区分：

**普通成长：** 打怪经验 → 波末升级 → 普通三选一。

**Punchboard：** 关卡脚本主动插入的独立技能事件 → 使用 Punchboard 专属随机逻辑 → 完成后回到关卡流程。

## Punchboard 自己维护一套技能候选重构

`PlayerPunchboard` 不是简单“随机给几张卡”的壳，它单独维护：

- `_haveSkills`：已有技能；
- `_newSkills`：新技能；
- `_replenishSkills`：补位技能；
- `_randomResult`；
- `_randomPunchboardResult`；
- `_realSelectResult`。

其方法包含 `FillRandomSkillList`、`GetSkillGroup2Skills`、`GetResultSkillList`、`MakeResultSkillListContinuous`、`EnsureNeedSkillsDependency`、`BuildUpgradeDepsMap` 等。这说明 Punchboard 会考虑已有 Build、升级依赖和补位，不是与普通三选一完全相同的一次裸随机。

`HeroSkillCreator` 还专门维护 `WeightRandom[] PunchboardRandoms`，进一步证明它拥有独立随机池。

## Punchboard 出几个技能，本身也是一次加权随机

`HeroComponentRandomSkill.GetPunchboardRandomCount`（RVA `0x686F88C`）的 native fallback 已能看到完整的“数量随机”骨架：

1. 读取全局 `PunchboardRandomSkillCountWeight`；
2. 复制出工作权重数组；
3. 读取角色某个 FP 属性，满足条件时修正数组末档权重；
4. 扫描当前已学技能，并统计符合条件的不同父技能；
5. 根据当前技能数量和 `PunchboardFiveSkillBlockThreshold` 对某一数量档做屏蔽；
6. 对剩余数量档权重求和；
7. 用战斗随机数做一次 roulette；
8. 返回 `index + 1`，即本次 Punchboard 的随机技能数量。

因此 Punchboard 的“给几个技能”并非固定值，而是受**全局数量权重 + 角色属性 + 当前 Build 状态**共同影响。

当前解码配置已经拿到：

- `PunchboardFiveSkillBlockThreshold = 4`，备注为“赌博机几个技能后解锁5个奖励概率”；
- `PunchboardMissAddWeight = 35`，备注为“赌博机丢失一个增加多少概率”；
- `PunchboardRandomTime = 0`；
- `PunchboardMoveSpeedScale = 0.8`。

当前 `Consts_Const.json` 没有 `PunchboardRandomSkillCountWeight` 这一行，虽然 IL2CPP 的 `LocalModels.Const` 已存在该静态字段和 `GetPunchboardRandomSkillCountWeight()`。因此**数量随机算法已证明，但每一档的基础概率数值还不能从当前解码表直接写死**。这很可能需要继续从 Const 初始化 native / 热更数据来源补证。

## 与第一章波次的关系

三个 Punchboard 节点恰好位于三段大节奏的切换位置：

- **105s / W6 开头：** W5 第一次软高潮之后，让玩家调整 Build，再进入 6～9 波的机制复杂化阶段。
- **240s / W11 开头：** W10 精英硬验收结束后，再给一次 Build 调整，再进入 11～14 波终盘压力段。
- **345s / W15 开头：** 最终 Boss 前再给一次 Build 调整，2 秒后直接进 Boss。

这比“每波一级、一路线性三选一”更完整。第一章实际上同时使用两条成长节奏：

**高频成长脉冲：** 基本每波一个经验等级跨度，W1～W14 明确由波末流程处理普通三选一。

**阶段性 Build 校准：** W6 / W11 / W15 开头的 Punchboard，在大阶段切换前额外干预技能构成。

从策划角度，它形成了很清楚的“成长—验收—再校准”结构：

> 前 5 波成长与软高潮 → Punchboard → 中段成长 → W10 精英验收 → Punchboard → 终盘成长 → Punchboard → Boss 总验收。

## 仍需补证

当前有三处应继续保留边界：

1. `PunchboardRandomSkillCountWeight` 的实际数组值尚未从当前解码配置中找到；native 只证明它被读取和用于 roulette。
2. `GetPunchboardRandomCount` 中用于修正末档权重的角色属性，当前反汇编没有恢复字符串名，暂不能给它贴具体属性名称。
3. “达到多少已学主技能后屏蔽/开放哪一个数量档”的分支结构已经看见，但在拿到完整数量权重数组前，不应把它简化成某个确定概率结论。

这些未决点不影响最重要的结论：**第一章 W6、W11、W15 的 `missinType=9` 是三次独立 Punchboard Build 节点，且 W15 是 Punchboard → 2 秒后 Boss。**
