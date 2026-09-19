# 三选一动态随机机制分析

> 目标：确认三选一是否会根据玩家已经学习的技能类型动态改变后续抽取权重，而不是把配置字段直接当结论。

## 结论先行

目前已经可以把“Build 越选越容易成型”从假设提升为**有 native 代码支撑的机制结论**。核心不是简单的“某个技能被抽到后自身加权”，而是系统会先按技能类型分组，维护玩家已经学习的各类型数量，再根据该类型的学习数量计算一个动态权重增量，并把这个增量应用到对应技能组中的候选项。技能增加和技能移除都会更新类型计数，因此这是一套随当前 Build 状态变化的反馈型权重系统。

配置 `Skill_SkillTypeWeight` 中大量条目的 `AddWeightPerSkill = 50`、`AddWeightMax = 500` 与 native 的 `GetDeltaWeightPercent` 对得上：函数先取得指定技能类型的配置，再调用 `GetSkillCountByType` 读取当前已学习数量，计算“每个已学习技能带来的增量”，最后与最大增量做上限比较。也就是说，概念公式可以写成：

`该类型动态加权 ≈ min(已学习该类型数量 × AddWeightPerSkill, AddWeightMax)`

这里的“50/500”在运行时还存在定点/百分比换算，因此最终写给策划时应解释成“每学一个同类技能提升一档权重，最多叠到上限”，而不是武断地写成“概率直接 +50%”。

## native 链路

初始化时，`InitRandomSkill` 会先初始化随机技能数据，然后调用 `GroupSkillsByType`，最后调用 `RecalculateAllWeight`。这说明“技能类型分组”不是日志或编辑器辅助，而是正式参与随机权重计算的数据结构。

当玩家学习技能时，`UpdateLearnedSkillCount` 维护一个按技能类型索引的计数字典：若类型已存在则 +1，否则从 1 开始。移除技能时，`DecreaseLearnedSkillCount` 做相反操作。另一个 `GetSkillCountByType` 直接从这张字典返回当前类型学习数量。

`GetDeltaWeightPercent` 随后读取 `Skill_SkillTypeWeight`，取得该技能类型对应的每技能增量与最大增量，并乘以当前类型学习数量，然后做封顶。也就是说，动态权重的输入明确包含“当前已经学了多少个该类型技能”。

`AdjustWeightsForSkillGroup` 负责把得到的动态权重变化作用到对应技能组；底层 `WeightRandom.UpdateWeightPercent` 会遍历候选项，找到目标 ID 后写入/更新该项的权重百分比。最终随机并不是重新建一个完全独立的池，而是在原有候选权重之上叠加 Build 状态修正。

## 策划意义

这套机制实质上是一种“软定向 Build”。玩家第一次拿到某一类型技能时，并不会锁死路线；但随着同类技能数量增加，该类型后续候选会逐渐获得更高权重，于是 Build 越往后越容易收敛。它解决了纯随机 Roguelike 三选一最常见的问题：前几次选择刚形成方向，后续却因为完全均匀随机长期拿不到协同项。

它也不是无限滚雪球，因为配置里存在 `AddWeightMax`。因此设计意图更像“帮助成型，而不是保证成型”。前期仍保留探索性，中期开始出现方向感，后期通过上限控制避免某一类型完全垄断候选池。

## 当前可以确认的规则

1. 技能会按类型被分组。
2. 系统维护“每种技能类型已学习数量”。
3. 学习同类技能会增加该类型计数，移除会减少。
4. 动态增量读取 `Skill_SkillTypeWeight`。
5. 增量随同类已学习数量增长，并受最大值封顶。
6. 算出的增量会用于调整对应技能组的随机权重。
7. 初始化和 Build 状态变化后会重新计算/刷新权重，因此不是一次性静态加权。

## 仍需继续深挖

目前还没有把三选一候选生成的所有优先级完整排出来。下一步重点应继续还原 `GetNormalSkill`、`FillNormalSkill`、`GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill`、`RandomOneSubSkillByParent` 的先后关系，确认“已学技能升级”“未学一星技能”“父子技能/合成前置”在三张卡中的槽位规则，以及是否存在保底、去重和替补逻辑。

另外，`BoostWeightByPercent` / `RevertWeightBoost` 很可能对应临时加权场景（例如某次刷新、某个事件或指定池），需要继续追调用方，避免和长期 Build 加权混在一起。

## 配置摘录

- id=1, AddWeightPerSkill=50, AddWeightMax=500
- id=100, AddWeightPerSkill=50, AddWeightMax=500
- id=101, AddWeightPerSkill=50, AddWeightMax=500
- id=102, AddWeightPerSkill=50, AddWeightMax=500
- id=103, AddWeightPerSkill=50, AddWeightMax=500
- id=104, AddWeightPerSkill=50, AddWeightMax=500
- id=105, AddWeightPerSkill=50, AddWeightMax=500
- id=106, AddWeightPerSkill=50, AddWeightMax=500
- id=107, AddWeightPerSkill=50, AddWeightMax=500
- id=108, AddWeightPerSkill=50, AddWeightMax=500
- id=109, AddWeightPerSkill=50, AddWeightMax=500
- id=110, AddWeightPerSkill=50, AddWeightMax=500
- id=111, AddWeightPerSkill=50, AddWeightMax=500
- id=112, AddWeightPerSkill=50, AddWeightMax=500
- id=113, AddWeightPerSkill=50, AddWeightMax=500
- id=114, AddWeightPerSkill=50, AddWeightMax=500
- id=115, AddWeightPerSkill=50, AddWeightMax=500
- id=116, AddWeightPerSkill=50, AddWeightMax=500
- id=117, AddWeightPerSkill=50, AddWeightMax=500
- id=118, AddWeightPerSkill=50, AddWeightMax=500
- id=119, AddWeightPerSkill=50, AddWeightMax=500
- id=120, AddWeightPerSkill=50, AddWeightMax=500
- id=0, AddWeightPerSkill=0, AddWeightMax=0
- id=0, AddWeightPerSkill=0, AddWeightMax=0

## 原始证据

- `restored/configs/tables/Skill_SkillTypeWeight.json`
- `restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm`
